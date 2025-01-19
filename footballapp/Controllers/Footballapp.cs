using Microsoft.AspNetCore.Mvc;
using footballapp.Data;
using footballapp.Models;
using Microsoft.EntityFrameworkCore;

namespace footballapp.Controllers
{
	public class Footballapp : Controller
	{

		private readonly PlayerContext _context;

		public Footballapp(PlayerContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			return View(await _context.Players.ToListAsync());
		}
	}
}
