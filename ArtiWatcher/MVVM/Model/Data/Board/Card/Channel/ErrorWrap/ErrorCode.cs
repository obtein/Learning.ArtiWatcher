using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorCode.Errors;

namespace ArtiWatcher.MVVM.Model.Data.Board.Card.Channel.ErrorCode
{
    class ErrorCode : IErrorWrapper
    {
        public bool Value
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool UpdateValue ( bool value )
        {
            throw new NotImplementedException();
        }

        public string Type { get => "Errors"; }

        Errors.NoCommunication NoCommunication  { get; set; }
        Errors.OverCurrent OverCurrent  { get; set; }
        Errors.ShortCircuit ShortCircuit  { get; set; }
        Errors.VoltageError VoltageError  { get; set; }

    }
}
