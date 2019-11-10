namespace RepairLog
{
    partial class Form_InputLog
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
            this.textBox_ItemRepaired = new System.Windows.Forms.TextBox();
            this.label_ItemRepaired = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Store = new System.Windows.Forms.Label();
            this.textBox_Store = new System.Windows.Forms.TextBox();
            this.label_Cost = new System.Windows.Forms.Label();
            this.textBox_Cost = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ItemRepaired
            // 
            this.textBox_ItemRepaired.Location = new System.Drawing.Point(133, 21);
            this.textBox_ItemRepaired.Multiline = true;
            this.textBox_ItemRepaired.Name = "textBox_ItemRepaired";
            this.textBox_ItemRepaired.Size = new System.Drawing.Size(241, 20);
            this.textBox_ItemRepaired.TabIndex = 0;
            // 
            // label_ItemRepaired
            // 
            this.label_ItemRepaired.AutoSize = true;
            this.label_ItemRepaired.Location = new System.Drawing.Point(24, 24);
            this.label_ItemRepaired.Name = "label_ItemRepaired";
            this.label_ItemRepaired.Size = new System.Drawing.Size(76, 13);
            this.label_ItemRepaired.TabIndex = 1;
            this.label_ItemRepaired.Text = "Item Repaired:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(24, 64);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(33, 13);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "Date:";
            // 
            // label_Store
            // 
            this.label_Store.AutoSize = true;
            this.label_Store.Location = new System.Drawing.Point(24, 141);
            this.label_Store.Name = "label_Store";
            this.label_Store.Size = new System.Drawing.Size(35, 13);
            this.label_Store.TabIndex = 7;
            this.label_Store.Text = "Store:";
            // 
            // textBox_Store
            // 
            this.textBox_Store.Location = new System.Drawing.Point(133, 138);
            this.textBox_Store.Name = "textBox_Store";
            this.textBox_Store.Size = new System.Drawing.Size(100, 20);
            this.textBox_Store.TabIndex = 3;
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.Location = new System.Drawing.Point(24, 101);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(31, 13);
            this.label_Cost.TabIndex = 5;
            this.label_Cost.Text = "Cost:";
            // 
            // textBox_Cost
            // 
            this.textBox_Cost.Location = new System.Drawing.Point(133, 98);
            this.textBox_Cost.Multiline = true;
            this.textBox_Cost.Name = "textBox_Cost";
            this.textBox_Cost.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cost.TabIndex = 2;
            this.textBox_Cost.Leave += new System.EventHandler(this.textBox_Cost_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(24, 179);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(63, 13);
            this.label_Description.TabIndex = 10;
            this.label_Description.Text = "Description:";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(136, 179);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(389, 180);
            this.textBox_Description.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(442, 387);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 27);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form_InputLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 544);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Store);
            this.Controls.Add(this.textBox_Store);
            this.Controls.Add(this.label_Cost);
            this.Controls.Add(this.textBox_Cost);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_ItemRepaired);
            this.Controls.Add(this.textBox_ItemRepaired);
            this.Name = "Form_InputLog";
            this.Text = "Home Repair Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ItemRepaired;
        private System.Windows.Forms.Label label_ItemRepaired;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Store;
        private System.Windows.Forms.TextBox textBox_Store;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.TextBox textBox_Cost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Button button_Save;
    }
}

