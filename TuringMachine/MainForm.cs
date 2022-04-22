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
        private readonly char[] _STEP_SYMBOLS_TO_R = { '>', 'R' };
        private readonly char[] _STEP_SYMBOLS_TO_L = { '<', 'L' };
        private readonly char[] _STEP_SYMBOLS_TO_S = { '0', 'H' };

        private int _startCellIndex = 0;
        private bool _isStartTuring = false;

        private int _stateIndex = 0;

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
            //Новые границы для счетчика стартовой позиции
            int newLeftBorder = (int)leftBorderRibbonNumericUpDown.Value;
            int newRightBorder = (int)rightBorderRibbonNumericUpDown.Value;

            startCellNumericUpDown.Maximum = newRightBorder;
            startCellNumericUpDown.Minimum = newLeftBorder;

            //Изменить длину ленты
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
            ChangeStartCell((int)startCellNumericUpDown.Value);
        }

        private string GetCellIndex(string header)
        {
            if (header.Contains('*'))
            {
                header = header.Remove(header.Length - 1);
            }

            return header;
        }

        private void ChangeStartCell(int newCell)
        {
            int oldStartCellInTableIndex = _startCellIndex - (int)leftBorderRibbonNumericUpDown.Value;
            int newStartCellInTableIndex = newCell - (int)leftBorderRibbonNumericUpDown.Value;

            ribbonDataGridView.Columns[oldStartCellInTableIndex].HeaderText = _startCellIndex.ToString();
            ribbonDataGridView.Columns[newStartCellInTableIndex].HeaderText += " *";
            _startCellIndex = newCell;

            startCellNumericUpDown.Value = newCell;
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
                string commands = commandDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString();

                bool isSplit = SplitToComands(commands, out string condition, out string mutableCharacter, out string floggedSide);

                if (isSplit)
                {
                    commandDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = mutableCharacter + floggedSide + "Q" + condition;
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

        private bool SplitToComands(string commands, out string condition, out string mutableCharacter, out string floggedSide)
        {
            condition = "";
            mutableCharacter = "";
            floggedSide = "";

            bool isFindeCondition = false;
            bool isFindeMutableCharacter = false;
            bool isFindeFloggedSide = false;

            foreach (char command in commands)
            {
                if (!isFindeMutableCharacter)
                {
                    if (alphabetTextBox.Text.Contains(command))
                    {
                        isFindeMutableCharacter = true;
                        mutableCharacter += command;
                    }
                    else
                    {
                        break;
                    }

                    continue;
                }

                if (!isFindeFloggedSide)
                {
                    char flogged = char.ToUpper(command);

                    if (_STEP_SYMBOLS_TO_R.Contains(flogged) || _STEP_SYMBOLS_TO_S.Contains(flogged) ||
                                                                        _STEP_SYMBOLS_TO_L.Contains(flogged))
                    {
                        isFindeFloggedSide = true;
                        floggedSide += flogged;
                    }
                    else
                    {
                        break;
                    }

                    continue;
                }

                if (int.TryParse(command.ToString(), out int findeCondition))
                {
                    condition += command;
                }
                else if (_STEP_SYMBOLS_TO_S.Contains(command))
                {
                    condition = command.ToString();
                    break;
                }
            }

            if (condition != "")
            {
                if (_STEP_SYMBOLS_TO_S.Contains(condition[0]) || (int)commandLenghtNumericUpDown.Value >= Convert.ToInt32(condition))
                {
                    isFindeCondition = true;
                }
            }

            return isFindeCondition && isFindeMutableCharacter && isFindeFloggedSide;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isStartTuring = true;
            TuringStep();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isStartTuring = false;
            _stateIndex = 0;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isStartTuring = false;
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isStartTuring = true;
            TuringStep();
            _isStartTuring = false;
        }

        private async void TuringStep()
        {
            if (_isStartTuring)
            {
                int mutableCharacterIndex = alphabetTextBox.Text.Length; //Инициализируем индексом пробела

                int startCell = _startCellIndex - (int)leftBorderRibbonNumericUpDown.Value; //Индекс стартового столюца

                if (ribbonDataGridView.Rows[0].Cells[startCell].Value != null)
                {
                    char fromMutableCharacter = Convert.ToChar(ribbonDataGridView.Rows[0].Cells[startCell].Value);
                    mutableCharacterIndex = alphabetTextBox.Text.IndexOf(fromMutableCharacter);
                }

                string commands = "";

                if (commandDataGridView.Rows[mutableCharacterIndex].Cells[_stateIndex].Value != null)
                {
                    commands = commandDataGridView.Rows[mutableCharacterIndex].Cells[_stateIndex].Value.ToString();
                }

                bool isSplit = SplitToComands(commands, out string condition, 
                            out string toMutableCharacter, out string floggedSide);

                if (isSplit)
                {
                    ribbonDataGridView.Rows[0].Cells[startCell].Value = toMutableCharacter;

                    if (_STEP_SYMBOLS_TO_L.Contains(floggedSide[0]))
                    {
                        if ((_startCellIndex - 1) < (int)leftBorderRibbonNumericUpDown.Value)
                        {
                            MessageBox.Show("Ошибка алгоритма");
                            _stateIndex = 0;
                            return;
                        }

                        ChangeStartCell(_startCellIndex - 1);
                    }
                    else if (_STEP_SYMBOLS_TO_R.Contains(floggedSide[0]))
                    {
                        if ((_startCellIndex + 1) > (int)rightBorderRibbonNumericUpDown.Value)
                        {
                            MessageBox.Show("Ошибка алгоритма");
                            _stateIndex = 0;
                            return;
                        }

                        ChangeStartCell(_startCellIndex + 1);
                    }

                    if (condition == "" || _STEP_SYMBOLS_TO_S.Contains(condition[0]))
                    {
                        MessageBox.Show("Алгоритм выполнен");
                        _stateIndex = 0;
                    }
                    else
                    {
                        _stateIndex = Convert.ToInt32(condition) - 1;

                        int speed = -speedTrackBar.Value * 1000;
                        await Task.Delay(speed);
                        TuringStep();
                    }
                }
                else
                {
                    MessageBox.Show("Для этой операции нет команды");
                    _stateIndex = 0;
                }
            }
        }

        private void кнопкаДляПростоТакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Просто так. Люблю кнопки!");
        }
    }
}
