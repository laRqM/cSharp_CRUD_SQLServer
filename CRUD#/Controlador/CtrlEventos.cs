using CRUD_.Modelo;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_.Controlador {
    internal class CtrlEventos : db {
        private Encriptacion decrypt = new Encriptacion();

        public List<Reunion> mostrarReuniones() {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string verReunionesProcedure = configuration["Procesos:VerEventosAgendados"];

            SqlDataReader reader;
            List<Reunion> lista = new List<Reunion>();

            try {
                SqlConnection conn = base.DBConn();
                conn.Open();
                SqlCommand comando = new SqlCommand(verReunionesProcedure, conn);
                reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Reunion _reunion = new Reunion();
                    _reunion.Id_persona = reader.GetInt32(0);
                    _reunion.PrimerNombre = decrypt.Desencriptar(reader[1].ToString());
                    _reunion.SegundoNombre = reader[2].ToString();
                    _reunion.ApPaterno = reader[3].ToString();
                    _reunion.ApMaterno = reader[4].ToString();
                    _reunion.Matricula = reader[5].ToString();
                    _reunion.Semestre = reader[6].ToString();
                    _reunion.Especialidad = reader[7].ToString();
                    _reunion.Id_reunion = reader.GetInt32(8);
                    _reunion.Tema = reader[9].ToString();
                    _reunion.Fecha = reader[10].ToString();
                    _reunion.Hora = reader[11].ToString();
                    _reunion.Lugar = reader[12].ToString();
                    lista.Add(_reunion);
                }
            } catch (SqlException ex) {
                MessageBox.Show("Lo sentimos, ha ocurrido un error al traer los datos desde la base de datos: " + ex.Message.ToString() + "\nPor favor, contacta al personal de TI");
            }

            return lista;
        }
    }
}
