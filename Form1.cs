namespace KenarlardanKirp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (comboBox1.SelectedItem != null)
            {
                string selectedDirection = comboBox1.SelectedItem.ToString();
                string[] lines = richTextBox1.Lines;

                int charactersToRemove;
                if (!int.TryParse(textBox1.Text, out charactersToRemove))
                {
                    MessageBox.Show("L�tfen ge�erli bir say� girin.");
                    return;
                }

                if (selectedDirection == "Sa�")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Length > charactersToRemove)
                            lines[i] = lines[i].Remove(lines[i].Length - charactersToRemove);
                        else
                            lines[i] = ""; 
                    }
                }
      
                else if (selectedDirection == "Sol")
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Length > charactersToRemove)
                            lines[i] = lines[i].Remove(0, charactersToRemove);
                        else
                            lines[i] = ""; 
                    }
                }

                richTextBox1.Lines = lines;
            }
            else
            {
                MessageBox.Show("L�tfen bir y�ntem se�in.");
            }

        
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sol");
            comboBox1.Items.Add("Sa�");
        }
    }
}
