using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Model
{
    public class Student:IEntityTypeConfiguration<Student>
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IdGrupy { get; set; }

        public Grupa Grupa { get; set; }

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(g => g.Grupa)
                .WithMany(s => s.Studenci)
                .HasForeignKey(g => g.IdGrupy);
        }
    }
}
