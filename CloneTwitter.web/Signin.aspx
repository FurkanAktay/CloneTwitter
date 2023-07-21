<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="CloneTwitter.web.Signin" %>


<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml>

<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <!-- title -->
    <title>Login to Twitter / Twitter</title>

    <!-- custom css link -->
    <link href="css/styleSignup.css" rel="stylesheet" />
    <!-- boxicons cdn link -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css">
    
</head>

<body>

    <div class="login__page">
        <form id="form3" runat="server">
        <div class="titles">

            <i class='bx bxl-twitter'></i>
            
            <h2>
                Sign in to Twitter
            </h2>
            
            <asp:Label CssClass="errorhandling" id="errortxtbox" runat="server" visible="false"/>  
            <br />

        </div>


        
        <div class="input">
            
            <asp:TextBox runat="server" id="peuname_txtbox" placeholder="Phone, email, or username"  />  
        </div>

        <div class="input">
            <asp:TextBox runat="server" id="password_txtbox" placeholder="Password" />  
        </div>
        

        <div class="button">
            <asp:Button id="Signin_btn" Text="Sign in" runat="server" OnClick="Signin_click"  CssClass="first" />

            <a href="LoginHome.aspx" class="sec" >Go Back</a>
        </div>
        </form>

        <span class="dont">
            Don't have an account?
            <a href="Signup.aspx" >Sign Up</a>
        </span>

    </div>

</body>

</html>

