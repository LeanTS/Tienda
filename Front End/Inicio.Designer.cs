namespace Front_End
{
    partial class Inicio
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
            this.txtbx_user = new System.Windows.Forms.TextBox();
            this.txtbx_pass = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_user
            // 
            this.txtbx_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_user.Location = new System.Drawing.Point(22, 45);
            this.txtbx_user.Name = "txtbx_user";
            this.txtbx_user.Size = new System.Drawing.Size(163, 23);
            this.txtbx_user.TabIndex = 0;
            // 
            // txtbx_pass
            // 
            this.txtbx_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_pass.Location = new System.Drawing.Point(22, 100);
            this.txtbx_pass.Name = "txtbx_pass";
            this.txtbx_pass.Size = new System.Drawing.Size(163, 23);
            this.txtbx_pass.TabIndex = 1;
            this.txtbx_pass.UseSystemPasswordChar = true;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_user.Location = new System.Drawing.Point(18, 22);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(167, 20);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "Ingrese un Usuario:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_pass.Location = new System.Drawing.Point(18, 77);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(107, 20);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_iniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_iniciar.Location = new System.Drawing.Point(219, 94);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(55, 29);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aviso.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_aviso.Location = new System.Drawing.Point(191, 22);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(116, 69);
            this.lbl_aviso.TabIndex = 5;
            this.lbl_aviso.Text = "Si eres cliente escribe \"Cliente\" en usuario y presione iniciar.";
            this.lbl_aviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tienda
            // 
            this.AcceptButton = this.btn_iniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(327, 154);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txtbx_pass);
            this.Controls.Add(this.txtbx_user);
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crystal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_user;
        private System.Windows.Forms.TextBox txtbx_pass;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_aviso;
    }
}

