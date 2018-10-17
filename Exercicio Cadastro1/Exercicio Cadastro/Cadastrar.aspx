<%@ Page Title="Pagina Inicial" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="Exercicio_Cadastro._Cadastrar" EnableEventValidation="false" EnableViewState="false"%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
  
    <div class="row" style="padding-bottom:2px">
        <div class="col-sm-1"><asp:RequiredFieldValidator runat="server" ControlToValidate="txtNome" ErrorMessage="Este campo é obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator><label id="label1">Nome:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtNome" runat="server" CssClass="col-sm-3" /> <asp:Label ID="lblMsgName" runat="server" ForeColor="Red" />
            &ensp;<asp:RegularExpressionValidator runat="server" ControlToValidate="txtNome" EnableClientScript="true" ValidationExpression="^[a-z,A-z,áéíóúàèìòùãõç',*\s]{3,30}$" ErrorMessage="Nome Incorreto" ForeColor="Red" />
        </div> 
    </div>
    <div class="row"style="padding-bottom:2px">
        <div class="col-sm-1"><asp:RequiredFieldValidator runat="server" ControlToValidate="txtIdade" ErrorMessage="Este campo é obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator><label id="idade">Idade:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtIdade" runat="server" CausesValidation="true" CssClass="col-sm-3"/> 
           &ensp;<asp:RangeValidator MinimumValue="0" MaximumValue="150" Type="Integer" ControlToValidate="txtIdade" runat="server" ErrorMessage="Insira uma idade valida" EnableClientScript="true" ForeColor="Red"></asp:RangeValidator>
            
            <asp:Label ID="lblMsgIdade" runat="server" ForeColor="Red"/></div>
    </div>
    <div class="row"style="padding-bottom:2px">
        <div class="col-sm-1"><asp:RequiredFieldValidator runat="server" ControlToValidate="txtSexo" ErrorMessage="Este campo é obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator><label id="sexo">Sexo:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtSexo" runat="server" CssClass="col-sm-3"/></div>
    </div>
    <div class="row"style="padding-bottom:2px">
        <div class="col-sm-1"><asp:RequiredFieldValidator runat="server" ControlToValidate="txtTel" ErrorMessage="Este campo é obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator><label id="telefone">Tel:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtTel" runat="server" CssClass="col-sm-3"/>&ensp;<asp:RegularExpressionValidator ControlToValidate="txtTel" ValidationExpression="^[0-9]{10}$" runat="server" ErrorMessage="Insira um telefone valido com o DDD!" EnableClientScript="true" ForeColor="Red"/></div>
    </div>
    <div class="row"style="padding-bottom:2px">
        <div class="col-sm-1"><label id="celular">Celular:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtCel" runat="server" CssClass="col-sm-3"/>&ensp;<asp:RegularExpressionValidator ControlToValidate="txtCel" ValidationExpression="^[0-9]{11}$" runat="server" ErrorMessage="Insira um celular valido com o DDD!" EnableClientScript="true" ForeColor="Red"/></div>
    </div>
    <div class="row"style="padding-bottom:2px">
        <div class="col-sm-1"><asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="Este campo é obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator><label id="email">E-mail:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtEmail" runat="server" CssClass="col-sm-3"/>&ensp;<asp:RegularExpressionValidator runat="server" ControlToValidate="txtEmail" EnableClientScript="true" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Insira um e-mail valido!" ForeColor="Red" /></div>
    </div>
    <div class="row"style="padding-bottom:2px">
        <div class="col-sm-1" ><label id="responsavel">Responsavel:</label></div>
        <div class="col-sm-11"><asp:TextBox ID="txtResp" runat="server" CssClass="col-sm-3"/>&ensp;<asp:CustomValidator runat="server" Display="Dynamic" ID="customValidator1" ForeColor="Red"   ClientValidationFunction="menorIdade"  ErrorMessage="">  
</asp:CustomValidator> </div>
    </div>
       <div class="row"><div class="col"><br /></div></div>
    <div class="row">
        <div class="col-sm-1"></div>
        <div class="col-sm-1"><asp:button runat="server" class="btn btn-success" type="submit" ID="btnCadastrar" OnClick="btnCadastrar_Click" CausesValidation="true" ValidateRequestMode="Disabled" Text="Cadastrar"/> </div>
        <div class="col-sm-1"><asp:button runat="server" class="btn btn-danger" type="LinkButton" id="btnCancelar" onclick="btnCancelar_Click" Text="Cancelar"/></div>
    </div>
       <div class="row">
           <div class="col">
               <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
           </div>
       </div>
        <script type="text/javascript">
            function menorIdade(sender, args) {
                if (document.getElementById("<%=txtIdade.ClientID %>").value < 18 && document.getElementById("<%=txtResp.ClientID %>").value == "") {
                    sender.innerHTML = "É necessário o preenchimento do Responsável!";
                    args.IsValid = false;
                } else {
                    args.IsValid = true;
                }
            }
            </script>

        <asp:ValidationSummary runat="server" HeaderText="Erros no Formulário:" ForeColor="red"/>
   
</div>
</asp:Content>
