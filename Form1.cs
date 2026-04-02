using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        string myID = "sungmin";
        string myPW = "superman";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인 성공");
            }
            else
            {
                // 틀리면 가차 없이 쫓아내부러야제!
                MessageBox.Show("로그인 실패");
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Gray;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Gray;
                txtPW.UseSystemPasswordChar = false;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPW.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



