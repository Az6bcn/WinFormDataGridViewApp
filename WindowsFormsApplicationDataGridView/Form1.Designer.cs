namespace WindowsFormsApplicationDataGridView
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
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Location = new System.Drawing.Point(64, 20);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.Size = new System.Drawing.Size(429, 280);
            this.peopleDataGridView.TabIndex = 0;
            this.peopleDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.peopleDataGridView_CellMouseClick);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(510, 153);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.peopleDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.Button ShowButton;
    }
}

