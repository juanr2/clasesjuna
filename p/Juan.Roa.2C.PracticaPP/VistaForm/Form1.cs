using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private Curso _curso;

        public Form1()
        {
            InitializeComponent();
        }             

        #region Events

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(_curso, null))
            {
                MessageBox.Show("El curso ya fue creado");
                return;
            }

            if (!IsValidCurso())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            CreateCurso();
        }       
       

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(_curso, null))
            {
                MessageBox.Show("Debe crear un curso para visualizar los datos");
                return;
            }

            ShowData();
        }      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(_curso, null))
            {
                MessageBox.Show("Debe crear un curso antes de ingresar alumnos");
                return;
            }

            if (!IsValidAlumno())
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            CreateAlumno();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombos();
        }

        #endregion

        #region Methods 

        private void LoadCombos()
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            
            nudAnioCurso.Maximum = DateTime.Now.Year + 10;
            nudAnioCurso.Value = (decimal)DateTime.Now.Year - 1;

            nupAnio.Maximum = DateTime.Now.Year + 10;
            nupAnio.Value = (decimal)DateTime.Now.Year - 1;
        }

        private bool IsValidCurso()
        {
            return nudAnioCurso.Value > 0 &&
                   !string.IsNullOrEmpty(txtNombreProfe.Text) &&
                   !string.IsNullOrEmpty(txtApellidoProfe.Text) &&
                   !string.IsNullOrEmpty(txtDocumentoProfe.Text) &&
                   dtpFechaIngreso.Value > DateTime.MinValue;
        }

        private bool IsValidAlumno()
        {
            return nupAnio.Value > 0 &&
                   !string.IsNullOrEmpty(txtNombre.Text) &&
                   !string.IsNullOrEmpty(txtApellido.Text) &&
                   !string.IsNullOrEmpty(txtLegajo.Text);
        }

        private void CreateCurso()
        {
            short anio = (short)nudAnioCurso.Value;
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            Profesor profesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value);

            _curso = new Curso(anio, division, profesor);
            MessageBox.Show("Curso creado correctamente");
        }

        private void CreateAlumno()
        {
            short anio = (short)nupAnio.Value;
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
            Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtLegajo.Text, anio, division);

            _curso += alumno;
            MessageBox.Show("Alumno creado correctamente");
            CleanFieldsAlumno();
        }

        private void CleanFieldsAlumno()
        {
            nupAnio.Value = (short)DateTime.Now.Year - 1;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtLegajo.Text = string.Empty;                 
        }

        private void ShowData()
        {
            richTextBox1.Text = (string)_curso;
        }


        #endregion       
    }
}
