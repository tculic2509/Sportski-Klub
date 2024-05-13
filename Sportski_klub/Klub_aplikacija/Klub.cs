
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using Sportski_klub.ViewModels;

namespace Klub_aplikacija
{
    public partial class Klub : Form
    {
        public Klub()
        {
            InitializeComponent();
        }

        private void Klub_Shown(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void GetAllData()
        {
            dataGridView1.AutoGenerateColumns = true;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:49750");
            HttpResponseMessage response = client.GetAsync("api/Klub").Result;

            var jsonString = response.Content.ReadAsStringAsync().Result;
            List<KlubViewModel> data = JsonConvert.DeserializeObject<List<KlubViewModel>>(jsonString);
            bindingSource1.DataSource = data;
        }

        private async void Izbrisi_ClickAsync(object sender, EventArgs e)
        {
            var ID = txtID.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49750/api/");
                var deleteTask = client.DeleteAsync("Klub/" + ID.ToString());            

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
                var response = client.GetAsync("Klub/GetByID/?ID=" + ID.ToString()).Result;

                var jsonString = response.Content.ReadAsStringAsync().Result;
                KlubViewModel klub = JsonConvert.DeserializeObject<KlubViewModel>(jsonString);
                txtID.Text = klub.ID.ToString();
                txtImeKluba.Text = klub.ImeKluba;
                txtDatumOsnivanja.Text = klub.DatumOsnivanja.ToString();
                txtOIB.Text = klub.OIB.ToString();
                txtClanarina.Text = klub.Clanarina.ToString();
                txtAdresa.Text = klub.Adresa;
            }

        }

        private async void save_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                var input = new KlubViewModel
                {
                    ID = Convert.ToInt32(txtID.Text),
                    ImeKluba = txtImeKluba.Text,
                    DatumOsnivanja = txtDatumOsnivanja.Value,
                    OIB = Convert.ToInt32(txtOIB.Text),
                    Clanarina = Convert.ToInt32(txtClanarina.Text),
                    Adresa = txtAdresa.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PutAsync("api/Klub", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<KlubViewModel> data = JsonConvert.DeserializeObject<List<KlubViewModel>>(jsonString);
                bindingSource1.DataSource = input;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krive podatke");
                Klub form = new Klub();
                form.Show();
                this.Hide();
            }

            GetAllData();
        }

        private async void Dodaj_ClickAsync(object sender, EventArgs e)
        {

            try {
                var input = new KlubViewModel
                {
                    ImeKluba = txtImeKluba.Text,
                    DatumOsnivanja = txtDatumOsnivanja.Value,
                    OIB = Convert.ToInt32(txtOIB.Text),
                    Clanarina = Convert.ToInt32(txtClanarina.Text),
                    Adresa = txtAdresa.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Klub", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<KlubViewModel> data = JsonConvert.DeserializeObject<List<KlubViewModel>>(jsonString);
                bindingSource1.DataSource = input;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krive podatke");
                Klub form = new Klub();
                form.Show();
                this.Hide();
            }

        GetAllData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtImeKluba.Clear();
            txtDatumOsnivanja.Value =DateTime.Now.Date;
            txtOIB.Clear();
            txtClanarina.Clear();
            txtAdresa.Clear();

        }

        private void txtNazad_Click(object sender, EventArgs e)
        {
            Meni newForm = new Meni();
            newForm.Show();
            this.Hide();
        }
    }
}