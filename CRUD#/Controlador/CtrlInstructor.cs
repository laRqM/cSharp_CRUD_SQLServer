using CRUD_.Modelo;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_.Controlador {
    internal class CtrlInstructor : db {
        private Encriptacion decrypt = new Encriptacion();

        public List<Instructor> mostrarInstructores() {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string verInstructoresProcedure = configuration["Procesos:VerInstructores"];

            SqlDataReader reader;
            List<Instructor> lista = new List<Instructor>();

            try {
                SqlConnection conn = base.DBConn();
                conn.Open();
                SqlCommand comando = new SqlCommand(verInstructoresProcedure, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Instructor _instructor = new Instructor();
                    _instructor.Id_persona = reader.GetInt32(0);
                    _instructor.PrimerNombre = decrypt.Desencriptar(reader[1].ToString());
                    _instructor.SegundoNombre = reader[2].ToString();
                    _instructor.ApPaterno = reader[3].ToString();
                    _instructor.ApMaterno = reader[4].ToString();
                    _instructor.FechaNacimiento = reader[5].ToString();
                    _instructor.Folio = reader[6].ToString();
                    lista.Add(_instructor);
                }
            } catch (SqlException ex) {
                MessageBox.Show("Lo sentimos, ha ocurrido un error al traer los datos desde la base de datos: " + ex.Message.ToString() + "\nPor favor, contacta al personal de TI");
            }

            return lista;
        }

        public void ActualizarDatos()
        {

        }

        public void AgregarDatos()
        {

        }

        public void EliminarDatos()
        {

        }
    }
}
