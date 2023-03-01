using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task_3_6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form = new Form1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //add button that says Lunch to the form)
            
            Application.Run(form);
        }
    }

    public class ClockDisplay
    {
        private NumberDisplay _hours;
        private NumberDisplay _minutes;
        private NumberDisplay _seconds;
        private bool _visaSek;
        public bool VisaSek    // the Name property
        {
            get => _visaSek;
            set => _visaSek = value;
        }
        public ClockDisplay() { }
        public ClockDisplay(int hours, int minutes) { }
        public ClockDisplay(int hours, int minutes, int seconds) { }
        public ClockDisplay(int hours, int minutes, int seconds, bool visaSek) { }
        public string GetTime() { return ""; }
        public void SetTime() { }
        public void TimeTick() { }


    }

    public class NumberDisplay
    {
        private int _maxNumber;
        private int _number;
        public int Number    // the Name property
        {
            get => _number;
            set => _number = value;
        }
        public NumberDisplay(int maxNumber) { this._maxNumber = maxNumber; }
        public NumberDisplay(int maxNumber, int number) { this._maxNumber = maxNumber; this._number = number; }

        public string GetDisplayNumber() { return ""; }
        public void Increment() { }
    }
}
