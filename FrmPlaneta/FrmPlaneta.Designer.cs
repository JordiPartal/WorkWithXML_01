
namespace Planeta
{
    partial class FrmPlaneta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.tlp_planeta_alianzas = new System.Windows.Forms.TableLayoutPanel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_contenido = new System.Windows.Forms.ComboBox();
            this.cmb_opciones = new System.Windows.Forms.ComboBox();
            this.pic_carga = new System.Windows.Forms.PictureBox();
            this.timer_carga = new System.Windows.Forms.Timer(this.components);
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_info_planeta = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_planeta = new System.Windows.Forms.Label();
            this.lbl_sector = new System.Windows.Forms.Label();
            this.lbl_nativos = new System.Windows.Forms.Label();
            this.lbl_alianza = new System.Windows.Forms.Label();
            this.lbl_longitud = new System.Windows.Forms.Label();
            this.lbl_latitud = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_rutas = new System.Windows.Forms.ListView();
            this.pic_planeta = new System.Windows.Forms.PictureBox();
            this.tlp_planeta_alianzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.tlp_info_planeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_planeta)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_planeta_alianzas
            // 
            this.tlp_planeta_alianzas.ColumnCount = 7;
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_planeta_alianzas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_planeta_alianzas.Controls.Add(this.btn_buscar, 4, 0);
            this.tlp_planeta_alianzas.Controls.Add(this.cmb_contenido, 2, 0);
            this.tlp_planeta_alianzas.Controls.Add(this.cmb_opciones, 0, 0);
            this.tlp_planeta_alianzas.Controls.Add(this.pic_carga, 5, 0);
            this.tlp_planeta_alianzas.Location = new System.Drawing.Point(16, 32);
            this.tlp_planeta_alianzas.Name = "tlp_planeta_alianzas";
            this.tlp_planeta_alianzas.RowCount = 1;
            this.tlp_planeta_alianzas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_planeta_alianzas.Size = new System.Drawing.Size(1180, 41);
            this.tlp_planeta_alianzas.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(593, 3);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(112, 35);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.BtnBuscarClick);
            // 
            // cmb_contenido
            // 
            this.cmb_contenido.BackColor = System.Drawing.Color.White;
            this.cmb_contenido.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contenido.FormattingEnabled = true;
            this.cmb_contenido.Location = new System.Drawing.Point(298, 3);
            this.cmb_contenido.Name = "cmb_contenido";
            this.cmb_contenido.Size = new System.Drawing.Size(230, 35);
            this.cmb_contenido.TabIndex = 1;
            this.cmb_contenido.SelectedIndexChanged += new System.EventHandler(this.SeleccionEnComboboxContenido);
            // 
            // cmb_opciones
            // 
            this.cmb_opciones.BackColor = System.Drawing.Color.White;
            this.cmb_opciones.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_opciones.FormattingEnabled = true;
            this.cmb_opciones.Location = new System.Drawing.Point(3, 3);
            this.cmb_opciones.Name = "cmb_opciones";
            this.cmb_opciones.Size = new System.Drawing.Size(230, 35);
            this.cmb_opciones.TabIndex = 0;
            this.cmb_opciones.SelectedIndexChanged += new System.EventHandler(this.SeleccionEnComboboxOpciones);
            // 
            // pic_carga
            // 
            this.pic_carga.Location = new System.Drawing.Point(711, 3);
            this.pic_carga.Name = "pic_carga";
            this.pic_carga.Size = new System.Drawing.Size(53, 35);
            this.pic_carga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_carga.TabIndex = 2;
            this.pic_carga.TabStop = false;
            // 
            // timer_carga
            // 
            this.timer_carga.Interval = 5000;
            this.timer_carga.Tick += new System.EventHandler(this.TimerCargaTick);
            // 
            // dgv_datos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.sector,
            this.filiation,
            this.natives});
            this.dgv_datos.Location = new System.Drawing.Point(13, 80);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_datos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_datos.RowTemplate.Height = 24;
            this.dgv_datos.Size = new System.Drawing.Size(710, 320);
            this.dgv_datos.TabIndex = 1;
            this.dgv_datos.SelectionChanged += new System.EventHandler(this.SeleccionDePlaneta);
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // sector
            // 
            this.sector.HeaderText = "Sector";
            this.sector.MinimumWidth = 6;
            this.sector.Name = "sector";
            // 
            // filiation
            // 
            this.filiation.HeaderText = "Alianzas";
            this.filiation.MinimumWidth = 6;
            this.filiation.Name = "filiation";
            // 
            // natives
            // 
            this.natives.HeaderText = "Nativos";
            this.natives.MinimumWidth = 6;
            this.natives.Name = "natives";
            // 
            // tlp_info_planeta
            // 
            this.tlp_info_planeta.ColumnCount = 4;
            this.tlp_info_planeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_planeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_planeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_planeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_info_planeta.Controls.Add(this.label1, 0, 0);
            this.tlp_info_planeta.Controls.Add(this.label2, 0, 2);
            this.tlp_info_planeta.Controls.Add(this.label3, 0, 4);
            this.tlp_info_planeta.Controls.Add(this.label4, 1, 4);
            this.tlp_info_planeta.Controls.Add(this.label5, 0, 6);
            this.tlp_info_planeta.Controls.Add(this.label6, 1, 6);
            this.tlp_info_planeta.Controls.Add(this.lbl_planeta, 0, 1);
            this.tlp_info_planeta.Controls.Add(this.lbl_sector, 0, 3);
            this.tlp_info_planeta.Controls.Add(this.lbl_nativos, 0, 5);
            this.tlp_info_planeta.Controls.Add(this.lbl_alianza, 1, 5);
            this.tlp_info_planeta.Controls.Add(this.lbl_longitud, 0, 7);
            this.tlp_info_planeta.Controls.Add(this.lbl_latitud, 1, 7);
            this.tlp_info_planeta.Controls.Add(this.label7, 2, 0);
            this.tlp_info_planeta.Controls.Add(this.lv_rutas, 2, 1);
            this.tlp_info_planeta.Location = new System.Drawing.Point(13, 407);
            this.tlp_info_planeta.Name = "tlp_info_planeta";
            this.tlp_info_planeta.RowCount = 8;
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_info_planeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_info_planeta.Size = new System.Drawing.Size(1183, 301);
            this.tlp_info_planeta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sector";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Natives";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filiation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Longitude";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Latitude";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_planeta
            // 
            this.lbl_planeta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_planeta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_planeta.Location = new System.Drawing.Point(3, 37);
            this.lbl_planeta.Name = "lbl_planeta";
            this.lbl_planeta.Size = new System.Drawing.Size(289, 37);
            this.lbl_planeta.TabIndex = 6;
            this.lbl_planeta.Text = "[Nombre Planeta]";
            // 
            // lbl_sector
            // 
            this.lbl_sector.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sector.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_sector.Location = new System.Drawing.Point(3, 111);
            this.lbl_sector.Name = "lbl_sector";
            this.lbl_sector.Size = new System.Drawing.Size(289, 37);
            this.lbl_sector.TabIndex = 7;
            this.lbl_sector.Text = "[Nombre Sector]";
            // 
            // lbl_nativos
            // 
            this.lbl_nativos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nativos.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_nativos.Location = new System.Drawing.Point(3, 185);
            this.lbl_nativos.Name = "lbl_nativos";
            this.lbl_nativos.Size = new System.Drawing.Size(289, 37);
            this.lbl_nativos.TabIndex = 8;
            this.lbl_nativos.Text = "[Nativos]";
            // 
            // lbl_alianza
            // 
            this.lbl_alianza.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alianza.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_alianza.Location = new System.Drawing.Point(298, 185);
            this.lbl_alianza.Name = "lbl_alianza";
            this.lbl_alianza.Size = new System.Drawing.Size(289, 37);
            this.lbl_alianza.TabIndex = 9;
            this.lbl_alianza.Text = "[Nombre Alianza]";
            // 
            // lbl_longitud
            // 
            this.lbl_longitud.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longitud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_longitud.Location = new System.Drawing.Point(3, 259);
            this.lbl_longitud.Name = "lbl_longitud";
            this.lbl_longitud.Size = new System.Drawing.Size(289, 37);
            this.lbl_longitud.TabIndex = 10;
            this.lbl_longitud.Text = "[Longitud]";
            // 
            // lbl_latitud
            // 
            this.lbl_latitud.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latitud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_latitud.Location = new System.Drawing.Point(298, 259);
            this.lbl_latitud.Name = "lbl_latitud";
            this.lbl_latitud.Size = new System.Drawing.Size(289, 37);
            this.lbl_latitud.TabIndex = 11;
            this.lbl_latitud.Text = "[Latitud]";
            // 
            // label7
            // 
            this.tlp_info_planeta.SetColumnSpan(this.label7, 2);
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(587, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Routes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lv_rutas
            // 
            this.lv_rutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlp_info_planeta.SetColumnSpan(this.lv_rutas, 2);
            this.lv_rutas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_rutas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lv_rutas.HideSelection = false;
            this.lv_rutas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lv_rutas.Location = new System.Drawing.Point(593, 40);
            this.lv_rutas.Name = "lv_rutas";
            this.tlp_info_planeta.SetRowSpan(this.lv_rutas, 7);
            this.lv_rutas.Size = new System.Drawing.Size(587, 258);
            this.lv_rutas.TabIndex = 13;
            this.lv_rutas.TileSize = new System.Drawing.Size(360, 50);
            this.lv_rutas.UseCompatibleStateImageBehavior = false;
            this.lv_rutas.View = System.Windows.Forms.View.List;
            // 
            // pic_planeta
            // 
            this.pic_planeta.Location = new System.Drawing.Point(729, 80);
            this.pic_planeta.Name = "pic_planeta";
            this.pic_planeta.Size = new System.Drawing.Size(467, 320);
            this.pic_planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_planeta.TabIndex = 3;
            this.pic_planeta.TabStop = false;
            // 
            // FrmPlaneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 720);
            this.Controls.Add(this.pic_planeta);
            this.Controls.Add(this.tlp_info_planeta);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.tlp_planeta_alianzas);
            this.Name = "FrmPlaneta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planeta";
            this.Load += new System.EventHandler(this.FrmPlanetaCarga);
            this.tlp_planeta_alianzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_carga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.tlp_info_planeta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_planeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_planeta_alianzas;
        private System.Windows.Forms.ComboBox cmb_opciones;
        private System.Windows.Forms.ComboBox cmb_contenido;
        private System.Windows.Forms.PictureBox pic_carga;
        private System.Windows.Forms.Timer timer_carga;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn filiation;
        private System.Windows.Forms.DataGridViewTextBoxColumn natives;
        private System.Windows.Forms.TableLayoutPanel tlp_info_planeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_planeta;
        private System.Windows.Forms.Label lbl_sector;
        private System.Windows.Forms.Label lbl_nativos;
        private System.Windows.Forms.Label lbl_alianza;
        private System.Windows.Forms.Label lbl_longitud;
        private System.Windows.Forms.Label lbl_latitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_planeta;
        private System.Windows.Forms.ListView lv_rutas;
    }
}

