using System.Collections.Generic;

namespace boakyepieshop.Models
{
    public interface ICategoryRepository
    {
         IEnumerable<Category> Categories {get;}
    }
}