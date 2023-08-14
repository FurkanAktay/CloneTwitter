<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="CloneTwitter.web.UserProfile" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Twitter Clone - User Page</title>
    <link href="cssx/styleProfile.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"
        integrity="sha512-iBBXm8fW90+nuLcSKlbmrPcLa0OT92xO1BIsZ+ywDWZCvqsWgccV3gFoRBv0z+8dLJgyAHIhR35VZc2oM/gI1w=="
        crossorigin="anonymous" />

</head>
<body>

    <!-- sidebar starts -->
    <div class="sidebar">
        <i class="fab fa-twitter"></i>

        <div class="post__avatar" id="prof_head" runat="server">
            <asp:Image ID="top_postavatar" runat="server" />
            <br />

            <asp:Label ID="top_postname" runat="server" Style="font-weight: bold; font-size: xx-large" />
            <asp:Label ID="top_postusername" runat="server" Style="font-size: x-large ;font-style:italic;font-weight:600" />


        </div>

        <div class="sidebarOption active">
            <span class="material-icons">home </span>
            <h2><a href="FlowHome.aspx" class="h2" style="text-decoration: none">Home</a></h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">search </span>
            <h2>Explore</h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">notifications_none </span>
            <h2>Notifications</h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">mail_outline </span>
            <h2><a href="ChatMessage.aspx" style="text-decoration:none">Messages</a></h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">bookmark_border </span>
            <h2>Bookmarks</h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">list_alt </span>
            <h2>Lists</h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">perm_identity </span>
            <h2>Profile</h2>
        </div>

        <div class="sidebarOption">
            <span class="material-icons">more_horiz </span>
            <h2><a href="LoginHome.aspx" style="text-decoration: none">Sign Out</a></h2>
        </div>
        <button class="sidebar__tweet">Tweet</button>
    </div>
    <!-- sidebar ends -->

    <!-- feed starts -->
    <div class="feed">
        <div class="feed__header">
            <h2>Profile</h2>
        </div>

        <!-- profilebox starts -->
        <asp:Repeater runat="server" ID="repeaterprofile">
            <ItemTemplate>
                <div class="tweetBox" id="profilebox">
                    <div class="tweetbox__input" style="background-image:url('<%#Eval("ProfileBgPic") %>')" >
                        <table>
                            <tr>
                                <td style="width: 20%; padding-right: 20px;">

                                    <asp:Image ImageUrl='<%#Eval("ProfilePic") %>' runat="server" Style="width: 150px; height: 150px;" class="profile_avatar" />

                                </td>
                                <td style="width: 75%;">
                                    <h1><%#Eval("Name")%></h1>
                                    <h3 style="font-weight:600;font-style:italic">@<%#Eval("UserName") %></h3>

                                </td>
                                <td style="width: 5%;"></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td style="width: 90%; max-width: 300px;">
                                    <asp:Label runat="server" Text='<%#Eval("ProfileBio")%>' />
                                </td>
                                <td cssclass="add_photo" style="width: 10%;"></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>



        <%--REPEATER ILE YAPILMIS POST START --%>
        <asp:Repeater ID="repeaterExample" runat="server">
            <ItemTemplate>
                <div>
                    <div class="post">
                        <table>

                            <tr>
                                <td style="width: 10%;">
                                    <div class="post__avatar" id="post_avatar" runat="server">
                                        <asp:Image ID="PostAvatar_img" type="text" ImageUrl='<%#Eval("User_Photo")%>' runat="server" />
                                    </div>
                                </td>
                                <td style="width: 80%">
                                    <div class="post__header">
                                        <div class="post__headerText">
                                            <asp:Label ID="PostHeader_lbl" runat="server"> 
                                                <h3><%#Eval("Name")%>
                                                    <span class="post__headerSpecial"><span class="material-icons post__badge">verified </span>@<%#Eval("UserName")%></span>
                                                </h3> 
                                            </asp:Label>

                                        </div>
                                    </div>
                                </td>
                                <td style="width: 10%"></td>

                            </tr>
                            <tr>
                                <td style="width: 10%;"></td>
                                <td style="width: 80%;">

                                    <div class="post__headerDescription">
                                        <asp:Label ID="PostContent_lbl" runat="server">
                                            <p class="post__content"><%#Eval("Post_Content") %></p>
                                            
                                        </asp:Label>

                                    </div>
                                </td>
                                <td style="width: 10%;"></td>

                            </tr>
                            <tr>
                                <td style="width: 10%;"></td>
                                <td style="width: 80%;" class="post__image">
                                    <div class="post__body">
                                        <asp:Image ID="PostContent_img" ImageUrl='<%#Eval("Post_imgcontent") %>' runat="server" />

                                    </div>
                                </td>
                                <td style="width: 10%;"></td>

                            </tr>
                            <tr>

                                <td style="width: 10%;"></td>
                                <td style="width: 80%;">
                                    <div class="post__footer">
                                        <%--<asp:LinkButton ID="repeat_postbtn" runat="server"> 
                                                <span class="material-icons">repeat </span>
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="fav_postbtn" runat="server"> 
                                                <span class="material-icons">favorite_border </span>
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="publish_postbtn" runat="server"> 
                                                <span class="material-icons">publish </span>
                                            </asp:LinkButton>        --%>
                                        <span class="material-icons">repeat </span>
                                        <span class="material-icons">favorite_border </span>
                                        <span class="material-icons">publish </span>

                                    </div>
                                </td>
                                <td style="width: 10%;"></td>

                            </tr>
                        </table>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <%--REPEATER ILE YAPILMIS POST END--%>





        <!-- post starts -->
        <div class="post">
            <div class="post__avatar">
                <img
                    src="https://i.pinimg.com/originals/a6/58/32/a65832155622ac173337874f02b218fb.png"
                    alt="" />
            </div>

            <div class="post__body">
                <div class="post__header">
                    <div class="post__headerText">
                        <h3>FURKAN AKTAY
                <span class="post__headerSpecial"><span class="material-icons post__badge">verified </span>@furkann</span>
                        </h3>
                    </div>
                    <div class="post__headerDescription">
                        <p>Bu bir test tweetidir.</p>
                    </div>
                </div>
                <img
                    src="https://www.focus2move.com/wp-content/uploads/2020/01/Tesla-Roadster-2020-1024-03.jpg"
                    alt="" />
                <div class="post__footer">
                    <%--                    <asp:LinkButton runat="server"> 
                                <span class="material-icons">repeat </span>
                        </asp:LinkButton>
                        <asp:LinkButton runat="server"> 
                                <span class="material-icons">favorite_border </span>
                        </asp:LinkButton>
                        <asp:LinkButton runat="server"> 
                                <span class="material-icons">publish </span>
                        </asp:LinkButton>--%>

                    <span class="material-icons">repeat </span>
                    <span class="material-icons">favorite_border </span>
                    <span class="material-icons">publish </span>

                </div>
            </div>
        </div>
        <!-- post ends -->

        <!-- post starts -->
        <div class="post">
            <div class="post__avatar">
                <img
                    src="https://i.pinimg.com/originals/a6/58/32/a65832155622ac173337874f02b218fb.png"
                    alt="" />
            </div>

            <div class="post__body">
                <div class="post__header">
                    <div class="post__headerText">
                        <h3>Somanath Goudar
                <span class="post__headerSpecial"><span class="material-icons post__badge">verified </span>@somanathg</span>
                        </h3>
                    </div>
                    <div class="post__headerDescription">
                        <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit.</p>
                    </div>
                </div>
                <img
                    src="https://www.focus2move.com/wp-content/uploads/2020/01/Tesla-Roadster-2020-1024-03.jpg"
                    alt="" />
                <div class="post__footer">
                    <span class="material-icons">repeat </span>
                    <span class="material-icons">favorite_border </span>
                    <span class="material-icons">publish </span>
                </div>
            </div>
        </div>
        <!-- post ends -->
    </div>
    <!-- feed ends -->

    <!-- widgets starts -->
    <div class="widgets">
        <div class="widgets__input">
            <span class="material-icons widgets__searchIcon">search </span>
            <input type="text" placeholder="Search Twitter" />
        </div>

        <%--widget twitter--%>
        <%--<div runat="server" id="WidgetContanier" class="widgets__widgetContainer">
            <h2>What's happening?</h2>
            <blockquote class="twitter-tweet">
                <p lang="en" dir="ltr">
                    Sunsets don&#39;t get much better than this one over
            <a href="https://twitter.com/GrandTetonNPS?ref_src=twsrc%5Etfw">@GrandTetonNPS</a>.
            <a href="https://twitter.com/hashtag/nature?src=hash&amp;ref_src=twsrc%5Etfw">#nature</a>
                    <a href="https://twitter.com/hashtag/sunset?src=hash&amp;ref_src=twsrc%5Etfw">#sunset</a>
                    <a href="http://t.co/YuKy2rcjyU">pic.twitter.com/YuKy2rcjyU</a>
                </p>
                &mdash; US Department of the Interior (@Interior)
          <a href="https://twitter.com/Interior/status/463440424141459456?ref_src=twsrc%5Etfw">May 5, 2014</a>
            </blockquote>
            <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>
        </div>--%>

        <%--add photo--%>
        <div runat="server" class="widgets__widgetContainer" id="ProfContainer">
            <button id="image_button" class="profileBox__imageButton">
                <span class="material-symbols-outlined">settings_account_box</span>
            </button>
            <div class="widgets__profSettings">
                <form runat="server">

                    <h2>Enter your new profile photo url: </h2>

                    <asp:TextBox runat="server" CssClass="newPpUrl" type="Text" ID="profPhotoUrl_txtbox" PlaceHolder="Enter your new profile photo url here." />

                    <h2>Enter your new background photo url: </h2>

                    <asp:TextBox runat="server" CssClass="newbgPhotoUrl" type="Text" ID="bgPhotoUrl_txtbox" PlaceHolder="Enter your new background photo url here." />

                    <h2>Enter your new biography text: </h2>

                    <asp:TextBox runat="server" CssClass="newbgText" type="Text" ID="bgText_txtbox" PlaceHolder="Enter your new biography text here." />

                    <table>
                        <tr>
                            <td style="width: 50%;"></td>
                            <td style="width: 50%;">
                                <asp:Button runat="server" Text="Save" CssClass="savebtn" OnClick="Savebtn_Click" />
                            </td>
                        </tr>

                    </table>
                </form>
            </div>



            <%--<blockquote class="twitter-tweet">
                <p lang="en" dir="ltr">
                    Sunsets don&#39;t get much better than this one over
            <a href="https://twitter.com/GrandTetonNPS?ref_src=twsrc%5Etfw">@GrandTetonNPS</a>.
            <a href="https://twitter.com/hashtag/nature?src=hash&amp;ref_src=twsrc%5Etfw">#nature</a>
                    <a href="https://twitter.com/hashtag/sunset?src=hash&amp;ref_src=twsrc%5Etfw">#sunset</a>
                    <a href="http://t.co/YuKy2rcjyU">pic.twitter.com/YuKy2rcjyU</a>
                </p>
                &mdash; US Department of the Interior (@Interior)
          <a href="https://twitter.com/Interior/status/463440424141459456?ref_src=twsrc%5Etfw">May 5, 2014</a>
            </blockquote>
            <script async src="https://platform.twitter.com/widgets.js" charset="utf-8"></script>--%>
        </div>
    </div>
    <!-- widgets ends -->


</body>
</html>
