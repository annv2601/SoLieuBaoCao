using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using daoSLBC.HeThong;
using daoSLBC.Database.HeThong;
using Ext.Net;
using SoLieuBaoCao.UIHelper;

namespace SoLieuBaoCao
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!X.IsAjaxRequest)
            {
                Menu();
            }
        }

        #region menu node
        private void Menu()
        {
            Ext.Net.Node root = new Ext.Net.Node();
            TreeStore treeStore = new TreeStore();

            daChucNang dCN = new daChucNang();
            List<sp_tblChucNang_DanhSachResult> lstChucNang;
            List<sp_tblChucNang_DanhSach_TheoCapTrenResult> lstCNCon;
            dCN.CN.Nhom = 1;
            lstChucNang = dCN.lstDanhSach();

            foreach (sp_tblChucNang_DanhSachResult composer in lstChucNang)
            {
                Ext.Net.Node composerNode = new Ext.Net.Node()
                {
                    Text = composer.Ten,
                    IconCls = "x-fa fa-" + composer.BieuTuong
                };
                root.Children.Add(composerNode);

                lstCNCon = dCN.lstDanhSachTheoCapTren(composer.ID);
                if(lstCNCon.Count>0)
                {
                    foreach(sp_tblChucNang_DanhSach_TheoCapTrenResult ptCon in lstCNCon)
                    {
                        Ext.Net.Node NodeCon = new Ext.Net.Node()
                        {
                            Text = ptCon.Ten,
                            IconCls = "x-fa fa-" + ptCon.BieuTuong,                            
                            Leaf=true
                        };
                        NodeCon.Listeners.AddScript = "addTabCN(#{TabPanelChinh},'idTabCN" + ptCon.ID.ToString() + "','" + daPhien.LayDiaChiURLChucNang(ptCon.ID, ptCon.dcUrl) + "','" + ptCon.TieuDe + "');";
                        composerNode.Children.Add(NodeCon);
                    }
                }
                
            }

            root.Expanded = true;
            treeStore.Root.Add(root);
            ChucNangTree.Store.Add(treeStore);
        }
        #endregion
    }
}