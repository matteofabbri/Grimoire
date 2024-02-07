using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Resource_ManagementPortClient : ClientBase<Resource_ManagementPort>, Resource_ManagementPort
	{
		public Resource_ManagementPortClient()
		{
		}

		public Resource_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Resource_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Resource_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Resource_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_InvoiceOutput Resource_ManagementPort.Submit_Supplier_Invoice(Submit_Supplier_InvoiceInput request)
		{
			return base.Channel.Submit_Supplier_Invoice(request);
		}

		public Submit_Supplier_Invoice_ResponseType Submit_Supplier_Invoice(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_RequestType Submit_Supplier_Invoice_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice(new Submit_Supplier_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Request = Submit_Supplier_Invoice_Request
			}).Submit_Supplier_Invoice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_InvoiceOutput> Resource_ManagementPort.Submit_Supplier_InvoiceAsync(Submit_Supplier_InvoiceInput request)
		{
			return base.Channel.Submit_Supplier_InvoiceAsync(request);
		}

		public Task<Submit_Supplier_InvoiceOutput> Submit_Supplier_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_RequestType Submit_Supplier_Invoice_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_InvoiceAsync(new Submit_Supplier_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Request = Submit_Supplier_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Resource_CategoriesOutput Resource_ManagementPort.Get_Resource_Categories(Get_Resource_CategoriesInput request)
		{
			return base.Channel.Get_Resource_Categories(request);
		}

		public Get_Resource_Categories_ResponseType Get_Resource_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Categories_RequestType Get_Resource_Categories_Request)
		{
			return ((Resource_ManagementPort)this).Get_Resource_Categories(new Get_Resource_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Categories_Request = Get_Resource_Categories_Request
			}).Get_Resource_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Resource_CategoriesOutput> Resource_ManagementPort.Get_Resource_CategoriesAsync(Get_Resource_CategoriesInput request)
		{
			return base.Channel.Get_Resource_CategoriesAsync(request);
		}

		public Task<Get_Resource_CategoriesOutput> Get_Resource_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Categories_RequestType Get_Resource_Categories_Request)
		{
			return ((Resource_ManagementPort)this).Get_Resource_CategoriesAsync(new Get_Resource_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Categories_Request = Get_Resource_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Resource_CategoryOutput Resource_ManagementPort.Put_Resource_Category(Put_Resource_CategoryInput request)
		{
			return base.Channel.Put_Resource_Category(request);
		}

		public Put_Resource_Category_ResponseType Put_Resource_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Resource_Category_RequestType Put_Resource_Category_Request)
		{
			return ((Resource_ManagementPort)this).Put_Resource_Category(new Put_Resource_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Resource_Category_Request = Put_Resource_Category_Request
			}).Put_Resource_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Resource_CategoryOutput> Resource_ManagementPort.Put_Resource_CategoryAsync(Put_Resource_CategoryInput request)
		{
			return base.Channel.Put_Resource_CategoryAsync(request);
		}

		public Task<Put_Resource_CategoryOutput> Put_Resource_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Resource_Category_RequestType Put_Resource_Category_Request)
		{
			return ((Resource_ManagementPort)this).Put_Resource_CategoryAsync(new Put_Resource_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Resource_Category_Request = Put_Resource_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Purchase_Item_GroupsOutput Resource_ManagementPort.Get_Purchase_Item_Groups(Get_Purchase_Item_GroupsInput request)
		{
			return base.Channel.Get_Purchase_Item_Groups(request);
		}

		public Get_Purchase_Item_Groups_ResponseType Get_Purchase_Item_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Item_Groups_RequestType Get_Purchase_Item_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Item_Groups(new Get_Purchase_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Item_Groups_Request = Get_Purchase_Item_Groups_Request
			}).Get_Purchase_Item_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Purchase_Item_GroupsOutput> Resource_ManagementPort.Get_Purchase_Item_GroupsAsync(Get_Purchase_Item_GroupsInput request)
		{
			return base.Channel.Get_Purchase_Item_GroupsAsync(request);
		}

		public Task<Get_Purchase_Item_GroupsOutput> Get_Purchase_Item_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Item_Groups_RequestType Get_Purchase_Item_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Item_GroupsAsync(new Get_Purchase_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Item_Groups_Request = Get_Purchase_Item_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Purchase_Item_GroupOutput Resource_ManagementPort.Put_Purchase_Item_Group(Put_Purchase_Item_GroupInput request)
		{
			return base.Channel.Put_Purchase_Item_Group(request);
		}

		public Put_Purchase_Item_Group_ResponseType Put_Purchase_Item_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Purchase_Item_Group_RequestType Put_Purchase_Item_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Purchase_Item_Group(new Put_Purchase_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Purchase_Item_Group_Request = Put_Purchase_Item_Group_Request
			}).Put_Purchase_Item_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Purchase_Item_GroupOutput> Resource_ManagementPort.Put_Purchase_Item_GroupAsync(Put_Purchase_Item_GroupInput request)
		{
			return base.Channel.Put_Purchase_Item_GroupAsync(request);
		}

		public Task<Put_Purchase_Item_GroupOutput> Put_Purchase_Item_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Purchase_Item_Group_RequestType Put_Purchase_Item_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Purchase_Item_GroupAsync(new Put_Purchase_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Purchase_Item_Group_Request = Put_Purchase_Item_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_ItemsOutput Resource_ManagementPort.Get_Expense_Items(Get_Expense_ItemsInput request)
		{
			return base.Channel.Get_Expense_Items(request);
		}

		public Get_Expense_Items_ResponseType Get_Expense_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Items_RequestType Get_Expense_Items_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Items(new Get_Expense_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Items_Request = Get_Expense_Items_Request
			}).Get_Expense_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_ItemsOutput> Resource_ManagementPort.Get_Expense_ItemsAsync(Get_Expense_ItemsInput request)
		{
			return base.Channel.Get_Expense_ItemsAsync(request);
		}

		public Task<Get_Expense_ItemsOutput> Get_Expense_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Items_RequestType Get_Expense_Items_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_ItemsAsync(new Get_Expense_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Items_Request = Get_Expense_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Purchase_ItemsOutput Resource_ManagementPort.Get_Purchase_Items(Get_Purchase_ItemsInput request)
		{
			return base.Channel.Get_Purchase_Items(request);
		}

		public Get_Purchase_Items_ResponseType Get_Purchase_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Items_RequestType Get_Purchase_Items_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Items(new Get_Purchase_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Items_Request = Get_Purchase_Items_Request
			}).Get_Purchase_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Purchase_ItemsOutput> Resource_ManagementPort.Get_Purchase_ItemsAsync(Get_Purchase_ItemsInput request)
		{
			return base.Channel.Get_Purchase_ItemsAsync(request);
		}

		public Task<Get_Purchase_ItemsOutput> Get_Purchase_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Items_RequestType Get_Purchase_Items_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_ItemsAsync(new Get_Purchase_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Items_Request = Get_Purchase_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Purchase_ItemOutput Resource_ManagementPort.Put_Purchase_Item(Put_Purchase_ItemInput request)
		{
			return base.Channel.Put_Purchase_Item(request);
		}

		public Put_Purchase_Item_ResponseType Put_Purchase_Item(Workday_Common_HeaderType Workday_Common_Header, Put_Purchase_Item_RequestType Put_Purchase_Item_Request)
		{
			return ((Resource_ManagementPort)this).Put_Purchase_Item(new Put_Purchase_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Purchase_Item_Request = Put_Purchase_Item_Request
			}).Put_Purchase_Item_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Purchase_ItemOutput> Resource_ManagementPort.Put_Purchase_ItemAsync(Put_Purchase_ItemInput request)
		{
			return base.Channel.Put_Purchase_ItemAsync(request);
		}

		public Task<Put_Purchase_ItemOutput> Put_Purchase_ItemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Purchase_Item_RequestType Put_Purchase_Item_Request)
		{
			return ((Resource_ManagementPort)this).Put_Purchase_ItemAsync(new Put_Purchase_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Purchase_Item_Request = Put_Purchase_Item_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_ItemOutput Resource_ManagementPort.Put_Expense_Item(Put_Expense_ItemInput request)
		{
			return base.Channel.Put_Expense_Item(request);
		}

		public Put_Expense_Item_ResponseType Put_Expense_Item(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_RequestType Put_Expense_Item_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Item(new Put_Expense_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Item_Request = Put_Expense_Item_Request
			}).Put_Expense_Item_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_ItemOutput> Resource_ManagementPort.Put_Expense_ItemAsync(Put_Expense_ItemInput request)
		{
			return base.Channel.Put_Expense_ItemAsync(request);
		}

		public Task<Put_Expense_ItemOutput> Put_Expense_ItemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_RequestType Put_Expense_Item_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_ItemAsync(new Put_Expense_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Item_Request = Put_Expense_Item_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SuppliersOutput Resource_ManagementPort.Get_Suppliers(Get_SuppliersInput request)
		{
			return base.Channel.Get_Suppliers(request);
		}

		public Get_Suppliers_ResponseType Get_Suppliers(Workday_Common_HeaderType Workday_Common_Header, Get_Suppliers_RequestType Get_Suppliers_Request)
		{
			return ((Resource_ManagementPort)this).Get_Suppliers(new Get_SuppliersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Suppliers_Request = Get_Suppliers_Request
			}).Get_Suppliers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SuppliersOutput> Resource_ManagementPort.Get_SuppliersAsync(Get_SuppliersInput request)
		{
			return base.Channel.Get_SuppliersAsync(request);
		}

		public Task<Get_SuppliersOutput> Get_SuppliersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Suppliers_RequestType Get_Suppliers_Request)
		{
			return ((Resource_ManagementPort)this).Get_SuppliersAsync(new Get_SuppliersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Suppliers_Request = Get_Suppliers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SupplierOutput Resource_ManagementPort.Put_Supplier(Put_SupplierInput request)
		{
			return base.Channel.Put_Supplier(request);
		}

		public Put_Supplier_ResponseType Put_Supplier(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_RequestType Put_Supplier_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier(new Put_SupplierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Request = Put_Supplier_Request
			}).Put_Supplier_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SupplierOutput> Resource_ManagementPort.Put_SupplierAsync(Put_SupplierInput request)
		{
			return base.Channel.Put_SupplierAsync(request);
		}

		public Task<Put_SupplierOutput> Put_SupplierAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_RequestType Put_Supplier_Request)
		{
			return ((Resource_ManagementPort)this).Put_SupplierAsync(new Put_SupplierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Request = Put_Supplier_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_Invoice_AdjustmentOutput Resource_ManagementPort.Submit_Supplier_Invoice_Adjustment(Submit_Supplier_Invoice_AdjustmentInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_Adjustment(request);
		}

		public Submit_Supplier_Invoice_Adjustment_ResponseType Submit_Supplier_Invoice_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Adjustment_RequestType Submit_Supplier_Invoice_Adjustment_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_Adjustment(new Submit_Supplier_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Adjustment_Request = Submit_Supplier_Invoice_Adjustment_Request
			}).Submit_Supplier_Invoice_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_Invoice_AdjustmentOutput> Resource_ManagementPort.Submit_Supplier_Invoice_AdjustmentAsync(Submit_Supplier_Invoice_AdjustmentInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_AdjustmentAsync(request);
		}

		public Task<Submit_Supplier_Invoice_AdjustmentOutput> Submit_Supplier_Invoice_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Adjustment_RequestType Submit_Supplier_Invoice_Adjustment_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_AdjustmentAsync(new Submit_Supplier_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Adjustment_Request = Submit_Supplier_Invoice_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Item_GroupsOutput Resource_ManagementPort.Get_Expense_Item_Groups(Get_Expense_Item_GroupsInput request)
		{
			return base.Channel.Get_Expense_Item_Groups(request);
		}

		public Get_Expense_Item_Groups_ResponseType Get_Expense_Item_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Item_Groups_RequestType Get_Expense_Item_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Item_Groups(new Get_Expense_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Item_Groups_Request = Get_Expense_Item_Groups_Request
			}).Get_Expense_Item_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Item_GroupsOutput> Resource_ManagementPort.Get_Expense_Item_GroupsAsync(Get_Expense_Item_GroupsInput request)
		{
			return base.Channel.Get_Expense_Item_GroupsAsync(request);
		}

		public Task<Get_Expense_Item_GroupsOutput> Get_Expense_Item_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Item_Groups_RequestType Get_Expense_Item_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Item_GroupsAsync(new Get_Expense_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Item_Groups_Request = Get_Expense_Item_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Item_GroupOutput Resource_ManagementPort.Put_Expense_Item_Group(Put_Expense_Item_GroupInput request)
		{
			return base.Channel.Put_Expense_Item_Group(request);
		}

		public Put_Expense_Item_Group_ResponseType Put_Expense_Item_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_Group_RequestType Put_Expense_Item_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Item_Group(new Put_Expense_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Item_Group_Request = Put_Expense_Item_Group_Request
			}).Put_Expense_Item_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Item_GroupOutput> Resource_ManagementPort.Put_Expense_Item_GroupAsync(Put_Expense_Item_GroupInput request)
		{
			return base.Channel.Put_Expense_Item_GroupAsync(request);
		}

		public Task<Put_Expense_Item_GroupOutput> Put_Expense_Item_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_Group_RequestType Put_Expense_Item_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Item_GroupAsync(new Put_Expense_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Item_Group_Request = Put_Expense_Item_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Supplier_InvoiceOutput Resource_ManagementPort.Cancel_Supplier_Invoice(Cancel_Supplier_InvoiceInput request)
		{
			return base.Channel.Cancel_Supplier_Invoice(request);
		}

		public Cancel_Supplier_Invoice_ResponseType Cancel_Supplier_Invoice(Workday_Common_HeaderType Workday_Common_Header, Cancel_Supplier_Invoice_RequestType Cancel_Supplier_Invoice_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Supplier_Invoice(new Cancel_Supplier_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Supplier_Invoice_Request = Cancel_Supplier_Invoice_Request
			}).Cancel_Supplier_Invoice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Supplier_InvoiceOutput> Resource_ManagementPort.Cancel_Supplier_InvoiceAsync(Cancel_Supplier_InvoiceInput request)
		{
			return base.Channel.Cancel_Supplier_InvoiceAsync(request);
		}

		public Task<Cancel_Supplier_InvoiceOutput> Cancel_Supplier_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Supplier_Invoice_RequestType Cancel_Supplier_Invoice_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Supplier_InvoiceAsync(new Cancel_Supplier_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Supplier_Invoice_Request = Cancel_Supplier_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Supplier_Invoice_AdjustmentOutput Resource_ManagementPort.Cancel_Supplier_Invoice_Adjustment(Cancel_Supplier_Invoice_AdjustmentInput request)
		{
			return base.Channel.Cancel_Supplier_Invoice_Adjustment(request);
		}

		public Cancel_Supplier_Invoice_Adjustment_ResponseType Cancel_Supplier_Invoice_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Cancel_Supplier_Invoice_Adjustment_RequestType Cancel_Supplier_Invoice_Adjustment_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Supplier_Invoice_Adjustment(new Cancel_Supplier_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Supplier_Invoice_Adjustment_Request = Cancel_Supplier_Invoice_Adjustment_Request
			}).Cancel_Supplier_Invoice_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Supplier_Invoice_AdjustmentOutput> Resource_ManagementPort.Cancel_Supplier_Invoice_AdjustmentAsync(Cancel_Supplier_Invoice_AdjustmentInput request)
		{
			return base.Channel.Cancel_Supplier_Invoice_AdjustmentAsync(request);
		}

		public Task<Cancel_Supplier_Invoice_AdjustmentOutput> Cancel_Supplier_Invoice_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Supplier_Invoice_Adjustment_RequestType Cancel_Supplier_Invoice_Adjustment_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Supplier_Invoice_AdjustmentAsync(new Cancel_Supplier_Invoice_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Supplier_Invoice_Adjustment_Request = Cancel_Supplier_Invoice_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PO_for_PO_Issue_OutboundOutput Resource_ManagementPort.Get_PO_for_PO_Issue_Outbound(Get_PO_for_PO_Issue_OutboundInput request)
		{
			return base.Channel.Get_PO_for_PO_Issue_Outbound(request);
		}

		public Issue_Purchase_Order_OutboundType Get_PO_for_PO_Issue_Outbound(Workday_Common_HeaderType Workday_Common_Header, Get_PO_Outbound_RequestType Get_PO_Outbound_Request)
		{
			return ((Resource_ManagementPort)this).Get_PO_for_PO_Issue_Outbound(new Get_PO_for_PO_Issue_OutboundInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_PO_Outbound_Request = Get_PO_Outbound_Request
			}).Issue_Purchase_Order_Outbound;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PO_for_PO_Issue_OutboundOutput> Resource_ManagementPort.Get_PO_for_PO_Issue_OutboundAsync(Get_PO_for_PO_Issue_OutboundInput request)
		{
			return base.Channel.Get_PO_for_PO_Issue_OutboundAsync(request);
		}

		public Task<Get_PO_for_PO_Issue_OutboundOutput> Get_PO_for_PO_Issue_OutboundAsync(Workday_Common_HeaderType Workday_Common_Header, Get_PO_Outbound_RequestType Get_PO_Outbound_Request)
		{
			return ((Resource_ManagementPort)this).Get_PO_for_PO_Issue_OutboundAsync(new Get_PO_for_PO_Issue_OutboundInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_PO_Outbound_Request = Get_PO_Outbound_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_CategoriesOutput Resource_ManagementPort.Get_Supplier_Categories(Get_Supplier_CategoriesInput request)
		{
			return base.Channel.Get_Supplier_Categories(request);
		}

		public Get_Supplier_Categories_ResponseType Get_Supplier_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Categories_RequestType Get_Supplier_Categories_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Categories(new Get_Supplier_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Categories_Request = Get_Supplier_Categories_Request
			}).Get_Supplier_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_CategoriesOutput> Resource_ManagementPort.Get_Supplier_CategoriesAsync(Get_Supplier_CategoriesInput request)
		{
			return base.Channel.Get_Supplier_CategoriesAsync(request);
		}

		public Task<Get_Supplier_CategoriesOutput> Get_Supplier_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Categories_RequestType Get_Supplier_Categories_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_CategoriesAsync(new Get_Supplier_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Categories_Request = Get_Supplier_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Supplier_CategoryOutput Resource_ManagementPort.Put_Supplier_Category(Put_Supplier_CategoryInput request)
		{
			return base.Channel.Put_Supplier_Category(request);
		}

		public Put_Supplier_Category_ResponseType Put_Supplier_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Category_RequestType Put_Supplier_Category_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier_Category(new Put_Supplier_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Category_Request = Put_Supplier_Category_Request
			}).Put_Supplier_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Supplier_CategoryOutput> Resource_ManagementPort.Put_Supplier_CategoryAsync(Put_Supplier_CategoryInput request)
		{
			return base.Channel.Put_Supplier_CategoryAsync(request);
		}

		public Task<Put_Supplier_CategoryOutput> Put_Supplier_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Category_RequestType Put_Supplier_Category_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier_CategoryAsync(new Put_Supplier_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Category_Request = Put_Supplier_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Supplier_GroupOutput Resource_ManagementPort.Put_Supplier_Group(Put_Supplier_GroupInput request)
		{
			return base.Channel.Put_Supplier_Group(request);
		}

		public Put_Supplier_Group_ResponseType Put_Supplier_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Group_RequestType Put_Supplier_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier_Group(new Put_Supplier_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Group_Request = Put_Supplier_Group_Request
			}).Put_Supplier_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Supplier_GroupOutput> Resource_ManagementPort.Put_Supplier_GroupAsync(Put_Supplier_GroupInput request)
		{
			return base.Channel.Put_Supplier_GroupAsync(request);
		}

		public Task<Put_Supplier_GroupOutput> Put_Supplier_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Group_RequestType Put_Supplier_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier_GroupAsync(new Put_Supplier_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Group_Request = Put_Supplier_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_GroupsOutput Resource_ManagementPort.Get_Supplier_Groups(Get_Supplier_GroupsInput request)
		{
			return base.Channel.Get_Supplier_Groups(request);
		}

		public Get_Supplier_Groups_ResponseType Get_Supplier_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Groups_RequestType Get_Supplier_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Groups(new Get_Supplier_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Groups_Request = Get_Supplier_Groups_Request
			}).Get_Supplier_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_GroupsOutput> Resource_ManagementPort.Get_Supplier_GroupsAsync(Get_Supplier_GroupsInput request)
		{
			return base.Channel.Get_Supplier_GroupsAsync(request);
		}

		public Task<Get_Supplier_GroupsOutput> Get_Supplier_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Groups_RequestType Get_Supplier_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_GroupsAsync(new Get_Supplier_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Groups_Request = Get_Supplier_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Catalog_LoadOutput Resource_ManagementPort.Submit_Catalog_Load(Submit_Catalog_LoadInput request)
		{
			return base.Channel.Submit_Catalog_Load(request);
		}

		public Submit_Catalog_Load_ResponseType Submit_Catalog_Load(Workday_Common_HeaderType Workday_Common_Header, Submit_Catalog_Load_RequestType Submit_Catalog_Load_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Catalog_Load(new Submit_Catalog_LoadInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Catalog_Load_Request = Submit_Catalog_Load_Request
			}).Submit_Catalog_Load_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Catalog_LoadOutput> Resource_ManagementPort.Submit_Catalog_LoadAsync(Submit_Catalog_LoadInput request)
		{
			return base.Channel.Submit_Catalog_LoadAsync(request);
		}

		public Task<Submit_Catalog_LoadOutput> Submit_Catalog_LoadAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Catalog_Load_RequestType Submit_Catalog_Load_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Catalog_LoadAsync(new Submit_Catalog_LoadInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Catalog_Load_Request = Submit_Catalog_Load_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_TimesheetsOutput Resource_ManagementPort.Get_Timesheets(Get_TimesheetsInput request)
		{
			return base.Channel.Get_Timesheets(request);
		}

		public Get_Timesheets_ResponseType Get_Timesheets(Workday_Common_HeaderType Workday_Common_Header, Get_Timesheets_RequestType Get_Timesheets_Request)
		{
			return ((Resource_ManagementPort)this).Get_Timesheets(new Get_TimesheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Timesheets_Request = Get_Timesheets_Request
			}).Get_Timesheets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_TimesheetsOutput> Resource_ManagementPort.Get_TimesheetsAsync(Get_TimesheetsInput request)
		{
			return base.Channel.Get_TimesheetsAsync(request);
		}

		public Task<Get_TimesheetsOutput> Get_TimesheetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Timesheets_RequestType Get_Timesheets_Request)
		{
			return ((Resource_ManagementPort)this).Get_TimesheetsAsync(new Get_TimesheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Timesheets_Request = Get_Timesheets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Corporate_Credit_Card_AccountsOutput Resource_ManagementPort.Get_Corporate_Credit_Card_Accounts(Get_Corporate_Credit_Card_AccountsInput request)
		{
			return base.Channel.Get_Corporate_Credit_Card_Accounts(request);
		}

		public Get_Corporate_Credit_Card_Accounts_ResponseType Get_Corporate_Credit_Card_Accounts(Workday_Common_HeaderType Workday_Common_Header, Get_Corporate_Credit_Card_Accounts_RequestType Get_Corporate_Credit_Card_Accounts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Corporate_Credit_Card_Accounts(new Get_Corporate_Credit_Card_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Corporate_Credit_Card_Accounts_Request = Get_Corporate_Credit_Card_Accounts_Request
			}).Get_Corporate_Credit_Card_Accounts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Corporate_Credit_Card_AccountsOutput> Resource_ManagementPort.Get_Corporate_Credit_Card_AccountsAsync(Get_Corporate_Credit_Card_AccountsInput request)
		{
			return base.Channel.Get_Corporate_Credit_Card_AccountsAsync(request);
		}

		public Task<Get_Corporate_Credit_Card_AccountsOutput> Get_Corporate_Credit_Card_AccountsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Corporate_Credit_Card_Accounts_RequestType Get_Corporate_Credit_Card_Accounts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Corporate_Credit_Card_AccountsAsync(new Get_Corporate_Credit_Card_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Corporate_Credit_Card_Accounts_Request = Get_Corporate_Credit_Card_Accounts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Corporate_Credit_Card_AccountOutput Resource_ManagementPort.Put_Corporate_Credit_Card_Account(Put_Corporate_Credit_Card_AccountInput request)
		{
			return base.Channel.Put_Corporate_Credit_Card_Account(request);
		}

		public Put_Corporate_Credit_Card_Account_ResponseType Put_Corporate_Credit_Card_Account(Workday_Common_HeaderType Workday_Common_Header, Put_Corporate_Credit_Card_Account_RequestType Put_Corporate_Credit_Card_Account_Request)
		{
			return ((Resource_ManagementPort)this).Put_Corporate_Credit_Card_Account(new Put_Corporate_Credit_Card_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Corporate_Credit_Card_Account_Request = Put_Corporate_Credit_Card_Account_Request
			}).Put_Corporate_Credit_Card_Account_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Corporate_Credit_Card_AccountOutput> Resource_ManagementPort.Put_Corporate_Credit_Card_AccountAsync(Put_Corporate_Credit_Card_AccountInput request)
		{
			return base.Channel.Put_Corporate_Credit_Card_AccountAsync(request);
		}

		public Task<Put_Corporate_Credit_Card_AccountOutput> Put_Corporate_Credit_Card_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Corporate_Credit_Card_Account_RequestType Put_Corporate_Credit_Card_Account_Request)
		{
			return ((Resource_ManagementPort)this).Put_Corporate_Credit_Card_AccountAsync(new Put_Corporate_Credit_Card_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Corporate_Credit_Card_Account_Request = Put_Corporate_Credit_Card_Account_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Credit_CardsOutput Resource_ManagementPort.Get_Expense_Credit_Cards(Get_Expense_Credit_CardsInput request)
		{
			return base.Channel.Get_Expense_Credit_Cards(request);
		}

		public Get_Expense_Credit_Cards_ResponseType Get_Expense_Credit_Cards(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Credit_Cards_RequestType Get_Expense_Credit_Cards_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Credit_Cards(new Get_Expense_Credit_CardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Credit_Cards_Request = Get_Expense_Credit_Cards_Request
			}).Get_Expense_Credit_Cards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Credit_CardsOutput> Resource_ManagementPort.Get_Expense_Credit_CardsAsync(Get_Expense_Credit_CardsInput request)
		{
			return base.Channel.Get_Expense_Credit_CardsAsync(request);
		}

		public Task<Get_Expense_Credit_CardsOutput> Get_Expense_Credit_CardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Credit_Cards_RequestType Get_Expense_Credit_Cards_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Credit_CardsAsync(new Get_Expense_Credit_CardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Credit_Cards_Request = Get_Expense_Credit_Cards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Credit_CardOutput Resource_ManagementPort.Put_Expense_Credit_Card(Put_Expense_Credit_CardInput request)
		{
			return base.Channel.Put_Expense_Credit_Card(request);
		}

		public Put_Expense_Credit_Card_ResponseType Put_Expense_Credit_Card(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Credit_Card_RequestType Put_Expense_Credit_Card_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Credit_Card(new Put_Expense_Credit_CardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Credit_Card_Request = Put_Expense_Credit_Card_Request
			}).Put_Expense_Credit_Card_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Credit_CardOutput> Resource_ManagementPort.Put_Expense_Credit_CardAsync(Put_Expense_Credit_CardInput request)
		{
			return base.Channel.Put_Expense_Credit_CardAsync(request);
		}

		public Task<Put_Expense_Credit_CardOutput> Put_Expense_Credit_CardAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Credit_Card_RequestType Put_Expense_Credit_Card_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Credit_CardAsync(new Put_Expense_Credit_CardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Credit_Card_Request = Put_Expense_Credit_Card_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_Entity_ContactsOutput Resource_ManagementPort.Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_Contacts(request);
		}

		public Get_Business_Entity_Contacts_ResponseType Get_Business_Entity_Contacts(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Business_Entity_Contacts(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			}).Get_Business_Entity_Contacts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_Entity_ContactsOutput> Resource_ManagementPort.Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_ContactsAsync(request);
		}

		public Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Business_Entity_ContactsAsync(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_Entity_ContactOutput Resource_ManagementPort.Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_Contact(request);
		}

		public Put_Business_Entity_Contact_ResponseType Put_Business_Entity_Contact(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Resource_ManagementPort)this).Put_Business_Entity_Contact(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			}).Put_Business_Entity_Contact_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_Entity_ContactOutput> Resource_ManagementPort.Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_ContactAsync(request);
		}

		public Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Resource_ManagementPort)this).Put_Business_Entity_ContactAsync(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_InvoicesOutput Resource_ManagementPort.Get_Supplier_Invoices(Get_Supplier_InvoicesInput request)
		{
			return base.Channel.Get_Supplier_Invoices(request);
		}

		public Get_Supplier_Invoices_ResponseType Get_Supplier_Invoices(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoices_RequestType Get_Supplier_Invoices_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoices(new Get_Supplier_InvoicesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoices_Request = Get_Supplier_Invoices_Request
			}).Get_Supplier_Invoices_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_InvoicesOutput> Resource_ManagementPort.Get_Supplier_InvoicesAsync(Get_Supplier_InvoicesInput request)
		{
			return base.Channel.Get_Supplier_InvoicesAsync(request);
		}

		public Task<Get_Supplier_InvoicesOutput> Get_Supplier_InvoicesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoices_RequestType Get_Supplier_Invoices_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_InvoicesAsync(new Get_Supplier_InvoicesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoices_Request = Get_Supplier_Invoices_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_Invoice_AdjustmentsOutput Resource_ManagementPort.Get_Supplier_Invoice_Adjustments(Get_Supplier_Invoice_AdjustmentsInput request)
		{
			return base.Channel.Get_Supplier_Invoice_Adjustments(request);
		}

		public Get_Supplier_Invoice_Adjustments_ResponseType Get_Supplier_Invoice_Adjustments(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Adjustments_RequestType Get_Supplier_Invoice_Adjustments_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_Adjustments(new Get_Supplier_Invoice_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Adjustments_Request = Get_Supplier_Invoice_Adjustments_Request
			}).Get_Supplier_Invoice_Adjustments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_Invoice_AdjustmentsOutput> Resource_ManagementPort.Get_Supplier_Invoice_AdjustmentsAsync(Get_Supplier_Invoice_AdjustmentsInput request)
		{
			return base.Channel.Get_Supplier_Invoice_AdjustmentsAsync(request);
		}

		public Task<Get_Supplier_Invoice_AdjustmentsOutput> Get_Supplier_Invoice_AdjustmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Adjustments_RequestType Get_Supplier_Invoice_Adjustments_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_AdjustmentsAsync(new Get_Supplier_Invoice_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Adjustments_Request = Get_Supplier_Invoice_Adjustments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Catalog_LoadsOutput Resource_ManagementPort.Get_Catalog_Loads(Get_Catalog_LoadsInput request)
		{
			return base.Channel.Get_Catalog_Loads(request);
		}

		public Get_Catalog_Loads_ResponseType Get_Catalog_Loads(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_Loads_RequestType Get_Catalog_Loads_Request)
		{
			return ((Resource_ManagementPort)this).Get_Catalog_Loads(new Get_Catalog_LoadsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Catalog_Loads_Request = Get_Catalog_Loads_Request
			}).Get_Catalog_Loads_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Catalog_LoadsOutput> Resource_ManagementPort.Get_Catalog_LoadsAsync(Get_Catalog_LoadsInput request)
		{
			return base.Channel.Get_Catalog_LoadsAsync(request);
		}

		public Task<Get_Catalog_LoadsOutput> Get_Catalog_LoadsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_Loads_RequestType Get_Catalog_Loads_Request)
		{
			return ((Resource_ManagementPort)this).Get_Catalog_LoadsAsync(new Get_Catalog_LoadsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Catalog_Loads_Request = Get_Catalog_Loads_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_Invoice_HistoriesOutput Resource_ManagementPort.Get_Supplier_Invoice_Histories(Get_Supplier_Invoice_HistoriesInput request)
		{
			return base.Channel.Get_Supplier_Invoice_Histories(request);
		}

		public Get_Supplier_Invoice_Histories_ResponseType Get_Supplier_Invoice_Histories(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Histories_RequestType Get_Supplier_Invoice_Histories_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_Histories(new Get_Supplier_Invoice_HistoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Histories_Request = Get_Supplier_Invoice_Histories_Request
			}).Get_Supplier_Invoice_Histories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_Invoice_HistoriesOutput> Resource_ManagementPort.Get_Supplier_Invoice_HistoriesAsync(Get_Supplier_Invoice_HistoriesInput request)
		{
			return base.Channel.Get_Supplier_Invoice_HistoriesAsync(request);
		}

		public Task<Get_Supplier_Invoice_HistoriesOutput> Get_Supplier_Invoice_HistoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Histories_RequestType Get_Supplier_Invoice_Histories_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_HistoriesAsync(new Get_Supplier_Invoice_HistoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Histories_Request = Get_Supplier_Invoice_Histories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Supplier_Invoice_HistoryOutput Resource_ManagementPort.Put_Supplier_Invoice_History(Put_Supplier_Invoice_HistoryInput request)
		{
			return base.Channel.Put_Supplier_Invoice_History(request);
		}

		public Put_Supplier_Invoice_History_ResponseType Put_Supplier_Invoice_History(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Invoice_History_RequestType Put_Supplier_Invoice_History_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier_Invoice_History(new Put_Supplier_Invoice_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Invoice_History_Request = Put_Supplier_Invoice_History_Request
			}).Put_Supplier_Invoice_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Supplier_Invoice_HistoryOutput> Resource_ManagementPort.Put_Supplier_Invoice_HistoryAsync(Put_Supplier_Invoice_HistoryInput request)
		{
			return base.Channel.Put_Supplier_Invoice_HistoryAsync(request);
		}

		public Task<Put_Supplier_Invoice_HistoryOutput> Put_Supplier_Invoice_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Invoice_History_RequestType Put_Supplier_Invoice_History_Request)
		{
			return ((Resource_ManagementPort)this).Put_Supplier_Invoice_HistoryAsync(new Put_Supplier_Invoice_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Invoice_History_Request = Put_Supplier_Invoice_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_Worker_RolesOutput Resource_ManagementPort.Get_Project_Worker_Roles(Get_Project_Worker_RolesInput request)
		{
			return base.Channel.Get_Project_Worker_Roles(request);
		}

		public Get_Project_Worker_Roles_ResponseType Get_Project_Worker_Roles(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Worker_Roles_RequestType Get_Project_Worker_Roles_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Worker_Roles(new Get_Project_Worker_RolesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Worker_Roles_Request = Get_Project_Worker_Roles_Request
			}).Get_Project_Worker_Roles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_Worker_RolesOutput> Resource_ManagementPort.Get_Project_Worker_RolesAsync(Get_Project_Worker_RolesInput request)
		{
			return base.Channel.Get_Project_Worker_RolesAsync(request);
		}

		public Task<Get_Project_Worker_RolesOutput> Get_Project_Worker_RolesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Worker_Roles_RequestType Get_Project_Worker_Roles_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Worker_RolesAsync(new Get_Project_Worker_RolesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Worker_Roles_Request = Get_Project_Worker_Roles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_Worker_RoleOutput Resource_ManagementPort.Put_Project_Worker_Role(Put_Project_Worker_RoleInput request)
		{
			return base.Channel.Put_Project_Worker_Role(request);
		}

		public Put_Project_Worker_Role_ResponseType Put_Project_Worker_Role(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Worker_Role_RequestType Put_Project_Worker_Role_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Worker_Role(new Put_Project_Worker_RoleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Worker_Role_Request = Put_Project_Worker_Role_Request
			}).Put_Project_Worker_Role_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_Worker_RoleOutput> Resource_ManagementPort.Put_Project_Worker_RoleAsync(Put_Project_Worker_RoleInput request)
		{
			return base.Channel.Put_Project_Worker_RoleAsync(request);
		}

		public Task<Put_Project_Worker_RoleOutput> Put_Project_Worker_RoleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Worker_Role_RequestType Put_Project_Worker_Role_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Worker_RoleAsync(new Put_Project_Worker_RoleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Worker_Role_Request = Put_Project_Worker_Role_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_TasksOutput Resource_ManagementPort.Get_Project_Tasks(Get_Project_TasksInput request)
		{
			return base.Channel.Get_Project_Tasks(request);
		}

		public Get_Project_Tasks_ResponseType Get_Project_Tasks(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Tasks_RequestType Get_Project_Tasks_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Tasks(new Get_Project_TasksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Tasks_Request = Get_Project_Tasks_Request
			}).Get_Project_Tasks_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_TasksOutput> Resource_ManagementPort.Get_Project_TasksAsync(Get_Project_TasksInput request)
		{
			return base.Channel.Get_Project_TasksAsync(request);
		}

		public Task<Get_Project_TasksOutput> Get_Project_TasksAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Tasks_RequestType Get_Project_Tasks_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_TasksAsync(new Get_Project_TasksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Tasks_Request = Get_Project_Tasks_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_TaskOutput Resource_ManagementPort.Put_Project_Task(Put_Project_TaskInput request)
		{
			return base.Channel.Put_Project_Task(request);
		}

		public Put_Project_Task_ResponseType Put_Project_Task(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Task_RequestType Put_Project_Task_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Task(new Put_Project_TaskInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Task_Request = Put_Project_Task_Request
			}).Put_Project_Task_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_TaskOutput> Resource_ManagementPort.Put_Project_TaskAsync(Put_Project_TaskInput request)
		{
			return base.Channel.Put_Project_TaskAsync(request);
		}

		public Task<Put_Project_TaskOutput> Put_Project_TaskAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Task_RequestType Put_Project_Task_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_TaskAsync(new Put_Project_TaskInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Task_Request = Put_Project_Task_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_PhasesOutput Resource_ManagementPort.Get_Project_Phases(Get_Project_PhasesInput request)
		{
			return base.Channel.Get_Project_Phases(request);
		}

		public Get_Project_Phases_ResponseType Get_Project_Phases(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Phases_RequestType Get_Project_Phases_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Phases(new Get_Project_PhasesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Phases_Request = Get_Project_Phases_Request
			}).Get_Project_Phases_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_PhasesOutput> Resource_ManagementPort.Get_Project_PhasesAsync(Get_Project_PhasesInput request)
		{
			return base.Channel.Get_Project_PhasesAsync(request);
		}

		public Task<Get_Project_PhasesOutput> Get_Project_PhasesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Phases_RequestType Get_Project_Phases_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_PhasesAsync(new Get_Project_PhasesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Phases_Request = Get_Project_Phases_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_PhaseOutput Resource_ManagementPort.Put_Project_Phase(Put_Project_PhaseInput request)
		{
			return base.Channel.Put_Project_Phase(request);
		}

		public Put_Project_Phase_ResponseType Put_Project_Phase(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Phase_RequestType Put_Project_Phase_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Phase(new Put_Project_PhaseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Phase_Request = Put_Project_Phase_Request
			}).Put_Project_Phase_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_PhaseOutput> Resource_ManagementPort.Put_Project_PhaseAsync(Put_Project_PhaseInput request)
		{
			return base.Channel.Put_Project_PhaseAsync(request);
		}

		public Task<Put_Project_PhaseOutput> Put_Project_PhaseAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Phase_RequestType Put_Project_Phase_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_PhaseAsync(new Put_Project_PhaseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Phase_Request = Put_Project_Phase_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Expense_ReportOutput Resource_ManagementPort.Submit_Expense_Report(Submit_Expense_ReportInput request)
		{
			return base.Channel.Submit_Expense_Report(request);
		}

		public Submit_Expense_Report_ResponseType Submit_Expense_Report(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_RequestType Submit_Expense_Report_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Expense_Report(new Submit_Expense_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Expense_Report_Request = Submit_Expense_Report_Request
			}).Submit_Expense_Report_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Expense_ReportOutput> Resource_ManagementPort.Submit_Expense_ReportAsync(Submit_Expense_ReportInput request)
		{
			return base.Channel.Submit_Expense_ReportAsync(request);
		}

		public Task<Submit_Expense_ReportOutput> Submit_Expense_ReportAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_RequestType Submit_Expense_Report_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Expense_ReportAsync(new Submit_Expense_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Expense_Report_Request = Submit_Expense_Report_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_ReportsOutput Resource_ManagementPort.Get_Expense_Reports(Get_Expense_ReportsInput request)
		{
			return base.Channel.Get_Expense_Reports(request);
		}

		public Get_Expense_Reports_ResponseType Get_Expense_Reports(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Reports_RequestType Get_Expense_Reports_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Reports(new Get_Expense_ReportsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Reports_Request = Get_Expense_Reports_Request
			}).Get_Expense_Reports_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_ReportsOutput> Resource_ManagementPort.Get_Expense_ReportsAsync(Get_Expense_ReportsInput request)
		{
			return base.Channel.Get_Expense_ReportsAsync(request);
		}

		public Task<Get_Expense_ReportsOutput> Get_Expense_ReportsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Reports_RequestType Get_Expense_Reports_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_ReportsAsync(new Get_Expense_ReportsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Reports_Request = Get_Expense_Reports_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Expense_ReportOutput Resource_ManagementPort.Cancel_Expense_Report(Cancel_Expense_ReportInput request)
		{
			return base.Channel.Cancel_Expense_Report(request);
		}

		public Cancel_Expense_Report_ResponseType Cancel_Expense_Report(Workday_Common_HeaderType Workday_Common_Header, Cancel_Expense_Report_RequestType Cancel_Expense_Report_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Expense_Report(new Cancel_Expense_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Expense_Report_Request = Cancel_Expense_Report_Request
			}).Cancel_Expense_Report_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Expense_ReportOutput> Resource_ManagementPort.Cancel_Expense_ReportAsync(Cancel_Expense_ReportInput request)
		{
			return base.Channel.Cancel_Expense_ReportAsync(request);
		}

		public Task<Cancel_Expense_ReportOutput> Cancel_Expense_ReportAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Expense_Report_RequestType Cancel_Expense_Report_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Expense_ReportAsync(new Cancel_Expense_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Expense_Report_Request = Cancel_Expense_Report_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Purchase_OrderOutput Resource_ManagementPort.Submit_Purchase_Order(Submit_Purchase_OrderInput request)
		{
			return base.Channel.Submit_Purchase_Order(request);
		}

		public Submit_Purchase_Order_ResponseType Submit_Purchase_Order(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_RequestType Submit_Purchase_Order_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order(new Submit_Purchase_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Request = Submit_Purchase_Order_Request
			}).Submit_Purchase_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Purchase_OrderOutput> Resource_ManagementPort.Submit_Purchase_OrderAsync(Submit_Purchase_OrderInput request)
		{
			return base.Channel.Submit_Purchase_OrderAsync(request);
		}

		public Task<Submit_Purchase_OrderOutput> Submit_Purchase_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_RequestType Submit_Purchase_Order_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_OrderAsync(new Submit_Purchase_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Request = Submit_Purchase_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_Order_ContractsOutput Resource_ManagementPort.Get_Supplier_Order_Contracts(Get_Supplier_Order_ContractsInput request)
		{
			return base.Channel.Get_Supplier_Order_Contracts(request);
		}

		public Get_Supplier_Order_Contracts_ResponseType Get_Supplier_Order_Contracts(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Order_Contracts_RequestType Get_Supplier_Order_Contracts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Order_Contracts(new Get_Supplier_Order_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Order_Contracts_Request = Get_Supplier_Order_Contracts_Request
			}).Get_Supplier_Order_Contracts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_Order_ContractsOutput> Resource_ManagementPort.Get_Supplier_Order_ContractsAsync(Get_Supplier_Order_ContractsInput request)
		{
			return base.Channel.Get_Supplier_Order_ContractsAsync(request);
		}

		public Task<Get_Supplier_Order_ContractsOutput> Get_Supplier_Order_ContractsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Order_Contracts_RequestType Get_Supplier_Order_Contracts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Order_ContractsAsync(new Get_Supplier_Order_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Order_Contracts_Request = Get_Supplier_Order_Contracts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Purchase_OrdersOutput Resource_ManagementPort.Get_Purchase_Orders(Get_Purchase_OrdersInput request)
		{
			return base.Channel.Get_Purchase_Orders(request);
		}

		public Get_Purchase_Orders_ResponseType Get_Purchase_Orders(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Orders_RequestType Get_Purchase_Orders_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Orders(new Get_Purchase_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Orders_Request = Get_Purchase_Orders_Request
			}).Get_Purchase_Orders_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Purchase_OrdersOutput> Resource_ManagementPort.Get_Purchase_OrdersAsync(Get_Purchase_OrdersInput request)
		{
			return base.Channel.Get_Purchase_OrdersAsync(request);
		}

		public Task<Get_Purchase_OrdersOutput> Get_Purchase_OrdersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Orders_RequestType Get_Purchase_Orders_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_OrdersAsync(new Get_Purchase_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Orders_Request = Get_Purchase_Orders_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Policy_GroupsOutput Resource_ManagementPort.Get_Expense_Policy_Groups(Get_Expense_Policy_GroupsInput request)
		{
			return base.Channel.Get_Expense_Policy_Groups(request);
		}

		public Get_Expense_Policy_Groups_ResponseType Get_Expense_Policy_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Policy_Groups_RequestType Get_Expense_Policy_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Policy_Groups(new Get_Expense_Policy_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Policy_Groups_Request = Get_Expense_Policy_Groups_Request
			}).Get_Expense_Policy_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Policy_GroupsOutput> Resource_ManagementPort.Get_Expense_Policy_GroupsAsync(Get_Expense_Policy_GroupsInput request)
		{
			return base.Channel.Get_Expense_Policy_GroupsAsync(request);
		}

		public Task<Get_Expense_Policy_GroupsOutput> Get_Expense_Policy_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Policy_Groups_RequestType Get_Expense_Policy_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Policy_GroupsAsync(new Get_Expense_Policy_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Policy_Groups_Request = Get_Expense_Policy_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Policy_GroupOutput Resource_ManagementPort.Put_Expense_Policy_Group(Put_Expense_Policy_GroupInput request)
		{
			return base.Channel.Put_Expense_Policy_Group(request);
		}

		public Put_Expense_Policy_Group_ResponseType Put_Expense_Policy_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Policy_Group_RequestType Put_Expense_Policy_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Policy_Group(new Put_Expense_Policy_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Policy_Group_Request = Put_Expense_Policy_Group_Request
			}).Put_Expense_Policy_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Policy_GroupOutput> Resource_ManagementPort.Put_Expense_Policy_GroupAsync(Put_Expense_Policy_GroupInput request)
		{
			return base.Channel.Put_Expense_Policy_GroupAsync(request);
		}

		public Task<Put_Expense_Policy_GroupOutput> Put_Expense_Policy_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Policy_Group_RequestType Put_Expense_Policy_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Policy_GroupAsync(new Put_Expense_Policy_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Policy_Group_Request = Put_Expense_Policy_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Rate_Table_RulesOutput Resource_ManagementPort.Get_Expense_Rate_Table_Rules(Get_Expense_Rate_Table_RulesInput request)
		{
			return base.Channel.Get_Expense_Rate_Table_Rules(request);
		}

		public Get_Expense_Rate_Table_Rules_ResponseType Get_Expense_Rate_Table_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Rate_Table_Rules_RequestType Get_Expense_Rate_Table_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Rate_Table_Rules(new Get_Expense_Rate_Table_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Rate_Table_Rules_Request = Get_Expense_Rate_Table_Rules_Request
			}).Get_Expense_Rate_Table_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Rate_Table_RulesOutput> Resource_ManagementPort.Get_Expense_Rate_Table_RulesAsync(Get_Expense_Rate_Table_RulesInput request)
		{
			return base.Channel.Get_Expense_Rate_Table_RulesAsync(request);
		}

		public Task<Get_Expense_Rate_Table_RulesOutput> Get_Expense_Rate_Table_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Rate_Table_Rules_RequestType Get_Expense_Rate_Table_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Rate_Table_RulesAsync(new Get_Expense_Rate_Table_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Rate_Table_Rules_Request = Get_Expense_Rate_Table_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Rate_Table_RuleOutput Resource_ManagementPort.Put_Expense_Rate_Table_Rule(Put_Expense_Rate_Table_RuleInput request)
		{
			return base.Channel.Put_Expense_Rate_Table_Rule(request);
		}

		public Put_Expense_Rate_Table_Rule_ResponseType Put_Expense_Rate_Table_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Rate_Table_Rule_RequestType Put_Expense_Rate_Table_Rule_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Rate_Table_Rule(new Put_Expense_Rate_Table_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Rate_Table_Rule_Request = Put_Expense_Rate_Table_Rule_Request
			}).Put_Expense_Rate_Table_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Rate_Table_RuleOutput> Resource_ManagementPort.Put_Expense_Rate_Table_RuleAsync(Put_Expense_Rate_Table_RuleInput request)
		{
			return base.Channel.Put_Expense_Rate_Table_RuleAsync(request);
		}

		public Task<Put_Expense_Rate_Table_RuleOutput> Put_Expense_Rate_Table_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Rate_Table_Rule_RequestType Put_Expense_Rate_Table_Rule_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Rate_Table_RuleAsync(new Put_Expense_Rate_Table_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Rate_Table_Rule_Request = Put_Expense_Rate_Table_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Rate_TablesOutput Resource_ManagementPort.Get_Expense_Rate_Tables(Get_Expense_Rate_TablesInput request)
		{
			return base.Channel.Get_Expense_Rate_Tables(request);
		}

		public Get_Expense_Rate_Tables_ResponseType Get_Expense_Rate_Tables(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Rate_Tables_RequestType Get_Expense_Rate_Tables_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Rate_Tables(new Get_Expense_Rate_TablesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Rate_Tables_Request = Get_Expense_Rate_Tables_Request
			}).Get_Expense_Rate_Tables_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Rate_TablesOutput> Resource_ManagementPort.Get_Expense_Rate_TablesAsync(Get_Expense_Rate_TablesInput request)
		{
			return base.Channel.Get_Expense_Rate_TablesAsync(request);
		}

		public Task<Get_Expense_Rate_TablesOutput> Get_Expense_Rate_TablesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Rate_Tables_RequestType Get_Expense_Rate_Tables_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Rate_TablesAsync(new Get_Expense_Rate_TablesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Rate_Tables_Request = Get_Expense_Rate_Tables_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Rate_TableOutput Resource_ManagementPort.Put_Expense_Rate_Table(Put_Expense_Rate_TableInput request)
		{
			return base.Channel.Put_Expense_Rate_Table(request);
		}

		public Put_Expense_Rate_Table_ResponseType Put_Expense_Rate_Table(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Rate_Table_RequestType Put_Expense_Rate_Table_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Rate_Table(new Put_Expense_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Rate_Table_Request = Put_Expense_Rate_Table_Request
			}).Put_Expense_Rate_Table_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Rate_TableOutput> Resource_ManagementPort.Put_Expense_Rate_TableAsync(Put_Expense_Rate_TableInput request)
		{
			return base.Channel.Put_Expense_Rate_TableAsync(request);
		}

		public Task<Put_Expense_Rate_TableOutput> Put_Expense_Rate_TableAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Rate_Table_RequestType Put_Expense_Rate_Table_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Rate_TableAsync(new Put_Expense_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Rate_Table_Request = Put_Expense_Rate_Table_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Spend_Category_HierarchyOutput Resource_ManagementPort.Put_Spend_Category_Hierarchy(Put_Spend_Category_HierarchyInput request)
		{
			return base.Channel.Put_Spend_Category_Hierarchy(request);
		}

		public Put_Spend_Category_Hierarchy_ResponseType Put_Spend_Category_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Category_Hierarchy_RequestType Put_Spend_Category_Hierarchy_Request)
		{
			return ((Resource_ManagementPort)this).Put_Spend_Category_Hierarchy(new Put_Spend_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Spend_Category_Hierarchy_Request = Put_Spend_Category_Hierarchy_Request
			}).Put_Spend_Category_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Spend_Category_HierarchyOutput> Resource_ManagementPort.Put_Spend_Category_HierarchyAsync(Put_Spend_Category_HierarchyInput request)
		{
			return base.Channel.Put_Spend_Category_HierarchyAsync(request);
		}

		public Task<Put_Spend_Category_HierarchyOutput> Put_Spend_Category_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Category_Hierarchy_RequestType Put_Spend_Category_Hierarchy_Request)
		{
			return ((Resource_ManagementPort)this).Put_Spend_Category_HierarchyAsync(new Put_Spend_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Spend_Category_Hierarchy_Request = Put_Spend_Category_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Spend_Category_HierarchiesOutput Resource_ManagementPort.Get_Spend_Category_Hierarchies(Get_Spend_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Spend_Category_Hierarchies(request);
		}

		public Get_Spend_Category_Hierarchies_ResponseType Get_Spend_Category_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Category_Hierarchies_RequestType Get_Spend_Category_Hierarchies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Spend_Category_Hierarchies(new Get_Spend_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Category_Hierarchies_Request = Get_Spend_Category_Hierarchies_Request
			}).Get_Spend_Category_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Spend_Category_HierarchiesOutput> Resource_ManagementPort.Get_Spend_Category_HierarchiesAsync(Get_Spend_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Spend_Category_HierarchiesAsync(request);
		}

		public Task<Get_Spend_Category_HierarchiesOutput> Get_Spend_Category_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Category_Hierarchies_RequestType Get_Spend_Category_Hierarchies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Spend_Category_HierarchiesAsync(new Get_Spend_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Category_Hierarchies_Request = Get_Spend_Category_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Expense_Report_for_ApplicantOutput Resource_ManagementPort.Submit_Expense_Report_for_Applicant(Submit_Expense_Report_for_ApplicantInput request)
		{
			return base.Channel.Submit_Expense_Report_for_Applicant(request);
		}

		public Submit_Expense_Report_for_Applicant_ResponseType Submit_Expense_Report_for_Applicant(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_for_Applicant_RequestType Submit_Expense_Report_for_Applicant_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Expense_Report_for_Applicant(new Submit_Expense_Report_for_ApplicantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Expense_Report_for_Applicant_Request = Submit_Expense_Report_for_Applicant_Request
			}).Submit_Expense_Report_for_Applicant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Expense_Report_for_ApplicantOutput> Resource_ManagementPort.Submit_Expense_Report_for_ApplicantAsync(Submit_Expense_Report_for_ApplicantInput request)
		{
			return base.Channel.Submit_Expense_Report_for_ApplicantAsync(request);
		}

		public Task<Submit_Expense_Report_for_ApplicantOutput> Submit_Expense_Report_for_ApplicantAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_for_Applicant_RequestType Submit_Expense_Report_for_Applicant_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Expense_Report_for_ApplicantAsync(new Submit_Expense_Report_for_ApplicantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Expense_Report_for_Applicant_Request = Submit_Expense_Report_for_Applicant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Timesheets_Time_In_Time_OutOutput Resource_ManagementPort.Get_Payroll_Timesheets_Time_In_Time_Out(Get_Payroll_Timesheets_Time_In_Time_OutInput request)
		{
			return base.Channel.Get_Payroll_Timesheets_Time_In_Time_Out(request);
		}

		public Get_Payroll_Timesheets_Time_In_Time_Out_ResponseType Get_Payroll_Timesheets_Time_In_Time_Out(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Timesheets_Time_In_Time_Out_RequestType Get_Payroll_Timesheets_Time_In_Time_Out_Request)
		{
			return ((Resource_ManagementPort)this).Get_Payroll_Timesheets_Time_In_Time_Out(new Get_Payroll_Timesheets_Time_In_Time_OutInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Timesheets_Time_In_Time_Out_Request = Get_Payroll_Timesheets_Time_In_Time_Out_Request
			}).Get_Payroll_Timesheets_Time_In_Time_Out_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Timesheets_Time_In_Time_OutOutput> Resource_ManagementPort.Get_Payroll_Timesheets_Time_In_Time_OutAsync(Get_Payroll_Timesheets_Time_In_Time_OutInput request)
		{
			return base.Channel.Get_Payroll_Timesheets_Time_In_Time_OutAsync(request);
		}

		public Task<Get_Payroll_Timesheets_Time_In_Time_OutOutput> Get_Payroll_Timesheets_Time_In_Time_OutAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Timesheets_Time_In_Time_Out_RequestType Get_Payroll_Timesheets_Time_In_Time_Out_Request)
		{
			return ((Resource_ManagementPort)this).Get_Payroll_Timesheets_Time_In_Time_OutAsync(new Get_Payroll_Timesheets_Time_In_Time_OutInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Timesheets_Time_In_Time_Out_Request = Get_Payroll_Timesheets_Time_In_Time_Out_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Timesheets_Total_HoursOutput Resource_ManagementPort.Get_Payroll_Timesheets_Total_Hours(Get_Payroll_Timesheets_Total_HoursInput request)
		{
			return base.Channel.Get_Payroll_Timesheets_Total_Hours(request);
		}

		public Get_Payroll_Timesheets_Total_Hours_ResponseType Get_Payroll_Timesheets_Total_Hours(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Timesheets_Total_Hours_RequestType Get_Payroll_Timesheets_Total_Hours_Request)
		{
			return ((Resource_ManagementPort)this).Get_Payroll_Timesheets_Total_Hours(new Get_Payroll_Timesheets_Total_HoursInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Timesheets_Total_Hours_Request = Get_Payroll_Timesheets_Total_Hours_Request
			}).Get_Payroll_Timesheets_Total_Hours_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Timesheets_Total_HoursOutput> Resource_ManagementPort.Get_Payroll_Timesheets_Total_HoursAsync(Get_Payroll_Timesheets_Total_HoursInput request)
		{
			return base.Channel.Get_Payroll_Timesheets_Total_HoursAsync(request);
		}

		public Task<Get_Payroll_Timesheets_Total_HoursOutput> Get_Payroll_Timesheets_Total_HoursAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Timesheets_Total_Hours_RequestType Get_Payroll_Timesheets_Total_Hours_Request)
		{
			return ((Resource_ManagementPort)this).Get_Payroll_Timesheets_Total_HoursAsync(new Get_Payroll_Timesheets_Total_HoursInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Timesheets_Total_Hours_Request = Get_Payroll_Timesheets_Total_Hours_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_TimesheetsOutput Resource_ManagementPort.Get_Project_Timesheets(Get_Project_TimesheetsInput request)
		{
			return base.Channel.Get_Project_Timesheets(request);
		}

		public Get_Project_Timesheets_ResponseType Get_Project_Timesheets(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Timesheets_RequestType Get_Project_Timesheets_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Timesheets(new Get_Project_TimesheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Timesheets_Request = Get_Project_Timesheets_Request
			}).Get_Project_Timesheets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_TimesheetsOutput> Resource_ManagementPort.Get_Project_TimesheetsAsync(Get_Project_TimesheetsInput request)
		{
			return base.Channel.Get_Project_TimesheetsAsync(request);
		}

		public Task<Get_Project_TimesheetsOutput> Get_Project_TimesheetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Timesheets_RequestType Get_Project_Timesheets_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_TimesheetsAsync(new Get_Project_TimesheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Timesheets_Request = Get_Project_Timesheets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Project_TimesheetOutput Resource_ManagementPort.Submit_Project_Timesheet(Submit_Project_TimesheetInput request)
		{
			return base.Channel.Submit_Project_Timesheet(request);
		}

		public Submit_Project_Timesheet_ResponseType Submit_Project_Timesheet(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_Timesheet_RequestType Submit_Project_Timesheet_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Project_Timesheet(new Submit_Project_TimesheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Project_Timesheet_Request = Submit_Project_Timesheet_Request
			}).Submit_Project_Timesheet_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Project_TimesheetOutput> Resource_ManagementPort.Submit_Project_TimesheetAsync(Submit_Project_TimesheetInput request)
		{
			return base.Channel.Submit_Project_TimesheetAsync(request);
		}

		public Task<Submit_Project_TimesheetOutput> Submit_Project_TimesheetAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_Timesheet_RequestType Submit_Project_Timesheet_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Project_TimesheetAsync(new Submit_Project_TimesheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Project_Timesheet_Request = Submit_Project_Timesheet_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_TimesheetOutput Resource_ManagementPort.Cancel_Timesheet(Cancel_TimesheetInput request)
		{
			return base.Channel.Cancel_Timesheet(request);
		}

		public Cancel_Timesheet_ResponseType Cancel_Timesheet(Workday_Common_HeaderType Workday_Common_Header, Cancel_Timesheet_RequestType Cancel_Timesheet_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Timesheet(new Cancel_TimesheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Timesheet_Request = Cancel_Timesheet_Request
			}).Cancel_Timesheet_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_TimesheetOutput> Resource_ManagementPort.Cancel_TimesheetAsync(Cancel_TimesheetInput request)
		{
			return base.Channel.Cancel_TimesheetAsync(request);
		}

		public Task<Cancel_TimesheetOutput> Cancel_TimesheetAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Timesheet_RequestType Cancel_Timesheet_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_TimesheetAsync(new Cancel_TimesheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Timesheet_Request = Cancel_Timesheet_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Travel_ProfilesOutput Resource_ManagementPort.Get_Travel_Profiles(Get_Travel_ProfilesInput request)
		{
			return base.Channel.Get_Travel_Profiles(request);
		}

		public Get_Travel_Profiles_ResponseType Get_Travel_Profiles(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Profiles_RequestType Get_Travel_Profiles_Request)
		{
			return ((Resource_ManagementPort)this).Get_Travel_Profiles(new Get_Travel_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Travel_Profiles_Request = Get_Travel_Profiles_Request
			}).Get_Travel_Profiles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Travel_ProfilesOutput> Resource_ManagementPort.Get_Travel_ProfilesAsync(Get_Travel_ProfilesInput request)
		{
			return base.Channel.Get_Travel_ProfilesAsync(request);
		}

		public Task<Get_Travel_ProfilesOutput> Get_Travel_ProfilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Profiles_RequestType Get_Travel_Profiles_Request)
		{
			return ((Resource_ManagementPort)this).Get_Travel_ProfilesAsync(new Get_Travel_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Travel_Profiles_Request = Get_Travel_Profiles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Credit_Card_Transaction_FilesOutput Resource_ManagementPort.Get_Expense_Credit_Card_Transaction_Files(Get_Expense_Credit_Card_Transaction_FilesInput request)
		{
			return base.Channel.Get_Expense_Credit_Card_Transaction_Files(request);
		}

		public Get_Credit_Card_Transaction_Files_ResponseType Get_Expense_Credit_Card_Transaction_Files(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Transaction_Files_RequestType Get_Credit_Card_Transaction_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Credit_Card_Transaction_Files(new Get_Expense_Credit_Card_Transaction_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Credit_Card_Transaction_Files_Request = Get_Credit_Card_Transaction_Files_Request
			}).Get_Credit_Card_Transaction_Files_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Credit_Card_Transaction_FilesOutput> Resource_ManagementPort.Get_Expense_Credit_Card_Transaction_FilesAsync(Get_Expense_Credit_Card_Transaction_FilesInput request)
		{
			return base.Channel.Get_Expense_Credit_Card_Transaction_FilesAsync(request);
		}

		public Task<Get_Expense_Credit_Card_Transaction_FilesOutput> Get_Expense_Credit_Card_Transaction_FilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Transaction_Files_RequestType Get_Credit_Card_Transaction_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Credit_Card_Transaction_FilesAsync(new Get_Expense_Credit_Card_Transaction_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Credit_Card_Transaction_Files_Request = Get_Credit_Card_Transaction_Files_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Credit_Card_Transaction_FileOutput Resource_ManagementPort.Put_Expense_Credit_Card_Transaction_File(Put_Expense_Credit_Card_Transaction_FileInput request)
		{
			return base.Channel.Put_Expense_Credit_Card_Transaction_File(request);
		}

		public Put_Credit_Card_Transaction_File_ResponseType Put_Expense_Credit_Card_Transaction_File(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Transaction_File_RequestType Put_Credit_Card_Transaction_File_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Credit_Card_Transaction_File(new Put_Expense_Credit_Card_Transaction_FileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Credit_Card_Transaction_File_Request = Put_Credit_Card_Transaction_File_Request
			}).Put_Credit_Card_Transaction_File_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Credit_Card_Transaction_FileOutput> Resource_ManagementPort.Put_Expense_Credit_Card_Transaction_FileAsync(Put_Expense_Credit_Card_Transaction_FileInput request)
		{
			return base.Channel.Put_Expense_Credit_Card_Transaction_FileAsync(request);
		}

		public Task<Put_Expense_Credit_Card_Transaction_FileOutput> Put_Expense_Credit_Card_Transaction_FileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Transaction_File_RequestType Put_Credit_Card_Transaction_File_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Credit_Card_Transaction_FileAsync(new Put_Expense_Credit_Card_Transaction_FileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Credit_Card_Transaction_File_Request = Put_Credit_Card_Transaction_File_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Credit_Card_TransactionsOutput Resource_ManagementPort.Get_Expense_Credit_Card_Transactions(Get_Expense_Credit_Card_TransactionsInput request)
		{
			return base.Channel.Get_Expense_Credit_Card_Transactions(request);
		}

		public Get_Expense_Credit_Card_Transactions_ResponseType Get_Expense_Credit_Card_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Credit_Card_Transactions_RequestType Get_Expense_Credit_Card_Transactions_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Credit_Card_Transactions(new Get_Expense_Credit_Card_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Credit_Card_Transactions_Request = Get_Expense_Credit_Card_Transactions_Request
			}).Get_Expense_Credit_Card_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Credit_Card_TransactionsOutput> Resource_ManagementPort.Get_Expense_Credit_Card_TransactionsAsync(Get_Expense_Credit_Card_TransactionsInput request)
		{
			return base.Channel.Get_Expense_Credit_Card_TransactionsAsync(request);
		}

		public Task<Get_Expense_Credit_Card_TransactionsOutput> Get_Expense_Credit_Card_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Credit_Card_Transactions_RequestType Get_Expense_Credit_Card_Transactions_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Credit_Card_TransactionsAsync(new Get_Expense_Credit_Card_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Credit_Card_Transactions_Request = Get_Expense_Credit_Card_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Credit_Card_TransactionOutput Resource_ManagementPort.Put_Expense_Credit_Card_Transaction(Put_Expense_Credit_Card_TransactionInput request)
		{
			return base.Channel.Put_Expense_Credit_Card_Transaction(request);
		}

		public Put_Expense_Credit_Card_Transaction_ResponseType Put_Expense_Credit_Card_Transaction(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Credit_Card_Transaction_RequestType Put_Expense_Credit_Card_Transaction_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Credit_Card_Transaction(new Put_Expense_Credit_Card_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Credit_Card_Transaction_Request = Put_Expense_Credit_Card_Transaction_Request
			}).Put_Expense_Credit_Card_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Credit_Card_TransactionOutput> Resource_ManagementPort.Put_Expense_Credit_Card_TransactionAsync(Put_Expense_Credit_Card_TransactionInput request)
		{
			return base.Channel.Put_Expense_Credit_Card_TransactionAsync(request);
		}

		public Task<Put_Expense_Credit_Card_TransactionOutput> Put_Expense_Credit_Card_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Credit_Card_Transaction_RequestType Put_Expense_Credit_Card_Transaction_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Credit_Card_TransactionAsync(new Put_Expense_Credit_Card_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Credit_Card_Transaction_Request = Put_Expense_Credit_Card_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Card_Holder_Listing_FileOutput Resource_ManagementPort.Put_Card_Holder_Listing_File(Put_Card_Holder_Listing_FileInput request)
		{
			return base.Channel.Put_Card_Holder_Listing_File(request);
		}

		public Put_Card_Holder_Listing_File_ResponseType Put_Card_Holder_Listing_File(Workday_Common_HeaderType Workday_Common_Header, Put_Card_Holder_Listing_File_RequestType Put_Card_Holder_Listing_File_Request)
		{
			return ((Resource_ManagementPort)this).Put_Card_Holder_Listing_File(new Put_Card_Holder_Listing_FileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Card_Holder_Listing_File_Request = Put_Card_Holder_Listing_File_Request
			}).Put_Card_Holder_Listing_File_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Card_Holder_Listing_FileOutput> Resource_ManagementPort.Put_Card_Holder_Listing_FileAsync(Put_Card_Holder_Listing_FileInput request)
		{
			return base.Channel.Put_Card_Holder_Listing_FileAsync(request);
		}

		public Task<Put_Card_Holder_Listing_FileOutput> Put_Card_Holder_Listing_FileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Card_Holder_Listing_File_RequestType Put_Card_Holder_Listing_File_Request)
		{
			return ((Resource_ManagementPort)this).Put_Card_Holder_Listing_FileAsync(new Put_Card_Holder_Listing_FileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Card_Holder_Listing_File_Request = Put_Card_Holder_Listing_File_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Card_Holder_Listing_FilesOutput Resource_ManagementPort.Get_Card_Holder_Listing_Files(Get_Card_Holder_Listing_FilesInput request)
		{
			return base.Channel.Get_Card_Holder_Listing_Files(request);
		}

		public Get_Card_Holder_Listing_Files_ResponseType Get_Card_Holder_Listing_Files(Workday_Common_HeaderType Workday_Common_Header, Get_Card_Holder_Listing_Files_RequestType Get_Card_Holder_Listing_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Card_Holder_Listing_Files(new Get_Card_Holder_Listing_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Card_Holder_Listing_Files_Request = Get_Card_Holder_Listing_Files_Request
			}).Get_Card_Holder_Listing_Files_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Card_Holder_Listing_FilesOutput> Resource_ManagementPort.Get_Card_Holder_Listing_FilesAsync(Get_Card_Holder_Listing_FilesInput request)
		{
			return base.Channel.Get_Card_Holder_Listing_FilesAsync(request);
		}

		public Task<Get_Card_Holder_Listing_FilesOutput> Get_Card_Holder_Listing_FilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Card_Holder_Listing_Files_RequestType Get_Card_Holder_Listing_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Card_Holder_Listing_FilesAsync(new Get_Card_Holder_Listing_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Card_Holder_Listing_Files_Request = Get_Card_Holder_Listing_Files_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Expense_Item_Attribute_GroupOutput Resource_ManagementPort.Put_Expense_Item_Attribute_Group(Put_Expense_Item_Attribute_GroupInput request)
		{
			return base.Channel.Put_Expense_Item_Attribute_Group(request);
		}

		public Put_Expense_Item_Attribute_Group_ResponseType Put_Expense_Item_Attribute_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_Attribute_Group_RequestType Put_Expense_Item_Attribute_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Item_Attribute_Group(new Put_Expense_Item_Attribute_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Item_Attribute_Group_Request = Put_Expense_Item_Attribute_Group_Request
			}).Put_Expense_Item_Attribute_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Expense_Item_Attribute_GroupOutput> Resource_ManagementPort.Put_Expense_Item_Attribute_GroupAsync(Put_Expense_Item_Attribute_GroupInput request)
		{
			return base.Channel.Put_Expense_Item_Attribute_GroupAsync(request);
		}

		public Task<Put_Expense_Item_Attribute_GroupOutput> Put_Expense_Item_Attribute_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Expense_Item_Attribute_Group_RequestType Put_Expense_Item_Attribute_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Expense_Item_Attribute_GroupAsync(new Put_Expense_Item_Attribute_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Expense_Item_Attribute_Group_Request = Put_Expense_Item_Attribute_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Expense_Item_Attribute_GroupsOutput Resource_ManagementPort.Get_Expense_Item_Attribute_Groups(Get_Expense_Item_Attribute_GroupsInput request)
		{
			return base.Channel.Get_Expense_Item_Attribute_Groups(request);
		}

		public Get_Expense_Item_Attribute_Groups_ResponseType Get_Expense_Item_Attribute_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Item_Attribute_Groups_RequestType Get_Expense_Item_Attribute_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Item_Attribute_Groups(new Get_Expense_Item_Attribute_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Item_Attribute_Groups_Request = Get_Expense_Item_Attribute_Groups_Request
			}).Get_Expense_Item_Attribute_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Expense_Item_Attribute_GroupsOutput> Resource_ManagementPort.Get_Expense_Item_Attribute_GroupsAsync(Get_Expense_Item_Attribute_GroupsInput request)
		{
			return base.Channel.Get_Expense_Item_Attribute_GroupsAsync(request);
		}

		public Task<Get_Expense_Item_Attribute_GroupsOutput> Get_Expense_Item_Attribute_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Expense_Item_Attribute_Groups_RequestType Get_Expense_Item_Attribute_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Expense_Item_Attribute_GroupsAsync(new Get_Expense_Item_Attribute_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Expense_Item_Attribute_Groups_Request = Get_Expense_Item_Attribute_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_Invoice_ContractOutput Resource_ManagementPort.Submit_Supplier_Invoice_Contract(Submit_Supplier_Invoice_ContractInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_Contract(request);
		}

		public Submit_Supplier_Invoice_Contract_ResponseType Submit_Supplier_Invoice_Contract(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Contract_RequestType Submit_Supplier_Invoice_Contract_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_Contract(new Submit_Supplier_Invoice_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Contract_Request = Submit_Supplier_Invoice_Contract_Request
			}).Submit_Supplier_Invoice_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_Invoice_ContractOutput> Resource_ManagementPort.Submit_Supplier_Invoice_ContractAsync(Submit_Supplier_Invoice_ContractInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_ContractAsync(request);
		}

		public Task<Submit_Supplier_Invoice_ContractOutput> Submit_Supplier_Invoice_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Contract_RequestType Submit_Supplier_Invoice_Contract_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_ContractAsync(new Submit_Supplier_Invoice_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Contract_Request = Submit_Supplier_Invoice_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_Order_ContractOutput Resource_ManagementPort.Submit_Supplier_Order_Contract(Submit_Supplier_Order_ContractInput request)
		{
			return base.Channel.Submit_Supplier_Order_Contract(request);
		}

		public Submit_Supplier_Order_Contract_ResponseType Submit_Supplier_Order_Contract(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Order_Contract_RequestType Submit_Supplier_Order_Contract_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Order_Contract(new Submit_Supplier_Order_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Order_Contract_Request = Submit_Supplier_Order_Contract_Request
			}).Submit_Supplier_Order_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_Order_ContractOutput> Resource_ManagementPort.Submit_Supplier_Order_ContractAsync(Submit_Supplier_Order_ContractInput request)
		{
			return base.Channel.Submit_Supplier_Order_ContractAsync(request);
		}

		public Task<Submit_Supplier_Order_ContractOutput> Submit_Supplier_Order_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Order_Contract_RequestType Submit_Supplier_Order_Contract_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Order_ContractAsync(new Submit_Supplier_Order_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Order_Contract_Request = Submit_Supplier_Order_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ReceiptsOutput Resource_ManagementPort.Get_Receipts(Get_ReceiptsInput request)
		{
			return base.Channel.Get_Receipts(request);
		}

		public Get_Receipts_ResponseType Get_Receipts(Workday_Common_HeaderType Workday_Common_Header, Get_Receipts_RequestType Get_Receipts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Receipts(new Get_ReceiptsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Receipts_Request = Get_Receipts_Request
			}).Get_Receipts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ReceiptsOutput> Resource_ManagementPort.Get_ReceiptsAsync(Get_ReceiptsInput request)
		{
			return base.Channel.Get_ReceiptsAsync(request);
		}

		public Task<Get_ReceiptsOutput> Get_ReceiptsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Receipts_RequestType Get_Receipts_Request)
		{
			return ((Resource_ManagementPort)this).Get_ReceiptsAsync(new Get_ReceiptsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Receipts_Request = Get_Receipts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_ReceiptOutput Resource_ManagementPort.Submit_Receipt(Submit_ReceiptInput request)
		{
			return base.Channel.Submit_Receipt(request);
		}

		public Submit_Receipt_ResponseType Submit_Receipt(Workday_Common_HeaderType Workday_Common_Header, Submit_Receipt_RequestType Submit_Receipt_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Receipt(new Submit_ReceiptInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Receipt_Request = Submit_Receipt_Request
			}).Submit_Receipt_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_ReceiptOutput> Resource_ManagementPort.Submit_ReceiptAsync(Submit_ReceiptInput request)
		{
			return base.Channel.Submit_ReceiptAsync(request);
		}

		public Task<Submit_ReceiptOutput> Submit_ReceiptAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Receipt_RequestType Submit_Receipt_Request)
		{
			return ((Resource_ManagementPort)this).Submit_ReceiptAsync(new Submit_ReceiptInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Receipt_Request = Submit_Receipt_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Register_AssetOutput Resource_ManagementPort.Register_Asset(Register_AssetInput request)
		{
			return base.Channel.Register_Asset(request);
		}

		public Register_Asset_ResponseType Register_Asset(Workday_Common_HeaderType Workday_Common_Header, Register_Asset_RequestType Register_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Register_Asset(new Register_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Register_Asset_Request = Register_Asset_Request
			}).Register_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Register_AssetOutput> Resource_ManagementPort.Register_AssetAsync(Register_AssetInput request)
		{
			return base.Channel.Register_AssetAsync(request);
		}

		public Task<Register_AssetOutput> Register_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Register_Asset_RequestType Register_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Register_AssetAsync(new Register_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Register_Asset_Request = Register_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Catalog_ItemsOutput Resource_ManagementPort.Get_Catalog_Items(Get_Catalog_ItemsInput request)
		{
			return base.Channel.Get_Catalog_Items(request);
		}

		public Get_Catalog_Items_ResponseType Get_Catalog_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_Items_RequestType Get_Catalog_Items_Request)
		{
			return ((Resource_ManagementPort)this).Get_Catalog_Items(new Get_Catalog_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Catalog_Items_Request = Get_Catalog_Items_Request
			}).Get_Catalog_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Catalog_ItemsOutput> Resource_ManagementPort.Get_Catalog_ItemsAsync(Get_Catalog_ItemsInput request)
		{
			return base.Channel.Get_Catalog_ItemsAsync(request);
		}

		public Task<Get_Catalog_ItemsOutput> Get_Catalog_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Catalog_Items_RequestType Get_Catalog_Items_Request)
		{
			return ((Resource_ManagementPort)this).Get_Catalog_ItemsAsync(new Get_Catalog_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Catalog_Items_Request = Get_Catalog_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Purchase_OrderOutput Resource_ManagementPort.Cancel_Purchase_Order(Cancel_Purchase_OrderInput request)
		{
			return base.Channel.Cancel_Purchase_Order(request);
		}

		public Cancel_Purchase_Order_ResponseType Cancel_Purchase_Order(Workday_Common_HeaderType Workday_Common_Header, Cancel_Purchase_Order_RequestType Cancel_Purchase_Order_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Purchase_Order(new Cancel_Purchase_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Purchase_Order_Request = Cancel_Purchase_Order_Request
			}).Cancel_Purchase_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Purchase_OrderOutput> Resource_ManagementPort.Cancel_Purchase_OrderAsync(Cancel_Purchase_OrderInput request)
		{
			return base.Channel.Cancel_Purchase_OrderAsync(request);
		}

		public Task<Cancel_Purchase_OrderOutput> Cancel_Purchase_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Purchase_Order_RequestType Cancel_Purchase_Order_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Purchase_OrderAsync(new Cancel_Purchase_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Purchase_Order_Request = Cancel_Purchase_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_RequisitionsOutput Resource_ManagementPort.Get_Requisitions(Get_RequisitionsInput request)
		{
			return base.Channel.Get_Requisitions(request);
		}

		public Get_Requisitions_ResponseType Get_Requisitions(Workday_Common_HeaderType Workday_Common_Header, Get_Requisitions_RequestType Get_Requisitions_Request)
		{
			return ((Resource_ManagementPort)this).Get_Requisitions(new Get_RequisitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Requisitions_Request = Get_Requisitions_Request
			}).Get_Requisitions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_RequisitionsOutput> Resource_ManagementPort.Get_RequisitionsAsync(Get_RequisitionsInput request)
		{
			return base.Channel.Get_RequisitionsAsync(request);
		}

		public Task<Get_RequisitionsOutput> Get_RequisitionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Requisitions_RequestType Get_Requisitions_Request)
		{
			return ((Resource_ManagementPort)this).Get_RequisitionsAsync(new Get_RequisitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Requisitions_Request = Get_Requisitions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Asset_Book_RulesOutput Resource_ManagementPort.Get_Asset_Book_Rules(Get_Asset_Book_RulesInput request)
		{
			return base.Channel.Get_Asset_Book_Rules(request);
		}

		public Get_Asset_Book_Rules_ResponseType Get_Asset_Book_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Book_Rules_RequestType Get_Asset_Book_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Book_Rules(new Get_Asset_Book_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Book_Rules_Request = Get_Asset_Book_Rules_Request
			}).Get_Asset_Book_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Asset_Book_RulesOutput> Resource_ManagementPort.Get_Asset_Book_RulesAsync(Get_Asset_Book_RulesInput request)
		{
			return base.Channel.Get_Asset_Book_RulesAsync(request);
		}

		public Task<Get_Asset_Book_RulesOutput> Get_Asset_Book_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Book_Rules_RequestType Get_Asset_Book_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Book_RulesAsync(new Get_Asset_Book_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Book_Rules_Request = Get_Asset_Book_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Asset_Book_RulesOutput Resource_ManagementPort.Put_Asset_Book_Rules(Put_Asset_Book_RulesInput request)
		{
			return base.Channel.Put_Asset_Book_Rules(request);
		}

		public Put_Asset_Book_Rules_ResponseType Put_Asset_Book_Rules(Workday_Common_HeaderType Workday_Common_Header, Put_Asset_Book_Rules_RequestType Put_Asset_Book_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Put_Asset_Book_Rules(new Put_Asset_Book_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Asset_Book_Rules_Request = Put_Asset_Book_Rules_Request
			}).Put_Asset_Book_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Asset_Book_RulesOutput> Resource_ManagementPort.Put_Asset_Book_RulesAsync(Put_Asset_Book_RulesInput request)
		{
			return base.Channel.Put_Asset_Book_RulesAsync(request);
		}

		public Task<Put_Asset_Book_RulesOutput> Put_Asset_Book_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Asset_Book_Rules_RequestType Put_Asset_Book_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Put_Asset_Book_RulesAsync(new Put_Asset_Book_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Asset_Book_Rules_Request = Put_Asset_Book_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_RequisitionOutput Resource_ManagementPort.Cancel_Requisition(Cancel_RequisitionInput request)
		{
			return base.Channel.Cancel_Requisition(request);
		}

		public Cancel_Requisition_ResponseType Cancel_Requisition(Workday_Common_HeaderType Workday_Common_Header, Cancel_Requisition_RequestType Cancel_Requisition_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Requisition(new Cancel_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Requisition_Request = Cancel_Requisition_Request
			}).Cancel_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_RequisitionOutput> Resource_ManagementPort.Cancel_RequisitionAsync(Cancel_RequisitionInput request)
		{
			return base.Channel.Cancel_RequisitionAsync(request);
		}

		public Task<Cancel_RequisitionOutput> Cancel_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Requisition_RequestType Cancel_Requisition_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_RequisitionAsync(new Cancel_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Requisition_Request = Cancel_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Issue_AssetOutput Resource_ManagementPort.Issue_Asset(Issue_AssetInput request)
		{
			return base.Channel.Issue_Asset(request);
		}

		public Issue_Asset_ResponseType Issue_Asset(Workday_Common_HeaderType Workday_Common_Header, Issue_Asset_RequestType Issue_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Issue_Asset(new Issue_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Issue_Asset_Request = Issue_Asset_Request
			}).Issue_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Issue_AssetOutput> Resource_ManagementPort.Issue_AssetAsync(Issue_AssetInput request)
		{
			return base.Channel.Issue_AssetAsync(request);
		}

		public Task<Issue_AssetOutput> Issue_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Issue_Asset_RequestType Issue_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Issue_AssetAsync(new Issue_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Issue_Asset_Request = Issue_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_RequisitionOutput Resource_ManagementPort.Submit_Requisition(Submit_RequisitionInput request)
		{
			return base.Channel.Submit_Requisition(request);
		}

		public Submit_Requisition_ResponseType Submit_Requisition(Workday_Common_HeaderType Workday_Common_Header, Submit_Requisition_RequestType Submit_Requisition_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Requisition(new Submit_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Requisition_Request = Submit_Requisition_Request
			}).Submit_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_RequisitionOutput> Resource_ManagementPort.Submit_RequisitionAsync(Submit_RequisitionInput request)
		{
			return base.Channel.Submit_RequisitionAsync(request);
		}

		public Task<Submit_RequisitionOutput> Submit_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Requisition_RequestType Submit_Requisition_Request)
		{
			return ((Resource_ManagementPort)this).Submit_RequisitionAsync(new Submit_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Requisition_Request = Submit_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Adjust_Asset_CostOutput Resource_ManagementPort.Adjust_Asset_Cost(Adjust_Asset_CostInput request)
		{
			return base.Channel.Adjust_Asset_Cost(request);
		}

		public Adjust_Asset_Cost_ResponseType Adjust_Asset_Cost(Workday_Common_HeaderType Workday_Common_Header, Adjust_Asset_Cost_RequestType Adjust_Asset_Cost_Request)
		{
			return ((Resource_ManagementPort)this).Adjust_Asset_Cost(new Adjust_Asset_CostInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Adjust_Asset_Cost_Request = Adjust_Asset_Cost_Request
			}).Adjust_Asset_Cost_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Adjust_Asset_CostOutput> Resource_ManagementPort.Adjust_Asset_CostAsync(Adjust_Asset_CostInput request)
		{
			return base.Channel.Adjust_Asset_CostAsync(request);
		}

		public Task<Adjust_Asset_CostOutput> Adjust_Asset_CostAsync(Workday_Common_HeaderType Workday_Common_Header, Adjust_Asset_Cost_RequestType Adjust_Asset_Cost_Request)
		{
			return ((Resource_ManagementPort)this).Adjust_Asset_CostAsync(new Adjust_Asset_CostInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Adjust_Asset_Cost_Request = Adjust_Asset_Cost_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_AssetOutput Resource_ManagementPort.Edit_Asset(Edit_AssetInput request)
		{
			return base.Channel.Edit_Asset(request);
		}

		public Edit_Asset_ResponseType Edit_Asset(Workday_Common_HeaderType Workday_Common_Header, Edit_Asset_RequestType Edit_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Edit_Asset(new Edit_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Asset_Request = Edit_Asset_Request
			}).Edit_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_AssetOutput> Resource_ManagementPort.Edit_AssetAsync(Edit_AssetInput request)
		{
			return base.Channel.Edit_AssetAsync(request);
		}

		public Task<Edit_AssetOutput> Edit_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Asset_RequestType Edit_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Edit_AssetAsync(new Edit_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Asset_Request = Edit_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Asset_Useful_LifeOutput Resource_ManagementPort.Update_Asset_Useful_Life(Update_Asset_Useful_LifeInput request)
		{
			return base.Channel.Update_Asset_Useful_Life(request);
		}

		public Update_Asset_Useful_Life_ResponseType Update_Asset_Useful_Life(Workday_Common_HeaderType Workday_Common_Header, Update_Asset_Useful_Life_RequestType Update_Asset_Useful_Life_Request)
		{
			return ((Resource_ManagementPort)this).Update_Asset_Useful_Life(new Update_Asset_Useful_LifeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Asset_Useful_Life_Request = Update_Asset_Useful_Life_Request
			}).Update_Asset_Useful_Life_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Asset_Useful_LifeOutput> Resource_ManagementPort.Update_Asset_Useful_LifeAsync(Update_Asset_Useful_LifeInput request)
		{
			return base.Channel.Update_Asset_Useful_LifeAsync(request);
		}

		public Task<Update_Asset_Useful_LifeOutput> Update_Asset_Useful_LifeAsync(Workday_Common_HeaderType Workday_Common_Header, Update_Asset_Useful_Life_RequestType Update_Asset_Useful_Life_Request)
		{
			return ((Resource_ManagementPort)this).Update_Asset_Useful_LifeAsync(new Update_Asset_Useful_LifeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Asset_Useful_Life_Request = Update_Asset_Useful_Life_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Transfer_AssetOutput Resource_ManagementPort.Transfer_Asset(Transfer_AssetInput request)
		{
			return base.Channel.Transfer_Asset(request);
		}

		public Transfer_Asset_ResponseType Transfer_Asset(Workday_Common_HeaderType Workday_Common_Header, Transfer_Asset_RequestType Transfer_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Transfer_Asset(new Transfer_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Transfer_Asset_Request = Transfer_Asset_Request
			}).Transfer_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Transfer_AssetOutput> Resource_ManagementPort.Transfer_AssetAsync(Transfer_AssetInput request)
		{
			return base.Channel.Transfer_AssetAsync(request);
		}

		public Task<Transfer_AssetOutput> Transfer_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Transfer_Asset_RequestType Transfer_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Transfer_AssetAsync(new Transfer_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Transfer_Asset_Request = Transfer_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Spend_AuthorizationOutput Resource_ManagementPort.Submit_Spend_Authorization(Submit_Spend_AuthorizationInput request)
		{
			return base.Channel.Submit_Spend_Authorization(request);
		}

		public Submit_Spend_Authorization_ResponseType Submit_Spend_Authorization(Workday_Common_HeaderType Workday_Common_Header, Submit_Spend_Authorization_RequestType Submit_Spend_Authorization_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Spend_Authorization(new Submit_Spend_AuthorizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Spend_Authorization_Request = Submit_Spend_Authorization_Request
			}).Submit_Spend_Authorization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Spend_AuthorizationOutput> Resource_ManagementPort.Submit_Spend_AuthorizationAsync(Submit_Spend_AuthorizationInput request)
		{
			return base.Channel.Submit_Spend_AuthorizationAsync(request);
		}

		public Task<Submit_Spend_AuthorizationOutput> Submit_Spend_AuthorizationAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Spend_Authorization_RequestType Submit_Spend_Authorization_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Spend_AuthorizationAsync(new Submit_Spend_AuthorizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Spend_Authorization_Request = Submit_Spend_Authorization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Spend_AuthorizationsOutput Resource_ManagementPort.Get_Spend_Authorizations(Get_Spend_AuthorizationsInput request)
		{
			return base.Channel.Get_Spend_Authorizations(request);
		}

		public Get_Spend_Authorizations_ResponseType Get_Spend_Authorizations(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Authorizations_RequestType Get_Spend_Authorizations_Request)
		{
			return ((Resource_ManagementPort)this).Get_Spend_Authorizations(new Get_Spend_AuthorizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Authorizations_Request = Get_Spend_Authorizations_Request
			}).Get_Spend_Authorizations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Spend_AuthorizationsOutput> Resource_ManagementPort.Get_Spend_AuthorizationsAsync(Get_Spend_AuthorizationsInput request)
		{
			return base.Channel.Get_Spend_AuthorizationsAsync(request);
		}

		public Task<Get_Spend_AuthorizationsOutput> Get_Spend_AuthorizationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Authorizations_RequestType Get_Spend_Authorizations_Request)
		{
			return ((Resource_ManagementPort)this).Get_Spend_AuthorizationsAsync(new Get_Spend_AuthorizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Authorizations_Request = Get_Spend_Authorizations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_Invoice_SchedulesOutput Resource_ManagementPort.Get_Supplier_Invoice_Schedules(Get_Supplier_Invoice_SchedulesInput request)
		{
			return base.Channel.Get_Supplier_Invoice_Schedules(request);
		}

		public Get_Supplier_Invoice_Schedules_ResponseType Get_Supplier_Invoice_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Schedules_RequestType Get_Supplier_Invoice_Schedules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_Schedules(new Get_Supplier_Invoice_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Schedules_Request = Get_Supplier_Invoice_Schedules_Request
			}).Get_Supplier_Invoice_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_Invoice_SchedulesOutput> Resource_ManagementPort.Get_Supplier_Invoice_SchedulesAsync(Get_Supplier_Invoice_SchedulesInput request)
		{
			return base.Channel.Get_Supplier_Invoice_SchedulesAsync(request);
		}

		public Task<Get_Supplier_Invoice_SchedulesOutput> Get_Supplier_Invoice_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Schedules_RequestType Get_Supplier_Invoice_Schedules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_SchedulesAsync(new Get_Supplier_Invoice_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Schedules_Request = Get_Supplier_Invoice_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Purchase_Order_SchedulesOutput Resource_ManagementPort.Get_Purchase_Order_Schedules(Get_Purchase_Order_SchedulesInput request)
		{
			return base.Channel.Get_Purchase_Order_Schedules(request);
		}

		public Get_Purchase_Order_Schedules_ResponseType Get_Purchase_Order_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Schedules_RequestType Get_Purchase_Order_Schedules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Order_Schedules(new Get_Purchase_Order_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Order_Schedules_Request = Get_Purchase_Order_Schedules_Request
			}).Get_Purchase_Order_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Purchase_Order_SchedulesOutput> Resource_ManagementPort.Get_Purchase_Order_SchedulesAsync(Get_Purchase_Order_SchedulesInput request)
		{
			return base.Channel.Get_Purchase_Order_SchedulesAsync(request);
		}

		public Task<Get_Purchase_Order_SchedulesOutput> Get_Purchase_Order_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Schedules_RequestType Get_Purchase_Order_Schedules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Order_SchedulesAsync(new Get_Purchase_Order_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Order_Schedules_Request = Get_Purchase_Order_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_ContractOutput Resource_ManagementPort.Submit_Supplier_Contract(Submit_Supplier_ContractInput request)
		{
			return base.Channel.Submit_Supplier_Contract(request);
		}

		public Submit_Supplier_Contract_ResponseType Submit_Supplier_Contract(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Contract_RequestType Submit_Supplier_Contract_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Contract(new Submit_Supplier_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Contract_Request = Submit_Supplier_Contract_Request
			}).Submit_Supplier_Contract_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_ContractOutput> Resource_ManagementPort.Submit_Supplier_ContractAsync(Submit_Supplier_ContractInput request)
		{
			return base.Channel.Submit_Supplier_ContractAsync(request);
		}

		public Task<Submit_Supplier_ContractOutput> Submit_Supplier_ContractAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Contract_RequestType Submit_Supplier_Contract_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_ContractAsync(new Submit_Supplier_ContractInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Contract_Request = Submit_Supplier_Contract_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_ContractsOutput Resource_ManagementPort.Get_Supplier_Contracts(Get_Supplier_ContractsInput request)
		{
			return base.Channel.Get_Supplier_Contracts(request);
		}

		public Get_Supplier_Contracts_ResponseType Get_Supplier_Contracts(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Contracts_RequestType Get_Supplier_Contracts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Contracts(new Get_Supplier_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Contracts_Request = Get_Supplier_Contracts_Request
			}).Get_Supplier_Contracts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_ContractsOutput> Resource_ManagementPort.Get_Supplier_ContractsAsync(Get_Supplier_ContractsInput request)
		{
			return base.Channel.Get_Supplier_ContractsAsync(request);
		}

		public Task<Get_Supplier_ContractsOutput> Get_Supplier_ContractsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Contracts_RequestType Get_Supplier_Contracts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_ContractsAsync(new Get_Supplier_ContractsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Contracts_Request = Get_Supplier_Contracts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_AirlinesOutput Resource_ManagementPort.Get_Airlines(Get_AirlinesInput request)
		{
			return base.Channel.Get_Airlines(request);
		}

		public Get_Airlines_ResponseType Get_Airlines(Workday_Common_HeaderType Workday_Common_Header, Get_Airlines_RequestType Get_Airlines_Request)
		{
			return ((Resource_ManagementPort)this).Get_Airlines(new Get_AirlinesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Airlines_Request = Get_Airlines_Request
			}).Get_Airlines_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_AirlinesOutput> Resource_ManagementPort.Get_AirlinesAsync(Get_AirlinesInput request)
		{
			return base.Channel.Get_AirlinesAsync(request);
		}

		public Task<Get_AirlinesOutput> Get_AirlinesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Airlines_RequestType Get_Airlines_Request)
		{
			return ((Resource_ManagementPort)this).Get_AirlinesAsync(new Get_AirlinesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Airlines_Request = Get_Airlines_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_AirlineOutput Resource_ManagementPort.Put_Airline(Put_AirlineInput request)
		{
			return base.Channel.Put_Airline(request);
		}

		public Put_Airline_ResponseType Put_Airline(Workday_Common_HeaderType Workday_Common_Header, Put_Airline_RequestType Put_Airline_Request)
		{
			return ((Resource_ManagementPort)this).Put_Airline(new Put_AirlineInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Airline_Request = Put_Airline_Request
			}).Put_Airline_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_AirlineOutput> Resource_ManagementPort.Put_AirlineAsync(Put_AirlineInput request)
		{
			return base.Channel.Put_AirlineAsync(request);
		}

		public Task<Put_AirlineOutput> Put_AirlineAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Airline_RequestType Put_Airline_Request)
		{
			return ((Resource_ManagementPort)this).Put_AirlineAsync(new Put_AirlineInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Airline_Request = Put_Airline_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_HotelsOutput Resource_ManagementPort.Get_Hotels(Get_HotelsInput request)
		{
			return base.Channel.Get_Hotels(request);
		}

		public Get_Hotels_ResponseType Get_Hotels(Workday_Common_HeaderType Workday_Common_Header, Get_Hotels_RequestType Get_Hotels_Request)
		{
			return ((Resource_ManagementPort)this).Get_Hotels(new Get_HotelsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Hotels_Request = Get_Hotels_Request
			}).Get_Hotels_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_HotelsOutput> Resource_ManagementPort.Get_HotelsAsync(Get_HotelsInput request)
		{
			return base.Channel.Get_HotelsAsync(request);
		}

		public Task<Get_HotelsOutput> Get_HotelsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Hotels_RequestType Get_Hotels_Request)
		{
			return ((Resource_ManagementPort)this).Get_HotelsAsync(new Get_HotelsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Hotels_Request = Get_Hotels_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_HotelOutput Resource_ManagementPort.Put_Hotel(Put_HotelInput request)
		{
			return base.Channel.Put_Hotel(request);
		}

		public Put_Hotel_ResponseType Put_Hotel(Workday_Common_HeaderType Workday_Common_Header, Put_Hotel_RequestType Put_Hotel_Request)
		{
			return ((Resource_ManagementPort)this).Put_Hotel(new Put_HotelInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Hotel_Request = Put_Hotel_Request
			}).Put_Hotel_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_HotelOutput> Resource_ManagementPort.Put_HotelAsync(Put_HotelInput request)
		{
			return base.Channel.Put_HotelAsync(request);
		}

		public Task<Put_HotelOutput> Put_HotelAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Hotel_RequestType Put_Hotel_Request)
		{
			return ((Resource_ManagementPort)this).Put_HotelAsync(new Put_HotelInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Hotel_Request = Put_Hotel_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Car_Rental_AgenciesOutput Resource_ManagementPort.Get_Car_Rental_Agencies(Get_Car_Rental_AgenciesInput request)
		{
			return base.Channel.Get_Car_Rental_Agencies(request);
		}

		public Get_Car_Rental_Agencies_ResponseType Get_Car_Rental_Agencies(Workday_Common_HeaderType Workday_Common_Header, Get_Car_Rental_Agencies_RequestType Get_Car_Rental_Agencies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Car_Rental_Agencies(new Get_Car_Rental_AgenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Car_Rental_Agencies_Request = Get_Car_Rental_Agencies_Request
			}).Get_Car_Rental_Agencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Car_Rental_AgenciesOutput> Resource_ManagementPort.Get_Car_Rental_AgenciesAsync(Get_Car_Rental_AgenciesInput request)
		{
			return base.Channel.Get_Car_Rental_AgenciesAsync(request);
		}

		public Task<Get_Car_Rental_AgenciesOutput> Get_Car_Rental_AgenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Car_Rental_Agencies_RequestType Get_Car_Rental_Agencies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Car_Rental_AgenciesAsync(new Get_Car_Rental_AgenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Car_Rental_Agencies_Request = Get_Car_Rental_Agencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Car_Rental_AgencyOutput Resource_ManagementPort.Put_Car_Rental_Agency(Put_Car_Rental_AgencyInput request)
		{
			return base.Channel.Put_Car_Rental_Agency(request);
		}

		public Put_Car_Rental_Agency_ResponseType Put_Car_Rental_Agency(Workday_Common_HeaderType Workday_Common_Header, Put_Car_Rental_Agency_RequestType Put_Car_Rental_Agency_Request)
		{
			return ((Resource_ManagementPort)this).Put_Car_Rental_Agency(new Put_Car_Rental_AgencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Car_Rental_Agency_Request = Put_Car_Rental_Agency_Request
			}).Put_Car_Rental_Agency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Car_Rental_AgencyOutput> Resource_ManagementPort.Put_Car_Rental_AgencyAsync(Put_Car_Rental_AgencyInput request)
		{
			return base.Channel.Put_Car_Rental_AgencyAsync(request);
		}

		public Task<Put_Car_Rental_AgencyOutput> Put_Car_Rental_AgencyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Car_Rental_Agency_RequestType Put_Car_Rental_Agency_Request)
		{
			return ((Resource_ManagementPort)this).Put_Car_Rental_AgencyAsync(new Put_Car_Rental_AgencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Car_Rental_Agency_Request = Put_Car_Rental_Agency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Travel_CitiesOutput Resource_ManagementPort.Get_Travel_Cities(Get_Travel_CitiesInput request)
		{
			return base.Channel.Get_Travel_Cities(request);
		}

		public Get_Travel_Cities_ResponseType Get_Travel_Cities(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Cities_RequestType Get_Travel_Cities_Request)
		{
			return ((Resource_ManagementPort)this).Get_Travel_Cities(new Get_Travel_CitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Travel_Cities_Request = Get_Travel_Cities_Request
			}).Get_Travel_Cities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Travel_CitiesOutput> Resource_ManagementPort.Get_Travel_CitiesAsync(Get_Travel_CitiesInput request)
		{
			return base.Channel.Get_Travel_CitiesAsync(request);
		}

		public Task<Get_Travel_CitiesOutput> Get_Travel_CitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Cities_RequestType Get_Travel_Cities_Request)
		{
			return ((Resource_ManagementPort)this).Get_Travel_CitiesAsync(new Get_Travel_CitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Travel_Cities_Request = Get_Travel_Cities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Travel_CityOutput Resource_ManagementPort.Put_Travel_City(Put_Travel_CityInput request)
		{
			return base.Channel.Put_Travel_City(request);
		}

		public Put_Travel_City_ResponseType Put_Travel_City(Workday_Common_HeaderType Workday_Common_Header, Put_Travel_City_RequestType Put_Travel_City_Request)
		{
			return ((Resource_ManagementPort)this).Put_Travel_City(new Put_Travel_CityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Travel_City_Request = Put_Travel_City_Request
			}).Put_Travel_City_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Travel_CityOutput> Resource_ManagementPort.Put_Travel_CityAsync(Put_Travel_CityInput request)
		{
			return base.Channel.Put_Travel_CityAsync(request);
		}

		public Task<Put_Travel_CityOutput> Put_Travel_CityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Travel_City_RequestType Put_Travel_City_Request)
		{
			return ((Resource_ManagementPort)this).Put_Travel_CityAsync(new Put_Travel_CityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Travel_City_Request = Put_Travel_City_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_AirportsOutput Resource_ManagementPort.Get_Airports(Get_AirportsInput request)
		{
			return base.Channel.Get_Airports(request);
		}

		public Get_Airports_ResponseType Get_Airports(Workday_Common_HeaderType Workday_Common_Header, Get_Airports_RequestType Get_Airports_Request)
		{
			return ((Resource_ManagementPort)this).Get_Airports(new Get_AirportsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Airports_Request = Get_Airports_Request
			}).Get_Airports_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_AirportsOutput> Resource_ManagementPort.Get_AirportsAsync(Get_AirportsInput request)
		{
			return base.Channel.Get_AirportsAsync(request);
		}

		public Task<Get_AirportsOutput> Get_AirportsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Airports_RequestType Get_Airports_Request)
		{
			return ((Resource_ManagementPort)this).Get_AirportsAsync(new Get_AirportsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Airports_Request = Get_Airports_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_AirportOutput Resource_ManagementPort.Put_Airport(Put_AirportInput request)
		{
			return base.Channel.Put_Airport(request);
		}

		public Put_Airport_ResponseType Put_Airport(Workday_Common_HeaderType Workday_Common_Header, Put_Airport_RequestType Put_Airport_Request)
		{
			return ((Resource_ManagementPort)this).Put_Airport(new Put_AirportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Airport_Request = Put_Airport_Request
			}).Put_Airport_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_AirportOutput> Resource_ManagementPort.Put_AirportAsync(Put_AirportInput request)
		{
			return base.Channel.Put_AirportAsync(request);
		}

		public Task<Put_AirportOutput> Put_AirportAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Airport_RequestType Put_Airport_Request)
		{
			return ((Resource_ManagementPort)this).Put_AirportAsync(new Put_AirportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Airport_Request = Put_Airport_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Transfer_Asset_To_Different_CompanyOutput Resource_ManagementPort.Transfer_Asset_To_Different_Company(Transfer_Asset_To_Different_CompanyInput request)
		{
			return base.Channel.Transfer_Asset_To_Different_Company(request);
		}

		public Transfer_Asset_To_Different_Company_ResponseType Transfer_Asset_To_Different_Company(Workday_Common_HeaderType Workday_Common_Header, Transfer_Asset_To_Different_Company_RequestType Transfer_Asset_To_Different_Company_Request)
		{
			return ((Resource_ManagementPort)this).Transfer_Asset_To_Different_Company(new Transfer_Asset_To_Different_CompanyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Transfer_Asset_To_Different_Company_Request = Transfer_Asset_To_Different_Company_Request
			}).Transfer_Asset_To_Different_Company_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Transfer_Asset_To_Different_CompanyOutput> Resource_ManagementPort.Transfer_Asset_To_Different_CompanyAsync(Transfer_Asset_To_Different_CompanyInput request)
		{
			return base.Channel.Transfer_Asset_To_Different_CompanyAsync(request);
		}

		public Task<Transfer_Asset_To_Different_CompanyOutput> Transfer_Asset_To_Different_CompanyAsync(Workday_Common_HeaderType Workday_Common_Header, Transfer_Asset_To_Different_Company_RequestType Transfer_Asset_To_Different_Company_Request)
		{
			return ((Resource_ManagementPort)this).Transfer_Asset_To_Different_CompanyAsync(new Transfer_Asset_To_Different_CompanyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Transfer_Asset_To_Different_Company_Request = Transfer_Asset_To_Different_Company_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_AssetsOutput Resource_ManagementPort.Get_Assets(Get_AssetsInput request)
		{
			return base.Channel.Get_Assets(request);
		}

		public Get_Assets_ResponseType Get_Assets(Workday_Common_HeaderType Workday_Common_Header, Get_Assets_RequestType Get_Assets_Request)
		{
			return ((Resource_ManagementPort)this).Get_Assets(new Get_AssetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assets_Request = Get_Assets_Request
			}).Get_Assets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_AssetsOutput> Resource_ManagementPort.Get_AssetsAsync(Get_AssetsInput request)
		{
			return base.Channel.Get_AssetsAsync(request);
		}

		public Task<Get_AssetsOutput> Get_AssetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Assets_RequestType Get_Assets_Request)
		{
			return ((Resource_ManagementPort)this).Get_AssetsAsync(new Get_AssetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assets_Request = Get_Assets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Impair_AssetOutput Resource_ManagementPort.Impair_Asset(Impair_AssetInput request)
		{
			return base.Channel.Impair_Asset(request);
		}

		public Impair_Asset_ResponseType Impair_Asset(Workday_Common_HeaderType Workday_Common_Header, Impair_Asset_RequestType Impair_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Impair_Asset(new Impair_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Impair_Asset_Request = Impair_Asset_Request
			}).Impair_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Impair_AssetOutput> Resource_ManagementPort.Impair_AssetAsync(Impair_AssetInput request)
		{
			return base.Channel.Impair_AssetAsync(request);
		}

		public Task<Impair_AssetOutput> Impair_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Impair_Asset_RequestType Impair_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Impair_AssetAsync(new Impair_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Impair_Asset_Request = Impair_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Reinstate_AssetOutput Resource_ManagementPort.Reinstate_Asset(Reinstate_AssetInput request)
		{
			return base.Channel.Reinstate_Asset(request);
		}

		public Reinstate_Asset_ResponseType Reinstate_Asset(Workday_Common_HeaderType Workday_Common_Header, Reinstate_Asset_RequestType Reinstate_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Reinstate_Asset(new Reinstate_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reinstate_Asset_Request = Reinstate_Asset_Request
			}).Reinstate_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Reinstate_AssetOutput> Resource_ManagementPort.Reinstate_AssetAsync(Reinstate_AssetInput request)
		{
			return base.Channel.Reinstate_AssetAsync(request);
		}

		public Task<Reinstate_AssetOutput> Reinstate_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Reinstate_Asset_RequestType Reinstate_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Reinstate_AssetAsync(new Reinstate_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reinstate_Asset_Request = Reinstate_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Dispose_AssetOutput Resource_ManagementPort.Dispose_Asset(Dispose_AssetInput request)
		{
			return base.Channel.Dispose_Asset(request);
		}

		public Dispose_Asset_ResponseType Dispose_Asset(Workday_Common_HeaderType Workday_Common_Header, Dispose_Asset_RequestType Dispose_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Dispose_Asset(new Dispose_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Dispose_Asset_Request = Dispose_Asset_Request
			}).Dispose_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Dispose_AssetOutput> Resource_ManagementPort.Dispose_AssetAsync(Dispose_AssetInput request)
		{
			return base.Channel.Dispose_AssetAsync(request);
		}

		public Task<Dispose_AssetOutput> Dispose_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Dispose_Asset_RequestType Dispose_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Dispose_AssetAsync(new Dispose_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Dispose_Asset_Request = Dispose_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Asset_Book_ConfigurationsOutput Resource_ManagementPort.Get_Asset_Book_Configurations(Get_Asset_Book_ConfigurationsInput request)
		{
			return base.Channel.Get_Asset_Book_Configurations(request);
		}

		public Get_Asset_Book_Configurations_ResponseType Get_Asset_Book_Configurations(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Book_Configurations_RequestType Get_Asset_Book_Configurations_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Book_Configurations(new Get_Asset_Book_ConfigurationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Book_Configurations_Request = Get_Asset_Book_Configurations_Request
			}).Get_Asset_Book_Configurations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Asset_Book_ConfigurationsOutput> Resource_ManagementPort.Get_Asset_Book_ConfigurationsAsync(Get_Asset_Book_ConfigurationsInput request)
		{
			return base.Channel.Get_Asset_Book_ConfigurationsAsync(request);
		}

		public Task<Get_Asset_Book_ConfigurationsOutput> Get_Asset_Book_ConfigurationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Book_Configurations_RequestType Get_Asset_Book_Configurations_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Book_ConfigurationsAsync(new Get_Asset_Book_ConfigurationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Book_Configurations_Request = Get_Asset_Book_Configurations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Asset_Book_ConfigurationOutput Resource_ManagementPort.Update_Asset_Book_Configuration(Update_Asset_Book_ConfigurationInput request)
		{
			return base.Channel.Update_Asset_Book_Configuration(request);
		}

		public Update_Asset_Book_Configuration_ResponseType Update_Asset_Book_Configuration(Workday_Common_HeaderType Workday_Common_Header, Update_Asset_Book_Configuration_RequestType Update_Asset_Book_Configuration_Request)
		{
			return ((Resource_ManagementPort)this).Update_Asset_Book_Configuration(new Update_Asset_Book_ConfigurationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Asset_Book_Configuration_Request = Update_Asset_Book_Configuration_Request
			}).Update_Asset_Book_Configuration_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Asset_Book_ConfigurationOutput> Resource_ManagementPort.Update_Asset_Book_ConfigurationAsync(Update_Asset_Book_ConfigurationInput request)
		{
			return base.Channel.Update_Asset_Book_ConfigurationAsync(request);
		}

		public Task<Update_Asset_Book_ConfigurationOutput> Update_Asset_Book_ConfigurationAsync(Workday_Common_HeaderType Workday_Common_Header, Update_Asset_Book_Configuration_RequestType Update_Asset_Book_Configuration_Request)
		{
			return ((Resource_ManagementPort)this).Update_Asset_Book_ConfigurationAsync(new Update_Asset_Book_ConfigurationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Asset_Book_Configuration_Request = Update_Asset_Book_Configuration_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_Scenario_GroupsOutput Resource_ManagementPort.Get_Project_Scenario_Groups(Get_Project_Scenario_GroupsInput request)
		{
			return base.Channel.Get_Project_Scenario_Groups(request);
		}

		public Get_Project_Scenario_Groups_ResponseType Get_Project_Scenario_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Scenario_Groups_RequestType Get_Project_Scenario_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Scenario_Groups(new Get_Project_Scenario_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Scenario_Groups_Request = Get_Project_Scenario_Groups_Request
			}).Get_Project_Scenario_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_Scenario_GroupsOutput> Resource_ManagementPort.Get_Project_Scenario_GroupsAsync(Get_Project_Scenario_GroupsInput request)
		{
			return base.Channel.Get_Project_Scenario_GroupsAsync(request);
		}

		public Task<Get_Project_Scenario_GroupsOutput> Get_Project_Scenario_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Scenario_Groups_RequestType Get_Project_Scenario_Groups_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Scenario_GroupsAsync(new Get_Project_Scenario_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Scenario_Groups_Request = Get_Project_Scenario_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_Scenario_GroupOutput Resource_ManagementPort.Put_Project_Scenario_Group(Put_Project_Scenario_GroupInput request)
		{
			return base.Channel.Put_Project_Scenario_Group(request);
		}

		public Put_Project_Scenario_Group_ResponseType Put_Project_Scenario_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Scenario_Group_RequestType Put_Project_Scenario_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Scenario_Group(new Put_Project_Scenario_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Scenario_Group_Request = Put_Project_Scenario_Group_Request
			}).Put_Project_Scenario_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_Scenario_GroupOutput> Resource_ManagementPort.Put_Project_Scenario_GroupAsync(Put_Project_Scenario_GroupInput request)
		{
			return base.Channel.Put_Project_Scenario_GroupAsync(request);
		}

		public Task<Put_Project_Scenario_GroupOutput> Put_Project_Scenario_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Scenario_Group_RequestType Put_Project_Scenario_Group_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Scenario_GroupAsync(new Put_Project_Scenario_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Scenario_Group_Request = Put_Project_Scenario_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_ScenariosOutput Resource_ManagementPort.Get_Project_Scenarios(Get_Project_ScenariosInput request)
		{
			return base.Channel.Get_Project_Scenarios(request);
		}

		public Get_Project_Scenarios_ResponseType Get_Project_Scenarios(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Scenarios_RequestType Get_Project_Scenarios_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Scenarios(new Get_Project_ScenariosInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Scenarios_Request = Get_Project_Scenarios_Request
			}).Get_Project_Scenarios_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_ScenariosOutput> Resource_ManagementPort.Get_Project_ScenariosAsync(Get_Project_ScenariosInput request)
		{
			return base.Channel.Get_Project_ScenariosAsync(request);
		}

		public Task<Get_Project_ScenariosOutput> Get_Project_ScenariosAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Scenarios_RequestType Get_Project_Scenarios_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_ScenariosAsync(new Get_Project_ScenariosInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Scenarios_Request = Get_Project_Scenarios_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Project_ScenarioOutput Resource_ManagementPort.Submit_Project_Scenario(Submit_Project_ScenarioInput request)
		{
			return base.Channel.Submit_Project_Scenario(request);
		}

		public Submit_Project_Scenario_ResponseType Submit_Project_Scenario(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_Scenario_RequestType Submit_Project_Scenario_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Project_Scenario(new Submit_Project_ScenarioInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Project_Scenario_Request = Submit_Project_Scenario_Request
			}).Submit_Project_Scenario_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Project_ScenarioOutput> Resource_ManagementPort.Submit_Project_ScenarioAsync(Submit_Project_ScenarioInput request)
		{
			return base.Channel.Submit_Project_ScenarioAsync(request);
		}

		public Task<Submit_Project_ScenarioOutput> Submit_Project_ScenarioAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_Scenario_RequestType Submit_Project_Scenario_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Project_ScenarioAsync(new Submit_Project_ScenarioInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Project_Scenario_Request = Submit_Project_Scenario_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Remove_AssetOutput Resource_ManagementPort.Remove_Asset(Remove_AssetInput request)
		{
			return base.Channel.Remove_Asset(request);
		}

		public Remove_Asset_ResponseType Remove_Asset(Workday_Common_HeaderType Workday_Common_Header, Remove_Asset_RequestType Remove_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Remove_Asset(new Remove_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Remove_Asset_Request = Remove_Asset_Request
			}).Remove_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Remove_AssetOutput> Resource_ManagementPort.Remove_AssetAsync(Remove_AssetInput request)
		{
			return base.Channel.Remove_AssetAsync(request);
		}

		public Task<Remove_AssetOutput> Remove_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Remove_Asset_RequestType Remove_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Remove_AssetAsync(new Remove_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Remove_Asset_Request = Remove_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_ReceiptOutput Resource_ManagementPort.Cancel_Receipt(Cancel_ReceiptInput request)
		{
			return base.Channel.Cancel_Receipt(request);
		}

		public Cancel_Receipt_ResponseType Cancel_Receipt(Workday_Common_HeaderType Workday_Common_Header, Cancel_Receipt_RequestType Cancel_Receipt_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Receipt(new Cancel_ReceiptInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Receipt_Request = Cancel_Receipt_Request
			}).Cancel_Receipt_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_ReceiptOutput> Resource_ManagementPort.Cancel_ReceiptAsync(Cancel_ReceiptInput request)
		{
			return base.Channel.Cancel_ReceiptAsync(request);
		}

		public Task<Cancel_ReceiptOutput> Cancel_ReceiptAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Receipt_RequestType Cancel_Receipt_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_ReceiptAsync(new Cancel_ReceiptInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Receipt_Request = Cancel_Receipt_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Prepaid_Spend_AmortizationsOutput Resource_ManagementPort.Get_Prepaid_Spend_Amortizations(Get_Prepaid_Spend_AmortizationsInput request)
		{
			return base.Channel.Get_Prepaid_Spend_Amortizations(request);
		}

		public Get_Prepaid_Spend_Amortizations_ResponseType Get_Prepaid_Spend_Amortizations(Workday_Common_HeaderType Workday_Common_Header, Get_Prepaid_Spend_Amortizations_RequestType Get_Prepaid_Spend_Amortizations_Request)
		{
			return ((Resource_ManagementPort)this).Get_Prepaid_Spend_Amortizations(new Get_Prepaid_Spend_AmortizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prepaid_Spend_Amortizations_Request = Get_Prepaid_Spend_Amortizations_Request
			}).Get_Prepaid_Spend_Amortizations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Prepaid_Spend_AmortizationsOutput> Resource_ManagementPort.Get_Prepaid_Spend_AmortizationsAsync(Get_Prepaid_Spend_AmortizationsInput request)
		{
			return base.Channel.Get_Prepaid_Spend_AmortizationsAsync(request);
		}

		public Task<Get_Prepaid_Spend_AmortizationsOutput> Get_Prepaid_Spend_AmortizationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Prepaid_Spend_Amortizations_RequestType Get_Prepaid_Spend_Amortizations_Request)
		{
			return ((Resource_ManagementPort)this).Get_Prepaid_Spend_AmortizationsAsync(new Get_Prepaid_Spend_AmortizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prepaid_Spend_Amortizations_Request = Get_Prepaid_Spend_Amortizations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Prepaid_Spend_AmortizationOutput Resource_ManagementPort.Submit_Prepaid_Spend_Amortization(Submit_Prepaid_Spend_AmortizationInput request)
		{
			return base.Channel.Submit_Prepaid_Spend_Amortization(request);
		}

		public Submit_Prepaid_Spend_Amortization_ResponseType Submit_Prepaid_Spend_Amortization(Workday_Common_HeaderType Workday_Common_Header, Submit_Prepaid_Spend_Amortization_RequestType Submit_Prepaid_Spend_Amortization_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Prepaid_Spend_Amortization(new Submit_Prepaid_Spend_AmortizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Prepaid_Spend_Amortization_Request = Submit_Prepaid_Spend_Amortization_Request
			}).Submit_Prepaid_Spend_Amortization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Prepaid_Spend_AmortizationOutput> Resource_ManagementPort.Submit_Prepaid_Spend_AmortizationAsync(Submit_Prepaid_Spend_AmortizationInput request)
		{
			return base.Channel.Submit_Prepaid_Spend_AmortizationAsync(request);
		}

		public Task<Submit_Prepaid_Spend_AmortizationOutput> Submit_Prepaid_Spend_AmortizationAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Prepaid_Spend_Amortization_RequestType Submit_Prepaid_Spend_Amortization_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Prepaid_Spend_AmortizationAsync(new Submit_Prepaid_Spend_AmortizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Prepaid_Spend_Amortization_Request = Submit_Prepaid_Spend_Amortization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_Invoice_ScheduleOutput Resource_ManagementPort.Submit_Supplier_Invoice_Schedule(Submit_Supplier_Invoice_ScheduleInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_Schedule(request);
		}

		public Submit_Supplier_Invoice_Schedule_ResponseType Submit_Supplier_Invoice_Schedule(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Schedule_RequestType Submit_Supplier_Invoice_Schedule_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_Schedule(new Submit_Supplier_Invoice_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Schedule_Request = Submit_Supplier_Invoice_Schedule_Request
			}).Submit_Supplier_Invoice_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_Invoice_ScheduleOutput> Resource_ManagementPort.Submit_Supplier_Invoice_ScheduleAsync(Submit_Supplier_Invoice_ScheduleInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_ScheduleAsync(request);
		}

		public Task<Submit_Supplier_Invoice_ScheduleOutput> Submit_Supplier_Invoice_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Schedule_RequestType Submit_Supplier_Invoice_Schedule_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_ScheduleAsync(new Submit_Supplier_Invoice_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Schedule_Request = Submit_Supplier_Invoice_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Suspend_Asset_DepreciationOutput Resource_ManagementPort.Suspend_Asset_Depreciation(Suspend_Asset_DepreciationInput request)
		{
			return base.Channel.Suspend_Asset_Depreciation(request);
		}

		public Suspend_Asset_Depreciation_ResponseType Suspend_Asset_Depreciation(Workday_Common_HeaderType Workday_Common_Header, Suspend_Asset_Depreciation_RequestType Suspend_Asset_Depreciation_Request)
		{
			return ((Resource_ManagementPort)this).Suspend_Asset_Depreciation(new Suspend_Asset_DepreciationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Suspend_Asset_Depreciation_Request = Suspend_Asset_Depreciation_Request
			}).Suspend_Asset_Depreciation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Suspend_Asset_DepreciationOutput> Resource_ManagementPort.Suspend_Asset_DepreciationAsync(Suspend_Asset_DepreciationInput request)
		{
			return base.Channel.Suspend_Asset_DepreciationAsync(request);
		}

		public Task<Suspend_Asset_DepreciationOutput> Suspend_Asset_DepreciationAsync(Workday_Common_HeaderType Workday_Common_Header, Suspend_Asset_Depreciation_RequestType Suspend_Asset_Depreciation_Request)
		{
			return ((Resource_ManagementPort)this).Suspend_Asset_DepreciationAsync(new Suspend_Asset_DepreciationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Suspend_Asset_Depreciation_Request = Suspend_Asset_Depreciation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Remove_Supplier_Contract_Line_HoldOutput Resource_ManagementPort.Remove_Supplier_Contract_Line_Hold(Remove_Supplier_Contract_Line_HoldInput request)
		{
			return base.Channel.Remove_Supplier_Contract_Line_Hold(request);
		}

		public Remove_Supplier_Contract_Line_Hold_ResponseType Remove_Supplier_Contract_Line_Hold(Workday_Common_HeaderType Workday_Common_Header, Remove_Supplier_Contract_Line_Hold_RequestType Remove_Supplier_Contract_Line_Hold_Request)
		{
			return ((Resource_ManagementPort)this).Remove_Supplier_Contract_Line_Hold(new Remove_Supplier_Contract_Line_HoldInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Remove_Supplier_Contract_Line_Hold_Request = Remove_Supplier_Contract_Line_Hold_Request
			}).Remove_Supplier_Contract_Line_Hold_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Remove_Supplier_Contract_Line_HoldOutput> Resource_ManagementPort.Remove_Supplier_Contract_Line_HoldAsync(Remove_Supplier_Contract_Line_HoldInput request)
		{
			return base.Channel.Remove_Supplier_Contract_Line_HoldAsync(request);
		}

		public Task<Remove_Supplier_Contract_Line_HoldOutput> Remove_Supplier_Contract_Line_HoldAsync(Workday_Common_HeaderType Workday_Common_Header, Remove_Supplier_Contract_Line_Hold_RequestType Remove_Supplier_Contract_Line_Hold_Request)
		{
			return ((Resource_ManagementPort)this).Remove_Supplier_Contract_Line_HoldAsync(new Remove_Supplier_Contract_Line_HoldInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Remove_Supplier_Contract_Line_Hold_Request = Remove_Supplier_Contract_Line_Hold_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Supplier_Contract_Line_HoldOutput Resource_ManagementPort.Add_Supplier_Contract_Line_Hold(Add_Supplier_Contract_Line_HoldInput request)
		{
			return base.Channel.Add_Supplier_Contract_Line_Hold(request);
		}

		public Add_Supplier_Contract_Line_Hold_ResponseType Add_Supplier_Contract_Line_Hold(Workday_Common_HeaderType Workday_Common_Header, Add_Supplier_Contract_Line_Hold_RequestType Add_Supplier_Contract_Line_Hold_Request)
		{
			return ((Resource_ManagementPort)this).Add_Supplier_Contract_Line_Hold(new Add_Supplier_Contract_Line_HoldInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Supplier_Contract_Line_Hold_Request = Add_Supplier_Contract_Line_Hold_Request
			}).Add_Supplier_Contract_Line_Hold_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Supplier_Contract_Line_HoldOutput> Resource_ManagementPort.Add_Supplier_Contract_Line_HoldAsync(Add_Supplier_Contract_Line_HoldInput request)
		{
			return base.Channel.Add_Supplier_Contract_Line_HoldAsync(request);
		}

		public Task<Add_Supplier_Contract_Line_HoldOutput> Add_Supplier_Contract_Line_HoldAsync(Workday_Common_HeaderType Workday_Common_Header, Add_Supplier_Contract_Line_Hold_RequestType Add_Supplier_Contract_Line_Hold_Request)
		{
			return ((Resource_ManagementPort)this).Add_Supplier_Contract_Line_HoldAsync(new Add_Supplier_Contract_Line_HoldInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Supplier_Contract_Line_Hold_Request = Add_Supplier_Contract_Line_Hold_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Purchase_Order_ScheduleOutput Resource_ManagementPort.Submit_Purchase_Order_Schedule(Submit_Purchase_Order_ScheduleInput request)
		{
			return base.Channel.Submit_Purchase_Order_Schedule(request);
		}

		public Submit_Purchase_Order_Schedule_ResponseType Submit_Purchase_Order_Schedule(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Schedule_RequestType Submit_Purchase_Order_Schedule_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order_Schedule(new Submit_Purchase_Order_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Schedule_Request = Submit_Purchase_Order_Schedule_Request
			}).Submit_Purchase_Order_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Purchase_Order_ScheduleOutput> Resource_ManagementPort.Submit_Purchase_Order_ScheduleAsync(Submit_Purchase_Order_ScheduleInput request)
		{
			return base.Channel.Submit_Purchase_Order_ScheduleAsync(request);
		}

		public Task<Submit_Purchase_Order_ScheduleOutput> Submit_Purchase_Order_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Schedule_RequestType Submit_Purchase_Order_Schedule_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order_ScheduleAsync(new Submit_Purchase_Order_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Schedule_Request = Submit_Purchase_Order_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Prepaid_Spend_Amortization_ScheduleOutput Resource_ManagementPort.Submit_Prepaid_Spend_Amortization_Schedule(Submit_Prepaid_Spend_Amortization_ScheduleInput request)
		{
			return base.Channel.Submit_Prepaid_Spend_Amortization_Schedule(request);
		}

		public Submit_Prepaid_Spend_Amortization_Schedule_ResponseType Submit_Prepaid_Spend_Amortization_Schedule(Workday_Common_HeaderType Workday_Common_Header, Submit_Prepaid_Spend_Amortization_Schedule_RequestType Submit_Prepaid_Spend_Amortization_Schedule_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Prepaid_Spend_Amortization_Schedule(new Submit_Prepaid_Spend_Amortization_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Prepaid_Spend_Amortization_Schedule_Request = Submit_Prepaid_Spend_Amortization_Schedule_Request
			}).Submit_Prepaid_Spend_Amortization_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Prepaid_Spend_Amortization_ScheduleOutput> Resource_ManagementPort.Submit_Prepaid_Spend_Amortization_ScheduleAsync(Submit_Prepaid_Spend_Amortization_ScheduleInput request)
		{
			return base.Channel.Submit_Prepaid_Spend_Amortization_ScheduleAsync(request);
		}

		public Task<Submit_Prepaid_Spend_Amortization_ScheduleOutput> Submit_Prepaid_Spend_Amortization_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Prepaid_Spend_Amortization_Schedule_RequestType Submit_Prepaid_Spend_Amortization_Schedule_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Prepaid_Spend_Amortization_ScheduleAsync(new Submit_Prepaid_Spend_Amortization_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Prepaid_Spend_Amortization_Schedule_Request = Submit_Prepaid_Spend_Amortization_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Prepaid_Spend_Amortization_SchedulesOutput Resource_ManagementPort.Get_Prepaid_Spend_Amortization_Schedules(Get_Prepaid_Spend_Amortization_SchedulesInput request)
		{
			return base.Channel.Get_Prepaid_Spend_Amortization_Schedules(request);
		}

		public Get_Prepaid_Spend_Amortization_Schedules_ResponseType Get_Prepaid_Spend_Amortization_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Prepaid_Spend_Amortization_Schedules_RequestType Get_Prepaid_Spend_Amortization_Schedules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Prepaid_Spend_Amortization_Schedules(new Get_Prepaid_Spend_Amortization_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prepaid_Spend_Amortization_Schedules_Request = Get_Prepaid_Spend_Amortization_Schedules_Request
			}).Get_Prepaid_Spend_Amortization_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Prepaid_Spend_Amortization_SchedulesOutput> Resource_ManagementPort.Get_Prepaid_Spend_Amortization_SchedulesAsync(Get_Prepaid_Spend_Amortization_SchedulesInput request)
		{
			return base.Channel.Get_Prepaid_Spend_Amortization_SchedulesAsync(request);
		}

		public Task<Get_Prepaid_Spend_Amortization_SchedulesOutput> Get_Prepaid_Spend_Amortization_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Prepaid_Spend_Amortization_Schedules_RequestType Get_Prepaid_Spend_Amortization_Schedules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Prepaid_Spend_Amortization_SchedulesAsync(new Get_Prepaid_Spend_Amortization_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prepaid_Spend_Amortization_Schedules_Request = Get_Prepaid_Spend_Amortization_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_AssetOutput Resource_ManagementPort.Get_Project_Asset(Get_Project_AssetInput request)
		{
			return base.Channel.Get_Project_Asset(request);
		}

		public Get_Project_Asset_ResponseType Get_Project_Asset(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Asset_RequestType Get_Project_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Asset(new Get_Project_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Asset_Request = Get_Project_Asset_Request
			}).Get_Project_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_AssetOutput> Resource_ManagementPort.Get_Project_AssetAsync(Get_Project_AssetInput request)
		{
			return base.Channel.Get_Project_AssetAsync(request);
		}

		public Task<Get_Project_AssetOutput> Get_Project_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Asset_RequestType Get_Project_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_AssetAsync(new Get_Project_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Asset_Request = Get_Project_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_AssetOutput Resource_ManagementPort.Put_Project_Asset(Put_Project_AssetInput request)
		{
			return base.Channel.Put_Project_Asset(request);
		}

		public Put_Project_Asset_ResponseType Put_Project_Asset(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Asset_RequestType Put_Project_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Asset(new Put_Project_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Asset_Request = Put_Project_Asset_Request
			}).Put_Project_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_AssetOutput> Resource_ManagementPort.Put_Project_AssetAsync(Put_Project_AssetInput request)
		{
			return base.Channel.Put_Project_AssetAsync(request);
		}

		public Task<Put_Project_AssetOutput> Put_Project_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Asset_RequestType Put_Project_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_AssetAsync(new Put_Project_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Asset_Request = Put_Project_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Resume_Asset_DepreciationOutput Resource_ManagementPort.Resume_Asset_Depreciation(Resume_Asset_DepreciationInput request)
		{
			return base.Channel.Resume_Asset_Depreciation(request);
		}

		public Resume_Asset_Depreciation_ResponseType Resume_Asset_Depreciation(Workday_Common_HeaderType Workday_Common_Header, Resume_Asset_Depreciation_RequestType Resume_Asset_Depreciation_Request)
		{
			return ((Resource_ManagementPort)this).Resume_Asset_Depreciation(new Resume_Asset_DepreciationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Resume_Asset_Depreciation_Request = Resume_Asset_Depreciation_Request
			}).Resume_Asset_Depreciation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Resume_Asset_DepreciationOutput> Resource_ManagementPort.Resume_Asset_DepreciationAsync(Resume_Asset_DepreciationInput request)
		{
			return base.Channel.Resume_Asset_DepreciationAsync(request);
		}

		public Task<Resume_Asset_DepreciationOutput> Resume_Asset_DepreciationAsync(Workday_Common_HeaderType Workday_Common_Header, Resume_Asset_Depreciation_RequestType Resume_Asset_Depreciation_Request)
		{
			return ((Resource_ManagementPort)this).Resume_Asset_DepreciationAsync(new Resume_Asset_DepreciationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Resume_Asset_Depreciation_Request = Resume_Asset_Depreciation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Asset_Pooling_RulesOutput Resource_ManagementPort.Get_Asset_Pooling_Rules(Get_Asset_Pooling_RulesInput request)
		{
			return base.Channel.Get_Asset_Pooling_Rules(request);
		}

		public Get_Asset_Pooling_Rules_ResponseType Get_Asset_Pooling_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Pooling_Rules_RequestType Get_Asset_Pooling_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Pooling_Rules(new Get_Asset_Pooling_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Pooling_Rules_Request = Get_Asset_Pooling_Rules_Request
			}).Get_Asset_Pooling_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Asset_Pooling_RulesOutput> Resource_ManagementPort.Get_Asset_Pooling_RulesAsync(Get_Asset_Pooling_RulesInput request)
		{
			return base.Channel.Get_Asset_Pooling_RulesAsync(request);
		}

		public Task<Get_Asset_Pooling_RulesOutput> Get_Asset_Pooling_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Pooling_Rules_RequestType Get_Asset_Pooling_Rules_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Pooling_RulesAsync(new Get_Asset_Pooling_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Pooling_Rules_Request = Get_Asset_Pooling_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Asset_Pooling_RuleOutput Resource_ManagementPort.Put_Asset_Pooling_Rule(Put_Asset_Pooling_RuleInput request)
		{
			return base.Channel.Put_Asset_Pooling_Rule(request);
		}

		public Put_Asset_Pooling_Rule_ResponseType Put_Asset_Pooling_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Asset_Pooling_Rule_RequestType Put_Asset_Pooling_Rule_Request)
		{
			return ((Resource_ManagementPort)this).Put_Asset_Pooling_Rule(new Put_Asset_Pooling_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Asset_Pooling_Rule_Request = Put_Asset_Pooling_Rule_Request
			}).Put_Asset_Pooling_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Asset_Pooling_RuleOutput> Resource_ManagementPort.Put_Asset_Pooling_RuleAsync(Put_Asset_Pooling_RuleInput request)
		{
			return base.Channel.Put_Asset_Pooling_RuleAsync(request);
		}

		public Task<Put_Asset_Pooling_RuleOutput> Put_Asset_Pooling_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Asset_Pooling_Rule_RequestType Put_Asset_Pooling_Rule_Request)
		{
			return ((Resource_ManagementPort)this).Put_Asset_Pooling_RuleAsync(new Put_Asset_Pooling_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Asset_Pooling_Rule_Request = Put_Asset_Pooling_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_SupplierOutput Resource_ManagementPort.Submit_Supplier(Submit_SupplierInput request)
		{
			return base.Channel.Submit_Supplier(request);
		}

		public Submit_Supplier_ResponseType Submit_Supplier(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_RequestType Submit_Supplier_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier(new Submit_SupplierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Request = Submit_Supplier_Request
			}).Submit_Supplier_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_SupplierOutput> Resource_ManagementPort.Submit_SupplierAsync(Submit_SupplierInput request)
		{
			return base.Channel.Submit_SupplierAsync(request);
		}

		public Task<Submit_SupplierOutput> Submit_SupplierAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_RequestType Submit_Supplier_Request)
		{
			return ((Resource_ManagementPort)this).Submit_SupplierAsync(new Submit_SupplierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Request = Submit_Supplier_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_ReturnOutput Resource_ManagementPort.Submit_Return(Submit_ReturnInput request)
		{
			return base.Channel.Submit_Return(request);
		}

		public Submit_Return_ResponseType Submit_Return(Workday_Common_HeaderType Workday_Common_Header, Submit_Return_RequestType Submit_Return_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Return(new Submit_ReturnInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Return_Request = Submit_Return_Request
			}).Submit_Return_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_ReturnOutput> Resource_ManagementPort.Submit_ReturnAsync(Submit_ReturnInput request)
		{
			return base.Channel.Submit_ReturnAsync(request);
		}

		public Task<Submit_ReturnOutput> Submit_ReturnAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Return_RequestType Submit_Return_Request)
		{
			return ((Resource_ManagementPort)this).Submit_ReturnAsync(new Submit_ReturnInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Return_Request = Submit_Return_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ReturnsOutput Resource_ManagementPort.Get_Returns(Get_ReturnsInput request)
		{
			return base.Channel.Get_Returns(request);
		}

		public Get_Returns_ResponseType Get_Returns(Workday_Common_HeaderType Workday_Common_Header, Get_Returns_RequestType Get_Returns_Request)
		{
			return ((Resource_ManagementPort)this).Get_Returns(new Get_ReturnsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Returns_Request = Get_Returns_Request
			}).Get_Returns_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ReturnsOutput> Resource_ManagementPort.Get_ReturnsAsync(Get_ReturnsInput request)
		{
			return base.Channel.Get_ReturnsAsync(request);
		}

		public Task<Get_ReturnsOutput> Get_ReturnsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Returns_RequestType Get_Returns_Request)
		{
			return ((Resource_ManagementPort)this).Get_ReturnsAsync(new Get_ReturnsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Returns_Request = Get_Returns_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Place_Asset_in_ServiceOutput Resource_ManagementPort.Place_Asset_in_Service(Place_Asset_in_ServiceInput request)
		{
			return base.Channel.Place_Asset_in_Service(request);
		}

		public Place_Asset_in_Service_ResponseType Place_Asset_in_Service(Workday_Common_HeaderType Workday_Common_Header, Place_Asset_in_Service_RequestType Place_Asset_in_Service_Request)
		{
			return ((Resource_ManagementPort)this).Place_Asset_in_Service(new Place_Asset_in_ServiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Place_Asset_in_Service_Request = Place_Asset_in_Service_Request
			}).Place_Asset_in_Service_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Place_Asset_in_ServiceOutput> Resource_ManagementPort.Place_Asset_in_ServiceAsync(Place_Asset_in_ServiceInput request)
		{
			return base.Channel.Place_Asset_in_ServiceAsync(request);
		}

		public Task<Place_Asset_in_ServiceOutput> Place_Asset_in_ServiceAsync(Workday_Common_HeaderType Workday_Common_Header, Place_Asset_in_Service_RequestType Place_Asset_in_Service_Request)
		{
			return ((Resource_ManagementPort)this).Place_Asset_in_ServiceAsync(new Place_Asset_in_ServiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Place_Asset_in_Service_Request = Place_Asset_in_Service_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Workday_Project_HierarchyOutput Resource_ManagementPort.Submit_Workday_Project_Hierarchy(Submit_Workday_Project_HierarchyInput request)
		{
			return base.Channel.Submit_Workday_Project_Hierarchy(request);
		}

		public Submit_Workday_Project_Hierarchy_ResponseType Submit_Workday_Project_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Submit_Workday_Project_Hierarchy_RequestType Submit_Workday_Project_Hierarchy_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Workday_Project_Hierarchy(new Submit_Workday_Project_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Workday_Project_Hierarchy_Request = Submit_Workday_Project_Hierarchy_Request
			}).Submit_Workday_Project_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Workday_Project_HierarchyOutput> Resource_ManagementPort.Submit_Workday_Project_HierarchyAsync(Submit_Workday_Project_HierarchyInput request)
		{
			return base.Channel.Submit_Workday_Project_HierarchyAsync(request);
		}

		public Task<Submit_Workday_Project_HierarchyOutput> Submit_Workday_Project_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Workday_Project_Hierarchy_RequestType Submit_Workday_Project_Hierarchy_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Workday_Project_HierarchyAsync(new Submit_Workday_Project_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Workday_Project_Hierarchy_Request = Submit_Workday_Project_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Workday_Project_HierarchiesOutput Resource_ManagementPort.Get_Workday_Project_Hierarchies(Get_Workday_Project_HierarchiesInput request)
		{
			return base.Channel.Get_Workday_Project_Hierarchies(request);
		}

		public Get_Workday_Project_Hierarchies_ResponseType Get_Workday_Project_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Project_Hierarchies_RequestType Get_Workday_Project_Hierarchies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Workday_Project_Hierarchies(new Get_Workday_Project_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Project_Hierarchies_Request = Get_Workday_Project_Hierarchies_Request
			}).Get_Workday_Project_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Workday_Project_HierarchiesOutput> Resource_ManagementPort.Get_Workday_Project_HierarchiesAsync(Get_Workday_Project_HierarchiesInput request)
		{
			return base.Channel.Get_Workday_Project_HierarchiesAsync(request);
		}

		public Task<Get_Workday_Project_HierarchiesOutput> Get_Workday_Project_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Project_Hierarchies_RequestType Get_Workday_Project_Hierarchies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Workday_Project_HierarchiesAsync(new Get_Workday_Project_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Project_Hierarchies_Request = Get_Workday_Project_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Workday_Project_Hierarchies_without_DependenciesOutput Resource_ManagementPort.Get_Workday_Project_Hierarchies_without_Dependencies(Get_Workday_Project_Hierarchies_without_DependenciesInput request)
		{
			return base.Channel.Get_Workday_Project_Hierarchies_without_Dependencies(request);
		}

		public Get_Workday_Project_Hierarchies_without_Dependencies_ResponseType Get_Workday_Project_Hierarchies_without_Dependencies(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Project_Hierarchies_without_Dependencies_RequestType Get_Workday_Project_Hierarchies_without_Dependencies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Workday_Project_Hierarchies_without_Dependencies(new Get_Workday_Project_Hierarchies_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Project_Hierarchies_without_Dependencies_Request = Get_Workday_Project_Hierarchies_without_Dependencies_Request
			}).Get_Workday_Project_Hierarchies_without_Dependencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Workday_Project_Hierarchies_without_DependenciesOutput> Resource_ManagementPort.Get_Workday_Project_Hierarchies_without_DependenciesAsync(Get_Workday_Project_Hierarchies_without_DependenciesInput request)
		{
			return base.Channel.Get_Workday_Project_Hierarchies_without_DependenciesAsync(request);
		}

		public Task<Get_Workday_Project_Hierarchies_without_DependenciesOutput> Get_Workday_Project_Hierarchies_without_DependenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Project_Hierarchies_without_Dependencies_RequestType Get_Workday_Project_Hierarchies_without_Dependencies_Request)
		{
			return ((Resource_ManagementPort)this).Get_Workday_Project_Hierarchies_without_DependenciesAsync(new Get_Workday_Project_Hierarchies_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Project_Hierarchies_without_Dependencies_Request = Get_Workday_Project_Hierarchies_without_Dependencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Procurement_Card_Transaction_VerificationsOutput Resource_ManagementPort.Get_Procurement_Card_Transaction_Verifications(Get_Procurement_Card_Transaction_VerificationsInput request)
		{
			return base.Channel.Get_Procurement_Card_Transaction_Verifications(request);
		}

		public Get_Procurement_Card_Transaction_Verifications_ResponseType Get_Procurement_Card_Transaction_Verifications(Workday_Common_HeaderType Workday_Common_Header, Get_Procurement_Card_Transaction_Verifications_RequestType Get_Procurement_Card_Transaction_Verifications_Request)
		{
			return ((Resource_ManagementPort)this).Get_Procurement_Card_Transaction_Verifications(new Get_Procurement_Card_Transaction_VerificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Procurement_Card_Transaction_Verifications_Request = Get_Procurement_Card_Transaction_Verifications_Request
			}).Get_Procurement_Card_Transaction_Verifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Procurement_Card_Transaction_VerificationsOutput> Resource_ManagementPort.Get_Procurement_Card_Transaction_VerificationsAsync(Get_Procurement_Card_Transaction_VerificationsInput request)
		{
			return base.Channel.Get_Procurement_Card_Transaction_VerificationsAsync(request);
		}

		public Task<Get_Procurement_Card_Transaction_VerificationsOutput> Get_Procurement_Card_Transaction_VerificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Procurement_Card_Transaction_Verifications_RequestType Get_Procurement_Card_Transaction_Verifications_Request)
		{
			return ((Resource_ManagementPort)this).Get_Procurement_Card_Transaction_VerificationsAsync(new Get_Procurement_Card_Transaction_VerificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Procurement_Card_Transaction_Verifications_Request = Get_Procurement_Card_Transaction_Verifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Procurement_Card_Transaction_VerificationOutput Resource_ManagementPort.Submit_Procurement_Card_Transaction_Verification(Submit_Procurement_Card_Transaction_VerificationInput request)
		{
			return base.Channel.Submit_Procurement_Card_Transaction_Verification(request);
		}

		public Submit_Procurement_Card_Transaction_Verification_ResponseType Submit_Procurement_Card_Transaction_Verification(Workday_Common_HeaderType Workday_Common_Header, Submit_Procurement_Card_Transaction_Verification_RequestType Submit_Procurement_Card_Transaction_Verification_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Procurement_Card_Transaction_Verification(new Submit_Procurement_Card_Transaction_VerificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Procurement_Card_Transaction_Verification_Request = Submit_Procurement_Card_Transaction_Verification_Request
			}).Submit_Procurement_Card_Transaction_Verification_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Procurement_Card_Transaction_VerificationOutput> Resource_ManagementPort.Submit_Procurement_Card_Transaction_VerificationAsync(Submit_Procurement_Card_Transaction_VerificationInput request)
		{
			return base.Channel.Submit_Procurement_Card_Transaction_VerificationAsync(request);
		}

		public Task<Submit_Procurement_Card_Transaction_VerificationOutput> Submit_Procurement_Card_Transaction_VerificationAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Procurement_Card_Transaction_Verification_RequestType Submit_Procurement_Card_Transaction_Verification_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Procurement_Card_Transaction_VerificationAsync(new Submit_Procurement_Card_Transaction_VerificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Procurement_Card_Transaction_Verification_Request = Submit_Procurement_Card_Transaction_Verification_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Procurement_Mass_CloseOutput Resource_ManagementPort.Get_Procurement_Mass_Close(Get_Procurement_Mass_CloseInput request)
		{
			return base.Channel.Get_Procurement_Mass_Close(request);
		}

		public Get_Procurement_Mass_Close_ResponseType Get_Procurement_Mass_Close(Workday_Common_HeaderType Workday_Common_Header, Get_Procurement_Mass_Close_RequestType Get_Procurement_Mass_Close_Request)
		{
			return ((Resource_ManagementPort)this).Get_Procurement_Mass_Close(new Get_Procurement_Mass_CloseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Procurement_Mass_Close_Request = Get_Procurement_Mass_Close_Request
			}).Get_Procurement_Mass_Close_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Procurement_Mass_CloseOutput> Resource_ManagementPort.Get_Procurement_Mass_CloseAsync(Get_Procurement_Mass_CloseInput request)
		{
			return base.Channel.Get_Procurement_Mass_CloseAsync(request);
		}

		public Task<Get_Procurement_Mass_CloseOutput> Get_Procurement_Mass_CloseAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Procurement_Mass_Close_RequestType Get_Procurement_Mass_Close_Request)
		{
			return ((Resource_ManagementPort)this).Get_Procurement_Mass_CloseAsync(new Get_Procurement_Mass_CloseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Procurement_Mass_Close_Request = Get_Procurement_Mass_Close_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Procurement_Mass_CloseOutput Resource_ManagementPort.Submit_Procurement_Mass_Close(Submit_Procurement_Mass_CloseInput request)
		{
			return base.Channel.Submit_Procurement_Mass_Close(request);
		}

		public Submit_Procurement_Mass_Close_ResponseType Submit_Procurement_Mass_Close(Workday_Common_HeaderType Workday_Common_Header, Submit_Procurement_Mass_Close_RequestType Submit_Procurement_Mass_Close_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Procurement_Mass_Close(new Submit_Procurement_Mass_CloseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Procurement_Mass_Close_Request = Submit_Procurement_Mass_Close_Request
			}).Submit_Procurement_Mass_Close_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Procurement_Mass_CloseOutput> Resource_ManagementPort.Submit_Procurement_Mass_CloseAsync(Submit_Procurement_Mass_CloseInput request)
		{
			return base.Channel.Submit_Procurement_Mass_CloseAsync(request);
		}

		public Task<Submit_Procurement_Mass_CloseOutput> Submit_Procurement_Mass_CloseAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Procurement_Mass_Close_RequestType Submit_Procurement_Mass_Close_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Procurement_Mass_CloseAsync(new Submit_Procurement_Mass_CloseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Procurement_Mass_Close_Request = Submit_Procurement_Mass_Close_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Travel_Booking_FilesOutput Resource_ManagementPort.Get_Travel_Booking_Files(Get_Travel_Booking_FilesInput request)
		{
			return base.Channel.Get_Travel_Booking_Files(request);
		}

		public Get_Travel_Booking_Files_ResponseType Get_Travel_Booking_Files(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Booking_Files_RequestType Get_Travel_Booking_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Travel_Booking_Files(new Get_Travel_Booking_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Travel_Booking_Files_Request = Get_Travel_Booking_Files_Request
			}).Get_Travel_Booking_Files_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Travel_Booking_FilesOutput> Resource_ManagementPort.Get_Travel_Booking_FilesAsync(Get_Travel_Booking_FilesInput request)
		{
			return base.Channel.Get_Travel_Booking_FilesAsync(request);
		}

		public Task<Get_Travel_Booking_FilesOutput> Get_Travel_Booking_FilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Travel_Booking_Files_RequestType Get_Travel_Booking_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Travel_Booking_FilesAsync(new Get_Travel_Booking_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Travel_Booking_Files_Request = Get_Travel_Booking_Files_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_Task_ResourcesOutput Resource_ManagementPort.Put_Project_Task_Resources(Put_Project_Task_ResourcesInput request)
		{
			return base.Channel.Put_Project_Task_Resources(request);
		}

		public Put_Project_Task_Resources_ResponseType Put_Project_Task_Resources(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Task_Resources_RequestType Put_Project_Task_Resources_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Task_Resources(new Put_Project_Task_ResourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Task_Resources_Request = Put_Project_Task_Resources_Request
			}).Put_Project_Task_Resources_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_Task_ResourcesOutput> Resource_ManagementPort.Put_Project_Task_ResourcesAsync(Put_Project_Task_ResourcesInput request)
		{
			return base.Channel.Put_Project_Task_ResourcesAsync(request);
		}

		public Task<Put_Project_Task_ResourcesOutput> Put_Project_Task_ResourcesAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Task_Resources_RequestType Put_Project_Task_Resources_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Task_ResourcesAsync(new Put_Project_Task_ResourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Task_Resources_Request = Put_Project_Task_Resources_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_Task_ResourcesOutput Resource_ManagementPort.Get_Project_Task_Resources(Get_Project_Task_ResourcesInput request)
		{
			return base.Channel.Get_Project_Task_Resources(request);
		}

		public Get_Project_Task_Resources_ResponseType Get_Project_Task_Resources(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Task_Resources_RequestType Get_Project_Task_Resources_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Task_Resources(new Get_Project_Task_ResourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Task_Resources_Request = Get_Project_Task_Resources_Request
			}).Get_Project_Task_Resources_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_Task_ResourcesOutput> Resource_ManagementPort.Get_Project_Task_ResourcesAsync(Get_Project_Task_ResourcesInput request)
		{
			return base.Channel.Get_Project_Task_ResourcesAsync(request);
		}

		public Task<Get_Project_Task_ResourcesOutput> Get_Project_Task_ResourcesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Task_Resources_RequestType Get_Project_Task_Resources_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Task_ResourcesAsync(new Get_Project_Task_ResourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Task_Resources_Request = Get_Project_Task_Resources_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_ProjectOutput Resource_ManagementPort.Submit_Project(Submit_ProjectInput request)
		{
			return base.Channel.Submit_Project(request);
		}

		public Submit_Project_ResponseType Submit_Project(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_RequestType Submit_Project_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Project(new Submit_ProjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Project_Request = Submit_Project_Request
			}).Submit_Project_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_ProjectOutput> Resource_ManagementPort.Submit_ProjectAsync(Submit_ProjectInput request)
		{
			return base.Channel.Submit_ProjectAsync(request);
		}

		public Task<Submit_ProjectOutput> Submit_ProjectAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Project_RequestType Submit_Project_Request)
		{
			return ((Resource_ManagementPort)this).Submit_ProjectAsync(new Submit_ProjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Project_Request = Submit_Project_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ProjectsOutput Resource_ManagementPort.Get_Projects(Get_ProjectsInput request)
		{
			return base.Channel.Get_Projects(request);
		}

		public Get_Projects_ResponseType Get_Projects(Workday_Common_HeaderType Workday_Common_Header, Get_Projects_RequestType Get_Projects_Request)
		{
			return ((Resource_ManagementPort)this).Get_Projects(new Get_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Projects_Request = Get_Projects_Request
			}).Get_Projects_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ProjectsOutput> Resource_ManagementPort.Get_ProjectsAsync(Get_ProjectsInput request)
		{
			return base.Channel.Get_ProjectsAsync(request);
		}

		public Task<Get_ProjectsOutput> Get_ProjectsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Projects_RequestType Get_Projects_Request)
		{
			return ((Resource_ManagementPort)this).Get_ProjectsAsync(new Get_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Projects_Request = Get_Projects_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_PlansOutput Resource_ManagementPort.Get_Project_Plans(Get_Project_PlansInput request)
		{
			return base.Channel.Get_Project_Plans(request);
		}

		public Get_Project_Plans_ResponseType Get_Project_Plans(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Plans_RequestType Get_Project_Plans_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Plans(new Get_Project_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Plans_Request = Get_Project_Plans_Request
			}).Get_Project_Plans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_PlansOutput> Resource_ManagementPort.Get_Project_PlansAsync(Get_Project_PlansInput request)
		{
			return base.Channel.Get_Project_PlansAsync(request);
		}

		public Task<Get_Project_PlansOutput> Get_Project_PlansAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Plans_RequestType Get_Project_Plans_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_PlansAsync(new Get_Project_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Plans_Request = Get_Project_Plans_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_PlanOutput Resource_ManagementPort.Put_Project_Plan(Put_Project_PlanInput request)
		{
			return base.Channel.Put_Project_Plan(request);
		}

		public Put_Project_Plan_ResponseType Put_Project_Plan(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Plan_RequestType Put_Project_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Plan(new Put_Project_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Plan_Request = Put_Project_Plan_Request
			}).Put_Project_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_PlanOutput> Resource_ManagementPort.Put_Project_PlanAsync(Put_Project_PlanInput request)
		{
			return base.Channel.Put_Project_PlanAsync(request);
		}

		public Task<Put_Project_PlanOutput> Put_Project_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Plan_RequestType Put_Project_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_PlanAsync(new Put_Project_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Plan_Request = Put_Project_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Resource_PlanOutput Resource_ManagementPort.Submit_Resource_Plan(Submit_Resource_PlanInput request)
		{
			return base.Channel.Submit_Resource_Plan(request);
		}

		public Submit_Resource_Plan_ResponseType Submit_Resource_Plan(Workday_Common_HeaderType Workday_Common_Header, Submit_Resource_Plan_RequestType Submit_Resource_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Resource_Plan(new Submit_Resource_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Resource_Plan_Request = Submit_Resource_Plan_Request
			}).Submit_Resource_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Resource_PlanOutput> Resource_ManagementPort.Submit_Resource_PlanAsync(Submit_Resource_PlanInput request)
		{
			return base.Channel.Submit_Resource_PlanAsync(request);
		}

		public Task<Submit_Resource_PlanOutput> Submit_Resource_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Resource_Plan_RequestType Submit_Resource_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Resource_PlanAsync(new Submit_Resource_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Resource_Plan_Request = Submit_Resource_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Resource_PlansOutput Resource_ManagementPort.Get_Resource_Plans(Get_Resource_PlansInput request)
		{
			return base.Channel.Get_Resource_Plans(request);
		}

		public Get_Resource_Plans_ResponseType Get_Resource_Plans(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Plans_RequestType Get_Resource_Plans_Request)
		{
			return ((Resource_ManagementPort)this).Get_Resource_Plans(new Get_Resource_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Plans_Request = Get_Resource_Plans_Request
			}).Get_Resource_Plans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Resource_PlansOutput> Resource_ManagementPort.Get_Resource_PlansAsync(Get_Resource_PlansInput request)
		{
			return base.Channel.Get_Resource_PlansAsync(request);
		}

		public Task<Get_Resource_PlansOutput> Get_Resource_PlansAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Plans_RequestType Get_Resource_Plans_Request)
		{
			return ((Resource_ManagementPort)this).Get_Resource_PlansAsync(new Get_Resource_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Plans_Request = Get_Resource_Plans_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Request_for_QuoteOutput Resource_ManagementPort.Get_Request_for_Quote(Get_Request_for_QuoteInput request)
		{
			return base.Channel.Get_Request_for_Quote(request);
		}

		public Get_Request_for_Quote_ResponseType Get_Request_for_Quote(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_RequestType Get_Request_for_Quote_Request)
		{
			return ((Resource_ManagementPort)this).Get_Request_for_Quote(new Get_Request_for_QuoteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Request_for_Quote_Request = Get_Request_for_Quote_Request
			}).Get_Request_for_Quote_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Request_for_QuoteOutput> Resource_ManagementPort.Get_Request_for_QuoteAsync(Get_Request_for_QuoteInput request)
		{
			return base.Channel.Get_Request_for_QuoteAsync(request);
		}

		public Task<Get_Request_for_QuoteOutput> Get_Request_for_QuoteAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_RequestType Get_Request_for_Quote_Request)
		{
			return ((Resource_ManagementPort)this).Get_Request_for_QuoteAsync(new Get_Request_for_QuoteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Request_for_Quote_Request = Get_Request_for_Quote_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Request_for_QuoteOutput Resource_ManagementPort.Submit_Request_for_Quote(Submit_Request_for_QuoteInput request)
		{
			return base.Channel.Submit_Request_for_Quote(request);
		}

		public Submit_Request_for_Quote_ResponseType Submit_Request_for_Quote(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_RequestType Submit_Request_for_Quote_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Request_for_Quote(new Submit_Request_for_QuoteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Request_for_Quote_Request = Submit_Request_for_Quote_Request
			}).Submit_Request_for_Quote_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Request_for_QuoteOutput> Resource_ManagementPort.Submit_Request_for_QuoteAsync(Submit_Request_for_QuoteInput request)
		{
			return base.Channel.Submit_Request_for_QuoteAsync(request);
		}

		public Task<Submit_Request_for_QuoteOutput> Submit_Request_for_QuoteAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_RequestType Submit_Request_for_Quote_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Request_for_QuoteAsync(new Submit_Request_for_QuoteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Request_for_Quote_Request = Submit_Request_for_Quote_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Reclassify_AssetOutput Resource_ManagementPort.Reclassify_Asset(Reclassify_AssetInput request)
		{
			return base.Channel.Reclassify_Asset(request);
		}

		public Reclassify_Asset_ResponseType Reclassify_Asset(Workday_Common_HeaderType Workday_Common_Header, Reclassify_Asset_RequestType Reclassify_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Reclassify_Asset(new Reclassify_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reclassify_Asset_Request = Reclassify_Asset_Request
			}).Reclassify_Asset_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Reclassify_AssetOutput> Resource_ManagementPort.Reclassify_AssetAsync(Reclassify_AssetInput request)
		{
			return base.Channel.Reclassify_AssetAsync(request);
		}

		public Task<Reclassify_AssetOutput> Reclassify_AssetAsync(Workday_Common_HeaderType Workday_Common_Header, Reclassify_Asset_RequestType Reclassify_Asset_Request)
		{
			return ((Resource_ManagementPort)this).Reclassify_AssetAsync(new Reclassify_AssetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reclassify_Asset_Request = Reclassify_Asset_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Request_for_Quote_ResponsesOutput Resource_ManagementPort.Get_Request_for_Quote_Responses(Get_Request_for_Quote_ResponsesInput request)
		{
			return base.Channel.Get_Request_for_Quote_Responses(request);
		}

		public Get_Request_for_Quote_Responses_ResponseType Get_Request_for_Quote_Responses(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_Responses_RequestType Get_Request_for_Quote_Responses_Request)
		{
			return ((Resource_ManagementPort)this).Get_Request_for_Quote_Responses(new Get_Request_for_Quote_ResponsesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Request_for_Quote_Responses_Request = Get_Request_for_Quote_Responses_Request
			}).Get_Request_for_Quote_Responses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Request_for_Quote_ResponsesOutput> Resource_ManagementPort.Get_Request_for_Quote_ResponsesAsync(Get_Request_for_Quote_ResponsesInput request)
		{
			return base.Channel.Get_Request_for_Quote_ResponsesAsync(request);
		}

		public Task<Get_Request_for_Quote_ResponsesOutput> Get_Request_for_Quote_ResponsesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_Responses_RequestType Get_Request_for_Quote_Responses_Request)
		{
			return ((Resource_ManagementPort)this).Get_Request_for_Quote_ResponsesAsync(new Get_Request_for_Quote_ResponsesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Request_for_Quote_Responses_Request = Get_Request_for_Quote_Responses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Request_for_Quote_ResponseOutput Resource_ManagementPort.Submit_Request_for_Quote_Response(Submit_Request_for_Quote_ResponseInput request)
		{
			return base.Channel.Submit_Request_for_Quote_Response(request);
		}

		public Submit_Request_for_Quote_Response_ResponseType Submit_Request_for_Quote_Response(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_Response_RequestType Submit_Request_for_Quote_Response_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Request_for_Quote_Response(new Submit_Request_for_Quote_ResponseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Request_for_Quote_Response_Request = Submit_Request_for_Quote_Response_Request
			}).Submit_Request_for_Quote_Response_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Request_for_Quote_ResponseOutput> Resource_ManagementPort.Submit_Request_for_Quote_ResponseAsync(Submit_Request_for_Quote_ResponseInput request)
		{
			return base.Channel.Submit_Request_for_Quote_ResponseAsync(request);
		}

		public Task<Submit_Request_for_Quote_ResponseOutput> Submit_Request_for_Quote_ResponseAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_Response_RequestType Submit_Request_for_Quote_Response_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Request_for_Quote_ResponseAsync(new Submit_Request_for_Quote_ResponseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Request_for_Quote_Response_Request = Submit_Request_for_Quote_Response_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_ConnectionsOutput Resource_ManagementPort.Get_Supplier_Connections(Get_Supplier_ConnectionsInput request)
		{
			return base.Channel.Get_Supplier_Connections(request);
		}

		public Get_Supplier_Connections_ResponseType Get_Supplier_Connections(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Connections_RequestType Get_Supplier_Connections_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Connections(new Get_Supplier_ConnectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Connections_Request = Get_Supplier_Connections_Request
			}).Get_Supplier_Connections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_ConnectionsOutput> Resource_ManagementPort.Get_Supplier_ConnectionsAsync(Get_Supplier_ConnectionsInput request)
		{
			return base.Channel.Get_Supplier_ConnectionsAsync(request);
		}

		public Task<Get_Supplier_ConnectionsOutput> Get_Supplier_ConnectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Connections_RequestType Get_Supplier_Connections_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_ConnectionsAsync(new Get_Supplier_ConnectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Connections_Request = Get_Supplier_Connections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_ConnectionOutput Resource_ManagementPort.Submit_Supplier_Connection(Submit_Supplier_ConnectionInput request)
		{
			return base.Channel.Submit_Supplier_Connection(request);
		}

		public Submit_Supplier_Connection_ResponseType Submit_Supplier_Connection(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Connection_RequestType Submit_Supplier_Connection_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Connection(new Submit_Supplier_ConnectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Connection_Request = Submit_Supplier_Connection_Request
			}).Submit_Supplier_Connection_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_ConnectionOutput> Resource_ManagementPort.Submit_Supplier_ConnectionAsync(Submit_Supplier_ConnectionInput request)
		{
			return base.Channel.Submit_Supplier_ConnectionAsync(request);
		}

		public Task<Submit_Supplier_ConnectionOutput> Submit_Supplier_ConnectionAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Connection_RequestType Submit_Supplier_Connection_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_ConnectionAsync(new Submit_Supplier_ConnectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Connection_Request = Submit_Supplier_Connection_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Requirements_for_Resource_PlanOutput Resource_ManagementPort.Put_Requirements_for_Resource_Plan(Put_Requirements_for_Resource_PlanInput request)
		{
			return base.Channel.Put_Requirements_for_Resource_Plan(request);
		}

		public Put_Requirements_for_Resource_Plan_Line_ResponseType Put_Requirements_for_Resource_Plan(Workday_Common_HeaderType Workday_Common_Header, Put_Requirements_for_Resource_Plan_RequestType Put_Requirements_for_Resource_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Put_Requirements_for_Resource_Plan(new Put_Requirements_for_Resource_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Requirements_for_Resource_Plan_Request = Put_Requirements_for_Resource_Plan_Request
			}).Put_Requirements_for_Resource_Plan_Line_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Requirements_for_Resource_PlanOutput> Resource_ManagementPort.Put_Requirements_for_Resource_PlanAsync(Put_Requirements_for_Resource_PlanInput request)
		{
			return base.Channel.Put_Requirements_for_Resource_PlanAsync(request);
		}

		public Task<Put_Requirements_for_Resource_PlanOutput> Put_Requirements_for_Resource_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Requirements_for_Resource_Plan_RequestType Put_Requirements_for_Resource_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Put_Requirements_for_Resource_PlanAsync(new Put_Requirements_for_Resource_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Requirements_for_Resource_Plan_Request = Put_Requirements_for_Resource_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Requirements_for_Resource_PlanOutput Resource_ManagementPort.Get_Requirements_for_Resource_Plan(Get_Requirements_for_Resource_PlanInput request)
		{
			return base.Channel.Get_Requirements_for_Resource_Plan(request);
		}

		public Get_Requirements_for_Resource_Plan_ResponseType Get_Requirements_for_Resource_Plan(Workday_Common_HeaderType Workday_Common_Header, Get_Requirements_for_Resource_Plan_RequestType Get_Requirements_for_Resource_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Get_Requirements_for_Resource_Plan(new Get_Requirements_for_Resource_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Requirements_for_Resource_Plan_Request = Get_Requirements_for_Resource_Plan_Request
			}).Get_Requirements_for_Resource_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Requirements_for_Resource_PlanOutput> Resource_ManagementPort.Get_Requirements_for_Resource_PlanAsync(Get_Requirements_for_Resource_PlanInput request)
		{
			return base.Channel.Get_Requirements_for_Resource_PlanAsync(request);
		}

		public Task<Get_Requirements_for_Resource_PlanOutput> Get_Requirements_for_Resource_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Requirements_for_Resource_Plan_RequestType Get_Requirements_for_Resource_Plan_Request)
		{
			return ((Resource_ManagementPort)this).Get_Requirements_for_Resource_PlanAsync(new Get_Requirements_for_Resource_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Requirements_for_Resource_Plan_Request = Get_Requirements_for_Resource_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Request_for_Quote_AwardsOutput Resource_ManagementPort.Get_Request_for_Quote_Awards(Get_Request_for_Quote_AwardsInput request)
		{
			return base.Channel.Get_Request_for_Quote_Awards(request);
		}

		public Get_Request_for_Quote_Awards_ResponseType Get_Request_for_Quote_Awards(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_Awards_RequestType Get_Request_for_Quote_Awards_Request)
		{
			return ((Resource_ManagementPort)this).Get_Request_for_Quote_Awards(new Get_Request_for_Quote_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Request_for_Quote_Awards_Request = Get_Request_for_Quote_Awards_Request
			}).Get_Request_for_Quote_Awards_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Request_for_Quote_AwardsOutput> Resource_ManagementPort.Get_Request_for_Quote_AwardsAsync(Get_Request_for_Quote_AwardsInput request)
		{
			return base.Channel.Get_Request_for_Quote_AwardsAsync(request);
		}

		public Task<Get_Request_for_Quote_AwardsOutput> Get_Request_for_Quote_AwardsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_Awards_RequestType Get_Request_for_Quote_Awards_Request)
		{
			return ((Resource_ManagementPort)this).Get_Request_for_Quote_AwardsAsync(new Get_Request_for_Quote_AwardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Request_for_Quote_Awards_Request = Get_Request_for_Quote_Awards_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Request_for_Quote_AwardOutput Resource_ManagementPort.Submit_Request_for_Quote_Award(Submit_Request_for_Quote_AwardInput request)
		{
			return base.Channel.Submit_Request_for_Quote_Award(request);
		}

		public Submit_Request_for_Quote_Award_ResponseType Submit_Request_for_Quote_Award(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_Award_RequestType Submit_Request_for_Quote_Award_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Request_for_Quote_Award(new Submit_Request_for_Quote_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Request_for_Quote_Award_Request = Submit_Request_for_Quote_Award_Request
			}).Submit_Request_for_Quote_Award_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Request_for_Quote_AwardOutput> Resource_ManagementPort.Submit_Request_for_Quote_AwardAsync(Submit_Request_for_Quote_AwardInput request)
		{
			return base.Channel.Submit_Request_for_Quote_AwardAsync(request);
		}

		public Task<Submit_Request_for_Quote_AwardOutput> Submit_Request_for_Quote_AwardAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Request_for_Quote_Award_RequestType Submit_Request_for_Quote_Award_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Request_for_Quote_AwardAsync(new Submit_Request_for_Quote_AwardInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Request_for_Quote_Award_Request = Submit_Request_for_Quote_Award_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_GuestsOutput Resource_ManagementPort.Get_Guests(Get_GuestsInput request)
		{
			return base.Channel.Get_Guests(request);
		}

		public Get_Guests_ResponseType Get_Guests(Workday_Common_HeaderType Workday_Common_Header, Get_Guests_RequestType Get_Guests_Request)
		{
			return ((Resource_ManagementPort)this).Get_Guests(new Get_GuestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Guests_Request = Get_Guests_Request
			}).Get_Guests_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_GuestsOutput> Resource_ManagementPort.Get_GuestsAsync(Get_GuestsInput request)
		{
			return base.Channel.Get_GuestsAsync(request);
		}

		public Task<Get_GuestsOutput> Get_GuestsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Guests_RequestType Get_Guests_Request)
		{
			return ((Resource_ManagementPort)this).Get_GuestsAsync(new Get_GuestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Guests_Request = Get_Guests_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Guest_Listing_FilesOutput Resource_ManagementPort.Get_Guest_Listing_Files(Get_Guest_Listing_FilesInput request)
		{
			return base.Channel.Get_Guest_Listing_Files(request);
		}

		public Get_Guest_Listing_Files_ResponseType Get_Guest_Listing_Files(Workday_Common_HeaderType Workday_Common_Header, Get_Guest_Listing_Files_RequestType Get_Guest_Listing_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Guest_Listing_Files(new Get_Guest_Listing_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Guest_Listing_Files_Request = Get_Guest_Listing_Files_Request
			}).Get_Guest_Listing_Files_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Guest_Listing_FilesOutput> Resource_ManagementPort.Get_Guest_Listing_FilesAsync(Get_Guest_Listing_FilesInput request)
		{
			return base.Channel.Get_Guest_Listing_FilesAsync(request);
		}

		public Task<Get_Guest_Listing_FilesOutput> Get_Guest_Listing_FilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Guest_Listing_Files_RequestType Get_Guest_Listing_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Guest_Listing_FilesAsync(new Get_Guest_Listing_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Guest_Listing_Files_Request = Get_Guest_Listing_Files_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_Contact_InformationOutput Resource_ManagementPort.Submit_Supplier_Contact_Information(Submit_Supplier_Contact_InformationInput request)
		{
			return base.Channel.Submit_Supplier_Contact_Information(request);
		}

		public Submit_Supplier_Contact_Information_ResponseType Submit_Supplier_Contact_Information(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Contact_Information_RequestType Submit_Supplier_Contact_Information_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Contact_Information(new Submit_Supplier_Contact_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Contact_Information_Request = Submit_Supplier_Contact_Information_Request
			}).Submit_Supplier_Contact_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_Contact_InformationOutput> Resource_ManagementPort.Submit_Supplier_Contact_InformationAsync(Submit_Supplier_Contact_InformationInput request)
		{
			return base.Channel.Submit_Supplier_Contact_InformationAsync(request);
		}

		public Task<Submit_Supplier_Contact_InformationOutput> Submit_Supplier_Contact_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Contact_Information_RequestType Submit_Supplier_Contact_Information_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Contact_InformationAsync(new Submit_Supplier_Contact_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Contact_Information_Request = Submit_Supplier_Contact_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_Contact_InformationOutput Resource_ManagementPort.Get_Supplier_Contact_Information(Get_Supplier_Contact_InformationInput request)
		{
			return base.Channel.Get_Supplier_Contact_Information(request);
		}

		public Get_Supplier_Contact_Information_ResponseType Get_Supplier_Contact_Information(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Contact_Information_RequestType Get_Supplier_Contact_Information_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Contact_Information(new Get_Supplier_Contact_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Contact_Information_Request = Get_Supplier_Contact_Information_Request
			}).Get_Supplier_Contact_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_Contact_InformationOutput> Resource_ManagementPort.Get_Supplier_Contact_InformationAsync(Get_Supplier_Contact_InformationInput request)
		{
			return base.Channel.Get_Supplier_Contact_InformationAsync(request);
		}

		public Task<Get_Supplier_Contact_InformationOutput> Get_Supplier_Contact_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Contact_Information_RequestType Get_Supplier_Contact_Information_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Contact_InformationAsync(new Get_Supplier_Contact_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Contact_Information_Request = Get_Supplier_Contact_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Resource_ForecastsOutput Resource_ManagementPort.Get_Resource_Forecasts(Get_Resource_ForecastsInput request)
		{
			return base.Channel.Get_Resource_Forecasts(request);
		}

		public Get_Resource_Forecasts_ResponseType Get_Resource_Forecasts(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Forecasts_RequestType Get_Resource_Forecasts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Resource_Forecasts(new Get_Resource_ForecastsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Forecasts_Request = Get_Resource_Forecasts_Request
			}).Get_Resource_Forecasts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Resource_ForecastsOutput> Resource_ManagementPort.Get_Resource_ForecastsAsync(Get_Resource_ForecastsInput request)
		{
			return base.Channel.Get_Resource_ForecastsAsync(request);
		}

		public Task<Get_Resource_ForecastsOutput> Get_Resource_ForecastsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Forecasts_RequestType Get_Resource_Forecasts_Request)
		{
			return ((Resource_ManagementPort)this).Get_Resource_ForecastsAsync(new Get_Resource_ForecastsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Forecasts_Request = Get_Resource_Forecasts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Cash_Advance_RepaymentOutput Resource_ManagementPort.Put_Cash_Advance_Repayment(Put_Cash_Advance_RepaymentInput request)
		{
			return base.Channel.Put_Cash_Advance_Repayment(request);
		}

		public Put_Cash_Advance_Repayment_ResponseType Put_Cash_Advance_Repayment(Workday_Common_HeaderType Workday_Common_Header, Put_Cash_Advance_Repayment_RequestType Put_Cash_Advance_Repayment_Request)
		{
			return ((Resource_ManagementPort)this).Put_Cash_Advance_Repayment(new Put_Cash_Advance_RepaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Cash_Advance_Repayment_Request = Put_Cash_Advance_Repayment_Request
			}).Put_Cash_Advance_Repayment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Cash_Advance_RepaymentOutput> Resource_ManagementPort.Put_Cash_Advance_RepaymentAsync(Put_Cash_Advance_RepaymentInput request)
		{
			return base.Channel.Put_Cash_Advance_RepaymentAsync(request);
		}

		public Task<Put_Cash_Advance_RepaymentOutput> Put_Cash_Advance_RepaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Cash_Advance_Repayment_RequestType Put_Cash_Advance_Repayment_Request)
		{
			return ((Resource_ManagementPort)this).Put_Cash_Advance_RepaymentAsync(new Put_Cash_Advance_RepaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Cash_Advance_Repayment_Request = Put_Cash_Advance_Repayment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Cash_Advance_RepaymentsOutput Resource_ManagementPort.Get_Cash_Advance_Repayments(Get_Cash_Advance_RepaymentsInput request)
		{
			return base.Channel.Get_Cash_Advance_Repayments(request);
		}

		public Get_Cash_Advance_Repayments_ResponseType Get_Cash_Advance_Repayments(Workday_Common_HeaderType Workday_Common_Header, Get_Cash_Advance_Repayments_RequestType Get_Cash_Advance_Repayments_Request)
		{
			return ((Resource_ManagementPort)this).Get_Cash_Advance_Repayments(new Get_Cash_Advance_RepaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Cash_Advance_Repayments_Request = Get_Cash_Advance_Repayments_Request
			}).Get_Cash_Advance_Repayments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Cash_Advance_RepaymentsOutput> Resource_ManagementPort.Get_Cash_Advance_RepaymentsAsync(Get_Cash_Advance_RepaymentsInput request)
		{
			return base.Channel.Get_Cash_Advance_RepaymentsAsync(request);
		}

		public Task<Get_Cash_Advance_RepaymentsOutput> Get_Cash_Advance_RepaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Cash_Advance_Repayments_RequestType Get_Cash_Advance_Repayments_Request)
		{
			return ((Resource_ManagementPort)this).Get_Cash_Advance_RepaymentsAsync(new Get_Cash_Advance_RepaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Cash_Advance_Repayments_Request = Get_Cash_Advance_Repayments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Purchase_Order_Change_OrdersOutput Resource_ManagementPort.Get_Purchase_Order_Change_Orders(Get_Purchase_Order_Change_OrdersInput request)
		{
			return base.Channel.Get_Purchase_Order_Change_Orders(request);
		}

		public Get_Purchase_Order_Change_Orders_ResponseType Get_Purchase_Order_Change_Orders(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Change_Orders_RequestType Get_Purchase_Order_Change_Orders_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Order_Change_Orders(new Get_Purchase_Order_Change_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Order_Change_Orders_Request = Get_Purchase_Order_Change_Orders_Request
			}).Get_Purchase_Order_Change_Orders_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Purchase_Order_Change_OrdersOutput> Resource_ManagementPort.Get_Purchase_Order_Change_OrdersAsync(Get_Purchase_Order_Change_OrdersInput request)
		{
			return base.Channel.Get_Purchase_Order_Change_OrdersAsync(request);
		}

		public Task<Get_Purchase_Order_Change_OrdersOutput> Get_Purchase_Order_Change_OrdersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Change_Orders_RequestType Get_Purchase_Order_Change_Orders_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Order_Change_OrdersAsync(new Get_Purchase_Order_Change_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Order_Change_Orders_Request = Get_Purchase_Order_Change_Orders_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Purchase_Order_Change_OrderOutput Resource_ManagementPort.Submit_Purchase_Order_Change_Order(Submit_Purchase_Order_Change_OrderInput request)
		{
			return base.Channel.Submit_Purchase_Order_Change_Order(request);
		}

		public Submit_Purchase_Order_Change_Order_ResponseType Submit_Purchase_Order_Change_Order(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Change_Order_RequestType Submit_Purchase_Order_Change_Order_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order_Change_Order(new Submit_Purchase_Order_Change_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Change_Order_Request = Submit_Purchase_Order_Change_Order_Request
			}).Submit_Purchase_Order_Change_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Purchase_Order_Change_OrderOutput> Resource_ManagementPort.Submit_Purchase_Order_Change_OrderAsync(Submit_Purchase_Order_Change_OrderInput request)
		{
			return base.Channel.Submit_Purchase_Order_Change_OrderAsync(request);
		}

		public Task<Submit_Purchase_Order_Change_OrderOutput> Submit_Purchase_Order_Change_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Change_Order_RequestType Submit_Purchase_Order_Change_Order_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order_Change_OrderAsync(new Submit_Purchase_Order_Change_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Change_Order_Request = Submit_Purchase_Order_Change_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Maintain_Asset_SharesOutput Resource_ManagementPort.Maintain_Asset_Shares(Maintain_Asset_SharesInput request)
		{
			return base.Channel.Maintain_Asset_Shares(request);
		}

		public Maintain_Asset_Shares_ResponseType Maintain_Asset_Shares(Workday_Common_HeaderType Workday_Common_Header, Maintain_Asset_Shares_RequestType Maintain_Asset_Shares_Request)
		{
			return ((Resource_ManagementPort)this).Maintain_Asset_Shares(new Maintain_Asset_SharesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Asset_Shares_Request = Maintain_Asset_Shares_Request
			}).Maintain_Asset_Shares_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Maintain_Asset_SharesOutput> Resource_ManagementPort.Maintain_Asset_SharesAsync(Maintain_Asset_SharesInput request)
		{
			return base.Channel.Maintain_Asset_SharesAsync(request);
		}

		public Task<Maintain_Asset_SharesOutput> Maintain_Asset_SharesAsync(Workday_Common_HeaderType Workday_Common_Header, Maintain_Asset_Shares_RequestType Maintain_Asset_Shares_Request)
		{
			return ((Resource_ManagementPort)this).Maintain_Asset_SharesAsync(new Maintain_Asset_SharesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Asset_Shares_Request = Maintain_Asset_Shares_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Asset_SharesOutput Resource_ManagementPort.Get_Asset_Shares(Get_Asset_SharesInput request)
		{
			return base.Channel.Get_Asset_Shares(request);
		}

		public Get_Asset_Shares_ResponseType Get_Asset_Shares(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Shares_RequestType Get_Asset_Shares_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_Shares(new Get_Asset_SharesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Shares_Request = Get_Asset_Shares_Request
			}).Get_Asset_Shares_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Asset_SharesOutput> Resource_ManagementPort.Get_Asset_SharesAsync(Get_Asset_SharesInput request)
		{
			return base.Channel.Get_Asset_SharesAsync(request);
		}

		public Task<Get_Asset_SharesOutput> Get_Asset_SharesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Shares_RequestType Get_Asset_Shares_Request)
		{
			return ((Resource_ManagementPort)this).Get_Asset_SharesAsync(new Get_Asset_SharesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Asset_Shares_Request = Get_Asset_Shares_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Request_for_Quote_ResponseOutput Resource_ManagementPort.Cancel_Request_for_Quote_Response(Cancel_Request_for_Quote_ResponseInput request)
		{
			return base.Channel.Cancel_Request_for_Quote_Response(request);
		}

		public Cancel_Request_for_Quote_Response_ResponseType Cancel_Request_for_Quote_Response(Workday_Common_HeaderType Workday_Common_Header, Cancel_Request_for_Quote_Response_RequestType Cancel_Request_for_Quote_Response_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Request_for_Quote_Response(new Cancel_Request_for_Quote_ResponseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Request_for_Quote_Response_Request = Cancel_Request_for_Quote_Response_Request
			}).Cancel_Request_for_Quote_Response_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Request_for_Quote_ResponseOutput> Resource_ManagementPort.Cancel_Request_for_Quote_ResponseAsync(Cancel_Request_for_Quote_ResponseInput request)
		{
			return base.Channel.Cancel_Request_for_Quote_ResponseAsync(request);
		}

		public Task<Cancel_Request_for_Quote_ResponseOutput> Cancel_Request_for_Quote_ResponseAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Request_for_Quote_Response_RequestType Cancel_Request_for_Quote_Response_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Request_for_Quote_ResponseAsync(new Cancel_Request_for_Quote_ResponseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Request_for_Quote_Response_Request = Cancel_Request_for_Quote_Response_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Project_Standard_Cost_Rate_SheetsOutput Resource_ManagementPort.Get_Project_Standard_Cost_Rate_Sheets(Get_Project_Standard_Cost_Rate_SheetsInput request)
		{
			return base.Channel.Get_Project_Standard_Cost_Rate_Sheets(request);
		}

		public Get_Project_Standard_Cost_Rate_Sheets_ResponseType Get_Project_Standard_Cost_Rate_Sheets(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Standard_Cost_Rate_Sheets_RequestType Get_Project_Standard_Cost_Rate_Sheets_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Standard_Cost_Rate_Sheets(new Get_Project_Standard_Cost_Rate_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Standard_Cost_Rate_Sheets_Request = Get_Project_Standard_Cost_Rate_Sheets_Request
			}).Get_Project_Standard_Cost_Rate_Sheets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Project_Standard_Cost_Rate_SheetsOutput> Resource_ManagementPort.Get_Project_Standard_Cost_Rate_SheetsAsync(Get_Project_Standard_Cost_Rate_SheetsInput request)
		{
			return base.Channel.Get_Project_Standard_Cost_Rate_SheetsAsync(request);
		}

		public Task<Get_Project_Standard_Cost_Rate_SheetsOutput> Get_Project_Standard_Cost_Rate_SheetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Standard_Cost_Rate_Sheets_RequestType Get_Project_Standard_Cost_Rate_Sheets_Request)
		{
			return ((Resource_ManagementPort)this).Get_Project_Standard_Cost_Rate_SheetsAsync(new Get_Project_Standard_Cost_Rate_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Project_Standard_Cost_Rate_Sheets_Request = Get_Project_Standard_Cost_Rate_Sheets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Project_Standard_Cost_Rate_SheetOutput Resource_ManagementPort.Put_Project_Standard_Cost_Rate_Sheet(Put_Project_Standard_Cost_Rate_SheetInput request)
		{
			return base.Channel.Put_Project_Standard_Cost_Rate_Sheet(request);
		}

		public Put_Project_Standard_Cost_Rate_Sheet_ResponseType Put_Project_Standard_Cost_Rate_Sheet(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Standard_Cost_Rate_Sheet_RequestType Put_Project_Standard_Cost_Rate_Sheet_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Standard_Cost_Rate_Sheet(new Put_Project_Standard_Cost_Rate_SheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Standard_Cost_Rate_Sheet_Request = Put_Project_Standard_Cost_Rate_Sheet_Request
			}).Put_Project_Standard_Cost_Rate_Sheet_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Project_Standard_Cost_Rate_SheetOutput> Resource_ManagementPort.Put_Project_Standard_Cost_Rate_SheetAsync(Put_Project_Standard_Cost_Rate_SheetInput request)
		{
			return base.Channel.Put_Project_Standard_Cost_Rate_SheetAsync(request);
		}

		public Task<Put_Project_Standard_Cost_Rate_SheetOutput> Put_Project_Standard_Cost_Rate_SheetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Standard_Cost_Rate_Sheet_RequestType Put_Project_Standard_Cost_Rate_Sheet_Request)
		{
			return ((Resource_ManagementPort)this).Put_Project_Standard_Cost_Rate_SheetAsync(new Put_Project_Standard_Cost_Rate_SheetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Project_Standard_Cost_Rate_Sheet_Request = Put_Project_Standard_Cost_Rate_Sheet_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Internal_Service_DeliveriesOutput Resource_ManagementPort.Get_Internal_Service_Deliveries(Get_Internal_Service_DeliveriesInput request)
		{
			return base.Channel.Get_Internal_Service_Deliveries(request);
		}

		public Get_Internal_Service_Deliveries_ResponseType Get_Internal_Service_Deliveries(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Service_Deliveries_RequestType Get_Internal_Service_Deliveries_Request)
		{
			return ((Resource_ManagementPort)this).Get_Internal_Service_Deliveries(new Get_Internal_Service_DeliveriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Internal_Service_Deliveries_Request = Get_Internal_Service_Deliveries_Request
			}).Get_Internal_Service_Deliveries_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Internal_Service_DeliveriesOutput> Resource_ManagementPort.Get_Internal_Service_DeliveriesAsync(Get_Internal_Service_DeliveriesInput request)
		{
			return base.Channel.Get_Internal_Service_DeliveriesAsync(request);
		}

		public Task<Get_Internal_Service_DeliveriesOutput> Get_Internal_Service_DeliveriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Service_Deliveries_RequestType Get_Internal_Service_Deliveries_Request)
		{
			return ((Resource_ManagementPort)this).Get_Internal_Service_DeliveriesAsync(new Get_Internal_Service_DeliveriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Internal_Service_Deliveries_Request = Get_Internal_Service_Deliveries_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Expense_Report_for_NonWorkerOutput Resource_ManagementPort.Submit_Expense_Report_for_NonWorker(Submit_Expense_Report_for_NonWorkerInput request)
		{
			return base.Channel.Submit_Expense_Report_for_NonWorker(request);
		}

		public Submit_Expense_Report_for_NonWorker_ResponseType Submit_Expense_Report_for_NonWorker(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_for_NonWorker_RequestType Submit_Expense_Report_for_NonWorker_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Expense_Report_for_NonWorker(new Submit_Expense_Report_for_NonWorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Expense_Report_for_NonWorker_Request = Submit_Expense_Report_for_NonWorker_Request
			}).Submit_Expense_Report_for_NonWorker_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Expense_Report_for_NonWorkerOutput> Resource_ManagementPort.Submit_Expense_Report_for_NonWorkerAsync(Submit_Expense_Report_for_NonWorkerInput request)
		{
			return base.Channel.Submit_Expense_Report_for_NonWorkerAsync(request);
		}

		public Task<Submit_Expense_Report_for_NonWorkerOutput> Submit_Expense_Report_for_NonWorkerAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_for_NonWorker_RequestType Submit_Expense_Report_for_NonWorker_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Expense_Report_for_NonWorkerAsync(new Submit_Expense_Report_for_NonWorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Expense_Report_for_NonWorker_Request = Submit_Expense_Report_for_NonWorker_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Internal_Service_DeliveryOutput Resource_ManagementPort.Submit_Internal_Service_Delivery(Submit_Internal_Service_DeliveryInput request)
		{
			return base.Channel.Submit_Internal_Service_Delivery(request);
		}

		public Submit_Internal_Service_Delivery_ResponseType Submit_Internal_Service_Delivery(Workday_Common_HeaderType Workday_Common_Header, Submit_Internal_Service_Delivery_RequestType Submit_Internal_Service_Delivery_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Internal_Service_Delivery(new Submit_Internal_Service_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Internal_Service_Delivery_Request = Submit_Internal_Service_Delivery_Request
			}).Submit_Internal_Service_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Internal_Service_DeliveryOutput> Resource_ManagementPort.Submit_Internal_Service_DeliveryAsync(Submit_Internal_Service_DeliveryInput request)
		{
			return base.Channel.Submit_Internal_Service_DeliveryAsync(request);
		}

		public Task<Submit_Internal_Service_DeliveryOutput> Submit_Internal_Service_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Internal_Service_Delivery_RequestType Submit_Internal_Service_Delivery_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Internal_Service_DeliveryAsync(new Submit_Internal_Service_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Internal_Service_Delivery_Request = Submit_Internal_Service_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Internal_Service_DeliveryOutput Resource_ManagementPort.Cancel_Internal_Service_Delivery(Cancel_Internal_Service_DeliveryInput request)
		{
			return base.Channel.Cancel_Internal_Service_Delivery(request);
		}

		public Cancel_Internal_Service_Delivery_ResponseType Cancel_Internal_Service_Delivery(Workday_Common_HeaderType Workday_Common_Header, Cancel_Internal_Service_Delivery_RequestType Cancel_Internal_Service_Delivery_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Internal_Service_Delivery(new Cancel_Internal_Service_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Internal_Service_Delivery_Request = Cancel_Internal_Service_Delivery_Request
			}).Cancel_Internal_Service_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Internal_Service_DeliveryOutput> Resource_ManagementPort.Cancel_Internal_Service_DeliveryAsync(Cancel_Internal_Service_DeliveryInput request)
		{
			return base.Channel.Cancel_Internal_Service_DeliveryAsync(request);
		}

		public Task<Cancel_Internal_Service_DeliveryOutput> Cancel_Internal_Service_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Internal_Service_Delivery_RequestType Cancel_Internal_Service_Delivery_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Internal_Service_DeliveryAsync(new Cancel_Internal_Service_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Internal_Service_Delivery_Request = Cancel_Internal_Service_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Internal_Service_ProvidersOutput Resource_ManagementPort.Get_Internal_Service_Providers(Get_Internal_Service_ProvidersInput request)
		{
			return base.Channel.Get_Internal_Service_Providers(request);
		}

		public Get_Internal_Service_Providers_ResponseType Get_Internal_Service_Providers(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Service_Providers_RequestType Get_Internal_Service_Providers_Request)
		{
			return ((Resource_ManagementPort)this).Get_Internal_Service_Providers(new Get_Internal_Service_ProvidersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Internal_Service_Providers_Request = Get_Internal_Service_Providers_Request
			}).Get_Internal_Service_Providers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Internal_Service_ProvidersOutput> Resource_ManagementPort.Get_Internal_Service_ProvidersAsync(Get_Internal_Service_ProvidersInput request)
		{
			return base.Channel.Get_Internal_Service_ProvidersAsync(request);
		}

		public Task<Get_Internal_Service_ProvidersOutput> Get_Internal_Service_ProvidersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Service_Providers_RequestType Get_Internal_Service_Providers_Request)
		{
			return ((Resource_ManagementPort)this).Get_Internal_Service_ProvidersAsync(new Get_Internal_Service_ProvidersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Internal_Service_Providers_Request = Get_Internal_Service_Providers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Internal_Service_ProviderOutput Resource_ManagementPort.Put_Internal_Service_Provider(Put_Internal_Service_ProviderInput request)
		{
			return base.Channel.Put_Internal_Service_Provider(request);
		}

		public Put_Internal_Service_Provider_ResponseType Put_Internal_Service_Provider(Workday_Common_HeaderType Workday_Common_Header, Put_Internal_Service_Provider_RequestType Put_Internal_Service_Provider_Request)
		{
			return ((Resource_ManagementPort)this).Put_Internal_Service_Provider(new Put_Internal_Service_ProviderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Internal_Service_Provider_Request = Put_Internal_Service_Provider_Request
			}).Put_Internal_Service_Provider_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Internal_Service_ProviderOutput> Resource_ManagementPort.Put_Internal_Service_ProviderAsync(Put_Internal_Service_ProviderInput request)
		{
			return base.Channel.Put_Internal_Service_ProviderAsync(request);
		}

		public Task<Put_Internal_Service_ProviderOutput> Put_Internal_Service_ProviderAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Internal_Service_Provider_RequestType Put_Internal_Service_Provider_Request)
		{
			return ((Resource_ManagementPort)this).Put_Internal_Service_ProviderAsync(new Put_Internal_Service_ProviderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Internal_Service_Provider_Request = Put_Internal_Service_Provider_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Internal_CatalogsOutput Resource_ManagementPort.Get_Internal_Catalogs(Get_Internal_CatalogsInput request)
		{
			return base.Channel.Get_Internal_Catalogs(request);
		}

		public Get_Internal_Catalogs_ResponseType Get_Internal_Catalogs(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Catalogs_RequestType Get_Internal_Catalogs_Request)
		{
			return ((Resource_ManagementPort)this).Get_Internal_Catalogs(new Get_Internal_CatalogsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Internal_Catalogs_Request = Get_Internal_Catalogs_Request
			}).Get_Internal_Catalogs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Internal_CatalogsOutput> Resource_ManagementPort.Get_Internal_CatalogsAsync(Get_Internal_CatalogsInput request)
		{
			return base.Channel.Get_Internal_CatalogsAsync(request);
		}

		public Task<Get_Internal_CatalogsOutput> Get_Internal_CatalogsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Catalogs_RequestType Get_Internal_Catalogs_Request)
		{
			return ((Resource_ManagementPort)this).Get_Internal_CatalogsAsync(new Get_Internal_CatalogsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Internal_Catalogs_Request = Get_Internal_Catalogs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Internal_CatalogOutput Resource_ManagementPort.Put_Internal_Catalog(Put_Internal_CatalogInput request)
		{
			return base.Channel.Put_Internal_Catalog(request);
		}

		public Put_Internal_Catalog_ResponseType Put_Internal_Catalog(Workday_Common_HeaderType Workday_Common_Header, Put_Internal_Catalog_RequestType Put_Internal_Catalog_Request)
		{
			return ((Resource_ManagementPort)this).Put_Internal_Catalog(new Put_Internal_CatalogInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Internal_Catalog_Request = Put_Internal_Catalog_Request
			}).Put_Internal_Catalog_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Internal_CatalogOutput> Resource_ManagementPort.Put_Internal_CatalogAsync(Put_Internal_CatalogInput request)
		{
			return base.Channel.Put_Internal_CatalogAsync(request);
		}

		public Task<Put_Internal_CatalogOutput> Put_Internal_CatalogAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Internal_Catalog_RequestType Put_Internal_Catalog_Request)
		{
			return ((Resource_ManagementPort)this).Put_Internal_CatalogAsync(new Put_Internal_CatalogInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Internal_Catalog_Request = Put_Internal_Catalog_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Credit_Card_Code_MappingsOutput Resource_ManagementPort.Get_Credit_Card_Code_Mappings(Get_Credit_Card_Code_MappingsInput request)
		{
			return base.Channel.Get_Credit_Card_Code_Mappings(request);
		}

		public Get_Credit_Card_Code_Mappings_ResponseType Get_Credit_Card_Code_Mappings(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Code_Mappings_RequestType Get_Credit_Card_Code_Mappings_Request)
		{
			return ((Resource_ManagementPort)this).Get_Credit_Card_Code_Mappings(new Get_Credit_Card_Code_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Credit_Card_Code_Mappings_Request = Get_Credit_Card_Code_Mappings_Request
			}).Get_Credit_Card_Code_Mappings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Credit_Card_Code_MappingsOutput> Resource_ManagementPort.Get_Credit_Card_Code_MappingsAsync(Get_Credit_Card_Code_MappingsInput request)
		{
			return base.Channel.Get_Credit_Card_Code_MappingsAsync(request);
		}

		public Task<Get_Credit_Card_Code_MappingsOutput> Get_Credit_Card_Code_MappingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Code_Mappings_RequestType Get_Credit_Card_Code_Mappings_Request)
		{
			return ((Resource_ManagementPort)this).Get_Credit_Card_Code_MappingsAsync(new Get_Credit_Card_Code_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Credit_Card_Code_Mappings_Request = Get_Credit_Card_Code_Mappings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Credit_Card_Code_MappingOutput Resource_ManagementPort.Put_Credit_Card_Code_Mapping(Put_Credit_Card_Code_MappingInput request)
		{
			return base.Channel.Put_Credit_Card_Code_Mapping(request);
		}

		public Put_Credit_Card_Code_Mapping_ResponseType Put_Credit_Card_Code_Mapping(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Code_Mapping_RequestType Put_Credit_Card_Code_Mapping_Request)
		{
			return ((Resource_ManagementPort)this).Put_Credit_Card_Code_Mapping(new Put_Credit_Card_Code_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Credit_Card_Code_Mapping_Request = Put_Credit_Card_Code_Mapping_Request
			}).Put_Credit_Card_Code_Mapping_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Credit_Card_Code_MappingOutput> Resource_ManagementPort.Put_Credit_Card_Code_MappingAsync(Put_Credit_Card_Code_MappingInput request)
		{
			return base.Channel.Put_Credit_Card_Code_MappingAsync(request);
		}

		public Task<Put_Credit_Card_Code_MappingOutput> Put_Credit_Card_Code_MappingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Credit_Card_Code_Mapping_RequestType Put_Credit_Card_Code_Mapping_Request)
		{
			return ((Resource_ManagementPort)this).Put_Credit_Card_Code_MappingAsync(new Put_Credit_Card_Code_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Credit_Card_Code_Mapping_Request = Put_Credit_Card_Code_Mapping_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_Invoice_RequestsOutput Resource_ManagementPort.Get_Supplier_Invoice_Requests(Get_Supplier_Invoice_RequestsInput request)
		{
			return base.Channel.Get_Supplier_Invoice_Requests(request);
		}

		public Get_Supplier_Invoice_Requests_ResponseType Get_Supplier_Invoice_Requests(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Requests_RequestType Get_Supplier_Invoice_Requests_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_Requests(new Get_Supplier_Invoice_RequestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Requests_Request = Get_Supplier_Invoice_Requests_Request
			}).Get_Supplier_Invoice_Requests_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_Invoice_RequestsOutput> Resource_ManagementPort.Get_Supplier_Invoice_RequestsAsync(Get_Supplier_Invoice_RequestsInput request)
		{
			return base.Channel.Get_Supplier_Invoice_RequestsAsync(request);
		}

		public Task<Get_Supplier_Invoice_RequestsOutput> Get_Supplier_Invoice_RequestsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Invoice_Requests_RequestType Get_Supplier_Invoice_Requests_Request)
		{
			return ((Resource_ManagementPort)this).Get_Supplier_Invoice_RequestsAsync(new Get_Supplier_Invoice_RequestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Invoice_Requests_Request = Get_Supplier_Invoice_Requests_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Supplier_Invoice_RequestOutput Resource_ManagementPort.Submit_Supplier_Invoice_Request(Submit_Supplier_Invoice_RequestInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_Request(request);
		}

		public Submit_Supplier_Invoice_Request_ResponseType Submit_Supplier_Invoice_Request(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Request_RequestType Submit_Supplier_Invoice_Request_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_Request(new Submit_Supplier_Invoice_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Request_Request = Submit_Supplier_Invoice_Request_Request
			}).Submit_Supplier_Invoice_Request_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Supplier_Invoice_RequestOutput> Resource_ManagementPort.Submit_Supplier_Invoice_RequestAsync(Submit_Supplier_Invoice_RequestInput request)
		{
			return base.Channel.Submit_Supplier_Invoice_RequestAsync(request);
		}

		public Task<Submit_Supplier_Invoice_RequestOutput> Submit_Supplier_Invoice_RequestAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Request_RequestType Submit_Supplier_Invoice_Request_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Supplier_Invoice_RequestAsync(new Submit_Supplier_Invoice_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Supplier_Invoice_Request_Request = Submit_Supplier_Invoice_Request_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Procurement_Document_AttachmentOutput Resource_ManagementPort.Put_Procurement_Document_Attachment(Put_Procurement_Document_AttachmentInput request)
		{
			return base.Channel.Put_Procurement_Document_Attachment(request);
		}

		public Put_Procurement_Document_Attachment_ResponseType Put_Procurement_Document_Attachment(Workday_Common_HeaderType Workday_Common_Header, Put_Procurement_Document_Attachment_RequestType Put_Procurement_Document_Attachment_Request)
		{
			return ((Resource_ManagementPort)this).Put_Procurement_Document_Attachment(new Put_Procurement_Document_AttachmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Procurement_Document_Attachment_Request = Put_Procurement_Document_Attachment_Request
			}).Put_Procurement_Document_Attachment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Procurement_Document_AttachmentOutput> Resource_ManagementPort.Put_Procurement_Document_AttachmentAsync(Put_Procurement_Document_AttachmentInput request)
		{
			return base.Channel.Put_Procurement_Document_AttachmentAsync(request);
		}

		public Task<Put_Procurement_Document_AttachmentOutput> Put_Procurement_Document_AttachmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Procurement_Document_Attachment_RequestType Put_Procurement_Document_Attachment_Request)
		{
			return ((Resource_ManagementPort)this).Put_Procurement_Document_AttachmentAsync(new Put_Procurement_Document_AttachmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Procurement_Document_Attachment_Request = Put_Procurement_Document_Attachment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Adjust_Asset_In_Service_DateOutput Resource_ManagementPort.Adjust_Asset_In_Service_Date(Adjust_Asset_In_Service_DateInput request)
		{
			return base.Channel.Adjust_Asset_In_Service_Date(request);
		}

		public Adjust_Asset_In_Service_Date_ResponseType Adjust_Asset_In_Service_Date(Workday_Common_HeaderType Workday_Common_Header, Adjust_Asset_In_Service_Date_RequestType Adjust_Asset_In_Service_Date_Request)
		{
			return ((Resource_ManagementPort)this).Adjust_Asset_In_Service_Date(new Adjust_Asset_In_Service_DateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Adjust_Asset_In_Service_Date_Request = Adjust_Asset_In_Service_Date_Request
			}).Adjust_Asset_In_Service_Date_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Adjust_Asset_In_Service_DateOutput> Resource_ManagementPort.Adjust_Asset_In_Service_DateAsync(Adjust_Asset_In_Service_DateInput request)
		{
			return base.Channel.Adjust_Asset_In_Service_DateAsync(request);
		}

		public Task<Adjust_Asset_In_Service_DateOutput> Adjust_Asset_In_Service_DateAsync(Workday_Common_HeaderType Workday_Common_Header, Adjust_Asset_In_Service_Date_RequestType Adjust_Asset_In_Service_Date_Request)
		{
			return ((Resource_ManagementPort)this).Adjust_Asset_In_Service_DateAsync(new Adjust_Asset_In_Service_DateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Adjust_Asset_In_Service_Date_Request = Adjust_Asset_In_Service_Date_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Advanced_Ship_NoticeOutput Resource_ManagementPort.Submit_Advanced_Ship_Notice(Submit_Advanced_Ship_NoticeInput request)
		{
			return base.Channel.Submit_Advanced_Ship_Notice(request);
		}

		public Submit_Advanced_Ship_Notice_ResponseType Submit_Advanced_Ship_Notice(Workday_Common_HeaderType Workday_Common_Header, Submit_Advanced_Ship_Notice_RequestType Submit_Advanced_Ship_Notice_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Advanced_Ship_Notice(new Submit_Advanced_Ship_NoticeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Advanced_Ship_Notice_Request = Submit_Advanced_Ship_Notice_Request
			}).Submit_Advanced_Ship_Notice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Advanced_Ship_NoticeOutput> Resource_ManagementPort.Submit_Advanced_Ship_NoticeAsync(Submit_Advanced_Ship_NoticeInput request)
		{
			return base.Channel.Submit_Advanced_Ship_NoticeAsync(request);
		}

		public Task<Submit_Advanced_Ship_NoticeOutput> Submit_Advanced_Ship_NoticeAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Advanced_Ship_Notice_RequestType Submit_Advanced_Ship_Notice_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Advanced_Ship_NoticeAsync(new Submit_Advanced_Ship_NoticeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Advanced_Ship_Notice_Request = Submit_Advanced_Ship_Notice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Advanced_Ship_NoticesOutput Resource_ManagementPort.Get_Advanced_Ship_Notices(Get_Advanced_Ship_NoticesInput request)
		{
			return base.Channel.Get_Advanced_Ship_Notices(request);
		}

		public Get_Advanced_Ship_Notices_ResponseType Get_Advanced_Ship_Notices(Workday_Common_HeaderType Workday_Common_Header, Get_Advanced_Ship_Notices_RequestType Get_Advanced_Ship_Notices_Request)
		{
			return ((Resource_ManagementPort)this).Get_Advanced_Ship_Notices(new Get_Advanced_Ship_NoticesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Advanced_Ship_Notices_Request = Get_Advanced_Ship_Notices_Request
			}).Get_Advanced_Ship_Notices_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Advanced_Ship_NoticesOutput> Resource_ManagementPort.Get_Advanced_Ship_NoticesAsync(Get_Advanced_Ship_NoticesInput request)
		{
			return base.Channel.Get_Advanced_Ship_NoticesAsync(request);
		}

		public Task<Get_Advanced_Ship_NoticesOutput> Get_Advanced_Ship_NoticesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Advanced_Ship_Notices_RequestType Get_Advanced_Ship_Notices_Request)
		{
			return ((Resource_ManagementPort)this).Get_Advanced_Ship_NoticesAsync(new Get_Advanced_Ship_NoticesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Advanced_Ship_Notices_Request = Get_Advanced_Ship_Notices_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Purchase_Order_AcknowledgementOutput Resource_ManagementPort.Submit_Purchase_Order_Acknowledgement(Submit_Purchase_Order_AcknowledgementInput request)
		{
			return base.Channel.Submit_Purchase_Order_Acknowledgement(request);
		}

		public Submit_Purchase_Order_Acknowledgement_ResponseType Submit_Purchase_Order_Acknowledgement(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Acknowledgement_RequestType Submit_Purchase_Order_Acknowledgement_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order_Acknowledgement(new Submit_Purchase_Order_AcknowledgementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Acknowledgement_Request = Submit_Purchase_Order_Acknowledgement_Request
			}).Submit_Purchase_Order_Acknowledgement_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Purchase_Order_AcknowledgementOutput> Resource_ManagementPort.Submit_Purchase_Order_AcknowledgementAsync(Submit_Purchase_Order_AcknowledgementInput request)
		{
			return base.Channel.Submit_Purchase_Order_AcknowledgementAsync(request);
		}

		public Task<Submit_Purchase_Order_AcknowledgementOutput> Submit_Purchase_Order_AcknowledgementAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Acknowledgement_RequestType Submit_Purchase_Order_Acknowledgement_Request)
		{
			return ((Resource_ManagementPort)this).Submit_Purchase_Order_AcknowledgementAsync(new Submit_Purchase_Order_AcknowledgementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Purchase_Order_Acknowledgement_Request = Submit_Purchase_Order_Acknowledgement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Advanced_Ship_NoticeOutput Resource_ManagementPort.Cancel_Advanced_Ship_Notice(Cancel_Advanced_Ship_NoticeInput request)
		{
			return base.Channel.Cancel_Advanced_Ship_Notice(request);
		}

		public Cancel_Advanced_Ship_Notice_ResponseType Cancel_Advanced_Ship_Notice(Workday_Common_HeaderType Workday_Common_Header, Cancel_Advanced_Ship_Notice_RequestType Cancel_Advanced_Ship_Notice_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Advanced_Ship_Notice(new Cancel_Advanced_Ship_NoticeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Advanced_Ship_Notice_Request = Cancel_Advanced_Ship_Notice_Request
			}).Cancel_Advanced_Ship_Notice_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Advanced_Ship_NoticeOutput> Resource_ManagementPort.Cancel_Advanced_Ship_NoticeAsync(Cancel_Advanced_Ship_NoticeInput request)
		{
			return base.Channel.Cancel_Advanced_Ship_NoticeAsync(request);
		}

		public Task<Cancel_Advanced_Ship_NoticeOutput> Cancel_Advanced_Ship_NoticeAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Advanced_Ship_Notice_RequestType Cancel_Advanced_Ship_Notice_Request)
		{
			return ((Resource_ManagementPort)this).Cancel_Advanced_Ship_NoticeAsync(new Cancel_Advanced_Ship_NoticeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Advanced_Ship_Notice_Request = Cancel_Advanced_Ship_Notice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_Travel_Profile_Listing_FilesOutput Resource_ManagementPort.Get_Worker_Travel_Profile_Listing_Files(Get_Worker_Travel_Profile_Listing_FilesInput request)
		{
			return base.Channel.Get_Worker_Travel_Profile_Listing_Files(request);
		}

		public Get_Worker_Travel_Profile_Listing_Files_ResponseType Get_Worker_Travel_Profile_Listing_Files(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Travel_Profile_Listing_Files_RequestType Get_Worker_Travel_Profile_Listing_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Worker_Travel_Profile_Listing_Files(new Get_Worker_Travel_Profile_Listing_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Travel_Profile_Listing_Files_Request = Get_Worker_Travel_Profile_Listing_Files_Request
			}).Get_Worker_Travel_Profile_Listing_Files_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_Travel_Profile_Listing_FilesOutput> Resource_ManagementPort.Get_Worker_Travel_Profile_Listing_FilesAsync(Get_Worker_Travel_Profile_Listing_FilesInput request)
		{
			return base.Channel.Get_Worker_Travel_Profile_Listing_FilesAsync(request);
		}

		public Task<Get_Worker_Travel_Profile_Listing_FilesOutput> Get_Worker_Travel_Profile_Listing_FilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Travel_Profile_Listing_Files_RequestType Get_Worker_Travel_Profile_Listing_Files_Request)
		{
			return ((Resource_ManagementPort)this).Get_Worker_Travel_Profile_Listing_FilesAsync(new Get_Worker_Travel_Profile_Listing_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Travel_Profile_Listing_Files_Request = Get_Worker_Travel_Profile_Listing_Files_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Purchase_Order_AcknowledgementOutput Resource_ManagementPort.Get_Purchase_Order_Acknowledgement(Get_Purchase_Order_AcknowledgementInput request)
		{
			return base.Channel.Get_Purchase_Order_Acknowledgement(request);
		}

		public Get_Purchase_Order_Acknowledgements_ResponseType Get_Purchase_Order_Acknowledgement(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Acknowledgements_RequestType Get_Purchase_Order_Acknowledgements_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Order_Acknowledgement(new Get_Purchase_Order_AcknowledgementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Order_Acknowledgements_Request = Get_Purchase_Order_Acknowledgements_Request
			}).Get_Purchase_Order_Acknowledgements_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Purchase_Order_AcknowledgementOutput> Resource_ManagementPort.Get_Purchase_Order_AcknowledgementAsync(Get_Purchase_Order_AcknowledgementInput request)
		{
			return base.Channel.Get_Purchase_Order_AcknowledgementAsync(request);
		}

		public Task<Get_Purchase_Order_AcknowledgementOutput> Get_Purchase_Order_AcknowledgementAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Acknowledgements_RequestType Get_Purchase_Order_Acknowledgements_Request)
		{
			return ((Resource_ManagementPort)this).Get_Purchase_Order_AcknowledgementAsync(new Get_Purchase_Order_AcknowledgementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Purchase_Order_Acknowledgements_Request = Get_Purchase_Order_Acknowledgements_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Supplier_Invoice(Import_Supplier_InvoiceInput request)
		{
			return base.Channel.Import_Supplier_Invoice(request);
		}

		public Put_Import_Process_ResponseType Import_Supplier_Invoice(Workday_Common_HeaderType Workday_Common_Header, Import_Supplier_Invoice_RequestType Import_Supplier_Invoice_Request)
		{
			return ((Resource_ManagementPort)this).Import_Supplier_Invoice(new Import_Supplier_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Supplier_Invoice_Request = Import_Supplier_Invoice_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Supplier_InvoiceAsync(Import_Supplier_InvoiceInput request)
		{
			return base.Channel.Import_Supplier_InvoiceAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Supplier_InvoiceAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Supplier_Invoice_RequestType Import_Supplier_Invoice_Request)
		{
			return ((Resource_ManagementPort)this).Import_Supplier_InvoiceAsync(new Import_Supplier_InvoiceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Supplier_Invoice_Request = Import_Supplier_Invoice_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Travel_Booking_Records(Import_Travel_Booking_RecordsInput request)
		{
			return base.Channel.Import_Travel_Booking_Records(request);
		}

		public Put_Import_Process_ResponseType Import_Travel_Booking_Records(Workday_Common_HeaderType Workday_Common_Header, Travel_Booking_Header_RequestType Travel_Booking_Header_Request)
		{
			return ((Resource_ManagementPort)this).Import_Travel_Booking_Records(new Import_Travel_Booking_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Travel_Booking_Header_Request = Travel_Booking_Header_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Travel_Booking_RecordsAsync(Import_Travel_Booking_RecordsInput request)
		{
			return base.Channel.Import_Travel_Booking_RecordsAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Travel_Booking_RecordsAsync(Workday_Common_HeaderType Workday_Common_Header, Travel_Booking_Header_RequestType Travel_Booking_Header_Request)
		{
			return ((Resource_ManagementPort)this).Import_Travel_Booking_RecordsAsync(new Import_Travel_Booking_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Travel_Booking_Header_Request = Travel_Booking_Header_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Credit_Card_Transactions(Import_Credit_Card_TransactionsInput request)
		{
			return base.Channel.Import_Credit_Card_Transactions(request);
		}

		public Put_Import_Process_ResponseType Import_Credit_Card_Transactions(Workday_Common_HeaderType Workday_Common_Header, Credit_Card_Transaction_Header__HV__RequestType Credit_Card_Transaction_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Credit_Card_Transactions(new Import_Credit_Card_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Credit_Card_Transaction_Header__HV__Request = Credit_Card_Transaction_Header__HV__Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Credit_Card_TransactionsAsync(Import_Credit_Card_TransactionsInput request)
		{
			return base.Channel.Import_Credit_Card_TransactionsAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Credit_Card_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Credit_Card_Transaction_Header__HV__RequestType Credit_Card_Transaction_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Credit_Card_TransactionsAsync(new Import_Credit_Card_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Credit_Card_Transaction_Header__HV__Request = Credit_Card_Transaction_Header__HV__Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Catalog_Load(Import_Catalog_LoadInput request)
		{
			return base.Channel.Import_Catalog_Load(request);
		}

		public Put_Import_Process_ResponseType Import_Catalog_Load(Workday_Common_HeaderType Workday_Common_Header, Import_Catalog_Load_RequestType Import_Catalog_Load_Request)
		{
			return ((Resource_ManagementPort)this).Import_Catalog_Load(new Import_Catalog_LoadInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Catalog_Load_Request = Import_Catalog_Load_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Catalog_LoadAsync(Import_Catalog_LoadInput request)
		{
			return base.Channel.Import_Catalog_LoadAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Catalog_LoadAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Catalog_Load_RequestType Import_Catalog_Load_Request)
		{
			return ((Resource_ManagementPort)this).Import_Catalog_LoadAsync(new Import_Catalog_LoadInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Catalog_Load_Request = Import_Catalog_Load_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Credit_Cards(Import_Credit_CardsInput request)
		{
			return base.Channel.Import_Credit_Cards(request);
		}

		public Put_Import_Process_ResponseType Import_Credit_Cards(Workday_Common_HeaderType Workday_Common_Header, Credit_Card_Header__HV__RequestType Credit_Card_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Credit_Cards(new Import_Credit_CardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Credit_Card_Header__HV__Request = Credit_Card_Header__HV__Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Credit_CardsAsync(Import_Credit_CardsInput request)
		{
			return base.Channel.Import_Credit_CardsAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Credit_CardsAsync(Workday_Common_HeaderType Workday_Common_Header, Credit_Card_Header__HV__RequestType Credit_Card_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Credit_CardsAsync(new Import_Credit_CardsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Credit_Card_Header__HV__Request = Credit_Card_Header__HV__Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Guests(Import_GuestsInput request)
		{
			return base.Channel.Import_Guests(request);
		}

		public Put_Import_Process_ResponseType Import_Guests(Workday_Common_HeaderType Workday_Common_Header, Guest_Header__HV__RequestType Guest_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Guests(new Import_GuestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Guest_Header__HV__Request = Guest_Header__HV__Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_GuestsAsync(Import_GuestsInput request)
		{
			return base.Channel.Import_GuestsAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_GuestsAsync(Workday_Common_HeaderType Workday_Common_Header, Guest_Header__HV__RequestType Guest_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_GuestsAsync(new Import_GuestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Guest_Header__HV__Request = Guest_Header__HV__Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Resource_Forecast(Import_Resource_ForecastInput request)
		{
			return base.Channel.Import_Resource_Forecast(request);
		}

		public Put_Import_Process_ResponseType Import_Resource_Forecast(Workday_Common_HeaderType Workday_Common_Header, Import_Resource_Forecast_RequestType Import_Resource_Forecast_Request)
		{
			return ((Resource_ManagementPort)this).Import_Resource_Forecast(new Import_Resource_ForecastInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Resource_Forecast_Request = Import_Resource_Forecast_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Resource_ForecastAsync(Import_Resource_ForecastInput request)
		{
			return base.Channel.Import_Resource_ForecastAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Resource_ForecastAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Resource_Forecast_RequestType Import_Resource_Forecast_Request)
		{
			return ((Resource_ManagementPort)this).Import_Resource_ForecastAsync(new Import_Resource_ForecastInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Resource_Forecast_Request = Import_Resource_Forecast_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Expense_Rate_Table(Import_Expense_Rate_TableInput request)
		{
			return base.Channel.Import_Expense_Rate_Table(request);
		}

		public Put_Import_Process_ResponseType Import_Expense_Rate_Table(Workday_Common_HeaderType Workday_Common_Header, Expense_Rate_Table_Header__HV__RequestType Expense_Rate_Table_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Expense_Rate_Table(new Import_Expense_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Expense_Rate_Table_Header__HV__Request = Expense_Rate_Table_Header__HV__Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Expense_Rate_TableAsync(Import_Expense_Rate_TableInput request)
		{
			return base.Channel.Import_Expense_Rate_TableAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Expense_Rate_TableAsync(Workday_Common_HeaderType Workday_Common_Header, Expense_Rate_Table_Header__HV__RequestType Expense_Rate_Table_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Expense_Rate_TableAsync(new Import_Expense_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Expense_Rate_Table_Header__HV__Request = Expense_Rate_Table_Header__HV__Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Supplier_InvoiceOutput Resource_ManagementPort.Import_Travel_Profiles(Import_Travel_ProfilesInput request)
		{
			return base.Channel.Import_Travel_Profiles(request);
		}

		public Put_Import_Process_ResponseType Import_Travel_Profiles(Workday_Common_HeaderType Workday_Common_Header, Worker_Travel_Profile_Header__HV__RequestType Worker_Travel_Profile_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Travel_Profiles(new Import_Travel_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Worker_Travel_Profile_Header__HV__Request = Worker_Travel_Profile_Header__HV__Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Supplier_InvoiceOutput> Resource_ManagementPort.Import_Travel_ProfilesAsync(Import_Travel_ProfilesInput request)
		{
			return base.Channel.Import_Travel_ProfilesAsync(request);
		}

		public Task<Import_Supplier_InvoiceOutput> Import_Travel_ProfilesAsync(Workday_Common_HeaderType Workday_Common_Header, Worker_Travel_Profile_Header__HV__RequestType Worker_Travel_Profile_Header__HV__Request)
		{
			return ((Resource_ManagementPort)this).Import_Travel_ProfilesAsync(new Import_Travel_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Worker_Travel_Profile_Header__HV__Request = Worker_Travel_Profile_Header__HV__Request
			});
		}
	}
}
