
namespace xml_laba
{
    partial class Pensia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.CheckBox();
            this.faculty = new System.Windows.Forms.CheckBox();
            this.catedra = new System.Windows.Forms.CheckBox();
            this.date = new System.Windows.Forms.CheckBox();
            this.degree = new System.Windows.Forms.CheckBox();
            this.namebox = new System.Windows.Forms.ComboBox();
            this.facultybox = new System.Windows.Forms.ComboBox();
            this.catedrabox = new System.Windows.Forms.ComboBox();
            this.databox = new System.Windows.Forms.ComboBox();
            this.degreebox = new System.Windows.Forms.ComboBox();
            this.sexbox = new System.Windows.Forms.ComboBox();
            this.sex = new System.Windows.Forms.CheckBox();
            this.pension = new System.Windows.Forms.DataGridView();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.openXMLfile = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pension)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 24);
            this.name.TabIndex = 2;
            this.name.Text = "name";
            this.name.UseVisualStyleBackColor = true;
            this.name.CheckedChanged += new System.EventHandler(this.name_CheckedChanged);
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Location = new System.Drawing.Point(12, 52);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(75, 24);
            this.faculty.TabIndex = 3;
            this.faculty.Text = "faculty";
            this.faculty.UseVisualStyleBackColor = true;
            this.faculty.CheckedChanged += new System.EventHandler(this.faculty_CheckedChanged);
            // 
            // catedra
            // 
            this.catedra.AutoSize = true;
            this.catedra.Location = new System.Drawing.Point(12, 82);
            this.catedra.Name = "catedra";
            this.catedra.Size = new System.Drawing.Size(89, 24);
            this.catedra.TabIndex = 4;
            this.catedra.Text = "cathedra";
            this.catedra.UseVisualStyleBackColor = true;
            this.catedra.CheckedChanged += new System.EventHandler(this.catedra_CheckedChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(13, 118);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(90, 24);
            this.date.TabIndex = 5;
            this.date.Text = "birth day";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Location = new System.Drawing.Point(13, 150);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(78, 24);
            this.degree.TabIndex = 6;
            this.degree.Text = "degree";
            this.degree.UseVisualStyleBackColor = true;
            this.degree.CheckedChanged += new System.EventHandler(this.degree_CheckedChanged);
            // 
            // namebox
            // 
            this.namebox.FormattingEnabled = true;
            this.namebox.Location = new System.Drawing.Point(119, 18);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(151, 28);
            this.namebox.TabIndex = 8;
            this.namebox.SelectedValueChanged += new System.EventHandler(this.namebox_SelectedValueChanged);
            // 
            // facultybox
            // 
            this.facultybox.FormattingEnabled = true;
            this.facultybox.Location = new System.Drawing.Point(119, 48);
            this.facultybox.Name = "facultybox";
            this.facultybox.Size = new System.Drawing.Size(151, 28);
            this.facultybox.TabIndex = 9;
            this.facultybox.SelectedValueChanged += new System.EventHandler(this.facultybox_SelectedValueChanged);
            // 
            // catedrabox
            // 
            this.catedrabox.FormattingEnabled = true;
            this.catedrabox.Location = new System.Drawing.Point(119, 82);
            this.catedrabox.Name = "catedrabox";
            this.catedrabox.Size = new System.Drawing.Size(151, 28);
            this.catedrabox.TabIndex = 10;
            this.catedrabox.SelectedValueChanged += new System.EventHandler(this.catedrabox_SelectedValueChanged);
            // 
            // databox
            // 
            this.databox.FormattingEnabled = true;
            this.databox.Location = new System.Drawing.Point(119, 114);
            this.databox.Name = "databox";
            this.databox.Size = new System.Drawing.Size(151, 28);
            this.databox.TabIndex = 11;
            this.databox.SelectedValueChanged += new System.EventHandler(this.databox_SelectedValueChanged);
            // 
            // degreebox
            // 
            this.degreebox.FormattingEnabled = true;
            this.degreebox.Location = new System.Drawing.Point(119, 148);
            this.degreebox.Name = "degreebox";
            this.degreebox.Size = new System.Drawing.Size(151, 28);
            this.degreebox.TabIndex = 12;
            this.degreebox.SelectedValueChanged += new System.EventHandler(this.degreebox_SelectedValueChanged);
            // 
            // sexbox
            // 
            this.sexbox.FormattingEnabled = true;
            this.sexbox.Location = new System.Drawing.Point(119, 182);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(151, 28);
            this.sexbox.TabIndex = 13;
            this.sexbox.SelectedValueChanged += new System.EventHandler(this.sexbox_SelectedValueChanged);
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(12, 184);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(78, 24);
            this.sex.TabIndex = 14;
            this.sex.Text = "gender";
            this.sex.UseVisualStyleBackColor = true;
            this.sex.CheckedChanged += new System.EventHandler(this.sex_CheckedChanged);
            // 
            // pension
            // 
            this.pension.AllowUserToAddRows = false;
            this.pension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pension.Location = new System.Drawing.Point(313, 41);
            this.pension.Name = "pension";
            this.pension.RowHeadersWidth = 51;
            this.pension.RowTemplate.Height = 29;
            this.pension.Size = new System.Drawing.Size(475, 335);
            this.pension.TabIndex = 15;
            this.pension.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pension_CellContentClick);
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(13, 252);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(57, 24);
            this.SAX.TabIndex = 16;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            this.SAX.CheckedChanged += new System.EventHandler(this.SAX_CheckedChanged);
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(13, 282);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(65, 24);
            this.DOM.TabIndex = 17;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            this.DOM.CheckedChanged += new System.EventHandler(this.DOM_CheckedChanged);
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(13, 312);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(63, 24);
            this.LINQ.TabIndex = 18;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            this.LINQ.CheckedChanged += new System.EventHandler(this.LINQ_CheckedChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(119, 247);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 29);
            this.search.TabIndex = 19;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(119, 317);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(94, 29);
            this.convert.TabIndex = 21;
            this.convert.Text = "convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(119, 282);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(94, 29);
            this.open.TabIndex = 22;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // Pensia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.open);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.search);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.pension);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.sexbox);
            this.Controls.Add(this.degreebox);
            this.Controls.Add(this.databox);
            this.Controls.Add(this.catedrabox);
            this.Controls.Add(this.facultybox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.date);
            this.Controls.Add(this.catedra);
            this.Controls.Add(this.faculty);
            this.Controls.Add(this.name);
            this.Name = "Pensia";
            this.Text = "Pensia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pension)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox name;
        private System.Windows.Forms.CheckBox faculty;
        private System.Windows.Forms.CheckBox catedra;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.CheckBox degree;
        private System.Windows.Forms.ComboBox namebox;
        private System.Windows.Forms.ComboBox facultybox;
        private System.Windows.Forms.ComboBox catedrabox;
        private System.Windows.Forms.ComboBox databox;
        private System.Windows.Forms.ComboBox degreebox;
        private System.Windows.Forms.ComboBox sexbox;
        private System.Windows.Forms.CheckBox sex;
        private System.Windows.Forms.DataGridView pension;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.OpenFileDialog openXMLfile;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

