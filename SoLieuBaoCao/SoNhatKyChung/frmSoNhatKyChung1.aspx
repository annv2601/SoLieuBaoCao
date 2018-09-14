<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSoNhatKyChung1.aspx.cs" Inherits="SoLieuBaoCao.SoNhatKyChung.frmSoNhatKyChung1" %>

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
                <ext:SelectBox runat="server" ID="slbThang" DisplayField="Ten" ValueField="ID" FieldLabel="Tháng" LabelStyle="font-weight:bold;" LabelWidth="60" Width="200">
                    <Store>
                        <ext:Store runat="server" ID="stoThang">
                            <Fields>
                                <ext:ModelField Name="ID" />
                                <ext:ModelField Name="Ten" />
                            </Fields>
                        </ext:Store>
                    </Store>
                </ext:SelectBox>
                <ext:SelectBox runat="server" ID="slbNam" DisplayField="Ten" ValueField="ID" FieldLabel="Năm" LabelStyle="font-weight:bold;" LabelWidth="50" Width="200" MarginSpec="0 0 0 20">
                    <Store>
                        <ext:Store runat="server" ID="stoNam">
                            <Fields>
                                <ext:ModelField Name="ID" />
                                <ext:ModelField Name="Ten" />
                            </Fields>
                        </ext:Store>
                    </Store>
                </ext:SelectBox>
                <ext:TextField runat="server" ID="txtMaDonVi" FieldLabel="Mã đơn vị" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" />
                <ext:Button runat="server" ID="btnHienThi" Text="Hiển thị" Icon="Zoom" Width="120" MarginSpec="0 0 0 20">
                    <DirectEvents>
                        <Click OnEvent="btnHienThi_Click">
                            <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                        </Click>
                    </DirectEvents>
                </ext:Button>

                <ext:RadioGroup ID="chkNoCo"
                            runat="server"
                            Layout="AnchorLayout" MarginSpec="0 0 0 30"
                            >
                            <Defaults>
                                <ext:Parameter Name="name" Value="ccType" />
                                <ext:Parameter Name="style" Value="margin-right:15px;" />
                            </Defaults>
                            <Items>
                                <ext:Radio
                                    runat="server" ID="chkNo"
                                    InputValue="TKNo"
                                    BoxLabel="Nợ"
                                     />
                                <ext:Radio
                                    runat="server" ID="chkCo"
                                    InputValue="TKCo"
                                    BoxLabel="Có" />
                            </Items>
                            <DirectEvents>
                                <Change OnEvent="chkNoCo_Change">
                                    <EventMask ShowMask="true" Msg="Đang thực hiện ....." />
                                </Change>
                            </DirectEvents>
                        </ext:RadioGroup>
            </Items>
        </ext:FieldContainer>
        <ext:GridPanel runat="server" ID="grdSoNhatKyChung" TitleAlign="Center" MinHeight="300" Height="1000" MarginSpec="20 0 0 0">
            <Store>
                <ext:Store runat="server" ID="stoSoNhatKyChung" >
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="NGAY_HT" />
                                <ext:ModelField Name="NGAY_CT" />
                                <ext:ModelField Name="ND" />

                                <ext:ModelField Name="TK_NO" />
                                <ext:ModelField Name="TK_CO" />

                                <ext:ModelField Name="TIEN_NO" />
                                <ext:ModelField Name="TIEN_CO" />

                                <ext:ModelField Name="MaDonVi" />
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
                    <ext:Column runat="server" Text="Ngày Chứng từ" DataIndex="NGAY_CT" Width="120" Align="Center" StyleSpec="font-weight:bold;">
                    </ext:Column>
                    <ext:Column runat="server" Text="Nội dung" DataIndex="ND" Width="380" Align="Left" StyleSpec="font-weight:bold;">
                        <Renderer Fn="change"/>
                    </ext:Column>

                    <ext:Column runat="server" Text="TK Nợ" DataIndex="TK_NO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
                    <ext:Column runat="server" Text="TK Có" DataIndex="TK_CO" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>

                    <ext:SummaryColumn runat="server" Text="Tiền Nợ" DataIndex="TIEN_NO" SummaryType="Sum" Width="200" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>
                    <ext:SummaryColumn runat="server" Text="Tiền Có" DataIndex="TIEN_CO" SummaryType="Sum" Width="200" Align="Right" StyleSpec="font-weight:bold;">
                        <Renderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                        <SummaryRenderer Fn="Ext.util.Format.numberRenderer('0,000')" />
                    </ext:SummaryColumn>

                    <ext:Column runat="server" Text="Mã ĐV" DataIndex="MaDonVi" Width="100" Align="Center" StyleSpec="font-weight:bold;"/>
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
            <DirectEvents>
                <ItemDblClick OnEvent="grdSoNhatKyChung_ClickDup">
                    <ExtraParams>
                        <ext:Parameter Name="ValuesSNKC" Value="Ext.encode(#{grdSoNhatKyChung}.getRowsValues({selectedOnly:true}))" Mode="Raw" />
                    </ExtraParams>
                </ItemDblClick>
            </DirectEvents>
        </ext:GridPanel>
    </form>
</body>
</html>
