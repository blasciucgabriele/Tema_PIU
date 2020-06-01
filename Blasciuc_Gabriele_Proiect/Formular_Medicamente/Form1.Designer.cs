using System.Windows.Forms;

namespace Formular_Medicamente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.Cod = new System.Windows.Forms.TextBox();
            this.Pret = new System.Windows.Forms.TextBox();
            this.Stoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Producator = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.numeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.f = new System.Windows.Forms.ToolStripTextBox();
            this.Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.numeProdusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.md = new System.Windows.Forms.ToolStripTextBox();
            this.authorNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret";
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(138, 43);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(100, 20);
            this.Denumire.TabIndex = 4;
            // 
            // Cod
            // 
            this.Cod.Location = new System.Drawing.Point(138, 119);
            this.Cod.Name = "Cod";
            this.Cod.Size = new System.Drawing.Size(100, 20);
            this.Cod.TabIndex = 6;
            // 
            // Pret
            // 
            this.Pret.Location = new System.Drawing.Point(138, 157);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(100, 20);
            this.Pret.TabIndex = 7;
            // 
            // Stoc
            // 
            this.Stoc.Location = new System.Drawing.Point(138, 196);
            this.Stoc.Name = "Stoc";
            this.Stoc.Size = new System.Drawing.Size(100, 20);
            this.Stoc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(65, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stoc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Format";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Eliberare";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(138, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Reteta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(138, 326);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Fara_Reteta";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 233);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Comprimate";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 256);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sirop";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(138, 275);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Gel";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Afiseaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Producator
            // 
            this.Producator.AllowDrop = true;
            this.Producator.FormattingEnabled = true;
            this.Producator.Items.AddRange(new object[] {
            "Bayer",
            "Angelini",
            "CnsRom",
            "ItalMed",
            "Mereuta",
            "DeutscheFarm"});
            this.Producator.Location = new System.Drawing.Point(138, 79);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(100, 21);
            this.Producator.TabIndex = 24;
            // 
            // richTextBox1
            // 
            this.richTextBox1.FormattingEnabled = true;
            this.richTextBox1.Location = new System.Drawing.Point(290, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(454, 173);
            this.richTextBox1.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.Search,
            this.Find,
            this.Modify,
            this.authorNameToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DoubleClickEnabled = true;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.DoubleClick += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(97, 20);
            this.Search.Text = "Search by Data";
            this.Search.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // Find
            // 
            this.Find.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeProdusToolStripMenuItem,
            this.f});
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(42, 20);
            this.Find.Text = "Find";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // numeProdusToolStripMenuItem
            // 
            this.numeProdusToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.numeProdusToolStripMenuItem.Name = "numeProdusToolStripMenuItem";
            this.numeProdusToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.numeProdusToolStripMenuItem.Text = "Nume produs:";
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.LightGray;
            this.f.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(100, 23);
            this.f.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Find_KeyDown);
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.Color.Green;
            this.Modify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeProdusToolStripMenuItem1,
            this.md});
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(57, 20);
            this.Modify.Text = "Modify";
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // numeProdusToolStripMenuItem1
            // 
            this.numeProdusToolStripMenuItem1.Name = "numeProdusToolStripMenuItem1";
            this.numeProdusToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.numeProdusToolStripMenuItem1.Text = "Nume produs:";
            // 
            // md
            // 
            this.md.BackColor = System.Drawing.Color.Silver;
            this.md.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.md.Name = "md";
            this.md.Size = new System.Drawing.Size(100, 23);
            this.md.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Modify_KeyDown);
            // 
            // authorNameToolStripMenuItem
            // 
            this.authorNameToolStripMenuItem.DoubleClickEnabled = true;
            this.authorNameToolStripMenuItem.Name = "authorNameToolStripMenuItem";
            this.authorNameToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.authorNameToolStripMenuItem.Text = "Author Name";
            this.authorNameToolStripMenuItem.DoubleClick += new System.EventHandler(this.authorNameToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DoubleClickEnabled = true;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.DoubleClick += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Stoc);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.Cod);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Farmacie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.TextBox Cod;
        private System.Windows.Forms.TextBox Pret;
        private System.Windows.Forms.TextBox Stoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Producator;
        private System.Windows.Forms.ListBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.ToolStripMenuItem Modify;
        private System.Windows.Forms.ToolStripMenuItem authorNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox f;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem numeProdusToolStripMenuItem1;
        private ToolStripTextBox md;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
    }
}

