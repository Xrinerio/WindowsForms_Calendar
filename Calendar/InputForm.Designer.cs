﻿namespace Calendar
{
    partial class InputForm
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
            label1 = new Label();
            inputdate = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox_nowtime = new MaskedTextBox();
            textBox_input = new MaskedTextBox();
            checkedListBox2 = new ListBox();
            label8 = new Label();
            btn_del = new Button();
            showDesc = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(257, 24);
            label1.Name = "label1";
            label1.Size = new Size(299, 38);
            label1.TabIndex = 0;
            label1.Text = "Введите ваши данные";
            // 
            // inputdate
            // 
            inputdate.AutoSize = true;
            inputdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputdate.Location = new Point(28, 52);
            inputdate.Name = "inputdate";
            inputdate.Size = new Size(62, 28);
            inputdate.TabIndex = 1;
            inputdate.Text = "ДАТА";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(217, 116);
            label3.Name = "label3";
            label3.Size = new Size(206, 23);
            label3.TabIndex = 2;
            label3.Text = "Время(в формате чч:мм)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(220, 200);
            label4.Name = "label4";
            label4.Size = new Size(220, 23);
            label4.TabIndex = 3;
            label4.Text = "Выберите ваши симптомы";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(516, 88);
            label5.Name = "label5";
            label5.Size = new Size(198, 51);
            label5.TabIndex = 4;
            label5.Text = "Введите ваше давление через /";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(516, 230);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 136);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(220, 230);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(290, 129);
            checkedListBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(516, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 27);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Добавить заметку";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(335, 409);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 10;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(745, 0);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 11;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightGray;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(745, 30);
            flowLayoutPanel1.TabIndex = 12;
            flowLayoutPanel1.MouseDown += InputForm_MouseDown;
            // 
            // textBox_nowtime
            // 
            textBox_nowtime.Location = new Point(217, 139);
            textBox_nowtime.Name = "textBox_nowtime";
            textBox_nowtime.Size = new Size(125, 27);
            textBox_nowtime.TabIndex = 13;
            textBox_nowtime.Text = "NOW TIME";
            textBox_nowtime.TextChanged += textBox_nowtime_TextChanged;
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(516, 139);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(175, 27);
            textBox_input.TabIndex = 14;
            textBox_input.Text = "/";
            textBox_input.TextAlign = HorizontalAlignment.Center;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(28, 99);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(150, 322);
            checkedListBox2.TabIndex = 15;
            checkedListBox2.SelectedIndexChanged += checkedListBox2_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 42);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 16;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.White;
            btn_del.Location = new Point(28, 428);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(150, 29);
            btn_del.TabIndex = 17;
            btn_del.Text = "Удалить запись";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += btn_del_Click;
            // 
            // showDesc
            // 
            showDesc.AutoSize = true;
            showDesc.Location = new Point(503, 431);
            showDesc.Name = "showDesc";
            showDesc.Size = new Size(155, 24);
            showDesc.TabIndex = 18;
            showDesc.Text = "Показать советы?";
            showDesc.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 236, 236);
            ClientSize = new Size(774, 469);
            Controls.Add(showDesc);
            Controls.Add(btn_del);
            Controls.Add(label8);
            Controls.Add(checkedListBox2);
            Controls.Add(textBox_input);
            Controls.Add(textBox_nowtime);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(inputdate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += InputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label inputdate;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaskedTextBox textBox_nowtime;
        private MaskedTextBox textBox_input;
        private ListBox checkedListBox2;
        private Label label8;
        private Button btn_del;
        private CheckBox showDesc;
    }
}