<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NumericalConversion.Views.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <!--Import materialize.css-->
    <link href="../css/materialize.min.css" media="screen,projection" rel="stylesheet" type="text/css" />

    <title>Numerical Conversion</title>
</head>
<body>
    <nav class="black" role="navigation">
        <div class="nav-wrapper container">
            <a id="logo-container" href="#" class="brand-logo">Numerical Conversion</a>
        </div>
    </nav>
    <div class="section no-pad-bot" id="body-banner">
    <div class="container">
     <br />
     <br />
    <form id="form1" runat="server">
        <div class="row center">   
            <div class="col m12">
                <h5 class="header center black-text">Enter a number to be converted to words:</h5>     
            </div> 
        </div>
        <div class="row center">
            <div class="col m8 offset-m2">
                <i class="material-icons prefix">dialpad</i> <br />
                <asp:Label ID="lbl_error" CssClass="center red-text" runat="server"></asp:Label>
                <asp:TextBox ID="txt_input" CssClass="center" runat="server"></asp:TextBox>  
                 
                <asp:Button ID="cmd_convert" CssClass="btn black waves-effect waves-light center" runat="server" OnClick="cmd_convert_Click" Text="Convert" style="height: 32px" />
            </div>
        </div>
        <div class="row center">
            <div class ="col m12">
                <h5 class="header center black-text">Converted words:</h5> 
            </div>
        </div>
        <div class="row center">
            <div class ="col m12">
                <i class="material-icons prefix">sort_by_alpha</i> 
              <asp:TextBox ID="txt_output" runat="server" Cssclass="black-text center" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
    </form>
    </div>
     </div>
    <footer class="page-footer black">
        <div class="container">
            <div class="row">
                <div class="col s4">
                    <p class="white-text">Matthew Lee</p>
                </div>
            </div>
        </div>
    </footer>
     <!--Import jQuery and materialize.js-->
    <script src="https://code.jquery.com/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="../js/materialize.min.js" type="text/javascript"></script>
</body>
</html>
