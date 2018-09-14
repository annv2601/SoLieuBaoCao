<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBieuBaoCao.aspx.cs" Inherits="SoLieuBaoCao.BieuBaoCao.frmBieuBaoCao" %>
<%@ Register src="~/BieuBaoCao/ucBieuBaoCao.ascx" tagname="BieuBC" tagprefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Resource/CSS/DataView.css" rel="stylesheet" />
    <script type="text/javascript">
        var DinhDangSo = function (value) {
            
            return "<b>"+value+"</b>";
        };
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" />
    <form id="form1" runat="server">
        <ext:DataView  runat="server" ID="vBieuBaoCao" 
                    MultiSelect="false" DeferInitialRefresh="false"
                    OverItemCls="x-view-over"
                    TrackOver="true"
                    Cls="img-chooser-view"
                    ItemSelector="div.thumb-wrap"
                    EmptyText="" MarginSpec="20 0 0 0">
                    <Store>
                        <ext:Store ID="stoBieuBaoCao" runat="server" PageSize="30">
                            <Model>
                                <ext:Model runat="server">
                                    <Fields>
                                        <ext:ModelField Name="STT" />
                                        <ext:ModelField Name="MaBaoCao" />
                                        <ext:ModelField Name="Thang" />
                                        <ext:ModelField Name="Nam" />
                                        <ext:ModelField Name="DonVi" />
                                        <ext:ModelField Name="NoiDung" />
                                        <ext:ModelField Name="IDBieuDinhNghia" />
                                        <ext:ModelField Name="TenBieuBaoCao" />
                                        <ext:ModelField Name="TongDoanhThu" />
                                        <ext:ModelField Name="TongChiPhi" />
                                        <ext:ModelField Name="TrangThai" />
                                        <ext:ModelField Name="NgayTrangThai" />
                                        <ext:ModelField Name="urlAnh" />
                                    </Fields>
                                </ext:Model>
                            </Model>
                        </ext:Store>
                    </Store>
                    <Tpl runat="server">
                        <Html>
                            <tpl for=".">
                                <div class="thumb-wrap" id="{STT}">
                                    <div class="thumb"><img src="{urlAnh}" title="{TenBieuBaoCao}"></div>
                                    <strong>{TenBieuBaoCao}</strong>
                                    <strong>Tháng: {Thang}  Năm: {Nam}</strong>
                                    <span>Mã: {MaBaoCao}</span>
                                    <strong>DT: {TongDoanhThu}</strong>
                                    <strong>CP: {TongChiPhi}</strong>
                                </div>
                            </tpl>
                        </html>                   
                    </Tpl>
                <DirectEvents>
                    <ItemDblClick OnEvent="BieuBaoCao_DBClick">
                        <ExtraParams>
                                <ext:Parameter
                                    Name="Values"
                                    Value="#{vBieuBaoCao}.getRowsValues({ selectedOnly : true })"
                                    Mode="Raw"
                                    Encode="true" />
                            </ExtraParams>
                        <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                    </ItemDblClick>
                </DirectEvents>
                </ext:DataView>

        <ext:Window runat="server" ID="wTaoBieuBaoCao" Icon="BookAdd" Title="Khởi tạo Biểu báo cáo" TitleAlign="Center"
            ButtonAlign="Center" Width="400" Height="250" AutoScroll="true" Hidden="true">
            <Items>
                <ext:Panel runat="server" Header="false" Layout="FitLayout" Closable="false">
                    <Content>
                        <uc:BieuBC ID="ucBieuBC1" runat="server" Title="" />
                    </Content>
                </ext:Panel>
            </Items>
            <Buttons>
                <ext:Button runat="server" ID="btnTaoBaoCao" Text="Tạo Báo cáo" Icon="Add" Width="120">
                    <DirectEvents>
                        <Click OnEvent="btnTaoBaoCao_Click">
                            <EventMask ShowMask="true" Msg="Đang khởi tạo ....." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button runat="server" Text="Đóng" Icon="Cross" Width="120">
                    <Listeners>
                        <Click Handler="#{wTaoBieuBaoCao}.hide()" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
    </form>
</body>
</html>
