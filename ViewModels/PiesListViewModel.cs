using System.Collections.Generic;
using boakyepieshop.Models;

namespace boakyepieshop.ViewModels
{
    public class PiesListViewModel
    {
      public IEnumerable<Pie> Pies{get; set;}
      public string CurrentCategory {get; set;}
    }
}