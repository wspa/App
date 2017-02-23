using Coach.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach.Infra.Mapping
{
    public class ConteudoMap : EntityTypeConfiguration<Conteudo>
    {
        public ConteudoMap()
        {
            ToTable("Conteudo");
            HasKey(x => x.Id);            
        }
    }
}
