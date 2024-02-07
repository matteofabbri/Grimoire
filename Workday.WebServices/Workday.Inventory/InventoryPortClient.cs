using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class InventoryPortClient : ClientBase<InventoryPort>, InventoryPort
	{
		public InventoryPortClient()
		{
		}

		public InventoryPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public InventoryPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public InventoryPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public InventoryPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Quick_IssueOutput InventoryPort.Submit_Inventory_Quick_Issue(Submit_Inventory_Quick_IssueInput request)
		{
			return base.Channel.Submit_Inventory_Quick_Issue(request);
		}

		public Submit_Inventory_Quick_Issue_ResponseType Submit_Inventory_Quick_Issue(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Quick_Issue_RequestType Submit_Inventory_Quick_Issue_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Quick_Issue(new Submit_Inventory_Quick_IssueInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Quick_Issue_Request = Submit_Inventory_Quick_Issue_Request
			}).Submit_Inventory_Quick_Issue_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Quick_IssueOutput> InventoryPort.Submit_Inventory_Quick_IssueAsync(Submit_Inventory_Quick_IssueInput request)
		{
			return base.Channel.Submit_Inventory_Quick_IssueAsync(request);
		}

		public Task<Submit_Inventory_Quick_IssueOutput> Submit_Inventory_Quick_IssueAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Quick_Issue_RequestType Submit_Inventory_Quick_Issue_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Quick_IssueAsync(new Submit_Inventory_Quick_IssueInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Quick_Issue_Request = Submit_Inventory_Quick_Issue_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_MoveOutput InventoryPort.Submit_Inventory_Move(Submit_Inventory_MoveInput request)
		{
			return base.Channel.Submit_Inventory_Move(request);
		}

		public Submit_Inventory_Move_ResponseType Submit_Inventory_Move(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Move_RequestType Submit_Inventory_Move_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Move(new Submit_Inventory_MoveInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Move_Request = Submit_Inventory_Move_Request
			}).Submit_Inventory_Move_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_MoveOutput> InventoryPort.Submit_Inventory_MoveAsync(Submit_Inventory_MoveInput request)
		{
			return base.Channel.Submit_Inventory_MoveAsync(request);
		}

		public Task<Submit_Inventory_MoveOutput> Submit_Inventory_MoveAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Move_RequestType Submit_Inventory_Move_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_MoveAsync(new Submit_Inventory_MoveInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Move_Request = Submit_Inventory_Move_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_AdjustmentOutput InventoryPort.Submit_Inventory_Adjustment(Submit_Inventory_AdjustmentInput request)
		{
			return base.Channel.Submit_Inventory_Adjustment(request);
		}

		public Submit_Inventory_Adjustment_ResponseType Submit_Inventory_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Adjustment_RequestType Submit_Inventory_Adjustment_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Adjustment(new Submit_Inventory_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Adjustment_Request = Submit_Inventory_Adjustment_Request
			}).Submit_Inventory_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_AdjustmentOutput> InventoryPort.Submit_Inventory_AdjustmentAsync(Submit_Inventory_AdjustmentInput request)
		{
			return base.Channel.Submit_Inventory_AdjustmentAsync(request);
		}

		public Task<Submit_Inventory_AdjustmentOutput> Submit_Inventory_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Adjustment_RequestType Submit_Inventory_Adjustment_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_AdjustmentAsync(new Submit_Inventory_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Adjustment_Request = Submit_Inventory_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Location_AttributesOutput InventoryPort.Get_Inventory_Location_Attributes(Get_Inventory_Location_AttributesInput request)
		{
			return base.Channel.Get_Inventory_Location_Attributes(request);
		}

		public Get_Inventory_Location_Attributes_ResponseType Get_Inventory_Location_Attributes(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Location_Attributes_RequestType Get_Inventory_Location_Attributes_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Location_Attributes(new Get_Inventory_Location_AttributesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Location_Attributes_Request = Get_Inventory_Location_Attributes_Request
			}).Get_Inventory_Location_Attributes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Location_AttributesOutput> InventoryPort.Get_Inventory_Location_AttributesAsync(Get_Inventory_Location_AttributesInput request)
		{
			return base.Channel.Get_Inventory_Location_AttributesAsync(request);
		}

		public Task<Get_Inventory_Location_AttributesOutput> Get_Inventory_Location_AttributesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Location_Attributes_RequestType Get_Inventory_Location_Attributes_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Location_AttributesAsync(new Get_Inventory_Location_AttributesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Location_Attributes_Request = Get_Inventory_Location_Attributes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Inventory_Location_AttributesOutput InventoryPort.Put_Inventory_Location_Attributes(Put_Inventory_Location_AttributesInput request)
		{
			return base.Channel.Put_Inventory_Location_Attributes(request);
		}

		public Put_Inventory_Location_Attributes_ResponseType Put_Inventory_Location_Attributes(Workday_Common_HeaderType Workday_Common_Header, Put_Inventory_Location_Attributes_RequestType Put_Inventory_Location_Attributes_Request)
		{
			return ((InventoryPort)this).Put_Inventory_Location_Attributes(new Put_Inventory_Location_AttributesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Inventory_Location_Attributes_Request = Put_Inventory_Location_Attributes_Request
			}).Put_Inventory_Location_Attributes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Inventory_Location_AttributesOutput> InventoryPort.Put_Inventory_Location_AttributesAsync(Put_Inventory_Location_AttributesInput request)
		{
			return base.Channel.Put_Inventory_Location_AttributesAsync(request);
		}

		public Task<Put_Inventory_Location_AttributesOutput> Put_Inventory_Location_AttributesAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Inventory_Location_Attributes_RequestType Put_Inventory_Location_Attributes_Request)
		{
			return ((InventoryPort)this).Put_Inventory_Location_AttributesAsync(new Put_Inventory_Location_AttributesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Inventory_Location_Attributes_Request = Put_Inventory_Location_Attributes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Ad_Hoc_PutAwayOutput InventoryPort.Submit_Ad_Hoc_PutAway(Submit_Ad_Hoc_PutAwayInput request)
		{
			return base.Channel.Submit_Ad_Hoc_PutAway(request);
		}

		public Submit_Ad_Hoc_PutAway_ResponseType Submit_Ad_Hoc_PutAway(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_Hoc_PutAway_RequestType Submit_Ad_Hoc_PutAway_Request)
		{
			return ((InventoryPort)this).Submit_Ad_Hoc_PutAway(new Submit_Ad_Hoc_PutAwayInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_Hoc_PutAway_Request = Submit_Ad_Hoc_PutAway_Request
			}).Submit_Ad_Hoc_PutAway_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Ad_Hoc_PutAwayOutput> InventoryPort.Submit_Ad_Hoc_PutAwayAsync(Submit_Ad_Hoc_PutAwayInput request)
		{
			return base.Channel.Submit_Ad_Hoc_PutAwayAsync(request);
		}

		public Task<Submit_Ad_Hoc_PutAwayOutput> Submit_Ad_Hoc_PutAwayAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_Hoc_PutAway_RequestType Submit_Ad_Hoc_PutAway_Request)
		{
			return ((InventoryPort)this).Submit_Ad_Hoc_PutAwayAsync(new Submit_Ad_Hoc_PutAwayInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_Hoc_PutAway_Request = Submit_Ad_Hoc_PutAway_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_PutAwayOutput InventoryPort.Submit_PutAway(Submit_PutAwayInput request)
		{
			return base.Channel.Submit_PutAway(request);
		}

		public Submit_PutAway_ResponseType Submit_PutAway(Workday_Common_HeaderType Workday_Common_Header, Submit_PutAway_RequestType Submit_PutAway_Request)
		{
			return ((InventoryPort)this).Submit_PutAway(new Submit_PutAwayInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_PutAway_Request = Submit_PutAway_Request
			}).Submit_PutAway_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_PutAwayOutput> InventoryPort.Submit_PutAwayAsync(Submit_PutAwayInput request)
		{
			return base.Channel.Submit_PutAwayAsync(request);
		}

		public Task<Submit_PutAwayOutput> Submit_PutAwayAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_PutAway_RequestType Submit_PutAway_Request)
		{
			return ((InventoryPort)this).Submit_PutAwayAsync(new Submit_PutAwayInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_PutAway_Request = Submit_PutAway_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Cost_AdjustmentOutput InventoryPort.Submit_Inventory_Cost_Adjustment(Submit_Inventory_Cost_AdjustmentInput request)
		{
			return base.Channel.Submit_Inventory_Cost_Adjustment(request);
		}

		public Submit_Inventory_Cost_Adjustment_ResponseType Submit_Inventory_Cost_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Cost_Adjustment_RequestType Submit_Inventory_Cost_Adjustment_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Cost_Adjustment(new Submit_Inventory_Cost_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Cost_Adjustment_Request = Submit_Inventory_Cost_Adjustment_Request
			}).Submit_Inventory_Cost_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Cost_AdjustmentOutput> InventoryPort.Submit_Inventory_Cost_AdjustmentAsync(Submit_Inventory_Cost_AdjustmentInput request)
		{
			return base.Channel.Submit_Inventory_Cost_AdjustmentAsync(request);
		}

		public Task<Submit_Inventory_Cost_AdjustmentOutput> Submit_Inventory_Cost_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Cost_Adjustment_RequestType Submit_Inventory_Cost_Adjustment_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Cost_AdjustmentAsync(new Submit_Inventory_Cost_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Cost_Adjustment_Request = Submit_Inventory_Cost_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Stock_RequestOutput InventoryPort.Submit_Inventory_Stock_Request(Submit_Inventory_Stock_RequestInput request)
		{
			return base.Channel.Submit_Inventory_Stock_Request(request);
		}

		public Submit_Inventory_Stock_Request_ResponseType Submit_Inventory_Stock_Request(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Stock_RequestType Submit_Inventory_Stock_Request1)
		{
			return ((InventoryPort)this).Submit_Inventory_Stock_Request(new Submit_Inventory_Stock_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Stock_Request = Submit_Inventory_Stock_Request1
			}).Submit_Inventory_Stock_Request_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Stock_RequestOutput> InventoryPort.Submit_Inventory_Stock_RequestAsync(Submit_Inventory_Stock_RequestInput request)
		{
			return base.Channel.Submit_Inventory_Stock_RequestAsync(request);
		}

		public Task<Submit_Inventory_Stock_RequestOutput> Submit_Inventory_Stock_RequestAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Stock_RequestType Submit_Inventory_Stock_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Stock_RequestAsync(new Submit_Inventory_Stock_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Stock_Request = Submit_Inventory_Stock_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Stock_RequestOutput InventoryPort.Get_Inventory_Stock_Request(Get_Inventory_Stock_RequestInput request)
		{
			return base.Channel.Get_Inventory_Stock_Request(request);
		}

		public Get_Inventory_Stock_Requests_ResponseType Get_Inventory_Stock_Request(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Stock_Requests_RequestType Get_Inventory_Stock_Requests_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Stock_Request(new Get_Inventory_Stock_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Stock_Requests_Request = Get_Inventory_Stock_Requests_Request
			}).Get_Inventory_Stock_Requests_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Stock_RequestOutput> InventoryPort.Get_Inventory_Stock_RequestAsync(Get_Inventory_Stock_RequestInput request)
		{
			return base.Channel.Get_Inventory_Stock_RequestAsync(request);
		}

		public Task<Get_Inventory_Stock_RequestOutput> Get_Inventory_Stock_RequestAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Stock_Requests_RequestType Get_Inventory_Stock_Requests_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Stock_RequestAsync(new Get_Inventory_Stock_RequestInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Stock_Requests_Request = Get_Inventory_Stock_Requests_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Picking_ListsOutput InventoryPort.Get_Inventory_Picking_Lists(Get_Inventory_Picking_ListsInput request)
		{
			return base.Channel.Get_Inventory_Picking_Lists(request);
		}

		public Get_Inventory_Picking_Lists_ResponseType Get_Inventory_Picking_Lists(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Picking_Lists_RequestType Get_Inventory_Picking_Lists_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Picking_Lists(new Get_Inventory_Picking_ListsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Picking_Lists_Request = Get_Inventory_Picking_Lists_Request
			}).Get_Inventory_Picking_Lists_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Picking_ListsOutput> InventoryPort.Get_Inventory_Picking_ListsAsync(Get_Inventory_Picking_ListsInput request)
		{
			return base.Channel.Get_Inventory_Picking_ListsAsync(request);
		}

		public Task<Get_Inventory_Picking_ListsOutput> Get_Inventory_Picking_ListsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Picking_Lists_RequestType Get_Inventory_Picking_Lists_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Picking_ListsAsync(new Get_Inventory_Picking_ListsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Picking_Lists_Request = Get_Inventory_Picking_Lists_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_PickOutput InventoryPort.Submit_Inventory_Pick(Submit_Inventory_PickInput request)
		{
			return base.Channel.Submit_Inventory_Pick(request);
		}

		public Submit_Inventory_Pick_ResponseType Submit_Inventory_Pick(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Pick_RequestType Submit_Inventory_Pick_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Pick(new Submit_Inventory_PickInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Pick_Request = Submit_Inventory_Pick_Request
			}).Submit_Inventory_Pick_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_PickOutput> InventoryPort.Submit_Inventory_PickAsync(Submit_Inventory_PickInput request)
		{
			return base.Channel.Submit_Inventory_PickAsync(request);
		}

		public Task<Submit_Inventory_PickOutput> Submit_Inventory_PickAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Pick_RequestType Submit_Inventory_Pick_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_PickAsync(new Submit_Inventory_PickInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Pick_Request = Submit_Inventory_Pick_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_ShipmentsOutput InventoryPort.Get_Inventory_Shipments(Get_Inventory_ShipmentsInput request)
		{
			return base.Channel.Get_Inventory_Shipments(request);
		}

		public Get_Inventory_Shipments_ResponseType Get_Inventory_Shipments(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Shipments_RequestType Get_Inventory_Shipments_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Shipments(new Get_Inventory_ShipmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Shipments_Request = Get_Inventory_Shipments_Request
			}).Get_Inventory_Shipments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_ShipmentsOutput> InventoryPort.Get_Inventory_ShipmentsAsync(Get_Inventory_ShipmentsInput request)
		{
			return base.Channel.Get_Inventory_ShipmentsAsync(request);
		}

		public Task<Get_Inventory_ShipmentsOutput> Get_Inventory_ShipmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Shipments_RequestType Get_Inventory_Shipments_Request)
		{
			return ((InventoryPort)this).Get_Inventory_ShipmentsAsync(new Get_Inventory_ShipmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Shipments_Request = Get_Inventory_Shipments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_ShipmentOutput InventoryPort.Submit_Inventory_Shipment(Submit_Inventory_ShipmentInput request)
		{
			return base.Channel.Submit_Inventory_Shipment(request);
		}

		public Submit_Inventory_Shipment_Request_ResponseType Submit_Inventory_Shipment(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Shipment_RequestType Submit_Inventory_Shipment_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Shipment(new Submit_Inventory_ShipmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Shipment_Request = Submit_Inventory_Shipment_Request
			}).Submit_Inventory_Shipment_Request_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_ShipmentOutput> InventoryPort.Submit_Inventory_ShipmentAsync(Submit_Inventory_ShipmentInput request)
		{
			return base.Channel.Submit_Inventory_ShipmentAsync(request);
		}

		public Task<Submit_Inventory_ShipmentOutput> Submit_Inventory_ShipmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Shipment_RequestType Submit_Inventory_Shipment_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_ShipmentAsync(new Submit_Inventory_ShipmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Shipment_Request = Submit_Inventory_Shipment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_BalanceOutput InventoryPort.Get_Inventory_Balance(Get_Inventory_BalanceInput request)
		{
			return base.Channel.Get_Inventory_Balance(request);
		}

		public Get_Inventory_Balance_WWS_Main_ResponseType Get_Inventory_Balance(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Balance_WWS_RequestType Get_Inventory_Balance_WWS_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Balance(new Get_Inventory_BalanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Balance_WWS_Request = Get_Inventory_Balance_WWS_Request
			}).Get_Inventory_Balance_WWS_Main_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_BalanceOutput> InventoryPort.Get_Inventory_BalanceAsync(Get_Inventory_BalanceInput request)
		{
			return base.Channel.Get_Inventory_BalanceAsync(request);
		}

		public Task<Get_Inventory_BalanceOutput> Get_Inventory_BalanceAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Balance_WWS_RequestType Get_Inventory_Balance_WWS_Request)
		{
			return ((InventoryPort)this).Get_Inventory_BalanceAsync(new Get_Inventory_BalanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Balance_WWS_Request = Get_Inventory_Balance_WWS_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Inventory_Par_LocationOutput InventoryPort.Put_Inventory_Par_Location(Put_Inventory_Par_LocationInput request)
		{
			return base.Channel.Put_Inventory_Par_Location(request);
		}

		public Put_Inventory_Par_Location_ResponseType Put_Inventory_Par_Location(Workday_Common_HeaderType Workday_Common_Header, Put_Inventory_Par_Location_RequestType Put_Inventory_Par_Location_Request)
		{
			return ((InventoryPort)this).Put_Inventory_Par_Location(new Put_Inventory_Par_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Inventory_Par_Location_Request = Put_Inventory_Par_Location_Request
			}).Put_Inventory_Par_Location_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Inventory_Par_LocationOutput> InventoryPort.Put_Inventory_Par_LocationAsync(Put_Inventory_Par_LocationInput request)
		{
			return base.Channel.Put_Inventory_Par_LocationAsync(request);
		}

		public Task<Put_Inventory_Par_LocationOutput> Put_Inventory_Par_LocationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Inventory_Par_Location_RequestType Put_Inventory_Par_Location_Request)
		{
			return ((InventoryPort)this).Put_Inventory_Par_LocationAsync(new Put_Inventory_Par_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Inventory_Par_Location_Request = Put_Inventory_Par_Location_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Par_LocationsOutput InventoryPort.Get_Inventory_Par_Locations(Get_Inventory_Par_LocationsInput request)
		{
			return base.Channel.Get_Inventory_Par_Locations(request);
		}

		public Get_Inventory_Par_Locations_ResponseType Get_Inventory_Par_Locations(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Par_Locations_RequestType Get_Inventory_Par_Locations_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Par_Locations(new Get_Inventory_Par_LocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Par_Locations_Request = Get_Inventory_Par_Locations_Request
			}).Get_Inventory_Par_Locations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Par_LocationsOutput> InventoryPort.Get_Inventory_Par_LocationsAsync(Get_Inventory_Par_LocationsInput request)
		{
			return base.Channel.Get_Inventory_Par_LocationsAsync(request);
		}

		public Task<Get_Inventory_Par_LocationsOutput> Get_Inventory_Par_LocationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Par_Locations_RequestType Get_Inventory_Par_Locations_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Par_LocationsAsync(new Get_Inventory_Par_LocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Par_Locations_Request = Get_Inventory_Par_Locations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_TransactionsOutput InventoryPort.Get_Inventory_Transactions(Get_Inventory_TransactionsInput request)
		{
			return base.Channel.Get_Inventory_Transactions(request);
		}

		public Get_Inventory_Transactions_ResponseType Get_Inventory_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Transactions_RequestType Get_Inventory_Transactions_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Transactions(new Get_Inventory_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Transactions_Request = Get_Inventory_Transactions_Request
			}).Get_Inventory_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_TransactionsOutput> InventoryPort.Get_Inventory_TransactionsAsync(Get_Inventory_TransactionsInput request)
		{
			return base.Channel.Get_Inventory_TransactionsAsync(request);
		}

		public Task<Get_Inventory_TransactionsOutput> Get_Inventory_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Transactions_RequestType Get_Inventory_Transactions_Request)
		{
			return ((InventoryPort)this).Get_Inventory_TransactionsAsync(new Get_Inventory_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Transactions_Request = Get_Inventory_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Adjustment_for_ReturnsOutput InventoryPort.Submit_Inventory_Adjustment_for_Returns(Submit_Inventory_Adjustment_for_ReturnsInput request)
		{
			return base.Channel.Submit_Inventory_Adjustment_for_Returns(request);
		}

		public Submit_Inventory_Adjustment_for_Returns_ResponseType Submit_Inventory_Adjustment_for_Returns(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Adjustment_for_Returns_RequestType Submit_Inventory_Adjustment_for_Returns_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Adjustment_for_Returns(new Submit_Inventory_Adjustment_for_ReturnsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Adjustment_for_Returns_Request = Submit_Inventory_Adjustment_for_Returns_Request
			}).Submit_Inventory_Adjustment_for_Returns_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Adjustment_for_ReturnsOutput> InventoryPort.Submit_Inventory_Adjustment_for_ReturnsAsync(Submit_Inventory_Adjustment_for_ReturnsInput request)
		{
			return base.Channel.Submit_Inventory_Adjustment_for_ReturnsAsync(request);
		}

		public Task<Submit_Inventory_Adjustment_for_ReturnsOutput> Submit_Inventory_Adjustment_for_ReturnsAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Adjustment_for_Returns_RequestType Submit_Inventory_Adjustment_for_Returns_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Adjustment_for_ReturnsAsync(new Submit_Inventory_Adjustment_for_ReturnsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Adjustment_for_Returns_Request = Submit_Inventory_Adjustment_for_Returns_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Count_SheetsOutput InventoryPort.Get_Inventory_Count_Sheets(Get_Inventory_Count_SheetsInput request)
		{
			return base.Channel.Get_Inventory_Count_Sheets(request);
		}

		public Get_Inventory_Count_Sheets_ResponseType Get_Inventory_Count_Sheets(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Count_Sheets_RequestType Get_Inventory_Count_Sheets_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Count_Sheets(new Get_Inventory_Count_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Count_Sheets_Request = Get_Inventory_Count_Sheets_Request
			}).Get_Inventory_Count_Sheets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Count_SheetsOutput> InventoryPort.Get_Inventory_Count_SheetsAsync(Get_Inventory_Count_SheetsInput request)
		{
			return base.Channel.Get_Inventory_Count_SheetsAsync(request);
		}

		public Task<Get_Inventory_Count_SheetsOutput> Get_Inventory_Count_SheetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Count_Sheets_RequestType Get_Inventory_Count_Sheets_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Count_SheetsAsync(new Get_Inventory_Count_SheetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Count_Sheets_Request = Get_Inventory_Count_Sheets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Return_OrderOutput InventoryPort.Submit_Inventory_Return_Order(Submit_Inventory_Return_OrderInput request)
		{
			return base.Channel.Submit_Inventory_Return_Order(request);
		}

		public Submit_Inventory_Return_Order_ResponseType Submit_Inventory_Return_Order(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Return_Order_RequestType Submit_Inventory_Return_Order_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Return_Order(new Submit_Inventory_Return_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Return_Order_Request = Submit_Inventory_Return_Order_Request
			}).Submit_Inventory_Return_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Return_OrderOutput> InventoryPort.Submit_Inventory_Return_OrderAsync(Submit_Inventory_Return_OrderInput request)
		{
			return base.Channel.Submit_Inventory_Return_OrderAsync(request);
		}

		public Task<Submit_Inventory_Return_OrderOutput> Submit_Inventory_Return_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Return_Order_RequestType Submit_Inventory_Return_Order_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Return_OrderAsync(new Submit_Inventory_Return_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Return_Order_Request = Submit_Inventory_Return_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Par_CountOutput InventoryPort.Submit_Inventory_Par_Count(Submit_Inventory_Par_CountInput request)
		{
			return base.Channel.Submit_Inventory_Par_Count(request);
		}

		public Submit_Inventory_Par_Count_ResponseType Submit_Inventory_Par_Count(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Par_Count_RequestType Submit_Inventory_Par_Count_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Par_Count(new Submit_Inventory_Par_CountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Par_Count_Request = Submit_Inventory_Par_Count_Request
			}).Submit_Inventory_Par_Count_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Par_CountOutput> InventoryPort.Submit_Inventory_Par_CountAsync(Submit_Inventory_Par_CountInput request)
		{
			return base.Channel.Submit_Inventory_Par_CountAsync(request);
		}

		public Task<Submit_Inventory_Par_CountOutput> Submit_Inventory_Par_CountAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Par_Count_RequestType Submit_Inventory_Par_Count_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Par_CountAsync(new Submit_Inventory_Par_CountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Par_Count_Request = Submit_Inventory_Par_Count_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Par_CountsOutput InventoryPort.Get_Inventory_Par_Counts(Get_Inventory_Par_CountsInput request)
		{
			return base.Channel.Get_Inventory_Par_Counts(request);
		}

		public Get_Inventory_Par_Counts_ResponseType Get_Inventory_Par_Counts(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Par_Counts_RequestType Get_Inventory_Par_Counts_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Par_Counts(new Get_Inventory_Par_CountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Par_Counts_Request = Get_Inventory_Par_Counts_Request
			}).Get_Inventory_Par_Counts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Par_CountsOutput> InventoryPort.Get_Inventory_Par_CountsAsync(Get_Inventory_Par_CountsInput request)
		{
			return base.Channel.Get_Inventory_Par_CountsAsync(request);
		}

		public Task<Get_Inventory_Par_CountsOutput> Get_Inventory_Par_CountsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Par_Counts_RequestType Get_Inventory_Par_Counts_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Par_CountsAsync(new Get_Inventory_Par_CountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Par_Counts_Request = Get_Inventory_Par_Counts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Count_InventoryOutput InventoryPort.Submit_Count_Inventory(Submit_Count_InventoryInput request)
		{
			return base.Channel.Submit_Count_Inventory(request);
		}

		public Submit_Count_Inventory_ResponseType Submit_Count_Inventory(Workday_Common_HeaderType Workday_Common_Header, Submit_Count_Inventory_RequestType Submit_Count_Inventory_Request)
		{
			return ((InventoryPort)this).Submit_Count_Inventory(new Submit_Count_InventoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Count_Inventory_Request = Submit_Count_Inventory_Request
			}).Submit_Count_Inventory_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Count_InventoryOutput> InventoryPort.Submit_Count_InventoryAsync(Submit_Count_InventoryInput request)
		{
			return base.Channel.Submit_Count_InventoryAsync(request);
		}

		public Task<Submit_Count_InventoryOutput> Submit_Count_InventoryAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Count_Inventory_RequestType Submit_Count_Inventory_Request)
		{
			return ((InventoryPort)this).Submit_Count_InventoryAsync(new Submit_Count_InventoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Count_Inventory_Request = Submit_Count_Inventory_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Inventory_Return_OrdersOutput InventoryPort.Get_Inventory_Return_Orders(Get_Inventory_Return_OrdersInput request)
		{
			return base.Channel.Get_Inventory_Return_Orders(request);
		}

		public Get_Inventory_Return_Orders_ResponseType Get_Inventory_Return_Orders(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Return_Orders_RequestType Get_Inventory_Return_Orders_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Return_Orders(new Get_Inventory_Return_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Return_Orders_Request = Get_Inventory_Return_Orders_Request
			}).Get_Inventory_Return_Orders_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Inventory_Return_OrdersOutput> InventoryPort.Get_Inventory_Return_OrdersAsync(Get_Inventory_Return_OrdersInput request)
		{
			return base.Channel.Get_Inventory_Return_OrdersAsync(request);
		}

		public Task<Get_Inventory_Return_OrdersOutput> Get_Inventory_Return_OrdersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Return_Orders_RequestType Get_Inventory_Return_Orders_Request)
		{
			return ((InventoryPort)this).Get_Inventory_Return_OrdersAsync(new Get_Inventory_Return_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Inventory_Return_Orders_Request = Get_Inventory_Return_Orders_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Item_LotOutput InventoryPort.Put_Item_Lot(Put_Item_LotInput request)
		{
			return base.Channel.Put_Item_Lot(request);
		}

		public Put_Item_Lot_ResponseType Put_Item_Lot(Workday_Common_HeaderType Workday_Common_Header, Put_Item_Lot_RequestType Put_Item_Lot_Request)
		{
			return ((InventoryPort)this).Put_Item_Lot(new Put_Item_LotInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Item_Lot_Request = Put_Item_Lot_Request
			}).Put_Item_Lot_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Item_LotOutput> InventoryPort.Put_Item_LotAsync(Put_Item_LotInput request)
		{
			return base.Channel.Put_Item_LotAsync(request);
		}

		public Task<Put_Item_LotOutput> Put_Item_LotAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Item_Lot_RequestType Put_Item_Lot_Request)
		{
			return ((InventoryPort)this).Put_Item_LotAsync(new Put_Item_LotInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Item_Lot_Request = Put_Item_Lot_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Item_LotsOutput InventoryPort.Get_Item_Lots(Get_Item_LotsInput request)
		{
			return base.Channel.Get_Item_Lots(request);
		}

		public Get_Item_Lots_ResponseType Get_Item_Lots(Workday_Common_HeaderType Workday_Common_Header, Get_Item_Lots_RequestType Get_Item_Lots_Request)
		{
			return ((InventoryPort)this).Get_Item_Lots(new Get_Item_LotsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Item_Lots_Request = Get_Item_Lots_Request
			}).Get_Item_Lots_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Item_LotsOutput> InventoryPort.Get_Item_LotsAsync(Get_Item_LotsInput request)
		{
			return base.Channel.Get_Item_LotsAsync(request);
		}

		public Task<Get_Item_LotsOutput> Get_Item_LotsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Item_Lots_RequestType Get_Item_Lots_Request)
		{
			return ((InventoryPort)this).Get_Item_LotsAsync(new Get_Item_LotsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Item_Lots_Request = Get_Item_Lots_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ManufacturerOutput InventoryPort.Put_Manufacturer(Put_ManufacturerInput request)
		{
			return base.Channel.Put_Manufacturer(request);
		}

		public Put_Manufacturer_ResponseType Put_Manufacturer(Workday_Common_HeaderType Workday_Common_Header, Put_Manufacturer_RequestType Put_Manufacturer_Request)
		{
			return ((InventoryPort)this).Put_Manufacturer(new Put_ManufacturerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Manufacturer_Request = Put_Manufacturer_Request
			}).Put_Manufacturer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ManufacturerOutput> InventoryPort.Put_ManufacturerAsync(Put_ManufacturerInput request)
		{
			return base.Channel.Put_ManufacturerAsync(request);
		}

		public Task<Put_ManufacturerOutput> Put_ManufacturerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Manufacturer_RequestType Put_Manufacturer_Request)
		{
			return ((InventoryPort)this).Put_ManufacturerAsync(new Put_ManufacturerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Manufacturer_Request = Put_Manufacturer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ManufacturersOutput InventoryPort.Get_Manufacturers(Get_ManufacturersInput request)
		{
			return base.Channel.Get_Manufacturers(request);
		}

		public Get_Manufacturers_ResponseType Get_Manufacturers(Workday_Common_HeaderType Workday_Common_Header, Get_Manufacturers_RequestType Get_Manufacturers_Request)
		{
			return ((InventoryPort)this).Get_Manufacturers(new Get_ManufacturersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Manufacturers_Request = Get_Manufacturers_Request
			}).Get_Manufacturers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ManufacturersOutput> InventoryPort.Get_ManufacturersAsync(Get_ManufacturersInput request)
		{
			return base.Channel.Get_ManufacturersAsync(request);
		}

		public Task<Get_ManufacturersOutput> Get_ManufacturersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Manufacturers_RequestType Get_Manufacturers_Request)
		{
			return ((InventoryPort)this).Get_ManufacturersAsync(new Get_ManufacturersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Manufacturers_Request = Get_Manufacturers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Inventory_Unit_of_Measure_ConversionOutput InventoryPort.Submit_Inventory_Unit_of_Measure_Conversion(Submit_Inventory_Unit_of_Measure_ConversionInput request)
		{
			return base.Channel.Submit_Inventory_Unit_of_Measure_Conversion(request);
		}

		public Submit_Inventory_Unit_of_Measure_Conversion_ResponseType Submit_Inventory_Unit_of_Measure_Conversion(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Unit_of_Measure_Conversion_RequestType Submit_Inventory_Unit_of_Measure_Conversion_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Unit_of_Measure_Conversion(new Submit_Inventory_Unit_of_Measure_ConversionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Unit_of_Measure_Conversion_Request = Submit_Inventory_Unit_of_Measure_Conversion_Request
			}).Submit_Inventory_Unit_of_Measure_Conversion_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Inventory_Unit_of_Measure_ConversionOutput> InventoryPort.Submit_Inventory_Unit_of_Measure_ConversionAsync(Submit_Inventory_Unit_of_Measure_ConversionInput request)
		{
			return base.Channel.Submit_Inventory_Unit_of_Measure_ConversionAsync(request);
		}

		public Task<Submit_Inventory_Unit_of_Measure_ConversionOutput> Submit_Inventory_Unit_of_Measure_ConversionAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Inventory_Unit_of_Measure_Conversion_RequestType Submit_Inventory_Unit_of_Measure_Conversion_Request)
		{
			return ((InventoryPort)this).Submit_Inventory_Unit_of_Measure_ConversionAsync(new Submit_Inventory_Unit_of_Measure_ConversionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Inventory_Unit_of_Measure_Conversion_Request = Submit_Inventory_Unit_of_Measure_Conversion_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Goods_Delivery_TicketsOutput InventoryPort.Get_Goods_Delivery_Tickets(Get_Goods_Delivery_TicketsInput request)
		{
			return base.Channel.Get_Goods_Delivery_Tickets(request);
		}

		public Get_Goods_Delivery_Tickets_ResponseType Get_Goods_Delivery_Tickets(Workday_Common_HeaderType Workday_Common_Header, Get_Goods_Delivery_Tickets_RequestType Get_Goods_Delivery_Tickets_Request)
		{
			return ((InventoryPort)this).Get_Goods_Delivery_Tickets(new Get_Goods_Delivery_TicketsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Goods_Delivery_Tickets_Request = Get_Goods_Delivery_Tickets_Request
			}).Get_Goods_Delivery_Tickets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Goods_Delivery_TicketsOutput> InventoryPort.Get_Goods_Delivery_TicketsAsync(Get_Goods_Delivery_TicketsInput request)
		{
			return base.Channel.Get_Goods_Delivery_TicketsAsync(request);
		}

		public Task<Get_Goods_Delivery_TicketsOutput> Get_Goods_Delivery_TicketsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Goods_Delivery_Tickets_RequestType Get_Goods_Delivery_Tickets_Request)
		{
			return ((InventoryPort)this).Get_Goods_Delivery_TicketsAsync(new Get_Goods_Delivery_TicketsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Goods_Delivery_Tickets_Request = Get_Goods_Delivery_Tickets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Ad_Hoc_Goods_DeliveryOutput InventoryPort.Submit_Ad_Hoc_Goods_Delivery(Submit_Ad_Hoc_Goods_DeliveryInput request)
		{
			return base.Channel.Submit_Ad_Hoc_Goods_Delivery(request);
		}

		public Submit_Ad_Hoc_Goods_Delivery_ResponseType Submit_Ad_Hoc_Goods_Delivery(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_Hoc_Goods_Delivery_RequestType Submit_Ad_Hoc_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Submit_Ad_Hoc_Goods_Delivery(new Submit_Ad_Hoc_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_Hoc_Goods_Delivery_Request = Submit_Ad_Hoc_Goods_Delivery_Request
			}).Submit_Ad_Hoc_Goods_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Ad_Hoc_Goods_DeliveryOutput> InventoryPort.Submit_Ad_Hoc_Goods_DeliveryAsync(Submit_Ad_Hoc_Goods_DeliveryInput request)
		{
			return base.Channel.Submit_Ad_Hoc_Goods_DeliveryAsync(request);
		}

		public Task<Submit_Ad_Hoc_Goods_DeliveryOutput> Submit_Ad_Hoc_Goods_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_Hoc_Goods_Delivery_RequestType Submit_Ad_Hoc_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Submit_Ad_Hoc_Goods_DeliveryAsync(new Submit_Ad_Hoc_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_Hoc_Goods_Delivery_Request = Submit_Ad_Hoc_Goods_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Goods_DeliveryOutput InventoryPort.Cancel_Goods_Delivery(Cancel_Goods_DeliveryInput request)
		{
			return base.Channel.Cancel_Goods_Delivery(request);
		}

		public Cancel_Goods_Delivery_ResponseType Cancel_Goods_Delivery(Workday_Common_HeaderType Workday_Common_Header, Cancel_Goods_Delivery_RequestType Cancel_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Cancel_Goods_Delivery(new Cancel_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Goods_Delivery_Request = Cancel_Goods_Delivery_Request
			}).Cancel_Goods_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Goods_DeliveryOutput> InventoryPort.Cancel_Goods_DeliveryAsync(Cancel_Goods_DeliveryInput request)
		{
			return base.Channel.Cancel_Goods_DeliveryAsync(request);
		}

		public Task<Cancel_Goods_DeliveryOutput> Cancel_Goods_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Goods_Delivery_RequestType Cancel_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Cancel_Goods_DeliveryAsync(new Cancel_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Goods_Delivery_Request = Cancel_Goods_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Close_Goods_DeliveryOutput InventoryPort.Close_Goods_Delivery(Close_Goods_DeliveryInput request)
		{
			return base.Channel.Close_Goods_Delivery(request);
		}

		public Close_Goods_Delivery_ResponseType Close_Goods_Delivery(Workday_Common_HeaderType Workday_Common_Header, Close_Goods_Delivery_RequestType Close_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Close_Goods_Delivery(new Close_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Goods_Delivery_Request = Close_Goods_Delivery_Request
			}).Close_Goods_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Close_Goods_DeliveryOutput> InventoryPort.Close_Goods_DeliveryAsync(Close_Goods_DeliveryInput request)
		{
			return base.Channel.Close_Goods_DeliveryAsync(request);
		}

		public Task<Close_Goods_DeliveryOutput> Close_Goods_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Close_Goods_Delivery_RequestType Close_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Close_Goods_DeliveryAsync(new Close_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Goods_Delivery_Request = Close_Goods_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Unreserve_InventoryOutput InventoryPort.Submit_Unreserve_Inventory(Submit_Unreserve_InventoryInput request)
		{
			return base.Channel.Submit_Unreserve_Inventory(request);
		}

		public Submit_Unreserve_Inventory_ResponseType Submit_Unreserve_Inventory(Workday_Common_HeaderType Workday_Common_Header, Submit_Unreserve_Inventory_RequestType Submit_Unreserve_Inventory_Request)
		{
			return ((InventoryPort)this).Submit_Unreserve_Inventory(new Submit_Unreserve_InventoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Unreserve_Inventory_Request = Submit_Unreserve_Inventory_Request
			}).Submit_Unreserve_Inventory_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Unreserve_InventoryOutput> InventoryPort.Submit_Unreserve_InventoryAsync(Submit_Unreserve_InventoryInput request)
		{
			return base.Channel.Submit_Unreserve_InventoryAsync(request);
		}

		public Task<Submit_Unreserve_InventoryOutput> Submit_Unreserve_InventoryAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Unreserve_Inventory_RequestType Submit_Unreserve_Inventory_Request)
		{
			return ((InventoryPort)this).Submit_Unreserve_InventoryAsync(new Submit_Unreserve_InventoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Unreserve_Inventory_Request = Submit_Unreserve_Inventory_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Goods_Delivery_RulesOutput InventoryPort.Get_Goods_Delivery_Rules(Get_Goods_Delivery_RulesInput request)
		{
			return base.Channel.Get_Goods_Delivery_Rules(request);
		}

		public Get_Goods_Delivery_Rules_ResponseType Get_Goods_Delivery_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Goods_Delivery_Rules_RequestType Get_Goods_Delivery_Rules_Request)
		{
			return ((InventoryPort)this).Get_Goods_Delivery_Rules(new Get_Goods_Delivery_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Goods_Delivery_Rules_Request = Get_Goods_Delivery_Rules_Request
			}).Get_Goods_Delivery_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Goods_Delivery_RulesOutput> InventoryPort.Get_Goods_Delivery_RulesAsync(Get_Goods_Delivery_RulesInput request)
		{
			return base.Channel.Get_Goods_Delivery_RulesAsync(request);
		}

		public Task<Get_Goods_Delivery_RulesOutput> Get_Goods_Delivery_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Goods_Delivery_Rules_RequestType Get_Goods_Delivery_Rules_Request)
		{
			return ((InventoryPort)this).Get_Goods_Delivery_RulesAsync(new Get_Goods_Delivery_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Goods_Delivery_Rules_Request = Get_Goods_Delivery_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Goods_Delivery_RuleOutput InventoryPort.Put_Goods_Delivery_Rule(Put_Goods_Delivery_RuleInput request)
		{
			return base.Channel.Put_Goods_Delivery_Rule(request);
		}

		public Put_Goods_Delivery_Rule_ResponseType Put_Goods_Delivery_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Goods_Delivery_Rule_RequestType Put_Goods_Delivery_Rule_Request)
		{
			return ((InventoryPort)this).Put_Goods_Delivery_Rule(new Put_Goods_Delivery_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Goods_Delivery_Rule_Request = Put_Goods_Delivery_Rule_Request
			}).Put_Goods_Delivery_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Goods_Delivery_RuleOutput> InventoryPort.Put_Goods_Delivery_RuleAsync(Put_Goods_Delivery_RuleInput request)
		{
			return base.Channel.Put_Goods_Delivery_RuleAsync(request);
		}

		public Task<Put_Goods_Delivery_RuleOutput> Put_Goods_Delivery_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Goods_Delivery_Rule_RequestType Put_Goods_Delivery_Rule_Request)
		{
			return ((InventoryPort)this).Put_Goods_Delivery_RuleAsync(new Put_Goods_Delivery_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Goods_Delivery_Rule_Request = Put_Goods_Delivery_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Capture_Goods_DeliveryOutput InventoryPort.Submit_Capture_Goods_Delivery(Submit_Capture_Goods_DeliveryInput request)
		{
			return base.Channel.Submit_Capture_Goods_Delivery(request);
		}

		public Submit_Capture_Goods_Delivery_ResponseType Submit_Capture_Goods_Delivery(Workday_Common_HeaderType Workday_Common_Header, Submit_Capture_Goods_Delivery_RequestType Submit_Capture_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Submit_Capture_Goods_Delivery(new Submit_Capture_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Capture_Goods_Delivery_Request = Submit_Capture_Goods_Delivery_Request
			}).Submit_Capture_Goods_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Capture_Goods_DeliveryOutput> InventoryPort.Submit_Capture_Goods_DeliveryAsync(Submit_Capture_Goods_DeliveryInput request)
		{
			return base.Channel.Submit_Capture_Goods_DeliveryAsync(request);
		}

		public Task<Submit_Capture_Goods_DeliveryOutput> Submit_Capture_Goods_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Capture_Goods_Delivery_RequestType Submit_Capture_Goods_Delivery_Request)
		{
			return ((InventoryPort)this).Submit_Capture_Goods_DeliveryAsync(new Submit_Capture_Goods_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Capture_Goods_Delivery_Request = Submit_Capture_Goods_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Capture_Goods_Delivery_RunsOutput InventoryPort.Get_Capture_Goods_Delivery_Runs(Get_Capture_Goods_Delivery_RunsInput request)
		{
			return base.Channel.Get_Capture_Goods_Delivery_Runs(request);
		}

		public Get_Capture_Goods_Delivery_Runs_ResponseType Get_Capture_Goods_Delivery_Runs(Workday_Common_HeaderType Workday_Common_Header, Get_Capture_Goods_Delivery_Runs_RequestType Get_Capture_Goods_Delivery_Runs_Request)
		{
			return ((InventoryPort)this).Get_Capture_Goods_Delivery_Runs(new Get_Capture_Goods_Delivery_RunsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Capture_Goods_Delivery_Runs_Request = Get_Capture_Goods_Delivery_Runs_Request
			}).Get_Capture_Goods_Delivery_Runs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Capture_Goods_Delivery_RunsOutput> InventoryPort.Get_Capture_Goods_Delivery_RunsAsync(Get_Capture_Goods_Delivery_RunsInput request)
		{
			return base.Channel.Get_Capture_Goods_Delivery_RunsAsync(request);
		}

		public Task<Get_Capture_Goods_Delivery_RunsOutput> Get_Capture_Goods_Delivery_RunsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Capture_Goods_Delivery_Runs_RequestType Get_Capture_Goods_Delivery_Runs_Request)
		{
			return ((InventoryPort)this).Get_Capture_Goods_Delivery_RunsAsync(new Get_Capture_Goods_Delivery_RunsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Capture_Goods_Delivery_Runs_Request = Get_Capture_Goods_Delivery_Runs_Request
			});
		}
	}
}
