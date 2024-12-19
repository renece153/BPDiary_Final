using BPDiary_Final.Data;
using Microsoft.AspNetCore.Mvc;
using BPDiary_Final.Models;

namespace BPDiary_Final.Controllers
{
	public class BPRecordController : Controller
	{
			public IActionResult Index()
			{
				return View();
			}

			private ApplicationDbContext Context { get; }

			public BPRecordController(ApplicationDbContext _context)
			{
				this.Context = _context;
			}


			[HttpPost]
			public IActionResult Index(bp_diary_records bp_diary_records)
			{
				this.Context.bp_diary_records.Add(bp_diary_records);
				this.Context.SaveChanges();

				return View(bp_diary_records);
			}

	}
}
