using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSoftware2
{
    class Paciente
    {
        //public string PrimerNombre { get; set; }
        public string NombrePaciente { get; set; }

        private long numeroDocumento;

        public TipoDocumento TipoDocumento { get; set; }


        public Rango Rango { get; set; }


        public long costoServicio { get; set; }

    }
}
