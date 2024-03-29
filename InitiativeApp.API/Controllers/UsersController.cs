using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InitiativeApp.API.Data;
using InitiativeApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InitiativeApp.API.Controllers
{

	[Route("api/[controller]")]
	public class UsersController : ControllerBase
	{
		private readonly IUserRepository _repo;
		private readonly IMapper _mapper;

		public UsersController(IUserRepository repo, IMapper mapper)
		{
			_mapper = mapper;
			_repo = repo;
		}



		[HttpGet]
		public async Task<IActionResult> GetUsers()
		{
			var users = await _repo.GetUsers();
			var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);
			return Ok(users);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetUser(int id)
		{
			var user = await _repo.GetUser(id);
			var userToReturn = _mapper.Map<UserForDetailedDto>(user);
			return Ok(userToReturn);
		}

	}
}