namespace Lab04_Q1
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
            this.lblinput1 = new System.Windows.Forms.Label();
            this.lblinput2 = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsubscription = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.lblmultiplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinput1
            // 
            this.lblinput1.AutoSize = true;
            this.lblinput1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput1.Location = new System.Drawing.Point(228, 96);
            this.lblinput1.Name = "lblinput1";
            this.lblinput1.Size = new System.Drawing.Size(84, 27);
            this.lblinput1.TabIndex = 0;
            this.lblinput1.Text = "Input 1";
            // 
            // lblinput2
            // 
            this.lblinput2.AutoSize = true;
            this.lblinput2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput2.Location = new System.Drawing.Point(228, 164);
            this.lblinput2.Name = "lblinput2";
            this.lblinput2.Size = new System.Drawing.Size(84, 27);
            this.lblinput2.TabIndex = 1;
            this.lblinput2.Text = "Input 2";
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsum.Location = new System.Drawing.Point(293, 311);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(142, 40);
            this.lblsum.TabIndex = 2;
            this.lblsum.Text = "Result =";
            this.lblsum.Click += new System.EventHandler(this.lblsum_Click);
            // 
            // txtinput1
            // 
            this.txtinput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput1.Location = new System.Drawing.Point(374, 93);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(247, 30);
            this.txtinput1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(374, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 30);
            this.textBox2.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(187, 235);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(67, 41);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsubscription
            // 
            this.btnsubscription.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubscription.Location = new System.Drawing.Point(318, 235);
            this.btnsubscription.Name = "btnsubscription";
            this.btnsubscription.Size = new System.Drawing.Size(67, 41);
            this.btnsubscription.TabIndex = 6;
            this.btnsubscription.Text = "-";
            this.btnsubscription.UseVisualStyleBackColor = true;
            this.btnsubscription.Click += new System.EventHandler(this.btnsubscription_Click);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(447, 235);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(67, 41);
            this.btndivision.TabIndex = 7;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // lblmultiplication
            // 
            this.lblmultiplication.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmultiplication.Location = new System.Drawing.Point(572, 235);
            this.lblmultiplication.Name = "lblmultiplication";
            this.lblmultiplication.Size = new System.Drawing.Size(67, 41);
            this.lblmultiplication.TabIndex = 8;
            this.lblmultiplication.Text = "*";
            this.lblmultiplication.UseVisualStyleBackColor = true;
            this.lblmultiplication.Click += new System.EventHandler(this.lblmultiplication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmultiplication);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnsubscription);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.lblinput2);
            this.Controls.Add(this.lblinput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput1;
        private System.Windows.Forms.Label lblinput2;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsubscription;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button lblmultiplication;
    }
}

