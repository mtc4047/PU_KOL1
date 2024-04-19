using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Historia: IEntityTypeConfiguration<Historia>
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int IdGrupy { get; set; }
        public bool TypAkcji { get; set; }
        public DateTime Data {  get; set; }

        public Grupa Grupa { get; set; }
        public void Configure(EntityTypeBuilder<Historia> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(g => g.Grupa)
            .WithMany(z => z.Zdarzenia)
            .HasForeignKey(g => g.IdGrupy);
        }
    }
}
