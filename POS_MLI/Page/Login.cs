using POS_MLI.Forms;
using System.Drawing;
using System.Windows.Forms;
using POS_MLI.Services;
using POS_MLI.Models;
using System;
using System.Linq;
using POS_MLI.Utils;

namespace POS_MLI.Page
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private string Username;
        private string Password;

        private string host = "191.111.3.2";
        private string port = "5432";
        private string user = "postgres";
        private string pass = "p@ssw0rd";
        private string data = "pgpos_tk";

        public Login()
        {
            InitializeComponent();


            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            txtUsername.Focus();

            DbConfig config = new DbConfig()
            {
                Host = host,
                Port = port,
                Username = user,
                Password = pass,
                Database = data
            };

            bool connected = DatabaseService.Connect(config);

            if (connected)
            {
                try
                {
                    // ดึงข้อมูล branch server ตาม ip
                    var branch = DatabaseService.QueryFirst<Branchserver_fixip>(
                        "SELECT * FROM security.branchserver_fixip bf WHERE ip_address = @ipaddress",
                        new { ipaddress = host }
                    );

                    if (branch != null)
                    {
                        // แสดง branch name
                        label_barch.Text = branch.branchname; // property ต้องตรงกับ class
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลในฐานข้อมูล", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label_barch.Text = "ไม่พบสาขา";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Config Error: ไม่สามารถเชื่อมต่อฐานข้อมูลได้", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;

            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("ກະລຸນາປ້ອນຊື່ຜູ້ໃຊ້ງານ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດຜ່ານ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string passwordHead = Md5Hasher.Hash(Password);
                var user = DatabaseService.Query<tb_user>(
                    "SELECT * FROM public.tb_user WHERE user_username = @username AND user_password = @passowrd",
                new
                {
                    username = Username,
                    passowrd = passwordHead
                }
                ).FirstOrDefault();

                if (user != null )
                {
                    MessageBox.Show("Login success");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("ເກີດຂໍ້ຜິດພາດ:" + ex.Message , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            ConnectionForm frm = new ConnectionForm();
            frm.ShowDialog();
        }
    }
}
