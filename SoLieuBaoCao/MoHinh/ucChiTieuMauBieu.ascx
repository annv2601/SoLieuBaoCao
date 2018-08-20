<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucChiTieuMauBieu.ascx.cs" Inherits="SoLieuBaoCao.MoHinh.ucChiTieuMauBieu" %>
 <script type="text/javascript">
        var editDSCong = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangDanSuatCongX.EditDSCong(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);
            }
        }

     var editDSTru = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangDanSuatTruX.EditDSTru(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);
            }
     }

     var editDSNhan = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangDanSuatNhanX.EditDSNhan(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);
            }
     }

     var editMSCTCong = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangMSCTCongX.EditMSCTCong(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);
            }
        }

     var editMSCTTru = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangMSCTTruX.EditMSCTTru(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);
            }
     }
</script>
<ext:Panel 
    ID="Panel1" 
    runat="server">
    <Items>
        <ext:FieldContainer runat="server" MarginSpec="10 0 0 0" Layout="HBoxLayout">
        <LayoutConfig>
            <ext:HBoxLayoutConfig Align="Middle" Pack="Center" />            
        </LayoutConfig>
            <Items>
                <ext:Label runat="server" ID="txtTenChiTieu" StyleSpec="font-weight:bold; font-size:20px; color:green;" Width="700" Height="25" MarginSpec="0 0 0 5"/>
            </Items>
        </ext:FieldContainer>
        
        <%--Chi tieu mau bieu--%>
        <ext:FormPanel 
            ID="Panel2" 
            runat="server" Border="false" 
                    Header="false" 
                    AnchorHorizontal="100%" Layout="FormLayout" MarginSpec="10 0 0 0">
            <Items>
                <ext:Hidden runat="server" ID="txtIDChiTieuMauBieu" />
                <ext:Hidden runat="server" ID="txtIDMauBieu" />
                
                <ext:FieldContainer runat="server">
                    <Items>
                        <ext:FieldContainer runat="server" Layout="HBoxLayout">
                        <Items>
                            <ext:TextField runat="server" ID="txtThuTu" Width="140" FieldLabel="Thứ tự" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 0" LabelWidth="70"/>
                            <ext:Checkbox runat="server" ID="chkInDam" Width="140" FieldLabel="In đậm" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" LabelWidth="70"/>
                            <ext:Checkbox runat="server" ID="chkInNghieng" Width="140" FieldLabel="In nghiêng" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" LabelWidth="80"/>
                            <ext:Button runat="server" ID="btnCapNhatChiTieuMauBieu" Text="Cập nhật" Icon="Accept" MarginSpec="0 0 0 30">
                                <DirectEvents>
                                    <Click OnEvent="btnCapNhatChiTieuMauBieu_Click" />
                                </DirectEvents>
                            </ext:Button>
                        </Items>
                        </ext:FieldContainer>
                        <ext:FieldContainer runat="server" Layout="HBoxLayout">
                        <Items>
                            <ext:Checkbox runat="server" ID="chkNhapTay" Width="140" FieldLabel="Nhập tay" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 0" LabelWidth="70"/>
                            <ext:NumberField runat="server" ID="txtSTTsx" Width="140" FieldLabel="STT sx" AllowDecimals="true" DecimalPrecision="3" LabelStyle="font-weight:bold;" MarginSpec="0 0 0 20" LabelWidth="70"/>
                        </Items>
                        </ext:FieldContainer>                        
                    </Items>
                </ext:FieldContainer>
            </Items>
        </ext:FormPanel>
        <%--=============================--%>

        <%--Chi tieu dan suat--%>
        <ext:FieldSet runat="server" Title="Chỉ tiêu dẫn suất" Layout="HBoxLayout">
            <Items>
                <ext:GridPanel
                    ID="grdDanSuatCong"
                    runat="server"
                    Title="Chỉ tiêu cộng" HideHeaders="true"
                    Width="180"
                    Height="250">
                    <Store>
                        <ext:Store runat="server" ID="stoDSCong">
                            <Model>
                                <ext:Model runat="server" IDProperty="STT">
                                    <Fields>
                                        <ext:ModelField Name="IDChiTieuDanSuat" />
                                        <ext:ModelField Name="MaChiTieuDanSuat" />
                                        <ext:ModelField Name="TenChiTieuDanSuat" />
                                        <ext:ModelField Name="HeSo" />
                                        <ext:ModelField Name="STT" />
                                    </Fields>
                                </ext:Model>
                            </Model>                            
                        </ext:Store>
                    </Store>
                    <ColumnModel runat="server">
                        <Columns>
                            <ext:Column runat="server" Text="STT" DataIndex="STT" Width="50" Align="Center"/>                            
                            <ext:Column runat="server" Text="Mã" DataIndex="MaChiTieuDanSuat" Width="120" Align="Center">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:CellSelectionModel runat="server">
                        </ext:CellSelectionModel>
                    </SelectionModel>
                    <Plugins>
                        <ext:CellEditing runat="server" ClicksToEdit="1">
                            <Listeners>
                                <Edit Fn="editDSCong" />
                            </Listeners>
                        </ext:CellEditing>
                    </Plugins>
                </ext:GridPanel>

                <ext:GridPanel
                    ID="grdDanSuatTru"
                    runat="server"
                    Title="Chỉ tiêu trừ" HideHeaders="true"
                    Width="180"
                    Height="250" MarginSpec="0 0 0 20">
                    <Store>
                        <ext:Store runat="server" ID="stoDSTru">
                            <Model>
                                <ext:Model runat="server" IDProperty="STT">
                                    <Fields>
                                        <ext:ModelField Name="IDChiTieuDanSuat" />
                                        <ext:ModelField Name="MaChiTieuDanSuat" />
                                        <ext:ModelField Name="TenChiTieuDanSuat" />
                                        <ext:ModelField Name="HeSo" />
                                        <ext:ModelField Name="STT" />
                                    </Fields>
                                </ext:Model>
                            </Model>                            
                        </ext:Store>
                    </Store>
                    <ColumnModel runat="server">
                        <Columns>
                            <ext:Column runat="server" Text="STT" DataIndex="STT" Width="50" Align="Center"/>                            
                            <ext:Column runat="server" Text="Mã" DataIndex="MaChiTieuDanSuat" Width="120" Align="Center">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:CellSelectionModel runat="server">
                        </ext:CellSelectionModel>
                    </SelectionModel>
                    <Plugins>
                        <ext:CellEditing runat="server" ClicksToEdit="1">
                            <Listeners>
                                <Edit Fn="editDSTru" />
                            </Listeners>
                        </ext:CellEditing>
                    </Plugins>
                </ext:GridPanel>

                <ext:GridPanel
                    ID="grdDanSuatNhan"
                    runat="server"
                    Title="Chỉ tiêu nhân" HideHeaders="true"
                    Width="240"
                    Height="250" MarginSpec="0 0 0 20">
                    <Store>
                        <ext:Store runat="server" ID="stoDSNhan">
                            <Model>
                                <ext:Model runat="server" IDProperty="STT">
                                    <Fields>
                                        <ext:ModelField Name="IDChiTieuDanSuat" />
                                        <ext:ModelField Name="MaChiTieuDanSuat" />
                                        <ext:ModelField Name="TenChiTieuDanSuat" />
                                        <ext:ModelField Name="HeSo" />
                                        <ext:ModelField Name="STT" />
                                    </Fields>
                                </ext:Model>
                            </Model>                            
                        </ext:Store>
                    </Store>
                    <ColumnModel runat="server">
                        <Columns>
                            <ext:Column runat="server" Text="STT" DataIndex="STT" Width="50" Align="Center"/>
                            <ext:NumberColumn runat="server" Text="Hệ số" DataIndex="HeSo" Align="Center" Width="100">
                                <Editor>
                                    <ext:NumberField runat="server" AllowDecimals="true" DecimalPrecision="3" />
                                </Editor>
                            </ext:NumberColumn>
                            <ext:Column runat="server" Text="Mã" DataIndex="MaChiTieuDanSuat" Width="120" Align="Center">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:CellSelectionModel runat="server">
                        </ext:CellSelectionModel>
                    </SelectionModel>
                    <Plugins>
                        <ext:CellEditing runat="server" ClicksToEdit="1">
                            <Listeners>
                                <Edit Fn="editDSNhan" />
                            </Listeners>
                        </ext:CellEditing>
                    </Plugins>
                </ext:GridPanel>
            </Items>
        </ext:FieldSet>
        <%--=============================--%>

        <%--Chi tieu MSCT--%>
        <ext:FieldSet runat="server" Title="Chỉ tiêu STK1" Layout="HBoxLayout">
            <Items>
                <ext:GridPanel
                    ID="grdMSCTCong"
                    runat="server"
                    Title="Chỉ tiêu cộng" HideHeaders="true"
                    Width="200"
                    Height="250">
                    <Store>
                        <ext:Store runat="server" ID="stoMSCTCong">
                            <Model>
                                <ext:Model runat="server" IDProperty="STT">
                                    <Fields>
                                        <ext:ModelField Name="IDMauBieu" />
                                        <ext:ModelField Name="IDChiTieu" />
                                        <ext:ModelField Name="MSCT" />
                                        <ext:ModelField Name="TenMSCT" />
                                        <ext:ModelField Name="STT" />
                                    </Fields>
                                </ext:Model>
                            </Model>                            
                        </ext:Store>
                    </Store>
                    <ColumnModel runat="server">
                        <Columns>
                            <ext:Column runat="server" Text="STT" DataIndex="STT" Width="50" Align="Center"/>                            
                            <ext:Column runat="server" Text="Mã" DataIndex="MSCT" Width="140" Align="Center">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:CellSelectionModel runat="server">
                        </ext:CellSelectionModel>
                    </SelectionModel>
                    <Plugins>
                        <ext:CellEditing runat="server" ClicksToEdit="1">
                            <Listeners>
                                <Edit Fn="editMSCTCong" />
                            </Listeners>
                        </ext:CellEditing>
                    </Plugins>
                </ext:GridPanel>

                <ext:GridPanel
                    ID="grdMSCTTru"
                    runat="server"
                    Title="Chỉ tiêu trừ" HideHeaders="true"
                    Width="200"
                    Height="250" MarginSpec="0 0 0 20">
                    <Store>
                        <ext:Store runat="server" ID="stoMSCTTru">
                            <Model>
                                <ext:Model runat="server" IDProperty="STT">
                                    <Fields>
                                        <ext:ModelField Name="IDMauBieu" />
                                        <ext:ModelField Name="IDChiTieu" />
                                        <ext:ModelField Name="MSCT" />
                                        <ext:ModelField Name="TenMSCT" />
                                        <ext:ModelField Name="STT" />
                                    </Fields>
                                </ext:Model>
                            </Model>                            
                        </ext:Store>
                    </Store>
                    <ColumnModel runat="server">
                        <Columns>
                            <ext:Column runat="server" Text="STT" DataIndex="STT" Width="50" Align="Center"/>                            
                            <ext:Column runat="server" Text="Mã" DataIndex="MSCT" Width="140" Align="Center">
                                <Editor>
                                    <ext:TextField runat="server" />
                                </Editor>
                            </ext:Column>
                        </Columns>
                    </ColumnModel>
                    <SelectionModel>
                        <ext:CellSelectionModel runat="server">
                        </ext:CellSelectionModel>
                    </SelectionModel>
                    <Plugins>
                        <ext:CellEditing runat="server" ClicksToEdit="1">
                            <Listeners>
                                <Edit Fn="editMSCTTru" />
                            </Listeners>
                        </ext:CellEditing>
                    </Plugins>
                </ext:GridPanel>
            </Items>
        </ext:FieldSet>
        <%--=============================--%>

    </Items>
</ext:Panel>