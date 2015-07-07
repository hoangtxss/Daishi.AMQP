#region Includes

using System.Collections.ObjectModel;

#endregion

namespace Daishi.Microservices.TestHarness.Areas.HelpPage.ModelDescriptions {
    public class EnumTypeModelDescription : ModelDescription {
        public EnumTypeModelDescription() {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}