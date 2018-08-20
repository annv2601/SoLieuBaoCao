<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBieuBaoCao.aspx.cs" Inherits="SoLieuBaoCao.BieuBaoCao.frmBieuBaoCao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Resource/CSS/DataView.css" rel="stylesheet" />
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
                                    <span>Mã: {MaBaoCao}</span>
                                </div>
                            </tpl>
                        </html>                   
                    </Tpl>
                <%--<DirectEvents>
                    <ItemDblClick OnEvent="DanhGiaNhanVien_DBClick">
                        <ExtraParams>
                                <ext:Parameter
                                    Name="Values"
                                    Value="#{vNhanVien}.getRowsValues({ selectedOnly : true })"
                                    Mode="Raw"
                                    Encode="true" />
                            </ExtraParams>
                        <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                    </ItemDblClick>
                </DirectEvents>--%>
                </ext:DataView>
    </form>
</body>
</html>
