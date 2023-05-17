using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Globalization;

namespace IT_list_wfapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConn = "Server=DESKTOP-O6O2RKO;" +
                    "Database=IT_companies_UKR;" +
                    "Trusted_Connection=True;" +
                    "TrustServerCertificate=True;";

            string sql = "SELECT * FROM [main_info]";

            int x = 13;
            int y = 50;

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, strConn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                
                DataTable userTable = ds.Tables[0];

                for (int i = 0; i < userTable.Rows.Count; i++)
                {
                    ITInfoUserControl control = new ITInfoUserControl(userTable.Rows[i].ItemArray[1].ToString(), userTable.Rows[i].ItemArray[2].ToString(), userTable.Rows[i].ItemArray[3].ToString());
                    control.Location = new System.Drawing.Point(x, y);
                    y += 70;
                    this.Controls.Add(control);
                }



                //          select               
                //foreach (DataRow item in userTable.Rows)
                //{
                //    foreach (object cell in item.ItemArray)
                //    {
                //        Console.Write($"{cell}\t\t");
                //    }
                //    Console.WriteLine();
                //}
                              

            }
        }

        private void ChangeLocals(string lang)
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            CultureInfo culture = new CultureInfo(lang);
            foreach (Control item in this.Controls)
            {
                manager.ApplyResources(item, item.Name, culture);
            }
        }


        private void enBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("en-EN");
        }

        private void geBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("de-DE");
        }

        private void ruBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("ru-RU");
        }

        private void ukrBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("uk-UA");
        }
    }
}
