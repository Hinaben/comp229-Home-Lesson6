<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="comp229_Home_Lesson6.Studnet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <div class="continer">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">

                <h1>Student List</h1>
                <a href="StudentDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus">Add Student</i>
                </a>
                <asp:GridView ID="StudentGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-hover" DataKeyNames="StudentID" OnRowDeleting="StudentGridView_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="StudentID" HeaderText="Student ID" Visible="true" />
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" Visible="true" />
                        <asp:BoundField DataField="FirstMidName" HeaderText="First Name" Visible="true" />
                        <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" Visible="true"
                            DataFormatString="{0:MMM dd, yyyy}" />
                        <asp:CommandField HeaderText="" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />

                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
