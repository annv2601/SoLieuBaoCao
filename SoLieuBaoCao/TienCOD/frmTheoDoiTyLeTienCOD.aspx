<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiTyLeTienCOD.aspx.cs" Inherits="SoLieuBaoCao.TienCOD.frmTheoDoiTyLeTienCOD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        var template = '<span style="color:{0};">{1}</span>';

        var change = function (value) {
            return Ext.String.format(template, (value > 0) ? "green" : "red", value);
        };

        var pctChange = function (value) {
            return Ext.String.format(template, (value > 0.5) ? "green" : "red", value + "%");
        };
    </script>
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
            </Items>
        </ext:FieldContainer>

        <ext:GridPanel runat="server" ID="grdTheoDoiTienCOD" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="20 0 0 0">
            <Store>
                <ext:Store runat="server" ID="stoTheoDoiTienCOD" >
                    <Model>
                        <ext:Model runat="server">
                            <Fields>
                                <ext:ModelField Name="Ma" />
                                <ext:ModelField Name="Ten" />
                                
                                <ext:ModelField Name="NhanMoiSoTien" />
                                <ext:ModelField Name="TraSoTien" />
                                <ext:ModelField Name="ChuyenHoanSoTien" />
                                <ext:ModelField Name="DuCuoiSoTien" />

                                <ext:ModelField Name="TyLePhat" />
                                <ext:ModelField Name="TyLeChuyenHoan" />
                                <ext:ModelField Name="TyLeTon" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã" DataIndex="Ma" Width="100" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Đơn vị" DataIndex="Ten" Width="240" Align="Left" StyleSpec="font-weight:bold;">                       
                    </ext:Column>

                    <ext:SummaryColumn runat="server" Text="Đến nhận mới" DataIndex="NhanMoiSoTien" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Phát thành công" DataIndex="TraSoTien" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Chuyển hoàn" DataIndex="ChuyenHoanSoTien" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Dư cuối" DataIndex="DuCuoiSoTien" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>

                    <ext:SummaryColumn runat="server" Text="Tỷ lệ phát thành công" DataIndex="TyLePhat" Width="140" Align="Right" StyleSpec="font-weight:bold;">
                       <Renderer Fn="pctChange" />
                    </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Tỷ lệ chuyển hoàn" DataIndex="TyLeChuyenHoan" Width="140" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="pctChange" />
                    </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Tỷ lệ tồn" DataIndex="TyLeTon" Width="140" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="pctChange" />
                    </ext:SummaryColumn>
                                        

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
