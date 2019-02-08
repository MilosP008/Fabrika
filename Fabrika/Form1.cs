using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrika.Parkinzi;

namespace Fabrika
{
    public partial class Form1 : Form
    {
        #region Polja
        List<Vozilo> vozila = new List<Vozilo>();
        // Parkinzi
        NadkriveniParking maliNadkriveniParking = new NadkriveniParking(30, 2.5);
        NadkriveniParking velikiNadkriveniParking = new NadkriveniParking(50, 5);
        OtvoreniParking otvoreniParking = new OtvoreniParking();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void dodajVoziloDugme_Click(object sender, EventArgs e)
        {
            dodajVoziloPanel.Visible = true;
        }

        private void otkaziDugme_Click(object sender, EventArgs e)
        {
            vrstaComboBox.Text = "";
            markaTextBox.Text = "";
            bojaTextBox.Text = "";
            osobina1TextBox.Lines = null;
            osobina2TextBox.Lines = null;
            osobina3TextBox.Lines = null;
            osobina3CheckBox.Checked = false;
            validacijaLabel.Visible = false;
            dodajVoziloPanel.Visible = false;
            PromeniOsobine(new string[] { "", "", "", "" }, new bool[] { false, false, false, false, false, false, false });
        }

        private void izadjiDugme_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void osobineGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PromeniOsobine(string[] text, bool[] visible, bool?[] multiline = null)
        {
            // Osobina 1
            osobina1Label.Visible = visible[0];
            osobina1Label.Text = text[0];
            osobina1TextBox.Visible = visible[1];
            osobina1TextBox.Multiline = (multiline != null) ? (bool)multiline[0] : false;
            // Osobina 2
            osobina2Label.Visible = visible[2];
            osobina2Label.Text = text[1];
            osobina2TextBox.Visible = visible[3];
            osobina2TextBox.Multiline = (multiline != null) ? (bool)multiline[1] : false;
            // Osobina 3
            osobina3Label.Visible = visible[4];
            osobina3Label.Text = text[2];
            osobina3TextBox.Visible = visible[5];
            osobina3TextBox.Multiline = (multiline != null) ? (bool)multiline[2] : false;
            osobina3CheckBox.Visible = visible[6];
            osobina3CheckBox.Text = text[3];
        }

        private string ParkirajVozilo(Vozilo vozilo)
        {
            if (maliNadkriveniParking.Povrsina >= vozilo.GetZauzima)
            {
                maliNadkriveniParking = maliNadkriveniParking - vozilo;
                return "mali nadkriveni parking";
            }
            else if (velikiNadkriveniParking.Povrsina >= vozilo.GetZauzima)
            {
                velikiNadkriveniParking = velikiNadkriveniParking - vozilo;
                return "veliki nadkriveni parking";
            }
            else
            {
                otvoreniParking = otvoreniParking - vozilo;
                return "otvoreni parking";
            }
        }

        private void UkloniVoziloSaParkinga(Vozilo vozilo)
        {
            if(vozilo.Parking == "mali nadkriveni parking")
            {
                maliNadkriveniParking = maliNadkriveniParking + vozilo;
            }
            else if(vozilo.Parking == "veliki nadkriveni parking")
            {
                velikiNadkriveniParking = velikiNadkriveniParking + vozilo;
            }
            else
            {
                otvoreniParking = otvoreniParking + vozilo;
            }
        }

        private void vrstaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (vrstaComboBox.SelectedItem.ToString())
            {
                case "Gradski autobus":
                    PromeniOsobine(new string[] { "Broj mesta za stajanje", "Broj mesta za sedenje", "", "Zglobni" }, new bool[] { true, true, true, true, false, false, true });
                    break;
                case "Medjugradski autobus":
                    PromeniOsobine(new string[] { "Broj mesta za stajanje", "Broj mesta za sedenje", "Kapacitet prtljaznog prostora", "" }, new bool[] { true, true, true, true, true, true, false });
                    break;
                case "Kabriolet automobil":
                    PromeniOsobine(new string[] { "Broj sedista", "Dodatna oprema", "", "Skidajuci krov" }, new bool[] { true, true, true, true, false, false, true }, new bool?[] { false, true, false });
                    break;
                case "Klasican automobil":
                    PromeniOsobine(new string[] { "Nosivost krova", "Broj sedista", "Dodatna oprema", "" }, new bool[] { true, true, true, true, true, true, false }, new bool?[] { false, false, true });
                    break;
                case "Cisterna kamion":
                    PromeniOsobine(new string[] { "Kapacitet tanka", "Broj osovina", "", "" }, new bool[] { true, true, true, true, false, false, false });
                    break;
                case "Sleper kamion":
                    PromeniOsobine(new string[] { "Vucna snaga", "Broj osovina", "", "" }, new bool[] { true, true, true, true, false, false, false });
                    break;
                default:
                    PromeniOsobine(new string[] { "", "", "", "" }, new bool[] { false, false, false, false, false, false, false });
                    break;
            }
        }

