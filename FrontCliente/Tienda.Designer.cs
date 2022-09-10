namespace FrontCliente
{
    partial class Tienda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Chupetin");
            this.lblbienvenida = new System.Windows.Forms.Label();
            this.listprod = new System.Windows.Forms.ListView();
            this.col_golosinas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_bebidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_cigarrillos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_artlimpieza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_almacen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblbienvenida
            // 
            this.lblbienvenida.AutoSize = true;
            this.lblbienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenida.Location = new System.Drawing.Point(264, 20);
            this.lblbienvenida.Name = "lblbienvenida";
            this.lblbienvenida.Size = new System.Drawing.Size(226, 25);
            this.lblbienvenida.TabIndex = 0;
            this.lblbienvenida.Text = "¡Bienvenido a Crystal!";
            // 
            // listprod
            // 
            this.listprod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listprod.CheckBoxes = true;
            this.listprod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_golosinas,
            this.col_bebidas,
            this.col_almacen,
            this.col_cigarrillos,
            this.col_artlimpieza});
            this.listprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listprod.HideSelection = false;
            listViewItem1.IndentCount = 1;
            listViewItem1.StateImageIndex = 0;
            this.listprod.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listprod.Location = new System.Drawing.Point(24, 101);
            this.listprod.Name = "listprod";
            this.listprod.Size = new System.Drawing.Size(372, 306);
            this.listprod.TabIndex = 1;
            this.listprod.UseCompatibleStateImageBehavior = false;
            this.listprod.View = System.Windows.Forms.View.Details;
            this.listprod.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // col_golosinas
            // 
            this.col_golosinas.Text = "GOLOSINAS";
            this.col_golosinas.Width = 84;
            // 
            // col_bebidas
            // 
            this.col_bebidas.Text = "Bebidas";
            this.col_bebidas.Width = 62;
            // 
            // col_cigarrillos
            // 
            this.col_cigarrillos.DisplayIndex = 2;
            this.col_cigarrillos.Text = "Cigarrillos";
            this.col_cigarrillos.Width = 72;
            // 
            // col_artlimpieza
            // 
            this.col_artlimpieza.DisplayIndex = 3;
            this.col_artlimpieza.Text = "Art.Limpieza";
            this.col_artlimpieza.Width = 82;
            // 
            // col_almacen
            // 
            this.col_almacen.DisplayIndex = 4;
            this.col_almacen.Text = "Almacen";
            this.col_almacen.Width = 66;
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.listprod);
            this.Controls.Add(this.lblbienvenida);
            this.Name = "Tienda";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenida;
        private System.Windows.Forms.ListView listprod;
        private System.Windows.Forms.ColumnHeader col_golosinas;
        private System.Windows.Forms.ColumnHeader col_bebidas;
        private System.Windows.Forms.ColumnHeader col_cigarrillos;
        private System.Windows.Forms.ColumnHeader col_almacen;
        private System.Windows.Forms.ColumnHeader col_artlimpieza;
    }
}

