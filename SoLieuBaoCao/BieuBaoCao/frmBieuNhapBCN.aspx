<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBieuNhapBCN.aspx.cs" Inherits="SoLieuBaoCao.BieuBaoCao.frmBieuNhapBCN" %>

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

        var edit = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                e.record.data.CongSoLieuBCN = e.record.data.SoLieuSTK1 + e.record.data.SoLieuNhap;
                e.record.data.LuyKeBCN = e.record.data.LuyKe + e.record.data.SoLieuSTK1 + e.record.data.SoLieuNhap;
                
                BangNhapBCNX.Edit(e.record.data.IDChiTieu, e.field, e.originalValue, e.value, e.record.data);

                App.grdBieuNhapBCN.getView().refresh();

                var grid = App.grdBieuNhapBCN;
                var pos = grid.getSelectionModel().getCurrentPosition();
                grid.editingPlugin.startEdit(pos.row + 1, pos.column);
            }
        }

        var beforeCellEditHandler = function (e) {
            if (e.record.data.NhapTay == false) {
                CellEditing1.cancelEdit(); 
            }
        }
        
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdBieuNhapBCN" TitleAlign="Center" MinHeight="300" Height="1000">
            <Store>
                <ext:Store runat="server" ID="stoNhapBCN" >
                    <Model>
                        <ext:Model runat="server" IDProperty="IDChiTieu">
                            <Fields>
                                <ext:ModelField Name="MaBieuBaoCao" />
                                <ext:ModelField Name="IDChiTieu" />
                                <ext:ModelField Name="TenChiTieu" />
                                <ext:ModelField Name="MaSoChiTieu" />
                                <ext:ModelField Name="ThuTu" />

                                <ext:ModelField Name="SoLieuSTK1" />
                                <ext:ModelField Name="SoLieuNhap" />
                                <ext:ModelField Name="SoLieuPhanBo" />
                                <ext:ModelField Name="SoLieuThucHien" />
                                <ext:ModelField Name="KeHoachGiao" />
                                <ext:ModelField Name="CongSoLieuBCN" />

                                <ext:ModelField Name="LuyKe" />
                                <ext:ModelField Name="LuyKeBCN" />
                                <ext:ModelField Name="LuyKeThucHien" />

                                <ext:ModelField Name="STTsx" />
                                <ext:ModelField Name="InDam" />
                                <ext:ModelField Name="InNghieng" />                                
                                <ext:ModelField Name="NhapTay" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>
            <TopBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:Button runat="server" ID="btnKhoiTaoLaiBaoCao" Text="Khởi tạo lại" Icon="BookAddressesAdd" Width="150" UI="Primary">
                            <DirectEvents>
                                <Click OnEvent="btnKhoiTaoLaiBaoCao_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>
                        <ext:Button runat="server" ID="btnLayThucHien" Text="Lấy Thực hiện" Icon="BookKey" Width="150" UI="Primary" MarginSpec="0 0 0 10">
                            <DirectEvents>
                                <Click OnEvent="btnLayThucHien_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>

                        <ext:Button runat="server" ID="btnGuiBaoCao" Text="Gửi báo cáo" Icon="TransmitGo" Width="150" UI="Primary" MarginSpec="0 0 0 10">

                        </ext:Button>

                        <ext:ToolbarFill/>

                        <ext:Button runat="server" ID="btnIn" Text="In báo biểu" Icon="Printer" Width="150" UI="Primary">
                            <DirectEvents>
                                <Click OnEvent="btnIn_CLick">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>

                        <ext:Button runat="server" ID="btnXuatExcel" Text="Xuất Excel" Icon="PageExcel" Width="150" UI="Primary" MarginSpec="0 0 0 10">
                            <DirectEvents>
                                <Click OnEvent="btnXuatExcel_Click">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Click>
                            </DirectEvents>
                        </ext:Button>
                    </Items>
                </ext:Toolbar>
            </TopBar>
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Thứ tự" DataIndex="ThuTu" Width="60" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Chỉ tiêu" DataIndex="TenChiTieu" Width="350" StyleSpec="font-weight:bold;">                        
                        <Renderer Fn="change"/>
                    </ext:Column>
                    <ext:Column runat="server" Text="Mã số" DataIndex="MaSoChiTieu" Width="80" Align="Center" StyleSpec="font-weight:bold;">
                        <Renderer Fn="pctChange" />
                    </ext:Column>

                    <ext:NumberColumn runat="server" Text="Kế hoạch" DataIndex="KeHoachGiao" Align="Right" Width="150" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                    <ext:NumberColumn runat="server" Text="Số liệu STK1" DataIndex="SoLieuSTK1" Align="Right" Width="150" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                    <ext:NumberColumn runat="server" Text="Số liệu nhập" DataIndex="SoLieuNhap" Align="Right" Width="150" StyleSpec="font-weight:bold;">
                        <Editor>
                            <ext:NumberField runat="server" AllowDecimals="true" DecimalPrecision="3" />
                        </Editor>
                    </ext:NumberColumn>
                    <ext:NumberColumn runat="server" Text="Cộng BCN" DataIndex="CongSoLieuBCN" Align="Right" Width="150" StyleSpec="font-weight:bold;"></ext:NumberColumn>

                    <ext:NumberColumn runat="server" Text="Lũy kế BCN" DataIndex="LuyKeBCN" Align="Right" Width="180" StyleSpec="font-weight:bold;"></ext:NumberColumn>
                    <ext:NumberColumn runat="server" Text="Lũy kế Thực hiện" DataIndex="LuyKeThucHien" Align="Right" Width="180" StyleSpec="font-weight:bold;"></ext:NumberColumn>

                    <%--<ext:CheckColumn runat="server" Text="Nhập tay" DataIndex="NhapTay" StyleSpec="font-weight:bold;">                        
                    </ext:CheckColumn>                    --%>
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
                        <BeforeEdit Handler="return beforeCellEditHandler(e);"></BeforeEdit>
                        <Edit Fn="edit" />
                    </Listeners>
                </ext:CellEditing>
            </Plugins>
            <DirectEvents>
                <ItemDblClick OnEvent="grdBieuNhapBCN_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesCTSTK" Value="Ext.encode(#{grdBieuNhapBCN}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
