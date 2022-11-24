using System;
using System.Windows.Forms;

namespace Frogs_WindowsFormsApp
{
    public partial class Message : Form
    {
        public string Result;
        public Message()
        {
            InitializeComponent();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            
            if (Result == "24")
            {
                resultLabel.Text = "Вы победили с лучшим возможным результатом!";
            }
            else
            {
                resultLabel.Text = $"Вы победили, количество ходов - {Result}, но можно было справиться за 24!";
            }
        }
    }
}
