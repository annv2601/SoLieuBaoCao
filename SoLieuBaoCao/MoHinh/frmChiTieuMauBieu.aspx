<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmChiTieuMauBieu.aspx.cs" Inherits="SoLieuBaoCao.MoHinh.frmChiTieuMauBieu" %>
<%@ Register src="~/MoHinh/ucChiTieuMauBieu.ascx" tagname="ChiTieuMB" tagprefix="uc" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Resource/CSS/main.css" />
    
    <script type="text/javascript">
        var template = 'color:{0};';

        var change = function (value, meta) {
            meta.style = Ext.String.format(template, (value !="") ? "green" : "red");
            return "<b>"+value+"</b>";
        };

        var pctChange = function (value, meta) {
            meta.style = Ext.String.format(template, (value !="") ? "red" : "green");
            return value ;
        };

        var edit = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangChiTieuMBX.Edit(e.record.data.IDChiTieu, e.field, e.originalValue, e.value, e.record.data);
            }
        }
        
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="Triton" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdChiTieuMB" TitleAlign="Center" MinHeight="300" Height="1000">
            <Store>
                <ext:Store runat="server" ID="stoChiTieuMB" OnReadData="DanhSachChiTieuMauBieuTD">
                    <Model>
                        <ext:Model runat="server" IDProperty="IDChiTieu">
                            <Fields>
                                <ext:ModelField Name="IDMauBieu" />
                                <ext:ModelField Name="IDChiTieu" />
                                <ext:ModelField Name="TenChiTieu" />
                                <ext:ModelField Name="Ma" />
                                <ext:ModelField Name="ThuTu" />
                                <ext:ModelField Name="InDam" />
                                <ext:ModelField Name="InNghieng" />
                                <ext:ModelField Name="STTsx" />
                                <ext:ModelField Name="NhapTay" />
                                <ext:ModelField Name="NgayTao" />
                                <ext:ModelField Name="NguoiTao" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:ComboBox ID="cboBieuBaoCao"
                            runat="server"
                            FieldLabel="Mẫu Biểu"
                            DisplayField="Ten"
                            ValueField="ID"
                            Width="320" QueryMode="Local"
                            TypeAhead="true" MarginSpec="0 0 0 10" LabelWidth="70" LabelStyle="font-weight:bold;">
                            <Listeners>
                                <Select Handler="#{stoChiTieuMB}.reload();" />
                            </Listeners>
                            <Store>
                                <ext:Store runat="server" ID="stoMauBieu" AutoDataBind="true">
                                    <Model>
                                        <ext:Model runat="server">
                                            <Fields>
                                                <ext:ModelField Name="ID" />
                                                <ext:ModelField Name="Ten" />
                                            </Fields>
                                        </ext:Model>
                                    </Model>
                                </ext:Store>
                            </Store>
                        </ext:ComboBox>
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Thứ tự" DataIndex="ThuTu" Width="80" Align="Center" StyleSpec="font-weight:bold;">
                        <Editor>
                            <ext:TextField runat="server" Width="80" />
                        </Editor>
                    </ext:Column>
                    <ext:Column runat="server" Text="Chỉ tiêu" DataIndex="TenChiTieu" Width="350" StyleSpec="font-weight:bold;">                        
                        <Renderer Fn="change"/>
                    </ext:Column>
                    <ext:Column runat="server" Text="Mã số" DataIndex="Ma" Width="80" Align="Center" StyleSpec="font-weight:bold;">
                        <Renderer Fn="pctChange" />
                    </ext:Column>
                    <ext:CheckColumn runat="server" Text="In đậm" DataIndex="InDam" Editable="true" StyleSpec="font-weight:bold;">                        
                    </ext:CheckColumn>
                    <ext:CheckColumn runat="server" Text="In nghiêng" DataIndex="InNghieng" Editable="true" StyleSpec="font-weight:bold;">                        
                    </ext:CheckColumn>
                    <ext:NumberColumn runat="server" Text="STT sx" DataIndex="STTsx" Align="Center" StyleSpec="font-weight:bold;">
                        <Editor>
                            <ext:NumberField runat="server" AllowDecimals="true" DecimalPrecision="3" />
                        </Editor>
                    </ext:NumberColumn>
                    <ext:CheckColumn runat="server" Text="Nhập tay" DataIndex="NhapTay" Editable="true" StyleSpec="font-weight:bold;">                        
                    </ext:CheckColumn>
                    <ext:DateColumn runat="server" Text="Ngày nhập" DataIndex="NgayTao" Format="dd/MM/yyyy HH:mm:ss" Width="150" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Người nhập" DataIndex="NguoiTao" Width="150" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="" DataIndex="" Width="250" />
                </Columns>
            </ColumnModel>
            <SelectionModel>
                <ext:CellSelectionModel runat="server" >                    
                </ext:CellSelectionModel>                
            </SelectionModel>
            <Plugins>
                <ext:FilterHeader runat="server" OnCreateFilterableField="OnCreateFilterableField" />
                <ext:CellEditing runat="server" ClicksToEdit="1">
                    <Listeners>
                        <Edit Fn="edit" />
                    </Listeners>
                </ext:CellEditing>
            </Plugins>
            <DirectEvents>
                <ItemDblClick OnEvent="grdChiTieuMB_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesCT" Value="Ext.encode(#{grdChiTieuMB}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>

        <ext:Window runat="server" ID="wChiTieuMauBieu" Icon="Table" Title="Chỉ tiêu mẫu biểu báo cáo nhanh" TitleAlign="Center"
            ButtonAlign="Center" Width="700" Height="650" AutoScroll="true" Hidden="true">
            <Items>
                <ext:Panel runat="server" Header="false" Layout="FitLayout" Closable="false">
                    <Content>
                        <uc:ChiTieuMB ID="ucChiTieuMB1" runat="server" Title="" />
                    </Content>
                </ext:Panel>
            </Items>
            <Buttons>
                <ext:Button runat="server" Text="Đóng" Icon="Cross">
                    <Listeners>
                        <Click Handler="#{wChiTieuMauBieu}.hide()" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
    </form>
</body>
</html>
