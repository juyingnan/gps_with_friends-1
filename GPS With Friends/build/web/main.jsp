<%-- 0
    Document   : main
    Created on : Jun 2, 2013, 11:54:16 AM
    Author     : ahmad
--%>

<%-- 
    Document   : index
    Created on : May 18, 2013, 12:16:51 PM
    Author     : ahmad
--%>

<%@page import="edu.uoregon.cs.client.Location"%>
<%@page import="java.lang.Long"%>
<%@page import="java.util.ArrayList"%>
<%@page import="java.util.List"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
       
    </head>
    <body>
    

    <%-- start web service invocation --%><hr/>
    <%
        java.util.List<edu.uoregon.cs.client.Group> result = new java.util.ArrayList<edu.uoregon.cs.client.Group> () ;
    try {
	edu.uoregon.cs.client.GPSwfriends_Service service = new edu.uoregon.cs.client.GPSwfriends_Service();
        out.println("error before uid");
	edu.uoregon.cs.client.GPSwfriends port = service.getGPSwfriendsPort();
	 // TODO initialize WS operation arguments here
	int uid = Integer.parseInt(request.getParameter("uid"));
	// TODO process result here
	result = port.getGroups(uid);
        
        out.println("my uid is " + uid + " and my result's name is " + result.get(0).getName());
        
    } catch (Exception ex) {
	
        out.println(ex.getMessage());
    }
    %>
    
    <form action="group.jsp" method="POST">
        <select name="glist">
    <%
    
    for (int i = 0;i<result.size();i++)
    {
        edu.uoregon.cs.client.Group g = result.get(i);
        out.println("<option value='" + g.getGid() + "'> "+ g.getName() + "</option>");
    }
    
    %>
        </select>
    <input type="submit" value=" show list" />

    
    <%-- end web service invocation --%><hr/>
    </form>
    
    
    
    </body>
</html>
