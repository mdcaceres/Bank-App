using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionBanco
{
    public partial class Form1 : Form
    {
        Banco miBanco = new Banco(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            lbClientes.Items.Clear();

            for(int i = 0; i < miBanco.MisClientes.Length; i++) 
            {
                if (miBanco.MisClientes[i] != null)
                {
                    lbClientes.Items.Add(miBanco.MisClientes[i].MostarDatos());
                }
                else
                    break;
            };
        }

        private void Limpiar()
        {
            foreach (Control ctr in panel2.Controls)
            {
                if (ctr is TextBox)
                    ((TextBox)ctr).Clear();

                if (ctr is ComboBox)
                    ((ComboBox)ctr).SelectedIndex = -1;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrar();
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool _auxSexo;

            if(cbSexo.Text == "Femenino")
                _auxSexo = true;
            else
                _auxSexo = false;

            //instancia de cliente
            Cliente _miCliente = new Cliente();

            //instancia de la cuenta
            Cuenta _cuentaCliente = new Cuenta();

            //Properties heredadas de Persona
            _miCliente.Nombre = txtNombre.Text;
            _miCliente.Apellido = txtApellido.Text;

            try
            {
                _miCliente.Dni = int.Parse(txtDni.Text);
            } catch(Exception ex)
            {
                MessageBox.Show("ingrese un dato correcto");
            }

            _miCliente.Sexo = _auxSexo;

            //properties propias de cliente 
            _miCliente.LimiteCredito = int.Parse(txtLimite.Text);
            _miCliente.CodigoCliente = txtCodigo.Text;

            //Properties cuenta
            _cuentaCliente.NumeroCuenta = int.Parse(txtNumeroCuenta.Text);
            _cuentaCliente.TipoCuenta = cbTipoCuenta.Text;
            _cuentaCliente.SaldoCuenta = int.Parse(txtSaldo.Text);

            //propertie de cliente 
            _miCliente.CuentaCliente = _cuentaCliente;

            miBanco.AgregarCliente(_miCliente);

            Mostrar();

            Limpiar();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnCantAhorro_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La cantidad de cajas de ahoro son: {Calculos.Calcular(miBanco.MisClientes, "Caja de ahorro")}");
        }
        
           

        private void bntCantCorriente_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La cantidad de Cuentas corriente son: {Calculos.Calcular(miBanco.MisClientes, "Cuenta corriente")}");
        }

        private void btnPorcFemenino_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El porcentaje de clientes de sexo femenino es: {Calculos.Porcentaje(miBanco.MisClientes)}");
        }
    }
}
