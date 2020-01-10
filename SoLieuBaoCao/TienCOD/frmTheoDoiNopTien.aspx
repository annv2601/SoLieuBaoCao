<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiNopTien.aspx.cs" Inherits="SoLieuBaoCao.TienCOD.frmTheoDoiNopTien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdTheoDoiNopTien" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items> 
                       <ext:Button runat="server" ID="btn30Ngay" Text="30 Ngày gần đây" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btn30Ngay_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTrongThang" Text="Tháng hiện tại" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTrongThang_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnHomQua" Text="Ngày hôm qua" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnHomQua_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnHomNay" Text="Ngày hôm nay" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnHomNay_Click" />
                           </DirectEvents>
                       </ext:Button>
                       
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoTDNopTien" >
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="TuNgay" />
                                <ext:ModelField Name="DenNgay" />
                                <ext:ModelField Name="Ma" />
                                <ext:ModelField Name="Ten" />
                                <ext:ModelField Name="SoLuong" />
                                <ext:ModelField Name="TongTienNop" />
                                <ext:ModelField Name="TongTienCo" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã" DataIndex="Ma" Width="120" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Đơn vị" DataIndex="Ten" Width="280" Align="Left" StyleSpec="font-weight:bold;">                       
                    </ext:Column>

                    <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="SoLuong" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Tổng tiền nộp" DataIndex="TongTienNop" SummaryType="Sum" Width="260" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Tổng tiền có" DataIndex="TongTienCo" SummaryType="Sum" Width="260" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>

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
                <ItemDblClick OnEvent="grdTheoDoiNopTien_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesNT" Value="Ext.encode(#{grdTheoDoiNopTien}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
