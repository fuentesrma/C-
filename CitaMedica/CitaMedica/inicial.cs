using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CitaMedica
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void inicial_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form2 frmAcceso = new Form2();
            frmAcceso.Show();
            this.Hide();
        }
    }
}
