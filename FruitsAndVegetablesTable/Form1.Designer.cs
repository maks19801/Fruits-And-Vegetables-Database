
namespace FruitsAndVegetablesTable
{
    partial class FruitsAndVegetablesForm
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
            this.fillButton = new System.Windows.Forms.Button();
            this.dataGridViewDatabaseTable = new System.Windows.Forms.DataGridView();
            this.sqlRequestsComboBox = new System.Windows.Forms.ComboBox();
            this.inputParameterTextBox = new System.Windows.Forms.TextBox();
            this.inputParametersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(0, 55);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(149, 41);
            this.fillButton.TabIndex = 1;
            this.fillButton.Text = "ExecuteRequest";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // dataGridViewDatabaseTable
            // 
            this.dataGridViewDatabaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabaseTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDatabaseTable.Location = new System.Drawing.Point(0, 125);
            this.dataGridViewDatabaseTable.Name = "dataGridViewDatabaseTable";
            this.dataGridViewDatabaseTable.RowHeadersWidth = 62;
            this.dataGridViewDatabaseTable.RowTemplate.Height = 28;
            this.dataGridViewDatabaseTable.Size = new System.Drawing.Size(878, 419);
            this.dataGridViewDatabaseTable.TabIndex = 2;
            // 
            // sqlRequestsComboBox
            // 
            this.sqlRequestsComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlRequestsComboBox.FormattingEnabled = true;
            this.sqlRequestsComboBox.Location = new System.Drawing.Point(0, 0);
            this.sqlRequestsComboBox.Name = "sqlRequestsComboBox";
            this.sqlRequestsComboBox.Size = new System.Drawing.Size(878, 28);
            this.sqlRequestsComboBox.TabIndex = 4;
            this.sqlRequestsComboBox.Text = "Choose the Request";
            // 
            // inputParameterTextBox
            // 
            this.inputParameterTextBox.Location = new System.Drawing.Point(707, 55);
            this.inputParameterTextBox.Name = "inputParameterTextBox";
            this.inputParameterTextBox.Size = new System.Drawing.Size(144, 26);
            this.inputParameterTextBox.TabIndex = 5;
            // 
            // inputParametersLabel
            // 
            this.inputParametersLabel.AutoSize = true;
            this.inputParametersLabel.Location = new System.Drawing.Point(504, 58);
            this.inputParametersLabel.Name = "inputParametersLabel";
            this.inputParametersLabel.Size = new System.Drawing.Size(175, 20);
            this.inputParametersLabel.TabIndex = 6;
            this.inputParametersLabel.Text = "Input Parameters Here:";
            // 
            // FruitsAndVegetablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.inputParametersLabel);
            this.Controls.Add(this.inputParameterTextBox);
            this.Controls.Add(this.sqlRequestsComboBox);
            this.Controls.Add(this.dataGridViewDatabaseTable);
            this.Controls.Add(this.fillButton);
            this.Location = new System.Drawing.Point(100, 50);
            this.Name = "FruitsAndVegetablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruits and Vegetables Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabaseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.DataGridView dataGridViewDatabaseTable;
        private System.Windows.Forms.ComboBox sqlRequestsComboBox;
        private System.Windows.Forms.TextBox inputParameterTextBox;
        private System.Windows.Forms.Label inputParametersLabel;
    }
}

