using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace MahjonngCalc
{   public enum Typ
    {
        Bamb, Char, Dot, Dragon, Wind
    };
    public enum Wert
    {
        Honor, Simple, Terminal
    };
    class Tile
    {
        public Image Img { get; set; }
        int tilerow;
        int tilecolumn;
        public Typ typ { get; set; }
        public Wert wert { get; set; }

        public Tile(int column, int row, String png)
            {
            Img = new Image();
            Img.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + png + ".png"));
            Img.SetValue(Grid.RowProperty,row);
            Img.SetValue(Grid.ColumnProperty,column);
            tilerow = row;
            tilecolumn = column;
            if (row == 0)
            {
                typ = Typ.Bamb;
            }
            else if (row == 2)
            {
                typ = Typ.Char;
            }
            else if (row == 4)
            {
                typ = Typ.Dot;
            }
            else if (row == 6 && column <10)
            {
                typ = Typ.Wind;
            }
            else if (row == 6&& column>=10)
            {
                typ = Typ.Dragon;
            }
            

            }
        public bool Honor()
        {
            if(tilerow == 6)
            {
                return true;
            }
            if (tilecolumn == 0 || tilecolumn == 16)
            {
                return true;
            }
            else return false;
        }


    }
}
