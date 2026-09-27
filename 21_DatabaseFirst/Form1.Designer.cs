namespace _21_DatabaseFirst
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
            btn_getData = new Button();
            dt_gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dt_gridView).BeginInit();
            SuspendLayout();
            // 
            // btn_getData
            // 
            btn_getData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_getData.Location = new Point(316, 45);
            btn_getData.Name = "btn_getData";
            btn_getData.Size = new Size(136, 29);
            btn_getData.TabIndex = 0;
            btn_getData.Text = "Get Data";
            btn_getData.UseVisualStyleBackColor = true;
            // 
            // dt_gridView
            // 
            dt_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_gridView.Location = new Point(12, 89);
            dt_gridView.Name = "dt_gridView";
            dt_gridView.Size = new Size(776, 349);
            dt_gridView.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dt_gridView);
            Controls.Add(btn_getData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dt_gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_getData;
        private DataGridView dt_gridView;
    }
}
