<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDoanhThuKhachHang.aspx.cs" Inherits="SoLieuBaoCao.DoanhThuKhachHang.frmDoanhThuKhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            font-weight: bold;
            font-size: 11px;
            background-color : #f1f2f4;
        }

        .total-field{
            background-color : #fff;
            padding          : 0px 1px 1px 1px;
            margin-right     : 1px;
            position: absolute;
        }

        .total-field .x-form-display-field{
            font-weight      : bold !important;
            border           : solid 1px silver;
            font-size        : 11px;
            font-family      : tahoma, arial, verdana, sans-serif;
            color            : #000;
            padding          : 0px 0px 0px 5px;
            height           : 22px;
            margin-top       : 0px;
            padding-top      : 3px;
        }
    </style>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grDoanhThu" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items> 
                       <ext:DateField runat="server" ID="txtTuNgay" FieldLabel="Từ ngày" LabelStyle="font-weight:bold;" LabelWidth="100" Width="240" Format="dd/MM/yyyy"/>
                       <ext:DateField runat="server" ID="txtDenNgay" FieldLabel="Đến ngày" LabelStyle="font-weight:bold;" LabelWidth="100" Width="240" MarginSpec="0 0 0 20" Format="dd/MM/yyyy"/>
                       <ext:TextField runat="server" ID="txtMaDonVi" FieldLabel="Mã đơn vị" Width="200" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20"/>

                       <ext:Button runat="server" ID="btnHienThi" Text="Hiển thị" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnHienThi_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>
                       
                       <ext:Button runat="server" ID="btnXuatExcel" Text="Xuất Excel" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnXuatExcel_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>

                       <ext:Button runat="server" ID="btnTongHop" Text="Tổng hợp" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTongHop_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>

                       <ext:Button runat="server" ID="btnTheoDoiDonViCot" Text="Tình hình Ngày" MarginSpec="0 0 0 20" ToggleGroup="NopTien">
                           <DirectEvents>
                               <Click OnEvent="btnTheoDoiDonViCot_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoKhachHang" >
                    <Model>
                        <ext:Model runat="server" IDProperty="ID">
                            <Fields>
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="MaCRM" />
                                <ext:ModelField Name="Nhom" />
                                <ext:ModelField Name="TenNhom" />
                                <ext:ModelField Name="TenKhachHang" />

                                <ext:ModelField Name="Tong_SL" />
                                <ext:ModelField Name="Tong_KL" />
                                <ext:ModelField Name="Tong_DT" />
                                <ext:ModelField Name="EMS_TNuoc_SL" />
                                <ext:ModelField Name="EMS_TNuoc_KL" />
                                <ext:ModelField Name="EMS_TNuoc_DT" />
                                <ext:ModelField Name="EMS_QTe_SL" />
                                <ext:ModelField Name="EMS_QTe_KL" />
                                <ext:ModelField Name="EMS_QTe_DT" />
                                <ext:ModelField Name="EMS_COD_SL" />
                                <ext:ModelField Name="EMS_COD_KL" />
                                <ext:ModelField Name="EMS_COD_DT" />
                                <ext:ModelField Name="EMS_HCC_SL" />
                                <ext:ModelField Name="EMS_HCC_KL" />
                                <ext:ModelField Name="EMS_HCC_DT" />
                                <ext:ModelField Name="BK_TNuoc_SL" />
                                <ext:ModelField Name="BK_TNuoc_KL" />
                                <ext:ModelField Name="BK_TNuoc_DT" />
                                <ext:ModelField Name="BK_QTe_SL" />
                                <ext:ModelField Name="BK_QTe_KL" />
                                <ext:ModelField Name="BK_QTe_DT" />
                                <ext:ModelField Name="BK_COD_SL" />
                                <ext:ModelField Name="BK_COD_KL" />
                                <ext:ModelField Name="BK_COD_DT" />
                                <ext:ModelField Name="BPBD_TNuoc_SL" />
                                <ext:ModelField Name="BPBD_TNuoc_KL" />
                                <ext:ModelField Name="BPBD_TNuoc_DT" />
                                <ext:ModelField Name="BPBD_QTe_SL" />
                                <ext:ModelField Name="BPBD_QTe_KL" />
                                <ext:ModelField Name="BPBD_QTe_DT" />
                                <ext:ModelField Name="Logis_TNuoc_SL" />
                                <ext:ModelField Name="Logis_TNuoc_KL" />
                                <ext:ModelField Name="Logis_TNuoc_DT" />
                                <ext:ModelField Name="Logis_COD_SL" />
                                <ext:ModelField Name="Logis_COD_KL" />
                                <ext:ModelField Name="Logis_COD_DT" />
                                <ext:ModelField Name="KT1_SL" />
                                <ext:ModelField Name="KT1_KL" />
                                <ext:ModelField Name="KT1_DT" />
                                <ext:ModelField Name="ePacket_SL" />
                                <ext:ModelField Name="ePacket_KL" />
                                <ext:ModelField Name="ePacket_DT" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã Bưu cục" DataIndex="MaBuuCuc" Width="120" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Mã KH" DataIndex="MaCRM" Width="200" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Tên KH" DataIndex="TenKhachHang" Width="400" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>

                    <ext:NumberColumn runat="server" Text="Sản lượng" DataIndex="Tong_SL" Align="Right" StyleSpec="font-weight:bold;" Width="200" Format="###,###,###"/>
                    <ext:NumberColumn runat="server" Text="Khối lượng" DataIndex="Tong_KL" Align="Right" StyleSpec="font-weight:bold;" Width="240" Format="###,###,###"/>
                    <ext:NumberColumn runat="server" Text="Doanh thu" DataIndex="Tong_DT" Align="Right" StyleSpec="font-weight:bold;" Width="300" Format="###,###,###,###,###"/>

                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:CellSelectionModel runat="server" />
            </SelectionModel>
             <Plugins>
                <ext:FilterHeader runat="server" OnCreateFilterableField="OnCreateFilterableField" />
            </Plugins>
        </ext:GridPanel>
    </form>
</body>
</html>
