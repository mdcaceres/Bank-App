using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBanco
{
    class Banco
    {
       private Cliente[] _misClientes;

       private int _auxMisClientes;

        public Cliente[] MisClientes
        {
            set { _misClientes = value; }
            get { return _misClientes; }
        }

        public int AuxiliarClientes
        {
            get { return _auxMisClientes; }
        }

        public Banco()
        {
            _misClientes = null;
            _auxMisClientes = 0;
        }

        public Banco(int clientes)
        {
            _misClientes = new Cliente[clientes];
            _auxMisClientes = 0;
        }

        public void AgregarCliente(Cliente cliente)
        {
            if(_auxMisClientes < _misClientes.Length)
            {
                _misClientes[_auxMisClientes] = cliente;
            }
            _auxMisClientes++;    
        }
    }
}
