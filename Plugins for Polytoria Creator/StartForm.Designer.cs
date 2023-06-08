namespace Plugins_for_Polytoria_Creator {
    partial class StartForm {
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
            this.LabelPolytoriaCreator = new System.Windows.Forms.Label();
            this.ButtonInstallLoader = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgessBarState = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListBoxMods = new System.Windows.Forms.ListBox();
            this.LabelInstalled = new System.Windows.Forms.Label();
            this.LabelModTitle = new System.Windows.Forms.Label();
            this.LabelMinVersion = new System.Windows.Forms.Label();
            this.LabelMaxVersion = new System.Windows.Forms.Label();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonInstallFromZip = new System.Windows.Forms.Button();
            this.OpenFileDialogZipFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPolytoriaCreator
            // 
            this.LabelPolytoriaCreator.AutoSize = true;
            this.LabelPolytoriaCreator.Location = new System.Drawing.Point(15, 13);
            this.LabelPolytoriaCreator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPolytoriaCreator.Name = "LabelPolytoriaCreator";
            this.LabelPolytoriaCreator.Size = new System.Drawing.Size(371, 21);
            this.LabelPolytoriaCreator.TabIndex = 0;
            this.LabelPolytoriaCreator.Text = "Polytoria Creator Version: 0.0.0; Loader installed: No";
            // 
            // ButtonInstallLoader
            // 
            this.ButtonInstallLoader.Location = new System.Drawing.Point(629, 13);
            this.ButtonInstallLoader.Name = "ButtonInstallLoader";
            this.ButtonInstallLoader.Size = new System.Drawing.Size(162, 36);
            this.ButtonInstallLoader.TabIndex = 1;
            this.ButtonInstallLoader.Text = "Install Loader/Sync";
            this.ButtonInstallLoader.UseVisualStyleBackColor = true;
            this.ButtonInstallLoader.Click += new System.EventHandler(this.ButtonInstallLoader_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgessBarState,
            this.LabelState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgessBarState
            // 
            this.ProgessBarState.Name = "ProgessBarState";
            this.ProgessBarState.Size = new System.Drawing.Size(250, 16);
            // 
            // LabelState
            // 
            this.LabelState.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new System.Drawing.Size(116, 17);
            this.LabelState.Text = "State: Doing nothing";
            // 
            // ListBoxMods
            // 
            this.ListBoxMods.FormattingEnabled = true;
            this.ListBoxMods.ItemHeight = 21;
            this.ListBoxMods.Location = new System.Drawing.Point(12, 65);
            this.ListBoxMods.Name = "ListBoxMods";
            this.ListBoxMods.Size = new System.Drawing.Size(305, 277);
            this.ListBoxMods.TabIndex = 3;
            // 
            // LabelInstalled
            // 
            this.LabelInstalled.AutoSize = true;
            this.LabelInstalled.Location = new System.Drawing.Point(12, 41);
            this.LabelInstalled.Name = "LabelInstalled";
            this.LabelInstalled.Size = new System.Drawing.Size(115, 21);
            this.LabelInstalled.TabIndex = 4;
            this.LabelInstalled.Text = "Isntalled mods:";
            // 
            // LabelModTitle
            // 
            this.LabelModTitle.AutoSize = true;
            this.LabelModTitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelModTitle.Location = new System.Drawing.Point(323, 65);
            this.LabelModTitle.Name = "LabelModTitle";
            this.LabelModTitle.Size = new System.Drawing.Size(460, 30);
            this.LabelModTitle.TabIndex = 5;
            this.LabelModTitle.Text = "Click an installed mod to see more information";
            // 
            // LabelMinVersion
            // 
            this.LabelMinVersion.AutoSize = true;
            this.LabelMinVersion.Location = new System.Drawing.Point(323, 95);
            this.LabelMinVersion.Name = "LabelMinVersion";
            this.LabelMinVersion.Size = new System.Drawing.Size(203, 21);
            this.LabelMinVersion.TabIndex = 6;
            this.LabelMinVersion.Text = "Minimum creator version: ?";
            // 
            // LabelMaxVersion
            // 
            this.LabelMaxVersion.AutoSize = true;
            this.LabelMaxVersion.Location = new System.Drawing.Point(323, 116);
            this.LabelMaxVersion.Name = "LabelMaxVersion";
            this.LabelMaxVersion.Size = new System.Drawing.Size(205, 21);
            this.LabelMaxVersion.TabIndex = 7;
            this.LabelMaxVersion.Text = "Maximum creator version: ?";
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(323, 345);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(460, 40);
            this.ButtonRemove.TabIndex = 8;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonInstallFromZip
            // 
            this.ButtonInstallFromZip.Location = new System.Drawing.Point(12, 345);
            this.ButtonInstallFromZip.Name = "ButtonInstallFromZip";
            this.ButtonInstallFromZip.Size = new System.Drawing.Size(305, 40);
            this.ButtonInstallFromZip.TabIndex = 9;
            this.ButtonInstallFromZip.Text = "Install from zip file";
            this.ButtonInstallFromZip.UseVisualStyleBackColor = true;
            this.ButtonInstallFromZip.Click += new System.EventHandler(this.ButtonInstallFromZip_Click);
            // 
            // OpenFileDialogZipFile
            // 
            this.OpenFileDialogZipFile.Filter = "ZIP-Files|*.zip";
            this.OpenFileDialogZipFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogZipFile_FileOk);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 410);
            this.Controls.Add(this.ButtonInstallFromZip);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.LabelMaxVersion);
            this.Controls.Add(this.LabelMinVersion);
            this.Controls.Add(this.LabelModTitle);
            this.Controls.Add(this.LabelInstalled);
            this.Controls.Add(this.ListBoxMods);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonInstallLoader);
            this.Controls.Add(this.LabelPolytoriaCreator);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelPolytoriaCreator;
        private Button ButtonInstallLoader;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar ProgessBarState;
        private ToolStripStatusLabel LabelState;
        private ListBox ListBoxMods;
        private Label LabelInstalled;
        private Label LabelModTitle;
        private Label LabelMinVersion;
        private Label LabelMaxVersion;
        private Button ButtonRemove;
        private Button ButtonInstallFromZip;
        private OpenFileDialog OpenFileDialogZipFile;
    }
}