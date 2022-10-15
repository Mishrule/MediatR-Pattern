using DemoLibrary.Model;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries
{
	public record GetPersonListQuery : IRequest<List<PersonModel>>
	{
	}
}
