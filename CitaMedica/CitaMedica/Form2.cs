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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDbSelectCommand1.CommandText = "SELECT Usuario, Clave, Nivel, Descripcion FROM Empleados WHERE Usuario ='" + txtUsuario.Text + "' AND Clave = '" + txtClave.Text + "'";
            oleDbDataAdapter1.Fill(dataSet11);
           
            
           
            if (lblUsua.Text == txtUsuario.Text && lblCla.Text == txtClave.Text)
            {
               
                this.Size = new Size(270, 260);
                label4.Text = "Cargando Aplicacion...";
                Vars.vNivel = int.Parse(lblNivel.Text);
                Vars.vDescripcion = lblDescripcion.Text;
                Vars.vUsuario = lblUsua.Text; // para tener el usuario como global
                progressBar1.Visible = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
                txtUsuario.Clear();
                txtClave.Clear();
                txtUsuario.Focus();
                intento++;
                if (intento == 4)
                {
                    
                    System.Media.SoundPlayer rep = new System.Media.SoundPlayer();
                    rep.SoundLocation = "c:\\Material\\sonido.wav";
                    rep.Play();
                   
                    MessageBox.Show("Acceso denegado");
                    Application.Exit();
                }
            
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == 27)
            {
                Application.Exit();
            }

            if ((int)e.KeyChar == 13)
            {
                txtClave.Focus();
            }
        }

    

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
             if ((int)e.KeyChar == 27)
            {
                Application.Exit();
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progreso++;
            progressBar1.Value = progreso;
            if (progreso == 100) 
            {
                timer1.Stop();
                MDIForm frmPrincipal = new MDIForm();
                frmPrincipal.Show();
                this.Hide();
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length != 0 && txtClave.Text.Length != 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length != 0 && txtClave.Text.Length != 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }

        
    }
}
