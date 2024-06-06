using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index(int page = 1)
        {
            const int pageSize = 3;
            var products = _context.Products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var totalProducts = _context.Products.Count();
            var totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);

            ViewBag.Page = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalProducts = totalProducts;

            return View(_mapper.Map(products,new List<ProductViewModel>()));
        }
      
        [HttpPost]
        public IActionResult Edit(List<ProductViewModel> products)
        {
            foreach (var product in products)
            {
                var existingProduct = _context.Products.FirstOrDefault(p => p.ItemID == product.ItemID);
                if (existingProduct != null)
                {
                    existingProduct.Price = product.Price;
                    _context.Products.Update(existingProduct);
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
