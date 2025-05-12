using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Certificado
    {
        public int Id { get; set; }
        public DateTime FechaEmision { get; set; }

        //clave foranea
        public int ParticipanteId { get; set; }

        //relaciones
        public Participante? Participante { get; set; }
    }
}
