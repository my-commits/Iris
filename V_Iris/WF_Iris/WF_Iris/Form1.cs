using System;
using System.Windows.Forms;

namespace WF_Iris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateFrame();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateFrame();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateFrame();
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            UpdateFrame();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            UpdateFrame();
        }
        void UpdateFrame()
        {
            float SL;
            float SW;
            float PL;
            float PW;

            SL = trackBar1.Value / 10f;
            SW = trackBar2.Value / 10f;
            PL = trackBar3.Value / 10f;
            PW = trackBar4.Value / 10f;

            lSL.Text = SL.ToString();
            lSW.Text = SW.ToString();
            lPL.Text = PL.ToString();
            lPW.Text = PW.ToString();

            MLClass mLClass = new MLClass();
            float[] probs = mLClass.Predict(new float[] { SL, SW, PL, PW });
            V1.Text = (probs[0]*100).ToString("F1") + "%";
            V2.Text = (probs[1]*100).ToString("F1") + "%";
            V3.Text = (probs[2]*100).ToString("F1") + "%";
        }
    }
}
