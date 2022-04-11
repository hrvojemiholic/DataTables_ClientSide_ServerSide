using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_DataTables.Models;

namespace Test_DataTables.Controllers
{
    public class DataTablesTestController : Controller
    {
        // GET: DataTablesTest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData() {
            
           

            List<Person> persons = new List<Person>();

            for ( int i = 1; i <= 20; i++ ) {

                Person person1 = new Person {
                    FirstName = "John",
                    LastName = "Smith",
                };

                Person person2 = new Person {
                    FirstName = "Steve",
                    LastName = "Robinson",
                };

                Person p = i % 2 == 0 ? person1 : person2;
                p.Id = i;
                persons.Add(p);
            }

            

            return PartialView( "/Views/PartialViews/_DataTablesClientSidePartial.cshtml", persons );
        }


        public ActionResult DataTablesClientSideTest() {
            return View();
        }

        public ActionResult DataTablesServerSideTest() {

            var model = this.GetPersonsMock( 0 );

            return View( model );
        }



        public ActionResult DataTableServerSide_Get( int pageIndex ) {

            DataTableTestModel model = GetPersonsMock( pageIndex - 1 );

            if( Request.IsAjaxRequest() ) {
                return PartialView( "/Views/PartialViews/_DataTablesServerSidePartial.cshtml", model );
            }
            else {
                return View( model );
            }

        }


        private DataTableTestModel GetPersonsMock( int pageIndex ) {
            List<Person> persons = new List<Person>();

            Enumerable.Range( 1, 20 ).ToList().ForEach(
                rowNum => persons.Add( rowNum % 2 == 0 ?
                    new Person {
                        Id = rowNum,
                        FirstName = "Steve",
                        LastName = "Smith",
                    } :
                    new Person {
                        Id = rowNum,
                        FirstName = "Mark",
                        LastName = "Long",
                    }
                )
            );

            int pageSize = 5;

            persons = persons.Skip( pageIndex * pageSize ).Take( pageSize ).ToList();


            DataTableTestModel model = new DataTableTestModel {
                Persons = persons,
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalRowCount = 20,
            };
            return model;
        }
        
    }
}