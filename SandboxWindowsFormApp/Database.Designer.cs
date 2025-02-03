namespace SandboxWindowsFormApp
{
    partial class Database
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
            components = new System.ComponentModel.Container();
            categoryBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonEdit = new Button();
            textBoxEditId = new TextBox();
            textBoxEditName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(390, 253);
            dataGridView1.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(614, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "追加";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(614, 78);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "削除";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(508, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(508, 79);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "名前";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(485, 82);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 9;
            label2.Text = "id";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(614, 222);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "編集";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxEditId
            // 
            textBoxEditId.Location = new Point(508, 193);
            textBoxEditId.Name = "textBoxEditId";
            textBoxEditId.Size = new Size(100, 23);
            textBoxEditId.TabIndex = 11;
            // 
            // textBoxEditName
            // 
            textBoxEditName.Location = new Point(508, 222);
            textBoxEditName.Name = "textBoxEditName";
            textBoxEditName.Size = new Size(100, 23);
            textBoxEditName.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 196);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 13;
            label3.Text = "id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 225);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 14;
            label4.Text = "名前";
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxEditName);
            Controls.Add(textBoxEditId);
            Controls.Add(buttonEdit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Name = "Database";
            Text = "データベース";
            Load += Database_Load;
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource categoryBindingSource;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonDelete;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label label1;
        private Label label2;
        private Button buttonEdit;
        private TextBox textBoxEditId;
        private TextBox textBoxEditName;
        private Label label3;
        private Label label4;
    }
}