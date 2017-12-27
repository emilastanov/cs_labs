using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DamerauLivensteinLib;
namespace bcit_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Lab5";
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private List<string> list=new List<string>();
            
        private void buttonLoad_Click(object sender, EventArgs e)
        {
           OpenFileDialog fd = new OpenFileDialog();
           fd.Filter = "текстовые файлы|*.txt";

           if (fd.ShowDialog() == DialogResult.OK)
           {
           Stopwatch t = new Stopwatch();
           t.Start();
            //Чтение файла в виде строки
            string text = File.ReadAllText(fd.FileName);
            //Разделительные символы для чтения из файла
            char[] separators = new char[] {' ','.',',','!','?','/','\t','\n'};
            string[] textArray = text.Split(separators);
               foreach (string strTemp in textArray)
               {
                   //Удаление пробелов в начале и конце строки
                   string str = strTemp.Trim();
                   //Добавление строки в список, если строка не содержится в списке
                   if (!list.Contains(str)) list.Add(str);
               }
               t.Stop();
               this.textBoxElapsedTime.Text = t.Elapsed.ToString();
               this.textBoxCountWords.Text = list.Count.ToString();
           } else
           {
               MessageBox.Show("Необходимо выбрать файл");
           }
        }

        private void buttonExact_Click(object sender, EventArgs e)
        {
            //слово из поисковой строки
            string word = this.textBoxFind.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
 
            

            int maxDist;            if(!int.TryParse(this.textBoxMaxDist.Text.Trim(),out maxDist))
            {
                MessageBox.Show("Необходимо указать максимальное расстояние");
                return;
            }            if (maxDist < 1 || maxDist > 5)
            {
            MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
            return;
            }
            //Слово для поиска в верхнем регистре
            string wordUpper = word.ToUpper();
            //Временные результаты поиска
            List<Tuple<string, int>> tempList = new List<Tuple<string,int>>();
            Stopwatch t = new Stopwatch();
            t.Start();       
            foreach (string str in list)
                {
                   int dist= DamerauLivenstein.Distance(str.ToUpper(),wordUpper);
                //Если расстояние меньше порогового, то слово добавляется в результат
                if (dist <= maxDist)
                   {
                    tempList.Add(new Tuple<string, int>(str, dist));
                   }
                 }
            t.Stop();
            this.labelSearch.Text= t.Elapsed.ToString();

            this.listBoxResult.BeginUpdate();
            //Очистка списка
            this.listBoxResult.Items.Clear();
            //Вывод результатов поиска
            foreach (var x in tempList)
            {
                string temp = x.Item1 + "(расстояние=" + x.Item2.ToString() +")";
                this.listBoxResult.Items.Add(temp);
            }
            this.listBoxResult.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
    }
   }
}
