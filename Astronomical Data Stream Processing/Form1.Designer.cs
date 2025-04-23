namespace Astronomical_Data_Stream_Processing
{
    partial class AstronomicalProcessingForm
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
            this.ListBoxData = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonLoadData = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.ItemHeight = 20;
            this.ListBoxData.Location = new System.Drawing.Point(23, 44);
            this.ListBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(300, 504);
            this.ListBoxData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonLoadData);
            this.groupBox1.Controls.Add(this.ButtonSort);
            this.groupBox1.Location = new System.Drawing.Point(400, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load/Sort";
            // 
            // ButtonLoadData
            // 
            this.ButtonLoadData.Location = new System.Drawing.Point(64, 36);
            this.ButtonLoadData.Name = "ButtonLoadData";
            this.ButtonLoadData.Size = new System.Drawing.Size(120, 40);
            this.ButtonLoadData.TabIndex = 8;
            this.ButtonLoadData.Text = "Load Data";
            this.ButtonLoadData.UseVisualStyleBackColor = true;
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(64, 84);
            this.ButtonSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(120, 40);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBoxInput);
            this.groupBox2.Controls.Add(this.ButtonSearch);
            this.groupBox2.Controls.Add(this.ButtonEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(400, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit/Search";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(64, 45);
            this.TextBoxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(120, 26);
            this.TextBoxInput.TabIndex = 1;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(64, 81);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(120, 40);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(64, 131);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(120, 40);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListBoxData);
            this.groupBox3.Location = new System.Drawing.Point(20, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 575);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Astronomical Data Display";
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AstronomicalProcessingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Astronomical Processing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonLoadData;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

