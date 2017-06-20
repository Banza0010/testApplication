<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="testApplication.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>testtt</title>

    <!-- Bootstrap -->
    <link href="js/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="js/css/Custom.css" rel="stylesheet"/>
     <link href="js/css/StyleSheet1.css" rel="stylesheet"/>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.1/css/font-awesome.min.css"/>

     <!-- Google Fonts -->
    <link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'/>
    <link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css'/>
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>

<body>

  <!--new GUI-->
       <div class="container">
        <div class="row main">
            <div class="panel-heading">
                <div class="panel-title text-center">
                    <h1 class="title">Enter details</h1>
                    <hr />
                </div>
            </div>
            <div class="main-login main-center">

                <form  id="form1" runat="server" class="form-horizontal">

                    <div class="form-group">    <!--username -->
                        <label class="cols-sm-2 control-label">Username</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon arrow"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                                <asp:TextBox ID="username" runat="server" class="form-control" placeholder="username"></asp:TextBox>
                            </div>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Username is required!" ControlToValidate="username" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>   
                    </div>

                    <div class="form-group">  <!--Password -->
                        <label  class="cols-sm-2 control-label">Password</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <asp:TextBox ID="password" runat="server" class="form-control" placeholder="password"></asp:TextBox>
                            </div>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Password is required!" Font-Bold="True" ControlToValidate="password" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">  <!--Confirm -->
                        <label class="cols-sm-2 control-label">Confirm Password</label>
                        <div class="cols-sm-10">
                            <div class="input-group">

                                <span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
                                <asp:TextBox ID="confirm" runat="server" class="form-control" placeholder="password"></asp:TextBox>
                                
                            </div>
                            <div>
                                <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Passwords do not match!" ControlToCompare="password" ControlToValidate="confirm" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <!--Name -->
                        <label  class="cols-sm-2 control-label">Name</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
                                <asp:TextBox ID="name" runat="server" class="form-control" placeholder="name"></asp:TextBox>
                                
                            </div>
                            <div>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Name is required!" ControlToValidate="name" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>


                    <div class="form-group">  <!--Email -->
                        <label  class="cols-sm-2 control-label">Email</label>
                        <div class="cols-sm-10">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-envelope fa" aria-hidden="true"></i></span>
                                <asp:TextBox ID="email" runat="server" class="form-control" placeholder="your-email"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Email address is required!" ControlToValidate="email" Font-Bold="True" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                               
                            </div>
                            <div>
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="incorrect email address!" ControlToValidate="email" Display="Dynamic" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                    </div>



                    <div class="form-group ">
                        <asp:Button ID="btnSignup" runat="server" class="btn btn-danger  btn-lg btn-block" Text="Sign up" OnClick="btnSignup_Click" />
                    </div>
                    <div class="col-xs-11 space">
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

                    </div>
                  <!--  <div class="login-register">
                        <a href="index.php">Login</a>
                    </div>-->

                </form>

            </div>
        </div>
    </div>

      

    

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    </body>
</html>

