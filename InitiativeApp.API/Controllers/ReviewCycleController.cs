using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Data;
using InitiativeApp.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InitiativeApp.API.Controllers
{
	[Route("api/[controller]")]
	public class ReviewCycleController : ControllerBase
	{
		private readonly IReviewCycleRepository _repo;
		private readonly IMapper _mapper;

		public ReviewCycleController(IReviewCycleRepository repo, IMapper mapper)
		{
			_repo = repo;
			_mapper = mapper;
		}

		[HttpPost]
		public async Task<IActionResult> AddReviewCycle(ReviewCycleDto reviewCycleDto)
		{
			var newReviewCycle = await _repo.AddReviewCycle(reviewCycleDto);
			return Ok(newReviewCycle);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteReviewCycle(int id)
		{
			var deletedReviewCycle = await _repo.DeleteReviewCycle(id);
			return Ok(deletedReviewCycle);
		}

		[HttpGet]
		public async Task<IActionResult> GetReviewCycles()
		{
			var reviewCycles = await _repo.GetReviewCycles();
			var reviewCyclesToReturn = _mapper.Map<IEnumerable<ReviewCycleDto>>(reviewCycles);
			return Ok(reviewCyclesToReturn);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetReviewCycle(int id)
		{
			var reviewCycle = await _repo.GetReviewCycle(id);
			var reviewCycleToReturn = _mapper.Map<ReviewCycleDto>(reviewCycle);
			return Ok(reviewCycleToReturn);
		}


	}

}