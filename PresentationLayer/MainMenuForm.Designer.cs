
namespace PresentationLayer
{
    partial class MainMenuForm
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
            this.BarOrder_Btn = new System.Windows.Forms.Button();
            this.Client_Btn = new System.Windows.Forms.Button();
            this.RestaurantOrder_Btn = new System.Windows.Forms.Button();
            this.RoomReservation_Btn = new System.Windows.Forms.Button();
            this.SpaSession_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarOrder_Btn
            // 
            this.BarOrder_Btn.Location = new System.Drawing.Point(46, 222);
            this.BarOrder_Btn.Name = "BarOrder_Btn";
            this.BarOrder_Btn.Size = new System.Drawing.Size(109, 23);
            this.BarOrder_Btn.TabIndex = 0;
            this.BarOrder_Btn.Text = "BarOrder";
            this.BarOrder_Btn.UseVisualStyleBackColor = true;
            this.BarOrder_Btn.Click += new System.EventHandler(this.BarOrder_Btn_Click);
            // 
            // Client_Btn
            // 
            this.Client_Btn.Location = new System.Drawing.Point(200, 222);
            this.Client_Btn.Name = "Client_Btn";
            this.Client_Btn.Size = new System.Drawing.Size(109, 23);
            this.Client_Btn.TabIndex = 1;
            this.Client_Btn.Text = "Client";
            this.Client_Btn.UseVisualStyleBackColor = true;
            this.Client_Btn.Click += new System.EventHandler(this.Client_Btn_Click);
            // 
            // RestaurantOrder_Btn
            // 
            this.RestaurantOrder_Btn.Location = new System.Drawing.Point(353, 222);
            this.RestaurantOrder_Btn.Name = "RestaurantOrder_Btn";
            this.RestaurantOrder_Btn.Size = new System.Drawing.Size(109, 23);
            this.RestaurantOrder_Btn.TabIndex = 2;
            this.RestaurantOrder_Btn.Text = "RestaurantOrder";
            this.RestaurantOrder_Btn.UseVisualStyleBackColor = true;
            this.RestaurantOrder_Btn.Click += new System.EventHandler(this.RestaurantOrder_Btn_Click);
            // 
            // RoomReservation_Btn
            // 
            this.RoomReservation_Btn.Location = new System.Drawing.Point(484, 222);
            this.RoomReservation_Btn.Name = "RoomReservation_Btn";
            this.RoomReservation_Btn.Size = new System.Drawing.Size(109, 23);
            this.RoomReservation_Btn.TabIndex = 3;
            this.RoomReservation_Btn.Text = "RoomReservation";
            this.RoomReservation_Btn.UseVisualStyleBackColor = true;
            this.RoomReservation_Btn.Click += new System.EventHandler(this.RoomReservation_Btn_Click);
            // 
            // SpaSession_Btn
            // 
            this.SpaSession_Btn.Location = new System.Drawing.Point(622, 222);
            this.SpaSession_Btn.Name = "SpaSession_Btn";
            this.SpaSession_Btn.Size = new System.Drawing.Size(109, 23);
            this.SpaSession_Btn.TabIndex = 4;
            this.SpaSession_Btn.Text = "SpaSession";
            this.SpaSession_Btn.UseVisualStyleBackColor = true;
            this.SpaSession_Btn.Click += new System.EventHandler(this.SpaSession_Btn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpaSession_Btn);
            this.Controls.Add(this.RoomReservation_Btn);
            this.Controls.Add(this.RestaurantOrder_Btn);
            this.Controls.Add(this.Client_Btn);
            this.Controls.Add(this.BarOrder_Btn);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BarOrder_Btn;
        private System.Windows.Forms.Button Client_Btn;
        private System.Windows.Forms.Button RestaurantOrder_Btn;
        private System.Windows.Forms.Button RoomReservation_Btn;
        private System.Windows.Forms.Button SpaSession_Btn;
    }
}

