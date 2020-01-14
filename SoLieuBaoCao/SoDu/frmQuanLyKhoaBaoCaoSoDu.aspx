<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmQuanLyKhoaBaoCaoSoDu.aspx.cs" Inherits="SoLieuBaoCao.SoDu.frmQuanLyKhoaBaoCaoSoDu" %>

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
     <script type="text/javascript">
         var template = '<span style="color:{0};">{1}</span>';

        var mauDuCuoi = function (value) {
            return Ext.String.format(template, (value > 0) ? "orange" : "red", value);
        };

        var mauDuKienChi = function (value) {
            return Ext.String.format(template, (value > 0) ? "green" : "red", value);
         };

         function getRowClass(record) {
             if (record.data.Khoa) {
                return "GridPanelUsersRowYellow";
            }
            else
            {
                return "GridPanelUsersRowWhite";
            }
         }

        var edit = function (editor, e)
        {
            if (e.value !== e.originalValue)
            {
                BangNhapKhoaX.Edit(e.record.data.STT, e.field, e.originalValue, e.value, e.record.data);
            }
        }

     </script>
</head>
<body>
    <ext:ResourceManager runat="server" Locale="vi-VN" Theme="NeptuneTouch" />
    <form id="form1" runat="server">
        <ext:GridPanel runat="server" ID="grdSoDuTMCuoiNgay" TitleAlign="Center" MinHeight="300" Height="800" MarginSpec="0 0 0 0">
            <TopBar>
                <ext:Toolbar runat="server">
                   <Items>
                       <ext:SelectBox runat="server" ID="slbDonVi" DisplayField="Ten" ValueField="Ma" FieldLabel="Đơn vị" LabelStyle="font-weight:bold;" 
                           LabelWidth="70" Width="360" MarginSpec="0 0 0 20">
                        <Store>
                            <ext:Store runat="server" ID="stoDonVi">
                                <Fields>
                                    <ext:ModelField Name="Ma" />
                                    <ext:ModelField Name="Ten" />
                                </Fields>
                            </ext:Store>
                        </Store>
                           <Listeners>
                               <Select Handler="#{stoKhoaSoDuTMCuoiNgay}.reload();" />
                           </Listeners>
                        </ext:SelectBox>
                       <ext:DateField runat="server" ID="txtNgay" FieldLabel="Ngày" LabelWidth="50" LabelStyle="font-weight:bold;"  MarginSpec="0 0 0 20" Width="200">
                           <Listeners>
                               <Select Handler="#{stoKhoaSoDuTMCuoiNgay}.reload();" />
                           </Listeners>
                       </ext:DateField>
                   </Items>
                </ext:Toolbar>
            </TopBar>
            <Store>
                <ext:Store runat="server" ID="stoKhoaSoDuTMCuoiNgay" OnReadData="DanhSachTrangThaiKhoa">
                    <Model>
                        <ext:Model runat="server" IDProperty="STT">
                            <Fields>
                                <ext:ModelField Name="STT" />
                                <ext:ModelField Name="MaKeToanNgay" />
                                <ext:ModelField Name="MaBuuCuc" />
                                <ext:ModelField Name="BuuCuc" />
                                <ext:ModelField Name="Ngay" />
                                
                                <ext:ModelField Name="Khoa" />
                                <ext:ModelField Name="NgayKhoa" />
                                <ext:ModelField Name="NguoiKhoa" />
                            </Fields>
                        </ext:Model>
                    </Model>
                </ext:Store>
            </Store>    
            <View>
                <ext:GridView ID="GridView1" runat="server">
                    <GetRowClass Fn="getRowClass" />
                </ext:GridView>
            </View>
            <ColumnModel>
                <Columns>
                    <ext:RowNumbererColumn runat="server" Text="STT" Align="Center" Width="60" StyleSpec="font-weight:bold;" />
                    <ext:DateColumn runat="server" Text="Ngày" DataIndex="Ngay" Align="Center" Width="110" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy" />
                    <ext:Column runat="server" Text="Mã BC" Align="Left" DataIndex="MaBuuCuc" Width="100" StyleSpec="font-weight:bold;" />
                    <ext:Column runat="server" Text="Bưu cục" Align="Left" DataIndex="BuuCuc" Width="260" StyleSpec="font-weight:bold;" />

                    <ext:CheckColumn runat="server" Text="Khóa" DataIndex="Khoa" Align="Center" Editable="true" StyleSpec="font-weight:bold;"/>
                    <ext:DateColumn runat="server" Text="Ngày khóa" DataIndex="NgayKhoa" Align="Center" Width="260" StyleSpec="font-weight:bold;" Format="dd/MM/yyyy HH:mm:ss" />
                    <ext:Column runat="server" Text="Người khóa" Align="Left" DataIndex="NguoiKhoa" Width="360" StyleSpec="font-weight:bold;" />
                </Columns>
            </ColumnModel>
            <SelectionModel>
               <ext:CellSelectionModel runat="server">
               </ext:CellSelectionModel>
            </SelectionModel>    
             <Plugins>                
                <ext:CellEditing runat="server" ClicksToEdit="1">
                    <Listeners>                        
                        <Edit Fn="edit" />
                    </Listeners>
                </ext:CellEditing>
            </Plugins>
        </ext:GridPanel>
    </form>
</body>
</html>
