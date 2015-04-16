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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            this.Text = Vars.vDescripcion; // obtiene descripcion de la variable global
            switch (Vars.vNivel)
            { 
                case 1: // menu del administrador
            // acceso a todo, sin restricciones
            break;
                case 2: // menu del oficinista recepcionista
            darConsultaToolStripMenuItem.Enabled = false; // no da consulta
            generarReportesToolStripMenuItem2.Enabled = false;  //no hace reportes de citas
            usuariosToolStripMenuItem.Enabled = false; // no administra usuarios
            break;
                case 3: // menu del medico
            agregarPAcientesToolStripMenuItem.Enabled = false; // no administra pacientes
            usuariosToolStripMenuItem.Enabled = false; // no administra usuarios
          
            break;
            
            
            
            }


        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void agregarPAcientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPacientes.Created == false)
            {

                frmPacientes = new Pacientes();
                frmPacientes.MdiParent = this;
                frmPacientes.Show();
            }
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUsuarios.Created == false)
            {

                frmUsuarios = new Usuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
            }
        }

        private void administrarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCitas.Created == false)
            {

                frmCitas = new Form1();
                frmCitas.MdiParent = this;
                frmCitas.Show();
            }

        }

        private void darConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConsultas.Created == false)
            {

                frmConsultas = new Consulta();
                frmConsultas.MdiParent = this;
                frmConsultas.Show();
            }
        }
    }
}
