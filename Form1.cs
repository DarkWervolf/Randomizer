using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void run_btn_Click(object sender, EventArgs e)
        {
            //getting info from the user
            string filename = filenm_textbox.Text;
            if (filename == "")
            {
                mainlbl.Text = "Enter file name!";
                Refresh();
            }
            else
            {
                filename += ".txt";

                string rowsq_str = updown_rows.Text;
                int rowsq = int.Parse(rowsq_str);

                string columnsq_str = updown_columns.Text;
                int columnsq = int.Parse(columnsq_str);

                string maxnum_str = updown_maxnum.Text;
                int maxnum = int.Parse(maxnum_str);

                string minnum_str = updown_minnum.Text;
                int minnum = int.Parse(minnum_str);

                //check if it works
                //int sum = minnum + maxnum + rowsq + columnsq;
                //mainlbl.Text = sum.ToString() + filename;
                //Refresh();

                string currentPath = Directory.GetCurrentDirectory();
                string yourfilesfoldername = Path.Combine(currentPath, "Your Files");
                string newpath = Path.Combine(yourfilesfoldername, filename);
                using (StreamWriter sw = new StreamWriter(newpath))
                {
                    Random rnd = new Random();
                    int num;
                    if (checkBox_rowsq.Checked == true)
                    {
                        sw.WriteLine(rowsq);
                    }
                    if (checkBox_columnsq.Checked == true)
                    {
                        sw.WriteLine(columnsq);
                    }
                    for (int i = 0; i < rowsq; i++)
                    {
                        for (int j = 0; j < columnsq; j++)
                        {
                            num = rnd.Next(minnum, maxnum + 1);
                            sw.Write(num);
                            sw.Write(" ");
                        }
                        sw.WriteLine();
                    }
                }

                mainlbl.Text = "Done!";
                Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filenm_textbox.ResetText();
            updown_columns.Value = 1;
            updown_rows.Value = 1;
            updown_minnum.Value = 0;
            updown_maxnum.Value = 100;
            checkBox_columnsq.Checked = false;
            checkBox_rowsq.Checked = true;

            mainlbl.Text = "Set Parametrs";
            Refresh();

            filenm_textbox.Focus();
        }
    }
}
