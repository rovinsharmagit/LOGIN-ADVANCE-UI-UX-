using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_LOGIN
{
    public partial class frmlogin : Form
    {
        int mov;
        int movX;
        int movY;
        public frmlogin()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }
        SqlConnection SqlConn = new SqlConnection("Data Source=DESKTOP-BPFHEQB\\HUSTLE_ROGER;Initial Catalog=cmblogin;Integrated Security=True");
        
        private void frmlogin_Load(object sender, EventArgs e)
        {
        }

        private void pnlfrmlogintop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlfrmlogintop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pnlfrmlogintop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pctboxexit_MouseHover(object sender, EventArgs e)
        {
            pctboxexit.BackColor = Color.Red;
        }

        private void pctboxexit_MouseLeave(object sender, EventArgs e)
        {
            pctboxexit.BackColor = Color.MediumSeaGreen;
        }

        private void pctboxexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text  =  DateTime.Now.ToString (("ddd, dd MMM yyy, hh:mm:ss tt '[GMT +05:30]'"));
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString(("ddd, dd MMM yyy, hh:mm:ss tt '[GMT +05:30]'"));
        }

        private void lblexit_MouseHover(object sender, EventArgs e)
        {
            lblexit.BackColor = Color.Red;
        }

        private void lblexit_MouseLeave(object sender, EventArgs e)
        {
            lblexit.BackColor = Color.White;

        }

        private void lblreset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }
        private void txtusername_Enter(object sender, EventArgs e)
        {
            txtusername.Text = "";
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            txtpassword.Text = "";
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
            }
        }
        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                btnshows.BringToFront();
                txtpassword.PasswordChar = '*';
            }

        }

        private void btnshows_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')

            {
                btnhide.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }
         
        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BPFHEQB\\HUSTLE_ROGER;Initial Catalog=cmblogin;Integrated Security=True");
            String username,password;   
            username = txtusername.Text;
            password = txtpassword.Text;
            try
            {
                string query = "select * from login where username = '"+txtusername.Text+"' And password = '"+txtpassword.Text+"'  ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtusername.Text;
                    password=txtpassword.Text;
                    frmdashboard Form2 = new frmdashboard();
                    Form2.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid Login Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtusername.Clear();    
                    txtpassword.Clear();    
                    txtusername.Focus();    

                }





            }
            catch 
            {
                MessageBox.Show("Invalid Username Or Password ");

                
            }
            finally
            {
                con.Close();
            }          
            
                
            

        }

        private void pnlfrmlogintop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

