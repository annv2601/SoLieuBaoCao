<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmChiTietSoNhatKy.aspx.cs" Inherits="SoLieuBaoCao.SoNhatKyChung.frmChiTietSoNhatKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Resource/CSS/main.css" rel="stylesheet" />

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

        .my-grid .x-grid3-row {        
            border:medium;
            }
    
        .my-grid .x-grid3-row-last {
                border:medium;
            }
    </style>
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
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="Neptune"/>
    <form id="form1" runat="server">
        <ext:Hidden runat="server" ID="txtThang"/>
        <ext:Hidden runat="server" ID="txtNam"/>
        <ext:Hidden runat="server" ID="txtMaDonVi"/>
        <ext:Hidden runat="server" ID="txtNoiDung"/>
        <ext:Hidden runat="server" ID="txtNgayHT"/>
        <ext:Hidden runat="server" ID="txtTaiKhoan"/>
        <ext:Hidden runat="server" ID="txtNoCo"/>

        <ext:GridPanel runat="server" ID="grdSoNhatKyChungCT" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="10 0 0 0">
            <Store>
                <ext:Store runat="server" ID="stoSoNhatKyChungCT" >
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="NGAY_HT" />
                                <ext:ModelField Name="SO_CT" />
                                <ext:ModelField Name="NGAY_CT" />
                                <ext:ModelField Name="ND" />

                                <ext:ModelField Name="TK_NO" />
                                <ext:ModelField Name="TKE_NO" />
                                <ext:ModelField Name="DTU_NO" />
                                <ext:ModelField Name="SP_NO" />

                                <ext:ModelField Name="TK_CO" />
                                <ext:ModelField Name="TKE_CO" />
                                <ext:ModelField Name="DTU_CO" />
                                <ext:ModelField Name="SP_CO" />

                                <ext:ModelField Name="TIEN_NO" />
                                <ext:ModelField Name="TIEN_CO" />

                                <ext:ModelField Name="NOTE" />
                                <ext:ModelField Name="MaDonVi" />
                                <ext:ModelField Name="MaNSD" />
                                <ext:ModelField Name="NgayHeThong" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>            
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Ngày hạch toán" DataIndex="NGAY_HT" Width="120" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Chứng từ">
                        <Columns>
                            <ext:Column runat="server" Text="Số" DataIndex="SO_CT" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Ngày" DataIndex="NGAY_CT" Width="120" Align="Center" StyleSpec="font-weight:bold;"/>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Nội dung" DataIndex="ND" Width="380" Align="Left" StyleSpec="font-weight:bold;">
                        <Renderer Fn="change"/>
                    </ext:Column>

                    <ext:Column runat="server" Text="TK Nợ">
                        <Columns>
                            <ext:Column runat="server" Text="Số hiệu TK" DataIndex="TK_NO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Mã thống kê" DataIndex="TKE_NO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Mã đối tượng" DataIndex="DTU_NO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Mã sản phẩm" DataIndex="SP_NO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="TK Có">
                        <Columns>
                            <ext:Column runat="server" Text="Số hiệu TK" DataIndex="TK_CO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Mã thống kê" DataIndex="TKE_CO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Mã đối tượng" DataIndex="DTU_CO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                            <ext:Column runat="server" Text="Mã sản phẩm" DataIndex="SP_CO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Số Phát sinh">
                        <Columns>
                            <ext:SummaryColumn runat="server" Text="Nợ" DataIndex="TIEN_NO" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                            <ext:SummaryColumn runat="server" Text="Có" DataIndex="TIEN_CO" SummaryType="Sum" Width="160" Align="Right" StyleSpec="font-weight:bold;">
                                <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                                <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                            </ext:SummaryColumn>
                        </Columns>
                    </ext:Column>

                    <ext:Column runat="server" Text="Mã ĐV" DataIndex="MaDonVi" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Mã NSD" DataIndex="MaNSD" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="Ghi chú" DataIndex="NOTE" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:DateColumn runat="server" Text="Ngày số liệu" DataIndex="NgayHeThong" Width="150" Align="Center" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy HH:mm:ss"/>
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:RowSelectionModel Mode="Multi" runat="server" />
            </SelectionModel>
            <Features>
                <ext:Summary runat="server"/>
            </Features>
        </ext:GridPanel>
    </form>
</body>
</html>

