using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HttpUtils;
using Newtonsoft.Json;

namespace WebServiceClientConsumer
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cboLocalite.Items.Add("Neuchatel");
            cboLocalite.Items.Add("La-chaux-de-fonds");
            cboLocalite.Items.Add("Bern");
            cboLocalite.Items.Add("Lausanne");

            cboPrevision.Items.Add(1);
            cboPrevision.Items.Add(2);
            cboPrevision.Items.Add(3);
            cboPrevision.Items.Add(4);
            cboPrevision.Items.Add(5);
        }

        private void GetCurrencyWeather(string Ville)
        {
            Meteo MeteoReponse = new Meteo();

            try
            {
                string endPoint = @"http://www.prevision-meteo.ch/services/json/" + Ville;
                var client = new RestClient(endPoint);
                var json = client.MakeRequest();
                object objResponse = JsonConvert.DeserializeObject(json, typeof(Meteo));

                //COnverti dans le type requis
                MeteoReponse = (Meteo)objResponse;
            }
            catch
            {

            }
        }

    }
}
