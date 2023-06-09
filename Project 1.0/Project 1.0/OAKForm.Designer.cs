
namespace Project_1._0
{
    partial class OAKForm
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
            this.OAKGreedview = new System.Windows.Forms.DataGridView();
            this.EdtBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PatronimicBox = new System.Windows.Forms.TextBox();
            this.BerthdateBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.OAKGreedview)).BeginInit();
            this.SuspendLayout();
            // 
            // OAKGreedview
            // 
            this.OAKGreedview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OAKGreedview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OAKGreedview.Location = new System.Drawing.Point(13, 57);
            this.OAKGreedview.Name = "OAKGreedview";
            this.OAKGreedview.RowHeadersWidth = 62;
            this.OAKGreedview.RowTemplate.Height = 28;
            this.OAKGreedview.Size = new System.Drawing.Size(1091, 289);
            this.OAKGreedview.TabIndex = 0;
            // 
            // EdtBtn
            // 
            this.EdtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdtBtn.Location = new System.Drawing.Point(13, 370);
            this.EdtBtn.Name = "EdtBtn";
            this.EdtBtn.Size = new System.Drawing.Size(266, 51);
            this.EdtBtn.TabIndex = 2;
            this.EdtBtn.Text = "Изменить";
            this.EdtBtn.UseVisualStyleBackColor = true;
            this.EdtBtn.Click += new System.EventHandler(this.EdtBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBtn.Location = new System.Drawing.Point(332, 370);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(272, 51);
            this.DelBtn.TabIndex = 3;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.Location = new System.Drawing.Point(685, 370);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(183, 51);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(951, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(33, 13);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(112, 26);
            this.NameBox.TabIndex = 6;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Enabled = false;
            this.SurnameBox.Location = new System.Drawing.Point(198, 12);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(106, 26);
            this.SurnameBox.TabIndex = 7;
            // 
            // PatronimicBox
            // 
            this.PatronimicBox.Enabled = false;
            this.PatronimicBox.Location = new System.Drawing.Point(354, 12);
            this.PatronimicBox.Name = "PatronimicBox";
            this.PatronimicBox.Size = new System.Drawing.Size(143, 26);
            this.PatronimicBox.TabIndex = 8;
            // 
            // BerthdateBox
            // 
            this.BerthdateBox.Enabled = false;
            this.BerthdateBox.Location = new System.Drawing.Point(519, 12);
            this.BerthdateBox.Name = "BerthdateBox";
            this.BerthdateBox.Size = new System.Drawing.Size(200, 26);
            this.BerthdateBox.TabIndex = 9;
            this.BerthdateBox.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // OAKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 450);
            this.Controls.Add(this.BerthdateBox);
            this.Controls.Add(this.PatronimicBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EdtBtn);
            this.Controls.Add(this.OAKGreedview);
            this.Name = "OAKForm";
            this.Text = "Общий Анализ Крови";
            ((System.ComponentModel.ISupportInitialize)(this.OAKGreedview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EdtBtn;
        private System.Windows.Forms.Button DelBtn;
        public System.Windows.Forms.DataGridView OAKGreedview;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox PatronimicBox;
        private System.Windows.Forms.DateTimePicker BerthdateBox;
    }
}