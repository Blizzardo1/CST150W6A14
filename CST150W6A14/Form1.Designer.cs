
namespace CST150W6A14
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
            this.label1 = new System.Windows.Forms.Label();
            this.shapeLstBx = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outlineBtn = new System.Windows.Forms.RadioButton();
            this.fillRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateChk = new System.Windows.Forms.CheckBox();
            this.nameChk = new System.Windows.Forms.CheckBox();
            this.canvasPnl = new System.Windows.Forms.Panel();
            this.drawBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dateFormatGrp = new System.Windows.Forms.GroupBox();
            this.shortDateRbtn = new System.Windows.Forms.RadioButton();
            this.longDateRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dateFormatGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a shape";
            // 
            // shapeLstBx
            // 
            this.shapeLstBx.FormattingEnabled = true;
            this.shapeLstBx.ItemHeight = 15;
            this.shapeLstBx.Location = new System.Drawing.Point(12, 44);
            this.shapeLstBx.Name = "shapeLstBx";
            this.shapeLstBx.Size = new System.Drawing.Size(135, 124);
            this.shapeLstBx.TabIndex = 1;
            this.shapeLstBx.SelectedIndexChanged += new System.EventHandler(this.shapeLstBx_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outlineBtn);
            this.groupBox1.Controls.Add(this.fillRbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select fill mode";
            // 
            // outlineBtn
            // 
            this.outlineBtn.AutoSize = true;
            this.outlineBtn.Location = new System.Drawing.Point(15, 56);
            this.outlineBtn.Name = "outlineBtn";
            this.outlineBtn.Size = new System.Drawing.Size(64, 19);
            this.outlineBtn.TabIndex = 0;
            this.outlineBtn.TabStop = true;
            this.outlineBtn.Text = "Outline";
            this.outlineBtn.UseVisualStyleBackColor = true;
            // 
            // fillRbtn
            // 
            this.fillRbtn.AutoSize = true;
            this.fillRbtn.Location = new System.Drawing.Point(15, 31);
            this.fillRbtn.Name = "fillRbtn";
            this.fillRbtn.Size = new System.Drawing.Size(40, 19);
            this.fillRbtn.TabIndex = 0;
            this.fillRbtn.TabStop = true;
            this.fillRbtn.Text = "Fill";
            this.fillRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateChk);
            this.groupBox2.Controls.Add(this.nameChk);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select details";
            // 
            // dateChk
            // 
            this.dateChk.AutoSize = true;
            this.dateChk.Location = new System.Drawing.Point(15, 56);
            this.dateChk.Name = "dateChk";
            this.dateChk.Size = new System.Drawing.Size(50, 19);
            this.dateChk.TabIndex = 0;
            this.dateChk.Text = "Date";
            this.dateChk.UseVisualStyleBackColor = true;
            this.dateChk.CheckedChanged += new System.EventHandler(this.dateChk_CheckedChanged);
            // 
            // nameChk
            // 
            this.nameChk.AutoSize = true;
            this.nameChk.Location = new System.Drawing.Point(14, 31);
            this.nameChk.Name = "nameChk";
            this.nameChk.Size = new System.Drawing.Size(58, 19);
            this.nameChk.TabIndex = 0;
            this.nameChk.Text = "Name";
            this.nameChk.UseVisualStyleBackColor = true;
            // 
            // canvasPnl
            // 
            this.canvasPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPnl.Location = new System.Drawing.Point(364, 26);
            this.canvasPnl.Name = "canvasPnl";
            this.canvasPnl.Size = new System.Drawing.Size(430, 345);
            this.canvasPnl.TabIndex = 4;
            // 
            // drawBtn
            // 
            this.drawBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawBtn.Location = new System.Drawing.Point(638, 388);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(75, 23);
            this.drawBtn.TabIndex = 5;
            this.drawBtn.Text = "&Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(719, 388);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dateFormatGrp
            // 
            this.dateFormatGrp.Controls.Add(this.shortDateRbtn);
            this.dateFormatGrp.Controls.Add(this.longDateRbtn);
            this.dateFormatGrp.Location = new System.Drawing.Point(153, 310);
            this.dateFormatGrp.Name = "dateFormatGrp";
            this.dateFormatGrp.Size = new System.Drawing.Size(110, 112);
            this.dateFormatGrp.TabIndex = 7;
            this.dateFormatGrp.TabStop = false;
            this.dateFormatGrp.Text = "Date Format";
            // 
            // shortDateRbtn
            // 
            this.shortDateRbtn.AutoSize = true;
            this.shortDateRbtn.Location = new System.Drawing.Point(9, 53);
            this.shortDateRbtn.Name = "shortDateRbtn";
            this.shortDateRbtn.Size = new System.Drawing.Size(53, 19);
            this.shortDateRbtn.TabIndex = 1;
            this.shortDateRbtn.TabStop = true;
            this.shortDateRbtn.Text = "Short";
            this.shortDateRbtn.UseVisualStyleBackColor = true;
            // 
            // longDateRbtn
            // 
            this.longDateRbtn.AutoSize = true;
            this.longDateRbtn.Location = new System.Drawing.Point(10, 31);
            this.longDateRbtn.Name = "longDateRbtn";
            this.longDateRbtn.Size = new System.Drawing.Size(52, 19);
            this.longDateRbtn.TabIndex = 0;
            this.longDateRbtn.TabStop = true;
            this.longDateRbtn.Text = "Long";
            this.longDateRbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.drawBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 430);
            this.Controls.Add(this.dateFormatGrp);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.canvasPnl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeLstBx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shape Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dateFormatGrp.ResumeLayout(false);
            this.dateFormatGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox shapeLstBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton outlineBtn;
        private System.Windows.Forms.RadioButton fillRbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox dateChk;
        private System.Windows.Forms.CheckBox nameChk;
        private System.Windows.Forms.Panel canvasPnl;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox dateFormatGrp;
        private System.Windows.Forms.RadioButton shortDateRbtn;
        private System.Windows.Forms.RadioButton longDateRbtn;
    }
}

