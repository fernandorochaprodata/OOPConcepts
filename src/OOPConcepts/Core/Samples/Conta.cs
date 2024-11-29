namespace Core.Samples
{
    public class Conta 
    {
        #region Fields
        private decimal _saldo;

        private Pessoa _pessoa;

        #endregion

        #region Constructors
        public Conta(Pessoa pessoa)
        {
            _pessoa = pessoa;
            _saldo = 0;
        }
        #endregion

        #region Properties
        public decimal Saldo
        {
            get { return _saldo; }            
        }
        public Pessoa Dono { get { return _pessoa; } }
        #endregion
    }
}
