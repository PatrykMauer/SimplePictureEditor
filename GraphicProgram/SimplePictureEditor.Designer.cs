namespace GraphicProgram
{
    partial class SimplePictureEditor
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
            this.panel = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.Toolbar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.unknownEffectButton = new System.Windows.Forms.Button();
            this.sharpenLabel = new System.Windows.Forms.Label();
            this.sharpenTrackBar = new System.Windows.Forms.TrackBar();
            this.sharpenButton = new System.Windows.Forms.Button();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.gammaSlideBar = new System.Windows.Forms.TrackBar();
            this.embossButton = new System.Windows.Forms.Button();
            this.blurLabel = new System.Windows.Forms.Label();
            this.blurTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.blurButton = new System.Windows.Forms.Button();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.blackAndWhiteButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.negativeFastButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.negativeSlowButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.histogramButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaSlideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.canvas);
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(707, 643);
            this.panel.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(707, 643);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // Toolbar
            // 
            this.Toolbar.Controls.Add(this.button3);
            this.Toolbar.Controls.Add(this.histogramButton);
            this.Toolbar.Controls.Add(this.button1);
            this.Toolbar.Controls.Add(this.unknownEffectButton);
            this.Toolbar.Controls.Add(this.sharpenLabel);
            this.Toolbar.Controls.Add(this.sharpenTrackBar);
            this.Toolbar.Controls.Add(this.sharpenButton);
            this.Toolbar.Controls.Add(this.gammaLabel);
            this.Toolbar.Controls.Add(this.gammaSlideBar);
            this.Toolbar.Controls.Add(this.embossButton);
            this.Toolbar.Controls.Add(this.blurLabel);
            this.Toolbar.Controls.Add(this.blurTrackBar);
            this.Toolbar.Controls.Add(this.brightnessLabel);
            this.Toolbar.Controls.Add(this.BrightnessTrackBar);
            this.Toolbar.Controls.Add(this.contrastTrackBar);
            this.Toolbar.Controls.Add(this.blurButton);
            this.Toolbar.Controls.Add(this.contrastLabel);
            this.Toolbar.Controls.Add(this.blackAndWhiteButton);
            this.Toolbar.Controls.Add(this.colorButton);
            this.Toolbar.Controls.Add(this.negativeFastButton);
            this.Toolbar.Controls.Add(this.openFileButton);
            this.Toolbar.Controls.Add(this.saveFileButton);
            this.Toolbar.Controls.Add(this.fileLabel);
            this.Toolbar.Controls.Add(this.negativeSlowButton);
            this.Toolbar.Location = new System.Drawing.Point(714, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(469, 634);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.TabStop = false;
            this.Toolbar.Text = "Toolbar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 52);
            this.button1.TabIndex = 32;
            this.button1.Text = "Unknown Effect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.unknownEffectButton_2_Click);
            // 
            // unknownEffectButton
            // 
            this.unknownEffectButton.Location = new System.Drawing.Point(294, 518);
            this.unknownEffectButton.Name = "unknownEffectButton";
            this.unknownEffectButton.Size = new System.Drawing.Size(90, 52);
            this.unknownEffectButton.TabIndex = 31;
            this.unknownEffectButton.Text = "Unknown Effect";
            this.unknownEffectButton.UseVisualStyleBackColor = true;
            this.unknownEffectButton.Click += new System.EventHandler(this.unknownEffectButton_Click);
            // 
            // sharpenLabel
            // 
            this.sharpenLabel.AutoSize = true;
            this.sharpenLabel.Location = new System.Drawing.Point(173, 57);
            this.sharpenLabel.Name = "sharpenLabel";
            this.sharpenLabel.Size = new System.Drawing.Size(47, 13);
            this.sharpenLabel.TabIndex = 30;
            this.sharpenLabel.Text = "Sharpen";
            // 
            // sharpenTrackBar
            // 
            this.sharpenTrackBar.Location = new System.Drawing.Point(9, 80);
            this.sharpenTrackBar.Maximum = 100;
            this.sharpenTrackBar.Minimum = 1;
            this.sharpenTrackBar.Name = "sharpenTrackBar";
            this.sharpenTrackBar.Size = new System.Drawing.Size(449, 45);
            this.sharpenTrackBar.TabIndex = 29;
            this.sharpenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sharpenTrackBar.Value = 1;
            // 
            // sharpenButton
            // 
            this.sharpenButton.Location = new System.Drawing.Point(261, 49);
            this.sharpenButton.Name = "sharpenButton";
            this.sharpenButton.Size = new System.Drawing.Size(66, 28);
            this.sharpenButton.TabIndex = 28;
            this.sharpenButton.Text = "Sharpen";
            this.sharpenButton.UseVisualStyleBackColor = true;
            this.sharpenButton.Click += new System.EventHandler(this.sharpenButton_Click);
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(187, 323);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(43, 13);
            this.gammaLabel.TabIndex = 27;
            this.gammaLabel.Text = "Gamma";
            // 
            // gammaSlideBar
            // 
            this.gammaSlideBar.Location = new System.Drawing.Point(9, 342);
            this.gammaSlideBar.Maximum = 100;
            this.gammaSlideBar.Minimum = 1;
            this.gammaSlideBar.Name = "gammaSlideBar";
            this.gammaSlideBar.Size = new System.Drawing.Size(449, 45);
            this.gammaSlideBar.TabIndex = 26;
            this.gammaSlideBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gammaSlideBar.Value = 1;
            this.gammaSlideBar.Scroll += new System.EventHandler(this.gammaTrackBar_Scroll);
            // 
            // embossButton
            // 
            this.embossButton.Location = new System.Drawing.Point(6, 576);
            this.embossButton.Name = "embossButton";
            this.embossButton.Size = new System.Drawing.Size(90, 52);
            this.embossButton.TabIndex = 25;
            this.embossButton.Text = "Emboss";
            this.embossButton.UseVisualStyleBackColor = true;
            this.embossButton.Click += new System.EventHandler(this.embossButton_Click);
            // 
            // blurLabel
            // 
            this.blurLabel.AutoSize = true;
            this.blurLabel.Location = new System.Drawing.Point(184, 136);
            this.blurLabel.Name = "blurLabel";
            this.blurLabel.Size = new System.Drawing.Size(25, 13);
            this.blurLabel.TabIndex = 24;
            this.blurLabel.Text = "Blur";
            // 
            // blurTrackBar
            // 
            this.blurTrackBar.Location = new System.Drawing.Point(6, 163);
            this.blurTrackBar.Maximum = 100;
            this.blurTrackBar.Minimum = 1;
            this.blurTrackBar.Name = "blurTrackBar";
            this.blurTrackBar.Size = new System.Drawing.Size(454, 45);
            this.blurTrackBar.TabIndex = 23;
            this.blurTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blurTrackBar.Value = 1;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(184, 275);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.brightnessLabel.TabIndex = 21;
            this.brightnessLabel.Text = "Brightness";
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Location = new System.Drawing.Point(9, 291);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Minimum = 1;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(449, 45);
            this.BrightnessTrackBar.TabIndex = 20;
            this.BrightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessTrackBar.Value = 1;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(9, 227);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = 1;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(449, 45);
            this.contrastTrackBar.TabIndex = 19;
            this.contrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrastTrackBar.Value = 1;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // blurButton
            // 
            this.blurButton.Location = new System.Drawing.Point(261, 131);
            this.blurButton.Name = "blurButton";
            this.blurButton.Size = new System.Drawing.Size(66, 26);
            this.blurButton.TabIndex = 16;
            this.blurButton.Text = "Blur";
            this.blurButton.UseVisualStyleBackColor = true;
            this.blurButton.Click += new System.EventHandler(this.blurButton_Click);
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(184, 211);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(46, 13);
            this.contrastLabel.TabIndex = 15;
            this.contrastLabel.Text = "Contrast";
            // 
            // blackAndWhiteButton
            // 
            this.blackAndWhiteButton.Location = new System.Drawing.Point(158, 576);
            this.blackAndWhiteButton.Name = "blackAndWhiteButton";
            this.blackAndWhiteButton.Size = new System.Drawing.Size(97, 52);
            this.blackAndWhiteButton.TabIndex = 14;
            this.blackAndWhiteButton.Text = "Black-and-white";
            this.blackAndWhiteButton.UseVisualStyleBackColor = true;
            this.blackAndWhiteButton.Click += new System.EventHandler(this.blackAndWhiteButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(102, 576);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(50, 52);
            this.colorButton.TabIndex = 5;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_click);
            // 
            // negativeFastButton
            // 
            this.negativeFastButton.Location = new System.Drawing.Point(364, 576);
            this.negativeFastButton.Name = "negativeFastButton";
            this.negativeFastButton.Size = new System.Drawing.Size(94, 52);
            this.negativeFastButton.TabIndex = 4;
            this.negativeFastButton.Text = "Negative?--fast";
            this.negativeFastButton.UseVisualStyleBackColor = true;
            this.negativeFastButton.Click += new System.EventHandler(this.negativeFastButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(41, 12);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(157, 23);
            this.openFileButton.TabIndex = 2;
            this.openFileButton.Text = "Open ";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(204, 12);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(157, 23);
            this.saveFileButton.TabIndex = 3;
            this.saveFileButton.Text = "Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(6, 16);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(29, 13);
            this.fileLabel.TabIndex = 2;
            this.fileLabel.Text = "File :";
            // 
            // negativeSlowButton
            // 
            this.negativeSlowButton.Location = new System.Drawing.Point(261, 576);
            this.negativeSlowButton.Name = "negativeSlowButton";
            this.negativeSlowButton.Size = new System.Drawing.Size(98, 52);
            this.negativeSlowButton.TabIndex = 0;
            this.negativeSlowButton.Text = "Negative?--slow";
            this.negativeSlowButton.UseVisualStyleBackColor = true;
            this.negativeSlowButton.Click += new System.EventHandler(this.negativeSlowButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
            // 
            // histogramButton
            // 
            this.histogramButton.Location = new System.Drawing.Point(6, 518);
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(90, 52);
            this.histogramButton.TabIndex = 33;
            this.histogramButton.Text = "Histogram";
            this.histogramButton.UseVisualStyleBackColor = true;
            this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 52);
            this.button3.TabIndex = 34;
            this.button3.Text = "Otsu Threshold";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.otsuThresholdButton_Click);
            // 
            // SimplePictureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 646);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SimplePictureEditor";
            this.Text = "SimplePictureEditor";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharpenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaSlideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.GroupBox Toolbar;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button negativeSlowButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button negativeFastButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button blackAndWhiteButton;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.Button blurButton;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label blurLabel;
        private System.Windows.Forms.TrackBar blurTrackBar;
        private System.Windows.Forms.Button embossButton;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.TrackBar gammaSlideBar;
        private System.Windows.Forms.Label sharpenLabel;
        private System.Windows.Forms.TrackBar sharpenTrackBar;
        private System.Windows.Forms.Button sharpenButton;
        private System.Windows.Forms.Button unknownEffectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button histogramButton;
    }
}

