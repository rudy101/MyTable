using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTable
{
    public partial class Form1 : Form
    {
        MyTable pMyTable;
        Checker pChecker;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Console.WriteLine("Program started.");
            pMyTable = new MyTable();
            pChecker = new Checker();
            buttonAdd.Enabled = false;
            buttonGet.Enabled = false;
            buttonSet.Enabled = false;
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (pChecker.isThereInt(textBoxAdd.Text))
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            pMyTable.Add(int.Parse(textBoxAdd.Text));
            setTableInfo();
        }

        private void textBoxGet_TextChanged(object sender, EventArgs e)
        {
            if (pChecker.check(textBoxGet.Text))
            {
                buttonGet.Enabled = true;
            }
            else
            {
                buttonGet.Enabled = false;
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            try
            {
                setInfo(int.Parse(textBoxGet.Text), pMyTable.Get(int.Parse(textBoxGet.Text)));
            }
            catch (IndexOutOfRangeException)
            {
                System.Console.WriteLine("Index out of range.");
            }
        }

        private void setInfo(int index, int value)
        {
            labelIndexOfCurrentElement.Text = index.ToString();
            labelValueOfCurrentElement.Text = value.ToString();
        }

        private void textBoxSetIndex_TextChanged(object sender, EventArgs e)
        {
            if (pChecker.check(textBoxSetIndex.Text))
            {
                buttonSet.Enabled = true;
            }
            else
            {
                buttonSet.Enabled = false;
            }
        }

        private void textBoxSetValue_TextChanged(object sender, EventArgs e)
        {
            if (pChecker.isThereInt(textBoxSetValue.Text))
            {
                buttonSet.Enabled = true;
            }
            else
            {
                buttonSet.Enabled = false;
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            pMyTable.Set(int.Parse(textBoxSetIndex.Text), int.Parse(textBoxSetValue.Text));
            setTableInfo();
        }

        private void setTableInfo()
        {
            labelAllocatedSizeOfTable.Text = pMyTable.CurrentSize.ToString();
            labelSizeOfTable.Text = (pMyTable.IndexOfLast + 1).ToString();
        }
    }
}
