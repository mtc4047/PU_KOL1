using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class HistoriaResponseDTO
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public bool TypAkcji { get; set; }
        public DateTime Data { get; set; }
        public string GrupaNazwa { get; set; } 
    }
}
