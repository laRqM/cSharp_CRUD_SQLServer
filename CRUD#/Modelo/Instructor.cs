using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_.Modelo {
    public class Instructor {
        private int id_persona;
        private string primerNombre;
        private string segundoNombre;
        private string apPaterno;
        private string apMaterno;
        private string fechaNacimiento;
        private string folio;

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Folio { get => folio; set => folio = value; }
    }
}
