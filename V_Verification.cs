using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class V_Verification : Form
    {
        TempStorage tempstorage = TempStorage.Instance;
        private AppData Data;
        public V_Verification(AppData data)
        {
            InitializeComponent();
            Data = data;
        }

        private void OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus Status)
        {
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();

            //save to the db
            const string filename = "biometricverification.sqlite";
            var conn = new SQLiteConnection("Data Source=" + filename + ";");

            try
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM fingerprint WHERE fingerprint = @finger_print", conn))
                {
                    command.Parameters.Add("@finger_print", DbType.Binary).Value = FeatureSet.Bytes;
                    //command.Parameters.Add("@fingerD", DbType.Int16).Value = Finger;
                    SQLiteDataReader dataR= command.ExecuteReader();
                    if (dataR.HasRows)
                    {
                        verification_status_lbl.ForeColor = Color.Green;
                        verification_status_lbl.Text = "VALID";
                    }
                    else
                    {
                        Status = DPFP.Gui.EventHandlerStatus.Failure;
                        verification_status_lbl.ForeColor = Color.Red;
                        verification_status_lbl.Text = "INVALID";
                    }
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Compare feature set with all stored templates.
            //foreach (DPFP.Template template in Data.Templates)
            //{
            //    // Get template from storage.
            //    if (template != null)
            //    {
            //        // Compare feature set with particular template.
            //        ver.Verify(FeatureSet, template, ref res);
            //        Data.IsFeatureSetMatched = res.Verified;
            //        Data.FalseAcceptRate = res.FARAchieved;
            //        if (res.Verified)
            //            verification_status_lbl.ForeColor = Color.Green;
            //            verification_status_lbl.Text = "VALID";
            //            break; // success
            //    }
            //}
            //if (!res.Verified)
            //{
            //    Status = DPFP.Gui.EventHandlerStatus.Failure;
            //    verification_status_lbl.ForeColor = Color.Red;
            //    verification_status_lbl.Text = "INVALID";
            //}
            Thread.Sleep(TimeSpan.FromSeconds(3));
            verification_status_lbl.Text = "";
        }
    }
}
