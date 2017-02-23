using Coach.Domain.Model;
using Coach.Infra.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coach.Infra.DataContext
{
    public class CoachDataContext : DbContext
    {
        public CoachDataContext() : base("Coach_Context")
        {
            Database.SetInitializer<CoachDataContext>(new CoachDataContextInitializer());
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Conteudo> Conteudo { get; set; }
        public DbSet<Contato> Contato { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new ConteudoMap());

            base.OnModelCreating(modelBuilder);
        }

        public class CoachDataContextInitializer : DropCreateDatabaseIfModelChanges<CoachDataContext>
        {
            protected override void Seed(CoachDataContext context)
            {
                context.Conteudo.Add(new Conteudo { Id = 1, Texto = "Teste" });

                base.Seed(context);

                context.SaveChanges();
            }
        }
    }
}
