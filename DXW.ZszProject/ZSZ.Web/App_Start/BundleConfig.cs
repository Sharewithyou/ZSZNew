using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ZSZ.Web.App_Start
{
    // Install-Package Microsoft.AspNet.Web.Optimization
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;   //enable CDN support

            //ResetIgnorePatterns(bundles.IgnoreList);

            bundles.Add(new StyleBundle("~/css/adminlte").Include(
                        "~/Content/plugins/font-awesome/css/font-awesome.min.css",
                        "~/Content/css/adminlte.min.css"));

            var jqueryCdn = "https://cdn.bootcss.com/jquery/3.3.1/jquery.min.js";

            var bootstrapBundleCdn = "https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.bundle.min.js";

            bundles.Add(new ScriptBundle("~/bundles/jquery", jqueryCdn).Include(
                        "~/Content/plugins/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap4", bootstrapBundleCdn).Include(
                       "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                         "~/Content/js/adminlte.min.js",
                         "~/Content/js/pages/home.js"));

            bundles.Add(new ScriptBundle("~/bundles/ckeditor4").Include(
                         "~/Content/plugins/ckeditor_full/ckeditor.js"));


            BundleTable.EnableOptimizations = true;  //是否打包压缩

        }

        public static void ResetIgnorePatterns(IgnoreList ignoreList)
        {
            ignoreList.Clear();
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            // ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}