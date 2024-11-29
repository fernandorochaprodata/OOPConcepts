using Core.Contracts;
using Core.Enum;

namespace Core
{    
    public sealed class Card
    {
        #region Attributes
        string _chip;
        private readonly float _width;
        private readonly float _height;
        private readonly float _memoryLength;
        private decimal _balance;
        #endregion

        #region Properties
        public float Width
        {
            get { return _width; }

        }

        public float Height
        {
            get { return _height; }
        }

        public float MemoryLength
        {
            get { return _memoryLength; }
        }

        public string Color
        {
            get;
            set;
        }

        #endregion


        #region Construtores

        public Card(float width, float height, float memoryLength, string chip)
        {
            _width = width;
            _height = height;
            _memoryLength = memoryLength;
            _balance = 0;
            _chip = chip;
        }

        #endregion

        public Transaction AdicionarDinheiro(decimal valor)
        {
            _balance += valor;
            return new Transaction(valor, TypeTransaction.Credit);

        }

        public bool LiberarCatacra(decimal tarifa)
        {
            if (_balance > 0)
            {
                Console.WriteLine("Catacra Liberada");
                _balance -= tarifa;
                var transaction = new Transaction(tarifa, TypeTransaction.Debit);
                return true;
            }
            else
            {
                Console.WriteLine("Sem Dinheiro");
                return false;
            }

        }
    }
}
