<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucChiTieuMauBieu.ascx.cs" Inherits="SoLieuBaoCao.MoHinh.ucChiTieuMauBieu" %>
<ext:Panel 
    ID="Panel1" 
    runat="server">
    <Items>
        <ext:FieldContainer runat="server" MarginSpec="10 0 0 0" Layout="HBoxLayout">
        <LayoutConfig>
            <ext:HBoxLayoutConfig Align="Middle" Pack="Center" />            
        </LayoutConfig>
            <Items>
                <ext:Label runat="server" ID="txtTenChiTieu" StyleSpec="font-weight:bold; font-size:20px; color:green;" Width="700" Height="25" MarginSpec="0 0 0 5"/>
            </Items>
        </ext:FieldContainer>
        
        <ext:FormPanel 
            ID="Panel2" 
            runat="server" Border="false" 
                    Header="false" 
                    AnchorHorizontal="100%" Layout="FormLayout" MarginSpec="10 0 0 0">
            <Items>
                <ext:Hidden runat="server" ID="txtIDChiTieuMauBieu" />
                <ext:Hidden runat="server" ID="txtIDMauBieu" />
                
                <ext:FieldContainer runat="server">
                    <Items>
                        <ext:FieldContainer runat="server" Layout="HBoxLayout">
                        <Items>
                            <ext:TextField runat="server" ID="txtThuTu" Width="140" FieldLabel="Thứ tự" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 0" LabelWidth="70"/>
                            <ext:Checkbox runat="server" ID="chkInDam" Width="140" FieldLabel="In đậm" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" LabelWidth="70"/>
                            <ext:Checkbox runat="server" ID="chkInNghieng" Width="140" FieldLabel="In nghiêng" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" LabelWidth="80"/>
                        </Items>
                        </ext:FieldContainer>
                        <ext:FieldContainer runat="server" Layout="HBoxLayout">
                        <Items>
                            <ext:Checkbox runat="server" ID="chkNhapTay" Width="140" FieldLabel="Nhập tay" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 0" LabelWidth="70"/>
                            <ext:NumberField runat="server" ID="txtSTTsx" Width="140" FieldLabel="STT sx" AllowDecimals="true" DecimalPrecision="3" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" LabelWidth="70"/>
                        </Items>
                        </ext:FieldContainer>                        
                    </Items>
                </ext:FieldContainer>
            </Items>
        </ext:FormPanel>
    </Items>
</ext:Panel>