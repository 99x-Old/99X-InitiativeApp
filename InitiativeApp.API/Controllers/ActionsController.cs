using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Data;
using InitiativeApp.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InitiativeApp.API.Controllers
{
	[Route("api/[controller]")]
	public class ActionsController : ControllerBase
	{
		private readonly IActionsRepository _repo;
		private readonly IMapper _mapper;

		public ActionsController(IActionsRepository repo, IMapper mapper)
		{
			_mapper = mapper;
			_repo = repo;
		}


		[HttpPost]
		public async Task<IActionResult> AddAction(ActionsDto actionsDto)
		{
			var createdAction = await _repo.AddActions(actionsDto);
			return Ok(createdAction);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAction(int id)
		{
			var deletedAction = await _repo.DeleteAction(id);
			return Ok(deletedAction);
		}

		[HttpGet]
		public async Task<IActionResult> GetActions()
		{
			var actions = await _repo.GetActions();
			var actionsToReturn = _mapper.Map<IEnumerable<ActionsDto>>(actions);
			return Ok(actionsToReturn);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAction(int id)
		{
			var action = await _repo.GetAction(id);
			var actionToReturn = _mapper.Map<InitiativeForDetailedDto>(action);
			return Ok(actionToReturn);
		}
	}
}