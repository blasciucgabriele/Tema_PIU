using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacie;

namespace Forma
{
    public partial class Form1 : Form
    {
        List<Medicament> medicamente = new List<Medicament>();
        public Form1()
        {

            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Denumire.Text == "")
            {
                MessageBox.Show("Introduceti Denumirea!");
                Denumire.BackColor = Color.Red;

            }
            else Denumire.BackColor = Color.GhostWhite;
            if (Producator.Text == "")
            {
                MessageBox.Show("Introduceti Producatorul!");
                Producator.BackColor = Color.Red;

            }
            else Producator.BackColor = Color.GhostWhite;
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Introduceti Formatul!");
            }

            if (Cod.Text == "")
            {
                MessageBox.Show("Introduceti Codul!");
                Cod.BackColor = Color.Red;

            }
            else Cod.BackColor = Color.GhostWhite;
            if (Pret.Text == "")
            {
                MessageBox.Show("Introduceti Pretul!");
                Pret.BackColor = Color.Red;

            }
            else Pret.BackColor = Color.GhostWhite;
            if (Stoc.Text == "")
            {
                MessageBox.Show("Introduceti Stocul!");
                Stoc.BackColor = Color.Red;

            }
            else Stoc.BackColor = Color.GhostWhite;
            if ((checkBox1.Checked == false && checkBox2.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == true))
            {
                MessageBox.Show("Bifati doar o singura optiune!");
            }

