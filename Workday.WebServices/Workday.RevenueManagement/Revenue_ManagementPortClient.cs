using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Revenue_ManagementPortClient : ClientBase<Revenue_ManagementPort>, Revenue_ManagementPort
	{
		public Revenue_ManagementPortClient()
		{
		}

		public Revenue_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Revenue_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Revenue_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Revenue_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ProspectOutput Revenue_ManagementPort.Put_Prospect(Put_ProspectInput request)
		{
			return base.Channel.Put_Prospect(request);
		}

		public Put_Prospect_ResponseType Put_Prospect(Workday_Common_HeaderType Workday_Common_Header, Put_Prospect_RequestType Put_Prospect_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Prospect(new Put_ProspectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Prospect_Request = Put_Prospect_Request
			}).Put_Prospect_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ProspectOutput> Revenue_ManagementPort.Put_ProspectAsync(Put_ProspectInput request)
		{
			return base.Channel.Put_ProspectAsync(request);
		}

		public Task<Put_ProspectOutput> Put_ProspectAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Prospect_RequestType Put_Prospect_Request)
		{
			return ((Revenue_ManagementPort)this).Put_ProspectAsync(new Put_ProspectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Prospect_Request = Put_Prospect_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_OpportunityOutput Revenue_ManagementPort.Put_Opportunity(Put_OpportunityInput request)
		{
			return base.Channel.Put_Opportunity(request);
		}

		public Put_Opportunity_ResponseType Put_Opportunity(Workday_Common_HeaderType Workday_Common_Header, Put_Opportunity_RequestType Put_Opportunity_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Opportunity(new Put_OpportunityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Opportunity_Request = Put_Opportunity_Request
			}).Put_Opportunity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_OpportunityOutput> Revenue_ManagementPort.Put_OpportunityAsync(Put_OpportunityInput request)
		{
			return base.Channel.Put_OpportunityAsync(request);
		}

		public Task<Put_OpportunityOutput> Put_OpportunityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Opportunity_RequestType Put_Opportunity_Request)
		{
			return ((Revenue_ManagementPort)this).Put_OpportunityAsync(new Put_OpportunityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Opportunity_Request = Put_Opportunity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_RequestOutput Revenue_ManagementPort.Put_Customer_Request(Put_Customer_RequestInput request)
		{
			return base.Channel.Put_Customer_Request(request);
		}

		public Put_Customer_Request_ResponseType Put_Customer_Request(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Request_RequestType Put_Customer_Request_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Request(new Put_Customer_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Request_Request = Put_Customer_Request_Request
			}).Put_Customer_Request_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_RequestOutput> Revenue_ManagementPort.Put_Customer_RequestAsync(Put_Customer_RequestInput request)
		{
			return base.Channel.Put_Customer_RequestAsync(request);
		}

		public Task<Put_Customer_RequestOutput> Put_Customer_RequestAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Request_RequestType Put_Customer_Request_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_RequestAsync(new Put_Customer_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Request_Request = Put_Customer_Request_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_InvoicesOutput Revenue_ManagementPort.Get_Customer_Invoices(Get_Customer_InvoicesInput request)
		{
			return base.Channel.Get_Customer_Invoices(request);
		}

		public Get_Customer_Invoices_ResponseType Get_Customer_Invoices(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Invoices_RequestType Get_Customer_Invoices_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Invoices(new Get_Customer_InvoicesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Invoices_Request = Get_Customer_Invoices_Request
			}).Get_Customer_Invoices_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_InvoicesOutput> Revenue_ManagementPort.Get_Customer_InvoicesAsync(Get_Customer_InvoicesInput request)
		{
			return base.Channel.Get_Customer_InvoicesAsync(request);
		}

		public Task<Get_Customer_InvoicesOutput> Get_Customer_InvoicesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Invoices_RequestType Get_Customer_Invoices_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_InvoicesAsync(new Get_Customer_InvoicesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Invoices_Request = Get_Customer_Invoices_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CustomersOutput Revenue_ManagementPort.Get_Customers(Get_CustomersInput request)
		{
			return base.Channel.Get_Customers(request);
		}

		public Get_Customers_ResponseType Get_Customers(Workday_Common_HeaderType Workday_Common_Header, Get_Customers_RequestType Get_Customers_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customers(new Get_CustomersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customers_Request = Get_Customers_Request
			}).Get_Customers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CustomersOutput> Revenue_ManagementPort.Get_CustomersAsync(Get_CustomersInput request)
		{
			return base.Channel.Get_CustomersAsync(request);
		}

		public Task<Get_CustomersOutput> Get_CustomersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customers_RequestType Get_Customers_Request)
		{
			return ((Revenue_ManagementPort)this).Get_CustomersAsync(new Get_CustomersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customers_Request = Get_Customers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ProspectsOutput Revenue_ManagementPort.Get_Prospects(Get_ProspectsInput request)
		{
			return base.Channel.Get_Prospects(request);
		}

		public Get_Prospects_ResponseType Get_Prospects(Workday_Common_HeaderType Workday_Common_Header, Get_Prospects_RequestType Get_Prospects_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Prospects(new Get_ProspectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prospects_Request = Get_Prospects_Request
			}).Get_Prospects_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ProspectsOutput> Revenue_ManagementPort.Get_ProspectsAsync(Get_ProspectsInput request)
		{
			return base.Channel.Get_ProspectsAsync(request);
		}

		public Task<Get_ProspectsOutput> Get_ProspectsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Prospects_RequestType Get_Prospects_Request)
		{
			return ((Revenue_ManagementPort)this).Get_ProspectsAsync(new Get_ProspectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prospects_Request = Get_Prospects_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_RequestsOutput Revenue_ManagementPort.Get_Customer_Requests(Get_Customer_RequestsInput request)
		{
			return base.Channel.Get_Customer_Requests(request);
		}

		public Get_Customer_Requests_ResponseType Get_Customer_Requests(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Requests_RequestType Get_Customer_Requests_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Requests(new Get_Customer_RequestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Requests_Request = Get_Customer_Requests_Request
			}).Get_Customer_Requests_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_RequestsOutput> Revenue_ManagementPort.Get_Customer_RequestsAsync(Get_Customer_RequestsInput request)
		{
			return base.Channel.Get_Customer_RequestsAsync(request);
		}

		public Task<Get_Customer_RequestsOutput> Get_Customer_RequestsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Requests_RequestType Get_Customer_Requests_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_RequestsAsync(new Get_Customer_RequestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Requests_Request = Get_Customer_Requests_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OpportunitiesOutput Revenue_ManagementPort.Get_Opportunities(Get_OpportunitiesInput request)
		{
			return base.Channel.Get_Opportunities(request);
		}

		public Get_Opportunities_ResponseType Get_Opportunities(Workday_Common_HeaderType Workday_Common_Header, Get_Opportunities_RequestType Get_Opportunities_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Opportunities(new Get_OpportunitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Opportunities_Request = Get_Opportunities_Request
			}).Get_Opportunities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OpportunitiesOutput> Revenue_ManagementPort.Get_OpportunitiesAsync(Get_OpportunitiesInput request)
		{
			return base.Channel.Get_OpportunitiesAsync(request);
		}

		public Task<Get_OpportunitiesOutput> Get_OpportunitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Opportunities_RequestType Get_Opportunities_Request)
		{
			return ((Revenue_ManagementPort)this).Get_OpportunitiesAsync(new Get_OpportunitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Opportunities_Request = Get_Opportunities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_RefundsOutput Revenue_ManagementPort.Get_Customer_Refunds(Get_Customer_RefundsInput request)
		{
			return base.Channel.Get_Customer_Refunds(request);
		}

		public Get_Customer_Refunds_ResponseType Get_Customer_Refunds(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Refunds_RequestType Get_Customer_Refunds_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Refunds(new Get_Customer_RefundsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Refunds_Request = Get_Customer_Refunds_Request
			}).Get_Customer_Refunds_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_RefundsOutput> Revenue_ManagementPort.Get_Customer_RefundsAsync(Get_Customer_RefundsInput request)
		{
			return base.Channel.Get_Customer_RefundsAsync(request);
		}

		public Task<Get_Customer_RefundsOutput> Get_Customer_RefundsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Refunds_RequestType Get_Customer_Refunds_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_RefundsAsync(new Get_Customer_RefundsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Refunds_Request = Get_Customer_Refunds_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_ActivityOutput Revenue_ManagementPort.Get_Customer_Activity(Get_Customer_ActivityInput request)
		{
			return base.Channel.Get_Customer_Activity(request);
		}

		public Get_Customer_Activity_ResponseType Get_Customer_Activity(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Activity_RequestType Get_Customer_Activity_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Activity(new Get_Customer_ActivityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Activity_Request = Get_Customer_Activity_Request
			}).Get_Customer_Activity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_ActivityOutput> Revenue_ManagementPort.Get_Customer_ActivityAsync(Get_Customer_ActivityInput request)
		{
			return base.Channel.Get_Customer_ActivityAsync(request);
		}

		public Task<Get_Customer_ActivityOutput> Get_Customer_ActivityAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Activity_RequestType Get_Customer_Activity_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_ActivityAsync(new Get_Customer_ActivityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Activity_Request = Get_Customer_Activity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Revenue_CategoriesOutput Revenue_ManagementPort.Get_Revenue_Categories(Get_Revenue_CategoriesInput request)
		{
			return base.Channel.Get_Revenue_Categories(request);
		}

		public Get_Revenue_Categories_ResponseType Get_Revenue_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Categories_RequestType Get_Revenue_Categories_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Categories(new Get_Revenue_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Categories_Request = Get_Revenue_Categories_Request
			}).Get_Revenue_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Revenue_CategoriesOutput> Revenue_ManagementPort.Get_Revenue_CategoriesAsync(Get_Revenue_CategoriesInput request)
		{
			return base.Channel.Get_Revenue_CategoriesAsync(request);
		}

		public Task<Get_Revenue_CategoriesOutput> Get_Revenue_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Categories_RequestType Get_Revenue_Categories_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_CategoriesAsync(new Get_Revenue_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Categories_Request = Get_Revenue_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Revenue_CategoryOutput Revenue_ManagementPort.Put_Revenue_Category(Put_Revenue_CategoryInput request)
		{
			return base.Channel.Put_Revenue_Category(request);
		}

		public Put_Revenue_Category_ResponseType Put_Revenue_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_RequestType Put_Revenue_Category_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Revenue_Category(new Put_Revenue_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Request = Put_Revenue_Category_Request
			}).Put_Revenue_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Revenue_CategoryOutput> Revenue_ManagementPort.Put_Revenue_CategoryAsync(Put_Revenue_CategoryInput request)
		{
			return base.Channel.Put_Revenue_CategoryAsync(request);
		}

		public Task<Put_Revenue_CategoryOutput> Put_Revenue_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_RequestType Put_Revenue_Category_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Revenue_CategoryAsync(new Put_Revenue_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Request = Put_Revenue_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Sales_Item_GroupsOutput Revenue_ManagementPort.Get_Sales_Item_Groups(Get_Sales_Item_GroupsInput request)
		{
			return base.Channel.Get_Sales_Item_Groups(request);
		}

		public Get_Sales_Item_Groups_ResponseType Get_Sales_Item_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Item_Groups_RequestType Get_Sales_Item_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sales_Item_Groups(new Get_Sales_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sales_Item_Groups_Request = Get_Sales_Item_Groups_Request
			}).Get_Sales_Item_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Sales_Item_GroupsOutput> Revenue_ManagementPort.Get_Sales_Item_GroupsAsync(Get_Sales_Item_GroupsInput request)
		{
			return base.Channel.Get_Sales_Item_GroupsAsync(request);
		}

		public Task<Get_Sales_Item_GroupsOutput> Get_Sales_Item_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Item_Groups_RequestType Get_Sales_Item_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sales_Item_GroupsAsync(new Get_Sales_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sales_Item_Groups_Request = Get_Sales_Item_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Sales_Item_GroupOutput Revenue_ManagementPort.Put_Sales_Item_Group(Put_Sales_Item_GroupInput request)
		{
			return base.Channel.Put_Sales_Item_Group(request);
		}

		public Put_Sales_Item_Group_ResponseType Put_Sales_Item_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Sales_Item_Group_RequestType Put_Sales_Item_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sales_Item_Group(new Put_Sales_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sales_Item_Group_Request = Put_Sales_Item_Group_Request
			}).Put_Sales_Item_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Sales_Item_GroupOutput> Revenue_ManagementPort.Put_Sales_Item_GroupAsync(Put_Sales_Item_GroupInput request)
		{
			return base.Channel.Put_Sales_Item_GroupAsync(request);
		}

		public Task<Put_Sales_Item_GroupOutput> Put_Sales_Item_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Sales_Item_Group_RequestType Put_Sales_Item_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sales_Item_GroupAsync(new Put_Sales_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sales_Item_Group_Request = Put_Sales_Item_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_InvoiceOutput Revenue_ManagementPort.Submit_Customer_Invoice(Submit_Customer_InvoiceInput request)
		{
			return base.Channel.Submit_Customer_Invoice(request);
		}

		public Submit_Customer_Invoice_ResponseType Submit_Customer_Invoice(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Invoice_RequestType Submit_Customer_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Invoice(new Submit_Customer_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Invoice_Request = Submit_Customer_Invoice_Request
			}).Submit_Customer_Invoice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_InvoiceOutput> Revenue_ManagementPort.Submit_Customer_InvoiceAsync(Submit_Customer_InvoiceInput request)
		{
			return base.Channel.Submit_Customer_InvoiceAsync(request);
		}

		public Task<Submit_Customer_InvoiceOutput> Submit_Customer_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Invoice_RequestType Submit_Customer_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_InvoiceAsync(new Submit_Customer_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Invoice_Request = Submit_Customer_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Sales_ItemsOutput Revenue_ManagementPort.Get_Sales_Items(Get_Sales_ItemsInput request)
		{
			return base.Channel.Get_Sales_Items(request);
		}

		public Get_Sales_Items_ResponseType Get_Sales_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Items_RequestType Get_Sales_Items_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sales_Items(new Get_Sales_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sales_Items_Request = Get_Sales_Items_Request
			}).Get_Sales_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Sales_ItemsOutput> Revenue_ManagementPort.Get_Sales_ItemsAsync(Get_Sales_ItemsInput request)
		{
			return base.Channel.Get_Sales_ItemsAsync(request);
		}

		public Task<Get_Sales_ItemsOutput> Get_Sales_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Items_RequestType Get_Sales_Items_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sales_ItemsAsync(new Get_Sales_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sales_Items_Request = Get_Sales_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Sales_ItemOutput Revenue_ManagementPort.Put_Sales_Item(Put_Sales_ItemInput request)
		{
			return base.Channel.Put_Sales_Item(request);
		}

		public Put_Sales_Item_ResponseType Put_Sales_Item(Workday_Common_HeaderType Workday_Common_Header, Put_Sales_Item_RequestType Put_Sales_Item_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sales_Item(new Put_Sales_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sales_Item_Request = Put_Sales_Item_Request
			}).Put_Sales_Item_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Sales_ItemOutput> Revenue_ManagementPort.Put_Sales_ItemAsync(Put_Sales_ItemInput request)
		{
			return base.Channel.Put_Sales_ItemAsync(request);
		}

		public Task<Put_Sales_ItemOutput> Put_Sales_ItemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Sales_Item_RequestType Put_Sales_Item_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sales_ItemAsync(new Put_Sales_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sales_Item_Request = Put_Sales_Item_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_Invoice_AdjustmentOutput Revenue_ManagementPort.Submit_Customer_Invoice_Adjustment(Submit_Customer_Invoice_AdjustmentInput request)
		{
			return base.Channel.Submit_Customer_Invoice_Adjustment(request);
		}

		public Submit_Customer_Invoice_Adjustment_ResponseType Submit_Customer_Invoice_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Invoice_Adjustment_RequestType Submit_Customer_Invoice_Adjustment_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Invoice_Adjustment(new Submit_Customer_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Invoice_Adjustment_Request = Submit_Customer_Invoice_Adjustment_Request
			}).Submit_Customer_Invoice_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_Invoice_AdjustmentOutput> Revenue_ManagementPort.Submit_Customer_Invoice_AdjustmentAsync(Submit_Customer_Invoice_AdjustmentInput request)
		{
			return base.Channel.Submit_Customer_Invoice_AdjustmentAsync(request);
		}

		public Task<Submit_Customer_Invoice_AdjustmentOutput> Submit_Customer_Invoice_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Invoice_Adjustment_RequestType Submit_Customer_Invoice_Adjustment_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Invoice_AdjustmentAsync(new Submit_Customer_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Invoice_Adjustment_Request = Submit_Customer_Invoice_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Customer_InvoiceOutput Revenue_ManagementPort.Cancel_Customer_Invoice(Cancel_Customer_InvoiceInput request)
		{
			return base.Channel.Cancel_Customer_Invoice(request);
		}

		public Cancel_Customer_Invoice_ResponseType Cancel_Customer_Invoice(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Invoice_RequestType Cancel_Customer_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Customer_Invoice(new Cancel_Customer_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Customer_Invoice_Request = Cancel_Customer_Invoice_Request
			}).Cancel_Customer_Invoice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Customer_InvoiceOutput> Revenue_ManagementPort.Cancel_Customer_InvoiceAsync(Cancel_Customer_InvoiceInput request)
		{
			return base.Channel.Cancel_Customer_InvoiceAsync(request);
		}

		public Task<Cancel_Customer_InvoiceOutput> Cancel_Customer_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Invoice_RequestType Cancel_Customer_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Customer_InvoiceAsync(new Cancel_Customer_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Customer_Invoice_Request = Cancel_Customer_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Customer_Invoice_AdjustmentOutput Revenue_ManagementPort.Cancel_Customer_Invoice_Adjustment(Cancel_Customer_Invoice_AdjustmentInput request)
		{
			return base.Channel.Cancel_Customer_Invoice_Adjustment(request);
		}

		public Cancel_Customer_Invoice_Adjustment_ResponseType Cancel_Customer_Invoice_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Invoice_Adjustment_RequestType Cancel_Customer_Invoice_Adjustment_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Customer_Invoice_Adjustment(new Cancel_Customer_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Customer_Invoice_Adjustment_Request = Cancel_Customer_Invoice_Adjustment_Request
			}).Cancel_Customer_Invoice_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Customer_Invoice_AdjustmentOutput> Revenue_ManagementPort.Cancel_Customer_Invoice_AdjustmentAsync(Cancel_Customer_Invoice_AdjustmentInput request)
		{
			return base.Channel.Cancel_Customer_Invoice_AdjustmentAsync(request);
		}

		public Task<Cancel_Customer_Invoice_AdjustmentOutput> Cancel_Customer_Invoice_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Invoice_Adjustment_RequestType Cancel_Customer_Invoice_Adjustment_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Customer_Invoice_AdjustmentAsync(new Cancel_Customer_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Customer_Invoice_Adjustment_Request = Cancel_Customer_Invoice_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_CategoriesOutput Revenue_ManagementPort.Get_Customer_Categories(Get_Customer_CategoriesInput request)
		{
			return base.Channel.Get_Customer_Categories(request);
		}

		public Get_Customer_Categories_ResponseType Get_Customer_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Categories_RequestType Get_Customer_Categories_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Categories(new Get_Customer_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Categories_Request = Get_Customer_Categories_Request
			}).Get_Customer_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_CategoriesOutput> Revenue_ManagementPort.Get_Customer_CategoriesAsync(Get_Customer_CategoriesInput request)
		{
			return base.Channel.Get_Customer_CategoriesAsync(request);
		}

		public Task<Get_Customer_CategoriesOutput> Get_Customer_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Categories_RequestType Get_Customer_Categories_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_CategoriesAsync(new Get_Customer_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Categories_Request = Get_Customer_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_CategoryOutput Revenue_ManagementPort.Put_Customer_Category(Put_Customer_CategoryInput request)
		{
			return base.Channel.Put_Customer_Category(request);
		}

		public Put_Customer_Category_ResponseType Put_Customer_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Category_RequestType Put_Customer_Category_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Category(new Put_Customer_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Category_Request = Put_Customer_Category_Request
			}).Put_Customer_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_CategoryOutput> Revenue_ManagementPort.Put_Customer_CategoryAsync(Put_Customer_CategoryInput request)
		{
			return base.Channel.Put_Customer_CategoryAsync(request);
		}

		public Task<Put_Customer_CategoryOutput> Put_Customer_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Category_RequestType Put_Customer_Category_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_CategoryAsync(new Put_Customer_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Category_Request = Put_Customer_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_GroupsOutput Revenue_ManagementPort.Get_Customer_Groups(Get_Customer_GroupsInput request)
		{
			return base.Channel.Get_Customer_Groups(request);
		}

		public Get_Customer_Groups_ResponseType Get_Customer_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Groups_RequestType Get_Customer_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Groups(new Get_Customer_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Groups_Request = Get_Customer_Groups_Request
			}).Get_Customer_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_GroupsOutput> Revenue_ManagementPort.Get_Customer_GroupsAsync(Get_Customer_GroupsInput request)
		{
			return base.Channel.Get_Customer_GroupsAsync(request);
		}

		public Task<Get_Customer_GroupsOutput> Get_Customer_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Groups_RequestType Get_Customer_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_GroupsAsync(new Get_Customer_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Groups_Request = Get_Customer_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_GroupOutput Revenue_ManagementPort.Put_Customer_Group(Put_Customer_GroupInput request)
		{
			return base.Channel.Put_Customer_Group(request);
		}

		public Put_Customer_Group_ResponseType Put_Customer_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Group_RequestType Put_Customer_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Group(new Put_Customer_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Group_Request = Put_Customer_Group_Request
			}).Put_Customer_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_GroupOutput> Revenue_ManagementPort.Put_Customer_GroupAsync(Put_Customer_GroupInput request)
		{
			return base.Channel.Put_Customer_GroupAsync(request);
		}

		public Task<Put_Customer_GroupOutput> Put_Customer_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Group_RequestType Put_Customer_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_GroupAsync(new Put_Customer_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Group_Request = Put_Customer_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Cash_SaleOutput Revenue_ManagementPort.Put_Cash_Sale(Put_Cash_SaleInput request)
		{
			return base.Channel.Put_Cash_Sale(request);
		}

		public Put_Cash_Sale_ResponseType Put_Cash_Sale(Workday_Common_HeaderType Workday_Common_Header, Put_Cash_Sale_RequestType Put_Cash_Sale_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Cash_Sale(new Put_Cash_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Cash_Sale_Request = Put_Cash_Sale_Request
			}).Put_Cash_Sale_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Cash_SaleOutput> Revenue_ManagementPort.Put_Cash_SaleAsync(Put_Cash_SaleInput request)
		{
			return base.Channel.Put_Cash_SaleAsync(request);
		}

		public Task<Put_Cash_SaleOutput> Put_Cash_SaleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Cash_Sale_RequestType Put_Cash_Sale_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Cash_SaleAsync(new Put_Cash_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Cash_Sale_Request = Put_Cash_Sale_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Cash_SaleOutput Revenue_ManagementPort.Cancel_Cash_Sale(Cancel_Cash_SaleInput request)
		{
			return base.Channel.Cancel_Cash_Sale(request);
		}

		public Cancel_Cash_Sale_ResponseType Cancel_Cash_Sale(Workday_Common_HeaderType Workday_Common_Header, Cancel_Cash_Sale_RequestType Cancel_Cash_Sale_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Cash_Sale(new Cancel_Cash_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Cash_Sale_Request = Cancel_Cash_Sale_Request
			}).Cancel_Cash_Sale_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Cash_SaleOutput> Revenue_ManagementPort.Cancel_Cash_SaleAsync(Cancel_Cash_SaleInput request)
		{
			return base.Channel.Cancel_Cash_SaleAsync(request);
		}

		public Task<Cancel_Cash_SaleOutput> Cancel_Cash_SaleAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Cash_Sale_RequestType Cancel_Cash_Sale_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Cash_SaleAsync(new Cancel_Cash_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Cash_Sale_Request = Cancel_Cash_Sale_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_Entity_ContactsOutput Revenue_ManagementPort.Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_Contacts(request);
		}

		public Get_Business_Entity_Contacts_ResponseType Get_Business_Entity_Contacts(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Business_Entity_Contacts(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			}).Get_Business_Entity_Contacts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_Entity_ContactsOutput> Revenue_ManagementPort.Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_ContactsAsync(request);
		}

		public Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Business_Entity_ContactsAsync(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_Entity_ContactOutput Revenue_ManagementPort.Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_Contact(request);
		}

		public Put_Business_Entity_Contact_ResponseType Put_Business_Entity_Contact(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Business_Entity_Contact(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			}).Put_Business_Entity_Contact_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_Entity_ContactOutput> Revenue_ManagementPort.Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_ContactAsync(request);
		}

		public Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Business_Entity_ContactAsync(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_CustomerOutput Revenue_ManagementPort.Put_Customer(Put_CustomerInput request)
		{
			return base.Channel.Put_Customer(request);
		}

		public Put_Customer_ResponseType Put_Customer(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_RequestType Put_Customer_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer(new Put_CustomerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Request = Put_Customer_Request
			}).Put_Customer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_CustomerOutput> Revenue_ManagementPort.Put_CustomerAsync(Put_CustomerInput request)
		{
			return base.Channel.Put_CustomerAsync(request);
		}

		public Task<Put_CustomerOutput> Put_CustomerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_RequestType Put_Customer_Request)
		{
			return ((Revenue_ManagementPort)this).Put_CustomerAsync(new Put_CustomerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Request = Put_Customer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_Invoice_AdjustmentsOutput Revenue_ManagementPort.Get_Customer_Invoice_Adjustments(Get_Customer_Invoice_AdjustmentsInput request)
		{
			return base.Channel.Get_Customer_Invoice_Adjustments(request);
		}

		public Get_Customer_Invoice_Adjustments_ResponseType Get_Customer_Invoice_Adjustments(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Invoice_Adjustments_RequestType Get_Customer_Invoice_Adjustments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Invoice_Adjustments(new Get_Customer_Invoice_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Invoice_Adjustments_Request = Get_Customer_Invoice_Adjustments_Request
			}).Get_Customer_Invoice_Adjustments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_Invoice_AdjustmentsOutput> Revenue_ManagementPort.Get_Customer_Invoice_AdjustmentsAsync(Get_Customer_Invoice_AdjustmentsInput request)
		{
			return base.Channel.Get_Customer_Invoice_AdjustmentsAsync(request);
		}

		public Task<Get_Customer_Invoice_AdjustmentsOutput> Get_Customer_Invoice_AdjustmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Invoice_Adjustments_RequestType Get_Customer_Invoice_Adjustments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Invoice_AdjustmentsAsync(new Get_Customer_Invoice_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Invoice_Adjustments_Request = Get_Customer_Invoice_Adjustments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Cash_SalesOutput Revenue_ManagementPort.Get_Cash_Sales(Get_Cash_SalesInput request)
		{
			return base.Channel.Get_Cash_Sales(request);
		}

		public Get_Cash_Sales_ResponseType Get_Cash_Sales(Workday_Common_HeaderType Workday_Common_Header, Get_Cash_Sales_RequestType Get_Cash_Sales_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Cash_Sales(new Get_Cash_SalesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Cash_Sales_Request = Get_Cash_Sales_Request
			}).Get_Cash_Sales_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Cash_SalesOutput> Revenue_ManagementPort.Get_Cash_SalesAsync(Get_Cash_SalesInput request)
		{
			return base.Channel.Get_Cash_SalesAsync(request);
		}

		public Task<Get_Cash_SalesOutput> Get_Cash_SalesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Cash_Sales_RequestType Get_Cash_Sales_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Cash_SalesAsync(new Get_Cash_SalesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Cash_Sales_Request = Get_Cash_Sales_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Cash_SaleOutput Revenue_ManagementPort.Submit_Cash_Sale(Submit_Cash_SaleInput request)
		{
			return base.Channel.Submit_Cash_Sale(request);
		}

		public Submit_Cash_Sale_ResponseType Submit_Cash_Sale(Workday_Common_HeaderType Workday_Common_Header, Submit_Cash_Sale_RequestType Submit_Cash_Sale_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Cash_Sale(new Submit_Cash_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Cash_Sale_Request = Submit_Cash_Sale_Request
			}).Submit_Cash_Sale_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Cash_SaleOutput> Revenue_ManagementPort.Submit_Cash_SaleAsync(Submit_Cash_SaleInput request)
		{
			return base.Channel.Submit_Cash_SaleAsync(request);
		}

		public Task<Submit_Cash_SaleOutput> Submit_Cash_SaleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Cash_Sale_RequestType Submit_Cash_Sale_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Cash_SaleAsync(new Submit_Cash_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Cash_Sale_Request = Submit_Cash_Sale_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Merchant_Customer_ProfileOutput Revenue_ManagementPort.Get_Merchant_Customer_Profile(Get_Merchant_Customer_ProfileInput request)
		{
			return base.Channel.Get_Merchant_Customer_Profile(request);
		}

		public Get_Merchant_Customer_Profile_ResponseType Get_Merchant_Customer_Profile(Workday_Common_HeaderType Workday_Common_Header, Get_Merchant_Customer_Profile_RequestType Get_Merchant_Customer_Profile_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Merchant_Customer_Profile(new Get_Merchant_Customer_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Merchant_Customer_Profile_Request = Get_Merchant_Customer_Profile_Request
			}).Get_Merchant_Customer_Profile_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Merchant_Customer_ProfileOutput> Revenue_ManagementPort.Get_Merchant_Customer_ProfileAsync(Get_Merchant_Customer_ProfileInput request)
		{
			return base.Channel.Get_Merchant_Customer_ProfileAsync(request);
		}

		public Task<Get_Merchant_Customer_ProfileOutput> Get_Merchant_Customer_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Merchant_Customer_Profile_RequestType Get_Merchant_Customer_Profile_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Merchant_Customer_ProfileAsync(new Get_Merchant_Customer_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Merchant_Customer_Profile_Request = Get_Merchant_Customer_Profile_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Merchant_Customer_ProfileOutput Revenue_ManagementPort.Put_Merchant_Customer_Profile(Put_Merchant_Customer_ProfileInput request)
		{
			return base.Channel.Put_Merchant_Customer_Profile(request);
		}

		public Put_Customer_Credit_Card_Profile_ResponseType Put_Merchant_Customer_Profile(Workday_Common_HeaderType Workday_Common_Header, Put_Merchant_Customer_Profile_RequestType Put_Merchant_Customer_Profile_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Merchant_Customer_Profile(new Put_Merchant_Customer_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Merchant_Customer_Profile_Request = Put_Merchant_Customer_Profile_Request
			}).Put_Customer_Credit_Card_Profile_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Merchant_Customer_ProfileOutput> Revenue_ManagementPort.Put_Merchant_Customer_ProfileAsync(Put_Merchant_Customer_ProfileInput request)
		{
			return base.Channel.Put_Merchant_Customer_ProfileAsync(request);
		}

		public Task<Put_Merchant_Customer_ProfileOutput> Put_Merchant_Customer_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Merchant_Customer_Profile_RequestType Put_Merchant_Customer_Profile_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Merchant_Customer_ProfileAsync(new Put_Merchant_Customer_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Merchant_Customer_Profile_Request = Put_Merchant_Customer_Profile_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Credit_Card_AuthorizationOutput Revenue_ManagementPort.Get_Credit_Card_Authorization(Get_Credit_Card_AuthorizationInput request)
		{
			return base.Channel.Get_Credit_Card_Authorization(request);
		}

		public Get_Credit_Card_Authorization_ResponseType Get_Credit_Card_Authorization(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Authorization_RequestType Get_Credit_Card_Authorization_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Credit_Card_Authorization(new Get_Credit_Card_AuthorizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Credit_Card_Authorization_Request = Get_Credit_Card_Authorization_Request
			}).Get_Credit_Card_Authorization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Credit_Card_AuthorizationOutput> Revenue_ManagementPort.Get_Credit_Card_AuthorizationAsync(Get_Credit_Card_AuthorizationInput request)
		{
			return base.Channel.Get_Credit_Card_AuthorizationAsync(request);
		}

		public Task<Get_Credit_Card_AuthorizationOutput> Get_Credit_Card_AuthorizationAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Authorization_RequestType Get_Credit_Card_Authorization_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Credit_Card_AuthorizationAsync(new Get_Credit_Card_AuthorizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Credit_Card_Authorization_Request = Get_Credit_Card_Authorization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Credit_Card_AuthorizationOutput Revenue_ManagementPort.Put_Credit_Card_Authorization(Put_Credit_Card_AuthorizationInput request)
		{
			return base.Channel.Put_Credit_Card_Authorization(request);
		}

		public Put_Credit_Card_Authorization_ResponseType Put_Credit_Card_Authorization(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Authorization_RequestType Put_Credit_Card_Authorization_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Credit_Card_Authorization(new Put_Credit_Card_AuthorizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Credit_Card_Authorization_Request = Put_Credit_Card_Authorization_Request
			}).Put_Credit_Card_Authorization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Credit_Card_AuthorizationOutput> Revenue_ManagementPort.Put_Credit_Card_AuthorizationAsync(Put_Credit_Card_AuthorizationInput request)
		{
			return base.Channel.Put_Credit_Card_AuthorizationAsync(request);
		}

		public Task<Put_Credit_Card_AuthorizationOutput> Put_Credit_Card_AuthorizationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Authorization_RequestType Put_Credit_Card_Authorization_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Credit_Card_AuthorizationAsync(new Put_Credit_Card_AuthorizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Credit_Card_Authorization_Request = Put_Credit_Card_Authorization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_ContractsOutput Revenue_ManagementPort.Get_Customer_Contracts(Get_Customer_ContractsInput request)
		{
			return base.Channel.Get_Customer_Contracts(request);
		}

		public Get_Customer_Contracts_ResponseType Get_Customer_Contracts(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contracts_RequestType Get_Customer_Contracts_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Contracts(new Get_Customer_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Contracts_Request = Get_Customer_Contracts_Request
			}).Get_Customer_Contracts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_ContractsOutput> Revenue_ManagementPort.Get_Customer_ContractsAsync(Get_Customer_ContractsInput request)
		{
			return base.Channel.Get_Customer_ContractsAsync(request);
		}

		public Task<Get_Customer_ContractsOutput> Get_Customer_ContractsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contracts_RequestType Get_Customer_Contracts_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_ContractsAsync(new Get_Customer_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Contracts_Request = Get_Customer_Contracts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_ContractOutput Revenue_ManagementPort.Submit_Customer_Contract(Submit_Customer_ContractInput request)
		{
			return base.Channel.Submit_Customer_Contract(request);
		}

		public Submit_Customer_Contract_ResponseType Submit_Customer_Contract(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Contract_RequestType Submit_Customer_Contract_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Contract(new Submit_Customer_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Contract_Request = Submit_Customer_Contract_Request
			}).Submit_Customer_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_ContractOutput> Revenue_ManagementPort.Submit_Customer_ContractAsync(Submit_Customer_ContractInput request)
		{
			return base.Channel.Submit_Customer_ContractAsync(request);
		}

		public Task<Submit_Customer_ContractOutput> Submit_Customer_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Contract_RequestType Submit_Customer_Contract_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_ContractAsync(new Submit_Customer_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Contract_Request = Submit_Customer_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_PaymentOutput Revenue_ManagementPort.Put_Customer_Payment(Put_Customer_PaymentInput request)
		{
			return base.Channel.Put_Customer_Payment(request);
		}

		public Put_Customer_Payment_ResponseType Put_Customer_Payment(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Payment_RequestType Put_Customer_Payment_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Payment(new Put_Customer_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Payment_Request = Put_Customer_Payment_Request
			}).Put_Customer_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_PaymentOutput> Revenue_ManagementPort.Put_Customer_PaymentAsync(Put_Customer_PaymentInput request)
		{
			return base.Channel.Put_Customer_PaymentAsync(request);
		}

		public Task<Put_Customer_PaymentOutput> Put_Customer_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Payment_RequestType Put_Customer_Payment_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_PaymentAsync(new Put_Customer_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Payment_Request = Put_Customer_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_PaymentsOutput Revenue_ManagementPort.Get_Customer_Payments(Get_Customer_PaymentsInput request)
		{
			return base.Channel.Get_Customer_Payments(request);
		}

		public Get_Customer_Payments_ResponseType Get_Customer_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Payments_RequestType Get_Customer_Payments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Payments(new Get_Customer_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Payments_Request = Get_Customer_Payments_Request
			}).Get_Customer_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_PaymentsOutput> Revenue_ManagementPort.Get_Customer_PaymentsAsync(Get_Customer_PaymentsInput request)
		{
			return base.Channel.Get_Customer_PaymentsAsync(request);
		}

		public Task<Get_Customer_PaymentsOutput> Get_Customer_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Payments_RequestType Get_Customer_Payments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_PaymentsAsync(new Get_Customer_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Payments_Request = Get_Customer_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_DepositsOutput Revenue_ManagementPort.Get_Customer_Deposits(Get_Customer_DepositsInput request)
		{
			return base.Channel.Get_Customer_Deposits(request);
		}

		public Get_Customer_Deposits_ResponseType Get_Customer_Deposits(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Deposits_RequestType Get_Customer_Deposits_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Deposits(new Get_Customer_DepositsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Deposits_Request = Get_Customer_Deposits_Request
			}).Get_Customer_Deposits_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_DepositsOutput> Revenue_ManagementPort.Get_Customer_DepositsAsync(Get_Customer_DepositsInput request)
		{
			return base.Channel.Get_Customer_DepositsAsync(request);
		}

		public Task<Get_Customer_DepositsOutput> Get_Customer_DepositsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Deposits_RequestType Get_Customer_Deposits_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_DepositsAsync(new Get_Customer_DepositsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Deposits_Request = Get_Customer_Deposits_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_DepositOutput Revenue_ManagementPort.Submit_Customer_Deposit(Submit_Customer_DepositInput request)
		{
			return base.Channel.Submit_Customer_Deposit(request);
		}

		public Submit_Customer_Deposit_ResponseType Submit_Customer_Deposit(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Deposit_RequestType Submit_Customer_Deposit_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Deposit(new Submit_Customer_DepositInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Deposit_Request = Submit_Customer_Deposit_Request
			}).Submit_Customer_Deposit_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_DepositOutput> Revenue_ManagementPort.Submit_Customer_DepositAsync(Submit_Customer_DepositInput request)
		{
			return base.Channel.Submit_Customer_DepositAsync(request);
		}

		public Task<Submit_Customer_DepositOutput> Submit_Customer_DepositAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Deposit_RequestType Submit_Customer_Deposit_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_DepositAsync(new Submit_Customer_DepositInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Deposit_Request = Submit_Customer_Deposit_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_AwardsOutput Revenue_ManagementPort.Get_Awards(Get_AwardsInput request)
		{
			return base.Channel.Get_Awards(request);
		}

		public Get_Awards_ResponseType Get_Awards(Workday_Common_HeaderType Workday_Common_Header, Get_Awards_RequestType Get_Awards_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Awards(new Get_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Awards_Request = Get_Awards_Request
			}).Get_Awards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_AwardsOutput> Revenue_ManagementPort.Get_AwardsAsync(Get_AwardsInput request)
		{
			return base.Channel.Get_AwardsAsync(request);
		}

		public Task<Get_AwardsOutput> Get_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Awards_RequestType Get_Awards_Request)
		{
			return ((Revenue_ManagementPort)this).Get_AwardsAsync(new Get_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Awards_Request = Get_Awards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_AwardOutput Revenue_ManagementPort.Submit_Award(Submit_AwardInput request)
		{
			return base.Channel.Submit_Award(request);
		}

		public Submit_Award_ResponseType Submit_Award(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_RequestType Submit_Award_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Award(new Submit_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Award_Request = Submit_Award_Request
			}).Submit_Award_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_AwardOutput> Revenue_ManagementPort.Submit_AwardAsync(Submit_AwardInput request)
		{
			return base.Channel.Submit_AwardAsync(request);
		}

		public Task<Submit_AwardOutput> Submit_AwardAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_RequestType Submit_Award_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_AwardAsync(new Submit_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Award_Request = Submit_Award_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Facilities_and_Administration_Basis_TypesOutput Revenue_ManagementPort.Get_Facilities_and_Administration_Basis_Types(Get_Facilities_and_Administration_Basis_TypesInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Basis_Types(request);
		}

		public Get_Facilities_and_Administration_Basis_Types_ResponseType Get_Facilities_and_Administration_Basis_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Basis_Types_RequestType Get_Facilities_and_Administration_Basis_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Basis_Types(new Get_Facilities_and_Administration_Basis_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Basis_Types_Request = Get_Facilities_and_Administration_Basis_Types_Request
			}).Get_Facilities_and_Administration_Basis_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Facilities_and_Administration_Basis_TypesOutput> Revenue_ManagementPort.Get_Facilities_and_Administration_Basis_TypesAsync(Get_Facilities_and_Administration_Basis_TypesInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Basis_TypesAsync(request);
		}

		public Task<Get_Facilities_and_Administration_Basis_TypesOutput> Get_Facilities_and_Administration_Basis_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Basis_Types_RequestType Get_Facilities_and_Administration_Basis_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Basis_TypesAsync(new Get_Facilities_and_Administration_Basis_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Basis_Types_Request = Get_Facilities_and_Administration_Basis_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Facilities_and_Administration_Basis_TypeOutput Revenue_ManagementPort.Put_Facilities_and_Administration_Basis_Type(Put_Facilities_and_Administration_Basis_TypeInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Basis_Type(request);
		}

		public Put_Facilities_and_Administration_Basis_Type_ResponseType Put_Facilities_and_Administration_Basis_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Basis_Type_RequestType Put_Facilities_and_Administration_Basis_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Basis_Type(new Put_Facilities_and_Administration_Basis_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Basis_Type_Request = Put_Facilities_and_Administration_Basis_Type_Request
			}).Put_Facilities_and_Administration_Basis_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Facilities_and_Administration_Basis_TypeOutput> Revenue_ManagementPort.Put_Facilities_and_Administration_Basis_TypeAsync(Put_Facilities_and_Administration_Basis_TypeInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Basis_TypeAsync(request);
		}

		public Task<Put_Facilities_and_Administration_Basis_TypeOutput> Put_Facilities_and_Administration_Basis_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Basis_Type_RequestType Put_Facilities_and_Administration_Basis_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Basis_TypeAsync(new Put_Facilities_and_Administration_Basis_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Basis_Type_Request = Put_Facilities_and_Administration_Basis_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Facilities_and_Administration_Object_Class_MappingsOutput Revenue_ManagementPort.Get_Facilities_and_Administration_Object_Class_Mappings(Get_Facilities_and_Administration_Object_Class_MappingsInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Object_Class_Mappings(request);
		}

		public Get_Facilities_and_Admin_Object_Class_Mappings_ResponseType Get_Facilities_and_Administration_Object_Class_Mappings(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Admin_Object_Class_Mappings_RequestType Get_Facilities_and_Admin_Object_Class_Mappings_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Object_Class_Mappings(new Get_Facilities_and_Administration_Object_Class_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Admin_Object_Class_Mappings_Request = Get_Facilities_and_Admin_Object_Class_Mappings_Request
			}).Get_Facilities_and_Admin_Object_Class_Mappings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Facilities_and_Administration_Object_Class_MappingsOutput> Revenue_ManagementPort.Get_Facilities_and_Administration_Object_Class_MappingsAsync(Get_Facilities_and_Administration_Object_Class_MappingsInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Object_Class_MappingsAsync(request);
		}

		public Task<Get_Facilities_and_Administration_Object_Class_MappingsOutput> Get_Facilities_and_Administration_Object_Class_MappingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Admin_Object_Class_Mappings_RequestType Get_Facilities_and_Admin_Object_Class_Mappings_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Object_Class_MappingsAsync(new Get_Facilities_and_Administration_Object_Class_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Admin_Object_Class_Mappings_Request = Get_Facilities_and_Admin_Object_Class_Mappings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Facilities_and_Administration_Object_Class_MappingOutput Revenue_ManagementPort.Put_Facilities_and_Administration_Object_Class_Mapping(Put_Facilities_and_Administration_Object_Class_MappingInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Object_Class_Mapping(request);
		}

		public Put_Facilities_and_Admin_Object_Class_Mapping_ResponseType Put_Facilities_and_Administration_Object_Class_Mapping(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Admin_Object_Class_Mapping_RequestType Put_Facilities_and_Admin_Object_Class_Mapping_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Object_Class_Mapping(new Put_Facilities_and_Administration_Object_Class_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Admin_Object_Class_Mapping_Request = Put_Facilities_and_Admin_Object_Class_Mapping_Request
			}).Put_Facilities_and_Admin_Object_Class_Mapping_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Facilities_and_Administration_Object_Class_MappingOutput> Revenue_ManagementPort.Put_Facilities_and_Administration_Object_Class_MappingAsync(Put_Facilities_and_Administration_Object_Class_MappingInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Object_Class_MappingAsync(request);
		}

		public Task<Put_Facilities_and_Administration_Object_Class_MappingOutput> Put_Facilities_and_Administration_Object_Class_MappingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Admin_Object_Class_Mapping_RequestType Put_Facilities_and_Admin_Object_Class_Mapping_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Object_Class_MappingAsync(new Put_Facilities_and_Administration_Object_Class_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Admin_Object_Class_Mapping_Request = Put_Facilities_and_Admin_Object_Class_Mapping_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SponsorsOutput Revenue_ManagementPort.Get_Sponsors(Get_SponsorsInput request)
		{
			return base.Channel.Get_Sponsors(request);
		}

		public Get_Sponsors_ResponseType Get_Sponsors(Workday_Common_HeaderType Workday_Common_Header, Get_Sponsors_RequestType Get_Sponsors_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sponsors(new Get_SponsorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sponsors_Request = Get_Sponsors_Request
			}).Get_Sponsors_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SponsorsOutput> Revenue_ManagementPort.Get_SponsorsAsync(Get_SponsorsInput request)
		{
			return base.Channel.Get_SponsorsAsync(request);
		}

		public Task<Get_SponsorsOutput> Get_SponsorsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Sponsors_RequestType Get_Sponsors_Request)
		{
			return ((Revenue_ManagementPort)this).Get_SponsorsAsync(new Get_SponsorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sponsors_Request = Get_Sponsors_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SponsorOutput Revenue_ManagementPort.Put_Sponsor(Put_SponsorInput request)
		{
			return base.Channel.Put_Sponsor(request);
		}

		public Put_Sponsor_ResponseType Put_Sponsor(Workday_Common_HeaderType Workday_Common_Header, Put_Sponsor_RequestType Put_Sponsor_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sponsor(new Put_SponsorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sponsor_Request = Put_Sponsor_Request
			}).Put_Sponsor_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SponsorOutput> Revenue_ManagementPort.Put_SponsorAsync(Put_SponsorInput request)
		{
			return base.Channel.Put_SponsorAsync(request);
		}

		public Task<Put_SponsorOutput> Put_SponsorAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Sponsor_RequestType Put_Sponsor_Request)
		{
			return ((Revenue_ManagementPort)this).Put_SponsorAsync(new Put_SponsorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sponsor_Request = Put_Sponsor_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_RefundOutput Revenue_ManagementPort.Submit_Customer_Refund(Submit_Customer_RefundInput request)
		{
			return base.Channel.Submit_Customer_Refund(request);
		}

		public Submit_Customer_Refund_ResponseType Submit_Customer_Refund(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Refund_RequestType Submit_Customer_Refund_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Refund(new Submit_Customer_RefundInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Refund_Request = Submit_Customer_Refund_Request
			}).Submit_Customer_Refund_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_RefundOutput> Revenue_ManagementPort.Submit_Customer_RefundAsync(Submit_Customer_RefundInput request)
		{
			return base.Channel.Submit_Customer_RefundAsync(request);
		}

		public Task<Submit_Customer_RefundOutput> Submit_Customer_RefundAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Refund_RequestType Submit_Customer_Refund_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_RefundAsync(new Submit_Customer_RefundInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Refund_Request = Submit_Customer_Refund_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_SchedulesOutput Revenue_ManagementPort.Get_Award_Schedules(Get_Award_SchedulesInput request)
		{
			return base.Channel.Get_Award_Schedules(request);
		}

		public Get_Award_Schedules_ResponseType Get_Award_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Schedules_RequestType Get_Award_Schedules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Schedules(new Get_Award_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Schedules_Request = Get_Award_Schedules_Request
			}).Get_Award_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_SchedulesOutput> Revenue_ManagementPort.Get_Award_SchedulesAsync(Get_Award_SchedulesInput request)
		{
			return base.Channel.Get_Award_SchedulesAsync(request);
		}

		public Task<Get_Award_SchedulesOutput> Get_Award_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Schedules_RequestType Get_Award_Schedules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_SchedulesAsync(new Get_Award_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Schedules_Request = Get_Award_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_ScheduleOutput Revenue_ManagementPort.Put_Award_Schedule(Put_Award_ScheduleInput request)
		{
			return base.Channel.Put_Award_Schedule(request);
		}

		public Put_Award_Schedule_ResponseType Put_Award_Schedule(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Schedule_RequestType Put_Award_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Schedule(new Put_Award_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Schedule_Request = Put_Award_Schedule_Request
			}).Put_Award_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_ScheduleOutput> Revenue_ManagementPort.Put_Award_ScheduleAsync(Put_Award_ScheduleInput request)
		{
			return base.Channel.Put_Award_ScheduleAsync(request);
		}

		public Task<Put_Award_ScheduleOutput> Put_Award_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Schedule_RequestType Put_Award_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_ScheduleAsync(new Put_Award_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Schedule_Request = Put_Award_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_Date_MilestonesOutput Revenue_ManagementPort.Get_Customer_Date_Milestones(Get_Customer_Date_MilestonesInput request)
		{
			return base.Channel.Get_Customer_Date_Milestones(request);
		}

		public Get_Customer_Date_Milestones_ResponseType Get_Customer_Date_Milestones(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Date_Milestones_RequestType Get_Customer_Date_Milestones_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Date_Milestones(new Get_Customer_Date_MilestonesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Date_Milestones_Request = Get_Customer_Date_Milestones_Request
			}).Get_Customer_Date_Milestones_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_Date_MilestonesOutput> Revenue_ManagementPort.Get_Customer_Date_MilestonesAsync(Get_Customer_Date_MilestonesInput request)
		{
			return base.Channel.Get_Customer_Date_MilestonesAsync(request);
		}

		public Task<Get_Customer_Date_MilestonesOutput> Get_Customer_Date_MilestonesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Date_Milestones_RequestType Get_Customer_Date_Milestones_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Date_MilestonesAsync(new Get_Customer_Date_MilestonesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Date_Milestones_Request = Get_Customer_Date_Milestones_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_Date_MilestoneOutput Revenue_ManagementPort.Put_Customer_Date_Milestone(Put_Customer_Date_MilestoneInput request)
		{
			return base.Channel.Put_Customer_Date_Milestone(request);
		}

		public Put_Customer_Date_Milestone_ResponseType Put_Customer_Date_Milestone(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Date_Milestone_RequestType Put_Customer_Date_Milestone_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Date_Milestone(new Put_Customer_Date_MilestoneInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Date_Milestone_Request = Put_Customer_Date_Milestone_Request
			}).Put_Customer_Date_Milestone_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_Date_MilestoneOutput> Revenue_ManagementPort.Put_Customer_Date_MilestoneAsync(Put_Customer_Date_MilestoneInput request)
		{
			return base.Channel.Put_Customer_Date_MilestoneAsync(request);
		}

		public Task<Put_Customer_Date_MilestoneOutput> Put_Customer_Date_MilestoneAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Date_Milestone_RequestType Put_Customer_Date_Milestone_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Date_MilestoneAsync(new Put_Customer_Date_MilestoneInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Date_Milestone_Request = Put_Customer_Date_Milestone_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Billing_SchedulesOutput Revenue_ManagementPort.Get_Billing_Schedules(Get_Billing_SchedulesInput request)
		{
			return base.Channel.Get_Billing_Schedules(request);
		}

		public Get_Billing_Schedules_ResponseType Get_Billing_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Billing_Schedules_RequestType Get_Billing_Schedules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Billing_Schedules(new Get_Billing_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Billing_Schedules_Request = Get_Billing_Schedules_Request
			}).Get_Billing_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Billing_SchedulesOutput> Revenue_ManagementPort.Get_Billing_SchedulesAsync(Get_Billing_SchedulesInput request)
		{
			return base.Channel.Get_Billing_SchedulesAsync(request);
		}

		public Task<Get_Billing_SchedulesOutput> Get_Billing_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Billing_Schedules_RequestType Get_Billing_Schedules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Billing_SchedulesAsync(new Get_Billing_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Billing_Schedules_Request = Get_Billing_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Billing_ScheduleOutput Revenue_ManagementPort.Submit_Billing_Schedule(Submit_Billing_ScheduleInput request)
		{
			return base.Channel.Submit_Billing_Schedule(request);
		}

		public Submit_Billing_Schedule_ResponseType Submit_Billing_Schedule(Workday_Common_HeaderType Workday_Common_Header, Submit_Billing_Schedule_RequestType Submit_Billing_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Billing_Schedule(new Submit_Billing_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Billing_Schedule_Request = Submit_Billing_Schedule_Request
			}).Submit_Billing_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Billing_ScheduleOutput> Revenue_ManagementPort.Submit_Billing_ScheduleAsync(Submit_Billing_ScheduleInput request)
		{
			return base.Channel.Submit_Billing_ScheduleAsync(request);
		}

		public Task<Submit_Billing_ScheduleOutput> Submit_Billing_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Billing_Schedule_RequestType Submit_Billing_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Billing_ScheduleAsync(new Submit_Billing_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Billing_Schedule_Request = Submit_Billing_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Facilities_and_Admin_Cost_Rate_Type_TypesOutput Revenue_ManagementPort.Get_Facilities_and_Admin_Cost_Rate_Type_Types(Get_Facilities_and_Admin_Cost_Rate_Type_TypesInput request)
		{
			return base.Channel.Get_Facilities_and_Admin_Cost_Rate_Type_Types(request);
		}

		public Get_Facilities_and_Admin_Cost_Rate_Type_Types_ResponseType Get_Facilities_and_Admin_Cost_Rate_Type_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Admin_Cost_Rate_Type_Types_RequestType Get_Facilities_and_Admin_Cost_Rate_Type_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Admin_Cost_Rate_Type_Types(new Get_Facilities_and_Admin_Cost_Rate_Type_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Admin_Cost_Rate_Type_Types_Request = Get_Facilities_and_Admin_Cost_Rate_Type_Types_Request
			}).Get_Facilities_and_Admin_Cost_Rate_Type_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Facilities_and_Admin_Cost_Rate_Type_TypesOutput> Revenue_ManagementPort.Get_Facilities_and_Admin_Cost_Rate_Type_TypesAsync(Get_Facilities_and_Admin_Cost_Rate_Type_TypesInput request)
		{
			return base.Channel.Get_Facilities_and_Admin_Cost_Rate_Type_TypesAsync(request);
		}

		public Task<Get_Facilities_and_Admin_Cost_Rate_Type_TypesOutput> Get_Facilities_and_Admin_Cost_Rate_Type_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Admin_Cost_Rate_Type_Types_RequestType Get_Facilities_and_Admin_Cost_Rate_Type_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Admin_Cost_Rate_Type_TypesAsync(new Get_Facilities_and_Admin_Cost_Rate_Type_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Admin_Cost_Rate_Type_Types_Request = Get_Facilities_and_Admin_Cost_Rate_Type_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Revenue_Recognition_SchedulesOutput Revenue_ManagementPort.Get_Revenue_Recognition_Schedules(Get_Revenue_Recognition_SchedulesInput request)
		{
			return base.Channel.Get_Revenue_Recognition_Schedules(request);
		}

		public Get_Revenue_Recognition_Schedules_ResponseType Get_Revenue_Recognition_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Recognition_Schedules_RequestType Get_Revenue_Recognition_Schedules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Recognition_Schedules(new Get_Revenue_Recognition_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Recognition_Schedules_Request = Get_Revenue_Recognition_Schedules_Request
			}).Get_Revenue_Recognition_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Revenue_Recognition_SchedulesOutput> Revenue_ManagementPort.Get_Revenue_Recognition_SchedulesAsync(Get_Revenue_Recognition_SchedulesInput request)
		{
			return base.Channel.Get_Revenue_Recognition_SchedulesAsync(request);
		}

		public Task<Get_Revenue_Recognition_SchedulesOutput> Get_Revenue_Recognition_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Recognition_Schedules_RequestType Get_Revenue_Recognition_Schedules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Recognition_SchedulesAsync(new Get_Revenue_Recognition_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Recognition_Schedules_Request = Get_Revenue_Recognition_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Revenue_Recognition_ScheduleOutput Revenue_ManagementPort.Submit_Revenue_Recognition_Schedule(Submit_Revenue_Recognition_ScheduleInput request)
		{
			return base.Channel.Submit_Revenue_Recognition_Schedule(request);
		}

		public Submit_Revenue_Recognition_Schedule_ResponseType Submit_Revenue_Recognition_Schedule(Workday_Common_HeaderType Workday_Common_Header, Submit_Revenue_Recognition_Schedule_RequestType Submit_Revenue_Recognition_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Revenue_Recognition_Schedule(new Submit_Revenue_Recognition_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Revenue_Recognition_Schedule_Request = Submit_Revenue_Recognition_Schedule_Request
			}).Submit_Revenue_Recognition_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Revenue_Recognition_ScheduleOutput> Revenue_ManagementPort.Submit_Revenue_Recognition_ScheduleAsync(Submit_Revenue_Recognition_ScheduleInput request)
		{
			return base.Channel.Submit_Revenue_Recognition_ScheduleAsync(request);
		}

		public Task<Submit_Revenue_Recognition_ScheduleOutput> Submit_Revenue_Recognition_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Revenue_Recognition_Schedule_RequestType Submit_Revenue_Recognition_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Revenue_Recognition_ScheduleAsync(new Submit_Revenue_Recognition_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Revenue_Recognition_Schedule_Request = Submit_Revenue_Recognition_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Facilities_and_Administration_Rate_AgreementsOutput Revenue_ManagementPort.Get_Facilities_and_Administration_Rate_Agreements(Get_Facilities_and_Administration_Rate_AgreementsInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Rate_Agreements(request);
		}

		public Get_Facilities_and_Administration_Rate_Agreements_ResponseType Get_Facilities_and_Administration_Rate_Agreements(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Rate_Agreements_RequestType Get_Facilities_and_Administration_Rate_Agreements_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Rate_Agreements(new Get_Facilities_and_Administration_Rate_AgreementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Rate_Agreements_Request = Get_Facilities_and_Administration_Rate_Agreements_Request
			}).Get_Facilities_and_Administration_Rate_Agreements_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Facilities_and_Administration_Rate_AgreementsOutput> Revenue_ManagementPort.Get_Facilities_and_Administration_Rate_AgreementsAsync(Get_Facilities_and_Administration_Rate_AgreementsInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Rate_AgreementsAsync(request);
		}

		public Task<Get_Facilities_and_Administration_Rate_AgreementsOutput> Get_Facilities_and_Administration_Rate_AgreementsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Rate_Agreements_RequestType Get_Facilities_and_Administration_Rate_Agreements_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Rate_AgreementsAsync(new Get_Facilities_and_Administration_Rate_AgreementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Rate_Agreements_Request = Get_Facilities_and_Administration_Rate_Agreements_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Facilities_and_Administration_Rate_AgreementOutput Revenue_ManagementPort.Put_Facilities_and_Administration_Rate_Agreement(Put_Facilities_and_Administration_Rate_AgreementInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Rate_Agreement(request);
		}

		public Put_Facilities_and_Administration_Rate_Agreement_ResponseType Put_Facilities_and_Administration_Rate_Agreement(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Rate_Agreement_RequestType Put_Facilities_and_Administration_Rate_Agreement_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Rate_Agreement(new Put_Facilities_and_Administration_Rate_AgreementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Rate_Agreement_Request = Put_Facilities_and_Administration_Rate_Agreement_Request
			}).Put_Facilities_and_Administration_Rate_Agreement_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Facilities_and_Administration_Rate_AgreementOutput> Revenue_ManagementPort.Put_Facilities_and_Administration_Rate_AgreementAsync(Put_Facilities_and_Administration_Rate_AgreementInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Rate_AgreementAsync(request);
		}

		public Task<Put_Facilities_and_Administration_Rate_AgreementOutput> Put_Facilities_and_Administration_Rate_AgreementAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Rate_Agreement_RequestType Put_Facilities_and_Administration_Rate_Agreement_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Rate_AgreementAsync(new Put_Facilities_and_Administration_Rate_AgreementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Rate_Agreement_Request = Put_Facilities_and_Administration_Rate_Agreement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput Revenue_ManagementPort.Put_Facilities_and_Admin_Cost_Rate_Type_Type(Put_Facilities_and_Admin_Cost_Rate_Type_TypeInput request)
		{
			return base.Channel.Put_Facilities_and_Admin_Cost_Rate_Type_Type(request);
		}

		public Put_Facilities_and_Admin_Cost_Rate_Type_Type_ResponseType Put_Facilities_and_Admin_Cost_Rate_Type_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Admin_Cost_Rate_Type_Type_RequestType Put_Facilities_and_Admin_Cost_Rate_Type_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Admin_Cost_Rate_Type_Type(new Put_Facilities_and_Admin_Cost_Rate_Type_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Admin_Cost_Rate_Type_Type_Request = Put_Facilities_and_Admin_Cost_Rate_Type_Type_Request
			}).Put_Facilities_and_Admin_Cost_Rate_Type_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput> Revenue_ManagementPort.Put_Facilities_and_Admin_Cost_Rate_Type_TypeAsync(Put_Facilities_and_Admin_Cost_Rate_Type_TypeInput request)
		{
			return base.Channel.Put_Facilities_and_Admin_Cost_Rate_Type_TypeAsync(request);
		}

		public Task<Put_Facilities_and_Admin_Cost_Rate_Type_TypeOutput> Put_Facilities_and_Admin_Cost_Rate_Type_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Admin_Cost_Rate_Type_Type_RequestType Put_Facilities_and_Admin_Cost_Rate_Type_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Admin_Cost_Rate_Type_TypeAsync(new Put_Facilities_and_Admin_Cost_Rate_Type_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Admin_Cost_Rate_Type_Type_Request = Put_Facilities_and_Admin_Cost_Rate_Type_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Facilities_and_Administration_ExceptionsOutput Revenue_ManagementPort.Get_Facilities_and_Administration_Exceptions(Get_Facilities_and_Administration_ExceptionsInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Exceptions(request);
		}

		public Get_Facilities_and_Administration_Exceptions_ResponseType Get_Facilities_and_Administration_Exceptions(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Exceptions_RequestType Get_Facilities_and_Administration_Exceptions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Exceptions(new Get_Facilities_and_Administration_ExceptionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Exceptions_Request = Get_Facilities_and_Administration_Exceptions_Request
			}).Get_Facilities_and_Administration_Exceptions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Facilities_and_Administration_ExceptionsOutput> Revenue_ManagementPort.Get_Facilities_and_Administration_ExceptionsAsync(Get_Facilities_and_Administration_ExceptionsInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_ExceptionsAsync(request);
		}

		public Task<Get_Facilities_and_Administration_ExceptionsOutput> Get_Facilities_and_Administration_ExceptionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Exceptions_RequestType Get_Facilities_and_Administration_Exceptions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_ExceptionsAsync(new Get_Facilities_and_Administration_ExceptionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Exceptions_Request = Get_Facilities_and_Administration_Exceptions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Facilities_and_Administration_ExceptionOutput Revenue_ManagementPort.Put_Facilities_and_Administration_Exception(Put_Facilities_and_Administration_ExceptionInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Exception(request);
		}

		public Put_Facilities_and_Administration_Exception_ResponseType Put_Facilities_and_Administration_Exception(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Exception_RequestType Put_Facilities_and_Administration_Exception_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Exception(new Put_Facilities_and_Administration_ExceptionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Exception_Request = Put_Facilities_and_Administration_Exception_Request
			}).Put_Facilities_and_Administration_Exception_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Facilities_and_Administration_ExceptionOutput> Revenue_ManagementPort.Put_Facilities_and_Administration_ExceptionAsync(Put_Facilities_and_Administration_ExceptionInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_ExceptionAsync(request);
		}

		public Task<Put_Facilities_and_Administration_ExceptionOutput> Put_Facilities_and_Administration_ExceptionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Exception_RequestType Put_Facilities_and_Administration_Exception_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_ExceptionAsync(new Put_Facilities_and_Administration_ExceptionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Exception_Request = Put_Facilities_and_Administration_Exception_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_ProposalsOutput Revenue_ManagementPort.Get_Award_Proposals(Get_Award_ProposalsInput request)
		{
			return base.Channel.Get_Award_Proposals(request);
		}

		public Get_Award_Proposals_ResponseType Get_Award_Proposals(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Proposals_RequestType Get_Award_Proposals_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Proposals(new Get_Award_ProposalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Proposals_Request = Get_Award_Proposals_Request
			}).Get_Award_Proposals_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_ProposalsOutput> Revenue_ManagementPort.Get_Award_ProposalsAsync(Get_Award_ProposalsInput request)
		{
			return base.Channel.Get_Award_ProposalsAsync(request);
		}

		public Task<Get_Award_ProposalsOutput> Get_Award_ProposalsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Proposals_RequestType Get_Award_Proposals_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_ProposalsAsync(new Get_Award_ProposalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Proposals_Request = Get_Award_Proposals_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Award_ProposalOutput Revenue_ManagementPort.Submit_Award_Proposal(Submit_Award_ProposalInput request)
		{
			return base.Channel.Submit_Award_Proposal(request);
		}

		public Submit_Award_Proposal_ResponseType Submit_Award_Proposal(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_Proposal_RequestType Submit_Award_Proposal_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Award_Proposal(new Submit_Award_ProposalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Award_Proposal_Request = Submit_Award_Proposal_Request
			}).Submit_Award_Proposal_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Award_ProposalOutput> Revenue_ManagementPort.Submit_Award_ProposalAsync(Submit_Award_ProposalInput request)
		{
			return base.Channel.Submit_Award_ProposalAsync(request);
		}

		public Task<Submit_Award_ProposalOutput> Submit_Award_ProposalAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_Proposal_RequestType Submit_Award_Proposal_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Award_ProposalAsync(new Submit_Award_ProposalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Award_Proposal_Request = Submit_Award_Proposal_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Customer_ContractOutput Revenue_ManagementPort.Cancel_Customer_Contract(Cancel_Customer_ContractInput request)
		{
			return base.Channel.Cancel_Customer_Contract(request);
		}

		public Cancel_Customer_Contract_ResponseType Cancel_Customer_Contract(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Contract_RequestType Cancel_Customer_Contract_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Customer_Contract(new Cancel_Customer_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Customer_Contract_Request = Cancel_Customer_Contract_Request
			}).Cancel_Customer_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Customer_ContractOutput> Revenue_ManagementPort.Cancel_Customer_ContractAsync(Cancel_Customer_ContractInput request)
		{
			return base.Channel.Cancel_Customer_ContractAsync(request);
		}

		public Task<Cancel_Customer_ContractOutput> Cancel_Customer_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Customer_Contract_RequestType Cancel_Customer_Contract_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Customer_ContractAsync(new Cancel_Customer_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Customer_Contract_Request = Cancel_Customer_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesOutput Revenue_ManagementPort.Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles(Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles(request);
		}

		public Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_ResponseType Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_RequestType Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles(new Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Request = Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Request
			}).Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesOutput> Revenue_ManagementPort.Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesAsync(Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesInput request)
		{
			return base.Channel.Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesAsync(request);
		}

		public Task<Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesOutput> Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_RequestType Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesAsync(new Get_Facilities_and_Administration_Waived_Expense_Allocation_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Request = Get_Facilities_and_Administration_Waived_Expense_Allocation_Profiles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput Revenue_ManagementPort.Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile(Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile(request);
		}

		public Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_ResponseType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_RequestType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile(new Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request = Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request
			}).Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput> Revenue_ManagementPort.Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileAsync(Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput request)
		{
			return base.Channel.Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileAsync(request);
		}

		public Task<Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput> Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_RequestType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileAsync(new Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request = Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Revenue_Category_HierarchiesOutput Revenue_ManagementPort.Get_Revenue_Category_Hierarchies(Get_Revenue_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Revenue_Category_Hierarchies(request);
		}

		public Get_Revenue_Category_Hierarchies_ResponseType Get_Revenue_Category_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Category_Hierarchies_RequestType Get_Revenue_Category_Hierarchies_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Category_Hierarchies(new Get_Revenue_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Category_Hierarchies_Request = Get_Revenue_Category_Hierarchies_Request
			}).Get_Revenue_Category_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Revenue_Category_HierarchiesOutput> Revenue_ManagementPort.Get_Revenue_Category_HierarchiesAsync(Get_Revenue_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Revenue_Category_HierarchiesAsync(request);
		}

		public Task<Get_Revenue_Category_HierarchiesOutput> Get_Revenue_Category_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Category_Hierarchies_RequestType Get_Revenue_Category_Hierarchies_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Category_HierarchiesAsync(new Get_Revenue_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Category_Hierarchies_Request = Get_Revenue_Category_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Revenue_Category_HierarchyOutput Revenue_ManagementPort.Put_Revenue_Category_Hierarchy(Put_Revenue_Category_HierarchyInput request)
		{
			return base.Channel.Put_Revenue_Category_Hierarchy(request);
		}

		public Put_Revenue_Category_Hierarchy_ResponseType Put_Revenue_Category_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_Hierarchy_RequestType Put_Revenue_Category_Hierarchy_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Revenue_Category_Hierarchy(new Put_Revenue_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Hierarchy_Request = Put_Revenue_Category_Hierarchy_Request
			}).Put_Revenue_Category_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Revenue_Category_HierarchyOutput> Revenue_ManagementPort.Put_Revenue_Category_HierarchyAsync(Put_Revenue_Category_HierarchyInput request)
		{
			return base.Channel.Put_Revenue_Category_HierarchyAsync(request);
		}

		public Task<Put_Revenue_Category_HierarchyOutput> Put_Revenue_Category_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_Hierarchy_RequestType Put_Revenue_Category_Hierarchy_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Revenue_Category_HierarchyAsync(new Put_Revenue_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Hierarchy_Request = Put_Revenue_Category_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Award_AmendmentOutput Revenue_ManagementPort.Submit_Award_Amendment(Submit_Award_AmendmentInput request)
		{
			return base.Channel.Submit_Award_Amendment(request);
		}

		public Submit_Award_Amendment_ResponseType Submit_Award_Amendment(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_Amendment_RequestType Submit_Award_Amendment_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Award_Amendment(new Submit_Award_AmendmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Award_Amendment_Request = Submit_Award_Amendment_Request
			}).Submit_Award_Amendment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Award_AmendmentOutput> Revenue_ManagementPort.Submit_Award_AmendmentAsync(Submit_Award_AmendmentInput request)
		{
			return base.Channel.Submit_Award_AmendmentAsync(request);
		}

		public Task<Submit_Award_AmendmentOutput> Submit_Award_AmendmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Award_Amendment_RequestType Submit_Award_Amendment_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Award_AmendmentAsync(new Submit_Award_AmendmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Award_Amendment_Request = Submit_Award_Amendment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Proposal_Submission_TypesOutput Revenue_ManagementPort.Get_Award_Proposal_Submission_Types(Get_Award_Proposal_Submission_TypesInput request)
		{
			return base.Channel.Get_Award_Proposal_Submission_Types(request);
		}

		public Get_Award_Proposal_Submission_Types_ResponseType Get_Award_Proposal_Submission_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Proposal_Submission_Types_RequestType Get_Award_Proposal_Submission_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Proposal_Submission_Types(new Get_Award_Proposal_Submission_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Proposal_Submission_Types_Request = Get_Award_Proposal_Submission_Types_Request
			}).Get_Award_Proposal_Submission_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Proposal_Submission_TypesOutput> Revenue_ManagementPort.Get_Award_Proposal_Submission_TypesAsync(Get_Award_Proposal_Submission_TypesInput request)
		{
			return base.Channel.Get_Award_Proposal_Submission_TypesAsync(request);
		}

		public Task<Get_Award_Proposal_Submission_TypesOutput> Get_Award_Proposal_Submission_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Proposal_Submission_Types_RequestType Get_Award_Proposal_Submission_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Proposal_Submission_TypesAsync(new Get_Award_Proposal_Submission_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Proposal_Submission_Types_Request = Get_Award_Proposal_Submission_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Proposal_Submission_TypeOutput Revenue_ManagementPort.Put_Award_Proposal_Submission_Type(Put_Award_Proposal_Submission_TypeInput request)
		{
			return base.Channel.Put_Award_Proposal_Submission_Type(request);
		}

		public Put_Award_Proposal_Submission_Type_ResponseType Put_Award_Proposal_Submission_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Proposal_Submission_Type_RequestType Put_Award_Proposal_Submission_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Proposal_Submission_Type(new Put_Award_Proposal_Submission_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Proposal_Submission_Type_Request = Put_Award_Proposal_Submission_Type_Request
			}).Put_Award_Proposal_Submission_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Proposal_Submission_TypeOutput> Revenue_ManagementPort.Put_Award_Proposal_Submission_TypeAsync(Put_Award_Proposal_Submission_TypeInput request)
		{
			return base.Channel.Put_Award_Proposal_Submission_TypeAsync(request);
		}

		public Task<Put_Award_Proposal_Submission_TypeOutput> Put_Award_Proposal_Submission_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Proposal_Submission_Type_RequestType Put_Award_Proposal_Submission_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Proposal_Submission_TypeAsync(new Put_Award_Proposal_Submission_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Proposal_Submission_Type_Request = Put_Award_Proposal_Submission_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Proposal_Lifecycle_StatusesOutput Revenue_ManagementPort.Get_Award_Proposal_Lifecycle_Statuses(Get_Award_Proposal_Lifecycle_StatusesInput request)
		{
			return base.Channel.Get_Award_Proposal_Lifecycle_Statuses(request);
		}

		public Get_Award_Proposal_Lifecycle_Statuses_ResponseType Get_Award_Proposal_Lifecycle_Statuses(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Proposal_Lifecycle_Statuses_RequestType Get_Award_Proposal_Lifecycle_Statuses_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Proposal_Lifecycle_Statuses(new Get_Award_Proposal_Lifecycle_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Proposal_Lifecycle_Statuses_Request = Get_Award_Proposal_Lifecycle_Statuses_Request
			}).Get_Award_Proposal_Lifecycle_Statuses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Proposal_Lifecycle_StatusesOutput> Revenue_ManagementPort.Get_Award_Proposal_Lifecycle_StatusesAsync(Get_Award_Proposal_Lifecycle_StatusesInput request)
		{
			return base.Channel.Get_Award_Proposal_Lifecycle_StatusesAsync(request);
		}

		public Task<Get_Award_Proposal_Lifecycle_StatusesOutput> Get_Award_Proposal_Lifecycle_StatusesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Proposal_Lifecycle_Statuses_RequestType Get_Award_Proposal_Lifecycle_Statuses_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Proposal_Lifecycle_StatusesAsync(new Get_Award_Proposal_Lifecycle_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Proposal_Lifecycle_Statuses_Request = Get_Award_Proposal_Lifecycle_Statuses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Proposal_Lifecycle_StatusOutput Revenue_ManagementPort.Put_Award_Proposal_Lifecycle_Status(Put_Award_Proposal_Lifecycle_StatusInput request)
		{
			return base.Channel.Put_Award_Proposal_Lifecycle_Status(request);
		}

		public Put_Award_Proposal_Lifecycle_Status_ResponseType Put_Award_Proposal_Lifecycle_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Proposal_Lifecycle_Status_RequestType Put_Award_Proposal_Lifecycle_Status_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Proposal_Lifecycle_Status(new Put_Award_Proposal_Lifecycle_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Proposal_Lifecycle_Status_Request = Put_Award_Proposal_Lifecycle_Status_Request
			}).Put_Award_Proposal_Lifecycle_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Proposal_Lifecycle_StatusOutput> Revenue_ManagementPort.Put_Award_Proposal_Lifecycle_StatusAsync(Put_Award_Proposal_Lifecycle_StatusInput request)
		{
			return base.Channel.Put_Award_Proposal_Lifecycle_StatusAsync(request);
		}

		public Task<Put_Award_Proposal_Lifecycle_StatusOutput> Put_Award_Proposal_Lifecycle_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Proposal_Lifecycle_Status_RequestType Put_Award_Proposal_Lifecycle_Status_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Proposal_Lifecycle_StatusAsync(new Put_Award_Proposal_Lifecycle_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Proposal_Lifecycle_Status_Request = Put_Award_Proposal_Lifecycle_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_Contract_AmendmentOutput Revenue_ManagementPort.Submit_Customer_Contract_Amendment(Submit_Customer_Contract_AmendmentInput request)
		{
			return base.Channel.Submit_Customer_Contract_Amendment(request);
		}

		public Submit_Customer_Contract_Amendment_ResponseType Submit_Customer_Contract_Amendment(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Contract_Amendment_RequestType Submit_Customer_Contract_Amendment_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Contract_Amendment(new Submit_Customer_Contract_AmendmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Contract_Amendment_Request = Submit_Customer_Contract_Amendment_Request
			}).Submit_Customer_Contract_Amendment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_Contract_AmendmentOutput> Revenue_ManagementPort.Submit_Customer_Contract_AmendmentAsync(Submit_Customer_Contract_AmendmentInput request)
		{
			return base.Channel.Submit_Customer_Contract_AmendmentAsync(request);
		}

		public Task<Submit_Customer_Contract_AmendmentOutput> Submit_Customer_Contract_AmendmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Contract_Amendment_RequestType Submit_Customer_Contract_Amendment_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Contract_AmendmentAsync(new Submit_Customer_Contract_AmendmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Contract_Amendment_Request = Submit_Customer_Contract_Amendment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_Contract_AmendmentsOutput Revenue_ManagementPort.Get_Customer_Contract_Amendments(Get_Customer_Contract_AmendmentsInput request)
		{
			return base.Channel.Get_Customer_Contract_Amendments(request);
		}

		public Get_Customer_Contract_Amendments_ResponseType Get_Customer_Contract_Amendments(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contract_Amendments_RequestType Get_Customer_Contract_Amendments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Contract_Amendments(new Get_Customer_Contract_AmendmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Contract_Amendments_Request = Get_Customer_Contract_Amendments_Request
			}).Get_Customer_Contract_Amendments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_Contract_AmendmentsOutput> Revenue_ManagementPort.Get_Customer_Contract_AmendmentsAsync(Get_Customer_Contract_AmendmentsInput request)
		{
			return base.Channel.Get_Customer_Contract_AmendmentsAsync(request);
		}

		public Task<Get_Customer_Contract_AmendmentsOutput> Get_Customer_Contract_AmendmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contract_Amendments_RequestType Get_Customer_Contract_Amendments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Contract_AmendmentsAsync(new Get_Customer_Contract_AmendmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Contract_Amendments_Request = Get_Customer_Contract_Amendments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_ConnectionOutput Revenue_ManagementPort.Put_Business_Connection(Put_Business_ConnectionInput request)
		{
			return base.Channel.Put_Business_Connection(request);
		}

		public Put_Business_Connection_ResponseType Put_Business_Connection(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Connection_RequestType Put_Business_Connection_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Business_Connection(new Put_Business_ConnectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Connection_Request = Put_Business_Connection_Request
			}).Put_Business_Connection_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_ConnectionOutput> Revenue_ManagementPort.Put_Business_ConnectionAsync(Put_Business_ConnectionInput request)
		{
			return base.Channel.Put_Business_ConnectionAsync(request);
		}

		public Task<Put_Business_ConnectionOutput> Put_Business_ConnectionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Connection_RequestType Put_Business_Connection_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Business_ConnectionAsync(new Put_Business_ConnectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Connection_Request = Put_Business_Connection_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_ConnectionsOutput Revenue_ManagementPort.Get_Business_Connections(Get_Business_ConnectionsInput request)
		{
			return base.Channel.Get_Business_Connections(request);
		}

		public Get_Business_Connections_ResponseType Get_Business_Connections(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Connections_RequestType Get_Business_Connections_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Business_Connections(new Get_Business_ConnectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Connections_Request = Get_Business_Connections_Request
			}).Get_Business_Connections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_ConnectionsOutput> Revenue_ManagementPort.Get_Business_ConnectionsAsync(Get_Business_ConnectionsInput request)
		{
			return base.Channel.Get_Business_ConnectionsAsync(request);
		}

		public Task<Get_Business_ConnectionsOutput> Get_Business_ConnectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Connections_RequestType Get_Business_Connections_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Business_ConnectionsAsync(new Get_Business_ConnectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Connections_Request = Get_Business_Connections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Task_Type_GroupsOutput Revenue_ManagementPort.Get_Award_Task_Type_Groups(Get_Award_Task_Type_GroupsInput request)
		{
			return base.Channel.Get_Award_Task_Type_Groups(request);
		}

		public Get_Award_Task_Type_Groups_ResponseType Get_Award_Task_Type_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Task_Type_Groups_RequestType Get_Award_Task_Type_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Task_Type_Groups(new Get_Award_Task_Type_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Task_Type_Groups_Request = Get_Award_Task_Type_Groups_Request
			}).Get_Award_Task_Type_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Task_Type_GroupsOutput> Revenue_ManagementPort.Get_Award_Task_Type_GroupsAsync(Get_Award_Task_Type_GroupsInput request)
		{
			return base.Channel.Get_Award_Task_Type_GroupsAsync(request);
		}

		public Task<Get_Award_Task_Type_GroupsOutput> Get_Award_Task_Type_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Task_Type_Groups_RequestType Get_Award_Task_Type_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Task_Type_GroupsAsync(new Get_Award_Task_Type_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Task_Type_Groups_Request = Get_Award_Task_Type_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_TasksOutput Revenue_ManagementPort.Get_Award_Tasks(Get_Award_TasksInput request)
		{
			return base.Channel.Get_Award_Tasks(request);
		}

		public Get_Award_Tasks_ResponseType Get_Award_Tasks(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Tasks_RequestType Get_Award_Tasks_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Tasks(new Get_Award_TasksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Tasks_Request = Get_Award_Tasks_Request
			}).Get_Award_Tasks_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_TasksOutput> Revenue_ManagementPort.Get_Award_TasksAsync(Get_Award_TasksInput request)
		{
			return base.Channel.Get_Award_TasksAsync(request);
		}

		public Task<Get_Award_TasksOutput> Get_Award_TasksAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Tasks_RequestType Get_Award_Tasks_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_TasksAsync(new Get_Award_TasksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Tasks_Request = Get_Award_Tasks_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Tasks_for_AwardOutput Revenue_ManagementPort.Put_Award_Tasks_for_Award(Put_Award_Tasks_for_AwardInput request)
		{
			return base.Channel.Put_Award_Tasks_for_Award(request);
		}

		public Put_Award_Tasks_for_Award_ResponseType Put_Award_Tasks_for_Award(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Tasks_for_Award_RequestType Put_Award_Tasks_for_Award_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Tasks_for_Award(new Put_Award_Tasks_for_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Tasks_for_Award_Request = Put_Award_Tasks_for_Award_Request
			}).Put_Award_Tasks_for_Award_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Tasks_for_AwardOutput> Revenue_ManagementPort.Put_Award_Tasks_for_AwardAsync(Put_Award_Tasks_for_AwardInput request)
		{
			return base.Channel.Put_Award_Tasks_for_AwardAsync(request);
		}

		public Task<Put_Award_Tasks_for_AwardOutput> Put_Award_Tasks_for_AwardAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Tasks_for_Award_RequestType Put_Award_Tasks_for_Award_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Tasks_for_AwardAsync(new Put_Award_Tasks_for_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Tasks_for_Award_Request = Put_Award_Tasks_for_Award_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Task_Type_GroupOutput Revenue_ManagementPort.Put_Award_Task_Type_Group(Put_Award_Task_Type_GroupInput request)
		{
			return base.Channel.Put_Award_Task_Type_Group(request);
		}

		public Put_Award_Task_Type_Group_ResponseType Put_Award_Task_Type_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_Type_Group_RequestType Put_Award_Task_Type_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task_Type_Group(new Put_Award_Task_Type_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_Type_Group_Request = Put_Award_Task_Type_Group_Request
			}).Put_Award_Task_Type_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Task_Type_GroupOutput> Revenue_ManagementPort.Put_Award_Task_Type_GroupAsync(Put_Award_Task_Type_GroupInput request)
		{
			return base.Channel.Put_Award_Task_Type_GroupAsync(request);
		}

		public Task<Put_Award_Task_Type_GroupOutput> Put_Award_Task_Type_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_Type_Group_RequestType Put_Award_Task_Type_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task_Type_GroupAsync(new Put_Award_Task_Type_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_Type_Group_Request = Put_Award_Task_Type_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Task_StatusesOutput Revenue_ManagementPort.Get_Award_Task_Statuses(Get_Award_Task_StatusesInput request)
		{
			return base.Channel.Get_Award_Task_Statuses(request);
		}

		public Get_Award_Task_Statuses_ResponseType Get_Award_Task_Statuses(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Task_Statuses_RequestType Get_Award_Task_Statuses_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Task_Statuses(new Get_Award_Task_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Task_Statuses_Request = Get_Award_Task_Statuses_Request
			}).Get_Award_Task_Statuses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Task_StatusesOutput> Revenue_ManagementPort.Get_Award_Task_StatusesAsync(Get_Award_Task_StatusesInput request)
		{
			return base.Channel.Get_Award_Task_StatusesAsync(request);
		}

		public Task<Get_Award_Task_StatusesOutput> Get_Award_Task_StatusesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Task_Statuses_RequestType Get_Award_Task_Statuses_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Task_StatusesAsync(new Get_Award_Task_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Task_Statuses_Request = Get_Award_Task_Statuses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Task_StatusOutput Revenue_ManagementPort.Put_Award_Task_Status(Put_Award_Task_StatusInput request)
		{
			return base.Channel.Put_Award_Task_Status(request);
		}

		public Put_Award_Task_Status_ResponseType Put_Award_Task_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_Status_RequestType Put_Award_Task_Status_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task_Status(new Put_Award_Task_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_Status_Request = Put_Award_Task_Status_Request
			}).Put_Award_Task_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Task_StatusOutput> Revenue_ManagementPort.Put_Award_Task_StatusAsync(Put_Award_Task_StatusInput request)
		{
			return base.Channel.Put_Award_Task_StatusAsync(request);
		}

		public Task<Put_Award_Task_StatusOutput> Put_Award_Task_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_Status_RequestType Put_Award_Task_Status_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task_StatusAsync(new Put_Award_Task_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_Status_Request = Put_Award_Task_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Revenue_Recognition_Schedule_TemplatesOutput Revenue_ManagementPort.Get_Revenue_Recognition_Schedule_Templates(Get_Revenue_Recognition_Schedule_TemplatesInput request)
		{
			return base.Channel.Get_Revenue_Recognition_Schedule_Templates(request);
		}

		public Get_Revenue_Recognition_Schedule_Templates_ResponseType Get_Revenue_Recognition_Schedule_Templates(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Recognition_Schedule_Templates_RequestType Get_Revenue_Recognition_Schedule_Templates_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Recognition_Schedule_Templates(new Get_Revenue_Recognition_Schedule_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Recognition_Schedule_Templates_Request = Get_Revenue_Recognition_Schedule_Templates_Request
			}).Get_Revenue_Recognition_Schedule_Templates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Revenue_Recognition_Schedule_TemplatesOutput> Revenue_ManagementPort.Get_Revenue_Recognition_Schedule_TemplatesAsync(Get_Revenue_Recognition_Schedule_TemplatesInput request)
		{
			return base.Channel.Get_Revenue_Recognition_Schedule_TemplatesAsync(request);
		}

		public Task<Get_Revenue_Recognition_Schedule_TemplatesOutput> Get_Revenue_Recognition_Schedule_TemplatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Recognition_Schedule_Templates_RequestType Get_Revenue_Recognition_Schedule_Templates_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Revenue_Recognition_Schedule_TemplatesAsync(new Get_Revenue_Recognition_Schedule_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Recognition_Schedule_Templates_Request = Get_Revenue_Recognition_Schedule_Templates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Revenue_Recognition_Schedule_TemplateOutput Revenue_ManagementPort.Put_Revenue_Recognition_Schedule_Template(Put_Revenue_Recognition_Schedule_TemplateInput request)
		{
			return base.Channel.Put_Revenue_Recognition_Schedule_Template(request);
		}

		public Put_Revenue_Recognition_Schedule_Template_ResponseType Put_Revenue_Recognition_Schedule_Template(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Recognition_Schedule_Template_RequestType Put_Revenue_Recognition_Schedule_Template_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Revenue_Recognition_Schedule_Template(new Put_Revenue_Recognition_Schedule_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Recognition_Schedule_Template_Request = Put_Revenue_Recognition_Schedule_Template_Request
			}).Put_Revenue_Recognition_Schedule_Template_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Revenue_Recognition_Schedule_TemplateOutput> Revenue_ManagementPort.Put_Revenue_Recognition_Schedule_TemplateAsync(Put_Revenue_Recognition_Schedule_TemplateInput request)
		{
			return base.Channel.Put_Revenue_Recognition_Schedule_TemplateAsync(request);
		}

		public Task<Put_Revenue_Recognition_Schedule_TemplateOutput> Put_Revenue_Recognition_Schedule_TemplateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Recognition_Schedule_Template_RequestType Put_Revenue_Recognition_Schedule_Template_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Revenue_Recognition_Schedule_TemplateAsync(new Put_Revenue_Recognition_Schedule_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Recognition_Schedule_Template_Request = Put_Revenue_Recognition_Schedule_Template_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_Rate_CategoryOutput Revenue_ManagementPort.Put_Project_Rate_Category(Put_Project_Rate_CategoryInput request)
		{
			return base.Channel.Put_Project_Rate_Category(request);
		}

		public Put_Project_Rate_Category_ResponseType Put_Project_Rate_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Rate_Category_RequestType Put_Project_Rate_Category_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Project_Rate_Category(new Put_Project_Rate_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Rate_Category_Request = Put_Project_Rate_Category_Request
			}).Put_Project_Rate_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_Rate_CategoryOutput> Revenue_ManagementPort.Put_Project_Rate_CategoryAsync(Put_Project_Rate_CategoryInput request)
		{
			return base.Channel.Put_Project_Rate_CategoryAsync(request);
		}

		public Task<Put_Project_Rate_CategoryOutput> Put_Project_Rate_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Rate_Category_RequestType Put_Project_Rate_Category_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Project_Rate_CategoryAsync(new Put_Project_Rate_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Rate_Category_Request = Put_Project_Rate_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_Rate_CategoriesOutput Revenue_ManagementPort.Get_Project_Rate_Categories(Get_Project_Rate_CategoriesInput request)
		{
			return base.Channel.Get_Project_Rate_Categories(request);
		}

		public Get_Project_Rate_Categories_ResponseType Get_Project_Rate_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Rate_Categories_RequestType Get_Project_Rate_Categories_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Project_Rate_Categories(new Get_Project_Rate_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Rate_Categories_Request = Get_Project_Rate_Categories_Request
			}).Get_Project_Rate_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_Rate_CategoriesOutput> Revenue_ManagementPort.Get_Project_Rate_CategoriesAsync(Get_Project_Rate_CategoriesInput request)
		{
			return base.Channel.Get_Project_Rate_CategoriesAsync(request);
		}

		public Task<Get_Project_Rate_CategoriesOutput> Get_Project_Rate_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Rate_Categories_RequestType Get_Project_Rate_Categories_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Project_Rate_CategoriesAsync(new Get_Project_Rate_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Rate_Categories_Request = Get_Project_Rate_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Contract_Rate_SheetsOutput Revenue_ManagementPort.Get_Contract_Rate_Sheets(Get_Contract_Rate_SheetsInput request)
		{
			return base.Channel.Get_Contract_Rate_Sheets(request);
		}

		public Get_Contract_Rate_Sheets_ResponseType Get_Contract_Rate_Sheets(Workday_Common_HeaderType Workday_Common_Header, Get_Contract_Rate_Sheets_RequestType Get_Contract_Rate_Sheets_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Contract_Rate_Sheets(new Get_Contract_Rate_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Contract_Rate_Sheets_Request = Get_Contract_Rate_Sheets_Request
			}).Get_Contract_Rate_Sheets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Contract_Rate_SheetsOutput> Revenue_ManagementPort.Get_Contract_Rate_SheetsAsync(Get_Contract_Rate_SheetsInput request)
		{
			return base.Channel.Get_Contract_Rate_SheetsAsync(request);
		}

		public Task<Get_Contract_Rate_SheetsOutput> Get_Contract_Rate_SheetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Contract_Rate_Sheets_RequestType Get_Contract_Rate_Sheets_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Contract_Rate_SheetsAsync(new Get_Contract_Rate_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Contract_Rate_Sheets_Request = Get_Contract_Rate_Sheets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Contract_Rate_SheetOutput Revenue_ManagementPort.Put_Contract_Rate_Sheet(Put_Contract_Rate_SheetInput request)
		{
			return base.Channel.Put_Contract_Rate_Sheet(request);
		}

		public Put_Contract_Rate_Sheet_ResponseType Put_Contract_Rate_Sheet(Workday_Common_HeaderType Workday_Common_Header, Put_Contract_Rate_Sheet_RequestType Put_Contract_Rate_Sheet_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Contract_Rate_Sheet(new Put_Contract_Rate_SheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contract_Rate_Sheet_Request = Put_Contract_Rate_Sheet_Request
			}).Put_Contract_Rate_Sheet_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Contract_Rate_SheetOutput> Revenue_ManagementPort.Put_Contract_Rate_SheetAsync(Put_Contract_Rate_SheetInput request)
		{
			return base.Channel.Put_Contract_Rate_SheetAsync(request);
		}

		public Task<Put_Contract_Rate_SheetOutput> Put_Contract_Rate_SheetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Contract_Rate_Sheet_RequestType Put_Contract_Rate_Sheet_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Contract_Rate_SheetAsync(new Put_Contract_Rate_SheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contract_Rate_Sheet_Request = Put_Contract_Rate_Sheet_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Correct_AwardOutput Revenue_ManagementPort.Correct_Award(Correct_AwardInput request)
		{
			return base.Channel.Correct_Award(request);
		}

		public Correct_Award_ResponseType Correct_Award(Workday_Common_HeaderType Workday_Common_Header, Correct_Award_RequestType Correct_Award_Request)
		{
			return ((Revenue_ManagementPort)this).Correct_Award(new Correct_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Correct_Award_Request = Correct_Award_Request
			}).Correct_Award_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Correct_AwardOutput> Revenue_ManagementPort.Correct_AwardAsync(Correct_AwardInput request)
		{
			return base.Channel.Correct_AwardAsync(request);
		}

		public Task<Correct_AwardOutput> Correct_AwardAsync(Workday_Common_HeaderType Workday_Common_Header, Correct_Award_RequestType Correct_Award_Request)
		{
			return ((Revenue_ManagementPort)this).Correct_AwardAsync(new Correct_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Correct_Award_Request = Correct_Award_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Usage_Based_TransactionOutput Revenue_ManagementPort.Put_Usage_Based_Transaction(Put_Usage_Based_TransactionInput request)
		{
			return base.Channel.Put_Usage_Based_Transaction(request);
		}

		public Put_Usage_Based_Transaction_ResponseType Put_Usage_Based_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_Usage_Based_Transaction_RequestType Put_Usage_Based_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Usage_Based_Transaction(new Put_Usage_Based_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Usage_Based_Transaction_Request = Put_Usage_Based_Transaction_Request
			}).Put_Usage_Based_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Usage_Based_TransactionOutput> Revenue_ManagementPort.Put_Usage_Based_TransactionAsync(Put_Usage_Based_TransactionInput request)
		{
			return base.Channel.Put_Usage_Based_TransactionAsync(request);
		}

		public Task<Put_Usage_Based_TransactionOutput> Put_Usage_Based_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Usage_Based_Transaction_RequestType Put_Usage_Based_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Usage_Based_TransactionAsync(new Put_Usage_Based_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Usage_Based_Transaction_Request = Put_Usage_Based_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Usage_Based_TransactionsOutput Revenue_ManagementPort.Get_Usage_Based_Transactions(Get_Usage_Based_TransactionsInput request)
		{
			return base.Channel.Get_Usage_Based_Transactions(request);
		}

		public Get_Usage_Based_Transactions_ResponseType Get_Usage_Based_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Usage_Based_Transactions_RequestType Get_Usage_Based_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Usage_Based_Transactions(new Get_Usage_Based_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Usage_Based_Transactions_Request = Get_Usage_Based_Transactions_Request
			}).Get_Usage_Based_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Usage_Based_TransactionsOutput> Revenue_ManagementPort.Get_Usage_Based_TransactionsAsync(Get_Usage_Based_TransactionsInput request)
		{
			return base.Channel.Get_Usage_Based_TransactionsAsync(request);
		}

		public Task<Get_Usage_Based_TransactionsOutput> Get_Usage_Based_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Usage_Based_Transactions_RequestType Get_Usage_Based_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Usage_Based_TransactionsAsync(new Get_Usage_Based_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Usage_Based_Transactions_Request = Get_Usage_Based_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_Billing_Rate_SheetsOutput Revenue_ManagementPort.Get_Project_Billing_Rate_Sheets(Get_Project_Billing_Rate_SheetsInput request)
		{
			return base.Channel.Get_Project_Billing_Rate_Sheets(request);
		}

		public Get_Project_Billing_Rate_Sheets_ResponseType Get_Project_Billing_Rate_Sheets(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Billing_Rate_Sheets_RequestType Get_Project_Billing_Rate_Sheets_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Project_Billing_Rate_Sheets(new Get_Project_Billing_Rate_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Billing_Rate_Sheets_Request = Get_Project_Billing_Rate_Sheets_Request
			}).Get_Project_Billing_Rate_Sheets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_Billing_Rate_SheetsOutput> Revenue_ManagementPort.Get_Project_Billing_Rate_SheetsAsync(Get_Project_Billing_Rate_SheetsInput request)
		{
			return base.Channel.Get_Project_Billing_Rate_SheetsAsync(request);
		}

		public Task<Get_Project_Billing_Rate_SheetsOutput> Get_Project_Billing_Rate_SheetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Billing_Rate_Sheets_RequestType Get_Project_Billing_Rate_Sheets_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Project_Billing_Rate_SheetsAsync(new Get_Project_Billing_Rate_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Billing_Rate_Sheets_Request = Get_Project_Billing_Rate_Sheets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_Billing_Rate_SheetOutput Revenue_ManagementPort.Put_Project_Billing_Rate_Sheet(Put_Project_Billing_Rate_SheetInput request)
		{
			return base.Channel.Put_Project_Billing_Rate_Sheet(request);
		}

		public Put_Project_Billing_Rate_Sheet_ResponseType Put_Project_Billing_Rate_Sheet(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Billing_Rate_Sheet_RequestType Put_Project_Billing_Rate_Sheet_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Project_Billing_Rate_Sheet(new Put_Project_Billing_Rate_SheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Billing_Rate_Sheet_Request = Put_Project_Billing_Rate_Sheet_Request
			}).Put_Project_Billing_Rate_Sheet_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_Billing_Rate_SheetOutput> Revenue_ManagementPort.Put_Project_Billing_Rate_SheetAsync(Put_Project_Billing_Rate_SheetInput request)
		{
			return base.Channel.Put_Project_Billing_Rate_SheetAsync(request);
		}

		public Task<Put_Project_Billing_Rate_SheetOutput> Put_Project_Billing_Rate_SheetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Billing_Rate_Sheet_RequestType Put_Project_Billing_Rate_Sheet_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Project_Billing_Rate_SheetAsync(new Put_Project_Billing_Rate_SheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Billing_Rate_Sheet_Request = Put_Project_Billing_Rate_Sheet_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Companies_as_Business_EntitiesOutput Revenue_ManagementPort.Get_Companies_as_Business_Entities(Get_Companies_as_Business_EntitiesInput request)
		{
			return base.Channel.Get_Companies_as_Business_Entities(request);
		}

		public Get_Companies_as_Business_Entities_ResponseType Get_Companies_as_Business_Entities(Workday_Common_HeaderType Workday_Common_Header, Get_Companies_as_Business_Entities_RequestType Get_Companies_as_Business_Entities_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Companies_as_Business_Entities(new Get_Companies_as_Business_EntitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Companies_as_Business_Entities_Request = Get_Companies_as_Business_Entities_Request
			}).Get_Companies_as_Business_Entities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Companies_as_Business_EntitiesOutput> Revenue_ManagementPort.Get_Companies_as_Business_EntitiesAsync(Get_Companies_as_Business_EntitiesInput request)
		{
			return base.Channel.Get_Companies_as_Business_EntitiesAsync(request);
		}

		public Task<Get_Companies_as_Business_EntitiesOutput> Get_Companies_as_Business_EntitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Companies_as_Business_Entities_RequestType Get_Companies_as_Business_Entities_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Companies_as_Business_EntitiesAsync(new Get_Companies_as_Business_EntitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Companies_as_Business_Entities_Request = Get_Companies_as_Business_Entities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Company_as_Business_EntityOutput Revenue_ManagementPort.Put_Company_as_Business_Entity(Put_Company_as_Business_EntityInput request)
		{
			return base.Channel.Put_Company_as_Business_Entity(request);
		}

		public Put_Company_as_Business_Entity_ResponseType Put_Company_as_Business_Entity(Workday_Common_HeaderType Workday_Common_Header, Put_Company_as_Business_Entity_RequestType Put_Company_as_Business_Entity_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Company_as_Business_Entity(new Put_Company_as_Business_EntityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Company_as_Business_Entity_Request = Put_Company_as_Business_Entity_Request
			}).Put_Company_as_Business_Entity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Company_as_Business_EntityOutput> Revenue_ManagementPort.Put_Company_as_Business_EntityAsync(Put_Company_as_Business_EntityInput request)
		{
			return base.Channel.Put_Company_as_Business_EntityAsync(request);
		}

		public Task<Put_Company_as_Business_EntityOutput> Put_Company_as_Business_EntityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Company_as_Business_Entity_RequestType Put_Company_as_Business_Entity_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Company_as_Business_EntityAsync(new Put_Company_as_Business_EntityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Company_as_Business_Entity_Request = Put_Company_as_Business_Entity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_Invoice_Collection_InformationOutput Revenue_ManagementPort.Put_Customer_Invoice_Collection_Information(Put_Customer_Invoice_Collection_InformationInput request)
		{
			return base.Channel.Put_Customer_Invoice_Collection_Information(request);
		}

		public Put_Customer_Invoice_Collection_Information_ResponseType Put_Customer_Invoice_Collection_Information(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Invoice_Collection_Information_RequestType Put_Customer_Invoice_Collection_Information_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Invoice_Collection_Information(new Put_Customer_Invoice_Collection_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Invoice_Collection_Information_Request = Put_Customer_Invoice_Collection_Information_Request
			}).Put_Customer_Invoice_Collection_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_Invoice_Collection_InformationOutput> Revenue_ManagementPort.Put_Customer_Invoice_Collection_InformationAsync(Put_Customer_Invoice_Collection_InformationInput request)
		{
			return base.Channel.Put_Customer_Invoice_Collection_InformationAsync(request);
		}

		public Task<Put_Customer_Invoice_Collection_InformationOutput> Put_Customer_Invoice_Collection_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Invoice_Collection_Information_RequestType Put_Customer_Invoice_Collection_Information_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Invoice_Collection_InformationAsync(new Put_Customer_Invoice_Collection_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Invoice_Collection_Information_Request = Put_Customer_Invoice_Collection_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_Invoice_Adjustment_Collection_InformationOutput Revenue_ManagementPort.Put_Customer_Invoice_Adjustment_Collection_Information(Put_Customer_Invoice_Adjustment_Collection_InformationInput request)
		{
			return base.Channel.Put_Customer_Invoice_Adjustment_Collection_Information(request);
		}

		public Put_Customer_Invoice_Adjustment_Collection_Information_ResponseType Put_Customer_Invoice_Adjustment_Collection_Information(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Invoice_Adjustment_Collection_Information_RequestType Put_Customer_Invoice_Adjustment_Collection_Information_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Invoice_Adjustment_Collection_Information(new Put_Customer_Invoice_Adjustment_Collection_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Invoice_Adjustment_Collection_Information_Request = Put_Customer_Invoice_Adjustment_Collection_Information_Request
			}).Put_Customer_Invoice_Adjustment_Collection_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_Invoice_Adjustment_Collection_InformationOutput> Revenue_ManagementPort.Put_Customer_Invoice_Adjustment_Collection_InformationAsync(Put_Customer_Invoice_Adjustment_Collection_InformationInput request)
		{
			return base.Channel.Put_Customer_Invoice_Adjustment_Collection_InformationAsync(request);
		}

		public Task<Put_Customer_Invoice_Adjustment_Collection_InformationOutput> Put_Customer_Invoice_Adjustment_Collection_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Invoice_Adjustment_Collection_Information_RequestType Put_Customer_Invoice_Adjustment_Collection_Information_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Invoice_Adjustment_Collection_InformationAsync(new Put_Customer_Invoice_Adjustment_Collection_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Invoice_Adjustment_Collection_Information_Request = Put_Customer_Invoice_Adjustment_Collection_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Lifecycle_StatusOutput Revenue_ManagementPort.Put_Award_Lifecycle_Status(Put_Award_Lifecycle_StatusInput request)
		{
			return base.Channel.Put_Award_Lifecycle_Status(request);
		}

		public Put_Award_Lifecycle_Status_ResponseType Put_Award_Lifecycle_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Lifecycle_Status_RequestType Put_Award_Lifecycle_Status_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Lifecycle_Status(new Put_Award_Lifecycle_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Lifecycle_Status_Request = Put_Award_Lifecycle_Status_Request
			}).Put_Award_Lifecycle_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Lifecycle_StatusOutput> Revenue_ManagementPort.Put_Award_Lifecycle_StatusAsync(Put_Award_Lifecycle_StatusInput request)
		{
			return base.Channel.Put_Award_Lifecycle_StatusAsync(request);
		}

		public Task<Put_Award_Lifecycle_StatusOutput> Put_Award_Lifecycle_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Lifecycle_Status_RequestType Put_Award_Lifecycle_Status_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Lifecycle_StatusAsync(new Put_Award_Lifecycle_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Lifecycle_Status_Request = Put_Award_Lifecycle_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Lifecycle_StatusesOutput Revenue_ManagementPort.Get_Award_Lifecycle_Statuses(Get_Award_Lifecycle_StatusesInput request)
		{
			return base.Channel.Get_Award_Lifecycle_Statuses(request);
		}

		public Get_Award_Lifecycle_Statuses_ResponseType Get_Award_Lifecycle_Statuses(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Lifecycle_Statuses_RequestType Get_Award_Lifecycle_Statuses_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Lifecycle_Statuses(new Get_Award_Lifecycle_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Lifecycle_Statuses_Request = Get_Award_Lifecycle_Statuses_Request
			}).Get_Award_Lifecycle_Statuses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Lifecycle_StatusesOutput> Revenue_ManagementPort.Get_Award_Lifecycle_StatusesAsync(Get_Award_Lifecycle_StatusesInput request)
		{
			return base.Channel.Get_Award_Lifecycle_StatusesAsync(request);
		}

		public Task<Get_Award_Lifecycle_StatusesOutput> Get_Award_Lifecycle_StatusesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Lifecycle_Statuses_RequestType Get_Award_Lifecycle_Statuses_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Lifecycle_StatusesAsync(new Get_Award_Lifecycle_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Lifecycle_Statuses_Request = Get_Award_Lifecycle_Statuses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Sales_Item_Fair_Value_Price_ListsOutput Revenue_ManagementPort.Get_Sales_Item_Fair_Value_Price_Lists(Get_Sales_Item_Fair_Value_Price_ListsInput request)
		{
			return base.Channel.Get_Sales_Item_Fair_Value_Price_Lists(request);
		}

		public Get_Sales_Item_Fair_Value_Price_Lists_ResponseType Get_Sales_Item_Fair_Value_Price_Lists(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Item_Fair_Value_Price_Lists_RequestType Get_Sales_Item_Fair_Value_Price_Lists_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sales_Item_Fair_Value_Price_Lists(new Get_Sales_Item_Fair_Value_Price_ListsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sales_Item_Fair_Value_Price_Lists_Request = Get_Sales_Item_Fair_Value_Price_Lists_Request
			}).Get_Sales_Item_Fair_Value_Price_Lists_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Sales_Item_Fair_Value_Price_ListsOutput> Revenue_ManagementPort.Get_Sales_Item_Fair_Value_Price_ListsAsync(Get_Sales_Item_Fair_Value_Price_ListsInput request)
		{
			return base.Channel.Get_Sales_Item_Fair_Value_Price_ListsAsync(request);
		}

		public Task<Get_Sales_Item_Fair_Value_Price_ListsOutput> Get_Sales_Item_Fair_Value_Price_ListsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Sales_Item_Fair_Value_Price_Lists_RequestType Get_Sales_Item_Fair_Value_Price_Lists_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Sales_Item_Fair_Value_Price_ListsAsync(new Get_Sales_Item_Fair_Value_Price_ListsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sales_Item_Fair_Value_Price_Lists_Request = Get_Sales_Item_Fair_Value_Price_Lists_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Sales_Item_Fair_Value_Price_ListOutput Revenue_ManagementPort.Put_Sales_Item_Fair_Value_Price_List(Put_Sales_Item_Fair_Value_Price_ListInput request)
		{
			return base.Channel.Put_Sales_Item_Fair_Value_Price_List(request);
		}

		public Put_Sales_Item_Fair_Value_Price_List_ResponseType Put_Sales_Item_Fair_Value_Price_List(Workday_Common_HeaderType Workday_Common_Header, Put_Sales_Item_Fair_Value_Price_List_RequestType Put_Sales_Item_Fair_Value_Price_List_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sales_Item_Fair_Value_Price_List(new Put_Sales_Item_Fair_Value_Price_ListInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sales_Item_Fair_Value_Price_List_Request = Put_Sales_Item_Fair_Value_Price_List_Request
			}).Put_Sales_Item_Fair_Value_Price_List_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Sales_Item_Fair_Value_Price_ListOutput> Revenue_ManagementPort.Put_Sales_Item_Fair_Value_Price_ListAsync(Put_Sales_Item_Fair_Value_Price_ListInput request)
		{
			return base.Channel.Put_Sales_Item_Fair_Value_Price_ListAsync(request);
		}

		public Task<Put_Sales_Item_Fair_Value_Price_ListOutput> Put_Sales_Item_Fair_Value_Price_ListAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Sales_Item_Fair_Value_Price_List_RequestType Put_Sales_Item_Fair_Value_Price_List_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Sales_Item_Fair_Value_Price_ListAsync(new Put_Sales_Item_Fair_Value_Price_ListInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sales_Item_Fair_Value_Price_List_Request = Put_Sales_Item_Fair_Value_Price_List_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Subrecipient_Risk_RecordsOutput Revenue_ManagementPort.Get_Subrecipient_Risk_Records(Get_Subrecipient_Risk_RecordsInput request)
		{
			return base.Channel.Get_Subrecipient_Risk_Records(request);
		}

		public Get_Subrecipient_Risk_Records_ResponseType Get_Subrecipient_Risk_Records(Workday_Common_HeaderType Workday_Common_Header, Get_Subrecipient_Risk_Records_RequestType Get_Subrecipient_Risk_Records_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Subrecipient_Risk_Records(new Get_Subrecipient_Risk_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subrecipient_Risk_Records_Request = Get_Subrecipient_Risk_Records_Request
			}).Get_Subrecipient_Risk_Records_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Subrecipient_Risk_RecordsOutput> Revenue_ManagementPort.Get_Subrecipient_Risk_RecordsAsync(Get_Subrecipient_Risk_RecordsInput request)
		{
			return base.Channel.Get_Subrecipient_Risk_RecordsAsync(request);
		}

		public Task<Get_Subrecipient_Risk_RecordsOutput> Get_Subrecipient_Risk_RecordsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Subrecipient_Risk_Records_RequestType Get_Subrecipient_Risk_Records_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Subrecipient_Risk_RecordsAsync(new Get_Subrecipient_Risk_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subrecipient_Risk_Records_Request = Get_Subrecipient_Risk_Records_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Subrecipient_Risk_RecordOutput Revenue_ManagementPort.Put_Subrecipient_Risk_Record(Put_Subrecipient_Risk_RecordInput request)
		{
			return base.Channel.Put_Subrecipient_Risk_Record(request);
		}

		public Put_Subrecipient_Risk_Record_ResponseType Put_Subrecipient_Risk_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Subrecipient_Risk_Record_RequestType Put_Subrecipient_Risk_Record_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Subrecipient_Risk_Record(new Put_Subrecipient_Risk_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subrecipient_Risk_Record_Request = Put_Subrecipient_Risk_Record_Request
			}).Put_Subrecipient_Risk_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Subrecipient_Risk_RecordOutput> Revenue_ManagementPort.Put_Subrecipient_Risk_RecordAsync(Put_Subrecipient_Risk_RecordInput request)
		{
			return base.Channel.Put_Subrecipient_Risk_RecordAsync(request);
		}

		public Task<Put_Subrecipient_Risk_RecordOutput> Put_Subrecipient_Risk_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Subrecipient_Risk_Record_RequestType Put_Subrecipient_Risk_Record_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Subrecipient_Risk_RecordAsync(new Put_Subrecipient_Risk_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subrecipient_Risk_Record_Request = Put_Subrecipient_Risk_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Subaward_Risk_AssessmentsOutput Revenue_ManagementPort.Get_Subaward_Risk_Assessments(Get_Subaward_Risk_AssessmentsInput request)
		{
			return base.Channel.Get_Subaward_Risk_Assessments(request);
		}

		public Get_Subaward_Risk_Assessments_ResponseType Get_Subaward_Risk_Assessments(Workday_Common_HeaderType Workday_Common_Header, Get_Subaward_Risk_Assessments_RequestType Get_Subaward_Risk_Assessments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Subaward_Risk_Assessments(new Get_Subaward_Risk_AssessmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subaward_Risk_Assessments_Request = Get_Subaward_Risk_Assessments_Request
			}).Get_Subaward_Risk_Assessments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Subaward_Risk_AssessmentsOutput> Revenue_ManagementPort.Get_Subaward_Risk_AssessmentsAsync(Get_Subaward_Risk_AssessmentsInput request)
		{
			return base.Channel.Get_Subaward_Risk_AssessmentsAsync(request);
		}

		public Task<Get_Subaward_Risk_AssessmentsOutput> Get_Subaward_Risk_AssessmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Subaward_Risk_Assessments_RequestType Get_Subaward_Risk_Assessments_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Subaward_Risk_AssessmentsAsync(new Get_Subaward_Risk_AssessmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subaward_Risk_Assessments_Request = Get_Subaward_Risk_Assessments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Subaward_Risk_AssessmentOutput Revenue_ManagementPort.Put_Subaward_Risk_Assessment(Put_Subaward_Risk_AssessmentInput request)
		{
			return base.Channel.Put_Subaward_Risk_Assessment(request);
		}

		public Put_Subaward_Risk_Assessment_ResponseType Put_Subaward_Risk_Assessment(Workday_Common_HeaderType Workday_Common_Header, Put_Subaward_Risk_Assessment_RequestType Put_Subaward_Risk_Assessment_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Subaward_Risk_Assessment(new Put_Subaward_Risk_AssessmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subaward_Risk_Assessment_Request = Put_Subaward_Risk_Assessment_Request
			}).Put_Subaward_Risk_Assessment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Subaward_Risk_AssessmentOutput> Revenue_ManagementPort.Put_Subaward_Risk_AssessmentAsync(Put_Subaward_Risk_AssessmentInput request)
		{
			return base.Channel.Put_Subaward_Risk_AssessmentAsync(request);
		}

		public Task<Put_Subaward_Risk_AssessmentOutput> Put_Subaward_Risk_AssessmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Subaward_Risk_Assessment_RequestType Put_Subaward_Risk_Assessment_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Subaward_Risk_AssessmentAsync(new Put_Subaward_Risk_AssessmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subaward_Risk_Assessment_Request = Put_Subaward_Risk_Assessment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SubrecipientOutput Revenue_ManagementPort.Put_Subrecipient(Put_SubrecipientInput request)
		{
			return base.Channel.Put_Subrecipient(request);
		}

		public Put_Subrecipient_ResponseType Put_Subrecipient(Workday_Common_HeaderType Workday_Common_Header, Put_Subrecipient_RequestType Put_Subrecipient_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Subrecipient(new Put_SubrecipientInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subrecipient_Request = Put_Subrecipient_Request
			}).Put_Subrecipient_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SubrecipientOutput> Revenue_ManagementPort.Put_SubrecipientAsync(Put_SubrecipientInput request)
		{
			return base.Channel.Put_SubrecipientAsync(request);
		}

		public Task<Put_SubrecipientOutput> Put_SubrecipientAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Subrecipient_RequestType Put_Subrecipient_Request)
		{
			return ((Revenue_ManagementPort)this).Put_SubrecipientAsync(new Put_SubrecipientInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subrecipient_Request = Put_Subrecipient_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SubrecipientsOutput Revenue_ManagementPort.Get_Subrecipients(Get_SubrecipientsInput request)
		{
			return base.Channel.Get_Subrecipients(request);
		}

		public Get_Subrecipients_ResponseType Get_Subrecipients(Workday_Common_HeaderType Workday_Common_Header, Get_Subrecipients_RequestType Get_Subrecipients_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Subrecipients(new Get_SubrecipientsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subrecipients_Request = Get_Subrecipients_Request
			}).Get_Subrecipients_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SubrecipientsOutput> Revenue_ManagementPort.Get_SubrecipientsAsync(Get_SubrecipientsInput request)
		{
			return base.Channel.Get_SubrecipientsAsync(request);
		}

		public Task<Get_SubrecipientsOutput> Get_SubrecipientsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Subrecipients_RequestType Get_Subrecipients_Request)
		{
			return ((Revenue_ManagementPort)this).Get_SubrecipientsAsync(new Get_SubrecipientsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subrecipients_Request = Get_Subrecipients_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Contact_TypesOutput Revenue_ManagementPort.Get_Contact_Types(Get_Contact_TypesInput request)
		{
			return base.Channel.Get_Contact_Types(request);
		}

		public Get_Contact_Types_ResponseType Get_Contact_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Contact_Types_RequestType Get_Contact_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Contact_Types(new Get_Contact_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Contact_Types_Request = Get_Contact_Types_Request
			}).Get_Contact_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Contact_TypesOutput> Revenue_ManagementPort.Get_Contact_TypesAsync(Get_Contact_TypesInput request)
		{
			return base.Channel.Get_Contact_TypesAsync(request);
		}

		public Task<Get_Contact_TypesOutput> Get_Contact_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Contact_Types_RequestType Get_Contact_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Contact_TypesAsync(new Get_Contact_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Contact_Types_Request = Get_Contact_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Contact_TypeOutput Revenue_ManagementPort.Put_Contact_Type(Put_Contact_TypeInput request)
		{
			return base.Channel.Put_Contact_Type(request);
		}

		public Put_Contact_Type_ResponseType Put_Contact_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Contact_Type_RequestType Put_Contact_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Contact_Type(new Put_Contact_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contact_Type_Request = Put_Contact_Type_Request
			}).Put_Contact_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Contact_TypeOutput> Revenue_ManagementPort.Put_Contact_TypeAsync(Put_Contact_TypeInput request)
		{
			return base.Channel.Put_Contact_TypeAsync(request);
		}

		public Task<Put_Contact_TypeOutput> Put_Contact_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Contact_Type_RequestType Put_Contact_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Contact_TypeAsync(new Put_Contact_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contact_Type_Request = Put_Contact_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SubawardsOutput Revenue_ManagementPort.Get_Subawards(Get_SubawardsInput request)
		{
			return base.Channel.Get_Subawards(request);
		}

		public Get_Subawards_ResponseType Get_Subawards(Workday_Common_HeaderType Workday_Common_Header, Get_Subawards_RequestType Get_Subawards_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Subawards(new Get_SubawardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subawards_Request = Get_Subawards_Request
			}).Get_Subawards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SubawardsOutput> Revenue_ManagementPort.Get_SubawardsAsync(Get_SubawardsInput request)
		{
			return base.Channel.Get_SubawardsAsync(request);
		}

		public Task<Get_SubawardsOutput> Get_SubawardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Subawards_RequestType Get_Subawards_Request)
		{
			return ((Revenue_ManagementPort)this).Get_SubawardsAsync(new Get_SubawardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subawards_Request = Get_Subawards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SubawardOutput Revenue_ManagementPort.Put_Subaward(Put_SubawardInput request)
		{
			return base.Channel.Put_Subaward(request);
		}

		public Put_Subaward_ResponseType Put_Subaward(Workday_Common_HeaderType Workday_Common_Header, Put_Subaward_RequestType Put_Subaward_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Subaward(new Put_SubawardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subaward_Request = Put_Subaward_Request
			}).Put_Subaward_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SubawardOutput> Revenue_ManagementPort.Put_SubawardAsync(Put_SubawardInput request)
		{
			return base.Channel.Put_SubawardAsync(request);
		}

		public Task<Put_SubawardOutput> Put_SubawardAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Subaward_RequestType Put_Subaward_Request)
		{
			return ((Revenue_ManagementPort)this).Put_SubawardAsync(new Put_SubawardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subaward_Request = Put_Subaward_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Ad_Hoc_Billable_TransactionsOutput Revenue_ManagementPort.Get_Ad_Hoc_Billable_Transactions(Get_Ad_Hoc_Billable_TransactionsInput request)
		{
			return base.Channel.Get_Ad_Hoc_Billable_Transactions(request);
		}

		public Get_Ad_Hoc_Billable_Transactions_ResponseType Get_Ad_Hoc_Billable_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_Hoc_Billable_Transactions_RequestType Get_Ad_Hoc_Billable_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Ad_Hoc_Billable_Transactions(new Get_Ad_Hoc_Billable_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_Hoc_Billable_Transactions_Request = Get_Ad_Hoc_Billable_Transactions_Request
			}).Get_Ad_Hoc_Billable_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Ad_Hoc_Billable_TransactionsOutput> Revenue_ManagementPort.Get_Ad_Hoc_Billable_TransactionsAsync(Get_Ad_Hoc_Billable_TransactionsInput request)
		{
			return base.Channel.Get_Ad_Hoc_Billable_TransactionsAsync(request);
		}

		public Task<Get_Ad_Hoc_Billable_TransactionsOutput> Get_Ad_Hoc_Billable_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_Hoc_Billable_Transactions_RequestType Get_Ad_Hoc_Billable_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Ad_Hoc_Billable_TransactionsAsync(new Get_Ad_Hoc_Billable_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_Hoc_Billable_Transactions_Request = Get_Ad_Hoc_Billable_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Ad_Hoc_Billable_TransactionOutput Revenue_ManagementPort.Put_Ad_Hoc_Billable_Transaction(Put_Ad_Hoc_Billable_TransactionInput request)
		{
			return base.Channel.Put_Ad_Hoc_Billable_Transaction(request);
		}

		public Put_Ad_Hoc_Billable_Transaction_ResponseType Put_Ad_Hoc_Billable_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Billable_Transaction_RequestType Put_Ad_Hoc_Billable_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Ad_Hoc_Billable_Transaction(new Put_Ad_Hoc_Billable_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ad_Hoc_Billable_Transaction_Request = Put_Ad_Hoc_Billable_Transaction_Request
			}).Put_Ad_Hoc_Billable_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Ad_Hoc_Billable_TransactionOutput> Revenue_ManagementPort.Put_Ad_Hoc_Billable_TransactionAsync(Put_Ad_Hoc_Billable_TransactionInput request)
		{
			return base.Channel.Put_Ad_Hoc_Billable_TransactionAsync(request);
		}

		public Task<Put_Ad_Hoc_Billable_TransactionOutput> Put_Ad_Hoc_Billable_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Billable_Transaction_RequestType Put_Ad_Hoc_Billable_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Ad_Hoc_Billable_TransactionAsync(new Put_Ad_Hoc_Billable_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ad_Hoc_Billable_Transaction_Request = Put_Ad_Hoc_Billable_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Catalog_of_Federal_Domestic_AssistanceOutput Revenue_ManagementPort.Put_Catalog_of_Federal_Domestic_Assistance(Put_Catalog_of_Federal_Domestic_AssistanceInput request)
		{
			return base.Channel.Put_Catalog_of_Federal_Domestic_Assistance(request);
		}

		public Put_Catalog_of_Federal_Domestic_Assistance_ResponseType Put_Catalog_of_Federal_Domestic_Assistance(Workday_Common_HeaderType Workday_Common_Header, Put_Catalog_of_Federal_Domestic_Assistance_RequestType Put_Catalog_of_Federal_Domestic_Assistance_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Catalog_of_Federal_Domestic_Assistance(new Put_Catalog_of_Federal_Domestic_AssistanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Catalog_of_Federal_Domestic_Assistance_Request = Put_Catalog_of_Federal_Domestic_Assistance_Request
			}).Put_Catalog_of_Federal_Domestic_Assistance_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Catalog_of_Federal_Domestic_AssistanceOutput> Revenue_ManagementPort.Put_Catalog_of_Federal_Domestic_AssistanceAsync(Put_Catalog_of_Federal_Domestic_AssistanceInput request)
		{
			return base.Channel.Put_Catalog_of_Federal_Domestic_AssistanceAsync(request);
		}

		public Task<Put_Catalog_of_Federal_Domestic_AssistanceOutput> Put_Catalog_of_Federal_Domestic_AssistanceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Catalog_of_Federal_Domestic_Assistance_RequestType Put_Catalog_of_Federal_Domestic_Assistance_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Catalog_of_Federal_Domestic_AssistanceAsync(new Put_Catalog_of_Federal_Domestic_AssistanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Catalog_of_Federal_Domestic_Assistance_Request = Put_Catalog_of_Federal_Domestic_Assistance_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Catalog_of_Federal_Domestic_AssistanceOutput Revenue_ManagementPort.Get_Catalog_of_Federal_Domestic_Assistance(Get_Catalog_of_Federal_Domestic_AssistanceInput request)
		{
			return base.Channel.Get_Catalog_of_Federal_Domestic_Assistance(request);
		}

		public Get_Catalog_of_Federal_Domestic_Assistance_ResponseType Get_Catalog_of_Federal_Domestic_Assistance(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_of_Federal_Domestic_Assistance_RequestType Get_Catalog_of_Federal_Domestic_Assistance_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Catalog_of_Federal_Domestic_Assistance(new Get_Catalog_of_Federal_Domestic_AssistanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Catalog_of_Federal_Domestic_Assistance_Request = Get_Catalog_of_Federal_Domestic_Assistance_Request
			}).Get_Catalog_of_Federal_Domestic_Assistance_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Catalog_of_Federal_Domestic_AssistanceOutput> Revenue_ManagementPort.Get_Catalog_of_Federal_Domestic_AssistanceAsync(Get_Catalog_of_Federal_Domestic_AssistanceInput request)
		{
			return base.Channel.Get_Catalog_of_Federal_Domestic_AssistanceAsync(request);
		}

		public Task<Get_Catalog_of_Federal_Domestic_AssistanceOutput> Get_Catalog_of_Federal_Domestic_AssistanceAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_of_Federal_Domestic_Assistance_RequestType Get_Catalog_of_Federal_Domestic_Assistance_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Catalog_of_Federal_Domestic_AssistanceAsync(new Get_Catalog_of_Federal_Domestic_AssistanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Catalog_of_Federal_Domestic_Assistance_Request = Get_Catalog_of_Federal_Domestic_Assistance_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Revenue_Recognition_ScheduleOutput Revenue_ManagementPort.Cancel_Revenue_Recognition_Schedule(Cancel_Revenue_Recognition_ScheduleInput request)
		{
			return base.Channel.Cancel_Revenue_Recognition_Schedule(request);
		}

		public Cancel_Revenue_Recognition_Schedule_ResponseType Cancel_Revenue_Recognition_Schedule(Workday_Common_HeaderType Workday_Common_Header, Cancel_Revenue_Recognition_Schedule_RequestType Cancel_Revenue_Recognition_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Revenue_Recognition_Schedule(new Cancel_Revenue_Recognition_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Revenue_Recognition_Schedule_Request = Cancel_Revenue_Recognition_Schedule_Request
			}).Cancel_Revenue_Recognition_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Revenue_Recognition_ScheduleOutput> Revenue_ManagementPort.Cancel_Revenue_Recognition_ScheduleAsync(Cancel_Revenue_Recognition_ScheduleInput request)
		{
			return base.Channel.Cancel_Revenue_Recognition_ScheduleAsync(request);
		}

		public Task<Cancel_Revenue_Recognition_ScheduleOutput> Cancel_Revenue_Recognition_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Revenue_Recognition_Schedule_RequestType Cancel_Revenue_Recognition_Schedule_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Revenue_Recognition_ScheduleAsync(new Cancel_Revenue_Recognition_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Revenue_Recognition_Schedule_Request = Cancel_Revenue_Recognition_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_TaskOutput Revenue_ManagementPort.Put_Award_Task(Put_Award_TaskInput request)
		{
			return base.Channel.Put_Award_Task(request);
		}

		public Put_Award_Task_ResponseType Put_Award_Task(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_RequestType Put_Award_Task_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task(new Put_Award_TaskInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_Request = Put_Award_Task_Request
			}).Put_Award_Task_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_TaskOutput> Revenue_ManagementPort.Put_Award_TaskAsync(Put_Award_TaskInput request)
		{
			return base.Channel.Put_Award_TaskAsync(request);
		}

		public Task<Put_Award_TaskOutput> Put_Award_TaskAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_RequestType Put_Award_Task_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_TaskAsync(new Put_Award_TaskInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_Request = Put_Award_Task_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_GroupsOutput Revenue_ManagementPort.Get_Award_Groups(Get_Award_GroupsInput request)
		{
			return base.Channel.Get_Award_Groups(request);
		}

		public Get_Award_Groups_ResponseType Get_Award_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Groups_RequestType Get_Award_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Groups(new Get_Award_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Groups_Request = Get_Award_Groups_Request
			}).Get_Award_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_GroupsOutput> Revenue_ManagementPort.Get_Award_GroupsAsync(Get_Award_GroupsInput request)
		{
			return base.Channel.Get_Award_GroupsAsync(request);
		}

		public Task<Get_Award_GroupsOutput> Get_Award_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Groups_RequestType Get_Award_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_GroupsAsync(new Get_Award_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Groups_Request = Get_Award_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_GroupOutput Revenue_ManagementPort.Put_Award_Group(Put_Award_GroupInput request)
		{
			return base.Channel.Put_Award_Group(request);
		}

		public Put_Award_Group_ResponseType Put_Award_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Group_RequestType Put_Award_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Group(new Put_Award_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Group_Request = Put_Award_Group_Request
			}).Put_Award_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_GroupOutput> Revenue_ManagementPort.Put_Award_GroupAsync(Put_Award_GroupInput request)
		{
			return base.Channel.Put_Award_GroupAsync(request);
		}

		public Task<Put_Award_GroupOutput> Put_Award_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Group_RequestType Put_Award_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_GroupAsync(new Put_Award_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Group_Request = Put_Award_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Salary_CapsOutput Revenue_ManagementPort.Get_Salary_Caps(Get_Salary_CapsInput request)
		{
			return base.Channel.Get_Salary_Caps(request);
		}

		public Get_Salary_Caps_ResponseType Get_Salary_Caps(Workday_Common_HeaderType Workday_Common_Header, Get_Salary_Caps_RequestType Get_Salary_Caps_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Salary_Caps(new Get_Salary_CapsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Salary_Caps_Request = Get_Salary_Caps_Request
			}).Get_Salary_Caps_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Salary_CapsOutput> Revenue_ManagementPort.Get_Salary_CapsAsync(Get_Salary_CapsInput request)
		{
			return base.Channel.Get_Salary_CapsAsync(request);
		}

		public Task<Get_Salary_CapsOutput> Get_Salary_CapsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Salary_Caps_RequestType Get_Salary_Caps_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Salary_CapsAsync(new Get_Salary_CapsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Salary_Caps_Request = Get_Salary_Caps_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Salary_CapOutput Revenue_ManagementPort.Put_Salary_Cap(Put_Salary_CapInput request)
		{
			return base.Channel.Put_Salary_Cap(request);
		}

		public Put_Salary_Cap_ResponseType Put_Salary_Cap(Workday_Common_HeaderType Workday_Common_Header, Put_Salary_Cap_RequestType Put_Salary_Cap_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Salary_Cap(new Put_Salary_CapInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Salary_Cap_Request = Put_Salary_Cap_Request
			}).Put_Salary_Cap_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Salary_CapOutput> Revenue_ManagementPort.Put_Salary_CapAsync(Put_Salary_CapInput request)
		{
			return base.Channel.Put_Salary_CapAsync(request);
		}

		public Task<Put_Salary_CapOutput> Put_Salary_CapAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Salary_Cap_RequestType Put_Salary_Cap_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Salary_CapAsync(new Put_Salary_CapInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Salary_Cap_Request = Put_Salary_Cap_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Task_List_TemplatesOutput Revenue_ManagementPort.Get_Award_Task_List_Templates(Get_Award_Task_List_TemplatesInput request)
		{
			return base.Channel.Get_Award_Task_List_Templates(request);
		}

		public Get_Award_Task_List_Templates_ResponseType Get_Award_Task_List_Templates(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Task_List_Templates_RequestType Get_Award_Task_List_Templates_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Task_List_Templates(new Get_Award_Task_List_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Task_List_Templates_Request = Get_Award_Task_List_Templates_Request
			}).Get_Award_Task_List_Templates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Task_List_TemplatesOutput> Revenue_ManagementPort.Get_Award_Task_List_TemplatesAsync(Get_Award_Task_List_TemplatesInput request)
		{
			return base.Channel.Get_Award_Task_List_TemplatesAsync(request);
		}

		public Task<Get_Award_Task_List_TemplatesOutput> Get_Award_Task_List_TemplatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Task_List_Templates_RequestType Get_Award_Task_List_Templates_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Task_List_TemplatesAsync(new Get_Award_Task_List_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Task_List_Templates_Request = Get_Award_Task_List_Templates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Task_List_TemplateOutput Revenue_ManagementPort.Put_Award_Task_List_Template(Put_Award_Task_List_TemplateInput request)
		{
			return base.Channel.Put_Award_Task_List_Template(request);
		}

		public Put_Award_Task_List_Template_ResponseType Put_Award_Task_List_Template(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_List_Template_RequestType Put_Award_Task_List_Template_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task_List_Template(new Put_Award_Task_List_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_List_Template_Request = Put_Award_Task_List_Template_Request
			}).Put_Award_Task_List_Template_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Task_List_TemplateOutput> Revenue_ManagementPort.Put_Award_Task_List_TemplateAsync(Put_Award_Task_List_TemplateInput request)
		{
			return base.Channel.Put_Award_Task_List_TemplateAsync(request);
		}

		public Task<Put_Award_Task_List_TemplateOutput> Put_Award_Task_List_TemplateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Task_List_Template_RequestType Put_Award_Task_List_Template_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Task_List_TemplateAsync(new Put_Award_Task_List_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Task_List_Template_Request = Put_Award_Task_List_Template_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_Contract_Renewal_TermsOutput Revenue_ManagementPort.Get_Customer_Contract_Renewal_Terms(Get_Customer_Contract_Renewal_TermsInput request)
		{
			return base.Channel.Get_Customer_Contract_Renewal_Terms(request);
		}

		public Get_Customer_Contract_Renewal_Terms_ResponseType Get_Customer_Contract_Renewal_Terms(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contract_Renewal_Terms_RequestType Get_Customer_Contract_Renewal_Terms_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Contract_Renewal_Terms(new Get_Customer_Contract_Renewal_TermsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Contract_Renewal_Terms_Request = Get_Customer_Contract_Renewal_Terms_Request
			}).Get_Customer_Contract_Renewal_Terms_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_Contract_Renewal_TermsOutput> Revenue_ManagementPort.Get_Customer_Contract_Renewal_TermsAsync(Get_Customer_Contract_Renewal_TermsInput request)
		{
			return base.Channel.Get_Customer_Contract_Renewal_TermsAsync(request);
		}

		public Task<Get_Customer_Contract_Renewal_TermsOutput> Get_Customer_Contract_Renewal_TermsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contract_Renewal_Terms_RequestType Get_Customer_Contract_Renewal_Terms_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Customer_Contract_Renewal_TermsAsync(new Get_Customer_Contract_Renewal_TermsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Contract_Renewal_Terms_Request = Get_Customer_Contract_Renewal_Terms_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_Contract_Renewal_TermsOutput Revenue_ManagementPort.Put_Customer_Contract_Renewal_Terms(Put_Customer_Contract_Renewal_TermsInput request)
		{
			return base.Channel.Put_Customer_Contract_Renewal_Terms(request);
		}

		public Put_Customer_Contract_Renewal_Terms_ResponseType Put_Customer_Contract_Renewal_Terms(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Contract_Renewal_Terms_RequestType Put_Customer_Contract_Renewal_Terms_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Contract_Renewal_Terms(new Put_Customer_Contract_Renewal_TermsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Contract_Renewal_Terms_Request = Put_Customer_Contract_Renewal_Terms_Request
			}).Put_Customer_Contract_Renewal_Terms_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_Contract_Renewal_TermsOutput> Revenue_ManagementPort.Put_Customer_Contract_Renewal_TermsAsync(Put_Customer_Contract_Renewal_TermsInput request)
		{
			return base.Channel.Put_Customer_Contract_Renewal_TermsAsync(request);
		}

		public Task<Put_Customer_Contract_Renewal_TermsOutput> Put_Customer_Contract_Renewal_TermsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Contract_Renewal_Terms_RequestType Put_Customer_Contract_Renewal_Terms_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Customer_Contract_Renewal_TermsAsync(new Put_Customer_Contract_Renewal_TermsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Contract_Renewal_Terms_Request = Put_Customer_Contract_Renewal_Terms_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Company_Creditor_IdentifierOutput Revenue_ManagementPort.Put_Company_Creditor_Identifier(Put_Company_Creditor_IdentifierInput request)
		{
			return base.Channel.Put_Company_Creditor_Identifier(request);
		}

		public Put_Company_Creditor_Identifier_ResponseType Put_Company_Creditor_Identifier(Workday_Common_HeaderType Workday_Common_Header, Put_Company_Creditor_Identifier_RequestType Put_Company_Creditor_Identifier_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Company_Creditor_Identifier(new Put_Company_Creditor_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Company_Creditor_Identifier_Request = Put_Company_Creditor_Identifier_Request
			}).Put_Company_Creditor_Identifier_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Company_Creditor_IdentifierOutput> Revenue_ManagementPort.Put_Company_Creditor_IdentifierAsync(Put_Company_Creditor_IdentifierInput request)
		{
			return base.Channel.Put_Company_Creditor_IdentifierAsync(request);
		}

		public Task<Put_Company_Creditor_IdentifierOutput> Put_Company_Creditor_IdentifierAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Company_Creditor_Identifier_RequestType Put_Company_Creditor_Identifier_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Company_Creditor_IdentifierAsync(new Put_Company_Creditor_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Company_Creditor_Identifier_Request = Put_Company_Creditor_Identifier_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Company_Creditor_IdentifiersOutput Revenue_ManagementPort.Get_Company_Creditor_Identifiers(Get_Company_Creditor_IdentifiersInput request)
		{
			return base.Channel.Get_Company_Creditor_Identifiers(request);
		}

		public Get_Company_Creditor_Identifiers_ResponseType Get_Company_Creditor_Identifiers(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Creditor_Identifiers_RequestType Get_Company_Creditor_Identifiers_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Company_Creditor_Identifiers(new Get_Company_Creditor_IdentifiersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Company_Creditor_Identifiers_Request = Get_Company_Creditor_Identifiers_Request
			}).Get_Company_Creditor_Identifiers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Company_Creditor_IdentifiersOutput> Revenue_ManagementPort.Get_Company_Creditor_IdentifiersAsync(Get_Company_Creditor_IdentifiersInput request)
		{
			return base.Channel.Get_Company_Creditor_IdentifiersAsync(request);
		}

		public Task<Get_Company_Creditor_IdentifiersOutput> Get_Company_Creditor_IdentifiersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Creditor_Identifiers_RequestType Get_Company_Creditor_Identifiers_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Company_Creditor_IdentifiersAsync(new Get_Company_Creditor_IdentifiersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Company_Creditor_Identifiers_Request = Get_Company_Creditor_Identifiers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Salary_Over_The_Cap_TypesOutput Revenue_ManagementPort.Get_Salary_Over_The_Cap_Types(Get_Salary_Over_The_Cap_TypesInput request)
		{
			return base.Channel.Get_Salary_Over_The_Cap_Types(request);
		}

		public Get_Salary_Over_The_Cap_Types_ResponseType Get_Salary_Over_The_Cap_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Salary_Over_The_Cap_Types_RequestType Get_Salary_Over_The_Cap_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Salary_Over_The_Cap_Types(new Get_Salary_Over_The_Cap_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Salary_Over_The_Cap_Types_Request = Get_Salary_Over_The_Cap_Types_Request
			}).Get_Salary_Over_The_Cap_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Salary_Over_The_Cap_TypesOutput> Revenue_ManagementPort.Get_Salary_Over_The_Cap_TypesAsync(Get_Salary_Over_The_Cap_TypesInput request)
		{
			return base.Channel.Get_Salary_Over_The_Cap_TypesAsync(request);
		}

		public Task<Get_Salary_Over_The_Cap_TypesOutput> Get_Salary_Over_The_Cap_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Salary_Over_The_Cap_Types_RequestType Get_Salary_Over_The_Cap_Types_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Salary_Over_The_Cap_TypesAsync(new Get_Salary_Over_The_Cap_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Salary_Over_The_Cap_Types_Request = Get_Salary_Over_The_Cap_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Salary_Over_the_Cap_TypeOutput Revenue_ManagementPort.Put_Salary_Over_the_Cap_Type(Put_Salary_Over_the_Cap_TypeInput request)
		{
			return base.Channel.Put_Salary_Over_the_Cap_Type(request);
		}

		public Put_Salary_Over_the_Cap_Type_ResponseType Put_Salary_Over_the_Cap_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Salary_Over_the_Cap_Type_RequestType Put_Salary_Over_the_Cap_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Salary_Over_the_Cap_Type(new Put_Salary_Over_the_Cap_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Salary_Over_the_Cap_Type_Request = Put_Salary_Over_the_Cap_Type_Request
			}).Put_Salary_Over_the_Cap_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Salary_Over_the_Cap_TypeOutput> Revenue_ManagementPort.Put_Salary_Over_the_Cap_TypeAsync(Put_Salary_Over_the_Cap_TypeInput request)
		{
			return base.Channel.Put_Salary_Over_the_Cap_TypeAsync(request);
		}

		public Task<Put_Salary_Over_the_Cap_TypeOutput> Put_Salary_Over_the_Cap_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Salary_Over_the_Cap_Type_RequestType Put_Salary_Over_the_Cap_Type_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Salary_Over_the_Cap_TypeAsync(new Put_Salary_Over_the_Cap_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Salary_Over_the_Cap_Type_Request = Put_Salary_Over_the_Cap_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Lifecycle_Status_Update_RulesOutput Revenue_ManagementPort.Get_Award_Lifecycle_Status_Update_Rules(Get_Award_Lifecycle_Status_Update_RulesInput request)
		{
			return base.Channel.Get_Award_Lifecycle_Status_Update_Rules(request);
		}

		public Get_Award_Lifecycle_Status_Update_Rules_ResponseType Get_Award_Lifecycle_Status_Update_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Lifecycle_Status_Update_Rules_RequestType Get_Award_Lifecycle_Status_Update_Rules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Lifecycle_Status_Update_Rules(new Get_Award_Lifecycle_Status_Update_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Lifecycle_Status_Update_Rules_Request = Get_Award_Lifecycle_Status_Update_Rules_Request
			}).Get_Award_Lifecycle_Status_Update_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Lifecycle_Status_Update_RulesOutput> Revenue_ManagementPort.Get_Award_Lifecycle_Status_Update_RulesAsync(Get_Award_Lifecycle_Status_Update_RulesInput request)
		{
			return base.Channel.Get_Award_Lifecycle_Status_Update_RulesAsync(request);
		}

		public Task<Get_Award_Lifecycle_Status_Update_RulesOutput> Get_Award_Lifecycle_Status_Update_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Lifecycle_Status_Update_Rules_RequestType Get_Award_Lifecycle_Status_Update_Rules_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Award_Lifecycle_Status_Update_RulesAsync(new Get_Award_Lifecycle_Status_Update_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Lifecycle_Status_Update_Rules_Request = Get_Award_Lifecycle_Status_Update_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Lifecycle_Status_Update_RuleOutput Revenue_ManagementPort.Put_Award_Lifecycle_Status_Update_Rule(Put_Award_Lifecycle_Status_Update_RuleInput request)
		{
			return base.Channel.Put_Award_Lifecycle_Status_Update_Rule(request);
		}

		public Put_Award_Lifecycle_Status_Update_Rule_ResponseType Put_Award_Lifecycle_Status_Update_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Lifecycle_Status_Update_Rule_RequestType Put_Award_Lifecycle_Status_Update_Rule_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Lifecycle_Status_Update_Rule(new Put_Award_Lifecycle_Status_Update_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Lifecycle_Status_Update_Rule_Request = Put_Award_Lifecycle_Status_Update_Rule_Request
			}).Put_Award_Lifecycle_Status_Update_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Lifecycle_Status_Update_RuleOutput> Revenue_ManagementPort.Put_Award_Lifecycle_Status_Update_RuleAsync(Put_Award_Lifecycle_Status_Update_RuleInput request)
		{
			return base.Channel.Put_Award_Lifecycle_Status_Update_RuleAsync(request);
		}

		public Task<Put_Award_Lifecycle_Status_Update_RuleOutput> Put_Award_Lifecycle_Status_Update_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Lifecycle_Status_Update_Rule_RequestType Put_Award_Lifecycle_Status_Update_Rule_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Award_Lifecycle_Status_Update_RuleAsync(new Put_Award_Lifecycle_Status_Update_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Lifecycle_Status_Update_Rule_Request = Put_Award_Lifecycle_Status_Update_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Order_Fulfillment_TransactionOutput Revenue_ManagementPort.Put_Order_Fulfillment_Transaction(Put_Order_Fulfillment_TransactionInput request)
		{
			return base.Channel.Put_Order_Fulfillment_Transaction(request);
		}

		public Put_Order_Fulfillment_Transaction_ResponseType Put_Order_Fulfillment_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_Order_Fulfillment_Transaction_RequestType Put_Order_Fulfillment_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Order_Fulfillment_Transaction(new Put_Order_Fulfillment_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Order_Fulfillment_Transaction_Request = Put_Order_Fulfillment_Transaction_Request
			}).Put_Order_Fulfillment_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Order_Fulfillment_TransactionOutput> Revenue_ManagementPort.Put_Order_Fulfillment_TransactionAsync(Put_Order_Fulfillment_TransactionInput request)
		{
			return base.Channel.Put_Order_Fulfillment_TransactionAsync(request);
		}

		public Task<Put_Order_Fulfillment_TransactionOutput> Put_Order_Fulfillment_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Order_Fulfillment_Transaction_RequestType Put_Order_Fulfillment_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Order_Fulfillment_TransactionAsync(new Put_Order_Fulfillment_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Order_Fulfillment_Transaction_Request = Put_Order_Fulfillment_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Order_Fulfillment_TransactionsOutput Revenue_ManagementPort.Get_Order_Fulfillment_Transactions(Get_Order_Fulfillment_TransactionsInput request)
		{
			return base.Channel.Get_Order_Fulfillment_Transactions(request);
		}

		public Get_Order_Fulfillment_Transactions_ResponseType Get_Order_Fulfillment_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Order_Fulfillment_Transactions_RequestType Get_Order_Fulfillment_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Order_Fulfillment_Transactions(new Get_Order_Fulfillment_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Order_Fulfillment_Transactions_Request = Get_Order_Fulfillment_Transactions_Request
			}).Get_Order_Fulfillment_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Order_Fulfillment_TransactionsOutput> Revenue_ManagementPort.Get_Order_Fulfillment_TransactionsAsync(Get_Order_Fulfillment_TransactionsInput request)
		{
			return base.Channel.Get_Order_Fulfillment_TransactionsAsync(request);
		}

		public Task<Get_Order_Fulfillment_TransactionsOutput> Get_Order_Fulfillment_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Order_Fulfillment_Transactions_RequestType Get_Order_Fulfillment_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Order_Fulfillment_TransactionsAsync(new Get_Order_Fulfillment_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Order_Fulfillment_Transactions_Request = Get_Order_Fulfillment_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Consolidated_InvoiceOutput Revenue_ManagementPort.Cancel_Consolidated_Invoice(Cancel_Consolidated_InvoiceInput request)
		{
			return base.Channel.Cancel_Consolidated_Invoice(request);
		}

		public Cancel_Consolidated_Invoice_ResponseType Cancel_Consolidated_Invoice(Workday_Common_HeaderType Workday_Common_Header, Cancel_Consolidated_Invoice_RequestType Cancel_Consolidated_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Consolidated_Invoice(new Cancel_Consolidated_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Consolidated_Invoice_Request = Cancel_Consolidated_Invoice_Request
			}).Cancel_Consolidated_Invoice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Consolidated_InvoiceOutput> Revenue_ManagementPort.Cancel_Consolidated_InvoiceAsync(Cancel_Consolidated_InvoiceInput request)
		{
			return base.Channel.Cancel_Consolidated_InvoiceAsync(request);
		}

		public Task<Cancel_Consolidated_InvoiceOutput> Cancel_Consolidated_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Consolidated_Invoice_RequestType Cancel_Consolidated_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Cancel_Consolidated_InvoiceAsync(new Cancel_Consolidated_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Consolidated_Invoice_Request = Cancel_Consolidated_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Customer_Contract_Change_OrderOutput Revenue_ManagementPort.Submit_Customer_Contract_Change_Order(Submit_Customer_Contract_Change_OrderInput request)
		{
			return base.Channel.Submit_Customer_Contract_Change_Order(request);
		}

		public Submit_Customer_Contract_Change_Order_ResponseType Submit_Customer_Contract_Change_Order(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Contract_Change_Order_RequestType Submit_Customer_Contract_Change_Order_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Contract_Change_Order(new Submit_Customer_Contract_Change_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Contract_Change_Order_Request = Submit_Customer_Contract_Change_Order_Request
			}).Submit_Customer_Contract_Change_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Customer_Contract_Change_OrderOutput> Revenue_ManagementPort.Submit_Customer_Contract_Change_OrderAsync(Submit_Customer_Contract_Change_OrderInput request)
		{
			return base.Channel.Submit_Customer_Contract_Change_OrderAsync(request);
		}

		public Task<Submit_Customer_Contract_Change_OrderOutput> Submit_Customer_Contract_Change_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Contract_Change_Order_RequestType Submit_Customer_Contract_Change_Order_Request)
		{
			return ((Revenue_ManagementPort)this).Submit_Customer_Contract_Change_OrderAsync(new Submit_Customer_Contract_Change_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Customer_Contract_Change_Order_Request = Submit_Customer_Contract_Change_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Percent_Complete_ProjectsOutput Revenue_ManagementPort.Get_Percent_Complete_Projects(Get_Percent_Complete_ProjectsInput request)
		{
			return base.Channel.Get_Percent_Complete_Projects(request);
		}

		public Get_Percent_Complete_Projects_ResponseType Get_Percent_Complete_Projects(Workday_Common_HeaderType Workday_Common_Header, Get_Percent_Complete_Projects_RequestType Get_Percent_Complete_Projects_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Percent_Complete_Projects(new Get_Percent_Complete_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Percent_Complete_Projects_Request = Get_Percent_Complete_Projects_Request
			}).Get_Percent_Complete_Projects_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Percent_Complete_ProjectsOutput> Revenue_ManagementPort.Get_Percent_Complete_ProjectsAsync(Get_Percent_Complete_ProjectsInput request)
		{
			return base.Channel.Get_Percent_Complete_ProjectsAsync(request);
		}

		public Task<Get_Percent_Complete_ProjectsOutput> Get_Percent_Complete_ProjectsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Percent_Complete_Projects_RequestType Get_Percent_Complete_Projects_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Percent_Complete_ProjectsAsync(new Get_Percent_Complete_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Percent_Complete_Projects_Request = Get_Percent_Complete_Projects_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Percent_Complete_ProjectOutput Revenue_ManagementPort.Put_Percent_Complete_Project(Put_Percent_Complete_ProjectInput request)
		{
			return base.Channel.Put_Percent_Complete_Project(request);
		}

		public Put_Percent_Complete_Project_ResponseType Put_Percent_Complete_Project(Workday_Common_HeaderType Workday_Common_Header, Put_Percent_Complete_Project_RequestType Put_Percent_Complete_Project_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Percent_Complete_Project(new Put_Percent_Complete_ProjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Percent_Complete_Project_Request = Put_Percent_Complete_Project_Request
			}).Put_Percent_Complete_Project_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Percent_Complete_ProjectOutput> Revenue_ManagementPort.Put_Percent_Complete_ProjectAsync(Put_Percent_Complete_ProjectInput request)
		{
			return base.Channel.Put_Percent_Complete_ProjectAsync(request);
		}

		public Task<Put_Percent_Complete_ProjectOutput> Put_Percent_Complete_ProjectAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Percent_Complete_Project_RequestType Put_Percent_Complete_Project_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Percent_Complete_ProjectAsync(new Put_Percent_Complete_ProjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Percent_Complete_Project_Request = Put_Percent_Complete_Project_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Deferred_Cost_TransactionOutput Revenue_ManagementPort.Put_Deferred_Cost_Transaction(Put_Deferred_Cost_TransactionInput request)
		{
			return base.Channel.Put_Deferred_Cost_Transaction(request);
		}

		public Put_Deferred_Cost_Transaction_ResponseType Put_Deferred_Cost_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_Deferred_Cost_Transaction_RequestType Put_Deferred_Cost_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Deferred_Cost_Transaction(new Put_Deferred_Cost_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Deferred_Cost_Transaction_Request = Put_Deferred_Cost_Transaction_Request
			}).Put_Deferred_Cost_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Deferred_Cost_TransactionOutput> Revenue_ManagementPort.Put_Deferred_Cost_TransactionAsync(Put_Deferred_Cost_TransactionInput request)
		{
			return base.Channel.Put_Deferred_Cost_TransactionAsync(request);
		}

		public Task<Put_Deferred_Cost_TransactionOutput> Put_Deferred_Cost_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Deferred_Cost_Transaction_RequestType Put_Deferred_Cost_Transaction_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Deferred_Cost_TransactionAsync(new Put_Deferred_Cost_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Deferred_Cost_Transaction_Request = Put_Deferred_Cost_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Deferred_Cost_TransactionsOutput Revenue_ManagementPort.Get_Deferred_Cost_Transactions(Get_Deferred_Cost_TransactionsInput request)
		{
			return base.Channel.Get_Deferred_Cost_Transactions(request);
		}

		public Get_Deferred_Cost_Transactions_ResponseType Get_Deferred_Cost_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Deferred_Cost_Transactions_RequestType Get_Deferred_Cost_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Deferred_Cost_Transactions(new Get_Deferred_Cost_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Deferred_Cost_Transactions_Request = Get_Deferred_Cost_Transactions_Request
			}).Get_Deferred_Cost_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Deferred_Cost_TransactionsOutput> Revenue_ManagementPort.Get_Deferred_Cost_TransactionsAsync(Get_Deferred_Cost_TransactionsInput request)
		{
			return base.Channel.Get_Deferred_Cost_TransactionsAsync(request);
		}

		public Task<Get_Deferred_Cost_TransactionsOutput> Get_Deferred_Cost_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Deferred_Cost_Transactions_RequestType Get_Deferred_Cost_Transactions_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Deferred_Cost_TransactionsAsync(new Get_Deferred_Cost_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Deferred_Cost_Transactions_Request = Get_Deferred_Cost_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Consolidated_InvoicesOutput Revenue_ManagementPort.Get_Consolidated_Invoices(Get_Consolidated_InvoicesInput request)
		{
			return base.Channel.Get_Consolidated_Invoices(request);
		}

		public Get_Consolidated_Invoices_ResponseType Get_Consolidated_Invoices(Workday_Common_HeaderType Workday_Common_Header, Get_Consolidated_Invoices_RequestType Get_Consolidated_Invoices_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Consolidated_Invoices(new Get_Consolidated_InvoicesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Consolidated_Invoices_Request = Get_Consolidated_Invoices_Request
			}).Get_Consolidated_Invoices_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Consolidated_InvoicesOutput> Revenue_ManagementPort.Get_Consolidated_InvoicesAsync(Get_Consolidated_InvoicesInput request)
		{
			return base.Channel.Get_Consolidated_InvoicesAsync(request);
		}

		public Task<Get_Consolidated_InvoicesOutput> Get_Consolidated_InvoicesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Consolidated_Invoices_RequestType Get_Consolidated_Invoices_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Consolidated_InvoicesAsync(new Get_Consolidated_InvoicesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Consolidated_Invoices_Request = Get_Consolidated_Invoices_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Consolidated_InvoiceOutput Revenue_ManagementPort.Put_Consolidated_Invoice(Put_Consolidated_InvoiceInput request)
		{
			return base.Channel.Put_Consolidated_Invoice(request);
		}

		public Put_Consolidated_Invoice_ResponseType Put_Consolidated_Invoice(Workday_Common_HeaderType Workday_Common_Header, Put_Consolidated_Invoice_RequestType Put_Consolidated_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Consolidated_Invoice(new Put_Consolidated_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Consolidated_Invoice_Request = Put_Consolidated_Invoice_Request
			}).Put_Consolidated_Invoice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Consolidated_InvoiceOutput> Revenue_ManagementPort.Put_Consolidated_InvoiceAsync(Put_Consolidated_InvoiceInput request)
		{
			return base.Channel.Put_Consolidated_InvoiceAsync(request);
		}

		public Task<Put_Consolidated_InvoiceOutput> Put_Consolidated_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Consolidated_Invoice_RequestType Put_Consolidated_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Consolidated_InvoiceAsync(new Put_Consolidated_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Consolidated_Invoice_Request = Put_Consolidated_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Alternate_Customer_ContractsOutput Revenue_ManagementPort.Get_Alternate_Customer_Contracts(Get_Alternate_Customer_ContractsInput request)
		{
			return base.Channel.Get_Alternate_Customer_Contracts(request);
		}

		public Get_Alternate_Customer_Contracts_ResponseType Get_Alternate_Customer_Contracts(Workday_Common_HeaderType Workday_Common_Header, Get_Alternate_Customer_Contracts_RequestType Get_Alternate_Customer_Contracts_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Alternate_Customer_Contracts(new Get_Alternate_Customer_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Alternate_Customer_Contracts_Request = Get_Alternate_Customer_Contracts_Request
			}).Get_Alternate_Customer_Contracts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Alternate_Customer_ContractsOutput> Revenue_ManagementPort.Get_Alternate_Customer_ContractsAsync(Get_Alternate_Customer_ContractsInput request)
		{
			return base.Channel.Get_Alternate_Customer_ContractsAsync(request);
		}

		public Task<Get_Alternate_Customer_ContractsOutput> Get_Alternate_Customer_ContractsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Alternate_Customer_Contracts_RequestType Get_Alternate_Customer_Contracts_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Alternate_Customer_ContractsAsync(new Get_Alternate_Customer_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Alternate_Customer_Contracts_Request = Get_Alternate_Customer_Contracts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Alternate_Customer_ContractOutput Revenue_ManagementPort.Put_Alternate_Customer_Contract(Put_Alternate_Customer_ContractInput request)
		{
			return base.Channel.Put_Alternate_Customer_Contract(request);
		}

		public Put_Alternate_Customer_Contract_ResponseType Put_Alternate_Customer_Contract(Workday_Common_HeaderType Workday_Common_Header, Put_Alternate_Customer_Contract_RequestType Put_Alternate_Customer_Contract_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Alternate_Customer_Contract(new Put_Alternate_Customer_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Alternate_Customer_Contract_Request = Put_Alternate_Customer_Contract_Request
			}).Put_Alternate_Customer_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Alternate_Customer_ContractOutput> Revenue_ManagementPort.Put_Alternate_Customer_ContractAsync(Put_Alternate_Customer_ContractInput request)
		{
			return base.Channel.Put_Alternate_Customer_ContractAsync(request);
		}

		public Task<Put_Alternate_Customer_ContractOutput> Put_Alternate_Customer_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Alternate_Customer_Contract_RequestType Put_Alternate_Customer_Contract_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Alternate_Customer_ContractAsync(new Put_Alternate_Customer_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Alternate_Customer_Contract_Request = Put_Alternate_Customer_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Dunning_Level_GroupsOutput Revenue_ManagementPort.Get_Dunning_Level_Groups(Get_Dunning_Level_GroupsInput request)
		{
			return base.Channel.Get_Dunning_Level_Groups(request);
		}

		public Get_Dunning_Level_Groups_ResponseType Get_Dunning_Level_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Dunning_Level_Groups_RequestType Get_Dunning_Level_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Dunning_Level_Groups(new Get_Dunning_Level_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Dunning_Level_Groups_Request = Get_Dunning_Level_Groups_Request
			}).Get_Dunning_Level_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Dunning_Level_GroupsOutput> Revenue_ManagementPort.Get_Dunning_Level_GroupsAsync(Get_Dunning_Level_GroupsInput request)
		{
			return base.Channel.Get_Dunning_Level_GroupsAsync(request);
		}

		public Task<Get_Dunning_Level_GroupsOutput> Get_Dunning_Level_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Dunning_Level_Groups_RequestType Get_Dunning_Level_Groups_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Dunning_Level_GroupsAsync(new Get_Dunning_Level_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Dunning_Level_Groups_Request = Get_Dunning_Level_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Dunning_Level_GroupOutput Revenue_ManagementPort.Put_Dunning_Level_Group(Put_Dunning_Level_GroupInput request)
		{
			return base.Channel.Put_Dunning_Level_Group(request);
		}

		public Put_Dunning_Level_Group_ResponseType Put_Dunning_Level_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Dunning_Level_Group_RequestType Put_Dunning_Level_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Dunning_Level_Group(new Put_Dunning_Level_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dunning_Level_Group_Request = Put_Dunning_Level_Group_Request
			}).Put_Dunning_Level_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Dunning_Level_GroupOutput> Revenue_ManagementPort.Put_Dunning_Level_GroupAsync(Put_Dunning_Level_GroupInput request)
		{
			return base.Channel.Put_Dunning_Level_GroupAsync(request);
		}

		public Task<Put_Dunning_Level_GroupOutput> Put_Dunning_Level_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Dunning_Level_Group_RequestType Put_Dunning_Level_Group_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Dunning_Level_GroupAsync(new Put_Dunning_Level_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dunning_Level_Group_Request = Put_Dunning_Level_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Usage_Billing_RateOutput Revenue_ManagementPort.Put_Usage_Billing_Rate(Put_Usage_Billing_RateInput request)
		{
			return base.Channel.Put_Usage_Billing_Rate(request);
		}

		public Put_Usage_Billing_Rate_ResponseType Put_Usage_Billing_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Usage_Billing_Rate_RequestType Put_Usage_Billing_Rate_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Usage_Billing_Rate(new Put_Usage_Billing_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Usage_Billing_Rate_Request = Put_Usage_Billing_Rate_Request
			}).Put_Usage_Billing_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Usage_Billing_RateOutput> Revenue_ManagementPort.Put_Usage_Billing_RateAsync(Put_Usage_Billing_RateInput request)
		{
			return base.Channel.Put_Usage_Billing_RateAsync(request);
		}

		public Task<Put_Usage_Billing_RateOutput> Put_Usage_Billing_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Usage_Billing_Rate_RequestType Put_Usage_Billing_Rate_Request)
		{
			return ((Revenue_ManagementPort)this).Put_Usage_Billing_RateAsync(new Put_Usage_Billing_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Usage_Billing_Rate_Request = Put_Usage_Billing_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Usage_Billing_RatesOutput Revenue_ManagementPort.Get_Usage_Billing_Rates(Get_Usage_Billing_RatesInput request)
		{
			return base.Channel.Get_Usage_Billing_Rates(request);
		}

		public Get_Usage_Billing_Rates_ResponseType Get_Usage_Billing_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Usage_Billing_Rates_RequestType Get_Usage_Billing_Rates_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Usage_Billing_Rates(new Get_Usage_Billing_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Usage_Billing_Rates_Request = Get_Usage_Billing_Rates_Request
			}).Get_Usage_Billing_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Usage_Billing_RatesOutput> Revenue_ManagementPort.Get_Usage_Billing_RatesAsync(Get_Usage_Billing_RatesInput request)
		{
			return base.Channel.Get_Usage_Billing_RatesAsync(request);
		}

		public Task<Get_Usage_Billing_RatesOutput> Get_Usage_Billing_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Usage_Billing_Rates_RequestType Get_Usage_Billing_Rates_Request)
		{
			return ((Revenue_ManagementPort)this).Get_Usage_Billing_RatesAsync(new Get_Usage_Billing_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Usage_Billing_Rates_Request = Get_Usage_Billing_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Customer_InvoiceOutput Revenue_ManagementPort.Import_Customer_Invoice(Import_Customer_InvoiceInput request)
		{
			return base.Channel.Import_Customer_Invoice(request);
		}

		public Put_Import_Process_ResponseType Import_Customer_Invoice(Workday_Common_HeaderType Workday_Common_Header, Import_Customer_Invoice_RequestType Import_Customer_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Import_Customer_Invoice(new Import_Customer_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Customer_Invoice_Request = Import_Customer_Invoice_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Customer_InvoiceOutput> Revenue_ManagementPort.Import_Customer_InvoiceAsync(Import_Customer_InvoiceInput request)
		{
			return base.Channel.Import_Customer_InvoiceAsync(request);
		}

		public Task<Import_Customer_InvoiceOutput> Import_Customer_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Customer_Invoice_RequestType Import_Customer_Invoice_Request)
		{
			return ((Revenue_ManagementPort)this).Import_Customer_InvoiceAsync(new Import_Customer_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Customer_Invoice_Request = Import_Customer_Invoice_Request
			});
		}
	}
}
