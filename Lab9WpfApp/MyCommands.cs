using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab8WpfApp
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedCommand Bond { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }
        public static RoutedCommand Black { get; set; }
        public static RoutedCommand Red { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands), inputs);
            Bond = new RoutedCommand("Bond", typeof(MyCommands));
            Italic = new RoutedCommand("Italic", typeof(MyCommands));
            Underline = new RoutedCommand("Underline", typeof(MyCommands));
            Black = new RoutedCommand("Black", typeof(MyCommands));
            Red = new RoutedCommand("Red", typeof(MyCommands));
        }
    }
}
