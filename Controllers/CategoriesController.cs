using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Authorize(Roles = "Admin,StoreOwner")]
    public class CategoriesController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
