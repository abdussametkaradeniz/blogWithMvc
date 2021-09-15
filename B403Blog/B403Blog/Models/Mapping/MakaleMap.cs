using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace B403Blog.Models.Mapping
{
    public class MakaleMap : EntityTypeConfiguration<Makale>
    {
        public MakaleMap()
        {
            // Primary Key
            this.HasKey(t => t.MakaleId);

            // Properties
            this.Property(t => t.Baslik)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Icerik)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Makale");
            this.Property(t => t.MakaleId).HasColumnName("MakaleId");
            this.Property(t => t.Baslik).HasColumnName("Baslik");
            this.Property(t => t.Icerik).HasColumnName("Icerik");
            this.Property(t => t.EklenmeTarihi).HasColumnName("EklenmeTarihi");
            this.Property(t => t.KategoriId).HasColumnName("KategoriId");
            this.Property(t => t.GoruntulenmeSayisi).HasColumnName("GoruntulenmeSayisi");
            this.Property(t => t.Begeni).HasColumnName("Begeni");
            this.Property(t => t.YazarId).HasColumnName("YazarId");
            this.Property(t => t.ResimID).HasColumnName("ResimID");

            // Relationships
            this.HasRequired(t => t.Kategori)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.KategoriId);
            this.HasOptional(t => t.Resim)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.ResimID);
            this.HasRequired(t => t.Yazar)
                .WithMany(t => t.Makales)
                .HasForeignKey(d => d.YazarId);

        }
    }
}
