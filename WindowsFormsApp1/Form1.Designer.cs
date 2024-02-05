
namespace WindowsFormsApp1
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtArchive = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblArchive = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(384, 91);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(424, 486);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(105, 36);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "ARCHIVE";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(729, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(371, 196);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(371, 157);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(371, 242);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 22);
            this.txtDelete.TabIndex = 6;
            // 
            // txtArchive
            // 
            this.txtArchive.Location = new System.Drawing.Point(371, 292);
            this.txtArchive.Name = "txtArchive";
            this.txtArchive.Size = new System.Drawing.Size(100, 22);
            this.txtArchive.TabIndex = 7;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(371, 332);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 22);
            this.txtPath.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(293, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 17);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "FROM";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(173, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 17);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total No. of Files";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(173, 196);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(120, 17);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Total Size of Files";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(173, 247);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(168, 17);
            this.lblDelete.TabIndex = 12;
            this.lblDelete.Text = "Total No. of Files Deleted";
            // 
            // lblArchive
            // 
            this.lblArchive.AutoSize = true;
            this.lblArchive.Location = new System.Drawing.Point(173, 292);
            this.lblArchive.Name = "lblArchive";
            this.lblArchive.Size = new System.Drawing.Size(174, 17);
            this.lblArchive.TabIndex = 13;
            this.lblArchive.Text = "Total No. of Files Archived";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(173, 337);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(145, 17);
            this.lblPath.TabIndex = 14;
            this.lblPath.Text = "Path of Archived Files";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "TB"});
            this.cmbSize.Location = new System.Drawing.Point(486, 196);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(60, 24);
            this.cmbSize.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 689);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblArchive);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtArchive);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtArchive;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblArchive;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox cmbSize;
    }
}

