using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Entities1
{
    public class Person
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DOB { get; set; }

        public string HomeTown { get; set; }
        public EGioiTinh Sex { get; set; }

        public string IdFaculty { get; set; }

        public string FullName
        {
            get { return $" {FirstName} { LastName}"; }
        }
        public static List<Person> GetList()
        {
            var ls = new List<Person>();
            ls.Add(new Person
            {
                Id = "1",
                FirstName = "Nguyễn Phước",
                LastName = "Bình",
                DOB = new DateTime(2000, 11, 01),
                HomeTown = "Thừa Thiên Huế",
                Sex = EGioiTinh.Nam,
                IdFaculty = "1"
            });
           
            return ls;
        }

        public static List<Person> GetList(string idFaculty)
        {
            var ls = GetList();
            var rs = ls.Where(e => e.IdFaculty == idFaculty).ToList();
            return rs;
        } 
        public static Person Get(string id)
        {
            var dbPerson = GetList();
            //Linq to SQL
            //Lamda expression
            var person = dbPerson.Where(p => p.Id == id).FirstOrDefault();
            return person;
        }
    }
    public enum EGioiTinh
    {
        Nam, Nu, Khac
    }
}