using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }
        IEnumerator<Pie> PiesOfTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}
