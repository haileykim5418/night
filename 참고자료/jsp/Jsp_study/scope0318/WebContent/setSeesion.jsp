<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
<%
session.setAttribute("ID","hack4ork");
session.setAttribute("NAME","홍길동");
%>
    
    
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>session 정보 저장</h1>
	<%
		String id = (String)session.getAttribute("ID");
		String name = (String)session.getAttribute("NAME");
	%>
	<h1>
	<br>
	아이디: <%=id %><br>
	이름: <%=name %><br>
	</h1>
</body>
</html>