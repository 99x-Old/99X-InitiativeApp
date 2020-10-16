using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Data;
using InitiativeApp.API.Dtos;
using InitiativeApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace InitiativeApp.API.Controllers
{
	[Route("api/[controller]")]
    public class InitiativeController :  ControllerBase
    {
        private readonly IInitiativeRepository _repo;
		private readonly IMapper _mapper;

		public InitiativeController(IInitiativeRepository repo, IMapper mapper)
		{
			_mapper = mapper;
			_repo = repo;
		}
            
		[HttpPost]
		public async Task<IActionResult> AddInitiative(InitiativeForListDto initiative)
		{
            var createdInitiative = await _repo.AddInitiative(initiative);
			return Ok(createdInitiative);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteInitiative(int id)
		{
            var deletedInitiative = await _repo.DeleteInitiative(id);
			return Ok(deletedInitiative);
		}
		
		[HttpGet]
		public async Task<IActionResult> GetInitiatives()
		{
			var initiatives = await _repo.GetInitiatives();
			var initiativesToReturn = _mapper.Map<IEnumerable<InitiativeForListDto>>(initiatives);
			return Ok(initiativesToReturn);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetInitiative(int id)
		{
			var initiative = await _repo.GetInitiative(id);
			var initiativeToReturn = _mapper.Map<InitiativeForDetailedDto>(initiative);
			return Ok(initiativeToReturn);
		}

    }
}