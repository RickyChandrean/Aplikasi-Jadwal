<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditDosen.aspx.cs" Inherits="AplikasiJadwal.EditDosen" %>
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
        </ul>
        <br />
        <div class="tab-content">
            <div class="tab-pane active" id="1">
                <asp:Literal ID="response" runat="server"></asp:Literal>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Kode Dosen"></asp:Label>
                    <asp:TextBox ID="txtKodeD" runat="server" CssClass="form-control" placeholder="Masukan Kode Dosen" readonly="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Kode Jurusan" for="txNama"></asp:Label>
                    <asp:DropDownList ID="ddjurusan" runat="server" class="form-control"></asp:DropDownList>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Nama Dosen" for="txNama"></asp:Label>
                    <asp:TextBox ID="txtNamaDosen" runat="server" class="form-control" placeholder="Masukan Nama Mata Dosen" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="No Telp"></asp:Label>
                    <asp:TextBox ID="TxtTelp" runat="server" class="form-control" placeholder="Masukan No Telp" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Alamat"></asp:Label>
                    <asp:TextBox ID="TxtAlamat" runat="server" class="form-control" placeholder="Masukan Alamat" required="true"></asp:TextBox>
                </div>
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Ubah" class="btn btn-warning" OnClick="btnSubmit_Click"/>
                &nbsp;<asp:HyperLink ID="Back" runat="server" NavigateUrl="~/Dosen.aspx" CssClass="btn btn-primary">Kembali</asp:HyperLink>
            </div>
        </div>
    </div>
</asp:Content>
