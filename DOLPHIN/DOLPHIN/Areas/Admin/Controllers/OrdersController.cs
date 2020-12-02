using DOLPHIN.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOLPHIN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly ApplicationDBContext _context;

        public OrdersController(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var applicationDBContext = _context.Orders.Include(c => c.CreatedBy).Include(c => c.UpdatedBy).Where(x => x.Id != null).OrderByDescending(x => x.CreatedDate);
            return View(await applicationDBContext.ToListAsync());
        }
    }
}
