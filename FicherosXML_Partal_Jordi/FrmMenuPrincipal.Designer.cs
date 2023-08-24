
namespace FicherosXML_Partal_Jordi
{
    partial class FrmMenuPrincipal
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
            this.pnl_planetas = new System.Windows.Forms.Panel();
            this.pnl_naves = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_planetas
            // 
            this.pnl_planetas.BackgroundImage = global::FicherosXML_Partal_Jordi.Properties.Resources.x_wing;
            this.pnl_planetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_planetas.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pnl_planetas.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.pnl_planetas.Location = new System.Drawing.Point(300, 0);
            this.pnl_planetas.Name = "pnl_planetas";
            this.pnl_planetas.Size = new System.Drawing.Size(300, 360);
            this.pnl_planetas.TabIndex = 1;
            this.pnl_planetas.Tag = "Nave";
            this.pnl_planetas.Click += new System.EventHandler(this.OnClickPanelSeleccionado);
            // 
            // pnl_naves
            // 
            this.pnl_naves.BackgroundImage = global::FicherosXML_Partal_Jordi.Properties.Resources.earth;
            this.pnl_naves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_naves.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pnl_naves.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.pnl_naves.Location = new System.Drawing.Point(0, 0);
            this.pnl_naves.Name = "pnl_naves";
            this.pnl_naves.Size = new System.Drawing.Size(300, 360);
            this.pnl_naves.TabIndex = 0;
            this.pnl_naves.Tag = "Planeta";
            this.pnl_naves.Click += new System.EventHandler(this.OnClickPanelSeleccionado);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.pnl_planetas);
            this.Controls.Add(this.pnl_naves);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_naves;
        private System.Windows.Forms.Panel pnl_planetas;
    }
}

