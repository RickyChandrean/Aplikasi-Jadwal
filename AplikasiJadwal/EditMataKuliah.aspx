<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditMataKuliah.aspx.cs" Inherits="AplikasiJadwal.EditMataKuliah" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Kode Mata Kuliah"></asp:Label>
                    <asp:TextBox ID="txtKodeMK" runat="server" CssClass="form-control" placeholder="Enter Kode Mata Kuliah" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Nama Mata Kuliah" for="txNama"></asp:Label>
                    <asp:TextBox ID="txtNamaJurusan" runat="server" class="form-control" placeholder="Enter Nama Mata Kuliah" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="SKS"></asp:Label>
                    <asp:TextBox ID="TxtSKS" runat="server" class="form-control" placeholder="Enter Jumlah SKS" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Semester"></asp:Label>
                    <asp:TextBox ID="TxtSems" runat="server" class="form-control" placeholder="Enter Semester" required="true"></asp:TextBox>
                </div>
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Ubah" class="btn btn-warning" OnClick="btnSubmit_Click"/>
                &nbsp
				<asp:HyperLink ID="kembali" runat="server" CssClass="btn btn-primary" NavigateUrl="~/MataKuliah.aspx">Kembali</asp:HyperLink>
            </div>
        </div>
    </div>
</asp:Content>
