using BLL.DTOModels;
using BLL.ServiceInterfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_EF
{
    public class HistoriaService : IHistoriaService
    {
        private readonly DatabaseContext _context;

        public HistoriaService(DatabaseContext context)
        {
            _context = context;
        }
        public ICollection<HistoriaResponseDTO> getHistoria(int strona, int iloscNaStronie)
        {
            int skip = (strona - 1) * iloscNaStronie;
            var historia = _context.Historia.Include(x => x.Grupa).Select(h => new HistoriaResponseDTO
            {
                Id = h.Id,
                Imie = h.Imie,
                Nazwisko = h.Nazwisko,
                TypAkcji = h.TypAkcji,
                Data = h.Data,
                GrupaNazwa = h.Grupa.Nazwa
            })
            .Skip(skip)
            .Take(iloscNaStronie);
            return historia.ToList();
        }
    }
}
