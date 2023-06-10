<%@ Page Title="" Language="C#" MasterPageFile="~/Bhc_Operations.Master" AutoEventWireup="true" CodeBehind="BhcHome.aspx.cs" Inherits="Bhc_Operations.BhcHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- start page title -->
                        <div class="row">
                            <div class="col-12">
                                <div class="page-title-box d-sm-flex align-items-center justify-content-between">
                                    <h4 class="mb-sm-0">Dashboard</h4>

                                </div>
                            </div>
                        </div>
                        <!-- end page title -->
                        
                        <div class="row">
                            <div class="col-xl-12">
                                <div class="card crm-widget">
                                    <div class="card-body p-0">
                                        <div class="row row-cols-xxl-5 row-cols-md-4 row-cols-3 g-0">
                                            <div class="col">
                                                <div class="py-4 px-4">
                                                    <h5 class="text-muted text-uppercase fs-13">Sowers</h5>
                                                    <div class="d-flex align-items-center">
                                                        <div class="flex-grow-1 ms-4">
                                                            <h2 class="mb-0"><span class="counter-value" data-target="197">5</span></h2>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div><!-- end col -->
                                            <div class="col">
                                                <div class="mt-4 mt-md-0 py-4 px-4">
                                                    <h5 class="text-muted text-uppercase fs-13">Bales</h5>
                                                    <div class="d-flex align-items-center">
                                                        <div class="flex-grow-1 ms-4">
                                                            <h2 class="mb-0"><span class="counter-value" data-target="489.4">10</span></h2>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div><!-- end col -->
                                            <div class="col">
                                                <div class="mt-3 mt-md-0 py-4 px-4">
                                                    <h5 class="text-muted text-uppercase fs-13"> Projects</h5>
                                                    <div class="d-flex align-items-center">
                                                        <div class="flex-grow-1 ms-4">
                                                            <h2 class="mb-0"><span class="counter-value" data-target="32.89">8</span></h2>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div><!-- end col -->
                                            
         
                                        </div><!-- end row -->
                                    </div><!-- end card body -->
                                </div><!-- end card -->
                            </div><!-- end col -->
                        </div><!-- end row -->


                        <div class="row">
                            <div class="col-xl-7">
                                <div class="card">
                                    <div class="card-header align-items-center d-flex">
                                        <h4 class="card-title mb-0 flex-grow-1">Projects</h4>
                                        <div class="flex-shrink-0">
                                            <div class="dropdown card-header-dropdown">
                                                <a class="text-reset dropdown-btn" href="#" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                    <span class="text-muted">02 Nov 2023 to 31 Dec 2023<i class="mdi mdi-chevron-down ms-1"></i></span>
                                                </a>
                                                <div class="dropdown-menu dropdown-menu-end">
                                                    <a class="dropdown-item" href="#">Today</a>
                                                    <a class="dropdown-item" href="#">Last Week</a>
                                                    <a class="dropdown-item" href="#">Last Month</a>
                                                    <a class="dropdown-item" href="#">Current Year</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div><!-- end card header -->

                                    <div class="card-body">
                                        <div class="table-responsive table-card">
                                            <table class="table table-borderless table-hover table-nowrap align-middle mb-0">
                                                <thead class="table-light">
                                                    <tr class="text-muted">
                                                        <th scope="col">Project Name</th>
                                                        <th scope="col" style="width: 20%;">Start Date</th>
                                                        <th scope="col" >Maturity Date</th>
                                                        <th scope="col" style="width: 16%;">Status</th>
                                                        <th scope="col" style="width: 12%;">Action</th>
                                                    </tr>
                                                </thead>
                                                
                                                <tbody>
                                                    <tr>
                                                        <td>Avocado Farm</td>
                                                        <td>Sep 20, 2023</td>
                                                        <td>Sep 22, 2023</td>
                                                        <td><span class="badge badge-soft-success p-2">Ongoing</span></td>
                                                        <td><asp:Button ID="Button4"  CssClass="btn btn-sm btn-primary" runat="server" Text="View" /></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Orange Farm</td>
                                                        <td>Sep 23, 2023</td>
                                                        <td>Sep 22, 2023</td>
                                                        <td><span class="badge badge-soft-warning p-2">Waiting</span></td>
                                                        <td><asp:Button ID="Button3"  CssClass="btn btn-sm btn-primary" runat="server" Text="View" /></td>
                                                    </tr>
                                                </tbody><!-- end tbody -->
                                            </table><!-- end table -->
                                        </div><!-- end table responsive -->
                                    </div><!-- end card body -->
                                </div><!-- end card -->
                            </div><!-- end col -->
                            <div class="col-xxl-5">
                                <div class="card">
                                    <div class="card-header align-items-center d-flex">
                                        <h4 class="card-title mb-0 flex-grow-1">Upcoming Events</h4>
                                        <div class="flex-shrink-0">
                                            <div class="dropdown card-header-dropdown">
                                                <a class="text-reset dropdown-btn" href="#" data-bs-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                                    <span class="text-muted fs-18"><i class="mdi mdi-dots-vertical"></i></span>
                                                </a>
                                                <div class="dropdown-menu dropdown-menu-end">
                                                    <a class="dropdown-item" href="#">Edit</a>
                                                    <a class="dropdown-item" href="#">Remove</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div><!-- end card header -->
                                    <div class="card-body pt-0">
                                        <ul class="list-group list-group-flush border-dashed">
                                            <li class="list-group-item ps-0">
                                                <div class="row align-items-center g-3">
                                                    <div class="col-auto">
                                                        <div class="avatar-sm p-1 py-2 h-auto bg-light rounded-3">
                                                            <div class="text-center">
                                                                 <h5 class="mb-0">25</h5>
                                                                 <div class="text-muted">Tue</div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col">
                                                        <h5 class="text-muted mt-0 mb-1 fs-13">12:00am - 03:30pm</h5>
                                                        <a href="#" class="text-reset fs-14 mb-0">Field trip to Mazowe</a>
                                                    </div>
      
                                                </div>
                                                <!-- end row -->
                                            </li><!-- end -->
                                            <li class="list-group-item ps-0">
                                                <div class="row align-items-center g-3">
                                                    <div class="col-auto">
                                                        <div class="avatar-sm p-1 py-2 h-auto bg-light rounded-3">
                                                            <div class="text-center">
                                                                <h5 class="mb-0">20</h5>
                                                                <div class="text-muted">Wed</div>
                                                           </div>
                                                        </div>
                                                    </div>
                                                    <div class="col">
                                                        <h5 class="text-muted mt-0 mb-1 fs-13">02:00pm - 03:45pm</h5>
                                                        <a href="#" class="text-reset fs-14 mb-0">AGM Conference Vumba</a>
                                                    </div>
                                            
                                                </div>
                                                <!-- end row -->
                                            </li><!-- end -->
                                            <li class="list-group-item ps-0">
                                                <div class="row align-items-center g-3">
                                                    <div class="col-auto">
                                                        <div class="avatar-sm p-1 py-2 h-auto bg-light rounded-3">
                                                            <div class="text-center">
                                                                <h5 class="mb-0">17</h5>
                                                                <div class="text-muted">Wed</div>
                                                           </div>
                                                        </div>
                                                    </div>
                                                    <div class="col">
                                                        <h5 class="text-muted mt-0 mb-1 fs-13">04:30pm - 07:15pm</h5>
                                                        <a href="#" class="text-reset fs-14 mb-0">Orange Project Visits</a>
                                                    </div>
                                               
                                                </div>
                                                <!-- end row -->
                                            </li><!-- end -->
                                            <li class="list-group-item ps-0">
                                                <div class="row align-items-center g-3">
                                                    <div class="col-auto">
                                                        <div class="avatar-sm p-1 py-2 h-auto bg-light rounded-3">
                                                            <div class="text-center">
                                                                <h5 class="mb-0">12</h5>
                                                                <div class="text-muted">Tue</div>
                                                           </div>
                                                        </div>
                                                    </div>
                                                    <div class="col">
                                                        <h5 class="text-muted mt-0 mb-1 fs-13">10:30am - 01:15pm</h5>
                                                        <a href="#" class="text-reset fs-14 mb-0">Payment of Dividends</a>
                                                    </div>
                                                  
                                                </div>
                                                <!-- end row -->
                                            </li><!-- end -->
                                        </ul><!-- end -->
                                        <div class="align-items-center mt-2 row g-3 text-center text-sm-start">
                                            <div class="col-sm">
                                                <div class="text-muted">Showing<span class="fw-semibold">4</span> of <span class="fw-semibold">125</span> Results
                                                </div>
                                            </div>
                                            <div class="col-sm-auto">
                                                <ul class="pagination pagination-separated pagination-sm justify-content-center justify-content-sm-start mb-0">
                                                    <li class="page-item disabled">
                                                        <a href="#" class="page-link">←</a>
                                                    </li>
                                                    <li class="page-item">
                                                        <a href="#" class="page-link">1</a>
                                                    </li>
                                                    <li class="page-item active">
                                                        <a href="#" class="page-link">2</a>
                                                    </li>
                                                    <li class="page-item">
                                                        <a href="#" class="page-link">3</a>
                                                    </li>
                                                    <li class="page-item">
                                                        <a href="#" class="page-link">→</a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div><!-- end card body -->
                                </div><!-- end card -->
                            </div><!-- end col -->
                            
                        </div><!-- end row -->
</asp:Content>
