namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Login = new Button();
            label1 = new Label();
            txtId = new TextBox();
            txtPw = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblError = new Label();
            Clear = new Button();
            ShowPw = new CheckBox();
            LockTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.Salmon;
            Login.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Login.ForeColor = SystemColors.ButtonFace;
            Login.Location = new Point(126, 282);
            Login.Name = "Login";
            Login.Size = new Size(260, 44);
            Login.TabIndex = 0;
            Login.Text = "로그인";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(126, 22);
            label1.Name = "label1";
            label1.Size = new Size(125, 47);
            label1.TabIndex = 1;
            label1.Text = "로그인";
            // 
            // txtId
            // 
            txtId.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtId.ForeColor = SystemColors.ScrollBar;
            txtId.Location = new Point(126, 135);
            txtId.Name = "txtId";
            txtId.Size = new Size(261, 35);
            txtId.TabIndex = 2;
            txtId.Text = "ID";
            txtId.TextChanged += txtId_TextChanged;
            txtId.Enter += txtId_Enter;
            txtId.KeyDown += txtId_KeyDown;
            txtId.Leave += txtId_Leave;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPw.ForeColor = SystemColors.ScrollBar;
            txtPw.Location = new Point(126, 215);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(261, 35);
            txtPw.TabIndex = 3;
            txtPw.Text = "Password";
            txtPw.Enter += txtPw_Enter;
            txtPw.KeyDown += txtPw_KeyDown;
            txtPw.Leave += txtPw_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(126, 105);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 4;
            label2.Text = "아이디";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(127, 187);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 5;
            label3.Text = "패스워드";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(110, 348);
            lblError.Name = "lblError";
            lblError.Size = new Size(290, 21);
            lblError.TabIndex = 6;
            lblError.Text = "아이디 혹은 비밀번호가 맞지 않습니다";
            lblError.Visible = false;
            // 
            // Clear
            // 
            Clear.BackColor = Color.AntiqueWhite;
            Clear.Location = new Point(297, 45);
            Clear.Name = "Clear";
            Clear.Size = new Size(89, 23);
            Clear.TabIndex = 7;
            Clear.Text = "입력 초기화";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // ShowPw
            // 
            ShowPw.AutoSize = true;
            ShowPw.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ShowPw.ForeColor = Color.LightCoral;
            ShowPw.Location = new Point(395, 217);
            ShowPw.Name = "ShowPw";
            ShowPw.Size = new Size(62, 34);
            ShowPw.TabIndex = 8;
            ShowPw.Text = "👁️";
            ShowPw.UseVisualStyleBackColor = true;
            ShowPw.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LockTimer
            // 
            LockTimer.Interval = 10000;
            LockTimer.Tick += LockTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(534, 403);
            Controls.Add(ShowPw);
            Controls.Add(Clear);
            Controls.Add(lblError);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private TextBox txtId;
        private TextBox txtPw;
        private Label label2;
        private Label label3;
        private Label lblError;
        private Button Clear;
        private CheckBox ShowPw;
        private System.Windows.Forms.Timer LockTimer;
    }
}
