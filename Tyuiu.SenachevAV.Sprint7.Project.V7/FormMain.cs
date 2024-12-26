using Tyuiu.SenachevAV.Sprint7.Project.V7.Lib;
using System.IO;
using System.Text;

namespace Tyuiu.SenachevAV.Sprint7.Project.V7
{
    public partial class FormMain_SAV : Form
    {
        public FormMain_SAV()
        {
            InitializeComponent();
            InfoGrid_SAV.RowCount = 100;
            InfoGrid_SAV.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                InfoGrid_SAV.Columns[i].Width = 130;
            }
            InfoGrid_SAV.Columns[2].Width = 180;
        }
        DataService ds = new DataService();
        public static string path = $@"{Directory.GetCurrentDirectory()}\Project\��������������.csv"; // ������� ���� ��� (� ��� 100 ��� ��������� ��� �Ш������ ���������� ������ ��� �Ѩ �٨ �� ����� ����� Ũ)

        private void Info_SAV_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSumPep_SAV_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { // ���������� ������� ���.
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMaxNumEnt_SAV_Click(object sender, EventArgs e)
        { // ��������� �� ����. �������
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 0);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }

        }

        private void InfoGrid_SAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBoxFiltr_SAV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSave_SAV_Click(object sender, EventArgs e)

        { // ����� ������� �������� �� ������ (��������), �� ������ ��������� ������ 86 � 88 ������
            if ((textBoxFIO_SAV.Text == "") || (textBoxAddEntrance_SAV.Text == "") || (textBoxSumFlatArea_SAV.Text == "") || (textBoxAddFlat_SAV.Text == "") || (textBoxSumPeople_SAV.Text == "") || (textBoxSumRoom_SAV.Text == "") || ((radioButtonBuy_SAV.Checked == false) && (radioButtonRent_SAV.Checked == false)))
                MessageBox.Show("�� ��� ���� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxAddEntrance_SAV.Text), Convert.ToInt32(textBoxAddFlat_SAV.Text)); // ������ ���������

                if (FlatBusy)
                    MessageBox.Show("������ �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (radioButtonBuy_SAV.Checked == true)
                            //����� � ��������� ������ 
                            str = $"{textBoxAddEntrance_SAV.Text};{textBoxAddFlat_SAV.Text};{textBoxFIO_SAV.Text};{textBoxSumPeople_SAV.Text};{textBoxSumFlatArea_SAV.Text};{textBoxSumRoom_SAV.Text};�������";
                        else
                            //����� � ��������� ������ 
                            str = $"{textBoxAddEntrance_SAV.Text};{textBoxAddFlat_SAV.Text};{textBoxFIO_SAV.Text};{textBoxSumPeople_SAV.Text};{textBoxSumFlatArea_SAV.Text};{textBoxSumRoom_SAV.Text};������";
                    }
                    File.AppendAllText(path, str + "\n");
                    textBoxFIO_SAV.Text = "";
                    textBoxAddEntrance_SAV.Text = "";
                    textBoxSumFlatArea_SAV.Text = "";
                    textBoxAddFlat_SAV.Text = "";
                    textBoxSumPeople_SAV.Text = "";   
                    textBoxSumRoom_SAV.Text = "";                             // �������� ������ �� ��������� �����, ���������� �� � ����
                    radioButtonBuy_SAV.Checked = false;
                    radioButtonRent_SAV.Checked = false;
                    string[,] DataMatrix = ds.GetMatrix(path);
                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);
                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            InfoGrid_SAV.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            InfoGrid_SAV.Rows[r].Cells[c].Value = DataMatrix[r, c]; // ������ ���������� �� ���������� �������, ���� �������� � �������� ��� ����
                        }
                    }
                    MessageBox.Show("����� ������ ���������������!", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            FormHelp_SAV formHelp = new FormHelp_SAV();
            formHelp.ShowDialog();
        }

        private void textBoxFIO_SAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApplication_SAV_Click(object sender, EventArgs e)
        {
            FormAbout_SAV formAbout_SAV = new FormAbout_SAV();
            formAbout_SAV.ShowDialog();
        }

        private void buttonFile_SAV_Click(object sender, EventArgs e)
        {
            openFileDialog_SAV.ShowDialog();
            string FileName = openFileDialog_SAV.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
            buttonMaxSumPeople_SAV.Enabled = true;
            buttonMaxNumEnt_SAV.Enabled = true;
            buttonMaxNumFlat_SAV.Enabled = true;
            buttonMinSumPeople_SAV.Enabled = true;
            buttonMinNumEnt_SAV.Enabled = true;
            buttonMinNumFlat_SAV.Enabled = true;
        }

        private void buttonMaxSumPeople_SAV_Click(object sender, EventArgs e)
        { // ���������� �� ���-�� ������� ����
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void buttonDel_SAV_Click(object sender, EventArgs e) // �������� �� ������ �������
        {
            if ((textBoxNumEntDel_SAV.Text == "") || (textBoxNumFlatDel_SAV.Text == ""))
            {
                MessageBox.Show("�� ��� ���� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool FlatBusy = ds.FlatExist(path, Convert.ToInt32(textBoxNumEntDel_SAV.Text), Convert.ToInt32(textBoxNumFlatDel_SAV.Text));

                if (FlatBusy == false)
                    MessageBox.Show("����� �������� ��� � ���� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string[] strRows = File.ReadAllLines(path);

                    for (int i = 0; i < strRows.Length; i++)
                    {
                        string[] strIndex = strRows[i].Split(';');
                        if ((strIndex[0] == textBoxNumEntDel_SAV.Text) && (strIndex[1] == textBoxNumFlatDel_SAV.Text))
                            strRows[i] = "";
                    }
                    strRows = strRows.Where(i => i != "").ToArray();

                    File.Delete("��������������.csv");

                    saveFileDialog_SAV.FileName = "��������������.csv";
                    saveFileDialog_SAV.ShowDialog();

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            InfoGrid_SAV.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            InfoGrid_SAV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("���������� �������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxNumEntDel_SAV.Text = "";
            textBoxNumFlatDel_SAV.Text = "";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonMaxNumFlat_SAV_Click(object sender, EventArgs e)
        {  // ���������� �� ��.� ����
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 4);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void buttonMinNumFlat_SAV_Click(object sender, EventArgs e)
        { // ���������� �� ��.� ���
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 4);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void buttonMinSumPeople_SAV_Click(object sender, EventArgs e)
        { // ���������� �� ��.� ����
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    InfoGrid_SAV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
        }

        private void radioButtonBuy_SAV_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
