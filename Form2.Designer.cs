namespace it482_Unit2_Michael_Peck
{
    partial class Form2
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
            this.radEmployee = new System.Windows.Forms.RadioButton();
            this.radOrders = new System.Windows.Forms.RadioButton();
            this.radCustomers = new System.Windows.Forms.RadioButton();
            this.btnCount_Click = new System.Windows.Forms.Button();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdate_Click = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnView_Click = new System.Windows.Forms.Button();
            this.txtMessageText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radEmployee
            // 
            this.radEmployee.AutoSize = true;
            this.radEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmployee.Location = new System.Drawing.Point(159, 370);
            this.radEmployee.Name = "radEmployee";
            this.radEmployee.Size = new System.Drawing.Size(167, 26);
            this.radEmployee.TabIndex = 47;
            this.radEmployee.TabStop = true;
            this.radEmployee.Text = "Employees Table";
            this.radEmployee.UseVisualStyleBackColor = true;
            // 
            // radOrders
            // 
            this.radOrders.AutoSize = true;
            this.radOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrders.Location = new System.Drawing.Point(159, 338);
            this.radOrders.Name = "radOrders";
            this.radOrders.Size = new System.Drawing.Size(134, 26);
            this.radOrders.TabIndex = 46;
            this.radOrders.TabStop = true;
            this.radOrders.Text = "Orders Table";
            this.radOrders.UseVisualStyleBackColor = true;
            // 
            // radCustomers
            // 
            this.radCustomers.AutoSize = true;
            this.radCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCustomers.Location = new System.Drawing.Point(159, 306);
            this.radCustomers.Name = "radCustomers";
            this.radCustomers.Size = new System.Drawing.Size(165, 26);
            this.radCustomers.TabIndex = 45;
            this.radCustomers.TabStop = true;
            this.radCustomers.Text = "Customers Table";
            this.radCustomers.UseVisualStyleBackColor = true;
            // 
            // btnCount_Click
            // 
            this.btnCount_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount_Click.Location = new System.Drawing.Point(789, 284);
            this.btnCount_Click.Name = "btnCount_Click";
            this.btnCount_Click.Size = new System.Drawing.Size(159, 41);
            this.btnCount_Click.TabIndex = 44;
            this.btnCount_Click.Text = "Count Records";
            this.btnCount_Click.UseVisualStyleBackColor = true;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(6, 63);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(147, 24);
            this.CompanyNameLabel.TabIndex = 43;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(126, 18);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 24);
            this.IdLabel.TabIndex = 42;
            this.IdLabel.Text = "ID";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(159, 60);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(181, 29);
            this.txtCompanyName.TabIndex = 41;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(159, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(181, 29);
            this.txtID.TabIndex = 40;
            // 
            // btnUpdate_Click
            // 
            this.btnUpdate_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_Click.Location = new System.Drawing.Point(159, 111);
            this.btnUpdate_Click.Name = "btnUpdate_Click";
            this.btnUpdate_Click.Size = new System.Drawing.Size(181, 45);
            this.btnUpdate_Click.TabIndex = 39;
            this.btnUpdate_Click.Text = "Update Database";
            this.btnUpdate_Click.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 186);
            this.dataGridView1.TabIndex = 38;
            // 
            // btnView_Click
            // 
            this.btnView_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView_Click.Location = new System.Drawing.Point(466, 620);
            this.btnView_Click.Name = "btnView_Click";
            this.btnView_Click.Size = new System.Drawing.Size(191, 51);
            this.btnView_Click.TabIndex = 37;
            this.btnView_Click.Text = "View Database";
            this.btnView_Click.UseVisualStyleBackColor = true;
            // 
            // txtMessageText
            // 
            this.txtMessageText.Location = new System.Drawing.Point(623, 13);
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.Size = new System.Drawing.Size(447, 247);
            this.txtMessageText.TabIndex = 36;
            this.txtMessageText.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 737);
            this.Controls.Add(this.radEmployee);
            this.Controls.Add(this.radOrders);
            this.Controls.Add(this.radCustomers);
            this.Controls.Add(this.btnCount_Click);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate_Click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnView_Click);
            this.Controls.Add(this.txtMessageText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radEmployee;
        private System.Windows.Forms.RadioButton radOrders;
        private System.Windows.Forms.RadioButton radCustomers;
        private System.Windows.Forms.Button btnCount_Click;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdate_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView_Click;
        private System.Windows.Forms.RichTextBox txtMessageText;
    }
}