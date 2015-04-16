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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(dataSet11, "Empleados");
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.EndEdit();
            oleDbDataAdapter1.Update(dataSet11, "Empleados");
            MessageBox.Show("Empleado Registrado");
        }
    }
}
