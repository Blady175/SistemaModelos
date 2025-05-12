using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Sesion
    {
        [Key]public int Id { get; set; }
        public DateTime Horario { get; set; }
        public string SalaAsignada { get; set; }

        //claves foraneas
        public int EventoId { get; set; }
        //relaciones
        public Evento? Evento { get; set; }
        public List<Ponente>? Ponentes { get; set; }
    }
}
