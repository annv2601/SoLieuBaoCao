<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSoDuTienmatCuoiNgayDonVi.aspx.cs" Inherits="SoLieuBaoCao.SoDu.SoDuCuoiNgay.frmSoDuTienmatCuoiNgayDonVi" %>

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
                       <ext:Button runat="server" ID="btnNgayTruoc" Text="Ngày trước" MarginSpec="0 0 0 20" >
                           <DirectEvents>
                               <Click OnEvent="btnThangTruoc_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnNgaySau" Text="Ngày sau" MarginSpec="0 0 0 20">
                           <DirectEvents>
                               <Click OnEvent="btnThangSau_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnInTonQuy" Text="In Tồn quỹ" Icon="Printer" MarginSpec="0 0 0 20">
                           <DirectEvents>
                               <Click OnEvent="btnInTonQuy_Click" />
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
                                <ext:ModelField Name="DonVi" />
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
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Align="Center" Width="110" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy" Locked="true"/>
                    <ext:Column runat="server" Text="Đơn vị" Align="Left" DataIndex="DonVi" Width="160" StyleSpec="font-weight:bold;" Locked="true"/>
                    <ext:Column runat="server" Text="Định mức" Locked="true">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="TCBC" SummaryType="Sum" DataIndex="DinhMucLuuQuyTCBC_DonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                                     <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                    <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="TKBĐ" SummaryType="Sum" DataIndex="DinhMucLuuQuyTKBD_DonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                                     <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                    <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                             </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>
                    
                    <ext:Column runat="server" Text="Số dư Tiền mặt cuối ngày">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Tập trung" SummaryType="Sum" DataIndex="TCBCTapTrung" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                                <Renderer Fn="mauDuCuoi" />
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Tại đơn vị" SummaryType="Sum" DataIndex="TCBCThanhToanTaiDonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="TKBĐ" SummaryType="Sum" DataIndex="TKBD" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Kinh doanh" SummaryType="Sum" DataIndex="KinhDoanh" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>
                    <ext:SummaryColumn runat="server" Text="Cộng dư cuối" SummaryType="Sum" DataIndex="Cong" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>

                     <ext:Column runat="server" Text="Dự kiến chi trả cho Ngày hôm sau">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Tập trung" SummaryType="Sum" DataIndex="dkTCBCTapTrung" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="mauDuKienChi" />
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Tại đơn vị" SummaryType="Sum" DataIndex="dkTCBCThanhToanTaiDonVi" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="TKBĐ" SummaryType="Sum" DataIndex="dkTKBD" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Kinh doanh" SummaryType="Sum" DataIndex="dkKinhDoanh" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                               <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>
                    <ext:SummaryColumn runat="server" Text="Cộng dự kiến trả" SummaryType="Sum" DataIndex="dkCong" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>

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
            <Features>
                            <ext:Summary ID="Summary1" runat="server" />
                        </Features>
        </ext:GridPanel>
    </form>
</body>
</html>
