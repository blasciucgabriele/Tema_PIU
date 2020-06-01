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
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacie;

namespace Formular_Medicamente
{
    public partial class Form_Modifica : Form
    {
        
        public Form1 f;
        const int maxim = 7;
        const int mx = 15;
        public Form_Modifica()
        {
            InitializeComponent();
            Producator.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            f.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = get_index(Denumire.Text);
            if (Producator.SelectedItem == null)
            {
                errorProvider2.SetError(Producator, "Introduceti Producatorul!");
            }
            else errorProvider2.Clear();
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                errorProvider3.SetError(radioButton1, "Introduceti Formatul!");
            }
            else errorProvider3.Clear();
            int _cod = 0, _stoc = 0;
            float _pret = 0;
            if (Cod.Text == string.Empty || int.TryParse(Cod.Text, out _cod) != true || Cod.Text.Length > maxim)
            {
                errorProvider4.SetError(Cod, "Introduceti Codul/Format incorect!");
            }
            else errorProvider4.Clear();
            if (Pret.Text == "" || float.TryParse(Pret.Text, out _pret) != true || Pret.Text.Length > maxim)
            {
                errorProvider5.SetError(Pret, "Introduceti Pretul/Format incorect!");
            }
            else errorProvider5.Clear();
            if (Stoc.Text == "" || int.TryParse(Stoc.Text, out _stoc) != true || Stoc.Text.Length > maxim)
            {
                errorProvider6.SetError(Stoc, "Introduceti Stocul/Format incorect!");
            }
            else errorProvider6.Clear();
            if ((checkBox1.Checked == false && checkBox2.Checked == false) || (checkBox1.Checked == true && checkBox2.Checked == true))
            {
                errorProvider7.SetError(checkBox1, "Bifati doar o singura optiune(Mod Eliberare)!");
            }
            else errorProvider7.Clear();
            if (int.TryParse(Cod.Text, out _cod) == true && int.TryParse(Stoc.Text, out _stoc) == true && float.TryParse(Pret.Text, out _pret) == true && Denumire.Text != "" && Cod.Text != "" && Pret.Text != "" && Stoc.Text != "" && (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true) && (checkBox1.Checked == true && checkBox2.Checked == false) || (checkBox1.Checked == false && checkBox2.Checked == true) && Producator.SelectedItem != null)
            {
                
                f.medicamente[k].producator = Producator.SelectedItem.ToString();
                f.medicamente[k].natura = GetFormat();
                f.medicamente[k].cod = _cod;
                f.medicamente[k].pret = _pret;
                f.medicamente[k].stoc = _stoc;
                f.medicamente[k].mod_eliberare = GetEliberare();
                f.medicamente[k].dataActualizare = DateTime.Now;
               
                MessageBox.Show("Medicament modficat!");
                button2.Enabled = false;
            }
        }
        private bool validare_nume(string nume)
        {
            foreach (Medicament m in f.medicamente)
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
            foreach (Medicament m in f.medicamente)
            {
                if (m.denumire.Equals(nume))
                {
                    return f.medicamente.IndexOf(m);
                }
            }
            return 0;
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
            if (checkBox1.Checked == true && checkBox2.Checked == false)
                return Eliberare.Reteta;
            if (checkBox2.Checked == true && checkBox1.Checked == false)
                return Eliberare.Fara_reteta;
            return Eliberare.Inexistent;
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
