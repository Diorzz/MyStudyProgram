using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyCommandDemo1_1.Commands
{
    public class CustomCommand
    {
        private static RoutedUICommand query;
        public static RoutedUICommand Query { get { return query; } }

        static CustomCommand() 
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl+R"));
            query = new RoutedUICommand("Query", "Query", typeof(CustomCommand), inputs);
        }
    }
}
