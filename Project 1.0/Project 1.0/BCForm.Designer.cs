
namespace Project_1._0
{
    partial class BCForm
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
            this.BcGreedView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ChngBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PatronimicBox = new System.Windows.Forms.TextBox();
            this.BerthdateBox = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BcGreedView)).BeginInit();
            this.SuspendLayout();
            // 
            // BcGreedView
            // 
            this.BcGreedView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BcGreedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BcGreedView.Location = new System.Drawing.Point(12, 58);
            this.BcGreedView.Name = "BcGreedView";
            this.BcGreedView.RowHeadersWidth = 62;
            this.BcGreedView.RowTemplate.Height = 28;
            this.BcGreedView.Size = new System.Drawing.Size(775, 325);
            this.BcGreedView.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.Location = new System.Drawing.Point(12, 389);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 40);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ChngBtn
            // 
            this.ChngBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChngBtn.Location = new System.Drawing.Point(182, 389);
            this.ChngBtn.Name = "ChngBtn";
            this.ChngBtn.Size = new System.Drawing.Size(133, 40);
            this.ChngBtn.TabIndex = 2;
            this.ChngBtn.Text = "Изменить";
            this.ChngBtn.UseVisualStyleBackColor = true;
            this.ChngBtn.Click += new System.EventHandler(this.ChngBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DelBtn.Location = new System.Drawing.Point(378, 389);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(120, 40);
            this.DelBtn.TabIndex = 3;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ExtBtn
            // 
            this.ExtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExtBtn.Location = new System.Drawing.Point(567, 389);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(114, 40);
            this.ExtBtn.TabIndex = 4;
            this.ExtBtn.Text = "Выход";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(41, 13);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 26);
            this.NameBox.TabIndex = 5;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Enabled = false;
            this.SurnameBox.Location = new System.Drawing.Point(169, 12);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 26);
            this.SurnameBox.TabIndex = 6;
            // 
            // PatronimicBox
            // 
            this.PatronimicBox.Enabled = false;
            this.PatronimicBox.Location = new System.Drawing.Point(302, 12);
            this.PatronimicBox.Name = "PatronimicBox";
            this.PatronimicBox.Size = new System.Drawing.Size(100, 26);
            this.PatronimicBox.TabIndex = 7;
            // 
            // BerthdateBox
            // 
            this.BerthdateBox.Enabled = false;
            this.BerthdateBox.Location = new System.Drawing.Point(462, 10);
            this.BerthdateBox.Name = "BerthdateBox";
            this.BerthdateBox.Size = new System.Drawing.Size(200, 26);
            this.BerthdateBox.TabIndex = 9;
            this.BerthdateBox.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // BCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BerthdateBox);
            this.Controls.Add(this.PatronimicBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.ChngBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.BcGreedView);
            this.Name = "BCForm";
            this.Text = "Биохимия крови";
            ((System.ComponentModel.ISupportInitialize)(this.BcGreedView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ChngBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button ExtBtn;
        public System.Windows.Forms.DataGridView BcGreedView;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox PatronimicBox;
        public System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.DateTimePicker BerthdateBox;
    }
}