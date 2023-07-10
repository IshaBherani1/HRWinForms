//Isha Bherani
//Windows Forms App- Human Resource 

using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Types;
using Microsoft.SqlServer;

namespace HRWinForms
{

    public partial class Form1 : Form
    {
        string newDepartmentTxt;
        string ShiftIDTxt;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
       
            //initialize the ID pser inputs
            int DepartmentTxt = Convert.ToInt32(DepartmentBox.Text);
            string OrgLevelTxt = Convert.ToString(OrgLevelBox.Text);
            

            //connect to the database server
            string ConnectionString = @"Data Source=192.168.14.22,1434\\MSSQLSERVER;Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=isha;Password=Beaumont786.; TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //sql query to fill the data table
            SqlCommand command = new SqlCommand("SELECT TOP (100) [HumanResources].[Employee].[BusinessEntityID] ," +
                "[DepartmentID] ,[OrganizationLevel] ,[JobTitle] " +
                "FROM[AdventureWorks2019].[HumanResources].[Employee] " +
                "left outer join[AdventureWorks2019].[HumanResources].[EmployeeDepartmentHistory]" +
                "on[AdventureWorks2019].[HumanResources].[Employee].BusinessEntityID = " +
                "[AdventureWorks2019].[HumanResources].[EmployeeDepartmentHistory].BusinessEntityID " +
                "Where DepartmentID= " + DepartmentTxt + " and OrganizationLevel= " + OrgLevelTxt, connection);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);

            //Set the datagridview control = to the datatable, and make it visibile
            dataGridView1.DataSource = datatable;
            dataGridView1.Visible = true;

            connection.Close();//close connection to avoid errors

            AddEmpBtn.Visible = true;
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            InsertNewEmpBtn.Visible=true;
            label1.Visible=true;
            label2.Visible=true;
            NewDepartmentIDBox.Visible=true;
            NewShiftIDBox.Visible =true;

        }

        private void InsertNewEmpBtn_Click(object sender, EventArgs e)
        {
            UpdateBtn.Visible=true;
            

            try
            {
                newDepartmentTxt = Convert.ToString(NewDepartmentIDBox.Text);
                ShiftIDTxt = Convert.ToString(NewShiftIDBox.Text);

            }
            catch
            {
                ShiftIDTxt = null;
            }


            //connect to the database server
            string ConnectionString = @"Data Source=192.168.14.22,1434\\MSSQLSERVER;Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=isha;Password=Beaumont786.; TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //sql query to fill the data table
            SqlCommand command = new SqlCommand("INSERT INTO [HumanResources].[EmployeeDepartmentHistory] ([DepartmentID]" +
                ",[ShiftID] ,[StartDate] ,[EndDate] ,[ModifiedDate]) " +
                "VALUES(' " + newDepartmentTxt + "', ' " + ShiftIDTxt + "', '2022-06-30', '2022-06-30', '2022-06-30')", connection);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);

            //Set the datagridview control = to the datatable, and make it visibile
            dataGridView1.DataSource = datatable;
            dataGridView1.Visible = true;

            connection.Close();//close connection to avoid errors

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                newDepartmentTxt = Convert.ToString(NewDepartmentIDBox.Text);
                ShiftIDTxt = Convert.ToString(NewShiftIDBox.Text);

            }
            catch
            {
                ShiftIDTxt = null;
            }

            int DepartmentTxt = Convert.ToInt32(DepartmentBox.Text);
            string OrgLevelTxt = Convert.ToString(OrgLevelBox.Text);

            //connect to the database server
            string ConnectionString2 = @"Data Source=192.168.14.22,1434\\MSSQLSERVER;Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=isha;Password=Beaumont786.; TrustServerCertificate=True";
            SqlConnection connection2 = new SqlConnection(ConnectionString2);

            connection2.Open();

            //sql query to fill the data table
            SqlCommand command2 = new SqlCommand("SELECT TOP (1000) [BusinessEntityID] " +
                ",[DepartmentID] ,[ShiftID],[StartDate] ,[EndDate] ,[ModifiedDate]" +
                "FROM[AdventureWorks2019].[HumanResources].[EmployeeDepartmentHistory] " +
                "where DepartmentID = ' " + newDepartmentTxt + "' and ShiftID = ' " + ShiftIDTxt + "' ", connection2);

            //Create a new datatable named 'datatable' to insert the reuslts to
            DataTable datatable2 = new DataTable();

            //Adapter to convert SQL result to .Net datatable object
            SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
            adapter2.Fill(datatable2);

            //Set the datagridview control = to the datatable, and make it visibile
            dataGridView1.DataSource = datatable2;
            dataGridView1.Visible = true;

            connection2.Close();//close connection to avoid errors

        }
    }
}