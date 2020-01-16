<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSoDuTGNHCuoiNgayDonVi.aspx.cs" Inherits="SoLieuBaoCao.SoDu.SoDuCuoiNgay.frmSoDuTGNHCuoiNgayDonVi" %>

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

                BangNhapSDCNX.Edit(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);

                var grid = App.grdSoDuTGNHCuoiNgay;
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
        <ext:GridPanel runat="server" ID="grdSoDuTGNHCuoiNgay" TitleAlign="Center" MinHeight="300" Height="800" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items>                        
                       <ext:Button runat="server" ID="btnNgayTruoc" Text="Ngày trước" MarginSpec="0 0 0 20" UI="Info" Width="160">
                           <DirectEvents>
                               <Click OnEvent="btnThangTruoc_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnNgaySau" Text="Ngày sau" MarginSpec="0 0 0 20" Width="160" UI="Info">
                           <DirectEvents>
                               <Click OnEvent="btnThangSau_Click" />
                           </DirectEvents>
                       </ext:Button>
                       
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoSoDuTGNHCuoiNgay">
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="MaKeToanNgay" />
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="TenDonVi" />                                
                                <ext:ModelField Name="DinhMucLuuQuyTCBC" />
                                <ext:ModelField Name="DinhMucLuuQuyTKBD" />
                                <ext:ModelField Name="DinhMucLuuQuyTCBC_DonVi" />
                                <ext:ModelField Name="DinhMucLuuQuyTKBD_DonVi" />

                                <ext:ModelField Name="TCBCTapTrung" />
                                <ext:ModelField Name="TCBCThanhToanTaiDonVi" />
                                <ext:ModelField Name="TKBD" />
                                <ext:ModelField Name="KinhDoanh" />
                                <ext:ModelField Name="Cong" />

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
                    <ext:Column runat="server" Text="Đơn vị" Align="Left" DataIndex="TenDonVi" Width="160" StyleSpec="font-weight:bold;" Locked="true"/>
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
                    
                    <ext:Column runat="server" Text="Số dư Tiền gửi ngân hàng cuối ngày">
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
