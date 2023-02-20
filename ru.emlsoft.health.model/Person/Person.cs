using EmlSoft.Data;
using System;
using System.Linq;

namespace EmlSoft.Health.model.Person
{
    internal class Person : IKeyable
    {
        public int Id { get; set; }
#pragma warning disable CS8618 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
#pragma warning restore CS8618 

        public DateTime? BirthDay { get; set; }
    }
}
