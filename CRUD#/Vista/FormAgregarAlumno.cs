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
    public partial class FormAgregarAlumno : Form {
        private Form2 form2;
        private Alumno alumno;
        Encriptacion encrypt = new Encriptacion();
        public event Action AlumnoAgregado;

        public FormAgregarAlumno(Form2 form2) {
            InitializeComponent();
            this.form2 = form2;
        }

        private void btnCerrarIngresarAlumno_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnGuardarIngresarAlumno_Click(object sender, EventArgs e) {
            alumno = new Alumno();

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
            controladorAlumno.AgregarDatos(alumno);
            AlumnoAgregado?.Invoke();
            this.Close();
        }
    }
}
