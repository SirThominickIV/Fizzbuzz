namespace Fizzbuzz_Snyder
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
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Next100 = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // rtb_Output
            // 
            this.rtb_Output.Location = new System.Drawing.Point(64, 24);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.Size = new System.Drawing.Size(219, 385);
            this.rtb_Output.TabIndex = 0;
            this.rtb_Output.Text = "";
            this.rtb_Output.TextChanged += new System.EventHandler(this.rtb_Output_TextChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(49, 436);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Next100
            // 
            this.btn_Next100.Location = new System.Drawing.Point(130, 436);
            this.btn_Next100.Name = "btn_Next100";
            this.btn_Next100.Size = new System.Drawing.Size(75, 23);
            this.btn_Next100.TabIndex = 2;
            this.btn_Next100.Text = "Next 100";
            this.btn_Next100.UseVisualStyleBackColor = true;
            this.btn_Next100.Click += new System.EventHandler(this.btn_Next100_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(211, 436);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(244, 485);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What is Fizz buzz?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 507);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Next100);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.rtb_Output);
            this.Name = "Form1";
            this.Text = "Fizz buzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Next100;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

