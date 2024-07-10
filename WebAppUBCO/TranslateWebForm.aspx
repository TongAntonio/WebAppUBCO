<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TranslateWebForm.aspx.cs" Inherits="WebAppUBCO.TranslateWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
     <div>
         <asp:TextBox runat="server" ID="txtUBCO" TextMode="Search" CssClass="form-control" />


          <asp:Button runat="server"  Text="Translate" ID="Translate" CssClass="btn btn-default" OnClick="Translate_Click"  />
         <br />
          <br />
          <asp:Label runat="server" ID="lblTranslate" CssClass="col-md-2 control-label"/>
     </div>
 </form>
</body>
</html>
