using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private int _startCellIndex = 0;
        private bool _isStartTuring = false;

        private int _stateIndex = 1;

        public MainForm()
        {
            InitializeComponent();

            ribbonDataGridView.ColumnCount = 1;
            ribbonDataGridView.Columns[0].HeaderText = "0 *";
            ribbonDataGridView.Rows.Add();
            ribbonDataGridView.RowHeadersVisible = false;

            commandDataGridView.ColumnCount = 1;
            commandDataGridView.Columns[0].HeaderText = "Q1";
            commandDataGridView.Rows.Add();
            commandDataGridView.Rows[0].HeaderCell.Value = " ";

            //ribbonDataGridView.CurrentCell.ColumnIndex;
            //ribbonDataGridView.Rows[0].Cells[i].Selected = true;

        }

        private void ChangeRibbonLenghtButton_Click(object sender, EventArgs e)
        {
            //Изменить длину ленты
            int newLeftBorder = (int)leftBorderRibbonNumericUpDown.Value;
            int newRightBorder = (int)rightBorderRibbonNumericUpDown.Value;

            int indexLastColumn = ribbonDataGridView.ColumnCount - 1;
            int oldLeftBorder = int.Parse(GetCellIndex(ribbonDataGridView.Columns[0].HeaderText));
            int oldRightBorder = int.Parse(GetCellIndex(ribbonDataGridView.Columns[indexLastColumn].HeaderText));

            while (oldLeftBorder < newLeftBorder)
            {
                ribbonDataGridView.Columns.RemoveAt(0);
                oldLeftBorder++;
            }

            while (oldLeftBorder > newLeftBorder)
            {
                DataGridViewTextBoxColumn normalColumn = new DataGridViewTextBoxColumn();
                ribbonDataGridView.Columns.Insert(0, normalColumn);
                normalColumn.HeaderText = (--oldLeftBorder).ToString();
            }

            while (oldRightBorder > newRightBorder)
            {
                ribbonDataGridView.Columns.RemoveAt(ribbonDataGridView.ColumnCount - 1);
                oldRightBorder--;
            }

            while (oldRightBorder < newRightBorder)
            {
                DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                ribbonDataGridView.Columns.Insert(ribbonDataGridView.ColumnCount, newColumn);
                newColumn.HeaderText = (++oldRightBorder).ToString();
            }

            //Изменить стартовую позицию
            ribbonDataGridView.Columns[_startCellIndex].HeaderText = _startCellIndex.ToString();
            ribbonDataGridView.Columns[(int)startCellNumericUpDown.Value].HeaderText += " *";
        }

        private string GetCellIndex(string header)
        {
            if (header.Contains('*'))
            {
                header = header.Remove(header.Length - 1);
            }

            return header;
        }

        private void ChangeCommandLenghtButton_Click(object sender, EventArgs e)
        {
            int newCountColumn = (int)commandLenghtNumericUpDown.Value;
            int oldCountColumn = commandDataGridView.ColumnCount;

            while (oldCountColumn < newCountColumn)
            {
                DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                commandDataGridView.Columns.Insert(oldCountColumn, newColumn);
                newColumn.HeaderText = "Q" + (++oldCountColumn).ToString();
            }

            while (oldCountColumn > newCountColumn)
            {
                commandDataGridView.Columns.RemoveAt(--oldCountColumn);
            }
        }

        private void AlphabetTextBox_TextChanged(object sender, EventArgs e)
        {
            string newAlphabet = alphabetTextBox.Text;

            for (int i = 0; i < newAlphabet.Length - 1; i++)
            {
                for (int j = i + 1; j < newAlphabet.Length; j++)
                {
                    if ( (newAlphabet[i] == newAlphabet[j]) || (newAlphabet[j] == ' ') )
                    {
                        newAlphabet = newAlphabet.Remove(j, 1);
                    }
                }
            }

            int selectionStart = alphabetTextBox.SelectionStart;
            alphabetTextBox.Text = newAlphabet;
            alphabetTextBox.SelectionStart = selectionStart;
        }

        private void AlphabetTextBox_Leave(object sender, EventArgs e)
        {
            string newAlphabet = alphabetTextBox.Text;

            for (int i = 0; i < commandDataGridView.Rows.Count; i++)
            {
                char headerValue = char.Parse(commandDataGridView.Rows[i].HeaderCell.Value.ToString());

                if ( (!newAlphabet.Contains(headerValue)) && (headerValue != ' ') )
                {
                    commandDataGridView.Rows.RemoveAt(i);
                }
            }

            for (int i = 0; i < newAlphabet.Length; i++)
            {
                bool isContains = false;

                for (int j = 0; j < commandDataGridView.Rows.Count; j++)
                {
                    if (newAlphabet[i].ToString() == commandDataGridView.Rows[j].HeaderCell.Value.ToString())
                    {
                        isContains = true;

                        if (i == j)
                        {
                            break;
                        }

                        DataGridViewRow row1 = commandDataGridView.Rows[j];
                        commandDataGridView.Rows.Remove(row1);
                        commandDataGridView.Rows.Insert(i, row1);
                    }
                }

                if (isContains)
                {
                    continue;
                }

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.HeaderCell.Value = newAlphabet[i].ToString();
                commandDataGridView.Rows.Insert(i, newRow);
            }

            commandDataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void ribbonDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = ribbonDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();

                string correctValue = null;

                foreach (char v in value)
                {
                    if (alphabetTextBox.Text.Contains(v))
                    {
                        correctValue = v.ToString();
                    }
                }

                ribbonDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = correctValue;
            }
            catch (Exception)
            {
            }
        }

        private void commandDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string comands = commandDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();

                string correctCondition = "";
                string correctMutableCharacter = "";
                string correctFloggedSide = "";

                bool isFindeCondition = false;
                bool isFindeMutableCharacter = false;
                bool isFindeFloggedSide = false;

                foreach (char comand in comands)
                {
                    if (!isFindeMutableCharacter)
                    {
                        if (alphabetTextBox.Text.Contains(comand))
                        {
                            isFindeMutableCharacter = true;
                            correctMutableCharacter += comand;
                        }
                        else
                        {
                            break;
                        }

                        continue;
                    }

                    if (!isFindeFloggedSide)
                    {
                        char floggedSide = char.ToUpper(comand);

                        if (floggedSide == '<' || floggedSide == '>' || floggedSide == '0' ||
                            floggedSide == 'R' || floggedSide == 'L' || floggedSide == 'H')
                        {
                            isFindeFloggedSide = true;
                            correctFloggedSide += floggedSide;
                        }
                        else
                        {
                            break;
                        }

                        continue;
                    }

                    if (int.TryParse(comand.ToString(), out int findeCondition))
                    {
                        correctCondition += comand;
                    }
                }

                if (correctCondition != "")
                {
                    if ((int)commandLenghtNumericUpDown.Value >= Convert.ToInt32(correctCondition))
                    {
                        isFindeCondition = true;
                    }
                }

                if (isFindeCondition && isFindeMutableCharacter && isFindeFloggedSide)
                {
                    commandDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = correctMutableCharacter + correctFloggedSide + "Q" + correctCondition;
                }
                else
                {
                    commandDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }                
            }
            catch (Exception)
            {
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isStartTuring = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isStartTuring = false;
        }

        private async void TuringStep()
        {
            if (_isStartTuring)
            {
                int mutableCharacterIndex = alphabetTextBox.Text.Length + 1;

                int indexSelectedColumn = ribbonDataGridView.CurrentCell.ColumnIndex;

                if (ribbonDataGridView.Rows[0].Cells[indexSelectedColumn] != null)
                {
                    char mutableCharacter = (char)ribbonDataGridView.Rows[0].Cells[indexSelectedColumn].Value;
                    mutableCharacterIndex = alphabetTextBox.Text.IndexOf(mutableCharacter);
                }

               // commandDataGridView.Rows[].Columns[_stateIndex]

                int speed = - speedTrackBar.Value * 1000;
                await Task.Delay(speed);
                TuringStep();
            }
        }
    }
}
