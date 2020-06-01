//BLASCIUC GABRIELE-ANDREA, gr.3124a
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacie;

namespace Formular_Medicamente
{
    public partial class Search : Form
    {
        public Form1 f;
       
        public Search()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        { 
            data.DataSource = null;
            List<Medicament> med = new List<Medicament>();
            if (f.medicamente.Count() == 0) MessageBox.Show("Nu exista produse!");
            else
            {
                data.DataSource = f.medicamente;

                foreach (Medicament m in f.medicamente)
                {
                        if (m.dataActualizare >= dateTimePicker1.Value && m.dataActualizare <= dateTimePicker2.Value)
                        {
                        med.Add(m);
                        }   
                }
                data.DataSource = med;
                data.DataSource.ToString();
     
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
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
