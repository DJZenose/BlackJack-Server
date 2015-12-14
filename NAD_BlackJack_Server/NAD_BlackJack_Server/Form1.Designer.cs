namespace NAD_BlackJack_Server
{
    partial class AdminTools
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
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blackJackDBDataSet = new NAD_BlackJack_Server.BlackJackDBDataSet();
            this.userDetailsTableAdapter = new NAD_BlackJack_Server.BlackJackDBDataSetTableAdapters.UserDetailsTableAdapter();
            this.Display = new System.Windows.Forms.Button();
            this.Execute = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackJackDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.hashKeyDataGridViewTextBoxColumn,
            this.accountBalanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // hashKeyDataGridViewTextBoxColumn
            // 
            this.hashKeyDataGridViewTextBoxColumn.DataPropertyName = "HashKey";
            this.hashKeyDataGridViewTextBoxColumn.HeaderText = "HashKey";
            this.hashKeyDataGridViewTextBoxColumn.Name = "hashKeyDataGridViewTextBoxColumn";
            this.hashKeyDataGridViewTextBoxColumn.Width = 200;
            // 
            // accountBalanceDataGridViewTextBoxColumn
            // 
            this.accountBalanceDataGridViewTextBoxColumn.DataPropertyName = "AccountBalance";
            this.accountBalanceDataGridViewTextBoxColumn.HeaderText = "AccountBalance";
            this.accountBalanceDataGridViewTextBoxColumn.Name = "accountBalanceDataGridViewTextBoxColumn";
            this.accountBalanceDataGridViewTextBoxColumn.Width = 120;
            // 
            // userDetailsBindingSource
            // 
            this.userDetailsBindingSource.DataMember = "UserDetails";
            this.userDetailsBindingSource.DataSource = this.blackJackDBDataSet;
            // 
            // blackJackDBDataSet
            // 
            this.blackJackDBDataSet.DataSetName = "BlackJackDBDataSet";
            this.blackJackDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDetailsTableAdapter
            // 
            this.userDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(24, 498);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(137, 39);
            this.Display.TabIndex = 1;
            this.Display.Text = "DIsplay";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.FillTable);
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(184, 498);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(130, 39);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute Query";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.ExecuteQuery);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(336, 498);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(114, 39);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Add User";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.Insert);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.Location = new System.Drawing.Point(504, 498);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 4;
            // 
            // AdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 561);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminTools";
            this.Text = "Administration Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackJackDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BlackJackDBDataSet blackJackDBDataSet;
        private System.Windows.Forms.BindingSource userDetailsBindingSource;
        private BlackJackDBDataSetTableAdapters.UserDetailsTableAdapter userDetailsTableAdapter;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

