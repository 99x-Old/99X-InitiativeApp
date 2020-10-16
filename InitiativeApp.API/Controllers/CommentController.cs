using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Data;
using InitiativeApp.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InitiativeApp.API.Controllers
{
	[Route("api/[controller]")]
	public class CommentController : ControllerBase
	{
		private readonly ICommentRepository _repo;
		private readonly IMapper _mapper;

		public CommentController(ICommentRepository repo, IMapper mapper)
		{
			_repo = repo;
			_mapper = mapper;
		}

		[HttpPost]
		public async Task<IActionResult> AddComment(CommentsDto commentDto)
		{
			var newComment = await _repo.AddComment(commentDto);
			return Ok(newComment);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteComment(int id)
		{
			var deletedComment = await _repo.DeleteComment(id);
			return Ok(deletedComment);
		}

		[HttpGet]
		public async Task<IActionResult> GetComments()
		{
			var comments = await _repo.GetComments();
			var commentsToReturn = _mapper.Map<IEnumerable<CommentsDto>>(comments);
			return Ok(commentsToReturn);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetComment(int id)
		{
			var comment = await _repo.GetComment(id);
			var commentToReturn = _mapper.Map<InitiativeForDetailedDto>(comment);
			return Ok(commentToReturn);
		}

	}
}