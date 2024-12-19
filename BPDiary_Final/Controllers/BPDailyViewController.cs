using BPDiary_Final.Data;
using Microsoft.AspNetCore.Mvc;


namespace BPDiary_Final.Controllers
{
    public class BPDailyViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly DbContextDaily _context;

        public BPDailyViewController(DbContextDaily context)
        {
            _context = context;
        }

        public IActionResult LineChart()
        {
            var data = _context.bp_diary_daily_aggregate.ToList();

            return Json(data);
        }
    }
}
