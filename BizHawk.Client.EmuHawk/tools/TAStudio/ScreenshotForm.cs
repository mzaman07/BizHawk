﻿// We pretend it's a tooltip kind of thing, so show only the actual contents
// and avoid stealing forcus, while still being topmost
// http://stackoverflow.com/a/25219399/2792852
// This is not an actual tooltip, because they can't reliably fade in and out with trasparency

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BizHawk.Client.Common;

namespace BizHawk.Client.EmuHawk
{
	public partial class ScreenshotForm : Form
	{
		private Timer _showTimer = new Timer();
		private Timer _hideTimer = new Timer();
		public TasBranch Branch { get; set; }
		new public Font Font;
		public FontStyle FontStyle;
		public int FontSize;
		public int DrawingHeight;
		new public int Padding;
		new public string Text;

		public ScreenshotForm()
		{
			InitializeComponent();

			Width = 320;
			Height = 240;
			FontSize = 10;
			FontStyle = FontStyle.Regular;
			Font = new Font(FontFamily.GenericMonospace, FontSize, FontStyle);
			DrawingHeight = 0;
			Padding = 0;
			Opacity = 0;
			
			_showTimer.Interval = 1;
			_showTimer.Tick += new EventHandler((sender, e) =>
			{
				if ((Opacity += 0.05d) >= 1)
					_showTimer.Stop();
			});

			_hideTimer.Interval = 1;
			_hideTimer.Tick += new EventHandler((sender, e) =>
			{
				if ((Opacity -= 0.05d) <= 0)
				{
					_hideTimer.Stop();
					Hide();
				}
			});
		}

		public void UpdateValues(TasBranch branch, Point location , int width, int height, int padding)
		{
			Branch = branch;
			Width = width;
			Padding = padding;
			DrawingHeight = height;
			Text = Branch.UserText;
			Location = location;

			// Set the screenshot to "1x" resolution of the core
			// cores like n64 and psx are going to still have sizes too big for the control, so cap them
			if (Width > 320)
			{
				double ratio = 320.0 / (double)Width;
				Width = 320;
				DrawingHeight = (int)((double)(DrawingHeight) * ratio);
			}

			if (Padding > 0)
				Padding += 2;
			Height = DrawingHeight + Padding;
			Refresh();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Branch.OSDFrameBuffer.DiscardAlpha();
			var bitmap = Branch.OSDFrameBuffer.ToSysdrawingBitmap();
			e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, Width, DrawingHeight));
			if (Padding > 0)
			{
				e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(new Point(0, DrawingHeight), new Size(Width - 1, Padding - 1)));
				e.Graphics.DrawString(Text, Font, Brushes.Black, new Rectangle(2, DrawingHeight, Width - 2, Height));
			}
			base.OnPaint(e);
		}

		public void FadeIn()
		{
			_showTimer.Stop();
			_hideTimer.Stop();
			_showTimer.Start();
			Show();
		}

		public void FadeOut()
		{
			_showTimer.Stop();
			_hideTimer.Stop();
			_hideTimer.Start();
		}

		protected override bool ShowWithoutActivation
		{
			get { return true; }
		}

		private const int WS_EX_TOPMOST = 0x00000008;
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= WS_EX_TOPMOST;
				return createParams;
			}
		}
	}
}
