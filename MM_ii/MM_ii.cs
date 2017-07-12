using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using function.lib;

namespace MM_ii
{
    public partial class MM_ii : Form
    {
        MM_ii_function fun = new MM_ii_function();
        MM_ii_ds MMiiDB = new MM_ii_ds();
        public MM_ii()
        {
            InitializeComponent();
        }

        private void MM_ii_Load(object sender, EventArgs e)
        {
            default_status();            //預設狀態
        }

        #region 變數
        //************************************************
        public MM_ii_ds MIDS
        {
            get
            {
                return MMiiDB;
            }
        }

        public string QueryDB       //SQL語法
        {
            set;
            get;
        }

        //************************************************
        #endregion

        #region 方法
        //************************************************

        private void GetSQL(string x)
        {
            if(x == "商品查詢")
            {
                QueryDB = @"SELECT [Check] = '0'
                                  ,[Item_No]
                                  ,[Item_Name]                                  
                                  ,[Spec]
                                  ,[Unit]
                                  ,[Remark]      
                              FROM [dbo].[SLS_MM_Item]";
            }
            else if(x == "倉別查詢")
            {
                QueryDB = @"SELECT *   
                                    FROM [dbo].[SLS_MM_WhseINFO]";

            }
            else if(x == "儲位查詢")
            {
                QueryDB = @"SELECT distinct [Whse_No],[Whse_Name]      
                                    FROM [dbo].[SLS_MM_WhseINFO]";
            }

        }

        private void default_status()            //預設狀態
        {
            #region 內容
            this.Text = "庫存系統";
            MM_ii_Status_info.Text = "瀏覽";
            fun.ServiceName = MM_ii_Server_ENV.Text;        //※重要※這行一定要加這樣才能設定DB連線語法
            //this.MaximizeBox = true;       //最大化
            //this.MinimizeBox = true;       //最小化
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;   //中央顯示視窗
            this.FormBorderStyle = FormBorderStyle.FixedSingle;     //限制使用者改變form大小
            this.AutoSize = false;          //自動調整大小            
            //Product_DGV_SetColumns();        //QS_ii_Product_DGV自定顯示欄位
            //this.Size = new System.Drawing.Size(1249, 882);      //設定Form大小
            fun.ReMAC(Local_MAC, Local_IP);         //取得本機MAC及IP
            fun.SYS_log("登入成功", this.Text, Local_IP.Text, USER_ID.Text, MM_ii_Server_ENV.Text);        //在DB記錄執行狀態
            MM_ii_detail_DGV1_SetColumns();        //MM_ii_detail_DGV1自定顯示欄位
            MM_ii_Detail_DGVColumn1.DataPropertyName = "Check";
            MM_ii_detail_DGV1.DataSource = MIDS.SLS_MM_Item_Temp;
            //MM_ii_Detail_DGVColumn1.DataPropertyName = "Check";
            MM_ii_Detail_DGVColumn1.Visible = false;           //明細<選取>顯示                        
            MM_ii_ItemAdd_button.Visible = false;
            MM_ii_ItemDel_button.Visible = false;
            MM_ii_ADD_button.Enabled = true;
            MM_ii_MOD_button.Enabled = true;
            MM_ii_DEL_button.Enabled = true;
            MM_ii_PT_button.Enabled = true;
            MM_ii_Save_button.Visible = false;
            MM_ii_Cancel_button.Visible = false;
           
            
            #endregion
        }

