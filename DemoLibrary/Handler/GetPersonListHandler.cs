using DemoLibrary.DataAccess;
using DemoLibrary.Model;
using DemoLibrary.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handler
{
	public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
	{
		private readonly IDataAccess _data;

		public GetPersonListHandler(IDataAccess data)
		{
			_data = data;
		}

		public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_data.GetPeople());
		}
	}
}
