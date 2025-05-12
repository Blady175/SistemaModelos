using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema.Modelos;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Sistema.Modelos.Certificado> Certificados { get; set; } = default!;

    public DbSet<Sistema.Modelos.Evento> Eventos { get; set; } = default!;

    public DbSet<Sistema.Modelos.Inscripcion> Inscripciones { get; set; } = default!;

    public DbSet<Sistema.Modelos.Pago> Pagos { get; set; } = default!;

    public DbSet<Sistema.Modelos.Participante> Participantes { get; set; } = default!;

    public DbSet<Sistema.Modelos.Ponente> Ponentes { get; set; } = default!;

    public DbSet<Sistema.Modelos.Sesion> Sesiones { get; set; } = default!;
}
