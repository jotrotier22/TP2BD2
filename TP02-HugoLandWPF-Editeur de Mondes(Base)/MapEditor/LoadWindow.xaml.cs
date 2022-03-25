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
using HugoLandEditeur;

namespace MapEditor
{
    /// <summary>
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class LoadWindow : Window
    {
        public string _openingFilePath = null;
        private string[] _allFiles = null;
        public int[,] _TileMap = null;

        public LoadWindow()
        {
            InitializeComponent();
        }
        public int CellHeight { set; get; }
        public int CellWidth { set; get; }
        public int WorldWidth { set; get; }
        public int WorldHeight { set; get; }
        public string TileSetFilePath { set; get; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            string[] allfiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\GameData\\mapHugoWorldTp2BD2", "*.txt", SearchOption.AllDirectories);
            _allFiles = allfiles;
            foreach (string s in allfiles)
            {
                int indexFin = s.LastIndexOf('.');
                int indexdebut = s.LastIndexOf('\\');
                int iLength = indexFin - indexdebut - 1;
                cbListeMonde.Items.Add(s.Substring(indexdebut + 1, iLength));
            }
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

        private void ButtonOk1_Click(object sender, RoutedEventArgs e)
        {


            //WorldHeight = int.Parse(txtWorldHeight.Text);
            //WorldWidth = int.Parse(txtWorldWidth.Text);
            //if (File.Exists(TileSetFilePath))
            //    DialogResult = true;
            //else
            //    MessageBox.Show("Please enter a valid file path", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
        }


        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show( cbListeMonde.SelectedItem.ToString());
            CellHeight = csteApplication.TILE_WIDTH_IN_IMAGE;
            CellWidth = csteApplication.TILE_HEIGHT_IN_IMAGE;
            TileSetFilePath = System.AppDomain.CurrentDomain.BaseDirectory + csteApplication.TILE_FILE_PATH;
            string s1 = "";
            if (cbListeMonde.SelectedIndex == 0)
            {
                DialogResult = false;
            }
            else
            {


                foreach (string s in _allFiles)
                {
                    int indexFin = s.LastIndexOf('.');
                    int indexdebut = s.LastIndexOf('\\');
                    int iLength = indexFin - indexdebut - 1;
                    s1 = s.Substring(indexdebut + 1, iLength);
                    if (s1 == cbListeMonde.SelectedItem.ToString())
                    {
                        _openingFilePath = s;
                        break;
                    }
                }
                StreamReader streamReaderLine0 = new StreamReader(_openingFilePath);
                StreamReader streamReader = new StreamReader(_openingFilePath);
                string sNbr = "";

                bool TileNbr = true;
                bool worldWidth = false;
                bool worldHeight = false;
                foreach (char c in streamReader.ReadLine())
                {
                    if (c == ' ' || c == '\n')
                    {
                        if (TileNbr)
                        {

                            TileNbr = false;
                            worldWidth = true;
                        }
                        else if (worldWidth)
                        {
                            WorldWidth = int.Parse(sNbr);
                            worldWidth = false;
                            worldHeight = true;
                        }





                        sNbr = "";
                    }
                    else
                    {
                        sNbr += c;
                    }
                }
                if (worldHeight)
                {
                    WorldHeight = int.Parse(sNbr);
                }
                int i = 0;
                int j = 0;
                sNbr = "";
                _TileMap = new int[WorldWidth, WorldHeight];
                foreach (char c in streamReader.ReadToEnd())
                {
                    if (c == '\r')
                    {

                    }
                    else if (c == ' ' || c == '\n')
                    {
                        if (c == '\n')
                        {
                            i++;
                            j = 0;
                        }
                        else
                        {
                            _TileMap[i, j] = int.Parse(sNbr);
                            j++;
                        }

                        sNbr = "";
                    }
                    else
                    {
                        sNbr += c;
                    }
                    if (i == WorldWidth && j == WorldHeight)
                    {
                        break;
                    }

                }





                DialogResult = true;
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void cbListeMonde_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }







    }
}
