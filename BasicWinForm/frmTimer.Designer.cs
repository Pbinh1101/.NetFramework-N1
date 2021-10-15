
namespace BasicWinForm
{
    partial class frmTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.btnbatdau = new System.Windows.Forms.Button();
            this.btndung = new System.Windows.Forms.Button();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian (m)";
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(287, 70);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(120, 20);
            this.numTimer.TabIndex = 1;
            this.numTimer.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnbatdau
            // 
            this.btnbatdau.Location = new System.Drawing.Point(528, 57);
            this.btnbatdau.Name = "btnbatdau";
            this.btnbatdau.Size = new System.Drawing.Size(163, 23);
            this.btnbatdau.TabIndex = 2;
            this.btnbatdau.Text = "Bắt đầu ";
            this.btnbatdau.UseVisualStyleBackColor = true;
            this.btnbatdau.Click += new System.EventHandler(this.btnbatdau_Click);
            // 
            // btndung
            // 
            this.btndung.Location = new System.Drawing.Point(528, 104);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(163, 23);
            this.btndung.TabIndex = 3;
            this.btndung.Text = "Dừng";
            this.btndung.UseVisualStyleBackColor = true;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltimer.Location = new System.Drawing.Point(339, 199);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(162, 73);
            this.lbltimer.TabIndex = 4;
            this.lbltimer.Text = "1:30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.btndung);
            this.Controls.Add(this.btnbatdau);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.label1);
            this.Name = "frmTimer";
            this.Text = "frmTimer";
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Button btnbatdau;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer1;
    }
}