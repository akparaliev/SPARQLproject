using System.Windows.Forms;

namespace SPARQLproject
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsBooks = new System.Windows.Forms.BindingSource(this.components);
            this.btnSumbitAccount = new System.Windows.Forms.Button();
            this.dgFilms = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchParamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFilms = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.gbSearchType = new System.Windows.Forms.GroupBox();
            this.rbSearchByBookAuthor = new System.Windows.Forms.RadioButton();
            this.rbSearchByBookName = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFilms)).BeginInit();
            this.gbSearchType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.txtUserId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgBooks, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSumbitAccount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgFilms, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectAll, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.gbSearchType, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 723);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtUserId
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtUserId, 3);
            this.txtUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUserId.Location = new System.Drawing.Point(3, 39);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(482, 23);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.Text = "59267749";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Goodreads.com user id";
            // 
            // dgBooks
            // 
            this.dgBooks.AllowUserToAddRows = false;
            this.dgBooks.AllowUserToDeleteRows = false;
            this.dgBooks.AutoGenerateColumns = false;
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.isSelectedDataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgBooks, 3);
            this.dgBooks.DataSource = this.bsBooks;
            this.dgBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBooks.Location = new System.Drawing.Point(3, 75);
            this.dgBooks.Name = "dgBooks";
            this.tableLayoutPanel1.SetRowSpan(this.dgBooks, 2);
            this.dgBooks.Size = new System.Drawing.Size(482, 607);
            this.dgBooks.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn6.HeaderText = "Author";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // isSelectedDataGridViewCheckBoxColumn
            // 
            this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
            // 
            // bsBooks
            // 
            this.bsBooks.DataSource = typeof(SPARQLproject.Models.BookModel);
            // 
            // btnSumbitAccount
            // 
            this.btnSumbitAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSumbitAccount.Location = new System.Drawing.Point(308, 3);
            this.btnSumbitAccount.Name = "btnSumbitAccount";
            this.btnSumbitAccount.Size = new System.Drawing.Size(177, 30);
            this.btnSumbitAccount.TabIndex = 3;
            this.btnSumbitAccount.Text = "Submit user";
            this.btnSumbitAccount.UseVisualStyleBackColor = true;
            this.btnSumbitAccount.Click += new System.EventHandler(this.btnSumbitAccount_Click);
            // 
            // dgFilms
            // 
            this.dgFilms.AllowUserToAddRows = false;
            this.dgFilms.AllowUserToDeleteRows = false;
            this.dgFilms.AutoGenerateColumns = false;
            this.dgFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.yearDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.searchParamDataGridViewTextBoxColumn});
            this.dgFilms.DataSource = this.bsFilms;
            this.dgFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFilms.Location = new System.Drawing.Point(491, 75);
            this.dgFilms.Name = "dgFilms";
            this.dgFilms.ReadOnly = true;
            this.dgFilms.Size = new System.Drawing.Size(726, 463);
            this.dgFilms.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchParamDataGridViewTextBoxColumn
            // 
            this.searchParamDataGridViewTextBoxColumn.DataPropertyName = "SearchParam";
            this.searchParamDataGridViewTextBoxColumn.HeaderText = "SearchParam";
            this.searchParamDataGridViewTextBoxColumn.Name = "searchParamDataGridViewTextBoxColumn";
            this.searchParamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsFilms
            // 
            this.bsFilms.DataSource = typeof(SPARQLproject.Models.FilmModel);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(308, 688);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(177, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search movies";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAll.Location = new System.Drawing.Point(186, 688);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(116, 32);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // gbSearchType
            // 
            this.gbSearchType.Controls.Add(this.rbSearchByBookAuthor);
            this.gbSearchType.Controls.Add(this.rbSearchByBookName);
            this.gbSearchType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchType.Location = new System.Drawing.Point(491, 3);
            this.gbSearchType.Name = "gbSearchType";
            this.tableLayoutPanel1.SetRowSpan(this.gbSearchType, 2);
            this.gbSearchType.Size = new System.Drawing.Size(726, 66);
            this.gbSearchType.TabIndex = 10;
            this.gbSearchType.TabStop = false;
            this.gbSearchType.Text = "Choose a search type";
            // 
            // rbSearchByBookAuthor
            // 
            this.rbSearchByBookAuthor.AutoSize = true;
            this.rbSearchByBookAuthor.Location = new System.Drawing.Point(405, 33);
            this.rbSearchByBookAuthor.Name = "rbSearchByBookAuthor";
            this.rbSearchByBookAuthor.Size = new System.Drawing.Size(98, 17);
            this.rbSearchByBookAuthor.TabIndex = 1;
            this.rbSearchByBookAuthor.TabStop = true;
            this.rbSearchByBookAuthor.Text = "by Book Author";
            this.rbSearchByBookAuthor.UseVisualStyleBackColor = true;
            // 
            // rbSearchByBookName
            // 
            this.rbSearchByBookName.AutoSize = true;
            this.rbSearchByBookName.Location = new System.Drawing.Point(266, 33);
            this.rbSearchByBookName.Name = "rbSearchByBookName";
            this.rbSearchByBookName.Size = new System.Drawing.Size(95, 17);
            this.rbSearchByBookName.TabIndex = 0;
            this.rbSearchByBookName.TabStop = true;
            this.rbSearchByBookName.Text = "by Book Name";
            this.rbSearchByBookName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFilms)).EndInit();
            this.gbSearchType.ResumeLayout(false);
            this.gbSearchType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.BindingSource bsBooks;
        private System.Windows.Forms.Button btnSumbitAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridView dgFilms;
        private BindingSource bsFilms;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private Button btnSearch;
        private Button btnSelectAll;
        private GroupBox gbSearchType;
        private RadioButton rbSearchByBookAuthor;
        private RadioButton rbSearchByBookName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn searchParamDataGridViewTextBoxColumn;
    }
}