            if (Denumire.Text != "" && Producator.Text != "" && Cod.Text != "" && Pret.Text != "" && Stoc.Text != "")
            {
                Medicament m = new Medicament(Denumire.Text, Producator.Text, Convert.ToString(GetFormat()), int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), Convert.ToString(GetEliberare()));
                medicamente.Add(m);
                MessageBox.Show("Medicament adaugat!");
            }
        }
        private Natura GetFormat()
        {
            if (radioButton1.Checked)
                return Natura.Comprimate;
            if (radioButton2.Checked)
                return Natura.Sirop;
            if (radioButton3.Checked)
                return Natura.Gel;
            return Natura.Inexistent;
        }
        private Eliberare GetEliberare()
        {
            if (checkBox1.Checked)
                return Eliberare.Reteta;
            if (checkBox2.Checked)
                return Eliberare.Fara_reteta;
            return Eliberare.Inexistent;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (medicamente == null) MessageBox.Show("Nu exista produse!");
            else
            {
                richTextBox1.Clear();
                var ou = String.Format("{0,-5}{1,-10}{2,-15}{3,-10}{4,-10}{5,-10}{6,-10}", "Id", "Denumire", "Producator", "Format", "Cod", "Pret", "Stoc", "Mod eliberare");
                richTextBox1.AppendText(ou + "\n");
                richTextBox1.ForeColor = Color.Black;
                if (checkBox1.Checked == true || checkBox2.Checked == true)
                {
                    foreach (Medicament m in medicamente)
                    {
                        richTextBox1.AppendText(m.afisare());
                    }
                }
                if (checkBox1.Checked == true && checkBox2.Checked == true)
                    MessageBox.Show("Bifati doar o optiune!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            Denumire.Text = Producator.Text = Cod.Text = Pret.Text = Stoc.Text = richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Denumire.Text == "")
            {
                MessageBox.Show("Introduceti denumirea!");
                Denumire.BackColor = Color.Red;
            }
            else
            {
                Denumire.BackColor = Color.GhostWhite;
                foreach (Medicament m in medicamente)
                {
                    if (m.denumire.Equals(Denumire.Text) == true)
                    {
                        richTextBox1.ForeColor = Color.Green;
                        richTextBox1.Text = "Produsul exista!";
                    }
                    else
                    {
                        richTextBox1.ForeColor = Color.Red;
                        richTextBox1.Text = "Produsul nu exista";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Denumire.Text == "")
            {
                MessageBox.Show("Introduceti denumirea!");
                Denumire.BackColor = Color.Red;
            }
            if (validare_nume(Denumire.Text) == false)
            {
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text = "Produsul nu exista";
            }
            else
            {
                Denumire.BackColor = Color.GhostWhite;
                if (validare_nume(Denumire.Text) == true)
                {
                    int k = get_index(Denumire.Text);
                    if (Producator.Text == "")
                    {
                        MessageBox.Show("Introduceti Producatorul!");
                        Producator.BackColor = Color.Red;

                    }
                    else Producator.BackColor = Color.GhostWhite;
                    if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    {
                        MessageBox.Show("Introduceti Formatul!");

                    }
                    if ((checkBox1.Checked == false && checkBox2.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == true))
                    {
                        MessageBox.Show("Bifati doar o singura optiune!");
                    }
                    if (Cod.Text == "")
                    {
                        MessageBox.Show("Introduceti Codul!");
                        Cod.BackColor = Color.Red;

                    }
                    else Cod.BackColor = Color.GhostWhite;
                    if (Pret.Text == "")
                    {
                        MessageBox.Show("Introduceti Pretul!");
                        Pret.BackColor = Color.Red;

                    }
                    else Pret.BackColor = Color.GhostWhite;
                    if (Stoc.Text == "")
                    {
                        MessageBox.Show("Introduceti Stocul!");
                        Stoc.BackColor = Color.Red;

                    }
                    else Stoc.BackColor = Color.GhostWhite;
                    if (checkBox1.Checked == false && checkBox2.Checked == false)
                    {
                        MessageBox.Show("Introduceti modul de eliberare!");
                    }
                    if (Denumire.Text != "" && Producator.Text != "" && Cod.Text != "" && Pret.Text != "" && Stoc.Text != "" && radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true && checkBox2.Checked == true || checkBox1.Checked == true)
                    {

                        if (radioButton1.Checked == true && checkBox1.Checked == true && checkBox2.Checked == false)
                        {
                            medicamente[k] = new Medicament(Denumire.Text, Producator.Text, radioButton1.Text, int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), checkBox1.Text);
                            richTextBox1.Text = "Modificare efectuata!";

                        }
                        if (radioButton1.Checked == true && checkBox2.Checked == true && checkBox1.Checked == false)
                        {
                            medicamente[k] = new Medicament(Denumire.Text, Producator.Text, radioButton1.Text, int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), checkBox2.Text);
                            richTextBox1.Text = "Modificare efectuata!";
                        }

                        if (radioButton2.Checked == true && checkBox1.Checked == true && checkBox2.Checked == false)
                        {
                            medicamente[k] = new Medicament(Denumire.Text, Producator.Text, radioButton1.Text, int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), checkBox1.Text);
                            richTextBox1.Text = "Modificare efectuata!";
                        }
                        if (radioButton2.Checked == true && checkBox2.Checked == true && checkBox1.Checked == false)
                        {
                            medicamente[k] = new Medicament(Denumire.Text, Producator.Text, radioButton1.Text, int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), checkBox2.Text);
                            richTextBox1.Text = "Modificare efectuata!";
                        }

                        if (radioButton3.Checked == true && checkBox1.Checked == true && checkBox2.Checked == false)
                        {
                            medicamente[k] = new Medicament(Denumire.Text, Producator.Text, radioButton1.Text, int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), checkBox1.Text);
                            richTextBox1.Text = "Modificare efectuata!";
                        }
                        if (radioButton3.Checked == true && checkBox2.Checked == true && checkBox1.Checked == false)
                        {
                            medicamente[k] = new Medicament(Denumire.Text, Producator.Text, radioButton1.Text, int.Parse(Cod.Text), float.Parse(Pret.Text), int.Parse(Stoc.Text), checkBox2.Text);
                            richTextBox1.Text = "Modificare efectuata!";
                        }


                        richTextBox1.ForeColor = Color.Green;
                    }
                }
            }
        }



        private bool validare_nume(string nume)
        {
            foreach(Medicament m in medicamente)
            {
                if (m.denumire.Equals(nume))
                {
                    return true;
                }
            }
            return false;
        }
        private int get_index(string nume)
        {
            for(int i=0;i<medicamente.Count();i++)
            {
                if(nume==medicamente[i].denumire)
                {
                    return i;
                }
            }
            return -1;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blasciuc Gabriele-Andrea, 3124a, FIESC C2");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
