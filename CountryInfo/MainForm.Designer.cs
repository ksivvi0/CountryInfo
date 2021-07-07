
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
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.PanelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLayout
            // 
            this.PanelLayout.Controls.Add(this.StatusBar);
            this.PanelLayout.Controls.Add(this.ResultsBox);
            this.PanelLayout.Controls.Add(this.ShowAllBtn);
            this.PanelLayout.Controls.Add(this.SearchBtn);
            this.PanelLayout.Controls.Add(this.CountryTextBox);
            this.PanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLayout.Location = new System.Drawing.Point(0, 0);
            this.PanelLayout.Name = "PanelLayout";
            this.PanelLayout.Size = new System.Drawing.Size(562, 463);
            this.PanelLayout.TabIndex = 0;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(5, 4);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(269, 23);
            this.CountryTextBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(280, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(100, 25);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Location = new System.Drawing.Point(386, 3);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(172, 25);
            this.ShowAllBtn.TabIndex = 2;
            this.ShowAllBtn.Text = "Показать все страны";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // ResultsBox
            // 
            this.ResultsBox.Location = new System.Drawing.Point(5, 33);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ResultsBox.Size = new System.Drawing.Size(553, 381);
            this.ResultsBox.TabIndex = 3;
            this.ResultsBox.Text = "";
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 441);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(562, 22);
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "statusStrip1";
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
            this.PanelLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLayout;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.RichTextBox ResultsBox;
        private System.Windows.Forms.StatusStrip StatusBar;
    }
}

