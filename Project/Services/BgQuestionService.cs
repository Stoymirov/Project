using Microsoft.EntityFrameworkCore;
using Project.Contracts;
using Project.Data;

namespace Project.Services
{
	public class BgQuestionService:IBgQuestionService
	{
		private readonly ApplicationDbContext context;

		public BgQuestionService(ApplicationDbContext context)
		{
			this.context = context;
		}
		public async Task<List<BgQuestion>> GetQuestionsAsync()
		{
			return await context.BgQuestions.ToListAsync();
			
		}
	}
}
