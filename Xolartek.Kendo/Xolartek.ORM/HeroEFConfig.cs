using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Xolartek.Core.Fortnite;

namespace Xolartek.ORM
{
    public class HeroEFConfig : EntityTypeConfiguration<Hero>
    {
        public HeroEFConfig()
        {
            ToTable("Heroes");
            HasKey<int>(s => s.Id)
                .Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            Property(s => s.Name).HasMaxLength(100);

            HasMany<SubClass>(c => c.SubClassAbilities)
                .WithRequired(s => s.Hero)
                .HasForeignKey(s => s.HeroId)
                .WillCascadeOnDelete(false);

            HasOptional(m => m.Picture);
        }
    }
}
