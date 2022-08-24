using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;

namespace Authorization.IdentityServer
{
    public static class Configuration
    {
        public static IEnumerable<Client> GetClients() =>
        new List<Client>
        {
            new Client
            {
                ClientId ="client_id",
                ClientSecrets = {new Secret("client_secret".ToSha256()) },
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                AllowedScopes =
                {
                    "OrderAPI"
                }
            },

            new Client
            {
                ClientId ="client_id_mvc",
                ClientSecrets = {new Secret("client_secret_mvc".ToSha256()) },
                AllowedGrantTypes = GrantTypes.Code,

                AllowedScopes =
                {
                    "OrderAPI",
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.OpenId,
                },

                RedirectUris = {"https://localhost:2001/signin-oidc"}
            }
        };

        internal static IEnumerable<IdentityResource> GetIdentityResources() =>
        new List<IdentityResource>
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

        public static IEnumerable<ApiResource> GetApiResources() =>
        new List<ApiResource>
        {
            new ApiResource("OrderAPI")
        };
    }
}
