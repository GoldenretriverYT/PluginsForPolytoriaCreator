namespace Plugins_for_Polytoria_Creator.Utils {
    partial class AddFromGITForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonAddFromGIT = new System.Windows.Forms.Button();
            this.TextBoxGitURL = new System.Windows.Forms.TextBox();
            this.LabelGitURL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAddFromGIT
            // 
            this.ButtonAddFromGIT.Location = new System.Drawing.Point(19, 275);
            this.ButtonAddFromGIT.Name = "ButtonAddFromGIT";
            this.ButtonAddFromGIT.Size = new System.Drawing.Size(501, 50);
            this.ButtonAddFromGIT.TabIndex = 5;
            this.ButtonAddFromGIT.Text = "Install from Git Repository";
            this.ButtonAddFromGIT.UseVisualStyleBackColor = true;
            this.ButtonAddFromGIT.Click += new System.EventHandler(this.ButtonAddFromGIT_Click);
            // 
            // TextBoxGitURL
            // 
            this.TextBoxGitURL.Location = new System.Drawing.Point(19, 54);
            this.TextBoxGitURL.Name = "TextBoxGitURL";
            this.TextBoxGitURL.Size = new System.Drawing.Size(501, 29);
            this.TextBoxGitURL.TabIndex = 4;
            // 
            // LabelGitURL
            // 
            this.LabelGitURL.AutoSize = true;
            this.LabelGitURL.Location = new System.Drawing.Point(19, 30);
            this.LabelGitURL.Name = "LabelGitURL";
            this.LabelGitURL.Size = new System.Drawing.Size(62, 21);
            this.LabelGitURL.TabIndex = 3;
            this.LabelGitURL.Text = "Git URL";
            // 
            // AddFromGITForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 337);
            this.Controls.Add(this.ButtonAddFromGIT);
            this.Controls.Add(this.TextBoxGitURL);
            this.Controls.Add(this.LabelGitURL);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddFromGITForm";
            this.Text = "AddFromGITForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonAddFromGIT;
        private TextBox TextBoxGitURL;
        private Label LabelGitURL;
    }
}