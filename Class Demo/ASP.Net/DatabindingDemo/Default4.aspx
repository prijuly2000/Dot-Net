﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1">
        <DataBindings>
            <asp:TreeNodeBinding DataMember="Eid" TextField="#InnerText" />
            <asp:TreeNodeBinding DataMember="EName" TextField="#InnerText" />
            <asp:TreeNodeBinding DataMember="Basic" TextField="#InnerText" />
        </DataBindings>
    </asp:TreeView>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Emp.xml">
    </asp:XmlDataSource>
    </form>
</body>
</html>
