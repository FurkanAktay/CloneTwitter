<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlowHome.aspx.cs" Inherits="CloneTwitter.web.FlowHome" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Twitter Clone - Final</title>
    <link href="cssx/styleFlow.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link
        rel="stylesheet"
        href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"
        integrity="sha512-iBBXm8fW90+nuLcSKlbmrPcLa0OT92xO1BIsZ+ywDWZCvqsWgccV3gFoRBv0z+8dLJgyAHIhR35VZc2oM/gI1w=="
        crossorigin="anonymous" />


    <script>

        function HomeRefresh() {
            location.reload();
        }


    </script>

</head>
<body>
    <%--<form runat="server">--%>
    <!-- sidebar starts -->
    <asp:Panel ID="sidebarpnl" CssClass="sidebar" runat="server" Width="100px">
        <div class="sidebar">
            <i class="fab fa-twitter"></i>
            <div class="post__avatar">
                <%--<asp:img id="top_postavatar" runat="server"
                src="")"
                alt="" />--%>
                <asp:Image ID="top_postavatar" runat="server" />
                <br />
                <asp:Label ID="top_postname" runat="server" Style="font-weight: bold; font-size: xx-large" />
                <asp:Label ID="top_postusername" runat="server" Style="font-size: x-large" />

            </div>


            <div class="sidebarOption active">
                <span class="material-icons">home </span>
                <h2><a href="FlowHome.aspx" class="h2" style="text-decoration: none" onclick="HomeRefresh()">Home</a></h2>
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
                <h2><a href="UserProfile.aspx" style="text-decoration: none">Profile</a></h2>
            </div>

            <div class="sidebarOption">
                <span class="material-icons">more_horiz </span>
                <h2><a href="LoginHome.aspx" style="text-decoration: none">Sign Out</a></h2>
            </div>
            <button class="sidebar__tweet">Tweet</button>
        </div>
    </asp:Panel>
    <!-- sidebar ends -->

    <!-- feed starts -->
    <asp:Panel ID="Panel1" CssClass="feed" runat="server" Width="100px">
        <div id="akis" class="feed" runat="server">
            <div class="feed__header">
                <h2>Home</h2>
            </div>

            <!-- tweetbox starts -->
            <div class="tweetBox">
                <form runat="server">
                    <div class="tweetbox__input">
                        <asp:Image ID="tweetbox_image" runat="server" />
                        <asp:TextBox runat="server" type="text" ID="PostContent_txtbox" placeholder="What's happening?" />
                    </div>

                    <table>
                        <tr>
                            <td style="width: 10%;">
                                <asp:LinkButton ID="attach_button" class="tweetBox__attachButton" runat="server" OnClick="btnAttach_Click">
                                <span class="material-symbols-outlined">attach_file</span>
                                </asp:LinkButton>
                            </td>
                            <td style="width: 80%;">
                                <asp:TextBox ID="attachlink_txt" class="tweetbox__attachLink" PlaceHolder="Write your media link here." runat="server" />
                            </td>
                            <td style="width: 10%;">
                                <asp:Button class="tweetBox__tweetButton" ID="btnSharePost" runat="server" Text="Tweet" OnClick="btnSharePost_Click" />
                            </td>
                        </tr>
                    </table>
                </form>
            </div>
            <!-- tweetbox ends -->

            <%--REPEATER ILE YAPILMIS POST START --%>
            <asp:Repeater ID="repeaterExample" runat="server">
                <ItemTemplate>
                    <div>
                        <div class="post">
                            <table>

                                <tr>
                                    <td style="width: 10%;">
                                        <div class="post__avatar">
                                            <asp:Image ID="PostAvatar_img" type="text" ImageUrl='<%#Eval("User_Photo")%>' runat="server" />

                                        </div>
                                    </td>
                                    <td style="width: 80%">
                                        <div class="post__header">
                                            <div class="post__headerText">
                                                <asp:Label ID="PostHeader_lbl" runat="server"> 
                                                <h3>  <%--<%#Eval("Name")%>--%>
                                                    <span class="post__headerSpecial"><span class="material-icons post__badge">verified </span>@furkann</span>
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
                                            </asp:LinkButton>--%>


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
                        <%--<asp:LinkButton runat="server"> 
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


        </div>
    </asp:Panel>
    <!-- feed ends -->

    <!-- widgets starts -->
    <asp:Panel ID="widgetspnl" CssClass="widgets" runat="server" Width="100px">
        <div class="widgets">
            <div class="widgets__input">
                <span class="material-icons widgets__searchIcon">search </span>
                <input type="text" placeholder="Search Twitter" />
            </div>

            <div class="widgets__widgetContainer">
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
            </div>


            <%--<table>
            <tr>
                <th>Name</th>
                <th>Age</th>
            </tr>
            @foreach (DataRow row in dataaTable.Rows)
        {
    <tr>
        <td>@row["Name"]</td>
        <td>@row["Age"]</td>
    </tr>
            }
        </table>--%>

            <%--<div id="gridview">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" EnableClientScript="False"></asp:GridView>
    </div>--%>

            <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
        </Columns>
        </asp:GridView>--%>
        </div>
    </asp:Panel>
    <!-- widgets ends -->

    <%--    </form>--%>
</body>
</html>
