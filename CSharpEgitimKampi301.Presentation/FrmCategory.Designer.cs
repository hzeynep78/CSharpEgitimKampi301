namespace CSharpEgitimKampi301.Presentation
{
    partial class FrmCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbPassive = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(77, 167);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(177, 42);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(159, 22);
            this.txtID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 423);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori Durumu:";
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(157, 129);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(53, 20);
            this.rdbActive.TabIndex = 7;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Aktif";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            this.rdbPassive.AutoSize = true;
            this.rdbPassive.Location = new System.Drawing.Point(216, 129);
            this.rdbPassive.Name = "rdbPassive";
            this.rdbPassive.Size = new System.Drawing.Size(58, 20);
            this.rdbPassive.TabIndex = 8;
            this.rdbPassive.TabStop = true;
            this.rdbPassive.Text = "Pasif";
            this.rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(77, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(77, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(77, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 42);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(77, 417);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(177, 42);
            this.btnID.TabIndex = 12;
            this.btnID.Text = "IDye Göre";
            this.btnID.UseVisualStyleBackColor = true;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 495);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdbPassive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategory";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbPassive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnID;
    }
}

