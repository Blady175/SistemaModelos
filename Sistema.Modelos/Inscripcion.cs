using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Inscripcion
    {
        [Key]public int Id { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInscripcion { get; set; }

        //claves foraneas
        public int EventoId { get; set; }
        public int ParticipanteId { get; set; }


        //relaciones
        public Evento? Evento { get; set; }
        public Participante? Participante { get; set; }
        public List<Pago>? Pagos { get; set; }

    }
}
