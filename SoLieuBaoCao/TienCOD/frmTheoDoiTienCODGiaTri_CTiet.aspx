<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiTienCODGiaTri_CTiet.aspx.cs" Inherits="SoLieuBaoCao.TienCOD.frmTheoDoiTienCODGiaTri_CTiet" %>

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
        <ext:Hidden runat="server" ID="txtSoTien"/>
        <ext:Hidden runat="server" ID="txtGiaTri"/>

        <ext:GridPanel
            ID="grdChiTietNT"
            runat="server"
            Frame="true"
            Title=""
            Icon="ApplicationViewColumns"
            Height="800">
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button ID="btnXuatExcel" runat="server" Text="Xuất Excel" Icon="PageExcel">
                            <DirectEvents>
                                <Click OnEvent="btnXuatExcel_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện .... " />
                                </Click>
                            </DirectEvents>
                        </ext:Button>
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store ID="stoChiTietNT" runat="server">                    
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="Ngay" />
                                <ext:ModelField Name="ToPOSCode" />
                                <ext:ModelField Name="BuuCuc" />
                                <ext:ModelField Name="ItemCode"/>
                                <ext:ModelField Name="AcceptancePOSCode"/>
                                <ext:ModelField Name="SendingTime"/>
                                <ext:ModelField Name="CustomerCode"/>
                                <ext:ModelField Name="SenderFullname"/>
                                <ext:ModelField Name="SenderAddress"/>
                                <ext:ModelField Name="SenderTel"/>

                                <ext:ModelField Name="MailTripNumber"/>
                                <ext:ModelField Name="PostBagNumber"/>
                                <ext:ModelField Name="IncomingDate"/>
                                <ext:ModelField Name="ReceiverFullname"/>
                                <ext:ModelField Name="ReceiverAddress"/>
                                <ext:ModelField Name="ReceiverTel"/>
                                <ext:ModelField Name="Weight"/>
                                <ext:ModelField Name="SendingContent"/>
                                <ext:ModelField Name="Value"/>
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel runat="server">
                <Columns>                    
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Width="160" Format="dd/MM/yyyy" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã BC Phát" DataIndex="ToPOSCode" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Tên Bưu cục" DataIndex="BuuCuc" Width="200" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Số hiệu" DataIndex="ItemCode" Width="200" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:SummaryColumn runat="server" Text="Số tiền COD" DataIndex="Value" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>
                    <ext:Column runat="server" Text="Mã BC chấp nhận" DataIndex="AcceptancePOSCode" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:DateColumn runat="server" Text="Ngày chấp nhận" DataIndex="SendingTime" Width="160" Align="Left" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy H:m:s"/>
                    <ext:Column runat="server" Text="Mã KH" DataIndex="CustomerCode" Width="160" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Tên người gửi" DataIndex="SenderFullname" Width="220" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Địa chỉ người gửi" DataIndex="SenderAddress" Width="280" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="ĐT người gửi" DataIndex="SenderTel" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    
                    <ext:Column runat="server" Text="Số CT đến" DataIndex="MailTripNumber" Width="100" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Số túi thư" DataIndex="PostBagNumber" Width="100" Align="Left" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy H:m:s"/>
                    <ext:DateColumn runat="server" Text="Ngày giờ đến" DataIndex="IncomingDate" Width="160" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Tên người nhận" DataIndex="ReceiverFullname" Width="220" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Địa chỉ người nhận" DataIndex="ReceiverAddress" Width="280" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="ĐT người nhận" DataIndex="ReceiverTel" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Trọng lượng BG" DataIndex="Weight" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Nội dung BG" DataIndex="SendingContent" Width="380" Align="Left" StyleSpec="font-weight:bold;"/>

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
