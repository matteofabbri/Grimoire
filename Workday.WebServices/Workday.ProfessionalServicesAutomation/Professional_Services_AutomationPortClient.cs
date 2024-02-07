using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Professional_Services_AutomationPortClient : ClientBase<Professional_Services_AutomationPort>, Professional_Services_AutomationPort
	{
		public Professional_Services_AutomationPortClient()
		{
		}

		public Professional_Services_AutomationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Professional_Services_AutomationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Professional_Services_AutomationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Professional_Services_AutomationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Update_Expense_ReportOutput Professional_Services_AutomationPort.Add_Update_Expense_Report(Add_Update_Expense_ReportInput request)
		{
			return base.Channel.Add_Update_Expense_Report(request);
		}

		public void Add_Update_Expense_Report(Workday_Common_HeaderType Workday_Common_Header, Expense_Report_Add_UpdateType Expense_Report_Add_Update)
		{
			((Professional_Services_AutomationPort)this).Add_Update_Expense_Report(new Add_Update_Expense_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Expense_Report_Add_Update = Expense_Report_Add_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Update_Expense_ReportOutput> Professional_Services_AutomationPort.Add_Update_Expense_ReportAsync(Add_Update_Expense_ReportInput request)
		{
			return base.Channel.Add_Update_Expense_ReportAsync(request);
		}

		public Task<Add_Update_Expense_ReportOutput> Add_Update_Expense_ReportAsync(Workday_Common_HeaderType Workday_Common_Header, Expense_Report_Add_UpdateType Expense_Report_Add_Update)
		{
			return ((Professional_Services_AutomationPort)this).Add_Update_Expense_ReportAsync(new Add_Update_Expense_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Expense_Report_Add_Update = Expense_Report_Add_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Expense_Report_OldOutput Professional_Services_AutomationPort.Cancel_Expense_Report_Old(Cancel_Expense_Report_OldInput request)
		{
			return base.Channel.Cancel_Expense_Report_Old(request);
		}

		public void Cancel_Expense_Report_Old(Workday_Common_HeaderType Workday_Common_Header, Expense_Report_CancelType Expense_Report_Cancel)
		{
			((Professional_Services_AutomationPort)this).Cancel_Expense_Report_Old(new Cancel_Expense_Report_OldInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Expense_Report_Cancel = Expense_Report_Cancel
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Expense_Report_OldOutput> Professional_Services_AutomationPort.Cancel_Expense_Report_OldAsync(Cancel_Expense_Report_OldInput request)
		{
			return base.Channel.Cancel_Expense_Report_OldAsync(request);
		}

		public Task<Cancel_Expense_Report_OldOutput> Cancel_Expense_Report_OldAsync(Workday_Common_HeaderType Workday_Common_Header, Expense_Report_CancelType Expense_Report_Cancel)
		{
			return ((Professional_Services_AutomationPort)this).Cancel_Expense_Report_OldAsync(new Cancel_Expense_Report_OldInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Expense_Report_Cancel = Expense_Report_Cancel
			});
		}
	}
}
