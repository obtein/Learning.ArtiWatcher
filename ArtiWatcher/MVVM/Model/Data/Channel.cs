﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtiWatcher.MVVM.Model.Data
{
    public partial class Channel : INotifyPropertyChanged
    {
        public int CardIndex
        {
            get; set;
        }
        public int ChannelIndex
        {
            get; set;
        }

        private bool isOpen;
        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
            set
            {
                if ( isOpen != value )
                {
                    isOpen = value;
                }
            }
        }

        private int errorCode;
        public int ErrorCode
        {
            get
            {
                return errorCode;
            }
            set
            {
                if ( errorCode != value )
                {
                    errorCode = value;
                }
                OnPropertyChanged( nameof( IsOpen ) );
                OnPropertyChanged( nameof( ErrorCode ) );
            }
        }

        private double current;
        public double Current
        {
            get
            {
                return current;
            }
            set
            {
                if ( current != value )
                {
                    current = value;
                    OnPropertyChanged( nameof( Current ) );
                }
            }
        }

        public Channel ( int cardIndex, int chIndex )
        {
            this.CardIndex = cardIndex;
            this.ChannelIndex = chIndex;
            isOpen = false;
            ErrorCode = 0;
            current = 0;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged ( string propertyName )
        {
            //Work in progress
        }

    }
}
