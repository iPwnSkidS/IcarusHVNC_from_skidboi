using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC
{
	// Token: 0x02000075 RID: 117
	public partial class HelpDisc : Form
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x000098B0 File Offset: 0x00007AB0
		public HelpDisc()
		{
			InitializeComponent();
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060005EF RID: 1519 RVA: 0x000285C0 File Offset: 0x000267C0
        private void InitializeComponent()
        {
            BirdBrainmofo.Bloom bloom1 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom2 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom3 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom4 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom5 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom6 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom7 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom8 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom9 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom10 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom11 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom12 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom13 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom14 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom15 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom16 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom17 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom18 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom19 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom20 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom21 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom22 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom23 = new BirdBrainmofo.Bloom();
            this.primeTheme1 = new BirdBrainmofo.PrimeTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studioButton5 = new BirdBrainmofo.StudioButton();
            this.primeTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // primeTheme1
            // 
            this.primeTheme1.BackColor = System.Drawing.Color.White;
            this.primeTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bloom1.Name = "Sides";
            bloom1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            bloom2.Name = "Gradient1";
            bloom2.Value = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            bloom3.Name = "Gradient2";
            bloom3.Value = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            bloom4.Name = "TextShade";
            bloom4.Value = System.Drawing.Color.White;
            bloom5.Name = "Text";
            bloom5.Value = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            bloom6.Name = "Back";
            bloom6.Value = System.Drawing.Color.White;
            bloom7.Name = "Border1";
            bloom7.Value = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            bloom8.Name = "Border2";
            bloom8.Value = System.Drawing.Color.White;
            bloom9.Name = "Border3";
            bloom9.Value = System.Drawing.Color.White;
            bloom10.Name = "Border4";
            bloom10.Value = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.primeTheme1.Colors = new BirdBrainmofo.Bloom[] {
        bloom1,
        bloom2,
        bloom3,
        bloom4,
        bloom5,
        bloom6,
        bloom7,
        bloom8,
        bloom9,
        bloom10};
            this.primeTheme1.Controls.Add(this.label1);
            this.primeTheme1.Controls.Add(this.label3);
            this.primeTheme1.Controls.Add(this.studioButton5);
            this.primeTheme1.Customization = "6Ojo//z8/P/y8vL//////1BQUP//////tLS0////////////lpaW/w==";
            this.primeTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primeTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.primeTheme1.Image = null;
            this.primeTheme1.Location = new System.Drawing.Point(0, 0);
            this.primeTheme1.Movable = true;
            this.primeTheme1.Name = "primeTheme1";
            this.primeTheme1.NoRounding = false;
            this.primeTheme1.Sizable = true;
            this.primeTheme1.Size = new System.Drawing.Size(244, 167);
            this.primeTheme1.SmartBounds = true;
            this.primeTheme1.TabIndex = 0;
            this.primeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 48);
            this.label1.TabIndex = 45;
            this.label1.Text = "1. Create a Channel\r\n2. Create a Webhook\r\n3. Get Webhook url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Discord Stealer Help";
            // 
            // studioButton5
            // 
            this.studioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton5.BackColor = System.Drawing.Color.Transparent;
            bloom11.Name = "DownGradient1";
            bloom11.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom12.Name = "DownGradient2";
            bloom12.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom13.Name = "NoneGradient1";
            bloom13.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom14.Name = "NoneGradient2";
            bloom14.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom15.Name = "Shine1";
            bloom15.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom16.Name = "Shine2A";
            bloom16.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom17.Name = "Shine2B";
            bloom17.Value = System.Drawing.Color.Transparent;
            bloom18.Name = "Shine3";
            bloom18.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom19.Name = "TextShade";
            bloom19.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom20.Name = "Text";
            bloom20.Value = System.Drawing.Color.White;
            bloom21.Name = "Glow";
            bloom21.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom22.Name = "Border";
            bloom22.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom23.Name = "Corners";
            bloom23.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton5.Colors = new BirdBrainmofo.Bloom[] {
        bloom11,
        bloom12,
        bloom13,
        bloom14,
        bloom15,
        bloom16,
        bloom17,
        bloom18,
        bloom19,
        bloom20,
        bloom21,
        bloom22,
        bloom23};
            this.studioButton5.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton5.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton5.Image = null;
            this.studioButton5.Location = new System.Drawing.Point(219, -6);
            this.studioButton5.Name = "studioButton5";
            this.studioButton5.NoRounding = false;
            this.studioButton5.Size = new System.Drawing.Size(13, 30);
            this.studioButton5.TabIndex = 42;
            this.studioButton5.Transparent = true;
            this.studioButton5.Click += new System.EventHandler(this.studioButton5_Click);
            // 
            // HelpDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 167);
            this.Controls.Add(this.primeTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpDisc";
            this.Text = "HelpDisc";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.primeTheme1.ResumeLayout(false);
            this.primeTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Token: 0x04000340 RID: 832
        private IContainer components = null;

        // Token: 0x04000341 RID: 833
        private PrimeTheme primeTheme1;

        // Token: 0x04000342 RID: 834
        private Label label3;

        // Token: 0x04000344 RID: 836
        private StudioButton studioButton5;

        // Token: 0x04000345 RID: 837
        private Label label1;

        // Token: 0x060005ED RID: 1517 RVA: 0x0000984F File Offset: 0x00007A4F
        private void studioButton5_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
