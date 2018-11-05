namespace PgSql
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.phNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFilterStreet = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterPatr = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterName = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterSurname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.updateMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // phNumber
            // 
            this.phNumber.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.phNumber.Location = new System.Drawing.Point(807, 65);
            this.phNumber.Multiline = true;
            this.phNumber.Name = "phNumber";
            this.phNumber.Size = new System.Drawing.Size(175, 36);
            this.phNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.add.Cursor = System.Windows.Forms.Cursors.Default;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.add.Location = new System.Drawing.Point(1076, 65);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(132, 35);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.delete.Location = new System.Drawing.Point(1076, 125);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 35);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clear.Cursor = System.Windows.Forms.Cursors.Default;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clear.Location = new System.Drawing.Point(1076, 237);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(132, 35);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button6_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.exit.Cursor = System.Windows.Forms.Cursors.Cross;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.exit.Location = new System.Drawing.Point(1076, 627);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(132, 35);
            this.exit.TabIndex = 9;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(804, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone number";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.name.Location = new System.Drawing.Point(223, 65);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 36);
            this.name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(220, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(421, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Patronymic";
            // 
            // patronymic
            // 
            this.patronymic.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.patronymic.Location = new System.Drawing.Point(424, 65);
            this.patronymic.Multiline = true;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(175, 36);
            this.patronymic.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lastName.Location = new System.Drawing.Point(10, 65);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(175, 36);
            this.lastName.TabIndex = 1;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.street.Location = new System.Drawing.Point(611, 65);
            this.street.Multiline = true;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(175, 36);
            this.street.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(608, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Street";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(1076, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Show everyone";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trajan Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 391);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(1076, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "name",
            "surname",
            "patronymic",
            "street",
            "telephone"});
            this.comboBoxTable.Location = new System.Drawing.Point(846, 390);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(175, 30);
            this.comboBoxTable.TabIndex = 23;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(831, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Choose a field for editing";
            // 
            // comboBoxFilterStreet
            // 
            this.comboBoxFilterStreet.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxFilterStreet.FormattingEnabled = true;
            this.comboBoxFilterStreet.Location = new System.Drawing.Point(612, 156);
            this.comboBoxFilterStreet.Name = "comboBoxFilterStreet";
            this.comboBoxFilterStreet.Size = new System.Drawing.Size(174, 30);
            this.comboBoxFilterStreet.TabIndex = 25;
            // 
            // comboBoxFilterPatr
            // 
            this.comboBoxFilterPatr.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxFilterPatr.FormattingEnabled = true;
            this.comboBoxFilterPatr.Location = new System.Drawing.Point(424, 156);
            this.comboBoxFilterPatr.Name = "comboBoxFilterPatr";
            this.comboBoxFilterPatr.Size = new System.Drawing.Size(174, 30);
            this.comboBoxFilterPatr.TabIndex = 26;
            // 
            // comboBoxFilterName
            // 
            this.comboBoxFilterName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxFilterName.FormattingEnabled = true;
            this.comboBoxFilterName.Location = new System.Drawing.Point(224, 156);
            this.comboBoxFilterName.Name = "comboBoxFilterName";
            this.comboBoxFilterName.Size = new System.Drawing.Size(174, 30);
            this.comboBoxFilterName.TabIndex = 27;
            // 
            // comboBoxFilterSurname
            // 
            this.comboBoxFilterSurname.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxFilterSurname.FormattingEnabled = true;
            this.comboBoxFilterSurname.Location = new System.Drawing.Point(12, 156);
            this.comboBoxFilterSurname.Name = "comboBoxFilterSurname";
            this.comboBoxFilterSurname.Size = new System.Drawing.Size(174, 30);
            this.comboBoxFilterSurname.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Filter by surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(219, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Filter by name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.Location = new System.Drawing.Point(421, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "Filter by patronymic";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(608, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 32;
            this.label10.Text = "Filter by street";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Filter.Location = new System.Drawing.Point(821, 151);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(132, 35);
            this.Filter.TabIndex = 33;
            this.Filter.Text = "Filter ";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // updateMain
            // 
            this.updateMain.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.updateMain.Location = new System.Drawing.Point(821, 628);
            this.updateMain.Name = "updateMain";
            this.updateMain.Size = new System.Drawing.Size(132, 35);
            this.updateMain.TabIndex = 34;
            this.updateMain.Text = "Update main";
            this.updateMain.UseVisualStyleBackColor = true;
            this.updateMain.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 692);
            this.Controls.Add(this.updateMain);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxFilterSurname);
            this.Controls.Add(this.comboBoxFilterName);
            this.Controls.Add(this.comboBoxFilterPatr);
            this.Controls.Add(this.comboBoxFilterStreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.street);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phNumber);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "phonebook";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        #endregion
        private System.Windows.Forms.TextBox phNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxFilterStreet;
        private System.Windows.Forms.ComboBox comboBoxFilterPatr;
        private System.Windows.Forms.ComboBox comboBoxFilterName;
        private System.Windows.Forms.ComboBox comboBoxFilterSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button updateMain;
    }
}

