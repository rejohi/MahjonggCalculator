using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjonngCalc
{  
    class Score
    {
        public int Ron (int Fu,int Han,Boolean Dealer)
        {
            
                if (Dealer == true)
                {
                    switch (Han)
                    {
                        case 1:
                            return (6 * Tally(Fu, Han));
                        case 2:
                            return (6 * Tally(Fu, Han));
                        case 3:
                            if (Fu < 70)
                            {
                                return (6 * Tally(Fu, Han));
                            }
                            else
                                return 12000;
                        case 4:
                            if (Fu < 40)
                            {
                                return (6 * Tally(Fu, Han));
                            }
                            else return 12000;
                        case 5:
                            return 12000;
                        case 6:
                            return 18000;
                        case 7:
                            return 18000;
                        case 8:
                            return 24000;
                        case 9:
                            return 24000;
                        case 10:
                            return 24000;
                        case 11:
                            return 36000;
                        case 12:
                            return 36000;
                        case 13:
                            return 48000;
                        default: return 0;
                    }

                }
            
            else
            {
                switch (Han)
                {
                    case 1:
                        return (4 * Tally(Fu, Han));
                    case 2:
                        return (4 * Tally(Fu, Han));
                    case 3:
                        if (Fu < 70)
                        {
                            return (4 * Tally(Fu, Han));
                        }
                        else
                            return 8000;
                    case 4:
                        if (Fu < 40)
                        {
                            return (4 * Tally(Fu, Han));
                        }
                        else return 8000;
                    case 5:
                        return 12000;
                    case 6:
                        return 12000;
                    case 7:
                        return 12000;
                    case 8:
                        return 16000;
                    case 9:
                        return 16000;
                    case 10:
                        return 16000;
                    case 11:
                        return 24000;
                    case 12:
                        return 24000;
                    case 13:
                        return 32000;
                    default: return 0;
                }
            }
        }
        public int Tsumo (int Fu,int Han,Boolean Dealer)
        {
            switch(Han)
              {
                        case 1:
                            return (2 * Tally(Fu, Han));
                        case 2:
                            return (2 * Tally(Fu, Han));
                        case 3:
                            if (Fu < 70)
                            {
                                return (2 * Tally(Fu, Han));
                            }
                            else
                                return 4000;
                        case 4:
                            if (Fu < 40)
                            {
                                return (2 * Tally(Fu, Han));
                            }
                            else return 4000;
                        case 5:
                            return 4000;
                        case 6:
                            return 6000;
                        case 7:
                            return 6000;
                        case 8:
                            return 8000;
                        case 9:
                            return 8000;
                        case 10:
                            return 8000;
                        case 11:
                            return 12000;
                        case 12:
                            return 12000;
                        case 13:
                            return 16000;
                default: return 0;
                    
            }
            
        }
        public int Tally(int Fu, int Han)
        {
            return (Fu * 2 ^ (2 + Han));
        }
    }
}
