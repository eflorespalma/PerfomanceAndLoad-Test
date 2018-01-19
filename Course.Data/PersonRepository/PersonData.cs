using Course.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Course.Data.PersonRepository
{
    public class PersonData
    {
        readonly DatabaseService _databaseService;

        public PersonData()
        {
            _databaseService = new DatabaseService();
        }

        public List<Person> GetAll()
        {

            return _databaseService.Person.ToList();
        }

        public Person GetPerson(int Id)
        {
            return _databaseService.Person.Where(x => x.Id == Id).SingleOrDefault();
        }

        public int SavePerson(Person person)
        {
            _databaseService.Person.Add(person);
            _databaseService.Save();
            return person.Id;
        }

        public void UpdatePerson(Person person)
        {
            _databaseService.Entry(person).State = EntityState.Modified;
            _databaseService.Person.AddOrUpdate(person);
            _databaseService.Save();
        }

        public void RemovePerson(Person person)
        {
            _databaseService.Entry(person).State = EntityState.Deleted;
            _databaseService.Person.Attach(person);
            _databaseService.Person.Remove(person);
            _databaseService.Save();
        }
    }
}
