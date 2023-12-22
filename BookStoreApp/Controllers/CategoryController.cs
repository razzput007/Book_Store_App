using BookStoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Models;
namespace BookStoreApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList= _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString()) {
            //    ModelState.AddModelError("name", "The Display Order name cannot be same as categoty name ");
            //}
            //if (obj.Name!=null &&  obj.Name.ToLower() == "test")
            //{
            //    ModelState.AddModelError("", "The value is invalid");
            //}
            if(ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
           
        }
    }
}
