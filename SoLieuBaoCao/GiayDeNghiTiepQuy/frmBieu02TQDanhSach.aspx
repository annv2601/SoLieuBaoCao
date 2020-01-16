<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmBieu02TQDanhSach.aspx.cs" Inherits="SoLieuBaoCao.GiayDeNghiTiepQuy.frmBieu02TQDanhSach" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resource/CSS/DataGrid.css" rel="stylesheet" />
    <style>
        .x-grid-body .x-grid-cell-Cost {
            background-color : #f1f2f4;
        }

        .x-grid-row-summary .x-grid-cell-Cost .x-grid-cell-inner{
            background-color : #e1e2e4;
        }

        .task .x-grid-cell-inner {
            padding-left: 10px;
        }

        .x-grid-row-summary .x-grid-cell-inner {
            font-weight: bold;
            font-size: 13px;
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
     <script type="text/javascript">
         var template = '<span style="color:{0};">{1}</span>';

        var mauDuCuoi = function (value) {
            return Ext.String.format(template, (value > 0) ? "orange" : "red", value);
        };

        var mauDuKienChi = function (value) {
            return Ext.String.format(template, (value > 0) ? "green" : "red", value);
         };


     </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:Hidden runat="server" ID="txtNgayThang" />
        <%--<ext:Menu runat="server" ID="mnuGDN">
            <Items>
                <ext:MenuItem runat="server" ID="mnuitemAnhBK" Text="Chụp ảnh bản ký" Icon="ImageAdd">
                    <DirectEvents>
                        <Click OnEvent="mnuitemAnhBK_Click">
                            <ExtraParams>
                                <ext:Parameter Name="ValuesGDN" Value="Ext.encode(#{grdGDNTQuy}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                            </ExtraParams>
                        </Click>
                    </DirectEvents>
                </ext:MenuItem>
            </Items>
        </ext:Menu>--%>
        <ext:GridPanel runat="server" ID="grdB02" TitleAlign="Center" MinHeight="300" Height="800" MarginSpec="0 0 0 0">   
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items>
                       <ext:DateField runat="server" ID="txtNgayTongHop" FieldLabel="Ngày" LabelWidth="60" Width="220">
                           <Listeners>
                               <Select Handler="#{stoB02}.reload();" />
                           </Listeners>
                       </ext:DateField>
                       <ext:Button runat="server" ID="btnTongHop" Text="Lập Đề nghị" MarginSpec="0 0 0 20" UI="Success" Width="160">
                           <DirectEvents>
                               <Click OnEvent="btnTongHop_Click">
                                   <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                               </Click>
                           </DirectEvents>
                       </ext:Button>

                      <ext:Button runat="server" ID="btnInAn" Text="In ấn" MarginSpec="0 0 0 20" UI="Info" Icon="Printer" Width="160">
                           <DirectEvents>
                               <Click OnEvent="btnInAn_Click" />
                           </DirectEvents>
                       </ext:Button>
                       <ext:Button runat="server" ID="btnXuatExcel" Text="Xuất Excel" MarginSpec="0 0 0 20" UI="Primary" Icon="PageExcel" Width="160">
                           <DirectEvents>
                               <Click OnEvent="btnXuatExcel_Click" />
                           </DirectEvents>
                       </ext:Button>

                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoB02" OnReadData="DanhSachB02TQ">
                    <Model>
                        <ext:Model runat="server" IDProperty="STTsx">
                            <Fields>
                                <ext:ModelField Name="STTsx" />
                                <ext:ModelField Name="MaDonVi" />
                                <ext:ModelField Name="TenDonVi" />
                                <ext:ModelField Name="TonDauNgay" />
                                <ext:ModelField Name="SoDaThuDichVu" />
                                <ext:ModelField Name="SoDaChiDichVu" />
                                <ext:ModelField Name="VayQuyKhac" />
                                <ext:ModelField Name="QuyKhacVay" />
                                <ext:ModelField Name="SoDaNhanTiepQuy" />
                                <ext:ModelField Name="SoDaNopQuy" />
                                <ext:ModelField Name="SoDuTienCuoiNgay" />
                                <ext:ModelField Name="DuKienCacKhoanChiDichVu" />
                                <ext:ModelField Name="HanMucLuuQuy" />
                                <ext:ModelField Name="SoTiepCanTiepHoacNopQuy" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store> 
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;" />         
                    <ext:Column runat="server" Text="Đơn vị" DataIndex="TenDonVi" Align="Left" Width="240" StyleSpec="font-weight:bold;"/>

                    
                    <ext:SummaryColumn runat="server" Text="Tiền tồn đầu ngày hôm trước" SummaryType="Sum" DataIndex="TonDauNgay" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số đã thu dịch vụ" SummaryType="Sum" DataIndex="SoDaThuDichVu" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số đã chi dịch vụ" SummaryType="Sum" DataIndex="SoDaChiDichVu" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="TCBC vay quỹ khác" SummaryType="Sum" DataIndex="VayQuyKhac" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Quỹ khác vay TCBC" SummaryType="Sum" DataIndex="QuyKhacVay" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số đã nhận tiếp quỹ" SummaryType="Sum" DataIndex="SoDaNhanTiepQuy" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số đã nộp quỹ" SummaryType="Sum" DataIndex="SoDaNopQuy" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số dư tiền cuối ngày hôm trước" SummaryType="Sum" DataIndex="SoDuTienCuoiNgay" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Dự kiến các khoản chi dịch vụ" SummaryType="Sum" DataIndex="DuKienCacKhoanChiDichVu" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Hạn mức lưu quỹ" SummaryType="Sum" DataIndex="HanMucLuuQuy" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Số tiền cần tiếp hoặc nộp quỹ" SummaryType="Sum" DataIndex="SoTiepCanTiepHoacNopQuy" Align="Right" Width="120" StyleSpec="font-weight:bold;">
                             <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                     </ext:SummaryColumn>
                </Columns>
            </ColumnModel>            
            <Features>
                <ext:Summary runat="server"/>
            </Features>
        </ext:GridPanel>

    </form>
</body>
</html>