        private void dodajDugme_Click(object sender, EventArgs e)
        {
            string vrstaVozila = vrstaComboBox.Text;
            string greska = "";

            try
            {
                switch (vrstaVozila)
                {
                    case "Gradski autobus":
                        greska += Validacija.ProveriGradskiAutobus(Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        if (greska != "") { break; }
                        Vozila.Autobusi.GradskiAutobus gradskiAutobus = new Vozila.Autobusi.GradskiAutobus(osobina3CheckBox.Checked, Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        gradskiAutobus.Parking = ParkirajVozilo(gradskiAutobus);
                        listaVozila.Items.Add(gradskiAutobus.ToString());
                        vozila.Add(gradskiAutobus);
                        break;
                    case "Medjugradski autobus":
                        greska += Validacija.ProveriMedjugradskiAutobus(Convert.ToDouble(osobina3TextBox.Text), Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        if (greska != "") { break; }
                        Vozila.Autobusi.MedjugradskiAutobus medjugradskiAutobus = new Vozila.Autobusi.MedjugradskiAutobus(Convert.ToDouble(osobina3TextBox.Text), Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        medjugradskiAutobus.Parking = ParkirajVozilo(medjugradskiAutobus);
                        listaVozila.Items.Add(medjugradskiAutobus.ToString());
                        vozila.Add(medjugradskiAutobus);
                        break;
                    case "Kabriolet automobil":
                        greska += Validacija.ProveriKabrioletAutomobil(Convert.ToInt32(osobina1TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        if (greska != "") { break; }
                        Vozila.Automobili.KabrioletAutomobil kabrioletAutomobil = new Vozila.Automobili.KabrioletAutomobil(osobina3CheckBox.Checked, Convert.ToInt32(osobina1TextBox.Text), markaTextBox.Text, bojaTextBox.Text, osobina2TextBox.Lines);
                        kabrioletAutomobil.Parking = ParkirajVozilo(kabrioletAutomobil);
                        listaVozila.Items.Add(kabrioletAutomobil.ToString());
                        vozila.Add(kabrioletAutomobil);
                        break;
                    case "Klasican automobil":
                        greska += Validacija.ProveriKlasicanAutomobil(Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        if (greska != "") { break; }
                        Vozila.Automobili.KlasicanAutomobil klasicanAutomobil = new Vozila.Automobili.KlasicanAutomobil(Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text, osobina3TextBox.Lines);
                        klasicanAutomobil.Parking = ParkirajVozilo(klasicanAutomobil);
                        listaVozila.Items.Add(klasicanAutomobil.ToString());
                        vozila.Add(klasicanAutomobil);
                        break;
                    case "Cisterna kamion":
                        greska += Validacija.ProveriCisternaKamion(Convert.ToDouble(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        if (greska != "") { break; }
                        Vozila.Kamioni.CisternaKamion cisternaKamion = new Vozila.Kamioni.CisternaKamion(Convert.ToDouble(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        cisternaKamion.Parking = ParkirajVozilo(cisternaKamion);
                        listaVozila.Items.Add(cisternaKamion.ToString());
                        vozila.Add(cisternaKamion);
                        break;
                    case "Sleper kamion":
                        greska += Validacija.ProveriSleperKamion(Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        if (greska != "") { break; }
                        Vozila.Kamioni.SleperKamion sleperKamion = new Vozila.Kamioni.SleperKamion(Convert.ToInt32(osobina1TextBox.Text), Convert.ToInt32(osobina2TextBox.Text), markaTextBox.Text, bojaTextBox.Text);
                        sleperKamion.Parking = ParkirajVozilo(sleperKamion);
                        listaVozila.Items.Add(sleperKamion.ToString());
                        vozila.Add(sleperKamion);
                        break;
                    default:
                        greska = "Vrsta vozila ne postoji.";
                        break;
                }
            }
            catch (FormatException)
            {
                greska = "Neko od polja nije u validnom formatu. ";
            }
            finally
            {
                if (greska == string.Empty)
                {
                    vrstaComboBox.Text = "";
                    markaTextBox.Text = "";
                    bojaTextBox.Text = "";
                    osobina1TextBox.Lines = null;
                    osobina2TextBox.Lines = null;
                    osobina3TextBox.Lines = null;
                    osobina3CheckBox.Checked = false;
                    validacijaLabel.Visible = false;
                    dodajVoziloPanel.Visible = false;
                    PromeniOsobine(new string[] { "", "", "", "" }, new bool[] { false, false, false, false, false, false, false });
                }
                else
                {
                    validacijaLabel.Visible = true;
                    validacijaLabel.Text = greska;
                }
            }
        }

        private void listaVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void obrisiVoziloDugme_Click(object sender, EventArgs e)
        {
            foreach(Vozilo vozilo in vozila)
            {
                if(vozilo.ToString() == listaVozila.SelectedItem.ToString()) // todo: PROBLEM - vozilo nema jedinstveni identifikator i iz tog razloga ako imamo 2 vozila sa istim osobinama program ce obrisati prvo iako mi to vozilo nismo obrisali sa liste!
                {
                    UkloniVoziloSaParkinga(vozilo);
                    vozila.Remove(vozilo);
                    break;
                }
            }

            listaVozila.Items.Remove(listaVozila.SelectedItem);
        }
    }
}
