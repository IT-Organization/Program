﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="top.aspx.cs" Inherits="backstage_top" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>top</title>
	<link rel="stylesheet" type="text/css" href="css/backstage.css">
</head>
<body>
    <form  id="form1" runat ="server">
	<div class="top">
		<div class="logo">
			<img src="images/logo.jpg">
		</div>
		<div class="login">
			<div class="selection">
                <a href='<%=url %>'><%=name %></a>
				<asp:LinkButton ID="Logout" runat="server" Text ="退出系统"  OnClick="Logout_Click"></asp:LinkButton>
				
			</div>
			<div class="icon">
				<img src='<%=imgUrl %>'>
			</div>
		</div>
	</div>
        </form>
</body>
</html>