        private void start_status(Button x)      //啟動狀態
        {
            if (x == MM_ii_ADD_button)      //新增
            {
                MM_ii_Status_info.Text = "新增";                
                MM_ii_Detail_DGVColumn1.Visible = true;           //明細<選取>顯示
                MM_ii_ItemAdd_button.Visible = true;
                MM_ii_ItemDel_button.Visible = true;
                MM_ii_ADD_button.Enabled = false;
                MM_ii_MOD_button.Enabled = false;
                MM_ii_DEL_button.Enabled = false;
                MM_ii_Save_button.Visible = true;
                MM_ii_Cancel_button.Visible = true;
            }
            else if (x == MM_ii_MOD_button)     //修改
            {
                MM_ii_Status_info.Text = "修改";
                MM_ii_Detail_DGVColumn1.Visible = true;           //明細<選取>顯示
                MM_ii_ItemAdd_button.Visible = true;
                MM_ii_ItemDel_button.Visible = true;
                MM_ii_ADD_button.Enabled = false;
                MM_ii_MOD_button.Enabled = false;
                MM_ii_DEL_button.Enabled = false;                
                MM_ii_Save_button.Visible = true;
                MM_ii_Cancel_button.Visible = true;
            }
            else if (x == MM_ii_DEL_button)     //刪除
            {

            }
            else if (x == MM_ii_Save_button)        //儲存
            {
                MM_ii_Status_info.Text = "瀏覽";
                MM_ii_Detail_DGVColumn1.Visible = false;           //明細<選取>隱藏
                MM_ii_ItemAdd_button.Visible = false;
                MM_ii_ItemDel_button.Visible = false;
                MM_ii_ADD_button.Enabled = true;
                MM_ii_MOD_button.Enabled = true;
                MM_ii_DEL_button.Enabled = true;
                MM_ii_Save_button.Visible = false;
                MM_ii_Cancel_button.Visible = false;
            }            
            else if (x == MM_ii_Cancel_button)      //取消
            {
                MM_ii_Status_info.Text = "瀏覽";
                MM_ii_Detail_DGVColumn1.Visible = false;           //明細<選取>隱藏
                MM_ii_ItemAdd_button.Visible = false;
                MM_ii_ItemDel_button.Visible = false;
                MM_ii_ADD_button.Enabled = true;
                MM_ii_MOD_button.Enabled = true;
                MM_ii_DEL_button.Enabled = true;
                MM_ii_Save_button.Visible = false;
                MM_ii_Cancel_button.Visible = false;
                MIDS.SLS_MM_Item_Temp.RejectChanges();
            }


        }

        public void MM_ii_detail_DGV1_SetColumns()        //MM_ii_detail_DGV1自定顯示欄位
        {
            MM_ii_detail_DGV1.AutoGenerateColumns = false;
            //MM_ii_detail_DGV1.AllowUserToAddRows = false;
            MM_ii_Detail_DGVColumn1.DataPropertyName = "Check";
            MM_ii_Detail_DGVColumn2.DataPropertyName = "Item_No";
            MM_ii_Detail_DGVColumn3.DataPropertyName = "Item_Name";
            MM_ii_Detail_DGVColumn4.DataPropertyName = "Unit";
            MM_ii_Detail_DGVColumn5.DataPropertyName = "Qty";
            //MM_ii_Detail_DGVColumn6.DataPropertyName = "Whse_No";
            //MM_ii_Detail_DGVColumn7.DataPropertyName = "Loc_NO";
            MM_ii_Detail_DGVColumn8.DataPropertyName = "Supp_No";
            MM_ii_Detail_DGVColumn9.DataPropertyName = "Dist_No";
            GetSQL("倉別查詢");
            fun.DB_S_toDT(QueryDB, MIDS.SLS_MM_WhseINFO);
            DataView mmdv = new DataView(MIDS.SLS_MM_WhseINFO);
            DataTable mmWhseINFO = mmdv.ToTable(true, "Whse_No");       //true=>設定不重覆資料
            //DataView mmdv = new DataView(MIDS.SLS_MM_WhseINFO);
            //DataTable mmWhseINFO = mmdv.ToTable(true, "Whse_No");       //true=>設定不重覆資料
            //MM_ii_Detail_DGVColumn6.DisplayMember = "Whse_No";
            //MM_ii_Detail_DGVColumn6.ValueMember = "Whse_No";
            //MM_ii_Detail_DGVColumn6.DataSource = mmWhseINFO;            
            //DataView mmdv1 = new DataView(MIDS.SLS_MM_WhseINFO);
            //mmdv1.RowFilter = "Whse_No = '" + MM_ii_detail_DGV1.CurrentRow.Cells[5].Value.ToString() + "'";
            //MM_ii_Detail_DGVColumn7.DisplayMember = "Loc_NO";
            //MM_ii_Detail_DGVColumn7.ValueMember = "Loc_NO";
            //MM_ii_Detail_DGVColumn7.DataSource = mmdv1;
        }

        private void CombXX()
        {
            DataView MM_WINFO = new DataView(MIDS.SLS_MM_WhseINFO);
            MM_WINFO.RowFilter = "Whse_No = '" + MM_ii_detail_DGV1.CurrentRow.Cells[5].Value.ToString()+"'";
            MM_ii_Detail_DGVColumn7.DisplayMember = "Loc_NO";
            MM_ii_Detail_DGVColumn7.ValueMember = "Loc_NO";
            MM_ii_Detail_DGVColumn7.DataSource = MM_WINFO;
        }

