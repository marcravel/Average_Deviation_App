namespace Average_Deviation_App
{
    partial class Form1
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.GroupBox();
            this.averageRadio = new System.Windows.Forms.RadioButton();
            this.deviationRadio = new System.Windows.Forms.RadioButton();
            this.deviationAvgRadio = new System.Windows.Forms.RadioButton();
            this.resultRichText = new System.Windows.Forms.RichTextBox();
            this.standartDeviationRadio = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.Operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(12, 12);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(245, 27);
            this.valueTextBox.TabIndex = 0;
            this.valueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTextBox_KeyPress);
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 20;
            this.valuesListBox.Location = new System.Drawing.Point(12, 45);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(245, 344);
            this.valuesListBox.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(285, 60);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(186, 42);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // Operations
            // 
            this.Operations.Controls.Add(this.standartDeviationRadio);
            this.Operations.Controls.Add(this.deviationAvgRadio);
            this.Operations.Controls.Add(this.deviationRadio);
            this.Operations.Controls.Add(this.averageRadio);
            this.Operations.Location = new System.Drawing.Point(285, 108);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(186, 147);
            this.Operations.TabIndex = 4;
            this.Operations.TabStop = false;
            this.Operations.Text = "Operations";
            // 
            // averageRadio
            // 
            this.averageRadio.AutoSize = true;
            this.averageRadio.Checked = true;
            this.averageRadio.Location = new System.Drawing.Point(6, 26);
            this.averageRadio.Name = "averageRadio";
            this.averageRadio.Size = new System.Drawing.Size(91, 24);
            this.averageRadio.TabIndex = 0;
            this.averageRadio.TabStop = true;
            this.averageRadio.Text = "Avarage";
            this.averageRadio.UseVisualStyleBackColor = true;
            // 
            // deviationRadio
            // 
            this.deviationRadio.AutoSize = true;
            this.deviationRadio.Location = new System.Drawing.Point(6, 56);
            this.deviationRadio.Name = "deviationRadio";
            this.deviationRadio.Size = new System.Drawing.Size(100, 24);
            this.deviationRadio.TabIndex = 1;
            this.deviationRadio.Text = "Deviation";
            this.deviationRadio.UseVisualStyleBackColor = true;
            // 
            // deviationAvgRadio
            // 
            this.deviationAvgRadio.AutoSize = true;
            this.deviationAvgRadio.Location = new System.Drawing.Point(6, 86);
            this.deviationAvgRadio.Name = "deviationAvgRadio";
            this.deviationAvgRadio.Size = new System.Drawing.Size(133, 24);
            this.deviationAvgRadio.TabIndex = 2;
            this.deviationAvgRadio.Text = "Deviation Avg";
            this.deviationAvgRadio.UseVisualStyleBackColor = true;
            // 
            // resultRichText
            // 
            this.resultRichText.Location = new System.Drawing.Point(285, 261);
            this.resultRichText.Name = "resultRichText";
            this.resultRichText.Size = new System.Drawing.Size(186, 188);
            this.resultRichText.TabIndex = 5;
            this.resultRichText.Text = "";
            // 
            // standartDeviationRadio
            // 
            this.standartDeviationRadio.AutoSize = true;
            this.standartDeviationRadio.Location = new System.Drawing.Point(6, 116);
            this.standartDeviationRadio.Name = "standartDeviationRadio";
            this.standartDeviationRadio.Size = new System.Drawing.Size(168, 24);
            this.standartDeviationRadio.TabIndex = 3;
            this.standartDeviationRadio.Text = "Standart Deviation";
            this.standartDeviationRadio.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 395);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(245, 54);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(285, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(186, 42);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 465);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resultRichText);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.valueTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operations.ResumeLayout(false);
            this.Operations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.GroupBox Operations;
        private System.Windows.Forms.RadioButton deviationAvgRadio;
        private System.Windows.Forms.RadioButton deviationRadio;
        private System.Windows.Forms.RadioButton averageRadio;
        private System.Windows.Forms.RichTextBox resultRichText;
        private System.Windows.Forms.RadioButton standartDeviationRadio;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

