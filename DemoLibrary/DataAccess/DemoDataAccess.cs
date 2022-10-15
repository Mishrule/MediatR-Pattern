using DemoLibrary.Model;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
	public class DemoDataAccess : IDataAccess
	{
		private List<PersonModel> _people = new();
		public DemoDataAccess()
		{
			_people.Add(new PersonModel { Id = 1, FirstName = "Mish", LastName = "Rule" });
			_people.Add(new PersonModel { Id = 2, FirstName = "Ben", LastName = "WRule" });
		}
		public List<PersonModel> GetPeople()
		{
			return _people;
		}

		public PersonModel InsertPerson(string firstName, string lastName)
		{
			PersonModel p = new() { FirstName = firstName, LastName = lastName };
			p.Id = _people.Max(x => x.Id) + 1;
			_people.Add(p);
			return p;
		}
	}
}
