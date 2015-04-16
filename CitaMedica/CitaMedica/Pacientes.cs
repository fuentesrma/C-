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
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.EndEdit();
            oleDbDataAdapter1.Update(dataSet11, "Pacientes");
            MessageBox.Show("Paciente Registrado");
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet11, "Pacientes");
        }
    }
}
