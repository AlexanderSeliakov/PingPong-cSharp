namespace ping
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
            this.paddleL = new System.Windows.Forms.PictureBox();
            this.paddleR = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreR = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paddleL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // paddleL
            // 
            this.paddleL.Image = ((System.Drawing.Image)(resources.GetObject("paddleL.Image")));
            this.paddleL.Location = new System.Drawing.Point(35, 197);
            this.paddleL.Name = "paddleL";
            this.paddleL.Size = new System.Drawing.Size(11, 256);
            this.paddleL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paddleL.TabIndex = 0;
            this.paddleL.TabStop = false;
            // 
            // paddleR
            // 
            this.paddleR.Image = ((System.Drawing.Image)(resources.GetObject("paddleR.Image")));
            this.paddleR.Location = new System.Drawing.Point(1308, 197);
            this.paddleR.Name = "paddleR";
            this.paddleR.Size = new System.Drawing.Size(10, 256);
            this.paddleR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paddleR.TabIndex = 1;
            this.paddleR.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ball);
            this.groupBox1.Controls.Add(this.paddleL);
            this.groupBox1.Controls.Add(this.paddleR);
            this.groupBox1.Location = new System.Drawing.Point(0, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1372, 716);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(656, 265);
            this.ball.Margin = new System.Windows.Forms.Padding(0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(18, 20);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(558, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 85);
            this.label1.TabIndex = 3;
            this.label1.Text = "SCORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreL
            // 
            this.scoreL.AutoSize = true;
            this.scoreL.Font = new System.Drawing.Font("Segoe Print", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreL.Location = new System.Drawing.Point(555, 94);
            this.scoreL.Margin = new System.Windows.Forms.Padding(0);
            this.scoreL.Name = "scoreL";
            this.scoreL.Size = new System.Drawing.Size(88, 104);
            this.scoreL.TabIndex = 4;
            this.scoreL.Text = "0";
            this.scoreL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(627, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 104);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreR
            // 
            this.scoreR.AutoSize = true;
            this.scoreR.Font = new System.Drawing.Font("Segoe Print", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreR.Location = new System.Drawing.Point(679, 94);
            this.scoreR.Margin = new System.Windows.Forms.Padding(0);
            this.scoreR.Name = "scoreR";
            this.scoreR.Size = new System.Drawing.Size(88, 104);
            this.scoreR.TabIndex = 6;
            this.scoreR.Text = "0";
            this.scoreR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1374, 929);
            this.Controls.Add(this.scoreR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Up);
            ((System.ComponentModel.ISupportInitialize)(this.paddleL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddleL;
        private System.Windows.Forms.PictureBox paddleR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scoreR;
        private System.Windows.Forms.Timer timer1;
    }
}

