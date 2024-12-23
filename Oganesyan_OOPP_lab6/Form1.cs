﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oganesyan_OOPP_lab6
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Book
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Title;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Author;

            [MarshalAs(UnmanagedType.I4)]
            public int Release_Year;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Publishing_House;

            [MarshalAs(UnmanagedType.Bool)]
            public bool In_Stock;

            [MarshalAs(UnmanagedType.R8)]
            public double Rating;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Link;
        }

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        private static extern void LoadLibraryBooks(string filename);

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        private static extern void SaveBooks(string filename);

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        private static extern int GetLibrarySize();

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern bool DeleteBook(int id);

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern void Clear();

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern void UpdateBook(ref Book book, int id);

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern void AddBook(int param);

        [DllImport(@"C:\Users\egiaz\Documents\GitHub\Oganesyan_OOPP_Dll\Oganesyan_OOPP_lab6\x64\Debug\Oganesyan_Dll.dll", CharSet = CharSet.Ansi)]
        public static extern void GetBook(ref Book book, int id);


        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите, какую добавить книгу.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selected = listBox1.SelectedIndex;
            var beforeEditBook = new Book();
            GetBook(ref beforeEditBook, selected);

            try
            {
                if (string.IsNullOrEmpty(title.Text) || string.IsNullOrEmpty(publishing_house.Text))
                {
                    MessageBox.Show("У книги должно быть название и издательство.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Convert.ToInt32(release_year.Text) < 1700 || Convert.ToInt32(release_year.Text) > 2024)
                {
                    MessageBox.Show("Год должен быть целым числом от 1700 до 2024.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                beforeEditBook.Title = title.Text;
                beforeEditBook.Author = author.Text;
                beforeEditBook.Release_Year = Convert.ToInt32(release_year.Text);
                beforeEditBook.Publishing_House = publishing_house.Text;
                beforeEditBook.In_Stock = Convert.ToBoolean(in_stock.Text);
                beforeEditBook.Rating = Convert.ToDouble(rating.Text);

                if (link.Visible)
                {
                    if (string.IsNullOrEmpty(link.Text) || string.IsNullOrEmpty(link.Text))
                    {
                        MessageBox.Show("У электронной книги должна быть ссылка.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    beforeEditBook.Link = link.Text;
                }
                else
                {
                    beforeEditBook.Link = "";
                }
            }
            catch
            {
                MessageBox.Show("Рейтинг должен быть числом от 0,0 до 5,0.", "Некорректные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateBook(ref beforeEditBook, selected);
            UpdateListBox();
            listBox1.SelectedIndex = selected;
            ToggleButtons(true);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var book = new Book();
            GetBook(ref book, listBox1.SelectedIndex);
            title.Text = book.Title;
            author.Text = book.Author;
            release_year.Text = book.Release_Year.ToString();
            publishing_house.Text = book.Publishing_House;
            in_stock.Text = book.In_Stock.ToString();
            rating.Text = book.Rating.ToString();

            if (!string.IsNullOrEmpty(book.Link))
            {
                link.Text = book.Link;
                label7.Visible = true;
                link.Visible = true;
            }
            else
            {
                link.Clear();
                label7.Visible = false;
                link.Visible = false;
            }

            title.Enabled = true;
            author.Enabled = true;
            release_year.Enabled = true;
            publishing_house.Enabled = true;
            in_stock.Enabled = true;
            rating.Enabled = true;
        
        }
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < GetLibrarySize(); i++)
            {
                var book = new Book();
                GetBook(ref book, i);
                listBox1.Items.Add(book.Title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook(0);
            UpdateListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            link.Clear();
            label7.Visible = false;
            link.Visible = false;

            ToggleButtons(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddBook(1);
            UpdateListBox();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            link.Text = "";
            label7.Visible = true;
            link.Visible = true;

            ToggleButtons(false);
        }

        private void ToggleButtons(bool enable)
        {
            button1.Enabled = enable;
            button4.Enabled = enable;
            button2.Enabled = enable;
            button6.Enabled = enable;
            button3.Enabled = enable;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите книгу для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DeleteBook(listBox1.SelectedIndex))
            {
                int beforeDelete = listBox1.SelectedIndex;
                UpdateListBox();
                if (beforeDelete != listBox1.Items.Count)
                {
                    listBox1.SelectedIndex = beforeDelete;
                }
                else
                {
                    listBox1.SelectedIndex = beforeDelete - 1;
                }
            }
            if (GetLibrarySize() == 0)
            {
                title.Text = "";
                author.Text = "";
                release_year.Text = "";
                publishing_house.Text = "";
                in_stock.Text = "";
                rating.Text = "";
                link.Text = "";
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateListBox();
            ToggleButtons(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files (*.dat)|*.dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                LoadLibraryBooks(filename);
                UpdateListBox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files (*.dat)|*.dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                SaveBooks(filename);
            }
        }

        private void title_TextChanged(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {}
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {}
    }
}