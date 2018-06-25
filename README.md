# ASP.NET External Bundles
[![Build Status](https://travis-ci.org/derkachdeveloper/DD.AspNet.Web.Optimization.External.svg?branch=master)](https://travis-ci.org/derkachdeveloper/DD.AspNet.Web.Optimization.External)

The **DD.AspNet.Web.Optimization.External** is a package of types to integration an externally bundled assets to Microsoft.AspNet.Web.Optimization.BundleCollection.
Main point it is a exclude JsMinifier and CssMinifier from Bundle Transforms.

# Usage
**BundleConfig:**
```
using System.Web.Optimization;

namespace ExternalSample
{
    /// <summary>
    /// Static front-end content bundles registration.
    /// For more details, see Global.asax file.
    /// </summary>
    internal static class BundleConfig
    {
        /// <summary>
        /// Registers script and styles bundles.
        /// </summary>
        /// <param name="bundles">The registered bundles collection.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*
            * Use ExternalBundle for registration bundle of externally bundled scripts or styles to BundleCollection.
            */

            // scripts registration
            bundles.Add(new ExternalBundle("~/scripts/sigin")
                .Include("~/scripts/external/signin.bundle.*"));

            // styles registration
            bundles.Add(new ExternalBundle("~/styles/layout")
                .Include("~/Content/styles/external/layout.bundle.*"));
        }
    }
}
```
