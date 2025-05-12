using Sistema.APIConsume;
using Sistema.Modelos;

namespace Sistema.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarCertificadoLeer();
            Console.ReadLine();
        }

        private static void ProbarEventoLeer()
        {
            Crud<Evento>.EndPoint = "https://localhost:7284/api/Eventos";
            var eventos = Crud<Evento>.GetAll();
            foreach (var e in eventos)
            {
                Console.WriteLine($"Id: {e.Id}, Nombre: {e.Nombre}, Lugar: {e.Lugar}, TipoEvento: {e.TipoEvento}, Fecha: {e.Fecha}");
            }
        }
        private static void ProbarEventoCrear() 
        {
            Crud<Evento>.EndPoint = "https://localhost:7284/api/Eventos";
            var evento = Crud<Evento>.Create(new Evento
            {
                Id = 0,
                Nombre = "Evento 5",
                Lugar = "Sala C",
                TipoEvento = "Informativo",
                Fecha = DateTime.Now
            });
            evento.Nombre = "Evento 5";
            Crud<Evento>.Update(evento.Id, evento);
            var eventos = Crud<Evento>.GetAll();
            foreach (var e in eventos)
            {
                Console.WriteLine($"Id: {e.Id}, Nombre: {e.Nombre}, Lugar: {e.Lugar}, TipoEvento: {e.TipoEvento}, Fecha: {e.Fecha}");
            }  
        }
        private static void ProbarEventoEliminar() 
        {
            Crud<Evento>.EndPoint = "https://localhost:7284/api/Eventos";
            int eventoId = 6;
            bool eliminado = Crud<Evento>.Delete(eventoId);
            if (eliminado)
            {
                Console.WriteLine($"Evento con Id: {eventoId} eliminado");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar el evento con Id: {eventoId}");
            }
            var eventos = Crud<Evento>.GetAll();
            foreach (var e in eventos)
            {
                Console.WriteLine($"Id: {e.Id}, Nombre: {e.Nombre}, Lugar: {e.Lugar}, TipoEvento: {e.TipoEvento}, Fecha: {e.Fecha}");
            }
        }
        private static void ProbarEventoActualizar()
        {
            Crud<Evento>.EndPoint = "https://localhost:7284/api/Eventos";
            int eventoId = 5;
            var evento = Crud<Evento>.GetById(eventoId);
            if (evento != null)
            {
                evento.Nombre = "CursoAPI";
                evento.Lugar = "Auditorio";
                evento.TipoEvento = "Conferencia";
                evento.Fecha = DateTime.Now;

                bool actualizado = Crud<Evento>.Update(eventoId, evento);
                if (actualizado)
                {
                    Console.WriteLine($"Evento con Id {eventoId} ha sido actualizado.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar el evento con Id {eventoId}.");
                }
            }
            else
            {
                Console.WriteLine($"Evento con Id {eventoId} no encontrado.");
            }
            var eventos = Crud<Evento>.GetAll();
            foreach (var e in eventos)
            {
                Console.WriteLine($"Id: {e.Id}, Nombre: {e.Nombre}, Lugar: {e.Lugar}, TipoEvento: {e.TipoEvento}, Fecha: {e.Fecha}");
            }
        }


        private static void ProbarPonenteLeer() 
        {
            Crud<Ponente>.EndPoint = "https://localhost:7284/api/Ponentes";
            var ponentes = Crud<Ponente>.GetAll();
            foreach (var p in ponentes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }
        private static void ProbarPonenteCrear() 
        {
            Crud<Ponente>.EndPoint = "https://localhost:7284/api/Ponentes";
            var ponente = Crud<Ponente>.Create(new Ponente
            {
                Id = 0,
                Nombre = "Jessica",
                Telefono = "0992248888",
                Correo = "jessica@gmail.com",
                EventoId = 5
            });
            ponente.Nombre = "Jessica";
            Crud<Ponente>.Update(ponente.Id, ponente);
            var ponentes = Crud<Ponente>.GetAll();
            foreach (var p in ponentes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }
        private static void ProbarPonenteEliminar() 
        {
            Crud<Ponente>.EndPoint = "https://localhost:7284/api/Ponentes";
            int ponenteId = 6;
            bool eliminado = Crud<Ponente>.Delete(ponenteId);
            if (eliminado)
            {
                Console.WriteLine($"Ponente con Id: {ponenteId} eliminado");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar el ponente con Id: {ponenteId}");
            }
            var ponentes = Crud<Ponente>.GetAll();
            foreach (var p in ponentes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }
        private static void ProbarPonenteActualizar() 
        {
            Crud<Ponente>.EndPoint = "https://localhost:7284/api/Ponentes";
            int ponenteId = 5;
            var ponente = Crud<Ponente>.GetById(ponenteId);
            if (ponente != null)
            {
                ponente.Nombre = "Patricia";
                ponente.Telefono = "0992248887";
                ponente.Correo = "paty@gmail.com";

                bool actualizado = Crud<Ponente>.Update(ponenteId, ponente);
                if (actualizado)
                {
                    Console.WriteLine($"Ponente con Id: {ponenteId} ha sido actualizado.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar el ponente con Id: {ponenteId}.");
                }
            }
            else
            {
                Console.WriteLine($"Ponente con Id: {ponenteId} no encontrado.");
            }
            var ponentes = Crud<Ponente>.GetAll();
            foreach (var p in ponentes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }


        private static void ProbarSesionLeer() 
        {
            Crud<Sesion>.EndPoint = "https://localhost:7284/api/Sesiones";
            var salas = Crud<Sesion>.GetAll();
            foreach (var s in salas)
            {
                Console.WriteLine($"Id: {s.Id}, Horario: {s.Horario}, SalaAsignada: {s.SalaAsignada}, EventoId: {s.EventoId}");
            }
        }
        private static void ProbarSesionCrear() 
        {
            Crud<Sesion>.EndPoint = "https://localhost:7284/api/Sesiones";
            var sala = Crud<Sesion>.Create(new Sesion
            {
                Id = 0,
                Horario = DateTime.Now,
                SalaAsignada = "Sala E",
                EventoId = 5
            });
            sala.SalaAsignada = "Sala E";
            Crud<Sesion>.Update(sala.Id, sala);
            var salas = Crud<Sesion>.GetAll();
            foreach (var s in salas)
            {
                Console.WriteLine($"Id: {s.Id}, Horario: {s.Horario}, SalaAsignada: {s.SalaAsignada}, EventoId: {s.EventoId}");
            }
        }
        private static void ProbarSesionEliminar()
        {
            Crud<Sesion>.EndPoint = "https://localhost:7284/api/Sesiones";
            int salaId = 6;
            bool eliminado = Crud<Sesion>.Delete(salaId);
            if (eliminado)
            {
                Console.WriteLine($"Sala con Id: {salaId} eliminada");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar la sala con Id: {salaId}");
            }
            var salas = Crud<Sesion>.GetAll();
            foreach (var s in salas)
            {
                Console.WriteLine($"Id: {s.Id}, Horario: {s.Horario}, SalaAsignada: {s.SalaAsignada}, EventoId: {s.EventoId}");
            }
        }
        private static void ProbarSesionActualizar()
        {
            Crud<Sesion>.EndPoint = "https://localhost:7284/api/Sesiones";
            int salaId = 5;
            var sala = Crud<Sesion>.GetById(salaId);
            if (sala != null)
            {
                sala.Horario = DateTime.Now;
                sala.SalaAsignada = "Sala F";
                bool actualizado = Crud<Sesion>.Update(salaId, sala);
                if (actualizado)
                {
                    Console.WriteLine($"Sala con Id: {salaId} ha sido actualizada.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar la sala con Id: {salaId}.");
                }
            }
            else
            {
                Console.WriteLine($"Sala con Id: {salaId} no encontrada.");
            }
            var salas = Crud<Sesion>.GetAll();
            foreach (var s in salas)
            {
                Console.WriteLine($"Id: {s.Id}, Horario: {s.Horario}, SalaAsignada: {s.SalaAsignada}, EventoId: {s.EventoId}");
            }
        }


        private static void ProbarParticipanteLeer() 
        {
            Crud<Participante>.EndPoint = "https://localhost:7284/api/Participantes";
            var participantes = Crud<Participante>.GetAll();
            foreach (var p in participantes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }
        private static void ProbarParticipanteCrear() 
        {
            Crud<Participante>.EndPoint = "https://localhost:7284/api/Participantes";
            var participante = Crud<Participante>.Create(new Participante
            {
                Id = 0,
                Nombre = "Lizbeth",
                Telefono = "0993356676",
                Correo = "liz@gmail.com",
                EventoId = 5
            });
            participante.Nombre = "Lizbeth";
            Crud<Participante>.Update(participante.Id, participante);
            var participantes = Crud<Participante>.GetAll();
            foreach (var p in participantes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }
        private static void ProbarParticipanteEliminar()
        {
            Crud<Participante>.EndPoint = "https://localhost:7284/api/Participantes";
            int participanteId = 6;
            bool eliminado = Crud<Participante>.Delete(participanteId);
            if (eliminado)
            {
                Console.WriteLine($"Participante con Id: {participanteId} eliminado");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar el participante con Id: {participanteId}");
            }
            var participantes = Crud<Participante>.GetAll();
            foreach (var p in participantes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }
        private static void ProbarParticipanteActualizar() 
        {
            Crud<Participante>.EndPoint = "https://localhost:7284/api/Participantes";
            int participanteId = 3;
            var participante = Crud<Participante>.GetById(participanteId);
            if (participante != null)
            {
                participante.Nombre = "Paul";
                bool actualizado = Crud<Participante>.Update(participanteId, participante);
                if (actualizado)
                {
                    Console.WriteLine($"Participante con Id: {participanteId} ha sido actualizado.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar el participante con Id: {participanteId}.");
                }
            }
            else
            {
                Console.WriteLine($"Participante con Id: {participanteId} no encontrado.");
            }
            var participantes = Crud<Participante>.GetAll();
            foreach (var p in participantes)
            {
                Console.WriteLine($"Id: {p.Id}, Nombre: {p.Nombre}, Telefono: {p.Telefono}, Correo: {p.Correo}, EventoId: {p.EventoId}");
            }
        }


        private static void ProbarInscripcionLeer() 
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7284/api/Inscripciones";
            var inscripciones = Crud<Inscripcion>.GetAll();
            foreach (var i in inscripciones)
            {
                Console.WriteLine($"Id: {i.Id}, FechaInscripcion: {i.FechaInscripcion}, EventoId: {i.EventoId}, ParticipanteId: {i.ParticipanteId}");
            }
        }
        private static void ProbarInscripcionCrear()
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7284/api/Inscripciones";
            var inscripcion = Crud<Inscripcion>.Create(new Inscripcion
            {
                Id = 0,
                Estado = "Confirmado",
                FechaInscripcion = DateTime.Now,
                EventoId = 5,
                ParticipanteId = 5
            });
            inscripcion.FechaInscripcion = DateTime.Now;
            Crud<Inscripcion>.Update(inscripcion.Id, inscripcion);
            var inscripciones = Crud<Inscripcion>.GetAll();
            foreach (var i in inscripciones)
            {
                Console.WriteLine($"Id: {i.Id}, FechaInscripcion: {i.FechaInscripcion}, EventoId: {i.EventoId}, ParticipanteId: {i.ParticipanteId}");
            }
        }
        private static void ProbarInscripcionEliminar() 
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7284/api/Inscripciones";
            int inscripcionId = 6;
            bool eliminado = Crud<Inscripcion>.Delete(inscripcionId);
            if (eliminado)
            {
                Console.WriteLine($"Inscripcion con Id: {inscripcionId} eliminada");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar la inscripcion con Id: {inscripcionId}");
            }
            var inscripciones = Crud<Inscripcion>.GetAll();
            foreach (var i in inscripciones)
            {
                Console.WriteLine($"Id: {i.Id}, FechaInscripcion: {i.FechaInscripcion}, EventoId: {i.EventoId}, ParticipanteId: {i.ParticipanteId}");
            }
        }
        private static void ProbarIncripcionActualizar() 
        {
            Crud<Inscripcion>.EndPoint = "https://localhost:7284/api/Inscripciones";
            int inscripcionId = 5;
            var inscripcion = Crud<Inscripcion>.GetById(inscripcionId);
            if (inscripcion != null)
            {
                inscripcion.Estado = "Cancelado";
                bool actualizado = Crud<Inscripcion>.Update(inscripcionId, inscripcion);
                if (actualizado)
                {
                    Console.WriteLine($"Inscripcion con Id: {inscripcionId} ha sido actualizada.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar la inscripcion con Id: {inscripcionId}.");
                }
            }
            else
            {
                Console.WriteLine($"Inscripcion con Id: {inscripcionId} no encontrada.");
            }
            var inscripciones = Crud<Inscripcion>.GetAll();
            foreach (var i in inscripciones)
            {
                Console.WriteLine($"Id: {i.Id}, FechaInscripcion: {i.FechaInscripcion}, EventoId: {i.EventoId}, ParticipanteId: {i.ParticipanteId}");
            }
        }



        private static void ProbarPagoLeer() 
        {
            Crud<Pago>.EndPoint = "https://localhost:7284/api/Pagos";
            var pagos = Crud<Pago>.GetAll();
            foreach (var p in pagos)
            {
                Console.WriteLine($"Id: {p.Id}, MetodoPago: {p.MetodoPago}, Monto: {p.Monto}, Estado: {p.Estado}, InscripcionId: {p.InscripcionId}");
            }
        }
        private static void ProbarPagoCrear()
        {
            Crud<Pago>.EndPoint = "https://localhost:7284/api/Pagos";
            var pago = Crud<Pago>.Create(new Pago
            {
                Id = 0,
                MetodoPago = "Tranferencia",
                Monto = 132,
                Estado = "Confirmado",
                InscripcionId = 5
            });
            pago.Monto = 95;
            Crud<Pago>.Update(pago.Id, pago);
            var pagos = Crud<Pago>.GetAll();
            foreach (var p in pagos)
            {
                Console.WriteLine($"Id: {p.Id}, MetodoPago: {p.MetodoPago}, Monto: {p.Monto}, Estado: {p.Estado}, InscripcionId: {p.InscripcionId}");
            }
        }
        private static void ProbarPagoEliminar() 
        {
            Crud<Pago>.EndPoint = "https://localhost:7284/api/Pagos";
            int pagoId = 6;
            bool eliminado = Crud<Pago>.Delete(pagoId);
            if (eliminado)
            {
                Console.WriteLine($"Pago con Id: {pagoId} eliminado");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar el pago con Id: {pagoId}");
            }
            var pagos = Crud<Pago>.GetAll();
            foreach (var p in pagos)
            {
                Console.WriteLine($"Id: {p.Id}, MetodoPago: {p.MetodoPago}, Monto: {p.Monto}, Estado: {p.Estado}, InscripcionId: {p.InscripcionId}");
            }
        }
        private static void ProbarPagoActualizar() 
        {
            Crud<Pago>.EndPoint = "https://localhost:7284/api/Pagos";
            int pagoId = 5;
            var pago = Crud<Pago>.GetById(pagoId);
            if (pago != null)
            {
                pago.MetodoPago = "Efectivo";
                pago.Monto = 100;
                bool actualizado = Crud<Pago>.Update(pagoId, pago);
                if (actualizado)
                {
                    Console.WriteLine($"Pago con Id: {pagoId} ha sido actualizado.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar el pago con Id: {pagoId}.");
                }
            }
            else
            {
                Console.WriteLine($"Pago con Id: {pagoId} no encontrado.");
            }
            var pagos = Crud<Pago>.GetAll();
            foreach (var p in pagos)
            {
                Console.WriteLine($"Id: {p.Id}, MetodoPago: {p.MetodoPago}, Monto: {p.Monto}, Estado: {p.Estado}, InscripcionId: {p.InscripcionId}");
            }
        }


        private static void ProbarCertificadoLeer() 
        {
            Crud<Certificado>.EndPoint = "https://localhost:7284/api/Certificados";
            var certificados = Crud<Certificado>.GetAll();
            foreach (var c in certificados)
            {
                Console.WriteLine($"Id: {c.Id}, FechaEmision: {c.FechaEmision}, ParticipanteId: {c.ParticipanteId}");
            }
        }
        private static void ProbarCertificadoCrear()
        {
            Crud<Certificado>.EndPoint = "https://localhost:7284/api/Certificados";
            var certificado = Crud<Certificado>.Create(new Certificado
            {
                Id = 0,
                FechaEmision = DateTime.Now,
                ParticipanteId = 5
            });
            Crud<Certificado>.Update(certificado.Id, certificado);
            var certificados = Crud<Certificado>.GetAll();
            foreach (var c in certificados)
            {
                Console.WriteLine($"Id: {c.Id}, FechaEmision: {c.FechaEmision}, ParticipanteId: {c.ParticipanteId}");
            }
        }
        private static void ProbarCertificadoEliminar() 
        {
            Crud<Certificado>.EndPoint = "https://localhost:7284/api/Certificados";
            int certificadoId = 6;
            bool eliminado = Crud<Certificado>.Delete(certificadoId);
            if (eliminado)
            {
                Console.WriteLine($"Certificado con Id: {certificadoId} eliminado");
            }
            else
            {
                Console.WriteLine($"No se pudo eliminar el certificado con Id: {certificadoId}");
            }
            var certificados = Crud<Certificado>.GetAll();
            foreach (var c in certificados)
            {
                Console.WriteLine($"Id: {c.Id}, FechaEmision: {c.FechaEmision}, ParticipanteId: {c.ParticipanteId}");
            }
        }
        private static void ProbarCertificadoActualizar()
        {
            Crud<Certificado>.EndPoint = "https://localhost:7284/api/Certificados";
            int certificadoId = 5;
            var certificado = Crud<Certificado>.GetById(certificadoId);
            if (certificado != null)
            {
                certificado.FechaEmision = DateTime.Now;
                bool actualizado = Crud<Certificado>.Update(certificadoId, certificado);
                if (actualizado)
                {
                    Console.WriteLine($"Certificado con Id: {certificadoId} ha sido actualizado.");
                }
                else
                {
                    Console.WriteLine($"No se pudo actualizar el certificado con Id: {certificadoId}.");
                }
            }
            else
            {
                Console.WriteLine($"Certificado con Id: {certificadoId} no encontrado.");
            }
            var certificados = Crud<Certificado>.GetAll();
            foreach (var c in certificados)
            {
                Console.WriteLine($"Id: {c.Id}, FechaEmision: {c.FechaEmision}, ParticipanteId: {c.ParticipanteId}");
            }
        }
    }
}
