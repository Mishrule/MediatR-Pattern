using DemoLibrary.Commands;
using DemoLibrary.Model;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private readonly IMediator _mediator;

		public PersonController(IMediator mediator)
		{
			_mediator = mediator;
		}
		//GET: api/<PersonController>
		[HttpGet]
		public async Task<List<PersonModel>> Get()
		{
			return await _mediator.Send(new GetPersonListQuery());
		}

		[HttpGet("{id}")]
		public async Task<PersonModel> Get(int id)
		{
			return await _mediator.Send(new GetPersonByIdQuery(id));
		}

		[HttpPost]
		public async Task<PersonModel> Post([FromBody] PersonModel value)
		{
			var model = new InsertPersonCommand(value.FirstName, value.FirstName);
			return await _mediator.Send(model);
		}
	}
}
