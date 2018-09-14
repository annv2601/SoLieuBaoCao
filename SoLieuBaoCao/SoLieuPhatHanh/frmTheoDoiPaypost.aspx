<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiPaypost.aspx.cs" Inherits="SoLieuBaoCao.SoLieuPhatHanh.frmTheoDoiPaypost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        
        <ext:FieldContainer runat="server" Layout="HBoxLayout" MarginSpec="10 0 0 0">
            <Items>
                <ext:DateField runat="server" ID="txtTuNgay" FieldLabel="Từ ngày" LabelStyle="font-weight:bold;" LabelWidth="100" Width="240" Format="dd/MM/yyyy"/>
                <ext:DateField runat="server" ID="txtDenNgay" FieldLabel="Đến ngày" LabelStyle="font-weight:bold;" LabelWidth="100" Width="240" MarginSpec="0 0 0 20" Format="dd/MM/yyyy"/>
                
                
                <ext:Button runat="server" ID="btnHienThi" Text="Hiển thị" Icon="MagnifierZoomIn" Width="120" MarginSpec="0 0 0 20">
                    <DirectEvents>
                        <Click OnEvent="btnHienThi_Click">
                            <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button runat="server" ID="btnLayTrongNgay" Text="Lấy hiện tại" Icon="CalculatorLink" Width="160" MarginSpec="0 0 0 20">
                    <DirectEvents>
                        <Click OnEvent="btnLayTrongNgay_Click">
                            <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
            </Items>
        </ext:FieldContainer>

        <ext:GridPanel runat="server" ID="grdTheoDoiPaypost" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="20 0 0 0">
            <Store>
                <ext:Store runat="server" ID="stoTDPaypost" >
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="DonVi" />
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="TenBuuCuc" />
                                <ext:ModelField Name="TenBuuCucGop" />

                                <ext:ModelField Name="SoLuongThu" />
                                <ext:ModelField Name="SoTienThu" />
                                <ext:ModelField Name="SoLuongChi" />
                                <ext:ModelField Name="SoTienChi" />
                                <ext:ModelField Name="SoLuongNormal" />
                                <ext:ModelField Name="SoTienNormal" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <%--<ext:Column runat="server" Text="Đơn vị" DataIndex="DonVi" Width="240" Align="Left" StyleSpec="font-weight:bold;">
                    </ext:Column>--%>
                    <ext:Column runat="server" Text="Mã Bưu cục" DataIndex="MaBuuCuc" Width="120" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Tên Bưu cục" DataIndex="TenBuuCucGop" Width="280" Align="Left" StyleSpec="font-weight:bold;">                       
                    </ext:Column>

                    <ext:Column runat="server" Text="Thu" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="SoLuongThu" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="SoTienThu" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Chi" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="SoLuongChi" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="SoTienChi" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Normal" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="SoLuongNormal" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="SoTienNormal" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>
                    

                    <ext:Column runat="server" Text="" DataIndex="" Width="400" Align="Center" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:RowSelectionModel Mode="Single" runat="server" />
            </SelectionModel>            
            <Features>
                <ext:Summary runat="server"/>
            </Features>
            <DirectEvents>
                <ItemDblClick OnEvent="grdTheoDoiPaypost_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesPP" Value="Ext.encode(#{grdTheoDoiPaypost}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
