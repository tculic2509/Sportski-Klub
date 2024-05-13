using Klub_aplikacija.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace Klub_aplikacija
{
    public partial class Clanarina : Form
    {
        public Clanarina()
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
            HttpResponseMessage response = client.GetAsync("api/Clanarina").Result;

            var jsonString = response.Content.ReadAsStringAsync().Result;
            List<ClanarinaViewModel> data = JsonConvert.DeserializeObject<List<ClanarinaViewModel>>(jsonString);
            bindingSource1.DataSource = data;
        }

        private async void Izbrisi_ClickAsync(object sender, EventArgs e)
        {
            var ID = txtID.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49750/api/");
                var deleteTask = client.DeleteAsync("Clanarina/" + ID.ToString());            

                GetAllData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSportasID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49750/api/");
                var response = client.GetAsync("Clanarina/GetByID/?ID=" + ID.ToString()).Result;

                var jsonString = response.Content.ReadAsStringAsync().Result;
                ClanarinaViewModel clanarina = JsonConvert.DeserializeObject<ClanarinaViewModel>(jsonString);

                txtID.Text = clanarina.ID.ToString();
                txtSportasID.Text = clanarina.SportasID.ToString();
                txtKlubID.Text = clanarina.KlubID.ToString();
                txtMjesec.Value = clanarina.Mjesec;
                txtIznos.Text = clanarina.Iznos.ToString();
            }

        }

        private async void save_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var input = new ClanarinaViewModel
                {
                    ID = Convert.ToInt32(txtID.Text),
                    SportasID = Convert.ToInt32(txtSportasID.Text),
                    KlubID = Convert.ToInt32(txtKlubID.Text),
                    Mjesec = txtMjesec.Value,
                    Iznos = Convert.ToDouble(txtIznos.Text),
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PutAsync("api/Clanarina", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<ClanarinaViewModel> data = JsonConvert.DeserializeObject<List<ClanarinaViewModel>>(jsonString);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krive podatke");
                Clanarina form = new Clanarina();
                form.Show();
                this.Hide();
            }

            GetAllData();
        }

        private async void Dodaj_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                var input = new ClanarinaViewModel
                {
                    SportasID = Convert.ToInt32(txtSportasID.Text),
                    KlubID = Convert.ToInt32(txtKlubID.Text),
                    Mjesec = txtMjesec.Value,
                    Iznos = Convert.ToDouble(txtIznos.Text),
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Clanarina", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<ClanarinaViewModel> data = JsonConvert.DeserializeObject<List<ClanarinaViewModel>>(jsonString);
                bindingSource1.DataSource = input;

            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krive podatke");
                Clanarina form = new Clanarina();
                form.Show();
                this.Hide();
            }

        GetAllData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtSportasID.Clear();
            txtKlubID.Clear();
            txtMjesec.Value=DateTime.Now.Date;
            txtIznos.Clear();

        }

        private void txtNazad_Click(object sender, EventArgs e)
        {
            Meni newForm = new Meni();
            newForm.Show();
            this.Hide();
        }

    }
}