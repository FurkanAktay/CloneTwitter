<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="CloneTwitter.web.Signup" %>


<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>

    <!-- title -->
    <title>Signup to Twitter / Twitter</title>

    <!-- custom css link -->
    <link href="css/styleSignup.css" rel="stylesheet" />
    <!-- boxicons cdn link -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/boxicons@latest/css/boxicons.min.css"/>

</head>

<body>

    <div class="login__page">
        <form id="form2" runat="server">
        <div class="titles">

            <i class='bx bxl-twitter'></i>
            
            <h2>
                Create your account
            </h2>
            
            <asp:Label CssClass="errorhandling" id="errortxtbox" runat="server" visible="false"/>  
            <br />
            
            
        </div>
        

        
        <div class="input">
            <asp:TextBox id="name_txtbox" placeholder="Name (*)" runat="server" />  
        </div>
        <div class="input">
            <asp:TextBox id="phone_txtbox" placeholder="Phone (*)" runat="server" /> 
        </div>
        <div class="input">
            <asp:TextBox id="email_txtbox" placeholder="Email" runat="server" /> 
        </div>
        <div class="input">
            <asp:TextBox id="username_txtbox" placeholder="User Name (*)" runat="server" /> 
        </div>

        <div class="input">
            <asp:TextBox id="password_txtbox" placeholder="Password (*)" runat="server" /> 
            
        </div>

        <div class="button">
            <asp:Button id="Signup_btn" Text="Sign Up" runat="server" OnClick="Signup_click"  CssClass="first"/>

            <a href="LoginHome.aspx" class="sec" >Go Back</a>
        </div>
        </form>
            


    </div>

</body>



</html>
