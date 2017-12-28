using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ExamenWPFprep
{
    class CustomProgressBar:ProgressBar
    {
        private int _AlertLevel;
        public int AlertLevel
        {
            get
            {
                return this._AlertLevel;
            }
            set
            {
                if (value <= Maximum && value > Minimum)
                {
                    this._AlertLevel = value;
                }
                else
                {
                    throw new Exception("Out of range value");
                }
            }
        }

        public static readonly RoutedEvent AlertEvent = EventManager.RegisterRoutedEvent("Alert", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomProgressBar));

        public event RoutedEventHandler Alert
        {
            add
            {
                this.AddHandler(CustomProgressBar.AlertEvent, value);
            }
            remove
            {
                this.RemoveHandler(CustomProgressBar.AlertEvent, value);

            }
        }


    }
}
