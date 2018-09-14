<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmChiTietPaypost.aspx.cs" Inherits="SoLieuBaoCao.SoLieuPhatHanh.frmChiTietPaypost" %>

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
            ID="grdChiTietPP"
            runat="server"
            Frame="true"
            Title=""
            Icon="ApplicationViewColumns"
            Height="800">
            <Store>
                <ext:Store ID="stoChiTietPP" runat="server" GroupField="Ngay">                    
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="MaDoiSoat" />
                                <ext:ModelField Name="Ngay" />
                                <ext:ModelField Name="TranTime" />
                                <ext:ModelField Name="InvokedFrom" />
                                <ext:ModelField Name="PAC"/>
                                <ext:ModelField Name="DichVu"/>
                                <ext:ModelField Name="AccountID"/>
                                <ext:ModelField Name="TranAmount"/>
                                <ext:ModelField Name="SenderName"/>
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel runat="server">
                <Columns>
                    <ext:SummaryColumn
                        runat="server"
                        TdCls="task"
                        Text="Giờ phát hành"
                        Sortable="true"
                        DataIndex="TranTime"
                        Hideable="false"
                        SummaryType="Count" Width="200"
                        Flex="1">
                        <SummaryRenderer Handler="return ((value === 0 || value > 1) ? '(' + value +' Phiếu)' : '(1 Phiếu)');" />
                    </ext:SummaryColumn>

                    <ext:Column runat="server" Text="Ngày" DataIndex="Ngay" Width="200" />

                    <ext:Column runat="server" Text="Loại" DataIndex="InvokedFrom" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã DV" DataIndex="PAC" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Dịch vụ" DataIndex="DichVu" Width="140" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Số phiếu" DataIndex="AccountID" Width="160" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Người gửi" DataIndex="SenderName" Width="280" Align="Left" StyleSpec="font-weight:bold;"/>

                    <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="TranAmount" SummaryType="Sum" Width="200" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>

                    <ext:Column runat="server" Text="" DataIndex="" Width="380" Align="Left" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <Listeners>
                
            </Listeners>
            <SelectionModel>
                <ext:CellSelectionModel runat="server" Mode="Single" />
            </SelectionModel>
            
            <Features>
                <ext:GroupingSummary
                    ID="Group1"
                    runat="server"
                    GroupHeaderTplString="{name}"
                    HideGroupedHeader="true"
                    EnableGroupingMenu="false" />
            </Features>
        </ext:GridPanel>
    </form>
</body>
</html>
