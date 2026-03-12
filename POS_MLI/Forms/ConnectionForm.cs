using System;
using System.Drawing;
using System.Windows.Forms;
using POS_MLI.Models;
using POS_MLI.Services;
using DevExpress.XtraEditors;

namespace POS_MLI.Forms
{
    public partial class ConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        public ConnectionForm()
        {
            InitializeComponent();

            this.Text = "Server Connection";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            i
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtdbHost.Text) ||
                    string.IsNullOrWhiteSpace(txtdbProt.Text) ||
                    string.IsNullOrWhiteSpace(txtdbUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtdbDatabase.Text))
                {
                    XtraMessageBox.Show("Please fill all database information",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Loading load = new Loading();
                load.Show();
                load.Refresh();

                DbConfig config = new DbConfig()
                {
                    Host = txtdbHost.Text,
                    Port = txtdbProt.Text,
                    Username = txtdbUsername.Text,
                    Password = txtdbPassowrd.Text,
                    Database = txtdbDatabase.Text
                };

                bool connected = DatabaseService.Connect(config);

                load.Close();

                if (connected)
                {
                    XtraMessageBox.Show(
                        "Connected to PostgreSQL successfully",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show(
                        "Connection failed",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}