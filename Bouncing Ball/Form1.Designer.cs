namespace Bouncing_Ball
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
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.ChkBoxGravity = new System.Windows.Forms.CheckBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TBoxBallQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Enabled = true;
            this.TimerRefresh.Interval = 24;
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // ChkBoxGravity
            // 
            this.ChkBoxGravity.AutoSize = true;
            this.ChkBoxGravity.Location = new System.Drawing.Point(87, 12);
            this.ChkBoxGravity.Name = "ChkBoxGravity";
            this.ChkBoxGravity.Size = new System.Drawing.Size(81, 17);
            this.ChkBoxGravity.TabIndex = 0;
            this.ChkBoxGravity.Text = "Add Gravity";
            this.ChkBoxGravity.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(6, 8);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // TBoxBallQty
            // 
            this.TBoxBallQty.Location = new System.Drawing.Point(6, 37);
            this.TBoxBallQty.Name = "TBoxBallQty";
            this.TBoxBallQty.Size = new System.Drawing.Size(32, 20);
            this.TBoxBallQty.TabIndex = 2;
            this.TBoxBallQty.Text = "10";
            this.TBoxBallQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity of balls (100 Max)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBoxBallQty);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.ChkBoxGravity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bouncing Balls";
            this.ClientSizeChanged += new System.EventHandler(this.Form1_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerRefresh;
        private System.Windows.Forms.CheckBox ChkBoxGravity;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TBoxBallQty;
        private System.Windows.Forms.Label label1;
    }
}

