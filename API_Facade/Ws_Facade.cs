using RestSharp;
using SistemaKPI_API.Models;
using System;

namespace SistemaKPI_Test.API_Facade
{

    public class HttpClient
    {
        public readonly string API_URL = @"http://localhost:56296/api/";

        public RespuestaServidor HttpGet(string url)
        {
            // Crea cliente HTTP.
            var client = new RestClient(API_URL);
            
            // Crea la solicitud al servidor (y el tipo de respuesta).
            var request = new RestRequest(url, Method.GET);
            request.RequestFormat = DataFormat.Json;

            // Ejecuta llamada.
            return client.Execute<RespuestaServidor>(request).Data;
        }

        public RespuestaServidor HttpPost(string url, object payload)
        {
            var cliente = new RestClient(API_URL);

            var request = new RestRequest(url, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(payload);

            return cliente.Execute<RespuestaServidor>(request).Data;

        }
        public RespuestaServidor HttpPut(string url, object payload)
        {
            var cliente = new RestClient(API_URL);

            var request = new RestRequest(url, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(payload);

            return cliente.Execute<RespuestaServidor>(request).Data;
        }
        public RespuestaServidor HttpDelete(string url, Guid id)
        {
            var fullURL = url + "/{id}";
            var client = new RestClient(API_URL);

            var request = new RestRequest(fullURL, Method.DELETE);


            request.AddParameter("id", id.ToString());

            return client.Execute<RespuestaServidor>(request).Data;
        }
    }

}



