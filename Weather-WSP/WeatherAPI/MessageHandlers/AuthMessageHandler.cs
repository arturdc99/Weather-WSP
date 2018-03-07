using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Text;

namespace WeatherAPI.MessageHandlers
{
    public class AuthMessageHandler : DelegatingHandler
    {
        //TODO: pass the API Key to web.config
        private const string APIKey = "my_user:my_password";

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Authorization == null)
                return request.CreateResponse(System.Net.HttpStatusCode.Forbidden, "No API Key");
            else
            {
                string authToken = request.Headers.Authorization.Parameter;
                string decodedAuthToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));

                if (decodedAuthToken.Equals(APIKey))
                {
                    return (await base.SendAsync(request, cancellationToken));
                }
                else
                {
                    return request.CreateResponse(System.Net.HttpStatusCode.Forbidden, "Invalid API Key");
                }
            }
        }

    }
}