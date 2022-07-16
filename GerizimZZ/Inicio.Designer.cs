namespace GerizimZZ
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBodega = new System.Windows.Forms.Button();
            this.btnDetalleVenta = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnMenuIzquierdo = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.barraBusqueda = new System.Windows.Forms.TextBox();
            this.Contenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.lblUsernma = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelsidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(370, -29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBodega);
            this.panel1.Controls.Add(this.btnDetalleVenta);
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMenuIzquierdo);
            this.panel1.Controls.Add(this.bt);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.barraBusqueda);
            this.panel1.Controls.Add(this.Contenedor);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 619);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(544, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "VENTAS";
            // 
            // btnBodega
            // 
            this.btnBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBodega.BackColor = System.Drawing.Color.Transparent;
            this.btnBodega.BackgroundImage = global::GerizimZZ.Properties.Resources.warehouse;
            this.btnBodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBodega.FlatAppearance.BorderSize = 0;
            this.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBodega.ForeColor = System.Drawing.Color.Transparent;
            this.btnBodega.Location = new System.Drawing.Point(862, 58);
            this.btnBodega.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Size = new System.Drawing.Size(48, 45);
            this.btnBodega.TabIndex = 9;
            this.btnBodega.UseVisualStyleBackColor = false;
            this.btnBodega.Click += new System.EventHandler(this.btnBodega_Click);
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalleVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnDetalleVenta.BackgroundImage = global::GerizimZZ.Properties.Resources.shopping_cart;
            this.btnDetalleVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetalleVenta.FlatAppearance.BorderSize = 0;
            this.btnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleVenta.ForeColor = System.Drawing.Color.Transparent;
            this.btnDetalleVenta.Location = new System.Drawing.Point(950, 58);
            this.btnDetalleVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(48, 45);
            this.btnDetalleVenta.TabIndex = 8;
            this.btnDetalleVenta.UseVisualStyleBackColor = false;
            this.btnDetalleVenta.Click += new System.EventHandler(this.button3_Click);
            this.btnDetalleVenta.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.btnDetalleVenta.MouseHover += new System.EventHandler(this.button3_Hover);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.BackgroundImage = global::GerizimZZ.Properties.Resources.search;
            this.btnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusqueda.Location = new System.Drawing.Point(959, 152);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(30, 28);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenuIzquierdo
            // 
            this.btnMenuIzquierdo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenuIzquierdo.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuIzquierdo.BackgroundImage = global::GerizimZZ.Properties.Resources.menu__2_;
            this.btnMenuIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuIzquierdo.FlatAppearance.BorderSize = 0;
            this.btnMenuIzquierdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuIzquierdo.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenuIzquierdo.Location = new System.Drawing.Point(1028, 58);
            this.btnMenuIzquierdo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenuIzquierdo.Name = "btnMenuIzquierdo";
            this.btnMenuIzquierdo.Size = new System.Drawing.Size(51, 45);
            this.btnMenuIzquierdo.TabIndex = 3;
            this.btnMenuIzquierdo.UseVisualStyleBackColor = false;
            this.btnMenuIzquierdo.Click += new System.EventHandler(this.button2_Click);
            this.btnMenuIzquierdo.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnMenuIzquierdo.MouseHover += new System.EventHandler(this.button2_Hover);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.Transparent;
            this.bt.BackgroundImage = global::GerizimZZ.Properties.Resources.menu;
            this.bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt.FlatAppearance.BorderSize = 0;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.Location = new System.Drawing.Point(35, 34);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(51, 45);
            this.bt.TabIndex = 5;
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources.substract;
            this.pictureBox2.Location = new System.Drawing.Point(35, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1065, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(128, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // barraBusqueda
            // 
            this.barraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraBusqueda.Location = new System.Drawing.Point(230, 141);
            this.barraBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barraBusqueda.Multiline = true;
            this.barraBusqueda.Name = "barraBusqueda";
            this.barraBusqueda.Size = new System.Drawing.Size(712, 39);
            this.barraBusqueda.TabIndex = 1;
            this.barraBusqueda.TextChanged += new System.EventHandler(this.BarraBusqueda_TextChanged);
            // 
            // Contenedor
            // 
            this.Contenedor.AllowDrop = true;
            this.Contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contenedor.AutoScroll = true;
            this.Contenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Contenedor.BackColor = System.Drawing.Color.Transparent;
            this.Contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contenedor.Location = new System.Drawing.Point(35, 187);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1065, 420);
            this.Contenedor.TabIndex = 6;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_titlebar.Location = new System.Drawing.Point(390, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(736, 662);
            this.panel_titlebar.TabIndex = 2;
            this.panel_titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_titlebar_Paint);
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.panelsidemenu.Controls.Add(this.lblUsernma);
            this.panelsidemenu.Controls.Add(this.pcbLogo);
            this.panelsidemenu.Controls.Add(this.panel3);
            this.panelsidemenu.Controls.Add(this.label1);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(240, 662);
            this.panelsidemenu.TabIndex = 11;
            this.panelsidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsidemenu_Paint);
            // 
            // lblUsernma
            // 
            this.lblUsernma.AutoSize = true;
            this.lblUsernma.Location = new System.Drawing.Point(86, 544);
            this.lblUsernma.Name = "lblUsernma";
            this.lblUsernma.Size = new System.Drawing.Size(0, 20);
            this.lblUsernma.TabIndex = 12;
            this.lblUsernma.Visible = false;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pcbLogo.Location = new System.Drawing.Point(57, 567);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(118, 70);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 11;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Menu";
            this.label1.Text = "MENU";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1126, 662);
            this.Controls.Add(this.panelsidemenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titlebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim Ventas";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelsidemenu.ResumeLayout(false);
            this.panelsidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnMenuIzquierdo;
        private PictureBox pictureBox2;
        private Button bt;
        private ErrorProvider errorProvider1;
        private Component1 component11;
        private Component1 component12;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Panel panel_titlebar;
        private Panel panelsidemenu;
        private FontAwesome.Sharp.IconButton btnclientesmi;
        private FontAwesome.Sharp.IconButton btnventasmi;
        private FontAwesome.Sharp.IconButton btnpedidosmi;
        private FontAwesome.Sharp.IconButton btninventariomi;
        private Panel panel3;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnregresarMI;
        private PictureBox pcbLogo;
        private Button btnBusqueda;
        public FlowLayoutPanel Contenedor;
        private Button btnDetalleVenta;
        public TextBox barraBusqueda;
        private Button btnBodega;
        private Label label2;
        private Label lblUsuario;
        public Label lblUsernma;
    }
}