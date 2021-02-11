
namespace Chat_Spammer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RichTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.Button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(175, 29);
            this.Button1.Name = "Button1";
            this.Button1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.Button1.Size = new System.Drawing.Size(102, 51);
            this.Button1.TabIndex = 0;
            this.Button1.Values.Text = "Start";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.RichTextBox1.Location = new System.Drawing.Point(3, 29);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(166, 108);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(175, 86);
            this.Button2.Name = "Button2";
            this.Button2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.Button2.Size = new System.Drawing.Size(102, 51);
            this.Button2.TabIndex = 2;
            this.Button2.Values.Text = "Stop";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(254, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.kryptonButton1.Size = new System.Drawing.Size(23, 24);
            this.kryptonButton1.TabIndex = 3;
            this.kryptonButton1.Values.Text = "X";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text Spammer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(280, 141);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Button1;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox RichTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label1;
    }
}

