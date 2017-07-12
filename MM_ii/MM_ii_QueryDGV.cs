using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_ii
{
    public partial class MM_ii_QueryDGV : Form
    {
        public MM_ii_QueryDGV()
        {
            InitializeComponent();
        }
        private void MM_ii_QueryDGV_Load(object sender, EventArgs e)
        {

        }

        #region 變數
        //******************************************************//
        public string NOID_Value            //設定or取得MM_ii_QueryDGV_PID值的變數
        {
            set
            {
                MM_ii_QueryDGV_PID_Value.Text = value;
            }
            get
            {
                return MM_ii_QueryDGV_PID_Value.Text;
            }
        }

        //public DataGridView idView1
        //{
        //    get
        //    {
        //        return MM_ii_QdataGridView1;
        //    }
        //}
        //******************************************************//
        #endregion

        #region 方法
        //******************************************************//        
        private void default_status()       //預設
        {
            this.Text = "查詢";
            this.MaximizeBox = false;       //最大化
            this.MinimizeBox = false;       //最小化
            this.FormBorderStyle = FormBorderStyle.FixedSingle;     //限制使用者改變form大小
            this.AutoSize = false;          //自動調整大小
        }        

        public virtual void MM_ii_QueryDGV查詢()         //查詢Button
        {

        }

        public virtual void MM_ii_QueryDGV加入()         //加入Button
        {

        }

        public virtual void MM_ii_QueryDGV_DGView1()       //DGView1資料呼叫方法
        {

        }
        //******************************************************//
        #endregion

        #region button
        //******************************************************//
        private void MM_ii_QueryDGV查詢button_Click(object sender, EventArgs e)
        {
            MM_ii_QueryDGV查詢();
        }

        private void MM_ii_QueryDGV加入button_Click(object sender, EventArgs e)
        {
            MM_ii_QueryDGV加入();
        }

        
        //******************************************************//
        #endregion

        #region 事件
        //******************************************************//
        private void MM_ii_QdataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)     //DGV雙擊左鍵二下
        {
            if (e.RowIndex >= 0)
            {
                MM_ii_QueryDGV_DGView1();       //DGView1資料呼叫方法
                this.Close();
            }
        }

        public void MM_ii_QdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)       //MM_ii_QdataGridView1中的Checkbox
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                #region 內容
                //QS_ii_QS_ii_DGView1_CellContentClick();
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)MM_ii_QdataGridView1.Rows[e.RowIndex].Cells[0];
                string flag = MM_ii_QdataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (flag == "1")     //被選取的資料行
                {
                    checkCell.Value = "0";
                }
                else
                {
                    checkCell.Value = "1";
                }
                #endregion
            }
        }

        //******************************************************//
        #endregion

    }
}
