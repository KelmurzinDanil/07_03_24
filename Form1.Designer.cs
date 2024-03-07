namespace XML_JSON_dz
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listViewLot = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameReception = new System.Windows.Forms.TextBox();
            this.nameLot = new System.Windows.Forms.TextBox();
            this.Deserialization = new System.Windows.Forms.Button();
            this.Serialization = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_OpenForm2 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.numberTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLotInTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameReceptionInTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumInTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableForJson = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SerJson = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableForJson)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(162, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(0, 110);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(162, 227);
            this.treeView1.TabIndex = 2;
            // 
            // listViewLot
            // 
            this.listViewLot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLot.HideSelection = false;
            this.listViewLot.Location = new System.Drawing.Point(168, 29);
            this.listViewLot.Name = "listViewLot";
            this.listViewLot.Size = new System.Drawing.Size(295, 162);
            this.listViewLot.TabIndex = 3;
            this.listViewLot.UseCompatibleStateImageBehavior = false;
            this.listViewLot.SelectedIndexChanged += new System.EventHandler(this.ListViewLot_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sum);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameReception);
            this.panel1.Controls.Add(this.nameLot);
            this.panel1.Location = new System.Drawing.Point(469, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 325);
            this.panel1.TabIndex = 4;
            // 
            // sum
            // 
            this.sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sum.Location = new System.Drawing.Point(14, 176);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(288, 22);
            this.sum.TabIndex = 10;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn_Add.Location = new System.Drawing.Point(183, 220);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(126, 49);
            this.Btn_Add.TabIndex = 7;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum in $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name Recipient";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name Lot";
            // 
            // nameReception
            // 
            this.nameReception.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameReception.Location = new System.Drawing.Point(14, 125);
            this.nameReception.Name = "nameReception";
            this.nameReception.Size = new System.Drawing.Size(288, 22);
            this.nameReception.TabIndex = 3;
            // 
            // nameLot
            // 
            this.nameLot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLot.Location = new System.Drawing.Point(14, 70);
            this.nameLot.Name = "nameLot";
            this.nameLot.Size = new System.Drawing.Size(288, 22);
            this.nameLot.TabIndex = 0;
            // 
            // Deserialization
            // 
            this.Deserialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Deserialization.BackColor = System.Drawing.Color.Crimson;
            this.Deserialization.Location = new System.Drawing.Point(469, 397);
            this.Deserialization.Name = "Deserialization";
            this.Deserialization.Size = new System.Drawing.Size(136, 53);
            this.Deserialization.TabIndex = 5;
            this.Deserialization.Text = "Deserialization Xml";
            this.Deserialization.UseVisualStyleBackColor = false;
            this.Deserialization.Click += new System.EventHandler(this.Deserialization_Click);
            // 
            // Serialization
            // 
            this.Serialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Serialization.BackColor = System.Drawing.Color.LimeGreen;
            this.Serialization.Location = new System.Drawing.Point(652, 397);
            this.Serialization.Name = "Serialization";
            this.Serialization.Size = new System.Drawing.Size(136, 53);
            this.Serialization.TabIndex = 6;
            this.Serialization.Text = "Serialization Xml";
            this.Serialization.UseVisualStyleBackColor = false;
            this.Serialization.Click += new System.EventHandler(this.Serialization_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XML_JSON_dz.Properties.Resources._9027177_tree_thin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_OpenForm2
            // 
            this.btn_OpenForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_OpenForm2.BackColor = System.Drawing.Color.Indigo;
            this.btn_OpenForm2.Location = new System.Drawing.Point(12, 359);
            this.btn_OpenForm2.Name = "btn_OpenForm2";
            this.btn_OpenForm2.Size = new System.Drawing.Size(136, 65);
            this.btn_OpenForm2.TabIndex = 7;
            this.btn_OpenForm2.Text = "About program";
            this.btn_OpenForm2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_OpenForm2.UseVisualStyleBackColor = false;
            this.btn_OpenForm2.Click += new System.EventHandler(this.btn_OpenForm2_Click_1);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberTable,
            this.nameLotInTable,
            this.nameReceptionInTable,
            this.sumInTable,
            this.timeTable});
            this.table.Location = new System.Drawing.Point(168, 214);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(295, 110);
            this.table.TabIndex = 9;
            // 
            // numberTable
            // 
            this.numberTable.HeaderText = "N";
            this.numberTable.MinimumWidth = 6;
            this.numberTable.Name = "numberTable";
            this.numberTable.Width = 125;
            // 
            // nameLotInTable
            // 
            this.nameLotInTable.HeaderText = "Lot";
            this.nameLotInTable.MinimumWidth = 6;
            this.nameLotInTable.Name = "nameLotInTable";
            this.nameLotInTable.Width = 125;
            // 
            // nameReceptionInTable
            // 
            this.nameReceptionInTable.HeaderText = "Reception";
            this.nameReceptionInTable.MinimumWidth = 6;
            this.nameReceptionInTable.Name = "nameReceptionInTable";
            this.nameReceptionInTable.Width = 125;
            // 
            // sumInTable
            // 
            this.sumInTable.HeaderText = "Sum";
            this.sumInTable.MinimumWidth = 6;
            this.sumInTable.Name = "sumInTable";
            this.sumInTable.Width = 125;
            // 
            // timeTable
            // 
            this.timeTable.HeaderText = "Time";
            this.timeTable.MinimumWidth = 6;
            this.timeTable.Name = "timeTable";
            this.timeTable.Width = 125;
            // 
            // tableForJson
            // 
            this.tableForJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableForJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForJson.Location = new System.Drawing.Point(168, 348);
            this.tableForJson.Name = "tableForJson";
            this.tableForJson.RowHeadersWidth = 51;
            this.tableForJson.RowTemplate.Height = 24;
            this.tableForJson.Size = new System.Drawing.Size(295, 102);
            this.tableForJson.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "XmlTable(Viewing separately is possible)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "JsonTable(Viewing separately is not allowed)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(469, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 13;
            this.button1.Text = "Deserialization Json";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_DeserJson);
            // 
            // btn_SerJson
            // 
            this.btn_SerJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SerJson.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_SerJson.Location = new System.Drawing.Point(652, 343);
            this.btn_SerJson.Name = "btn_SerJson";
            this.btn_SerJson.Size = new System.Drawing.Size(136, 53);
            this.btn_SerJson.TabIndex = 14;
            this.btn_SerJson.Text = "Serialization Json";
            this.btn_SerJson.UseVisualStyleBackColor = false;
            this.btn_SerJson.Click += new System.EventHandler(this.Btn_SerJson);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "ViewList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_SerJson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableForJson);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_OpenForm2);
            this.Controls.Add(this.Serialization);
            this.Controls.Add(this.Deserialization);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewLot);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableForJson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listViewLot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Deserialization;
        private System.Windows.Forms.Button Serialization;
        private System.Windows.Forms.TextBox nameLot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameReception;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button btn_OpenForm2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLotInTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameReceptionInTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumInTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeTable;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.DataGridView tableForJson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SerJson;
        private System.Windows.Forms.Label label6;
    }
}

