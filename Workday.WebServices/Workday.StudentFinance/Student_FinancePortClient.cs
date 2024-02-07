using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Student_FinancePortClient : ClientBase<Student_FinancePort>, Student_FinancePort
	{
		public Student_FinancePortClient()
		{
		}

		public Student_FinancePortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Student_FinancePortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Student_FinancePortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Student_FinancePortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_ChargesOutput Student_FinancePort.Get_Student_Charges(Get_Student_ChargesInput request)
		{
			return base.Channel.Get_Student_Charges(request);
		}

		public Get_Student_Charges_ResponseType Get_Student_Charges(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Charges_RequestType Get_Student_Charges_Request)
		{
			return ((Student_FinancePort)this).Get_Student_Charges(new Get_Student_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Charges_Request = Get_Student_Charges_Request
			}).Get_Student_Charges_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_ChargesOutput> Student_FinancePort.Get_Student_ChargesAsync(Get_Student_ChargesInput request)
		{
			return base.Channel.Get_Student_ChargesAsync(request);
		}

		public Task<Get_Student_ChargesOutput> Get_Student_ChargesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Charges_RequestType Get_Student_Charges_Request)
		{
			return ((Student_FinancePort)this).Get_Student_ChargesAsync(new Get_Student_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Charges_Request = Get_Student_Charges_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Student_ChargeOutput Student_FinancePort.Submit_Student_Charge(Submit_Student_ChargeInput request)
		{
			return base.Channel.Submit_Student_Charge(request);
		}

		public Submit_Student_Charge_ResponseType Submit_Student_Charge(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Charge_RequestType Submit_Student_Charge_Request)
		{
			return ((Student_FinancePort)this).Submit_Student_Charge(new Submit_Student_ChargeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Charge_Request = Submit_Student_Charge_Request
			}).Submit_Student_Charge_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Student_ChargeOutput> Student_FinancePort.Submit_Student_ChargeAsync(Submit_Student_ChargeInput request)
		{
			return base.Channel.Submit_Student_ChargeAsync(request);
		}

		public Task<Submit_Student_ChargeOutput> Submit_Student_ChargeAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Charge_RequestType Submit_Student_Charge_Request)
		{
			return ((Student_FinancePort)this).Submit_Student_ChargeAsync(new Submit_Student_ChargeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Charge_Request = Submit_Student_Charge_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Historical_ChargesOutput Student_FinancePort.Get_Student_Historical_Charges(Get_Student_Historical_ChargesInput request)
		{
			return base.Channel.Get_Student_Historical_Charges(request);
		}

		public Get_Student_Historical_Charges_ResponseType Get_Student_Historical_Charges(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Historical_Charges_RequestType Get_Student_Historical_Charges_Request)
		{
			return ((Student_FinancePort)this).Get_Student_Historical_Charges(new Get_Student_Historical_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Historical_Charges_Request = Get_Student_Historical_Charges_Request
			}).Get_Student_Historical_Charges_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Historical_ChargesOutput> Student_FinancePort.Get_Student_Historical_ChargesAsync(Get_Student_Historical_ChargesInput request)
		{
			return base.Channel.Get_Student_Historical_ChargesAsync(request);
		}

		public Task<Get_Student_Historical_ChargesOutput> Get_Student_Historical_ChargesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Historical_Charges_RequestType Get_Student_Historical_Charges_Request)
		{
			return ((Student_FinancePort)this).Get_Student_Historical_ChargesAsync(new Get_Student_Historical_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Historical_Charges_Request = Get_Student_Historical_Charges_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Historical_PaymentsOutput Student_FinancePort.Get_Student_Historical_Payments(Get_Student_Historical_PaymentsInput request)
		{
			return base.Channel.Get_Student_Historical_Payments(request);
		}

		public Get_Student_Historical_Payments_ResponseType Get_Student_Historical_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Historical_Payments_RequestType Get_Student_Historical_Payments_Request)
		{
			return ((Student_FinancePort)this).Get_Student_Historical_Payments(new Get_Student_Historical_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Historical_Payments_Request = Get_Student_Historical_Payments_Request
			}).Get_Student_Historical_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Historical_PaymentsOutput> Student_FinancePort.Get_Student_Historical_PaymentsAsync(Get_Student_Historical_PaymentsInput request)
		{
			return base.Channel.Get_Student_Historical_PaymentsAsync(request);
		}

		public Task<Get_Student_Historical_PaymentsOutput> Get_Student_Historical_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Historical_Payments_RequestType Get_Student_Historical_Payments_Request)
		{
			return ((Student_FinancePort)this).Get_Student_Historical_PaymentsAsync(new Get_Student_Historical_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Historical_Payments_Request = Get_Student_Historical_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Student_ChargesOutput Student_FinancePort.Import_Student_Charges(Import_Student_ChargesInput request)
		{
			return base.Channel.Import_Student_Charges(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Charges(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Charge_RequestType Import_Student_Charge_Request)
		{
			return ((Student_FinancePort)this).Import_Student_Charges(new Import_Student_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Charge_Request = Import_Student_Charge_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Student_ChargesOutput> Student_FinancePort.Import_Student_ChargesAsync(Import_Student_ChargesInput request)
		{
			return base.Channel.Import_Student_ChargesAsync(request);
		}

		public Task<Import_Student_ChargesOutput> Import_Student_ChargesAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Charge_RequestType Import_Student_Charge_Request)
		{
			return ((Student_FinancePort)this).Import_Student_ChargesAsync(new Import_Student_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Charge_Request = Import_Student_Charge_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Student_ChargesOutput Student_FinancePort.Import_Student_Historical_Charges(Import_Student_Historical_ChargesInput request)
		{
			return base.Channel.Import_Student_Historical_Charges(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Historical_Charges(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Historical_Charge_RequestType Import_Student_Historical_Charge_Request)
		{
			return ((Student_FinancePort)this).Import_Student_Historical_Charges(new Import_Student_Historical_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Historical_Charge_Request = Import_Student_Historical_Charge_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Student_ChargesOutput> Student_FinancePort.Import_Student_Historical_ChargesAsync(Import_Student_Historical_ChargesInput request)
		{
			return base.Channel.Import_Student_Historical_ChargesAsync(request);
		}

		public Task<Import_Student_ChargesOutput> Import_Student_Historical_ChargesAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Historical_Charge_RequestType Import_Student_Historical_Charge_Request)
		{
			return ((Student_FinancePort)this).Import_Student_Historical_ChargesAsync(new Import_Student_Historical_ChargesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Historical_Charge_Request = Import_Student_Historical_Charge_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Student_ChargesOutput Student_FinancePort.Import_Student_Historical_Payment(Import_Student_Historical_PaymentInput request)
		{
			return base.Channel.Import_Student_Historical_Payment(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Historical_Payment(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Historical_Payment_RequestType Import_Student_Historical_Payment_Request)
		{
			return ((Student_FinancePort)this).Import_Student_Historical_Payment(new Import_Student_Historical_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Historical_Payment_Request = Import_Student_Historical_Payment_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Student_ChargesOutput> Student_FinancePort.Import_Student_Historical_PaymentAsync(Import_Student_Historical_PaymentInput request)
		{
			return base.Channel.Import_Student_Historical_PaymentAsync(request);
		}

		public Task<Import_Student_ChargesOutput> Import_Student_Historical_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Historical_Payment_RequestType Import_Student_Historical_Payment_Request)
		{
			return ((Student_FinancePort)this).Import_Student_Historical_PaymentAsync(new Import_Student_Historical_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Historical_Payment_Request = Import_Student_Historical_Payment_Request
			});
		}
	}
}
