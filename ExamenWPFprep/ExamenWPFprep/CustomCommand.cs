using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenWPFprep
{
    public static class CustomCommand
    {

        public static readonly RoutedCommand Exit;
        static CustomCommand()
        {
            Exit = new RoutedCommand("Exit", typeof(CustomCommand), new InputGestureCollection()
            {
                new KeyGesture(Key.F4,ModifierKeys.Alt)
            });
        }
        
    }
}
