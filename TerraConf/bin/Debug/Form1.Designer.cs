using System;
using System.Diagnostics;

namespace TerraConf
{
    partial class TCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TCForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tMouseGreen = new System.Windows.Forms.Label();
            this.tMouseRed = new System.Windows.Forms.Label();
            this.tMouseBlue = new System.Windows.Forms.Label();
            this.tAudioMaster = new System.Windows.Forms.Label();
            this.tAudioAmbient = new System.Windows.Forms.Label();
            this.tAudioMusic = new System.Windows.Forms.Label();
            this.tCaveParallax = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.fCurRelease = new System.Windows.Forms.TextBox();
            this.fCllientUUID = new System.Windows.Forms.TextBox();
            this.fFullScreen = new System.Windows.Forms.CheckBox();
            this.fMaximized = new System.Windows.Forms.CheckBox();
            this.fAutoSave = new System.Windows.Forms.CheckBox();
            this.fAutoPause = new System.Windows.Forms.CheckBox();
            this.fMapEnabled = new System.Windows.Forms.CheckBox();
            this.fMouseRed = new System.Windows.Forms.HScrollBar();
            this.fMouseGreen = new System.Windows.Forms.HScrollBar();
            this.fMouseBlue = new System.Windows.Forms.HScrollBar();
            this.fAudioMaster = new System.Windows.Forms.HScrollBar();
            this.fAudioAmbient = new System.Windows.Forms.HScrollBar();
            this.fAudioMusic = new System.Windows.Forms.HScrollBar();
            this.fFrameSkip = new System.Windows.Forms.CheckBox();
            this.fXResolution = new System.Windows.Forms.TextBox();
            this.fYResolution = new System.Windows.Forms.TextBox();
            this.fItemText = new System.Windows.Forms.CheckBox();
            this.fBackground = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.fQuality = new System.Windows.Forms.ComboBox();
            this.fLanguage = new System.Windows.Forms.ComboBox();
            this.fLightingMode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tUp = new System.Windows.Forms.Label();
            this.tDown = new System.Windows.Forms.Label();
            this.tLeft = new System.Windows.Forms.Label();
            this.tRight = new System.Windows.Forms.Label();
            this.tJump = new System.Windows.Forms.Label();
            this.tThrowItem = new System.Windows.Forms.Label();
            this.tInv = new System.Windows.Forms.Label();
            this.tHeal = new System.Windows.Forms.Label();
            this.tMana = new System.Windows.Forms.Label();
            this.tBuff = new System.Windows.Forms.Label();
            this.tSmart = new System.Windows.Forms.Label();
            this.tMapAlphaDown = new System.Windows.Forms.Label();
            this.tMapAlphaUp = new System.Windows.Forms.Label();
            this.tMapZoomOut = new System.Windows.Forms.Label();
            this.tMapZoomIn = new System.Windows.Forms.Label();
            this.tMapFull = new System.Windows.Forms.Label();
            this.tMapStyle = new System.Windows.Forms.Label();
            this.tTorch = new System.Windows.Forms.Label();
            this.tHook = new System.Windows.Forms.Label();
            this.fParallax = new System.Windows.Forms.HScrollBar();
            this.fSmartMode = new System.Windows.Forms.ComboBox();
            this.fLightingThreads = new System.Windows.Forms.ComboBox();
            this.ProcWarn = new System.Windows.Forms.Label();
            this.AuthorInfo = new System.Windows.Forms.Label();
            this.tCFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Release";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tMouseGreen, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tMouseRed, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tMouseBlue, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tAudioMaster, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tAudioAmbient, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tAudioMusic, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tCaveParallax, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.fCurRelease, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fCllientUUID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fFullScreen, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fMaximized, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.fAutoSave, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.fAutoPause, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.fMapEnabled, 1, 20);
            this.tableLayoutPanel1.Controls.Add(this.fMouseRed, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fMouseGreen, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fMouseBlue, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.fAudioMaster, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.fAudioAmbient, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.fAudioMusic, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.fFrameSkip, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.fXResolution, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.fYResolution, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.fItemText, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.fBackground, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 21);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 22);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 23);
            this.tableLayoutPanel1.Controls.Add(this.fQuality, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.fLanguage, 1, 19);
            this.tableLayoutPanel1.Controls.Add(this.fLightingMode, 1, 21);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 24);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tUp, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tDown, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tLeft, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tRight, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.tJump, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.tThrowItem, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.tInv, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.tHeal, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.tMana, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.tBuff, 2, 13);
            this.tableLayoutPanel1.Controls.Add(this.tSmart, 2, 22);
            this.tableLayoutPanel1.Controls.Add(this.tMapAlphaDown, 2, 21);
            this.tableLayoutPanel1.Controls.Add(this.tMapAlphaUp, 2, 20);
            this.tableLayoutPanel1.Controls.Add(this.tMapZoomOut, 2, 19);
            this.tableLayoutPanel1.Controls.Add(this.tMapZoomIn, 2, 18);
            this.tableLayoutPanel1.Controls.Add(this.tMapFull, 2, 17);
            this.tableLayoutPanel1.Controls.Add(this.tMapStyle, 2, 16);
            this.tableLayoutPanel1.Controls.Add(this.tTorch, 2, 15);
            this.tableLayoutPanel1.Controls.Add(this.tHook, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.fParallax, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.fSmartMode, 1, 23);
            this.tableLayoutPanel1.Controls.Add(this.fLightingThreads, 1, 22);
            this.tableLayoutPanel1.Controls.Add(this.ProcWarn, 1, 24);
            this.tableLayoutPanel1.Controls.Add(this.AuthorInfo, 0, 24);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 25;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client UUID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Screen?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tMouseGreen
            // 
            this.tMouseGreen.AutoSize = true;
            this.tMouseGreen.ForeColor = System.Drawing.Color.Green;
            this.tMouseGreen.Location = new System.Drawing.Point(3, 80);
            this.tMouseGreen.Name = "tMouseGreen";
            this.tMouseGreen.Size = new System.Drawing.Size(77, 13);
            this.tMouseGreen.TabIndex = 4;
            this.tMouseGreen.Text = "Mouse - Green";
            this.tMouseGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tMouseRed
            // 
            this.tMouseRed.AutoSize = true;
            this.tMouseRed.ForeColor = System.Drawing.Color.Red;
            this.tMouseRed.Location = new System.Drawing.Point(3, 60);
            this.tMouseRed.Name = "tMouseRed";
            this.tMouseRed.Size = new System.Drawing.Size(68, 13);
            this.tMouseRed.TabIndex = 3;
            this.tMouseRed.Text = "Mouse - Red";
            this.tMouseRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tMouseBlue
            // 
            this.tMouseBlue.AutoSize = true;
            this.tMouseBlue.ForeColor = System.Drawing.Color.Blue;
            this.tMouseBlue.Location = new System.Drawing.Point(3, 100);
            this.tMouseBlue.Name = "tMouseBlue";
            this.tMouseBlue.Size = new System.Drawing.Size(69, 13);
            this.tMouseBlue.TabIndex = 5;
            this.tMouseBlue.Text = "Mouse - Blue";
            this.tMouseBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tAudioMaster
            // 
            this.tAudioMaster.AutoSize = true;
            this.tAudioMaster.Location = new System.Drawing.Point(3, 120);
            this.tAudioMaster.Name = "tAudioMaster";
            this.tAudioMaster.Size = new System.Drawing.Size(79, 13);
            this.tAudioMaster.TabIndex = 6;
            this.tAudioMaster.Text = "Sound - Master";
            this.tAudioMaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tAudioAmbient
            // 
            this.tAudioAmbient.AutoSize = true;
            this.tAudioAmbient.Location = new System.Drawing.Point(3, 140);
            this.tAudioAmbient.Name = "tAudioAmbient";
            this.tAudioAmbient.Size = new System.Drawing.Size(85, 13);
            this.tAudioAmbient.TabIndex = 7;
            this.tAudioAmbient.Text = "Sound - Ambient";
            this.tAudioAmbient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tAudioMusic
            // 
            this.tAudioMusic.AutoSize = true;
            this.tAudioMusic.Location = new System.Drawing.Point(3, 160);
            this.tAudioMusic.Name = "tAudioMusic";
            this.tAudioMusic.Size = new System.Drawing.Size(75, 13);
            this.tAudioMusic.TabIndex = 8;
            this.tAudioMusic.Text = "Sound - Music";
            this.tAudioMusic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tCaveParallax
            // 
            this.tCaveParallax.AutoSize = true;
            this.tCaveParallax.Location = new System.Drawing.Point(3, 180);
            this.tCaveParallax.Name = "tCaveParallax";
            this.tCaveParallax.Size = new System.Drawing.Size(44, 13);
            this.tCaveParallax.TabIndex = 9;
            this.tCaveParallax.Text = "Parallax";
            this.tCaveParallax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Frame Skip";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Screen Maximized?";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "X Resolution";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Y Resolution";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Auto Save";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Auto Pause";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 320);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Show Item Text";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Quality Level";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 360);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Show Background?";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 380);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Language";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 400);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Map Enabled?";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fCurRelease
            // 
            this.fCurRelease.Enabled = false;
            this.fCurRelease.Location = new System.Drawing.Point(138, 3);
            this.fCurRelease.Name = "fCurRelease";
            this.fCurRelease.ReadOnly = true;
            this.fCurRelease.Size = new System.Drawing.Size(100, 20);
            this.fCurRelease.TabIndex = 21;
            // 
            // fCllientUUID
            // 
            this.fCllientUUID.Enabled = false;
            this.fCllientUUID.Location = new System.Drawing.Point(138, 23);
            this.fCllientUUID.Name = "fCllientUUID";
            this.fCllientUUID.ReadOnly = true;
            this.fCllientUUID.Size = new System.Drawing.Size(276, 20);
            this.fCllientUUID.TabIndex = 22;
            // 
            // fFullScreen
            // 
            this.fFullScreen.AutoSize = true;
            this.fFullScreen.Location = new System.Drawing.Point(138, 43);
            this.fFullScreen.Name = "fFullScreen";
            this.fFullScreen.Size = new System.Drawing.Size(15, 14);
            this.fFullScreen.TabIndex = 23;
            this.fFullScreen.UseVisualStyleBackColor = true;
            this.fFullScreen.CheckedChanged += new System.EventHandler(this.fFullScreen_CheckedChanged);
            // 
            // fMaximized
            // 
            this.fMaximized.AutoSize = true;
            this.fMaximized.Location = new System.Drawing.Point(138, 223);
            this.fMaximized.Name = "fMaximized";
            this.fMaximized.Size = new System.Drawing.Size(15, 14);
            this.fMaximized.TabIndex = 24;
            this.fMaximized.UseVisualStyleBackColor = true;
            this.fMaximized.CheckedChanged += new System.EventHandler(this.fMaximized_CheckedChanged);
            // 
            // fAutoSave
            // 
            this.fAutoSave.AutoSize = true;
            this.fAutoSave.Location = new System.Drawing.Point(138, 283);
            this.fAutoSave.Name = "fAutoSave";
            this.fAutoSave.Size = new System.Drawing.Size(15, 14);
            this.fAutoSave.TabIndex = 25;
            this.fAutoSave.UseVisualStyleBackColor = true;
            this.fAutoSave.CheckedChanged += new System.EventHandler(this.fAutoSave_CheckedChanged);
            // 
            // fAutoPause
            // 
            this.fAutoPause.AutoSize = true;
            this.fAutoPause.Location = new System.Drawing.Point(138, 303);
            this.fAutoPause.Name = "fAutoPause";
            this.fAutoPause.Size = new System.Drawing.Size(15, 14);
            this.fAutoPause.TabIndex = 26;
            this.fAutoPause.UseVisualStyleBackColor = true;
            this.fAutoPause.CheckedChanged += new System.EventHandler(this.fAutoPause_CheckedChanged);
            // 
            // fMapEnabled
            // 
            this.fMapEnabled.AutoSize = true;
            this.fMapEnabled.Location = new System.Drawing.Point(138, 403);
            this.fMapEnabled.Name = "fMapEnabled";
            this.fMapEnabled.Size = new System.Drawing.Size(15, 14);
            this.fMapEnabled.TabIndex = 27;
            this.fMapEnabled.UseVisualStyleBackColor = true;
            this.fMapEnabled.CheckedChanged += new System.EventHandler(this.fMapEnabled_CheckedChanged);
            // 
            // fMouseRed
            // 
            this.fMouseRed.LargeChange = 1;
            this.fMouseRed.Location = new System.Drawing.Point(135, 60);
            this.fMouseRed.Maximum = 255;
            this.fMouseRed.Name = "fMouseRed";
            this.fMouseRed.Size = new System.Drawing.Size(150, 17);
            this.fMouseRed.TabIndex = 28;
            this.fMouseRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fMouseRed_Scroll);
            // 
            // fMouseGreen
            // 
            this.fMouseGreen.LargeChange = 1;
            this.fMouseGreen.Location = new System.Drawing.Point(135, 80);
            this.fMouseGreen.Maximum = 255;
            this.fMouseGreen.Name = "fMouseGreen";
            this.fMouseGreen.Size = new System.Drawing.Size(150, 17);
            this.fMouseGreen.TabIndex = 29;
            this.fMouseGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fMouseGreen_Scroll);
            // 
            // fMouseBlue
            // 
            this.fMouseBlue.LargeChange = 1;
            this.fMouseBlue.Location = new System.Drawing.Point(135, 100);
            this.fMouseBlue.Maximum = 255;
            this.fMouseBlue.Name = "fMouseBlue";
            this.fMouseBlue.Size = new System.Drawing.Size(150, 17);
            this.fMouseBlue.TabIndex = 30;
            this.fMouseBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fMouseBlue_Scroll);
            // 
            // fAudioMaster
            // 
            this.fAudioMaster.LargeChange = 1;
            this.fAudioMaster.Location = new System.Drawing.Point(135, 120);
            this.fAudioMaster.Name = "fAudioMaster";
            this.fAudioMaster.Size = new System.Drawing.Size(150, 17);
            this.fAudioMaster.TabIndex = 31;
            this.fAudioMaster.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fAudioMaster_Scroll);
            // 
            // fAudioAmbient
            // 
            this.fAudioAmbient.LargeChange = 1;
            this.fAudioAmbient.Location = new System.Drawing.Point(135, 140);
            this.fAudioAmbient.Name = "fAudioAmbient";
            this.fAudioAmbient.Size = new System.Drawing.Size(150, 17);
            this.fAudioAmbient.TabIndex = 32;
            this.fAudioAmbient.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fAudioAmbient_Scroll);
            // 
            // fAudioMusic
            // 
            this.fAudioMusic.LargeChange = 1;
            this.fAudioMusic.Location = new System.Drawing.Point(135, 160);
            this.fAudioMusic.Name = "fAudioMusic";
            this.fAudioMusic.Size = new System.Drawing.Size(150, 17);
            this.fAudioMusic.TabIndex = 33;
            this.fAudioMusic.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fAudioMusic_Scroll);
            // 
            // fFrameSkip
            // 
            this.fFrameSkip.AutoSize = true;
            this.fFrameSkip.Location = new System.Drawing.Point(138, 203);
            this.fFrameSkip.Name = "fFrameSkip";
            this.fFrameSkip.Size = new System.Drawing.Size(15, 14);
            this.fFrameSkip.TabIndex = 34;
            this.fFrameSkip.UseVisualStyleBackColor = true;
            this.fFrameSkip.CheckedChanged += new System.EventHandler(this.fFrameSkip_CheckedChanged);
            // 
            // fXResolution
            // 
            this.fXResolution.Location = new System.Drawing.Point(138, 243);
            this.fXResolution.MaxLength = 5;
            this.fXResolution.Name = "fXResolution";
            this.fXResolution.Size = new System.Drawing.Size(100, 20);
            this.fXResolution.TabIndex = 35;
            this.fXResolution.TextChanged += new System.EventHandler(this.fXResolution_TextChanged);
            // 
            // fYResolution
            // 
            this.fYResolution.Location = new System.Drawing.Point(138, 263);
            this.fYResolution.MaxLength = 5;
            this.fYResolution.Name = "fYResolution";
            this.fYResolution.Size = new System.Drawing.Size(100, 20);
            this.fYResolution.TabIndex = 36;
            this.fYResolution.TextChanged += new System.EventHandler(this.fYResolution_TextChanged);
            // 
            // fItemText
            // 
            this.fItemText.AutoSize = true;
            this.fItemText.Location = new System.Drawing.Point(138, 323);
            this.fItemText.Name = "fItemText";
            this.fItemText.Size = new System.Drawing.Size(15, 14);
            this.fItemText.TabIndex = 39;
            this.fItemText.UseVisualStyleBackColor = true;
            this.fItemText.CheckedChanged += new System.EventHandler(this.fItemText_CheckedChanged);
            // 
            // fBackground
            // 
            this.fBackground.AutoSize = true;
            this.fBackground.Location = new System.Drawing.Point(138, 363);
            this.fBackground.Name = "fBackground";
            this.fBackground.Size = new System.Drawing.Size(15, 14);
            this.fBackground.TabIndex = 40;
            this.fBackground.UseVisualStyleBackColor = true;
            this.fBackground.CheckedChanged += new System.EventHandler(this.fBackground_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 420);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Lighting Mode";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 440);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Lighting Threads";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 460);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 46;
            this.label24.Text = "Smart Cursor Mode";
            // 
            // fQuality
            // 
            this.fQuality.FormattingEnabled = true;
            this.fQuality.Items.AddRange(new object[] {
            "Auto",
            "High",
            "Medium",
            "Low"});
            this.fQuality.Location = new System.Drawing.Point(138, 343);
            this.fQuality.Name = "fQuality";
            this.fQuality.Size = new System.Drawing.Size(121, 21);
            this.fQuality.TabIndex = 47;
            this.fQuality.SelectedIndexChanged += new System.EventHandler(this.fQuality_SelectedIndexChanged);
            // 
            // fLanguage
            // 
            this.fLanguage.FormattingEnabled = true;
            this.fLanguage.Items.AddRange(new object[] {
            "English",
            "Deutsch",
            "Italiano",
            "Française",
            "Español"});
            this.fLanguage.Location = new System.Drawing.Point(138, 383);
            this.fLanguage.Name = "fLanguage";
            this.fLanguage.Size = new System.Drawing.Size(121, 21);
            this.fLanguage.TabIndex = 48;
            this.fLanguage.SelectedIndexChanged += new System.EventHandler(this.fLanguage_SelectedIndexChanged);
            // 
            // fLightingMode
            // 
            this.fLightingMode.FormattingEnabled = true;
            this.fLightingMode.Items.AddRange(new object[] {
            "Color",
            "White",
            "Retro",
            "Trippy"});
            this.fLightingMode.Location = new System.Drawing.Point(138, 423);
            this.fLightingMode.Name = "fLightingMode";
            this.fLightingMode.Size = new System.Drawing.Size(121, 21);
            this.fLightingMode.TabIndex = 49;
            this.fLightingMode.SelectedIndexChanged += new System.EventHandler(this.fLightingMode_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(477, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 62);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Keyboard Controls";
            // 
            // tUp
            // 
            this.tUp.AutoSize = true;
            this.tUp.Location = new System.Drawing.Point(477, 80);
            this.tUp.Name = "tUp";
            this.tUp.Size = new System.Drawing.Size(27, 13);
            this.tUp.TabIndex = 51;
            this.tUp.Text = "Up: ";
            // 
            // tDown
            // 
            this.tDown.AutoSize = true;
            this.tDown.Location = new System.Drawing.Point(477, 100);
            this.tDown.Name = "tDown";
            this.tDown.Size = new System.Drawing.Size(41, 13);
            this.tDown.TabIndex = 52;
            this.tDown.Text = "Down: ";
            // 
            // tLeft
            // 
            this.tLeft.AutoSize = true;
            this.tLeft.Location = new System.Drawing.Point(477, 120);
            this.tLeft.Name = "tLeft";
            this.tLeft.Size = new System.Drawing.Size(31, 13);
            this.tLeft.TabIndex = 53;
            this.tLeft.Text = "Left: ";
            // 
            // tRight
            // 
            this.tRight.AutoSize = true;
            this.tRight.Location = new System.Drawing.Point(477, 140);
            this.tRight.Name = "tRight";
            this.tRight.Size = new System.Drawing.Size(38, 13);
            this.tRight.TabIndex = 54;
            this.tRight.Text = "Right: ";
            // 
            // tJump
            // 
            this.tJump.AutoSize = true;
            this.tJump.Location = new System.Drawing.Point(477, 160);
            this.tJump.Name = "tJump";
            this.tJump.Size = new System.Drawing.Size(38, 13);
            this.tJump.TabIndex = 55;
            this.tJump.Text = "Jump: ";
            // 
            // tThrowItem
            // 
            this.tThrowItem.AutoSize = true;
            this.tThrowItem.Location = new System.Drawing.Point(477, 180);
            this.tThrowItem.Name = "tThrowItem";
            this.tThrowItem.Size = new System.Drawing.Size(43, 13);
            this.tThrowItem.TabIndex = 56;
            this.tThrowItem.Text = "Throw: ";
            // 
            // tInv
            // 
            this.tInv.AutoSize = true;
            this.tInv.Location = new System.Drawing.Point(477, 200);
            this.tInv.Name = "tInv";
            this.tInv.Size = new System.Drawing.Size(57, 13);
            this.tInv.TabIndex = 57;
            this.tInv.Text = "Inventory: ";
            // 
            // tHeal
            // 
            this.tHeal.AutoSize = true;
            this.tHeal.Location = new System.Drawing.Point(477, 220);
            this.tHeal.Name = "tHeal";
            this.tHeal.Size = new System.Drawing.Size(35, 13);
            this.tHeal.TabIndex = 58;
            this.tHeal.Text = "Heal: ";
            // 
            // tMana
            // 
            this.tMana.AutoSize = true;
            this.tMana.Location = new System.Drawing.Point(477, 240);
            this.tMana.Name = "tMana";
            this.tMana.Size = new System.Drawing.Size(40, 13);
            this.tMana.TabIndex = 59;
            this.tMana.Text = "Mana: ";
            // 
            // tBuff
            // 
            this.tBuff.AutoSize = true;
            this.tBuff.Location = new System.Drawing.Point(477, 260);
            this.tBuff.Name = "tBuff";
            this.tBuff.Size = new System.Drawing.Size(32, 13);
            this.tBuff.TabIndex = 60;
            this.tBuff.Text = "Buff: ";
            // 
            // tSmart
            // 
            this.tSmart.AutoSize = true;
            this.tSmart.Location = new System.Drawing.Point(477, 440);
            this.tSmart.Name = "tSmart";
            this.tSmart.Size = new System.Drawing.Size(73, 13);
            this.tSmart.TabIndex = 68;
            this.tSmart.Text = "Smart Cursor: ";
            // 
            // tMapAlphaDown
            // 
            this.tMapAlphaDown.AutoSize = true;
            this.tMapAlphaDown.Location = new System.Drawing.Point(477, 420);
            this.tMapAlphaDown.Name = "tMapAlphaDown";
            this.tMapAlphaDown.Size = new System.Drawing.Size(70, 13);
            this.tMapAlphaDown.TabIndex = 67;
            this.tMapAlphaDown.Text = "Map Alpha -: ";
            // 
            // tMapAlphaUp
            // 
            this.tMapAlphaUp.AutoSize = true;
            this.tMapAlphaUp.Location = new System.Drawing.Point(477, 400);
            this.tMapAlphaUp.Name = "tMapAlphaUp";
            this.tMapAlphaUp.Size = new System.Drawing.Size(73, 13);
            this.tMapAlphaUp.TabIndex = 66;
            this.tMapAlphaUp.Text = "Map Alpha +: ";
            // 
            // tMapZoomOut
            // 
            this.tMapZoomOut.AutoSize = true;
            this.tMapZoomOut.Location = new System.Drawing.Point(477, 380);
            this.tMapZoomOut.Name = "tMapZoomOut";
            this.tMapZoomOut.Size = new System.Drawing.Size(84, 13);
            this.tMapZoomOut.TabIndex = 65;
            this.tMapZoomOut.Text = "Map Zoom Out: ";
            // 
            // tMapZoomIn
            // 
            this.tMapZoomIn.AutoSize = true;
            this.tMapZoomIn.Location = new System.Drawing.Point(477, 360);
            this.tMapZoomIn.Name = "tMapZoomIn";
            this.tMapZoomIn.Size = new System.Drawing.Size(76, 13);
            this.tMapZoomIn.TabIndex = 64;
            this.tMapZoomIn.Text = "Map Zoom In: ";
            // 
            // tMapFull
            // 
            this.tMapFull.AutoSize = true;
            this.tMapFull.Location = new System.Drawing.Point(477, 340);
            this.tMapFull.Name = "tMapFull";
            this.tMapFull.Size = new System.Drawing.Size(85, 13);
            this.tMapFull.TabIndex = 63;
            this.tMapFull.Text = "Map Fullscreen: ";
            // 
            // tMapStyle
            // 
            this.tMapStyle.AutoSize = true;
            this.tMapStyle.Location = new System.Drawing.Point(477, 320);
            this.tMapStyle.Name = "tMapStyle";
            this.tMapStyle.Size = new System.Drawing.Size(60, 13);
            this.tMapStyle.TabIndex = 62;
            this.tMapStyle.Text = "Map Style: ";
            // 
            // tTorch
            // 
            this.tTorch.AutoSize = true;
            this.tTorch.Location = new System.Drawing.Point(477, 300);
            this.tTorch.Name = "tTorch";
            this.tTorch.Size = new System.Drawing.Size(67, 13);
            this.tTorch.TabIndex = 61;
            this.tTorch.Text = "Torch/Tool: ";
            // 
            // tHook
            // 
            this.tHook.AutoSize = true;
            this.tHook.Location = new System.Drawing.Point(477, 280);
            this.tHook.Name = "tHook";
            this.tHook.Size = new System.Drawing.Size(39, 13);
            this.tHook.TabIndex = 69;
            this.tHook.Text = "Hook: ";
            // 
            // fParallax
            // 
            this.fParallax.LargeChange = 1;
            this.fParallax.Location = new System.Drawing.Point(135, 180);
            this.fParallax.Name = "fParallax";
            this.fParallax.Size = new System.Drawing.Size(200, 17);
            this.fParallax.TabIndex = 70;
            this.fParallax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fParallax_Scroll);
            // 
            // fSmartMode
            // 
            this.fSmartMode.FormattingEnabled = true;
            this.fSmartMode.Items.AddRange(new object[] {
            "Hold",
            "Toggle"});
            this.fSmartMode.Location = new System.Drawing.Point(138, 463);
            this.fSmartMode.Name = "fSmartMode";
            this.fSmartMode.Size = new System.Drawing.Size(121, 21);
            this.fSmartMode.TabIndex = 71;
            this.fSmartMode.SelectedIndexChanged += new System.EventHandler(this.fSmartMode_SelectedIndexChanged);
            // 
            // fLightingThreads
            // 
            this.fLightingThreads.FormattingEnabled = true;
            this.fLightingThreads.Items.AddRange(new object[] {
            "Off"});
            this.fLightingThreads.Location = new System.Drawing.Point(138, 443);
            this.fLightingThreads.Name = "fLightingThreads";
            this.fLightingThreads.Size = new System.Drawing.Size(48, 21);
            this.fLightingThreads.TabIndex = 72;
            this.fLightingThreads.SelectedIndexChanged += new System.EventHandler(this.fLightingThreads_SelectedIndexChanged);
            // 
            // ProcWarn
            // 
            this.ProcWarn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcWarn.AutoSize = true;
            this.ProcWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcWarn.ForeColor = System.Drawing.Color.Red;
            this.ProcWarn.Location = new System.Drawing.Point(156, 501);
            this.ProcWarn.Name = "ProcWarn";
            this.ProcWarn.Size = new System.Drawing.Size(296, 26);
            this.ProcWarn.TabIndex = 73;
            this.ProcWarn.Text = "Terraria is currently running.  Exit the game before saving, otherwise changes ma" +
    "de here will be lost.";
            this.ProcWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProcWarn.Visible = false;
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorInfo.AutoSize = true;
            this.AuthorInfo.ForeColor = System.Drawing.Color.Blue;
            this.AuthorInfo.Location = new System.Drawing.Point(3, 507);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.Size = new System.Drawing.Size(74, 13);
            this.AuthorInfo.TabIndex = 74;
            this.AuthorInfo.Text = "SBLogic 2015";
            this.AuthorInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tCFormBindingSource
            // 
            this.tCFormBindingSource.DataSource = typeof(TerraConf.TCForm);
            // 
            // TCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TCForm";
            this.Text = "TerraConf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tCFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tMouseGreen;
        private System.Windows.Forms.Label tMouseRed;
        private System.Windows.Forms.Label tMouseBlue;
        private System.Windows.Forms.Label tAudioMaster;
        private System.Windows.Forms.Label tAudioAmbient;
        private System.Windows.Forms.Label tAudioMusic;
        private System.Windows.Forms.Label tCaveParallax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox fCurRelease;
        private System.Windows.Forms.TextBox fCllientUUID;
        private System.Windows.Forms.CheckBox fFullScreen;
        private System.Windows.Forms.CheckBox fMaximized;
        private System.Windows.Forms.CheckBox fAutoSave;
        private System.Windows.Forms.CheckBox fAutoPause;
        private System.Windows.Forms.CheckBox fMapEnabled;
        private System.Windows.Forms.HScrollBar fMouseRed;
        private System.Windows.Forms.HScrollBar fMouseGreen;
        private System.Windows.Forms.HScrollBar fMouseBlue;
        private System.Windows.Forms.HScrollBar fAudioMaster;
        private System.Windows.Forms.HScrollBar fAudioAmbient;
        private System.Windows.Forms.HScrollBar fAudioMusic;
        private System.Windows.Forms.CheckBox fFrameSkip;
        private System.Windows.Forms.TextBox fXResolution;
        private System.Windows.Forms.TextBox fYResolution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox fItemText;
        private System.Windows.Forms.CheckBox fBackground;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.BindingSource tCFormBindingSource;
        private System.Windows.Forms.ComboBox fQuality;
        private System.Windows.Forms.ComboBox fLanguage;
        private System.Windows.Forms.ComboBox fLightingMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tUp;
        private System.Windows.Forms.Label tDown;
        private System.Windows.Forms.Label tLeft;
        private System.Windows.Forms.Label tRight;
        private System.Windows.Forms.Label tJump;
        private System.Windows.Forms.Label tThrowItem;
        private System.Windows.Forms.Label tInv;
        private System.Windows.Forms.Label tHeal;
        private System.Windows.Forms.Label tMana;
        private System.Windows.Forms.Label tBuff;
        private System.Windows.Forms.Label tSmart;
        private System.Windows.Forms.Label tMapAlphaDown;
        private System.Windows.Forms.Label tMapAlphaUp;
        private System.Windows.Forms.Label tMapZoomOut;
        private System.Windows.Forms.Label tMapZoomIn;
        private System.Windows.Forms.Label tMapFull;
        private System.Windows.Forms.Label tMapStyle;
        private System.Windows.Forms.Label tTorch;
        private System.Windows.Forms.Label tHook;
        private System.Windows.Forms.HScrollBar fParallax;
        private System.Windows.Forms.ComboBox fSmartMode;
        private System.Windows.Forms.ComboBox fLightingThreads;
        private System.Windows.Forms.Label ProcWarn;
        private System.Windows.Forms.Label AuthorInfo;

    }
}

