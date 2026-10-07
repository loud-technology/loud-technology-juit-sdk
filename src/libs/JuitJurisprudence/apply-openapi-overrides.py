#!/usr/bin/env python3
"""Apply deterministic generation fixes to Juit's published OpenAPI document."""

from __future__ import annotations

import json
import sys
from pathlib import Path
from typing import Any


EXPECTED_OPERATIONS = {
    ("/jurisprudence", "get"): "getJurisprudences",
    ("/jurisprudence/{juit_id}/artifact", "get"): "downloadJurisprudenceArtifact",
}
TRANSPORT_HEADERS = {
    "#/components/parameters/Accept",
    "#/components/parameters/AcceptLanguage",
    "#/components/parameters/AcceptEncoding",
    "#/components/parameters/ContentType",
    "#/components/parameters/UserAgent",
}


def apply_overrides(spec: dict[str, Any]) -> None:
    if spec.get("openapi") != "3.1.1":
        raise RuntimeError("Juit OpenAPI version changed; review the generation overrides")

    components = spec.get("components")
    if not isinstance(components, dict):
        raise RuntimeError("Juit OpenAPI no longer defines components")

    basic_auth = components.get("securitySchemes", {}).get("basicAuth")
    if basic_auth != {"type": "http", "scheme": "basic"}:
        raise RuntimeError("Juit OpenAPI no longer defines basicAuth as HTTP Basic")

    spec["servers"] = [{"url": "https://api.juit.io/v1/data-products/search"}]
    spec["security"] = [{"basicAuth": []}]

    for (path, method), operation_id in EXPECTED_OPERATIONS.items():
        try:
            operation = spec["paths"][path][method]
        except KeyError as exception:
            raise RuntimeError(f"Juit OpenAPI no longer exposes {method.upper()} {path}") from exception

        if operation.get("operationId") != operation_id:
            raise RuntimeError(f"Unexpected operationId for {method.upper()} {path}")

        operation["security"] = [{"basicAuth": []}]
        operation["parameters"] = [
            parameter
            for parameter in operation.get("parameters", [])
            if parameter.get("$ref") not in TRANSPORT_HEADERS
        ]

    schemas = components.get("schemas", {})
    try:
        error_properties = schemas["Error"]["properties"]
        details_properties = error_properties["details"]["properties"]
    except KeyError as exception:
        raise RuntimeError("Juit Error schema changed; review the generation overrides") from exception

    error_properties["status"]["type"] = "integer"
    details_properties["short_message"]["type"] = "string"
    details_properties["long_message"]["type"] = "string"

    download_response = spec["paths"]["/jurisprudence/{juit_id}/artifact"]["get"]["responses"]["200"]
    for media_type, media in download_response.get("content", {}).items():
        if not isinstance(media, dict):
            raise RuntimeError(f"Unexpected download media definition for {media_type}")
        description = media.get("schema", {}).get("description", "Arquivo binário.")
        media["schema"] = {
            "type": "string",
            "format": "binary",
            "description": description,
        }


def main() -> None:
    if len(sys.argv) != 2:
        raise SystemExit(f"usage: {Path(sys.argv[0]).name} OPENAPI_FILE")

    path = Path(sys.argv[1])
    with path.open(encoding="utf-8") as stream:
        spec = json.load(stream)

    apply_overrides(spec)

    with path.open("w", encoding="utf-8") as stream:
        json.dump(spec, stream, ensure_ascii=False, indent=2)
        stream.write("\n")


if __name__ == "__main__":
    main()
