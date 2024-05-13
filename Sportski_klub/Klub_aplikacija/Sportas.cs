using Klub_aplikacija.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;

namespace Klub_aplikacija
{
    public partial class Sportas : Form
    {
        Form parentForm2;
        public Sportas(Form form2)
        {

            InitializeComponent();
            this.parentForm2 = form2;

        }
        private void Form2_FormClosing(object sender, EventArgs e)
        {
            this.parentForm2.Visible = true;
        }
        private void Sportas_Shown(object sender, EventArgs e)
        {
            GetAllData();

        }

        private void GetAllData()
        {
            dataGridView1.AutoGenerateColumns = true;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:49750");
            HttpResponseMessage response = client.GetAsync("api/Sportas").Result;

            var jsonString = response.Content.ReadAsStringAsync().Result;
            List<SportasViewModel> data = JsonConvert.DeserializeObject<List<SportasViewModel>>(jsonString);
            bindingSource1.DataSource = data;
        }

        private async void Izbrisi_ClickAsync(object sender, EventArgs e)
        {
            var ID = txtID.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:49750/api/");
                var deleteTask = client.DeleteAsync("Sportas/" + ID.ToString());            

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
                var response = client.GetAsync("Sportas/GetByID/?ID=" + ID.ToString()).Result;

                var jsonString = response.Content.ReadAsStringAsync().Result;
                SportasViewModel sportas = JsonConvert.DeserializeObject<SportasViewModel>(jsonString);
                txtID.Text = sportas.ID.ToString();
                txtKlubID.Text = sportas.KlubID.ToString();
                txtTrenerID.Text = sportas.TrenerID.ToString();
                txtIme.Text = sportas.Ime;
                txtPrezime.Text = sportas.Prezime;
                txtDatumRodenja.Text = sportas.DatumRodenja.ToString();
                txtOIB.Text = sportas.OIB.ToString();
                txtMjestoStanovanja.Text = sportas.MjestoStanovanja;
                txtAdresa.Text = sportas.Adresa;
                if (sportas.LijecnickiPregledVrijediDo == null)
                {
                    txtLijecnickiPregledVrijediDo.CustomFormat = " ";
                    txtLijecnickiPregledVrijediDo.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    txtLijecnickiPregledVrijediDo.Text = sportas.LijecnickiPregledVrijediDo.ToString();
                }
                
                txtDatumUpisa.Text = sportas.DatumUpisa.ToString();
            }

        }

        private async void save_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                var input = new SportasViewModel
                {
                    ID = Convert.ToInt32(txtID.Text),
                    KlubID = Convert.ToInt32(txtKlubID.Text),
                    TrenerID = Convert.ToInt32(txtTrenerID.Text),
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodenja = txtDatumRodenja.Value,
                    OIB = Convert.ToInt32(txtOIB.Text),
                    MjestoStanovanja = txtMjestoStanovanja.Text,
                    Adresa = txtAdresa.Text,
                    LijecnickiPregledVrijediDo = txtLijecnickiPregledVrijediDo.Value,
                    DatumUpisa = txtDatumUpisa.Value
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PutAsync("api/Sportas", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<SportasViewModel> data = JsonConvert.DeserializeObject<List<SportasViewModel>>(jsonString);
                bindingSource1.DataSource = input;

            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krivo podatke");
                Sportas form = new Sportas(this);
                form.Show();
                this.Hide();
            }

            GetAllData();
        }

        private async void Dodaj_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                var input = new SportasViewModel
                {
                    KlubID = Convert.ToInt32(txtKlubID.Text),
                    TrenerID = Convert.ToInt32(txtTrenerID.Text),
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodenja = txtDatumRodenja.Value,
                    OIB = Convert.ToInt32(txtOIB.Text),
                    MjestoStanovanja = txtMjestoStanovanja.Text,
                    Adresa = txtAdresa.Text,
                    DatumUpisa = txtDatumUpisa.Value
                };
                if (txtLijecnickiPregledVrijediDo.Text!=" ")
                {
                    input.LijecnickiPregledVrijediDo = Convert.ToDateTime(txtLijecnickiPregledVrijediDo.Value);
                    // hide date value since it's not set
                    txtLijecnickiPregledVrijediDo.CustomFormat = " ";
                    txtLijecnickiPregledVrijediDo.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    txtLijecnickiPregledVrijediDo.CustomFormat = null;
                    txtLijecnickiPregledVrijediDo.Format = DateTimePickerFormat.Long; // set the date format you want.
                }
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49750");

                var content = new StringContent(JsonConvert.SerializeObject(input), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Sportas", content);
                var jsonString = response.Content.ReadAsStringAsync().Result;
                List<SportasViewModel> data = JsonConvert.DeserializeObject<List<SportasViewModel>>(jsonString);
                bindingSource1.DataSource = input;
            }
            catch (FormatException)
            {
                MessageBox.Show("Unijeli ste krivo podatke");
                Sportas form = new Sportas(this);
                form.Show();
                this.Hide();
            }

            
        GetAllData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtKlubID.Clear();
            txtTrenerID.Clear();
            txtID.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
            txtAdresa.Clear();
            txtDatumRodenja.Value = DateTime.Now.Date;
            txtDatumUpisa.Value = DateTime.Now.Date;
            //txtLijecnickiPregledVrijediDo.Value = DateTime.Now.Date;
            txtLijecnickiPregledVrijediDo.CustomFormat = " ";
            txtLijecnickiPregledVrijediDo.Format = DateTimePickerFormat.Custom;
            txtOIB.Clear();
            txtMjestoStanovanja.Clear();

        }

        private void txtNazad_Click(object sender, EventArgs e)
        {
            Meni newForm = new Meni();
            newForm.Show();
            this.Hide();
        }
    }
}