namespace Goku_Words
{
    partial class Form1
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
            this.charBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prefixBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.topBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bottomBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.endResultImage = new System.Windows.Forms.PictureBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.consoleLabel = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.endResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // charBox
            // 
            this.charBox.BackColor = System.Drawing.SystemColors.Control;
            this.charBox.Location = new System.Drawing.Point(70, 12);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(337, 23);
            this.charBox.TabIndex = 0;
            this.charBox.Text = "Goku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Character:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Prefix:";
            // 
            // prefixBox
            // 
            this.prefixBox.BackColor = System.Drawing.SystemColors.Control;
            this.prefixBox.Location = new System.Drawing.Point(93, 41);
            this.prefixBox.Name = "prefixBox";
            this.prefixBox.Size = new System.Drawing.Size(314, 23);
            this.prefixBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Top Text:";
            // 
            // topBox
            // 
            this.topBox.BackColor = System.Drawing.SystemColors.Control;
            this.topBox.Location = new System.Drawing.Point(71, 70);
            this.topBox.Name = "topBox";
            this.topBox.Size = new System.Drawing.Size(336, 23);
            this.topBox.TabIndex = 4;
            this.topBox.Text = "Top Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bottom Text:";
            // 
            // bottomBox
            // 
            this.bottomBox.BackColor = System.Drawing.SystemColors.Control;
            this.bottomBox.Location = new System.Drawing.Point(92, 99);
            this.bottomBox.Name = "bottomBox";
            this.bottomBox.Size = new System.Drawing.Size(315, 23);
            this.bottomBox.TabIndex = 6;
            this.bottomBox.Text = "Bottom Text";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goButton.Location = new System.Drawing.Point(12, 128);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(395, 70);
            this.goButton.TabIndex = 8;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // endResultImage
            // 
            this.endResultImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endResultImage.Location = new System.Drawing.Point(413, 12);
            this.endResultImage.Name = "endResultImage";
            this.endResultImage.Size = new System.Drawing.Size(375, 375);
            this.endResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.endResultImage.TabIndex = 9;
            this.endResultImage.TabStop = false;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyButton.Location = new System.Drawing.Point(413, 393);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(375, 45);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy to clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // consoleLabel
            // 
            this.consoleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consoleLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.consoleLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.consoleLabel.Location = new System.Drawing.Point(12, 199);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.ReadOnly = true;
            this.consoleLabel.Size = new System.Drawing.Size(395, 239);
            this.consoleLabel.TabIndex = 12;
            this.consoleLabel.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.endResultImage);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bottomBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prefixBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charBox);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Goku Words";
            ((System.ComponentModel.ISupportInitialize)(this.endResultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox charBox;
        private Label label1;
        private Label label2;
        private TextBox prefixBox;
        private Label label3;
        private TextBox topBox;
        private Label label4;
        private TextBox bottomBox;
        private Button goButton;
        private PictureBox endResultImage;
        private Button copyButton;
        private RichTextBox consoleLabel;
    }
}