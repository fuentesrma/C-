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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // fijar la fecha maxima de acuerdo a la fecha del sistema


            // fijar la fecha minima de cita al dia actual
            fecha_CitaDateTimePicker.MinDate = System.DateTime.Now;
            fecha_CitaDateTimePicker.MaxDate = System.DateTime.Now.AddMonths(12);
            txtPaciente.Focus();
            



        }



        /// <summary>
        /// Este Metodo Sirve Para agendar la citas medicas
        /// </summary>
        /// <param name="sender"> este parametro identifica quein lanza el metodo </param>
        /// <param name="e"> argumentos de lanzamiento</param>
        private void button1_Click(object sender, EventArgs e)
        {
            consultasBindingSource.AddNew();
            rfc1TextBox.Text = lstPacientes.Text;
            usuario1TextBox.Text = usuarioTextBox.Text;
            fecha_CitaDateTimePicker.Enabled = true;
            hora_CitaDateTimePicker.Enabled = true;
            sintomatologiaTextBox.Enabled = true;



            
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPaciente.Text.Length != 0)
            {
                txtPaciente.BackColor = Color.White;
            }
            else
            {
                txtPaciente.BackColor = Color.Salmon;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


      

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Caracter no valido");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {
          
                oleDbDataAdapter1.SelectCommand.CommandText = "SELECT  Nombre, Direccion, Telefono, Sexo, Intervenciones, Hijos, Enfermedades, Historial_Clinico, Fecha_Nac, Rfc FROM Pacientes WHERE Rfc LIKE '%" + txtPaciente.Text + "%'";
                dataSet11.Pacientes.Clear();
                oleDbDataAdapter1.Fill(dataSet11, "Pacientes");
          
            
            if (dataSet11.Pacientes.Rows.Count > 0)
            {
                lstPacientes.Visible = true;
                lstPacientes.Size = new Size(250, (dataSet11.Pacientes.Rows.Count * 18));
            }
            else
            {
                lstPacientes.Visible = false;
                lstPacientes.Size = new Size(250, 4);
            }


        }

        

        private void lstPacientes_Click(object sender, EventArgs e)
        {
            txtPaciente.Text = lstPacientes.Text;
            lstPacientes.Visible = false;
            txtEmpleado.Focus(); // envia el foco a la caja txtEmpleado
        }

        

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            oleDbDataAdapter2.SelectCommand.CommandText = "SELECT Usuario, Clave, Nivel, Descripcion FROM Empleados WHERE Descripcion LIKE '%" + txtEmpleado.Text + "%' AND Nivel = 3";
            dataSet11.Empleados.Clear();
            oleDbDataAdapter2.Fill(dataSet11, "Empleados");

            if (dataSet11.Empleados.Rows.Count > 0)
            {
                lstEmpleados.Visible = true;
                lstEmpleados.Size = new Size(250, (dataSet11.Empleados.Rows.Count * 18));
            }
            else
            {
                lstEmpleados.Visible = false;
                lstEmpleados.Size = new Size(250, 4);
            }

        }

        private void lstEmpleados_Click(object sender, EventArgs e)
        {
            txtEmpleado.Text = lstEmpleados.Text;
            lstEmpleados.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string confirma = MessageBox.Show("Guardar los datos para consulta", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (confirma == "Yes") 
            {
                consultasBindingSource.EndEdit();
                oleDbDataAdapter3.Update(dataSet11, "Consultas");
                MessageBox.Show("Consulta Agendada Exitosamente");
                this.Close();
            }
            else
            {
            MessageBox.Show("Redefine los parametros para la consulta");
            }

        }

        

       






    

        
    }
}