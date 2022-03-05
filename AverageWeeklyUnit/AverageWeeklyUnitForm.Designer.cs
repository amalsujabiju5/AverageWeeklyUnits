
namespace AverageWeeklyUnit
{
    partial class AverageWeeklyUnitForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textAverage1 = new System.Windows.Forms.TextBox();
            this.textAverage2 = new System.Windows.Forms.TextBox();
            this.textAverage3 = new System.Windows.Forms.TextBox();
            this.textOverAllAverage = new System.Windows.Forms.TextBox();
            this.richTextRegion1 = new System.Windows.Forms.RichTextBox();
            this.richTextRegion2 = new System.Windows.Forms.RichTextBox();
            this.richTextRegion3 = new System.Windows.Forms.RichTextBox();
            this.labelErrors = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entries:";
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegion1.Location = new System.Drawing.Point(146, 100);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(68, 20);
            this.labelRegion1.TabIndex = 1;
            this.labelRegion1.Text = "Region 1";
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(427, 100);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(68, 20);
            this.labelRegion2.TabIndex = 2;
            this.labelRegion2.Text = "Region 2";
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(681, 100);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(68, 20);
            this.labelRegion3.TabIndex = 3;
            this.labelRegion3.Text = "Region 3";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonExit.Location = new System.Drawing.Point(600, 553);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(273, 31);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.buttonExit, "To Exit the application");
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonReset.Location = new System.Drawing.Point(325, 553);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(269, 31);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "It will Reset your Entries");
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEnter.Location = new System.Drawing.Point(41, 553);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(277, 31);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Enter Button");
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInput.Location = new System.Drawing.Point(86, 36);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(114, 27);
            this.textBoxInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxInput, "Please enter the number of cases here.");
            // 
            // textAverage1
            // 
            this.textAverage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAverage1.Location = new System.Drawing.Point(41, 449);
            this.textAverage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAverage1.Name = "textAverage1";
            this.textAverage1.ReadOnly = true;
            this.textAverage1.Size = new System.Drawing.Size(276, 27);
            this.textAverage1.TabIndex = 8;
            this.textAverage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textAverage1, "Average of Region1");
            // 
            // textAverage2
            // 
            this.textAverage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAverage2.Location = new System.Drawing.Point(325, 449);
            this.textAverage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAverage2.Name = "textAverage2";
            this.textAverage2.ReadOnly = true;
            this.textAverage2.Size = new System.Drawing.Size(268, 27);
            this.textAverage2.TabIndex = 9;
            this.textAverage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textAverage2, "Average of Region 2");
            // 
            // textAverage3
            // 
            this.textAverage3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textAverage3.Location = new System.Drawing.Point(600, 449);
            this.textAverage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textAverage3.Name = "textAverage3";
            this.textAverage3.ReadOnly = true;
            this.textAverage3.Size = new System.Drawing.Size(273, 27);
            this.textAverage3.TabIndex = 10;
            this.textAverage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textAverage3, "Average of Region 3");
            // 
            // textOverAllAverage
            // 
            this.textOverAllAverage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textOverAllAverage.Location = new System.Drawing.Point(42, 499);
            this.textOverAllAverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textOverAllAverage.Name = "textOverAllAverage";
            this.textOverAllAverage.ReadOnly = true;
            this.textOverAllAverage.Size = new System.Drawing.Size(831, 27);
            this.textOverAllAverage.TabIndex = 11;
            this.textOverAllAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textOverAllAverage, "Total Average will be Displayed here");
            // 
            // richTextRegion1
            // 
            this.richTextRegion1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextRegion1.Location = new System.Drawing.Point(101, 124);
            this.richTextRegion1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextRegion1.Name = "richTextRegion1";
            this.richTextRegion1.ReadOnly = true;
            this.richTextRegion1.Size = new System.Drawing.Size(146, 293);
            this.richTextRegion1.TabIndex = 20;
            this.richTextRegion1.Text = "";
            this.toolTip1.SetToolTip(this.richTextRegion1, "Your Entrys Of Region 1 Will Be Saved Here");
            // 
            // richTextRegion2
            // 
            this.richTextRegion2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextRegion2.Location = new System.Drawing.Point(385, 124);
            this.richTextRegion2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextRegion2.Name = "richTextRegion2";
            this.richTextRegion2.ReadOnly = true;
            this.richTextRegion2.Size = new System.Drawing.Size(146, 293);
            this.richTextRegion2.TabIndex = 21;
            this.richTextRegion2.Text = "";
            this.toolTip1.SetToolTip(this.richTextRegion2, "Your Entrys Of Region 2 Will Be Saved Here");
            // 
            // richTextRegion3
            // 
            this.richTextRegion3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextRegion3.Location = new System.Drawing.Point(634, 124);
            this.richTextRegion3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextRegion3.Name = "richTextRegion3";
            this.richTextRegion3.ReadOnly = true;
            this.richTextRegion3.Size = new System.Drawing.Size(146, 293);
            this.richTextRegion3.TabIndex = 22;
            this.richTextRegion3.Text = "";
            this.toolTip1.SetToolTip(this.richTextRegion3, "Your Entrys Of Region 3 Will Be Saved Here");
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(214, 36);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(0, 20);
            this.labelErrors.TabIndex = 23;
            // 
            // AverageWeeklyUnitForm
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.richTextRegion3);
            this.Controls.Add(this.richTextRegion2);
            this.Controls.Add(this.richTextRegion1);
            this.Controls.Add(this.textOverAllAverage);
            this.Controls.Add(this.textAverage3);
            this.Controls.Add(this.textAverage2);
            this.Controls.Add(this.textAverage1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(932, 647);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(932, 647);
            this.Name = "AverageWeeklyUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Unit Region Wise";
            this.Load += new System.EventHandler(this.AverageWeeklyUnitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textAverage1;
        private System.Windows.Forms.TextBox textAverage2;
        private System.Windows.Forms.TextBox textAverage3;
        private System.Windows.Forms.TextBox textOverAllAverage;
        private System.Windows.Forms.RichTextBox richTextRegion1;
        private System.Windows.Forms.RichTextBox richTextRegion2;
        private System.Windows.Forms.RichTextBox richTextRegion3;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

