<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexPrincipal.aspx.cs" Inherits="FleetWeb.indexPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Fleet Management</title>
</head>
<body>
    <!--  carousel  -->
    <div class="col-md-12" id="slides">
        <div class="row">

            <div id="meuCarousel" class="carousel slide " data-ride="carousel">

                <ol class="carousel-indicators">
                    <li data-target="#meuCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#meuCarousel" data-slide-to="1"></li>
                    <li data-target="#meuCarousel" data-slide-to="2"></li>
                </ol>

                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img class="d-block w-100 img-fluid" src="https://i.stack.imgur.com/YNHbD.png" alt="primeiro slide"/>
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100 img-fluid" src="https://i.stack.imgur.com/YNHbD.png" alt="segundo slide"/>
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100 img-fluid" src="https://i.stack.imgur.com/YNHbD.png" alt="terceiro slide"/>
                    </div>
                </div>

            </div>

        </div>
    </div>
</body>
</html>
