namespace Practice.Components
{
    partial class HeaderControl
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
            lblTitle = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(14, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(72, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ButtonShadow;
            lblDescription.Location = new Point(14, 50);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "lblDescription";
            // 
            // HeaderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Name = "HeaderControl";
            Size = new Size(604, 88);
            Load += HeaderControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
    }
}
