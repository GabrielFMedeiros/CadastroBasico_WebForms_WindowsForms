<%@ Page Title="Pagina Inicial" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercicio_Cadastro._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div class="container-fluid">
    <div class="jumbotron">
        <div class="row">
            <center>Bem vindo
        <div class="col">
           <span>
                Pagina destinada a cadastro e validaçãoes simples.   
            </span>
        </div></center>
        </div>
        <div class="row">
            <div class="col-sm-1"></div>
            <div class="col-sm-5">
                <span>Caso dejese realizar um cadastro de um novo paciente
                    clique no botão abaixo para que seja redirecionado a
                    pagina de cadastramento.<br /><br />
                    <a href="Cadastrar.aspx" class="btn btn-warning" role="button">Cadastrar Paciente &raquo;</a>
                </span>
            </div>
            <div class="col-sm-5">
                <span>Caso deseje verificar a listagem de cadastros de
                    pacientes, clique no botão abaixo para que seja redirecionado
                    a pagina de listagem de cadastros.<br /><br />
               <a href="Listar.aspx" class="btn btn-info" role="button">Listar Paciente &raquo;</a></span>
            </div>
            <div class="col-sm-1"></div>
        </div>
    </div>
</div>

</asp:Content>
