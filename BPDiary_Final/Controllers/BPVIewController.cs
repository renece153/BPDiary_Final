using BPDiary_Final.Data;
using BPDiary_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace BPDiary_Final.Controllers
{
	public class BPVIewController : Controller
	{
		readonly ApplicationDbContext _db;
		public BPVIewController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			List<bp_diary_records> objPriceList;

			objPriceList = _db.bp_diary_records.ToList();

			return View(objPriceList);
		}
	}
}
