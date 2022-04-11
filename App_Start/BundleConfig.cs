using System.Web;
using System.Web.Optimization;

namespace Test_DataTables {
    public class BundleConfig {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles( BundleCollection bundles ) {
            bundles.Add( new ScriptBundle( "~/bundles/jquery" ).Include(

                            "~/Content/jquery/jquery-3.5.1.js",
                            "~/Content/jquery/jquery-3.6.0.js",
                            "~/Content/dataTables/datatables.js",
                            "~/Content/dataTables/datatables.bootstrap.js",
                            "~/Content/pagination/pagination.min.js",
                            "~/Content/site.js"

                        ) );

            //bundles.Add( new ScriptBundle( "~/bundles/jqueryval" ).Include(
            //            "~/Scripts/jquery.validate*" ) );
          

            bundles.Add( new ScriptBundle( "~/bundles/bootstrap" ).Include(
                      "~/Content/bootstrap/js/bootstrap.js" ) );

            bundles.Add( new StyleBundle( "~/Content/css" ).Include(
                      "~/Content/bootstrap/css/bootstrap.css",
                      "~/Content/pagination/pagination.css",
                      "~/Content/PagedList.css",
                      "~/Content/dataTables/css/datatables.bootstrap.js",
                      "~/Content/site.css" ) );
        }
    }
}
