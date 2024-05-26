namespace WinFormsAppGosiTest
{
    partial class FormCars
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.checkBoxIsBus = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.buttonDeleteName = new System.Windows.Forms.Button();
            this.buttonDeleteSus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 20;
            this.listBoxCars.Location = new System.Drawing.Point(869, 12);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(442, 424);
            this.listBoxCars.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(25, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(25, 70);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(125, 27);
            this.textBoxWidth.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(25, 120);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(125, 27);
            this.textBoxHeight.TabIndex = 3;
            // 
            // checkBoxIsBus
            // 
            this.checkBoxIsBus.AutoSize = true;
            this.checkBoxIsBus.Location = new System.Drawing.Point(25, 174);
            this.checkBoxIsBus.Name = "checkBoxIsBus";
            this.checkBoxIsBus.Size = new System.Drawing.Size(101, 24);
            this.checkBoxIsBus.TabIndex = 4;
            this.checkBoxIsBus.Text = "checkBox1";
            this.checkBoxIsBus.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(26, 224);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "button1";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(575, 476);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 29);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "button1";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(242, 12);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.RowHeadersWidth = 51;
            this.dataGridViewCars.RowTemplate.Height = 29;
            this.dataGridViewCars.Size = new System.Drawing.Size(604, 424);
            this.dataGridViewCars.TabIndex = 7;
            // 
            // buttonDeleteName
            // 
            this.buttonDeleteName.Location = new System.Drawing.Point(713, 479);
            this.buttonDeleteName.Name = "buttonDeleteName";
            this.buttonDeleteName.Size = new System.Drawing.Size(94, 29);
            this.buttonDeleteName.TabIndex = 8;
            this.buttonDeleteName.Text = "button1";
            this.buttonDeleteName.UseVisualStyleBackColor = true;
            this.buttonDeleteName.Click += new System.EventHandler(this.buttonDeleteName_Click);
            // 
            // buttonDeleteSus
            // 
            this.buttonDeleteSus.Location = new System.Drawing.Point(851, 476);
            this.buttonDeleteSus.Name = "buttonDeleteSus";
            this.buttonDeleteSus.Size = new System.Drawing.Size(94, 29);
            this.buttonDeleteSus.TabIndex = 9;
            this.buttonDeleteSus.Text = "button1";
            this.buttonDeleteSus.UseVisualStyleBackColor = true;
            this.buttonDeleteSus.Click += new System.EventHandler(this.buttonDeleteSus_Click);
            // 
            // FormCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 736);
            this.Controls.Add(this.buttonDeleteSus);
            this.Controls.Add(this.buttonDeleteName);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxIsBus);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxCars);
            this.Name = "FormCars";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxCars;
        private TextBox textBoxName;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private CheckBox checkBoxIsBus;
        private Button buttonSave;
        private Button buttonLoad;
        private DataGridView dataGridViewCars;
        private Button buttonDeleteName;
        private Button buttonDeleteSus;
    }
}