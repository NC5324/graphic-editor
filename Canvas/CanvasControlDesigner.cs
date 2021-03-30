using System.Collections;
using System.Windows.Forms.Design;

namespace CourseProject
{
    class CanvasControlDesigner : ControlDesigner
    {
        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            properties.Remove("MaximumSize");
            properties.Remove("MinimumSize");
            properties.Remove("Localizable");
            properties.Remove("Language");
            properties.Remove("WaitOnLoad");
            properties.Remove("AccessibleRole");
            properties.Remove("AccessibleDescription");
            properties.Remove("AccessibleName");
            properties.Remove("Enabled");
            properties.Remove("AccessibleName");
            properties.Remove("UseWaitCursor");
        }
    }
}
