
namespace PresentationLayer
{
    partial class BarOrderForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.Read_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OrderDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TotalPrice";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Create_Btn
            // 
            this.Create_Btn.Location = new System.Drawing.Point(52, 199);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(75, 23);
            this.Create_Btn.TabIndex = 5;
            this.Create_Btn.Text = "Create";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Location = new System.Drawing.Point(53, 237);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(75, 23);
            this.Read_Btn.TabIndex = 6;
            this.Read_Btn.Text = "Read";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Location = new System.Drawing.Point(52, 276);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(75, 23);
            this.Update_Btn.TabIndex = 7;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(52, 315);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_Btn.TabIndex = 8;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // BarOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.Read_Btn);
            this.Controls.Add(this.Create_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BarOrderForm";
            this.Text = "BarOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.Button Read_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Delete_Btn;
    }
}