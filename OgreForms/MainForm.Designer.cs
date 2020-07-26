namespace OgreForms
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.LeftTabControl = new System.Windows.Forms.TabControl();
            this.LeftTabPage1 = new System.Windows.Forms.TabPage();
            this.StartButton = new System.Windows.Forms.Button();
            this.LeftTabPage2 = new System.Windows.Forms.TabPage();
            this.RightTabControl = new System.Windows.Forms.TabControl();
            this.RightTabPage1 = new System.Windows.Forms.TabPage();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RightTabPage2 = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogBottomControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoScrollCB = new System.Windows.Forms.CheckBox();
            this.ClearDebugButton = new System.Windows.Forms.Button();
            this.RenderButton = new System.Windows.Forms.Button();
            this.LeftTabControl.SuspendLayout();
            this.LeftTabPage1.SuspendLayout();
            this.RightTabControl.SuspendLayout();
            this.RightTabPage1.SuspendLayout();
            this.RightTabPage2.SuspendLayout();
            this.LogBottomControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftTabControl
            // 
            this.LeftTabControl.Controls.Add(this.LeftTabPage1);
            this.LeftTabControl.Controls.Add(this.LeftTabPage2);
            this.LeftTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftTabControl.Location = new System.Drawing.Point(0, 0);
            this.LeftTabControl.Name = "LeftTabControl";
            this.LeftTabControl.SelectedIndex = 0;
            this.LeftTabControl.Size = new System.Drawing.Size(200, 423);
            this.LeftTabControl.TabIndex = 0;
            // 
            // LeftTabPage1
            // 
            this.LeftTabPage1.Controls.Add(this.RenderButton);
            this.LeftTabPage1.Controls.Add(this.StartButton);
            this.LeftTabPage1.Location = new System.Drawing.Point(4, 22);
            this.LeftTabPage1.Name = "LeftTabPage1";
            this.LeftTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.LeftTabPage1.Size = new System.Drawing.Size(192, 397);
            this.LeftTabPage1.TabIndex = 0;
            this.LeftTabPage1.Text = "Tab1";
            this.LeftTabPage1.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(8, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LeftTabPage2
            // 
            this.LeftTabPage2.Location = new System.Drawing.Point(4, 22);
            this.LeftTabPage2.Name = "LeftTabPage2";
            this.LeftTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.LeftTabPage2.Size = new System.Drawing.Size(192, 397);
            this.LeftTabPage2.TabIndex = 1;
            this.LeftTabPage2.Text = "Tab2";
            this.LeftTabPage2.UseVisualStyleBackColor = true;
            // 
            // RightTabControl
            // 
            this.RightTabControl.Controls.Add(this.RightTabPage1);
            this.RightTabControl.Controls.Add(this.RightTabPage2);
            this.RightTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightTabControl.Location = new System.Drawing.Point(200, 0);
            this.RightTabControl.Name = "RightTabControl";
            this.RightTabControl.SelectedIndex = 0;
            this.RightTabControl.Size = new System.Drawing.Size(389, 423);
            this.RightTabControl.TabIndex = 0;
            // 
            // RightTabPage1
            // 
            this.RightTabPage1.Controls.Add(this.Panel1);
            this.RightTabPage1.Location = new System.Drawing.Point(4, 22);
            this.RightTabPage1.Name = "RightTabPage1";
            this.RightTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.RightTabPage1.Size = new System.Drawing.Size(381, 397);
            this.RightTabPage1.TabIndex = 0;
            this.RightTabPage1.Text = "Tab1";
            this.RightTabPage1.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(375, 391);
            this.Panel1.TabIndex = 1;
            // 
            // RightTabPage2
            // 
            this.RightTabPage2.Controls.Add(this.LogTextBox);
            this.RightTabPage2.Controls.Add(this.LogBottomControlsGroupBox);
            this.RightTabPage2.Location = new System.Drawing.Point(4, 22);
            this.RightTabPage2.Name = "RightTabPage2";
            this.RightTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.RightTabPage2.Size = new System.Drawing.Size(381, 397);
            this.RightTabPage2.TabIndex = 1;
            this.RightTabPage2.Text = "Tab2";
            this.RightTabPage2.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.Color.Black;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogTextBox.ForeColor = System.Drawing.Color.White;
            this.LogTextBox.Location = new System.Drawing.Point(3, 3);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(375, 350);
            this.LogTextBox.TabIndex = 8;
            this.LogTextBox.WordWrap = false;
            // 
            // LogBottomControlsGroupBox
            // 
            this.LogBottomControlsGroupBox.Controls.Add(this.AutoScrollCB);
            this.LogBottomControlsGroupBox.Controls.Add(this.ClearDebugButton);
            this.LogBottomControlsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogBottomControlsGroupBox.Location = new System.Drawing.Point(3, 353);
            this.LogBottomControlsGroupBox.Name = "LogBottomControlsGroupBox";
            this.LogBottomControlsGroupBox.Size = new System.Drawing.Size(375, 41);
            this.LogBottomControlsGroupBox.TabIndex = 7;
            this.LogBottomControlsGroupBox.TabStop = false;
            // 
            // AutoScrollCB
            // 
            this.AutoScrollCB.AutoSize = true;
            this.AutoScrollCB.Checked = true;
            this.AutoScrollCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoScrollCB.Location = new System.Drawing.Point(84, 14);
            this.AutoScrollCB.Name = "AutoScrollCB";
            this.AutoScrollCB.Size = new System.Drawing.Size(77, 17);
            this.AutoScrollCB.TabIndex = 9;
            this.AutoScrollCB.Text = "Auto Scroll";
            this.AutoScrollCB.UseVisualStyleBackColor = true;
            // 
            // ClearDebugButton
            // 
            this.ClearDebugButton.Location = new System.Drawing.Point(3, 10);
            this.ClearDebugButton.Name = "ClearDebugButton";
            this.ClearDebugButton.Size = new System.Drawing.Size(75, 23);
            this.ClearDebugButton.TabIndex = 8;
            this.ClearDebugButton.Text = "Clear";
            this.ClearDebugButton.UseVisualStyleBackColor = true;
            // 
            // RenderButton
            // 
            this.RenderButton.Location = new System.Drawing.Point(8, 51);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(75, 23);
            this.RenderButton.TabIndex = 1;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 423);
            this.Controls.Add(this.RightTabControl);
            this.Controls.Add(this.LeftTabControl);
            this.Name = "MainForm";
            this.Text = "OgreWindowsForms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftTabControl.ResumeLayout(false);
            this.LeftTabPage1.ResumeLayout(false);
            this.RightTabControl.ResumeLayout(false);
            this.RightTabPage1.ResumeLayout(false);
            this.RightTabPage2.ResumeLayout(false);
            this.RightTabPage2.PerformLayout();
            this.LogBottomControlsGroupBox.ResumeLayout(false);
            this.LogBottomControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LeftTabControl;
        private System.Windows.Forms.TabPage LeftTabPage1;
        private System.Windows.Forms.TabPage LeftTabPage2;
        private System.Windows.Forms.TabControl RightTabControl;
        private System.Windows.Forms.TabPage RightTabPage1;
        private System.Windows.Forms.TabPage RightTabPage2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.GroupBox LogBottomControlsGroupBox;
        private System.Windows.Forms.CheckBox AutoScrollCB;
        private System.Windows.Forms.Button ClearDebugButton;
        private System.Windows.Forms.Button RenderButton;
    }
}