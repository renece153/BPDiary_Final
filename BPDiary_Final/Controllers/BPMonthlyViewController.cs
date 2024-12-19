using BPDiary_Final.Data;
using Microsoft.AspNetCore.Mvc;

namespace BPDiary_Final.Controllers
{
	public class BPMonthlyViewController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}


		private readonly DbContextMonthly _context;

		public BPMonthlyViewController(DbContextMonthly context)
		{
			_context = context;
		}

		public IActionResult BarChart()
        {
			var data = _context.bp_diary_monthly_aggregate.ToList();

			return Json(data);
		}
	}
}
