<%@ Page Title="Principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Actividad12._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="color: blue; text-align: center;">Tus cuentos favoritos</h1>
        <p class="lead" style="text-align: center">¿Qué quieres leer?</p>

        <div class="row">

            <div class="col-md-6" >
                <asp:ImageButton CssClass="img-thumbnail rounded mx-auto d-block" ImageUrl="~/Images/CaperucitaRoja.jpg" runat="server" ID="CR" OnClick="CR_Click" />                
            </div>
            <div class="col-md-6">
                  <asp:ImageButton CssClass="img-thumbnail rounded mx-auto d-block" ImageUrl="~/Images/HAndG.fw.png" runat="server" ID="CR1" OnClick="CR_Click" />                   
            </div>

        </div>
        <div class="row">
            <div class="col-md-6">
                 <asp:ImageButton CssClass="img-thumbnail rounded mx-auto d-block" ImageUrl="~/Images/PatitoFeo.fw.png" runat="server" ID="CR2" OnClick="CR_Click" />                  
            </div>                      
            <div class="col-md-6">
                 <asp:ImageButton CssClass="img-thumbnail rounded mx-auto d-block" ImageUrl="~/Images/TresCerditos.fw.png" runat="server" ID="CR3" OnClick="CR_Click" />                   
            </div>
        </div>

    </div>

    <div  class="jumbotron" style="text-align:center">
        <h1><asp:Label style="color: blue;" runat="server" ID="txtTituloCuento"></asp:Label></h1>
        <p> <asp:Label runat="server" ID="txtCuento"></asp:Label></p>
    </div>

</asp:Content>
