using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handler
{
	public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
	{
		private readonly IDataAccess _data;

		public InsertPersonHandler(IDataAccess data)
		{
			_data = data;
		}

		public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
		}
	}
}
