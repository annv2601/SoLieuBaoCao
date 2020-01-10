<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmChiTietNopTien.aspx.cs" Inherits="SoLieuBaoCao.TienCOD.frmChiTietNopTien" %>

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
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" />
    <form id="form1" runat="server">
        <ext:Hidden runat="server" ID="txtTuNgay"/>
        <ext:Hidden runat="server" ID="txtDenNgay"/>
        <ext:Hidden runat="server" ID="txtMaBuuCuc"/>

        <ext:GridPanel
            ID="grdChiTietNT"
            runat="server"
            Frame="true"
            Title=""
            Icon="ApplicationViewColumns"
            Height="800">
            <Store>
                <ext:Store ID="stoChiTietNT" runat="server">                    
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="Ngay" />
                                <ext:ModelField Name="Gio" />
                                <ext:ModelField Name="Lan" />
                                <ext:ModelField Name="NguoiGiao"/>
                                <ext:ModelField Name="TongTienNop"/>
                                <ext:ModelField Name="BangChu"/>
                                <ext:ModelField Name="TongTienCo"/>
                                <ext:ModelField Name="DiaDiemGiaoNhan"/>
                                <ext:ModelField Name="PhuongThucGiaoNhan"/>
                                <ext:ModelField Name="ChiNhanhNganHangGiaoNhan"/>
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel runat="server">
                <Columns>                    
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Width="200" Format="dd/MM/yyyy" StyleSpec="font-weight:bold;"/>
                    <%--<ext:DateColumn runat="server" Text="Giờ" DataIndex="Gio" StyleSpec="font-weight:bold;"/>--%>
                    <ext:Column runat="server" Text="Giờ" DataIndex="Gio" Align="Center" StyleSpec="font-weight:bold;"/>

                    <ext:Column runat="server" Text="Lần" DataIndex="Lan" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Người giao" DataIndex="NguoiGiao" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>

                    <ext:SummaryColumn runat="server" Text="Số tiền nộp" DataIndex="TongTienNop" SummaryType="Sum" Width="200" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>

                    <ext:Column runat="server" Text="Bằng chữ" DataIndex="BangChu" Width="300" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:SummaryColumn runat="server" Text="Số tiền có" DataIndex="TongTienCo" SummaryType="Sum" Width="200" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>
                    
                    <ext:Column runat="server" Text="Địa điểm" DataIndex="DiaDiemGiaoNhan" Width="240" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Giao nhận" DataIndex="PhuongThucGiaoNhan" Width="160" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Chi nhánh ngân hàng" DataIndex="ChiNhanhNganHangGiaoNhan" Width="280" Align="Left" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <Listeners>
                
            </Listeners>
            <SelectionModel>
                <ext:CellSelectionModel runat="server" Mode="Single" />
            </SelectionModel>
            
            <Features>
                <ext:Summary runat="server"/>
            </Features>
        </ext:GridPanel>
    </form>
</body>
</html>
