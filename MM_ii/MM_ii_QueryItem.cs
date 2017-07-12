using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_ii
{
    class MM_ii_QueryItem : MM_ii_QueryDGV
    {
        MM_ii MMii;

        public MM_ii_QueryItem(MM_ii x)
        {
            this.MMii = x;
        }

        public override void MM_ii_QueryDGV_DGView1()         //把選取資料對應到TextBox
        {
            #region 內容
            try
            {
                //QS_iiQ_add.QS_ii_PriceDataBinding(QS_iiQ_add.QSiiDB.QS_ii_QProduct);           //datatable的欄位與Text綁定資料
                //QS_iiQ_add.DataTable_SETColumnExpression();                 //設定DataTable的Column.Expression
                
                DataView MMii_QDView = new DataView(MMii.MIDS.SLS_MM_Item_Temp);
                MMii_QDView.RowFilter = "Item_No = '" + MM_ii_QdataGridView1.CurrentRow.Cells["Item_No"].Value.ToString() + "'";
                if (MMii_QDView.Count == 0)
                {
                    DataRow MM_ii_dr = MMii.MIDS.SLS_MM_Item_Temp.NewRow();
                    MM_ii_dr["Check"] = "0";
                    MM_ii_dr["Item_No"] = MM_ii_QdataGridView1.CurrentRow.Cells["Item_No"].Value.ToString();
                    MM_ii_dr["Item_Name"] = MM_ii_QdataGridView1.CurrentRow.Cells["Item_Name"].Value.ToString();
                    //MM_ii_dr["Spec"] = MM_ii_QdataGridView1.CurrentRow.Cells["Spec"].Value.ToString();
                    //MM_ii_dr["Unit"] = MM_ii_QdataGridView1.CurrentRow.Cells["Unit"].Value.ToString();
                    //MM_ii_dr["Remark"] = MM_ii_QdataGridView1.CurrentRow.Cells["Remark"].Value.ToString();
                    MMii.MIDS.SLS_MM_Item_Temp.Rows.Add(MM_ii_dr);
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
            #endregion          
        }

        public override void MM_ii_QueryDGV查詢()       //查詢Button
        {
            //DataTable ProductM_dt = new DataTable();
            //ProductM_dt.Columns.Add("Check");
            //QS_ii_QueryDGV_Column1.Visible = true;            
            //QS_ii_QueryDGV_Column1.DataPropertyName = "Check";
            //QS_iiQ_add.Product_Query(QS_ii_QueryDGv_PID, QS_iiQ_add.QSiiDB.QS_ii_Product, QS_ii_DGView1);        //商品主檔查詢            
        }

        public override void MM_ii_QueryDGV加入()      //報價單明細檔多選的加入button//
        {
            #region 內容
            //QS_iiQ_add.QS_ii_PriceDataBinding(QS_iiQ_add.QSiiDB.QS_ii_QProduct);           //datatable的欄位與Text綁定資料
            //QS_iiQ_add.DataTable_SETColumnExpression();                 //設定DataTable的Column.Expression
            //DataView QS_ii_DView = new DataView(QS_iiQ_add.QSiiDB.QS_ii_Product);
            //DataView QS_ii_QDView = new DataView(QS_iiQ_add.QSiiDB.QS_ii_QProduct);
            //QS_ii_DView.RowFilter = "Check = '1'";

            //foreach (DataRowView DView in QS_ii_DView)
            //{
            //    QS_ii_QDView.RowFilter = "item_NO = '" + DView["商品編號"].ToString() + "'";
            //    if (QS_ii_QDView.Count == 0)
            //    {
            //        DataRow QS_ii_dr = QS_iiQ_add.QSiiDB.QS_ii_QProduct.NewRow();
            //        QS_ii_dr["Check"] = "0";
            //        QS_ii_dr["QT_NO"] = QS_iiQ_add.tb_QT_NO.Text;
            //        QS_ii_dr["item_NO"] = DView["商品編號"];
            //        QS_ii_dr["item_NAME"] = DView["商品名稱"];
            //        QS_ii_dr["SPEC"] = DView["規格"];
            //        QS_ii_dr["UNIT"] = DView["單位"];
            //        QS_ii_dr["QTY"] = 1;
            //        QS_ii_dr["UNIT_PRICE"] = DView["單價"];
            //        QS_iiQ_add.QSiiDB.QS_ii_QProduct.Rows.Add(QS_ii_dr);

            //    }
            //DataRowView QS_ii_dr = QS_ii_QDView.AddNew();
            //QS_ii_dr["Check"] = "0";
            //QS_ii_dr["QT_NO"] = QS_iiQ_add.tb_QT_NO.Text;
            //QS_ii_dr["item_NO"] = DView["商品編號"];
            //QS_ii_dr["item_NAME"] = DView["商品名稱"];
            //QS_ii_dr["SPEC"] = DView["規格"];
            //QS_ii_dr["UNIT"] = DView["單位"];
            //QS_ii_dr["QTY"] = 1;
            //QS_ii_dr["UNIT_PRICE"] = DView["單價"];
            //QS_ii_dr.EndEdit();
            //}
            #endregion
        } 
    }
}
