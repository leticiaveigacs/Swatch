<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Site_Projeto.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

        <link href="css/estilos.css" rel="stylesheet" />



    <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <meta name="description" content="">
        <meta name="author" content="">

      <title>Barista Cafe HTML CSS Template</title>

        <!-- CSS FILES -->                
        <link rel="preconnect" href="https://fonts.googleapis.com">
        
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>

        <link href="https://fonts.googleapis.com/css2?family=Plus+Jakarta+Sans:ital,wght@0,200;0,400;0,600;0,700;1,200;1,700&display=swap" rel="stylesheet">
            
        <link href="css/bootstrap.min.css" rel="stylesheet">

        <link href="css/bootstrap-icons.css" rel="stylesheet">

        <link href="css/vegas.min.css" rel="stylesheet">

        <link href="css/tooplate-barista.css" rel="stylesheet">
        
        
<!--

Tooplate 2137 Barista Cafe

https://www.tooplate.com/view/2137-barista-cafe

Bootstrap 5 HTML CSS Template

-->

</head>
<body>
    <form id="form1" runat="server">
       


         <main>
                <nav class="navbar navbar-expand-lg">                
                    <div class="container">
                        <a class="navbar-brand d-flex align-items-center" href="index.html">
                            <img src="images/coffee-beans.png" class="navbar-brand-image img-fluid" alt="Barista Cafe Template">
                            Barista
                        </a>
        
                        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"></span>
                        </button>
        
                        <div class="collapse navbar-collapse" id="navbarNav">
                            <ul class="navbar-nav ms-lg-auto">
                                <li class="nav-item">
                                    <a class="nav-link click-scroll" href="#section_1">Home</a>
                                </li>
        
                                <li class="nav-item">
                                    <a class="nav-link click-scroll" href="#section_2">About</a>
                                </li>

                                <li class="nav-item">
                                    <a class="nav-link click-scroll" href="#section_3">Our Menu</a>
                                </li>

                                <li class="nav-item">
                                    <a class="nav-link click-scroll" href="#section_4">Reviews</a>
                                </li>

                                <li class="nav-item">
                                    <a class="nav-link click-scroll" href="#section_5">Contact</a>
                                </li>
                            </ul>

                        <!--    <div class="ms-lg-3">
                                <a class="btn custom-btn custom-border-btn" href="reservation.html">
                                    Reservation
                                    <i class="bi-arrow-up-right ms-2"></i>
                                </a>
                            </div> -->
                        </div>
                    </div>
                </nav>

          


              <section class="hero-section d-flex justify-content-center align-items-center" id="section_1">

                    <div class="container">
                        <div class="row align-items-center">

                            <div class="col-lg-6 col-12 mx-auto">
                                <em class="small-text">welcome to Barista.co</em>
                                
                                <h1>Cafe Klang</h1>

                                <p class="text-white mb-4 pb-lg-2">
                                    your <em>favourite</em> coffee daily lives.
                                </p>

                                <a class="btn custom-btn custom-border-btn smoothscroll me-3" href="#section_2">
                                    Our Story
                                </a>

                                <a class="btn custom-btn smoothscroll me-2 mb-2" href="#section_3"><strong>Check Menu</strong></a>
                            </div>

                        </div>
                    </div>

                    <div class="hero-slides"></div>
                </section>


                 


                <section class="contact-section section-padding" id="section_5">
                    <div class="container">
                        <div class="row">   

                            <div class="col-lg-12 col-12">
                                <em class="text-white">Say Hello</em>
                                <h2 class="text-white mb-4 pb-lg-2">Login</h2>
                            </div>

                            <div class="col-lg-6 col-12">
                                <div action="#" method="post" class="custom-form contact-form" role="form">

                                <div class="row">
                                    
                                    <div class="col-lg-6 col-12">
                                        <label for="name" class="form-label">Usuário <sup class="text-danger"></sup></label>

                                      <!--     <input type="text" name="name" id="name" class="form-control" placeholder="Jackson" >
                                    </div>-->
                                    
       

                                    <asp:TextBox ID="tb_nome" runat="server" class="form-control" placeholder="Insira Nome" heithg="10px" width="300px" ></asp:TextBox>


                                    <div class="col-lg-6 col-12">
                                        <label for="email" class="form-label">Email </label>

                                       <!--  <input type="email" name="email" id="email" pattern="[^ @]*@[^ @]*" class="form-control" placeholder="Jack@gmail.com">
                                    </div> -->
                                        
                                        <asp:TextBox ID="tb_email" runat="server" pattern="[^ @]*@[^ @]*" class="form-control" placeholder="nome@mail.com"  heithg="10px" width="300px" ></asp:TextBox>


                                    <div class="col-12">
                                        <label for="message" class="form-label">Mensagem:</label>

                                        <!-- <textarea name="message" rows="4" class="form-control" id="message" placeholder="Message"></textarea>  -->

                                        <asp:TextBox ID="tb_mensagem" runat="server" TextMode="MultiLine" class="form-control" placeholder="Insaira Menssagem"  heithg="10px" width="300px" ></asp:TextBox>
                                        
                                    </div>
                                </div>

                                <div class="col-lg-5 col-12 mx-auto mt-3">
                                     <!--  <button type="submit" class="form-control">Send Message</button>  -->

                                    <asp:Button ID="Button1" runat="server" Text="Enviar" class="btn custom-btn smoothscroll me-2 mb-2" heithg="50px" width="180px"/>

                                </div>
                                </div>
                            </div>

                            <div class="col-lg-6 col-12 mx-auto mt-5 mt-lg-0 ps-lg-5">
                                <iframe class="google-map" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5039.668141741662!2d72.81814769288509!3d19.043340656729775!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3be7c994f34a7355%3A0x2680d63a6f7e33c2!2sLover%20Point!5e1!3m2!1sen!2sth!4v1692722771770!5m2!1sen!2sth" width="100%" height="300" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>  
                            </div>

                        </div>
                    </div>
                </section>


                <footer class="site-footer">
                    <div class="container">
                        <div class="row">

                            <div class="col-lg-4 col-12 me-auto">
                                <em class="text-white d-block mb-4">Where to find us?</em>

                                <strong class="text-white">
                                    <i class="bi-geo-alt me-2"></i>
                                    Bandra West, Mumbai, Maharashtra 400050, India
                                </strong>

                                <ul class="social-icon mt-4">
                                    <li class="social-icon-item">
                                        <a href="#" class="social-icon-link bi-facebook">
                                        </a>
                                    </li>
        
                                    <li class="social-icon-item">
                                        <a href="https://x.com/minthu" target="_new" class="social-icon-link bi-twitter">
                                        </a>
                                    </li>

                                    <li class="social-icon-item">
                                        <a href="#" class="social-icon-link bi-whatsapp">
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>

                            <div class="col-lg-3 col-12 mt-4 mb-3 mt-lg-0 mb-lg-0">
                                <em class="text-white d-block mb-4">Contact</em>

                                <p class="d-flex mb-1">
                                    <strong class="me-2">Phone:</strong>
                                    <a href="tel: 305-240-9671" class="site-footer-link">
                                        (65) 
                                        305 2409 671
                                    </a>
                                </p>

                                <p class="d-flex">
                                    <strong class="me-2">Email:</strong>

                                    <a href="mailto:info@yourgmail.com" class="site-footer-link">
                                        hello@barista.co
                                    </a>
                                </p>
                            </div>


                            <div class="col-lg-5 col-12">
                                <em class="text-white d-block mb-4">Opening Hours.</em>

                                <ul class="opening-hours-list">
                                    <li class="d-flex">
                                        Monday - Friday
                                        <span class="underline"></span>

                                        <strong>9:00 - 18:00</strong>
                                    </li>

                                    <li class="d-flex">
                                        Saturday
                                        <span class="underline"></span>

                                        <strong>11:00 - 16:30</strong>
                                    </li>

                                    <li class="d-flex">
                                        Sunday
                                        <span class="underline"></span>

                                        <strong>Closed</strong>
                                    </li>
                                </ul>
                            </div>

                            <div class="col-lg-8 col-12 mt-4">
                                <p class="copyright-text mb-0">Copyright © Barista Cafe 2048 
                                    - Design: <a rel="sponsored" href="https://www.tooplate.com" target="_blank">Tooplate</a></p>
                            </div>
                    </div>
                </footer>
            </main>

        <!-- JAVASCRIPT FILES -->
        <script src="js/jquery.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/jquery.sticky.js"></script>
        <script src="js/click-scroll.js"></script>
        <script src="js/vegas.min.js"></script>
        <script src="js/custom.js"></script>


     <!--     required=""  -->

  



        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="utilizador" HeaderText="utilizador" SortExpression="utilizador" />
                <asp:BoundField DataField="palavra_passe" HeaderText="palavra_passe" SortExpression="palavra_passe" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:swatchConnectionString %>" SelectCommand="SELECT * FROM [utilizadores]"></asp:SqlDataSource>
    </form>
</body>
</html>
