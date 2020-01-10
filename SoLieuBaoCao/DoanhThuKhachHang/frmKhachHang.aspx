<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmKhachHang.aspx.cs" Inherits="SoLieuBaoCao.DoanhThuKhachHang.frmKhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        var template = 'color:{0};';

        var change = function (value, meta) {
            meta.style = Ext.String.format(template, (value !="") ? "green" : "red");
            return "<b>"+value+"</b>";
        };

        var pctChange = function (value, meta) {
            meta.style = Ext.String.format(template, (value !="") ? "red" : "green");
            return value ;
        };

        var beforeCellEditHandler = function (e) {
            if (e.record.data.NhapTay == false) {
                CellEditing1.cancelEdit(); 
            }
        }

        var edit = function (editor, e) {
            if (e.value !== e.originalValue) {

                BangKHX.Edit(e.record.data.ID, e.field, e.originalValue, e.value, e.record.data);

                //var grid = App.grdKhachHang;
                //var pos = grid.getSelectionModel().getCurrentPosition();
                //grid.editingPlugin.startEdit(pos.row + 1, pos.column);
            }
        };
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdKhachHang" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items> 
                       <ext:SelectBox runat="server" ID="slbNhom" DisplayField="Ten" ValueField="Ma" FieldLabel="Nhóm" LabelStyle="font-weight:bold;" LabelWidth="60" Width="320">
                            <Store>
                                <ext:Store runat="server" ID="stoNhom">
                                    <Fields>
                                        <ext:ModelField Name="Ma" />
                                        <ext:ModelField Name="Ten" />
                                    </Fields>
                                </ext:Store>
                            </Store>
                        </ext:SelectBox>
                       <ext:TextField runat="server" ID="txtMaDonVi" FieldLabel="Mã đơn vị" Width="200" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20"/>

                       <ext:Button runat="server" ID="btnTuDauTuan" Text="Từ đầu Tuần" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTuDauTuan_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTuDauThang" Text="Từ đầu Tháng" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTuDauThang_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTuDauNam" Text="Từ đầu năm" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTuDauNam_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>                       
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoKhachHang" >
                    <Model>
                        <ext:Model runat="server" IDProperty="ID">
                            <Fields>
                                <ext:ModelField Name="ID" />
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="BuuCuc" />
                                <ext:ModelField Name="Nhom" />
                                <ext:ModelField Name="NhomKH" />
                                <ext:ModelField Name="MaKhachHang" />
                                <ext:ModelField Name="TenKhachHang" />
                                <ext:ModelField Name="DiaChiKhachHang" />
                                <ext:ModelField Name="NgayPhatSinhDoanhThu" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã KH" DataIndex="MaKhachHang" Width="200" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Tên KH" DataIndex="TenKhachHang" Width="380" Align="Left" StyleSpec="font-weight:bold;">                       
                    </ext:Column>                    
                    <ext:DateColumn runat="server" Text="Ngày bắt đầu PSDT" DataIndex="NgayPhatSinhDoanhThu" Width="160" Align="Center" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy">
                        <Editor>
                            <ext:DateField runat="server" Format="dd/MM/yyyy" />
                        </Editor>
                    </ext:DateColumn>

                    <ext:Column runat="server" Text="Nhóm KH" DataIndex="NhomKH" Width="180" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Bưu cục" DataIndex="BuuCuc" Width="180" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Địa chỉ KH" DataIndex="DiaChiKhachHang" Width="400" Align="Center" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:CellSelectionModel runat="server" />
            </SelectionModel>
             <Plugins>
                <ext:FilterHeader runat="server" OnCreateFilterableField="OnCreateFilterableField" />
                <ext:CellEditing runat="server" ClicksToEdit="1">
                    <Listeners>
                        <Edit Fn="edit" />
                    </Listeners>
                </ext:CellEditing>
            </Plugins>
        </ext:GridPanel>
    </form>
</body>
</html>
