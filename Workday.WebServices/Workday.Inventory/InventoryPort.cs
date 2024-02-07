using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Inventory", ConfigurationName = "InventoryService.InventoryPort")]
	public interface InventoryPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Quick_IssueOutput Submit_Inventory_Quick_Issue(Submit_Inventory_Quick_IssueInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Quick_IssueOutput> Submit_Inventory_Quick_IssueAsync(Submit_Inventory_Quick_IssueInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_MoveOutput Submit_Inventory_Move(Submit_Inventory_MoveInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_MoveOutput> Submit_Inventory_MoveAsync(Submit_Inventory_MoveInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_AdjustmentOutput Submit_Inventory_Adjustment(Submit_Inventory_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_AdjustmentOutput> Submit_Inventory_AdjustmentAsync(Submit_Inventory_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Location_AttributesOutput Get_Inventory_Location_Attributes(Get_Inventory_Location_AttributesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Location_AttributesOutput> Get_Inventory_Location_AttributesAsync(Get_Inventory_Location_AttributesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Inventory_Location_AttributesOutput Put_Inventory_Location_Attributes(Put_Inventory_Location_AttributesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Inventory_Location_AttributesOutput> Put_Inventory_Location_AttributesAsync(Put_Inventory_Location_AttributesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Ad_Hoc_PutAwayOutput Submit_Ad_Hoc_PutAway(Submit_Ad_Hoc_PutAwayInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Ad_Hoc_PutAwayOutput> Submit_Ad_Hoc_PutAwayAsync(Submit_Ad_Hoc_PutAwayInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_PutAwayOutput Submit_PutAway(Submit_PutAwayInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_PutAwayOutput> Submit_PutAwayAsync(Submit_PutAwayInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Cost_AdjustmentOutput Submit_Inventory_Cost_Adjustment(Submit_Inventory_Cost_AdjustmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Cost_AdjustmentOutput> Submit_Inventory_Cost_AdjustmentAsync(Submit_Inventory_Cost_AdjustmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Stock_RequestOutput Submit_Inventory_Stock_Request(Submit_Inventory_Stock_RequestInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Stock_RequestOutput> Submit_Inventory_Stock_RequestAsync(Submit_Inventory_Stock_RequestInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Stock_RequestOutput Get_Inventory_Stock_Request(Get_Inventory_Stock_RequestInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Stock_RequestOutput> Get_Inventory_Stock_RequestAsync(Get_Inventory_Stock_RequestInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Picking_ListsOutput Get_Inventory_Picking_Lists(Get_Inventory_Picking_ListsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Picking_ListsOutput> Get_Inventory_Picking_ListsAsync(Get_Inventory_Picking_ListsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_PickOutput Submit_Inventory_Pick(Submit_Inventory_PickInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_PickOutput> Submit_Inventory_PickAsync(Submit_Inventory_PickInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_ShipmentsOutput Get_Inventory_Shipments(Get_Inventory_ShipmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_ShipmentsOutput> Get_Inventory_ShipmentsAsync(Get_Inventory_ShipmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_ShipmentOutput Submit_Inventory_Shipment(Submit_Inventory_ShipmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_ShipmentOutput> Submit_Inventory_ShipmentAsync(Submit_Inventory_ShipmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_BalanceOutput Get_Inventory_Balance(Get_Inventory_BalanceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_BalanceOutput> Get_Inventory_BalanceAsync(Get_Inventory_BalanceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Inventory_Par_LocationOutput Put_Inventory_Par_Location(Put_Inventory_Par_LocationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Inventory_Par_LocationOutput> Put_Inventory_Par_LocationAsync(Put_Inventory_Par_LocationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Par_LocationsOutput Get_Inventory_Par_Locations(Get_Inventory_Par_LocationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Par_LocationsOutput> Get_Inventory_Par_LocationsAsync(Get_Inventory_Par_LocationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_TransactionsOutput Get_Inventory_Transactions(Get_Inventory_TransactionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_TransactionsOutput> Get_Inventory_TransactionsAsync(Get_Inventory_TransactionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Adjustment_for_ReturnsOutput Submit_Inventory_Adjustment_for_Returns(Submit_Inventory_Adjustment_for_ReturnsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Adjustment_for_ReturnsOutput> Submit_Inventory_Adjustment_for_ReturnsAsync(Submit_Inventory_Adjustment_for_ReturnsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Count_SheetsOutput Get_Inventory_Count_Sheets(Get_Inventory_Count_SheetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Count_SheetsOutput> Get_Inventory_Count_SheetsAsync(Get_Inventory_Count_SheetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Return_OrderOutput Submit_Inventory_Return_Order(Submit_Inventory_Return_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Return_OrderOutput> Submit_Inventory_Return_OrderAsync(Submit_Inventory_Return_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Par_CountOutput Submit_Inventory_Par_Count(Submit_Inventory_Par_CountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Par_CountOutput> Submit_Inventory_Par_CountAsync(Submit_Inventory_Par_CountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Par_CountsOutput Get_Inventory_Par_Counts(Get_Inventory_Par_CountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Par_CountsOutput> Get_Inventory_Par_CountsAsync(Get_Inventory_Par_CountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Count_InventoryOutput Submit_Count_Inventory(Submit_Count_InventoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Count_InventoryOutput> Submit_Count_InventoryAsync(Submit_Count_InventoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Inventory_Return_OrdersOutput Get_Inventory_Return_Orders(Get_Inventory_Return_OrdersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Inventory_Return_OrdersOutput> Get_Inventory_Return_OrdersAsync(Get_Inventory_Return_OrdersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Item_LotOutput Put_Item_Lot(Put_Item_LotInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Item_LotOutput> Put_Item_LotAsync(Put_Item_LotInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Item_LotsOutput Get_Item_Lots(Get_Item_LotsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Item_LotsOutput> Get_Item_LotsAsync(Get_Item_LotsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ManufacturerOutput Put_Manufacturer(Put_ManufacturerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ManufacturerOutput> Put_ManufacturerAsync(Put_ManufacturerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ManufacturersOutput Get_Manufacturers(Get_ManufacturersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ManufacturersOutput> Get_ManufacturersAsync(Get_ManufacturersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Inventory_Unit_of_Measure_ConversionOutput Submit_Inventory_Unit_of_Measure_Conversion(Submit_Inventory_Unit_of_Measure_ConversionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Inventory_Unit_of_Measure_ConversionOutput> Submit_Inventory_Unit_of_Measure_ConversionAsync(Submit_Inventory_Unit_of_Measure_ConversionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Goods_Delivery_TicketsOutput Get_Goods_Delivery_Tickets(Get_Goods_Delivery_TicketsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Goods_Delivery_TicketsOutput> Get_Goods_Delivery_TicketsAsync(Get_Goods_Delivery_TicketsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Ad_Hoc_Goods_DeliveryOutput Submit_Ad_Hoc_Goods_Delivery(Submit_Ad_Hoc_Goods_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Ad_Hoc_Goods_DeliveryOutput> Submit_Ad_Hoc_Goods_DeliveryAsync(Submit_Ad_Hoc_Goods_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Cancel_Goods_DeliveryOutput Cancel_Goods_Delivery(Cancel_Goods_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Cancel_Goods_DeliveryOutput> Cancel_Goods_DeliveryAsync(Cancel_Goods_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Close_Goods_DeliveryOutput Close_Goods_Delivery(Close_Goods_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Close_Goods_DeliveryOutput> Close_Goods_DeliveryAsync(Close_Goods_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Unreserve_InventoryOutput Submit_Unreserve_Inventory(Submit_Unreserve_InventoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Unreserve_InventoryOutput> Submit_Unreserve_InventoryAsync(Submit_Unreserve_InventoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Goods_Delivery_RulesOutput Get_Goods_Delivery_Rules(Get_Goods_Delivery_RulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Goods_Delivery_RulesOutput> Get_Goods_Delivery_RulesAsync(Get_Goods_Delivery_RulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Goods_Delivery_RuleOutput Put_Goods_Delivery_Rule(Put_Goods_Delivery_RuleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Goods_Delivery_RuleOutput> Put_Goods_Delivery_RuleAsync(Put_Goods_Delivery_RuleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Capture_Goods_DeliveryOutput Submit_Capture_Goods_Delivery(Submit_Capture_Goods_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Capture_Goods_DeliveryOutput> Submit_Capture_Goods_DeliveryAsync(Submit_Capture_Goods_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Capture_Goods_Delivery_RunsOutput Get_Capture_Goods_Delivery_Runs(Get_Capture_Goods_Delivery_RunsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Capture_Goods_Delivery_RunsOutput> Get_Capture_Goods_Delivery_RunsAsync(Get_Capture_Goods_Delivery_RunsInput request);
	}
}
