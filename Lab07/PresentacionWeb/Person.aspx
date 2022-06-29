<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="PresentacionWeb.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mx-4 my-4">
        
            <div class="mb-3 col-lg-5 ">
                <asp:Label ID="Buscar" runat="server" Text="Buscar" CssClass="px-2"></asp:Label>
                <asp:TextBox ID="txtBuscar" runat="server"  CssClass="px-2"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar"  CssClass="btn btn-success px-2" OnClick="btnBuscar_Click"/>
                <asp:Button ID="Button2" runat="server" Text="Listar" CssClass="btn btn-primary px-2" OnClick="btnListar_Click"/>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-info px-2" OnClick="btnAgregar_Click"/>
            
            
            </div>
            
            <div>
                <asp:GridView ID="gvDatos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
