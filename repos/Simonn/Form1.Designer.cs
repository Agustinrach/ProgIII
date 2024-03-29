
namespace Simonn
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
            this.components = new System.ComponentModel.Container();
            this.p_0 = new System.Windows.Forms.Button();
            this.p_1 = new System.Windows.Forms.Button();
            this.p_2 = new System.Windows.Forms.Button();
            this.p_3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p_0
            // 
            this.p_0.BackColor = System.Drawing.Color.Lime;
            this.p_0.Location = new System.Drawing.Point(120, 55);
            this.p_0.Name = "p_0";
            this.p_0.Size = new System.Drawing.Size(224, 124);
            this.p_0.TabIndex = 0;
            this.p_0.Text = " ";
            this.p_0.UseVisualStyleBackColor = false;
            this.p_0.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.Yellow;
            this.p_1.Location = new System.Drawing.Point(120, 204);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(224, 133);
            this.p_1.TabIndex = 1;
            this.p_1.Text = " ";
            this.p_1.UseVisualStyleBackColor = false;
            this.p_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.Blue;
            this.p_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.p_2.Location = new System.Drawing.Point(377, 55);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(230, 124);
            this.p_2.TabIndex = 2;
            this.p_2.Text = " ";
            this.p_2.UseVisualStyleBackColor = false;
            this.p_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Red;
            this.p_3.Location = new System.Drawing.Point(377, 204);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(230, 133);
            this.p_3.TabIndex = 3;
            this.p_3.Text = " ";
            this.p_3.UseVisualStyleBackColor = false;
            this.p_3.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(487, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "INICIAR JUEGO";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.p_0);
            this.Name = "Form1";
            this.Text = "SIMON DICE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p_0;
        private System.Windows.Forms.Button p_1;
        private System.Windows.Forms.Button p_2;
        private System.Windows.Forms.Button p_3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

