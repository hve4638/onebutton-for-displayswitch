namespace DisplayControl
{
    partial class DisplayControlButton
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
            ToggleButton = new PictureBox();
            DragButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ToggleButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DragButton).BeginInit();
            SuspendLayout();
            // 
            // ToggleButton
            // 
            ToggleButton.Image = Properties.Resources.off;
            ToggleButton.Location = new Point(4, 4);
            ToggleButton.Name = "ToggleButton";
            ToggleButton.Size = new Size(32, 16);
            ToggleButton.SizeMode = PictureBoxSizeMode.AutoSize;
            ToggleButton.TabIndex = 1;
            ToggleButton.TabStop = false;
            ToggleButton.Click += ToggleButton_Click;
            ToggleButton.MouseMove += ToggleButton_MouseMove;
            // 
            // DragButton
            // 
            DragButton.Image = Properties.Resources.drag;
            DragButton.Location = new Point(38, 4);
            DragButton.Name = "DragButton";
            DragButton.Size = new Size(11, 11);
            DragButton.SizeMode = PictureBoxSizeMode.AutoSize;
            DragButton.TabIndex = 2;
            DragButton.TabStop = false;
            DragButton.MouseMove += DragButton_MouseMove;
            // 
            // DisplayControlButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(54, 26);
            ControlBox = false;
            Controls.Add(DragButton);
            Controls.Add(ToggleButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DisplayControlButton";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "ToggleDisplay";
            TopMost = true;
            Load += DisplayControlButton_Load;
            ((System.ComponentModel.ISupportInitialize)ToggleButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)DragButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ToggleButton;
        private PictureBox DragButton;
    }
}