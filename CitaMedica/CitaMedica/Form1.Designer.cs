namespace CitaMedica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label fecha_NacLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label intervencionesLabel;
            System.Windows.Forms.Label hijosLabel;
            System.Windows.Forms.Label enfermedadesLabel;
            System.Windows.Forms.Label historial_ClinicoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label nivelLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label rfc1Label;
            System.Windows.Forms.Label usuario1Label;
            System.Windows.Forms.Label fecha_CitaLabel;
            System.Windows.Forms.Label sintomatologiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label hora_CitaLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet11 = new CitaMedica.DataSet1();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_NacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.intervencionesCheckBox = new System.Windows.Forms.CheckBox();
            this.hijosTextBox = new System.Windows.Forms.TextBox();
            this.enfermedadesTextBox = new System.Windows.Forms.TextBox();
            this.historial_ClinicoTextBox = new System.Windows.Forms.TextBox();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.nivelTextBox = new System.Windows.Forms.TextBox();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.rfc1TextBox = new System.Windows.Forms.TextBox();
            this.usuario1TextBox = new System.Windows.Forms.TextBox();
            this.fecha_CitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sintomatologiaTextBox = new System.Windows.Forms.TextBox();
            this.hora_CitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            fecha_NacLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            intervencionesLabel = new System.Windows.Forms.Label();
            hijosLabel = new System.Windows.Forms.Label();
            enfermedadesLabel = new System.Windows.Forms.Label();
            historial_ClinicoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            rfc1Label = new System.Windows.Forms.Label();
            usuario1Label = new System.Windows.Forms.Label();
            fecha_CitaLabel = new System.Windows.Forms.Label();
            sintomatologiaLabel = new System.Windows.Forms.Label();
            hora_CitaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 92);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 25;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 118);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 27;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 144);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 29;
            telefonoLabel.Text = "Telefono:";
            // 
            // fecha_NacLabel
            // 
            fecha_NacLabel.AutoSize = true;
            fecha_NacLabel.Location = new System.Drawing.Point(14, 171);
            fecha_NacLabel.Name = "fecha_NacLabel";
            fecha_NacLabel.Size = new System.Drawing.Size(63, 13);
            fecha_NacLabel.TabIndex = 31;
            fecha_NacLabel.Text = "Fecha Nac:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(180, 170);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 33;
            sexoLabel.Text = "Sexo:";
            // 
            // intervencionesLabel
            // 
            intervencionesLabel.AutoSize = true;
            intervencionesLabel.Location = new System.Drawing.Point(244, 170);
            intervencionesLabel.Name = "intervencionesLabel";
            intervencionesLabel.Size = new System.Drawing.Size(80, 13);
            intervencionesLabel.TabIndex = 35;
            intervencionesLabel.Text = "Intervenciones:";
            // 
            // hijosLabel
            // 
            hijosLabel.AutoSize = true;
            hijosLabel.Location = new System.Drawing.Point(278, 201);
            hijosLabel.Name = "hijosLabel";
            hijosLabel.Size = new System.Drawing.Size(33, 13);
            hijosLabel.TabIndex = 37;
            hijosLabel.Text = "Hijos:";
            // 
            // enfermedadesLabel
            // 
            enfermedadesLabel.AutoSize = true;
            enfermedadesLabel.Location = new System.Drawing.Point(16, 201);
            enfermedadesLabel.Name = "enfermedadesLabel";
            enfermedadesLabel.Size = new System.Drawing.Size(78, 13);
            enfermedadesLabel.TabIndex = 39;
            enfermedadesLabel.Text = "Enfermedades:";
            // 
            // historial_ClinicoLabel
            // 
            historial_ClinicoLabel.AutoSize = true;
            historial_ClinicoLabel.Location = new System.Drawing.Point(16, 232);
            historial_ClinicoLabel.Name = "historial_ClinicoLabel";
            historial_ClinicoLabel.Size = new System.Drawing.Size(81, 13);
            historial_ClinicoLabel.TabIndex = 41;
            historial_ClinicoLabel.Text = "Historial Clinico:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(397, 96);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 43;
            usuarioLabel.Text = "Usuario:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(477, 62);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 45;
            claveLabel.Text = "Clave:";
            claveLabel.Visible = false;
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(477, 59);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(34, 13);
            nivelLabel.TabIndex = 47;
            nivelLabel.Text = "Nivel:";
            nivelLabel.Visible = false;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(398, 60);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(45, 13);
            descripcionLabel.TabIndex = 49;
            descripcionLabel.Text = "Médico:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(22, 255);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 52;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // rfc1Label
            // 
            rfc1Label.AutoSize = true;
            rfc1Label.Location = new System.Drawing.Point(397, 122);
            rfc1Label.Name = "rfc1Label";
            rfc1Label.Size = new System.Drawing.Size(33, 13);
            rfc1Label.TabIndex = 54;
            rfc1Label.Text = "Rfc1:";
            // 
            // usuario1Label
            // 
            usuario1Label.AutoSize = true;
            usuario1Label.Location = new System.Drawing.Point(397, 148);
            usuario1Label.Name = "usuario1Label";
            usuario1Label.Size = new System.Drawing.Size(52, 13);
            usuario1Label.TabIndex = 56;
            usuario1Label.Text = "Usuario1:";
            // 
            // fecha_CitaLabel
            // 
            fecha_CitaLabel.AutoSize = true;
            fecha_CitaLabel.Location = new System.Drawing.Point(397, 175);
            fecha_CitaLabel.Name = "fecha_CitaLabel";
            fecha_CitaLabel.Size = new System.Drawing.Size(61, 13);
            fecha_CitaLabel.TabIndex = 58;
            fecha_CitaLabel.Text = "Fecha Cita:";
            // 
            // sintomatologiaLabel
            // 
            sintomatologiaLabel.AutoSize = true;
            sintomatologiaLabel.Location = new System.Drawing.Point(394, 226);
            sintomatologiaLabel.Name = "sintomatologiaLabel";
            sintomatologiaLabel.Size = new System.Drawing.Size(79, 13);
            sintomatologiaLabel.TabIndex = 62;
            sintomatologiaLabel.Text = "Sintomatologia:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "\"El Buen Remedio\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(538, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Programar Consulta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(99, 60);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(250, 20);
            this.txtPaciente.TabIndex = 20;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Paciente";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Nombre, Direccion, Telefono, Sexo, Intervenciones, Hijos, Enfermeda" +
                "des, Historial_Clinico, Fecha_Nac, Rfc\r\nFROM            Pacientes";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Material\\Usuarios.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Pacientes` (`Nombre`, `Direccion`, `Telefono`, `Sexo`, `Intervencion" +
                "es`, `Hijos`, `Enfermedades`, `Historial_Clinico`, `Fecha_Nac`, `Rfc`) VALUES (?" +
                ", ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"),
            new System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"),
            new System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"),
            new System.Data.OleDb.OleDbParameter("Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, "Sexo"),
            new System.Data.OleDb.OleDbParameter("Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, "Intervenciones"),
            new System.Data.OleDb.OleDbParameter("Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Hijos"),
            new System.Data.OleDb.OleDbParameter("Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, "Enfermedades"),
            new System.Data.OleDb.OleDbParameter("Historial_Clinico", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Historial_Clinico"),
            new System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, "Fecha_Nac"),
            new System.Data.OleDb.OleDbParameter("Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, "Rfc")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"),
            new System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"),
            new System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"),
            new System.Data.OleDb.OleDbParameter("Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, "Sexo"),
            new System.Data.OleDb.OleDbParameter("Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, "Intervenciones"),
            new System.Data.OleDb.OleDbParameter("Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Hijos"),
            new System.Data.OleDb.OleDbParameter("Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, "Enfermedades"),
            new System.Data.OleDb.OleDbParameter("Historial_Clinico", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Historial_Clinico"),
            new System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, "Fecha_Nac"),
            new System.Data.OleDb.OleDbParameter("Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, "Rfc"),
            new System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Sexo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Intervenciones", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hijos", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Enfermedades", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rfc", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Sexo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Intervenciones", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hijos", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Enfermedades", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rfc", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Pacientes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Sexo", "Sexo"),
                        new System.Data.Common.DataColumnMapping("Intervenciones", "Intervenciones"),
                        new System.Data.Common.DataColumnMapping("Hijos", "Hijos"),
                        new System.Data.Common.DataColumnMapping("Enfermedades", "Enfermedades"),
                        new System.Data.Common.DataColumnMapping("Historial_Clinico", "Historial_Clinico"),
                        new System.Data.Common.DataColumnMapping("Fecha_Nac", "Fecha_Nac"),
                        new System.Data.Common.DataColumnMapping("Rfc", "Rfc")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.dataSet11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(99, 89);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(250, 20);
            this.nombreTextBox.TabIndex = 26;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(99, 115);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(250, 20);
            this.direccionTextBox.TabIndex = 28;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(99, 141);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(250, 20);
            this.telefonoTextBox.TabIndex = 30;
            // 
            // fecha_NacDateTimePicker
            // 
            this.fecha_NacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "Fecha_Nac", true));
            this.fecha_NacDateTimePicker.Enabled = false;
            this.fecha_NacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_NacDateTimePicker.Location = new System.Drawing.Point(98, 167);
            this.fecha_NacDateTimePicker.Name = "fecha_NacDateTimePicker";
            this.fecha_NacDateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.fecha_NacDateTimePicker.TabIndex = 32;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(217, 167);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(22, 20);
            this.sexoTextBox.TabIndex = 34;
            // 
            // intervencionesCheckBox
            // 
            this.intervencionesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pacientesBindingSource, "Intervenciones", true));
            this.intervencionesCheckBox.Location = new System.Drawing.Point(331, 165);
            this.intervencionesCheckBox.Name = "intervencionesCheckBox";
            this.intervencionesCheckBox.Size = new System.Drawing.Size(23, 24);
            this.intervencionesCheckBox.TabIndex = 36;
            this.intervencionesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hijosTextBox
            // 
            this.hijosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Hijos", true));
            this.hijosTextBox.Location = new System.Drawing.Point(323, 198);
            this.hijosTextBox.Name = "hijosTextBox";
            this.hijosTextBox.Size = new System.Drawing.Size(26, 20);
            this.hijosTextBox.TabIndex = 38;
            // 
            // enfermedadesTextBox
            // 
            this.enfermedadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Enfermedades", true));
            this.enfermedadesTextBox.Location = new System.Drawing.Point(100, 198);
            this.enfermedadesTextBox.Name = "enfermedadesTextBox";
            this.enfermedadesTextBox.Size = new System.Drawing.Size(172, 20);
            this.enfermedadesTextBox.TabIndex = 40;
            // 
            // historial_ClinicoTextBox
            // 
            this.historial_ClinicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Historial_Clinico", true));
            this.historial_ClinicoTextBox.Location = new System.Drawing.Point(100, 229);
            this.historial_ClinicoTextBox.Multiline = true;
            this.historial_ClinicoTextBox.Name = "historial_ClinicoTextBox";
            this.historial_ClinicoTextBox.Size = new System.Drawing.Size(249, 49);
            this.historial_ClinicoTextBox.TabIndex = 42;
            // 
            // lstPacientes
            // 
            this.lstPacientes.DataSource = this.pacientesBindingSource;
            this.lstPacientes.DisplayMember = "Rfc";
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.Location = new System.Drawing.Point(99, 76);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(250, 4);
            this.lstPacientes.TabIndex = 43;
            this.lstPacientes.Visible = false;
            this.lstPacientes.Click += new System.EventHandler(this.lstPacientes_Click);
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        Usuario, Clave, Nivel, Descripcion\r\nFROM            Empleados";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `Empleados` (`Usuario`, `Clave`, `Nivel`, `Descripcion`) VALUES (?, ?" +
                ", ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Usuario", System.Data.OleDb.OleDbType.VarWChar, 0, "Usuario"),
            new System.Data.OleDb.OleDbParameter("Clave", System.Data.OleDb.OleDbType.VarWChar, 0, "Clave"),
            new System.Data.OleDb.OleDbParameter("Nivel", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Nivel"),
            new System.Data.OleDb.OleDbParameter("Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, "Descripcion")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Usuario", System.Data.OleDb.OleDbType.VarWChar, 0, "Usuario"),
            new System.Data.OleDb.OleDbParameter("Clave", System.Data.OleDb.OleDbType.VarWChar, 0, "Clave"),
            new System.Data.OleDb.OleDbParameter("Nivel", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Nivel"),
            new System.Data.OleDb.OleDbParameter("Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, "Descripcion"),
            new System.Data.OleDb.OleDbParameter("Original_Usuario", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usuario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Clave", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Clave", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Clave", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Clave", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Nivel", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nivel", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Descripcion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Usuario", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usuario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Clave", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Clave", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Clave", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Clave", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Nivel", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nivel", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nivel", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Descripcion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Descripcion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Descripcion", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Empleados", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Usuario", "Usuario"),
                        new System.Data.Common.DataColumnMapping("Clave", "Clave"),
                        new System.Data.Common.DataColumnMapping("Nivel", "Nivel"),
                        new System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dataSet11;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(449, 92);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.ReadOnly = true;
            this.usuarioTextBox.Size = new System.Drawing.Size(83, 20);
            this.usuarioTextBox.TabIndex = 44;
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(528, 59);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 46;
            this.claveTextBox.Visible = false;
            // 
            // nivelTextBox
            // 
            this.nivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Nivel", true));
            this.nivelTextBox.Location = new System.Drawing.Point(528, 56);
            this.nivelTextBox.Name = "nivelTextBox";
            this.nivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.nivelTextBox.TabIndex = 48;
            this.nivelTextBox.Visible = false;
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.DataSource = this.empleadosBindingSource;
            this.lstEmpleados.DisplayMember = "Descripcion";
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(449, 76);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(250, 4);
            this.lstEmpleados.TabIndex = 51;
            this.lstEmpleados.Visible = false;
            this.lstEmpleados.Click += new System.EventHandler(this.lstEmpleados_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(449, 56);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(250, 20);
            this.txtEmpleado.TabIndex = 52;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        Id, Rfc1, Usuario1, Fecha_Cita, Hora_Cita, Sintomatologia, Realizad" +
                "a\r\nFROM            Consultas";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `Consultas` (`Rfc1`, `Usuario1`, `Fecha_Cita`, `Hora_Cita`, `Sintomat" +
                "ologia`, `Realizada`) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Rfc1", System.Data.OleDb.OleDbType.VarWChar, 0, "Rfc1"),
            new System.Data.OleDb.OleDbParameter("Usuario1", System.Data.OleDb.OleDbType.VarWChar, 0, "Usuario1"),
            new System.Data.OleDb.OleDbParameter("Fecha_Cita", System.Data.OleDb.OleDbType.Date, 0, "Fecha_Cita"),
            new System.Data.OleDb.OleDbParameter("Hora_Cita", System.Data.OleDb.OleDbType.Date, 0, "Hora_Cita"),
            new System.Data.OleDb.OleDbParameter("Sintomatologia", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Sintomatologia"),
            new System.Data.OleDb.OleDbParameter("Realizada", System.Data.OleDb.OleDbType.Boolean, 0, "Realizada")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Rfc1", System.Data.OleDb.OleDbType.VarWChar, 0, "Rfc1"),
            new System.Data.OleDb.OleDbParameter("Usuario1", System.Data.OleDb.OleDbType.VarWChar, 0, "Usuario1"),
            new System.Data.OleDb.OleDbParameter("Fecha_Cita", System.Data.OleDb.OleDbType.Date, 0, "Fecha_Cita"),
            new System.Data.OleDb.OleDbParameter("Hora_Cita", System.Data.OleDb.OleDbType.Date, 0, "Hora_Cita"),
            new System.Data.OleDb.OleDbParameter("Sintomatologia", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Sintomatologia"),
            new System.Data.OleDb.OleDbParameter("Realizada", System.Data.OleDb.OleDbType.Boolean, 0, "Realizada"),
            new System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Rfc1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Rfc1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Rfc1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rfc1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Usuario1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Usuario1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Usuario1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usuario1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha_Cita", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha_Cita", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha_Cita", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha_Cita", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hora_Cita", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hora_Cita", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hora_Cita", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hora_Cita", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Realizada", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Realizada", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Realizada", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Realizada", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Id", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Rfc1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Rfc1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Rfc1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rfc1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Usuario1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Usuario1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Usuario1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Usuario1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha_Cita", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha_Cita", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha_Cita", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha_Cita", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hora_Cita", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hora_Cita", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hora_Cita", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hora_Cita", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Realizada", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Realizada", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Realizada", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Realizada", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Consultas", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Rfc1", "Rfc1"),
                        new System.Data.Common.DataColumnMapping("Usuario1", "Usuario1"),
                        new System.Data.Common.DataColumnMapping("Fecha_Cita", "Fecha_Cita"),
                        new System.Data.Common.DataColumnMapping("Hora_Cita", "Hora_Cita"),
                        new System.Data.Common.DataColumnMapping("Sintomatologia", "Sintomatologia"),
                        new System.Data.Common.DataColumnMapping("Realizada", "Realizada")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.dataSet11;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(47, 252);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(30, 20);
            this.idTextBox.TabIndex = 53;
            this.idTextBox.Visible = false;
            // 
            // rfc1TextBox
            // 
            this.rfc1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Rfc1", true));
            this.rfc1TextBox.Location = new System.Drawing.Point(482, 119);
            this.rfc1TextBox.Name = "rfc1TextBox";
            this.rfc1TextBox.ReadOnly = true;
            this.rfc1TextBox.Size = new System.Drawing.Size(217, 20);
            this.rfc1TextBox.TabIndex = 55;
            // 
            // usuario1TextBox
            // 
            this.usuario1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Usuario1", true));
            this.usuario1TextBox.Location = new System.Drawing.Point(482, 145);
            this.usuario1TextBox.Name = "usuario1TextBox";
            this.usuario1TextBox.ReadOnly = true;
            this.usuario1TextBox.Size = new System.Drawing.Size(217, 20);
            this.usuario1TextBox.TabIndex = 57;
            // 
            // fecha_CitaDateTimePicker
            // 
            this.fecha_CitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "Fecha_Cita", true));
            this.fecha_CitaDateTimePicker.Enabled = false;
            this.fecha_CitaDateTimePicker.Location = new System.Drawing.Point(482, 171);
            this.fecha_CitaDateTimePicker.Name = "fecha_CitaDateTimePicker";
            this.fecha_CitaDateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.fecha_CitaDateTimePicker.TabIndex = 59;
            // 
            // sintomatologiaTextBox
            // 
            this.sintomatologiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Sintomatologia", true));
            this.sintomatologiaTextBox.Enabled = false;
            this.sintomatologiaTextBox.Location = new System.Drawing.Point(482, 223);
            this.sintomatologiaTextBox.Multiline = true;
            this.sintomatologiaTextBox.Name = "sintomatologiaTextBox";
            this.sintomatologiaTextBox.Size = new System.Drawing.Size(217, 55);
            this.sintomatologiaTextBox.TabIndex = 63;
            // 
            // hora_CitaLabel
            // 
            hora_CitaLabel.AutoSize = true;
            hora_CitaLabel.Location = new System.Drawing.Point(395, 203);
            hora_CitaLabel.Name = "hora_CitaLabel";
            hora_CitaLabel.Size = new System.Drawing.Size(54, 13);
            hora_CitaLabel.TabIndex = 63;
            hora_CitaLabel.Text = "Hora Cita:";
            // 
            // hora_CitaDateTimePicker
            // 
            this.hora_CitaDateTimePicker.CustomFormat = "HH:00";
            this.hora_CitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "Hora_Cita", true));
            this.hora_CitaDateTimePicker.Enabled = false;
            this.hora_CitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hora_CitaDateTimePicker.Location = new System.Drawing.Point(482, 197);
            this.hora_CitaDateTimePicker.Name = "hora_CitaDateTimePicker";
            this.hora_CitaDateTimePicker.ShowUpDown = true;
            this.hora_CitaDateTimePicker.Size = new System.Drawing.Size(75, 20);
            this.hora_CitaDateTimePicker.TabIndex = 64;
            this.hora_CitaDateTimePicker.Value = new System.DateTime(2012, 7, 13, 8, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(397, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "Agendar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(hora_CitaLabel);
            this.Controls.Add(this.hora_CitaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(rfc1Label);
            this.Controls.Add(this.rfc1TextBox);
            this.Controls.Add(usuario1Label);
            this.Controls.Add(this.usuario1TextBox);
            this.Controls.Add(fecha_CitaLabel);
            this.Controls.Add(this.fecha_CitaDateTimePicker);
            this.Controls.Add(sintomatologiaLabel);
            this.Controls.Add(this.sintomatologiaTextBox);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(fecha_NacLabel);
            this.Controls.Add(this.fecha_NacDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(intervencionesLabel);
            this.Controls.Add(this.intervencionesCheckBox);
            this.Controls.Add(hijosLabel);
            this.Controls.Add(this.hijosTextBox);
            this.Controls.Add(enfermedadesLabel);
            this.Controls.Add(this.enfermedadesTextBox);
            this.Controls.Add(historial_ClinicoLabel);
            this.Controls.Add(this.historial_ClinicoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(nivelLabel);
            this.Controls.Add(this.nivelTextBox);
            this.Name = "Form1";
            this.Text = "Citas Médicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        string[,] docs = new string[9, 2] { { "0", "Bolaños", }, 
                                            { "0", "Rodriguez", }, 
                                            { "0", "Marquez", }, 
                                            { "1", "Montes", }, 
                                            { "1", "Ramirez", }, 
                                            { "1", "Ordoñez", }, 
                                            { "1", "Dominguez", }, 
                                            { "2", "Rivero", }, 
                                            { "2", "Gutierrez", } };
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_NacDateTimePicker;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.CheckBox intervencionesCheckBox;
        private System.Windows.Forms.TextBox hijosTextBox;
        private System.Windows.Forms.TextBox enfermedadesTextBox;
        private System.Windows.Forms.TextBox historial_ClinicoTextBox;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox nivelTextBox;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox rfc1TextBox;
        private System.Windows.Forms.TextBox usuario1TextBox;
        private System.Windows.Forms.DateTimePicker fecha_CitaDateTimePicker;
        private System.Windows.Forms.TextBox sintomatologiaTextBox;
        private System.Windows.Forms.DateTimePicker hora_CitaDateTimePicker;
        private System.Windows.Forms.Button button2;
    }
}

