<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTheoDoiQuyKet.aspx.cs" Inherits="SoLieuBaoCao.QuyKet.frmTheoDoiQuyKet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        
    </script>
    <style>
        .x-grid-body .x-grid-cell-Cost {
            background-color : #f1f2f4;
        }

        .x-grid-row-summary .x-grid-cell-Cost .x-grid-cell-inner{
            background-color : #e1e2e4;
        }

        .task .x-grid-cell-inner {
            padding-left: 15px;
        }

        .x-grid-row-summary .x-grid-cell-inner {
            font-weight      : bold;
            font-size        : 15px;
            background-color : #f1f2f4;            
        }
    </style>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:Hidden runat="server" ID="txtNoCo" />
        <ext:FieldContainer runat="server" Layout="HBoxLayout" MarginSpec="10 0 0 0">
            <Items>
                <ext:DateField runat="server" ID="txtTuNgay" Format="dd/MM/yyyy" FieldLabel="Từ ngày" LabelWidth="80" LabelStyle="font-weight:bold;">
                    <Listeners>
                        <Change Handler="#{stoQuyKet}.reload()" />
                    </Listeners>
                </ext:DateField>
                <ext:DateField runat="server" ID="txtDenNgay" Format="dd/MM/yyyy" FieldLabel="Đến ngày" LabelWidth="80" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20">
                    <Listeners>
                        <Change Handler="#{stoQuyKet}.reload()" />
                    </Listeners>
                </ext:DateField>
                <ext:Button runat="server" ID="btnTongHop" Text="Tổng hợp" Icon="Sum" Width="120" MarginSpec="0 0 0 40">
                    <DirectEvents>
                        <Click OnEvent="btnTongHop_Click">
                            <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
            </Items>
        </ext:FieldContainer>
        <ext:GridPanel runat="server" ID="grdQuyKet" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="20 0 0 0">
            <Store>
                <ext:Store runat="server" ID="stoQuyKet" OnReadData="DanhSachTheoDoi">
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="DonVi" />
                                <ext:ModelField Name="TenBuuCuc" />
                                <ext:ModelField Name="TenGop" />

                                <ext:ModelField Name="Ngay" />
                                <ext:ModelField Name="DuDau" />

                                <ext:ModelField Name="NhanTiepQuy" />
                                <ext:ModelField Name="PSCo" />

                                <ext:ModelField Name="PSCoNhap" />
                                <ext:ModelField Name="PSNo" />
                                <ext:ModelField Name="PSNoNhap" />
                                <ext:ModelField Name="NopTienMat" />
                                <ext:ModelField Name="NopTienChuyenKhoan" />
                                <ext:ModelField Name="DuCuoi" />
                                <ext:ModelField Name="NgayHeThong" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="40" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã Bưu cục" DataIndex="MaBuuCuc" Width="80" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Đơn vị" DataIndex="DonVi" Width="200" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Bưu cục" DataIndex="TenBuuCuc" Width="180" Align="Left" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Format="dd/MM/yyyy" StyleSpec="font-weight:bold;"/>

                    <ext:NumberColumn runat="server" Text="Dư đầu" DataIndex="DuDau" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:NumberColumn runat="server" Text="Tiếp quỹ" DataIndex="NhanTiepQuyNhanTiepQuy" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:NumberColumn runat="server" Text="PS có" DataIndex="PSCo" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:NumberColumn runat="server" Text="PS nợ" DataIndex="PSNo" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:NumberColumn runat="server" Text="Nộp tiền mặt" DataIndex="NopTienMat" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:NumberColumn runat="server" Text="Nộp tiền NH" DataIndex="NopTienChuyenKhoan" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>
                    <ext:NumberColumn runat="server" Text="Dư cuối" DataIndex="DuCuoi" Width="120" Align="Left" StyleSpec="font-weight:bold;"/>

                    <ext:DateColumn runat="server" Text="" DataIndex="NgayHeThong" Format="dd/MM/yyyy HH:mm:ss"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:RowSelectionModel Mode="Multi" runat="server" />
            </SelectionModel>
            <Plugins>
                <ext:FilterHeader runat="server" OnCreateFilterableField="OnCreateFilterableField" />                
            </Plugins>
            <Features>
                <ext:Summary runat="server"/>
            </Features>
            <%--<DirectEvents>
                <ItemDblClick OnEvent="grdSoNhatKyChung_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesSNKC" Value="Ext.encode(#{grdSoNhatKyChung}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>--%>
        </ext:GridPanel>
    </form>
</body>
</html>
