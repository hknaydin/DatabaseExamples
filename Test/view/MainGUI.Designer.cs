namespace Test
{
    partial class MainGUI
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
            btnConnect = new Button();
            btnDisconnect = new Button();
            dateTimePickerMain = new DateTimePicker();
            dataGridViewTables = new DataGridView();
            cmbTableNames = new ComboBox();
            lblTables = new Label();
            btnDataFetch = new Button();
            btnNewFormWindow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(326, 60);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Database Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(394, 12);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(326, 60);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerMain
            // 
            dateTimePickerMain.Location = new Point(842, 27);
            dateTimePickerMain.Name = "dateTimePickerMain";
            dateTimePickerMain.Size = new Size(250, 27);
            dateTimePickerMain.TabIndex = 2;
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Location = new Point(12, 112);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowHeadersWidth = 51;
            dataGridViewTables.Size = new Size(708, 300);
            dataGridViewTables.TabIndex = 3;
            // 
            // cmbTableNames
            // 
            cmbTableNames.FormattingEnabled = true;
            cmbTableNames.Location = new Point(879, 157);
            cmbTableNames.Name = "cmbTableNames";
            cmbTableNames.Size = new Size(213, 28);
            cmbTableNames.TabIndex = 4;
            // 
            // lblTables
            // 
            lblTables.AutoSize = true;
            lblTables.Location = new Point(766, 165);
            lblTables.Name = "lblTables";
            lblTables.Size = new Size(97, 20);
            lblTables.TabIndex = 5;
            lblTables.Text = "Table Names:";
            // 
            // btnDataFetch
            // 
            btnDataFetch.Location = new Point(807, 80);
            btnDataFetch.Name = "btnDataFetch";
            btnDataFetch.Size = new Size(285, 52);
            btnDataFetch.TabIndex = 6;
            btnDataFetch.Text = "Data Fetch";
            btnDataFetch.UseVisualStyleBackColor = true;
            // 
            // btnNewFormWindow
            // 
            btnNewFormWindow.Location = new Point(799, 261);
            btnNewFormWindow.Name = "btnNewFormWindow";
            btnNewFormWindow.Size = new Size(293, 74);
            btnNewFormWindow.TabIndex = 7;
            btnNewFormWindow.Text = "New Form Open";
            btnNewFormWindow.UseVisualStyleBackColor = true;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 450);
            Controls.Add(btnNewFormWindow);
            Controls.Add(btnDataFetch);
            Controls.Add(lblTables);
            Controls.Add(cmbTableNames);
            Controls.Add(dataGridViewTables);
            Controls.Add(dateTimePickerMain);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Name = "MainGUI";
            Text = "MainGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnConnect;
        public Button btnDisconnect;
        public DateTimePicker dateTimePickerMain;
        public DataGridView dataGridViewTables;
        public ComboBox cmbTableNames;
        public Label lblTables;
        public Button btnDataFetch;
        public Button btnNewFormWindow;
    }
}
