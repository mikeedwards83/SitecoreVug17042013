<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopNavigationSublayout.ascx.cs" Inherits="Vug.layouts.Site.Misc.TopNavigationSublayout" %>
<div class="navbar">
  <div class="navbar-inner">
    <a class="brand" href="<%=Model.Url %>"><%=Model.Title %></a> <!-- Url, Title -->
    <ul class="nav">
        <!-- Children -->
        <% foreach (var item in Model.Children)
           {%>
                <li><a href="<%=item.Url %>"><%=item.Title %></a></li>
          <% } %>
    </ul>
  </div>
</div>