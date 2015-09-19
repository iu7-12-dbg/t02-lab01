using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDist_Click(object sender, EventArgs e)
        {
            if (edtSource.Text.Length == 0)
            {
                MessageBox.Show("Введите данные в поле исходной строки!");
                return;
            }

            if (edtComp.Text.Length == 0)
            {
                MessageBox.Show("Введите данные в поле сравниваемой строки!");
                return;
            }

            string source = edtSource.Text;
            string comp = edtComp.Text;
            edtResult.Text = "Ждите...";
            btnDist.Enabled = false;

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate (object o)
                {
                    long mem = 0;

                    int dist = StringDistCalc.levenshteinDist(source, comp);
                    int dist2 = StringDistCalc.levenshteinDistStack(source, comp);
                    int dist3 = StringDistCalc.damerauLevensteinDistance(source, comp);
                    int dist4 = StringDistCalc.levenshteinDistMatrix(source, comp);

                    Invoke(new Action(delegate()
                        {
                            btnDist.Enabled = true;
                            edtResult.Text = String.Format("{0} = {1} = {2} = {3}", dist, dist2, dist3, dist4);
                        }));
                }));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
