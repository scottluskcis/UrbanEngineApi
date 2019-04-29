using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

using UrbanEngineApi.Integration.Tests.Extensions;
using UrbanEngineApi.Integration.Tests.Model;
using HttpClientHelper = UrbanEngineApi.Integration.Tests.Helpers.HttpClientHelper;
using System;
using System.Diagnostics;

namespace UrbanEngineApi.Integration.Tests
{
    [TestClass]
    public class AuthenticationTests
    {
        private IConfiguration _configuration;
        private readonly HttpClientHelper _helper;

        public AuthenticationTests()
        {
            _helper = new HttpClientHelper();
        }

        [TestInitialize]
        public void Init()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
        }

        #region Tests

        /// <summary>
        /// Verifies that the API returns a 401 Unauthorized if no access token is provided in the request
        /// </summary>
        [TestMethod]
        public async Task UnAuthorizedAccess()
        {
            // Arrange
            var client = _helper.Client;

            // Act
            var response = await client.GetAsync( "/about" );

            // Assert
            Assert.AreEqual( HttpStatusCode.Unauthorized, response.StatusCode );
        }

        /// <summary>
        /// Verifies that the API returns a 401 Unauthorized if no access token is provided in the request
        /// </summary>
        [TestMethod]
        public async Task TestGetToken()
        {
            // Arrange
            var client = new HttpClient();
            var json = new Auth0RequestModel()
            {
                audience = _configuration["Auth0:Audience"],
                authority = _configuration["Auth0:Authority"],
                client_id = _configuration["Auth0:ClientId"],
                client_secret = _configuration["Auth0:ClientSecret"],
                grant_type = "client_credentials"
            };

            var payload = json.ToJson();
            var content = new StringContent( payload, Encoding.UTF8, "application/json" );
            var url = $"{json.authority}/oauth/token";
            
            // Act
            var response = await client.PostAsync( url, content );
            var deserializedResponse = await response.Content.ReadAsAsync<Auth0ResponseModel>();

            // Assert
            Assert.IsNotNull( deserializedResponse.access_token );
            Assert.AreEqual( "Bearer", deserializedResponse.token_type );
        }

        /// <summary>
        /// Verifies that the API returns a 401 Unauthorized if no access token is provided in the request
        /// </summary>
        [TestMethod]
        public async Task AuthorizedAccess()
        {
            // Arrange
            var client = _helper.Client;
            var token = await GetToken();

            // Act
            client.DefaultRequestHeaders.TryAddWithoutValidation( "Authorization", string.Format( "Bearer {0}", token ) );
            var response = await client.GetAsync( "/about" ); // this throws an InvalidOperationException

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        #endregion

        #region Private Methods

        private async Task<string> GetToken()
        {
            var client = new HttpClient();
            string token = string.Empty;
            var json = new Auth0RequestModel()
            {
                audience = _configuration["Auth0:Audience"],
                authority = _configuration["Auth0:Authority"],
                client_id = _configuration["Auth0:ClientId"],
                client_secret = _configuration["Auth0:ClientSecret"],
                grant_type = "client_credentials"
            };

            var payload = json.ToJson();
            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            var url = $"{json.authority}/oauth/token";

            // Act
            var response = await client.PostAsync(url, content);
            

            if ( response.IsSuccessStatusCode )
            {
                var deserializedResponse = await response.Content.ReadAsAsync<Auth0ResponseModel>();
                token = deserializedResponse.access_token;
            }

            return token;
        }

        #endregion
    }
}
