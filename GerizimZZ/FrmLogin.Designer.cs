namespace GerizimZZ
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.chbxmotrar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(23, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(160, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de Usuario :";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.Location = new System.Drawing.Point(23, 101);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(97, 21);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña :";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(223, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(294, 28);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.Location = new System.Drawing.Point(223, 98);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(294, 28);
            this.txtContraseña.TabIndex = 3;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalir.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalir.Location = new System.Drawing.Point(68, 200);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(138, 55);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click_1);
            // 
            // btConectar
            // 
            this.btConectar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConectar.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConectar.Location = new System.Drawing.Point(318, 200);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(138, 55);
            this.btConectar.TabIndex = 5;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = false;
            this.btConectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // chbxmotrar
            // 
            this.chbxmotrar.AutoSize = true;
            this.chbxmotrar.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbxmotrar.Location = new System.Drawing.Point(373, 153);
            this.chbxmotrar.Name = "chbxmotrar";
            this.chbxmotrar.Size = new System.Drawing.Size(144, 21);
            this.chbxmotrar.TabIndex = 6;
            this.chbxmotrar.Text = "Mostrar Contraseña";
            this.chbxmotrar.UseVisualStyleBackColor = true;
            this.chbxmotrar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerizimZZ.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 286);
            this.Controls.Add(this.chbxmotrar);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btSalir;
        private Button btConectar;
        private CheckBox chbxmotrar;
    }
}