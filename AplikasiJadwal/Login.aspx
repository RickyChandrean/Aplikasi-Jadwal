<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AplikasiJadwal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Login Form</title>
    <link href="Scripts/bootstrap.min.js" rel="stylesheet" />
    <link href="Asset/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.css" rel="stylesheet" />
    <link href="https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Asset/vendor/bootstrap/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
     <!-- Bootstrap core JavaScript -->
            <script src="Asset/vendor/jquery/jquery.slim.min.js"></script>
            <script src="Asset/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
            <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
            <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
            <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
            <script src="https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
            <script src="https://cdn.datatables.net/1.10.23/js/dataTables.bootstrap4.min.js"></script>
            <script src="Asset/vendor/jquery/jquery.min.js" type="text/javascript"></script>
            <script src="js/jquery.dataTables.min.js" type="text/javascript"></script>
            <script>
                $(document).ready(function () {
                    $('#table').DataTable();
                });
            </script>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark static-top">
        <div class="container">
            <a class="navbar-brand" href="#">Aplikasi Jadwal</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </div>
    </nav>
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <h3 class="mt-3">Login Form</h3>
                <form id="form1" runat="server">
                    <div>
                        <div class="form-inline">
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control my-1 mr-1" placeholder="Masukan Username" required="true"></asp:TextBox>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Masukan Password" TextMode="Password" required="true"></asp:TextBox>
                        </div>
                        <div>
                            <asp:CheckBox ID="ckremember" runat="server" Text="Remember Me" />
                        </div>
                        <div>
                            <asp:Button ID="btLogin" runat="server" Text="Login" CssClass="btn btn-primary my-2" onclick="btLogin_Click" />
                            <asp:Literal ID="response" runat="server"></asp:Literal>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
