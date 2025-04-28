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
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.ButtonSequentialSearch = new System.Windows.Forms.Button();
            this.GroupBoxMathFunctions = new System.Windows.Forms.GroupBox();
            this.GroupBoxLoadSort.SuspendLayout();
            this.GroupBoxEditSearch.SuspendLayout();
            this.GroupBoxMathFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.ItemHeight = 20;
            this.ListBoxData.Location = new System.Drawing.Point(48, 65);
            this.ListBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(300, 424);
            this.ListBoxData.TabIndex = 0;
            this.ListBoxData.SelectedIndexChanged += new System.EventHandler(this.ListBoxData_SelectedIndexChanged);
            // 
            // GroupBoxLoadSort
            // 
            this.GroupBoxLoadSort.Controls.Add(this.ButtonLoadData);
            this.GroupBoxLoadSort.Controls.Add(this.ButtonSort);
            this.GroupBoxLoadSort.Location = new System.Drawing.Point(385, 60);
            this.GroupBoxLoadSort.Name = "GroupBoxLoadSort";
            this.GroupBoxLoadSort.Size = new System.Drawing.Size(250, 151);
            this.GroupBoxLoadSort.TabIndex = 9;
            this.GroupBoxLoadSort.TabStop = false;
            this.GroupBoxLoadSort.Text = "Load/Sort";
            // 
            // ButtonLoadData
            // 
            this.ButtonLoadData.Location = new System.Drawing.Point(64, 35);
            this.ButtonLoadData.Name = "ButtonLoadData";
            this.ButtonLoadData.Size = new System.Drawing.Size(120, 40);
            this.ButtonLoadData.TabIndex = 8;
            this.ButtonLoadData.Text = "Load Data";
            this.ButtonLoadData.UseVisualStyleBackColor = true;
            this.ButtonLoadData.Click += new System.EventHandler(this.ButtonLoadData_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(64, 85);
            this.ButtonSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(120, 40);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // GroupBoxEditSearch
            // 
            this.GroupBoxEditSearch.Controls.Add(this.ButtonSequentialSearch);
            this.GroupBoxEditSearch.Controls.Add(this.TextBoxInput);
            this.GroupBoxEditSearch.Controls.Add(this.ButtonSearch);
            this.GroupBoxEditSearch.Controls.Add(this.ButtonEdit);
            this.GroupBoxEditSearch.Controls.Add(this.LabelInput);
            this.GroupBoxEditSearch.Location = new System.Drawing.Point(385, 235);
            this.GroupBoxEditSearch.Name = "GroupBoxEditSearch";
            this.GroupBoxEditSearch.Size = new System.Drawing.Size(250, 250);
            this.GroupBoxEditSearch.TabIndex = 10;
            this.GroupBoxEditSearch.TabStop = false;
            this.GroupBoxEditSearch.Text = "Edit/Search";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(64, 45);
            this.TextBoxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(120, 26);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(64, 82);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(120, 40);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Linear Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(64, 193);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(120, 40);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(8, 48);
            this.LabelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(50, 20);
            this.LabelInput.TabIndex = 5;
            this.LabelInput.Text = "Input:";
            // 
            // LabelMessageDisplay
            // 
            this.LabelMessageDisplay.AutoSize = true;
            this.LabelMessageDisplay.Location = new System.Drawing.Point(656, 327);
            this.LabelMessageDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMessageDisplay.Name = "LabelMessageDisplay";
            this.LabelMessageDisplay.Size = new System.Drawing.Size(133, 20);
            this.LabelMessageDisplay.TabIndex = 15;
            this.LabelMessageDisplay.Text = "Message Display:";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Location = new System.Drawing.Point(660, 350);
            this.TextBoxMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxMessage.Multiline = true;
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.ReadOnly = true;
            this.TextBoxMessage.Size = new System.Drawing.Size(250, 130);
            this.TextBoxMessage.TabIndex = 13;
            this.TextBoxMessage.TextChanged += new System.EventHandler(this.TextBoxMessage_TextChanged);
            // 
            // LabelAstronomicalProcessingData
            // 
            this.LabelAstronomicalProcessingData.AutoSize = true;
            this.LabelAstronomicalProcessingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAstronomicalProcessingData.Location = new System.Drawing.Point(79, 40);
            this.LabelAstronomicalProcessingData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAstronomicalProcessingData.Name = "LabelAstronomicalProcessingData";
            this.LabelAstronomicalProcessingData.Size = new System.Drawing.Size(237, 20);
            this.LabelAstronomicalProcessingData.TabIndex = 16;
            this.LabelAstronomicalProcessingData.Text = "Astronomical Processing Data";
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(64, 35);
            this.ButtonMidExtreme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(120, 40);
            this.ButtonMidExtreme.TabIndex = 17;
            this.ButtonMidExtreme.Text = "Mid Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(64, 85);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(120, 40);
            this.ButtonMode.TabIndex = 18;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(64, 135);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(120, 40);
            this.ButtonAverage.TabIndex = 19;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(64, 185);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(120, 40);
            this.ButtonRange.TabIndex = 20;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = true;
            // 
            // ButtonSequentialSearch
            // 
            this.ButtonSequentialSearch.Location = new System.Drawing.Point(64, 131);
            this.ButtonSequentialSearch.Name = "ButtonSequentialSearch";
            this.ButtonSequentialSearch.Size = new System.Drawing.Size(120, 54);
            this.ButtonSequentialSearch.TabIndex = 21;
            this.ButtonSequentialSearch.Text = "Sequential Search";
            this.ButtonSequentialSearch.UseVisualStyleBackColor = true;
            // 
            // GroupBoxMathFunctions
            // 
            this.GroupBoxMathFunctions.Controls.Add(this.ButtonRange);
            this.GroupBoxMathFunctions.Controls.Add(this.ButtonAverage);
            this.GroupBoxMathFunctions.Controls.Add(this.ButtonMode);
            this.GroupBoxMathFunctions.Controls.Add(this.ButtonMidExtreme);
            this.GroupBoxMathFunctions.Location = new System.Drawing.Point(660, 60);
            this.GroupBoxMathFunctions.Name = "GroupBoxMathFunctions";
            this.GroupBoxMathFunctions.Size = new System.Drawing.Size(250, 250);
            this.GroupBoxMathFunctions.TabIndex = 21;
            this.GroupBoxMathFunctions.TabStop = false;
            this.GroupBoxMathFunctions.Text = "Math Functions";
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 544);
            this.Controls.Add(this.GroupBoxMathFunctions);
            this.Controls.Add(this.LabelAstronomicalProcessingData);
            this.Controls.Add(this.ListBoxData);
            this.Controls.Add(this.TextBoxMessage);
            this.Controls.Add(this.LabelMessageDisplay);
            this.Controls.Add(this.GroupBoxEditSearch);
            this.Controls.Add(this.GroupBoxLoadSort);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AstronomicalProcessingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Astronomical Processing";
            this.GroupBoxLoadSort.ResumeLayout(false);
            this.GroupBoxEditSearch.ResumeLayout(false);
            this.GroupBoxEditSearch.PerformLayout();
            this.GroupBoxMathFunctions.ResumeLayout(false);
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
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.Button ButtonSequentialSearch;
        private System.Windows.Forms.GroupBox GroupBoxMathFunctions;
    }
}

