using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijeVozilo
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloLista = new List<Vozilo>();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtboxBrojKotaca.Text) % 2 != 0)
            {
                MessageBox.Show("nije dovzoljeno upisati neparni broj kotaca! \r\n", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Vozilo vozilo = new Vozilo(Convert.ToInt32(txtboxBrojKotaca.Text), Convert.ToInt32(txtboxGodProizvodnje.Text), txtboxModel.Text, "");
                voziloLista.Add(vozilo);
                txtboxModel.Clear();
                txtboxGodProizvodnje.Clear();
                txtboxBrojKotaca.Clear();
                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnObradi_Click(object sender, EventArgs e)
        {
            txtboxIspisi.AppendText("-_-__-_-_- Obrađivanje.....................");
            foreach(Vozilo vozilo in voziloLista)
            {
                if(vozilo.Brojkotaca==2)
                {
                    vozilo.Kategorija = "Motocikl";
                }
                if (vozilo.Brojkotaca == 4)
                {
                    vozilo.Kategorija = "Automobil";
                }
                if (vozilo.Brojkotaca >4)
                {
                    vozilo.Kategorija = "Kamion";
                }
            }
           
        }

        private void btnispis_Click(object sender, EventArgs e)
        {
            txtboxIspisi.Text = "Model" + "\tGodina proizvodnje" + "\tBroj Kotaca" + "\t\tKategorija\r\n";
            foreach (Vozilo vozilo in voziloLista)
            {
                txtboxIspisi.AppendText(vozilo.ToString() + "\r\n");
            }
        }
    }

    
}
