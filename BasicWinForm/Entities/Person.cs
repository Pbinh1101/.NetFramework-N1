using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinForm.Entities
{
    class Person
    {
   
public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        /// <summary>
        /// NGÀY SINH
        /// </summary>
        public EGioiTinh SEX { get; set; }
        public string HomeTown { get; set; }
        public EGioiTinh Sex { get; private set; }

        public string FullName { 
            get 
            { 
                return $"{FirstName} {LastName}"; 
            }

        
        }

        /// Lây toàn bộ danh sách sinh viên trong CSDL
        ///(mock data )   
        /// Danh sách sinh viên
        public static List<Person> GetList()
        {
            var ls = new List<Person>();
            ls.Add(new Person() { 
            Id = "1",
            FirstName = "Nguyễn Phước",
            LastName   = "Bình",
            DOB = new DateTime(2000, 11, 01),
            HomeTown = "Huế",
            Sex = EGioiTinh.Nam
        });
          return ls;
         }
        
        public static Person Get(string id)
        {
            var dbPerson = GetList();
            
            var person = dbPerson.Where(p=>p.Id == id).FirstOrDefault();
            return person;
        }

    public enum EGioiTinh
    {
        Nam, Nu, Khac
    }
}
}
