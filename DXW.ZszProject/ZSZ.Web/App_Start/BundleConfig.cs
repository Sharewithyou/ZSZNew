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

            //--------------------------- css 绑定 --------------------------------

            bundles.Add(new StyleBundle("~/css/adminlte").Include(
                        "~/Content/plugins/font-awesome/css/font-awesome.min.css",
                        "~/Content/css/adminlte.min.css",
                        "~/Content/plugins/spin.js-4.0.0/spin.css"
                        ));

            //页面样式
            bundles.Add(new StyleBundle("~/css/page/css").Include(
                        "~/Content/css/pages/homePage.css"));



            //----------------------------- js 绑定 -------------------------------

            // cdn 链接

            var jqueryCdn = "https://cdn.bootcss.com/jquery/3.3.1/jquery.min.js";

            var bootstrapBundleCdn = "https://cdn.bootcss.com/bootstrap/4.1.0/js/bootstrap.bundle.min.js";

            // jQuery 

            bundles.Add(new ScriptBundle("~/bundles/jquery", jqueryCdn).Include(
                        "~/Content/plugins/jquery/jquery.min.js"));

            // bootstrap 4
            bundles.Add(new ScriptBundle("~/bundles/bootstrap4", bootstrapBundleCdn).Include(
                       "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js"));

            // adminlte

            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                         "~/Content/js/adminlte.min.js",
                         "~/Content/js/pages/home.js"));

            // ckeditor
            bundles.Add(new ScriptBundle("~/bundles/ckeditor4").Include(
                         "~/Content/plugins/ckeditor_full/ckeditor.js"));

            // spin loading
            bundles.Add(new ScriptBundle("~/bundles/spin").Include(
                         "~/Content/plugins/spin/spin.js",
                          "~/Content/plugins/spin/spinInit.js"
                         ));


            BundleTable.EnableOptimizations = false;  //是否打包压缩

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