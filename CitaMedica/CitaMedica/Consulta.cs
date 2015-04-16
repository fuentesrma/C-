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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            oleDbDataAdapter1.SelectCommand.CommandText = " SELECT Consultas.Id, Consultas.Rfc1, Consultas.Usuario1, Consultas.Fecha_Cita,
            Consultas.Hora_Cita, Consultas.Sintomatologia, Consultas.Realizada, Pacientes.Rfc, Pacientes.Nombre, Pacientes.Sexo,
            Pacientes.Intervenciones, Pacientes.Hijos, Pacientes.Enfermedades, Pacientes.Historial_Clinico 
                FROM (Consultas INNER JOIN Pacientes ON Consultas.Rfc1 = Pacientes.Rfc) WHERE (Consultas.Usuario1 = '" + Vars.vUsuario + "')";
            oleDbDataAdapter1.Fill(dataSet11);
           
        }

      
      
    }
}
