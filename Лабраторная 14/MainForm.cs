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
            int count;
            int V = int.Parse(textBoxInput.Text);
            int index = Calc.IndexOf(ref MassivForBubble, V, out count);
            labelNumber.Text = "Номер: " + (index+1).ToString();
            label1.Text = "кол операций: " + count; 
            if (index != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Cells[1].Selected = true;
            }
        }

        private void buttonQiuckSort_Click(object sender, EventArgs e)
        {
            MassivForQSort = (int[])Massiv.Clone();
            Calc.QSort(ref MassivForQSort);
            OutputQSort();
        }

        private void buttonSelectionSort_Click(object sender, EventArgs e)
        {
            MassivForSelect = (int[])Massiv.Clone();
            Calc.SelectSort(ref MassivForSelect);
            OutputSelect();
        }

        private void buttonSortBubble_Click(object sender, EventArgs e)
        {
            MassivForBubble = (int[])Massiv.Clone();
            Calc.BubbleSort(ref MassivForBubble);
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
            int index = Calc.SimpleSearch(ref Massiv, V);
            labelNumber.Text = "Номер: " + (index + 1 ).ToString();
            if (index != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Cells[0].Selected = true;
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = (e.Row.Index + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int V = int.Parse(textBoxInput.Text);
            int index = Calc.SimpleSearch(ref MassivForBubble, V);
            labelNumber.Text = "Номер: " + (index + 1).ToString();
            if (index != -1)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Cells[1].Selected = true;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
