using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Benefits_Administration", ConfigurationName = "Benefits_AdministrationService.Benefits_AdministrationPort")]
	public interface Benefits_AdministrationPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Benefit_Annual_RatesOutput Get_Benefit_Annual_Rates(Get_Benefit_Annual_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Benefit_Annual_RatesOutput> Get_Benefit_Annual_RatesAsync(Get_Benefit_Annual_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Benefit_Annual_RateOutput Put_Benefit_Annual_Rate(Put_Benefit_Annual_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Benefit_Annual_RateOutput> Put_Benefit_Annual_RateAsync(Put_Benefit_Annual_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Employee_Defined_Contribution_ElectionsOutput Put_Employee_Defined_Contribution_Elections(Put_Employee_Defined_Contribution_ElectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Employee_Defined_Contribution_ElectionsOutput> Put_Employee_Defined_Contribution_ElectionsAsync(Put_Employee_Defined_Contribution_ElectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_Defined_Contribution_ElectionsOutput Get_Employee_Defined_Contribution_Elections(Get_Employee_Defined_Contribution_ElectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_Defined_Contribution_ElectionsOutput> Get_Employee_Defined_Contribution_ElectionsAsync(Get_Employee_Defined_Contribution_ElectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_DependentOutput Put_Dependent(Put_DependentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_DependentOutput> Put_DependentAsync(Put_DependentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Health_Care_RatesOutput Get_Health_Care_Rates(Get_Health_Care_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Health_Care_RatesOutput> Get_Health_Care_RatesAsync(Get_Health_Care_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Health_Care_RateOutput Put_Health_Care_Rate(Put_Health_Care_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Health_Care_RateOutput> Put_Health_Care_RateAsync(Put_Health_Care_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Postal_Code_SetOutput Put_Postal_Code_Set(Put_Postal_Code_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Postal_Code_SetOutput> Put_Postal_Code_SetAsync(Put_Postal_Code_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Benefit_Individual_RatesOutput Get_Benefit_Individual_Rates(Get_Benefit_Individual_RatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Benefit_Individual_RatesOutput> Get_Benefit_Individual_RatesAsync(Get_Benefit_Individual_RatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Benefit_Individual_RateOutput Put_Benefit_Individual_Rate(Put_Benefit_Individual_RateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Benefit_Individual_RateOutput> Put_Benefit_Individual_RateAsync(Put_Benefit_Individual_RateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_BenefitsOutput Change_Benefits(Change_BenefitsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_BenefitsOutput> Change_BenefitsAsync(Change_BenefitsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Enroll_in_Retirement_Savings_PlansOutput Enroll_in_Retirement_Savings_Plans(Enroll_in_Retirement_Savings_PlansInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Enroll_in_Retirement_Savings_PlansOutput> Enroll_in_Retirement_Savings_PlansAsync(Enroll_in_Retirement_Savings_PlansInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Grant_COBRA_EligibilityOutput Grant_COBRA_Eligibility(Grant_COBRA_EligibilityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Grant_COBRA_EligibilityOutput> Grant_COBRA_EligibilityAsync(Grant_COBRA_EligibilityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_DependentOutput Add_Dependent(Add_DependentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_DependentOutput> Add_DependentAsync(Add_DependentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_DependentOutput Edit_Dependent(Edit_DependentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_DependentOutput> Edit_DependentAsync(Edit_DependentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Benefit_JobsOutput Change_Benefit_Jobs(Change_Benefit_JobsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Benefit_JobsOutput> Change_Benefit_JobsAsync(Change_Benefit_JobsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Benefit_Annual_CreditsOutput Get_Benefit_Annual_Credits(Get_Benefit_Annual_CreditsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Benefit_Annual_CreditsOutput> Get_Benefit_Annual_CreditsAsync(Get_Benefit_Annual_CreditsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Benefit_Annual_CreditOutput Put_Benefit_Annual_Credit(Put_Benefit_Annual_CreditInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Benefit_Annual_CreditOutput> Put_Benefit_Annual_CreditAsync(Put_Benefit_Annual_CreditInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Worker_Wellness_DataOutput Put_Worker_Wellness_Data(Put_Worker_Wellness_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Worker_Wellness_DataOutput> Put_Worker_Wellness_DataAsync(Put_Worker_Wellness_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput Put_Affordable_Care_Act_Worker_Hours_And_Wages(Put_Affordable_Care_Act_Worker_Hours_And_WagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput> Put_Affordable_Care_Act_Worker_Hours_And_WagesAsync(Put_Affordable_Care_Act_Worker_Hours_And_WagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Evidence_of_InsurabilityOutput Put_Evidence_of_Insurability(Put_Evidence_of_InsurabilityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Evidence_of_InsurabilityOutput> Put_Evidence_of_InsurabilityAsync(Put_Evidence_of_InsurabilityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_BeneficiaryOutput Change_Beneficiary(Change_BeneficiaryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_BeneficiaryOutput> Change_BeneficiaryAsync(Change_BeneficiaryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ACA_1095C_Forms_DataOutput Get_ACA_1095C_Forms_Data(Get_ACA_1095C_Forms_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ACA_1095C_Forms_DataOutput> Get_ACA_1095C_Forms_DataAsync(Get_ACA_1095C_Forms_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Medicare_InformationOutput Manage_Medicare_Information(Manage_Medicare_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Medicare_InformationOutput> Manage_Medicare_InformationAsync(Manage_Medicare_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_1095C_Form_Recipients_DataOutput Import_1095C_Form_Recipients_Data(Import_1095C_Form_Recipients_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_1095C_Form_Recipients_DataOutput> Import_1095C_Form_Recipients_DataAsync(Import_1095C_Form_Recipients_DataInput request);
	}
}
