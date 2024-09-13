using Project.Data;

namespace Project.Contracts
{
	public interface IBgQuestionService
	{
		Task<List<BgQuestion>> GetQuestionsAsync();
	}
}
