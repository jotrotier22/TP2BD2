using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace MapEditor
{
    /// <summary>
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class LoadWindow : Window
    {
        private string openingFilePath = null;

        public LoadWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] allfiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\GameData\\mapHugoWorldTp2BD2", "*.txt", SearchOption.AllDirectories);
            foreach (string s in allfiles)
            {
                int indexFin = s.LastIndexOf('.');
                int indexdebut = s.LastIndexOf('\\');
                int iLength = indexFin - indexdebut - 1;
                cbListeMonde.Items.Add(s.Substring(indexdebut + 1, iLength));
            }
        }











        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void cbListeMonde_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //public void SaveTileMap(string pathToTileMapFile, int[,] tileMap, int count)
        //{
        //    string[] lines = new string[tileMap.Length + 1];

        //    int m = tileMap.GetLength(0);
        //    int n = tileMap.GetLength(1);

        //    lines[0] = count.ToString() + ' ' + m + ' ' + n;

        //    string tmp;
        //    for (int i = 1; i < m + 1; i++)
        //    {
        //        tmp = "";
        //        for (int j = 0; j < n; j++)
        //        {
        //            tmp += tileMap[i - 1, j].ToString() + ' ';
        //        }
        //        lines[i] = tmp;
        //    }

        //    File.WriteAllLines(pathToTileMapFile, lines);
        //}



        private void btnOpenWorld_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.AddExtension = true;
            if (openFileDialog.ShowDialog() == true)
            {
                openingFilePath = openFileDialog.FileName;
                int index = openingFilePath.LastIndexOf('\\');
                cbListeMonde.Items.Add(openingFilePath.Substring(index + 1));
            }
        }
    }
}
