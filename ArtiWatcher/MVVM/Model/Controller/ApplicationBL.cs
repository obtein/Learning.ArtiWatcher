using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtiWatcher.MVVM.Model.Data;

namespace ArtiWatcher.MVVM.Model.Controller
{
    public class ApplicationBL
    {
        Board Board { get; set; }

        Stack<byte []> dataReceived;
        Stack<byte []> dataToSent;

        Thread process, update, puBridge;


        public ApplicationBL()
        {
            Board = new Board();
        }

        /// <summary>
        /// Updates data according to the received package
        /// </summary>
        /// <param name="cardIndex"></param>
        /// <param name="channelIndex"></param>
        /// <returns></returns>
        bool UpdateData (int cardIndex, int channelIndex)
        {
            if ( channelIndex == -1 ) // Update only card property
            {
                if ( cardIndex == 0 )
                {
                    lock ( Board.Card0 )
                    {
                    }
                }
                else if ( cardIndex == 1 )
                {
                    lock ( Board.Card1 )
                    {
                    }
                }
                else if(cardIndex == 2)
                {
                    lock ( Board.Card2 )
                    {
                    }
                }
            }
            else
            {
                if ( cardIndex == 0 )
                {
                    if (channelIndex == 0) 
                    {
                        lock ( Board.Ch00 )
                        {
                        }
                    }
                    else if ( channelIndex == 1 )
                    {
                        lock ( Board.Ch01 )
                        {
                        }
                    }
                    else if ( channelIndex == 2 )
                    {
                        lock ( Board.Ch02 )
                        {
                        }
                    }
                    else if ( channelIndex == 3 )
                    {
                        lock ( Board.Ch03 )
                        {
                        }
                    }
                    else if ( channelIndex == 4 )
                    {
                        lock ( Board.Ch04 )
                        {
                        }
                    }
                    else if ( channelIndex == 5 )
                    {
                        lock ( Board.Ch05 )
                        {
                        }
                    }
                    else if ( channelIndex == 6 )
                    {
                        lock ( Board.Ch06 )
                        {
                        }
                    }
                    else if ( channelIndex == 7 )
                    {
                        lock ( Board.Ch07 )
                        {
                        }
                    }
                }
                else if ( cardIndex == 1 )
                {
                    if ( channelIndex == 0 )
                    {
                        lock ( Board.Ch10 )
                        {
                        }
                    }
                    else if ( channelIndex == 1 )
                    {
                        lock ( Board.Ch11 )
                        {
                        }
                    }
                    else if ( channelIndex == 2 )
                    {
                        lock ( Board.Ch12 )
                        {
                        }
                    }
                    else if ( channelIndex == 3 )
                    {
                        lock ( Board.Ch13 )
                        {
                        }
                    }
                    else if ( channelIndex == 4 )
                    {
                        lock ( Board.Ch14 )
                        {
                        }
                    }
                    else if ( channelIndex == 5 )
                    {
                        lock ( Board.Ch15 )
                        {
                        }
                    }
                    else if ( channelIndex == 6 )
                    {
                        lock ( Board.Ch16 )
                        {
                        }
                    }
                    else if ( channelIndex == 7 )
                    {
                        lock ( Board.Ch17 )
                        {
                        }
                    }
                }
                else if ( cardIndex == 2 )
                {
                    if ( channelIndex == 0 )
                    {
                        lock ( Board.Ch20 )
                        {
                        }
                    }
                    else if ( channelIndex == 1 )
                    {
                        lock ( Board.Ch21 )
                        {
                        }
                    }
                    else if ( channelIndex == 2 )
                    {
                        lock ( Board.Ch22 )
                        {
                        }
                    }
                    else if ( channelIndex == 3 )
                    {
                        lock ( Board.Ch23 )
                        {
                        }
                    }
                    else if ( channelIndex == 4 )
                    {
                        lock ( Board.Ch24 )
                        {
                        }
                    }
                    else if ( channelIndex == 5 )
                    {
                        lock ( Board.Ch25 )
                        {
                        }
                    }
                    else if ( channelIndex == 6 )
                    {
                        lock ( Board.Ch26 )
                        {
                        }
                    }
                    else if ( channelIndex == 7 )
                    {
                        lock ( Board.Ch27 )
                        {
                        }
                    }
                }
            }
            return true;
        }
    }
}
