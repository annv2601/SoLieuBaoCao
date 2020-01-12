<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGiayDeNghiTiepQuyDanhSachDonVi.aspx.cs" Inherits="SoLieuBaoCao.GiayDeNghiTiepQuy.frmGiayDeNghiTiepQuyDanhSachDonVi" %>
<%@ Register src="~/GiayDeNghiTiepQuy/ucNganHang.ascx" tagname="NganHang" tagprefix="uc" %>
<%@ Register src="~/GiayDeNghiTiepQuy/ucAnhBanKy.ascx" tagname="AnhBKy" tagprefix="uc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resource/CSS/DataGrid.css" rel="stylesheet" />
    <style>
        .x-grid-body .x-grid-cell-Cost {
            background-color : #f1f2f4;
        }

        .x-grid-row-summary .x-grid-cell-Cost .x-grid-cell-inner{
            background-color : #e1e2e4;
        }

        .task .x-grid-cell-inner {
            padding-left: 15px;
        }

        .x-grid-row-summary .x-grid-cell-inner {
            font-weight: bold;
            font-size: 11px;
            background-color : #f1f2f4;
        }

        .total-field{
            background-color : #fff;
            padding          : 0px 1px 1px 1px;
            margin-right     : 1px;
            position: absolute;
        }

        .total-field .x-form-display-field{
            font-weight      : bold !important;
            border           : solid 1px silver;
            font-size        : 11px;
            font-family      : tahoma, arial, verdana, sans-serif;
            color            : #000;
            padding          : 0px 0px 0px 5px;
            height           : 22px;
            margin-top       : 0px;
            padding-top      : 3px;
        }
    </style>
     <script type="text/javascript">
         var template = '<span style="color:{0};">{1}</span>';

        var mauDuCuoi = function (value) {
            return Ext.String.format(template, (value > 0) ? "orange" : "red", value);
        };

        var mauDuKienChi = function (value) {
            return Ext.String.format(template, (value > 0) ? "green" : "red", value);
         };

         function getRowClass(record) {
             if (record.data.Khoa) {
                return "GridPanelUsersRowYellow";
            }
            else
             {
                 if (record.data.urlAnhBanIn == "") {
                     return "GridPanelUsersRowWhite";
                 }
                 else {
                     return "GridPanelUsersXacNhan";
                 }
            }
         }

        var edit = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangNhapDMLQX.Edit(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);

                var grid = App.grdDinhMucLuuQuy;
                var pos = grid.getSelectionModel().getCurrentPosition();
                grid.editingPlugin.startEdit(pos.row , pos.column+1);
            }
        }

        var beforeCellEditHandler = function (e) {
            if (e.record.data.Khoa == true) {
                CellEditing1.cancelEdit(); 
            }
         }
     </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:Hidden runat="server" ID="txtNgayThang" />
        <ext:GridPanel runat="server" ID="grdGDNTQuy" TitleAlign="Center" MinHeight="300" Height="800" MarginSpec="0 0 0 0">   
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items>
                       <ext:Button runat="server" ID="btnThangTruoc" Text="Ngày trước" MarginSpec="0 0 0 20" >
                           <DirectEvents>
                               <Click OnEvent="btnThangTruoc_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnThangSau" Text="Ngày sau" MarginSpec="0 0 0 20" >
                           <DirectEvents>
                               <Click OnEvent="btnThangSau_Click" />
                           </DirectEvents>
                       </ext:Button>
                       
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoGDNTQuy">
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="MaKeToanNgay" />
                                <ext:ModelField Name="MaDonVi" />
                                <ext:ModelField Name="TenDonVi" />
                                <ext:ModelField Name="Ngay" />
                                <ext:ModelField Name="SoTienDeNghi" />
                                <ext:ModelField Name="DuKienChiTra" />
                                <ext:ModelField Name="SoTienQuyKhacVay" />
                                <ext:ModelField Name="TongSoDuTien" />
                                <ext:ModelField Name="SoDuTienMat" />
                                <ext:ModelField Name="SoDuTienMatTaiBuuCuc" />
                                <ext:ModelField Name="SoDuTienMatTaiBDH" />
                                <ext:ModelField Name="SoDuTGNH" />
                                <ext:ModelField Name="SoDuTienDangChuyen" />
                                <ext:ModelField Name="urlAnhBanIn" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>    
            <View>
                <ext:GridView ID="GridView1" runat="server">
                    <GetRowClass Fn="getRowClass" />
                </ext:GridView>
            </View>
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;" />         
                    <ext:Column runat="server" Text="Đơn vị" DataIndex="TenDonVi" Align="Left" Width="220" StyleSpec="font-weight:bold;"/>
                    <ext:TemplateColumn
                                runat="server"
                                Text="ảnh chụp" StyleSpec="font-weight:bold;"
                                Flex="15"
                                DataIndex="urlAnhBanIn"
                                TemplateString='<img style="width:60px;height:45px;" src="{urlAnhBanIn}" />'
                                />
                    <ext:Column runat="server" Text="Số tiền đề nghị" DataIndex="SoTienDeNghi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Dự kiến trả" DataIndex="DuKienChiTra" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Số tiền quỹ khác vay" DataIndex="SoTienQuyKhacVay" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Tổng số dư tiền" DataIndex="TongSoDuTien" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Số dư tiền mặt tại đơn vị" DataIndex="SoDuTienMat" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Số dư tiền mặt tại Bưu cục" DataIndex="SoDuTienMatTaiBuuCuc" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Sô dư tiền mặt tại BĐTT/BĐH" DataIndex="SoDuTienMatTaiBDH" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Số dư TGNH" DataIndex="SoDuTGNH" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                    <ext:Column runat="server" Text="Số dư tiền đang chuyển" DataIndex="SoDuTienDangChuyen" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:CellSelectionModel runat="server">
               </ext:CellSelectionModel>
            </SelectionModel>    
             <Plugins>                
                <ext:CellEditing runat="server" ClicksToEdit="1">
                    <Listeners>
                        <BeforeEdit Handler="return beforeCellEditHandler(e);"></BeforeEdit>                       
                    </Listeners>
                </ext:CellEditing>
            </Plugins>
            <Features>
                <ext:Summary runat="server"/>
            </Features>
            <DirectEvents>
                <ItemDblClick OnEvent="grdGDNTQuy_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesCTSTK" Value="Ext.encode(#{grdGDNTQuy}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
        
        <ext:Window runat="server" ID="wAnhBanKy" Icon="Image" Title="Ảnh bản ký" TitleAlign="Center"
            ButtonAlign="Center" Width="600" Height="600" AutoScroll="true" Hidden="true">
            <Items>
                <ext:Panel runat="server" Header="false" Layout="FitLayout" Closable="false">
                    <Content>
                        <uc:AnhBKy ID="ucAnhBKy1" runat="server" Title="" />
                    </Content>
                </ext:Panel>
            </Items>
        </ext:Window>
    </form>
</body>
</html>
