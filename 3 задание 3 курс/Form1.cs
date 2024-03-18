using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_задание_3_курс
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        public CalcDelegate Calc = null;

        private void AddElement_B_Click(object sender, EventArgs e)
        {
            try
            {
                string First = Convert.ToString(First_TB.Text);
                string Second = Convert.ToString(Second_TB.Text);
                if (string.IsNullOrWhiteSpace(First))
                {
                    First_TB.Focus();
                    throw new Exception(
                    "Первая вводимая строчка не должна быть пустой");
                }
                if (string.IsNullOrWhiteSpace(Second))
                {
                    Second_TB.Focus();
                    throw new Exception(
                    "Вторая вводимая строчка не должна быть пустой");
                }
                Spisok_CLB.Items.Add(new Element(First, Second,
                Spisok_CLB));
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Требуется исправление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void DelElement_B_Click(object sender, EventArgs e)
        {
            for (int i = Spisok_CLB.Items.Count - 1; i >= 0; i--)
                if (Spisok_CLB.GetItemChecked(i))
                {
                    if (Calc != null)
                    {
                        Element Item = Spisok_CLB.Items[i] as Element;
                        int nAfter = Calc.GetInvocationList().Length;
                        int nBefore;
                        do
                        {
                            nBefore = nAfter;
                            Calc -= Item.AddToMinLength;
                            Calc -= Item.ReplacingWithLongest;
                            if (Calc == null)
                                break;
                            nAfter = Calc.GetInvocationList().Length;
                        }
                        while (nBefore != nAfter);
                    }
                    Spisok_CLB.Items.RemoveAt(i);
                }

        }

        private void AddFirst_B_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Spisok_CLB.Items.Count; i++)
                if (Spisok_CLB.GetItemChecked(i))
                {
                    Element Item = Spisok_CLB.Items[i] as Element;
                    Calc += Item.AddToMinLength;
                }
        }

        private void AddSecond_B_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Spisok_CLB.Items.Count; i++)
                if (Spisok_CLB.GetItemChecked(i))
                {
                    Element Item = Spisok_CLB.Items[i] as Element;
                    Calc += Item.ReplacingWithLongest;
                }
        }

        private void DelFirst_B_Click(object sender, EventArgs e)
        {
            if (Calc != null)
                for (int i = 0; i < Spisok_CLB.Items.Count; i++)
                    if (Spisok_CLB.GetItemChecked(i))
                    {
                        Element Item = Spisok_CLB.Items[i] as Element;
                        int nAfter = Calc.GetInvocationList().Length;
                        int nBefore;
                        do
                        {
                            nBefore = nAfter;
                            Calc -= Item.AddToMinLength;
                            if (Calc == null)
                                return;
                            nAfter = Calc.GetInvocationList().Length;
                        }
                        while (nBefore != nAfter);
                    }
        }

        private void DelSecond_B_Click(object sender, EventArgs e)
        {
            if (Calc != null)
                for (int i = 0; i < Spisok_CLB.Items.Count; i++)
                    if (Spisok_CLB.GetItemChecked(i))
                    {
                        Element Item = Spisok_CLB.Items[i] as Element;
                        int nAfter = Calc.GetInvocationList().Length;
                        int nBefore;
                        do
                        {
                            nBefore = nAfter;
                            Calc -= Item.ReplacingWithLongest;
                            if (Calc == null)
                                return;
                            nAfter = Calc.GetInvocationList().Length;
                        }
                        while (nBefore != nAfter);
                    }

        }

        private void Clear_B_Click(object sender, EventArgs e)
        {
            Calc = null;
        }

        private void PrintResult(string s)
        {
            Result_TB.AppendText(s + Environment.NewLine);
        }

        private void Calc_B_Click(object sender, EventArgs e)
        {
            try
            {
                string Number = Convert.ToString(Number_TB.Text);
                Result_TB.Clear();
                if (Calc != null)
                    Calc(Number, PrintResult);
                else
                    PrintResult("Не назначено ни одной операции");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Требуется исправление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
