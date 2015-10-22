using Orchard.ContentManagement;

namespace PJS.Envision.Models {
    public class EnvisionThemeSettingsPart : ContentPart {
        public string Skin {
            get { return this.Retrieve(r => r.Skin, "default"); }
            set { this.Store(r => r.Skin, value); }
        }
        public string LayoutStyle {
            get { return this.Retrieve(r => r.LayoutStyle, "wide"); }
            set { this.Store(r => r.LayoutStyle, value); }
        }
        public string BackgroundImageUrl {
            get { return this.Retrieve(r => r.BackgroundImageUrl, string.Empty); }
            set { this.Store(r => r.BackgroundImageUrl, value); }
        }
        public bool ShowTopBar {
            get { return this.Retrieve(r => r.ShowTopBar, true); }
            set { this.Store(r => r.ShowTopBar, value); }
        }
        public bool StickyTopBar {
            get { return this.Retrieve(r => r.StickyTopBar, false); }
            set { this.Store(r => r.StickyTopBar, value); }
        }
        public string HeaderStyle {
            get { return this.Retrieve(r => r.HeaderStyle, "header-style-1"); }
            set { this.Store(r => r.HeaderStyle, value); }
        }
        public string LogoPosition {
            get { return this.Retrieve(r => r.LogoPosition, "left"); }
            set { this.Store(r => r.LogoPosition, value); }
        }
        public string NavigationPosition {
            get { return this.Retrieve(r => r.NavigationPosition, "right"); }
            set { this.Store(r => r.NavigationPosition, value); }
        }
        public bool StickyHeader {
            get { return this.Retrieve(r => r.StickyHeader, true); }
            set { this.Store(r => r.StickyHeader, value); }
        }
        public string StickyLogoPosition {
            get { return this.Retrieve(r => r.StickyLogoPosition, "left"); }
            set { this.Store(r => r.StickyLogoPosition, value); }
        }
        public string StickyNavigationPosition {
            get { return this.Retrieve(r => r.StickyNavigationPosition, "right"); }
            set { this.Store(r => r.StickyNavigationPosition, value); }
        }
        public bool ShowLogoStickyHeader {
            get { return this.Retrieve(r => r.ShowLogoStickyHeader, true); }
            set { this.Store(r => r.ShowLogoStickyHeader, value); }
        }
        public string TitleBarBackgroundImageUrl {
            get { return this.Retrieve(r => r.TitleBarBackgroundImageUrl, string.Empty); }
            set { this.Store(r => r.TitleBarBackgroundImageUrl, value); }
        }
        public bool StickyFooter {
            get { return this.Retrieve(r => r.StickyFooter, false); }
            set { this.Store(r => r.StickyFooter, value); }
        }
    }
}