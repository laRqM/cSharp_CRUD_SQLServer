using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_.Modelo {
    public class Alumno {
        private int id_persona;
        private string primerNombre;
        private string segundoNombre;
        private string apPaterno;
        private string apMaterno;
        private string fechaNacimiento;
        private string matricula;
        private string carrera;
        private string semestre;
        private string especialidad;

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
