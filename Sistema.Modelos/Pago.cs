using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelos
{
    public class Pago
    {
        public int Id { get; set; }
        public string MetodoPago { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }

        //claves foraneas
        public int InscripcionId { get; set; }

        //relaciones
        public Inscripcion? Inscripcion { get; set; }
    }
}
