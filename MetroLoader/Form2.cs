using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ManualMapInjection.Injection;
using MetroFramework.Forms;
using MetroLoader.Properties;

namespace MetroLoader
{
	// Token: 0x02000034 RID: 52
	public class Form2 : MetroForm
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000520C File Offset: 0x0000340C
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000521C File Offset: 0x0000341C
		private void Form2_Load(object sender, EventArgs e)
		{
			this.label1.Text = "Starting injection";
			Thread.Sleep(200);
			if (Process.GetProcessesByName("csgo").FirstOrDefault<Process>() == null)
			{
				this.csgof = false;
				return;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000042E5 File Offset: 0x000024E5
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005260 File Offset: 0x00003460
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (!this.csgof)
			{
				this.label1.Text = "Waiting for CSGO.exe";
				Process process = Process.GetProcessesByName("csgo").FirstOrDefault<Process>();
				if (process != null)
				{
					string path = "C:\\Temp\\cheat.dll";
					byte[] buffer = File.ReadAllBytes(path);
					if (!File.Exists(path))
					{
						this.label1.Text = "DLL not found";
						return;
					}
					ManualMapInjector manualMapInjector = new ManualMapInjector(process)
					{
						AsyncInjection = true
					};
					this.label1.Text = string.Format("hmodule = 0x{0:x8}", manualMapInjector.Inject(buffer).ToInt64());
					this.label1.Text = "Successfully injected";
					this.timer1.Stop();
					this.timer2.Start();
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000531F File Offset: 0x0000351F
		private void timer2_Tick(object sender, EventArgs e)
		{
			File.Delete("C:\\Temp\\cheat.dll");
			Application.Exit();
			this.timer2.Stop();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000533B File Offset: 0x0000353B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000535C File Offset: 0x0000355C
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
			this.label1 = new Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new ProgressBar();
			this.pictureBox1 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.ForeColor = SystemColors.ControlLight;
			this.label1.Location = new Point(127, 54);
			this.label1.Name = "label1";
			this.label1.Size = new Size(53, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Injecting..";
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += this.timer1_Tick;
			this.timer2.Enabled = true;
			this.timer2.Interval = 2000;
			this.timer2.Tick += this.timer2_Tick;
			this.progressBar1.Location = new Point(84, 82);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(142, 17);
			this.progressBar1.Style = ProgressBarStyle.Marquee;
			this.progressBar1.TabIndex = 3;
			this.progressBar1.Value = 100;
			this.pictureBox1.Image = Resources.login_logo;
			this.pictureBox1.Location = new Point(44, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(220, 61);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(312, 112);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			base.Resizable = false;
			base.Style = 10;
			base.TextAlign = 1;
			base.Theme = 2;
			base.Load += this.Form2_Load;
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400015C RID: 348
		private bool csgof;

		// Token: 0x0400015D RID: 349
		private IContainer components;

		// Token: 0x0400015E RID: 350
		private Label label1;

		// Token: 0x0400015F RID: 351
		private System.Windows.Forms.Timer timer1;

		// Token: 0x04000160 RID: 352
		private System.Windows.Forms.Timer timer2;

		// Token: 0x04000161 RID: 353
		private PictureBox pictureBox1;

		// Token: 0x04000162 RID: 354
		private ProgressBar progressBar1;
	}
}
