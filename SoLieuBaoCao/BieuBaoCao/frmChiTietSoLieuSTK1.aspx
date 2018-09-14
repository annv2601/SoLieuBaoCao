<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmChiTietSoLieuSTK1.aspx.cs" Inherits="SoLieuBaoCao.BieuBaoCao.frmChiTietSoLieuSTK1" %>

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
            font-size        : 11px;
            background-color : #f1f2f4;
        }

        .my-grid .x-grid3-row {        
            border:medium;
            }
    
        .my-grid .x-grid3-row-last {
                border:medium;
            }
    </style>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="Neptune"/>
    <form id="form1" runat="server">
        <ext:Hidden runat="server" ID="txtMaBieuBaoCao"/>
        <ext:Hidden runat="server" ID="txtIDChiTieu" />

        <ext:TabPanel runat="server" ID="tabpeChiTiet">
            <Items>
                <ext:Panel ID="Tab1" runat="server" Title="Dịch vụ" BodyPadding="5">
                    <Items>
                        <ext:GridPanel runat="server" ID="grdChiTietDichVuSTK1" TitleAlign="Center" MinHeight="300" Height="700" Cls="my-grid">
                        <Store>
                            <ext:Store runat="server" ID="stoChiTietDichVuSTK1">
                                <Model>
                                    <ext:Model runat="server">
                                        <Fields>
                                            <ext:ModelField Name="Ma" />
                                            <ext:ModelField Name="Ten" />
                                            <ext:ModelField Name="SoLieuSTK1" />
                                        </Fields>
                                    </ext:Model>
                                </Model>
                            </ext:Store>
                        </Store>
                        <%--<TopBar>
                            <ext:Toolbar runat="server">
                                <Items>
                                    <ext:Button runat="server" Text="Xuất Excel" Icon="PageExcel" ID="btnXuatExcelDV">
                                        <DirectEvents>
                                            <Click OnEvent="btnXuatExcelDV_Click">
                                                <EventMask ShowMask="true" Msg="Đang thực thi ....." />
                                            </Click>
                                        </DirectEvents>
                                    </ext:Button>
                                </Items>
                            </ext:Toolbar>
                        </TopBar>--%>
                        <ColumnModel>
                            <Columns>
                                <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                                <ext:Column runat="server" Text="Mã" DataIndex="Ma" Width="100" Align="Center" StyleSpec="font-weight:bold;">                                    
                                </ext:Column>
                                <ext:Column runat="server" Text="Tên" DataIndex="Ten" Width="350" StyleSpec="font-weight:bold;">
                                </ext:Column>
                                <ext:SummaryColumn runat="server" Text="Số liệu" DataIndex="SoLieuSTK1" SummaryType="Sum" Align="Right" Width="200" StyleSpec="font-weight:bold;">
                                     
                                </ext:SummaryColumn>
                            </Columns>
                        </ColumnModel>
                        <SelectionModel>
                            <ext:RowSelectionModel runat="server" />
                        </SelectionModel>
                        <Features>
                            <ext:Summary ID="Summary1" runat="server" />
                        </Features>
                    </ext:GridPanel>
                    </Items>
                </ext:Panel>

                <ext:Panel ID="Tab2" runat="server" Title="Dịch vụ Ngày" BodyPadding="5">
                    <Items>
                        <ext:GridPanel runat="server" ID="GridPanel1" TitleAlign="Center" MinHeight="300" Height="700">
                        <Store>
                            <ext:Store runat="server" ID="stoChiTietDichVuNgay">
                                <Model>
                                    <ext:Model runat="server">
                                        <Fields>
                                            <ext:ModelField Name="Ma" />
                                            <ext:ModelField Name="Ten" />
                                            <ext:ModelField Name="N1" />
                                            <ext:ModelField Name="N2" />
                                            <ext:ModelField Name="N3" />
                                            <ext:ModelField Name="N4" />
                                            <ext:ModelField Name="N5" />
                                            <ext:ModelField Name="N6" />
                                            <ext:ModelField Name="N7" />
                                            <ext:ModelField Name="N8" />
                                            <ext:ModelField Name="N9" />
                                            <ext:ModelField Name="N10" />

                                            <ext:ModelField Name="N11" />
                                            <ext:ModelField Name="N12" />
                                            <ext:ModelField Name="N13" />
                                            <ext:ModelField Name="N14" />
                                            <ext:ModelField Name="N15" />
                                            <ext:ModelField Name="N16" />
                                            <ext:ModelField Name="N17" />
                                            <ext:ModelField Name="N18" />
                                            <ext:ModelField Name="N19" />
                                            <ext:ModelField Name="N20" />

                                            <ext:ModelField Name="N21" />
                                            <ext:ModelField Name="N22" />
                                            <ext:ModelField Name="N23" />
                                            <ext:ModelField Name="N24" />
                                            <ext:ModelField Name="N25" />
                                            <ext:ModelField Name="N26" />
                                            <ext:ModelField Name="N27" />
                                            <ext:ModelField Name="N28" />
                                            <ext:ModelField Name="N29" />
                                            <ext:ModelField Name="N30" />
                                            <ext:ModelField Name="N31" />
                                            <ext:ModelField Name="Cong" />
                                        </Fields>
                                    </ext:Model>
                                </Model>
                            </ext:Store>
                        </Store>    
                        <TopBar>
                            <ext:Toolbar runat="server">
                                <Items>
                                    <ext:Button runat="server" Text="Xuất Excel" Icon="PageExcel" ID="btnXuatExcelDVNgay">
                                        <DirectEvents>
                                            <Click OnEvent="btnXuatExcelDVNgay_Click">
                                                <EventMask ShowMask="true" Msg="Đang thực thi ....." />
                                            </Click>
                                        </DirectEvents>
                                    </ext:Button>
                                </Items>
                            </ext:Toolbar>
                        </TopBar>
                        <ColumnModel>
                            <Columns>
                                <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                                <ext:Column runat="server" Text="Mã" DataIndex="Ma" Width="100" Align="Center" StyleSpec="font-weight:bold;">                                    
                                </ext:Column>
                                <ext:Column runat="server" Text="Tên" DataIndex="Ten" Width="200" StyleSpec="font-weight:bold;">
                                </ext:Column>
                                <ext:SummaryColumn runat="server" Text="N1" DataIndex="N1" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N2" DataIndex="N2" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N3" DataIndex="N3" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N4" DataIndex="N4" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N5" DataIndex="N5" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N6" DataIndex="N6" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N7" DataIndex="N7" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N8" DataIndex="N8" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N9" DataIndex="N9" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N10" DataIndex="N10" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>

                                <ext:SummaryColumn runat="server" Text="N11" DataIndex="N11" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N12" DataIndex="N12" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N13" DataIndex="N13" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N14" DataIndex="N14" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N15" DataIndex="N15" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N16" DataIndex="N16" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N17" DataIndex="N17" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N18" DataIndex="N18" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N19" DataIndex="N19" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N20" DataIndex="N20" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>

                                <ext:SummaryColumn runat="server" Text="N21" DataIndex="N21" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N22" DataIndex="N22" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N23" DataIndex="N23" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N24" DataIndex="N24" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N25" DataIndex="N25" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N26" DataIndex="N26" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N27" DataIndex="N27" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N28" DataIndex="N28" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N29" DataIndex="N29" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N30" DataIndex="N30" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N31" DataIndex="N31" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="Cộng" DataIndex="Cong" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                            </Columns>
                        </ColumnModel>
                        <SelectionModel>
                            <ext:RowSelectionModel runat="server" />
                        </SelectionModel>
                        <Features>
                            <ext:Summary ID="Summary2" runat="server" />
                        </Features>
                    </ext:GridPanel>
                    </Items>
                </ext:Panel>

                <ext:Panel ID="Tab3" runat="server" Title="Bưu cục Ngày" BodyPadding="5">
                    <Items>
                        <ext:GridPanel runat="server" ID="GridPanel2" TitleAlign="Center" MinHeight="300" Height="700">
                        <Store>
                            <ext:Store runat="server" ID="stoChiTietBuuCucNgay">
                                <Model>
                                    <ext:Model runat="server">
                                        <Fields>
                                            <ext:ModelField Name="Ma" />
                                            <ext:ModelField Name="Ten" />
                                            <ext:ModelField Name="N1" />
                                            <ext:ModelField Name="N2" />
                                            <ext:ModelField Name="N3" />
                                            <ext:ModelField Name="N4" />
                                            <ext:ModelField Name="N5" />
                                            <ext:ModelField Name="N6" />
                                            <ext:ModelField Name="N7" />
                                            <ext:ModelField Name="N8" />
                                            <ext:ModelField Name="N9" />
                                            <ext:ModelField Name="N10" />

                                            <ext:ModelField Name="N11" />
                                            <ext:ModelField Name="N12" />
                                            <ext:ModelField Name="N13" />
                                            <ext:ModelField Name="N14" />
                                            <ext:ModelField Name="N15" />
                                            <ext:ModelField Name="N16" />
                                            <ext:ModelField Name="N17" />
                                            <ext:ModelField Name="N18" />
                                            <ext:ModelField Name="N19" />
                                            <ext:ModelField Name="N20" />

                                            <ext:ModelField Name="N21" />
                                            <ext:ModelField Name="N22" />
                                            <ext:ModelField Name="N23" />
                                            <ext:ModelField Name="N24" />
                                            <ext:ModelField Name="N25" />
                                            <ext:ModelField Name="N26" />
                                            <ext:ModelField Name="N27" />
                                            <ext:ModelField Name="N28" />
                                            <ext:ModelField Name="N29" />
                                            <ext:ModelField Name="N30" />
                                            <ext:ModelField Name="N31" />
                                            <ext:ModelField Name="Cong" />
                                        </Fields>
                                    </ext:Model>
                                </Model>
                            </ext:Store>
                        </Store>
                        <TopBar>
                            <ext:Toolbar runat="server">
                                <Items>
                                    <ext:Button runat="server" Text="Xuất Excel" Icon="PageExcel" ID="btnXuatExcelBCNgay">
                                        <DirectEvents>
                                            <Click OnEvent="btnXuatExcelBCNgay_Click">
                                                <EventMask ShowMask="true" Msg="Đang thực thi ....." />
                                            </Click>
                                        </DirectEvents>
                                    </ext:Button>
                                </Items>
                            </ext:Toolbar>
                        </TopBar>
                        <ColumnModel>
                            <Columns>
                                <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;"/>
                                <ext:Column runat="server" Text="Mã" DataIndex="Ma" Width="100" Align="Center" StyleSpec="font-weight:bold;">                                    
                                </ext:Column>
                                <ext:Column runat="server" Text="Tên" DataIndex="Ten" Width="200" StyleSpec="font-weight:bold;">
                                </ext:Column>
                                <ext:SummaryColumn runat="server" Text="N1" DataIndex="N1" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N2" DataIndex="N2" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N3" DataIndex="N3" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N4" DataIndex="N4" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N5" DataIndex="N5" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N6" DataIndex="N6" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N7" DataIndex="N7" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N8" DataIndex="N8" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N9" DataIndex="N9" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N10" DataIndex="N10" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>

                                <ext:SummaryColumn runat="server" Text="N11" DataIndex="N11" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N12" DataIndex="N12" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N13" DataIndex="N13" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N14" DataIndex="N14" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N15" DataIndex="N15" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N16" DataIndex="N16" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N17" DataIndex="N17" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N18" DataIndex="N18" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N19" DataIndex="N19" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N20" DataIndex="N20" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>

                                <ext:SummaryColumn runat="server" Text="N21" DataIndex="N21" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N22" DataIndex="N22" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N23" DataIndex="N23" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N24" DataIndex="N24" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N25" DataIndex="N25" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N26" DataIndex="N26" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N27" DataIndex="N27" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N28" DataIndex="N28" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N29" DataIndex="N29" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N30" DataIndex="N30" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="N31" DataIndex="N31" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                                <ext:SummaryColumn runat="server" Text="Cộng" DataIndex="Cong" SummaryType="Sum" StyleSpec="font-weight:bold;" Align="Right"/>
                            </Columns>
                        </ColumnModel>
                        <SelectionModel>
                            <ext:RowSelectionModel runat="server" />
                        </SelectionModel>
                        <Features>
                            <ext:Summary ID="Summary3" runat="server" />
                        </Features>
                    </ext:GridPanel>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:TabPanel>
    </form>
</body>
</html>

