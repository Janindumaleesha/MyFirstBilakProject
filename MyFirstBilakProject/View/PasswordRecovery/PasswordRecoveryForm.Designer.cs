namespace MyFirstBilakProject.View.PasswordRecovery
{
    partial class PasswordRecoveryForm
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            label2 = new Label();
            label1 = new Label();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Controls.Add(kryptonPictureBox1);
            kryptonPanel1.Location = new Point(12, 12);
            kryptonPanel1.MinimumSize = new Size(776, 426);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(776, 426);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.StateCommon.Color2 = SystemColors.HotTrack;
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.None;
            kryptonPanel2.Controls.Add(kryptonTextBox3);
            kryptonPanel2.Controls.Add(linkLabel1);
            kryptonPanel2.Controls.Add(label5);
            kryptonPanel2.Controls.Add(label4);
            kryptonPanel2.Controls.Add(label3);
            kryptonPanel2.Controls.Add(kryptonTextBox2);
            kryptonPanel2.Controls.Add(kryptonTextBox1);
            kryptonPanel2.Controls.Add(kryptonButton1);
            kryptonPanel2.Controls.Add(label2);
            kryptonPanel2.Controls.Add(label1);
            kryptonPanel2.Location = new Point(397, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(376, 420);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.StateCommon.Color2 = Color.White;
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Anchor = AnchorStyles.None;
            kryptonTextBox3.Location = new Point(38, 129);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(300, 33);
            kryptonTextBox3.StateCommon.Border.Color1 = SystemColors.ControlDarkDark;
            kryptonTextBox3.StateCommon.Border.Color2 = SystemColors.ControlDarkDark;
            kryptonTextBox3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox3.StateCommon.Border.Rounding = 20F;
            kryptonTextBox3.StateCommon.Content.Color1 = SystemColors.ControlDarkDark;
            kryptonTextBox3.StateCommon.Content.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox3.TabIndex = 30;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(38, 165);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 15);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Resend Code";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 8.25F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(38, 304);
            label5.Name = "label5";
            label5.Size = new Size(107, 14);
            label5.TabIndex = 28;
            label5.Text = "Password mismatch!";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 8.25F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(38, 238);
            label4.Name = "label4";
            label4.Size = new Size(115, 14);
            label4.TabIndex = 27;
            label4.Text = "At leaste 6 characters";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(38, 111);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 26;
            label3.Text = "Verification Code";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Anchor = AnchorStyles.None;
            kryptonTextBox2.Location = new Point(38, 201);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(300, 34);
            kryptonTextBox2.StateCommon.Border.Color1 = SystemColors.ControlDarkDark;
            kryptonTextBox2.StateCommon.Border.Color2 = SystemColors.ControlDarkDark;
            kryptonTextBox2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox2.StateCommon.Border.Rounding = 20F;
            kryptonTextBox2.StateCommon.Content.Color1 = SystemColors.ControlDarkDark;
            kryptonTextBox2.StateCommon.Content.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox2.TabIndex = 25;
            kryptonTextBox2.Text = "Confirm new password";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = AnchorStyles.None;
            kryptonTextBox1.Location = new Point(38, 267);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(300, 34);
            kryptonTextBox1.StateCommon.Border.Color1 = SystemColors.ControlDarkDark;
            kryptonTextBox1.StateCommon.Border.Color2 = SystemColors.ControlDarkDark;
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            kryptonTextBox1.StateCommon.Content.Color1 = SystemColors.ControlDarkDark;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.TabIndex = 24;
            kryptonTextBox1.Text = "Enter new password";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(38, 344);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(300, 35);
            kryptonButton1.StateCommon.Back.Color1 = SystemColors.HotTrack;
            kryptonButton1.StateCommon.Back.Color2 = SystemColors.HotTrack;
            kryptonButton1.StateCommon.Border.Color1 = SystemColors.HotTrack;
            kryptonButton1.StateCommon.Border.Color2 = SystemColors.HotTrack;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.Rounding = 20F;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 23;
            kryptonButton1.Values.Text = "Create New Password";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(38, 67);
            label2.Name = "label2";
            label2.Size = new Size(266, 30);
            label2.TabIndex = 22;
            label2.Text = "Please enter a new password different from the\r\nprevious one.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 21;
            label1.Text = "Create New Password";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Anchor = AnchorStyles.None;
            kryptonPictureBox1.Image = Properties.Resources.back;
            kryptonPictureBox1.Location = new Point(3, 3);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(395, 420);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // PasswordRecoveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonPanel1);
            Name = "PasswordRecoveryForm";
            Text = "PasswordRecoveryForm";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Label label2;
        private Label label1;
    }
}