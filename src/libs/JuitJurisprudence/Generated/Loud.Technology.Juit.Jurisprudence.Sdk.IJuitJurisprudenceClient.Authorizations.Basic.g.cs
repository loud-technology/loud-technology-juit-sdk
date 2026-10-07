
#nullable enable

namespace Loud.Technology.Juit.Jurisprudence.Sdk
{
    public partial interface IJuitJurisprudenceClient
    {
        /// <summary>
        /// Authorize using basic authentication.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>

        public void AuthorizeUsingBasic(
            string username,
            string password);
    }
}