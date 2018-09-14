<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMauBieuBaoCao.aspx.cs" Inherits="SoLieuBaoCao.MoHinh.frmMauBieuBaoCao" %>
<%@ Register src="~/MoHinh/ucMauBieuBaoCao.ascx" tagname="MauBieu" tagprefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Resource/CSS/main.css" />
    <script type="text/javascript">
        var template = 'color:{0};';

        var change = function (value, meta) {            
            return "<b>"+value+"</b>";
        };
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" />
    <form id="form1" runat="server">        
        <ext:GridPanel runat="server" ID="grdMauBieu" TitleAlign="Center" MinHeight="300" Height="800">
            <Store>
                <ext:Store runat="server" ID="stoMauBieu">
                    <Model>
                        <ext:Model runat="server" IDProperty="ID">
                            <Fields>
                                <ext:ModelField Name="ID" />
                                <ext:ModelField Name="Ten" />
                                <ext:ModelField Name="TenTat" />
                                <ext:ModelField Name="Ma" />
                                <ext:ModelField Name="TieuDe1" />
                                <ext:ModelField Name="TieuDe2" />
                                <ext:ModelField Name="TieuDe3" />
                                <ext:ModelField Name="Muc" />
                                <ext:ModelField Name="Cap" />
                                <ext:ModelField Name="GhiChu" />
                                <ext:ModelField Name="NgayApDung" />
                                <ext:ModelField Name="NgayKetThuc" />
                                <ext:ModelField Name="NgayTao" />
                                <ext:ModelField Name="NguoiTao" />
                                <ext:ModelField Name="Nhom" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button runat="server" ID="txtThemMauBieuMoi" Text="Thêm Mẫu biểu" Icon="Add" ToolTip="Thêm 1 mẫu biểu báo cáo mới" UI="Default">
                            <DirectEvents>
                                <Click OnEvent="txtThemMauBieuMoi_Click" />
                            </DirectEvents>
                        </ext:Button>
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã" DataIndex="Ma" Width="80" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Tên" DataIndex="Ten" Width="250" StyleSpec="font-weight:bold;">                        
                        <Renderer Fn="change"/>
                    </ext:Column>
                    <ext:Column runat="server" Text="Mức" DataIndex="Muc" Width="80" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Cấp" DataIndex="Cap" Width="80" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:DateColumn runat="server" Text="Ngày áp dụng" DataIndex="NgayApDung" Format="dd/MM/yyyy" Width="120" StyleSpec="font-weight:bold;"/>
                    <ext:DateColumn runat="server" Text="Ngày kết thúc" DataIndex="NgayKetThuc" Format="dd/MM/yyyy" Width="120" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Nhóm" DataIndex="Nhom" Width="80" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Tên tắt" DataIndex="TenTat" Width="100" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Tiêu đề 1" DataIndex="TieuDe1" Width="200" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Tiêu đề 2" DataIndex="TieuDe2" Width="200" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Tiêu đề 3" DataIndex="TieuDe3" Width="200" Align="Center" StyleSpec="font-weight:bold;"/>
                    
                    <ext:Column runat="server" Text="Ghi chú" DataIndex="GhiChu" Width="250" StyleSpec="font-weight:bold;"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
                <ext:RowSelectionModel runat="server" />                
            </SelectionModel>
            <DirectEvents>
                <ItemDblClick OnEvent="grdMauBieu_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesMB" Value="Ext.encode(#{grdMauBieu}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>

        <ext:Window runat="server" ID="wMauBieu" Icon="Table" Title="Mẫu biểu Báo cáo" TitleAlign="Center"
            ButtonAlign="Center" Width="520" Height="650" AutoScroll="true" Hidden="true">
            <Items>
                <ext:Panel runat="server" Header="false" Layout="FitLayout" Closable="false">
                    <Content>
                        <uc:MauBieu ID="ucMauBieu1" runat="server" Title="" />
                    </Content>
                </ext:Panel>
            </Items>
            <Buttons>
                <ext:Button runat="server" Text="Cập nhật" Icon="Accept" ID="btnCapNhat" Width="120">
                    <DirectEvents>
                        <Click OnEvent="btnCapNhat_Click" />
                    </DirectEvents>
                </ext:Button>
                <ext:Button runat="server" Text="Đóng" Icon="Cross" Width="120">
                    <Listeners>
                        <Click Handler="#{wMauBieu}.hide()" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
    </form>
</body>
</html>
