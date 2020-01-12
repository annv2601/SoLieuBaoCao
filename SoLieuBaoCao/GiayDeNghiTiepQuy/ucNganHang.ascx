<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucNganHang.ascx.cs" Inherits="SoLieuBaoCao.GiayDeNghiTiepQuy.ucNganHang" %>
<ext:Panel 
    ID="Panel1" 
    runat="server">
    <Items>
        <ext:Hidden runat="server" ID="txtID" />
        <ext:FieldContainer runat="server">
            <Items>
                <ext:TextField runat="server" ID="txtTenNganHang" FieldLabel="Tên NH" LabelStyle="font-weight:bold;" MarginSpec="20 0 0 5" Width="440"/>
                <ext:TextField runat="server" ID="txtPhongGD" FieldLabel="Phòng GD" LabelStyle="font-weight:bold;" MarginSpec="20 0 0 5" Width="440"/>
                <ext:TextField runat="server" ID="txtSoTK" FieldLabel="Số TK" LabelStyle="font-weight:bold;" MarginSpec="20 0 0 5" Width="440"/>
                <ext:TextArea runat="server" ID="txtDonViHuong" FieldLabel="Tên ĐV hưởng" LabelStyle="font-weight:bold;" MarginSpec="20 0 0 5" Width="440"/>
            </Items>
        </ext:FieldContainer>
    </Items>
</ext:Panel>