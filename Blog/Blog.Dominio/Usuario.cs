using System;
using System.Collections.Generic;

namespace Blog.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Boolean Ativo { get; set; }
        public virtual List<Publicacao> Publicacoes { get; set; }
    }
}
