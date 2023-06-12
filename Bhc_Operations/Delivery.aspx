<%@ Page Title="" Language="C#" MasterPageFile="~/Bhc_Operations.Master" AutoEventWireup="true" CodeBehind="Delivery.aspx.cs" Inherits="Bhc_Operations.Delivery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row">
        <div class="col-12">
            <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                <h4 class="mb-sm-0">Delivery</h4>
                <div class="page-title-right">
                    <ol class="breadcrumb m-0">
                        <li class="breadcrumb-item"><a href="javascript: void(0);">Home</a></li>
                        <li class="breadcrumb-item active">Delivery</li>
                    </ol>
                </div>
            </div>
        </div>
    </div>
    <%-- end breadcrumb --%>
     <asp:HiddenField ID="txtEventID" runat="server" />
        <asp:HiddenField ID="txtQueryID" runat="server" />
        <asp:HiddenField ID="txtMemberID" runat="server" />

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="firstNameinput" class="form-label">Sower ID</label>
                <asp:TextBox ID="txtSowerID" placeholder="Sower ID" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <!--end col-->
        <div class="col-6">
            <div class="mb-3">
                <label for="lastNameinput" class="form-label">Bale ID</label>
                <asp:TextBox ID="txtBaleID" placeholder="Last Name" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <!--end col-->
        <div class="col-12">
            <div class="mb-3">
                <label for="compnayNameinput" class="form-label">Company Name</label>
                <asp:TextBox ID="txtCompany" placeholder="Company Name" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <!--end col-->
        <div class="col-6">
            <div class="mb-3">
                <label for="phonenumberInput" class="form-label">Phone Number</label>
                <asp:TextBox ID="txtPhoneNumber" placeholder="236 776 339 832" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <!--end col-->
        <div class="col-6">
            <div class="mb-3">
                <label for="emailidInput" class="form-label">Email Address</label>
                <asp:TextBox ID="txtEmail" placeholder="example@gamil.com" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
            </div>
        </div>
        <!--end col-->

        <div class="col-6">
            <div class="mb-3">
                <label for="pensionFund" class="form-label">Pension Fund</label>
                <asp:TextBox ID="txtPensionFund" placeholder="Comarton Umbrella" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <!--end col-->
        <div class="col-6">
            <div class="mb-3">
                <label for="ForminputState" class="form-label">Designation </label>
                <asp:DropDownList runat="server" ID="txtDesignation" CssClass="form-control dropdown">
                    <asp:ListItem Text="Principal Officer" />
                    <asp:ListItem Text="Fund Administrator" />
                    <asp:ListItem Text="Personal Assistant to the PO" />
                    <asp:ListItem Text="Member" />
                </asp:DropDownList>

            </div>
        </div>
        <!--end col-->
        <div class="col-lg-12">
            <div class="text-end">
                <asp:Button ID="btnCreate" OnClick="btnCreate_Click" CssClass="btn btn-primary" runat="server" Text="Create" />
            </div>
        </div>
        <!--end col-->
    </div>
    <!--end row-->

</asp:Content>
