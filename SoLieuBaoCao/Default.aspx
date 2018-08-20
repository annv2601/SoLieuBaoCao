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
    <script type="text/javascript">
        var handleNavToggle = function (button, pressed) {
            var treelist = App.ChucNangTree,
                ct = treelist.ownerCt;

            treelist.setExpanderFirst(!pressed);
            treelist.setUi(pressed ? 'nav' : null);
            treelist.setHighlightPath(pressed);
            ct[pressed ? 'addCls' : 'removeCls']('treelist-with-nav');

            if (treelist.getMicro()) {
                ct.setWidth(treelist.toolsElement.getWidth())
            }

            if (Ext.isIE8) {
                this.repaintList(treelist);
            }
        }

        var handleMicroToggle = function (me) {
            var tl = App.ChucNangTree,
                ct = tl.ownerCt;
            App.ChucNangTree.setMicro(me.pressed);

            if (me.pressed) {
                tl.macroWidth = ct.getWidth();
                ct.setWidth(tl.toolsElement.getWidth());
            } else {
                if (tl.macroWidth === undefined) {
                    tl.macroWidth = 200;
                }
                ct.setWidth(tl.macroWidth);
            }
        }

        var addTabCN = function (tabPanel, id, url, TieuDe) {
                var tab = tabPanel.getComponent(id);

                if (!tab) {
                    tab = tabPanel.add({
                        id       : id,
                        title    : TieuDe,
                        closable: true,
                                              
                        loader   : {
                            url      : url,
                            renderer : "frame",
                            loadMask : {
                                showMask : true,
                                msg      : "Nạp chức năng ..."
                            }
                        }
                    });
                }

                tabPanel.setActiveTab(tab);
            }
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server" Theme="Triton" />
    
    <ext:Viewport runat="server" Layout="BorderLayout">
        <Items>            
            <ext:Panel
                runat="server"
                Header="false"                Region="North"
                Border="false"
                Height="70">
                <Content>
                    <header class="site-header" role="banner">
                        <nav class="top-navigation">
                            <div class="logo-container">
                                <img src="resource/images/Logo_BaoCao.jpg" />
                            </div>
                            <div class="navigation-bar">
                                <div class="platform-selector-container">
                                    
                                </div>                               
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
                Border="false" Split="true" Scrollable="Both">
                <TopBar>
                            <ext:Toolbar runat="server" Cls="left-header">
                                <Items>
                                    <ext:TextField
                                        ID="TriggerField1"
                                        runat="server"
                                        EnableKeyEvents="true"
                                        Flex="1"
                                        EmptyText="Tìm chức năng ..."
                                        RemoveClearTrigger="true">                                        
                                    </ext:TextField>

                                    <ext:Button
                                        ID="MicroToggleBtn"
                                        runat="server"
                                        Text="< - >"
                                        EnableToggle="true">
                                        <Listeners>
                                            <Toggle Fn="handleMicroToggle" />
                                        </Listeners>
                                    </ext:Button>
                                </Items>
                            </ext:Toolbar>
                        </TopBar>
                <Items>                    
                    <ext:TreeList 
                        ID="ChucNangTree"
                        runat="server"
                        Header="false"
                        AutoScroll="true"
                        Lines="false"
                        UseArrows="true"
                        CollapseFirst="false"
                        RootVisible="false"
                        Animate="false"
                        HideHeaders="true">                        
                        <Listeners>
                            
                        </Listeners>
                    </ext:TreeList>
                </Items>
            </ext:Panel>

            <ext:TabPanel
                ID="TabPanelChinh"
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
