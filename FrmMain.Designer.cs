namespace WFA220131
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTemaSzerint = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSzerkesztes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzerzo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiForras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIdezet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKereses = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMaiDatum = new System.Windows.Forms.Label();
            this.lblNapIdezete = new System.Windows.Forms.Label();
            this.lblIdezetekSzama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSzerzoSzerint = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemaSzerint)).BeginInit();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzerzoSzerint)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A nap idézete:";
            // 
            // dgvTemaSzerint
            // 
            this.dgvTemaSzerint.AllowUserToAddRows = false;
            this.dgvTemaSzerint.AllowUserToDeleteRows = false;
            this.dgvTemaSzerint.AllowUserToResizeColumns = false;
            this.dgvTemaSzerint.AllowUserToResizeRows = false;
            this.dgvTemaSzerint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTemaSzerint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemaSzerint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemaSzerint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemaSzerint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemaSzerint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTemaSzerint.Location = new System.Drawing.Point(3, 33);
            this.dgvTemaSzerint.Name = "dgvTemaSzerint";
            this.dgvTemaSzerint.RowHeadersVisible = false;
            this.dgvTemaSzerint.Size = new System.Drawing.Size(347, 383);
            this.dgvTemaSzerint.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Téma";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Idézetek száma";
            this.Column2.Name = "Column2";
            // 
            // msMain
            // 
            this.msMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.msMain.AutoSize = false;
            this.msMain.Dock = System.Windows.Forms.DockStyle.None;
            this.msMain.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzerkesztes,
            this.tsmiKereses});
            this.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msMain.Location = new System.Drawing.Point(733, 265);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.msMain.Size = new System.Drawing.Size(212, 324);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiSzerkesztes
            // 
            this.tsmiSzerkesztes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSzerzo,
            this.tsmiTema,
            this.tsmiForras,
            this.tsmiIdezet});
            this.tsmiSzerkesztes.Image = global::WFA220131.Properties.Resources.edit;
            this.tsmiSzerkesztes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiSzerkesztes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsmiSzerkesztes.Name = "tsmiSzerkesztes";
            this.tsmiSzerkesztes.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.tsmiSzerkesztes.Size = new System.Drawing.Size(205, 118);
            this.tsmiSzerkesztes.Text = "Szerkesztés";
            this.tsmiSzerkesztes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiSzerzo
            // 
            this.tsmiSzerzo.Name = "tsmiSzerzo";
            this.tsmiSzerzo.Size = new System.Drawing.Size(180, 34);
            this.tsmiSzerzo.Text = "Szerző";
            this.tsmiSzerzo.Click += new System.EventHandler(this.TsmiSzerzo_Click);
            // 
            // tsmiTema
            // 
            this.tsmiTema.Name = "tsmiTema";
            this.tsmiTema.Size = new System.Drawing.Size(180, 34);
            this.tsmiTema.Text = "Téma";
            // 
            // tsmiForras
            // 
            this.tsmiForras.Name = "tsmiForras";
            this.tsmiForras.Size = new System.Drawing.Size(180, 34);
            this.tsmiForras.Text = "Forrás";
            // 
            // tsmiIdezet
            // 
            this.tsmiIdezet.Name = "tsmiIdezet";
            this.tsmiIdezet.Size = new System.Drawing.Size(180, 34);
            this.tsmiIdezet.Text = "Idézet";
            // 
            // tsmiKereses
            // 
            this.tsmiKereses.Image = global::WFA220131.Properties.Resources.search;
            this.tsmiKereses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiKereses.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.tsmiKereses.Name = "tsmiKereses";
            this.tsmiKereses.Padding = new System.Windows.Forms.Padding(4, 20, 4, 0);
            this.tsmiKereses.Size = new System.Drawing.Size(205, 118);
            this.tsmiKereses.Text = "Keresés";
            this.tsmiKereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblMaiDatum
            // 
            this.lblMaiDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaiDatum.Location = new System.Drawing.Point(729, 9);
            this.lblMaiDatum.Name = "lblMaiDatum";
            this.lblMaiDatum.Size = new System.Drawing.Size(213, 40);
            this.lblMaiDatum.TabIndex = 0;
            this.lblMaiDatum.Text = "###mai_datum###";
            this.lblMaiDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNapIdezete
            // 
            this.lblNapIdezete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNapIdezete.BackColor = System.Drawing.Color.White;
            this.lblNapIdezete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNapIdezete.Location = new System.Drawing.Point(16, 65);
            this.lblNapIdezete.Name = "lblNapIdezete";
            this.lblNapIdezete.Size = new System.Drawing.Size(707, 83);
            this.lblNapIdezete.TabIndex = 0;
            this.lblNapIdezete.Text = "###nap_idezete###";
            this.lblNapIdezete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdezetekSzama
            // 
            this.lblIdezetekSzama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdezetekSzama.Location = new System.Drawing.Point(729, 49);
            this.lblIdezetekSzama.Name = "lblIdezetekSzama";
            this.lblIdezetekSzama.Size = new System.Drawing.Size(213, 99);
            this.lblIdezetekSzama.TabIndex = 0;
            this.lblIdezetekSzama.Text = "Idézetek száma:";
            this.lblIdezetekSzama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Az idézetek száma témák szerint:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(356, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Az idézetek száma szerzők szerint:";
            // 
            // dgvSzerzoSzerint
            // 
            this.dgvSzerzoSzerint.AllowUserToAddRows = false;
            this.dgvSzerzoSzerint.AllowUserToDeleteRows = false;
            this.dgvSzerzoSzerint.AllowUserToResizeColumns = false;
            this.dgvSzerzoSzerint.AllowUserToResizeRows = false;
            this.dgvSzerzoSzerint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSzerzoSzerint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSzerzoSzerint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSzerzoSzerint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSzerzoSzerint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzerzoSzerint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvSzerzoSzerint.Location = new System.Drawing.Point(356, 33);
            this.dgvSzerzoSzerint.Name = "dgvSzerzoSzerint";
            this.dgvSzerzoSzerint.RowHeadersVisible = false;
            this.dgvSzerzoSzerint.Size = new System.Drawing.Size(348, 383);
            this.dgvSzerzoSzerint.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Szerző";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Idézetek száma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSzerzoSzerint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTemaSzerint, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 419);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblNapIdezete);
            this.Controls.Add(this.lblIdezetekSzama);
            this.Controls.Add(this.lblMaiDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Idézetgyűjtemény";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemaSzerint)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzerzoSzerint)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTemaSzerint;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzerkesztes;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzerzo;
        private System.Windows.Forms.ToolStripMenuItem tsmiTema;
        private System.Windows.Forms.ToolStripMenuItem tsmiForras;
        private System.Windows.Forms.ToolStripMenuItem tsmiIdezet;
        private System.Windows.Forms.ToolStripMenuItem tsmiKereses;
        private System.Windows.Forms.Label lblMaiDatum;
        private System.Windows.Forms.Label lblNapIdezete;
        private System.Windows.Forms.Label lblIdezetekSzama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dgvSzerzoSzerint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

