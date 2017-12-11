<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html lang="pt-BR">
    <!-- HEAD -->
    <head>
        <meta charset="utf-8">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="${applicationName}">
        <meta name="author" content="Anderson Iago Merten">

        <link rel="icon" href="assets/icons/qb-icon.png">
        <title>${applicationName} -  ${tittle}</title>

        <!-- Bootstrap -->
        <link href="assets/core/bootstrap-3.3.5-dist/css/bootstrap.min.css" rel="stylesheet">
        <link href="assets/core/bootstrap-3.3.5-dist/css/bootstrap-theme.min.css" rel="stylesheet">
        <!-- Custom styles for this template -->
    </head><!-- /HEAD -->
    <body>
        <!-- MAIN CONTAINER -->   
        
        <nav class="navbar navbar-default">
            <div class="container-fluid">
              <div class="navbar-header">
                <a class="navbar-brand" href="#">VirtualShop</a>
              </div>
              <ul class="nav navbar-nav">
                <li><a href="mvccustomer?do=lstmodel">Clientes</a></li>
                <li><a href="#">Produtos</a></li>
                <li><a href="#">Transportadoras</a></li>
                <li><a href="#">Pedidos</a></li>
              </ul>
            </div>
        </nav>
        <div id="main" class="container-fluid"> 

            <!-- SIMPLE MENU BAR -->            
            <div class="row">
                <div class="col-md-12">
                    <jsp:include page="../includes/HeaderMenuInclude.jsp" />
                </div>
            </div>
            <!-- /SIMPLE MENU BAR -->        

            <BR>User: ${userName}<BR><BR>

            <div class="row">
                <div class="form-group col-md-12">
                    <label for="comboMenu">Opções:</label>  
                    <select id="comboMenu" name="comboMenu" size="1">
                        <option value="#">Selecione uma Opção...</option>
                        <c:forEach var="o" items="${datasource}">
                            <option value="${o.url}">${o.name}</option>
                        </c:forEach>            
                    </select>  
                </div>
                <div class="col-md-12">
                    <BR><BR><a href="logout">Sair</a>
                </div>

            </div>  
            
            
        </div><!-- /MAIN CONTAINER --> 

        <!-- JQUERY -->                    
        <script src="assets/js/jquery.min.js"></script>
        <!-- /JQUERY --> 

        <script type="text/javascript">

            $(document).ready(function () {

                $("#comboMenu").change(
                        function () {
                            //alert($("#comboMenu").val());                        
                            $(location).attr('href', $("#comboMenu").val());
                        }
                );

            });

        </script>

    </body>
</html>
