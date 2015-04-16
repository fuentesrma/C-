namespace CitaMedica
{
    partial class Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rfcLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label fecha_NacLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label intervencionesLabel;
            System.Windows.Forms.Label hijosLabel;
            System.Windows.Forms.Label enfermedadesLabel;
            System.Windows.Forms.Label historial_ClinicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet11 = new CitaMedica.DataSet1();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rfcTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_NacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.intervencionesCheckBox = new System.Windows.Forms.CheckBox();
            this.hijosTextBox = new System.Windows.Forms.TextBox();
            this.enfermedadesTextBox = new System.Windows.Forms.TextBox();
            this.historial_ClinicoTextBox = new System.Windows.Forms.TextBox();
            rfcLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            fecha_NacLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            intervencionesLabel = new System.Windows.Forms.Label();
            hijosLabel = new System.Windows.Forms.Label();
            enfermedadesLabel = new System.Windows.Forms.Label();
            historial_ClinicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).BeginInit();
            this.pacientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rfcLabel
            // 
            rfcLabel.AutoSize = true;
            rfcLabel.Location = new System.Drawing.Point(12, 43);
            rfcLabel.Name = "rfcLabel";
            rfcLabel.Size = new System.Drawing.Size(27, 13);
            rfcLabel.TabIndex = 1;
            rfcLabel.Text = "Rfc:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 95);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 121);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // fecha_NacLabel
            // 
            fecha_NacLabel.AutoSize = true;
            fecha_NacLabel.Location = new System.Drawing.Point(12, 148);
            fecha_NacLabel.Name = "fecha_NacLabel";
            fecha_NacLabel.Size = new System.Drawing.Size(63, 13);
            fecha_NacLabel.TabIndex = 9;
            fecha_NacLabel.Text = "Fecha Nac:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(12, 173);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // intervencionesLabel
            // 
            intervencionesLabel.AutoSize = true;
            intervencionesLabel.Location = new System.Drawing.Point(12, 201);
            intervencionesLabel.Name = "intervencionesLabel";
            intervencionesLabel.Size = new System.Drawing.Size(80, 13);
            intervencionesLabel.TabIndex = 13;
            intervencionesLabel.Text = "Intervenciones:";
            // 
            // hijosLabel
            // 
            hijosLabel.AutoSize = true;
            hijosLabel.Location = new System.Drawing.Point(12, 229);
            hijosLabel.Name = "hijosLabel";
            hijosLabel.Size = new System.Drawing.Size(33, 13);
            hijosLabel.TabIndex = 15;
            hijosLabel.Text = "Hijos:";
            // 
            // enfermedadesLabel
            // 
            enfermedadesLabel.AutoSize = true;
            enfermedadesLabel.Location = new System.Drawing.Point(12, 255);
            enfermedadesLabel.Name = "enfermedadesLabel";
            enfermedadesLabel.Size = new System.Drawing.Size(78, 13);
            enfermedadesLabel.TabIndex = 17;
            enfermedadesLabel.Text = "Enfermedades:";
            // 
            // historial_ClinicoLabel
            // 
            historial_ClinicoLabel.AutoSize = true;
            historial_ClinicoLabel.Location = new System.Drawing.Point(12, 281);
            historial_ClinicoLabel.Name = "historial_ClinicoLabel";
            historial_ClinicoLabel.Size = new System.Drawing.Size(81, 13);
            historial_ClinicoLabel.TabIndex = 19;
            historial_ClinicoLabel.Text = "Historial Clinico:";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Rfc, Nombre, Direccion, Telefono, Fecha_Nac, Sexo, Intervenciones, " +
                "Hijos, Enfermedades, Historial_Clinico\r\nFROM            Pacientes";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Material\\Usuarios.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Pacientes` (`Rfc`, `Nombre`, `Direccion`, `Telefono`, `Fecha_Nac`, `" +
                "Sexo`, `Intervenciones`, `Hijos`, `Enfermedades`, `Historial_Clinico`) VALUES (?" +
                ", ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, "Rfc"),
            new System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"),
            new System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"),
            new System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"),
            new System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, "Fecha_Nac"),
            new System.Data.OleDb.OleDbParameter("Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, "Sexo"),
            new System.Data.OleDb.OleDbParameter("Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, "Intervenciones"),
            new System.Data.OleDb.OleDbParameter("Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Hijos"),
            new System.Data.OleDb.OleDbParameter("Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, "Enfermedades"),
            new System.Data.OleDb.OleDbParameter("Historial_Clinico", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Historial_Clinico")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, "Rfc"),
            new System.Data.OleDb.OleDbParameter("Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "Nombre"),
            new System.Data.OleDb.OleDbParameter("Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, "Direccion"),
            new System.Data.OleDb.OleDbParameter("Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, "Telefono"),
            new System.Data.OleDb.OleDbParameter("Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, "Fecha_Nac"),
            new System.Data.OleDb.OleDbParameter("Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, "Sexo"),
            new System.Data.OleDb.OleDbParameter("Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, "Intervenciones"),
            new System.Data.OleDb.OleDbParameter("Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Hijos"),
            new System.Data.OleDb.OleDbParameter("Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, "Enfermedades"),
            new System.Data.OleDb.OleDbParameter("Historial_Clinico", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Historial_Clinico"),
            new System.Data.OleDb.OleDbParameter("Original_Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rfc", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Sexo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Intervenciones", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hijos", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Enfermedades", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Rfc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rfc", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nombre", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Direccion", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Direccion", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Direccion", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Telefono", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Telefono", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefono", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha_Nac", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha_Nac", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha_Nac", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Sexo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Sexo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sexo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Intervenciones", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Intervenciones", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Intervenciones", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hijos", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hijos", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hijos", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Enfermedades", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Enfermedades", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Enfermedades", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Pacientes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Rfc", "Rfc"),
                        new System.Data.Common.DataColumnMapping("Nombre", "Nombre"),
                        new System.Data.Common.DataColumnMapping("Direccion", "Direccion"),
                        new System.Data.Common.DataColumnMapping("Telefono", "Telefono"),
                        new System.Data.Common.DataColumnMapping("Fecha_Nac", "Fecha_Nac"),
                        new System.Data.Common.DataColumnMapping("Sexo", "Sexo"),
                        new System.Data.Common.DataColumnMapping("Intervenciones", "Intervenciones"),
                        new System.Data.Common.DataColumnMapping("Hijos", "Hijos"),
                        new System.Data.Common.DataColumnMapping("Enfermedades", "Enfermedades"),
                        new System.Data.Common.DataColumnMapping("Historial_Clinico", "Historial_Clinico")})});
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
            // pacientesBindingNavigator
            // 
            this.pacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacientesBindingNavigator.BindingSource = this.pacientesBindingSource;
            this.pacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pacientesBindingNavigatorSaveItem});
            this.pacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacientesBindingNavigator.Name = "pacientesBindingNavigator";
            this.pacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacientesBindingNavigator.Size = new System.Drawing.Size(369, 25);
            this.pacientesBindingNavigator.TabIndex = 0;
            this.pacientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pacientesBindingNavigatorSaveItem
            // 
            this.pacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientesBindingNavigatorSaveItem.Image")));
            this.pacientesBindingNavigatorSaveItem.Name = "pacientesBindingNavigatorSaveItem";
            this.pacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacientesBindingNavigatorSaveItem_Click);
            // 
            // rfcTextBox
            // 
            this.rfcTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Rfc", true));
            this.rfcTextBox.Location = new System.Drawing.Point(99, 40);
            this.rfcTextBox.Name = "rfcTextBox";
            this.rfcTextBox.Size = new System.Drawing.Size(200, 20);
            this.rfcTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(99, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(99, 92);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(99, 118);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // fecha_NacDateTimePicker
            // 
            this.fecha_NacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "Fecha_Nac", true));
            this.fecha_NacDateTimePicker.Location = new System.Drawing.Point(99, 144);
            this.fecha_NacDateTimePicker.Name = "fecha_NacDateTimePicker";
            this.fecha_NacDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_NacDateTimePicker.TabIndex = 10;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(99, 170);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexoTextBox.TabIndex = 12;
            // 
            // intervencionesCheckBox
            // 
            this.intervencionesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pacientesBindingSource, "Intervenciones", true));
            this.intervencionesCheckBox.Location = new System.Drawing.Point(99, 196);
            this.intervencionesCheckBox.Name = "intervencionesCheckBox";
            this.intervencionesCheckBox.Size = new System.Drawing.Size(200, 24);
            this.intervencionesCheckBox.TabIndex = 14;
            this.intervencionesCheckBox.Text = "checkBox1";
            this.intervencionesCheckBox.UseVisualStyleBackColor = true;
            // 
            // hijosTextBox
            // 
            this.hijosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Hijos", true));
            this.hijosTextBox.Location = new System.Drawing.Point(99, 226);
            this.hijosTextBox.Name = "hijosTextBox";
            this.hijosTextBox.Size = new System.Drawing.Size(200, 20);
            this.hijosTextBox.TabIndex = 16;
            // 
            // enfermedadesTextBox
            // 
            this.enfermedadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Enfermedades", true));
            this.enfermedadesTextBox.Location = new System.Drawing.Point(99, 252);
            this.enfermedadesTextBox.Name = "enfermedadesTextBox";
            this.enfermedadesTextBox.Size = new System.Drawing.Size(200, 20);
            this.enfermedadesTextBox.TabIndex = 18;
            // 
            // historial_ClinicoTextBox
            // 
            this.historial_ClinicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Historial_Clinico", true));
            this.historial_ClinicoTextBox.Location = new System.Drawing.Point(99, 278);
            this.historial_ClinicoTextBox.Name = "historial_ClinicoTextBox";
            this.historial_ClinicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.historial_ClinicoTextBox.TabIndex = 20;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 320);
            this.Controls.Add(rfcLabel);
            this.Controls.Add(this.rfcTextBox);
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
            this.Controls.Add(this.pacientesBindingNavigator);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).EndInit();
            this.pacientesBindingNavigator.ResumeLayout(false);
            this.pacientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.BindingNavigator pacientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rfcTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_NacDateTimePicker;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.CheckBox intervencionesCheckBox;
        private System.Windows.Forms.TextBox hijosTextBox;
        private System.Windows.Forms.TextBox enfermedadesTextBox;
        private System.Windows.Forms.TextBox historial_ClinicoTextBox;
    }
}