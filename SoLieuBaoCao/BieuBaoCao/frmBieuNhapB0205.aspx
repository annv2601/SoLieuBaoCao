<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBieuNhapB0205.aspx.cs" Inherits="SoLieuBaoCao.BieuBaoCao.frmBieuNhapB0205" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdBieuNhapB0205" TitleAlign="Center" MinHeight="300" Height="1000">
            <Store>
                <ext:Store runat="server" ID="stoNhapB0205" >
                    <Model>
                        <ext:Model runat="server" IDProperty="IDChiTieu">
                            <Fields>
                                <ext:ModelField Name="MaBieuBaoCao" />
                                <ext:ModelField Name="IDChiTieu" />
                                <ext:ModelField Name="Ten" />
                                <ext:ModelField Name="MaSo" />
                                <ext:ModelField Name="ThuTu" />
                                <ext:ModelField Name="DonViTinh" />

                                <ext:ModelField Name="SLDi" />
                                <ext:ModelField Name="DoanhThu" />
                                <ext:ModelField Name="DoanhThuLK" />
                                <ext:ModelField Name="ThueSuat" />
                                <ext:ModelField Name="ThueGTGT" />
                                <ext:ModelField Name="ThueGTGTLK" />
                                <ext:ModelField Name="SLNVu" />
                                <ext:ModelField Name="SLDen" />

                                <ext:ModelField Name="InDamNghieng" />
                                <ext:ModelField Name="InDam" />
                                <ext:ModelField Name="InNghieng" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button runat="server" ID="btnKhoiTaoLaiBaoCao" Text="Khởi tạo lại" Icon="BookAddressesAdd" Width="150" UI="Primary">
                            <DirectEvents>
                                <Click OnEvent="btnKhoiTaoLaiBaoCao_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>

                        <ext:Button runat="server" ID="btnGuiBaoCao" Text="Gửi báo cáo" Icon="TransmitGo" Width="150" UI="Primary">

                        </ext:Button>

                        <ext:ToolbarFill/>

                        <ext:Button runat="server" ID="btnIn" Text="In báo biểu" Icon="Printer" Width="150" UI="Primary">
                            <DirectEvents>
                                <Click OnEvent="btnIn_CLick">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>

                        <ext:Button runat="server" ID="btnXuatExcel" Text="Xuất Excel" Icon="PageExcel" Width="150" UI="Primary">
                            <DirectEvents>
                                <Click OnEvent="btnXuatExcel_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <%--<ext:Column runat="server" Text="Thứ tự" DataIndex="ThuTu" Width="60" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>--%>
                    <ext:Column runat="server" Text="Chỉ tiêu" DataIndex="Ten" Width="350" StyleSpec="font-weight:bold;" CellWrap="true">                        
                        <Renderer Fn="change"/>
                    </ext:Column>
                    <ext:Column runat="server" Text="ĐVT" DataIndex="DonViTinh" Width="70" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã số" DataIndex="MaSo" Width="80" Align="Center" StyleSpec="font-weight:bold;">
                        <Renderer Fn="pctChange" />
                    </ext:Column>                    

                    <ext:NumberColumn runat="server" Text="SL Đi" DataIndex="SLDi" Align="Right" Width="100" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                    
                    <ext:Column runat="server" Text="Doanh thu (Chưa có thuế)" StyleSpec="font-weight:bold;">
                        <Columns>
                            <ext:NumberColumn runat="server" Text="Phát sinh" DataIndex="DoanhThu" Align="Right" Width="150" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                            <ext:NumberColumn runat="server" Text="Lũy kế" DataIndex="DoanhThuLK" Align="Right" Width="150" StyleSpec="font-weight:bold;"/>
                        </Columns>
                    </ext:Column>
                    
                    <ext:Column runat="server" Text="Thuế Giá trị gia tăng" StyleSpec="font-weight:bold;">
                        <Columns>
                            <ext:NumberColumn runat="server" Text="Thuế suất" DataIndex="ThueSuat" Align="Right" Width="100" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                            <ext:NumberColumn runat="server" Text="Phát sinh" DataIndex="ThueGTGT" Align="Right" Width="150" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                            <ext:NumberColumn runat="server" Text="Lũy kế" DataIndex="ThueGTGTLK" Align="Right" Width="150" StyleSpec="font-weight:bold;"/>
                        </Columns>
                    </ext:Column>
                    
                    <ext:NumberColumn runat="server" Text="SL nghiệp vụ đi" DataIndex="SLNVu" Align="Right" Width="100" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                    <ext:NumberColumn runat="server" Text="SL Đến" DataIndex="SLDen" Align="Right" Width="100" StyleSpec="font-weight:bold;"></ext:NumberColumn>

                </Columns>
            </ColumnModel>
            <SelectionModel>
                <ext:CellSelectionModel runat="server" >                    
                </ext:CellSelectionModel>                
            </SelectionModel>
            <Plugins>
                <ext:FilterHeader runat="server" OnCreateFilterableField="OnCreateFilterableField" />                
            </Plugins>
            <DirectEvents>
                <ItemDblClick OnEvent="grdBieuNhapB0205_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesCTSTK" Value="Ext.encode(#{grdBieuNhapB0205}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
