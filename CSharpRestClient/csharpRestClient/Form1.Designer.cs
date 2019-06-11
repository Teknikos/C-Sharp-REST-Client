namespace csharpRestClient
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
            this.txtRequestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNTLM = new System.Windows.Forms.RadioButton();
            this.rdoBasicAuth = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoNetCred = new System.Windows.Forms.RadioButton();
            this.rdoRollOwn = new System.Windows.Forms.RadioButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRequestURI
            // 
            this.txtRequestURI.Location = new System.Drawing.Point(216, 54);
            this.txtRequestURI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRequestURI.Name = "txtRequestURI";
            this.txtRequestURI.Size = new System.Drawing.Size(540, 26);
            this.txtRequestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(216, 353);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(679, 171);
            this.txtResponse.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(783, 54);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(112, 35);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(290, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(239, 26);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(656, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(239, 26);
            this.txtPassword.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNTLM);
            this.groupBox1.Controls.Add(this.rdoBasicAuth);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(216, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auth Type";
            // 
            // rdoNTLM
            // 
            this.rdoNTLM.AutoSize = true;
            this.rdoNTLM.Location = new System.Drawing.Point(16, 95);
            this.rdoNTLM.Name = "rdoNTLM";
            this.rdoNTLM.Size = new System.Drawing.Size(154, 24);
            this.rdoNTLM.TabIndex = 1;
            this.rdoNTLM.TabStop = true;
            this.rdoNTLM.Text = "NTLM (Windows)";
            this.rdoNTLM.UseVisualStyleBackColor = true;
            // 
            // rdoBasicAuth
            // 
            this.rdoBasicAuth.AutoSize = true;
            this.rdoBasicAuth.Checked = true;
            this.rdoBasicAuth.Location = new System.Drawing.Point(16, 44);
            this.rdoBasicAuth.Name = "rdoBasicAuth";
            this.rdoBasicAuth.Size = new System.Drawing.Size(180, 24);
            this.rdoBasicAuth.TabIndex = 0;
            this.rdoBasicAuth.TabStop = true;
            this.rdoBasicAuth.Text = "Basic Authentication";
            this.rdoBasicAuth.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNetCred);
            this.groupBox2.Controls.Add(this.rdoRollOwn);
            this.groupBox2.Location = new System.Drawing.Point(572, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Techique";
            // 
            // rdoNetCred
            // 
            this.rdoNetCred.AutoSize = true;
            this.rdoNetCred.Location = new System.Drawing.Point(30, 95);
            this.rdoNetCred.Name = "rdoNetCred";
            this.rdoNetCred.Size = new System.Drawing.Size(207, 24);
            this.rdoNetCred.TabIndex = 3;
            this.rdoNetCred.TabStop = true;
            this.rdoNetCred.Text = "NetworkCredential Class";
            this.rdoNetCred.UseVisualStyleBackColor = true;
            // 
            // rdoRollOwn
            // 
            this.rdoRollOwn.AutoSize = true;
            this.rdoRollOwn.Checked = true;
            this.rdoRollOwn.Location = new System.Drawing.Point(30, 44);
            this.rdoRollOwn.Name = "rdoRollOwn";
            this.rdoRollOwn.Size = new System.Drawing.Size(135, 24);
            this.rdoRollOwn.TabIndex = 2;
            this.rdoRollOwn.TabStop = true;
            this.rdoRollOwn.Text = "Roll Your Own";
            this.rdoRollOwn.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(568, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequestURI);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "authAPI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNTLM;
        private System.Windows.Forms.RadioButton rdoBasicAuth;
        private System.Windows.Forms.RadioButton rdoNetCred;
        private System.Windows.Forms.RadioButton rdoRollOwn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label3;
    }
}

