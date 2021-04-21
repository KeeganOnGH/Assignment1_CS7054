
namespace WinFormsApp1
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
            this.Mealbtn = new System.Windows.Forms.Button();
            this.Drinkbtn = new System.Windows.Forms.Button();
            this.Sidebtn = new System.Windows.Forms.Button();
            this.Meal_txtbx = new System.Windows.Forms.TextBox();
            this.Drink_txtbx = new System.Windows.Forms.TextBox();
            this.Side_txtbx = new System.Windows.Forms.TextBox();
            this.ListofOrders = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.Menubtn = new System.Windows.Forms.Button();
            this.Sign_in_btn = new System.Windows.Forms.Button();
            this.Deliverybtn = new System.Windows.Forms.Button();
            this.Pickup_btn = new System.Windows.Forms.Button();
            this.PayNow_btn = new System.Windows.Forms.Button();
            this.TotalPrice_lbl = new System.Windows.Forms.Label();
            this.TotalPrice_txtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Mealbtn
            // 
            this.Mealbtn.Location = new System.Drawing.Point(492, 74);
            this.Mealbtn.Name = "Mealbtn";
            this.Mealbtn.Size = new System.Drawing.Size(75, 23);
            this.Mealbtn.TabIndex = 0;
            this.Mealbtn.Text = "Meal";
            this.Mealbtn.UseVisualStyleBackColor = true;
            // 
            // Drinkbtn
            // 
            this.Drinkbtn.Location = new System.Drawing.Point(492, 133);
            this.Drinkbtn.Name = "Drinkbtn";
            this.Drinkbtn.Size = new System.Drawing.Size(75, 23);
            this.Drinkbtn.TabIndex = 1;
            this.Drinkbtn.Text = "Drink";
            this.Drinkbtn.UseVisualStyleBackColor = true;
            // 
            // Sidebtn
            // 
            this.Sidebtn.Location = new System.Drawing.Point(492, 198);
            this.Sidebtn.Name = "Sidebtn";
            this.Sidebtn.Size = new System.Drawing.Size(75, 23);
            this.Sidebtn.TabIndex = 2;
            this.Sidebtn.Text = "Side";
            this.Sidebtn.UseVisualStyleBackColor = true;
            // 
            // Meal_txtbx
            // 
            this.Meal_txtbx.Location = new System.Drawing.Point(313, 74);
            this.Meal_txtbx.Name = "Meal_txtbx";
            this.Meal_txtbx.Size = new System.Drawing.Size(173, 23);
            this.Meal_txtbx.TabIndex = 3;
            // 
            // Drink_txtbx
            // 
            this.Drink_txtbx.Location = new System.Drawing.Point(313, 134);
            this.Drink_txtbx.Name = "Drink_txtbx";
            this.Drink_txtbx.Size = new System.Drawing.Size(173, 23);
            this.Drink_txtbx.TabIndex = 4;
            // 
            // Side_txtbx
            // 
            this.Side_txtbx.Location = new System.Drawing.Point(313, 199);
            this.Side_txtbx.Name = "Side_txtbx";
            this.Side_txtbx.Size = new System.Drawing.Size(173, 23);
            this.Side_txtbx.TabIndex = 5;
            // 
            // ListofOrders
            // 
            this.ListofOrders.FormattingEnabled = true;
            this.ListofOrders.ItemHeight = 15;
            this.ListofOrders.Location = new System.Drawing.Point(12, 74);
            this.ListofOrders.Name = "ListofOrders";
            this.ListofOrders.Size = new System.Drawing.Size(276, 244);
            this.ListofOrders.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(212, 30);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Meal-To-Go-App";
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(359, 29);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(71, 29);
            this.Menubtn.TabIndex = 8;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            // 
            // Sign_in_btn
            // 
            this.Sign_in_btn.Location = new System.Drawing.Point(696, 18);
            this.Sign_in_btn.Name = "Sign_in_btn";
            this.Sign_in_btn.Size = new System.Drawing.Size(79, 35);
            this.Sign_in_btn.TabIndex = 9;
            this.Sign_in_btn.Text = "Sign-in";
            this.Sign_in_btn.UseVisualStyleBackColor = true;
            // 
            // Deliverybtn
            // 
            this.Deliverybtn.Location = new System.Drawing.Point(207, 324);
            this.Deliverybtn.Name = "Deliverybtn";
            this.Deliverybtn.Size = new System.Drawing.Size(81, 31);
            this.Deliverybtn.TabIndex = 10;
            this.Deliverybtn.Text = "Delivery";
            this.Deliverybtn.UseVisualStyleBackColor = true;
            // 
            // Pickup_btn
            // 
            this.Pickup_btn.Location = new System.Drawing.Point(120, 324);
            this.Pickup_btn.Name = "Pickup_btn";
            this.Pickup_btn.Size = new System.Drawing.Size(81, 31);
            this.Pickup_btn.TabIndex = 11;
            this.Pickup_btn.Text = "Pick-up";
            this.Pickup_btn.UseVisualStyleBackColor = true;
            // 
            // PayNow_btn
            // 
            this.PayNow_btn.Location = new System.Drawing.Point(673, 411);
            this.PayNow_btn.Name = "PayNow_btn";
            this.PayNow_btn.Size = new System.Drawing.Size(102, 27);
            this.PayNow_btn.TabIndex = 12;
            this.PayNow_btn.Text = "Pay Now";
            this.PayNow_btn.UseVisualStyleBackColor = true;
            // 
            // TotalPrice_lbl
            // 
            this.TotalPrice_lbl.AutoSize = true;
            this.TotalPrice_lbl.Location = new System.Drawing.Point(606, 386);
            this.TotalPrice_lbl.Name = "TotalPrice_lbl";
            this.TotalPrice_lbl.Size = new System.Drawing.Size(61, 15);
            this.TotalPrice_lbl.TabIndex = 13;
            this.TotalPrice_lbl.Text = "Total Price";
            // 
            // TotalPrice_txtbx
            // 
            this.TotalPrice_txtbx.Location = new System.Drawing.Point(673, 383);
            this.TotalPrice_txtbx.Name = "TotalPrice_txtbx";
            this.TotalPrice_txtbx.Size = new System.Drawing.Size(102, 23);
            this.TotalPrice_txtbx.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.T3AppPho;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalPrice_txtbx);
            this.Controls.Add(this.TotalPrice_lbl);
            this.Controls.Add(this.PayNow_btn);
            this.Controls.Add(this.Pickup_btn);
            this.Controls.Add(this.Deliverybtn);
            this.Controls.Add(this.Sign_in_btn);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ListofOrders);
            this.Controls.Add(this.Side_txtbx);
            this.Controls.Add(this.Drink_txtbx);
            this.Controls.Add(this.Meal_txtbx);
            this.Controls.Add(this.Sidebtn);
            this.Controls.Add(this.Drinkbtn);
            this.Controls.Add(this.Mealbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mealbtn;
        private System.Windows.Forms.Button Drinkbtn;
        private System.Windows.Forms.Button Sidebtn;
        private System.Windows.Forms.TextBox Meal_txtbx;
        private System.Windows.Forms.TextBox Drink_txtbx;
        private System.Windows.Forms.TextBox Side_txtbx;
        private System.Windows.Forms.ListBox ListofOrders;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button Sign_in_btn;
        private System.Windows.Forms.Button Deliverybtn;
        private System.Windows.Forms.Button Pickup_btn;
        private System.Windows.Forms.Button PayNow_btn;
        private System.Windows.Forms.Label TotalPrice_lbl;
        private System.Windows.Forms.TextBox TotalPrice_txtbx;
    }
}