        public void Combobox_Content()      //Combobox設定名稱和值
        {
            //DataTable dt_Com = new DataTable();
            //DataColumn SDC = new DataColumn("ID", System.Type.GetType("System.String"));
            //DataColumn SDC1 = new DataColumn("Value", System.Type.GetType("System.String"));
            //dt_Com.Columns.Add(SDC);
            //dt_Com.Columns.Add(SDC1);
            //string[] str_ID = { "公司代碼", "存放地點", "財產屬性", "財產類別", "使用狀態", "單位" };
            //string[] str_Value = { "CT", "OT", "A", "B", "C", "U" };
            //for (int i = 0; i < str_ID.Length; i++)
            //{
            //    DataRow dr = dt_Com.NewRow();
            //    dr["ID"] = str_ID[i];
            //    dr["Value"] = str_Value[i];
            //    dt_Com.Rows.Add(dr);
            //}
            //init_CO_Query_CB.DisplayMember = "ID";
            //init_CO_Query_CB.ValueMember = "Value";
            //init_CO_Query_CB.DataSource = dt_Com;

        }

        private void MM_ii_ADD()        //新增
        {

        }

        private void MM_ii_MOD()        //修改
        {

        }

        private void MM_ii_DEL()        //刪除
        {

        }

        private void MM_ii_Save()       //儲存
        {

        }

        private void MM_ii_PT()         //銷貨單-套表輸出
        {
            
        }

        private void LOGINOUT()         //登出
        {
            MM_ii_LOGIN MMLOGIN = new MM_ii_LOGIN();
            this.Hide();
            MMLOGIN.ShowDialog();
            this.Close();
        }               

        private void MM_ii_ItemAdd()        //明細檔-新增料號
        {
            MM_ii_QueryItem MMiiQDGV = new MM_ii_QueryItem(this);
            //MM_ii_QdataGridView1
            MMiiQDGV.MM_QDGV_Column1.DataPropertyName = "Check";
            //設定init_Staff 新視窗的相對位置#############
            MMiiQDGV.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //############################################
            fun.Check_error = false;
            GetSQL("商品查詢");    //語法丟進QueryDB
            fun.xxx_DB(QueryDB, MMiiQDGV.MM_ii_QdataGridView1);         //連接DB-執行DB指令            
            MMiiQDGV.ShowDialog();
        }

        private void MM_ii_ItemDel()        //明細檔-刪除料號
        {
            #region 內容
            //***************DataTable刪除選取的資料*****************
            for (int i = MM_ii_detail_DGV1.Rows.Count - 1; i >= 0; i--)
            {
                if (MM_ii_detail_DGV1.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    this.MM_ii_detail_DGV1.Rows.Remove(this.MM_ii_detail_DGV1.Rows[i]);
                    i = MM_ii_detail_DGV1.Rows.Count;
                }
            }
            #endregion
        }
        
        //************************************************
        #endregion

        #region 事件
        //************************************************

        //************************************************
        #endregion

        #region button
        //************************************************
        private void MM_ii_ADD_button_Click(object sender, EventArgs e)
        {
            start_status(MM_ii_ADD_button);            
        }        

        private void MM_ii_MOD_button_Click(object sender, EventArgs e)
        {
            start_status(MM_ii_MOD_button);  
        }

        private void MM_ii_DEL_button_Click(object sender, EventArgs e)
        {
            
        }

        private void MM_ii_PT_button_Click(object sender, EventArgs e)
        {
            MM_ii_PT();
        }

        private void MM_ii_Save_button_Click(object sender, EventArgs e)
        {
            start_status(MM_ii_Save_button); 
            MM_ii_Save();
        }

        private void MM_ii_Cancel_button_Click(object sender, EventArgs e)
        {
            start_status(MM_ii_Cancel_button);            
        }

        private void MM_ii_ItemAdd_button_Click(object sender, EventArgs e)
        {
            MM_ii_ItemAdd();
        }

        private void MM_ii_ItemDel_button_Click(object sender, EventArgs e)
        {
            MM_ii_ItemDel();
        }

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGINOUT();
        }
        
        //************************************************
        #endregion
    }
}
