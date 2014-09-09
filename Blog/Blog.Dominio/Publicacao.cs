using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Dominio
{
    public class Publicacao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Boolean Ativo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual List<Comentario> Comentarios { get; set; }

        public Publicacao()
        {
            Ativo = true;
            DataPublicacao = DateTime.Now;
        }
    }
}
