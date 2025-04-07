namespace Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerControl1 = new Practice.Components.HeaderControl();
            roundedPanel1 = new Practice.Components.RoundedPanel();
            SuspendLayout();
            // 
            // headerControl1
            // 
            headerControl1.Description = "Description";
            headerControl1.Dock = DockStyle.Top;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(1171, 88);
            headerControl1.TabIndex = 0;
            headerControl1.Title = "Title";
            headerControl1.Load += headerControl1_Load;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BorderColor = Color.IndianRed;
            roundedPanel1.BorderWidth = 5;
            roundedPanel1.Dock = DockStyle.Fill;
            roundedPanel1.InnerBackgroundColor = Color.Black;
            roundedPanel1.Location = new Point(0, 88);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1171, 711);
            roundedPanel1.TabIndex = 1;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1171, 799);
            Controls.Add(roundedPanel1);
            Controls.Add(headerControl1);
            Name = "Form1";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Components.HeaderControl headerControl1;
        private Components.RoundedPanel roundedPanel1;
    }
}
