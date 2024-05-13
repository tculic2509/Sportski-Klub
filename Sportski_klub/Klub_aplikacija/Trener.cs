using Klub_aplikacija.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace Klub_aplikacija
{
    public partial class Trener : Form
    {
        Form parentForm;
        public Trener(Form form)
        {
            InitializeComponent();

            this.parentForm = form;
        }
        private void Form2_FormClosing(object sender, EventArgs e)
        {
            this.parentForm.Visible = true;
        }

        private void Trener_Shown(object sender, EventArgs e)
        {
            GetAllData();

        }

        private void GetAllData()
        {
            dataGridView1.AutoGenerateColumns = true;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:49750");
            HttpResponseMessage response = client.GetAsync("api/Trener").Result;

            var jsonString = response.Content.ReadAsStringAsync().Result;
            List<TrenerViewModel> data = JsonConvert.DeserializeObject<List<TrenerViewModel>>(jsonString);
            bindingSource1.DataSource = data;
        }

        private async void Izbrisi_ClickAsync(object sender, EventArgs e)
        {
            var ID = txtID.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49750/api/");
                var deleteTask = client.DeleteAsync("Trener/" + ID.ToString());            

                GetAllData();
            }
        }
    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49750/api/");
                var response = client.GetAsync("Trener/GetByID/?ID=" + ID.ToString()).Result;
        
                var jsonString = response.Content.ReadAsStringAsync().Result;
                TrenerViewModel trener = JsonConvert.DeserializeObject<TrenerViewModel>(jsonString);

                txtID.Text = trener.ID.ToString();
                txtKlubID.Text = trener.KlubID.ToString();
                txtIsAdmin.Checked = trener.IsAdmin;
                txtIme.Text = trener.Ime;
                txtPrezime.Text = trener.Prezime;
                txtOIB.Text = trener.OIB.ToString();
                txtAdresa.Text = trener.Adresa;
                txtUsername.Text = trener.Username;
                txtLozinka.Text = trener.Lozinka;
            }
            
        }

        private async void save_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var input = new TrenerViewModel
                {
                    ID = Convert.ToInt32(txtID.Text),
                    KlubID = Convert.ToInt32(txtKlubID.Text),
                    IsAdmin = txtIsAdmin.Checked,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    OIB = Convert.ToInt32(txtOIB.Text),
                    Adresa = txtAdresa.Text,
                    Username = txtUsername.Text,
                    Lozinka = txtLozinka.Text

                };

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PutAsync("api/Trener", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<TrenerViewModel> data = JsonConvert.DeserializeObject<List<TrenerViewModel>>(jsonString);
                bindingSource1.DataSource = input;
            }catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krivo podatke");
                Trener form = new Trener(this);
                form.Show();
                this.Hide();
            }
            

            GetAllData();
        }

        private async void Dodaj_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var input = new TrenerViewModel
                {
                    KlubID = Convert.ToInt32(txtKlubID.Text),
                    IsAdmin = txtIsAdmin.Checked,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    OIB = Convert.ToInt32(txtOIB.Text),
                    Adresa = txtAdresa.Text,
                    Username = txtUsername.Text,
                    Lozinka = txtLozinka.Text

                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Trener", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<TrenerViewModel> data = JsonConvert.DeserializeObject<List<TrenerViewModel>>(jsonString);
                bindingSource1.DataSource = input;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krivo podatke");
                Trener form = new Trener(this);
                form.Show();
                this.Hide();
            }


        GetAllData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtKlubID.Clear();
            txtIsAdmin.Checked=false;
            txtIme.Clear();
            txtPrezime.Clear();
            txtOIB.Clear();
            txtAdresa.Clear();
            txtUsername.Clear();
            txtLozinka.Clear();

        }

        private void txtNazad_Click(object sender, EventArgs e)
        {
            Meni newForm = new Meni();
            newForm.Show();
            this.Hide();
        }
    }
}