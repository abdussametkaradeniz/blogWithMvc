using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using B403Blog.Models.Mapping;

namespace B403Blog.Models
{
    public partial class B403BlogContext : DbContext
    {
        static B403BlogContext()
        {
            Database.SetInitializer<B403BlogContext>(null);
        }

        public B403BlogContext()
            : base("Name=B403BlogContext")
        {
        }

        public DbSet<Etiket> Etikets { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Resim> Resims { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Yorum> Yorums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EtiketMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new ResimMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new YorumMap());
        }
    }
}
