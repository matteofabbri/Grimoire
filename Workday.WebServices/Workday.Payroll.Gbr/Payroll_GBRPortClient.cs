using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Payroll_GBRPortClient : ClientBase<Payroll_GBRPort>, Payroll_GBRPort
	{
		public Payroll_GBRPortClient()
		{
		}

		public Payroll_GBRPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Payroll_GBRPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_GBRPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_GBRPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payee_Tax_CodeOutput Payroll_GBRPort.Put_Payee_Tax_Code(Put_Payee_Tax_CodeInput request)
		{
			return base.Channel.Put_Payee_Tax_Code(request);
		}

		public Put_Payee_Tax_Code_ResponseType Put_Payee_Tax_Code(Workday_Common_HeaderType Workday_Common_Header, Put_Payee_Tax_Code_RequestType Put_Payee_Tax_Code_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payee_Tax_Code(new Put_Payee_Tax_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payee_Tax_Code_Request = Put_Payee_Tax_Code_Request
			}).Put_Payee_Tax_Code_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payee_Tax_CodeOutput> Payroll_GBRPort.Put_Payee_Tax_CodeAsync(Put_Payee_Tax_CodeInput request)
		{
			return base.Channel.Put_Payee_Tax_CodeAsync(request);
		}

		public Task<Put_Payee_Tax_CodeOutput> Put_Payee_Tax_CodeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payee_Tax_Code_RequestType Put_Payee_Tax_Code_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payee_Tax_CodeAsync(new Put_Payee_Tax_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payee_Tax_Code_Request = Put_Payee_Tax_Code_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payee_Tax_CodesOutput Payroll_GBRPort.Get_Payee_Tax_Codes(Get_Payee_Tax_CodesInput request)
		{
			return base.Channel.Get_Payee_Tax_Codes(request);
		}

		public Get_Payee_Tax_Codes_ResponseType Get_Payee_Tax_Codes(Workday_Common_HeaderType Workday_Common_Header, Get_Payee_Tax_Codes_RequestType Get_Payee_Tax_Codes_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payee_Tax_Codes(new Get_Payee_Tax_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payee_Tax_Codes_Request = Get_Payee_Tax_Codes_Request
			}).Get_Payee_Tax_Codes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payee_Tax_CodesOutput> Payroll_GBRPort.Get_Payee_Tax_CodesAsync(Get_Payee_Tax_CodesInput request)
		{
			return base.Channel.Get_Payee_Tax_CodesAsync(request);
		}

		public Task<Get_Payee_Tax_CodesOutput> Get_Payee_Tax_CodesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payee_Tax_Codes_RequestType Get_Payee_Tax_Codes_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payee_Tax_CodesAsync(new Get_Payee_Tax_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payee_Tax_Codes_Request = Get_Payee_Tax_Codes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_Student_LoanOutput Payroll_GBRPort.Put_Payroll_Payee_Student_Loan(Put_Payroll_Payee_Student_LoanInput request)
		{
			return base.Channel.Put_Payroll_Payee_Student_Loan(request);
		}

		public Put_Payroll_Payee_Student_Loan_ResponseType Put_Payroll_Payee_Student_Loan(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_Student_Loan_RequestType Put_Payroll_Payee_Student_Loan_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_Payee_Student_Loan(new Put_Payroll_Payee_Student_LoanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_Student_Loan_Request = Put_Payroll_Payee_Student_Loan_Request
			}).Put_Payroll_Payee_Student_Loan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_Student_LoanOutput> Payroll_GBRPort.Put_Payroll_Payee_Student_LoanAsync(Put_Payroll_Payee_Student_LoanInput request)
		{
			return base.Channel.Put_Payroll_Payee_Student_LoanAsync(request);
		}

		public Task<Put_Payroll_Payee_Student_LoanOutput> Put_Payroll_Payee_Student_LoanAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_Student_Loan_RequestType Put_Payroll_Payee_Student_Loan_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_Payee_Student_LoanAsync(new Put_Payroll_Payee_Student_LoanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_Student_Loan_Request = Put_Payroll_Payee_Student_Loan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_Student_LoansOutput Payroll_GBRPort.Get_Payroll_Payee_Student_Loans(Get_Payroll_Payee_Student_LoansInput request)
		{
			return base.Channel.Get_Payroll_Payee_Student_Loans(request);
		}

		public Get_Payroll_Payee_Student_Loans_ResponseType Get_Payroll_Payee_Student_Loans(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_Student_Loans_RequestType Get_Payroll_Payee_Student_Loans_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_Payee_Student_Loans(new Get_Payroll_Payee_Student_LoansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_Student_Loans_Request = Get_Payroll_Payee_Student_Loans_Request
			}).Get_Payroll_Payee_Student_Loans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_Student_LoansOutput> Payroll_GBRPort.Get_Payroll_Payee_Student_LoansAsync(Get_Payroll_Payee_Student_LoansInput request)
		{
			return base.Channel.Get_Payroll_Payee_Student_LoansAsync(request);
		}

		public Task<Get_Payroll_Payee_Student_LoansOutput> Get_Payroll_Payee_Student_LoansAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_Student_Loans_RequestType Get_Payroll_Payee_Student_Loans_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_Payee_Student_LoansAsync(new Get_Payroll_Payee_Student_LoansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_Student_Loans_Request = Get_Payroll_Payee_Student_Loans_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_NIOutput Payroll_GBRPort.Put_Payroll_Payee_NI(Put_Payroll_Payee_NIInput request)
		{
			return base.Channel.Put_Payroll_Payee_NI(request);
		}

		public Put_Payroll_Payee_NI_ResponseType Put_Payroll_Payee_NI(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_NI_RequestType Put_Payroll_Payee_NI_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_Payee_NI(new Put_Payroll_Payee_NIInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_NI_Request = Put_Payroll_Payee_NI_Request
			}).Put_Payroll_Payee_NI_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_NIOutput> Payroll_GBRPort.Put_Payroll_Payee_NIAsync(Put_Payroll_Payee_NIInput request)
		{
			return base.Channel.Put_Payroll_Payee_NIAsync(request);
		}

		public Task<Put_Payroll_Payee_NIOutput> Put_Payroll_Payee_NIAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_NI_RequestType Put_Payroll_Payee_NI_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_Payee_NIAsync(new Put_Payroll_Payee_NIInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_NI_Request = Put_Payroll_Payee_NI_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_NIsOutput Payroll_GBRPort.Get_Payroll_Payee_NIs(Get_Payroll_Payee_NIsInput request)
		{
			return base.Channel.Get_Payroll_Payee_NIs(request);
		}

		public Get_Payroll_Payee_NIs_ResponseType Get_Payroll_Payee_NIs(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_NIs_RequestType Get_Payroll_Payee_NIs_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_Payee_NIs(new Get_Payroll_Payee_NIsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_NIs_Request = Get_Payroll_Payee_NIs_Request
			}).Get_Payroll_Payee_NIs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_NIsOutput> Payroll_GBRPort.Get_Payroll_Payee_NIsAsync(Get_Payroll_Payee_NIsInput request)
		{
			return base.Channel.Get_Payroll_Payee_NIsAsync(request);
		}

		public Task<Get_Payroll_Payee_NIsOutput> Get_Payroll_Payee_NIsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_NIs_RequestType Get_Payroll_Payee_NIs_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_Payee_NIsAsync(new Get_Payroll_Payee_NIsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_NIs_Request = Get_Payroll_Payee_NIs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_IDsOutput Payroll_GBRPort.Get_Payroll_IDs(Get_Payroll_IDsInput request)
		{
			return base.Channel.Get_Payroll_IDs(request);
		}

		public Get_Payroll_IDs_ResponseType Get_Payroll_IDs(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_IDs_RequestType Get_Payroll_IDs_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_IDs(new Get_Payroll_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_IDs_Request = Get_Payroll_IDs_Request
			}).Get_Payroll_IDs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_IDsOutput> Payroll_GBRPort.Get_Payroll_IDsAsync(Get_Payroll_IDsInput request)
		{
			return base.Channel.Get_Payroll_IDsAsync(request);
		}

		public Task<Get_Payroll_IDsOutput> Get_Payroll_IDsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_IDs_RequestType Get_Payroll_IDs_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_IDsAsync(new Get_Payroll_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_IDs_Request = Get_Payroll_IDs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_IDOutput Payroll_GBRPort.Put_Payroll_ID(Put_Payroll_IDInput request)
		{
			return base.Channel.Put_Payroll_ID(request);
		}

		public Put_Payroll_ID_ResponseType Put_Payroll_ID(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_ID_RequestType Put_Payroll_ID_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_ID(new Put_Payroll_IDInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_ID_Request = Put_Payroll_ID_Request
			}).Put_Payroll_ID_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_IDOutput> Payroll_GBRPort.Put_Payroll_IDAsync(Put_Payroll_IDInput request)
		{
			return base.Channel.Put_Payroll_IDAsync(request);
		}

		public Task<Put_Payroll_IDOutput> Put_Payroll_IDAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_ID_RequestType Put_Payroll_ID_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_IDAsync(new Put_Payroll_IDInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_ID_Request = Put_Payroll_ID_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_SSP_HistoryOutput Payroll_GBRPort.Put_Payroll_SSP_History(Put_Payroll_SSP_HistoryInput request)
		{
			return base.Channel.Put_Payroll_SSP_History(request);
		}

		public Put_Payroll_SSP_History_ResponseType Put_Payroll_SSP_History(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_SSP_History_RequestType Put_Payroll_SSP_History_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_SSP_History(new Put_Payroll_SSP_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_SSP_History_Request = Put_Payroll_SSP_History_Request
			}).Put_Payroll_SSP_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_SSP_HistoryOutput> Payroll_GBRPort.Put_Payroll_SSP_HistoryAsync(Put_Payroll_SSP_HistoryInput request)
		{
			return base.Channel.Put_Payroll_SSP_HistoryAsync(request);
		}

		public Task<Put_Payroll_SSP_HistoryOutput> Put_Payroll_SSP_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_SSP_History_RequestType Put_Payroll_SSP_History_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_SSP_HistoryAsync(new Put_Payroll_SSP_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_SSP_History_Request = Put_Payroll_SSP_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_SSP_HistoryOutput Payroll_GBRPort.Get_Payroll_SSP_History(Get_Payroll_SSP_HistoryInput request)
		{
			return base.Channel.Get_Payroll_SSP_History(request);
		}

		public Get_Payroll_SSP_History_ResponseType Get_Payroll_SSP_History(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_SSP_History_RequestType Get_Payroll_SSP_History_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_SSP_History(new Get_Payroll_SSP_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_SSP_History_Request = Get_Payroll_SSP_History_Request
			}).Get_Payroll_SSP_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_SSP_HistoryOutput> Payroll_GBRPort.Get_Payroll_SSP_HistoryAsync(Get_Payroll_SSP_HistoryInput request)
		{
			return base.Channel.Get_Payroll_SSP_HistoryAsync(request);
		}

		public Task<Get_Payroll_SSP_HistoryOutput> Get_Payroll_SSP_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_SSP_History_RequestType Get_Payroll_SSP_History_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_SSP_HistoryAsync(new Get_Payroll_SSP_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_SSP_History_Request = Get_Payroll_SSP_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput Payroll_GBRPort.Put_Pensions_Auto_Enrolment_External_Assessment_History(Put_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request)
		{
			return base.Channel.Put_Pensions_Auto_Enrolment_External_Assessment_History(request);
		}

		public Put_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType Put_Pensions_Auto_Enrolment_External_Assessment_History(Workday_Common_HeaderType Workday_Common_Header, Put_Pensions_Auto_Enrolment_External_Assessment_History_RequestType Put_Pensions_Auto_Enrolment_External_Assessment_History_Request)
		{
			return ((Payroll_GBRPort)this).Put_Pensions_Auto_Enrolment_External_Assessment_History(new Put_Pensions_Auto_Enrolment_External_Assessment_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Pensions_Auto_Enrolment_External_Assessment_History_Request = Put_Pensions_Auto_Enrolment_External_Assessment_History_Request
			}).Put_Pensions_Auto_Enrolment_External_Assessment_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput> Payroll_GBRPort.Put_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(Put_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request)
		{
			return base.Channel.Put_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(request);
		}

		public Task<Put_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput> Put_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Pensions_Auto_Enrolment_External_Assessment_History_RequestType Put_Pensions_Auto_Enrolment_External_Assessment_History_Request)
		{
			return ((Payroll_GBRPort)this).Put_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(new Put_Pensions_Auto_Enrolment_External_Assessment_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Pensions_Auto_Enrolment_External_Assessment_History_Request = Put_Pensions_Auto_Enrolment_External_Assessment_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput Payroll_GBRPort.Get_Pensions_Auto_Enrolment_External_Assessment_History(Get_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request)
		{
			return base.Channel.Get_Pensions_Auto_Enrolment_External_Assessment_History(request);
		}

		public Get_Pensions_Auto_Enrolment_External_Assessment_History_ResponseType Get_Pensions_Auto_Enrolment_External_Assessment_History(Workday_Common_HeaderType Workday_Common_Header, Get_Pensions_Auto_Enrolment_External_Assessment_History_RequestType Get_Pensions_Auto_Enrolment_External_Assessment_History_Request)
		{
			return ((Payroll_GBRPort)this).Get_Pensions_Auto_Enrolment_External_Assessment_History(new Get_Pensions_Auto_Enrolment_External_Assessment_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Pensions_Auto_Enrolment_External_Assessment_History_Request = Get_Pensions_Auto_Enrolment_External_Assessment_History_Request
			}).Get_Pensions_Auto_Enrolment_External_Assessment_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput> Payroll_GBRPort.Get_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(Get_Pensions_Auto_Enrolment_External_Assessment_HistoryInput request)
		{
			return base.Channel.Get_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(request);
		}

		public Task<Get_Pensions_Auto_Enrolment_External_Assessment_HistoryOutput> Get_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Pensions_Auto_Enrolment_External_Assessment_History_RequestType Get_Pensions_Auto_Enrolment_External_Assessment_History_Request)
		{
			return ((Payroll_GBRPort)this).Get_Pensions_Auto_Enrolment_External_Assessment_HistoryAsync(new Get_Pensions_Auto_Enrolment_External_Assessment_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Pensions_Auto_Enrolment_External_Assessment_History_Request = Get_Pensions_Auto_Enrolment_External_Assessment_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Worker_Pensions_Auto_Enrolment_DetailsOutput Payroll_GBRPort.Put_Worker_Pensions_Auto_Enrolment_Details(Put_Worker_Pensions_Auto_Enrolment_DetailsInput request)
		{
			return base.Channel.Put_Worker_Pensions_Auto_Enrolment_Details(request);
		}

		public Put_Worker_Pensions_Auto_Enrolment_Details_ResponseType Put_Worker_Pensions_Auto_Enrolment_Details(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Pensions_Auto_Enrolment_Details_RequestType Put_Worker_Pensions_Auto_Enrolment_Details_Request)
		{
			return ((Payroll_GBRPort)this).Put_Worker_Pensions_Auto_Enrolment_Details(new Put_Worker_Pensions_Auto_Enrolment_DetailsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Pensions_Auto_Enrolment_Details_Request = Put_Worker_Pensions_Auto_Enrolment_Details_Request
			}).Put_Worker_Pensions_Auto_Enrolment_Details_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Worker_Pensions_Auto_Enrolment_DetailsOutput> Payroll_GBRPort.Put_Worker_Pensions_Auto_Enrolment_DetailsAsync(Put_Worker_Pensions_Auto_Enrolment_DetailsInput request)
		{
			return base.Channel.Put_Worker_Pensions_Auto_Enrolment_DetailsAsync(request);
		}

		public Task<Put_Worker_Pensions_Auto_Enrolment_DetailsOutput> Put_Worker_Pensions_Auto_Enrolment_DetailsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Pensions_Auto_Enrolment_Details_RequestType Put_Worker_Pensions_Auto_Enrolment_Details_Request)
		{
			return ((Payroll_GBRPort)this).Put_Worker_Pensions_Auto_Enrolment_DetailsAsync(new Put_Worker_Pensions_Auto_Enrolment_DetailsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Pensions_Auto_Enrolment_Details_Request = Put_Worker_Pensions_Auto_Enrolment_Details_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_Pensions_Auto_Enrolment_DetailsOutput Payroll_GBRPort.Get_Worker_Pensions_Auto_Enrolment_Details(Get_Worker_Pensions_Auto_Enrolment_DetailsInput request)
		{
			return base.Channel.Get_Worker_Pensions_Auto_Enrolment_Details(request);
		}

		public Get_Worker_Pensions_Auto_Enrolment_Details_ResponseType Get_Worker_Pensions_Auto_Enrolment_Details(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Pensions_Auto_Enrolment_Details_RequestType Get_Worker_Pensions_Auto_Enrolment_Details_Request)
		{
			return ((Payroll_GBRPort)this).Get_Worker_Pensions_Auto_Enrolment_Details(new Get_Worker_Pensions_Auto_Enrolment_DetailsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Pensions_Auto_Enrolment_Details_Request = Get_Worker_Pensions_Auto_Enrolment_Details_Request
			}).Get_Worker_Pensions_Auto_Enrolment_Details_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_Pensions_Auto_Enrolment_DetailsOutput> Payroll_GBRPort.Get_Worker_Pensions_Auto_Enrolment_DetailsAsync(Get_Worker_Pensions_Auto_Enrolment_DetailsInput request)
		{
			return base.Channel.Get_Worker_Pensions_Auto_Enrolment_DetailsAsync(request);
		}

		public Task<Get_Worker_Pensions_Auto_Enrolment_DetailsOutput> Get_Worker_Pensions_Auto_Enrolment_DetailsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Pensions_Auto_Enrolment_Details_RequestType Get_Worker_Pensions_Auto_Enrolment_Details_Request)
		{
			return ((Payroll_GBRPort)this).Get_Worker_Pensions_Auto_Enrolment_DetailsAsync(new Get_Worker_Pensions_Auto_Enrolment_DetailsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Pensions_Auto_Enrolment_Details_Request = Get_Worker_Pensions_Auto_Enrolment_Details_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_RTIOutput Payroll_GBRPort.Put_Payroll_Payee_RTI(Put_Payroll_Payee_RTIInput request)
		{
			return base.Channel.Put_Payroll_Payee_RTI(request);
		}

		public Put_Payroll_Payee_RTI_ResponseType Put_Payroll_Payee_RTI(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_RTI_RequestType Put_Payroll_Payee_RTI_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_Payee_RTI(new Put_Payroll_Payee_RTIInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_RTI_Request = Put_Payroll_Payee_RTI_Request
			}).Put_Payroll_Payee_RTI_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_RTIOutput> Payroll_GBRPort.Put_Payroll_Payee_RTIAsync(Put_Payroll_Payee_RTIInput request)
		{
			return base.Channel.Put_Payroll_Payee_RTIAsync(request);
		}

		public Task<Put_Payroll_Payee_RTIOutput> Put_Payroll_Payee_RTIAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_RTI_RequestType Put_Payroll_Payee_RTI_Request)
		{
			return ((Payroll_GBRPort)this).Put_Payroll_Payee_RTIAsync(new Put_Payroll_Payee_RTIInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_RTI_Request = Put_Payroll_Payee_RTI_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_RTIsOutput Payroll_GBRPort.Get_Payroll_Payee_RTIs(Get_Payroll_Payee_RTIsInput request)
		{
			return base.Channel.Get_Payroll_Payee_RTIs(request);
		}

		public Get_Payroll_Payee_RTIs_ResponseType Get_Payroll_Payee_RTIs(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_RTIs_RequestType Get_Payroll_Payee_RTIs_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_Payee_RTIs(new Get_Payroll_Payee_RTIsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_RTIs_Request = Get_Payroll_Payee_RTIs_Request
			}).Get_Payroll_Payee_RTIs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_RTIsOutput> Payroll_GBRPort.Get_Payroll_Payee_RTIsAsync(Get_Payroll_Payee_RTIsInput request)
		{
			return base.Channel.Get_Payroll_Payee_RTIsAsync(request);
		}

		public Task<Get_Payroll_Payee_RTIsOutput> Get_Payroll_Payee_RTIsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_RTIs_RequestType Get_Payroll_Payee_RTIs_Request)
		{
			return ((Payroll_GBRPort)this).Get_Payroll_Payee_RTIsAsync(new Get_Payroll_Payee_RTIsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_RTIs_Request = Get_Payroll_Payee_RTIs_Request
			});
		}
	}
}
