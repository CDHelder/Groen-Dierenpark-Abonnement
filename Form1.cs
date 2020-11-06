using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groen__Dierenpark_Abonnement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePickerPersoonlijk.Visible = false;
            dateTimePickerEchtpaar1.Visible = false;
            dateTimePickerEchtpaar2.Visible = false;

            labelAantalKinderen.Visible = false;
            nudAantalKinderen.Visible = false;

            labelAbonnment.Visible = false;
            labelPrijs.Visible = false;

            labelPersoonlijk1.Visible = false;
            labelEchtpaar1.Visible = false;
        }

        private void rbEchtpaar_Click(object sender, EventArgs e)
        {
            if (rbEchtpaar.Checked)
            {
                rbPersoonlijk.Checked = false;
                rbGezin.Checked = false;

                dateTimePickerPersoonlijk.Visible = false;
                dateTimePickerEchtpaar1.Visible = true;
                dateTimePickerEchtpaar2.Visible = true;

                labelAantalKinderen.Visible = false;
                nudAantalKinderen.Visible = false;

                labelPersoonlijk1.Visible = false;
                labelEchtpaar1.Visible = true;
            }
        }

        private void rbPersoonlijk_Click(object sender, EventArgs e)
        {
            if (rbPersoonlijk.Checked)
            {
                rbEchtpaar.Checked = false;
                rbGezin.Checked = false;

                dateTimePickerPersoonlijk.Visible = true;
                dateTimePickerEchtpaar1.Visible = false;
                dateTimePickerEchtpaar2.Visible = false;

                labelAantalKinderen.Visible = false;
                nudAantalKinderen.Visible = false;

                labelPersoonlijk1.Visible = true;
                labelEchtpaar1.Visible = false;
            }
        }

        private void rbGezin_Click(object sender, EventArgs e)
        {
            if (rbGezin.Checked)
            {
                rbPersoonlijk.Checked = false;
                rbEchtpaar.Checked = false;

                dateTimePickerPersoonlijk.Visible = false;
                dateTimePickerEchtpaar1.Visible = false;
                dateTimePickerEchtpaar2.Visible = false;

                labelAantalKinderen.Visible = true;
                nudAantalKinderen.Visible = true;

                labelPersoonlijk1.Visible = false;
                labelEchtpaar1.Visible = false;
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            dateTimePickerPersoonlijk.ResetText();
            dateTimePickerEchtpaar1.ResetText();
            dateTimePickerEchtpaar2.ResetText();

            nudAantalKinderen.ResetText();

            labelAbonnment.Visible = false;
            labelPrijs.Visible = false;
        }

        private void bBereken_Click(object sender, EventArgs e)
        {
            int abonnementPrijs = 0;
            
            if (rbPersoonlijk.Checked)
            {
                if (dateTimePickerPersoonlijk.Value.Year > 65)
                {
                    abonnementPrijs = 26;
                }
                if (dateTimePickerPersoonlijk.Value.Year < 65)
                {
                    abonnementPrijs = 30;
                }
            }

            if (rbEchtpaar.Checked)
            {
                if (dateTimePickerEchtpaar1.Value.Year > 65 && dateTimePickerEchtpaar2.Value.Year > 65)
                {
                    abonnementPrijs = 65;
                }
                else
                {
                    abonnementPrijs = 61;
                }
            }

            if (rbGezin.Checked)
            {
                if (nudAantalKinderen.Value == 1)
                {
                    abonnementPrijs = 71;
                }
                else if (nudAantalKinderen.Value == 2)
                {
                    abonnementPrijs = 82;
                }
                else if (nudAantalKinderen.Value >= 3)
                {
                    int aantalKinderen;
                    aantalKinderen = Convert.ToInt32(nudAantalKinderen.Value) - 2;
                    abonnementPrijs = 82 + (aantalKinderen * 11);
                }
            }

            labelPrijs.Text = abonnementPrijs.ToString();

            labelAbonnment.Visible = true;
            labelPrijs.Visible = true;
        }
    }
}
