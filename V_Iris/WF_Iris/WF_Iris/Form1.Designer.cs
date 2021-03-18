
namespace WF_Iris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.lPW = new System.Windows.Forms.Label();
            this.lPL = new System.Windows.Forms.Label();
            this.lSW = new System.Windows.Forms.Label();
            this.lSL = new System.Windows.Forms.Label();
            this.V1 = new System.Windows.Forms.Label();
            this.V2 = new System.Windows.Forms.Label();
            this.V3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "sepal length in cm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "sepal width in cm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "petal length in cm";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(125, 9);
            this.trackBar1.Maximum = 79;
            this.trackBar1.Minimum = 43;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(100, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 43;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "petal width in cm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 10;
            this.trackBar2.Location = new System.Drawing.Point(125, 60);
            this.trackBar2.Maximum = 44;
            this.trackBar2.Minimum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(100, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Value = 20;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(125, 111);
            this.trackBar3.Maximum = 69;
            this.trackBar3.Minimum = 10;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(100, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Value = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.LargeChange = 10;
            this.trackBar4.Location = new System.Drawing.Point(125, 162);
            this.trackBar4.Maximum = 25;
            this.trackBar4.Minimum = 1;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(100, 45);
            this.trackBar4.TabIndex = 7;
            this.trackBar4.Value = 1;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // lPW
            // 
            this.lPW.AutoSize = true;
            this.lPW.Location = new System.Drawing.Point(231, 162);
            this.lPW.Name = "lPW";
            this.lPW.Size = new System.Drawing.Size(40, 15);
            this.lPW.TabIndex = 11;
            this.lPW.Text = "label5";
            this.lPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lPL
            // 
            this.lPL.AutoSize = true;
            this.lPL.Location = new System.Drawing.Point(231, 111);
            this.lPL.Name = "lPL";
            this.lPL.Size = new System.Drawing.Size(40, 15);
            this.lPL.TabIndex = 10;
            this.lPL.Text = "label6";
            this.lPL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSW
            // 
            this.lSW.AutoSize = true;
            this.lSW.Location = new System.Drawing.Point(231, 60);
            this.lSW.Name = "lSW";
            this.lSW.Size = new System.Drawing.Size(40, 15);
            this.lSW.TabIndex = 9;
            this.lSW.Text = "label7";
            this.lSW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSL
            // 
            this.lSL.AutoSize = true;
            this.lSL.Location = new System.Drawing.Point(231, 9);
            this.lSL.Name = "lSL";
            this.lSL.Size = new System.Drawing.Size(40, 15);
            this.lSL.TabIndex = 8;
            this.lSL.Text = "label8";
            this.lSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // V1
            // 
            this.V1.AutoSize = true;
            this.V1.Location = new System.Drawing.Point(12, 192);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(31, 15);
            this.V1.TabIndex = 12;
            this.V1.Text = "50%";
            // 
            // V2
            // 
            this.V2.AutoSize = true;
            this.V2.Location = new System.Drawing.Point(125, 192);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(31, 15);
            this.V2.TabIndex = 13;
            this.V2.Text = "50%";
            // 
            // V3
            // 
            this.V3.AutoSize = true;
            this.V3.Location = new System.Drawing.Point(240, 192);
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(31, 15);
            this.V3.TabIndex = 14;
            this.V3.Text = "50%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Iris Virginica";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Iris Versicolour";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Iris Setosa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 252);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.V3);
            this.Controls.Add(this.V2);
            this.Controls.Add(this.V1);
            this.Controls.Add(this.lPW);
            this.Controls.Add(this.lPL);
            this.Controls.Add(this.lSW);
            this.Controls.Add(this.lSL);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label lPW;
        private System.Windows.Forms.Label lPL;
        private System.Windows.Forms.Label lSW;
        private System.Windows.Forms.Label lSL;
        private System.Windows.Forms.Label V1;
        private System.Windows.Forms.Label V2;
        private System.Windows.Forms.Label V3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

