using LOGIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_ii
{
    class MM_ii_LOGIN : Login_main
    {
        private DataTable MM_LOGIN_DT
        {
            get
            {
                return new DataTable();
            }
        }

        public override void PRD_login()        //設定PRD登入的方法
        {
            MessageBox.Show("伺服器目前沒開放!!\n請選擇其他伺服器", this.Text);
        }

        public override void V_login_SetENV()      //設定LOGIN變數
        {
            base.V_login_SetENV();
            if (GETServerName == "PRD")
            {
                Query_DB = @"select * from [dbo].[SLS_MM_LOGINTemp]('" + ID_Login + "','" + App_LoginPW + "')";
                LOD_DT = MM_LOGIN_DT;       //暫存LOGIN的資料
            }
            else if (GETServerName == "DEV")
            {
                Query_DB = @"select * from [dbo].[SLS_MM_LOGINTemp]('" + ID_Login + "','" + App_LoginPW + "')";
                LOD_DT = MM_LOGIN_DT;       //暫存LOGIN的資料
            }
        }

        public override void V_login_open()      //開窗
        {
            //fun.ServiceName = 
            DataView DV = new DataView(LOD_DT);
            DV.RowFilter = "MM_Login = 'Y'";
            if (DV.Count == 1)
            {
                #region 內容
                //******************************************
                MM_ii MMii = new MM_ii();
                //設定init_Staff 新視窗的相對位置#############
                MMii.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                //############################################
                //string Query_DB = @"select * from [dbo].[SLS_QS_LOGINTemp]('" + UID + "')";
                //QiQ.fun.USER_INFO(Query_DB, QiQ.QSiiDB.Tables["SLS_QS_ii_LOGIN"]);        //登入後載入使用者資訊至DS
                //LOD_DT =>this.LOD.SLS_QS_LOGIN
                DataRow MMiiDR = MMii.MIDS.MM_ii_LOGIN.NewRow();
                MMiiDR["EMP_ID"] = LOD_DT.Rows[0]["EMP_ID"];
                MMiiDR["EMP_Name"] = LOD_DT.Rows[0]["EMP_Name"];
                MMiiDR["MM_Login"] = LOD_DT.Rows[0]["MM_Login"];
                MMiiDR["MM_ROOT"] = LOD_DT.Rows[0]["MM_ROOT"];
                MMiiDR["MM_ADD"] = LOD_DT.Rows[0]["MM_ADD"];
                MMiiDR["MM_Modify"] = LOD_DT.Rows[0]["MM_Modify"];
                MMiiDR["MM_Del"] = LOD_DT.Rows[0]["MM_Del"];
                MMiiDR["MM_Query"] = LOD_DT.Rows[0]["MM_Query"];
                MMiiDR["MM_SUPP"] = LOD_DT.Rows[0]["MM_SUPP"];
                MMiiDR["MM_CUST"] = LOD_DT.Rows[0]["MM_CUST"];
                MMiiDR["MM_Whse"] = LOD_DT.Rows[0]["MM_Whse"];
                MMiiDR["MM_Other"] = LOD_DT.Rows[0]["MM_Other"];
                MMiiDR["Del_Flag"] = LOD_DT.Rows[0]["Del_Flag"];
                MMii.MIDS.MM_ii_LOGIN.Rows.Add(MMiiDR);
                MMii.MIDS.MM_ii_LOGIN.AcceptChanges();
                MMii.MM_ii_Server_ENV.Text = GETServerName;
                MMii.USER_ID.Text = UID;
                this.Hide();
                MMii.ShowDialog(this);
                this.Close();
                //******************************************
                #endregion
            }
            else
            {
                MessageBox.Show("您沒有權限登入!!\n請找資訊部門協助", this.Text);
            }
        }
    }
}
