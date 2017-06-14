<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="testApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>testtt</title>

    <!-- Bootstrap -->
    <link href="js/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="js/css/Custom.css" rel="stylesheet"/>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <div class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toogle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="WebForm2.aspx"><span>
                            <img alt="Logo" src="images/bat1600.png" height="30" /></span></a>
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav navbar-right">
                            <li class="active"><a href="WebForm2.aspx">Home</a></li>
                            <li><a href="#">About</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <!--sIGN UP-->
        <div class="center_page">
            <label class="col-xs-11" >Username</label>
            <div class="col-xs-11">
            <asp:TextBox ID="username" runat="server" class="form-control" placeholder="username"></asp:TextBox>
            </div>

            <label class="col-xs-11" >Password</label>
            <div class="col-xs-11">
            <asp:TextBox ID="password" runat="server" class="form-control" placeholder="password"></asp:TextBox>
            </div>

            <label class="col-xs-11" >Confirm passsword</label>
            <div class="col-xs-11">
            <asp:TextBox ID="confirm" runat="server" class="form-control" placeholder="password"></asp:TextBox>
            </div>

            <label class="col-xs-11" >Name</label>
            <div class="col-xs-11">
            <asp:TextBox ID="name" runat="server" class="form-control" placeholder="name"></asp:TextBox>
            </div>

            <label class="col-xs-11" >Email</label>
            <div class="col-xs-11">
            <asp:TextBox ID="email" runat="server" class="form-control" placeholder="your-email"></asp:TextBox>
            </div>

            <div class="col-xs-11 space" >
            <asp:Button ID="btnSignup" runat="server" class="btn btn-default" Text="Sign up" OnClick="btnSignup_Click" />
                </div>

            <div class="col-xs-11 space">
            <asp:Label ID="lblMessage" runat="server" Text="" ></asp:Label>
            </div>

        </div>
   
    </form>

    

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    </body>
</html>

