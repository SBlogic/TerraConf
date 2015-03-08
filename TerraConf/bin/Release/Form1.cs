using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraConf
{
    public partial class TCForm : Form
    {
        public TCForm()
        {
            InitializeComponent();

            if (Environment.ProcessorCount > 1)
            {
                for (int i = 2; i <= Environment.ProcessorCount; i++)
                {
                    this.fLightingThreads.Items.Add(i.ToString());
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Program.IsGameRunning())
                this.ProcWarn.Visible = true;

            // Initialize text fields
            this.fCurRelease.Text = Program.curRelease.ToString();
            this.fCllientUUID.Text = Program.clientUUID;
            this.fXResolution.Text = Program.PreferredBackBufferWidth.ToString();
            this.fYResolution.Text = Program.PreferredBackBufferHeight.ToString();

            // Initialize check fields
            this.fFullScreen.Checked = Program.IsFullScreen;
            this.fFrameSkip.Checked = !Program.fixedTiming;
            this.fMaximized.Checked = Program.screenMaximized;
            this.fAutoSave.Checked = Program.autoSave;
            this.fAutoPause.Checked = Program.autoPause;
            this.fItemText.Checked = Program.showItemText;
            this.fBackground.Checked = Program.owBack;
            this.fMapEnabled.Checked = Program.mapEnabled;

            // Initialize list selectors
            this.fQuality.SelectedIndex = Program.qaStyle;
            this.fLanguage.SelectedIndex = Program.lang - 1;
            this.fLightingMode.SelectedIndex = Program.lightMode;
            this.fSmartMode.SelectedIndex = (Program.SmartToggle ? 1 : 0);
            this.fLightingThreads.SelectedIndex = Program.LightingThreads;

            // Initialize sliders
            tMouseRed.Text = "Mouse - Red [" + Program.mouseColor_R.ToString() + "]";
            fMouseRed.Value = Program.mouseColor_R;
            tMouseGreen.Text = "Mouse - Green [" + Program.mouseColor_G.ToString() + "]";
            fMouseGreen.Value = Program.mouseColor_G;
            tMouseBlue.Text = "Mouse - Blue [" + Program.mouseColor_B.ToString() + "]";
            fMouseBlue.Value = Program.mouseColor_B;

            tAudioMaster.Text = "Sound - Master [" + ((int)(Program.soundVolume * 100f)).ToString() + "]";
            fAudioMaster.Value = (int) (Program.soundVolume*100f);
            tAudioAmbient.Text = "Sound - Ambient [" + ((int)(Program.ambientVolume * 100f)).ToString() + "]";
            fAudioAmbient.Value = (int)(Program.ambientVolume * 100f);
            tAudioMusic.Text = "Sound - Music [" + ((int)(Program.musicVolume * 100f)).ToString() + "]";
            fAudioMusic.Value = (int)(Program.musicVolume * 100f);

            tCaveParallax.Text = "Parallax [" + ((int)(-(Program.caveParallax - 1.0) * 500.0)).ToString() + "]";
            fParallax.Value = (int)(-(Program.caveParallax - 1.0) * 500.0);

            // Display key bindings
            tUp.Text = tUp.Text + Program.cUp;
            tDown.Text = tDown.Text + Program.cDown;
            tLeft.Text = tLeft.Text + Program.cLeft;
            tRight.Text = tRight.Text + Program.cRight;
            tJump.Text = tJump.Text + Program.cJump;
            tThrowItem.Text = tThrowItem.Text + Program.cThrowItem;
            tInv.Text = tInv.Text + Program.cInv;
            tHeal.Text = tHeal.Text + Program.cHeal;
            tMana.Text = tMana.Text + Program.cMana;
            tBuff.Text = tBuff.Text + Program.cBuff;
            tHook.Text = tHook.Text + Program.cHook;
            tTorch.Text = tTorch.Text + Program.cTorch;
            tMapStyle.Text = tMapStyle.Text + Program.cMapStyle;
            tMapFull.Text = tMapFull.Text + Program.cMapFull;
            tMapZoomIn.Text = tMapZoomIn.Text + Program.cMapZoomIn;
            tMapZoomOut.Text = tMapZoomOut.Text + Program.cMapZoomOut;
            tMapAlphaUp.Text = tMapAlphaUp.Text + Program.cMapAlphaUp;
            tMapAlphaDown.Text = tMapAlphaDown.Text + Program.cMapAlphaDown;
            tSmart.Text = tSmart.Text + Program.cSmart;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fMouseRed_Scroll(object sender, ScrollEventArgs e)
        {
            tMouseRed.Text = "Mouse - Red [" + e.NewValue.ToString() + "]";
            Program.mouseColor_R = (byte)e.NewValue;
        }

        private void fMouseGreen_Scroll(object sender, ScrollEventArgs e)
        {
            tMouseGreen.Text = "Mouse - Green [" + e.NewValue.ToString() + "]";
            Program.mouseColor_G = (byte)e.NewValue;
        }

        private void fMouseBlue_Scroll(object sender, ScrollEventArgs e)
        {
            tMouseBlue.Text = "Mouse - Blue [" + e.NewValue.ToString() + "]";
            Program.mouseColor_B = (byte)e.NewValue;
        }

        private void fFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            Program.IsFullScreen = ((CheckBox)sender).Checked;
        }

        private void fAudioMaster_Scroll(object sender, ScrollEventArgs e)
        {
            tAudioMaster.Text = "Sound - Master [" + e.NewValue.ToString() +"]";
            Program.soundVolume = ((float)e.NewValue) / 100;
        }

        private void fAudioAmbient_Scroll(object sender, ScrollEventArgs e)
        {
            tAudioAmbient.Text = "Sound - Ambient [" + e.NewValue.ToString() + "]";
            Program.ambientVolume = ((float)e.NewValue) / 100;
        }

        private void fAudioMusic_Scroll(object sender, ScrollEventArgs e)
        {
            tAudioMusic.Text = "Sound - Music [" + e.NewValue.ToString() + "]";
            Program.musicVolume = ((float)e.NewValue) / 100;
        }

        private void fParallax_Scroll(object sender, ScrollEventArgs e)
        {
            tCaveParallax.Text = "Parallax [" + e.NewValue.ToString() + "]";
            Program.caveParallax = (float)1.0 - (float)e.NewValue / (float)500.0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SaveConfig();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.qaStyle = (byte)((ComboBox)sender).SelectedIndex;
        }

        private void fLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.lang = (byte)(((ComboBox)sender).SelectedIndex + 1);
        }

        private void fLightingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.lightMode = (byte)((ComboBox)sender).SelectedIndex;
        }

        private void fFrameSkip_CheckedChanged(object sender, EventArgs e)
        {
            Program.fixedTiming = !((CheckBox)sender).Checked;
        }

        private void fMaximized_CheckedChanged(object sender, EventArgs e)
        {
            Program.screenMaximized = ((CheckBox)sender).Checked;
        }

        private void fLightingThreads_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.LightingThreads = ((ComboBox)sender).SelectedIndex;
        }

        private void fXResolution_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int t = Convert.ToInt32(((TextBox)sender).Text);
                Program.PreferredBackBufferWidth = t;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please provide a valid number for screen width.");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Somehow I doubt your screen is that large.");
            }
        }

        private void fYResolution_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int t = Convert.ToInt32(((TextBox)sender).Text);
                Program.PreferredBackBufferHeight = t;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please provide a valid number for screen height.");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Somehow I doubt your screen is that large.");
            }

        }

        private void fAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            Program.autoSave = ((CheckBox)sender).Checked;
        }

        private void fAutoPause_CheckedChanged(object sender, EventArgs e)
        {
            Program.autoPause = ((CheckBox)sender).Checked;

        }

        private void fItemText_CheckedChanged(object sender, EventArgs e)
        {
            Program.showItemText = ((CheckBox)sender).Checked;
        }

        private void fBackground_CheckedChanged(object sender, EventArgs e)
        {
            Program.owBack = ((CheckBox)sender).Checked;
        }

        private void fMapEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Program.mapEnabled = ((CheckBox)sender).Checked;
        }

        private void fSmartMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SmartToggle = ((ComboBox)sender).SelectedIndex == 0 ? false : true;
        }
    
    }
}