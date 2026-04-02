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
            Login = new Button();
            label1 = new Label();
            txtId = new TextBox();
            txtPw = new TextBox();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.MintCream;
            Login.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Login.Location = new Point(168, 281);
            Login.Name = "Login";
            Login.Size = new Size(173, 44);
            Login.TabIndex = 0;
            Login.Text = "로그인";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("휴먼둥근헤드라인", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(168, 50);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // txtId
            // 
            txtId.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtId.ForeColor = SystemColors.ScrollBar;
            txtId.Location = new Point(126, 154);
            txtId.Name = "txtId";
            txtId.Size = new Size(261, 35);
            txtId.TabIndex = 2;
            txtId.Text = "아이디";
            txtId.TextChanged += txtId_TextChanged;
            txtId.Enter += txtId_Enter;
            txtId.Leave += txtId_Leave;
            // 
            // txtPw
            // 
            txtPw.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPw.ForeColor = SystemColors.ScrollBar;
            txtPw.Location = new Point(126, 212);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(261, 35);
            txtPw.TabIndex = 3;
            txtPw.Text = "비밀번호";
            txtPw.Enter += txtPw_Enter;
            txtPw.Leave += txtPw_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(534, 403);
            Controls.Add(txtPw);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private Label label1;
        private TextBox txtId;
        private TextBox txtPw;
    }
}
