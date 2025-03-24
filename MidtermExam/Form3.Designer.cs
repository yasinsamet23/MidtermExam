namespace MidtermExam
{
    partial class Form3
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
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.lstboxTodo = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCleaAll = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F"});
            this.cmbGrade.Location = new System.Drawing.Point(45, 89);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(121, 23);
            this.cmbGrade.TabIndex = 0;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.cmbGrade_SelectedIndexChanged);
            // 
            // lstboxTodo
            // 
            this.lstboxTodo.FormattingEnabled = true;
            this.lstboxTodo.ItemHeight = 15;
            this.lstboxTodo.Location = new System.Drawing.Point(473, 75);
            this.lstboxTodo.Name = "lstboxTodo";
            this.lstboxTodo.Size = new System.Drawing.Size(120, 94);
            this.lstboxTodo.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(404, 243);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCleaAll
            // 
            this.btnCleaAll.Location = new System.Drawing.Point(530, 243);
            this.btnCleaAll.Name = "btnCleaAll";
            this.btnCleaAll.Size = new System.Drawing.Size(75, 23);
            this.btnCleaAll.TabIndex = 4;
            this.btnCleaAll.Text = "Clear All";
            this.btnCleaAll.UseVisualStyleBackColor = true;
            this.btnCleaAll.Click += new System.EventHandler(this.btnCleaAll_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(639, 243);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(129, 23);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Back to Main Form";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(248, 89);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(143, 23);
            this.txtEditor.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnCleaAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstboxTodo);
            this.Controls.Add(this.cmbGrade);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbGrade;
        private ListBox lstboxTodo;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnCleaAll;
        private Button btnMain;
        private TextBox txtEditor;
    }
}