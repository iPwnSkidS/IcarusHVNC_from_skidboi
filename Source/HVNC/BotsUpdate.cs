using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BirdBrainmofo.HVNC
{
	// Token: 0x02000073 RID: 115
	public class BotsUpdate : Form
	{
		// Token: 0x060005E2 RID: 1506 RVA: 0x0000983A File Offset: 0x00007A3A
		public BotsUpdate()
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

        // Token: 0x060005E6 RID: 1510 RVA: 0x00027084 File Offset: 0x00025284
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
            BirdBrainmofo.Bloom bloom24 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom25 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom26 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom27 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom28 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom29 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom30 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom31 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom32 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom33 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom34 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom35 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom36 = new BirdBrainmofo.Bloom();
            this.primeTheme1 = new BirdBrainmofo.PrimeTheme();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new BirdBrainmofo.StudioButton();
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
            this.primeTheme1.Controls.Add(this.txtURL);
            this.primeTheme1.Controls.Add(this.label1);
            this.primeTheme1.Controls.Add(this.button2);
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
            this.primeTheme1.Size = new System.Drawing.Size(555, 254);
            this.primeTheme1.SmartBounds = true;
            this.primeTheme1.TabIndex = 0;
            this.primeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(101, 112);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(386, 30);
            this.txtURL.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Url:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.Transparent;
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
            this.button2.Colors = new BirdBrainmofo.Bloom[] {
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
            this.button2.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.button2.Font = new System.Drawing.Font("Verdana", 8F);
            this.button2.Image = null;
            this.button2.Location = new System.Drawing.Point(339, 148);
            this.button2.Name = "button2";
            this.button2.NoRounding = false;
            this.button2.Size = new System.Drawing.Size(148, 30);
            this.button2.TabIndex = 41;
            this.button2.Text = "Download & Execute";
            this.button2.Transparent = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Update Bots";
            // 
            // studioButton5
            // 
            this.studioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton5.BackColor = System.Drawing.Color.Transparent;
            bloom24.Name = "DownGradient1";
            bloom24.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom25.Name = "DownGradient2";
            bloom25.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom26.Name = "NoneGradient1";
            bloom26.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom27.Name = "NoneGradient2";
            bloom27.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom28.Name = "Shine1";
            bloom28.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom29.Name = "Shine2A";
            bloom29.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom30.Name = "Shine2B";
            bloom30.Value = System.Drawing.Color.Transparent;
            bloom31.Name = "Shine3";
            bloom31.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom32.Name = "TextShade";
            bloom32.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom33.Name = "Text";
            bloom33.Value = System.Drawing.Color.White;
            bloom34.Name = "Glow";
            bloom34.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom35.Name = "Border";
            bloom35.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom36.Name = "Corners";
            bloom36.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton5.Colors = new BirdBrainmofo.Bloom[] {
        bloom24,
        bloom25,
        bloom26,
        bloom27,
        bloom28,
        bloom29,
        bloom30,
        bloom31,
        bloom32,
        bloom33,
        bloom34,
        bloom35,
        bloom36};
            this.studioButton5.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton5.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton5.Image = null;
            this.studioButton5.Location = new System.Drawing.Point(529, -7);
            this.studioButton5.Name = "studioButton5";
            this.studioButton5.NoRounding = false;
            this.studioButton5.Size = new System.Drawing.Size(13, 30);
            this.studioButton5.TabIndex = 23;
            this.studioButton5.Transparent = true;
            this.studioButton5.Click += new System.EventHandler(this.studioButton5_Click);
            // 
            // BotsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 254);
            this.Controls.Add(this.primeTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BotsUpdate";
            this.Text = "BotsUpdate";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.primeTheme1.ResumeLayout(false);
            this.primeTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Token: 0x04000332 RID: 818
        private IContainer components = null;

        // Token: 0x04000333 RID: 819
        private PrimeTheme primeTheme1;

        // Token: 0x04000334 RID: 820
        private StudioButton studioButton5;

        // Token: 0x04000335 RID: 821
        private Label label3;

        // Token: 0x04000337 RID: 823
        private StudioButton button2;

        // Token: 0x04000338 RID: 824
        private TextBox txtURL;

        // Token: 0x04000339 RID: 825
        private Label label1;

        // Token: 0x060005E3 RID: 1507 RVA: 0x00027014 File Offset: 0x00025214
        private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(txtURL.Text))
				{
					MessageBox.Show("URL is not valid!");
				}
				else
				{
					Manager.saveurl = txtURL.Text;
					Manager.ispressed = true;
					Close();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("An Error Has Occured When Trying To Execute Update Bots");
				Close();
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000984F File Offset: 0x00007A4F
		private void studioButton5_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
