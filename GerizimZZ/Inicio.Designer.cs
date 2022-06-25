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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.barraBusqueda = new System.Windows.Forms.TextBox();
            this.Contenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnclientesmi = new FontAwesome.Sharp.IconButton();
            this.VInicio = new FontAwesome.Sharp.IconButton();
            this.btnpedidosmi = new FontAwesome.Sharp.IconButton();
            this.btninventariomi = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregresarMI = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_titlebar.SuspendLayout();
            this.panelsidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(339, -26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 143);
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
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.barraBusqueda);
            this.panel1.Controls.Add(this.Contenedor);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 471);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::GerizimZZ.Properties.Resources.shopping_cart;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(733, 51);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 40);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_Hover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GerizimZZ.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(767, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GerizimZZ.Properties.Resources.menu__2_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(806, 51);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 40);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_Hover);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.Transparent;
            this.bt.BackgroundImage = global::GerizimZZ.Properties.Resources.menu;
            this.bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt.FlatAppearance.BorderSize = 0;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt.Location = new System.Drawing.Point(81, 51);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(47, 40);
            this.bt.TabIndex = 5;
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources.substract;
            this.pictureBox2.Location = new System.Drawing.Point(81, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // barraBusqueda
            // 
            this.barraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraBusqueda.Location = new System.Drawing.Point(211, 124);
            this.barraBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barraBusqueda.Multiline = true;
            this.barraBusqueda.Name = "barraBusqueda";
            this.barraBusqueda.Size = new System.Drawing.Size(532, 35);
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
            this.Contenedor.Location = new System.Drawing.Point(96, 165);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(756, 284);
            this.Contenedor.TabIndex = 6;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 15;
            this.btnCerrar.Location = new System.Drawing.Point(620, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 45D;
            this.btnCerrar.Size = new System.Drawing.Size(31, 22);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorProvider1.SetIconAlignment(this.btnMaximizar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.Black;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMaximizar.IconSize = 15;
            this.btnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximizar.Location = new System.Drawing.Point(585, 12);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 22);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorProvider1.SetIconAlignment(this.btnMinimizar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMinimizar.IconSize = 15;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(549, 12);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 22);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.Controls.Add(this.btnCerrar);
            this.panel_titlebar.Controls.Add(this.btnMaximizar);
            this.panel_titlebar.Controls.Add(this.btnMinimizar);
            this.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_titlebar.Location = new System.Drawing.Point(236, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(675, 509);
            this.panel_titlebar.TabIndex = 2;
            this.panel_titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_titlebar_Paint);
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.panelsidemenu.Controls.Add(this.pictureBox3);
            this.panelsidemenu.Controls.Add(this.btnclientesmi);
            this.panelsidemenu.Controls.Add(this.VInicio);
            this.panelsidemenu.Controls.Add(this.btnpedidosmi);
            this.panelsidemenu.Controls.Add(this.btninventariomi);
            this.panelsidemenu.Controls.Add(this.panel3);
            this.panelsidemenu.Controls.Add(this.label1);
            this.panelsidemenu.Controls.Add(this.btnregresarMI);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(220, 509);
            this.panelsidemenu.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox3.Location = new System.Drawing.Point(63, 444);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnclientesmi
            // 
            this.btnclientesmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnclientesmi.FlatAppearance.BorderSize = 0;
            this.btnclientesmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientesmi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclientesmi.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnclientesmi.IconColor = System.Drawing.Color.Black;
            this.btnclientesmi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclientesmi.IconSize = 35;
            this.btnclientesmi.Location = new System.Drawing.Point(32, 372);
            this.btnclientesmi.Name = "btnclientesmi";
            this.btnclientesmi.Padding = new System.Windows.Forms.Padding(9);
            this.btnclientesmi.Size = new System.Drawing.Size(133, 50);
            this.btnclientesmi.TabIndex = 10;
            this.btnclientesmi.Tag = "user";
            this.btnclientesmi.Text = "Clientes";
            this.btnclientesmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclientesmi.UseVisualStyleBackColor = false;
            this.btnclientesmi.MouseLeave += new System.EventHandler(this.btnclientesmi_MouseLeaves);
            this.btnclientesmi.MouseHover += new System.EventHandler(this.btnclientesmi_Hover);
            // 
            // VInicio
            // 
            this.VInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.VInicio.FlatAppearance.BorderSize = 0;
            this.VInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VInicio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VInicio.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.VInicio.IconColor = System.Drawing.Color.Black;
            this.VInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VInicio.IconSize = 35;
            this.VInicio.Location = new System.Drawing.Point(32, 302);
            this.VInicio.Name = "VInicio";
            this.VInicio.Padding = new System.Windows.Forms.Padding(9);
            this.VInicio.Size = new System.Drawing.Size(133, 50);
            this.VInicio.TabIndex = 9;
            this.VInicio.Tag = "ventas";
            this.VInicio.Text = "Ventas";
            this.VInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VInicio.UseVisualStyleBackColor = false;
            this.VInicio.Click += new System.EventHandler(this.btnventasmi_Click);
            this.VInicio.MouseLeave += new System.EventHandler(this.btnventasmi_MouseLeaves);
            this.VInicio.MouseHover += new System.EventHandler(this.btnventasmi_Hover);
            // 
            // btnpedidosmi
            // 
            this.btnpedidosmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btnpedidosmi.FlatAppearance.BorderSize = 0;
            this.btnpedidosmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpedidosmi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpedidosmi.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnpedidosmi.IconColor = System.Drawing.Color.Black;
            this.btnpedidosmi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpedidosmi.IconSize = 35;
            this.btnpedidosmi.Location = new System.Drawing.Point(32, 226);
            this.btnpedidosmi.Name = "btnpedidosmi";
            this.btnpedidosmi.Padding = new System.Windows.Forms.Padding(9);
            this.btnpedidosmi.Size = new System.Drawing.Size(133, 50);
            this.btnpedidosmi.TabIndex = 8;
            this.btnpedidosmi.Tag = "pedidos";
            this.btnpedidosmi.Text = "Pedidos";
            this.btnpedidosmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpedidosmi.UseVisualStyleBackColor = false;
            this.btnpedidosmi.MouseLeave += new System.EventHandler(this.btnpedidosmi_MouseLeaves);
            this.btnpedidosmi.MouseHover += new System.EventHandler(this.btnpedidosmi_Hover);
            // 
            // btninventariomi
            // 
            this.btninventariomi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.btninventariomi.FlatAppearance.BorderSize = 0;
            this.btninventariomi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventariomi.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btninventariomi.IconChar = FontAwesome.Sharp.IconChar.CommentMedical;
            this.btninventariomi.IconColor = System.Drawing.Color.Black;
            this.btninventariomi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninventariomi.IconSize = 35;
            this.btninventariomi.Location = new System.Drawing.Point(32, 151);
            this.btninventariomi.Name = "btninventariomi";
            this.btninventariomi.Padding = new System.Windows.Forms.Padding(9);
            this.btninventariomi.Size = new System.Drawing.Size(133, 50);
            this.btninventariomi.TabIndex = 7;
            this.btninventariomi.Tag = "Inventario";
            this.btninventariomi.Text = "Inventario";
            this.btninventariomi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninventariomi.UseVisualStyleBackColor = false;
            this.btninventariomi.Click += new System.EventHandler(this.btninventariomi_Click);
            this.btninventariomi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn);
            this.btninventariomi.MouseEnter += new System.EventHandler(this.btninventariomi_Click);
            this.btninventariomi.MouseLeave += new System.EventHandler(this.btninventarioomi_MouseLeaves);
            this.btninventariomi.MouseHover += new System.EventHandler(this.btninventarioomi_Hover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(11, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 1);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Menu";
            this.label1.Text = "MENU";
            // 
            // btnregresarMI
            // 
            this.btnregresarMI.BackColor = System.Drawing.Color.Transparent;
            this.btnregresarMI.FlatAppearance.BorderSize = 0;
            this.btnregresarMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresarMI.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnregresarMI.IconColor = System.Drawing.Color.Black;
            this.btnregresarMI.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregresarMI.Location = new System.Drawing.Point(11, 12);
            this.btnregresarMI.Name = "btnregresarMI";
            this.btnregresarMI.Size = new System.Drawing.Size(45, 47);
            this.btnregresarMI.TabIndex = 0;
            this.btnregresarMI.UseVisualStyleBackColor = false;
            this.btnregresarMI.Click += new System.EventHandler(this.btnregresarMI_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(911, 509);
            this.Controls.Add(this.panelsidemenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titlebar);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_titlebar.ResumeLayout(false);
            this.panelsidemenu.ResumeLayout(false);
            this.panelsidemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
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
        private FontAwesome.Sharp.IconButton VInicio;
        private FontAwesome.Sharp.IconButton btnpedidosmi;
        private FontAwesome.Sharp.IconButton btninventariomi;
        private Panel panel3;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnregresarMI;
        private PictureBox pictureBox3;
        private Button button1;
        public FlowLayoutPanel Contenedor;
        private Button button3;
        public TextBox barraBusqueda;
    }
}