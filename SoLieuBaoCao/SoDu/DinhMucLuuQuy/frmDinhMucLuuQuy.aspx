<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDinhMucLuuQuy.aspx.cs" Inherits="SoLieuBaoCao.SoDu.DinhMucLuuQuy.frmDinhMucLuuQuy" %>

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
        <ext:GridPanel runat="server" ID="grdDinhMucLuuQuy" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="0 0 0 0">            
            <Store>
                <ext:Store runat="server" ID="stoDinhMucLuuQuy">
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="TenBuuCuc" />
                                <ext:ModelField Name="DinhMucLuuQuyTCBC" />
                                <ext:ModelField Name="DinhMucLuuQuyTKBD" />
                                <ext:ModelField Name="DinhMucLuuQuyTCBC_DonVi" />
                                <ext:ModelField Name="DinhMucLuuQuyTKBD_DonVi" />
                                <ext:ModelField Name="NgayApDung" />
                                <ext:ModelField Name="NgayKetThuc" />
                                <ext:ModelField Name="GhiChu" />
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
                    <ext:Column runat="server" Text="Mã BC" Align="Left" DataIndex="MaBuuCuc" Width="120" StyleSpec="font-weight:bold;" />
                    <ext:Column runat="server" Text="Tên BC" Align="Left" DataIndex="TenBuuCuc" Width="260" StyleSpec="font-weight:bold;" />
                    <ext:Column runat="server" Text="Định mức">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="TCBC" DataIndex="DinhMucLuuQuyTCBC_DonVi" Align="Right" Width="200" StyleSpec="font-weight:bold;">
                                     <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="TKBĐ" DataIndex="DinhMucLuuQuyTKBD_DonVi" Align="Right" Width="200" StyleSpec="font-weight:bold;">
                                     <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <Editor>
                                    <ext:NumberField runat="server" MinValue="0" AllowDecimals="false" />
                                </Editor>
                             </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Ghi chú" DataIndex="GhiChu" Width="500" Align="Left" StyleSpec="font-weight:bold;">
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
                <ext:Summary runat="server"/>
            </Features>
        </ext:GridPanel>
    </form>
</body>
</html>
