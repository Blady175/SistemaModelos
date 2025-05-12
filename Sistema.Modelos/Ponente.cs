using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Ponente
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        //claves foraneas
        public int EventoId { get; set; }

        //relaciones
        public Evento? Evento { get; set; }
    }
}
