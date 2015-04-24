using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudyCommandDemo1_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsSave = false;
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding binding = new CommandBinding(ApplicationCommands.Cut);
            CommandBinding SaveBinding = new CommandBinding(ApplicationCommands.Save);
            binding.Executed += NewCommand_Executed;
            SaveBinding.Executed+=SaveCommand_Executed;
            SaveBinding.CanExecute += SaveCommand_CanExecuted;
            this.CommandBindings.Add(binding);
            this.CommandBindings.Add(SaveBinding);
        }
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e) 
        {
            MessageBox.Show("New");
        }
        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Save");
            IsSave = false;
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsSave = true;
        }
        private void SaveCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e) 
        {
            e.CanExecute = IsSave;
        }
    }
}
