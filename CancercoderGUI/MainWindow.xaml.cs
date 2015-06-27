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
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Reflection;

namespace CancercoderGUI
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


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Clear listbox items
            listFiles.Items.Clear();
            
            // Create OpenFileDialog
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select files...";

            // Set default directory
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Enable Multiselect
            dlg.Multiselect = true;

            //  Set filter for file extension adn default file extension
            dlg.DefaultExt = "*.mkv";
            dlg.Filter = "Video Files (*.mkv,*.mp4,*.avi,*.divx,*.ogm)|*.mkv;*.mp4;*.avi;*.divx;*.ogm|All Files *.*|*.*";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name(s) and display in a listbox
            if (result == true)
            {
                foreach (string filename in dlg.FileNames)
                    listFiles.Items.Add(System.IO.Path.GetFileName(filename));
                

            }
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Settings SettingsWindow = new Settings();
            SettingsWindow.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            About AboutWindow = new About();
            AboutWindow.ShowDialog();
        }

        private void btnBrowseOutput_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
