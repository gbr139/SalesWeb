using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Models.Enums
{
    public enum SalesStatus : int


    {
          Pending = 0, // Pendente
          Billed = 1, // Faturad
          Canceled = 2 // Cancelado
    }
}
