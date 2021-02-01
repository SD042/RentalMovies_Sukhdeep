namespace RentalMovies_Sukhdeep
{
    partial class RantalMoviesBySukhdeep
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOutRented = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewRental = new System.Windows.Forms.DataGridView();
            this.rdbAllRented = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.movieUpdate = new System.Windows.Forms.Button();
            this.movieDelete = new System.Windows.Forms.Button();
            this.movieAdd = new System.Windows.Forms.Button();
            this.movieIssue = new System.Windows.Forms.Button();
            this.movieReturn = new System.Windows.Forms.Button();
            this.custDelete = new System.Windows.Forms.Button();
            this.custUpdate = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.custAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1039, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1041, 278);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rented Movies";
            // 
            // rdbOutRented
            // 
            this.rdbOutRented.AutoSize = true;
            this.rdbOutRented.Location = new System.Drawing.Point(160, 47);
            this.rdbOutRented.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOutRented.Name = "rdbOutRented";
            this.rdbOutRented.Size = new System.Drawing.Size(102, 21);
            this.rdbOutRented.TabIndex = 2;
            this.rdbOutRented.TabStop = true;
            this.rdbOutRented.Text = "Out Rented";
            this.rdbOutRented.UseVisualStyleBackColor = true;
            this.rdbOutRented.CheckedChanged += new System.EventHandler(this.rdbOutRented_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewRental);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1039, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRental
            // 
            this.dataGridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRental.Location = new System.Drawing.Point(4, 0);
            this.dataGridViewRental.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewRental.Name = "dataGridViewRental";
            this.dataGridViewRental.RowHeadersWidth = 51;
            this.dataGridViewRental.Size = new System.Drawing.Size(1032, 278);
            this.dataGridViewRental.TabIndex = 0;
            this.dataGridViewRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRental_CellContentClick);
            // 
            // rdbAllRented
            // 
            this.rdbAllRented.AutoSize = true;
            this.rdbAllRented.Location = new System.Drawing.Point(4, 47);
            this.rdbAllRented.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAllRented.Name = "rdbAllRented";
            this.rdbAllRented.Size = new System.Drawing.Size(94, 21);
            this.rdbAllRented.TabIndex = 1;
            this.rdbAllRented.TabStop = true;
            this.rdbAllRented.Text = "All Rented";
            this.rdbAllRented.UseVisualStyleBackColor = true;
            this.rdbAllRented.CheckedChanged += new System.EventHandler(this.rdbAllRented_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(54, 57);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 306);
            this.tabControl1.TabIndex = 65;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1039, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(4, 0);
            this.dataGridViewMovies.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.Size = new System.Drawing.Size(1032, 278);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellContentClick);
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(674, 470);
            this.txtPlot.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(141, 22);
            this.txtPlot.TabIndex = 64;
            this.txtPlot.Text = "Plot......";
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(190, 422);
            this.txtCustFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(152, 22);
            this.txtCustFirstName.TabIndex = 63;
            this.txtCustFirstName.Text = "First Name......";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(512, 422);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(152, 22);
            this.txtAddress.TabIndex = 62;
            this.txtAddress.Text = "Address......";
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(351, 422);
            this.txtCustLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(152, 22);
            this.txtCustLastName.TabIndex = 61;
            this.txtCustLastName.Text = "Last Name......";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.rdbAllRented);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbOutRented);
            this.panel1.Location = new System.Drawing.Point(778, 508);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 79);
            this.panel1.TabIndex = 60;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(824, 471);
            this.txtRentalID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(48, 22);
            this.txtRentalID.TabIndex = 59;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(410, 470);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(125, 22);
            this.txtGenre.TabIndex = 58;
            this.txtGenre.Text = "Genre......";
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(544, 470);
            this.txtRentalCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(120, 22);
            this.txtRentalCost.TabIndex = 57;
            this.txtRentalCost.Text = "Rental Cost......";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(274, 470);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(127, 22);
            this.txtTitle.TabIndex = 56;
            this.txtTitle.Text = "Title......";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(190, 470);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(75, 22);
            this.txtMovieID.TabIndex = 55;
            // 
            // movieUpdate
            // 
            this.movieUpdate.Location = new System.Drawing.Point(190, 520);
            this.movieUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.movieUpdate.Name = "movieUpdate";
            this.movieUpdate.Size = new System.Drawing.Size(133, 66);
            this.movieUpdate.TabIndex = 54;
            this.movieUpdate.Text = "Update Movie";
            this.movieUpdate.UseVisualStyleBackColor = true;
            this.movieUpdate.Click += new System.EventHandler(this.movieUpdate_Click);
            // 
            // movieDelete
            // 
            this.movieDelete.Location = new System.Drawing.Point(54, 520);
            this.movieDelete.Margin = new System.Windows.Forms.Padding(4);
            this.movieDelete.Name = "movieDelete";
            this.movieDelete.Size = new System.Drawing.Size(128, 66);
            this.movieDelete.TabIndex = 53;
            this.movieDelete.Text = "Delete Movie";
            this.movieDelete.UseVisualStyleBackColor = true;
            this.movieDelete.Click += new System.EventHandler(this.movieDelete_Click);
            // 
            // movieAdd
            // 
            this.movieAdd.Location = new System.Drawing.Point(54, 455);
            this.movieAdd.Margin = new System.Windows.Forms.Padding(4);
            this.movieAdd.Name = "movieAdd";
            this.movieAdd.Size = new System.Drawing.Size(128, 63);
            this.movieAdd.TabIndex = 52;
            this.movieAdd.Text = "Add Movie";
            this.movieAdd.UseVisualStyleBackColor = true;
            this.movieAdd.Click += new System.EventHandler(this.movieAdd_Click);
            // 
            // movieIssue
            // 
            this.movieIssue.ForeColor = System.Drawing.Color.Green;
            this.movieIssue.Location = new System.Drawing.Point(994, 371);
            this.movieIssue.Margin = new System.Windows.Forms.Padding(4);
            this.movieIssue.Name = "movieIssue";
            this.movieIssue.Size = new System.Drawing.Size(107, 106);
            this.movieIssue.TabIndex = 51;
            this.movieIssue.Text = "Issue Movie";
            this.movieIssue.UseVisualStyleBackColor = true;
            this.movieIssue.Click += new System.EventHandler(this.movieIssue_Click);
            // 
            // movieReturn
            // 
            this.movieReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movieReturn.Location = new System.Drawing.Point(882, 371);
            this.movieReturn.Margin = new System.Windows.Forms.Padding(4);
            this.movieReturn.Name = "movieReturn";
            this.movieReturn.Size = new System.Drawing.Size(104, 106);
            this.movieReturn.TabIndex = 50;
            this.movieReturn.Text = "Return Movie";
            this.movieReturn.UseVisualStyleBackColor = true;
            this.movieReturn.Click += new System.EventHandler(this.movieReturn_Click);
            // 
            // custDelete
            // 
            this.custDelete.Location = new System.Drawing.Point(630, 371);
            this.custDelete.Margin = new System.Windows.Forms.Padding(4);
            this.custDelete.Name = "custDelete";
            this.custDelete.Size = new System.Drawing.Size(244, 43);
            this.custDelete.TabIndex = 49;
            this.custDelete.Text = "Delete Customer";
            this.custDelete.UseVisualStyleBackColor = true;
            this.custDelete.Click += new System.EventHandler(this.custDelete_Click);
            // 
            // custUpdate
            // 
            this.custUpdate.Location = new System.Drawing.Point(398, 371);
            this.custUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.custUpdate.Name = "custUpdate";
            this.custUpdate.Size = new System.Drawing.Size(224, 43);
            this.custUpdate.TabIndex = 48;
            this.custUpdate.Text = "Update Customer";
            this.custUpdate.UseVisualStyleBackColor = true;
            this.custUpdate.Click += new System.EventHandler(this.custUpdate_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(190, 371);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(75, 22);
            this.txtCustID.TabIndex = 46;
            // 
            // custAdd
            // 
            this.custAdd.Location = new System.Drawing.Point(54, 371);
            this.custAdd.Margin = new System.Windows.Forms.Padding(4);
            this.custAdd.Name = "custAdd";
            this.custAdd.Size = new System.Drawing.Size(128, 84);
            this.custAdd.TabIndex = 45;
            this.custAdd.Text = "Add Customer";
            this.custAdd.UseVisualStyleBackColor = true;
            this.custAdd.Click += new System.EventHandler(this.custAdd_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(674, 422);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(152, 22);
            this.txtPhone.TabIndex = 47;
            this.txtPhone.Text = "Phone......";
            // 
            // RantalMoviesBySukhdeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 644);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtCustFirstName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustLastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.movieUpdate);
            this.Controls.Add(this.movieDelete);
            this.Controls.Add(this.movieAdd);
            this.Controls.Add(this.movieIssue);
            this.Controls.Add(this.movieReturn);
            this.Controls.Add(this.custDelete);
            this.Controls.Add(this.custUpdate);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.custAdd);
            this.Controls.Add(this.txtPhone);
            this.Name = "RantalMoviesBySukhdeep";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRental)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbOutRented;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewRental;
        private System.Windows.Forms.RadioButton rdbAllRented;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Button movieUpdate;
        private System.Windows.Forms.Button movieDelete;
        private System.Windows.Forms.Button movieAdd;
        private System.Windows.Forms.Button movieIssue;
        private System.Windows.Forms.Button movieReturn;
        private System.Windows.Forms.Button custDelete;
        private System.Windows.Forms.Button custUpdate;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Button custAdd;
        private System.Windows.Forms.TextBox txtPhone;
    }
}

