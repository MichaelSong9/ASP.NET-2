<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Pagina_Inicial.aspx.vb"
    Inherits="Pagina_Inicial" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="App_Themes/CCL/CCL.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div style="z-index: 104; left: 331px; width: 169px; position: absolute; top: 48px;
        height: 100px">
        <input id="txtResolucao" type="text" runat="server" visible="true" style="width: 1px;
            background-color: transparent; visibility: hidden;" />
    </div>
    <form id="form1" runat="server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/CCL/Imagens/background_Copo.gif"
        Style="margin-left: 70px" />
    </form>
</body>
</html>
