namespace Hubstaf
{
    partial class Timer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtresult = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtresult.BaseColor = System.Drawing.Color.Black;
            this.txtresult.BorderColor = System.Drawing.Color.Black;
            this.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresult.FocusedBaseColor = System.Drawing.Color.White;
            this.txtresult.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtresult.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtresult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtresult.Location = new System.Drawing.Point(0, 0);
            this.txtresult.Name = "txtresult";
            this.txtresult.PasswordChar = '\0';
            this.txtresult.SelectedText = "";
            this.txtresult.Size = new System.Drawing.Size(161, 32);
            this.txtresult.TabIndex = 3;
            this.txtresult.Text = "00:00:00";
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtresult);
            this.Name = "Timer";
            this.Size = new System.Drawing.Size(161, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtresult;
    }
}
