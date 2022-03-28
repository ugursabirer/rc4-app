
namespace RC4_App
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
            this.keyArea = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.plaintextArea = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.encrypt = new MetroFramework.Controls.MetroButton();
            this.decrypt = new MetroFramework.Controls.MetroButton();
            this.ciphertextArea = new MetroFramework.Controls.MetroTextBox();
            this.maintextArea = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // keyArea
            // 
            this.keyArea.Location = new System.Drawing.Point(275, 100);
            this.keyArea.Multiline = true;
            this.keyArea.Name = "keyArea";
            this.keyArea.Size = new System.Drawing.Size(200, 25);
            this.keyArea.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(360, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(29, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Key";
            // 
            // plaintextArea
            // 
            this.plaintextArea.Location = new System.Drawing.Point(125, 175);
            this.plaintextArea.Multiline = true;
            this.plaintextArea.Name = "plaintextArea";
            this.plaintextArea.Size = new System.Drawing.Size(500, 100);
            this.plaintextArea.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(345, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Plaintext";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(125, 300);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(245, 25);
            this.encrypt.TabIndex = 4;
            this.encrypt.Text = "Encrypt";
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(380, 300);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(245, 25);
            this.decrypt.TabIndex = 5;
            this.decrypt.Text = "Decrypt";
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // ciphertextArea
            // 
            this.ciphertextArea.Location = new System.Drawing.Point(125, 375);
            this.ciphertextArea.Multiline = true;
            this.ciphertextArea.Name = "ciphertextArea";
            this.ciphertextArea.ReadOnly = true;
            this.ciphertextArea.Size = new System.Drawing.Size(245, 100);
            this.ciphertextArea.TabIndex = 6;
            // 
            // maintextArea
            // 
            this.maintextArea.Location = new System.Drawing.Point(380, 375);
            this.maintextArea.Multiline = true;
            this.maintextArea.Name = "maintextArea";
            this.maintextArea.ReadOnly = true;
            this.maintextArea.Size = new System.Drawing.Size(245, 100);
            this.maintextArea.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(125, 350);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Ciphertext";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(555, 350);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Plaintext";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.maintextArea);
            this.Controls.Add(this.ciphertextArea);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.plaintextArea);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.keyArea);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RC4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox keyArea;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox plaintextArea;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton encrypt;
        private MetroFramework.Controls.MetroButton decrypt;
        private MetroFramework.Controls.MetroTextBox ciphertextArea;
        private MetroFramework.Controls.MetroTextBox maintextArea;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

