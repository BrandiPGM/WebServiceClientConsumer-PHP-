﻿using System;
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

/// <summary>
/// Auteur : Brandon Mérillat
/// Classe : 3INFC
/// Enseignant : P.Sachetti
/// Date : 06/02/17
/// </summary>

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

            //Ajout des villes par défaut et/ou celles précédemment ajoutées.
            AfficherVillesListe();

            //Ajout du nombres de jour dans la liste déroulante
            cbxPrevision.Items.Add(1);
            cbxPrevision.Items.Add(2);
            cbxPrevision.Items.Add(3);
            cbxPrevision.Items.Add(4);
            cbxPrevision.Items.Add(5);


        }
        /// <summary>
        /// Permet de faire la connexion au site "www.prevision-meteo.ch" pour récupérer les informations météorologique.
        /// </summary>
        /// <param name="strVille"></param>
        private void RecupererMeteo(string strVille)
        {
            Meteo MeteoReponse = new Meteo();

            try
            {
                //Connexion au site.
                string endPoint = @"http://www.prevision-meteo.ch/services/json/" + strVille;
                var client = new RestClient(endPoint);
                var json = client.MakeRequest();
                object objResponse = JsonConvert.DeserializeObject(json, typeof(Meteo));

                //Converti dans le type requis
                MeteoReponse = (Meteo)objResponse;

                int iJours = Convert.ToInt16(cbxPrevision.SelectedValue);
                EffacerTout(); 
                //La boucle for permet de savoir combien de jours on affiche.
                for(int i = 0; i <= iJours; i++)
                {
                    //Le switch affiche en fonction de i le nombre de jours. Ecriture des prévision dans les textboxs et affichage des images.
                    switch (i)
                    {
                        case 0: //Le 0 est là car lorsque l'ont lance l'application il se peut que le programme vienne ici. Dans ce cas, comme nous n'avons pas défini de jour, il pourrait générer une erreur sans celà.
                            break;
                        case 1:
                                tbxMeteoJour0.Text = AfficherPrevision_Jour_0(MeteoReponse);
                                img_day_0.Source = AfficherIcone(MeteoReponse.fcst_day_0.icon);
                            break;
                        case 2: tbxMeteoJour1.Text = AfficherPrevision_Jour_1(MeteoReponse);
                                img_day_1.Source = AfficherIcone(MeteoReponse.fcst_day_1.icon);
                            break;
                        case 3:
                                tbxMeteoJour2.Text = AfficherPrevision_Jour_2(MeteoReponse);
                                img_day_2.Source = AfficherIcone(MeteoReponse.fcst_day_2.icon);
                            break;
                        case 4:
                                tbxMeteoJour3.Text = AfficherPrevision_Jour_3(MeteoReponse);
                                img_day_3.Source = AfficherIcone(MeteoReponse.fcst_day_3.icon);
                            break;
                        case 5:
                                tbxMeteoJour4.Text = AfficherPrevision_Jour_4(MeteoReponse);
                                img_day_4.Source = AfficherIcone(MeteoReponse.fcst_day_4.icon);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// On entre dans cette méthode au moment où on change la localité.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxLocalite_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Convert.ToString(cbxLocalite.SelectedValue) != "")
            {
                string Localite = Convert.ToString(cbxLocalite.SelectedValue);
                RecupererMeteo(Localite);
            }
            else
            { }
            
        }

        /// <summary>
        /// On entre dans cette méthode au moment où on change le nombre de jours.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPrevision_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string Localite = Convert.ToString(cbxLocalite.SelectedValue); //Le ".SelectedValue" doit être converti en string pour être utilisé.
            RecupererMeteo(Localite);
        }
        /// <summary>
        /// Permet d'afficher l'image de la météo pour le jour courant.
        /// </summary>
        /// <param name="fullFilePath"></param>
        /// <returns></returns>
        private BitmapImage AfficherIcone(string fullFilePath)
        {
            Image image = new Image();
                     
            
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Absolute);
            bitmap.EndInit();
            return bitmap;
        }
    
        /// <summary>
        /// Affiche les prévisions pour le jours courant.
        /// </summary>
        /// <param name="Meteo_Prevision_0"></param>
        /// <returns></returns>
        private string AfficherPrevision_Jour_0(Meteo Meteo_Prevision_0)
        {
            string strPrevision = "";
            groupBox.Header = Meteo_Prevision_0.fcst_day_0.day_long;
            strPrevision += Meteo_Prevision_0.fcst_day_0.condition + Environment.NewLine;
            strPrevision += "Temp. minimal " + Meteo_Prevision_0.fcst_day_0.tmin + '°' + Environment.NewLine;
            strPrevision += "Temp. maximal " + Meteo_Prevision_0.fcst_day_0.tmax + '°';

            return strPrevision;
        }

        /// <summary>
        /// Affiche les prévisions pour le lendemain
        /// Exemple : Nous somme Lundi, il affichera Mardi
        /// </summary>
        /// <param name="Meteo_Prevision_1"></param>
        /// <returns></returns>
        private string AfficherPrevision_Jour_1(Meteo Meteo_Prevision_1)
        {
            string strPrevision = "";
            groupBox1.Header = Meteo_Prevision_1.fcst_day_1.day_long;
            strPrevision += Meteo_Prevision_1.fcst_day_1.condition + Environment.NewLine;
            strPrevision += "Temp. minimal " + Meteo_Prevision_1.fcst_day_1.tmin + '°' + Environment.NewLine;
            strPrevision += "Temp. maximal " + Meteo_Prevision_1.fcst_day_1.tmax + '°';

            return strPrevision;
        }

        /// <summary>
        /// Affiche les prévisions pour le surlendemain
        /// </summary>
        /// <param name="Meteo_Prevision_2"></param>
        /// <returns></returns>
        private string AfficherPrevision_Jour_2(Meteo Meteo_Prevision_2)
        {
            string strPrevision = "";
            groupBox2.Header = Meteo_Prevision_2.fcst_day_2.day_long;
            strPrevision += Meteo_Prevision_2.fcst_day_2.condition + Environment.NewLine;
            strPrevision += "Temp. minimal " + Meteo_Prevision_2.fcst_day_2.tmin + '°' + Environment.NewLine;
            strPrevision += "Temp. maximal " + Meteo_Prevision_2.fcst_day_2.tmax + '°';

            return strPrevision;
        }

        /// <summary>
        /// Affiches les prévisions pour le sursurlendemain
        /// </summary>
        /// <param name="Meteo_Prevision_3"></param>
        /// <returns></returns>
        private string AfficherPrevision_Jour_3(Meteo Meteo_Prevision_3)
        {
            string strPrevision = "";
            groupBox3.Header = Meteo_Prevision_3.fcst_day_3.day_long;
            strPrevision += Meteo_Prevision_3.fcst_day_3.condition + Environment.NewLine;
            strPrevision += "Temp. minimal " + Meteo_Prevision_3.fcst_day_3.tmin + '°' + Environment.NewLine;
            strPrevision += "Temp. maximal " + Meteo_Prevision_3.fcst_day_3.tmax + '°';

            return strPrevision;
        }

        /// <summary>
        /// Affiche les prévisions pour le quatrième jours après aujourd'hui
        /// </summary>
        /// <param name="Meteo_Prevision_4"></param>
        /// <returns></returns>
        private string AfficherPrevision_Jour_4(Meteo Meteo_Prevision_4)
        {
            string strPrevision = "";
            groupBox4.Header = Meteo_Prevision_4.fcst_day_4.day_long;
            strPrevision += Meteo_Prevision_4.fcst_day_4.condition + Environment.NewLine;
            strPrevision += "Temp. minimal " + Meteo_Prevision_4.fcst_day_4.tmin + '°' + Environment.NewLine;
            strPrevision += "Temp. maximal " + Meteo_Prevision_4.fcst_day_4.tmax + '°';

            return strPrevision;
        }

        /// <summary>
        /// Efface toutes les text box afin de ne plus avoir les textes afficher lorseque
        /// l'ont passe d'un plus grands nombres de jours a un plus petit nombres
        /// Exemple : de 5 jours à 3
        /// Permet également de retirer les images qui serait déjà présente.
        /// </summary>
        private void EffacerTout()
        {
            tbxMeteoJour0.Clear();
            tbxMeteoJour1.Clear();
            tbxMeteoJour2.Clear();
            tbxMeteoJour3.Clear();
            tbxMeteoJour4.Clear();

            img_day_0.Source = new BitmapImage();
            img_day_1.Source = new BitmapImage();
            img_day_2.Source = new BitmapImage();
            img_day_3.Source = new BitmapImage();
            img_day_4.Source = new BitmapImage();
        }

        /// <summary>
        /// C'est ici que l'ont récupère la valeur de la villes que l'ont souhaite ajouter.
        /// On est ensuite renvoyer dans la méthode "LireFichierVille"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            List<string> lstDeVilles = LireFichierVilles();

            lstDeVilles.Add(tbxAjouterVille.Text);

            string[] s = lstDeVilles.ToArray();
            System.IO.File.WriteAllLines("Villes.txt", s);
            tbxAjouterVille.Text = "";
            AfficherVillesListe();
            cbxLocalite.SelectedIndex = 0;
            MessageBox.Show("La ville a correctement été ajoutée", "Valeur ajoutée");

        }

        /// <summary>
        /// Lit dans le fichier "Villes.txt" les villes qui sont par défaut et celles ajoutées.
        /// Elle renvoie une liste de villes.
        /// </summary>
        /// <returns></returns>
        private List<string> LireFichierVilles()
        {
            string[] tblVilles = System.IO.File.ReadAllLines("Villes.txt");
            List<string> ListeVille = tblVilles.ToList<string>();
            return ListeVille;
        }

        /// <summary>
        /// Affiche les villes présente dans le fichier.
        /// Il retire toutes les villes déjà présente dans la liste déroulante.
        /// Puis, réajoute les villes ainsi que la nouvelle présente dans le fichier .txt
        /// </summary>
        private void AfficherVillesListe()
        {
            List<string> lstVilles = LireFichierVilles();
            
            cbxLocalite.Items.Clear();

            //Ajout des Villes dans la lsite déroulante
            foreach (string s in lstVilles)
            {
                cbxLocalite.Items.Add(s);
            }
        }
    }
}