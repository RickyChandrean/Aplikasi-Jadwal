<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditPassword.aspx.cs" Inherits="AplikasiJadwal.EditPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <h2>Ubah Password</h2>
        <hr />
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link active" href="#1" data-toggle="tab">Input data</a>
            </li>
        </ul>
        <br />
        <div class="tab-content">
            <div class="tab-pane active" id="1">
                <asp:Literal ID="response" runat="server"></asp:Literal>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Password Lama"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Password Baru"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="btUbah" runat="server" Text="Ubah" CssClass="btn btn-warning" OnClick="btUbah_Click" />
            </div>
</asp:Content>
