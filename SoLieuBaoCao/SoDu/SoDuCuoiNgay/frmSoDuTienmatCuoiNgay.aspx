<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSoDuTienmatCuoiNgay.aspx.cs" Inherits="SoLieuBaoCao.SoDu.SoDuCuoiNgay.frmSoDuTienmatCuoiNgay" %>

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
                e.record.data.Cong = e.record.data.TCBCTapTrung + e.record.data.TCBCThanhToanTaiDonVi + e.record.data.TKBD + e.record.data.KinhDoanh;
                e.record.data.dkCong = e.record.data.dkTCBCTapTrung + e.record.data.dkTCBCThanhToanTaiDonVi + e.record.data.dkTKBD + e.record.data.dkKinhDoanh;

                BangNhapSDCNX.Edit(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);

                var grid = App.grdSoDuTMCuoiNgay;
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
        <ext:GridPanel runat="server" ID="grdSoDuTMCuoiNgay" TitleAlign="Center" MinHeight="300" Height="800" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items>                        
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
                <ext:Store runat="server" ID="stoSoDuTMCuoiNgay">
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="MaKeToanNgay" />
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="Ngay" />
                                <ext:ModelField Name="DinhMucLuuQuyTCBC" />
                                <ext:ModelField Name="DinhMucLuuQuyTKBD" />
                                <ext:ModelField Name="DinhMucLuuQuyTCBC_DonVi" />
                                <ext:ModelField Name="DinhMucLuuQuyTKBD_DonVi" />

                                <ext:ModelField Name="TCBCTapTrung" />
                                <ext:ModelField Name="TCBCThanhToanTaiDonVi" />
                                <ext:ModelField Name="TKBD" />
                                <ext:ModelField Name="KinhDoanh" />
                                <ext:ModelField Name="Cong" />

                                <ext:ModelField Name="dkTCBCTapTrung" />
                                <ext:ModelField Name="dkTCBCThanhToanTaiDonVi" />
                                <ext:ModelField Name="dkTKBD" />
                                <ext:ModelField Name="dkKinhDoanh" />
                                <ext:ModelField Name="dkCong" />

                                <ext:ModelField Name="GhiChu" />
                                <ext:ModelField Name="Khoa" />
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
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;" Locked="true"/>
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Align="Center" Width="130" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy" Locked="true">
                        <Commands>
                            <ext:ImageCommand CommandName="InAn" Icon="Printer" >
                                <ToolTip Text="In giấy đề nghị Tiếp quỹ" />                                
                            </ext:ImageCommand>                            
                        </Commands>
                        <DirectEvents>
                            <Command OnEvent="InAn_Click">
                                <ExtraParams>
                                    <ext:Parameter Name="ValuesDCN" Value="record.data.MaKeToanNgay" Mode="Raw"/>
                                </ExtraParams>
                                <EventMask ShowMask="true" Msg="Đang thực thi ....." />
                            </Command>
                        </DirectEvents>
                    </ext:DateColumn>
                    <ext:Column runat="server" Text="Định mức" Locked="true">
                        <Columns>
                            <ext:Column runat="server" Text="TCBC" DataIndex="DinhMucLuuQuyTCBC_DonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                                     <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                             </ext:Column>
                            <ext:Column runat="server" Text="TKBĐ" DataIndex="DinhMucLuuQuyTKBD_DonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                                     <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                             </ext:Column>
                        </Columns>
                    </ext:Column>
                    
                    <ext:Column runat="server" Text="Số dư Tiền mặt cuối ngày">
                        <Columns>
                            <ext:Column runat="server" Text="Tập trung" DataIndex="TCBCTapTrung" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                                <Renderer Fn="mauDuCuoi" />
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />                                
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                            <ext:Column runat="server" Text="Tại đơn vị" DataIndex="TCBCThanhToanTaiDonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                            <ext:Column runat="server" Text="TKBĐ" DataIndex="TKBD" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                            <ext:Column runat="server" Text="Kinh doanh" DataIndex="KinhDoanh" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                        </Columns>
                    </ext:Column>
                    <ext:Column runat="server" Text="Cộng dư cuối" DataIndex="Cong" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>

                     <ext:Column runat="server" Text="Dự kiến chi trả cho Ngày hôm sau">
                        <Columns>
                            <ext:Column runat="server" Text="Tập trung" DataIndex="dkTCBCTapTrung" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="mauDuKienChi" />
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                            <ext:Column runat="server" Text="Tại đơn vị" DataIndex="dkTCBCThanhToanTaiDonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                            <ext:Column runat="server" Text="TKBĐ" DataIndex="dkTKBD" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                            <ext:Column runat="server" Text="Kinh doanh" DataIndex="dkKinhDoanh" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:Column>
                        </Columns>
                    </ext:Column>
                    <ext:Column runat="server" Text="Cộng dự kiến trả" DataIndex="dkCong" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:Column>

                    <ext:Column runat="server" Text="Ghi chú" DataIndex="GhiChu" Width="400" Align="Left" StyleSpec="font-weight:bold;">
                        <Editor>
                            <ext:TextField runat="server" />
                        </Editor>
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
                        <Edit Fn="edit" />
                    </Listeners>
                </ext:CellEditing>
            </Plugins>
        </ext:GridPanel>
    </form>
</body>
</html>
