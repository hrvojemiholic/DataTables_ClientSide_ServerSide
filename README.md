# DataTables_ClientSide_ServerSide
Example of serverside and clientside datatables with Asp.Net MVC.

<b>Client side version:</b>

1. Request is made to MVC controller

```

   var jqxhr = $.get("/DataTablesTest/GetData",
                  function (data) {

                      document.querySelector("#resultHolder").innerHTML = data;

                      $(document).ready(function () {
                          $("#tablePersons").DataTable();
                      });


                  }).fail(function () {
                      alert("error");
                  });

          }
```

2. MVC renders html table in partial view

```
    return PartialView( "/Views/PartialViews/_DataTablesClientSidePartial.cshtml", persons );
```
    
3. Partial view is returned to client and is insereted into #resultHolder.


<b>Server side version:</b>

1. Request is made to MVC controller (DataTableServerSide_Get)

3. DataTable (only one page) is rendered on server and returned in partial view

```
return PartialView( "/Views/PartialViews/_DataTablesServerSidePartial.cshtml", model );
```
  
  Partial view also renderes pager control using PagedListPager.
  
3. Following clicks on pager control make new requests to MVC Controller, but with page index,
so serverside can render specific page.

  


