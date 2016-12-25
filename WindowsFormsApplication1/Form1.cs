using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        BusEntity bus = new BusEntity();

        public delegate void ActionEventHandler(object sender, ActionCancelEventArgs ev);
        private static ActionEventHandler action;
        public static event ActionEventHandler Actions;
        //{
        //    add
        //    {
        //        action += value;
        //    }
        //    remove
        //    {
        //        action -=value;
        //    }
        //}
        

        public Form1()
        {
            InitializeComponent();
            //buttonOne.Click += new EventHandler(Buttone_Click);
            //buttonTwo.Click += new EventHandler(Buttone_Click); 
            //buttonTwo.Click +=new EventHandler(buttonTwo_Click);
            buttonRaise.Click +=new EventHandler(buttonRaise_Click);
        }

        public class ActionCancelEventArgs : System.ComponentModel.CancelEventArgs
        {
            public ActionCancelEventArgs() : this(false){}
            public ActionCancelEventArgs(bool cancel) : this(cancel,String.Empty) {}
            public ActionCancelEventArgs(bool cancel,string message) :base(cancel)
            {
                this.Message = message;
            }
            public string Message{get;set;}
        }



        protected void OnAction(object sender, ActionCancelEventArgs ev)
        {
            if(Actions !=null)
            {
                Actions(sender,ev);
            }
            //ActionCancelEventArgs e = new ActionCancelEventArgs();
            //Actions(this, e);
        }
        private void Buttone_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Name=="buttonOne")
            {
                labelInfo.Text = "Button one was pressed";
            }
            else
            {
                labelInfo.Text = "Button two was pressed";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This only happen in Button2 click event");
        }

        private void buttonRaise_Click(object sender, EventArgs e)
        {
            ActionCancelEventArgs cancelEvent = new ActionCancelEventArgs(true,"12345");
            OnAction(this,cancelEvent);
            if (cancelEvent.Cancel)
                labelInfo.Text = cancelEvent.Message;
            else
                labelInfo.Text = bus.TimeString;
        }
    }
}
