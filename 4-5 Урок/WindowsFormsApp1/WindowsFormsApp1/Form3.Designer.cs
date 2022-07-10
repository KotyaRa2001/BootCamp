namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblShowResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirst.Location = new System.Drawing.Point(21, 51);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(140, 24);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первое число:";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSecond.Location = new System.Drawing.Point(21, 148);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(133, 24);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Второе число";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(46, 371);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(108, 24);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Результат:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(217, 56);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 3;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirst_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirst_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(217, 148);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 4;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirst_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirst_KeyPress);
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIncrement.FlatAppearance.BorderSize = 0;
            this.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrement.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrement.Location = new System.Drawing.Point(25, 216);
            this.btnIncrement.Margin = new System.Windows.Forms.Padding(0);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(80, 80);
            this.btnIncrement.TabIndex = 6;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDecrement.FlatAppearance.BorderSize = 0;
            this.btnDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrement.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrement.Location = new System.Drawing.Point(111, 216);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(80, 80);
            this.btnDecrement.TabIndex = 7;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = false;
            this.btnDecrement.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIncrease.FlatAppearance.BorderSize = 0;
            this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrease.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIncrease.Location = new System.Drawing.Point(197, 216);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(80, 80);
            this.btnIncrease.TabIndex = 8;
            this.btnIncrease.Text = "*";
            this.btnIncrease.UseVisualStyleBackColor = false;
            this.btnIncrease.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(283, 216);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 80);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = ":";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(144, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 46);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblShowResult
            // 
            this.lblShowResult.AutoSize = true;
            this.lblShowResult.BackColor = System.Drawing.Color.Transparent;
            this.lblShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowResult.Location = new System.Drawing.Point(178, 360);
            this.lblShowResult.Name = "lblShowResult";
            this.lblShowResult.Size = new System.Drawing.Size(50, 53);
            this.lblShowResult.TabIndex = 11;
            this.lblShowResult.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.lblShowResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Простой калькултор";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblShowResult;
    }
}