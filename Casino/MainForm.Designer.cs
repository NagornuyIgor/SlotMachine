using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Casino
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureButton = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.pictureMoneta = new System.Windows.Forms.PictureBox();
			this.rateBox = new System.Windows.Forms.ComboBox();
			this.suppliedMoneyLabel = new System.Windows.Forms.Label();
			this.gainLabel = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureMoneta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureButton
			// 
			this.pictureButton.BackColor = System.Drawing.Color.Transparent;
			this.pictureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureButton.BackgroundImage")));
			this.pictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureButton.Location = new System.Drawing.Point(200, 541);
			this.pictureButton.Name = "pictureButton";
			this.pictureButton.Size = new System.Drawing.Size(76, 61);
			this.pictureButton.TabIndex = 1;
			this.pictureButton.TabStop = false;
			this.pictureButton.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Location = new System.Drawing.Point(117, 400);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(64, 64);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Location = new System.Drawing.Point(117, 464);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(64, 64);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox6.Location = new System.Drawing.Point(210, 400);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(64, 64);
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox7.Location = new System.Drawing.Point(210, 464);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(64, 64);
			this.pictureBox7.TabIndex = 7;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox8.Location = new System.Drawing.Point(212, 336);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(64, 64);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox9.Location = new System.Drawing.Point(307, 400);
			this.pictureBox9.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(64, 64);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox10.Location = new System.Drawing.Point(307, 336);
			this.pictureBox10.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(64, 64);
			this.pictureBox10.TabIndex = 10;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox11.Location = new System.Drawing.Point(307, 464);
			this.pictureBox11.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(64, 64);
			this.pictureBox11.TabIndex = 11;
			this.pictureBox11.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "acida.png");
			this.imageList1.Images.SetKeyName(1, "caipirinhaicon.png");
			this.imageList1.Images.SetKeyName(2, "cake.png");
			this.imageList1.Images.SetKeyName(3, "cake2.png");
			this.imageList1.Images.SetKeyName(4, "candy.png");
			this.imageList1.Images.SetKeyName(5, "cream1.png");
			this.imageList1.Images.SetKeyName(6, "maitaiicon.png");
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
			this.label1.Location = new System.Drawing.Point(196, 868);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 26);
			this.label1.TabIndex = 12;
			this.label1.Text = "500";
			// 
			// pictureMoneta
			// 
			this.pictureMoneta.BackColor = System.Drawing.Color.Transparent;
			this.pictureMoneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureMoneta.Location = new System.Drawing.Point(369, 464);
			this.pictureMoneta.Name = "pictureMoneta";
			this.pictureMoneta.Size = new System.Drawing.Size(100, 96);
			this.pictureMoneta.TabIndex = 13;
			this.pictureMoneta.TabStop = false;
			this.pictureMoneta.Click += new System.EventHandler(this.pictureMoneta_Click);
			this.pictureMoneta.MouseEnter += new System.EventHandler(this.pictureMoneta_MouseEnter);
			this.pictureMoneta.MouseLeave += new System.EventHandler(this.pictureMoneta_MouseLeave);
			// 
			// rateBox
			// 
			this.rateBox.BackColor = System.Drawing.Color.White;
			this.rateBox.FormattingEnabled = true;
			this.rateBox.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500",
            "1000",
            "2000",
            "5000"});
			this.rateBox.Location = new System.Drawing.Point(44, 563);
			this.rateBox.Name = "rateBox";
			this.rateBox.Size = new System.Drawing.Size(121, 21);
			this.rateBox.TabIndex = 15;
			// 
			// suppliedMoneyLabel
			// 
			this.suppliedMoneyLabel.AutoSize = true;
			this.suppliedMoneyLabel.BackColor = System.Drawing.Color.Transparent;
			this.suppliedMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.suppliedMoneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
			this.suppliedMoneyLabel.Location = new System.Drawing.Point(22, 190);
			this.suppliedMoneyLabel.Name = "suppliedMoneyLabel";
			this.suppliedMoneyLabel.Size = new System.Drawing.Size(24, 26);
			this.suppliedMoneyLabel.TabIndex = 16;
			this.suppliedMoneyLabel.Text = "0";
			// 
			// gainLabel
			// 
			this.gainLabel.AutoSize = true;
			this.gainLabel.BackColor = System.Drawing.Color.Transparent;
			this.gainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.gainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
			this.gainLabel.Location = new System.Drawing.Point(22, 216);
			this.gainLabel.Name = "gainLabel";
			this.gainLabel.Size = new System.Drawing.Size(24, 26);
			this.gainLabel.TabIndex = 17;
			this.gainLabel.Text = "0";
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Location = new System.Drawing.Point(117, 336);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(64, 64);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(490, 920);
			this.Controls.Add(this.gainLabel);
			this.Controls.Add(this.suppliedMoneyLabel);
			this.Controls.Add(this.rateBox);
			this.Controls.Add(this.pictureMoneta);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureButton);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox4);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Casino ne \"joy\"";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureMoneta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureButton;
		private System.Windows.Forms.PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureMoneta;
		private System.Windows.Forms.ComboBox rateBox;
		private System.Windows.Forms.Label suppliedMoneyLabel;
		private System.Windows.Forms.Label gainLabel;
	}

	public class TransparentPictureBox : PictureBox
	{
		public TransparentPictureBox()
		{
			this.BackColor = Color.Transparent;
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			if (Parent != null && this.BackColor == Color.Transparent)
			{
				using (var bmp = new Bitmap(Parent.Width, Parent.Height))
				{
					Parent.Controls.Cast<Control>()
						  .Where(c => Parent.Controls.GetChildIndex(c) > Parent.Controls.GetChildIndex(this))
						  .Where(c => c.Bounds.IntersectsWith(this.Bounds))
						  .OrderByDescending(c => Parent.Controls.GetChildIndex(c))
						  .ToList()
						  .ForEach(c => c.DrawToBitmap(bmp, c.Bounds));

					e.Graphics.DrawImage(bmp, -Left, -Top);

				}
			}
			base.OnPaint(e);
		}
	}

}

