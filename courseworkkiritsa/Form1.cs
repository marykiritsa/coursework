﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseworkkiritsa
{
    public partial class Form1 : Form
    {
        DatabaseClass database = new DatabaseClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            String input = inputTextBox.Text;
            String checkInput = input;

            switch (chooseActionBox.Text)
            {
                case "русский в кириллицу":
                    foreach (KeyValuePair<string, string> pair in database.LettersTransliteration)
                    {
                        input = input.Replace(pair.Key, pair.Value);
                    }

                    if (checkInput.Equals(input))
                    {
                        resultTextBox.Text = "";
                        MessageBox.Show("Выбрано неверное действие");
                    }
                    else
                    {
                        resultTextBox.Text = input;
                    }

                    break;

                case "кириллицу в русский":
                    foreach (KeyValuePair<string, string> pair in database.LettersTransliteration)
                    {
                        input = input.Replace(pair.Value, pair.Key);
                    }

                    if (checkInput.Equals(input))
                    {
                        resultTextBox.Text = "";
                        MessageBox.Show("Выбрано неверное действие");
                    }
                    else
                    {
                        resultTextBox.Text = input;
                    }

                    break;

                case "в русский регистр":
                    foreach (KeyValuePair<string, string> pair in database.LettersKeyboard)
                    {
                        input = input.Replace(pair.Value, pair.Key);
                    }

                    if (checkInput.Equals(input))
                    {
                        resultTextBox.Text = "";
                        MessageBox.Show("Выбрано неверное действие");
                    }
                    else
                    {
                        resultTextBox.Text = input;
                    }

                    break;

                case "в английский регистр":
                    foreach (KeyValuePair<string, string> pair in database.LettersKeyboard)
                    {
                        input = input.Replace(pair.Key, pair.Value);
                    }

                    if (checkInput.Equals(input))
                    {
                        resultTextBox.Text = "";
                        MessageBox.Show("Выбрано неверное действие");
                    }
                    else
                    {
                        resultTextBox.Text = input;
                    }

                    break;

                default:
                    resultTextBox.Text = "";
                    MessageBox.Show("Пожалуйста выберите действие!");
                    break;
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            resultTextBox.Text = "";
            chooseActionBox.Text = "";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение поддерживает следующие функции: \n1) перевод введенного текста с кириллицы на русский язык \n2) перевод с русского языка на кириллицу \n3) перевод текста при вводе текста на русском языке и выбранном английском регистре на клавиатуре \n4) перевод текста при вводе текста на английском языке и выбранном русском регистре на клавиатуре");

        }
    }
}
