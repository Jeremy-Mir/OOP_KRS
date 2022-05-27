
namespace OOP_KRS
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priseLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label offices__1Label;
            System.Windows.Forms.Label offices__2Label;
            System.Windows.Forms.Label offices__3Label;
            System.Windows.Forms.Label pushkinLabel;
            System.Windows.Forms.Label tolstoiLabel;
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new OOP_KRS.Database1DataSet();
            this.newspaperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newspaperTableAdapter = new OOP_KRS.Database1DataSetTableAdapters.newspaperTableAdapter();
            this.tableAdapterManager = new OOP_KRS.Database1DataSetTableAdapters.TableAdapterManager();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priseTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.offices__1TextBox = new System.Windows.Forms.TextBox();
            this.offices__2TextBox = new System.Windows.Forms.TextBox();
            this.offices__3TextBox = new System.Windows.Forms.TextBox();
            this.pushkinTextBox = new System.Windows.Forms.TextBox();
            this.tolstoiTextBox = new System.Windows.Forms.TextBox();
            this.newspaperDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priseLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            offices__1Label = new System.Windows.Forms.Label();
            offices__2Label = new System.Windows.Forms.Label();
            offices__3Label = new System.Windows.Forms.Label();
            pushkinLabel = new System.Windows.Forms.Label();
            tolstoiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspaperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspaperDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(212, 391);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 49;
            this.button7.Text = "сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 47;
            this.button5.Text = "добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 361);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.database1DataSet;
            this.bindingSource2.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newspaperBindingSource
            // 
            this.newspaperBindingSource.DataMember = "newspaper";
            this.newspaperBindingSource.DataSource = this.database1DataSet;
            // 
            // newspaperTableAdapter
            // 
            this.newspaperTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.newspaperTableAdapter = this.newspaperTableAdapter;
            this.tableAdapterManager.officeTableAdapter = null;
            this.tableAdapterManager.typographyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OOP_KRS.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(65, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 63;
            idLabel.Text = "Id:";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(90, 63);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 64;
            this.idLabel1.Text = "label1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(51, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 64;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(93, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 65;
            // 
            // priseLabel
            // 
            priseLabel.AutoSize = true;
            priseLabel.Location = new System.Drawing.Point(55, 118);
            priseLabel.Name = "priseLabel";
            priseLabel.Size = new System.Drawing.Size(32, 13);
            priseLabel.TabIndex = 65;
            priseLabel.Text = "prise:";
            // 
            // priseTextBox
            // 
            this.priseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "prise", true));
            this.priseTextBox.Location = new System.Drawing.Point(93, 115);
            this.priseTextBox.Name = "priseTextBox";
            this.priseTextBox.Size = new System.Drawing.Size(100, 20);
            this.priseTextBox.TabIndex = 66;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(51, 144);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(36, 13);
            ratingLabel.TabIndex = 66;
            ratingLabel.Text = "rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(93, 141);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 67;
            // 
            // offices__1Label
            // 
            offices__1Label.AutoSize = true;
            offices__1Label.Location = new System.Drawing.Point(30, 170);
            offices__1Label.Name = "offices__1Label";
            offices__1Label.Size = new System.Drawing.Size(57, 13);
            offices__1Label.TabIndex = 67;
            offices__1Label.Text = "offices #1:";
            // 
            // offices__1TextBox
            // 
            this.offices__1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "offices_#1", true));
            this.offices__1TextBox.Location = new System.Drawing.Point(93, 167);
            this.offices__1TextBox.Name = "offices__1TextBox";
            this.offices__1TextBox.Size = new System.Drawing.Size(100, 20);
            this.offices__1TextBox.TabIndex = 68;
            // 
            // offices__2Label
            // 
            offices__2Label.AutoSize = true;
            offices__2Label.Location = new System.Drawing.Point(30, 196);
            offices__2Label.Name = "offices__2Label";
            offices__2Label.Size = new System.Drawing.Size(57, 13);
            offices__2Label.TabIndex = 68;
            offices__2Label.Text = "offices #2:";
            // 
            // offices__2TextBox
            // 
            this.offices__2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "offices_#2", true));
            this.offices__2TextBox.Location = new System.Drawing.Point(93, 193);
            this.offices__2TextBox.Name = "offices__2TextBox";
            this.offices__2TextBox.Size = new System.Drawing.Size(100, 20);
            this.offices__2TextBox.TabIndex = 69;
            // 
            // offices__3Label
            // 
            offices__3Label.AutoSize = true;
            offices__3Label.Location = new System.Drawing.Point(30, 222);
            offices__3Label.Name = "offices__3Label";
            offices__3Label.Size = new System.Drawing.Size(57, 13);
            offices__3Label.TabIndex = 69;
            offices__3Label.Text = "offices #3:";
            // 
            // offices__3TextBox
            // 
            this.offices__3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "offices_#3", true));
            this.offices__3TextBox.Location = new System.Drawing.Point(93, 219);
            this.offices__3TextBox.Name = "offices__3TextBox";
            this.offices__3TextBox.Size = new System.Drawing.Size(100, 20);
            this.offices__3TextBox.TabIndex = 70;
            // 
            // pushkinLabel
            // 
            pushkinLabel.AutoSize = true;
            pushkinLabel.Location = new System.Drawing.Point(40, 248);
            pushkinLabel.Name = "pushkinLabel";
            pushkinLabel.Size = new System.Drawing.Size(47, 13);
            pushkinLabel.TabIndex = 70;
            pushkinLabel.Text = "pushkin:";
            // 
            // pushkinTextBox
            // 
            this.pushkinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "pushkin", true));
            this.pushkinTextBox.Location = new System.Drawing.Point(93, 245);
            this.pushkinTextBox.Name = "pushkinTextBox";
            this.pushkinTextBox.Size = new System.Drawing.Size(100, 20);
            this.pushkinTextBox.TabIndex = 71;
            // 
            // tolstoiLabel
            // 
            tolstoiLabel.AutoSize = true;
            tolstoiLabel.Location = new System.Drawing.Point(50, 274);
            tolstoiLabel.Name = "tolstoiLabel";
            tolstoiLabel.Size = new System.Drawing.Size(37, 13);
            tolstoiLabel.TabIndex = 71;
            tolstoiLabel.Text = "tolstoi:";
            // 
            // tolstoiTextBox
            // 
            this.tolstoiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newspaperBindingSource, "tolstoi", true));
            this.tolstoiTextBox.Location = new System.Drawing.Point(93, 271);
            this.tolstoiTextBox.Name = "tolstoiTextBox";
            this.tolstoiTextBox.Size = new System.Drawing.Size(100, 20);
            this.tolstoiTextBox.TabIndex = 72;
            // 
            // newspaperDataGridView
            // 
            this.newspaperDataGridView.AutoGenerateColumns = false;
            this.newspaperDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newspaperDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.newspaperDataGridView.DataSource = this.newspaperBindingSource;
            this.newspaperDataGridView.Location = new System.Drawing.Point(212, 12);
            this.newspaperDataGridView.Name = "newspaperDataGridView";
            this.newspaperDataGridView.Size = new System.Drawing.Size(943, 307);
            this.newspaperDataGridView.TabIndex = 72;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prise";
            this.dataGridViewTextBoxColumn3.HeaderText = "prise";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn4.HeaderText = "rating";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "offices_#1";
            this.dataGridViewTextBoxColumn5.HeaderText = "offices_#1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "offices_#2";
            this.dataGridViewTextBoxColumn6.HeaderText = "offices_#2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "offices_#3";
            this.dataGridViewTextBoxColumn7.HeaderText = "offices_#3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pushkin";
            this.dataGridViewTextBoxColumn8.HeaderText = "pushkin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "tolstoi";
            this.dataGridViewTextBoxColumn9.HeaderText = "tolstoi";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 447);
            this.Controls.Add(this.newspaperDataGridView);
            this.Controls.Add(tolstoiLabel);
            this.Controls.Add(this.tolstoiTextBox);
            this.Controls.Add(pushkinLabel);
            this.Controls.Add(this.pushkinTextBox);
            this.Controls.Add(offices__3Label);
            this.Controls.Add(this.offices__3TextBox);
            this.Controls.Add(offices__2Label);
            this.Controls.Add(this.offices__2TextBox);
            this.Controls.Add(offices__1Label);
            this.Controls.Add(this.offices__1TextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(priseLabel);
            this.Controls.Add(this.priseTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspaperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspaperDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource newspaperBindingSource;
        private Database1DataSetTableAdapters.newspaperTableAdapter newspaperTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priseTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox offices__1TextBox;
        private System.Windows.Forms.TextBox offices__2TextBox;
        private System.Windows.Forms.TextBox offices__3TextBox;
        private System.Windows.Forms.TextBox pushkinTextBox;
        private System.Windows.Forms.TextBox tolstoiTextBox;
        private System.Windows.Forms.DataGridView newspaperDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}