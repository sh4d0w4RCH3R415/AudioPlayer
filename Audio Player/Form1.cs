using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;

namespace Audio_Player
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			if (lstAudioFiles.Items.Count == 0)
			{
				pnlPlayer.SendToBack();
				pnlSettings.BringToFront();
				picPlayerTab.Visible = false;
				picSettingsTab.Visible = true;
			}
		}

		#region Custom DropShadow
		private bool aeroEnabled;
		private const int CS_DROPSHADOW = 131072;

		[DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS pMarInset);

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll")]
		private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		private bool CheckAeroEnabled()
		{
			if (Environment.OSVersion.Version.Major < 6)
				return false;
			int pfEnabled = 0;
			DwmIsCompositionEnabled(ref pfEnabled);
			return pfEnabled == 1;
		}

		private struct MARGINS
		{
			public int LeftWidth;
			public int RightWidth;
			public int TopHeight;
			public int BottomHeight;
		}

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;

				aeroEnabled = CheckAeroEnabled();
				if (!aeroEnabled) cp.ClassStyle |= CS_DROPSHADOW;

				return cp;
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, Height - 1, Width, 1));

			if (!aeroEnabled) return;

			int attrValue = 2;
			DwmSetWindowAttribute(Handle, 2, ref attrValue, 4);
			MARGINS pMarInset = new MARGINS
			{
				LeftWidth = 0,
				RightWidth = 0,
				BottomHeight = 1,
				TopHeight = 0,
			};
			DwmExtendFrameIntoClientArea(Handle, ref pMarInset);
		}
		#endregion
		#region Custom TitleBar
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hwnd, int msg, int wp, int lp);

		private void DragForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}

		private void Close_MsEnter(object sender, EventArgs e)
		{
			pnlClose.BackColor = Color.FromArgb(55, 65, 75);
			lblClose.BackColor = Color.FromArgb(55, 65, 75);
		}
		private void Close_MsLeave(object sender, EventArgs e)
		{
			pnlClose.BackColor = Color.FromArgb(35, 45, 55);
			lblClose.BackColor = Color.FromArgb(35, 45, 55);
		}

		private void Minimize_MsEnter(object sender, EventArgs e)
		{
			pnlMinimize.BackColor = Color.FromArgb(55, 65, 75);
			lblMinimize.BackColor = Color.FromArgb(55, 65, 75);
		}
		private void Minimize_MsLeave(object sender, EventArgs e)
		{
			pnlMinimize.BackColor = Color.FromArgb(35, 45, 55);
			lblMinimize.BackColor = Color.FromArgb(35, 45, 55);
		}

		private void Close_MsClick(object sender, MouseEventArgs e)
		{
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity -= 0.05;

				if (Opacity <= 0)
				{
					t.Enabled = false;
					Opacity = 0;
					Close();
				}
			};
			t.Start();
		}
		private void Minimize_MsClick(object sender, MouseEventArgs e)
		{
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity -= 0.05;

				if (Opacity <= 0)
				{
					t.Enabled = false;
					Opacity = 0;
					WindowState = FormWindowState.Minimized;
				}
			};
			t.Start();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			Opacity = 0;

			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity += 0.05;

				if (Opacity >= 1)
				{
					t.Enabled = false;
					Opacity = 1;
				}
			};
			t.Start();
		}
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);

			if (WindowState == FormWindowState.Minimized) Opacity = 0;

			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity += 0.05;

				if (Opacity >= 1)
				{
					t.Enabled = false;
					Opacity = 1;
				}
			};
			t.Start();
		}
		#endregion

		private void PlayerTab_MsEnter(object sender, EventArgs e)
		{
			pnlPlayerTab.BackColor = Color.FromArgb(35, 45, 55);
			lblPlayerTab.BackColor = Color.FromArgb(35, 45, 55);
		}
		private void PlayerTab_MsLeave(object sender, EventArgs e)
		{
			pnlPlayerTab.BackColor = Color.FromArgb(25, 35, 45);
			lblPlayerTab.BackColor = Color.FromArgb(25, 35, 45);
		}

		private void SettingsTab_MsEnter(object sender, EventArgs e)
		{
			pnlSettingsTab.BackColor = Color.FromArgb(35, 45, 55);
			lblSettingsTab.BackColor = Color.FromArgb(35, 45, 55);
		}
		private void SettingsTab_MsLeave(object sender, EventArgs e)
		{
			pnlSettingsTab.BackColor = Color.FromArgb(25, 35, 45);
			lblSettingsTab.BackColor = Color.FromArgb(25, 35, 45);
		}

		private void PlayerTab_MsClick(object sender, MouseEventArgs e)
		{
			picPlayerTab.Visible = true;
			picSettingsTab.Visible = false;
			pnlPlayer.BringToFront();
			pnlSettings.SendToBack();
		}
		private void SettingsTab_MsClick(object sender, MouseEventArgs e)
		{
			picSettingsTab.Visible = true;
			picPlayerTab.Visible = false;
			pnlSettings.BringToFront();
			pnlPlayer.SendToBack();
		}

		private void AddMedia_MsEnter(object sender, EventArgs e)
		{
			pnlAddMedia.BackColor = Color.FromArgb(35, 45, 55);
			lblAddMedia.BackColor = Color.FromArgb(35, 45, 55);
		}
		private void AddMedia_MsLeave(object sender, EventArgs e)
		{
			pnlAddMedia.BackColor = Color.FromArgb(25, 35, 45);
			lblAddMedia.BackColor = Color.FromArgb(25, 35, 45);
		}

		private void RemoveSelectedMedia_MsEnter(object sender, EventArgs e)
		{
			pnlRemoveSelectedMedia.BackColor = Color.FromArgb(35, 45, 55);
			lblRemoveSelectedMedia.BackColor = Color.FromArgb(35, 45, 55);
		}
		private void RemoveSelectedMedia_MsLeave(object sender, EventArgs e)
		{
			pnlRemoveSelectedMedia.BackColor = Color.FromArgb(25, 35, 45);
			lblRemoveSelectedMedia.BackColor = Color.FromArgb(25, 35, 45);
		}

		private List<string> files = new List<string>();
		private List<string> paths = new List<string>();
		private string currentAudio = string.Empty;
		private WindowsMediaPlayer audioPlayer = new WindowsMediaPlayer();

		private void AddMedia_MsClick(object sender, MouseEventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog
			{
				Title = "Please select an .mp3 to add...",
				Filter = "MPEG3 Audio|*.mp3",
				FilterIndex = 0,
			})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					string file = Path.GetFileName(ofd.FileName);
					string path = Path.GetDirectoryName(ofd.FileName);

					files.Add(file);
					paths.Add(path);

					files = files.Distinct().ToList();
					if (lstAudioFiles.Items.Count > 0)
					{
						lstAudioFiles.Items.Add(file);
						string[] strArray = new string[lstAudioFiles.Items.Count];
						for (int i = 0; i < lstAudioFiles.Items.Count; i++)
						{
							string fileName = lstAudioFiles.Items[i].ToString();
							strArray[i] = fileName;
						}
						strArray = strArray.Distinct().ToArray();
						lstAudioFiles.Items.Clear();
						lstAudioFiles.Items.AddRange(strArray);
						lstPlayableMedia.Items.Clear();
						lstPlayableMedia.Items.AddRange(strArray);
					}
					else
					{
						lstAudioFiles.Items.Add(file);
						lstPlayableMedia.Items.Add(file);
					}
				}
			}
		}
		private void RemoveSelectedMedia_MsClick(object sender, MouseEventArgs e)
		{
			if (lstAudioFiles.SelectedIndex >= 0 && lstAudioFiles.SelectedIndex <= lstAudioFiles.Items.Count - 1)
			{
				files.RemoveAt(lstAudioFiles.SelectedIndex);
				paths.RemoveAt(lstAudioFiles.SelectedIndex);
				lstAudioFiles.Items.RemoveAt(lstAudioFiles.SelectedIndex);
				lstPlayableMedia.Items.RemoveAt(lstPlayableMedia.SelectedIndex);
			}
		}

		private void PlaySelectedMedia_MsEnter(object sender, EventArgs e)
		{
			pnlPlayMedia.BackColor = Color.FromArgb(35, 45, 55);
			lblPlayMedia.BackColor = Color.FromArgb(35, 45, 55);
		}
		private void PlaySelectedMedia_MsLeave(object sender, EventArgs e)
		{
			pnlPlayMedia.BackColor = Color.FromArgb(25, 35, 45);
			lblPlayMedia.BackColor = Color.FromArgb(25, 35, 45);
		}

		private void StopSelectedMedia_MsEnter(object sender, EventArgs e)
		{
			pnlStopMedia.BackColor = Color.FromArgb(35, 45, 55);
			lblStopMedia.BackColor = Color.FromArgb(35, 45, 55);
		}
		private void StopSelectedMedia_MsLeave(object sender, EventArgs e)
		{
			pnlStopMedia.BackColor = Color.FromArgb(25, 35, 45);
			lblStopMedia.BackColor = Color.FromArgb(25, 35, 45);
		}

		private void SelectedMedia_FileChanged(object sender, EventArgs e)
		{
			currentAudio = Path.Combine(
				paths[lstPlayableMedia.SelectedIndex],
				files[lstPlayableMedia.SelectedIndex]
				);
			audioPlayer.URL = currentAudio;
			audioPlayer.controls.stop();
		}
		private void PlaySelectedMedia_MsClick(object sender, MouseEventArgs e)
		{
			if (lstPlayableMedia.SelectedIndex < 0 || lstPlayableMedia.SelectedIndex >= lstPlayableMedia.Items.Count)
			{
				MessageBox.Show("Cannot play media because no audio file is selected.", "Audio File Not Selected",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				audioPlayer.controls.play();
			}
		}
		private void StopSelectedMedia_MsClick(object sender, MouseEventArgs e)
		{
			audioPlayer.controls.stop();
		}
	}
}
