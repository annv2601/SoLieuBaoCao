<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHienThiBaoCao.aspx.cs" Inherits="SoLieuBaoCao.BaoCao.frmHienThiBaoCao" %>
<%@ Register Assembly="PdfViewer" Namespace="PdfViewer" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:ShowPdf ID="ShowPdf1" runat="server" BoderStyle="Inset" BoderWidth="2px" Height="800px" Width="100%"
            Style="z-index: 103; left:10px; position:absolute; top:10px"/>
    </form>
</body>
</html>
