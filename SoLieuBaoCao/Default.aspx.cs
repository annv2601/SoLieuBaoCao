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
                DanhSachNguoiSuDung();
            }
        }

        #region menu node
        private void Menu()
        {
            Ext.Net.Node root = new Ext.Net.Node();
            //TreeStore treeStore = new TreeStore();

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
                    NodeID=composer.ID.ToString(),
                    IconCls = "x-fa fa-" + composer.BieuTuong
                };
                composerNode.CustomAttributes.Add(new ConfigItem("DiaChiURL", "0"));
                root.Children.Add(composerNode);

                if (daPhien.ThongTinDN.Cap == null)
                {
                    lstCNCon = dCN.lstDanhSachTheoCapTren(composer.ID, 2);
                }
                else
                {
                    lstCNCon = dCN.lstDanhSachTheoCapTren(composer.ID, daPhien.ThongTinDN.Cap.Value);
                }
                if(lstCNCon.Count>0)
                {
                    foreach(sp_tblChucNang_DanhSach_TheoCapTrenResult ptCon in lstCNCon)
                    {
                        Ext.Net.Node NodeCon = new Ext.Net.Node()
                        {
                            Text = ptCon.Ten,
                            IconCls = "x-fa fa-" + ptCon.BieuTuong,
                            NodeID=ptCon.ID.ToString(),
                            Leaf=true                            
                        };
                        
                        NodeCon.CustomAttributes.Add(new ConfigItem("DiaChiURL", daPhien.LayDiaChiURLChucNang(ptCon.ID, ptCon.dcUrl), ParameterMode.Value));
                        composerNode.Children.Add(NodeCon);
                    }
                }
                
            }

            root.Expanded = true;
            
            treesto.Root.Add(root);            
            treesto.GetRootNode().ExpandChildren(true);
            /*treeStore.Root.Add(root);
            treeStore.Render();
            treeStore.GetRootNode().ExpandChildren(true);
                       
            ChucNangTree.Store.Add(treeStore);*/
            //ChucNangTree.Render();

        }

        private void DanhSachNguoiSuDung()
        {
            daDangNhap dDN = new daDangNhap();
            stoNSD.DataSource = dDN.DanhSach();
            stoNSD.DataBind();
        }
        #endregion

        protected void btnDangNhap_click(object sender, DirectEventArgs e)
        {
            txtMaNSD.Text = "";
            txtMaDonVi.Text = "";            
            wDangNhap.Show();
            txtMaDonVi.Focus();
        }

        protected void btnKiemTraDangNhap_click(object sender, DirectEventArgs e)
        {
            daDangNhap dDN = new daDangNhap();
            dDN.MaNSD = txtMaNSD.Text.Trim();
            dDN.MaDonVi = txtMaDonVi.SelectedItem.Text.Trim().Split(':')[0];
            UIHelper.daPhien.DaDangNhap = dDN.KiemTra();
            if(UIHelper.daPhien.DaDangNhap)
            {
                wDangNhap.Hide();
                btnDangNhap.Text = dDN.TenNguoiSuDung;
                UIHelper.daPhien.MaNSD = dDN.MaNSD;
                UIHelper.daPhien.MaDonVi = dDN.MaDonVi;
                UIHelper.daPhien.TenNguoiSuDung = dDN.TenNguoiSuDung;

                UIHelper.daPhien.ThongTinDN = dDN.TTDN;


                //Menu();
                //treesto.Render();
                //ChucNangTree.Render(true);
                
                Notification.Show(new NotificationConfig
                {
                    Title = "Hoàn thành",
                    Icon = Icon.Information,
                    AlignCfg = new NotificationAlignConfig
                    {
                        ElementAnchor = AnchorPoint.Center,
                        TargetAnchor = AnchorPoint.Center,
                        OffsetX = -20,
                        OffsetY = 20                        
                    },
                    Html = "Đăng nhập Thành công vào hệ thống"
                });

                Response.Redirect("Default.aspx");
            }
            else
            {
                X.Msg.Alert("Lỗi","Anh/chị đăng nhập không thành công!").Show();
                btnDangNhap.Text = "[Đăng nhập]";
                UIHelper.daPhien.MaNSD = "";
                UIHelper.daPhien.MaDonVi = "";
                UIHelper.daPhien.TenNguoiSuDung = "";
                UIHelper.daPhien.ThongTinDN = null;
            }
        }
    }
}