namespace ProductsTest
{
    partial class FormCatalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalog));
            this.tableLayoutPanelUp = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCatalog = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelCatalog = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCount = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.catalogTableAdapter = new ProductsTest.Exam_Test_2DataSetTableAdapters.CatalogTableAdapter();
            this.tableLayoutPanelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUp
            // 
            this.tableLayoutPanelUp.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanelUp.ColumnCount = 3;
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.7056F));
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanelUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62774F));
            this.tableLayoutPanelUp.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanelUp.Controls.Add(this.labelCatalog, 1, 0);
            this.tableLayoutPanelUp.Controls.Add(this.buttonExit, 2, 0);
            this.tableLayoutPanelUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUp.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelUp.Name = "tableLayoutPanelUp";
            this.tableLayoutPanelUp.RowCount = 1;
            this.tableLayoutPanelUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUp.Size = new System.Drawing.Size(1045, 85);
            this.tableLayoutPanelUp.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(810, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(232, 79);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCatalog
            // 
            this.labelCatalog.AutoSize = true;
            this.labelCatalog.BackColor = System.Drawing.Color.Bisque;
            this.labelCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCatalog.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCatalog.Location = new System.Drawing.Point(114, 0);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(690, 85);
            this.labelCatalog.TabIndex = 1;
            this.labelCatalog.Text = "Список товаров";
            this.labelCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Bisque;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(105, 79);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Bisque;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelUp, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelCatalog, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCount, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.4557F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.9566F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.09946F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38136F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1051, 553);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.01703F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.46715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.40876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.26277F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.84428F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDiscount, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSearch, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 38);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanelCatalog
            // 
            this.flowLayoutPanelCatalog.BackColor = System.Drawing.Color.Khaki;
            this.flowLayoutPanelCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCatalog.Location = new System.Drawing.Point(3, 138);
            this.flowLayoutPanelCatalog.Name = "flowLayoutPanelCatalog";
            this.flowLayoutPanelCatalog.Size = new System.Drawing.Size(1045, 354);
            this.flowLayoutPanelCatalog.TabIndex = 2;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(3, 495);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(1045, 58);
            this.labelCount.TabIndex = 3;
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Все",
            "По возрастанию",
            "По убыванию"});
            this.comboBoxSort.Location = new System.Drawing.Point(139, 3);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(291, 34);
            this.comboBoxSort.TabIndex = 0;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSort.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort.Location = new System.Drawing.Point(3, 0);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(130, 38);
            this.labelSort.TabIndex = 1;
            this.labelSort.Text = "Сортировать";
            this.labelSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCategory.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(436, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(123, 38);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Скидка";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDiscount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Items.AddRange(new object[] {
            "Все",
            "5-10%",
            "10-15%",
            "Более 15%"});
            this.comboBoxDiscount.Location = new System.Drawing.Point(565, 3);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(226, 34);
            this.comboBoxDiscount.TabIndex = 3;
            this.comboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscount_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(824, 3);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(191, 34);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // catalogTableAdapter
            // 
            this.catalogTableAdapter.ClearBeforeFill = true;
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1051, 553);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1067, 592);
            this.Name = "FormCatalog";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            this.tableLayoutPanelUp.ResumeLayout(false);
            this.tableLayoutPanelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Exam_Test_2DataSetTableAdapters.CatalogTableAdapter catalogTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUp;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCatalog;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCatalog;
        private System.Windows.Forms.Label labelCount;
    }
}

