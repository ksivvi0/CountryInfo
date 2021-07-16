
namespace CountryInfo
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
            this.PanelLayout = new System.Windows.Forms.Panel();
            this.ResultsGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImportFromSqlBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.PanelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLayout
            // 
            this.PanelLayout.Controls.Add(this.ResultsGrid);
            this.PanelLayout.Controls.Add(this.TopPanel);
            this.PanelLayout.Controls.Add(this.panel1);
            this.PanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLayout.Location = new System.Drawing.Point(0, 0);
            this.PanelLayout.Name = "PanelLayout";
            this.PanelLayout.Size = new System.Drawing.Size(562, 463);
            this.PanelLayout.TabIndex = 0;
            // 
            // ResultsGrid
            // 
            this.ResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsGrid.Location = new System.Drawing.Point(0, 32);
            this.ResultsGrid.Name = "ResultsGrid";
            this.ResultsGrid.Size = new System.Drawing.Size(562, 398);
            this.ResultsGrid.TabIndex = 3;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.CountryTextBox);
            this.TopPanel.Controls.Add(this.SearchBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(562, 32);
            this.TopPanel.TabIndex = 2;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(3, 4);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(460, 23);
            this.CountryTextBox.TabIndex = 10;
            this.CountryTextBox.Tag = "0";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SearchBtn.Location = new System.Drawing.Point(464, 0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(98, 32);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImportFromSqlBtn);
            this.panel1.Controls.Add(this.ExportBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 33);
            this.panel1.TabIndex = 1;
            // 
            // ImportFromSqlBtn
            // 
            this.ImportFromSqlBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImportFromSqlBtn.Location = new System.Drawing.Point(238, 0);
            this.ImportFromSqlBtn.Name = "ImportFromSqlBtn";
            this.ImportFromSqlBtn.Size = new System.Drawing.Size(162, 33);
            this.ImportFromSqlBtn.TabIndex = 10;
            this.ImportFromSqlBtn.Text = "Импорт из SQL";
            this.ImportFromSqlBtn.UseVisualStyleBackColor = true;
            this.ImportFromSqlBtn.Click += new System.EventHandler(this.ImportFromSqlBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExportBtn.Location = new System.Drawing.Point(400, 0);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(162, 33);
            this.ExportBtn.TabIndex = 9;
            this.ExportBtn.Text = "Экспорт в SQL";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Visible = false;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 463);
            this.Controls.Add(this.PanelLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountryInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.DataGridView ResultsGrid;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ImportFromSqlBtn;
    }
}

