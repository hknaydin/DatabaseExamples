namespace Test.view
{
    partial class SecondGUI
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
            btnSecond = new Button();
            dateTimePicker = new DateTimePicker();
            groupBox = new GroupBox();
            checkMale = new CheckBox();
            checkFemale = new CheckBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnSecond
            // 
            btnSecond.Location = new Point(12, 12);
            btnSecond.Name = "btnSecond";
            btnSecond.Size = new Size(189, 69);
            btnSecond.TabIndex = 0;
            btnSecond.Text = "Second Button";
            btnSecond.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(539, 21);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 1;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(checkFemale);
            groupBox.Controls.Add(checkMale);
            groupBox.Location = new Point(12, 106);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(760, 321);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Panel";
            // 
            // checkMale
            // 
            checkMale.AutoSize = true;
            checkMale.Location = new Point(6, 44);
            checkMale.Name = "checkMale";
            checkMale.Size = new Size(101, 24);
            checkMale.TabIndex = 0;
            checkMale.Text = "checkMale";
            checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            checkFemale.AutoSize = true;
            checkFemale.Location = new Point(6, 91);
            checkFemale.Name = "checkFemale";
            checkFemale.Size = new Size(116, 24);
            checkFemale.TabIndex = 1;
            checkFemale.Text = "checkFemale";
            checkFemale.UseVisualStyleBackColor = true;
            // 
            // SecondGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox);
            Controls.Add(dateTimePicker);
            Controls.Add(btnSecond);
            Name = "SecondGUI";
            Text = "SecondGUI";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSecond;
        private DateTimePicker dateTimePicker;
        private GroupBox groupBox;
        private CheckBox checkMale;
        private CheckBox checkFemale;
    }
}