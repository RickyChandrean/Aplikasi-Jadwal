<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Jadwal.aspx.cs" Inherits="AplikasiJadwal.Jadwal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-12">
        <h2>Informasi Mata Kuliah</h2>
        <hr />
        <ul class="nav nav-tabs">
            <li class="nav-item">
                <a class="nav-link active" href="#1" data-toggle="tab">Input data</a>
            </li>
            <li classs="nav-item">
                <a class="nav-link" href="#2" data-toggle="tab">Display</a>
            </li>
        </ul>
        <br />
        <div class="tab-content">
            <div class="tab-pane active" id="1" style="margin-top: 1px">
                <asp:Literal ID="response" runat="server"></asp:Literal>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Kode Dosen"></asp:Label>
                    <asp:TextBox ID="txtKodeD" runat="server" CssClass="form-control" placeholder="Masukan Kode Dosen"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Kode Mata Kuliah" for="txNama"></asp:Label>
                    <asp:TextBox ID="txtKdMK" runat="server" class="form-control" placeholder="Masukan Kode Mata Kuliah"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Tanggal"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtDate" runat="server" placeholder="Masukan Tanggal"></asp:TextBox>
                    &nbsp;<asp:ImageButton ID="ImgButton" runat="server" ImageUrl="~/Asset/pic/cal.png" OnClick="ImgButton_Click" />
                    <asp:Calendar ID="Calendar1" runat="server" Visible="false" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Jam"></asp:Label>
                    <asp:TextBox ID="TxtJam" runat="server" class="form-control" placeholder="Masukan Jam"></asp:TextBox>
                </div>
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
            </div>
            <div class="tab-pane" id="2">
                <asp:Literal ID="lt_table" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
</asp:Content>
