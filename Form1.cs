namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int failCount = 0; // 실패 횟수 저장

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string inputId = txtId.Text;          // 아이디 저장
            string inputPw = txtPw.Text;          // 비밀번호 저장

            if (!IsValidInput(inputId, inputPw)) { lblError.Visible = true; return; } // 검사 

            if (inputId == "mangmoo2" && inputPw == "1234!")      // 논리연산자&& 사용
            {
                lblError.Visible = false; // 에러 메시지 숨김
                failCount = 0; // 성공 시 횟수 초기화
                MessageBox.Show("로그인에 성공하였습니다."); // 로그인 성공
            }
            else
            {
                failCount++; //실패카운트
                lblError.Visible = true;  // messageBox 대신 에러 메세지

                if (failCount >= 3)
                {
                    Login.Enabled = false; // 버튼 비활성화
                    lblError.Text = "3회 실패! 10초 후 재시도하세요.";

                    // 타이머 실행 (아래 3단계 참고)
                    LockTimer.Start();
                }
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

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter 키를 누르면
            {
                txtPw.Focus(); // 비밀번호 입력창으로 포커스 이동
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Click(sender, e); // 로그인 버튼 실행
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";    //아이디 초기화
            txtPw.Text = "";    //비밀번호 초기화
            lblError.Visible = false; // 에러 메시지도 숨김
            txtId.Focus();      //아이디 TestBox로 이동
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPw.Checked)
            {
                txtPw.UseSystemPasswordChar = false; // 체크박스가 체크되어 있으면 글자가 보이고
            }
            else
            {
                if (txtPw.Text != "Password")
                {
                    txtPw.UseSystemPasswordChar = true; // 아니면 가리기 
                }
            }
        }

        private bool IsValidInput(string id, string pw)
        {
            if (id.Contains(" ") || id == "ID") //아이디에 공백이 있는지 체크
            {
                lblError.Text = "아이디에 공백을 넣을 수 없습니다.";
                return false;
            }

            if (!pw.Contains("!"))
            {
                lblError.Text = "비밀번호에 '!'가 반드시 포함되어야 합니다."; // 비밀번호에 '!'가 포함되어야 함
                return false;
            }

            return true;
        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            LockTimer.Stop();     // 타이머 중지
            Login.Enabled = true; // 버튼 다시 활성화
            failCount = 0;        // 횟수 초기화
            lblError.Text = "다시 시도할 수 있습니다.";
        }

        private void LockTimer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
