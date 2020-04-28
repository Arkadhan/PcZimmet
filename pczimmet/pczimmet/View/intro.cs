using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pczimmet.View
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void intro_Load(object sender, EventArgs e)
        {

            progressBar1.ForeColor = Color.DarkBlue;
                

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                progressBar1.Value = 100;
                userGiris userfrm = new userGiris();
                userfrm.Show();
                this.Hide();
                timer1.Stop();
            }
            else if (progressBar1.Value < 100)
            {
                progressBar1.Value += 50;
            }
          


        }
    }
}
