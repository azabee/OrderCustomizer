namespace OrderCustomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //TryParse on p.235

                //Ham sandwich
                if (HamRadioButton.Checked && cheeseRadioButton.Checked)
                {
                    MessageBox.Show("You picked a Ham and Cheese sandwich!");
                }
                    else if (HamRadioButton.Checked && tomatoRadioButton.Checked)
                    {
                    MessageBox.Show("You picked a Ham and Tomato sandwich!");
                    }
                        else if (HamRadioButton.Checked && LettuceRadioButton.Checked)
                        {
                    MessageBox.Show("You picked a Ham and Lettuce sandwich!");
                        }

                //Turkey sandwich
                if (TurkeyRadioButton.Checked && cheeseRadioButton.Checked)
                {
                    MessageBox.Show("You picked a Turkey and Cheese sandwich!");
                }
                    else if (TurkeyRadioButton.Checked && tomatoRadioButton.Checked)
                    {
                    MessageBox.Show("You picked a Turkey and Tomato sandwich!");
                    }
                        else if (TurkeyRadioButton.Checked && LettuceRadioButton.Checked)
                        {
                    MessageBox.Show("You picked a Turkey and Lettuce sandwich!");
                        }

                //Veggie sandwich
                if (veggieRadioButton.Checked && cheeseRadioButton.Checked)
                {
                    MessageBox.Show("You picked a Veggie and Cheese sandwich!");
                }
                    else if (veggieRadioButton.Checked && tomatoRadioButton.Checked)
                    {
                    MessageBox.Show("You picked a Veggie and Tomato sandwich!");
                    }
                        else if (veggieRadioButton.Checked && LettuceRadioButton.Checked)
                        {
                    MessageBox.Show("You picked a Veggie and Lettuce sandwich!");
                        }

            }
            catch (Exception ex)
            {

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
