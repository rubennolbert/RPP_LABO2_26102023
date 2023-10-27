namespace WinFormsApp1
{
    partial class frmFabricaDeVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFabricaDeVehiculos));
            lstVehiculos = new ListBox();
            lblTipoDeVehiculo = new Label();
            btnFabricar = new Button();
            btnEliminar = new Button();
            cmbTipoDeVehiculos = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(12, 27);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(408, 349);
            lstVehiculos.TabIndex = 0;
            lstVehiculos.SelectedIndexChanged += lstVehiculos_SelectedIndexChanged;
            // 
            // lblTipoDeVehiculo
            // 
            lblTipoDeVehiculo.AutoSize = true;
            lblTipoDeVehiculo.Location = new Point(549, 38);
            lblTipoDeVehiculo.Name = "lblTipoDeVehiculo";
            lblTipoDeVehiculo.Size = new Size(94, 15);
            lblTipoDeVehiculo.TabIndex = 1;
            lblTipoDeVehiculo.Text = "Tipo de vehiculo";
            lblTipoDeVehiculo.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(549, 228);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(134, 23);
            btnFabricar.TabIndex = 2;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(549, 286);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbTipoDeVehiculos
            // 
            cmbTipoDeVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeVehiculos.FormattingEnabled = true;
            cmbTipoDeVehiculos.Location = new Point(549, 74);
            cmbTipoDeVehiculos.Name = "cmbTipoDeVehiculos";
            cmbTipoDeVehiculos.Size = new Size(121, 23);
            cmbTipoDeVehiculos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_vehicles_64;
            pictureBox1.Location = new Point(570, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 87);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmFabricaDeVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cmbTipoDeVehiculos);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(lblTipoDeVehiculo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFabricaDeVehiculos";
            Text = "Fabrica de Vehiculos";
            Load += frmFabricaDeVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipoDeVehiculo;
        private Button btnFabricar;
        private Button btnEliminar;
        private ComboBox cmbTipoDeVehiculos;
        private PictureBox pictureBox1;
    }
}