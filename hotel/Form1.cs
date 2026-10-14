using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( cmb_selezionestagione.SelectedIndex == null || cmb_selezionecamera== null )
            {
                MessageBox.Show("attenzione non e stato rilevato alcun messagio");
                return;

            }else
            {
                int giorni=Convert.ToInt32(txt_giorni.Text);
                string stagione = cmb_selezionestagione.ToString();
                string stanza=cmb_selezionecamera.ToString();
                bool parcheggio = chk_parcheggio.Checked;
                double costoGiornaliero = 0;
                if( stagione=="bassa stagione")
                {

                }
            }
        }
    }
}
