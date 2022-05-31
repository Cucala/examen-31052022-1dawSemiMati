namespace JaimeMartinezMartinez34
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageShop = new System.Windows.Forms.PictureBox();
            this.lblComprador = new System.Windows.Forms.Label();
            this.tBoxComprador = new System.Windows.Forms.TextBox();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.bttnCompra = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageShop)).BeginInit();
            this.SuspendLayout();
            // 
            // imageShop
            // 
            this.imageShop.Image = ((System.Drawing.Image)(resources.GetObject("imageShop.Image")));
            this.imageShop.Location = new System.Drawing.Point(28, 95);
            this.imageShop.Name = "imageShop";
            this.imageShop.Size = new System.Drawing.Size(263, 203);
            this.imageShop.TabIndex = 0;
            this.imageShop.TabStop = false;
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Location = new System.Drawing.Point(434, 103);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(85, 20);
            this.lblComprador.TabIndex = 1;
            this.lblComprador.Text = "Comprador";
            // 
            // tBoxComprador
            // 
            this.tBoxComprador.Location = new System.Drawing.Point(548, 103);
            this.tBoxComprador.Name = "tBoxComprador";
            this.tBoxComprador.Size = new System.Drawing.Size(125, 27);
            this.tBoxComprador.TabIndex = 2;
            // 
            // buttonProductos
            // 
            this.buttonProductos.Location = new System.Drawing.Point(288, 347);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(189, 29);
            this.buttonProductos.TabIndex = 3;
            this.buttonProductos.Text = "Añadir Productos";
            this.buttonProductos.UseVisualStyleBackColor = true;
            // 
            // bttnCompra
            // 
            this.bttnCompra.Location = new System.Drawing.Point(288, 415);
            this.bttnCompra.Name = "bttnCompra";
            this.bttnCompra.Size = new System.Drawing.Size(189, 29);
            this.bttnCompra.TabIndex = 4;
            this.bttnCompra.Text = "Añadir lista de la compra";
            this.bttnCompra.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(548, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 104);
            this.listBox1.TabIndex = 5;
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Location = new System.Drawing.Point(377, 155);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(154, 20);
            this.lblListaProductos.TabIndex = 6;
            this.lblListaProductos.Text = "Lista de los productos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(522, 357);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "0 €";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bttnCompra);
            this.Controls.Add(this.buttonProductos);
            this.Controls.Add(this.tBoxComprador);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.imageShop);
            this.Name = "Form1";
            this.Text = "Hola soy el TPV rey";
            ((System.ComponentModel.ISupportInitialize)(this.imageShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imageShop;
        private Label lblComprador;
        private TextBox tBoxComprador;
        private Button buttonProductos;
        private Button bttnCompra;
        private ListBox listBox1;
        private Label lblListaProductos;
        private Label lblTotal;
        private Label label1;
    }
}