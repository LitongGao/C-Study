using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Automation;

namespace UIATest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AutomationElement root = AutomationElement.RootElement;
            AutomationElement calc = root.FindFirst(TreeScope.Descendants, new AndCondition(
                new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window),
                new PropertyCondition(AutomationElement.ClassNameProperty, "Windows.UI.Core.CoreWindow")));

            ClickCalcButton(calc, "Clear");
            ClickCalcButton(calc, "Three");
            ClickCalcButton(calc, "Six");
            ClickCalcButton(calc, "Five");
            ClickCalcButton(calc, "Multiply by");
            ClickCalcButton(calc, "One");
            ClickCalcButton(calc, "Two");
            ClickCalcButton(calc, "Equals");

            VerifyTestResult(calc, "4380");
        }

        public static void InvokeButton(AutomationElement e)
        {
            InvokePattern invoke = (InvokePattern)e.GetCurrentPattern(InvokePattern.Pattern);
            invoke.Invoke();
        }

        private static void ClickCalcButton(AutomationElement calcFrame1, string name)
        {
            Condition conditionBtnPlus = new AndCondition(
                new PropertyCondition(AutomationElement.ClassNameProperty, "Button"),
                new PropertyCondition(AutomationElement.NameProperty, name));

            var btn = calcFrame1.FindFirst(TreeScope.Descendants, conditionBtnPlus);

            if (btn == null)
            {
                throw new Exception("can not find the button name is:" + name);
            }

            InvokeButton(btn);
        }

        public static void VerifyTestResult(AutomationElement calcFrame1, string exceptResult)
        {
            Condition conditionTextResult = new AndCondition(
                new PropertyCondition(AutomationElement.AutomationIdProperty, "CalculatorResults"),
                new PropertyCondition(AutomationElement.AutomationIdProperty, "CalculatorResults")
                );
            string result = calcFrame1.FindFirst(TreeScope.Descendants, conditionTextResult).Current.Name;
            string actualResult = result.Trim("Display is ,".ToCharArray());
            
            if (!actualResult.Equals(exceptResult))
            {
                throw new Exception("The result is wrong, and the actual result is " + actualResult);
                
            }
        }
    }
}
