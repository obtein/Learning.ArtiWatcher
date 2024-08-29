using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorWrap.Errors
{
    class VoltageError : IChannelErrorTypes
    {
        public bool Value{ get; set; }

        public bool UpdateValue ( bool value )
        {
            throw new NotImplementedException();
        }
    }
}
