using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Payroll", ConfigurationName = "Payroll.PayrollPort")]
	public interface PayrollPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_ResultsOutput Get_Payroll_Results(Get_Payroll_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_ResultsOutput> Get_Payroll_ResultsAsync(Get_Payroll_ResultsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_BalancesOutput Get_Payroll_Balances(Get_Payroll_BalancesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_BalancesOutput> Get_Payroll_BalancesAsync(Get_Payroll_BalancesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Offcycle_PaymentOutput Put_Payroll_Offcycle_Payment(Put_Payroll_Offcycle_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Offcycle_PaymentOutput> Put_Payroll_Offcycle_PaymentAsync(Put_Payroll_Offcycle_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_History_PaymentOutput Put_Payroll_History_Payment(Put_Payroll_History_PaymentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_History_PaymentOutput> Put_Payroll_History_PaymentAsync(Put_Payroll_History_PaymentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Payroll_InputOutput Submit_Payroll_Input(Submit_Payroll_InputInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Payroll_InputOutput> Submit_Payroll_InputAsync(Submit_Payroll_InputInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_History_PaymentsOutput Get_Payroll_History_Payments(Get_Payroll_History_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_History_PaymentsOutput> Get_Payroll_History_PaymentsAsync(Get_Payroll_History_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Period_SchedulesOutput Get_Period_Schedules(Get_Period_SchedulesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Period_SchedulesOutput> Get_Period_SchedulesAsync(Get_Period_SchedulesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Period_ScheduleOutput Put_Period_Schedule(Put_Period_ScheduleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Period_ScheduleOutput> Put_Period_ScheduleAsync(Put_Period_ScheduleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Submit_Payroll_InputsOutput Get_Submit_Payroll_Inputs(Get_Submit_Payroll_InputsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Submit_Payroll_InputsOutput> Get_Submit_Payroll_InputsAsync(Get_Submit_Payroll_InputsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_Costing_AllocationOutput Assign_Costing_Allocation(Assign_Costing_AllocationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_Costing_AllocationOutput> Assign_Costing_AllocationAsync(Assign_Costing_AllocationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_PayslipsOutput Get_Payroll_Payslips(Get_Payroll_PayslipsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_PayslipsOutput> Get_Payroll_PayslipsAsync(Get_Payroll_PayslipsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Quarterly_Worker_Tax_Filing_DataOutput Get_Quarterly_Worker_Tax_Filing_Data(Get_Quarterly_Worker_Tax_Filing_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Quarterly_Worker_Tax_Filing_DataOutput> Get_Quarterly_Worker_Tax_Filing_DataAsync(Get_Quarterly_Worker_Tax_Filing_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_FICAOutput Put_Payroll_Payee_FICA(Put_Payroll_Payee_FICAInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_FICAOutput> Put_Payroll_Payee_FICAAsync(Put_Payroll_Payee_FICAInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Periodic_Worker_Tax_Filing_DataOutput Get_Periodic_Worker_Tax_Filing_Data(Get_Periodic_Worker_Tax_Filing_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Periodic_Worker_Tax_Filing_DataOutput> Get_Periodic_Worker_Tax_Filing_DataAsync(Get_Periodic_Worker_Tax_Filing_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Periodic_Company_Tax_Filing_DataOutput Get_Periodic_Company_Tax_Filing_Data(Get_Periodic_Company_Tax_Filing_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Periodic_Company_Tax_Filing_DataOutput> Get_Periodic_Company_Tax_Filing_DataAsync(Get_Periodic_Company_Tax_Filing_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_PT1sOutput Get_Payroll_Payee_PT1s(Get_Payroll_Payee_PT1sInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_PT1sOutput> Get_Payroll_Payee_PT1sAsync(Get_Payroll_Payee_PT1sInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_PT1Output Put_Payroll_Payee_PT1(Put_Payroll_Payee_PT1Input request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_PT1Output> Put_Payroll_Payee_PT1Async(Put_Payroll_Payee_PT1Input request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_FICAsOutput Get_Payroll_Payee_FICAs(Get_Payroll_Payee_FICAsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_FICAsOutput> Get_Payroll_Payee_FICAsAsync(Get_Payroll_Payee_FICAsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Offcycle_PaymentsOutput Get_Payroll_Offcycle_Payments(Get_Payroll_Offcycle_PaymentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Offcycle_PaymentsOutput> Get_Payroll_Offcycle_PaymentsAsync(Get_Payroll_Offcycle_PaymentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Company_Payment_DatesOutput Get_Company_Payment_Dates(Get_Company_Payment_DatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Company_Payment_DatesOutput> Get_Company_Payment_DatesAsync(Get_Company_Payment_DatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_TD1sOutput Get_Payroll_Payee_TD1s(Get_Payroll_Payee_TD1sInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_TD1sOutput> Get_Payroll_Payee_TD1sAsync(Get_Payroll_Payee_TD1sInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_TD1Output Put_Payroll_Payee_TD1(Put_Payroll_Payee_TD1Input request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_TD1Output> Put_Payroll_Payee_TD1Async(Put_Payroll_Payee_TD1Input request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Canadian_Record_of_Employment_DataOutput Get_Canadian_Record_of_Employment_Data(Get_Canadian_Record_of_Employment_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Canadian_Record_of_Employment_DataOutput> Get_Canadian_Record_of_Employment_DataAsync(Get_Canadian_Record_of_Employment_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ROE_History_DataOutput Put_ROE_History_Data(Put_ROE_History_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ROE_History_DataOutput> Put_ROE_History_DataAsync(Put_ROE_History_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ROE_History_DataOutput Get_ROE_History_Data(Get_ROE_History_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ROE_History_DataOutput> Get_ROE_History_DataAsync(Get_ROE_History_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Canadian_Record_of_Employment_DataOutput Put_Canadian_Record_of_Employment_Data(Put_Canadian_Record_of_Employment_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Canadian_Record_of_Employment_DataOutput> Put_Canadian_Record_of_Employment_DataAsync(Put_Canadian_Record_of_Employment_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Federal_W4_Tax_ElectionOutput Get_Payroll_Federal_W4_Tax_Election(Get_Payroll_Federal_W4_Tax_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Federal_W4_Tax_ElectionOutput> Get_Payroll_Federal_W4_Tax_ElectionAsync(Get_Payroll_Federal_W4_Tax_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Federal_W4_Tax_ElectionOutput Put_Payroll_Federal_W4_Tax_Election(Put_Payroll_Federal_W4_Tax_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Federal_W4_Tax_ElectionOutput> Put_Payroll_Federal_W4_Tax_ElectionAsync(Put_Payroll_Federal_W4_Tax_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Worker_Tax_TreatyOutput Put_Payroll_Worker_Tax_Treaty(Put_Payroll_Worker_Tax_TreatyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Worker_Tax_TreatyOutput> Put_Payroll_Worker_Tax_TreatyAsync(Put_Payroll_Worker_Tax_TreatyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Worker_Tax_TreatiesOutput Get_Payroll_Worker_Tax_Treaties(Get_Payroll_Worker_Tax_TreatiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Worker_Tax_TreatiesOutput> Get_Payroll_Worker_Tax_TreatiesAsync(Get_Payroll_Worker_Tax_TreatiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Involuntary_Withholding_OrdersOutput Get_Payroll_Involuntary_Withholding_Orders(Get_Payroll_Involuntary_Withholding_OrdersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Involuntary_Withholding_OrdersOutput> Get_Payroll_Involuntary_Withholding_OrdersAsync(Get_Payroll_Involuntary_Withholding_OrdersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Involuntary_Withholding_OrderOutput Put_Payroll_Involuntary_Withholding_Order(Put_Payroll_Involuntary_Withholding_OrderInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Involuntary_Withholding_OrderOutput> Put_Payroll_Involuntary_Withholding_OrderAsync(Put_Payroll_Involuntary_Withholding_OrderInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_No_Retro_Processing_Prior_ToOutput Change_No_Retro_Processing_Prior_To(Change_No_Retro_Processing_Prior_ToInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_No_Retro_Processing_Prior_ToOutput> Change_No_Retro_Processing_Prior_ToAsync(Change_No_Retro_Processing_Prior_ToInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Multiple_Worksite_ReportOutput Get_Multiple_Worksite_Report(Get_Multiple_Worksite_ReportInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Multiple_Worksite_ReportOutput> Get_Multiple_Worksite_ReportAsync(Get_Multiple_Worksite_ReportInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Limit_OverridesOutput Get_Payroll_Limit_Overrides(Get_Payroll_Limit_OverridesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Limit_OverridesOutput> Get_Payroll_Limit_OverridesAsync(Get_Payroll_Limit_OverridesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Limit_OverrideOutput Put_Payroll_Limit_Override(Put_Payroll_Limit_OverrideInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Limit_OverrideOutput> Put_Payroll_Limit_OverrideAsync(Put_Payroll_Limit_OverrideInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_Costing_AllocationsOutput Get_Worker_Costing_Allocations(Get_Worker_Costing_AllocationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_Costing_AllocationsOutput> Get_Worker_Costing_AllocationsAsync(Get_Worker_Costing_AllocationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers(Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput> Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersAsync(Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput Put_Payroll_Payee_RPP_or_DPSP_Registration_Number(Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput> Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberAsync(Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput Get_Payroll_USA_State_and_Local_Tax_Elections(Get_Payroll_USA_State_and_Local_Tax_ElectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput> Get_Payroll_USA_State_and_Local_Tax_ElectionsAsync(Get_Payroll_USA_State_and_Local_Tax_ElectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_USA_State_and_Local_Tax_ElectionOutput Put_Payroll_USA_State_and_Local_Tax_Election(Put_Payroll_USA_State_and_Local_Tax_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_USA_State_and_Local_Tax_ElectionOutput> Put_Payroll_USA_State_and_Local_Tax_ElectionAsync(Put_Payroll_USA_State_and_Local_Tax_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput> Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput> Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Monthly_Worker_Tax_Filing_DataOutput Get_Monthly_Worker_Tax_Filing_Data(Get_Monthly_Worker_Tax_Filing_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Monthly_Worker_Tax_Filing_DataOutput> Get_Monthly_Worker_Tax_Filing_DataAsync(Get_Monthly_Worker_Tax_Filing_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Successor_EmployersOutput Get_Successor_Employers(Get_Successor_EmployersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Successor_EmployersOutput> Get_Successor_EmployersAsync(Get_Successor_EmployersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Successor_EmployerOutput Put_Successor_Employer(Put_Successor_EmployerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Successor_EmployerOutput> Put_Successor_EmployerAsync(Put_Successor_EmployerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_ROE_Prior_Period_History_ResultsOutput Put_Payroll_ROE_Prior_Period_History_Results(Put_Payroll_ROE_Prior_Period_History_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_ROE_Prior_Period_History_ResultsOutput> Put_Payroll_ROE_Prior_Period_History_ResultsAsync(Put_Payroll_ROE_Prior_Period_History_ResultsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_FUTAOutput Put_Payroll_Payee_FUTA(Put_Payroll_Payee_FUTAInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_FUTAOutput> Put_Payroll_Payee_FUTAAsync(Put_Payroll_Payee_FUTAInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_FUTAsOutput Get_Payroll_Payee_FUTAs(Get_Payroll_Payee_FUTAsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_FUTAsOutput> Get_Payroll_Payee_FUTAsAsync(Get_Payroll_Payee_FUTAsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Deduction_RecipientsOutput Get_Payroll_Deduction_Recipients(Get_Payroll_Deduction_RecipientsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Deduction_RecipientsOutput> Get_Payroll_Deduction_RecipientsAsync(Get_Payroll_Deduction_RecipientsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Deduction_RecipientOutput Put_Payroll_Deduction_Recipient(Put_Payroll_Deduction_RecipientInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Deduction_RecipientOutput> Put_Payroll_Deduction_RecipientAsync(Put_Payroll_Deduction_RecipientInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Paycheck_DeliveriesOutput Get_Paycheck_Deliveries(Get_Paycheck_DeliveriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Paycheck_DeliveriesOutput> Get_Paycheck_DeliveriesAsync(Get_Paycheck_DeliveriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Paycheck_Delivery__Public_Output Put_Paycheck_Delivery__Public_(Put_Paycheck_Delivery__Public_Input request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Paycheck_Delivery__Public_Output> Put_Paycheck_Delivery__Public_Async(Put_Paycheck_Delivery__Public_Input request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Single_Legal_EntityOutput Put_Single_Legal_Entity(Put_Single_Legal_EntityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Single_Legal_EntityOutput> Put_Single_Legal_EntityAsync(Put_Single_Legal_EntityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Single_Legal_EntitiesOutput Get_Single_Legal_Entities(Get_Single_Legal_EntitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Single_Legal_EntitiesOutput> Get_Single_Legal_EntitiesAsync(Get_Single_Legal_EntitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_W2_W2C_Printing_ElectionOutput Get_W2_W2C_Printing_Election(Get_W2_W2C_Printing_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_W2_W2C_Printing_ElectionOutput> Get_W2_W2C_Printing_ElectionAsync(Get_W2_W2C_Printing_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_W2_W2C_Printing_ElectionOutput Put_W2_W2C_Printing_Election(Put_W2_W2C_Printing_ElectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_W2_W2C_Printing_ElectionOutput> Put_W2_W2C_Printing_ElectionAsync(Put_W2_W2C_Printing_ElectionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Tax_Levy_Deduction_RestrictionsOutput Get_Tax_Levy_Deduction_Restrictions(Get_Tax_Levy_Deduction_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Tax_Levy_Deduction_RestrictionsOutput> Get_Tax_Levy_Deduction_RestrictionsAsync(Get_Tax_Levy_Deduction_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Tax_Levy_Deduction_RestrictionOutput Put_Tax_Levy_Deduction_Restriction(Put_Tax_Levy_Deduction_RestrictionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Tax_Levy_Deduction_RestrictionOutput> Put_Tax_Levy_Deduction_RestrictionAsync(Put_Tax_Levy_Deduction_RestrictionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Tax_Document_DeliveryOutput Put_Tax_Document_Delivery(Put_Tax_Document_DeliveryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Tax_Document_DeliveryOutput> Put_Tax_Document_DeliveryAsync(Put_Tax_Document_DeliveryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Tax_Document_DeliveriesOutput Get_Tax_Document_Deliveries(Get_Tax_Document_DeliveriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Tax_Document_DeliveriesOutput> Get_Tax_Document_DeliveriesAsync(Get_Tax_Document_DeliveriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Periodic_Company_CAN_Tax_Remittance_DataOutput Get_Periodic_Company_CAN_Tax_Remittance_Data(Get_Periodic_Company_CAN_Tax_Remittance_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Periodic_Company_CAN_Tax_Remittance_DataOutput> Get_Periodic_Company_CAN_Tax_Remittance_DataAsync(Get_Periodic_Company_CAN_Tax_Remittance_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Withholding_Order_Local_Minimum_Wage_RateOutput Put_Withholding_Order_Local_Minimum_Wage_Rate(Put_Withholding_Order_Local_Minimum_Wage_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Withholding_Order_Local_Minimum_Wage_RateOutput> Put_Withholding_Order_Local_Minimum_Wage_RateAsync(Put_Withholding_Order_Local_Minimum_Wage_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Withholding_Order_Local_Minimum_Wage_RateOutput Get_Withholding_Order_Local_Minimum_Wage_Rate(Get_Withholding_Order_Local_Minimum_Wage_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Withholding_Order_Local_Minimum_Wage_RateOutput> Get_Withholding_Order_Local_Minimum_Wage_RateAsync(Get_Withholding_Order_Local_Minimum_Wage_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Tax_Mappings_on_LocationOutput Get_Payroll_Tax_Mappings_on_Location(Get_Payroll_Tax_Mappings_on_LocationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Tax_Mappings_on_LocationOutput> Get_Payroll_Tax_Mappings_on_LocationAsync(Get_Payroll_Tax_Mappings_on_LocationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Tax_Mapping_on_LocationOutput Put_Payroll_Tax_Mapping_on_Location(Put_Payroll_Tax_Mapping_on_LocationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Tax_Mapping_on_LocationOutput> Put_Payroll_Tax_Mapping_on_LocationAsync(Put_Payroll_Tax_Mapping_on_LocationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Run_Pay_CalculationOutput Put_Run_Pay_Calculation(Put_Run_Pay_CalculationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Run_Pay_CalculationOutput> Put_Run_Pay_CalculationAsync(Put_Run_Pay_CalculationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_EFW2_Year_End_Worker_Filing_DataOutput Get_EFW2_Year_End_Worker_Filing_Data(Get_EFW2_Year_End_Worker_Filing_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_EFW2_Year_End_Worker_Filing_DataOutput> Get_EFW2_Year_End_Worker_Filing_DataAsync(Get_EFW2_Year_End_Worker_Filing_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_PrePrinted_PayslipsOutput Get_Payroll_PrePrinted_Payslips(Get_Payroll_PrePrinted_PayslipsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_PrePrinted_PayslipsOutput> Get_Payroll_PrePrinted_PayslipsAsync(Get_Payroll_PrePrinted_PayslipsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_EFW2_Year_End_Employer_Filing_DataOutput Get_EFW2_Year_End_Employer_Filing_Data(Get_EFW2_Year_End_Employer_Filing_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_EFW2_Year_End_Employer_Filing_DataOutput> Get_EFW2_Year_End_Employer_Filing_DataAsync(Get_EFW2_Year_End_Employer_Filing_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Run_Pay_CalculationOutput Get_Run_Pay_Calculation(Get_Run_Pay_CalculationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Run_Pay_CalculationOutput> Get_Run_Pay_CalculationAsync(Get_Run_Pay_CalculationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Payroll_Payee_Tax_Location_MappingsOutput Get_Payroll_Payee_Tax_Location_Mappings(Get_Payroll_Payee_Tax_Location_MappingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Payroll_Payee_Tax_Location_MappingsOutput> Get_Payroll_Payee_Tax_Location_MappingsAsync(Get_Payroll_Payee_Tax_Location_MappingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Payroll_Payee_Tax_Location_MappingOutput Put_Payroll_Payee_Tax_Location_Mapping(Put_Payroll_Payee_Tax_Location_MappingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Payroll_Payee_Tax_Location_MappingOutput> Put_Payroll_Payee_Tax_Location_MappingAsync(Put_Payroll_Payee_Tax_Location_MappingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Payroll_InputOutput Import_Payroll_Input(Import_Payroll_InputInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Payroll_InputOutput> Import_Payroll_InputAsync(Import_Payroll_InputInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Payroll_InputOutput Import_ROE_Prior_Period_History_Results(Import_ROE_Prior_Period_History_ResultsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Payroll_InputOutput> Import_ROE_Prior_Period_History_ResultsAsync(Import_ROE_Prior_Period_History_ResultsInput request);
	}
}
