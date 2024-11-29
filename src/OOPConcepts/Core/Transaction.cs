
using Core.Enum;

namespace Core
{
    public class Transaction
    {
        #region Attributes
        private readonly decimal _valor;
        
        private readonly DateTime _data;

        private readonly TypeTransaction _type;
        #endregion

        #region Properties
        public decimal Valor { get { return _valor; } }
        public DateTime Data { get { return _data;  } }

        public TypeTransaction Type { get { return _type; } }


        #endregion


        #region Constructors
        internal Transaction(decimal valor, TypeTransaction typeTransaction)
        {
            _valor = valor;
            _data = DateTime.Now;
            _type = typeTransaction;
        }
        #endregion
    }
}
