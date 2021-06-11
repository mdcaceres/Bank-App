using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBanco
{
    class Cuenta
    {
        private int _numeroCuenta;
        private string _tipoCuenta;
        private int _saldoCuenta;
        
        public int NumeroCuenta
        {
            set { _numeroCuenta = value; }
            get { return _numeroCuenta; }
        }

        public string TipoCuenta
        {
            set { _tipoCuenta = value; }
            get { return _tipoCuenta; }
        }

        public int SaldoCuenta
        {
            set { _saldoCuenta = value; }
            get { return _saldoCuenta; }
        }

        public Cuenta()
        {
            _numeroCuenta = 0;
            _tipoCuenta = string.Empty;
            _saldoCuenta = 0; 
        }

        public Cuenta(int _numeroCuenta, string _tipoCuenta, int _saldoCuenta)
        {
            this._numeroCuenta = _numeroCuenta;
            this._tipoCuenta = _tipoCuenta;
            this._saldoCuenta = _saldoCuenta;
        }

        public override string ToString()
        {
            return $"{_numeroCuenta} | {_tipoCuenta} | {_saldoCuenta}";
        }
    }
}
