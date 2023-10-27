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
    public partial class Form4 : Form {
        private CtrlEventos ctrlEvento;

        public Form4()
        {
            InitializeComponent();
            txtBuscarEvento.TextChanged += txtBuscarEvento_TextChanged; // Suscribir al evento TextChanged
            dataGridView1.ColumnCount = 13; // Establece el número de columnas en el DataGridView.

            // Configuramos los encabezados de las columnas
            dataGridView1.Columns[0].Name = "Identificador";
            dataGridView1.Columns[1].Name = "Primer Nombre";
            dataGridView1.Columns[2].Name = "Segundo Nombre";
            dataGridView1.Columns[3].Name = "Apellido Paterno";
            dataGridView1.Columns[4].Name = "Apellido Materno";
            dataGridView1.Columns[5].Name = "Matrícula";
            dataGridView1.Columns[6].Name = "Semestre";
            dataGridView1.Columns[7].Name = "Especialidad";
            dataGridView1.Columns[8].Name = "ID Reunión";
            dataGridView1.Columns[9].Name = "Tema";
            dataGridView1.Columns[10].Name = "Fecha";
            dataGridView1.Columns[11].Name = "Hora";
            dataGridView1.Columns[12].Name = "Lugar";

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;

            ctrlEvento = new CtrlEventos();
            CargarDatos();
        }

        public void CargarDatos()
        {
            List<Reunion> lista = ctrlEvento.mostrarReuniones();

            dataGridView1.Rows.Clear();

            foreach (Reunion reunion in lista)
            {
                dataGridView1.Rows.Add(reunion.Id_persona, reunion.PrimerNombre, reunion.SegundoNombre, reunion.ApPaterno, reunion.ApMaterno, reunion.Matricula, reunion.Semestre, reunion.Especialidad, reunion.Id_reunion, reunion.Tema, reunion.Fecha, reunion.Hora, reunion.Tema);
            }
        }

        private void FiltrarInstructores(string filtro)
        {
            List<Reunion> listaCompleta = ctrlEvento.mostrarReuniones(); // Obtenemos una lista completa de alumnos.

            List<Reunion> listaFiltrada = listaCompleta // Filtramos la lista según el texto ingresado en txtBuscarAlumno.
                .Where(alumno =>
                    alumno.PrimerNombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) || // Comparación sin distinción de mayúsculas y minúsculas
                    alumno.SegundoNombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.ApPaterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.ApMaterno.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Matricula.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Semestre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Especialidad.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Tema.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Fecha.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Hora.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    alumno.Lugar.Contains(filtro, StringComparison.OrdinalIgnoreCase)
                )
                .ToList();

            dataGridView1.Rows.Clear(); // Actualizamos el DataGridView con la lista filtrada.

            foreach (Reunion reunion in listaFiltrada)
            {
                dataGridView1.Rows.Add(reunion.Id_persona, reunion.PrimerNombre, reunion.SegundoNombre, reunion.ApPaterno, reunion.ApMaterno, reunion.Matricula, reunion.Semestre, reunion.Especialidad, reunion.Id_reunion, reunion.Tema, reunion.Fecha, reunion.Hora, reunion.Tema);
            }
        }

        private void txtBuscarEvento_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarEvento.Text;
            FiltrarInstructores(filtro);
        }
    }
}
