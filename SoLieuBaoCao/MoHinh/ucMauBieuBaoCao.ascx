<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMauBieuBaoCao.ascx.cs" Inherits="SoLieuBaoCao.MoHinh.ucBieuBaoCao" %>
<ext:Panel 
    ID="Panel1" 
    runat="server">
    <Items>
        <ext:Hidden runat="server" ID="txtID" />
        <ext:FieldContainer runat="server">
            <FieldDefaults LabelStyle="font-weight:bold;" LabelWidth="80" />
            <Items>
                <ext:FieldContainer runat="server" Layout="HBoxLayout" MarginSpec="10 0 0 0">
                    <Items>
                        <ext:TextField runat="server" FieldLabel="Mã" ID="txtMa" Width="190"/>
                        <ext:TextField runat="server" FieldLabel="Tên" ID="txtTen" MarginSpec="0 0 0 10" Width="290"/>
                    </Items>
                </ext:FieldContainer>
                <ext:TextArea runat="server" FieldLabel="Tên tắt" ID="txtTenTat" Width="500" MarginSpec="10 0 0 0" />
                <ext:TextArea runat="server" FieldLabel="Tiêu đề 1" ID="txtTieuDe1" Width="500" MarginSpec="10 0 0 0" />
                <ext:TextArea runat="server" FieldLabel="Tiêu đề 2" ID="txtTieuDe2" Width="500" MarginSpec="10 0 0 0" />
                <ext:TextArea runat="server" FieldLabel="Tiêu đề 3" ID="txtTieuDe3" Width="500" MarginSpec="10 0 0 0" />
                <ext:FieldContainer runat="server" Layout="HBoxLayout">
                    <Items>
                        <ext:NumberField runat="server" FieldLabel="Mức" ID="txtMuc" Width="160" AllowDecimals="false" LabelWidth="50"/>
                        <ext:NumberField runat="server" FieldLabel="Cấp" ID="txtCap" MarginSpec="0 0 0 10" Width="160" AllowDecimals="false" LabelWidth="50"/>
                        <ext:NumberField runat="server" FieldLabel="Nhóm" ID="txtNhom" MarginSpec="0 0 0 10" Width="160" AllowDecimals="false" LabelWidth="50"/>
                    </Items>
                </ext:FieldContainer>
                
                <ext:FieldContainer runat="server" Layout="HBoxLayout" MarginSpec="10 0 0 0">
                    <Items>
                        <ext:DateField runat="server" FieldLabel="Ngày áp dụng" ID="txtNgayApDung" Width="240" Format="dd/MM/yyyy"/>
                        <ext:DateField runat="server" FieldLabel="Ngày kết thúc" ID="txtNgayKetThuc" MarginSpec="0 0 0 10" Width="240" Format="dd/MM/yyyy"/>
                    </Items>
                </ext:FieldContainer>
                <ext:TextArea runat="server" FieldLabel="Ghi chú" ID="txtGhiChu" Width="500" MarginSpec="10 0 0 0" />
            </Items>
        </ext:FieldContainer>
    </Items>
</ext:Panel>