namespace пр_6._22
{
    partial class Form4
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelLoanAmount = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkCreditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.LightGreen;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar1.LargeChange = 1000;
            this.trackBar1.Location = new System.Drawing.Point(12, 61);
            this.trackBar1.Maximum = 1000000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(278, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelLoanAmount
            // 
            this.labelLoanAmount.AutoSize = true;
            this.labelLoanAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelLoanAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoanAmount.ForeColor = System.Drawing.Color.Indigo;
            this.labelLoanAmount.Location = new System.Drawing.Point(12, 23);
            this.labelLoanAmount.Name = "labelLoanAmount";
            this.labelLoanAmount.Size = new System.Drawing.Size(196, 21);
            this.labelLoanAmount.TabIndex = 1;
            this.labelLoanAmount.Text = "Выберите сумму займа";
            this.labelLoanAmount.Click += new System.EventHandler(this.labelLoanAmount_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.YellowGreen;
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(12, 112);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(119, 59);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Потдвердить сумму займа\r\n";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::пр_6._22.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(388, 61);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Уйти\r\n";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Баланс\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(274, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вы можете посмотреть баланс\r\n вашего аккаунта:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вы можете посмотреть \r\nВашу кредитную историю:\r\n\r\n";
            // 
            // checkCreditButton
            // 
            this.checkCreditButton.BackColor = System.Drawing.Color.YellowGreen;
            this.checkCreditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCreditButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCreditButton.Location = new System.Drawing.Point(47, 271);
            this.checkCreditButton.Name = "checkCreditButton";
            this.checkCreditButton.Size = new System.Drawing.Size(123, 53);
            this.checkCreditButton.TabIndex = 7;
            this.checkCreditButton.Text = "Кредитная \r\nистория";
            this.checkCreditButton.UseVisualStyleBackColor = false;
            this.checkCreditButton.Click += new System.EventHandler(this.checkCreditButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::пр_6._22.Properties.Resources._1676577933_catherineasquithgallery_com_p_gde_vzyat_zelenii_fon_159;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 348);
            this.ControlBox = false;
            this.Controls.Add(this.checkCreditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.labelLoanAmount);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelLoanAmount;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkCreditButton;
    }
}