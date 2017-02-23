using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach.Domain.Model
{
    public class Conteudo : Base
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }

        public int Categoria { get; set; }
        public string CategoriaDescricao
        {
            get
            {
                switch (Categoria)
                {
                    case 1:
                        return "";

                    case 2:
                        return "";

                    case 3:
                        return "";

                    default:
                        return "";
                }
            }
        }
    }
}
