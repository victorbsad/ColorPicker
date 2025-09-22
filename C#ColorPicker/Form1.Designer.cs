namespace C_ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRgbValues = new System.Windows.Forms.Label();
            this.lblSmallScreen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRedValue = new System.Windows.Forms.TextBox();
            this.tbxGreenValue = new System.Windows.Forms.TextBox();
            this.tbxBlueValue = new System.Windows.Forms.TextBox();
            this.pnlSelectorScreen = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHexaValues = new System.Windows.Forms.Label();
            this.tbxHexaValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Picker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // lblRgbValues
            // 
            this.lblRgbValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRgbValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgbValues.Location = new System.Drawing.Point(26, 222);
            this.lblRgbValues.Name = "lblRgbValues";
            this.lblRgbValues.Size = new System.Drawing.Size(197, 25);
            this.lblRgbValues.TabIndex = 2;
            // 
            // lblSmallScreen
            // 
            this.lblSmallScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallScreen.Location = new System.Drawing.Point(245, 244);
            this.lblSmallScreen.Name = "lblSmallScreen";
            this.lblSmallScreen.Size = new System.Drawing.Size(100, 25);
            this.lblSmallScreen.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxHexaValue);
            this.groupBox1.Controls.Add(this.pnlSelectorScreen);
            this.groupBox1.Controls.Add(this.tbxBlueValue);
            this.groupBox1.Controls.Add(this.tbxGreenValue);
            this.groupBox1.Controls.Add(this.tbxRedValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Blue";
            // 
            // tbxRedValue
            // 
            this.tbxRedValue.Location = new System.Drawing.Point(66, 29);
            this.tbxRedValue.Name = "tbxRedValue";
            this.tbxRedValue.ReadOnly = true;
            this.tbxRedValue.Size = new System.Drawing.Size(92, 20);
            this.tbxRedValue.TabIndex = 3;
            // 
            // tbxGreenValue
            // 
            this.tbxGreenValue.Location = new System.Drawing.Point(66, 60);
            this.tbxGreenValue.Name = "tbxGreenValue";
            this.tbxGreenValue.ReadOnly = true;
            this.tbxGreenValue.Size = new System.Drawing.Size(92, 20);
            this.tbxGreenValue.TabIndex = 4;
            // 
            // tbxBlueValue
            // 
            this.tbxBlueValue.Location = new System.Drawing.Point(66, 94);
            this.tbxBlueValue.Name = "tbxBlueValue";
            this.tbxBlueValue.ReadOnly = true;
            this.tbxBlueValue.Size = new System.Drawing.Size(92, 20);
            this.tbxBlueValue.TabIndex = 5;
            // 
            // pnlSelectorScreen
            // 
            this.pnlSelectorScreen.Location = new System.Drawing.Point(230, 49);
            this.pnlSelectorScreen.Name = "pnlSelectorScreen";
            this.pnlSelectorScreen.Size = new System.Drawing.Size(109, 85);
            this.pnlSelectorScreen.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(138, 489);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHexaValues
            // 
            this.lblHexaValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHexaValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaValues.Location = new System.Drawing.Point(26, 263);
            this.lblHexaValues.Name = "lblHexaValues";
            this.lblHexaValues.Size = new System.Drawing.Size(197, 25);
            this.lblHexaValues.TabIndex = 5;
            // 
            // tbxHexaValue
            // 
            this.tbxHexaValue.Location = new System.Drawing.Point(66, 130);
            this.tbxHexaValue.Name = "tbxHexaValue";
            this.tbxHexaValue.ReadOnly = true;
            this.tbxHexaValue.Size = new System.Drawing.Size(92, 20);
            this.tbxHexaValue.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hexa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 537);
            this.Controls.Add(this.lblHexaValues);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSmallScreen);
            this.Controls.Add(this.lblRgbValues);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRgbValues;
        private System.Windows.Forms.Label lblSmallScreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBlueValue;
        private System.Windows.Forms.TextBox tbxGreenValue;
        private System.Windows.Forms.TextBox tbxRedValue;
        private System.Windows.Forms.Panel pnlSelectorScreen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHexaValues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxHexaValue;
    }
}

