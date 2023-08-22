<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_productos.aspx.cs" Inherits="App_Comercio.frm_productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Productos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <br />
            <div class="div">
                <br />
                <h3>Formulario de producto</h3>
                <br />
                <asp:TextBox ID="txt_nombre_productos" runat="server" placeholder="Nombre del producto" CssClass="cajas"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_existencia" runat="server" placeholder="existencia" CssClass="cajas"></asp:TextBox>

                <asp:TextBox ID="txt_valor_compra" runat="server" placeholder="valor de la compra" CssClass="cajas"></asp:TextBox>

                <asp:TextBox ID="txt_ganancia" runat="server" placeholder="Ganacia" CssClass="cajas"></asp:TextBox>

                <div> <asp:DropDownList ID="txt_categoria" runat="server" placeholder="categoria" CssClass="cajas" AutoPostBack="True" OnSelectedIndexChanged="txt_categoria_SelectedIndexChanged">
                    <asp:ListItem>alimentos</asp:ListItem>
                    <asp:ListItem>seguridad</asp:ListItem>
                    </asp:DropDownList></div>

                <asp:TextBox ID="txt_especificaciones" runat="server" placeholder="especificaciones" CssClass="cajas"></asp:TextBox>

                
                <asp:TextBox ID="txt_valor_venta" runat="server" placeholder="Valor de venta" CssClass="cajas"></asp:TextBox>


                <div> <asp:DropDownList ID="txt_estado" runat="server" placeholder="estado"  CssClass="cajas"></asp:DropDownList></div>

                <div> <asp:DropDownList ID="txt_usuario" runat="server" placeholder="usuario"  CssClass="cajas"></asp:DropDownList></div>

                <asp:Button ID="btn_registrar" runat="server" Text="Registrar" CssClass="botones" OnClick="btn_registrar_Click" />

                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="botones" OnClick="btn_cancelar_Click" />

                <asp:Button ID="btn_consultar" runat="server" Text="Consultar" CssClass="botones" OnClick="btn_consultar_Click" />
           
                <br />
                <asp:Label ID="lbl_mensaje" runat="server" Text=""></asp:Label>
               
            
            </div>
        </center>
    </form>
</body>
</html>