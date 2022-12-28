namespace Hubstaf
{
    partial class AddWorks
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
            this.btncancel = new Guna.UI.WinForms.GunaButton();
            this.btndone = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.AnimationHoverSpeed = 0.07F;
            this.btncancel.AnimationSpeed = 0.03F;
            this.btncancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancel.BaseColor = System.Drawing.SystemColors.Control;
            this.btncancel.BorderColor = System.Drawing.Color.Black;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncancel.FocusedColor = System.Drawing.Color.Empty;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btncancel.Image = null;
            this.btncancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancel.Location = new System.Drawing.Point(379, 189);
            this.btncancel.Name = "btncancel";
            this.btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btncancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancel.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.btncancel.OnHoverImage = null;
            this.btncancel.OnPressedColor = System.Drawing.Color.Black;
            this.btncancel.Size = new System.Drawing.Size(74, 26);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndone
            // 
            this.btndone.AnimationHoverSpeed = 0.07F;
            this.btndone.AnimationSpeed = 0.03F;
            this.btndone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btndone.BorderColor = System.Drawing.Color.Black;
            this.btndone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btndone.FocusedColor = System.Drawing.Color.Empty;
            this.btndone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndone.ForeColor = System.Drawing.Color.White;
            this.btndone.Image = null;
            this.btndone.ImageSize = new System.Drawing.Size(20, 20);
            this.btndone.Location = new System.Drawing.Point(12, 189);
            this.btndone.Name = "btndone";
            this.btndone.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndone.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndone.OnHoverForeColor = System.Drawing.Color.White;
            this.btndone.OnHoverImage = null;
            this.btndone.OnPressedColor = System.Drawing.Color.Black;
            this.btndone.Size = new System.Drawing.Size(74, 26);
            this.btndone.TabIndex = 5;
            this.btndone.Text = "Done";
            this.btndone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(12, 39);
            this.gunaTextBox1.Multiline = true;
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(441, 144);
            this.gunaTextBox1.TabIndex = 7;
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // AddWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 227);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddWorks";
            this.Text = "AddWorks";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btncancel;
        private Guna.UI.WinForms.GunaButton btndone;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
    }
}