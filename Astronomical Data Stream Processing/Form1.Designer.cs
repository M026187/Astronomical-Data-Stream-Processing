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
            this.GroupBoxLoadSort = new System.Windows.Forms.GroupBox();
            this.ButtonLoadData = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.GroupBoxEditSearch = new System.Windows.Forms.GroupBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.LabelInput = new System.Windows.Forms.Label();
            this.LabelMessageDisplay = new System.Windows.Forms.Label();
            this.TextBoxMessage = new System.Windows.Forms.TextBox();
            this.LabelAstronomicalProcessingData = new System.Windows.Forms.Label();
            this.GroupBoxLoadSort.SuspendLayout();
            this.GroupBoxEditSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.Location = new System.Drawing.Point(32, 42);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(201, 329);
            this.ListBoxData.TabIndex = 0;
            this.ListBoxData.SelectedIndexChanged += new System.EventHandler(this.ListBoxData_SelectedIndexChanged);
            // 
            // GroupBoxLoadSort
            // 
            this.GroupBoxLoadSort.Controls.Add(this.ButtonLoadData);
            this.GroupBoxLoadSort.Controls.Add(this.ButtonSort);
            this.GroupBoxLoadSort.Location = new System.Drawing.Point(267, 13);
            this.GroupBoxLoadSort.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxLoadSort.Name = "GroupBoxLoadSort";
            this.GroupBoxLoadSort.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxLoadSort.Size = new System.Drawing.Size(167, 98);
            this.GroupBoxLoadSort.TabIndex = 9;
            this.GroupBoxLoadSort.TabStop = false;
            this.GroupBoxLoadSort.Text = "Load/Sort";
            // 
            // ButtonLoadData
            // 
            this.ButtonLoadData.Location = new System.Drawing.Point(43, 23);
            this.ButtonLoadData.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLoadData.Name = "ButtonLoadData";
            this.ButtonLoadData.Size = new System.Drawing.Size(80, 26);
            this.ButtonLoadData.TabIndex = 8;
            this.ButtonLoadData.Text = "Load Data";
            this.ButtonLoadData.UseVisualStyleBackColor = true;
            this.ButtonLoadData.Click += new System.EventHandler(this.ButtonLoadData_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(43, 55);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(80, 26);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // GroupBoxEditSearch
            // 
            this.GroupBoxEditSearch.Controls.Add(this.TextBoxInput);
            this.GroupBoxEditSearch.Controls.Add(this.ButtonSearch);
            this.GroupBoxEditSearch.Controls.Add(this.ButtonEdit);
            this.GroupBoxEditSearch.Controls.Add(this.LabelInput);
            this.GroupBoxEditSearch.Location = new System.Drawing.Point(267, 114);
            this.GroupBoxEditSearch.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxEditSearch.Name = "GroupBoxEditSearch";
            this.GroupBoxEditSearch.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxEditSearch.Size = new System.Drawing.Size(167, 130);
            this.GroupBoxEditSearch.TabIndex = 10;
            this.GroupBoxEditSearch.TabStop = false;
            this.GroupBoxEditSearch.Text = "Edit/Search";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(43, 29);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(81, 20);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(43, 53);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(80, 26);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(43, 85);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(80, 26);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(5, 31);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(34, 13);
            this.LabelInput.TabIndex = 5;
            this.LabelInput.Text = "Input:";
            // 
            // LabelMessageDisplay
            // 
            this.LabelMessageDisplay.AutoSize = true;
            this.LabelMessageDisplay.Location = new System.Drawing.Point(305, 253);
            this.LabelMessageDisplay.Name = "LabelMessageDisplay";
            this.LabelMessageDisplay.Size = new System.Drawing.Size(90, 13);
            this.LabelMessageDisplay.TabIndex = 15;
            this.LabelMessageDisplay.Text = "Message Display:";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(267, 269);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.Size = new System.Drawing.Size(167, 102);
            this.TextBoxMessage.TabIndex = 13;
            this.TextBoxMessage.TextChanged += new System.EventHandler(this.TextBoxMessage_TextChanged);
            // 
            // LabelAstronomicalProcessingData
            // 
            this.LabelAstronomicalProcessingData.AutoSize = true;
            this.LabelAstronomicalProcessingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAstronomicalProcessingData.Location = new System.Drawing.Point(58, 13);
            this.LabelAstronomicalProcessingData.Name = "LabelAstronomicalProcessingData";
            this.LabelAstronomicalProcessingData.Size = new System.Drawing.Size(148, 13);
            this.LabelAstronomicalProcessingData.TabIndex = 16;
            this.LabelAstronomicalProcessingData.Text = "Astronomical Processing Data";
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 401);
            this.Controls.Add(this.LabelAstronomicalProcessingData);
            this.Controls.Add(this.ListBoxData);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.LabelMessageDisplay);
            this.Controls.Add(this.GroupBoxEditSearch);
            this.Controls.Add(this.GroupBoxLoadSort);
            this.Name = "AstronomicalProcessingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Astronomical Processing";
            this.GroupBoxLoadSort.ResumeLayout(false);
            this.GroupBoxEditSearch.ResumeLayout(false);
            this.GroupBoxEditSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxData;
        private System.Windows.Forms.GroupBox GroupBoxLoadSort;
        private System.Windows.Forms.Button ButtonLoadData;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.GroupBox GroupBoxEditSearch;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Label LabelMessageDisplay;
        private System.Windows.Forms.TextBox TextBoxMessage;
        private System.Windows.Forms.Label LabelAstronomicalProcessingData;
    }
}

