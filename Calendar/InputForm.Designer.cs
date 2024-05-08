namespace Calendar
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
            textBox_input = new TextBox();
            textBox_nowtime = new TextBox();
            textBox1 = new TextBox();
            checkedListBox1 = new CheckedListBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(173, 30);
            label1.Name = "label1";
            label1.Size = new Size(299, 38);
            label1.TabIndex = 0;
            label1.Text = "Введите ваши данные";
            // 
            // inputdate
            // 
            inputdate.AutoSize = true;
            inputdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputdate.Location = new Point(55, 79);
            inputdate.Name = "inputdate";
            inputdate.Size = new Size(62, 28);
            inputdate.TabIndex = 1;
            inputdate.Text = "ДАТА";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 116);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Время";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 200);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 3;
            label4.Text = "Выберите ваши симптомы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 116);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 4;
            label5.Text = "Введите ваше давление";
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(354, 144);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(231, 27);
            textBox_input.TabIndex = 5;
            // 
            // textBox_nowtime
            // 
            textBox_nowtime.Location = new Point(58, 144);
            textBox_nowtime.Name = "textBox_nowtime";
            textBox_nowtime.Size = new Size(153, 27);
            textBox_nowtime.TabIndex = 6;
            textBox_nowtime.Text = "NOW TIME";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(354, 230);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 140);
            textBox1.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(58, 230);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(290, 136);
            checkedListBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(354, 196);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Добавить заметку";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(250, 409);
            button1.Name = "button1";
            button1.Size = new Size(144, 48);
            button1.TabIndex = 10;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(614, 0);
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
            flowLayoutPanel1.Size = new Size(614, 30);
            flowLayoutPanel1.TabIndex = 12;
            flowLayoutPanel1.MouseDown += InputForm_MouseDown;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 236, 236);
            ClientSize = new Size(640, 469);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox_nowtime);
            Controls.Add(textBox_input);
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
        private TextBox textBox_input;
        private TextBox textBox_nowtime;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}