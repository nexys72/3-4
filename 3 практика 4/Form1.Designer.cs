namespace _3_практика_4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.rEdit = new System.Windows.Forms.TextBox();
            this.gEdit = new System.Windows.Forms.TextBox();
            this.bEdit = new System.Windows.Forms.TextBox();
            this.rgbPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "G=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "B=";
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(295, 26);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(0, 13);
            this.rgbLabel.TabIndex = 3;
            // 
            // rEdit
            // 
            this.rEdit.Location = new System.Drawing.Point(83, 68);
            this.rEdit.Name = "rEdit";
            this.rEdit.Size = new System.Drawing.Size(100, 20);
            this.rEdit.TabIndex = 4;
            this.rEdit.TextChanged += new System.EventHandler(this.rEdit_TextChanged);
            // 
            // gEdit
            // 
            this.gEdit.Location = new System.Drawing.Point(83, 100);
            this.gEdit.Name = "gEdit";
            this.gEdit.Size = new System.Drawing.Size(100, 20);
            this.gEdit.TabIndex = 5;
            this.gEdit.TextChanged += new System.EventHandler(this.gEdit_TextChanged);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(83, 130);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(100, 20);
            this.bEdit.TabIndex = 6;
            this.bEdit.TextChanged += new System.EventHandler(this.bEdit_TextChanged);
            // 
            // rgbPanel
            // 
            this.rgbPanel.Location = new System.Drawing.Point(234, 68);
            this.rgbPanel.Name = "rgbPanel";
            this.rgbPanel.Size = new System.Drawing.Size(200, 100);
            this.rgbPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 466);
            this.Controls.Add(this.rgbPanel);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.gEdit);
            this.Controls.Add(this.rEdit);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.TextBox rEdit;
        private System.Windows.Forms.TextBox gEdit;
        private System.Windows.Forms.TextBox bEdit;
        private System.Windows.Forms.Panel rgbPanel;
    }
}

