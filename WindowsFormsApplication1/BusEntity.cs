using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    public class BusEntity
    {
        string time = String.Empty;
        public BusEntity()
        {
            Form1.Actions += new Form1.ActionEventHandler(Form1_Actions);
        }
        private void Form1_Actions(object sender, WindowsFormsApplication1.Form1.ActionCancelEventArgs e)
        {
            e.Cancel = !DoActions();
            if (e.Cancel)
                e.Message = "Wasn't the right time" + TimeString;
        }
        
        private bool DoActions()
        {
            bool retVal = false;
            DateTime tm = DateTime.Now;
            if (tm.Second < 30)
            {
                time = "The time is " + DateTime.Now.ToLongTimeString();
                retVal = true;
            }
            else
                time = ": peter is now due to second lager than 30";
            return retVal;
        }
        public string TimeString
        {
            get { return time; }
        }
    }
}
