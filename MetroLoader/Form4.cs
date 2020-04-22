using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroLoader.Properties;

namespace MetroLoader
{
	// Token: 0x02000035 RID: 53
	public class Form4 : MetroForm
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00005645 File Offset: 0x00003845
		public Form4()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005660 File Offset: 0x00003860
		private void Form4_Load(object sender, EventArgs e)
		{
			this.webBrowser1.Navigate("http://www.resolved.pub/group.php?username=" + Settings.Default.Username);
			this.metroButton1.Enabled = false;
			this.metroRadioButton2.Visible = false;
			this.metroRadioButton3.Visible = false;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000056B0 File Offset: 0x000038B0
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.webBrowser1.DocumentText.Contains("4"))
			{
				this.admin = true;
				this.metroButton1.Enabled = true;
				this.metroLabel1.Text = "User status: DEV";
				this.metroRadioButton2.Visible = true;
				this.metroRadioButton3.Visible = true;
			}
			else if (this.webBrowser1.DocumentText.Contains("3"))
			{
				this.admin = true;
				this.metroButton1.Enabled = true;
				this.metroLabel1.Text = "User status: ADMIN";
				this.metroRadioButton2.Visible = true;
				this.metroRadioButton3.Visible = true;
			}
			else if (this.webBrowser1.DocumentText.Contains("8"))
			{
				this.premium = true;
				this.metroButton1.Enabled = true;
				this.metroLabel1.Text = "User status: PREMIUM";
				this.metroRadioButton3.Visible = false;
			}
			else if (this.webBrowser1.DocumentText.Contains("9"))
			{
				this.premium = true;
				this.metroButton1.Enabled = true;
				this.metroLabel1.Text = "User status: ALPHA";
				this.metroRadioButton2.Visible = true;
				this.metroRadioButton3.Visible = false;
			}
			Thread.Sleep(1000);
			this.timer1.Stop();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000581A File Offset: 0x00003A1A
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.admin)
			{
				this.metroRadioButton2.Visible = true;
				this.metroRadioButton3.Visible = true;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000583C File Offset: 0x00003A3C
		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (this.metroRadioButton1.Checked)
			{
				WebClient webClient = new WebClient();
				webClient.Headers.Add("User-Agent", "kdwakdlskaiodjxionwda");
				Directory.CreateDirectory("C:\\Temp\\");
				webClient.DownloadFile("http://www.resolved.pub/dlls/122a.dll", "C:\\Temp\\cheat.dll");
			}
			if (this.metroRadioButton2.Checked)
			{
				WebClient webClient2 = new WebClient();
				webClient2.Headers.Add("User-Agent", "xwaxwakdpwakdopkspl");
				Directory.CreateDirectory("C:\\Temp\\");
				webClient2.DownloadFile("http://www.resolved.pub/dlls/133a.dll", "C:\\Temp\\cheat.dll");
			}
			if (this.metroRadioButton3.Checked)
			{
				WebClient webClient3 = new WebClient();
				webClient3.Headers.Add("User-Agent", "pdwaiduwaidhsainxwanui");
				Directory.CreateDirectory("C:\\Temp\\");
				webClient3.DownloadFile("http://www.resolved.pub/dlls/cloud.dll", "C:\\Temp\\cheat.dll");
			}
			base.Hide();
			Form2 form = new Form2();
			form.Closed += delegate(object s, EventArgs args)
			{
				base.Close();
			};
			form.Show();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000042E5 File Offset: 0x000024E5
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000042E5 File Offset: 0x000024E5
		private void MetroRadioButton3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000042E5 File Offset: 0x000024E5
		private void MetroRadioButton2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000042E7 File Offset: 0x000024E7
		private void Button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000042E7 File Offset: 0x000024E7
		private void Button1_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000042E5 File Offset: 0x000024E5
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000042E5 File Offset: 0x000024E5
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000042E5 File Offset: 0x000024E5
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000042E5 File Offset: 0x000024E5
		private void MetroRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000592E File Offset: 0x00003B2E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005950 File Offset: 0x00003B50
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
			this.metroButton1 = new MetroButton();
			this.webBrowser1 = new WebBrowser();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.metroLabel1 = new MetroLabel();
			this.metroRadioButton1 = new MetroRadioButton();
			this.metroRadioButton2 = new MetroRadioButton();
			this.metroRadioButton3 = new MetroRadioButton();
			this.metroTextBox1 = new MetroTextBox();
			this.pictureBox2 = new PictureBox();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.metroButton1.BackColor = Color.Transparent;
			this.metroButton1.ForeColor = SystemColors.ControlText;
			this.metroButton1.Location = new Point(360, 331);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new Size(298, 55);
			this.metroButton1.Style = 5;
			this.metroButton1.TabIndex = 0;
			this.metroButton1.Text = "Inject Cheat";
			this.metroButton1.Theme = 2;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += this.metroButton1_Click;
			this.webBrowser1.Location = new Point(39, 614);
			this.webBrowser1.MinimumSize = new Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new Size(20, 29);
			this.webBrowser1.TabIndex = 1;
			this.webBrowser1.Visible = false;
			this.webBrowser1.DocumentCompleted += this.webBrowser1_DocumentCompleted;
			this.timer1.Enabled = true;
			this.timer1.Interval = 300;
			this.timer1.Tick += this.timer1_Tick;
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new Point(360, 280);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new Size(127, 19);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "User status: Fetching";
			this.metroLabel1.Theme = 2;
			this.metroRadioButton1.AutoSize = true;
			this.metroRadioButton1.Location = new Point(360, 99);
			this.metroRadioButton1.Name = "metroRadioButton1";
			this.metroRadioButton1.Size = new Size(91, 15);
			this.metroRadioButton1.Style = 5;
			this.metroRadioButton1.TabIndex = 3;
			this.metroRadioButton1.Text = "OMEGA.WIN";
			this.metroRadioButton1.Theme = 2;
			this.metroRadioButton1.UseSelectable = true;
			this.metroRadioButton1.CheckedChanged += this.MetroRadioButton1_CheckedChanged;
			this.metroRadioButton2.AutoSize = true;
			this.metroRadioButton2.Location = new Point(360, 151);
			this.metroRadioButton2.Name = "metroRadioButton2";
			this.metroRadioButton2.Size = new Size(140, 15);
			this.metroRadioButton2.Style = 5;
			this.metroRadioButton2.TabIndex = 4;
			this.metroRadioButton2.Text = "OMEGA.WIN [ALPHA]";
			this.metroRadioButton2.Theme = 2;
			this.metroRadioButton2.UseSelectable = true;
			this.metroRadioButton2.CheckedChanged += this.MetroRadioButton2_CheckedChanged;
			this.metroRadioButton3.AutoSize = true;
			this.metroRadioButton3.Location = new Point(360, 207);
			this.metroRadioButton3.Name = "metroRadioButton3";
			this.metroRadioButton3.Size = new Size(75, 15);
			this.metroRadioButton3.Style = 5;
			this.metroRadioButton3.TabIndex = 5;
			this.metroRadioButton3.Text = "Test-Build";
			this.metroRadioButton3.Theme = 2;
			this.metroRadioButton3.UseSelectable = true;
			this.metroRadioButton3.CheckedChanged += this.MetroRadioButton3_CheckedChanged;
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new Point(170, 1);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new Size(21, 21);
			this.metroTextBox1.CustomButton.Style = 4;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = 1;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.Enabled = false;
			this.metroTextBox1.Lines = new string[]
			{
				"                   Latest Updates"
			};
			this.metroTextBox1.Location = new Point(32, 143);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.ReadOnly = true;
			this.metroTextBox1.ScrollBars = ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new Size(192, 23);
			this.metroTextBox1.TabIndex = 8;
			this.metroTextBox1.Text = "                   Latest Updates";
			this.metroTextBox1.Theme = 2;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox1.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
			this.pictureBox2.Image = Resources.shittylogo4;
			this.pictureBox2.Location = new Point(-6, 5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(698, 414);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += this.pictureBox2_Click_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Resources.aa;
			base.ClientSize = new Size(694, 409);
			base.Controls.Add(this.metroTextBox1);
			base.Controls.Add(this.metroRadioButton3);
			base.Controls.Add(this.metroRadioButton2);
			base.Controls.Add(this.metroRadioButton1);
			base.Controls.Add(this.metroLabel1);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.pictureBox2);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form4";
			base.Resizable = false;
			base.Style = 10;
			base.TextAlign = 1;
			base.Theme = 2;
			base.Load += this.Form4_Load;
			((ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000163 RID: 355
		private bool admin;

		// Token: 0x04000164 RID: 356
		private bool premium;

		// Token: 0x04000165 RID: 357
		private Form1 otherForm = new Form1();

		// Token: 0x04000166 RID: 358
		private IContainer components;

		// Token: 0x04000167 RID: 359
		private MetroButton metroButton1;

		// Token: 0x04000168 RID: 360
		private WebBrowser webBrowser1;

		// Token: 0x04000169 RID: 361
		private System.Windows.Forms.Timer timer1;

		// Token: 0x0400016A RID: 362
		private MetroLabel metroLabel1;

		// Token: 0x0400016B RID: 363
		private MetroRadioButton metroRadioButton1;

		// Token: 0x0400016C RID: 364
		private MetroRadioButton metroRadioButton2;

		// Token: 0x0400016D RID: 365
		private MetroRadioButton metroRadioButton3;

		// Token: 0x0400016E RID: 366
		private MetroTextBox metroTextBox1;

		// Token: 0x0400016F RID: 367
		private PictureBox pictureBox2;
	}
}
