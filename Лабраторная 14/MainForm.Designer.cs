
namespace Лабраторная_14
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateMassiv = new System.Windows.Forms.Button();
            this.buttonSortBubble = new System.Windows.Forms.Button();
            this.buttonSelectionSort = new System.Windows.Forms.Button();
            this.buttonQiuckSort = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSimpleSearch = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 439);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Исходный массив";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Метод пузырька";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сортировка выбором";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Быстрая сортировка";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // buttonCreateMassiv
            // 
            this.buttonCreateMassiv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateMassiv.Location = new System.Drawing.Point(622, 12);
            this.buttonCreateMassiv.Name = "buttonCreateMassiv";
            this.buttonCreateMassiv.Size = new System.Drawing.Size(166, 31);
            this.buttonCreateMassiv.TabIndex = 1;
            this.buttonCreateMassiv.Text = "Исходный массив";
            this.buttonCreateMassiv.UseVisualStyleBackColor = true;
            this.buttonCreateMassiv.Click += new System.EventHandler(this.buttonCreateMassiv_Click);
            // 
            // buttonSortBubble
            // 
            this.buttonSortBubble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortBubble.Location = new System.Drawing.Point(622, 72);
            this.buttonSortBubble.Name = "buttonSortBubble";
            this.buttonSortBubble.Size = new System.Drawing.Size(166, 31);
            this.buttonSortBubble.TabIndex = 2;
            this.buttonSortBubble.Text = "Метод пузырька";
            this.buttonSortBubble.UseVisualStyleBackColor = true;
            this.buttonSortBubble.Click += new System.EventHandler(this.buttonSortBubble_Click);
            // 
            // buttonSelectionSort
            // 
            this.buttonSelectionSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectionSort.Location = new System.Drawing.Point(622, 109);
            this.buttonSelectionSort.Name = "buttonSelectionSort";
            this.buttonSelectionSort.Size = new System.Drawing.Size(166, 31);
            this.buttonSelectionSort.TabIndex = 3;
            this.buttonSelectionSort.Text = "Сортировка выбором";
            this.buttonSelectionSort.UseVisualStyleBackColor = true;
            this.buttonSelectionSort.Click += new System.EventHandler(this.buttonSelectionSort_Click);
            // 
            // buttonQiuckSort
            // 
            this.buttonQiuckSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQiuckSort.Location = new System.Drawing.Point(622, 146);
            this.buttonQiuckSort.Name = "buttonQiuckSort";
            this.buttonQiuckSort.Size = new System.Drawing.Size(166, 31);
            this.buttonQiuckSort.TabIndex = 4;
            this.buttonQiuckSort.Text = "Быстрая сортировка";
            this.buttonQiuckSort.UseVisualStyleBackColor = true;
            this.buttonQiuckSort.Click += new System.EventHandler(this.buttonQiuckSort_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(622, 220);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(97, 22);
            this.textBoxInput.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(622, 309);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(166, 45);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Найти в отсортированном";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSimpleSearch
            // 
            this.buttonSimpleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSimpleSearch.Location = new System.Drawing.Point(622, 258);
            this.buttonSimpleSearch.Name = "buttonSimpleSearch";
            this.buttonSimpleSearch.Size = new System.Drawing.Size(166, 45);
            this.buttonSimpleSearch.TabIndex = 7;
            this.buttonSimpleSearch.Text = "Найти в исходном";
            this.buttonSimpleSearch.UseVisualStyleBackColor = true;
            this.buttonSimpleSearch.Click += new System.EventHandler(this.buttonSimpleSearch_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(622, 381);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(53, 16);
            this.labelNumber.TabIndex = 8;
            this.labelNumber.Text = "Номер:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonSimpleSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonQiuckSort);
            this.Controls.Add(this.buttonSelectionSort);
            this.Controls.Add(this.buttonSortBubble);
            this.Controls.Add(this.buttonCreateMassiv);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Лабораторная 14 Холоденко";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreateMassiv;
        private System.Windows.Forms.Button buttonSortBubble;
        private System.Windows.Forms.Button buttonSelectionSort;
        private System.Windows.Forms.Button buttonQiuckSort;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonSimpleSearch;
        private System.Windows.Forms.Label labelNumber;
    }
}

