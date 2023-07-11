<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DeleteDosen.aspx.cs" Inherits="AplikasiJadwal.DeleteDosen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-lg-12">
		<h2>Informasi Dosen</h2>
		<hr />
		<ul class="nav nav-tabs">
			<li>
				<a class="nav-link active" href="#insert" data-toggle="tab">Konfirmasi Hapus</a>
			</li>
		
		</ul> 
		<br />
		<div class="tab-content">
			<div id="insert" class="tab-pane active" >
				<asp:Literal ID="response" runat="server"></asp:Literal>
				<div class="form-group">
					<asp:Label ID="Label1" runat="server" Text="Kode Jurusan"></asp:Label>
				</div>
				<asp:Button ID="btnHapus" runat="server" Text="Yes" CssClass="btn btn-danger" OnClick="btnHapus_Click1"/>	
				<asp:Button ID="btnCancel" runat="server" Text="No" CssClass="btn btn-primary" OnClick="btnCancel_Click1"/>	
			</div>
		</div>
	</div>
</asp:Content>
