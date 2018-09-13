using System.Web;
using System.Web.Optimization;

namespace Xolartek.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/system.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/kendo-ui").Include(
                      "~/Scripts/Kendo/2018.2.620/kendo.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendoui").Include(
                "~/Scripts/kendo/2013.2.716/jquery.min.js",
                "~/Scripts/kendo/2013.2.716/kendo.all.min.js",
                "~/Scripts/kendo/2013.2.716/kendo.aspnetmvc.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/Kendo/2018.2.620/kendo.bootstrap.min.css",
                "~/Content/Kendo/2018.2.620/kendo.common-bootstrap.min.css",
                "~/Content/Kendo/2018.2.620/kendo.blueopal.min.css",
                "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css/2013").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/kendo/2013.2.716/kendo.common.min.css",
                      "~/Content/kendo/2013.2.716/kendo.bootstrap.min.css",
                      "~/Content/kendo/2013.2.716/kendo.blueopal.min.css"));
        }
    }
}
