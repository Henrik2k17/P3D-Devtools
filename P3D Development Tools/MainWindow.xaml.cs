using System;
using System.IO;
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
//using System.Windows.Shapes;


namespace P3D_Development_Tools
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

        string ShaderDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Lockheed Martin\\Prepar3D v5\\Shaders\\";
        string SceneryCache = @"C:\\ProgramData\\Lockheed Martin\\Prepar3D v5\\SceneryIndexes_x64";
        string filesToDeleteGeneral = @"*General*.cso";
        string filesToDeleteTerrain = @"*Terrain*.cso";
        string filesToDeletePBR = @"*PBRBase*.cso";
        string filesToDeleteHDR = @"*HDR*.cso";


        private void Button_Click_Shader(object sender, RoutedEventArgs e)
        {

            if (Directory.Exists(ShaderDirectory))
            {
                Directory.Delete(ShaderDirectory, true);
            }
            else
            {
                MessageBox.Show("File Not Exist");
            }
        }

        private void Button_Click_GeneralShader(object sender, RoutedEventArgs e)
        {
            string[] fileListGeneral = System.IO.Directory.GetFiles(ShaderDirectory, filesToDeleteGeneral);

            foreach (string file in fileListGeneral)
            {
                System.IO.File.Delete(file);
            }
        }

        private void Button_Click_TerrainShader(object sender, RoutedEventArgs e)
        {
            string[] fileListTerrain = System.IO.Directory.GetFiles(ShaderDirectory, filesToDeleteTerrain);

            foreach (string file in fileListTerrain)
            {
                System.IO.File.Delete(file);
            }

        }

        private void Button_Click_PBRShader(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_HDRShader(object sender, RoutedEventArgs e)
        {

        }
    }
}
