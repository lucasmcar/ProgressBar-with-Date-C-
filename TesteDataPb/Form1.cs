using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDataPb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            int dt = DateTime.Now.DayOfYear;


            label1.Text = Convert.ToString(dt);

            if (pbDia.Value <= dt)
            {
                pbDia.Value = pbDia.Value + dt;
                label4.Text = "Hoje é o " + dt + "º dia do ano";
            }
            else
            {
                tm.Enabled = false;
            }
        }
    }
}
