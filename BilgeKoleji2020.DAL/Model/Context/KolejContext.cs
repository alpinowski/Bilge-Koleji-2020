using BilgeKoleji2020.MAPS.Maps;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.DAL.Model.Context
{
    public class KolejContext : DbContext
    {
        public KolejContext()
        {
            Database.Connection.ConnectionString = "server=.;database=BilgeKoleji2020;uid=sa;pwd=123";
            Database.SetInitializer<KolejContext>(new DropCreateDatabaseIfModelChanges<KolejContext>());
            Database.SetInitializer<KolejContext>(new SampleData());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ClassesMap());
            modelBuilder.Configurations.Add(new LessonsMap());
            modelBuilder.Configurations.Add(new LoginMap());
            modelBuilder.Configurations.Add(new PreRegisterMap());
            modelBuilder.Configurations.Add(new RegisterMap());
            modelBuilder.Configurations.Add(new StudentAccountMap());
            modelBuilder.Configurations.Add(new TeacherAccountMap());
            
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Article> Articles {get; set;}
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<PreRegister> PreRegisters { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<StudentAccount> Students { get; set; }
        public virtual DbSet<TeacherAccount> Teachers { get; set; }
          
    }
}
