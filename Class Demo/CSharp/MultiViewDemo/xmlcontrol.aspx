﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xmlcontrol.aspx.cs" Inherits="xmlcontrol" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Xml ID="Xml1" runat=server DocumentSource="~/XMLFile.xml" 
        TransformSource="~/XSLTFile.xslt"></asp:Xml>
    <div>
    
        
    
    </div>
    </form>
</body>
</html>