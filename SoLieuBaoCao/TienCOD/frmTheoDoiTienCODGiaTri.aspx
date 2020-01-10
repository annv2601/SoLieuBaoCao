<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiTienCODGiaTri.aspx.cs" Inherits="SoLieuBaoCao.TienCOD.frmTheoDoiTienCODGiaTri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdTheoDoiTienCODGiaTri" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items> 
                       <ext:DateField runat="server" ID="txtTuNgay" FieldLabel="Từ ngày" LabelStyle="font-weight:bold;" LabelWidth="100" Width="240" Format="dd/MM/yyyy"/>
                       <ext:DateField runat="server" ID="txtDenNgay" FieldLabel="Đến ngày" LabelStyle="font-weight:bold;" LabelWidth="100" Width="240" MarginSpec="0 0 0 20" Format="dd/MM/yyyy"/>

                       <ext:Button runat="server" ID="btnTren1Trieu" Text="Trên 1 triệu" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTren1Trieu_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTren2Trieu" Text="Trên 2 triệu" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTren2Trieu_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTren3Trieu" Text="Trên 3 triệu" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTren3Trieu_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTren5Trieu" Text="Trên 5 triệu" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTren5Trieu_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnTren10Trieu" Text="Trên 10 triệu" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTren10Trieu_Click" />
                           </DirectEvents>
                       </ext:Button>
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoTheoDoiTienCODGiaTri" >
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="TuNgay" />
                                <ext:ModelField Name="DenNgay" />
                                <ext:ModelField Name="Ma" />
                                <ext:ModelField Name="Ten" />
                                <ext:ModelField Name="SoLuong" />
                                <ext:ModelField Name="GiaTri" />
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

                    
                    <ext:SummaryColumn runat="server" Text="Tổng tiền nộp" DataIndex="GiaTri" SummaryType="Sum" Width="260" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số lượng" DataIndex="SoLuong" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>

                    <ext:Column runat="server" Text="" DataIndex="" Width="500" Align="Center" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:RowSelectionModel Mode="Single" runat="server" />
            </SelectionModel>            
            <Features>
                <ext:Summary runat="server"/>
            </Features>
            <DirectEvents>
                <ItemDblClick OnEvent="grdTheoDoiTienCODGiaTri_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesGT" Value="Ext.encode(#{grdTheoDoiTienCODGiaTri}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
