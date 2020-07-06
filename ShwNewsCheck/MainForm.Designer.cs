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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSetupBot = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelOperationsLeft = new System.Windows.Forms.Panel();
            this.panelOperationsBot = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panelSetupBot);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 597);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelSetupBot
            // 
            this.panelSetupBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSetupBot.Location = new System.Drawing.Point(3, 600);
            this.panelSetupBot.Name = "panelSetupBot";
            this.panelSetupBot.Size = new System.Drawing.Size(994, 100);
            this.panelSetupBot.TabIndex = 0;
            // 
            // tabPage2
            // 
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
            // panelOperationsLeft
            // 
            this.panelOperationsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOperationsLeft.Location = new System.Drawing.Point(3, 3);
            this.panelOperationsLeft.Name = "panelOperationsLeft";
            this.panelOperationsLeft.Size = new System.Drawing.Size(200, 597);
            this.panelOperationsLeft.TabIndex = 1;
            // 
            // panelOperationsBot
            // 
            this.panelOperationsBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOperationsBot.Location = new System.Drawing.Point(3, 600);
            this.panelOperationsBot.Name = "panelOperationsBot";
            this.panelOperationsBot.Size = new System.Drawing.Size(994, 100);
            this.panelOperationsBot.TabIndex = 0;
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
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelSetupBot;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelOperationsLeft;
        private System.Windows.Forms.Panel panelOperationsBot;
    }
}

