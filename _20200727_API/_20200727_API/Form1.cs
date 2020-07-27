using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
    

namespace _20200727_API
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> TypeOfJokeToUSe;

        public Form1()
        {
            InitializeComponent();
            TypeOfJoke.Items.Add("All");
            TypeOfJoke.Items.Add("Single");
            TypeOfJoke.Items.Add("TwoPart");
            TypeOfJoke.SelectedIndex = 0;
            TypeOfJokeToUSe = new Dictionary<string, string>()
            {
                {"All", "" },
                {"Single", "?type=single" },
                {"TwoPart", "?type=twopart" }
            };

        }

        private async void jokeBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage mess = new HttpRequestMessage(HttpMethod.Get, 
                "https://sv443.net/jokeapi/v2/joke/Programming"
                + TypeOfJokeToUSe[TypeOfJoke.SelectedItem.ToString()]);

            var response = await client.SendAsync(mess);
            var zinute = await response.Content.ReadAsStringAsync();

            var tekstas = JsonConvert.DeserializeObject<JokeClass>(zinute);

            if (tekstas.type == "twopart")
            {
                JokeText.Text = tekstas.setup + Environment.NewLine + tekstas.delivery;
            }
            else
            {
                JokeText.Text = tekstas.joke;
            }
        }
    }
}
