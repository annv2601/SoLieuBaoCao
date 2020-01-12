<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAnhBanKy.ascx.cs" Inherits="SoLieuBaoCao.GiayDeNghiTiepQuy.ucAnhBanKy" %>
<ext:FieldContainer runat="server">    
    <Items>
        <ext:Hidden runat="server" ID="txtMaKeToan" />
        <ext:FileUploadField runat="server" ID="btnFileAnh" Icon="ImageLink" ButtonText="File ảnh bản ký..." Width="150" Height="25" MarginSpec="10 0 0 0" ButtonOnly="true">
                                        <DirectEvents>
                                            <Change OnEvent="btnFileAnh_Click">
                                                <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                            </Change>
                                        </DirectEvents>
                                    </ext:FileUploadField>
    </Items>
</ext:FieldContainer>

<ext:Image runat="server" ID="imgBanKy" Width="800" Height="1000" MarginSpec="10 0 0 0"/>
