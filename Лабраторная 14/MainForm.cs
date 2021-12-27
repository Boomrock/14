using System;
using System.Windows.Forms;

namespace Лабраторная_14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static int N = 100; // Кол-во строк
        static int[] Massiv = new int[N];
        int[] MassivForBubble = new int[N];
        int[] MassivForSelect = new int[N];
        int[] MassivForQSort = new int[N];
        Random random = new Random();

        private void Create_Original_Massiv()
        { 
            for (int i = 0; i < N; i++)
            {
                Massiv[i] = random.Next(0, 100);
            }
        }
        
        private void OutputOriginalMassiv()
        {
            dataGridView1.RowCount = N;
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = Massiv[i].ToString();
            }
        }

       
        private void OutputBubble()
        {
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = MassivForBubble[i].ToString();
            }
        }
       
        private void OutputSelect()
        {
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = MassivForSelect[i].ToString();
            }
        }
        
        private void OutputQSort()
        {
            for (int i = 0; i < N; i++)
            {
                dataGridView1.Rows[i].Cells[3].Value = MassivForQSort[i].ToString();
            }
        }
       
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            int V = int.Parse(textBoxInput.Text);
            labelNumber.Text = "Номер: " + (Calc.IndexOf(ref MassivForBubble, V, 0, N)+1).ToString();
        }

        private void buttonQiuckSort_Click(object sender, EventArgs e)
        {
            MassivForQSort = (int[])Massiv.Clone();
            Calc.Create_QSort(ref MassivForQSort, 0, N - 1);
            OutputQSort();
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            MassivForSelect = (int[])Massiv.Clone();
            Calc.Create_Select(ref MassivForSelect);
            OutputSelect();
        }

        private void buttonSortBubble_Click(object sender, EventArgs e)
        {
            MassivForBubble = (int[])Massiv.Clone();
            Calc.Create_Bubble(ref MassivForBubble, ref N);
            OutputBubble();
        }

        private void buttonCreateMassiv_Click(object sender, EventArgs e)
        {
            Create_Original_Massiv();
            OutputOriginalMassiv();
        }

        private void buttonSimpleSearch_Click(object sender, EventArgs e)
        {
            int V = int.Parse(textBoxInput.Text);
            labelNumber.Text = "Номер: " + (Calc.SimpleSearch(ref Massiv, V) + 1).ToString();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }
    }
}
