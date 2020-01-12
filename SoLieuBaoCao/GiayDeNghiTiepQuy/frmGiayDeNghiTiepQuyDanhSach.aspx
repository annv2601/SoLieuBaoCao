<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGiayDeNghiTiepQuyDanhSach.aspx.cs" Inherits="SoLieuBaoCao.GiayDeNghiTiepQuy.frmGiayDeNghiTiepQuyDanhSach" %>
<%@ Register src="~/GiayDeNghiTiepQuy/ucNganHang.ascx" tagname="NganHang" tagprefix="uc" %>
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
                return "GridPanelUsersRowWhite";
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
        <ext:GridPanel runat="server" ID="grdGDNTQuy" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="0 0 0 0">   
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items>
                       <ext:DateField runat="server" ID="txtNgayTongHop" FieldLabel="Ngày" LabelWidth="60" />
                       <ext:Button runat="server" ID="btnTongHop" Text="Lập Đề nghị" MarginSpec="0 0 0 20" >
                           <DirectEvents>
                               <Click OnEvent="btnTongHop_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>

                       <ext:Button runat="server" ID="btnNganHang" Text="TT Ngân hàng" MarginSpec="0 0 0 20" >
                           <DirectEvents>
                               <Click OnEvent="btnNganHang_Click" />
                           </DirectEvents>
                       </ext:Button>

                       <ext:Button runat="server" ID="btnThangTruoc" Text="Tháng trước" MarginSpec="0 0 0 20" >
                           <DirectEvents>
                               <Click OnEvent="btnThangTruoc_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnThangSau" Text="Tháng sau" MarginSpec="0 0 0 20" >
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
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Align="Center" Width="130" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy" Locked="true">
                        <Commands>
                            <ext:ImageCommand CommandName="InAn" Icon="Printer" >
                                <ToolTip Text="In giấy đề nghị Tiếp quỹ" />                                
                            </ext:ImageCommand>                            
                        </Commands>
                        <DirectEvents>
                            <Command OnEvent="InAn_Click">
                                <ExtraParams>
                                    <ext:Parameter Name="ValuesGDN" Value="record.data.MaKeToanNgay" Mode="Raw"/>
                                </ExtraParams>
                                <EventMask ShowMask="true" Msg="Đang thực thi ....." />
                            </Command>
                        </DirectEvents>
                    </ext:DateColumn>
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
        </ext:GridPanel>

        <ext:Window runat="server" ID="wNganHang" Icon="Money" Title="Thông tin Ngân hàng" TitleAlign="Center"
            ButtonAlign="Center" Width="460" Height="360" AutoScroll="true" Hidden="true">
            <Items>
                <ext:Panel runat="server" Header="false" Layout="FitLayout" Closable="false">
                    <Content>
                        <uc:NganHang ID="ucNganHang1" runat="server" Title="" />
                    </Content>
                </ext:Panel>
            </Items>
            <Buttons>
                <ext:Button runat="server" ID="btnCapNhatNH" Text="Cập nhật" Icon="Add" Width="120">
                    <DirectEvents>
                        <Click OnEvent="btnCapNhatNH_Click">
                            <EventMask ShowMask="true" Msg="Đang khởi tạo ....." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button runat="server" Text="Đóng" Icon="Cross" Width="120">
                    <Listeners>
                        <Click Handler="#{wNganHang}.hide()" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
    </form>
</body>
</html>
