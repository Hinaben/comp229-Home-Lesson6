<%@ Page Title="Departments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="comp229_Home_Lesson6.Department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div class="continer">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <asp:GridView ID="DepartmentGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-hover">
                    <Columns>
                        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" Visible="true" />
                        <asp:BoundField DataField="Name" HeaderText="Department Name" Visible="true" />
                        <asp:BoundField DataField="Budget" HeaderText="Budget" Visible="true" 
                            DataFormatString="{0:C3}"/>

                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
