namespace Hubstaf
{
    partial class AddDialog
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txttodo = new Guna.UI.WinForms.GunaTextBox();
            this.btndone = new Guna.UI.WinForms.GunaButton();
            this.btncancel = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(106, 53);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(52, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "To-do:";
            // 
            // txttodo
            // 
            this.txttodo.BaseColor = System.Drawing.Color.White;
            this.txttodo.BorderColor = System.Drawing.Color.Silver;
            this.txttodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttodo.FocusedBaseColor = System.Drawing.Color.White;
            this.txttodo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttodo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttodo.Location = new System.Drawing.Point(161, 48);
            this.txttodo.Name = "txttodo";
            this.txttodo.PasswordChar = '\0';
            this.txttodo.SelectedText = "";
            this.txttodo.Size = new System.Drawing.Size(312, 30);
            this.txttodo.TabIndex = 1;
            this.txttodo.TextChanged += new System.EventHandler(this.txttodo_TextChanged);
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
            this.btndone.Location = new System.Drawing.Point(319, 114);
            this.btndone.Name = "btndone";
            this.btndone.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btndone.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btndone.OnHoverForeColor = System.Drawing.Color.White;
            this.btndone.OnHoverImage = null;
            this.btndone.OnPressedColor = System.Drawing.Color.Black;
            this.btndone.Size = new System.Drawing.Size(74, 26);
            this.btndone.TabIndex = 3;
            this.btndone.Text = "Done";
            this.btndone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btndone.Click += new System.EventHandler(this.btndone_Click);
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
            this.btncancel.Location = new System.Drawing.Point(399, 114);
            this.btncancel.Name = "btncancel";
            this.btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btncancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancel.OnHoverForeColor = System.Drawing.Color.Wheat;
            this.btncancel.OnHoverImage = null;
            this.btncancel.OnPressedColor = System.Drawing.Color.Black;
            this.btncancel.Size = new System.Drawing.Size(74, 26);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(485, 168);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndone);
            this.Controls.Add(this.txttodo);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to-do to project";
            this.Load += new System.EventHandler(this.AddDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txttodo;
        private Guna.UI.WinForms.GunaButton btndone;
        private Guna.UI.WinForms.GunaButton btncancel;
    }
}