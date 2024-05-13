using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klub_aplikacija
{
    public partial class UserMeni : Form
    {
        public UserMeni()
        {
            InitializeComponent();
        }

        private void buttonClanarina_Click(object sender, EventArgs e)
        {
            Clanarina newForm = new Clanarina();
            newForm.Show();
            this.Hide();
        }

        private void buttonKlub_Click(object sender, EventArgs e)
        {
            Klub newForm = new Klub();
            newForm.Show();
            this.Hide();
        }

        private void buttonTrener_Click(object sender, EventArgs e)
        {
            Trener newForm = new Trener(this);
            newForm.Show();
            this.Hide();
        }

        private void buttonSportas_Click(object sender, EventArgs e)
        {
            Sportas newForm = new Sportas(this);
            newForm.Show();
            this.Hide();
        }
    }
}
