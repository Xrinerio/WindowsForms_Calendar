namespace Calendar
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            UCDays = new Label();
            notesscore = new Label();
            todaysday = new Label();
            SuspendLayout();
            // 
            // UCDays
            // 
            UCDays.AutoSize = true;
            UCDays.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UCDays.Location = new Point(15, 16);
            UCDays.Name = "UCDays";
            UCDays.Size = new Size(34, 28);
            UCDays.TabIndex = 0;
            UCDays.Text = "00";
            UCDays.Click += UserControlDays_Click;
            // 
            // notesscore
            // 
            notesscore.AutoSize = true;
            notesscore.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            notesscore.Location = new Point(15, 76);
            notesscore.Name = "notesscore";
            notesscore.Size = new Size(0, 23);
            notesscore.TabIndex = 1;
            notesscore.Click += UserControlDays_Click;
            // 
            // todaysday
            // 
            todaysday.AutoSize = true;
            todaysday.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            todaysday.Location = new Point(55, 20);
            todaysday.Name = "todaysday";
            todaysday.Size = new Size(0, 22);
            todaysday.TabIndex = 2;
            todaysday.Click += UserControlDays_Click;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(todaysday);
            Controls.Add(notesscore);
            Controls.Add(UCDays);
            Cursor = Cursors.Hand;
            Name = "UserControlDays";
            Size = new Size(168, 113);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UCDays;
        private Label notesscore;
        private Label todaysday;
    }
}
