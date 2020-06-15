namespace file_project_final_2
{
    partial class equalForm
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
            this.columetextBox = new System.Windows.Forms.TextBox();
            this.finishbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputnumtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "condition 1";
            // 
            // columetextBox
            // 
            this.columetextBox.Location = new System.Drawing.Point(15, 45);
            this.columetextBox.Name = "columetextBox";
            this.columetextBox.Size = new System.Drawing.Size(100, 20);
            this.columetextBox.TabIndex = 1;
            // 
            // finishbutton
            // 
            this.finishbutton.Location = new System.Drawing.Point(122, 205);
            this.finishbutton.Name = "finishbutton";
            this.finishbutton.Size = new System.Drawing.Size(75, 23);
            this.finishbutton.TabIndex = 2;
            this.finishbutton.Text = "finish";
            this.finishbutton.UseVisualStyleBackColor = true;
            this.finishbutton.Click += new System.EventHandler(this.finishbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "your number";
            // 
            // inputnumtextBox
            // 
            this.inputnumtextBox.Location = new System.Drawing.Point(15, 100);
            this.inputnumtextBox.Name = "inputnumtextBox";
            this.inputnumtextBox.Size = new System.Drawing.Size(100, 20);
            this.inputnumtextBox.TabIndex = 4;
            this.inputnumtextBox.TextChanged += new System.EventHandler(this.inputnumtextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(133, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "OR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "condition 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "your number";
            // 
            // equalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputnumtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finishbutton);
            this.Controls.Add(this.columetextBox);
            this.Controls.Add(this.label1);
            this.Name = "equalForm";
            this.Text = "equalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox columetextBox;
        private System.Windows.Forms.Button finishbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputnumtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}