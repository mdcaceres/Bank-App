using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBanco
{
    class Cliente : Persona 
    {
        private string _codigoCliente;
        private int _limiteCredito;
        private Cuenta _cuentaCliente;

        public string CodigoCliente
        {
            set { _codigoCliente = value; }
            get { return _codigoCliente; }
        }

        public int LimiteCredito
        {
            set { _limiteCredito = value; }
            get { return _limiteCredito; }
        }

        public Cuenta CuentaCliente
        {
            set { _cuentaCliente = value; }
            get { return _cuentaCliente; }
        }

        //Cliente miCliente = new Cliente();
        public Cliente() : base()
        {
            _codigoCliente = string.Empty;
            _limiteCredito = 0;
            _cuentaCliente = null;
        }

        //Cliente miCliente = new Cliente(miguel,caceres,123,false,12,787, 20, Caja de ahorro, 5)
        public Cliente(string _nombre, string _apellido, int _dni, bool _sexo, string _codigoCliente, int _limiteCredito,
            int _numeroCuenta, string _tipoCuenta, int _saldoCuenta ) : base(_nombre, _apellido, _dni, _sexo)
        {
            this._codigoCliente = _codigoCliente;
            this._limiteCredito = _limiteCredito;
            this._cuentaCliente = new Cuenta(_numeroCuenta, _tipoCuenta, _saldoCuenta);
        }


        public override string MostarDatos()
        {
            string _auxSexo = string.Empty;
            if (base.Sexo)
                _auxSexo = "Femenino";
            else
                _auxSexo = "Masculino";

            return $"{base.Nombre} {base.Apellido} | {base.Dni} | {_auxSexo} | {_codigoCliente} | {_limiteCredito} | {_cuentaCliente.ToString()}";
        }
    }
}
