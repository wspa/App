using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach.Domain.Model
{
    public class Contato : Base
    {
        public string Assunto { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string EmailDe { get; set; }
        public string Mensagem { get; set; }
    }
}
