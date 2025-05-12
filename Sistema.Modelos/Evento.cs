using System.ComponentModel.DataAnnotations;

namespace Sistema.Modelos
{
    public class Evento
    {
        [Key]public int Id { get; set; }
        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string TipoEvento { get; set; }
        public DateTime Fecha { get; set; }

        //relaciones
        public List<Ponente>? Ponentes { get; set; }
        public List<Participante>? Participantes { get; set; }
        public List<Inscripcion>? Inscripciones { get; set; }
    }
}
