using CRUD_.Controlador;
using CRUD_.Modelo;
using CRUD_.Vista;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace CRUD_ {
    public partial class Form2 : Form {
        private CtrlAlumno ctrlAlumno;

        public Form2() { // Constructor de la clase.
            InitializeComponent(); // Inicializamos los componentes.
            txtBuscarAlumno.TextChanged += txtBuscarAlumno_TextChanged;
            menuEditarAlumno.Click += menuEditarAlumno_Click;
            //menuEliminarAlumno.Click += menuEliminarAlumno_Click;
            dataGridView1.ColumnCount = 10; // Establece el número de columnas en el DataGridView.

            // Configuramos los encabezados de las columnas
            dataGridView1.Columns[0].Name = "Identificador";
            dataGridView1.Columns[1].Name = "Primer Nombre";
            dataGridView1.Columns[2].Name = "Segundo Nombre";
            dataGridView1.Columns[3].Name = "Apellido Paterno";
            dataGridView1.Columns[4].Name = "Apellido Materno";
            dataGridView1.Columns[5].Name = "Fecha de Nacimiento";
            dataGridView1.Columns[6].Name = "Matrícula";
            dataGridView1.Columns[7].Name = "Carrera";
            dataGridView1.Columns[8].Name = "Semestre";
            dataGridView1.Columns[9].Name = "Especialidad";

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;

            ctrlAlumno = new CtrlAlumno(this);
            CargarDatos();
        }

        public void CargarDatos() {
            List<Alumno> lista = ctrlAlumno.mostrarAlumnos();

            dataGridView1.Rows.Clear();

            foreach (Alumno alumno in lista) {
                dataGridView1.Rows.Add(alumno.Id_persona, alumno.PrimerNombre, alumno.SegundoNombre, alumno.ApPaterno, alumno.ApMaterno, alumno.FechaNacimiento, alumno.Matricula, alumno.Carrera, alumno.Semestre, alumno.Especialidad);
            }
        }

        private void FiltrarAlumnos(string filtro) {
            List<Alumno> listaCompleta = ctrlAlumno.mostrarAlumnos(); // Obtenemos una lista completa de alumnos.

            List<Alumno> listaFiltrada = listaCompleta // Filtramos la lista según el texto ingresado en txtBuscarAlumno.
                .Where(alumno =>
                    alumno.PrimerNombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) || // Comparación sin distinción de mayúsculas y minúsculas
                    alumno.SegundoNombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.ApPaterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.ApMaterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.FechaNacimiento.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Matricula.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Carrera.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Semestre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Especialidad.Contains(filtro, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();

            dataGridView1.Rows.Clear(); // Actualizamos el DataGridView con la lista filtrada.

            foreach (Alumno alumno in listaFiltrada) {
                dataGridView1.Rows.Add(alumno.Id_persona, alumno.PrimerNombre, alumno.SegundoNombre, alumno.ApPaterno, alumno.ApMaterno, alumno.FechaNacimiento, alumno.Matricula, alumno.Carrera, alumno.Semestre, alumno.Especialidad);
            }
        }

        private void txtBuscarAlumno_TextChanged(object sender, EventArgs e) {
            string filtro = txtBuscarAlumno.Text;
            FiltrarAlumnos(filtro);
        }

        private void menuEditarAlumno_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;
                string idPersona = dataGridView1.Rows[filaSeleccionada].Cells["Identificador"].Value.ToString();
                CtrlAlumno controladorAlumno = new CtrlAlumno(this);
                Alumno alumno = controladorAlumno.ObtenerAlumnoPorId(int.Parse(idPersona));

                FormEditarAlumno editarAlumno = new FormEditarAlumno(alumno, this, dataGridView1);
                DialogResult result = editarAlumno.ShowDialog();

                if (result == DialogResult.OK) {
                    Alumno alumnoActualizado = editarAlumno.AlumnoActualizado;
                    if (alumnoActualizado != null) {
                        alumno = controladorAlumno.ActualizarDatos(alumnoActualizado);
                        if (alumno != null) {
                            //dataGridView1.Update();
                        }
                    }
                }
            }
            else {
                MessageBox.Show("No se ha seleccionado ninguna fila para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) {
                contextMenuStrip1.Show(dataGridView1, e.Location);
            }
        }

        private void menuEliminarAlumno_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                int filaSeleccionada = dataGridView1.SelectedRows[0].Index;

                string idPersona = dataGridView1.Rows[filaSeleccionada].Cells["Identificador"].Value.ToString();
                CtrlAlumno controladorAlumno = new CtrlAlumno(this);
                controladorAlumno.EliminarDatos(int.Parse(idPersona));
            } else {
                MessageBox.Show("No se ha seleccionado ninguna fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e) {
            FormAgregarAlumno agregarAlumno = new FormAgregarAlumno(this);
            DialogResult result = agregarAlumno.ShowDialog();
        }
    }
}
