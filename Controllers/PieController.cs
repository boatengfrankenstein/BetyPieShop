using boakyepieshop.Models;
using boakyepieshop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace boakyepieshop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository){
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(){
            PiesListViewModel pieListViewModel = new PiesListViewModel();
            pieListViewModel.Pies = _pieRepository.Pies;
            pieListViewModel.CurrentCategory = "Cheese cakes";

            return View(pieListViewModel);
        }
    }
}