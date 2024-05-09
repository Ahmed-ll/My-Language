using com.calitha.goldparser;

namespace Orint
{
    public partial class Form1 : Form
    {
        MyParser Parsser;
        public Form1()
        {
            InitializeComponent();
            Parsser = new MyParser("MyLanguage.cgt", list_box1, list_box2);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            list_box1.Items.Clear();
            list_box2.Items.Clear();
            Parsser.Parse(text_box.Text);
        }
    }
}
