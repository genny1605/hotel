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
            if( cmb_selezionestagione.SelectedIndex == -1 || cmb_selezionecamera.SelectedIndex == -1 )
            {
                MessageBox.Show("attenzione non e stato rilevato alcun messagio");
                return;

            }else
            {
                int giorni=Convert.ToInt32(txt_giorni.Text);
                string stagione = cmb_selezionestagione.Text.ToLower();
                string stanza= cmb_selezionecamera.Text.ToLower();
                bool parcheggio = chk_parcheggio.Checked;
                double costoGiornaliero = 0;
                if( stagione=="bassa stagione")
                {
                    if(stanza=="bassa")
                    {
                        costoGiornaliero = 15;
                    }else if( stanza=="media")
                    {
                        costoGiornaliero = 30;
                    }else if( stanza=="alta")
                    {
                        costoGiornaliero = 45;
                    }
                }if (stagione == "media stagione")
                {
                    if( stanza=="bassa")
                    {
                        costoGiornaliero = 20;
                    }else if( stanza=="media")
                    {
                        costoGiornaliero = 35;
                    }else if( stanza=="alta")
                    {
                        costoGiornaliero = 50;
                    }
                }if ( stagione=="alta stagione")
                {
                    if( stanza=="bassa")
                    {
                        costoGiornaliero = 25;
                    }else if( stanza =="media")
                    {
                        costoGiornaliero = 40;
                    }else if( stanza=="alta")
                    {
                        costoGiornaliero = 55;
                    }
                }
                double costoStanza = 0;
                if( giorni<=0)
                {
                    MessageBox.Show(" i dati inseriti non sono corretti, riprova");
                }else if( giorni<=2)
                {
                    costoStanza += costoGiornaliero;
                }else if( giorni<=7)
                {
                    costoStanza += (costoGiornaliero * giorni)* 0.75;
                }
                else
                {
                    costoStanza  += (costoGiornaliero * giorni)* 0.65;
                   
                }
                double costoParcheggio = 0;
				if (chk_parcheggio.Checked)
				{
					costoParcheggio= 5 * giorni;
				}
               double prezzoTotale = costoStanza + costoParcheggio;
                lbl_spesaTotale.Text = " spesa totale: " + prezzoTotale;
			}
        }
	}
}
