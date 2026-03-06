namespace ColorPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.redLbl = new System.Windows.Forms.Label();
            this.greenLbl = new System.Windows.Forms.Label();
            this.blueLbl = new System.Windows.Forms.Label();
            this.hexaCodeLbl = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chsColorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // redTrackBar
            // 
            this.redTrackBar.LargeChange = 30;
            this.redTrackBar.Location = new System.Drawing.Point(134, 93);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(670, 56);
            this.redTrackBar.TabIndex = 0;
            this.redTrackBar.Value = 255;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color Picker";
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.LargeChange = 30;
            this.greenTrackBar.Location = new System.Drawing.Point(134, 173);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(670, 56);
            this.greenTrackBar.TabIndex = 2;
            this.greenTrackBar.Value = 255;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.LargeChange = 30;
            this.blueTrackBar.Location = new System.Drawing.Point(134, 253);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(670, 56);
            this.blueTrackBar.TabIndex = 3;
            this.blueTrackBar.Value = 255;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Green";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(29, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blue";
            // 
            // redLbl
            // 
            this.redLbl.AutoSize = true;
            this.redLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLbl.Location = new System.Drawing.Point(822, 97);
            this.redLbl.Name = "redLbl";
            this.redLbl.Size = new System.Drawing.Size(66, 36);
            this.redLbl.TabIndex = 7;
            this.redLbl.Text = "255";
            // 
            // greenLbl
            // 
            this.greenLbl.AutoSize = true;
            this.greenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLbl.Location = new System.Drawing.Point(822, 173);
            this.greenLbl.Name = "greenLbl";
            this.greenLbl.Size = new System.Drawing.Size(66, 36);
            this.greenLbl.TabIndex = 8;
            this.greenLbl.Text = "255";
            // 
            // blueLbl
            // 
            this.blueLbl.AutoSize = true;
            this.blueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLbl.Location = new System.Drawing.Point(822, 253);
            this.blueLbl.Name = "blueLbl";
            this.blueLbl.Size = new System.Drawing.Size(66, 36);
            this.blueLbl.TabIndex = 9;
            this.blueLbl.Text = "255";
            // 
            // hexaCodeLbl
            // 
            this.hexaCodeLbl.AutoSize = true;
            this.hexaCodeLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hexaCodeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexaCodeLbl.Location = new System.Drawing.Point(391, 333);
            this.hexaCodeLbl.Name = "hexaCodeLbl";
            this.hexaCodeLbl.Size = new System.Drawing.Size(136, 30);
            this.hexaCodeLbl.TabIndex = 10;
            this.hexaCodeLbl.Text = "#FFFFFFFFF";
            this.hexaCodeLbl.Click += new System.EventHandler(this.hexaCodeLbl_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.BackgroundImage = global::ColorPicker.Properties.Resources.copy_document;
            this.copyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyBtn.Location = new System.Drawing.Point(533, 328);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(48, 48);
            this.copyBtn.TabIndex = 11;
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chsColorBtn
            // 
            this.chsColorBtn.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chsColorBtn.Location = new System.Drawing.Point(392, 404);
            this.chsColorBtn.Name = "chsColorBtn";
            this.chsColorBtn.Size = new System.Drawing.Size(139, 58);
            this.chsColorBtn.TabIndex = 12;
            this.chsColorBtn.Text = "Choose Color";
            this.chsColorBtn.UseVisualStyleBackColor = true;
            this.chsColorBtn.Click += new System.EventHandler(this.chsColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 523);
            this.Controls.Add(this.chsColorBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.hexaCodeLbl);
            this.Controls.Add(this.blueLbl);
            this.Controls.Add(this.greenLbl);
            this.Controls.Add(this.redLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redTrackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label redLbl;
        private System.Windows.Forms.Label greenLbl;
        private System.Windows.Forms.Label blueLbl;
        private System.Windows.Forms.Label hexaCodeLbl;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button chsColorBtn;
    }
}

