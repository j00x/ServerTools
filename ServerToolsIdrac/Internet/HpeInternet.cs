﻿using HtmlAgilityPack;
using RestSharp;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace ServerToolsIdrac.Internet
{
    public class HpeInternet
    {
        private readonly IRestClient client;

        public HpeInternet(string serialNumber)
        {
            client = new RestClient(string.Format("https://partsurfer.hpe.com/Search.aspx?searchText={0}", serialNumber));
            client.RemoteCertificateValidationCallback += (sender, certificate, chain, sslPolicyErros) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12;
        }

        public async Task<string> GetProcessorAsync()
        {
            var request = new RestRequest();
            request.AddHeader("Accept", "*/*");
            var response = await client.ExecuteTaskAsync(request);

            if (!response.IsSuccessful)
                throw new Exception(string.Format("Fail to get Processor, Error Code {0}",
                    response.StatusCode));

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(response.Content);
            string processorName = "Not found";

            foreach (var element in document.DocumentNode.SelectNodes("//span"))
            {
                if (element.InnerText.ToLower().Contains("ghz"))
                {
                    processorName = element.InnerText;
                    break;
                }
            }

            //Delay between requests
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
            });

            return processorName;
        }
    }
}
