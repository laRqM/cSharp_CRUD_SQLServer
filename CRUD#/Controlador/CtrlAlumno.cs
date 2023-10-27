using CRUD_.Modelo;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Media.Media3D;

namespace CRUD_.Controlador {
    class CtrlAlumno : db {
        private Encriptacion decrypt = new Encriptacion();
        private Form2 form2;

        public CtrlAlumno(Form2 form2) {
            this.form2 = form2;
        }
        public List<Alumno> mostrarAlumnos() {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string verAlumnosProcedure = configuration["Procesos:VerAlumnos"];

            SqlDataReader reader;
            List<Alumno> lista = new List<Alumno>();

            try {
                SqlConnection conn = base.DBConn();
                conn.Open();
                SqlCommand comando = new SqlCommand(verAlumnosProcedure, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Alumno _alumno = new Alumno();
                    _alumno.Id_persona = reader.GetInt32(0);
                    _alumno.PrimerNombre = decrypt.Desencriptar(reader[1].ToString());
                    _alumno.SegundoNombre = reader[2].ToString();
                    _alumno.ApPaterno = reader[3].ToString();
                    _alumno.ApMaterno = reader[4].ToString();
                    _alumno.FechaNacimiento = reader[5].ToString();
                    _alumno.Matricula = reader[6].ToString();
                    _alumno.Carrera = reader[7].ToString();
                    _alumno.Semestre = reader[8].ToString();
                    _alumno.Especialidad = reader[9].ToString();
                    lista.Add(_alumno);
                }
            }
            catch (SqlException ex) {
                MessageBox.Show("Lo sentimos, ha ocurrido un error al traer los datos desde la base de datos: " + ex.Message.ToString() + "\nPor favor, contacta al personal de TI");
            }

            return lista;
        }

        public Alumno ObtenerAlumnoPorId(int idPersona) {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string verAlumnosProcedure = configuration["Procesos:ObtenerIDAlumno"];

            SqlDataReader reader;

            try {
                using (SqlConnection conn = base.DBConn()) {
                    conn.Open();

                    SqlCommand command = new SqlCommand(verAlumnosProcedure, conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idPersona", idPersona);

                    reader = command.ExecuteReader();

                    if (reader.Read()) {
                        Alumno alumno = new Alumno();
                        alumno.Id_persona = reader.GetInt32(0);
                        alumno.PrimerNombre = decrypt.Desencriptar(reader[1].ToString());
                        alumno.SegundoNombre = reader[2].ToString();
                        alumno.ApPaterno = reader[3].ToString();
                        alumno.ApMaterno = reader[4].ToString();
                        alumno.FechaNacimiento = reader[5].ToString();
                        alumno.Matricula = reader[6].ToString();
                        alumno.Carrera = reader[7].ToString();
                        alumno.Semestre = reader[8].ToString();
                        alumno.Especialidad = reader[9].ToString();
                        return alumno;
                    }
                }
            } catch (SqlException ex) {
                MessageBox.Show("Error al obtener el registro del alumno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public Alumno ActualizarDatos(Alumno alumno) {
            try {
                using(SqlConnection conexion = base.DBConn()) {
                    conexion.Open();

                    IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .Build();

                    string actualizarAlumnosProcedure = configuration["Procesos:ActualizarAlumno"];

                    using(SqlCommand cmd = new SqlCommand(actualizarAlumnosProcedure, conexion)) {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@idPersona", alumno.Id_persona);
                        cmd.Parameters.AddWithValue("@Nombre1", alumno.PrimerNombre);
                        cmd.Parameters.AddWithValue("@Nombre2", alumno.SegundoNombre);
                        cmd.Parameters.AddWithValue("@Ap1", alumno.ApPaterno);
                        cmd.Parameters.AddWithValue("@Ap2", alumno.ApMaterno);
                        cmd.Parameters.AddWithValue("@DNacimiento", alumno.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Matricula", alumno.Matricula);
                        cmd.Parameters.AddWithValue("@Carrera", alumno.Carrera);
                        cmd.Parameters.AddWithValue("@Semestre", alumno.Semestre);
                        cmd.Parameters.AddWithValue("@Especialidad", alumno.Especialidad);

                        int exito = cmd.ExecuteNonQuery();

                        if(exito > 0) {
                            MessageBox.Show("Registro actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return alumno;
                        } else {
                            MessageBox.Show("No se encontró el registro en la tabla de alumnos correspondiente al identificador especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } catch(SqlException ex) {
                MessageBox.Show("Error al intentar actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void AgregarDatos(Alumno alumno) {
            try {
                using(SqlConnection conexion = base.DBConn()) {
                    conexion.Open();

                    IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json")
                        .Build();

                    string ingresarAlumnosProcedure = configuration["Procesos:InsertarAlumnos"];

                    using (SqlCommand cmd = new SqlCommand(ingresarAlumnosProcedure, conexion)) {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre1", alumno.PrimerNombre);
                        cmd.Parameters.AddWithValue("@Nombre2", alumno.SegundoNombre);
                        cmd.Parameters.AddWithValue("@Ap1", alumno.ApPaterno);
                        cmd.Parameters.AddWithValue("@Ap2", alumno.ApMaterno);
                        cmd.Parameters.AddWithValue("@DNacimiento", alumno.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Matricula", alumno.Matricula);
                        cmd.Parameters.AddWithValue("@Carrera", alumno.Carrera);
                        cmd.Parameters.AddWithValue("@Semestre", alumno.Semestre);
                        cmd.Parameters.AddWithValue("@Especialidad", alumno.Especialidad);

                        int exito = cmd.ExecuteNonQuery();

                        if (exito > 0) {
                            MessageBox.Show("Alumno agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form2.CargarDatos();
                        } else {
                            MessageBox.Show("Ocurrió un error al intentar ejecutar la sentencia SQL de ingreso de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } catch(SqlException ex) {
                MessageBox.Show("Error al intentar ingresar el nuevo registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarDatos(int idPersona) {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes) {
                try {
                    using (SqlConnection conexion = base.DBConn()) {
                        conexion.Open();

                        IConfigurationRoot configuration = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.json")
                            .Build();

                        string eliminarAlumnosProcedure = configuration["Procesos:EliminarAlumno"];

                        using (SqlCommand cmd = new SqlCommand(eliminarAlumnosProcedure, conexion)) {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@idPersona", idPersona);

                            int exito = cmd.ExecuteNonQuery();

                            if (exito > 0) {
                                MessageBox.Show("Registro eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                form2.CargarDatos();
                            } else {
                                MessageBox.Show("No se encontró el registro con el identificador especificado en la tabla de personas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                } catch(SqlException ex) {
                    MessageBox.Show("Error al intentar borrar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
