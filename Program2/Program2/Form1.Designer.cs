namespace Program2
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.freshmanBtn = new System.Windows.Forms.RadioButton();
            this.sophomoreBtn = new System.Windows.Forms.RadioButton();
            this.juniorBtn = new System.Windows.Forms.RadioButton();
            this.seniorBtn = new System.Windows.Forms.RadioButton();
            this.submitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(78, 33);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(119, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Enter Last Name Letter:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(204, 30);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // freshmanBtn
            // 
            this.freshmanBtn.AutoSize = true;
            this.freshmanBtn.Location = new System.Drawing.Point(81, 185);
            this.freshmanBtn.Name = "freshmanBtn";
            this.freshmanBtn.Size = new System.Drawing.Size(71, 17);
            this.freshmanBtn.TabIndex = 2;
            this.freshmanBtn.TabStop = true;
            this.freshmanBtn.Text = "Freshman";
            this.freshmanBtn.UseVisualStyleBackColor = true;
            // 
            // sophomoreBtn
            // 
            this.sophomoreBtn.AutoSize = true;
            this.sophomoreBtn.Location = new System.Drawing.Point(81, 147);
            this.sophomoreBtn.Name = "sophomoreBtn";
            this.sophomoreBtn.Size = new System.Drawing.Size(79, 17);
            this.sophomoreBtn.TabIndex = 3;
            this.sophomoreBtn.TabStop = true;
            this.sophomoreBtn.Text = "Sophomore";
            this.sophomoreBtn.UseVisualStyleBackColor = true;
            // 
            // juniorBtn
            // 
            this.juniorBtn.AutoSize = true;
            this.juniorBtn.Location = new System.Drawing.Point(81, 107);
            this.juniorBtn.Name = "juniorBtn";
            this.juniorBtn.Size = new System.Drawing.Size(53, 17);
            this.juniorBtn.TabIndex = 4;
            this.juniorBtn.TabStop = true;
            this.juniorBtn.Text = "Junior";
            this.juniorBtn.UseVisualStyleBackColor = true;
            // 
            // seniorBtn
            // 
            this.seniorBtn.AutoSize = true;
            this.seniorBtn.Checked = true;
            this.seniorBtn.Location = new System.Drawing.Point(81, 71);
            this.seniorBtn.Name = "seniorBtn";
            this.seniorBtn.Size = new System.Drawing.Size(55, 17);
            this.seniorBtn.TabIndex = 5;
            this.seniorBtn.TabStop = true;
            this.seniorBtn.Text = "Senior";
            this.seniorBtn.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(108, 229);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetBtn.Location = new System.Drawing.Point(274, 229);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetBtn;
            this.ClientSize = new System.Drawing.Size(427, 314);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.seniorBtn);
            this.Controls.Add(this.juniorBtn);
            this.Controls.Add(this.sophomoreBtn);
            this.Controls.Add(this.freshmanBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.RadioButton freshmanBtn;
        private System.Windows.Forms.RadioButton sophomoreBtn;
        private System.Windows.Forms.RadioButton juniorBtn;
        private System.Windows.Forms.RadioButton seniorBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

