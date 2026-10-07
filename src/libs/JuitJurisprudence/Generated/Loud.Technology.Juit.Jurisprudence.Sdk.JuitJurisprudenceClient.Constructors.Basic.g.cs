
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    public sealed partial class JuitJurisprudenceClient
    {
        /// <inheritdoc cref="JuitJurisprudenceClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointAuthorization}?, bool)"/>

        public JuitJurisprudenceClient(
            string username,
            string password,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Loud.Technology.Juit.Jurisprudence.Sdk.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref username, ref password);

            AuthorizeUsingBasic(username, password);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string username,
            ref string password);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);

    }
}