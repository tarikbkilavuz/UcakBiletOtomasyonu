namespace UcakBiletOtomasyonu
{
    partial class Form1 : Form1Base
    {

        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Onay = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_HavayoluSirketi = new System.Windows.Forms.Label();
            this.dgv_ucus = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_havayolusirketi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_havayoluOnay = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ucus)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_Onay);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_Onay
            // 
            this.btn_Onay.BackColor = System.Drawing.Color.Orange;
            this.btn_Onay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.btn_Onay, "btn_Onay");
            this.btn_Onay.Name = "btn_Onay";
            this.btn_Onay.UseVisualStyleBackColor = false;
            this.btn_Onay.Click += new System.EventHandler(this.btn_KoltukOnayla_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lb_HavayoluSirketi);
            this.tabPage2.Controls.Add(this.dgv_ucus);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_HavayoluSirketi
            // 
            resources.ApplyResources(this.lb_HavayoluSirketi, "lb_HavayoluSirketi");
            this.lb_HavayoluSirketi.Name = "lb_HavayoluSirketi";
            this.lb_HavayoluSirketi.Click += new System.EventHandler(this.lb_HavayoluSirketi_Click);
            // 
            // dgv_ucus
            // 
            this.dgv_ucus.AllowUserToAddRows = false;
            this.dgv_ucus.AllowUserToDeleteRows = false;
            this.dgv_ucus.AllowUserToResizeColumns = false;
            this.dgv_ucus.AllowUserToResizeRows = false;
            this.dgv_ucus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ucus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_ucus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ucus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ucakId,
            this.tarih,
            this.saat});
            resources.ApplyResources(this.dgv_ucus, "dgv_ucus");
            this.dgv_ucus.Name = "dgv_sucus";
            this.dgv_ucus.ReadOnly = true;
            this.dgv_ucus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ucus.RowTemplate.Height = 24;
            this.dgv_ucus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ucus_CellContentClick);
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ucakId
            // 
            resources.ApplyResources(this.ucakId, "ucakId");
            this.ucakId.Name = "ucakId";
            this.ucakId.ReadOnly = true;
            this.ucakId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ucakId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tarih
            // 
            resources.ApplyResources(this.tarih, "tarih");
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            this.tarih.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_havayolusirketi);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_havayoluOnay);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_havayolusirketi
            // 
            resources.ApplyResources(this.cb_havayolusirketi, "cb_havayolusirketi");
            this.cb_havayolusirketi.FormattingEnabled = true;
            this.cb_havayolusirketi.Name = "cb_havayolusirketi";
            this.cb_havayolusirketi.SelectedIndexChanged += new System.EventHandler(this.cb_havayolusirketi_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_havayoluOnay
            // 
            this.btn_havayoluOnay.BackColor = System.Drawing.Color.Orange;
            this.btn_havayoluOnay.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_havayoluOnay, "btn_havayoluOnay");
            this.btn_havayoluOnay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_havayoluOnay.Name = "btn_havayoluOnay";
            this.btn_havayoluOnay.UseVisualStyleBackColor = false;
            this.btn_havayoluOnay.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ucus)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_HavayoluSirketi;
        private System.Windows.Forms.DataGridView dgv_ucus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cb_havayolusirketi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_havayoluOnay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_Onay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

