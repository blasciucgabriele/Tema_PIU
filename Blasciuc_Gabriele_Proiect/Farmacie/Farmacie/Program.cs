using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using Farmacie;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    class Program
    {
        static void Main(string[] args)
        {
            FormularMedicament m = new FormularMedicament();
            m.Show();
            Application.Run();
        }
    }


    class FormularMedicament : Form
    {

        Medicament n = new Medicament();
        private Label lblDenumire;
        private TextBox txtDenumire;
        private Label lblProducator;
        private TextBox txtProducator;
        private Label lblNatura;
        private TextBox txtNatura;
        private Label lblCod;
        private TextBox txtCod;
        private Label lblPret;
        private TextBox txtPret;
        private Label lblStoc;
        private TextBox txtStoc;

        private Button btnAdauga;

        private Label lblAfisare;


        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int DIMENSIUNE_SIR = 15;

        public FormularMedicament()
        {


            Size = new System.Drawing.Size(600, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(500, 500);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.Text = "GESTIUNE FARMACIE";
            this.BackColor = Color.Green;



            lblDenumire = new Label();
            lblDenumire.Width = LATIME_CONTROL;
            lblDenumire.Text = "Denumire:";
            lblDenumire.BackColor = Color.GhostWhite;
            this.Controls.Add(lblDenumire);
            txtDenumire = new TextBox();
            txtDenumire.Width = LATIME_CONTROL;
            txtDenumire.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtDenumire);


            lblProducator = new Label();
            lblProducator.Width = LATIME_CONTROL;
            lblProducator.Text = "Producator:";
            lblProducator.Top = DIMENSIUNE_PAS_Y;
            lblProducator.BackColor = Color.GhostWhite;
            this.Controls.Add(lblProducator);
            txtProducator = new TextBox();
            txtProducator.Width = LATIME_CONTROL;
            txtProducator.Location = new Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtProducator);

            lblNatura = new Label();
            lblNatura.Width = LATIME_CONTROL;
            lblNatura.Text = "Format:";
            lblNatura.Top = 2 * DIMENSIUNE_PAS_Y;
            lblNatura.BackColor = Color.GhostWhite;
            this.Controls.Add(lblNatura);
            txtNatura = new TextBox();
            txtNatura.Width = LATIME_CONTROL;
            txtNatura.Location = new Point(DIMENSIUNE_PAS_X, 2 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtNatura);

            lblCod = new Label();
            lblCod.Width = LATIME_CONTROL;
            lblCod.Text = "Cod:";
            lblCod.Top = 3 * DIMENSIUNE_PAS_Y;
            lblCod.BackColor = Color.GhostWhite;
            this.Controls.Add(lblCod);
            txtCod = new TextBox();
            txtCod.Width = LATIME_CONTROL;
            txtCod.Location = new Point(DIMENSIUNE_PAS_X, 3 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtCod);

            lblPret = new Label();
            lblPret.Width = LATIME_CONTROL;
            lblPret.Text = "Pret:";
            lblPret.Top = 4 * DIMENSIUNE_PAS_Y;
            lblPret.BackColor = Color.GhostWhite;
            this.Controls.Add(lblPret);
            txtPret = new TextBox();
            txtPret.Width = LATIME_CONTROL;
            txtPret.Location = new Point(DIMENSIUNE_PAS_X, 4 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtPret);

            lblStoc = new Label();
            lblStoc.Width = LATIME_CONTROL;
            lblStoc.Text = "Stoc:";
            lblStoc.Top = 5 * DIMENSIUNE_PAS_Y;
            lblStoc.BackColor = Color.GhostWhite;
            this.Controls.Add(lblStoc);
            txtStoc = new TextBox();
            txtStoc.Width = LATIME_CONTROL;
            txtStoc.Location = new Point(DIMENSIUNE_PAS_X, 5 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(txtStoc);

            lblAfisare = new Label();
            lblAfisare.Width = 400;
            lblAfisare.Height = 50;
            lblAfisare.Location = new Point(DIMENSIUNE_PAS_X, 7 * DIMENSIUNE_PAS_Y);
            lblAfisare.BackColor = Color.GhostWhite;
            lblAfisare.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblAfisare);

            //adaugare control de tip Button Adauga Medicament
            btnAdauga = new Button();
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 6 * DIMENSIUNE_PAS_Y);
            btnAdauga.Text = "Adauga Medicament";
            //"Click" este un *event* in clasa Button si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            //acesta este motivul utilizarii operatorului +=
            btnAdauga.Click += OnButtonClicked; //numele metodei este utilizat fara () pentru a indica ca se transmite adresa functiei si nu este un apel de functie
            this.Controls.Add(btnAdauga);

            this.FormClosed += OnFormClosed;
        }


        private void OnButtonClicked(object sender, EventArgs e)
        {

            if (txtDenumire.Text == string.Empty || txtDenumire.Text.Length > DIMENSIUNE_SIR)
            {
                MessageBox.Show("Introduceti denumirea!");
                txtDenumire.BackColor = Color.Red;
            }
            else 
            { 
                txtDenumire.BackColor = Color.GhostWhite;
                n.denumire = txtDenumire.Text;
            }
            



            if (txtProducator.Text == string.Empty || txtProducator.Text.Length > DIMENSIUNE_SIR)
            {
                MessageBox.Show("Introduceti producatorul!");
                txtProducator.BackColor = Color.Red;
            }
            else
            {
                txtProducator.BackColor = Color.GhostWhite;
                n.producator = txtProducator.Text;
            }



            if (txtNatura.Text == string.Empty || txtNatura.Text.Length > DIMENSIUNE_SIR)
            {
                MessageBox.Show("Introduceti formatul!");
                txtNatura.BackColor = Color.Red;
            }
            else
            {
                txtNatura.BackColor = Color.GhostWhite;
                n.natura = txtNatura.Text;
            }



            if (txtCod.Text == string.Empty || txtCod.Text.Length > DIMENSIUNE_SIR)
            {
                MessageBox.Show("Introduceti codul!");
                txtCod.BackColor = Color.Red;
            }
            else
            {
                txtCod.BackColor = Color.GhostWhite;
                n.cod = Convert.ToInt32(txtCod.Text);
            }



            if (txtPret.Text == string.Empty || txtPret.Text.Length > DIMENSIUNE_SIR)
            {
                MessageBox.Show("Introduceti pretul!");
                txtPret.BackColor = Color.Red;
            }
            else
            {
                txtPret.BackColor = Color.GhostWhite;
                n.pret = float.Parse(txtPret.Text);
            }



            if (txtStoc.Text == string.Empty || txtStoc.Text.Length > DIMENSIUNE_SIR)
            {
                MessageBox.Show("Introduceti stocul!");
                txtStoc.BackColor = Color.Red;
            }
            else
            {
                txtStoc.BackColor = Color.GhostWhite;
                n.stoc = Convert.ToInt32(txtStoc.Text);
            }
            if (txtDenumire.Text != string.Empty && txtDenumire.Text.Length < DIMENSIUNE_SIR && txtProducator.Text != string.Empty && txtProducator.Text.Length < DIMENSIUNE_SIR && txtNatura.Text != string.Empty && txtNatura.Text.Length < DIMENSIUNE_SIR && txtCod.Text != string.Empty && txtCod.Text.Length < DIMENSIUNE_SIR && txtPret.Text != string.Empty && txtPret.Text.Length < DIMENSIUNE_SIR && txtStoc.Text != string.Empty && txtStoc.Text.Length < DIMENSIUNE_SIR)
            {
                lblAfisare.Text = n.afisare();
                n.scriere_in_fisier();
            }

        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

       
 



