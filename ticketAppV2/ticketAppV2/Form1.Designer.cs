namespace ticketAppV2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpeedInput = new System.Windows.Forms.TextBox();
            this.txtFastLimitInput = new System.Windows.Forms.TextBox();
            this.rtbFineOutput = new System.Windows.Forms.RichTextBox();
            this.btnInterfaceCalc = new System.Windows.Forms.Button();
            this.btnDelegateCalc = new System.Windows.Forms.Button();
            this.btnLamdaBool = new System.Windows.Forms.Button();
            this.btnLamdaCalc = new System.Windows.Forms.Button();
            this.btnValidateID = new System.Windows.Forms.Button();
            this.txtIDInput = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed Limit:";
            // 
            // txtSpeedInput
            // 
            this.txtSpeedInput.Location = new System.Drawing.Point(97, 27);
            this.txtSpeedInput.Name = "txtSpeedInput";
            this.txtSpeedInput.Size = new System.Drawing.Size(74, 20);
            this.txtSpeedInput.TabIndex = 2;
            // 
            // txtFastLimitInput
            // 
            this.txtFastLimitInput.Location = new System.Drawing.Point(97, 58);
            this.txtFastLimitInput.Name = "txtFastLimitInput";
            this.txtFastLimitInput.Size = new System.Drawing.Size(74, 20);
            this.txtFastLimitInput.TabIndex = 3;
            // 
            // rtbFineOutput
            // 
            this.rtbFineOutput.Location = new System.Drawing.Point(192, 27);
            this.rtbFineOutput.Name = "rtbFineOutput";
            this.rtbFineOutput.Size = new System.Drawing.Size(147, 192);
            this.rtbFineOutput.TabIndex = 4;
            this.rtbFineOutput.Text = "";
            // 
            // btnInterfaceCalc
            // 
            this.btnInterfaceCalc.Location = new System.Drawing.Point(15, 139);
            this.btnInterfaceCalc.Name = "btnInterfaceCalc";
            this.btnInterfaceCalc.Size = new System.Drawing.Size(75, 23);
            this.btnInterfaceCalc.TabIndex = 5;
            this.btnInterfaceCalc.Text = "Interface";
            this.btnInterfaceCalc.UseVisualStyleBackColor = true;
            this.btnInterfaceCalc.Click += new System.EventHandler(this.BtnInterfaceCalc_Click);
            // 
            // btnDelegateCalc
            // 
            this.btnDelegateCalc.Location = new System.Drawing.Point(97, 139);
            this.btnDelegateCalc.Name = "btnDelegateCalc";
            this.btnDelegateCalc.Size = new System.Drawing.Size(75, 23);
            this.btnDelegateCalc.TabIndex = 6;
            this.btnDelegateCalc.Text = "Delegate";
            this.btnDelegateCalc.UseVisualStyleBackColor = true;
            this.btnDelegateCalc.Click += new System.EventHandler(this.BtnDelegateCalc_Click);
            // 
            // btnLamdaBool
            // 
            this.btnLamdaBool.Location = new System.Drawing.Point(12, 168);
            this.btnLamdaBool.Name = "btnLamdaBool";
            this.btnLamdaBool.Size = new System.Drawing.Size(75, 23);
            this.btnLamdaBool.TabIndex = 7;
            this.btnLamdaBool.Text = "btnLamdaTF";
            this.btnLamdaBool.UseVisualStyleBackColor = true;
            this.btnLamdaBool.Click += new System.EventHandler(this.BtnLamdaBool_Click);
            // 
            // btnLamdaCalc
            // 
            this.btnLamdaCalc.Location = new System.Drawing.Point(97, 168);
            this.btnLamdaCalc.Name = "btnLamdaCalc";
            this.btnLamdaCalc.Size = new System.Drawing.Size(75, 23);
            this.btnLamdaCalc.TabIndex = 8;
            this.btnLamdaCalc.Text = "Lamda Fine";
            this.btnLamdaCalc.UseVisualStyleBackColor = true;
            this.btnLamdaCalc.Click += new System.EventHandler(this.BtnLamdaCalc_Click);
            // 
            // btnValidateID
            // 
            this.btnValidateID.Location = new System.Drawing.Point(15, 198);
            this.btnValidateID.Name = "btnValidateID";
            this.btnValidateID.Size = new System.Drawing.Size(75, 23);
            this.btnValidateID.TabIndex = 9;
            this.btnValidateID.Text = "Validate ID";
            this.btnValidateID.UseVisualStyleBackColor = true;
            this.btnValidateID.Click += new System.EventHandler(this.btnValidateID_Click);
            // 
            // txtIDInput
            // 
            this.txtIDInput.Location = new System.Drawing.Point(97, 97);
            this.txtIDInput.Mask = "##55#";
            this.txtIDInput.Name = "txtIDInput";
            this.txtIDInput.Size = new System.Drawing.Size(75, 20);
            this.txtIDInput.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDInput);
            this.Controls.Add(this.btnValidateID);
            this.Controls.Add(this.btnLamdaCalc);
            this.Controls.Add(this.btnLamdaBool);
            this.Controls.Add(this.btnDelegateCalc);
            this.Controls.Add(this.btnInterfaceCalc);
            this.Controls.Add(this.rtbFineOutput);
            this.Controls.Add(this.txtFastLimitInput);
            this.Controls.Add(this.txtSpeedInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpeedInput;
        private System.Windows.Forms.TextBox txtFastLimitInput;
        private System.Windows.Forms.RichTextBox rtbFineOutput;
        private System.Windows.Forms.Button btnInterfaceCalc;
        private System.Windows.Forms.Button btnDelegateCalc;
        private System.Windows.Forms.Button btnLamdaBool;
        private System.Windows.Forms.Button btnLamdaCalc;
        private System.Windows.Forms.Button btnValidateID;
        private System.Windows.Forms.MaskedTextBox txtIDInput;
        private System.Windows.Forms.Label label3;
    }
}

