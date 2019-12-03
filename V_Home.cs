using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class V_Home : Form
    {
        private AppData Data;					// keeps application-wide data
        private EnrollmentForm Enroller;
        private V_Verification verification;
        TempStorage tempstorage = TempStorage.Instance;

        public V_Home()
        {
            InitializeComponent();
            Data = new AppData();								// Create the application data object
            Data.OnChange += delegate { ExchangeData(false); };	// Track data changes to keep the form synchronized
            Enroller = new EnrollmentForm(Data);
            verification = new V_Verification(Data);
            ExchangeData(false);
        }

        // Simple dialog data exchange (DDX) implementation.
        private void ExchangeData(bool read)
        {
            if (read)
            {	// read values from the form's controls to the data object
                
              

                //save to the db
                //const string filename = "sample_db.sqlite";
                //const string sql = "select * from staff;";
                //var conn = new SQLiteConnection("Data Source=" + filename + ";");

                //try
                //{
                //    conn.Open();
                //    using (var command = new SQLiteCommand("INSERT INTO staff(staff_no,first_name,last_name,phone,gender,faculty,department,image)VALUES(@staffno,@firstname,@lastname,@phone,@gender,@faculty,@department',@photo)", conn))
                //    {
                //        byte[] photo = ImageToByte(Data.staff.StaffImage);
                //        byte[] fingerprintTemp = new byte[Data.staff.Templates.Length];
                //        for (int i = 0; i < fingerprintTemp.Length; i++)
                //        {
                //            Data.staff.Templates[i].Serialize(ref fingerprintTemp);

                //        }

                //        command.Parameters.Add("@photo", DbType.Binary, 20).Value = photo;
                //        command.ExecuteNonQuery();
                //        MessageBox.Show("successfully added to db");
                //    }

                //    //save fingerprint to db
                //    using (var command = new SQLiteCommand("INSERT INTO fingerprint(staff_id,staff_name,staff_no,fingerprint)VALUES('sch25','ola','ade','08052634152','male','csc','csc',@photo,@finger)", conn))
                //    {
                //        byte[] photo = ImageToByte(Data.staff.StaffImage);
                //        byte[] fingerprintTemp = new byte[Data.staff.Templates.Length];
                //        for (int i = 0; i < fingerprintTemp.Length; i++)
                //        {
                //            Data.staff.Templates[i].Serialize(ref fingerprintTemp);

                //        }

                //        command.Parameters.Add("@photo", DbType.Binary, 20).Value = photo;
                //        command.ExecuteNonQuery();
                //        MessageBox.Show("successfully added to db");
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }

        private void verification_Click(object sender, EventArgs e)
        {
            verification.ShowDialog();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            Enroller.ShowDialog();
        }
    }
}
