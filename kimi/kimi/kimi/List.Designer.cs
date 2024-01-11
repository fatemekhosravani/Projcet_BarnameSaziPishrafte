namespace kimi
{
    partial class List
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPlayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowCardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redCardsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDataSet = new kimi.teamDataSet();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerDataSet = new kimi.playerDataSet();
            this.tableTableAdapter = new kimi.teamDataSetTableAdapters.TableTableAdapter();
            this.tableTableAdapter1 = new kimi.playerDataSetTableAdapters.TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.playerDataSet1 = new kimi.playerDataSet1();
            this.tableTableAdapter2 = new kimi.playerDataSet1TableAdapters.TableTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameOfTeamDataGridViewTextBoxColumn,
            this.countPlayerDataGridViewTextBoxColumn,
            this.coachDataGridViewTextBoxColumn,
            this.goalsDataGridViewTextBoxColumn,
            this.yellowCardsDataGridViewTextBoxColumn,
            this.redCardsDataGridViewTextBoxColumn,
            this.winDataGridViewTextBoxColumn,
            this.drawDataGridViewTextBoxColumn,
            this.loseDataGridViewTextBoxColumn,
            this.ptsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(617, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 35;
            // 
            // nameOfTeamDataGridViewTextBoxColumn
            // 
            this.nameOfTeamDataGridViewTextBoxColumn.DataPropertyName = "NameOfTeam";
            this.nameOfTeamDataGridViewTextBoxColumn.HeaderText = "NameOfTeam";
            this.nameOfTeamDataGridViewTextBoxColumn.Name = "nameOfTeamDataGridViewTextBoxColumn";
            this.nameOfTeamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countPlayerDataGridViewTextBoxColumn
            // 
            this.countPlayerDataGridViewTextBoxColumn.DataPropertyName = "CountPlayer";
            this.countPlayerDataGridViewTextBoxColumn.HeaderText = "CountPlayer";
            this.countPlayerDataGridViewTextBoxColumn.Name = "countPlayerDataGridViewTextBoxColumn";
            this.countPlayerDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPlayerDataGridViewTextBoxColumn.Width = 50;
            // 
            // coachDataGridViewTextBoxColumn
            // 
            this.coachDataGridViewTextBoxColumn.DataPropertyName = "Coach";
            this.coachDataGridViewTextBoxColumn.HeaderText = "Coach";
            this.coachDataGridViewTextBoxColumn.Name = "coachDataGridViewTextBoxColumn";
            this.coachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goalsDataGridViewTextBoxColumn
            // 
            this.goalsDataGridViewTextBoxColumn.DataPropertyName = "Goals";
            this.goalsDataGridViewTextBoxColumn.HeaderText = "Goals";
            this.goalsDataGridViewTextBoxColumn.Name = "goalsDataGridViewTextBoxColumn";
            this.goalsDataGridViewTextBoxColumn.ReadOnly = true;
            this.goalsDataGridViewTextBoxColumn.Width = 50;
            // 
            // yellowCardsDataGridViewTextBoxColumn
            // 
            this.yellowCardsDataGridViewTextBoxColumn.DataPropertyName = "YellowCards";
            this.yellowCardsDataGridViewTextBoxColumn.HeaderText = "YellowCards";
            this.yellowCardsDataGridViewTextBoxColumn.Name = "yellowCardsDataGridViewTextBoxColumn";
            this.yellowCardsDataGridViewTextBoxColumn.ReadOnly = true;
            this.yellowCardsDataGridViewTextBoxColumn.Width = 50;
            // 
            // redCardsDataGridViewTextBoxColumn
            // 
            this.redCardsDataGridViewTextBoxColumn.DataPropertyName = "RedCards";
            this.redCardsDataGridViewTextBoxColumn.HeaderText = "RedCards";
            this.redCardsDataGridViewTextBoxColumn.Name = "redCardsDataGridViewTextBoxColumn";
            this.redCardsDataGridViewTextBoxColumn.ReadOnly = true;
            this.redCardsDataGridViewTextBoxColumn.Width = 50;
            // 
            // winDataGridViewTextBoxColumn
            // 
            this.winDataGridViewTextBoxColumn.DataPropertyName = "Win";
            this.winDataGridViewTextBoxColumn.HeaderText = "Win";
            this.winDataGridViewTextBoxColumn.Name = "winDataGridViewTextBoxColumn";
            this.winDataGridViewTextBoxColumn.ReadOnly = true;
            this.winDataGridViewTextBoxColumn.Width = 35;
            // 
            // drawDataGridViewTextBoxColumn
            // 
            this.drawDataGridViewTextBoxColumn.DataPropertyName = "Draw";
            this.drawDataGridViewTextBoxColumn.HeaderText = "Draw";
            this.drawDataGridViewTextBoxColumn.Name = "drawDataGridViewTextBoxColumn";
            this.drawDataGridViewTextBoxColumn.ReadOnly = true;
            this.drawDataGridViewTextBoxColumn.Width = 35;
            // 
            // loseDataGridViewTextBoxColumn
            // 
            this.loseDataGridViewTextBoxColumn.DataPropertyName = "Lose";
            this.loseDataGridViewTextBoxColumn.HeaderText = "Lose";
            this.loseDataGridViewTextBoxColumn.Name = "loseDataGridViewTextBoxColumn";
            this.loseDataGridViewTextBoxColumn.ReadOnly = true;
            this.loseDataGridViewTextBoxColumn.Width = 35;
            // 
            // ptsDataGridViewTextBoxColumn
            // 
            this.ptsDataGridViewTextBoxColumn.DataPropertyName = "Pts";
            this.ptsDataGridViewTextBoxColumn.HeaderText = "Pts";
            this.ptsDataGridViewTextBoxColumn.Name = "ptsDataGridViewTextBoxColumn";
            this.ptsDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptsDataGridViewTextBoxColumn.Width = 35;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.teamDataSet;
            // 
            // teamDataSet
            // 
            this.teamDataSet.DataSetName = "teamDataSet";
            this.teamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.playerDataSet;
            // 
            // playerDataSet
            // 
            this.playerDataSet.DataSetName = "playerDataSet";
            this.playerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "لیست تیم ها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(932, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "بازیکنان تیم :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1006, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "حذف تیم";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "ویرایش تیم";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "بروزرسانی";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(642, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "حذف بازیکن";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1318, 629);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "ویرایش بازیکن";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1009, 468);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "بروزرسانی";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(642, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(790, 396);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tableBindingSource2
            // 
            this.tableBindingSource2.DataMember = "Table";
            this.tableBindingSource2.DataSource = this.playerDataSet1;
            // 
            // playerDataSet1
            // 
            this.playerDataSet1.DataSetName = "playerDataSet1";
            this.playerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter2
            // 
            this.tableTableAdapter2.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(491, 494);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(491, 520);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "نام تیم :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "تعداد بازی کن";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "نام مربی";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1298, 471);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1298, 497);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1298, 523);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(128, 20);
            this.textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1298, 549);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(128, 20);
            this.textBox7.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1298, 575);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1298, 602);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1261, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "نام";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1248, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "فامیل";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1248, 530);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "شماره";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1258, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "سن";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1261, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "تیم";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1256, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "پست";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 698);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private teamDataSet teamDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private teamDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private playerDataSet playerDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private playerDataSetTableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowCardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redCardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private playerDataSet1 playerDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource2;
        private playerDataSet1TableAdapters.TableTableAdapter tableTableAdapter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}