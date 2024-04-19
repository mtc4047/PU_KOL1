﻿using BLL.DTOModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IHistoriaService
    {
        public ICollection<HistoriaResponseDTO> getHistoria(int strona, int iloscNaStronie);
    }
}
