using System.Windows;

namespace DAndD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FileDragDropZone_FileDropped(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is string[] files)
            {
                foreach (string file in files)
                {
                    Console.WriteLine($"File dropped: {file}");
                }
            }
        }
    }
}