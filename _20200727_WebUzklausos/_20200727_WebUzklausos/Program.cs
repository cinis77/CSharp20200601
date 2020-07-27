using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace _20200727_WebUzklausos
{
    class Filmas
    {
        public string _id { get; set; }
        public string name { get; set; }
        public int runtimeInMinutes { get; set; }
        public int budgetInMillions { get; set; }
        public double boxOfficeRevenueInMillions { get; set; }
        public int academyAwardNominations { get; set; }
        public int academyAwardWins { get; set; }
    }

    class Filmai
    {
        public Filmas[] docs { get; set; }
    }



    class Knyga
    {
        public string _id { get; set; }
        public string name { get; set; }
    }

    class Knygos
    {
        public Knyga[] docs { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GautiFilmus();
            while (true)
            {

            }
        }

        private async static void GautiFilmus()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 2YwiB3xJ9QVBPIK9KaGD");
            var response = await client.GetAsync("https://the-one-api.herokuapp.com/v1/movie");
            var zinute = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(zinute);
            var objektas = JsonConvert.DeserializeObject<Filmai>(zinute);
            foreach (var item in objektas.docs)
            {
                Console.WriteLine("Filmas " + item.name + " laikas: " + item.runtimeInMinutes);
            }
        }


        private async static void GautiUzklausa()
        {
            HttpClient client = new HttpClient();
            // Get - Gauti duomenis
            // Post - prisijungimu arba registracija
            // Put - Tik persiuti duomenis be atsakymo
            var response = await client.GetAsync("https://the-one-api.herokuapp.com/v1/book");
            var zinute = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(zinute);
            var Atsakymas = JsonConvert.DeserializeObject<Knygos>(zinute);

            foreach (var item in Atsakymas.docs)
            {
                Console.WriteLine("Knyga: " + item.name);
            }
        }
    }
}
