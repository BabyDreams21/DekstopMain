namespace Hubstaf
{
    partial class Uploadimage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uploadimage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUapload = new Guna.UI.WinForms.GunaButton();
            this.btndownload = new Guna.UI.WinForms.GunaGradientButton();
            this.txtFileName = new Guna.UI.WinForms.GunaTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(272, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUapload
            // 
            this.btnUapload.AnimationHoverSpeed = 0.07F;
            this.btnUapload.AnimationSpeed = 0.03F;
            this.btnUapload.BackColor = System.Drawing.Color.Transparent;
            this.btnUapload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUapload.BorderColor = System.Drawing.Color.Black;
            this.btnUapload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUapload.FocusedColor = System.Drawing.Color.Empty;
            this.btnUapload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUapload.ForeColor = System.Drawing.Color.White;
            this.btnUapload.Image = ((System.Drawing.Image)(resources.GetObject("btnUapload.Image")));
            this.btnUapload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUapload.Location = new System.Drawing.Point(485, 134);
            this.btnUapload.Name = "btnUapload";
            this.btnUapload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUapload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUapload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUapload.OnHoverImage = null;
            this.btnUapload.OnPressedColor = System.Drawing.Color.Black;
            this.btnUapload.Radius = 10;
            this.btnUapload.Size = new System.Drawing.Size(160, 42);
            this.btnUapload.TabIndex = 0;
            this.btnUapload.Text = "Upload File";
            this.btnUapload.Click += new System.EventHandler(this.btnUapload_Click);
            // 
            // btndownload
            // 
            this.btndownload.AnimationHoverSpeed = 0.07F;
            this.btndownload.AnimationSpeed = 0.03F;
            this.btndownload.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btndownload.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btndownload.BorderColor = System.Drawing.Color.Black;
            this.btndownload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndownload.FocusedColor = System.Drawing.Color.Empty;
            this.btndownload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndownload.ForeColor = System.Drawing.Color.White;
            this.btndownload.Image = ((System.Drawing.Image)(resources.GetObject("btndownload.Image")));
            this.btndownload.ImageSize = new System.Drawing.Size(20, 20);
            this.btndownload.Location = new System.Drawing.Point(237, 311);
            this.btndownload.Name = "btndownload";
            this.btndownload.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btndownload.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btndownload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndownload.OnHoverForeColor = System.Drawing.Color.White;
            this.btndownload.OnHoverImage = null;
            this.btndownload.OnPressedColor = System.Drawing.Color.Black;
            this.btndownload.Size = new System.Drawing.Size(160, 42);
            this.btndownload.TabIndex = 2;
            this.btndownload.Text = "Doanload";
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BaseColor = System.Drawing.Color.White;
            this.txtFileName.BorderColor = System.Drawing.Color.Silver;
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFileName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFileName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFileName.Location = new System.Drawing.Point(501, 281);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(144, 26);
            this.txtFileName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Uploadimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUapload);
            this.Name = "Uploadimage";
            this.Text = "Uploadimage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnUapload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btndownload;
        private Guna.UI.WinForms.GunaTextBox txtFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}