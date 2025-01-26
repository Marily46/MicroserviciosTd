﻿using Microsoft.EntityFrameworkCore;
using TiendaServicio.Api.Autor.Modelo;

namespace TiendaServicio.Api.Autor.Persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options) { }

        public DbSet<AutorLibro> AutorLibro { get; set; }
        public DbSet<GradoAcademico> GradoAcademico { get; set; }

    }
}
