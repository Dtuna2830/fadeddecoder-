namespace FadedDecoder
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.b64InputBox = new System.Windows.Forms.RichTextBox();
            this.b64OutputBox = new System.Windows.Forms.RichTextBox();
            this.outputClearCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encodingSwitcher = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b64InputBox
            // 
            this.b64InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b64InputBox.ForeColor = System.Drawing.Color.Black;
            this.b64InputBox.Location = new System.Drawing.Point(17, 70);
            this.b64InputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b64InputBox.Name = "b64InputBox";
            this.b64InputBox.Size = new System.Drawing.Size(243, 121);
            this.b64InputBox.TabIndex = 1;
            this.b64InputBox.Text = "";
            // 
            // b64OutputBox
            // 
            this.b64OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b64OutputBox.Location = new System.Drawing.Point(310, 70);
            this.b64OutputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b64OutputBox.Name = "b64OutputBox";
            this.b64OutputBox.ReadOnly = true;
            this.b64OutputBox.Size = new System.Drawing.Size(243, 121);
            this.b64OutputBox.TabIndex = 3;
            this.b64OutputBox.Text = "";
            // 
            // outputClearCheckbox
            // 
            this.outputClearCheckbox.AutoSize = true;
            this.outputClearCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputClearCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputClearCheckbox.Location = new System.Drawing.Point(95, 340);
            this.outputClearCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputClearCheckbox.Name = "outputClearCheckbox";
            this.outputClearCheckbox.Size = new System.Drawing.Size(105, 21);
            this.outputClearCheckbox.TabIndex = 4;
            this.outputClearCheckbox.Text = "Clear Output";
            this.outputClearCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Options";
            // 
            // encodingSwitcher
            // 
            this.encodingSwitcher.Appearance = System.Windows.Forms.Appearance.Button;
            this.encodingSwitcher.AutoSize = true;
            this.encodingSwitcher.FlatAppearance.BorderSize = 0;
            this.encodingSwitcher.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.encodingSwitcher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.encodingSwitcher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.encodingSwitcher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encodingSwitcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodingSwitcher.Location = new System.Drawing.Point(194, 337);
            this.encodingSwitcher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encodingSwitcher.Name = "encodingSwitcher";
            this.encodingSwitcher.Size = new System.Drawing.Size(121, 27);
            this.encodingSwitcher.TabIndex = 6;
            this.encodingSwitcher.Text = "Switch Encoding";
            this.encodingSwitcher.UseVisualStyleBackColor = true;
            this.encodingSwitcher.CheckedChanged += new System.EventHandler(this.encodeOption_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox3.Image = global::FadedDecoder.Properties.Resources.fadeddeco;
            this.pictureBox3.Location = new System.Drawing.Point(55, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 28);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox2.Image = global::FadedDecoder.Properties.Resources.fadelogomini;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // decodeButton
            // 
            this.decodeButton.BackColor = System.Drawing.Color.DimGray;
            this.decodeButton.BackgroundImage = global::FadedDecoder.Properties.Resources.decode;
            this.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeButton.Location = new System.Drawing.Point(172, 215);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(2);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(215, 90);
            this.decodeButton.TabIndex = 2;
            this.decodeButton.UseVisualStyleBackColor = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputClearCheckbox);
            this.Controls.Add(this.b64OutputBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.b64InputBox);
            this.Controls.Add(this.encodingSwitcher);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindowForm";
            this.Text = "Faded Decoder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox b64InputBox;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.RichTextBox b64OutputBox;
        private System.Windows.Forms.CheckBox outputClearCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox encodingSwitcher;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

