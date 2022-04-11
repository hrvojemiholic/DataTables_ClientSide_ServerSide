using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_DataTables.Models {
    public class Person {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        
        public List<string> Addresses { get; set; }

        public List<CarData> Cars { get; set; }

        public string ErrorMessage { get; set; }
    }
}