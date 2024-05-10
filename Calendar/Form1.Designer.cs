namespace Calendar
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
            btnprev = new Button();
            btnnext = new Button();
            daycontainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            monthyear = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnprev
            // 
            btnprev.Cursor = Cursors.Hand;
            btnprev.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnprev.Location = new Point(231, 43);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(103, 46);
            btnprev.TabIndex = 0;
            btnprev.Text = "<<<";
            btnprev.UseVisualStyleBackColor = true;
            btnprev.Click += btnprev_Click;
            // 
            // btnnext
            // 
            btnnext.Cursor = Cursors.Hand;
            btnnext.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnnext.Location = new Point(952, 43);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(103, 46);
            btnnext.TabIndex = 1;
            btnnext.Text = ">>>";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // daycontainer
            // 
            daycontainer.Location = new Point(38, 201);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1219, 716);
            daycontainer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(49, 157);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 3;
            label1.Text = "Понедельник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(249, 157);
            label2.Name = "label2";
            label2.Size = new Size(100, 31);
            label2.TabIndex = 4;
            label2.Text = "Вторник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(431, 157);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 5;
            label3.Text = "Среда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(595, 157);
            label4.Name = "label4";
            label4.Size = new Size(97, 31);
            label4.TabIndex = 6;
            label4.Text = "Четверг";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(761, 157);
            label5.Name = "label5";
            label5.Size = new Size(103, 31);
            label5.TabIndex = 7;
            label5.Text = "Пятница";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(941, 157);
            label6.Name = "label6";
            label6.Size = new Size(99, 31);
            label6.TabIndex = 8;
            label6.Text = "Суббота";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(1096, 157);
            label7.Name = "label7";
            label7.Size = new Size(148, 31);
            label7.TabIndex = 9;
            label7.Text = "Воскресенье";
            // 
            // monthyear
            // 
            monthyear.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            monthyear.Location = new Point(406, 43);
            monthyear.Name = "monthyear";
            monthyear.Size = new Size(487, 56);
            monthyear.TabIndex = 10;
            monthyear.Text = "МЕСЯЦ ГОД";
            monthyear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1261, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gainsboro;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1261, 30);
            flowLayoutPanel1.TabIndex = 13;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Enabled = false;
            label8.Location = new Point(46, 57);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 14;
            label8.Click += Refresh;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1290, 950);
            Controls.Add(label8);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(monthyear);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(daycontainer);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Activated += Refresh;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnprev;
        private Button btnnext;
        private FlowLayoutPanel daycontainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label monthyear;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
    }
}
