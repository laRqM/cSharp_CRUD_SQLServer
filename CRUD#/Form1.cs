using CRUD_.Controlador;
using CRUD_.Modelo;
//using CRUD_.Vista;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CRUD_ {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void abrirFormulario(Form formularioHijo) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelPrincipalAlumno.Controls.Add(formularioHijo);
            panelPrincipalAlumno.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnTablaAlumno_Click(object sender, EventArgs e) {
            abrirFormulario(new Form2());
        }

        private void button1_Click(object sender, EventArgs e) {
            abrirFormulario(new Form3());
        }

        private void btnEventosAgendados_Click(object sender, EventArgs e) {
            abrirFormulario(new Form4());
        }
    }
}