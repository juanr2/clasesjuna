namespace VistaForm
{
    partial class Form1
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblDocumentoProfe = new System.Windows.Forms.Label();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.lblFechaIngr = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.nupAnio = new System.Windows.Forms.NumericUpDown();
            this.gpbDatosCurso = new System.Windows.Forms.GroupBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gpbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnio)).BeginInit();
            this.gpbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(19, 196);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 50);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(250, 196);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(122, 50);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(131, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 50);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(126, 101);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(166, 20);
            this.txtApellidoProfe.TabIndex = 5;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(126, 75);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(166, 20);
            this.txtNombreProfe.TabIndex = 6;
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(126, 127);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(166, 20);
            this.txtDocumentoProfe.TabIndex = 7;
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(16, 75);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 8;
            this.lblNombreProfe.Text = "Nombre";
            this.lblNombreProfe.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(16, 101);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 9;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblDocumentoProfe
            // 
            this.lblDocumentoProfe.AutoSize = true;
            this.lblDocumentoProfe.Location = new System.Drawing.Point(16, 127);
            this.lblDocumentoProfe.Name = "lblDocumentoProfe";
            this.lblDocumentoProfe.Size = new System.Drawing.Size(26, 13);
            this.lblDocumentoProfe.TabIndex = 10;
            this.lblDocumentoProfe.Text = "DNI";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(16, 50);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 11;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(16, 25);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 12;
            this.lblAnioCurso.Text = "Año";
            // 
            // lblFechaIngr
            // 
            this.lblFechaIngr.AutoSize = true;
            this.lblFechaIngr.Location = new System.Drawing.Point(16, 159);
            this.lblFechaIngr.Name = "lblFechaIngr";
            this.lblFechaIngr.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngr.TabIndex = 13;
            this.lblFechaIngr.Text = "Ingreso";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(161, 56);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(166, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(161, 82);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(166, 20);
            this.txtLegajo.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(71, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(71, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(71, 85);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 19;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(71, 110);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 20;
            this.lblAnio.Text = "Año";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(71, 140);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 21;
            this.lblDivision.Text = "Division";
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(126, 42);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionCurso.TabIndex = 22;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(161, 137);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbDivision.TabIndex = 23;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(126, 159);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(210, 20);
            this.dtpFechaIngreso.TabIndex = 24;
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.nupAnio);
            this.gpbDatosAlumno.Controls.Add(this.cmbDivision);
            this.gpbDatosAlumno.Controls.Add(this.lblDivision);
            this.gpbDatosAlumno.Controls.Add(this.lblAnio);
            this.gpbDatosAlumno.Controls.Add(this.lblLegajo);
            this.gpbDatosAlumno.Controls.Add(this.lblApellido);
            this.gpbDatosAlumno.Controls.Add(this.lblNombre);
            this.gpbDatosAlumno.Controls.Add(this.txtLegajo);
            this.gpbDatosAlumno.Controls.Add(this.txtApellido);
            this.gpbDatosAlumno.Controls.Add(this.txtNombre);
            this.gpbDatosAlumno.Controls.Add(this.btnAgregar);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(440, 15);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(336, 262);
            this.gpbDatosAlumno.TabIndex = 25;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Alumno";
            // 
            // nupAnio
            // 
            this.nupAnio.Location = new System.Drawing.Point(161, 108);
            this.nupAnio.Name = "nupAnio";
            this.nupAnio.Size = new System.Drawing.Size(85, 20);
            this.nupAnio.TabIndex = 26;
            // 
            // gpbDatosCurso
            // 
            this.gpbDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gpbDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gpbDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.lblFechaIngr);
            this.gpbDatosCurso.Controls.Add(this.lblAnioCurso);
            this.gpbDatosCurso.Controls.Add(this.lblDivisionCurso);
            this.gpbDatosCurso.Controls.Add(this.lblDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.lblNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gpbDatosCurso.Controls.Add(this.txtNombreProfe);
            this.gpbDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gpbDatosCurso.Controls.Add(this.btnMostrar);
            this.gpbDatosCurso.Controls.Add(this.btnCrear);
            this.gpbDatosCurso.Location = new System.Drawing.Point(10, 21);
            this.gpbDatosCurso.Name = "gpbDatosCurso";
            this.gpbDatosCurso.Size = new System.Drawing.Size(399, 255);
            this.gpbDatosCurso.TabIndex = 26;
            this.gpbDatosCurso.TabStop = false;
            this.gpbDatosCurso.Text = "Datos Curso";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(126, 16);
            this.nudAnioCurso.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAnioCurso.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(85, 20);
            this.nudAnioCurso.TabIndex = 25;
            this.nudAnioCurso.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 282);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(766, 236);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 530);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gpbDatosCurso);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);      
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAnio)).EndInit();
            this.gpbDatosCurso.ResumeLayout(false);
            this.gpbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.TextBox txtDocumentoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblDocumentoProfe;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.Label lblFechaIngr;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.NumericUpDown nupAnio;
        private System.Windows.Forms.GroupBox gpbDatosCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

