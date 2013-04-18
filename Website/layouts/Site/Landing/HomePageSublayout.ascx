<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomePageSublayout.ascx.cs" Inherits="Vug.layouts.Site.Landing.HomePageSublayout" %>
<%@ Import Namespace="Vug.Models" %>


<div class="hero-unit">
    <h1><%=Editable(x=>x.Title) %></h1>
    <%=Model.MainBody %>
</div>
<div class="span6">
    <h3>News</h3>
    <ul class="thumbnails">
        <% foreach (var news in Model.News)
           { %>
        <li class="span3">
            <div class="thumbnail">
                <img src="<%=news.FeaturedImage.Src  %>" alt="<%=news.FeaturedImage.Alt %>">
                <h4>
                    <a href="<%=news.Url %>">
                        <%=news.Title %>
                    </a>
                </h4>
                <p><%=news.Abstract %></p>
            </div>
        </li>

        <% } %>
    </ul>
</div>
<div class="span6">
    <h3>Featured Events</h3>
    <ul class="thumbnails">
        <% foreach (var evt in Model.Events)
           { %>
        <li class="span3">
            <div class="thumbnail">
                <% if (evt is LargeEvent)
                   { %>
                    <p>Large Event!</p>
                <% } %>
                <% else if (evt is SmallEvent)
                   { %>
                    <p>Small Event!</p>
                <% } %>
                <h4>
                    <a href="<%=evt.Url %>">
                        <%=evt.Title %>
                    </a>
                </h4>
                <p><%=evt.Abstract %></p>
            </div>
        </li>

        <% } %>
    </ul>
</div>