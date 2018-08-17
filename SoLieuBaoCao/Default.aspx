<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SoLieuBaoCao.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Số liệu Báo cáo</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="Resource/CSS/main.css" />
    <link rel="stylesheet" href="Resource/CSS/examples.css" />
    <script src="resources/js/perfect-scrollbar.min.js?0.6.8"></script>
    <script src="resources/js/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server" Theme="Triton" />
    
    <ext:Viewport runat="server" Layout="BorderLayout">
        <Items>
            
            <ext:Panel
                runat="server"
                Header="false"
                Region="North"
                Border="false"
                Height="70">
                <Content>
                    <header class="site-header" role="banner">
                        <nav class="top-navigation">
                            <div class="logo-container">
                                <img src="resources/images/Logo_BaoCao.jpg" />
                            </div>
                            <div class="navigation-bar">
                                <div class="platform-selector-container">
                                    
                                </div>
                                <label id="menu-button" for="menu-button-checkbox">
                                    <span></span>
                                </label>
                            </div>
                        </nav>
                    </header>
                </Content>
            </ext:Panel>

            <ext:Panel
                runat="server"
                Region="West"
                Layout="Fit"
                Width="270"
                Header="false"
                MarginSpec="0"
                Border="false">
                <Items>
                    <ext:TreePanel
                        ID="exampleTree"
                        runat="server"
                        Header="false"
                        AutoScroll="true"
                        Lines="false"
                        UseArrows="true"
                        CollapseFirst="false"
                        RootVisible="false"
                        Animate="false"
                        HideHeaders="true">
                        <TopBar>
                            <ext:Toolbar runat="server" Cls="left-header">
                                <Items>
                                    <ext:TextField
                                        ID="TriggerField1"
                                        runat="server"
                                        EnableKeyEvents="true"
                                        Flex="1"
                                        EmptyText="Filter Examples..."
                                        RemoveClearTrigger="true">                                        
                                    </ext:TextField>                                    
                                </Items>
                            </ext:Toolbar>
                        </TopBar>
                        <Store>
                            <ext:TreeStore runat="server" >
                                <Proxy>
                                    <ext:PageProxy>
                                        <RequestConfig Method="GET" Type="Load" />
                                    </ext:PageProxy>
                                </Proxy>
                                <Root>
                                    <ext:Node NodeID="Root" Expanded="true" />
                                </Root>
                                <Fields>
                                    <ext:ModelField Name="tags" />
                                    <ext:ModelField Name="flags" />
                                </Fields>
                            </ext:TreeStore>
                        </Store>
                        <ColumnModel>
                            <Columns>
                                <ext:TreeColumn runat="server" DataIndex="text" Flex="1">
                                    
                                </ext:TreeColumn>
                            </Columns>
                        </ColumnModel>
                        <Listeners>
                            
                        </Listeners>
                    </ext:TreePanel>
                </Items>
            </ext:Panel>

            <ext:TabPanel
                ID="ExampleTabs"
                runat="server"
                Region="Center"
                MarginSpec="0"
                Cls="tabs"
                MinTabWidth="115">
                <Items>
                    
                </Items>
            </ext:TabPanel>
        </Items>
    </ext:Viewport>
    </form>
</body>
</html>
