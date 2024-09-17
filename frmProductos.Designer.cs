namespace PresentaciónTienda
{
    partial class frmProductos
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
            this.dgvtProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtProductos
            // 
            this.dgvtProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtProductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtProductos.Location = new System.Drawing.Point(12, 68);
            this.dgvtProductos.Name = "dgvtProductos";
            this.dgvtProductos.Size = new System.Drawing.Size(573, 370);
            this.dgvtProductos.TabIndex = 0;
//            this.dgvtProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtProductos_CellClick);
            this.dgvtProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("QuiverItal", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODUCTOS";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(180, 22);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(405, 31);
            this.txtProducto.TabIndex = 5;
            this.txtProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentaciónTienda.Properties.Resources.jdjdj_Mesa_de_trabajo_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvtProductos);
            this.DoubleBuffered = true;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvtProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducto;
    }
}