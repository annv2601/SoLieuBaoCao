<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiTienCOD.aspx.cs" Inherits="SoLieuBaoCao.TienCOD.frmTheoDoiTienCOD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        
        <%--<ext:FieldContainer runat="server" Layout="HBoxLayout" MarginSpec="10 0 0 0">
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
            </Items>
        </ext:FieldContainer>--%>

        <ext:Hidden runat="server" ID="txtTuNgay" />
        <ext:Hidden runat="server" ID="txtDenNgay" />
        <ext:Hidden runat="server" ID="txtMaBuuCuc" />

        <ext:GridPanel runat="server" ID="grdTheoDoiTienCOD" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="20 0 0 0">
            <Store>
                <ext:Store runat="server" ID="stoTheoDoiTienCOD" >
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="Ten" />

                                <ext:ModelField Name="DuDauSanLuong" />
                                <ext:ModelField Name="DuDauSoTien" />
                                <ext:ModelField Name="NhanMoiSanLuong" />
                                <ext:ModelField Name="NhanMoiSoTien" />
                                <ext:ModelField Name="TraSanLuong" />
                                <ext:ModelField Name="TraSoTien" />
                                <ext:ModelField Name="ChuyenHoanSanLuong" />
                                <ext:ModelField Name="ChuyenHoanSoTien" />
                                <ext:ModelField Name="PSGiamKhacSanLuong" />
                                <ext:ModelField Name="PSGiamKhacSoTien" />
                                <ext:ModelField Name="DuCuoiSanLuong" />
                                <ext:ModelField Name="DuCuoiSoTien" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã Bưu cục" DataIndex="MaBuuCuc" Width="120" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Tên Bưu cục" DataIndex="Ten" Width="280" Align="Left" StyleSpec="font-weight:bold;">                       
                    </ext:Column>

                    <ext:Column runat="server" Text="Dư đầu" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="DuDauSanLuong" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="DuDauSoTien" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Nhận mới" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="NhanMoiSanLuong" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="NhanMoiSoTien" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Phát thành công" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="TraSanLuong" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="TraSoTien" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Chuyển hoàn" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="ChuyenHoanSanLuong" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="ChuyenHoanSoTien" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Khác" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="PSGiamKhacSanLuong" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="PSGiamKhacSoTien" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Dư cuối" StyleSpec="font-weight:bold;" Align="Center">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="DuCuoiSanLuong" SummaryType="Sum" Width="110" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Số tiền" DataIndex="DuCuoiSoTien" SummaryType="Sum" Width="180" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>
                    

                    <ext:Column runat="server" Text="" DataIndex="" Width="200" Align="Center" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:RowSelectionModel Mode="Single" runat="server" />
            </SelectionModel>            
            <Features>
                <ext:Summary runat="server"/>
            </Features>
            <DirectEvents>
                <ItemDblClick OnEvent="grdTheoDoiTienCOD_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesCODDV" Value="Ext.encode(#{grdTheoDoiTienCOD}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
