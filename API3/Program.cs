using System;
using RestSharp;

namespace API3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        public void GetDataByPostCode()
        {
            RestClient client = new RestClient("api.zippopotam.us/us/90210");
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
        }
    }
}
