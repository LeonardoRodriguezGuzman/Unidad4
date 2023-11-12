namespace Unidad4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelTienda = new Panel();
            cbEmpleados = new ComboBox();
            lblEmpleado = new Label();
            PanelTabla = new Panel();
            btnAgregar = new Button();
            txtProducto = new TextBox();
            lblBuscar = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelTotal = new Panel();
            panel1 = new Panel();
            cbCliente = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            cbProveedor = new ComboBox();
            lblShipper = new Label();
            panel3 = new Panel();
            dtpFehcaEnvio = new DateTimePicker();
            dtpFechaEntrega = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            PanelTienda.SuspendLayout();
            PanelTabla.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // PanelTienda
            // 
            PanelTienda.Controls.Add(cbEmpleados);
            PanelTienda.Controls.Add(lblEmpleado);
            PanelTienda.Location = new Point(16, 14);
            PanelTienda.Name = "PanelTienda";
            PanelTienda.Size = new Size(200, 33);
            PanelTienda.TabIndex = 0;
            // 
            // cbEmpleados
            // 
            cbEmpleados.FormattingEnabled = true;
            cbEmpleados.Location = new Point(66, 5);
            cbEmpleados.Name = "cbEmpleados";
            cbEmpleados.Size = new Size(121, 23);
            cbEmpleados.TabIndex = 1;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(6, 9);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(63, 15);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado:";
            // 
            // PanelTabla
            // 
            PanelTabla.Controls.Add(btnAgregar);
            PanelTabla.Controls.Add(txtProducto);
            PanelTabla.Controls.Add(lblBuscar);
            PanelTabla.Controls.Add(tableLayoutPanel1);
            PanelTabla.Location = new Point(16, 111);
            PanelTabla.Name = "PanelTabla";
            PanelTabla.Size = new Size(597, 214);
            PanelTabla.TabIndex = 2;
            PanelTabla.Paint += panel1_Paint;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(400, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(57, 5);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(334, 23);
            txtProducto.TabIndex = 2;
            txtProducto.KeyDown += txtProducto_KeyDown;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(9, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.Location = new Point(3, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(584, 180);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // PanelTotal
            // 
            PanelTotal.Location = new Point(16, 331);
            PanelTotal.Name = "PanelTotal";
            PanelTotal.Size = new Size(597, 107);
            PanelTotal.TabIndex = 3;
            PanelTotal.Paint += panel1_Paint_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCliente);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(222, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 33);
            panel1.TabIndex = 4;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(53, 6);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(121, 23);
            cbCliente.TabIndex = 1;
            cbCliente.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbProveedor);
            panel2.Controls.Add(lblShipper);
            panel2.Location = new Point(413, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 33);
            panel2.TabIndex = 2;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(69, 5);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(121, 23);
            cbProveedor.TabIndex = 1;
            // 
            // lblShipper
            // 
            lblShipper.AutoSize = true;
            lblShipper.Location = new Point(3, 9);
            lblShipper.Name = "lblShipper";
            lblShipper.Size = new Size(63, 15);
            lblShipper.TabIndex = 0;
            lblShipper.Text = "Expedidor:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dtpFehcaEnvio);
            panel3.Controls.Add(dtpFechaEntrega);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(16, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(597, 33);
            panel3.TabIndex = 5;
            // 
            // dtpFehcaEnvio
            // 
            dtpFehcaEnvio.Location = new Point(394, 3);
            dtpFehcaEnvio.Name = "dtpFehcaEnvio";
            dtpFehcaEnvio.Size = new Size(200, 23);
            dtpFehcaEnvio.TabIndex = 3;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(100, 3);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(200, 23);
            dtpFechaEntrega.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 7);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 1;
            label4.Text = "Feha de Envio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 7);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha de Entrega";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PanelTotal);
            Controls.Add(PanelTabla);
            Controls.Add(PanelTienda);
            Name = "Form1";
            Text = "Form1";
            PanelTienda.ResumeLayout(false);
            PanelTienda.PerformLayout();
            PanelTabla.ResumeLayout(false);
            PanelTabla.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTienda;
        private Label lblEmpleado;
        private Panel PanelTabla;
        private Panel PanelTotal;
        private ComboBox cbEmpleados;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtProducto;
        private Label lblBuscar;
        private Panel panel1;
        private ComboBox cbCliente;
        private Label label1;
        private Panel panel2;
        private ComboBox cbProveedor;
        private Label lblShipper;
        private Panel panel3;
        private DateTimePicker dtpFehcaEnvio;
        private DateTimePicker dtpFechaEntrega;
        private Label label4;
        private Label label3;
        private Button btnAgregar;
    }
}