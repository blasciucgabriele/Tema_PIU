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

namespace Formular_Medicamente
{
    public partial class Farmacia_USV : Form
    {
        int move = 2;
        public Farmacia_USV()
        {
            InitializeComponent();
        }
        private void Farmacia_USV_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if(panelSlide.Left>170)
            {
                panelSlide.Left = 0;
            }
            if (panelSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void Farmacia_USV_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

       
    }
}
