using System.Web;
using System.Web.Optimization;

namespace GetARoom.UI.web.main
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/angular.js",
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(       
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/fontawesome").Include(
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/font-awesome.css",
                      "~/css/main.css",
                      "~/css/3Dbuttons.css",
                      "~/css/reviews.css",
                      "~/Content/site.css"));
        }
    }
}
