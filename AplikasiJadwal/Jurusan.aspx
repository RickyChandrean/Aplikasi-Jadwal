<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Jurusan.aspx.cs" Inherits="AplikasiJadwal.Jurusan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="col-lg-12">
		<h2>Informasi Jurusan</h2>
		<hr />
		<ul class="nav nav-tabs">
			<li>
				<a class="nav-link active" href="#insert" data-toggle="tab">Input data</a>
			</li>
			<li>
				<a class="nav-link" href="#display" data-toggle="tab">Display</a>
			</li>
		</ul> 
		<br />
		<div class="tab-content">
			<div id="insert" class="tab-pane active" >
				<asp:Literal ID="response" runat="server"></asp:Literal>
				<div class="form-group">
					<asp:Label ID="Label1" runat="server" Text="Kode Jurusan"></asp:Label>
					<asp:TextBox ID="txtKodeJurusan" runat="server" CssClass="form-control" placeholder="Enter Kode Jurusan" required="true"></asp:TextBox>
				</div>
				<div class="form-group">
					<asp:Label ID="Label2" runat="server" Text="Nama Jurusan" for="txNama"></asp:Label>
					<asp:TextBox ID="txtNamaJurusan" runat="server" class="form-control" placeholder="Enter Nama Jurusan" required="true"></asp:TextBox>
				</div>
				<br />
				<asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" OnClick="btnSimpan_Click" />	
			</div>

			<div id="display" class="tab-pane" >
				<asp:Literal ID="lt_table" runat="server"></asp:Literal>
			</div>
		</div>
	</div>
</asp:Content>