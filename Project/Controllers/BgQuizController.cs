using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Contracts;
using Project.Data;

namespace Project.Controllers
{
	public class BgQuizController : Controller
	{
		private readonly IBgQuestionService service;

		public BgQuizController(IBgQuestionService service)
		{
			this.service = service;
		}
		public async Task<IActionResult> Index()
		{
			Random random = new Random();
			int randomIndex = random.Next(data.BgQuestions.Count());
			var randomQuestion = await data.BgQuestions.ToArrayAsync()[randomIndex];


			return View(randomQuestion);
		}
	}
}
