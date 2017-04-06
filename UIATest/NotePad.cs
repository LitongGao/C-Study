using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace UIATest
{
    class NotePad
    {
        public static void ClickAbout()
        {
            AutomationElement root = AutomationElement.RootElement;
            AutomationElement about_notepad_windows = root.FindFirst(TreeScope.Descendants, new OrCondition(
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window),
                new PropertyCondition(AutomationElement.NameProperty, "About Notepad")));

        }
    }
}
