using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Benefits_AdministrationPortClient : ClientBase<Benefits_AdministrationPort>, Benefits_AdministrationPort
	{
		public Benefits_AdministrationPortClient()
		{
		}

		public Benefits_AdministrationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Benefits_AdministrationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Benefits_AdministrationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Benefits_AdministrationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Benefit_Annual_RatesOutput Benefits_AdministrationPort.Get_Benefit_Annual_Rates(Get_Benefit_Annual_RatesInput request)
		{
			return base.Channel.Get_Benefit_Annual_Rates(request);
		}

		public Get_Benefit_Annual_Rates_ResponseType Get_Benefit_Annual_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Annual_Rates_RequestType Get_Benefit_Annual_Rates_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Benefit_Annual_Rates(new Get_Benefit_Annual_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benefit_Annual_Rates_Request = Get_Benefit_Annual_Rates_Request
			}).Get_Benefit_Annual_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Benefit_Annual_RatesOutput> Benefits_AdministrationPort.Get_Benefit_Annual_RatesAsync(Get_Benefit_Annual_RatesInput request)
		{
			return base.Channel.Get_Benefit_Annual_RatesAsync(request);
		}

		public Task<Get_Benefit_Annual_RatesOutput> Get_Benefit_Annual_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Annual_Rates_RequestType Get_Benefit_Annual_Rates_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Benefit_Annual_RatesAsync(new Get_Benefit_Annual_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benefit_Annual_Rates_Request = Get_Benefit_Annual_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Benefit_Annual_RateOutput Benefits_AdministrationPort.Put_Benefit_Annual_Rate(Put_Benefit_Annual_RateInput request)
		{
			return base.Channel.Put_Benefit_Annual_Rate(request);
		}

		public Put_Benefit_Annual_Rate_ResponseType Put_Benefit_Annual_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Annual_Rate_RequestType Put_Benefit_Annual_Rate_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Benefit_Annual_Rate(new Put_Benefit_Annual_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benefit_Annual_Rate_Request = Put_Benefit_Annual_Rate_Request
			}).Put_Benefit_Annual_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Benefit_Annual_RateOutput> Benefits_AdministrationPort.Put_Benefit_Annual_RateAsync(Put_Benefit_Annual_RateInput request)
		{
			return base.Channel.Put_Benefit_Annual_RateAsync(request);
		}

		public Task<Put_Benefit_Annual_RateOutput> Put_Benefit_Annual_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Annual_Rate_RequestType Put_Benefit_Annual_Rate_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Benefit_Annual_RateAsync(new Put_Benefit_Annual_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benefit_Annual_Rate_Request = Put_Benefit_Annual_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Employee_Defined_Contribution_ElectionsOutput Benefits_AdministrationPort.Put_Employee_Defined_Contribution_Elections(Put_Employee_Defined_Contribution_ElectionsInput request)
		{
			return base.Channel.Put_Employee_Defined_Contribution_Elections(request);
		}

		public Put_Employee_Defined_Contribution_Elections_ResponseType Put_Employee_Defined_Contribution_Elections(Workday_Common_HeaderType Workday_Common_Header, Put_Employee_Defined_Contribution_Elections_RequestType Put_Employee_Defined_Contribution_Elections_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Employee_Defined_Contribution_Elections(new Put_Employee_Defined_Contribution_ElectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Employee_Defined_Contribution_Elections_Request = Put_Employee_Defined_Contribution_Elections_Request
			}).Put_Employee_Defined_Contribution_Elections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Employee_Defined_Contribution_ElectionsOutput> Benefits_AdministrationPort.Put_Employee_Defined_Contribution_ElectionsAsync(Put_Employee_Defined_Contribution_ElectionsInput request)
		{
			return base.Channel.Put_Employee_Defined_Contribution_ElectionsAsync(request);
		}

		public Task<Put_Employee_Defined_Contribution_ElectionsOutput> Put_Employee_Defined_Contribution_ElectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Employee_Defined_Contribution_Elections_RequestType Put_Employee_Defined_Contribution_Elections_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Employee_Defined_Contribution_ElectionsAsync(new Put_Employee_Defined_Contribution_ElectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Employee_Defined_Contribution_Elections_Request = Put_Employee_Defined_Contribution_Elections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_Defined_Contribution_ElectionsOutput Benefits_AdministrationPort.Get_Employee_Defined_Contribution_Elections(Get_Employee_Defined_Contribution_ElectionsInput request)
		{
			return base.Channel.Get_Employee_Defined_Contribution_Elections(request);
		}

		public Get_Employee_Defined_Contribution_Elections_ResponseType Get_Employee_Defined_Contribution_Elections(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Defined_Contribution_Elections_RequestType Get_Employee_Defined_Contribution_Elections_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Employee_Defined_Contribution_Elections(new Get_Employee_Defined_Contribution_ElectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Employee_Defined_Contribution_Elections_Request = Get_Employee_Defined_Contribution_Elections_Request
			}).Get_Employee_Defined_Contribution_Elections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_Defined_Contribution_ElectionsOutput> Benefits_AdministrationPort.Get_Employee_Defined_Contribution_ElectionsAsync(Get_Employee_Defined_Contribution_ElectionsInput request)
		{
			return base.Channel.Get_Employee_Defined_Contribution_ElectionsAsync(request);
		}

		public Task<Get_Employee_Defined_Contribution_ElectionsOutput> Get_Employee_Defined_Contribution_ElectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Defined_Contribution_Elections_RequestType Get_Employee_Defined_Contribution_Elections_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Employee_Defined_Contribution_ElectionsAsync(new Get_Employee_Defined_Contribution_ElectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Employee_Defined_Contribution_Elections_Request = Get_Employee_Defined_Contribution_Elections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DependentOutput Benefits_AdministrationPort.Put_Dependent(Put_DependentInput request)
		{
			return base.Channel.Put_Dependent(request);
		}

		public Put_Dependent_ResponseType Put_Dependent(Workday_Common_HeaderType Workday_Common_Header, Put_Dependent_RequestType Put_Dependent_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Dependent(new Put_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dependent_Request = Put_Dependent_Request
			}).Put_Dependent_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DependentOutput> Benefits_AdministrationPort.Put_DependentAsync(Put_DependentInput request)
		{
			return base.Channel.Put_DependentAsync(request);
		}

		public Task<Put_DependentOutput> Put_DependentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Dependent_RequestType Put_Dependent_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_DependentAsync(new Put_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dependent_Request = Put_Dependent_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Health_Care_RatesOutput Benefits_AdministrationPort.Get_Health_Care_Rates(Get_Health_Care_RatesInput request)
		{
			return base.Channel.Get_Health_Care_Rates(request);
		}

		public Get_Health_Care_Rates_ResponseType Get_Health_Care_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Health_Care_Rates_RequestType Get_Health_Care_Rates_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Health_Care_Rates(new Get_Health_Care_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Health_Care_Rates_Request = Get_Health_Care_Rates_Request
			}).Get_Health_Care_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Health_Care_RatesOutput> Benefits_AdministrationPort.Get_Health_Care_RatesAsync(Get_Health_Care_RatesInput request)
		{
			return base.Channel.Get_Health_Care_RatesAsync(request);
		}

		public Task<Get_Health_Care_RatesOutput> Get_Health_Care_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Health_Care_Rates_RequestType Get_Health_Care_Rates_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Health_Care_RatesAsync(new Get_Health_Care_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Health_Care_Rates_Request = Get_Health_Care_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Health_Care_RateOutput Benefits_AdministrationPort.Put_Health_Care_Rate(Put_Health_Care_RateInput request)
		{
			return base.Channel.Put_Health_Care_Rate(request);
		}

		public Put_Health_Care_Rate_ResponseType Put_Health_Care_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Health_Care_Rate_RequestType Put_Health_Care_Rate_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Health_Care_Rate(new Put_Health_Care_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Health_Care_Rate_Request = Put_Health_Care_Rate_Request
			}).Put_Health_Care_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Health_Care_RateOutput> Benefits_AdministrationPort.Put_Health_Care_RateAsync(Put_Health_Care_RateInput request)
		{
			return base.Channel.Put_Health_Care_RateAsync(request);
		}

		public Task<Put_Health_Care_RateOutput> Put_Health_Care_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Health_Care_Rate_RequestType Put_Health_Care_Rate_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Health_Care_RateAsync(new Put_Health_Care_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Health_Care_Rate_Request = Put_Health_Care_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Postal_Code_SetOutput Benefits_AdministrationPort.Put_Postal_Code_Set(Put_Postal_Code_SetInput request)
		{
			return base.Channel.Put_Postal_Code_Set(request);
		}

		public Put_Postal_Code_Set_ResponseType Put_Postal_Code_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Postal_Code_Set_RequestType Put_Postal_Code_Set_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Postal_Code_Set(new Put_Postal_Code_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Postal_Code_Set_Request = Put_Postal_Code_Set_Request
			}).Put_Postal_Code_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Postal_Code_SetOutput> Benefits_AdministrationPort.Put_Postal_Code_SetAsync(Put_Postal_Code_SetInput request)
		{
			return base.Channel.Put_Postal_Code_SetAsync(request);
		}

		public Task<Put_Postal_Code_SetOutput> Put_Postal_Code_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Postal_Code_Set_RequestType Put_Postal_Code_Set_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Postal_Code_SetAsync(new Put_Postal_Code_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Postal_Code_Set_Request = Put_Postal_Code_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Benefit_Individual_RatesOutput Benefits_AdministrationPort.Get_Benefit_Individual_Rates(Get_Benefit_Individual_RatesInput request)
		{
			return base.Channel.Get_Benefit_Individual_Rates(request);
		}

		public Get_Benefit_Individual_Rates_ResponseType Get_Benefit_Individual_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Individual_Rates_RequestType Get_Benefit_Individual_Rates_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Benefit_Individual_Rates(new Get_Benefit_Individual_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benefit_Individual_Rates_Request = Get_Benefit_Individual_Rates_Request
			}).Get_Benefit_Individual_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Benefit_Individual_RatesOutput> Benefits_AdministrationPort.Get_Benefit_Individual_RatesAsync(Get_Benefit_Individual_RatesInput request)
		{
			return base.Channel.Get_Benefit_Individual_RatesAsync(request);
		}

		public Task<Get_Benefit_Individual_RatesOutput> Get_Benefit_Individual_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Individual_Rates_RequestType Get_Benefit_Individual_Rates_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Benefit_Individual_RatesAsync(new Get_Benefit_Individual_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benefit_Individual_Rates_Request = Get_Benefit_Individual_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Benefit_Individual_RateOutput Benefits_AdministrationPort.Put_Benefit_Individual_Rate(Put_Benefit_Individual_RateInput request)
		{
			return base.Channel.Put_Benefit_Individual_Rate(request);
		}

		public Put_Benefit_Individual_Rate_ResponseType Put_Benefit_Individual_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Individual_Rate_RequestType Put_Benefit_Individual_Rate_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Benefit_Individual_Rate(new Put_Benefit_Individual_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benefit_Individual_Rate_Request = Put_Benefit_Individual_Rate_Request
			}).Put_Benefit_Individual_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Benefit_Individual_RateOutput> Benefits_AdministrationPort.Put_Benefit_Individual_RateAsync(Put_Benefit_Individual_RateInput request)
		{
			return base.Channel.Put_Benefit_Individual_RateAsync(request);
		}

		public Task<Put_Benefit_Individual_RateOutput> Put_Benefit_Individual_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Individual_Rate_RequestType Put_Benefit_Individual_Rate_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Benefit_Individual_RateAsync(new Put_Benefit_Individual_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benefit_Individual_Rate_Request = Put_Benefit_Individual_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_BenefitsOutput Benefits_AdministrationPort.Change_Benefits(Change_BenefitsInput request)
		{
			return base.Channel.Change_Benefits(request);
		}

		public Change_Benefits_ResponseType Change_Benefits(Workday_Common_HeaderType Workday_Common_Header, Change_Benefits_RequestType Change_Benefits_Request)
		{
			return ((Benefits_AdministrationPort)this).Change_Benefits(new Change_BenefitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Benefits_Request = Change_Benefits_Request
			}).Change_Benefits_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_BenefitsOutput> Benefits_AdministrationPort.Change_BenefitsAsync(Change_BenefitsInput request)
		{
			return base.Channel.Change_BenefitsAsync(request);
		}

		public Task<Change_BenefitsOutput> Change_BenefitsAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Benefits_RequestType Change_Benefits_Request)
		{
			return ((Benefits_AdministrationPort)this).Change_BenefitsAsync(new Change_BenefitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Benefits_Request = Change_Benefits_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Enroll_in_Retirement_Savings_PlansOutput Benefits_AdministrationPort.Enroll_in_Retirement_Savings_Plans(Enroll_in_Retirement_Savings_PlansInput request)
		{
			return base.Channel.Enroll_in_Retirement_Savings_Plans(request);
		}

		public Enroll_in_Retirement_Savings_Plans_ResponseType Enroll_in_Retirement_Savings_Plans(Workday_Common_HeaderType Workday_Common_Header, Enroll_in_Retirement_Savings_Plans_RequestType Enroll_in_Retirement_Savings_Plans_Request)
		{
			return ((Benefits_AdministrationPort)this).Enroll_in_Retirement_Savings_Plans(new Enroll_in_Retirement_Savings_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Enroll_in_Retirement_Savings_Plans_Request = Enroll_in_Retirement_Savings_Plans_Request
			}).Enroll_in_Retirement_Savings_Plans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Enroll_in_Retirement_Savings_PlansOutput> Benefits_AdministrationPort.Enroll_in_Retirement_Savings_PlansAsync(Enroll_in_Retirement_Savings_PlansInput request)
		{
			return base.Channel.Enroll_in_Retirement_Savings_PlansAsync(request);
		}

		public Task<Enroll_in_Retirement_Savings_PlansOutput> Enroll_in_Retirement_Savings_PlansAsync(Workday_Common_HeaderType Workday_Common_Header, Enroll_in_Retirement_Savings_Plans_RequestType Enroll_in_Retirement_Savings_Plans_Request)
		{
			return ((Benefits_AdministrationPort)this).Enroll_in_Retirement_Savings_PlansAsync(new Enroll_in_Retirement_Savings_PlansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Enroll_in_Retirement_Savings_Plans_Request = Enroll_in_Retirement_Savings_Plans_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Grant_COBRA_EligibilityOutput Benefits_AdministrationPort.Grant_COBRA_Eligibility(Grant_COBRA_EligibilityInput request)
		{
			return base.Channel.Grant_COBRA_Eligibility(request);
		}

		public Grant_COBRA_Eligibility_ResponseType Grant_COBRA_Eligibility(Workday_Common_HeaderType Workday_Common_Header, Grant_COBRA_Eligibility_RequestType Grant_COBRA_Eligibility_Request)
		{
			return ((Benefits_AdministrationPort)this).Grant_COBRA_Eligibility(new Grant_COBRA_EligibilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Grant_COBRA_Eligibility_Request = Grant_COBRA_Eligibility_Request
			}).Grant_COBRA_Eligibility_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Grant_COBRA_EligibilityOutput> Benefits_AdministrationPort.Grant_COBRA_EligibilityAsync(Grant_COBRA_EligibilityInput request)
		{
			return base.Channel.Grant_COBRA_EligibilityAsync(request);
		}

		public Task<Grant_COBRA_EligibilityOutput> Grant_COBRA_EligibilityAsync(Workday_Common_HeaderType Workday_Common_Header, Grant_COBRA_Eligibility_RequestType Grant_COBRA_Eligibility_Request)
		{
			return ((Benefits_AdministrationPort)this).Grant_COBRA_EligibilityAsync(new Grant_COBRA_EligibilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Grant_COBRA_Eligibility_Request = Grant_COBRA_Eligibility_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_DependentOutput Benefits_AdministrationPort.Add_Dependent(Add_DependentInput request)
		{
			return base.Channel.Add_Dependent(request);
		}

		public Add_Dependent_ResponseType Add_Dependent(Workday_Common_HeaderType Workday_Common_Header, Add_Dependent_RequestType Add_Dependent_Request)
		{
			return ((Benefits_AdministrationPort)this).Add_Dependent(new Add_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Dependent_Request = Add_Dependent_Request
			}).Add_Dependent_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_DependentOutput> Benefits_AdministrationPort.Add_DependentAsync(Add_DependentInput request)
		{
			return base.Channel.Add_DependentAsync(request);
		}

		public Task<Add_DependentOutput> Add_DependentAsync(Workday_Common_HeaderType Workday_Common_Header, Add_Dependent_RequestType Add_Dependent_Request)
		{
			return ((Benefits_AdministrationPort)this).Add_DependentAsync(new Add_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Dependent_Request = Add_Dependent_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_DependentOutput Benefits_AdministrationPort.Edit_Dependent(Edit_DependentInput request)
		{
			return base.Channel.Edit_Dependent(request);
		}

		public Edit_Dependent_ResponseType Edit_Dependent(Workday_Common_HeaderType Workday_Common_Header, Edit_Dependent_RequestType Edit_Dependent_Request)
		{
			return ((Benefits_AdministrationPort)this).Edit_Dependent(new Edit_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Dependent_Request = Edit_Dependent_Request
			}).Edit_Dependent_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_DependentOutput> Benefits_AdministrationPort.Edit_DependentAsync(Edit_DependentInput request)
		{
			return base.Channel.Edit_DependentAsync(request);
		}

		public Task<Edit_DependentOutput> Edit_DependentAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Dependent_RequestType Edit_Dependent_Request)
		{
			return ((Benefits_AdministrationPort)this).Edit_DependentAsync(new Edit_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Dependent_Request = Edit_Dependent_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Benefit_JobsOutput Benefits_AdministrationPort.Change_Benefit_Jobs(Change_Benefit_JobsInput request)
		{
			return base.Channel.Change_Benefit_Jobs(request);
		}

		public Change_Benefit_Jobs_ResponseType Change_Benefit_Jobs(Workday_Common_HeaderType Workday_Common_Header, Change_Benefit_Jobs_RequestType Change_Benefit_Jobs_Request)
		{
			return ((Benefits_AdministrationPort)this).Change_Benefit_Jobs(new Change_Benefit_JobsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Benefit_Jobs_Request = Change_Benefit_Jobs_Request
			}).Change_Benefit_Jobs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Benefit_JobsOutput> Benefits_AdministrationPort.Change_Benefit_JobsAsync(Change_Benefit_JobsInput request)
		{
			return base.Channel.Change_Benefit_JobsAsync(request);
		}

		public Task<Change_Benefit_JobsOutput> Change_Benefit_JobsAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Benefit_Jobs_RequestType Change_Benefit_Jobs_Request)
		{
			return ((Benefits_AdministrationPort)this).Change_Benefit_JobsAsync(new Change_Benefit_JobsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Benefit_Jobs_Request = Change_Benefit_Jobs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Benefit_Annual_CreditsOutput Benefits_AdministrationPort.Get_Benefit_Annual_Credits(Get_Benefit_Annual_CreditsInput request)
		{
			return base.Channel.Get_Benefit_Annual_Credits(request);
		}

		public Get_Benefit_Annual_Credits_ResponseType Get_Benefit_Annual_Credits(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Annual_Credits_RequestType Get_Benefit_Annual_Credits_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Benefit_Annual_Credits(new Get_Benefit_Annual_CreditsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benefit_Annual_Credits_Request = Get_Benefit_Annual_Credits_Request
			}).Get_Benefit_Annual_Credits_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Benefit_Annual_CreditsOutput> Benefits_AdministrationPort.Get_Benefit_Annual_CreditsAsync(Get_Benefit_Annual_CreditsInput request)
		{
			return base.Channel.Get_Benefit_Annual_CreditsAsync(request);
		}

		public Task<Get_Benefit_Annual_CreditsOutput> Get_Benefit_Annual_CreditsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Annual_Credits_RequestType Get_Benefit_Annual_Credits_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_Benefit_Annual_CreditsAsync(new Get_Benefit_Annual_CreditsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Benefit_Annual_Credits_Request = Get_Benefit_Annual_Credits_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Benefit_Annual_CreditOutput Benefits_AdministrationPort.Put_Benefit_Annual_Credit(Put_Benefit_Annual_CreditInput request)
		{
			return base.Channel.Put_Benefit_Annual_Credit(request);
		}

		public Put_Benefit_Annual_Credit_ResponseType Put_Benefit_Annual_Credit(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Annual_Credit_RequestType Put_Benefit_Annual_Credit_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Benefit_Annual_Credit(new Put_Benefit_Annual_CreditInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benefit_Annual_Credit_Request = Put_Benefit_Annual_Credit_Request
			}).Put_Benefit_Annual_Credit_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Benefit_Annual_CreditOutput> Benefits_AdministrationPort.Put_Benefit_Annual_CreditAsync(Put_Benefit_Annual_CreditInput request)
		{
			return base.Channel.Put_Benefit_Annual_CreditAsync(request);
		}

		public Task<Put_Benefit_Annual_CreditOutput> Put_Benefit_Annual_CreditAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Annual_Credit_RequestType Put_Benefit_Annual_Credit_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Benefit_Annual_CreditAsync(new Put_Benefit_Annual_CreditInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Benefit_Annual_Credit_Request = Put_Benefit_Annual_Credit_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Worker_Wellness_DataOutput Benefits_AdministrationPort.Put_Worker_Wellness_Data(Put_Worker_Wellness_DataInput request)
		{
			return base.Channel.Put_Worker_Wellness_Data(request);
		}

		public Put_Worker_Wellness_Data_ResponseType Put_Worker_Wellness_Data(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Wellness_Data_RequestType Put_Worker_Wellness_Data_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Worker_Wellness_Data(new Put_Worker_Wellness_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Wellness_Data_Request = Put_Worker_Wellness_Data_Request
			}).Put_Worker_Wellness_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Worker_Wellness_DataOutput> Benefits_AdministrationPort.Put_Worker_Wellness_DataAsync(Put_Worker_Wellness_DataInput request)
		{
			return base.Channel.Put_Worker_Wellness_DataAsync(request);
		}

		public Task<Put_Worker_Wellness_DataOutput> Put_Worker_Wellness_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Wellness_Data_RequestType Put_Worker_Wellness_Data_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Worker_Wellness_DataAsync(new Put_Worker_Wellness_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Wellness_Data_Request = Put_Worker_Wellness_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput Benefits_AdministrationPort.Put_Affordable_Care_Act_Worker_Hours_And_Wages(Put_Affordable_Care_Act_Worker_Hours_And_WagesInput request)
		{
			return base.Channel.Put_Affordable_Care_Act_Worker_Hours_And_Wages(request);
		}

		public Put_Affordable_Care_Act_Worker_Hours_And_Wages_ResponseType Put_Affordable_Care_Act_Worker_Hours_And_Wages(Workday_Common_HeaderType Workday_Common_Header, Put_Affordable_Care_Act_Worker_Hours_And_Wages_RequestType Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Affordable_Care_Act_Worker_Hours_And_Wages(new Put_Affordable_Care_Act_Worker_Hours_And_WagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request = Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request
			}).Put_Affordable_Care_Act_Worker_Hours_And_Wages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput> Benefits_AdministrationPort.Put_Affordable_Care_Act_Worker_Hours_And_WagesAsync(Put_Affordable_Care_Act_Worker_Hours_And_WagesInput request)
		{
			return base.Channel.Put_Affordable_Care_Act_Worker_Hours_And_WagesAsync(request);
		}

		public Task<Put_Affordable_Care_Act_Worker_Hours_And_WagesOutput> Put_Affordable_Care_Act_Worker_Hours_And_WagesAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Affordable_Care_Act_Worker_Hours_And_Wages_RequestType Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Affordable_Care_Act_Worker_Hours_And_WagesAsync(new Put_Affordable_Care_Act_Worker_Hours_And_WagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request = Put_Affordable_Care_Act_Worker_Hours_And_Wages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Evidence_of_InsurabilityOutput Benefits_AdministrationPort.Put_Evidence_of_Insurability(Put_Evidence_of_InsurabilityInput request)
		{
			return base.Channel.Put_Evidence_of_Insurability(request);
		}

		public Put_Evidence_of_Insurability_ResponseType Put_Evidence_of_Insurability(Workday_Common_HeaderType Workday_Common_Header, Put_Evidence_of_Insurability_RequestType Put_Evidence_of_Insurability_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Evidence_of_Insurability(new Put_Evidence_of_InsurabilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Evidence_of_Insurability_Request = Put_Evidence_of_Insurability_Request
			}).Put_Evidence_of_Insurability_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Evidence_of_InsurabilityOutput> Benefits_AdministrationPort.Put_Evidence_of_InsurabilityAsync(Put_Evidence_of_InsurabilityInput request)
		{
			return base.Channel.Put_Evidence_of_InsurabilityAsync(request);
		}

		public Task<Put_Evidence_of_InsurabilityOutput> Put_Evidence_of_InsurabilityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Evidence_of_Insurability_RequestType Put_Evidence_of_Insurability_Request)
		{
			return ((Benefits_AdministrationPort)this).Put_Evidence_of_InsurabilityAsync(new Put_Evidence_of_InsurabilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Evidence_of_Insurability_Request = Put_Evidence_of_Insurability_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_BeneficiaryOutput Benefits_AdministrationPort.Change_Beneficiary(Change_BeneficiaryInput request)
		{
			return base.Channel.Change_Beneficiary(request);
		}

		public Change_Beneficiary_ResponseType Change_Beneficiary(Workday_Common_HeaderType Workday_Common_Header, Change_Beneficiary_RequestType Change_Beneficiary_Request)
		{
			return ((Benefits_AdministrationPort)this).Change_Beneficiary(new Change_BeneficiaryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Beneficiary_Request = Change_Beneficiary_Request
			}).Change_Beneficiary_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_BeneficiaryOutput> Benefits_AdministrationPort.Change_BeneficiaryAsync(Change_BeneficiaryInput request)
		{
			return base.Channel.Change_BeneficiaryAsync(request);
		}

		public Task<Change_BeneficiaryOutput> Change_BeneficiaryAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Beneficiary_RequestType Change_Beneficiary_Request)
		{
			return ((Benefits_AdministrationPort)this).Change_BeneficiaryAsync(new Change_BeneficiaryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Beneficiary_Request = Change_Beneficiary_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ACA_1095C_Forms_DataOutput Benefits_AdministrationPort.Get_ACA_1095C_Forms_Data(Get_ACA_1095C_Forms_DataInput request)
		{
			return base.Channel.Get_ACA_1095C_Forms_Data(request);
		}

		public Get_ACA_1095C_Forms_Data_ResponseType Get_ACA_1095C_Forms_Data(Workday_Common_HeaderType Workday_Common_Header, Get_ACA_1095C_Forms_Data_RequestType Get_ACA_1095C_Forms_Data_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_ACA_1095C_Forms_Data(new Get_ACA_1095C_Forms_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_ACA_1095C_Forms_Data_Request = Get_ACA_1095C_Forms_Data_Request
			}).Get_ACA_1095C_Forms_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ACA_1095C_Forms_DataOutput> Benefits_AdministrationPort.Get_ACA_1095C_Forms_DataAsync(Get_ACA_1095C_Forms_DataInput request)
		{
			return base.Channel.Get_ACA_1095C_Forms_DataAsync(request);
		}

		public Task<Get_ACA_1095C_Forms_DataOutput> Get_ACA_1095C_Forms_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_ACA_1095C_Forms_Data_RequestType Get_ACA_1095C_Forms_Data_Request)
		{
			return ((Benefits_AdministrationPort)this).Get_ACA_1095C_Forms_DataAsync(new Get_ACA_1095C_Forms_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_ACA_1095C_Forms_Data_Request = Get_ACA_1095C_Forms_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Medicare_InformationOutput Benefits_AdministrationPort.Manage_Medicare_Information(Manage_Medicare_InformationInput request)
		{
			return base.Channel.Manage_Medicare_Information(request);
		}

		public Manage_Medicare_Information_ResponseType Manage_Medicare_Information(Workday_Common_HeaderType Workday_Common_Header, Manage_Medicare_Information_RequestType Manage_Medicare_Information_Request)
		{
			return ((Benefits_AdministrationPort)this).Manage_Medicare_Information(new Manage_Medicare_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Medicare_Information_Request = Manage_Medicare_Information_Request
			}).Manage_Medicare_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Medicare_InformationOutput> Benefits_AdministrationPort.Manage_Medicare_InformationAsync(Manage_Medicare_InformationInput request)
		{
			return base.Channel.Manage_Medicare_InformationAsync(request);
		}

		public Task<Manage_Medicare_InformationOutput> Manage_Medicare_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Medicare_Information_RequestType Manage_Medicare_Information_Request)
		{
			return ((Benefits_AdministrationPort)this).Manage_Medicare_InformationAsync(new Manage_Medicare_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Medicare_Information_Request = Manage_Medicare_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_1095C_Form_Recipients_DataOutput Benefits_AdministrationPort.Import_1095C_Form_Recipients_Data(Import_1095C_Form_Recipients_DataInput request)
		{
			return base.Channel.Import_1095C_Form_Recipients_Data(request);
		}

		public Put_Import_Process_ResponseType Import_1095C_Form_Recipients_Data(Workday_Common_HeaderType Workday_Common_Header, Import_ACA_1095C_Forms_Data_RequestType Import_ACA_1095C_Forms_Data_Request)
		{
			return ((Benefits_AdministrationPort)this).Import_1095C_Form_Recipients_Data(new Import_1095C_Form_Recipients_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_ACA_1095C_Forms_Data_Request = Import_ACA_1095C_Forms_Data_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_1095C_Form_Recipients_DataOutput> Benefits_AdministrationPort.Import_1095C_Form_Recipients_DataAsync(Import_1095C_Form_Recipients_DataInput request)
		{
			return base.Channel.Import_1095C_Form_Recipients_DataAsync(request);
		}

		public Task<Import_1095C_Form_Recipients_DataOutput> Import_1095C_Form_Recipients_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Import_ACA_1095C_Forms_Data_RequestType Import_ACA_1095C_Forms_Data_Request)
		{
			return ((Benefits_AdministrationPort)this).Import_1095C_Form_Recipients_DataAsync(new Import_1095C_Form_Recipients_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_ACA_1095C_Forms_Data_Request = Import_ACA_1095C_Forms_Data_Request
			});
		}
	}
}
