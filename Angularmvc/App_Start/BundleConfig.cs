using System.Web;
using System.Web.Optimization;

namespace Angularmvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //           "~/Scripts/jquery-2.2.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/mybundle").Include(
            "~/Scripts/jquery-3.1.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/easing.js",
                      "~/Scripts/jquery.nicescroll.js",
                      "~/Scripts/move-top.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/scripts.js",
                      "~/Scripts/simple-lightbox.js",
                      "~/Scripts/jquery.nicescroll.js",
                      "~/Scripts/jquery.carouFredSel-6.2.0-packed.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/style.css",
                      "~/Content/wowStyle.css",
                      "~/Content/animate.css",
                      "~/Content/font-awesome.css",
                      "~/Content/carousel.css",
                       "~/Content/simplelightbox.min.css"

                      ));

        }
    }
}
