namespace Formular_Medicamente
{
    partial class Search
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Ok = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Din = new System.Windows.Forms.Label();
            this.Pana = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 62);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
     
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(41, 121);
            this.dateTimePicker2.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(364, 122);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(491, 122);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Din
            // 
            this.Din.AutoSize = true;
            this.Din.BackColor = System.Drawing.Color.White;
            this.Din.Location = new System.Drawing.Point(38, 40);
            this.Din.Name = "Din";
            this.Din.Size = new System.Drawing.Size(26, 13);
            this.Din.TabIndex = 4;
            this.Din.Text = "Din:";
            // 
            // Pana
            // 
            this.Pana.AutoSize = true;
            this.Pana.BackColor = System.Drawing.Color.White;
            this.Pana.Location = new System.Drawing.Point(38, 96);
            this.Pana.Name = "Pana";
            this.Pana.Size = new System.Drawing.Size(38, 13);
            this.Pana.TabIndex = 5;
            this.Pana.Text = "Pana :";
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(41, 169);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(657, 213);
            this.data.TabIndex = 6;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(749, 408);
            this.Controls.Add(this.data);
            this.Controls.Add(this.Pana);
            this.Controls.Add(this.Din);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Din;
        private System.Windows.Forms.Label Pana;
        private System.Windows.Forms.DataGridView data;
    }
}