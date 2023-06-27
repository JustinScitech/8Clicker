namespace Clicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackerBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.PowerButton = new System.Windows.Forms.Button();
            this.CPSVAL = new System.Windows.Forms.Label();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "8CLICKER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(189, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TrackerBar
            // 
            this.TrackerBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TrackerBar.Location = new System.Drawing.Point(28, 236);
            this.TrackerBar.Maximum = 25;
            this.TrackerBar.Minimum = 1;
            this.TrackerBar.Name = "TrackerBar";
            this.TrackerBar.Size = new System.Drawing.Size(300, 23);
            this.TrackerBar.TabIndex = 2;
            this.TrackerBar.ThumbColor = System.Drawing.Color.DarkGreen;
            this.TrackerBar.Value = 10;
            this.TrackerBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneTrackBar1_Scroll);
            // 
            // PowerButton
            // 
            this.PowerButton.BackColor = System.Drawing.Color.Green;
            this.PowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PowerButton.Location = new System.Drawing.Point(98, 82);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(75, 68);
            this.PowerButton.TabIndex = 3;
            this.PowerButton.Text = "ON";
            this.PowerButton.UseVisualStyleBackColor = false;
            this.PowerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CPSVAL
            // 
            this.CPSVAL.AutoSize = true;
            this.CPSVAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSVAL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CPSVAL.Location = new System.Drawing.Point(178, 80);
            this.CPSVAL.Name = "CPSVAL";
            this.CPSVAL.Size = new System.Drawing.Size(106, 73);
            this.CPSVAL.TabIndex = 4;
            this.CPSVAL.Text = "10";
            this.CPSVAL.Click += new System.EventHandler(this.CPSVAL_Click);
            // 
            // Autoclicker
            // 
            this.Autoclicker.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Random
            // 
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(349, 361);
            this.Controls.Add(this.CPSVAL);
            this.Controls.Add(this.PowerButton);
            this.Controls.Add(this.TrackerBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AutoClicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar TrackerBar;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.Label CPSVAL;
        private System.Windows.Forms.Timer Autoclicker;
        private System.Windows.Forms.Timer Random;
    }
}

