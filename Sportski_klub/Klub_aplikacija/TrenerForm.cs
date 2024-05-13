using Klub_aplikacija.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klub_aplikacija
{
    public partial class TrenerForm : Form
    {
        public TrenerForm()
        {
            InitializeComponent();
        }

        public void login(object sender, EventArgs e)
        {
            string username = inputUsername.Text.Trim();
            string lozinka = inputLozinka.Text.Trim();

            
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://localhost:49750/");
                    HttpResponseMessage response = client.GetAsync("api/Trener/GetByUsernameAndLozinka/?Username=" + username + "&Lozinka=" + lozinka).Result;
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    TrenerViewModel user = JsonConvert.DeserializeObject<TrenerViewModel>(jsonString);
                    if (user.Username == username)
                    {
                        MessageBox.Show("Dobrodošli");
                        Meni meniForma = new Meni();
                        meniForma.Show();
                        this.Hide();
                    }
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show("Netočni podaci unesite ponovo");
                    TrenerForm newForm = new TrenerForm();
                    newForm.Show();
                    this.Hide();
                }
                
            }
            /*try
            {
                WebClient client = new WebClient();
                var jsonString = client.DownloadString("http://localhost:49750/api/Trener/?Username=" + username + "&Lozinka=" + lozinka + "");
                List<TrenerViewModel> user = JsonConvert.DeserializeObject<List<TrenerViewModel>>(jsonString);
                if (username.Equals(user))
                {
                    MessageBox.Show("Dobrodošli");
                    Meni newForm = new Meni();
                    newForm.Show();
                    this.Hide();
                }
            }
            catch (WebException ex)
            {
                InitializeComponent();
                MessageBox.Show("Netočni podaci unesite ponovo");
                Meni newForm = new Meni();
                newForm.Show();
                this.Hide();


            }*/

        }

        /* private void inputUsername_TextChanged(object sender, EventArgs e)
         {
             using (var client = new HttpClient())
             {
                 client.BaseAddress = new Uri("http://localhost:49750/api/");
                 var response = client.GetAsync("Trener/GetByUsernameAndLozinka/?Username=" + username.ToString()).Result;

                 var jsonString = response.Content.ReadAsStringAsync().Result;
                 TrenerViewModel user = JsonConvert.DeserializeObject<TrenerViewModel>(jsonString);

                 if (user.ToString() == "admin")
                 {
                     login(sender,e);
                 }
             }
         }

         private void inputLozinka_TextChanged(object sender, EventArgs e)
         {
             using (var client = new HttpClient())
             {
                 client.BaseAddress = new Uri("http://localhost:49750/api/");
                 var response = client.GetAsync("Trener/GetByUsernameAndLozinka/?Lozinka=" + lozinka.ToString()).Result;

                 var jsonString = response.Content.ReadAsStringAsync().Result;
                 TrenerViewModel loz = JsonConvert.DeserializeObject<TrenerViewModel>(jsonString);

                 if (loz.ToString() == "admin")
                 {
                     login(sender, e);
                 }
             }
         }*/

    }
}
