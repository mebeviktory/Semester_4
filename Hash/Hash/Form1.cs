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

namespace Hash
{
    public partial class Form1 : Form
    {
        List<string> allWordsFromBook = new List<string>();
        List<string>[] MyDictionary;
        Dictionary<Int64, int> collisionsOfHashFunction = new Dictionary<Int64, int>();
        public int size = 257;
        public Form1()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        string path = openFileDialog1.FileName;
                        string book = File.ReadAllText(path);
                        BookReader(book);
                        NumberOfCollisionsTextBox.Text = "Book is loaded.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void BookReader(string book)
        {
            //string [] words = book.Split(new Char[] { ' ', ',', '.', ':', '\t', '\n', '!', '?', '-' , ';' , '\'', '"', '*'});
            string word = String.Empty;
            allWordsFromBook.Clear();
            for (int i = 0; i<book.Length; i++ )
            {
                if (!Char.IsLetter(book[i]))
                {
                    if (!allWordsFromBook.Contains(word))
                    {
                        allWordsFromBook.Add(word);
                    }
                    word = String.Empty;
                }
                else
                {
                    word += book[i];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberOfCollisionsTextBox.ResetText();
            collisionsOfHashFunction.Clear();
            MyDictionary = new List<string>[size];
            for (int i = 0; i < size; i++)
            {
                MyDictionary[i] = new List<string>();
            }
            int p = 31;
            foreach (string word in allWordsFromBook)
            {
                Int64 hash = 0;
                int sum = 0;
                int i = 1;
                foreach (char ch in word)
                {
                    int c = (int)ch;
                    sum += c*(p^i);
                    i++;
                }
                hash = (sum ^ 2) % size;
                addToDictionary(hash);
                MyDictionary[hash].Add(word);
            }
            printDictionary();
            collisionsOfHashFunction.Clear();
        }

        private void addToDictionary(Int64 hash)
        {
            if (collisionsOfHashFunction.ContainsKey(hash))
            {
                collisionsOfHashFunction[hash]++;
            }
            else
            {
                collisionsOfHashFunction.Add(hash, 1);
            }
        }

        private void printDictionary()
        {
            foreach (var pair in collisionsOfHashFunction.OrderBy(pair => pair.Key))
                NumberOfCollisionsTextBox.Text += "hash  " + pair.Key.ToString() + ", collision  " + pair.Value.ToString() + "\n";
            for(int i = 0; i < size; i++)
            {
                ListOfWordsTextBox.Text += "hash" + i.ToString() + "- list of words: ";
                foreach (string word in MyDictionary[i])
                {
                    ListOfWordsTextBox.Text += word.ToString() + ", ";
                }
                ListOfWordsTextBox.Text += "\n";
            }
            max.Text =  collisionsOfHashFunction.Values.Max().ToString();
            min.Text = collisionsOfHashFunction.Values.Min().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberOfCollisionsTextBox.Clear();
            collisionsOfHashFunction.Clear();
            MyDictionary = new List<string>[size];
            for (int i = 0; i < size; i++)
            {
                MyDictionary[i] = new List<string>();
            }
            float a = 0.61803F;
            foreach (string word in allWordsFromBook)
            {
                Int64 hash = 0;
                int sum = 1;
                int i = 1;
                foreach (char ch in word)
                {
                    int c = (int)ch;
                    sum *= c;
                    i++;
                }
                hash =Math.Abs((int)( size * ((sum*a)%1)));
                addToDictionary(hash);
                MyDictionary[hash].Add(word);
            }
            printDictionary();
            collisionsOfHashFunction.Clear();
        }

    }
}
