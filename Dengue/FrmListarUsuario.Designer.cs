namespace P2Dengue
{
    partial class FrmListarUsuario
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
            this.dgv_listarUsuario = new System.Windows.Forms.DataGridView();
            this.btn_fechar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listarUsuario
            // 
            this.dgv_listarUsuario.AllowUserToAddRows = false;
            this.dgv_listarUsuario.AllowUserToDeleteRows = false;
            this.dgv_listarUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_listarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarUsuario.GridColor = System.Drawing.SystemColors.Info;
            this.dgv_listarUsuario.Location = new System.Drawing.Point(1, 3);
            this.dgv_listarUsuario.Name = "dgv_listarUsuario";
            this.dgv_listarUsuario.ReadOnly = true;
            this.dgv_listarUsuario.RowTemplate.Height = 25;
            this.dgv_listarUsuario.Size = new System.Drawing.Size(673, 399);
            this.dgv_listarUsuario.TabIndex = 4;
            this.dgv_listarUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listarUsuario_CellContentClick);
            // 
            // btn_fechar2
            // 
            this.btn_fechar2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_fechar2.Location = new System.Drawing.Point(568, 408);
            this.btn_fechar2.Name = "btn_fechar2";
            this.btn_fechar2.Size = new System.Drawing.Size(106, 38);
            this.btn_fechar2.TabIndex = 6;
            this.btn_fechar2.Text = "Fechar";
            this.btn_fechar2.UseVisualStyleBackColor = true;
            this.btn_fechar2.Click += new System.EventHandler(this.btn_fechar2_Click);
            // 
            // FrmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 448);
            this.Controls.Add(this.btn_fechar2);
            this.Controls.Add(this.dgv_listarUsuario);
            this.Name = "FrmListarUsuario";
            this.Text = "Listar Usuario";
            this.Load += new System.EventHandler(this.FrmListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_listarUsuario;
        private Button btn_fechar2;
    }
}