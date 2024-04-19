using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Grupa: IEntityTypeConfiguration<Grupa>
    {
        public int Id { get; set; } 
        public string Nazwa { get; set; }

        public ICollection<Student> Studenci { get; set; }
        public ICollection<Historia> Zdarzenia { get; set; }

        public void Configure(EntityTypeBuilder<Grupa> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
