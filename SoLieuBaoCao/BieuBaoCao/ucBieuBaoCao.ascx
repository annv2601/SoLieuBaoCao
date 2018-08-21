<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucBieuBaoCao.ascx.cs" Inherits="SoLieuBaoCao.BieuBaoCao.ucBieuBaoCao" %>
<ext:Panel 
    ID="Panel1" 
    runat="server">
    <Items>
        <ext:SelectBox runat="server" ID="slbMauBieuDinhNghia" DisplayField="Ten" ValueField="ID"
             FieldLabel="Biểu mẫu" Width="380" MarginSpec="20 0 0 0" LabelStyle="font-weight:bold;">
            <Store>
                <ext:Store runat="server" ID="stoBieuDN">
                    <Fields>
                        <ext:ModelField Name="ID" />
                        <ext:ModelField Name="Ten" />
                    </Fields>
                </ext:Store>
            </Store>
        </ext:SelectBox>
        <ext:FieldContainer runat="server" Layout="HBoxLayout">
            <Items>
                <ext:SelectBox runat="server" ID="slbThang" DisplayField="Ten" ValueField="ID"
                     FieldLabel="Tháng" Width="180" MarginSpec="30 0 0 0" LabelStyle="font-weight:bold;" LabelWidth="60">
                    <Store>
                        <ext:Store runat="server" ID="stoThang">
                            <Fields>
                                <ext:ModelField Name="ID" />
                                <ext:ModelField Name="Ten" />
                            </Fields>
                        </ext:Store>
                    </Store>
                </ext:SelectBox>
                <ext:NumberField runat="server" ID="txtNam" FieldLabel="Năm" AllowDecimals="false" MinValue="2000"
                    Width="180" MarginSpec="30 0 0 20" LabelStyle="font-weight:bold;" LabelWidth="60" />
            </Items>
        </ext:FieldContainer>
    </Items>
</ext:Panel>