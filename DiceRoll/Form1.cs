using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            diceComboBox.SelectedIndex = 5; // Sets default selection to d4
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int roll = RollDice(diceComboBox.SelectedItem.ToString());
            int modifier = 5;
            if (!int.TryParse(modifierTextBox.Text, out modifier))
            {
                MessageBox.Show("Invalid modifier. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = roll + modifier;
            string resultText = $"You rolled: {roll} + {modifier} = {result}";

            if (diceComboBox.SelectedItem.ToString() == "d20")
            {
                if (roll == 1)
                {
                    resultText += " Critical Fail";
                }
                else if (roll == 20)
                {
                    resultText += " Critical Hit";
                }
             }
            _resultLabel.Text = resultText;
        }

        private int RollDice(string diceType)
        {
            int sides = int.Parse(diceType.Substring(1));
            return random.Next(1, sides + 1);
        }
    }
}