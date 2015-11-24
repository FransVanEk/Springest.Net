using Springest.Net.Models.Trainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Springest.Net
{
    public class SpringestApi : Springest.Net.ISpringestApi
    {

        public SpringestApi()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            this.Trainings = new Trainings.Trainings(this);
            this.Categories = new Categories.Categories(this);
        }

        public string ApiKey { get; set; }
        public string Endpoint { get; set; }
        public dataformat DataFormat { get; set; }

        public HttpResponseMessage LastResponse { get; set; }


        public SpringestApi SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
            return this;
        }

        public SpringestApi SetEndPoint(string endpoint)
        {
            Endpoint = endpoint;
            return this;
        }

        public SpringestApi SetFormat(dataformat dataFormat)
        {
            DataFormat = dataFormat;
            return this;
        }

        public string DataFormatString
        {
            get
            {
                return GetDataFormatString();
            }
        }

        private string GetDataFormatString()
        {
            switch (DataFormat)
            {
                case dataformat.xml:
                    return "xml";
                case dataformat.json:
                    return "json";
                default:
                    return "xml";
            }
        }

        public T GetCall<T>(string webApiUrl)
        {
            var client = new WebApiClientHelper();
            client.BaseUrl = Endpoint;
            var result = client.GetWebApiAsync<T>(webApiUrl).Result;
            LastResponse = client.LastResponse;
            return result;
        }

        public Trainings.Trainings Trainings { get; set; }
        public Categories.Categories Categories { get; set; }
    }
}