namespace Tesis_1.Control
{
    partial class Logica
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pnl_Res = new System.Windows.Forms.Panel();
            this.Pnl_Eval = new System.Windows.Forms.Panel();
            this.Pnl_Q = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Pnl_Res
            // 
            this.Pnl_Res.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Res.Location = new System.Drawing.Point(0, 259);
            this.Pnl_Res.Name = "Pnl_Res";
            this.Pnl_Res.Size = new System.Drawing.Size(439, 114);
            this.Pnl_Res.TabIndex = 0;
            // 
            // Pnl_Eval
            // 
            this.Pnl_Eval.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Eval.Location = new System.Drawing.Point(287, 0);
            this.Pnl_Eval.Name = "Pnl_Eval";
            this.Pnl_Eval.Size = new System.Drawing.Size(152, 259);
            this.Pnl_Eval.TabIndex = 1;
            // 
            // Pnl_Q
            // 
            this.Pnl_Q.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Q.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Q.Name = "Pnl_Q";
            this.Pnl_Q.Size = new System.Drawing.Size(287, 259);
            this.Pnl_Q.TabIndex = 2;
            // 
            // Logica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pnl_Q);
            this.Controls.Add(this.Pnl_Eval);
            this.Controls.Add(this.Pnl_Res);
            this.Name = "Logica";
            this.Size = new System.Drawing.Size(439, 373);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Res;
        private System.Windows.Forms.Panel Pnl_Eval;
        private System.Windows.Forms.Panel Pnl_Q;
    }
}
