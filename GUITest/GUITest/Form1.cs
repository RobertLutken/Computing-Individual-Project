using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace GUITest
{
    public partial class Form1 : Form
    {
        //Label lbTimer1 = new Label();
        public Form1()
        {
            InitializeComponent();
            lbTimer.Update();
            lbTimer.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                textBox1.Focus();
            }
        }
        class mTimer :  Form1
        {
            DateTime mTime;

            public mTimer(int minutes) { mTime = DateTime.Now.AddMinutes(minutes); startTimer(); }
            // public static void setTime(int minutes) { mTimer m2 = new mTimer(); m2.mTime = DateTime.Now.AddMinutes(minutes); m2.startTimer(); }

            // private static void setTime(int hours , int minutes, int seconds) { mTimer m2 = new mTimer(); m2.mTime = DateTime.Now.AddMinutes(hours); m2.startTimer(); }

            public void startTimer()
            {
                // Create a new timer
                System.Timers.Timer t = new System.Timers.Timer();
                // set the interval of the timer to 1 sec
                t.Interval = 1000;

                t.Elapsed += new ElapsedEventHandler(onTimerTick);
                TimeSpan ts = mTime.Subtract(DateTime.Now);
                t.Start();
            }

            void onTimerTick(object source, ElapsedEventArgs e)
            {
                TimeSpan ts = mTime.Subtract(DateTime.Now);

                Console.Write("\rYou have  : " + ts.Minutes + " Minutes and " + ts.Seconds + " Seconds remaining.");
               lbTimer.Text = "Time Remaining " + ts.Minutes + "Minutes and" + ts.Seconds + "Seconds remaining.";
           //    lbTimer.Refresh();
               lbTimer.Update();
            }
          public  string getText()
            {
                TimeSpan ts = mTime.Subtract(DateTime.Now);
                return "Time Remaining " + ts.Minutes + "Minutes and" + ts.Seconds + "Seconds remaining.";
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            mTimer m = new mTimer(10);
            lbTimer.Text = m.getText();
            lbTimer.Refresh();
        }

        private void lbTimer_Click(object sender, EventArgs e)
        {

        }
        private void lbTimer_TextChanged(object sender, EventArgs e)
        {
            
        }
      //  public virtual void Refresh() { }
    }
}
