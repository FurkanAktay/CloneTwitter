<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatMessage.aspx.cs" Inherits="CloneTwitter.web.ChatMessage" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Twitter Clone - Final</title>
    <link href="cssx/StyleChatMessage.css" rel="stylesheet" />
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
                <h2>Messages</h2>
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
    <!-- sidebar ends -->

    <!-- feed starts -->
        <div id="akis" class="feed" runat="server">
            <div class="feed__header">
                <h2>Messages</h2>
            </div>

            <!-- tweetbox starts -->
            <div class="tweetBox">
                
            </div>
            <!-- tweetbox ends -->

            <asp:Panel runat="server">
                <h4>Mesajlar buraya gelecek</h4>
            </asp:Panel>


        </div>
    <!-- feed ends -->

    <!-- widgets starts -->
        <div class="widgets">
            <div class="widgets__input">
                <span class="material-icons widgets__searchIcon">search </span>
                <input type="text" placeholder="Search Twitter" />
            </div>

            <form runat="server">

                <h4>Önceki konuşmalar buraya gelecek</h4>
                <asp:GridView runat="server">
                    

                </asp:GridView>

            </form>





            <%--<div class="widgets__widgetContainer">
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


        </div>
    <!-- widgets ends -->

    <%--    </form>--%>
</body>
</html>
