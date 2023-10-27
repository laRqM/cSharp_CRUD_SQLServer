using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_.Modelo {
    public class Reunion {
        private int id_persona;
        private string primerNombre;
        private string segundoNombre;
        private string apPaterno;
        private string apMaterno;
        private string matricula;
        private string semestre;
        private string especialidad;
        private int id_reunion;
        private string tema;
        private string fecha;
        private string hora;
        private string lugar;

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int Id_reunion { get => id_reunion; set => id_reunion = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Lugar { get => lugar; set => lugar = value; }
    }
}
