using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBanco
{
    abstract class Persona
    {
        //Atributos
        private string _nombre;
        private string _apellido;
        private int _dni;
        private bool _sexo; 


        //properties
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public string Apellido
        {
            set { _apellido = value; }
            get { return _apellido; }
        }

        public int Dni
        {
            set { _dni = value; }
            get { return _dni; }
        }

        public bool Sexo
        {
            set { _sexo = value;  }
            get { return _sexo; }
        }

        //metodos constructores

        //Persona miPersona = new Persona(); 
        public Persona()
        {
            _nombre = "";
            _apellido = string.Empty;
            _dni = 0;
            _sexo = false; 
        }

        //Persona miPersona = new Persona(maria, caceres,123, true); 

        public Persona (string _nombre, string _apellido, int _dni, bool _sexo)
        {
            this._nombre = _nombre;
            this._apellido = Apellido;
            this._dni = _dni;
            this._sexo = _sexo;
        }

        virtual public string MostarDatos()
        {
            string _auxSexo;

            if (_sexo)
                _auxSexo = "Femenino";
            else
                _auxSexo = "Masculino";

            return $"Nombre: {_nombre} {_apellido}, Documento: {_dni}, sexo: {_auxSexo}";
        }
    }
}
