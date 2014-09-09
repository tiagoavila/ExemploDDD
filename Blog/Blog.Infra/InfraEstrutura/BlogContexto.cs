using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Blog.Dominio;

namespace Blog.Infra.InfraEstrutura
{
    public class BlogContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Publicacao> Publicacao { get; set; }
        public DbSet<Comentario> Comentario { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
