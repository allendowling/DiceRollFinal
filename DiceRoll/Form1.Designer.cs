namespace DiceRoll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rollButton = new System.Windows.Forms.Button();
            this._resultLabel = new System.Windows.Forms.Label();
            this.diceComboBox = new System.Windows.Forms.ComboBox();
            this.modifierTextBox = new System.Windows.Forms.TextBox();
            this.ModifierLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(102, 186);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // _resultLabel
            // 
            this._resultLabel.AutoSize = true;
            this._resultLabel.Location = new System.Drawing.Point(96, 228);
            this._resultLabel.Name = "_resultLabel";
            this._resultLabel.Size = new System.Drawing.Size(0, 13);
            this._resultLabel.TabIndex = 1;
            // 
            // diceComboBox
            // 
            this.diceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diceComboBox.FormattingEnabled = true;
            this.diceComboBox.Items.AddRange(new object[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20",
            "d100"});
            this.diceComboBox.Location = new System.Drawing.Point(12, 12);
            this.diceComboBox.Name = "diceComboBox";
            this.diceComboBox.Size = new System.Drawing.Size(76, 21);
            this.diceComboBox.TabIndex = 2;
            // 
            // modifierTextBox
            // 
            this.modifierTextBox.Location = new System.Drawing.Point(208, 13);
            this.modifierTextBox.Name = "modifierTextBox";
            this.modifierTextBox.Size = new System.Drawing.Size(64, 20);
            this.modifierTextBox.TabIndex = 3;
            this.modifierTextBox.Text = "0";
            // 
            // ModifierLabel
            // 
            this.ModifierLabel.AutoSize = true;
            this.ModifierLabel.Location = new System.Drawing.Point(213, 36);
            this.ModifierLabel.Name = "ModifierLabel";
            this.ModifierLabel.Size = new System.Drawing.Size(59, 13);
            this.ModifierLabel.TabIndex = 4;
            this.ModifierLabel.Text = "MODIFIER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ModifierLabel);
            this.Controls.Add(this.modifierTextBox);
            this.Controls.Add(this.diceComboBox);
            this.Controls.Add(this._resultLabel);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label _resultLabel;
        private System.Windows.Forms.ComboBox diceComboBox;
        private System.Windows.Forms.TextBox modifierTextBox;
        private System.Windows.Forms.Label _labelResult;
        private System.Windows.Forms.Label ModifierLabel;
    }
}
