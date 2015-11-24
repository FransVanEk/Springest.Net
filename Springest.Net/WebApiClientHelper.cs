using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net
{
    public class WebApiClientHelper
    {
        public string BaseUrl { get; set; }
        public List<string> AllowedMediaTypes { get; set; }
        public HttpResponseMessage LastResponse { get; set; }
        public WebApiClientHelper()
        {

        }

        public async Task<T> GetWebApiAsync<T>(string webApiCall)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);

                 LastResponse = await client.GetAsync(webApiCall).ConfigureAwait(false);
                 if (LastResponse.IsSuccessStatusCode)
                {
                    return await LastResponse.Content.ReadAsAsync<T>();
                }
                else
                {
                    return default(T);
                }

            }

        }


    }
}
