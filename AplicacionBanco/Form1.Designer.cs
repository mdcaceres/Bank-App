
namespace AplicacionBanco
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSaldoCuenta = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.lblLimiteCuenta = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.btnCantAhorro = new System.Windows.Forms.Button();
            this.bntCantCorriente = new System.Windows.Forms.Button();
            this.btnPorcFemenino = new System.Windows.Forms.Button();
            this.btnMayorCredito = new System.Windows.Forms.Button();
            this.btnPromSaldo = new System.Windows.Forms.Button();
            this.cbPromSaldo = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.cbTipoCuenta);
            this.panel2.Controls.Add(this.cbSexo);
            this.panel2.Controls.Add(this.txtSaldo);
            this.panel2.Controls.Add(this.txtNumeroCuenta);
            this.panel2.Controls.Add(this.txtLimite);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.txtDni);
            this.panel2.Controls.Add(this.txtApellido);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblSaldoCuenta);
            this.panel2.Controls.Add(this.lblTipoCuenta);
            this.panel2.Controls.Add(this.lblNumeroCuenta);
            this.panel2.Controls.Add(this.lblLimiteCuenta);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Controls.Add(this.lblSexo);
            this.panel2.Controls.Add(this.lblDni);
            this.panel2.Controls.Add(this.lblApellido);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Location = new System.Drawing.Point(463, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(65, 379);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(227, 37);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbTipoCuenta
            // 
            this.cbTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCuenta.FormattingEnabled = true;
            this.cbTipoCuenta.Items.AddRange(new object[] {
            "Caja de ahorro",
            "Cuenta corriente"});
            this.cbTipoCuenta.Location = new System.Drawing.Point(118, 336);
            this.cbTipoCuenta.Name = "cbTipoCuenta";
            this.cbTipoCuenta.Size = new System.Drawing.Size(104, 21);
            this.cbTipoCuenta.TabIndex = 17;
            // 
            // cbSexo
            // 
            this.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(118, 141);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(104, 21);
            this.cbSexo.TabIndex = 16;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(118, 297);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(104, 22);
            this.txtSaldo.TabIndex = 15;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCuenta.Location = new System.Drawing.Point(118, 259);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(193, 22);
            this.txtNumeroCuenta.TabIndex = 14;
            // 
            // txtLimite
            // 
            this.txtLimite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimite.Location = new System.Drawing.Point(118, 219);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(104, 22);
            this.txtLimite.TabIndex = 13;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(118, 180);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 22);
            this.txtCodigo.TabIndex = 12;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(118, 102);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(193, 22);
            this.txtDni.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(118, 63);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(193, 22);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(118, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // lblSaldoCuenta
            // 
            this.lblSaldoCuenta.AutoSize = true;
            this.lblSaldoCuenta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaldoCuenta.Location = new System.Drawing.Point(73, 300);
            this.lblSaldoCuenta.Name = "lblSaldoCuenta";
            this.lblSaldoCuenta.Size = new System.Drawing.Size(36, 13);
            this.lblSaldoCuenta.TabIndex = 8;
            this.lblSaldoCuenta.Text = "Saldo";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoCuenta.Location = new System.Drawing.Point(28, 339);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(82, 13);
            this.lblTipoCuenta.TabIndex = 7;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            this.lblTipoCuenta.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroCuenta.Location = new System.Drawing.Point(11, 261);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(102, 13);
            this.lblNumeroCuenta.TabIndex = 6;
            this.lblNumeroCuenta.Text = "Numero de Cuenta";
            // 
            // lblLimiteCuenta
            // 
            this.lblLimiteCuenta.AutoSize = true;
            this.lblLimiteCuenta.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimiteCuenta.Location = new System.Drawing.Point(23, 222);
            this.lblLimiteCuenta.Name = "lblLimiteCuenta";
            this.lblLimiteCuenta.Size = new System.Drawing.Size(93, 13);
            this.lblLimiteCuenta.TabIndex = 5;
            this.lblLimiteCuenta.Text = "Limite de credito";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCodigo.Location = new System.Drawing.Point(67, 183);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSexo.Location = new System.Drawing.Point(76, 144);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDni.Location = new System.Drawing.Point(81, 105);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(63, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AllowDrop = true;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(63, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbClientes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 357);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbClientes
            // 
            this.lbClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.ItemHeight = 17;
            this.lbClientes.Location = new System.Drawing.Point(0, 0);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(463, 357);
            this.lbClientes.TabIndex = 0;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // btnCantAhorro
            // 
            this.btnCantAhorro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCantAhorro.FlatAppearance.BorderSize = 0;
            this.btnCantAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantAhorro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantAhorro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCantAhorro.Location = new System.Drawing.Point(21, 371);
            this.btnCantAhorro.Name = "btnCantAhorro";
            this.btnCantAhorro.Size = new System.Drawing.Size(104, 23);
            this.btnCantAhorro.TabIndex = 2;
            this.btnCantAhorro.Text = "Cant. Ahorros";
            this.btnCantAhorro.UseVisualStyleBackColor = false;
            this.btnCantAhorro.Click += new System.EventHandler(this.btnCantAhorro_Click);
            // 
            // bntCantCorriente
            // 
            this.bntCantCorriente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bntCantCorriente.FlatAppearance.BorderSize = 0;
            this.bntCantCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCantCorriente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCantCorriente.ForeColor = System.Drawing.SystemColors.Control;
            this.bntCantCorriente.Location = new System.Drawing.Point(179, 371);
            this.bntCantCorriente.Name = "bntCantCorriente";
            this.bntCantCorriente.Size = new System.Drawing.Size(104, 23);
            this.bntCantCorriente.TabIndex = 3;
            this.bntCantCorriente.Text = "Cant. Corrientes";
            this.bntCantCorriente.UseVisualStyleBackColor = false;
            this.bntCantCorriente.Click += new System.EventHandler(this.bntCantCorriente_Click);
            // 
            // btnPorcFemenino
            // 
            this.btnPorcFemenino.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPorcFemenino.FlatAppearance.BorderSize = 0;
            this.btnPorcFemenino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcFemenino.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcFemenino.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPorcFemenino.Location = new System.Drawing.Point(337, 371);
            this.btnPorcFemenino.Name = "btnPorcFemenino";
            this.btnPorcFemenino.Size = new System.Drawing.Size(104, 23);
            this.btnPorcFemenino.TabIndex = 4;
            this.btnPorcFemenino.Text = "Porc. Femenino";
            this.btnPorcFemenino.UseVisualStyleBackColor = false;
            this.btnPorcFemenino.Click += new System.EventHandler(this.btnPorcFemenino_Click);
            // 
            // btnMayorCredito
            // 
            this.btnMayorCredito.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMayorCredito.FlatAppearance.BorderSize = 0;
            this.btnMayorCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayorCredito.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayorCredito.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMayorCredito.Location = new System.Drawing.Point(337, 412);
            this.btnMayorCredito.Name = "btnMayorCredito";
            this.btnMayorCredito.Size = new System.Drawing.Size(104, 23);
            this.btnMayorCredito.TabIndex = 6;
            this.btnMayorCredito.Text = "Mayor Credito";
            this.btnMayorCredito.UseVisualStyleBackColor = false;
            // 
            // btnPromSaldo
            // 
            this.btnPromSaldo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPromSaldo.FlatAppearance.BorderSize = 0;
            this.btnPromSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromSaldo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromSaldo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPromSaldo.Location = new System.Drawing.Point(179, 412);
            this.btnPromSaldo.Name = "btnPromSaldo";
            this.btnPromSaldo.Size = new System.Drawing.Size(104, 23);
            this.btnPromSaldo.TabIndex = 7;
            this.btnPromSaldo.Text = "Prom. Saldo";
            this.btnPromSaldo.UseVisualStyleBackColor = false;
            // 
            // cbPromSaldo
            // 
            this.cbPromSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPromSaldo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPromSaldo.FormattingEnabled = true;
            this.cbPromSaldo.Items.AddRange(new object[] {
            "Caja de ahorro",
            "Cuenta corriente"});
            this.cbPromSaldo.Location = new System.Drawing.Point(55, 414);
            this.cbPromSaldo.Name = "cbPromSaldo";
            this.cbPromSaldo.Size = new System.Drawing.Size(104, 21);
            this.cbPromSaldo.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromSaldo);
            this.Controls.Add(this.cbPromSaldo);
            this.Controls.Add(this.btnMayorCredito);
            this.Controls.Add(this.btnPorcFemenino);
            this.Controls.Add(this.bntCantCorriente);
            this.Controls.Add(this.btnCantAhorro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.Label lblLimiteCuenta;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbTipoCuenta;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSaldoCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCantAhorro;
        private System.Windows.Forms.Button bntCantCorriente;
        private System.Windows.Forms.Button btnPorcFemenino;
        private System.Windows.Forms.Button btnMayorCredito;
        private System.Windows.Forms.Button btnPromSaldo;
        private System.Windows.Forms.ComboBox cbPromSaldo;
        private System.Windows.Forms.ListBox lbClientes;
    }
}

