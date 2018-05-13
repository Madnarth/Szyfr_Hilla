using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szyfr_Hilla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };
        int[,] matrixK = new int [2,2];
        int[,] invertedMatrixK = new int[2, 2];
        int[,] matrixM;
        int[,] matrixC;
        #region Preview events  //Protect from entering wrong symbols to text boxes
        private void tbKey1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void tbKey1_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
                e.Handled = true;            
        }
        private void tbKey2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void tbKey2_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
                e.Handled = true;
        }
        private void tbKey3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void tbKey3_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
                e.Handled = true;
        }
        private void tbKey4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void tbKey4_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Paste)
                e.Handled = true;
        }
        private void tbText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-z]");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion

        private int[,] BuildKeyMatrix(int[,] _matrix, int _key1, int _key2, int _key3, int _key4)
        {
            _matrix[0, 0] = _key1;
            _matrix[0, 1] = _key2;
            _matrix[1, 0] = _key3;
            _matrix[1, 1] = _key4;

            return _matrix;
        }
        private int CharCountWithoutSpaces(string str)
        {
            string[] arr = str.Split(' ');
            string allChars = "";
            foreach (string s in arr)
            {
                allChars += s;
            }
            int length = allChars.Length;
            return length;
        }
        private int[,] CalculateMatrixM(char[] _text, int _textLenght)
        {
            int[,] outputMatrix = new int[2, _textLenght / 2];
            int counter = 0;

            for (int i = 0; i < outputMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < outputMatrix.GetLength(0); j++)
                {                                            
                    if (Char.IsLetter(_text[counter]))
                        outputMatrix[j, i] = Array.IndexOf(alphabet, _text[counter]);
                    counter++;
                }
            }
            return outputMatrix;
        }
        private int[,] CalculateMatrixC(int[,] _matrixM, int[,] _matrixK)
        {
            int[,] outputMatrix = new int[_matrixM.GetLength(0), _matrixM.GetLength(1)];

            for (int j = 0; j < outputMatrix.GetLength(1); j++)
            {
                //for (int i = 0; i < outputMatrix.GetLength(0); i++)
                //{
                    outputMatrix[0, j] = ((_matrixK[0, 0] * _matrixM[0, j]) + (_matrixK[0, 1] * _matrixM[1, j])) % 26;
                    outputMatrix[1, j] = ((_matrixK[1, 0] * _matrixM[0, j]) + (_matrixK[1, 1] * _matrixM[1, j])) % 26;
                    //outputMatrix[i, j] = (_matrixK[i, j+1] * _matrixM[i, j]) + (_matrixK[i, j + 1] * _matrixM[i, j + 1]);
                //}
            }
            return outputMatrix;
        }
        private string TextEncryption(int[,] _inputMatrix)
        {
            string output = "";
            for (int i = 0; i < _inputMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < _inputMatrix.GetLength(0); j++)
                {
                    output += alphabet[_inputMatrix[j, i]];
                }
            }
            return output;
        }
        private int[,] KeyInversion(int[,] _inputMatrix)
        {
            int temp;

            temp = _inputMatrix[1, 1];
            _inputMatrix[1, 1] = _inputMatrix[0, 0];
            _inputMatrix[0, 0] = temp;

            _inputMatrix[1, 0] = 26 + (_inputMatrix[1, 0] * (-1));
            _inputMatrix[0, 1] = 26 + (_inputMatrix[0,1] * (-1));

            return _inputMatrix;
        }
        private void bExec_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = "";

            try
            {
                if (string.IsNullOrWhiteSpace(tbKey1.Text) || string.IsNullOrWhiteSpace(tbKey2.Text) || string.IsNullOrWhiteSpace(tbKey3.Text) || string.IsNullOrWhiteSpace(tbKey4.Text))
                    throw new Exception("Wszystkie komórki klucza muszą być zapełnione " + Environment.NewLine + "Popraw klucz");

                if (CharCountWithoutSpaces(tbInput.Text) % 2 != 0)
                    throw new Exception("Dla klucza długości 2 ilość liter powinna być podzielna przez 2" + Environment.NewLine + "Popraw tekst");

                matrixK = BuildKeyMatrix(matrixK, Int32.Parse(tbKey1.Text), Int32.Parse(tbKey2.Text), Int32.Parse(tbKey3.Text), Int32.Parse(tbKey4.Text));
                try
                {
                    switch (combOption.SelectedIndex)
                    {
                        case 0:
                            {
                                matrixM = CalculateMatrixM(tbInput.Text.ToCharArray(), CharCountWithoutSpaces(tbInput.Text));

                                matrixC = CalculateMatrixC(matrixM, matrixK);

                                tbOutput.Text = TextEncryption(matrixC);

                                break;
                            }
                        case 1:
                            {
                                if (combOption.SelectedIndex == 1)
                                {
                                    int temp = (Int32.Parse(tbKey1.Text) * Int32.Parse(tbKey4.Text)) - (Int32.Parse(tbKey2.Text) * Int32.Parse(tbKey3.Text));
                                    if (temp != 1 && temp != 3 && temp != 5 && temp != 7 && temp != 9 && temp != 11 && temp != 15 && temp != 17 && temp != 19 && temp != 21 && temp != 23 && temp != 25)
                                        throw new Exception("Wyznacznik macierzy klucza nieprawidłowy" + Environment.NewLine + "Niemożliwe odwrócenie macierzy");
                                }
                                invertedMatrixK = KeyInversion(matrixK);

                                matrixM = CalculateMatrixM(tbInput.Text.ToCharArray(), CharCountWithoutSpaces(tbInput.Text));

                                matrixC = CalculateMatrixC(matrixM, invertedMatrixK);

                                tbOutput.Text = TextEncryption(matrixC);

                                break;
                            }
                        default: break;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
