namespace Plugins
{
    partial class PluginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pass Spacing (mm)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Overspray (mm)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spray Speed (mm/m)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Repeats";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Generate G-Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Generate G-Code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Nanoslic G-Code";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginForm_FormClosing);
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public double x_value, y_value, z_value;
        private SprayParameters parameters;

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;


    }
}

// Deleted button code
/*// 
// jogXplusbutton
// 
this.jogXplusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogXplusbutton.Location = new System.Drawing.Point(255, 20);
this.jogXplusbutton.Name = "jogXplusbutton";
this.jogXplusbutton.Size = new System.Drawing.Size(40, 30);
this.jogXplusbutton.TabIndex = 6;
this.jogXplusbutton.Text = "X+";
this.jogXplusbutton.UseVisualStyleBackColor = true;
this.jogXplusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogXplusbutton_MouseDown);
this.jogXplusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogXplusbutton_MouseUp);
// 
// jogXminusbutton
// 
this.jogXminusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogXminusbutton.Location = new System.Drawing.Point(209, 20);
this.jogXminusbutton.Name = "jogXminusbutton";
this.jogXminusbutton.Size = new System.Drawing.Size(40, 30);
this.jogXminusbutton.TabIndex = 7;
this.jogXminusbutton.Text = "X-";
this.jogXminusbutton.UseVisualStyleBackColor = true;
this.jogXminusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogXminusbutton_MouseDown);
this.jogXminusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogXminusbutton_MouseUp);
// 
// jogYminusbutton
// 
this.jogYminusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogYminusbutton.Location = new System.Drawing.Point(209, 56);
this.jogYminusbutton.Name = "jogYminusbutton";
this.jogYminusbutton.Size = new System.Drawing.Size(40, 30);
this.jogYminusbutton.TabIndex = 8;
this.jogYminusbutton.Text = "Y-";
this.jogYminusbutton.UseVisualStyleBackColor = true;
this.jogYminusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogYminusbutton_MouseDown);
this.jogYminusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogYminusbutton_MouseUp);
// 
// jogZminusbutton
// 
this.jogZminusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogZminusbutton.Location = new System.Drawing.Point(209, 92);
this.jogZminusbutton.Name = "jogZminusbutton";
this.jogZminusbutton.Size = new System.Drawing.Size(40, 30);
this.jogZminusbutton.TabIndex = 9;
this.jogZminusbutton.Text = "Z-";
this.jogZminusbutton.UseVisualStyleBackColor = true;
this.jogZminusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogZminusbutton_MouseDown);
this.jogZminusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogZminusbutton_MouseUp);
// 
// jogAminusbutton
// 
this.jogAminusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogAminusbutton.Location = new System.Drawing.Point(209, 128);
this.jogAminusbutton.Name = "jogAminusbutton";
this.jogAminusbutton.Size = new System.Drawing.Size(40, 30);
this.jogAminusbutton.TabIndex = 10;
this.jogAminusbutton.Text = "A-";
this.jogAminusbutton.UseVisualStyleBackColor = true;
this.jogAminusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogAminusbutton_MouseDown);
this.jogAminusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogAminusbutton_MouseUp);
// 
// jogYplusbutton
// 
this.jogYplusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogYplusbutton.Location = new System.Drawing.Point(255, 56);
this.jogYplusbutton.Name = "jogYplusbutton";
this.jogYplusbutton.Size = new System.Drawing.Size(40, 30);
this.jogYplusbutton.TabIndex = 11;
this.jogYplusbutton.Text = "Y+";
this.jogYplusbutton.UseVisualStyleBackColor = true;
this.jogYplusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogYplusbutton_MouseDown);
this.jogYplusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogYplusbutton_MouseUp);
// 
// jogZplusbutton
// 
this.jogZplusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogZplusbutton.Location = new System.Drawing.Point(255, 92);
this.jogZplusbutton.Name = "jogZplusbutton";
this.jogZplusbutton.Size = new System.Drawing.Size(40, 30);
this.jogZplusbutton.TabIndex = 12;
this.jogZplusbutton.Text = "Z+";
this.jogZplusbutton.UseVisualStyleBackColor = true;
this.jogZplusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogZplusbutton_MouseDown);
this.jogZplusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogZplusbutton_MouseUp);
// 
// jogAplusbutton
// 
this.jogAplusbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
this.jogAplusbutton.Location = new System.Drawing.Point(255, 128);
this.jogAplusbutton.Name = "jogAplusbutton";
this.jogAplusbutton.Size = new System.Drawing.Size(40, 30);
this.jogAplusbutton.TabIndex = 13;
this.jogAplusbutton.Text = "A+";
this.jogAplusbutton.UseVisualStyleBackColor = true;
this.jogAplusbutton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jogAplusbutton_MouseDown);
this.jogAplusbutton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jogAplusbutton_MouseUp);*/