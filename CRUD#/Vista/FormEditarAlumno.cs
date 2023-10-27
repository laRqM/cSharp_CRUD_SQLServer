using CRUD_.Controlador;
using CRUD_.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_.Vista {
    public partial class FormEditarAlumno : Form {
        private Alumno alumno;
        Encriptacion encrypt = new Encriptacion();
        private Form2 form2;
        private DataGridView dataGridView;

        public FormEditarAlumno(Alumno alumno, Form2 form2, DataGridView dataGridView) {
            InitializeComponent();
            this.alumno = alumno;
            this.form2 = form2;
            this.dataGridView = dataGridView;

            txtAgregarAlumnoNombreUno.Text = alumno.PrimerNombre;
            txtAgregarAlumnoNombreDos.Text = alumno.SegundoNombre;
            txtAgregarAlumnoApUno.Text = alumno.ApPaterno;
            txtAgregarAlumnoApDos.Text = alumno.ApMaterno;
            string fecha = alumno.FechaNacimiento;
            DateTime fechaNacimiento = DateTime.Parse(fecha);
            string fechaImprimir = fechaNacimiento.ToString("dd/MM/yyyy");
            txtAgregarAlumnoDNacimiento.Text = fechaImprimir;
            txtAgregarAlumnoMatricula.Text = alumno.Matricula;
            txtAgregarAlumnoCarrera.Text = alumno.Carrera;
            txtAgregarAlumnoSemestre.Text = alumno.Semestre;
            txtAgregarAlumnoEspecialidad.Text = alumno.Especialidad;
        }

        private void btnCerrarIngresarAlumno_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardarIngresarAlumno_Click(object sender, EventArgs e) {
            string nombreEncriptar = txtAgregarAlumnoNombreUno.Text;
            alumno.PrimerNombre = encrypt.Encriptar(nombreEncriptar);
            alumno.SegundoNombre = txtAgregarAlumnoNombreDos.Text;
            alumno.ApPaterno = txtAgregarAlumnoApUno.Text;
            alumno.ApMaterno = txtAgregarAlumnoApDos.Text;
            string fechaIngresada = txtAgregarAlumnoDNacimiento.Text;
            DateTime fechaNacimiento = DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Cambia el formato si es necesario
            string fechaParaBaseDeDatos = fechaNacimiento.ToString("yyyy-MM-dd");
            alumno.FechaNacimiento = fechaParaBaseDeDatos;
            alumno.Matricula = txtAgregarAlumnoMatricula.Text;
            alumno.Carrera = txtAgregarAlumnoCarrera.Text;
            alumno.Semestre = txtAgregarAlumnoSemestre.Text;
            alumno.Especialidad = txtAgregarAlumnoEspecialidad.Text;

            CtrlAlumno controladorAlumno = new CtrlAlumno(form2);
            controladorAlumno.ActualizarDatos(alumno);
            form2.CargarDatos();
            this.Close();
        }

        public Alumno AlumnoActualizado {
            get {
                Alumno alumno = new Alumno();
                alumno.PrimerNombre = txtAgregarAlumnoNombreUno.Text;
                alumno.SegundoNombre = txtAgregarAlumnoNombreDos.Text;
                alumno.ApPaterno = txtAgregarAlumnoApUno.Text;
                alumno.ApMaterno = txtAgregarAlumnoApDos.Text;
                alumno.FechaNacimiento = txtAgregarAlumnoDNacimiento.Text;
                alumno.Matricula = txtAgregarAlumnoMatricula.Text;
                alumno.Carrera = txtAgregarAlumnoCarrera.Text;
                alumno.Semestre = txtAgregarAlumnoSemestre.Text;
                alumno.Especialidad = txtAgregarAlumnoSemestre.Text;
                return alumno;
            }
        }
    }
}
