using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using PJS.Envision.Models;

namespace PJS.Envision.Handlers {
    [UsedImplicitly]
    public class EnvisionThemeSettingsPartHandler : ContentHandler {
        public EnvisionThemeSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<EnvisionThemeSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<EnvisionThemeSettingsPart>("EnvisionThemeSettings", "Parts/EnvisionThemeSettings", "Theme-Envision"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Theme-Envision")));
        }
    }
}