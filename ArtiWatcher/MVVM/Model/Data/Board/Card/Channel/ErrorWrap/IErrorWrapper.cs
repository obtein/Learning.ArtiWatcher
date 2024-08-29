using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorCode.Errors;

namespace ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorCode
{
    interface IErrorWrapper : Errors.IChannelErrorTypes
    {
        string Type { get; }
    }
}
