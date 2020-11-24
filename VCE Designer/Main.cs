using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCE_Designer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            saveFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            openFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {


            SaveFileDialog dialog = new SaveFileDialog();
            try
            {
                
                
                    DataSet ds = new DataSet(); // создаем пока что пустой кэш данных
                    DataTable dt = new DataTable(); // создаем пока что пустую таблицу данных
                    dt.TableName = "Test"; // название таблицы
                    dt.Columns.Add("ask"); // название колонок
                    dt.Columns.Add("answer");
                    dt.Columns.Add("bals");
                    ds.Tables.Add(dt); //в ds создается таблица, с названием и колонками, созданными выше

                    foreach (DataGridViewRow r in dataGridView1.Rows) // пока в dataGridView1 есть строки
                    {
                        DataRow row = ds.Tables["Test"].NewRow(); // создаем новую строку в таблице, занесенной в ds
                        row["ask"] = r.Cells[0].Value;  //в столбец этой строки заносим данные из первого столбца dataGridView1
                        row["answer"] = r.Cells[1].Value; // то же самое со вторыми столбцами
                        row["bals"] = r.Cells[2].Value; //то же самое с третьими столбцами
                        ds.Tables["Test"].Rows.Add(row); //добавление всей этой строки в таблицу ds.
                    }
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                    string filename = saveFileDialog1.FileName;
                
                ds.WriteXml(@filename);

                    MessageBox.Show("Тест сохранен!", "Успех!");
                
            }
            
            catch
            {
                MessageBox.Show("Невозможно сохранить файл теста.", "Ошибка.");
            }
        
        
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            //textBox1.Text = fileText;
            MessageBox.Show("Файл открыт","Успех", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filename);

                foreach (DataRow item in ds.Tables["Test"].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["ask"];
                    dataGridView1.Rows[n].Cells[1].Value = item["answer"];
                    dataGridView1.Rows[n].Cells[2].Value = item["bals"];
                }
            }
            catch
            {
                MessageBox.Show("Невозможно открыть файл теста.", "Ошибка.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox2.Text == ""|| textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Ошибка.");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int n = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox3.Text;
            }
            else
            {
                MessageBox.Show("Оберіть, що редагувати.", "Помилка.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Оберіть, що видалити.", "Помилка.");
            }
        }
    }
}
