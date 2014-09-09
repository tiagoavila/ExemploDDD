using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Dominio
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Boolean Ativo { get; set; }
        public virtual Publicacao Publicacao { get; set; }
    }
}
