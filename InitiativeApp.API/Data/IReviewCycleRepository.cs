using System.Collections.Generic;
using System.Threading.Tasks;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;

namespace InitiativeApp.API.Data
{
    public interface IReviewCycleRepository
    {
        Task<ReviewCycle> AddReviewCycle(ReviewCycleDto reviewCycle);
		Task<bool> DeleteReviewCycle(int id);
		Task<bool> SaveAll();
		Task<IEnumerable<ReviewCycle>> GetReviewCycles();
		Task<ReviewCycle> GetReviewCycle(int id);
    }
}