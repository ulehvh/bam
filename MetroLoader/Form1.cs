using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HWIDGrabber;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroLoader.Properties;

namespace MetroLoader
{
	// Token: 0x02000033 RID: 51
	public class Form1 : MetroForm
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00003EEC File Offset: 0x000020EC
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003EFC File Offset: 0x000020FC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.metroCheckBox1.Checked = true;
			Process.GetProcessesByName("steam").FirstOrDefault<Process>();
			this.hwidstring = HWDI.GetMachineGuid();
			this.metroTextBox1.Text = Settings.Default.Username;
			this.metroTextBox2.Text = Settings.Default.Password;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003F5C File Offset: 0x0000215C
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.webBrowser1.Navigate("http://www.resolved.pub/check.php?username=" + this.metroTextBox1.Text + "&password=" + this.metroTextBox2.Text);
			this.username = true;
			Settings.Default.Username = this.metroTextBox1.Text;
			Settings.Default.Password = this.metroTextBox2.Text;
			Settings.Default.Checked = this.metroCheckBox1.Checked;
			Settings.Default.Save();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003FEC File Offset: 0x000021EC
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.username)
			{
				if (this.webBrowser1.DocumentText.Contains("0"))
				{
					this.username = false;
					MessageBox.Show("Password incorrect");
					return;
				}
				if (this.webBrowser1.DocumentText.Contains("1"))
				{
					this.usergroup = true;
					this.username = false;
					this.webBrowser2.Navigate("http://www.resolved.pub/group.php?username=" + this.metroTextBox1.Text);
					return;
				}
				if (this.webBrowser2.DocumentText.Contains("2"))
				{
					this.username = false;
					MessageBox.Show("No user with that name");
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000040A0 File Offset: 0x000022A0
		private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.usergroup)
			{
				if (this.webBrowser2.DocumentText.Contains("4") || this.webBrowser2.DocumentText.Contains("8") || this.webBrowser2.DocumentText.Contains("9") || this.webBrowser2.DocumentText.Contains("3"))
				{
					this.usergroup = false;
					this.hwid = true;
					this.webBrowser3.Navigate("http://www.resolved.pub/hwid.php?username=" + this.metroTextBox1.Text + "&hwid=" + this.hwidstring);
					return;
				}
				MessageBox.Show("Group incorrect");
				this.usergroup = false;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004160 File Offset: 0x00002360
		private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (this.hwid)
			{
				if (this.webBrowser3.DocumentText.Contains("0"))
				{
					MessageBox.Show("HWID Incorrect");
					this.hwid = false;
					Application.Exit();
					return;
				}
				if (this.webBrowser3.DocumentText.Contains("1"))
				{
					base.Hide();
					Form4 form = new Form4();
					form.Closed += delegate(object s, EventArgs args)
					{
						base.Close();
					};
					form.Show();
					return;
				}
				if (this.webBrowser3.DocumentText.Contains("2"))
				{
					MessageBox.Show("HWID Value Empty?");
					this.hwid = false;
					return;
				}
				if (this.webBrowser3.DocumentText.Contains("3"))
				{
					DialogResult dialogResult = MessageBox.Show(string.Concat(new string[]
					{
						"HWID Has Been Set!",
						Environment.NewLine,
						"HWID: ",
						this.hwidstring,
						Environment.NewLine,
						"You will need your current HWID to change it later!",
						Environment.NewLine,
						"Press yes to copy the text to your clipboard, no to not."
					}), "HWID Set", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						Clipboard.SetText(this.hwidstring);
					}
					this.hwid = false;
					base.Hide();
					Form4 form2 = new Form4();
					form2.Closed += delegate(object s, EventArgs args)
					{
						base.Close();
					};
					form2.Show();
					return;
				}
				if (this.webBrowser3.DocumentText.Contains("4"))
				{
					MessageBox.Show("SQL error with HWID setting");
					this.hwid = false;
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000042E5 File Offset: 0x000024E5
		private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000042E7 File Offset: 0x000024E7
		private void MetroButton2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000042E5 File Offset: 0x000024E5
		private void MetroTextBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000042E5 File Offset: 0x000024E5
		private void metroTextBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000042E5 File Offset: 0x000024E5
		private void metroDateTime1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000042E5 File Offset: 0x000024E5
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000042E5 File Offset: 0x000024E5
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000042EE File Offset: 0x000024EE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004310 File Offset: 0x00002510
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.metroTextBox2 = new MetroTextBox();
			this.metroTextBox1 = new MetroTextBox();
			this.metroButton1 = new MetroButton();
			this.metroCheckBox1 = new MetroCheckBox();
			this.webBrowser1 = new WebBrowser();
			this.webBrowser2 = new WebBrowser();
			this.webBrowser3 = new WebBrowser();
			this.webBrowser4 = new WebBrowser();
			this.metroButton2 = new MetroButton();
			this.metroTextBox3 = new MetroTextBox();
			this.metroDateTime1 = new MetroDateTime();
			this.metroTextBox4 = new MetroTextBox();
			this.pictureBox1 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.metroTextBox2.BackColor = Color.Green;
			this.metroTextBox2.CustomButton.Image = null;
			this.metroTextBox2.CustomButton.Location = new Point(306, 1);
			this.metroTextBox2.CustomButton.Name = "";
			this.metroTextBox2.CustomButton.Size = new Size(33, 33);
			this.metroTextBox2.CustomButton.Style = 4;
			this.metroTextBox2.CustomButton.TabIndex = 1;
			this.metroTextBox2.CustomButton.Theme = 1;
			this.metroTextBox2.CustomButton.UseSelectable = true;
			this.metroTextBox2.CustomButton.Visible = false;
			this.metroTextBox2.FontSize = 2;
			this.metroTextBox2.Lines = new string[0];
			this.metroTextBox2.Location = new Point(332, 215);
			this.metroTextBox2.MaxLength = 32767;
			this.metroTextBox2.Name = "metroTextBox2";
			this.metroTextBox2.PasswordChar = '●';
			this.metroTextBox2.PromptText = "Password";
			this.metroTextBox2.ScrollBars = ScrollBars.None;
			this.metroTextBox2.SelectedText = "";
			this.metroTextBox2.SelectionLength = 0;
			this.metroTextBox2.SelectionStart = 0;
			this.metroTextBox2.ShortcutsEnabled = true;
			this.metroTextBox2.Size = new Size(340, 35);
			this.metroTextBox2.Style = 10;
			this.metroTextBox2.TabIndex = 5;
			this.metroTextBox2.Theme = 2;
			this.metroTextBox2.UseSelectable = true;
			this.metroTextBox2.WaterMark = "Password";
			this.metroTextBox2.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox2.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
			this.metroTextBox1.BackColor = Color.Black;
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new Point(306, 1);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new Size(33, 33);
			this.metroTextBox1.CustomButton.Style = 4;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = 1;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.FontSize = 2;
			this.metroTextBox1.ForeColor = SystemColors.ControlText;
			this.metroTextBox1.Lines = new string[0];
			this.metroTextBox1.Location = new Point(332, 125);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.PromptText = "Username";
			this.metroTextBox1.ScrollBars = ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new Size(340, 35);
			this.metroTextBox1.Style = 10;
			this.metroTextBox1.TabIndex = 4;
			this.metroTextBox1.Theme = 2;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.WaterMark = "Username";
			this.metroTextBox1.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox1.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
			this.metroTextBox1.Click += this.MetroTextBox1_Click;
			this.metroButton1.Location = new Point(332, 338);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new Size(161, 35);
			this.metroButton1.Style = 5;
			this.metroButton1.TabIndex = 2;
			this.metroButton1.Text = "Login";
			this.metroButton1.Theme = 2;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += this.metroButton1_Click;
			this.metroCheckBox1.AutoSize = true;
			this.metroCheckBox1.Location = new Point(-62, 220);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new Size(16, 0);
			this.metroCheckBox1.Style = 5;
			this.metroCheckBox1.TabIndex = 3;
			this.metroCheckBox1.Theme = 2;
			this.metroCheckBox1.UseSelectable = true;
			this.webBrowser1.Location = new Point(261, 660);
			this.webBrowser1.MinimumSize = new Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new Size(20, 20);
			this.webBrowser1.TabIndex = 1;
			this.webBrowser1.Visible = false;
			this.webBrowser1.DocumentCompleted += this.webBrowser1_DocumentCompleted;
			this.webBrowser2.Location = new Point(158, 680);
			this.webBrowser2.MinimumSize = new Size(20, 20);
			this.webBrowser2.Name = "webBrowser2";
			this.webBrowser2.Size = new Size(20, 20);
			this.webBrowser2.TabIndex = 2;
			this.webBrowser2.Visible = false;
			this.webBrowser2.DocumentCompleted += this.webBrowser2_DocumentCompleted;
			this.webBrowser3.Location = new Point(199, 573);
			this.webBrowser3.MinimumSize = new Size(20, 20);
			this.webBrowser3.Name = "webBrowser3";
			this.webBrowser3.Size = new Size(20, 20);
			this.webBrowser3.TabIndex = 3;
			this.webBrowser3.Visible = false;
			this.webBrowser3.DocumentCompleted += this.webBrowser3_DocumentCompleted;
			this.webBrowser4.Location = new Point(391, 671);
			this.webBrowser4.MinimumSize = new Size(20, 20);
			this.webBrowser4.Name = "webBrowser4";
			this.webBrowser4.Size = new Size(20, 20);
			this.webBrowser4.TabIndex = 4;
			this.webBrowser4.Visible = false;
			this.webBrowser4.DocumentCompleted += this.webBrowser4_DocumentCompleted;
			this.metroButton2.Location = new Point(511, 338);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new Size(161, 35);
			this.metroButton2.Style = 5;
			this.metroButton2.TabIndex = 6;
			this.metroButton2.Text = "Exit";
			this.metroButton2.Theme = 2;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += this.MetroButton2_Click;
			this.metroTextBox3.CustomButton.Image = null;
			this.metroTextBox3.CustomButton.Location = new Point(61, 1);
			this.metroTextBox3.CustomButton.Name = "";
			this.metroTextBox3.CustomButton.Size = new Size(33, 33);
			this.metroTextBox3.CustomButton.Style = 4;
			this.metroTextBox3.CustomButton.TabIndex = 1;
			this.metroTextBox3.CustomButton.Theme = 1;
			this.metroTextBox3.CustomButton.UseSelectable = true;
			this.metroTextBox3.CustomButton.Visible = false;
			this.metroTextBox3.FontSize = 2;
			this.metroTextBox3.Lines = new string[]
			{
				"User Login"
			};
			this.metroTextBox3.Location = new Point(449, 63);
			this.metroTextBox3.MaxLength = 32767;
			this.metroTextBox3.Name = "metroTextBox3";
			this.metroTextBox3.PasswordChar = '\0';
			this.metroTextBox3.ScrollBars = ScrollBars.None;
			this.metroTextBox3.SelectedText = "";
			this.metroTextBox3.SelectionLength = 0;
			this.metroTextBox3.SelectionStart = 0;
			this.metroTextBox3.ShortcutsEnabled = true;
			this.metroTextBox3.Size = new Size(95, 35);
			this.metroTextBox3.TabIndex = 9;
			this.metroTextBox3.Text = "User Login";
			this.metroTextBox3.Theme = 2;
			this.metroTextBox3.UseSelectable = true;
			this.metroTextBox3.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox3.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
			this.metroTextBox3.Click += this.metroTextBox3_Click;
			this.metroDateTime1.DropDownAlign = LeftRightAlignment.Right;
			this.metroDateTime1.Enabled = false;
			this.metroDateTime1.Location = new Point(55, 125);
			this.metroDateTime1.MinimumSize = new Size(0, 29);
			this.metroDateTime1.Name = "metroDateTime1";
			this.metroDateTime1.Size = new Size(152, 29);
			this.metroDateTime1.TabIndex = 10;
			this.metroDateTime1.Theme = 2;
			this.metroDateTime1.ValueChanged += this.metroDateTime1_ValueChanged;
			this.metroTextBox4.CustomButton.Image = null;
			this.metroTextBox4.CustomButton.Location = new Point(126, 1);
			this.metroTextBox4.CustomButton.Name = "";
			this.metroTextBox4.CustomButton.Size = new Size(21, 21);
			this.metroTextBox4.CustomButton.Style = 4;
			this.metroTextBox4.CustomButton.TabIndex = 1;
			this.metroTextBox4.CustomButton.Theme = 1;
			this.metroTextBox4.CustomButton.UseSelectable = true;
			this.metroTextBox4.CustomButton.Visible = false;
			this.metroTextBox4.Enabled = false;
			this.metroTextBox4.Lines = new string[]
			{
				"              Latest News"
			};
			this.metroTextBox4.Location = new Point(55, 215);
			this.metroTextBox4.MaxLength = 32767;
			this.metroTextBox4.Name = "metroTextBox4";
			this.metroTextBox4.PasswordChar = '\0';
			this.metroTextBox4.ScrollBars = ScrollBars.None;
			this.metroTextBox4.SelectedText = "";
			this.metroTextBox4.SelectionLength = 0;
			this.metroTextBox4.SelectionStart = 0;
			this.metroTextBox4.ShortcutsEnabled = true;
			this.metroTextBox4.Size = new Size(148, 23);
			this.metroTextBox4.TabIndex = 11;
			this.metroTextBox4.Text = "              Latest News";
			this.metroTextBox4.Theme = 2;
			this.metroTextBox4.UseSelectable = true;
			this.metroTextBox4.WaterMarkColor = Color.FromArgb(109, 109, 109);
			this.metroTextBox4.WaterMarkFont = new Font("Segoe UI", 12f, FontStyle.Italic, GraphicsUnit.Pixel);
			this.pictureBox1.Image = Resources.shittylogo3;
			this.pictureBox1.Location = new Point(-6, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(699, 414);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += this.PictureBox1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackgroundImage = Resources._1;
			base.BorderStyle = 1;
			base.ClientSize = new Size(692, 421);
			base.Controls.Add(this.metroTextBox4);
			base.Controls.Add(this.metroDateTime1);
			base.Controls.Add(this.metroTextBox3);
			base.Controls.Add(this.metroButton2);
			base.Controls.Add(this.webBrowser4);
			base.Controls.Add(this.webBrowser3);
			base.Controls.Add(this.metroTextBox2);
			base.Controls.Add(this.webBrowser2);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.metroTextBox1);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.metroCheckBox1);
			base.Controls.Add(this.pictureBox1);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.Resizable = false;
			base.ShadowType = 4;
			base.Style = 10;
			base.TextAlign = 1;
			base.Theme = 2;
			base.Load += this.Form1_Load;
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400014A RID: 330
		private bool username;

		// Token: 0x0400014B RID: 331
		private bool usergroup;

		// Token: 0x0400014C RID: 332
		private bool hwid;

		// Token: 0x0400014D RID: 333
		private string hwidstring;

		// Token: 0x0400014E RID: 334
		private IContainer components;

		// Token: 0x0400014F RID: 335
		private WebBrowser webBrowser1;

		// Token: 0x04000150 RID: 336
		private MetroTextBox metroTextBox2;

		// Token: 0x04000151 RID: 337
		private MetroTextBox metroTextBox1;

		// Token: 0x04000152 RID: 338
		private MetroCheckBox metroCheckBox1;

		// Token: 0x04000153 RID: 339
		private MetroButton metroButton1;

		// Token: 0x04000154 RID: 340
		private WebBrowser webBrowser2;

		// Token: 0x04000155 RID: 341
		private WebBrowser webBrowser3;

		// Token: 0x04000156 RID: 342
		private WebBrowser webBrowser4;

		// Token: 0x04000157 RID: 343
		private MetroButton metroButton2;

		// Token: 0x04000158 RID: 344
		private MetroTextBox metroTextBox3;

		// Token: 0x04000159 RID: 345
		private MetroDateTime metroDateTime1;

		// Token: 0x0400015A RID: 346
		private MetroTextBox metroTextBox4;

		// Token: 0x0400015B RID: 347
		private PictureBox pictureBox1;
	}
}
