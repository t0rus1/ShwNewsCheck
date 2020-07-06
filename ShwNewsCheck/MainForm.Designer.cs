namespace ShwNewsCheck
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.panelSetupBot = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelOperationsRight = new System.Windows.Forms.Panel();
            this.panelOperationsLeft = new System.Windows.Forms.Panel();
            this.listBoxShares = new System.Windows.Forms.ListBox();
            this.panelOperationsBot = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.stripText2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panelSetupBot.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelOperationsLeft.SuspendLayout();
            this.panelOperationsBot.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1008, 729);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgView);
            this.tabPage1.Controls.Add(this.panelSetupBot);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgView.Location = new System.Drawing.Point(3, 3);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(994, 597);
            this.dgView.TabIndex = 1;
            // 
            // panelSetupBot
            // 
            this.panelSetupBot.Controls.Add(this.statusStrip1);
            this.panelSetupBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSetupBot.Location = new System.Drawing.Point(3, 600);
            this.panelSetupBot.Name = "panelSetupBot";
            this.panelSetupBot.Size = new System.Drawing.Size(994, 100);
            this.panelSetupBot.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 78);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(994, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripText
            // 
            this.stripText.Name = "stripText";
            this.stripText.Size = new System.Drawing.Size(22, 17);
            this.stripText.Text = "Ok";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelOperationsRight);
            this.tabPage2.Controls.Add(this.panelOperationsLeft);
            this.tabPage2.Controls.Add(this.panelOperationsBot);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 703);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelOperationsRight
            // 
            this.panelOperationsRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperationsRight.Location = new System.Drawing.Point(239, 3);
            this.panelOperationsRight.Name = "panelOperationsRight";
            this.panelOperationsRight.Size = new System.Drawing.Size(758, 597);
            this.panelOperationsRight.TabIndex = 2;
            // 
            // panelOperationsLeft
            // 
            this.panelOperationsLeft.Controls.Add(this.listBoxShares);
            this.panelOperationsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOperationsLeft.Location = new System.Drawing.Point(3, 3);
            this.panelOperationsLeft.Name = "panelOperationsLeft";
            this.panelOperationsLeft.Size = new System.Drawing.Size(236, 597);
            this.panelOperationsLeft.TabIndex = 1;
            // 
            // listBoxShares
            // 
            this.listBoxShares.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxShares.FormattingEnabled = true;
            this.listBoxShares.Location = new System.Drawing.Point(0, 164);
            this.listBoxShares.Name = "listBoxShares";
            this.listBoxShares.Size = new System.Drawing.Size(236, 433);
            this.listBoxShares.TabIndex = 0;
            // 
            // panelOperationsBot
            // 
            this.panelOperationsBot.Controls.Add(this.statusStrip2);
            this.panelOperationsBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOperationsBot.Location = new System.Drawing.Point(3, 600);
            this.panelOperationsBot.Name = "panelOperationsBot";
            this.panelOperationsBot.Size = new System.Drawing.Size(994, 100);
            this.panelOperationsBot.TabIndex = 0;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripText2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 78);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(994, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // stripText2
            // 
            this.stripText2.Name = "stripText2";
            this.stripText2.Size = new System.Drawing.Size(22, 17);
            this.stripText2.Text = "Ok";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Shw News Check";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panelSetupBot.ResumeLayout(false);
            this.panelSetupBot.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelOperationsLeft.ResumeLayout(false);
            this.panelOperationsBot.ResumeLayout(false);
            this.panelOperationsBot.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelSetupBot;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelOperationsLeft;
        private System.Windows.Forms.Panel panelOperationsBot;
        private System.Windows.Forms.Panel panelOperationsRight;
        private System.Windows.Forms.ListBox listBoxShares;
        private System.Windows.Forms.ToolStripStatusLabel stripText;
        private System.Windows.Forms.ToolStripStatusLabel stripText2;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.StatusStrip statusStrip2;
        internal System.Windows.Forms.DataGridView dgView;
    }
}

