using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorCode;

namespace ArtiWatcher.MVVM.Model.Data.Board.Card.Channel
{
    class ChannelError : ErrorCode.IErrorWrapper
    {
        public string Type => throw new NotImplementedException();
        public bool Value
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool UpdateValue ( bool value )
        {
            throw new NotImplementedException();
        }

        public ErrorCode MyProperty { get; set; }

        public ChannelError () 
        {
            ErrorCode 
        }
        
    }
}
