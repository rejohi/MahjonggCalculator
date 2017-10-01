using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MahjonngCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            for(int i = 0; i <= 6; i = i + 2)
            {
                for(int j = 0; j <= 16; j = j + 2)
                {
                    if (i == 0)
                    {
                        InsertTile(j, i, "Bamb" + (j / 2 + 1));
                    }
                    if (i == 2)
                    {
                        InsertTile(j, i, "Char" + (j / 2 + 1));
                    }
                    if (i == 4)
                    {
                        InsertTile(j, i, "Dot" + (j / 2 + 1));
                    }
                    if (i == 6)
                    {
                       switch(j)
                        {
                            case 0: InsertTile(j, i, "WindE"); break;
                            case 2: InsertTile(j, i, "WindS"); break;
                            case 4: InsertTile(j, i, "windW"); break;
                            case 6: InsertTile(j, i, "windN"); break;
                            case 10: InsertTile(j, i, "DragonG"); break;
                            case 12: InsertTile(j, i, "DragonR"); break;
                            case 14: InsertTile(j, i, "DragonW"); break;
                            default: break;
                        }
                    }
                }
            }
    }
        public void InsertTile(int row,int column,String png)
        {
            Tile T = new Tile(row, column, png);
            T.Img.Tapped += Img_Tapped;
            tileGrid.Children.Add(T.Img);
        }

        private void Img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Grid _grid = sender as Grid;
            int _row = (int)_grid.GetValue(Grid.RowProperty);
            int _column = (int)_grid.GetValue(Grid.ColumnProperty);
            foreach(UIElement child in _grid.Children)
            {
                if (Grid.GetRow(child) == _row && Grid.GetColumn(child)== _column)
                {
                    child.
                }
            }
        }
    }
}
