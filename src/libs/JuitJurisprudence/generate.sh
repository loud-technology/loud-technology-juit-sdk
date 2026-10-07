#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.34.6"
readonly DEFAULT_BASE_URL="https://api.juit.io/v1/data-products/search"
readonly CONTRACT_PATH="../../../juit-swagger.json"

installed_version=""
if command -v autosdk >/dev/null 2>&1; then
  installed_version="$(autosdk --version | cut -d+ -f1)"
fi

if [[ -z "${installed_version}" ]]; then
  dotnet tool install --global autosdk.cli --version "${AUTOSDK_VERSION}"
elif [[ "${installed_version}" != "${AUTOSDK_VERSION}" ]]; then
  dotnet tool update --global autosdk.cli --version "${AUTOSDK_VERSION}"
fi

cp "${CONTRACT_PATH}" openapi.json
python3 apply-openapi-overrides.py openapi.json

rm -rf Generated

autosdk generate openapi.json \
  --namespace Loud.Technology.Juit.Jurisprudence.Sdk \
  --clientClassName JuitJurisprudenceClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env JUIT_BASE_URL \
  --validation \
  --generate-http-exception-hierarchy \
  --exclude-deprecated-operations \
  --clean-stale-files
