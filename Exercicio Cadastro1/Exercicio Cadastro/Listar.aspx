<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Listar.aspx.cs" Inherits="Exercicio_Cadastro._Listar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
                <div class="col-sm-8"><asp:button runat="server" CssClass="btn btn-info" ID="btnListar" OnClick="btnListar_Click" Text="Listar Pacientes"/><br /><br /></div>
                <div class="col-cm-4">
                    Insira o ID do Paciente: <asp:TextBox ID="txtId" runat="server" Width="50px" Height="23px" />&#09<asp:Button runat="server" CssClass="btn" ID="btnPesquisa" OnClick="btnPesquisa_Click" Text="Pesquisar" />
                    <br /><asp:Label ID="lblMsgPesquisa" runat="server" ForeColor="Red"/>
                </div>
            <div class="row">
                <asp:GridView ID="grdPaciente" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" AllowPaging="true" EnableModelValidation="true"
                DataKeyNames="IdPaciente" OnPageIndexChanging="grdPaciente_PageIndexChanging" 
                OnRowCancelingEdit="grdPaciente_RowCancelingEdit" OnRowDeleting="grdPaciente_RowDeleting" 
                OnRowEditing="grdPaciente_RowEditing" OnRowUpdating="grdPaciente_RowUpdating">
            <Columns>
            <asp:BoundField DataField="IdPaciente" HeaderText="ID" HeaderStyle-BackColor="#5BC0DE" ReadOnly="true"/>
            <asp:BoundField DataField="NomePaciente" HeaderText="Nome" HeaderStyle-BackColor="#5BC0DE" />
            <asp:BoundField DataField="IdadePaciente" HeaderText="Idade" DataFormatString="{0: 00 Anos}" HeaderStyle-BackColor="#5BC0DE" />
            <asp:BoundField DataField="SexoPaciente" HeaderText="Sexo" HeaderStyle-BackColor="#5BC0DE" />
            <asp:BoundField DataField="TelefonePaciente" HeaderText="Telefone" HeaderStyle-BackColor="#5BC0DE" />
            <asp:BoundField DataField="CelularPaciente" HeaderText="Celular" HeaderStyle-BackColor="#5BC0DE" />
            <asp:BoundField DataField="EmailPaciente" HeaderText="Email" HeaderStyle-BackColor="#5BC0DE"/>
            <asp:BoundField DataField="RespPaciente" HeaderText="Responsavel" HeaderStyle-BackColor="#5BC0DE"/>
            <asp:CommandField HeaderText="Ações" HeaderStyle-BackColor="#5BC0DE" ShowEditButton="true" ShowDeleteButton="true" DeleteText="Deletar" EditText="Editar" ButtonType="Image" EditImageUrl="img/edit.png" DeleteImageUrl="img/delete.png" CancelImageUrl="img/cancel.png" UpdateImageUrl="img/update.png"/>
            </Columns>
            <PagerSettings Position="Bottom" Mode="NextPreviousFirstLast" Visible="true" 
            FirstPageImageUrl="img/seta-esquerda-ultima.png" 
            PreviousPageImageUrl="img/seta-esquerda.png" 
            NextPageImageUrl="img/seta-direita.png" 
            LastPageImageUrl="img/seta-direita-ultima.png"/>
            </asp:GridView>
                </div>
            </div>
</asp:Content>
