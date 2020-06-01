//BLASCIUC GABRIELE-ANDREA, gr.3124a
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacie;

namespace Formular_Medicamente
{
    public partial class Form1 : Form
    {
        
        public List<Medicament> medicamente = new List<Medicament>();
        const int maxim = 7;
        const int mx = 15;
        
        public Form1()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            Producator.DropDownStyle = ComboBoxStyle.DropDownList;
            trd.Abort();  

        }
        ///START APLICATIE/////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void formRun()
        {
            Application.Run(new Farmacia_USV());
        }
        ///RETURNEAZA OPTIUNEA DIN RADIOBUTTON BIFATA//////////////////////////////////////////////////////////////////////////////
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
        ///RETURNEAZA OPTIUNEA DIN CHECKBOX BIFATA//////////////////////////////////////////////////////////////////////////////
        private Eliberare GetEliberare()
        {
            if (checkBox1.Checked==true && checkBox2.Checked==false)
                return Eliberare.Reteta;
            if (checkBox2.Checked==true && checkBox1.Checked==false)
                return Eliberare.Fara_reteta;
            return Eliberare.Inexistent;
        }
    ///BUTONUL ADAUGA MEDICAMENT///////////////////////////////////////////////////////////////////////////////////////////////////
            private void button1_Click_1(object sender, EventArgs e)
           {

            if (Denumire.Text == string.Empty || Denumire.Text.Length > mx)
            {
                errorProvider1.SetError(Denumire, "Introduceti formatul");
            }
            else errorProvider1.Clear();
            if (Producator.SelectedItem == null)
            {
                errorProvider2.SetError(Producator, "Introduceti Producatorul!");
            }
            else errorProvider2.Clear();
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                errorProvider3.SetError(radioButton1,"Introduceti Formatul!");
            }
            else errorProvider3.Clear();
            int _cod = 0, _stoc = 0;
            float _pret = 0;
            if (Cod.Text == string.Empty || int.TryParse(Cod.Text, out _cod) != true || Cod.Text.Length > maxim)
            {
                errorProvider4.SetError(Cod,"Introduceti Codul/Format incorect!");
            }
            else errorProvider4.Clear();
            if (Pret.Text == "" || float.TryParse(Pret.Text, out _pret) != true || Pret.Text.Length>maxim)
            {
                errorProvider5.SetError(Pret,"Introduceti Pretul/Format incorect!");
            }
            else errorProvider5.Clear();
            if (Stoc.Text == "" || int.TryParse(Stoc.Text, out _stoc) != true || Stoc.Text.Length>maxim)
            {
                errorProvider6.SetError(Stoc,"Introduceti Stocul/Format incorect!");
            }
            else errorProvider6.Clear();
            if ((checkBox1.Checked == false && checkBox2.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == true))
            {
                errorProvider7.SetError(checkBox1,"Bifati doar o singura optiune(Mod Eliberare)!");
            }
            else errorProvider7.Clear();
            if (Producator.SelectedIndex!=-1 && int.TryParse(Cod.Text, out _cod) == true && int.TryParse(Stoc.Text, out _stoc) == true && float.TryParse(Pret.Text, out _pret) == true && Denumire.Text != "" && Cod.Text != "" && Pret.Text != "" && Stoc.Text != "" && (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true) && (checkBox1.Checked == true && checkBox2.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == true))
            {
                    Medicament m = new Medicament(Denumire.Text, Producator.SelectedItem.ToString(), Convert.ToString(GetFormat()), _cod, _pret,_stoc, Convert.ToString(GetEliberare()));
                    medicamente.Add(m);
                    m.Add_Medicament();
                    m.dataActualizare = DateTime.Now;
                    MessageBox.Show("Medicament adaugat!");
            }
        }
        ///BUTONUL AFISEAZA MEDICAMENTE////////////////////////////////////////////////////////////////////////////////////////////////
        private void button2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Items.Clear();
            var j = String.Format("{0,-5}{1,-15}{2,-20}{3,-15}{4,-12}{5,-10}{6,-10}{7,-20}\n", "Id", "Denumire", "Producator", "Format", "Cod", "Pret", "Stoc", "Mod Eliberare");
            richTextBox1.Items.Add(j);
            if (medicamente.Count() == 0) MessageBox.Show("Nu exista produse!");
            else
            {   
                    int c = 1;
                    foreach (Medicament m in medicamente)
                    {
                        var k = String.Format("{0,-5}{1,-15}{2,-20}{3,-15}{4,-12}{5,-10}{6,-10}{7,-20}\n", c, m.denumire, m.producator, Convert.ToString(m.natura), m.cod, m.pret, m.stoc, m.mod_eliberare.ToString());
                        richTextBox1.Items.Add(k);
                        c = c + 1;
                    }
            }
        }
        ///RESTART APLICATIE///////////////////////////////////////////////////////////////////////////////////////
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
        }
        ///INFO AUTOR///////////////////////////////////////////////////////////////////////////////////////////////
        private void authorNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Blasciuc Gabriele-Andrea, 3124a, FIESC C2");
        } 
        ///FORMULAR MODIFICA MEDICAMENT///////////////////////////////////////////////////////////////////////////////
        private void Modify_KeyDown(object sender, KeyEventArgs e)
        {
            int ok = 1;
            if (e.KeyCode == Keys.Enter)
            {
                if (medicamente.Count() == 0) MessageBox.Show("Nu exista medicamente!");
                else
                {
                    if (md.Text == "")
                    {
                        MessageBox.Show("Introduceti Denumirea!");
                        md.BackColor = Color.Red;
                    }
                    else
                    {
                        md.BackColor = Color.GhostWhite;
                        foreach (Medicament m in medicamente)
                        {
                            if (m.denumire.Equals(md.Text) == true)
                            {
                                Form_Modifica f = new Form_Modifica();
                                f.f = this;
                                f.ShowDialog();
                                ok = 1;
                            }
                            else ok = 0;
                        }
                        if(ok==0) MessageBox.Show("Medicamentul nu exista!");
                    }
                }
            }
        }
        ///CAUTA EXISTENTA UNUI MEDICAMENT////////////////////////////////////////////////////////////////////////
        private  void Find_KeyDown(object sender, KeyEventArgs e)
        {
            int ok = 1;
            if (e.KeyCode == Keys.Enter)
            {
                if (medicamente.Count() == 0) MessageBox.Show("Nu exista medicamente!");
                else
                {
                    if (f.Text == "")
                    {
                        MessageBox.Show("Introduceti denumirea!");
                        f.BackColor = Color.Red;
                    }
                    else
                    {
                            f.BackColor = Color.GhostWhite;
                        foreach (Medicament m in medicamente)
                        {
                            if (m.denumire.Equals(f.Text) == true)
                            {

                                MessageBox.Show("Produsul exista!");
                                ok = 1;
                                break;
     
                            }
                            else
                            {
                                ok = 0;
                            }
                        }
                            if(ok==0) MessageBox.Show("Produsul nu exista");                 
                    }
                }
            }
        }
    ///CLEAR FIELDS///////////////////////////////////////////////////////////////////////////////////////////////////////
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                Denumire.Text = Producator.Text = Cod.Text = Pret.Text = Stoc.Text = "";
                richTextBox1.Items.Clear();
                Producator.SelectedIndex = -1;
        }
        ///FORMULAR DE CAUTARE DUPA INTERVAL DE TIMP///////////////////////////////////////////////////////////////////////////
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Search f = new Search();
           f.f = this;
            f.ShowDialog();
        }
        ///UN CLICK PE SECTIUNEA FIND DIN MENIU VA GOLI CONTROALELE////////////////////////////////////////////////////////////
        private void Find_Click(object sender, EventArgs e)
        {
            f.Text = "";
            f.BackColor = Color.GhostWhite;
        }
        ///UN CLICK PE SECTIUNEA MODIFY DIN MENIU VA GOLI CONTROALELE////////////////////////////////////////////////////////////
        private void Modify_Click(object sender, EventArgs e)
        {
            md.Text = "";
            md.BackColor = Color.GhostWhite;
        }
        ///IESIRE DIN APLICATIE
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message = "Doriti sa inchideti aplicatia?";
            const string caption = "Iesire";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Environment.Exit(0);
            e.Cancel = (result == DialogResult.No);
        }

    }   
    }
   

