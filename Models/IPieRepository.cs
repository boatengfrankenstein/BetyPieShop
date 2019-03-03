using System.Collections.Generic;

namespace boakyepieshop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies {get;}
        IEnumerable<Pie> PiesOfTheWeek{get;}

        Pie GetPieById(int pieId);
         
    }
}