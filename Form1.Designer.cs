namespace Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Columns_lbl = new System.Windows.Forms.Label();
            this.row_lbl = new System.Windows.Forms.Label();
            this.maxnum_lbl = new System.Windows.Forms.Label();
            this.minnum_lbl = new System.Windows.Forms.Label();
            this.filenm_textbox = new System.Windows.Forms.TextBox();
            this.filenm_lbl = new System.Windows.Forms.Label();
            this.run_btn = new System.Windows.Forms.Button();
            this.mainlbl = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.updown_rows = new System.Windows.Forms.NumericUpDown();
            this.updown_columns = new System.Windows.Forms.NumericUpDown();
            this.updown_maxnum = new System.Windows.Forms.NumericUpDown();
            this.updown_minnum = new System.Windows.Forms.NumericUpDown();
            this.checkBox_rowsq = new System.Windows.Forms.CheckBox();
            this.checkBox_columnsq = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updown_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_maxnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_minnum)).BeginInit();
            this.SuspendLayout();
            // 
            // Columns_lbl
            // 
            this.Columns_lbl.AutoSize = true;
            this.Columns_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Columns_lbl.Location = new System.Drawing.Point(8, 74);
            this.Columns_lbl.Name = "Columns_lbl";
            this.Columns_lbl.Size = new System.Drawing.Size(115, 17);
            this.Columns_lbl.TabIndex = 2;
            this.Columns_lbl.Text = "Columns Quanity";
            // 
            // row_lbl
            // 
            this.row_lbl.AutoSize = true;
            this.row_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row_lbl.Location = new System.Drawing.Point(8, 49);
            this.row_lbl.Name = "row_lbl";
            this.row_lbl.Size = new System.Drawing.Size(95, 17);
            this.row_lbl.TabIndex = 3;
            this.row_lbl.Text = "Rows Quanity";
            // 
            // maxnum_lbl
            // 
            this.maxnum_lbl.AutoSize = true;
            this.maxnum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxnum_lbl.Location = new System.Drawing.Point(8, 101);
            this.maxnum_lbl.Name = "maxnum_lbl";
            this.maxnum_lbl.Size = new System.Drawing.Size(120, 17);
            this.maxnum_lbl.TabIndex = 5;
            this.maxnum_lbl.Text = "Maximum Number";
            // 
            // minnum_lbl
            // 
            this.minnum_lbl.AutoSize = true;
            this.minnum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minnum_lbl.Location = new System.Drawing.Point(8, 126);
            this.minnum_lbl.Name = "minnum_lbl";
            this.minnum_lbl.Size = new System.Drawing.Size(117, 17);
            this.minnum_lbl.TabIndex = 6;
            this.minnum_lbl.Text = "Minimum Number";
            // 
            // filenm_textbox
            // 
            this.filenm_textbox.Location = new System.Drawing.Point(129, 22);
            this.filenm_textbox.Name = "filenm_textbox";
            this.filenm_textbox.Size = new System.Drawing.Size(100, 20);
            this.filenm_textbox.TabIndex = 8;
            // 
            // filenm_lbl
            // 
            this.filenm_lbl.AutoSize = true;
            this.filenm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenm_lbl.Location = new System.Drawing.Point(8, 22);
            this.filenm_lbl.Name = "filenm_lbl";
            this.filenm_lbl.Size = new System.Drawing.Size(71, 17);
            this.filenm_lbl.TabIndex = 9;
            this.filenm_lbl.Text = "File Name";
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(235, 86);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(125, 60);
            this.run_btn.TabIndex = 10;
            this.run_btn.Text = "Run";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // mainlbl
            // 
            this.mainlbl.AutoSize = true;
            this.mainlbl.Location = new System.Drawing.Point(138, 6);
            this.mainlbl.Name = "mainlbl";
            this.mainlbl.Size = new System.Drawing.Size(73, 13);
            this.mainlbl.TabIndex = 11;
            this.mainlbl.Text = "Set Parametrs";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(235, 20);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(125, 60);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset Values";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // updown_rows
            // 
            this.updown_rows.Location = new System.Drawing.Point(129, 49);
            this.updown_rows.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updown_rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_rows.Name = "updown_rows";
            this.updown_rows.Size = new System.Drawing.Size(100, 20);
            this.updown_rows.TabIndex = 13;
            this.updown_rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updown_columns
            // 
            this.updown_columns.Location = new System.Drawing.Point(129, 75);
            this.updown_columns.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updown_columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updown_columns.Name = "updown_columns";
            this.updown_columns.Size = new System.Drawing.Size(100, 20);
            this.updown_columns.TabIndex = 14;
            this.updown_columns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updown_maxnum
            // 
            this.updown_maxnum.Location = new System.Drawing.Point(129, 101);
            this.updown_maxnum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updown_maxnum.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.updown_maxnum.Name = "updown_maxnum";
            this.updown_maxnum.Size = new System.Drawing.Size(100, 20);
            this.updown_maxnum.TabIndex = 15;
            this.updown_maxnum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // updown_minnum
            // 
            this.updown_minnum.Location = new System.Drawing.Point(129, 127);
            this.updown_minnum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updown_minnum.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.updown_minnum.Name = "updown_minnum";
            this.updown_minnum.Size = new System.Drawing.Size(100, 20);
            this.updown_minnum.TabIndex = 16;
            // 
            // checkBox_rowsq
            // 
            this.checkBox_rowsq.AutoSize = true;
            this.checkBox_rowsq.Checked = true;
            this.checkBox_rowsq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_rowsq.Location = new System.Drawing.Point(11, 153);
            this.checkBox_rowsq.Name = "checkBox_rowsq";
            this.checkBox_rowsq.Size = new System.Drawing.Size(126, 17);
            this.checkBox_rowsq.TabIndex = 17;
            this.checkBox_rowsq.Text = "Include rows quantity";
            this.checkBox_rowsq.UseVisualStyleBackColor = true;
            // 
            // checkBox_columnsq
            // 
            this.checkBox_columnsq.AutoSize = true;
            this.checkBox_columnsq.Location = new System.Drawing.Point(141, 153);
            this.checkBox_columnsq.Name = "checkBox_columnsq";
            this.checkBox_columnsq.Size = new System.Drawing.Size(143, 17);
            this.checkBox_columnsq.TabIndex = 18;
            this.checkBox_columnsq.Text = "Include columns quantity";
            this.checkBox_columnsq.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 154);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Version 1,0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_columnsq);
            this.Controls.Add(this.checkBox_rowsq);
            this.Controls.Add(this.updown_minnum);
            this.Controls.Add(this.updown_maxnum);
            this.Controls.Add(this.updown_columns);
            this.Controls.Add(this.updown_rows);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.mainlbl);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.filenm_lbl);
            this.Controls.Add(this.filenm_textbox);
            this.Controls.Add(this.minnum_lbl);
            this.Controls.Add(this.maxnum_lbl);
            this.Controls.Add(this.row_lbl);
            this.Controls.Add(this.Columns_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.updown_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_maxnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_minnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Columns_lbl;
        private System.Windows.Forms.Label row_lbl;
        private System.Windows.Forms.Label maxnum_lbl;
        private System.Windows.Forms.Label minnum_lbl;
        private System.Windows.Forms.TextBox filenm_textbox;
        private System.Windows.Forms.Label filenm_lbl;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.Label mainlbl;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.NumericUpDown updown_rows;
        private System.Windows.Forms.NumericUpDown updown_columns;
        private System.Windows.Forms.NumericUpDown updown_maxnum;
        private System.Windows.Forms.NumericUpDown updown_minnum;
        private System.Windows.Forms.CheckBox checkBox_rowsq;
        private System.Windows.Forms.CheckBox checkBox_columnsq;
        private System.Windows.Forms.Label label1;
    }
}

