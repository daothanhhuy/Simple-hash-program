
namespace HashProgram
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
            this.SelectInputCB = new System.Windows.Forms.ComboBox();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.md5OutputTb = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.md5Cb = new System.Windows.Forms.CheckBox();
            this.sha1Cb = new System.Windows.Forms.CheckBox();
            this.sha1OutputTb = new System.Windows.Forms.TextBox();
            this.sha2Cb = new System.Windows.Forms.CheckBox();
            this.sha2OutputTb = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectInputCB
            // 
            this.SelectInputCB.FormattingEnabled = true;
            this.SelectInputCB.Items.AddRange(new object[] {
            "Text String",
            "Hex String",
            "Binary File"});
            this.SelectInputCB.Location = new System.Drawing.Point(12, 12);
            this.SelectInputCB.Name = "SelectInputCB";
            this.SelectInputCB.Size = new System.Drawing.Size(79, 23);
            this.SelectInputCB.TabIndex = 0;
            this.SelectInputCB.SelectedIndexChanged += new System.EventHandler(this.SelectInputCB_SelectedIndexChanged);
            // 
            // InputTB
            // 
            this.InputTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTB.Location = new System.Drawing.Point(97, 12);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(876, 23);
            this.InputTB.TabIndex = 2;
            this.InputTB.TextChanged += new System.EventHandler(this.InputTB_TextChanged);
            // 
            // md5OutputTb
            // 
            this.md5OutputTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md5OutputTb.Location = new System.Drawing.Point(97, 65);
            this.md5OutputTb.Name = "md5OutputTb";
            this.md5OutputTb.Size = new System.Drawing.Size(876, 23);
            this.md5OutputTb.TabIndex = 3;
            this.md5OutputTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // convertBtn
            // 
            this.convertBtn.Location = new System.Drawing.Point(899, 186);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(75, 23);
            this.convertBtn.TabIndex = 4;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // md5Cb
            // 
            this.md5Cb.AutoSize = true;
            this.md5Cb.Location = new System.Drawing.Point(20, 69);
            this.md5Cb.Name = "md5Cb";
            this.md5Cb.Size = new System.Drawing.Size(56, 19);
            this.md5Cb.TabIndex = 16;
            this.md5Cb.Text = "MD-5";
            this.md5Cb.UseVisualStyleBackColor = true;
            // 
            // sha1Cb
            // 
            this.sha1Cb.AutoSize = true;
            this.sha1Cb.Location = new System.Drawing.Point(20, 110);
            this.sha1Cb.Name = "sha1Cb";
            this.sha1Cb.Size = new System.Drawing.Size(60, 19);
            this.sha1Cb.TabIndex = 17;
            this.sha1Cb.Text = "SHA-1";
            this.sha1Cb.UseVisualStyleBackColor = true;
            // 
            // sha1OutputTb
            // 
            this.sha1OutputTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha1OutputTb.Location = new System.Drawing.Point(97, 106);
            this.sha1OutputTb.Name = "sha1OutputTb";
            this.sha1OutputTb.Size = new System.Drawing.Size(876, 23);
            this.sha1OutputTb.TabIndex = 18;
            // 
            // sha2Cb
            // 
            this.sha2Cb.AutoSize = true;
            this.sha2Cb.Location = new System.Drawing.Point(20, 151);
            this.sha2Cb.Name = "sha2Cb";
            this.sha2Cb.Size = new System.Drawing.Size(72, 19);
            this.sha2Cb.TabIndex = 19;
            this.sha2Cb.Text = "SHA-256";
            this.sha2Cb.UseVisualStyleBackColor = true;
            // 
            // sha2OutputTb
            // 
            this.sha2OutputTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha2OutputTb.Location = new System.Drawing.Point(98, 147);
            this.sha2OutputTb.Name = "sha2OutputTb";
            this.sha2OutputTb.Size = new System.Drawing.Size(876, 23);
            this.sha2OutputTb.TabIndex = 20;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(818, 186);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 21;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 224);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.sha2OutputTb);
            this.Controls.Add(this.sha2Cb);
            this.Controls.Add(this.sha1OutputTb);
            this.Controls.Add(this.sha1Cb);
            this.Controls.Add(this.md5Cb);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.md5OutputTb);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.SelectInputCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectInputCB;
        private System.Windows.Forms.TextBox InputTB;
        private System.Windows.Forms.TextBox md5OutputTb;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textToStoreTb;
        private System.Windows.Forms.TextBox binaryMd5Tb;
        private System.Windows.Forms.CheckBox md5Cb;
        private System.Windows.Forms.CheckBox sha1Cb;
        private System.Windows.Forms.TextBox sha1OutputTb;
        private System.Windows.Forms.CheckBox sha2Cb;
        private System.Windows.Forms.TextBox sha2OutputTb;
        private System.Windows.Forms.Button clearBtn;
    }
}

