using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtiWatcher.MVVM.Model.Data
{
    public class Board
    {
        public static Card Card0 { get; set; }
        public static readonly object Card0LockRef = new object();
        public static Card Card1 { get; set; }
        public static readonly object Card1LockRef = new object();
        public static Card Card2 { get; set; }
        public static readonly object Card2LockRef = new object();

        public static Channel Ch00 { get; set; }
        public static readonly object Channel00LockRef = new object();
        public static Channel Ch01 { get; set; }
        public static readonly object Channel01LockRef = new object();
        public static Channel Ch02 { get; set; }
        public static readonly object Channel02LockRef = new object();
        public static Channel Ch03 { get; set; }
        public static readonly object Channel03LockRef = new object();
        public static Channel Ch04 { get; set; }
        public static readonly object Channel04LockRef = new object();
        public static Channel Ch05 { get; set; }
        public static readonly object Channel05LockRef = new object();
        public static Channel Ch06 { get; set; }
        public static readonly object Channel06LockRef = new object();
        public static Channel Ch07 { get; set; }
        public static readonly object Channel07LockRef = new object();

        public static Channel Ch10
        {
            get; set;
        }
        public static readonly object Channel10LockRef = new object();
        public static Channel Ch11
        {
            get; set;
        }
        public static readonly object Channel11LockRef = new object();
        public static Channel Ch12
        {
            get; set;
        }
        public static readonly object Channel12LockRef = new object();
        public static Channel Ch13
        {
            get; set;
        }
        public static readonly object Channel13LockRef = new object();
        public static Channel Ch14
        {
            get; set;
        }
        public static readonly object Channel14LockRef = new object();
        public static Channel Ch15
        {
            get; set;
        }
        public static readonly object Channel15LockRef = new object();
        public static Channel Ch16
        {
            get; set;
        }
        public static readonly object Channel16LockRef = new object();
        public static Channel Ch17
        {
            get; set;
        }
        public static readonly object Channel17LockRef = new object();

        public static Channel Ch20
        {
            get; set;
        }
        public static readonly object Channel20LockRef = new object();
        public static Channel Ch21
        {
            get; set;
        }
        public static readonly object Channel21LockRef = new object();
        public static Channel Ch22
        {
            get; set;
        }
        public static readonly object Channel22LockRef = new object();
        public static Channel Ch23
        {
            get; set;
        }
        public static readonly object Channel23LockRef = new object();
        public static Channel Ch24
        {
            get; set;
        }
        public static readonly object Channel24LockRef = new object();
        public static Channel Ch25
        {
            get; set;
        }
        public static readonly object Channel25LockRef = new object();
        public static Channel Ch26
        {
            get; set;
        }
        public static readonly object Channel26LockRef = new object();
        public static Channel Ch27
        {
            get; set;
        }
        public static readonly object Channel27LockRef = new object();

        public Board()
        {
            Card0 = new Card( 0, 8 );
            Card1 = new Card( 1, 8 );
            Card2 = new Card( 2, 8 );

            Ch00 = new Channel( 0, 0 );
            Ch01 = new Channel( 0, 1 );
            Ch02 = new Channel( 0, 2 );
            Ch03 = new Channel( 0, 3 );
            Ch04 = new Channel( 0, 4 );
            Ch05 = new Channel( 0, 5 );
            Ch06 = new Channel( 0, 6 );
            Ch07 = new Channel( 0, 7 );

            Ch00 = new Channel( 1, 0 );
            Ch01 = new Channel( 1, 1 );
            Ch02 = new Channel( 1, 2 );
            Ch03 = new Channel( 1, 3 );
            Ch04 = new Channel( 1, 4 );
            Ch05 = new Channel( 1, 5 );
            Ch06 = new Channel( 1, 6 );
            Ch07 = new Channel( 1, 7 );

            Ch00 = new Channel( 2, 0 );
            Ch01 = new Channel( 2, 1 );
            Ch02 = new Channel( 2, 2 );
            Ch03 = new Channel( 2, 3 );
            Ch04 = new Channel( 2, 4 );
            Ch05 = new Channel( 2, 5 );
            Ch06 = new Channel( 2, 6 );
            Ch07 = new Channel( 2, 7 );
        }

        public static bool UpdateCard0



    }
}
