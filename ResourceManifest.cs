using Orchard.UI.Resources;

namespace PJS.Envision {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            // JAVASCRIPT FILES
            manifest.DefineScript("jQuery-Migrate").SetUrl("jquery-migrate.min.js", "jquery-migrate.js").SetVersion("1.2.1").SetDependencies("jQuery");
            manifest.DefineScript("ToTop").SetUrl("to_top.js").SetVersion("1.2");
            manifest.DefineScript("Envision-Common").SetUrl("common.js").SetVersion("2.0.9.4").SetDependencies("jQuery");
            manifest.DefineScript("Modernizr").SetUrl("modernizr-2.6.2-respond-1.1.0.min.js").SetVersion("2.6.2");
            manifest.DefineScript("NoConflict").SetUrl("noconflict.js").SetDependencies("jQuery");
            manifest.DefineScript("WebFont").SetUrl("webfont.js");
            manifest.DefineScript("prettyPhoto").SetUrl("jquery.prettyPhoto.js").SetVersion("3.1.6").SetDependencies("jQuery");
            manifest.DefineScript("Envision-Extensions").SetUrl("extensions.js").SetVersion("2.0.9.4").SetDependencies("jQuery");
            manifest.DefineScript("Retina").SetUrl("retina.js").SetVersion("1.0").SetDependencies("jQuery");
            manifest.DefineScript("QueryLoader2").SetUrl("queryloader2.js").SetDependencies("jQuery");
            manifest.DefineScript("Waypoints").SetUrl("waypoints.min.js").SetVersion("2.0.2").SetDependencies("jQuery");
            manifest.DefineScript("Waypoints-Sticky").SetUrl("waypoints-sticky.js").SetVersion("2.0.3").SetDependencies("jQuery", "Waypoints");
            manifest.DefineScript("SmoothScroll").SetUrl("jquery.smoothscroll.js").SetVersion("1.2.1").SetDependencies("jQuery");
            manifest.DefineScript("TextRotator").SetUrl("jquery.text-rotator.js").SetVersion("1.0").SetDependencies("jQuery");
            manifest.DefineScript("Viewport-Mini").SetUrl("jquery.viewport.mini.js").SetDependencies("jQuery");
            manifest.DefineScript("Flexslider").SetUrl("jquery.flexslider.js").SetVersion("2.5.0").SetDependencies("jQuery");
            manifest.DefineScript("Sharrre").SetUrl("jquery.sharrre.min.js", "jquery.sharrre.js").SetVersion("1.3.3").SetDependencies("jQuery");
            manifest.DefineScript("Revslider").SetUrl("jquery.themepunch.revolution.min.js", "jquery.themepunch.revolution.js").SetVersion("4.6.5").SetDependencies("jQuery");
            manifest.DefineScript("Revslider-Tools").SetUrl("jquery.themepunch.tools.min.js").SetVersion("4.6.5").SetDependencies("jQuery");
            manifest.DefineScript("Envision-Custom").SetUrl("envision-custom.js").SetDependencies("jQuery");

            // CSS Files
            manifest.DefineStyle("Custom-Login").SetUrl("custom-login.css");
            manifest.DefineStyle("Bootstrap").SetUrl("bootstrap.min.css", "bootstrap.css").SetVersion("2.3.0");
            manifest.DefineStyle("Envision-Style").SetUrl("style.min.css", "style.css").SetVersion("2.0.9.4");
            manifest.DefineStyle("Envision-Extensions").SetUrl("extensions.min.css", "extensions.css").SetVersion("2.0.9.4");
            manifest.DefineStyle("Bootstrap-Responsive").SetUrl("bootstrap-responsive.min.css", "bootstrap-responsive.css").SetVersion("2.3.0");
            manifest.DefineStyle("Bootstrap-Responsive-1170").SetUrl("bootstrap-responsive-1170.min.css", "bootstrap-responsive-1170.css");
            manifest.DefineStyle("Responsive").SetUrl("responsive.min.css", "responsive.css");
            manifest.DefineStyle("Retina").SetUrl("retina.css");
            manifest.DefineStyle("Font-Awesome").SetUrl("font-awesome-4.4.0/css/font-awesome.min.css", "font-awesome-4.4.0/css/font-awesome.css").SetVersion("4.4.0");
            manifest.DefineStyle("Icomoon").SetUrl("icomoon/css/icomoon.css");
            manifest.DefineStyle("Fonts").SetUrl("fonts.css");
            manifest.DefineStyle("Revslider").SetUrl("revslider/css/settings.css").SetVersion("4.6.5");
            manifest.DefineStyle("Envision-Custom").SetUrl("envision-custom.css");
        }
    }
}