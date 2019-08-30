using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        //return all pies
        IEnumerable<Pie> GetAllPies();

        //To get pies by their id
        Pie GetPieById(int pieId);
    }
}
