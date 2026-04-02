namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string inputId = txtId.Text;          // 아이디 저장
            string inputPw = txtPw.Text;          // 비밀번호 저장

            if (inputId == "mangmoo2" && inputPw == "1234")      // 논리연산자&& 사용
            {
                lblError.Visible = false; // 에러 메시지 숨김
                MessageBox.Show("로그인에 성공하였습니다."); // 로그인 성공
            }
            else
            {
                lblError.Visible = true;  // messageBox 대신 에러 메세지
            }
        }

        private void txtPw_Enter(object sender, EventArgs e) // 비밀번호 검은 점으로 가리기 
        {
            if (txtPw.Text == "Password") // 처음 회색 비밀번호
            {
                txtPw.Text = ""; // 글자를 삭제
                txtPw.ForeColor = Color.Black; // 글자색 검정
                txtPw.UseSystemPasswordChar = true; // 가리기 시작
            }
        }

        private void txtPw_Leave(object sender, EventArgs e)
        {
            if (txtPw.Text == "")
            {
                txtPw.Text = "Password"; // 다시 비밀번호
                txtPw.ForeColor = Color.Gray; // 다시 회색
                txtPw.UseSystemPasswordChar = false; // 글자가 보이게
            }
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            if (txtId.Text == "ID") // 처음 회색 아이디
            {
                txtId.Text = ""; // 글자를 삭제
                txtId.ForeColor = Color.Black; // 글자색 검정
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "ID"; // 다시 아이디
                txtId.ForeColor = Color.Gray; // 다시 회색
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
