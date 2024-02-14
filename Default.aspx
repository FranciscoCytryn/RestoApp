<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RestoApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="cards-container">

            <asp:Repeater ID="RptMesas" runat="server" OnItemCommand="RptMesas_ItemCommand">
                <ItemTemplate>

                    <div class="card mb-4 bg-ca" style="width: 18rem;">
                        <h5 class="card-title"><%# Eval("Descripcion") %></h5>

                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:DropDownList ID="ddlMesero" runat="server" DataTextField="NombreEmpleado" DataValueField="IdEmpleado" />

        </div>
    </main>

</asp:Content>
