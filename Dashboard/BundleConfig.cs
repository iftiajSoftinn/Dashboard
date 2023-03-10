using System.Web;
using System.Web.Optimization;

namespace Dashboard
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/angular").Include(                         
                          "~/Scripts/angular.js",
                          "~/Scripts/angular-route.js"));
            //the following creates bundles in debug mode;
            //BundleTable.EnableOptimizations = true;

        }
    }
}
