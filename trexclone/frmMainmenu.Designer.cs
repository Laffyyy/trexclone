namespace T_Rex_Endless_Runner_MOO_ICT
{
    partial class frmMainmenu
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
            this.StartGame = new System.Windows.Forms.Button();
            this.tbtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblinstruction = new System.Windows.Forms.Button();
            this.dBDinorunDataSet = new T_Rex_Endless_Runner_MOO_ICT.DBDinorunDataSet();
            this.tblScoreboardBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblScoreboardTableAdapter = new T_Rex_Endless_Runner_MOO_ICT.DBDinorunDataSetTableAdapters.tblScoreboardTableAdapter();
            this.tableAdapterManager = new T_Rex_Endless_Runner_MOO_ICT.DBDinorunDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblScoreboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblScoreboardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBDinorunDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreboardBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreboardBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(422, 49);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(180, 34);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "StartGame";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // tbtName
            // 
            this.tbtName.Location = new System.Drawing.Point(449, 23);
            this.tbtName.Name = "tbtName";
            this.tbtName.Size = new System.Drawing.Size(130, 20);
            this.tbtName.TabIndex = 2;
            this.tbtName.TextChanged += new System.EventHandler(this.tbtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter yer name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblinstruction
            // 
            this.lblinstruction.Location = new System.Drawing.Point(458, 89);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(110, 23);
            this.lblinstruction.TabIndex = 5;
            this.lblinstruction.Text = "How to play";
            this.lblinstruction.UseVisualStyleBackColor = true;
            this.lblinstruction.Click += new System.EventHandler(this.btndatabase_Click);
            // 
            // dBDinorunDataSet
            // 
            this.dBDinorunDataSet.DataSetName = "DBDinorunDataSet";
            this.dBDinorunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblScoreboardBindingSource2
            // 
            this.tblScoreboardBindingSource2.DataMember = "tblScoreboard";
            this.tblScoreboardBindingSource2.DataSource = this.dBDinorunDataSet;
            // 
            // tblScoreboardTableAdapter
            // 
            this.tblScoreboardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblScoreboardTableAdapter = this.tblScoreboardTableAdapter;
            this.tableAdapterManager.UpdateOrder = T_Rex_Endless_Runner_MOO_ICT.DBDinorunDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 312);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::T_Rex_Endless_Runner_MOO_ICT.Properties.Resources.dino;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top players";
            // 
            // frmMainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblinstruction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtName);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.frmMainmenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dBDinorunDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreboardBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblScoreboardBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.TextBox tbtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lblinstruction;
        private System.Windows.Forms.BindingSource tblScoreboardBindingSource;
        private System.Windows.Forms.BindingSource tblScoreboardBindingSource1;
        private DBDinorunDataSet dBDinorunDataSet;
        private System.Windows.Forms.BindingSource tblScoreboardBindingSource2;
        private DBDinorunDataSetTableAdapters.tblScoreboardTableAdapter tblScoreboardTableAdapter;
        private DBDinorunDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}