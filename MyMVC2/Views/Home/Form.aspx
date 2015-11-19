<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MyMVC2.Models.SubmitDataModel>" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    FormTest
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Form</h2>
    <p>
        Submit Data Here
    </p>
    <hr />
    <%= ViewData["FormData"]  %>
    <hr />
    <% using(Html.BeginForm("Form", "Home")) %>
    <% { %>
        <%= Html.TextArea("FormData") %>
        <br />
        <input type="submit" value="Submit" />
    <% } %>
    
    
</asp:Content>
