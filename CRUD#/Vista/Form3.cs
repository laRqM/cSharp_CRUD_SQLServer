using CRUD_.Controlador;
using CRUD_.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ {
    public partial class Form3 : Form {
        private CtrlInstructor ctrlInstructor;

        public Form3() {
            InitializeComponent();
            txtBuscarInstructor.TextChanged += txtBuscarInstructor_TextChanged;
            dataGridView1.ColumnCount = 7; // Establece el número de columnas en el DataGridView.

            // Configuramos los encabezados de las columnas
            dataGridView1.Columns[0].Name = "Identificador";
            dataGridView1.Columns[1].Name = "Primer Nombre";
            dataGridView1.Columns[2].Name = "Segundo Nombre";
            dataGridView1.Columns[3].Name = "Apellido Paterno";
            dataGridView1.Columns[4].Name = "Apellido Materno";
            dataGridView1.Columns[5].Name = "Fecha de Nacimiento";
            dataGridView1.Columns[6].Name = "Folio";

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;

            ctrlInstructor = new CtrlInstructor();
            CargarDatos();
        }

        public void CargarDatos() {
            List<Instructor> lista = ctrlInstructor.mostrarInstructores();

            dataGridView1.Rows.Clear();

            foreach (Instructor instructor in lista) {
                dataGridView1.Rows.Add(instructor.Id_persona, instructor.PrimerNombre, instructor.SegundoNombre, instructor.ApPaterno, instructor.ApMaterno, instructor.FechaNacimiento, instructor.Folio);
            }
        }

        private void FiltrarInstructores(string filtro) {
            List<Instructor> listaCompleta = ctrlInstructor.mostrarInstructores(); // Obtenemos una lista completa de alumnos.

            List<Instructor> listaFiltrada = listaCompleta // Filtramos la lista según el texto ingresado en txtBuscarAlumno.
                .Where(alumno =>
                    alumno.PrimerNombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) || // Comparación sin distinción de mayúsculas y minúsculas
                    alumno.SegundoNombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.ApPaterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.ApMaterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.FechaNacimiento.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Folio.Contains(filtro, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();

            dataGridView1.Rows.Clear(); // Actualizamos el DataGridView con la lista filtrada.

            foreach (Instructor instructor in listaFiltrada) {
                dataGridView1.Rows.Add(instructor.Id_persona, instructor.PrimerNombre, instructor.SegundoNombre, instructor.ApPaterno, instructor.ApMaterno, instructor.FechaNacimiento, instructor.Folio);
            }
        }

        private void txtBuscarInstructor_TextChanged(object sender, EventArgs e) {
            string filtro = txtBuscarInstructor.Text;
            FiltrarInstructores(filtro);
        }
    }
}
