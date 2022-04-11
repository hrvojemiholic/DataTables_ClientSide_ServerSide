using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_DataTables.Models {
    public class DataTableTestModel {

        public List<Person> Persons { get; set; }

        public int PageSize { get; set; }

        public int PageIndex { get; set; }

        public int TotalRowCount { get; set; }        

        public StaticPagedList<Person> PagerDataSource {
            get {               

                return new StaticPagedList<Person>( this.Persons, this.PageIndex + 1, this.PageSize, this.TotalRowCount );                
                
            }
        }

    }
}