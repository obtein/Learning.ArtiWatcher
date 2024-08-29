using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorCode
{
    class ChannelErrorLock : IErrorWrapper
    {
        #region no need
        public bool Value
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool UpdateValue ( bool value )
        {
            throw new NotImplementedException();
        }
        #endregion
        object ErrorLock { get; set; }
        string Name { get; set; }
        public string Type { get => "Lock"; }
    }
}
