namespace JaimeMartinezMartinez34
{
    partial class Form3
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
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOtroProd = new System.Windows.Forms.Button();
            this.bttnFin = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblDescrp = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(69, 369);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(94, 29);
            this.bttnCancel.TabIndex = 0;
            this.bttnCancel.Text = "Cancelar";
            this.bttnCancel.UseVisualStyleBackColor = true;
            // 
            // bttnOtroProd
            // 
            this.bttnOtroProd.Location = new System.Drawing.Point(247, 369);
            this.bttnOtroProd.Name = "bttnOtroProd";
            this.bttnOtroProd.Size = new System.Drawing.Size(94, 29);
            this.bttnOtroProd.TabIndex = 1;
            this.bttnOtroProd.Text = "Otro Producto";
            this.bttnOtroProd.UseVisualStyleBackColor = true;
            // 
            // bttnFin
            // 
            this.bttnFin.Location = new System.Drawing.Point(415, 369);
            this.bttnFin.Name = "bttnFin";
            this.bttnFin.Size = new System.Drawing.Size(94, 29);
            this.bttnFin.TabIndex = 2;
            this.bttnFin.Text = "Finalizar";
            this.bttnFin.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(75, 78);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 20);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto";
            this.lblProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(247, 95);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(0, 20);
            this.lblProd.TabIndex = 4;
            // 
            // lblDescrp
            // 
            this.lblDescrp.AutoSize = true;
            this.lblDescrp.Location = new System.Drawing.Point(247, 161);
            this.lblDescrp.Name = "lblDescrp";
            this.lblDescrp.Size = new System.Drawing.Size(0, 20);
            this.lblDescrp.TabIndex = 5;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(247, 240);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(0, 20);
            this.lblCat.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(247, 315);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 20);
            this.lblPrecio.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblDescrp);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.bttnFin);
            this.Controls.Add(this.bttnOtroProd);
            this.Controls.Add(this.bttnCancel);
            this.Name = "Form3";
            this.Text = "Hola Soy el TPV rey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttnCancel;
        private Button bttnOtroProd;
        private Button bttnFin;
        private Label lblProducto;
        private Label lblProd;
        private Label lblDescrp;
        private Label lblCat;
        private Label lblPrecio;
    }
}