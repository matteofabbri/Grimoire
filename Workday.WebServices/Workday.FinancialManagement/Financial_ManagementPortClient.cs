using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Financial_ManagementPortClient : ClientBase<Financial_ManagementPort>, Financial_ManagementPort
	{
		public Financial_ManagementPortClient()
		{
		}

		public Financial_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Financial_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Financial_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Financial_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Accounting_JournalOutput Financial_ManagementPort.Submit_Accounting_Journal(Submit_Accounting_JournalInput request)
		{
			return base.Channel.Submit_Accounting_Journal(request);
		}

		public Submit_Accounting_Journal_ResponseType Submit_Accounting_Journal(Workday_Common_HeaderType Workday_Common_Header, Submit_Accounting_Journal_RequestType Submit_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Accounting_Journal(new Submit_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Accounting_Journal_Request = Submit_Accounting_Journal_Request
			}).Submit_Accounting_Journal_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Accounting_JournalOutput> Financial_ManagementPort.Submit_Accounting_JournalAsync(Submit_Accounting_JournalInput request)
		{
			return base.Channel.Submit_Accounting_JournalAsync(request);
		}

		public Task<Submit_Accounting_JournalOutput> Submit_Accounting_JournalAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Accounting_Journal_RequestType Submit_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Accounting_JournalAsync(new Submit_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Accounting_Journal_Request = Submit_Accounting_Journal_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Currency_Conversion_RateOutput Financial_ManagementPort.Put_Currency_Conversion_Rate(Put_Currency_Conversion_RateInput request)
		{
			return base.Channel.Put_Currency_Conversion_Rate(request);
		}

		public Put_Currency_Conversion_Rate_ResponseType Put_Currency_Conversion_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Conversion_Rate_RequestType Put_Currency_Conversion_Rate_Request)
		{
			return ((Financial_ManagementPort)this).Put_Currency_Conversion_Rate(new Put_Currency_Conversion_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Currency_Conversion_Rate_Request = Put_Currency_Conversion_Rate_Request
			}).Put_Currency_Conversion_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Currency_Conversion_RateOutput> Financial_ManagementPort.Put_Currency_Conversion_RateAsync(Put_Currency_Conversion_RateInput request)
		{
			return base.Channel.Put_Currency_Conversion_RateAsync(request);
		}

		public Task<Put_Currency_Conversion_RateOutput> Put_Currency_Conversion_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Conversion_Rate_RequestType Put_Currency_Conversion_Rate_Request)
		{
			return ((Financial_ManagementPort)this).Put_Currency_Conversion_RateAsync(new Put_Currency_Conversion_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Currency_Conversion_Rate_Request = Put_Currency_Conversion_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_JournalsOutput Financial_ManagementPort.Get_Journals(Get_JournalsInput request)
		{
			return base.Channel.Get_Journals(request);
		}

		public Get_Journals_ResponseType Get_Journals(Workday_Common_HeaderType Workday_Common_Header, Get_Journals_RequestType Get_Journals_Request)
		{
			return ((Financial_ManagementPort)this).Get_Journals(new Get_JournalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Journals_Request = Get_Journals_Request
			}).Get_Journals_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_JournalsOutput> Financial_ManagementPort.Get_JournalsAsync(Get_JournalsInput request)
		{
			return base.Channel.Get_JournalsAsync(request);
		}

		public Task<Get_JournalsOutput> Get_JournalsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Journals_RequestType Get_Journals_Request)
		{
			return ((Financial_ManagementPort)this).Get_JournalsAsync(new Get_JournalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Journals_Request = Get_Journals_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CompaniesOutput Financial_ManagementPort.Get_Companies(Get_CompaniesInput request)
		{
			return base.Channel.Get_Companies(request);
		}

		public Get_Companies_ResponseType Get_Companies(Workday_Common_HeaderType Workday_Common_Header, Get_Companies_RequestType Get_Companies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Companies(new Get_CompaniesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Companies_Request = Get_Companies_Request
			}).Get_Companies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CompaniesOutput> Financial_ManagementPort.Get_CompaniesAsync(Get_CompaniesInput request)
		{
			return base.Channel.Get_CompaniesAsync(request);
		}

		public Task<Get_CompaniesOutput> Get_CompaniesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Companies_RequestType Get_Companies_Request)
		{
			return ((Financial_ManagementPort)this).Get_CompaniesAsync(new Get_CompaniesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Companies_Request = Get_Companies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Revenue_CategoriesOutput Financial_ManagementPort.Get_Revenue_Categories(Get_Revenue_CategoriesInput request)
		{
			return base.Channel.Get_Revenue_Categories(request);
		}

		public Get_Revenue_Categories_ResponseType Get_Revenue_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Categories_RequestType Get_Revenue_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Revenue_Categories(new Get_Revenue_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Categories_Request = Get_Revenue_Categories_Request
			}).Get_Revenue_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Revenue_CategoriesOutput> Financial_ManagementPort.Get_Revenue_CategoriesAsync(Get_Revenue_CategoriesInput request)
		{
			return base.Channel.Get_Revenue_CategoriesAsync(request);
		}

		public Task<Get_Revenue_CategoriesOutput> Get_Revenue_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Categories_RequestType Get_Revenue_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Revenue_CategoriesAsync(new Get_Revenue_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Categories_Request = Get_Revenue_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Resource_CategoriesOutput Financial_ManagementPort.Get_Resource_Categories(Get_Resource_CategoriesInput request)
		{
			return base.Channel.Get_Resource_Categories(request);
		}

		public Get_Resource_Categories_ResponseType Get_Resource_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Categories_RequestType Get_Resource_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Resource_Categories(new Get_Resource_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Categories_Request = Get_Resource_Categories_Request
			}).Get_Resource_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Resource_CategoriesOutput> Financial_ManagementPort.Get_Resource_CategoriesAsync(Get_Resource_CategoriesInput request)
		{
			return base.Channel.Get_Resource_CategoriesAsync(request);
		}

		public Task<Get_Resource_CategoriesOutput> Get_Resource_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Resource_Categories_RequestType Get_Resource_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Resource_CategoriesAsync(new Get_Resource_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Resource_Categories_Request = Get_Resource_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Resource_CategoryOutput Financial_ManagementPort.Put_Resource_Category(Put_Resource_CategoryInput request)
		{
			return base.Channel.Put_Resource_Category(request);
		}

		public Put_Resource_Category_ResponseType Put_Resource_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Resource_Category_RequestType Put_Resource_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Resource_Category(new Put_Resource_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Resource_Category_Request = Put_Resource_Category_Request
			}).Put_Resource_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Resource_CategoryOutput> Financial_ManagementPort.Put_Resource_CategoryAsync(Put_Resource_CategoryInput request)
		{
			return base.Channel.Put_Resource_CategoryAsync(request);
		}

		public Task<Put_Resource_CategoryOutput> Put_Resource_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Resource_Category_RequestType Put_Resource_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Resource_CategoryAsync(new Put_Resource_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Resource_Category_Request = Put_Resource_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Revenue_CategoryOutput Financial_ManagementPort.Put_Revenue_Category(Put_Revenue_CategoryInput request)
		{
			return base.Channel.Put_Revenue_Category(request);
		}

		public Put_Revenue_Category_ResponseType Put_Revenue_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_RequestType Put_Revenue_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Revenue_Category(new Put_Revenue_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Request = Put_Revenue_Category_Request
			}).Put_Revenue_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Revenue_CategoryOutput> Financial_ManagementPort.Put_Revenue_CategoryAsync(Put_Revenue_CategoryInput request)
		{
			return base.Channel.Put_Revenue_CategoryAsync(request);
		}

		public Task<Put_Revenue_CategoryOutput> Put_Revenue_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_RequestType Put_Revenue_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Revenue_CategoryAsync(new Put_Revenue_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Request = Put_Revenue_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_TermsOutput Financial_ManagementPort.Get_Payment_Terms(Get_Payment_TermsInput request)
		{
			return base.Channel.Get_Payment_Terms(request);
		}

		public Get_Payment_Terms_ResponseType Get_Payment_Terms(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Terms_RequestType Get_Payment_Terms_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payment_Terms(new Get_Payment_TermsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Terms_Request = Get_Payment_Terms_Request
			}).Get_Payment_Terms_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_TermsOutput> Financial_ManagementPort.Get_Payment_TermsAsync(Get_Payment_TermsInput request)
		{
			return base.Channel.Get_Payment_TermsAsync(request);
		}

		public Task<Get_Payment_TermsOutput> Get_Payment_TermsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Terms_RequestType Get_Payment_Terms_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payment_TermsAsync(new Get_Payment_TermsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Terms_Request = Get_Payment_Terms_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payment_TermOutput Financial_ManagementPort.Put_Payment_Term(Put_Payment_TermInput request)
		{
			return base.Channel.Put_Payment_Term(request);
		}

		public Put_Payment_Term_ResponseType Put_Payment_Term(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Term_RequestType Put_Payment_Term_Request)
		{
			return ((Financial_ManagementPort)this).Put_Payment_Term(new Put_Payment_TermInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Term_Request = Put_Payment_Term_Request
			}).Put_Payment_Term_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payment_TermOutput> Financial_ManagementPort.Put_Payment_TermAsync(Put_Payment_TermInput request)
		{
			return base.Channel.Put_Payment_TermAsync(request);
		}

		public Task<Put_Payment_TermOutput> Put_Payment_TermAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Term_RequestType Put_Payment_Term_Request)
		{
			return ((Financial_ManagementPort)this).Put_Payment_TermAsync(new Put_Payment_TermInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Term_Request = Put_Payment_Term_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Transaction_Tax_CodesOutput Financial_ManagementPort.Get_Transaction_Tax_Codes(Get_Transaction_Tax_CodesInput request)
		{
			return base.Channel.Get_Transaction_Tax_Codes(request);
		}

		public Get_Tax_Codes_ResponseType Get_Transaction_Tax_Codes(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Codes_RequestType Get_Tax_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_Codes(new Get_Transaction_Tax_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Codes_Request = Get_Tax_Codes_Request
			}).Get_Tax_Codes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Transaction_Tax_CodesOutput> Financial_ManagementPort.Get_Transaction_Tax_CodesAsync(Get_Transaction_Tax_CodesInput request)
		{
			return base.Channel.Get_Transaction_Tax_CodesAsync(request);
		}

		public Task<Get_Transaction_Tax_CodesOutput> Get_Transaction_Tax_CodesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Codes_RequestType Get_Tax_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_CodesAsync(new Get_Transaction_Tax_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Codes_Request = Get_Tax_Codes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Transaction_Tax_CodeOutput Financial_ManagementPort.Put_Transaction_Tax_Code(Put_Transaction_Tax_CodeInput request)
		{
			return base.Channel.Put_Transaction_Tax_Code(request);
		}

		public Put_Tax_Code_ResponseType Put_Transaction_Tax_Code(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Code_RequestType Put_Tax_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_Code(new Put_Transaction_Tax_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Code_Request = Put_Tax_Code_Request
			}).Put_Tax_Code_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Transaction_Tax_CodeOutput> Financial_ManagementPort.Put_Transaction_Tax_CodeAsync(Put_Transaction_Tax_CodeInput request)
		{
			return base.Channel.Put_Transaction_Tax_CodeAsync(request);
		}

		public Task<Put_Transaction_Tax_CodeOutput> Put_Transaction_Tax_CodeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Code_RequestType Put_Tax_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_CodeAsync(new Put_Transaction_Tax_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Code_Request = Put_Tax_Code_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Tax_ApplicabilitiesOutput Financial_ManagementPort.Get_Tax_Applicabilities(Get_Tax_ApplicabilitiesInput request)
		{
			return base.Channel.Get_Tax_Applicabilities(request);
		}

		public Get_Tax_Applicabilities_ResponseType Get_Tax_Applicabilities(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Applicabilities_RequestType Get_Tax_Applicabilities_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_Applicabilities(new Get_Tax_ApplicabilitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Applicabilities_Request = Get_Tax_Applicabilities_Request
			}).Get_Tax_Applicabilities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Tax_ApplicabilitiesOutput> Financial_ManagementPort.Get_Tax_ApplicabilitiesAsync(Get_Tax_ApplicabilitiesInput request)
		{
			return base.Channel.Get_Tax_ApplicabilitiesAsync(request);
		}

		public Task<Get_Tax_ApplicabilitiesOutput> Get_Tax_ApplicabilitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Applicabilities_RequestType Get_Tax_Applicabilities_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_ApplicabilitiesAsync(new Get_Tax_ApplicabilitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Applicabilities_Request = Get_Tax_Applicabilities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Tax_ApplicabilityOutput Financial_ManagementPort.Put_Tax_Applicability(Put_Tax_ApplicabilityInput request)
		{
			return base.Channel.Put_Tax_Applicability(request);
		}

		public Put_Tax_Applicability_ResponseType Put_Tax_Applicability(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Applicability_RequestType Put_Tax_Applicability_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_Applicability(new Put_Tax_ApplicabilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Applicability_Request = Put_Tax_Applicability_Request
			}).Put_Tax_Applicability_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Tax_ApplicabilityOutput> Financial_ManagementPort.Put_Tax_ApplicabilityAsync(Put_Tax_ApplicabilityInput request)
		{
			return base.Channel.Put_Tax_ApplicabilityAsync(request);
		}

		public Task<Put_Tax_ApplicabilityOutput> Put_Tax_ApplicabilityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Applicability_RequestType Put_Tax_Applicability_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_ApplicabilityAsync(new Put_Tax_ApplicabilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Applicability_Request = Put_Tax_Applicability_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_TypesOutput Financial_ManagementPort.Get_Payment_Types(Get_Payment_TypesInput request)
		{
			return base.Channel.Get_Payment_Types(request);
		}

		public Get_Payment_Types_ResponseType Get_Payment_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Types_RequestType Get_Payment_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payment_Types(new Get_Payment_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Types_Request = Get_Payment_Types_Request
			}).Get_Payment_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_TypesOutput> Financial_ManagementPort.Get_Payment_TypesAsync(Get_Payment_TypesInput request)
		{
			return base.Channel.Get_Payment_TypesAsync(request);
		}

		public Task<Get_Payment_TypesOutput> Get_Payment_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Types_RequestType Get_Payment_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payment_TypesAsync(new Get_Payment_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Types_Request = Get_Payment_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payment_TypeOutput Financial_ManagementPort.Put_Payment_Type(Put_Payment_TypeInput request)
		{
			return base.Channel.Put_Payment_Type(request);
		}

		public Put_Payment_Type_ResponseType Put_Payment_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Type_RequestType Put_Payment_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Payment_Type(new Put_Payment_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Type_Request = Put_Payment_Type_Request
			}).Put_Payment_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payment_TypeOutput> Financial_ManagementPort.Put_Payment_TypeAsync(Put_Payment_TypeInput request)
		{
			return base.Channel.Put_Payment_TypeAsync(request);
		}

		public Task<Put_Payment_TypeOutput> Put_Payment_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Type_RequestType Put_Payment_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Payment_TypeAsync(new Put_Payment_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Type_Request = Put_Payment_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Transaction_Tax_RatesOutput Financial_ManagementPort.Get_Transaction_Tax_Rates(Get_Transaction_Tax_RatesInput request)
		{
			return base.Channel.Get_Transaction_Tax_Rates(request);
		}

		public Get_Tax_Rates_ResponseType Get_Transaction_Tax_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Rates_RequestType Get_Tax_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_Rates(new Get_Transaction_Tax_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Rates_Request = Get_Tax_Rates_Request
			}).Get_Tax_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Transaction_Tax_RatesOutput> Financial_ManagementPort.Get_Transaction_Tax_RatesAsync(Get_Transaction_Tax_RatesInput request)
		{
			return base.Channel.Get_Transaction_Tax_RatesAsync(request);
		}

		public Task<Get_Transaction_Tax_RatesOutput> Get_Transaction_Tax_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Rates_RequestType Get_Tax_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_RatesAsync(new Get_Transaction_Tax_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Rates_Request = Get_Tax_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Transaction_Tax_RateOutput Financial_ManagementPort.Put_Transaction_Tax_Rate(Put_Transaction_Tax_RateInput request)
		{
			return base.Channel.Put_Transaction_Tax_Rate(request);
		}

		public Put_Tax_Rate_ResponseType Put_Transaction_Tax_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Rate_RequestType Put_Tax_Rate_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_Rate(new Put_Transaction_Tax_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Rate_Request = Put_Tax_Rate_Request
			}).Put_Tax_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Transaction_Tax_RateOutput> Financial_ManagementPort.Put_Transaction_Tax_RateAsync(Put_Transaction_Tax_RateInput request)
		{
			return base.Channel.Put_Transaction_Tax_RateAsync(request);
		}

		public Task<Put_Transaction_Tax_RateOutput> Put_Transaction_Tax_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Rate_RequestType Put_Tax_Rate_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_RateAsync(new Put_Transaction_Tax_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Rate_Request = Put_Tax_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supplier_CategoriesOutput Financial_ManagementPort.Get_Supplier_Categories(Get_Supplier_CategoriesInput request)
		{
			return base.Channel.Get_Supplier_Categories(request);
		}

		public Get_Supplier_Categories_ResponseType Get_Supplier_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Categories_RequestType Get_Supplier_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Supplier_Categories(new Get_Supplier_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Categories_Request = Get_Supplier_Categories_Request
			}).Get_Supplier_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supplier_CategoriesOutput> Financial_ManagementPort.Get_Supplier_CategoriesAsync(Get_Supplier_CategoriesInput request)
		{
			return base.Channel.Get_Supplier_CategoriesAsync(request);
		}

		public Task<Get_Supplier_CategoriesOutput> Get_Supplier_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Supplier_Categories_RequestType Get_Supplier_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Supplier_CategoriesAsync(new Get_Supplier_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Supplier_Categories_Request = Get_Supplier_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Supplier_CategoryOutput Financial_ManagementPort.Put_Supplier_Category(Put_Supplier_CategoryInput request)
		{
			return base.Channel.Put_Supplier_Category(request);
		}

		public Put_Supplier_Category_ResponseType Put_Supplier_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Category_RequestType Put_Supplier_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Supplier_Category(new Put_Supplier_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Category_Request = Put_Supplier_Category_Request
			}).Put_Supplier_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Supplier_CategoryOutput> Financial_ManagementPort.Put_Supplier_CategoryAsync(Put_Supplier_CategoryInput request)
		{
			return base.Channel.Put_Supplier_CategoryAsync(request);
		}

		public Task<Put_Supplier_CategoryOutput> Put_Supplier_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Supplier_Category_RequestType Put_Supplier_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Supplier_CategoryAsync(new Put_Supplier_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Supplier_Category_Request = Put_Supplier_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Customer_CategoriesOutput Financial_ManagementPort.Get_Customer_Categories(Get_Customer_CategoriesInput request)
		{
			return base.Channel.Get_Customer_Categories(request);
		}

		public Get_Customer_Categories_ResponseType Get_Customer_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Categories_RequestType Get_Customer_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Customer_Categories(new Get_Customer_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Categories_Request = Get_Customer_Categories_Request
			}).Get_Customer_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Customer_CategoriesOutput> Financial_ManagementPort.Get_Customer_CategoriesAsync(Get_Customer_CategoriesInput request)
		{
			return base.Channel.Get_Customer_CategoriesAsync(request);
		}

		public Task<Get_Customer_CategoriesOutput> Get_Customer_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Categories_RequestType Get_Customer_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Customer_CategoriesAsync(new Get_Customer_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Customer_Categories_Request = Get_Customer_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Customer_CategoryOutput Financial_ManagementPort.Put_Customer_Category(Put_Customer_CategoryInput request)
		{
			return base.Channel.Put_Customer_Category(request);
		}

		public Put_Customer_Category_ResponseType Put_Customer_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Category_RequestType Put_Customer_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Customer_Category(new Put_Customer_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Category_Request = Put_Customer_Category_Request
			}).Put_Customer_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Customer_CategoryOutput> Financial_ManagementPort.Put_Customer_CategoryAsync(Put_Customer_CategoryInput request)
		{
			return base.Channel.Put_Customer_CategoryAsync(request);
		}

		public Task<Put_Customer_CategoryOutput> Put_Customer_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_Category_RequestType Put_Customer_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Customer_CategoryAsync(new Put_Customer_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Customer_Category_Request = Put_Customer_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Currency_Rate_TypesOutput Financial_ManagementPort.Get_Currency_Rate_Types(Get_Currency_Rate_TypesInput request)
		{
			return base.Channel.Get_Currency_Rate_Types(request);
		}

		public Get_Currency_Rate_Types_ResponseType Get_Currency_Rate_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Currency_Rate_Types_RequestType Get_Currency_Rate_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Currency_Rate_Types(new Get_Currency_Rate_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Currency_Rate_Types_Request = Get_Currency_Rate_Types_Request
			}).Get_Currency_Rate_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Currency_Rate_TypesOutput> Financial_ManagementPort.Get_Currency_Rate_TypesAsync(Get_Currency_Rate_TypesInput request)
		{
			return base.Channel.Get_Currency_Rate_TypesAsync(request);
		}

		public Task<Get_Currency_Rate_TypesOutput> Get_Currency_Rate_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Currency_Rate_Types_RequestType Get_Currency_Rate_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Currency_Rate_TypesAsync(new Get_Currency_Rate_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Currency_Rate_Types_Request = Get_Currency_Rate_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Currency_Rate_TypeOutput Financial_ManagementPort.Put_Currency_Rate_Type(Put_Currency_Rate_TypeInput request)
		{
			return base.Channel.Put_Currency_Rate_Type(request);
		}

		public Put_Currency_Rate_Type_ResponseType Put_Currency_Rate_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Rate_Type_RequestType Put_Currency_Rate_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Currency_Rate_Type(new Put_Currency_Rate_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Currency_Rate_Type_Request = Put_Currency_Rate_Type_Request
			}).Put_Currency_Rate_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Currency_Rate_TypeOutput> Financial_ManagementPort.Put_Currency_Rate_TypeAsync(Put_Currency_Rate_TypeInput request)
		{
			return base.Channel.Put_Currency_Rate_TypeAsync(request);
		}

		public Task<Put_Currency_Rate_TypeOutput> Put_Currency_Rate_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Rate_Type_RequestType Put_Currency_Rate_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Currency_Rate_TypeAsync(new Put_Currency_Rate_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Currency_Rate_Type_Request = Put_Currency_Rate_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Currency_Conversion_RatesOutput Financial_ManagementPort.Get_Currency_Conversion_Rates(Get_Currency_Conversion_RatesInput request)
		{
			return base.Channel.Get_Currency_Conversion_Rates(request);
		}

		public Get_Currency_Conversion_Rates_ResponseType Get_Currency_Conversion_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Currency_Conversion_Rates_RequestType Get_Currency_Conversion_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Currency_Conversion_Rates(new Get_Currency_Conversion_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Currency_Conversion_Rates_Request = Get_Currency_Conversion_Rates_Request
			}).Get_Currency_Conversion_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Currency_Conversion_RatesOutput> Financial_ManagementPort.Get_Currency_Conversion_RatesAsync(Get_Currency_Conversion_RatesInput request)
		{
			return base.Channel.Get_Currency_Conversion_RatesAsync(request);
		}

		public Task<Get_Currency_Conversion_RatesOutput> Get_Currency_Conversion_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Currency_Conversion_Rates_RequestType Get_Currency_Conversion_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Currency_Conversion_RatesAsync(new Get_Currency_Conversion_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Currency_Conversion_Rates_Request = Get_Currency_Conversion_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Tax_CategoriesOutput Financial_ManagementPort.Get_Tax_Categories(Get_Tax_CategoriesInput request)
		{
			return base.Channel.Get_Tax_Categories(request);
		}

		public Get_Tax_Categories_ResponseType Get_Tax_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Categories_RequestType Get_Tax_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_Categories(new Get_Tax_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Categories_Request = Get_Tax_Categories_Request
			}).Get_Tax_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Tax_CategoriesOutput> Financial_ManagementPort.Get_Tax_CategoriesAsync(Get_Tax_CategoriesInput request)
		{
			return base.Channel.Get_Tax_CategoriesAsync(request);
		}

		public Task<Get_Tax_CategoriesOutput> Get_Tax_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Categories_RequestType Get_Tax_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_CategoriesAsync(new Get_Tax_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Categories_Request = Get_Tax_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Tax_CategoryOutput Financial_ManagementPort.Put_Tax_Category(Put_Tax_CategoryInput request)
		{
			return base.Channel.Put_Tax_Category(request);
		}

		public Put_Tax_Category_ResponseType Put_Tax_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Category_RequestType Put_Tax_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_Category(new Put_Tax_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Category_Request = Put_Tax_Category_Request
			}).Put_Tax_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Tax_CategoryOutput> Financial_ManagementPort.Put_Tax_CategoryAsync(Put_Tax_CategoryInput request)
		{
			return base.Channel.Put_Tax_CategoryAsync(request);
		}

		public Task<Put_Tax_CategoryOutput> Put_Tax_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Category_RequestType Put_Tax_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_CategoryAsync(new Put_Tax_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Category_Request = Put_Tax_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Tax_AuthoritiesOutput Financial_ManagementPort.Get_Tax_Authorities(Get_Tax_AuthoritiesInput request)
		{
			return base.Channel.Get_Tax_Authorities(request);
		}

		public Get_Tax_Authorities_ResponseType Get_Tax_Authorities(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Authorities_RequestType Get_Tax_Authorities_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_Authorities(new Get_Tax_AuthoritiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Authorities_Request = Get_Tax_Authorities_Request
			}).Get_Tax_Authorities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Tax_AuthoritiesOutput> Financial_ManagementPort.Get_Tax_AuthoritiesAsync(Get_Tax_AuthoritiesInput request)
		{
			return base.Channel.Get_Tax_AuthoritiesAsync(request);
		}

		public Task<Get_Tax_AuthoritiesOutput> Get_Tax_AuthoritiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Authorities_RequestType Get_Tax_Authorities_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_AuthoritiesAsync(new Get_Tax_AuthoritiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Authorities_Request = Get_Tax_Authorities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Tax_AuthorityOutput Financial_ManagementPort.Put_Tax_Authority(Put_Tax_AuthorityInput request)
		{
			return base.Channel.Put_Tax_Authority(request);
		}

		public Put_Tax_Authority_ResponseType Put_Tax_Authority(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Authority_RequestType Put_Tax_Authority_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_Authority(new Put_Tax_AuthorityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Authority_Request = Put_Tax_Authority_Request
			}).Put_Tax_Authority_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Tax_AuthorityOutput> Financial_ManagementPort.Put_Tax_AuthorityAsync(Put_Tax_AuthorityInput request)
		{
			return base.Channel.Put_Tax_AuthorityAsync(request);
		}

		public Task<Put_Tax_AuthorityOutput> Put_Tax_AuthorityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Authority_RequestType Put_Tax_Authority_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_AuthorityAsync(new Put_Tax_AuthorityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Authority_Request = Put_Tax_Authority_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Receivable_Writeoff_CategoriesOutput Financial_ManagementPort.Get_Receivable_Writeoff_Categories(Get_Receivable_Writeoff_CategoriesInput request)
		{
			return base.Channel.Get_Receivable_Writeoff_Categories(request);
		}

		public Get_Receivable_Writeoff_Categories_ResponseType Get_Receivable_Writeoff_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Receivable_Writeoff_Categories_RequestType Get_Receivable_Writeoff_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Receivable_Writeoff_Categories(new Get_Receivable_Writeoff_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Receivable_Writeoff_Categories_Request = Get_Receivable_Writeoff_Categories_Request
			}).Get_Receivable_Writeoff_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Receivable_Writeoff_CategoriesOutput> Financial_ManagementPort.Get_Receivable_Writeoff_CategoriesAsync(Get_Receivable_Writeoff_CategoriesInput request)
		{
			return base.Channel.Get_Receivable_Writeoff_CategoriesAsync(request);
		}

		public Task<Get_Receivable_Writeoff_CategoriesOutput> Get_Receivable_Writeoff_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Receivable_Writeoff_Categories_RequestType Get_Receivable_Writeoff_Categories_Request)
		{
			return ((Financial_ManagementPort)this).Get_Receivable_Writeoff_CategoriesAsync(new Get_Receivable_Writeoff_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Receivable_Writeoff_Categories_Request = Get_Receivable_Writeoff_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Receivable_Writeoff_CategoryOutput Financial_ManagementPort.Put_Receivable_Writeoff_Category(Put_Receivable_Writeoff_CategoryInput request)
		{
			return base.Channel.Put_Receivable_Writeoff_Category(request);
		}

		public Put_Receivable_Writeoff_Category_ResponseType Put_Receivable_Writeoff_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Receivable_Writeoff_Category_RequestType Put_Receivable_Writeoff_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Receivable_Writeoff_Category(new Put_Receivable_Writeoff_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Receivable_Writeoff_Category_Request = Put_Receivable_Writeoff_Category_Request
			}).Put_Receivable_Writeoff_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Receivable_Writeoff_CategoryOutput> Financial_ManagementPort.Put_Receivable_Writeoff_CategoryAsync(Put_Receivable_Writeoff_CategoryInput request)
		{
			return base.Channel.Put_Receivable_Writeoff_CategoryAsync(request);
		}

		public Task<Put_Receivable_Writeoff_CategoryOutput> Put_Receivable_Writeoff_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Receivable_Writeoff_Category_RequestType Put_Receivable_Writeoff_Category_Request)
		{
			return ((Financial_ManagementPort)this).Put_Receivable_Writeoff_CategoryAsync(new Put_Receivable_Writeoff_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Receivable_Writeoff_Category_Request = Put_Receivable_Writeoff_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Journal_SourcesOutput Financial_ManagementPort.Get_Journal_Sources(Get_Journal_SourcesInput request)
		{
			return base.Channel.Get_Journal_Sources(request);
		}

		public Get_Journal_Sources_ResponseType Get_Journal_Sources(Workday_Common_HeaderType Workday_Common_Header, Get_Journal_Sources_RequestType Get_Journal_Sources_Request)
		{
			return ((Financial_ManagementPort)this).Get_Journal_Sources(new Get_Journal_SourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Journal_Sources_Request = Get_Journal_Sources_Request
			}).Get_Journal_Sources_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Journal_SourcesOutput> Financial_ManagementPort.Get_Journal_SourcesAsync(Get_Journal_SourcesInput request)
		{
			return base.Channel.Get_Journal_SourcesAsync(request);
		}

		public Task<Get_Journal_SourcesOutput> Get_Journal_SourcesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Journal_Sources_RequestType Get_Journal_Sources_Request)
		{
			return ((Financial_ManagementPort)this).Get_Journal_SourcesAsync(new Get_Journal_SourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Journal_Sources_Request = Get_Journal_Sources_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Journal_SourceOutput Financial_ManagementPort.Put_Journal_Source(Put_Journal_SourceInput request)
		{
			return base.Channel.Put_Journal_Source(request);
		}

		public Put_Journal_Source_ResponseType Put_Journal_Source(Workday_Common_HeaderType Workday_Common_Header, Put_Journal_Source_RequestType Put_Journal_Source_Request)
		{
			return ((Financial_ManagementPort)this).Put_Journal_Source(new Put_Journal_SourceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Journal_Source_Request = Put_Journal_Source_Request
			}).Put_Journal_Source_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Journal_SourceOutput> Financial_ManagementPort.Put_Journal_SourceAsync(Put_Journal_SourceInput request)
		{
			return base.Channel.Put_Journal_SourceAsync(request);
		}

		public Task<Put_Journal_SourceOutput> Put_Journal_SourceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Journal_Source_RequestType Put_Journal_Source_Request)
		{
			return ((Financial_ManagementPort)this).Put_Journal_SourceAsync(new Put_Journal_SourceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Journal_Source_Request = Put_Journal_Source_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Account_SetsOutput Financial_ManagementPort.Get_Account_Sets(Get_Account_SetsInput request)
		{
			return base.Channel.Get_Account_Sets(request);
		}

		public Get_Account_Sets_ResponseType Get_Account_Sets(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Sets_RequestType Get_Account_Sets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Account_Sets(new Get_Account_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Account_Sets_Request = Get_Account_Sets_Request
			}).Get_Account_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Account_SetsOutput> Financial_ManagementPort.Get_Account_SetsAsync(Get_Account_SetsInput request)
		{
			return base.Channel.Get_Account_SetsAsync(request);
		}

		public Task<Get_Account_SetsOutput> Get_Account_SetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Sets_RequestType Get_Account_Sets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Account_SetsAsync(new Get_Account_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Account_Sets_Request = Get_Account_Sets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Account_SetOutput Financial_ManagementPort.Put_Account_Set(Put_Account_SetInput request)
		{
			return base.Channel.Put_Account_Set(request);
		}

		public Put_Account_Set_ResponseType Put_Account_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Account_Set_RequestType Put_Account_Set_Request)
		{
			return ((Financial_ManagementPort)this).Put_Account_Set(new Put_Account_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Account_Set_Request = Put_Account_Set_Request
			}).Put_Account_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Account_SetOutput> Financial_ManagementPort.Put_Account_SetAsync(Put_Account_SetInput request)
		{
			return base.Channel.Put_Account_SetAsync(request);
		}

		public Task<Put_Account_SetOutput> Put_Account_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Account_Set_RequestType Put_Account_Set_Request)
		{
			return ((Financial_ManagementPort)this).Put_Account_SetAsync(new Put_Account_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Account_Set_Request = Put_Account_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Account_Posting_Rule_SetsOutput Financial_ManagementPort.Get_Account_Posting_Rule_Sets(Get_Account_Posting_Rule_SetsInput request)
		{
			return base.Channel.Get_Account_Posting_Rule_Sets(request);
		}

		public Get_Account_Posting_Rule_Sets_ResponseType Get_Account_Posting_Rule_Sets(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Posting_Rule_Sets_RequestType Get_Account_Posting_Rule_Sets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Account_Posting_Rule_Sets(new Get_Account_Posting_Rule_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Account_Posting_Rule_Sets_Request = Get_Account_Posting_Rule_Sets_Request
			}).Get_Account_Posting_Rule_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Account_Posting_Rule_SetsOutput> Financial_ManagementPort.Get_Account_Posting_Rule_SetsAsync(Get_Account_Posting_Rule_SetsInput request)
		{
			return base.Channel.Get_Account_Posting_Rule_SetsAsync(request);
		}

		public Task<Get_Account_Posting_Rule_SetsOutput> Get_Account_Posting_Rule_SetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Posting_Rule_Sets_RequestType Get_Account_Posting_Rule_Sets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Account_Posting_Rule_SetsAsync(new Get_Account_Posting_Rule_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Account_Posting_Rule_Sets_Request = Get_Account_Posting_Rule_Sets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Account_Posting_Rule_SetOutput Financial_ManagementPort.Put_Account_Posting_Rule_Set(Put_Account_Posting_Rule_SetInput request)
		{
			return base.Channel.Put_Account_Posting_Rule_Set(request);
		}

		public Put_Account_Posting_Rule_Set_ResponseType Put_Account_Posting_Rule_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Account_Posting_Rule_Set_RequestType Put_Account_Posting_Rule_Set_Request)
		{
			return ((Financial_ManagementPort)this).Put_Account_Posting_Rule_Set(new Put_Account_Posting_Rule_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Account_Posting_Rule_Set_Request = Put_Account_Posting_Rule_Set_Request
			}).Put_Account_Posting_Rule_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Account_Posting_Rule_SetOutput> Financial_ManagementPort.Put_Account_Posting_Rule_SetAsync(Put_Account_Posting_Rule_SetInput request)
		{
			return base.Channel.Put_Account_Posting_Rule_SetAsync(request);
		}

		public Task<Put_Account_Posting_Rule_SetOutput> Put_Account_Posting_Rule_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Account_Posting_Rule_Set_RequestType Put_Account_Posting_Rule_Set_Request)
		{
			return ((Financial_ManagementPort)this).Put_Account_Posting_Rule_SetAsync(new Put_Account_Posting_Rule_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Account_Posting_Rule_Set_Request = Put_Account_Posting_Rule_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Ledger_Account_SummariesOutput Financial_ManagementPort.Get_Ledger_Account_Summaries(Get_Ledger_Account_SummariesInput request)
		{
			return base.Channel.Get_Ledger_Account_Summaries(request);
		}

		public Get_Ledger_Account_Summaries_ResponseType Get_Ledger_Account_Summaries(Workday_Common_HeaderType Workday_Common_Header, Get_Ledger_Account_Summary_RequestType Get_Ledger_Account_Summary_Request)
		{
			return ((Financial_ManagementPort)this).Get_Ledger_Account_Summaries(new Get_Ledger_Account_SummariesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ledger_Account_Summary_Request = Get_Ledger_Account_Summary_Request
			}).Get_Ledger_Account_Summaries_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Ledger_Account_SummariesOutput> Financial_ManagementPort.Get_Ledger_Account_SummariesAsync(Get_Ledger_Account_SummariesInput request)
		{
			return base.Channel.Get_Ledger_Account_SummariesAsync(request);
		}

		public Task<Get_Ledger_Account_SummariesOutput> Get_Ledger_Account_SummariesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ledger_Account_Summary_RequestType Get_Ledger_Account_Summary_Request)
		{
			return ((Financial_ManagementPort)this).Get_Ledger_Account_SummariesAsync(new Get_Ledger_Account_SummariesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ledger_Account_Summary_Request = Get_Ledger_Account_Summary_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Ledger_Account_SummaryOutput Financial_ManagementPort.Put_Ledger_Account_Summary(Put_Ledger_Account_SummaryInput request)
		{
			return base.Channel.Put_Ledger_Account_Summary(request);
		}

		public Put_Ledger_Account_Summary_ResponseType Put_Ledger_Account_Summary(Workday_Common_HeaderType Workday_Common_Header, Put_Ledger_Account_Summary_RequestType Put_Ledger_Account_Summary_Request)
		{
			return ((Financial_ManagementPort)this).Put_Ledger_Account_Summary(new Put_Ledger_Account_SummaryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ledger_Account_Summary_Request = Put_Ledger_Account_Summary_Request
			}).Put_Ledger_Account_Summary_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Ledger_Account_SummaryOutput> Financial_ManagementPort.Put_Ledger_Account_SummaryAsync(Put_Ledger_Account_SummaryInput request)
		{
			return base.Channel.Put_Ledger_Account_SummaryAsync(request);
		}

		public Task<Put_Ledger_Account_SummaryOutput> Put_Ledger_Account_SummaryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Ledger_Account_Summary_RequestType Put_Ledger_Account_Summary_Request)
		{
			return ((Financial_ManagementPort)this).Put_Ledger_Account_SummaryAsync(new Put_Ledger_Account_SummaryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ledger_Account_Summary_Request = Put_Ledger_Account_Summary_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Accounting_JournalOutput Financial_ManagementPort.Cancel_Accounting_Journal(Cancel_Accounting_JournalInput request)
		{
			return base.Channel.Cancel_Accounting_Journal(request);
		}

		public Cancel_Accounting_Journal_ResponseType Cancel_Accounting_Journal(Workday_Common_HeaderType Workday_Common_Header, Cancel_Accounting_Journal_RequestType Cancel_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Cancel_Accounting_Journal(new Cancel_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Accounting_Journal_Request = Cancel_Accounting_Journal_Request
			}).Cancel_Accounting_Journal_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Accounting_JournalOutput> Financial_ManagementPort.Cancel_Accounting_JournalAsync(Cancel_Accounting_JournalInput request)
		{
			return base.Channel.Cancel_Accounting_JournalAsync(request);
		}

		public Task<Cancel_Accounting_JournalOutput> Cancel_Accounting_JournalAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Accounting_Journal_RequestType Cancel_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Cancel_Accounting_JournalAsync(new Cancel_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Accounting_Journal_Request = Cancel_Accounting_Journal_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_Entity_ContactsOutput Financial_ManagementPort.Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_Contacts(request);
		}

		public Get_Business_Entity_Contacts_ResponseType Get_Business_Entity_Contacts(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Entity_Contacts(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			}).Get_Business_Entity_Contacts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_Entity_ContactsOutput> Financial_ManagementPort.Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_ContactsAsync(request);
		}

		public Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Entity_ContactsAsync(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_Entity_ContactOutput Financial_ManagementPort.Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_Contact(request);
		}

		public Put_Business_Entity_Contact_ResponseType Put_Business_Entity_Contact(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Financial_ManagementPort)this).Put_Business_Entity_Contact(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			}).Put_Business_Entity_Contact_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_Entity_ContactOutput> Financial_ManagementPort.Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_ContactAsync(request);
		}

		public Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Financial_ManagementPort)this).Put_Business_Entity_ContactAsync(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OrganizationsOutput Financial_ManagementPort.Get_Organizations(Get_OrganizationsInput request)
		{
			return base.Channel.Get_Organizations(request);
		}

		public Get_Organizations_ResponseType Get_Organizations(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((Financial_ManagementPort)this).Get_Organizations(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			}).Get_Organizations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OrganizationsOutput> Financial_ManagementPort.Get_OrganizationsAsync(Get_OrganizationsInput request)
		{
			return base.Channel.Get_OrganizationsAsync(request);
		}

		public Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((Financial_ManagementPort)this).Get_OrganizationsAsync(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_Plan_DetailsOutput Financial_ManagementPort.Get_Business_Plan_Details(Get_Business_Plan_DetailsInput request)
		{
			return base.Channel.Get_Business_Plan_Details(request);
		}

		public Get_Business_Plan_Details_ResponseType Get_Business_Plan_Details(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Plan_Details_RequestType Get_Business_Plan_Details_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Plan_Details(new Get_Business_Plan_DetailsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Plan_Details_Request = Get_Business_Plan_Details_Request
			}).Get_Business_Plan_Details_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_Plan_DetailsOutput> Financial_ManagementPort.Get_Business_Plan_DetailsAsync(Get_Business_Plan_DetailsInput request)
		{
			return base.Channel.Get_Business_Plan_DetailsAsync(request);
		}

		public Task<Get_Business_Plan_DetailsOutput> Get_Business_Plan_DetailsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Plan_Details_RequestType Get_Business_Plan_Details_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Plan_DetailsAsync(new Get_Business_Plan_DetailsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Plan_Details_Request = Get_Business_Plan_Details_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Beginning_Balance_JournalsOutput Financial_ManagementPort.Get_Beginning_Balance_Journals(Get_Beginning_Balance_JournalsInput request)
		{
			return base.Channel.Get_Beginning_Balance_Journals(request);
		}

		public Get_Beginning_Balance_Journals_ResponseType Get_Beginning_Balance_Journals(Workday_Common_HeaderType Workday_Common_Header, Get_Beginning_Balance_Journals_RequestType Get_Beginning_Balance_Journals_Request)
		{
			return ((Financial_ManagementPort)this).Get_Beginning_Balance_Journals(new Get_Beginning_Balance_JournalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Beginning_Balance_Journals_Request = Get_Beginning_Balance_Journals_Request
			}).Get_Beginning_Balance_Journals_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Beginning_Balance_JournalsOutput> Financial_ManagementPort.Get_Beginning_Balance_JournalsAsync(Get_Beginning_Balance_JournalsInput request)
		{
			return base.Channel.Get_Beginning_Balance_JournalsAsync(request);
		}

		public Task<Get_Beginning_Balance_JournalsOutput> Get_Beginning_Balance_JournalsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Beginning_Balance_Journals_RequestType Get_Beginning_Balance_Journals_Request)
		{
			return ((Financial_ManagementPort)this).Get_Beginning_Balance_JournalsAsync(new Get_Beginning_Balance_JournalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Beginning_Balance_Journals_Request = Get_Beginning_Balance_Journals_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Beginning_Balance_JournalOutput Financial_ManagementPort.Put_Beginning_Balance_Journal(Put_Beginning_Balance_JournalInput request)
		{
			return base.Channel.Put_Beginning_Balance_Journal(request);
		}

		public Put_Beginning_Balance_Journal_ResponseType Put_Beginning_Balance_Journal(Workday_Common_HeaderType Workday_Common_Header, Put_Beginning_Balance_Journal_RequestType Put_Beginning_Balance_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Put_Beginning_Balance_Journal(new Put_Beginning_Balance_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Beginning_Balance_Journal_Request = Put_Beginning_Balance_Journal_Request
			}).Put_Beginning_Balance_Journal_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Beginning_Balance_JournalOutput> Financial_ManagementPort.Put_Beginning_Balance_JournalAsync(Put_Beginning_Balance_JournalInput request)
		{
			return base.Channel.Put_Beginning_Balance_JournalAsync(request);
		}

		public Task<Put_Beginning_Balance_JournalOutput> Put_Beginning_Balance_JournalAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Beginning_Balance_Journal_RequestType Put_Beginning_Balance_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Put_Beginning_Balance_JournalAsync(new Put_Beginning_Balance_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Beginning_Balance_Journal_Request = Put_Beginning_Balance_Journal_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Recurring_Journal_TemplatesOutput Financial_ManagementPort.Get_Recurring_Journal_Templates(Get_Recurring_Journal_TemplatesInput request)
		{
			return base.Channel.Get_Recurring_Journal_Templates(request);
		}

		public Get_Recurring_Journal_Templates_ResponseType Get_Recurring_Journal_Templates(Workday_Common_HeaderType Workday_Common_Header, Get_Recurring_Journal_Templates_RequestType Get_Recurring_Journal_Templates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Recurring_Journal_Templates(new Get_Recurring_Journal_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Recurring_Journal_Templates_Request = Get_Recurring_Journal_Templates_Request
			}).Get_Recurring_Journal_Templates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Recurring_Journal_TemplatesOutput> Financial_ManagementPort.Get_Recurring_Journal_TemplatesAsync(Get_Recurring_Journal_TemplatesInput request)
		{
			return base.Channel.Get_Recurring_Journal_TemplatesAsync(request);
		}

		public Task<Get_Recurring_Journal_TemplatesOutput> Get_Recurring_Journal_TemplatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Recurring_Journal_Templates_RequestType Get_Recurring_Journal_Templates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Recurring_Journal_TemplatesAsync(new Get_Recurring_Journal_TemplatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Recurring_Journal_Templates_Request = Get_Recurring_Journal_Templates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Recurring_Journal_TemplateOutput Financial_ManagementPort.Put_Recurring_Journal_Template(Put_Recurring_Journal_TemplateInput request)
		{
			return base.Channel.Put_Recurring_Journal_Template(request);
		}

		public Put_Recurring_Journal_Template_ResponseType Put_Recurring_Journal_Template(Workday_Common_HeaderType Workday_Common_Header, Put_Recurring_Journal_Template_RequestType Put_Recurring_Journal_Template_Request)
		{
			return ((Financial_ManagementPort)this).Put_Recurring_Journal_Template(new Put_Recurring_Journal_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Recurring_Journal_Template_Request = Put_Recurring_Journal_Template_Request
			}).Put_Recurring_Journal_Template_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Recurring_Journal_TemplateOutput> Financial_ManagementPort.Put_Recurring_Journal_TemplateAsync(Put_Recurring_Journal_TemplateInput request)
		{
			return base.Channel.Put_Recurring_Journal_TemplateAsync(request);
		}

		public Task<Put_Recurring_Journal_TemplateOutput> Put_Recurring_Journal_TemplateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Recurring_Journal_Template_RequestType Put_Recurring_Journal_Template_Request)
		{
			return ((Financial_ManagementPort)this).Put_Recurring_Journal_TemplateAsync(new Put_Recurring_Journal_TemplateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Recurring_Journal_Template_Request = Put_Recurring_Journal_Template_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Intercompany_ProfilesOutput Financial_ManagementPort.Get_Intercompany_Profiles(Get_Intercompany_ProfilesInput request)
		{
			return base.Channel.Get_Intercompany_Profiles(request);
		}

		public Get_Intercompany_Profiles_ResponseType Get_Intercompany_Profiles(Workday_Common_HeaderType Workday_Common_Header, Get_Intercompany_Profiles_RequestType Get_Intercompany_Profiles_Request)
		{
			return ((Financial_ManagementPort)this).Get_Intercompany_Profiles(new Get_Intercompany_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Intercompany_Profiles_Request = Get_Intercompany_Profiles_Request
			}).Get_Intercompany_Profiles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Intercompany_ProfilesOutput> Financial_ManagementPort.Get_Intercompany_ProfilesAsync(Get_Intercompany_ProfilesInput request)
		{
			return base.Channel.Get_Intercompany_ProfilesAsync(request);
		}

		public Task<Get_Intercompany_ProfilesOutput> Get_Intercompany_ProfilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Intercompany_Profiles_RequestType Get_Intercompany_Profiles_Request)
		{
			return ((Financial_ManagementPort)this).Get_Intercompany_ProfilesAsync(new Get_Intercompany_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Intercompany_Profiles_Request = Get_Intercompany_Profiles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Intercompany_ProfileOutput Financial_ManagementPort.Put_Intercompany_Profile(Put_Intercompany_ProfileInput request)
		{
			return base.Channel.Put_Intercompany_Profile(request);
		}

		public Put_Intercompany_Profile_ResponseType Put_Intercompany_Profile(Workday_Common_HeaderType Workday_Common_Header, Put_Intercompany_Profile_RequestType Put_Intercompany_Profile_Request)
		{
			return ((Financial_ManagementPort)this).Put_Intercompany_Profile(new Put_Intercompany_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Intercompany_Profile_Request = Put_Intercompany_Profile_Request
			}).Put_Intercompany_Profile_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Intercompany_ProfileOutput> Financial_ManagementPort.Put_Intercompany_ProfileAsync(Put_Intercompany_ProfileInput request)
		{
			return base.Channel.Put_Intercompany_ProfileAsync(request);
		}

		public Task<Put_Intercompany_ProfileOutput> Put_Intercompany_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Intercompany_Profile_RequestType Put_Intercompany_Profile_Request)
		{
			return ((Financial_ManagementPort)this).Put_Intercompany_ProfileAsync(new Put_Intercompany_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Intercompany_Profile_Request = Put_Intercompany_Profile_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Custom_Validation_RulesOutput Financial_ManagementPort.Get_Custom_Validation_Rules(Get_Custom_Validation_RulesInput request)
		{
			return base.Channel.Get_Custom_Validation_Rules(request);
		}

		public Get_Custom_Validation_Rules_ResponseType Get_Custom_Validation_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Validation_Rules_RequestType Get_Custom_Validation_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Custom_Validation_Rules(new Get_Custom_Validation_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Validation_Rules_Request = Get_Custom_Validation_Rules_Request
			}).Get_Custom_Validation_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Custom_Validation_RulesOutput> Financial_ManagementPort.Get_Custom_Validation_RulesAsync(Get_Custom_Validation_RulesInput request)
		{
			return base.Channel.Get_Custom_Validation_RulesAsync(request);
		}

		public Task<Get_Custom_Validation_RulesOutput> Get_Custom_Validation_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Validation_Rules_RequestType Get_Custom_Validation_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Custom_Validation_RulesAsync(new Get_Custom_Validation_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Validation_Rules_Request = Get_Custom_Validation_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Custom_Validation_RuleOutput Financial_ManagementPort.Put_Custom_Validation_Rule(Put_Custom_Validation_RuleInput request)
		{
			return base.Channel.Put_Custom_Validation_Rule(request);
		}

		public Put_Custom_Validation_Rule_ResponseType Put_Custom_Validation_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_Validation_Rule_RequestType Put_Custom_Validation_Rule_Request)
		{
			return ((Financial_ManagementPort)this).Put_Custom_Validation_Rule(new Put_Custom_Validation_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Custom_Validation_Rule_Request = Put_Custom_Validation_Rule_Request
			}).Put_Custom_Validation_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Custom_Validation_RuleOutput> Financial_ManagementPort.Put_Custom_Validation_RuleAsync(Put_Custom_Validation_RuleInput request)
		{
			return base.Channel.Put_Custom_Validation_RuleAsync(request);
		}

		public Task<Put_Custom_Validation_RuleOutput> Put_Custom_Validation_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_Validation_Rule_RequestType Put_Custom_Validation_Rule_Request)
		{
			return ((Financial_ManagementPort)this).Put_Custom_Validation_RuleAsync(new Put_Custom_Validation_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Custom_Validation_Rule_Request = Put_Custom_Validation_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Statistic_DefinitionsOutput Financial_ManagementPort.Get_Statistic_Definitions(Get_Statistic_DefinitionsInput request)
		{
			return base.Channel.Get_Statistic_Definitions(request);
		}

		public Get_Statistic_Definitions_ResponseType Get_Statistic_Definitions(Workday_Common_HeaderType Workday_Common_Header, Get_Statistic_Definitions_RequestType Get_Statistic_Definitions_Request)
		{
			return ((Financial_ManagementPort)this).Get_Statistic_Definitions(new Get_Statistic_DefinitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Statistic_Definitions_Request = Get_Statistic_Definitions_Request
			}).Get_Statistic_Definitions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Statistic_DefinitionsOutput> Financial_ManagementPort.Get_Statistic_DefinitionsAsync(Get_Statistic_DefinitionsInput request)
		{
			return base.Channel.Get_Statistic_DefinitionsAsync(request);
		}

		public Task<Get_Statistic_DefinitionsOutput> Get_Statistic_DefinitionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Statistic_Definitions_RequestType Get_Statistic_Definitions_Request)
		{
			return ((Financial_ManagementPort)this).Get_Statistic_DefinitionsAsync(new Get_Statistic_DefinitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Statistic_Definitions_Request = Get_Statistic_Definitions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Statistic_DefinitionOutput Financial_ManagementPort.Put_Statistic_Definition(Put_Statistic_DefinitionInput request)
		{
			return base.Channel.Put_Statistic_Definition(request);
		}

		public Put_Statistic_Definition_ResponseType Put_Statistic_Definition(Workday_Common_HeaderType Workday_Common_Header, Put_Statistic_Definition_RequestType Put_Statistic_Definition_Request)
		{
			return ((Financial_ManagementPort)this).Put_Statistic_Definition(new Put_Statistic_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Statistic_Definition_Request = Put_Statistic_Definition_Request
			}).Put_Statistic_Definition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Statistic_DefinitionOutput> Financial_ManagementPort.Put_Statistic_DefinitionAsync(Put_Statistic_DefinitionInput request)
		{
			return base.Channel.Put_Statistic_DefinitionAsync(request);
		}

		public Task<Put_Statistic_DefinitionOutput> Put_Statistic_DefinitionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Statistic_Definition_RequestType Put_Statistic_Definition_Request)
		{
			return ((Financial_ManagementPort)this).Put_Statistic_DefinitionAsync(new Put_Statistic_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Statistic_Definition_Request = Put_Statistic_Definition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_StatisticsOutput Financial_ManagementPort.Get_Statistics(Get_StatisticsInput request)
		{
			return base.Channel.Get_Statistics(request);
		}

		public Get_Statistics_ResponseType Get_Statistics(Workday_Common_HeaderType Workday_Common_Header, Get_Statistics_RequestType Get_Statistics_Request)
		{
			return ((Financial_ManagementPort)this).Get_Statistics(new Get_StatisticsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Statistics_Request = Get_Statistics_Request
			}).Get_Statistics_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_StatisticsOutput> Financial_ManagementPort.Get_StatisticsAsync(Get_StatisticsInput request)
		{
			return base.Channel.Get_StatisticsAsync(request);
		}

		public Task<Get_StatisticsOutput> Get_StatisticsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Statistics_RequestType Get_Statistics_Request)
		{
			return ((Financial_ManagementPort)this).Get_StatisticsAsync(new Get_StatisticsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Statistics_Request = Get_Statistics_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_StatisticOutput Financial_ManagementPort.Put_Statistic(Put_StatisticInput request)
		{
			return base.Channel.Put_Statistic(request);
		}

		public Put_Statistic_ResponseType Put_Statistic(Workday_Common_HeaderType Workday_Common_Header, Put_Statistic_RequestType Put_Statistic_Request)
		{
			return ((Financial_ManagementPort)this).Put_Statistic(new Put_StatisticInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Statistic_Request = Put_Statistic_Request
			}).Put_Statistic_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_StatisticOutput> Financial_ManagementPort.Put_StatisticAsync(Put_StatisticInput request)
		{
			return base.Channel.Put_StatisticAsync(request);
		}

		public Task<Put_StatisticOutput> Put_StatisticAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Statistic_RequestType Put_Statistic_Request)
		{
			return ((Financial_ManagementPort)this).Put_StatisticAsync(new Put_StatisticInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Statistic_Request = Put_Statistic_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Custom_WorktagsOutput Financial_ManagementPort.Get_Custom_Worktags(Get_Custom_WorktagsInput request)
		{
			return base.Channel.Get_Custom_Worktags(request);
		}

		public Get_Custom_Worktags_ResponseType Get_Custom_Worktags(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Worktags_RequestType Get_Custom_Worktags_Request)
		{
			return ((Financial_ManagementPort)this).Get_Custom_Worktags(new Get_Custom_WorktagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Worktags_Request = Get_Custom_Worktags_Request
			}).Get_Custom_Worktags_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Custom_WorktagsOutput> Financial_ManagementPort.Get_Custom_WorktagsAsync(Get_Custom_WorktagsInput request)
		{
			return base.Channel.Get_Custom_WorktagsAsync(request);
		}

		public Task<Get_Custom_WorktagsOutput> Get_Custom_WorktagsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Worktags_RequestType Get_Custom_Worktags_Request)
		{
			return ((Financial_ManagementPort)this).Get_Custom_WorktagsAsync(new Get_Custom_WorktagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Worktags_Request = Get_Custom_Worktags_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Custom_WorktagOutput Financial_ManagementPort.Put_Custom_Worktag(Put_Custom_WorktagInput request)
		{
			return base.Channel.Put_Custom_Worktag(request);
		}

		public Put_Custom_Worktag_ResponseType Put_Custom_Worktag(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_Worktag_RequestType Put_Custom_Worktag_Request)
		{
			return ((Financial_ManagementPort)this).Put_Custom_Worktag(new Put_Custom_WorktagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Custom_Worktag_Request = Put_Custom_Worktag_Request
			}).Put_Custom_Worktag_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Custom_WorktagOutput> Financial_ManagementPort.Put_Custom_WorktagAsync(Put_Custom_WorktagInput request)
		{
			return base.Channel.Put_Custom_WorktagAsync(request);
		}

		public Task<Put_Custom_WorktagOutput> Put_Custom_WorktagAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Custom_Worktag_RequestType Put_Custom_Worktag_Request)
		{
			return ((Financial_ManagementPort)this).Put_Custom_WorktagAsync(new Put_Custom_WorktagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Custom_Worktag_Request = Put_Custom_Worktag_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Funding_SourcesOutput Financial_ManagementPort.Get_Funding_Sources(Get_Funding_SourcesInput request)
		{
			return base.Channel.Get_Funding_Sources(request);
		}

		public Get_Funding_Sources_ResponseType Get_Funding_Sources(Workday_Common_HeaderType Workday_Common_Header, Get_Funding_Sources_RequestType Get_Funding_Sources_Request)
		{
			return ((Financial_ManagementPort)this).Get_Funding_Sources(new Get_Funding_SourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Funding_Sources_Request = Get_Funding_Sources_Request
			}).Get_Funding_Sources_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Funding_SourcesOutput> Financial_ManagementPort.Get_Funding_SourcesAsync(Get_Funding_SourcesInput request)
		{
			return base.Channel.Get_Funding_SourcesAsync(request);
		}

		public Task<Get_Funding_SourcesOutput> Get_Funding_SourcesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Funding_Sources_RequestType Get_Funding_Sources_Request)
		{
			return ((Financial_ManagementPort)this).Get_Funding_SourcesAsync(new Get_Funding_SourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Funding_Sources_Request = Get_Funding_Sources_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Funding_SourceOutput Financial_ManagementPort.Put_Funding_Source(Put_Funding_SourceInput request)
		{
			return base.Channel.Put_Funding_Source(request);
		}

		public Put_Funding_Source_ResponseType Put_Funding_Source(Workday_Common_HeaderType Workday_Common_Header, Put_Funding_Source_RequestType Put_Funding_Source_Request)
		{
			return ((Financial_ManagementPort)this).Put_Funding_Source(new Put_Funding_SourceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Funding_Source_Request = Put_Funding_Source_Request
			}).Put_Funding_Source_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Funding_SourceOutput> Financial_ManagementPort.Put_Funding_SourceAsync(Put_Funding_SourceInput request)
		{
			return base.Channel.Put_Funding_SourceAsync(request);
		}

		public Task<Put_Funding_SourceOutput> Put_Funding_SourceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Funding_Source_RequestType Put_Funding_Source_Request)
		{
			return ((Financial_ManagementPort)this).Put_Funding_SourceAsync(new Put_Funding_SourceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Funding_Source_Request = Put_Funding_Source_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Fund_TypesOutput Financial_ManagementPort.Get_Fund_Types(Get_Fund_TypesInput request)
		{
			return base.Channel.Get_Fund_Types(request);
		}

		public Get_Fund_Types_ResponseType Get_Fund_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Fund_Types_RequestType Get_Fund_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Fund_Types(new Get_Fund_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fund_Types_Request = Get_Fund_Types_Request
			}).Get_Fund_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Fund_TypesOutput> Financial_ManagementPort.Get_Fund_TypesAsync(Get_Fund_TypesInput request)
		{
			return base.Channel.Get_Fund_TypesAsync(request);
		}

		public Task<Get_Fund_TypesOutput> Get_Fund_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Fund_Types_RequestType Get_Fund_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Fund_TypesAsync(new Get_Fund_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fund_Types_Request = Get_Fund_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Fund_TypeOutput Financial_ManagementPort.Put_Fund_Type(Put_Fund_TypeInput request)
		{
			return base.Channel.Put_Fund_Type(request);
		}

		public Put_Fund_Type_ResponseType Put_Fund_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Fund_Type_RequestType Put_Fund_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fund_Type(new Put_Fund_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fund_Type_Request = Put_Fund_Type_Request
			}).Put_Fund_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Fund_TypeOutput> Financial_ManagementPort.Put_Fund_TypeAsync(Put_Fund_TypeInput request)
		{
			return base.Channel.Put_Fund_TypeAsync(request);
		}

		public Task<Put_Fund_TypeOutput> Put_Fund_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Fund_Type_RequestType Put_Fund_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fund_TypeAsync(new Put_Fund_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fund_Type_Request = Put_Fund_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_FundsOutput Financial_ManagementPort.Get_Funds(Get_FundsInput request)
		{
			return base.Channel.Get_Funds(request);
		}

		public Get_Funds_ResponseType Get_Funds(Workday_Common_HeaderType Workday_Common_Header, Get_Funds_RequestType Get_Funds_Request)
		{
			return ((Financial_ManagementPort)this).Get_Funds(new Get_FundsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Funds_Request = Get_Funds_Request
			}).Get_Funds_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_FundsOutput> Financial_ManagementPort.Get_FundsAsync(Get_FundsInput request)
		{
			return base.Channel.Get_FundsAsync(request);
		}

		public Task<Get_FundsOutput> Get_FundsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Funds_RequestType Get_Funds_Request)
		{
			return ((Financial_ManagementPort)this).Get_FundsAsync(new Get_FundsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Funds_Request = Get_Funds_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_FundOutput Financial_ManagementPort.Put_Fund(Put_FundInput request)
		{
			return base.Channel.Put_Fund(request);
		}

		public Put_Fund_ResponseType Put_Fund(Workday_Common_HeaderType Workday_Common_Header, Put_Fund_RequestType Put_Fund_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fund(new Put_FundInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fund_Request = Put_Fund_Request
			}).Put_Fund_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_FundOutput> Financial_ManagementPort.Put_FundAsync(Put_FundInput request)
		{
			return base.Channel.Put_FundAsync(request);
		}

		public Task<Put_FundOutput> Put_FundAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Fund_RequestType Put_Fund_Request)
		{
			return ((Financial_ManagementPort)this).Put_FundAsync(new Put_FundInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fund_Request = Put_Fund_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PaymentsOutput Financial_ManagementPort.Get_Payments(Get_PaymentsInput request)
		{
			return base.Channel.Get_Payments(request);
		}

		public Get_Payments_ResponseType Get_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Payments_RequestType Get_Payments_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payments(new Get_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payments_Request = Get_Payments_Request
			}).Get_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PaymentsOutput> Financial_ManagementPort.Get_PaymentsAsync(Get_PaymentsInput request)
		{
			return base.Channel.Get_PaymentsAsync(request);
		}

		public Task<Get_PaymentsOutput> Get_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payments_RequestType Get_Payments_Request)
		{
			return ((Financial_ManagementPort)this).Get_PaymentsAsync(new Get_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payments_Request = Get_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_MessagesOutput Financial_ManagementPort.Get_Payment_Messages(Get_Payment_MessagesInput request)
		{
			return base.Channel.Get_Payment_Messages(request);
		}

		public Get_Payment_Messages_ResponseType Get_Payment_Messages(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Messages_RequestType Get_Payment_Messages_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payment_Messages(new Get_Payment_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Messages_Request = Get_Payment_Messages_Request
			}).Get_Payment_Messages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_MessagesOutput> Financial_ManagementPort.Get_Payment_MessagesAsync(Get_Payment_MessagesInput request)
		{
			return base.Channel.Get_Payment_MessagesAsync(request);
		}

		public Task<Get_Payment_MessagesOutput> Get_Payment_MessagesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Messages_RequestType Get_Payment_Messages_Request)
		{
			return ((Financial_ManagementPort)this).Get_Payment_MessagesAsync(new Get_Payment_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Messages_Request = Get_Payment_Messages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_RegionsOutput Financial_ManagementPort.Get_Regions(Get_RegionsInput request)
		{
			return base.Channel.Get_Regions(request);
		}

		public Get_Regions_ResponseType Get_Regions(Workday_Common_HeaderType Workday_Common_Header, Get_Regions_RequestType Get_Regions_Request)
		{
			return ((Financial_ManagementPort)this).Get_Regions(new Get_RegionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Regions_Request = Get_Regions_Request
			}).Get_Regions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_RegionsOutput> Financial_ManagementPort.Get_RegionsAsync(Get_RegionsInput request)
		{
			return base.Channel.Get_RegionsAsync(request);
		}

		public Task<Get_RegionsOutput> Get_RegionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Regions_RequestType Get_Regions_Request)
		{
			return ((Financial_ManagementPort)this).Get_RegionsAsync(new Get_RegionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Regions_Request = Get_Regions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Cost_CentersOutput Financial_ManagementPort.Get_Cost_Centers(Get_Cost_CentersInput request)
		{
			return base.Channel.Get_Cost_Centers(request);
		}

		public Get_Cost_Centers_ResponseType Get_Cost_Centers(Workday_Common_HeaderType Workday_Common_Header, Get_Cost_Centers_RequestType Get_Cost_Centers_Request)
		{
			return ((Financial_ManagementPort)this).Get_Cost_Centers(new Get_Cost_CentersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Cost_Centers_Request = Get_Cost_Centers_Request
			}).Get_Cost_Centers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Cost_CentersOutput> Financial_ManagementPort.Get_Cost_CentersAsync(Get_Cost_CentersInput request)
		{
			return base.Channel.Get_Cost_CentersAsync(request);
		}

		public Task<Get_Cost_CentersOutput> Get_Cost_CentersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Cost_Centers_RequestType Get_Cost_Centers_Request)
		{
			return ((Financial_ManagementPort)this).Get_Cost_CentersAsync(new Get_Cost_CentersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Cost_Centers_Request = Get_Cost_Centers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Cost_CenterOutput Financial_ManagementPort.Put_Cost_Center(Put_Cost_CenterInput request)
		{
			return base.Channel.Put_Cost_Center(request);
		}

		public Put_Cost_Center_ResponseType Put_Cost_Center(Workday_Common_HeaderType Workday_Common_Header, Put_Cost_Center_RequestType Put_Cost_Center_Request)
		{
			return ((Financial_ManagementPort)this).Put_Cost_Center(new Put_Cost_CenterInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Cost_Center_Request = Put_Cost_Center_Request
			}).Put_Cost_Center_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Cost_CenterOutput> Financial_ManagementPort.Put_Cost_CenterAsync(Put_Cost_CenterInput request)
		{
			return base.Channel.Put_Cost_CenterAsync(request);
		}

		public Task<Put_Cost_CenterOutput> Put_Cost_CenterAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Cost_Center_RequestType Put_Cost_Center_Request)
		{
			return ((Financial_ManagementPort)this).Put_Cost_CenterAsync(new Put_Cost_CenterInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Cost_Center_Request = Put_Cost_Center_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Account_SetsOutput Financial_ManagementPort.Get_Account_Sets_Without_Dependencies(Get_Account_Sets_Without_DependenciesInput request)
		{
			return base.Channel.Get_Account_Sets_Without_Dependencies(request);
		}

		public Get_Account_Sets_ResponseType Get_Account_Sets_Without_Dependencies(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Sets_without_Dependencies_RequestType Get_Account_Sets_without_Dependencies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Account_Sets_Without_Dependencies(new Get_Account_Sets_Without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Account_Sets_without_Dependencies_Request = Get_Account_Sets_without_Dependencies_Request
			}).Get_Account_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Account_SetsOutput> Financial_ManagementPort.Get_Account_Sets_Without_DependenciesAsync(Get_Account_Sets_Without_DependenciesInput request)
		{
			return base.Channel.Get_Account_Sets_Without_DependenciesAsync(request);
		}

		public Task<Get_Account_SetsOutput> Get_Account_Sets_Without_DependenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Account_Sets_without_Dependencies_RequestType Get_Account_Sets_without_Dependencies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Account_Sets_Without_DependenciesAsync(new Get_Account_Sets_Without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Account_Sets_without_Dependencies_Request = Get_Account_Sets_without_Dependencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Custom_Validation_RulesOutput Financial_ManagementPort.Get_Custom_Validation_Rules_without_Dependencies(Get_Custom_Validation_Rules_without_DependenciesInput request)
		{
			return base.Channel.Get_Custom_Validation_Rules_without_Dependencies(request);
		}

		public Get_Custom_Validation_Rules_ResponseType Get_Custom_Validation_Rules_without_Dependencies(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Validation_Rules_without_Dependencies_RequestType Get_Custom_Validation_Rules_without_Dependencies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Custom_Validation_Rules_without_Dependencies(new Get_Custom_Validation_Rules_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Validation_Rules_without_Dependencies_Request = Get_Custom_Validation_Rules_without_Dependencies_Request
			}).Get_Custom_Validation_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Custom_Validation_RulesOutput> Financial_ManagementPort.Get_Custom_Validation_Rules_without_DependenciesAsync(Get_Custom_Validation_Rules_without_DependenciesInput request)
		{
			return base.Channel.Get_Custom_Validation_Rules_without_DependenciesAsync(request);
		}

		public Task<Get_Custom_Validation_RulesOutput> Get_Custom_Validation_Rules_without_DependenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Custom_Validation_Rules_without_Dependencies_RequestType Get_Custom_Validation_Rules_without_Dependencies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Custom_Validation_Rules_without_DependenciesAsync(new Get_Custom_Validation_Rules_without_DependenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Custom_Validation_Rules_without_Dependencies_Request = Get_Custom_Validation_Rules_without_Dependencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Spend_Category_HierarchyOutput Financial_ManagementPort.Put_Spend_Category_Hierarchy(Put_Spend_Category_HierarchyInput request)
		{
			return base.Channel.Put_Spend_Category_Hierarchy(request);
		}

		public Put_Spend_Category_Hierarchy_ResponseType Put_Spend_Category_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Category_Hierarchy_RequestType Put_Spend_Category_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Spend_Category_Hierarchy(new Put_Spend_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Spend_Category_Hierarchy_Request = Put_Spend_Category_Hierarchy_Request
			}).Put_Spend_Category_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Spend_Category_HierarchyOutput> Financial_ManagementPort.Put_Spend_Category_HierarchyAsync(Put_Spend_Category_HierarchyInput request)
		{
			return base.Channel.Put_Spend_Category_HierarchyAsync(request);
		}

		public Task<Put_Spend_Category_HierarchyOutput> Put_Spend_Category_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Category_Hierarchy_RequestType Put_Spend_Category_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Spend_Category_HierarchyAsync(new Put_Spend_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Spend_Category_Hierarchy_Request = Put_Spend_Category_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Spend_Category_HierarchiesOutput Financial_ManagementPort.Get_Spend_Category_Hierarchies(Get_Spend_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Spend_Category_Hierarchies(request);
		}

		public Get_Spend_Category_Hierarchies_ResponseType Get_Spend_Category_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Category_Hierarchies_RequestType Get_Spend_Category_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Spend_Category_Hierarchies(new Get_Spend_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Category_Hierarchies_Request = Get_Spend_Category_Hierarchies_Request
			}).Get_Spend_Category_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Spend_Category_HierarchiesOutput> Financial_ManagementPort.Get_Spend_Category_HierarchiesAsync(Get_Spend_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Spend_Category_HierarchiesAsync(request);
		}

		public Task<Get_Spend_Category_HierarchiesOutput> Get_Spend_Category_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Category_Hierarchies_RequestType Get_Spend_Category_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Spend_Category_HierarchiesAsync(new Get_Spend_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Category_Hierarchies_Request = Get_Spend_Category_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Workday_CompaniesOutput Financial_ManagementPort.Get_Workday_Companies(Get_Workday_CompaniesInput request)
		{
			return base.Channel.Get_Workday_Companies(request);
		}

		public Get_Workday_Companies_ResponseType Get_Workday_Companies(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Companies_RequestType Get_Workday_Companies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Workday_Companies(new Get_Workday_CompaniesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Companies_Request = Get_Workday_Companies_Request
			}).Get_Workday_Companies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Workday_CompaniesOutput> Financial_ManagementPort.Get_Workday_CompaniesAsync(Get_Workday_CompaniesInput request)
		{
			return base.Channel.Get_Workday_CompaniesAsync(request);
		}

		public Task<Get_Workday_CompaniesOutput> Get_Workday_CompaniesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Companies_RequestType Get_Workday_Companies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Workday_CompaniesAsync(new Get_Workday_CompaniesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Companies_Request = Get_Workday_Companies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Position_BudgetsOutput Financial_ManagementPort.Get_Position_Budgets(Get_Position_BudgetsInput request)
		{
			return base.Channel.Get_Position_Budgets(request);
		}

		public Get_Position_Budgets_ResponseType Get_Position_Budgets(Workday_Common_HeaderType Workday_Common_Header, Get_Position_Budgets_RequestType Get_Position_Budgets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Position_Budgets(new Get_Position_BudgetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Position_Budgets_Request = Get_Position_Budgets_Request
			}).Get_Position_Budgets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Position_BudgetsOutput> Financial_ManagementPort.Get_Position_BudgetsAsync(Get_Position_BudgetsInput request)
		{
			return base.Channel.Get_Position_BudgetsAsync(request);
		}

		public Task<Get_Position_BudgetsOutput> Get_Position_BudgetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Position_Budgets_RequestType Get_Position_Budgets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Position_BudgetsAsync(new Get_Position_BudgetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Position_Budgets_Request = Get_Position_Budgets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_InvestorOutput Financial_ManagementPort.Put_Investor(Put_InvestorInput request)
		{
			return base.Channel.Put_Investor(request);
		}

		public Put_Investor_ResponseType Put_Investor(Workday_Common_HeaderType Workday_Common_Header, Put_Investor_RequestType Put_Investor_Request)
		{
			return ((Financial_ManagementPort)this).Put_Investor(new Put_InvestorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Investor_Request = Put_Investor_Request
			}).Put_Investor_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_InvestorOutput> Financial_ManagementPort.Put_InvestorAsync(Put_InvestorInput request)
		{
			return base.Channel.Put_InvestorAsync(request);
		}

		public Task<Put_InvestorOutput> Put_InvestorAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Investor_RequestType Put_Investor_Request)
		{
			return ((Financial_ManagementPort)this).Put_InvestorAsync(new Put_InvestorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Investor_Request = Put_Investor_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_InvestorsOutput Financial_ManagementPort.Get_Investors(Get_InvestorsInput request)
		{
			return base.Channel.Get_Investors(request);
		}

		public Get_Investors_ResponseType Get_Investors(Workday_Common_HeaderType Workday_Common_Header, Get_Investors_RequestType Get_Investors_Request)
		{
			return ((Financial_ManagementPort)this).Get_Investors(new Get_InvestorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investors_Request = Get_Investors_Request
			}).Get_Investors_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_InvestorsOutput> Financial_ManagementPort.Get_InvestorsAsync(Get_InvestorsInput request)
		{
			return base.Channel.Get_InvestorsAsync(request);
		}

		public Task<Get_InvestorsOutput> Get_InvestorsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Investors_RequestType Get_Investors_Request)
		{
			return ((Financial_ManagementPort)this).Get_InvestorsAsync(new Get_InvestorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investors_Request = Get_Investors_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Company_1099_MISC_DataOutput Financial_ManagementPort.Get_Company_1099_MISC_Data(Get_Company_1099_MISC_DataInput request)
		{
			return base.Channel.Get_Company_1099_MISC_Data(request);
		}

		public Get_1099_Electronic_Filing_Run_ResponseType Get_Company_1099_MISC_Data(Workday_Common_HeaderType Workday_Common_Header, Get_1099_Data_RequestType Get_1099_Data_Request)
		{
			return ((Financial_ManagementPort)this).Get_Company_1099_MISC_Data(new Get_Company_1099_MISC_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1099_Data_Request = Get_1099_Data_Request
			}).Get_1099_Electronic_Filing_Run_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Company_1099_MISC_DataOutput> Financial_ManagementPort.Get_Company_1099_MISC_DataAsync(Get_Company_1099_MISC_DataInput request)
		{
			return base.Channel.Get_Company_1099_MISC_DataAsync(request);
		}

		public Task<Get_Company_1099_MISC_DataOutput> Get_Company_1099_MISC_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_1099_Data_RequestType Get_1099_Data_Request)
		{
			return ((Financial_ManagementPort)this).Get_Company_1099_MISC_DataAsync(new Get_Company_1099_MISC_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1099_Data_Request = Get_1099_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Basic_Sales_ItemsOutput Financial_ManagementPort.Get_Basic_Sales_Items(Get_Basic_Sales_ItemsInput request)
		{
			return base.Channel.Get_Basic_Sales_Items(request);
		}

		public Get_Basic_Sales_Items_ResponseType Get_Basic_Sales_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Sales_Items_RequestType Get_Basic_Sales_Items_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Sales_Items(new Get_Basic_Sales_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Sales_Items_Request = Get_Basic_Sales_Items_Request
			}).Get_Basic_Sales_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Basic_Sales_ItemsOutput> Financial_ManagementPort.Get_Basic_Sales_ItemsAsync(Get_Basic_Sales_ItemsInput request)
		{
			return base.Channel.Get_Basic_Sales_ItemsAsync(request);
		}

		public Task<Get_Basic_Sales_ItemsOutput> Get_Basic_Sales_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Sales_Items_RequestType Get_Basic_Sales_Items_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Sales_ItemsAsync(new Get_Basic_Sales_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Sales_Items_Request = Get_Basic_Sales_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Basic_Sales_ItemOutput Financial_ManagementPort.Put_Basic_Sales_Item(Put_Basic_Sales_ItemInput request)
		{
			return base.Channel.Put_Basic_Sales_Item(request);
		}

		public Put_Sales_Item_ResponseType Put_Basic_Sales_Item(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Sales_Item_RequestType Put_Basic_Sales_Item_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Sales_Item(new Put_Basic_Sales_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Sales_Item_Request = Put_Basic_Sales_Item_Request
			}).Put_Sales_Item_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Basic_Sales_ItemOutput> Financial_ManagementPort.Put_Basic_Sales_ItemAsync(Put_Basic_Sales_ItemInput request)
		{
			return base.Channel.Put_Basic_Sales_ItemAsync(request);
		}

		public Task<Put_Basic_Sales_ItemOutput> Put_Basic_Sales_ItemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Sales_Item_RequestType Put_Basic_Sales_Item_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Sales_ItemAsync(new Put_Basic_Sales_ItemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Sales_Item_Request = Put_Basic_Sales_Item_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Basic_ProjectsOutput Financial_ManagementPort.Get_Basic_Projects(Get_Basic_ProjectsInput request)
		{
			return base.Channel.Get_Basic_Projects(request);
		}

		public Get_Basic_Projects_ResponseType Get_Basic_Projects(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Projects_RequestType Get_Basic_Projects_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Projects(new Get_Basic_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Projects_Request = Get_Basic_Projects_Request
			}).Get_Basic_Projects_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Basic_ProjectsOutput> Financial_ManagementPort.Get_Basic_ProjectsAsync(Get_Basic_ProjectsInput request)
		{
			return base.Channel.Get_Basic_ProjectsAsync(request);
		}

		public Task<Get_Basic_ProjectsOutput> Get_Basic_ProjectsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Projects_RequestType Get_Basic_Projects_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_ProjectsAsync(new Get_Basic_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Projects_Request = Get_Basic_Projects_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Basic_ProjectOutput Financial_ManagementPort.Put_Basic_Project(Put_Basic_ProjectInput request)
		{
			return base.Channel.Put_Basic_Project(request);
		}

		public Put_Project_ResponseType Put_Basic_Project(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Project_RequestType Put_Basic_Project_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Project(new Put_Basic_ProjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Project_Request = Put_Basic_Project_Request
			}).Put_Project_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Basic_ProjectOutput> Financial_ManagementPort.Put_Basic_ProjectAsync(Put_Basic_ProjectInput request)
		{
			return base.Channel.Put_Basic_ProjectAsync(request);
		}

		public Task<Put_Basic_ProjectOutput> Put_Basic_ProjectAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Project_RequestType Put_Basic_Project_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_ProjectAsync(new Put_Basic_ProjectInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Project_Request = Put_Basic_Project_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Basic_SuppliersOutput Financial_ManagementPort.Get_Basic_Suppliers(Get_Basic_SuppliersInput request)
		{
			return base.Channel.Get_Basic_Suppliers(request);
		}

		public Get_Basic_Suppliers_ResponseType Get_Basic_Suppliers(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Suppliers_RequestType Get_Basic_Suppliers_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Suppliers(new Get_Basic_SuppliersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Suppliers_Request = Get_Basic_Suppliers_Request
			}).Get_Basic_Suppliers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Basic_SuppliersOutput> Financial_ManagementPort.Get_Basic_SuppliersAsync(Get_Basic_SuppliersInput request)
		{
			return base.Channel.Get_Basic_SuppliersAsync(request);
		}

		public Task<Get_Basic_SuppliersOutput> Get_Basic_SuppliersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Suppliers_RequestType Get_Basic_Suppliers_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_SuppliersAsync(new Get_Basic_SuppliersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Suppliers_Request = Get_Basic_Suppliers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Basic_SupplierOutput Financial_ManagementPort.Put_Basic_Supplier(Put_Basic_SupplierInput request)
		{
			return base.Channel.Put_Basic_Supplier(request);
		}

		public Put_Supplier_ResponseType Put_Basic_Supplier(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Supplier_RequestType Put_Basic_Supplier_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Supplier(new Put_Basic_SupplierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Supplier_Request = Put_Basic_Supplier_Request
			}).Put_Supplier_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Basic_SupplierOutput> Financial_ManagementPort.Put_Basic_SupplierAsync(Put_Basic_SupplierInput request)
		{
			return base.Channel.Put_Basic_SupplierAsync(request);
		}

		public Task<Put_Basic_SupplierOutput> Put_Basic_SupplierAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Supplier_RequestType Put_Basic_Supplier_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_SupplierAsync(new Put_Basic_SupplierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Supplier_Request = Put_Basic_Supplier_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Basic_CustomersOutput Financial_ManagementPort.Get_Basic_Customers(Get_Basic_CustomersInput request)
		{
			return base.Channel.Get_Basic_Customers(request);
		}

		public Get_Basic_Customers_ResponseType Get_Basic_Customers(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Customers_RequestType Get_Basic_Customers_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Customers(new Get_Basic_CustomersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Customers_Request = Get_Basic_Customers_Request
			}).Get_Basic_Customers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Basic_CustomersOutput> Financial_ManagementPort.Get_Basic_CustomersAsync(Get_Basic_CustomersInput request)
		{
			return base.Channel.Get_Basic_CustomersAsync(request);
		}

		public Task<Get_Basic_CustomersOutput> Get_Basic_CustomersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Customers_RequestType Get_Basic_Customers_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_CustomersAsync(new Get_Basic_CustomersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Customers_Request = Get_Basic_Customers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Basic_CustomerOutput Financial_ManagementPort.Put_Basic_Customer(Put_Basic_CustomerInput request)
		{
			return base.Channel.Put_Basic_Customer(request);
		}

		public Put_Customer_ResponseType Put_Basic_Customer(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Customer_RequestType Put_Basic_Customer_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Customer(new Put_Basic_CustomerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Customer_Request = Put_Basic_Customer_Request
			}).Put_Customer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Basic_CustomerOutput> Financial_ManagementPort.Put_Basic_CustomerAsync(Put_Basic_CustomerInput request)
		{
			return base.Channel.Put_Basic_CustomerAsync(request);
		}

		public Task<Put_Basic_CustomerOutput> Put_Basic_CustomerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Customer_RequestType Put_Basic_Customer_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_CustomerAsync(new Put_Basic_CustomerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Customer_Request = Put_Basic_Customer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Accounting_JournalOutput Financial_ManagementPort.Unpost_Accounting_Journal(Unpost_Accounting_JournalInput request)
		{
			return base.Channel.Unpost_Accounting_Journal(request);
		}

		public Cancel_Accounting_Journal_ResponseType Unpost_Accounting_Journal(Workday_Common_HeaderType Workday_Common_Header, Unpost_Accounting_Journal_RequestType Unpost_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Unpost_Accounting_Journal(new Unpost_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Unpost_Accounting_Journal_Request = Unpost_Accounting_Journal_Request
			}).Cancel_Accounting_Journal_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Accounting_JournalOutput> Financial_ManagementPort.Unpost_Accounting_JournalAsync(Unpost_Accounting_JournalInput request)
		{
			return base.Channel.Unpost_Accounting_JournalAsync(request);
		}

		public Task<Cancel_Accounting_JournalOutput> Unpost_Accounting_JournalAsync(Workday_Common_HeaderType Workday_Common_Header, Unpost_Accounting_Journal_RequestType Unpost_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Unpost_Accounting_JournalAsync(new Unpost_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Unpost_Accounting_Journal_Request = Unpost_Accounting_Journal_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_1099_MISCsOutput Financial_ManagementPort.Get_1099_MISCs(Get_1099_MISCsInput request)
		{
			return base.Channel.Get_1099_MISCs(request);
		}

		public Get_1099_Miscs_ResponseType Get_1099_MISCs(Workday_Common_HeaderType Workday_Common_Header, Get_1099_Miscs_RequestType Get_1099_Miscs_Request)
		{
			return ((Financial_ManagementPort)this).Get_1099_MISCs(new Get_1099_MISCsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1099_Miscs_Request = Get_1099_Miscs_Request
			}).Get_1099_Miscs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_1099_MISCsOutput> Financial_ManagementPort.Get_1099_MISCsAsync(Get_1099_MISCsInput request)
		{
			return base.Channel.Get_1099_MISCsAsync(request);
		}

		public Task<Get_1099_MISCsOutput> Get_1099_MISCsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_1099_Miscs_RequestType Get_1099_Miscs_Request)
		{
			return ((Financial_ManagementPort)this).Get_1099_MISCsAsync(new Get_1099_MISCsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1099_Miscs_Request = Get_1099_Miscs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Fund_HierarchyOutput Financial_ManagementPort.Put_Fund_Hierarchy(Put_Fund_HierarchyInput request)
		{
			return base.Channel.Put_Fund_Hierarchy(request);
		}

		public Put_Fund_Hierarchy_ResponseType Put_Fund_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Fund_Hierarchy_RequestType Put_Fund_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fund_Hierarchy(new Put_Fund_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fund_Hierarchy_Request = Put_Fund_Hierarchy_Request
			}).Put_Fund_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Fund_HierarchyOutput> Financial_ManagementPort.Put_Fund_HierarchyAsync(Put_Fund_HierarchyInput request)
		{
			return base.Channel.Put_Fund_HierarchyAsync(request);
		}

		public Task<Put_Fund_HierarchyOutput> Put_Fund_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Fund_Hierarchy_RequestType Put_Fund_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fund_HierarchyAsync(new Put_Fund_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fund_Hierarchy_Request = Put_Fund_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Fund_HierarchiesOutput Financial_ManagementPort.Get_Fund_Hierarchies(Get_Fund_HierarchiesInput request)
		{
			return base.Channel.Get_Fund_Hierarchies(request);
		}

		public Get_Fund_Hierarchies_ResponseType Get_Fund_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Fund_Hierarchies_RequestType Get_Fund_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Fund_Hierarchies(new Get_Fund_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fund_Hierarchies_Request = Get_Fund_Hierarchies_Request
			}).Get_Fund_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Fund_HierarchiesOutput> Financial_ManagementPort.Get_Fund_HierarchiesAsync(Get_Fund_HierarchiesInput request)
		{
			return base.Channel.Get_Fund_HierarchiesAsync(request);
		}

		public Task<Get_Fund_HierarchiesOutput> Get_Fund_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Fund_Hierarchies_RequestType Get_Fund_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Fund_HierarchiesAsync(new Get_Fund_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fund_Hierarchies_Request = Get_Fund_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_GrantOutput Financial_ManagementPort.Put_Grant(Put_GrantInput request)
		{
			return base.Channel.Put_Grant(request);
		}

		public Put_Grant_ResponseType Put_Grant(Workday_Common_HeaderType Workday_Common_Header, Put_Grant_RequestType Put_Grant_Request)
		{
			return ((Financial_ManagementPort)this).Put_Grant(new Put_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Grant_Request = Put_Grant_Request
			}).Put_Grant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_GrantOutput> Financial_ManagementPort.Put_GrantAsync(Put_GrantInput request)
		{
			return base.Channel.Put_GrantAsync(request);
		}

		public Task<Put_GrantOutput> Put_GrantAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Grant_RequestType Put_Grant_Request)
		{
			return ((Financial_ManagementPort)this).Put_GrantAsync(new Put_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Grant_Request = Put_Grant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_GrantsOutput Financial_ManagementPort.Get_Grants(Get_GrantsInput request)
		{
			return base.Channel.Get_Grants(request);
		}

		public Get_Grants_ResponseType Get_Grants(Workday_Common_HeaderType Workday_Common_Header, Get_Grants_RequestType Get_Grants_Request)
		{
			return ((Financial_ManagementPort)this).Get_Grants(new Get_GrantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Grants_Request = Get_Grants_Request
			}).Get_Grants_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_GrantsOutput> Financial_ManagementPort.Get_GrantsAsync(Get_GrantsInput request)
		{
			return base.Channel.Get_GrantsAsync(request);
		}

		public Task<Get_GrantsOutput> Get_GrantsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Grants_RequestType Get_Grants_Request)
		{
			return ((Financial_ManagementPort)this).Get_GrantsAsync(new Get_GrantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Grants_Request = Get_Grants_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_UnitOutput Financial_ManagementPort.Put_Business_Unit(Put_Business_UnitInput request)
		{
			return base.Channel.Put_Business_Unit(request);
		}

		public Put_Business_Unit_ResponseType Put_Business_Unit(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Unit_RequestType Put_Business_Unit_Request)
		{
			return ((Financial_ManagementPort)this).Put_Business_Unit(new Put_Business_UnitInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Unit_Request = Put_Business_Unit_Request
			}).Put_Business_Unit_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_UnitOutput> Financial_ManagementPort.Put_Business_UnitAsync(Put_Business_UnitInput request)
		{
			return base.Channel.Put_Business_UnitAsync(request);
		}

		public Task<Put_Business_UnitOutput> Put_Business_UnitAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Unit_RequestType Put_Business_Unit_Request)
		{
			return ((Financial_ManagementPort)this).Put_Business_UnitAsync(new Put_Business_UnitInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Unit_Request = Put_Business_Unit_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_UnitsOutput Financial_ManagementPort.Get_Business_Units(Get_Business_UnitsInput request)
		{
			return base.Channel.Get_Business_Units(request);
		}

		public Get_Business_Units_ResponseType Get_Business_Units(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Units_RequestType Get_Business_Units_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Units(new Get_Business_UnitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Units_Request = Get_Business_Units_Request
			}).Get_Business_Units_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_UnitsOutput> Financial_ManagementPort.Get_Business_UnitsAsync(Get_Business_UnitsInput request)
		{
			return base.Channel.Get_Business_UnitsAsync(request);
		}

		public Task<Get_Business_UnitsOutput> Get_Business_UnitsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Units_RequestType Get_Business_Units_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_UnitsAsync(new Get_Business_UnitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Units_Request = Get_Business_Units_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_Unit_HierarchyOutput Financial_ManagementPort.Put_Business_Unit_Hierarchy(Put_Business_Unit_HierarchyInput request)
		{
			return base.Channel.Put_Business_Unit_Hierarchy(request);
		}

		public Put_Business_Unit_Hierarchy_ResponseType Put_Business_Unit_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Unit_Hierarchy_RequestType Put_Business_Unit_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Business_Unit_Hierarchy(new Put_Business_Unit_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Unit_Hierarchy_Request = Put_Business_Unit_Hierarchy_Request
			}).Put_Business_Unit_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_Unit_HierarchyOutput> Financial_ManagementPort.Put_Business_Unit_HierarchyAsync(Put_Business_Unit_HierarchyInput request)
		{
			return base.Channel.Put_Business_Unit_HierarchyAsync(request);
		}

		public Task<Put_Business_Unit_HierarchyOutput> Put_Business_Unit_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Unit_Hierarchy_RequestType Put_Business_Unit_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Business_Unit_HierarchyAsync(new Put_Business_Unit_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Unit_Hierarchy_Request = Put_Business_Unit_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_Unit_HierarchiesOutput Financial_ManagementPort.Get_Business_Unit_Hierarchies(Get_Business_Unit_HierarchiesInput request)
		{
			return base.Channel.Get_Business_Unit_Hierarchies(request);
		}

		public Get_Business_Unit_Hierarchies_ResponseType Get_Business_Unit_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Unit_Hierarchies_RequestType Get_Business_Unit_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Unit_Hierarchies(new Get_Business_Unit_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Unit_Hierarchies_Request = Get_Business_Unit_Hierarchies_Request
			}).Get_Business_Unit_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_Unit_HierarchiesOutput> Financial_ManagementPort.Get_Business_Unit_HierarchiesAsync(Get_Business_Unit_HierarchiesInput request)
		{
			return base.Channel.Get_Business_Unit_HierarchiesAsync(request);
		}

		public Task<Get_Business_Unit_HierarchiesOutput> Get_Business_Unit_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Unit_Hierarchies_RequestType Get_Business_Unit_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Business_Unit_HierarchiesAsync(new Get_Business_Unit_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Unit_Hierarchies_Request = Get_Business_Unit_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SurveysOutput Financial_ManagementPort.Get_Surveys(Get_SurveysInput request)
		{
			return base.Channel.Get_Surveys(request);
		}

		public Get_Surveys_ResponseType Get_Surveys(Workday_Common_HeaderType Workday_Common_Header, Get_Surveys_RequestType Get_Surveys_Request)
		{
			return ((Financial_ManagementPort)this).Get_Surveys(new Get_SurveysInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Surveys_Request = Get_Surveys_Request
			}).Get_Surveys_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SurveysOutput> Financial_ManagementPort.Get_SurveysAsync(Get_SurveysInput request)
		{
			return base.Channel.Get_SurveysAsync(request);
		}

		public Task<Get_SurveysOutput> Get_SurveysAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Surveys_RequestType Get_Surveys_Request)
		{
			return ((Financial_ManagementPort)this).Get_SurveysAsync(new Get_SurveysInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Surveys_Request = Get_Surveys_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ProgramOutput Financial_ManagementPort.Put_Program(Put_ProgramInput request)
		{
			return base.Channel.Put_Program(request);
		}

		public Put_Program_ResponseType Put_Program(Workday_Common_HeaderType Workday_Common_Header, Put_Program_RequestType Put_Program_Request)
		{
			return ((Financial_ManagementPort)this).Put_Program(new Put_ProgramInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Program_Request = Put_Program_Request
			}).Put_Program_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ProgramOutput> Financial_ManagementPort.Put_ProgramAsync(Put_ProgramInput request)
		{
			return base.Channel.Put_ProgramAsync(request);
		}

		public Task<Put_ProgramOutput> Put_ProgramAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Program_RequestType Put_Program_Request)
		{
			return ((Financial_ManagementPort)this).Put_ProgramAsync(new Put_ProgramInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Program_Request = Put_Program_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ProgramsOutput Financial_ManagementPort.Get_Programs(Get_ProgramsInput request)
		{
			return base.Channel.Get_Programs(request);
		}

		public Get_Programs_ResponseType Get_Programs(Workday_Common_HeaderType Workday_Common_Header, Get_Programs_RequestType Get_Programs_Request)
		{
			return ((Financial_ManagementPort)this).Get_Programs(new Get_ProgramsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Programs_Request = Get_Programs_Request
			}).Get_Programs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ProgramsOutput> Financial_ManagementPort.Get_ProgramsAsync(Get_ProgramsInput request)
		{
			return base.Channel.Get_ProgramsAsync(request);
		}

		public Task<Get_ProgramsOutput> Get_ProgramsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Programs_RequestType Get_Programs_Request)
		{
			return ((Financial_ManagementPort)this).Get_ProgramsAsync(new Get_ProgramsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Programs_Request = Get_Programs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Program_HierarchyOutput Financial_ManagementPort.Put_Program_Hierarchy(Put_Program_HierarchyInput request)
		{
			return base.Channel.Put_Program_Hierarchy(request);
		}

		public Put_Program_Hierarchy_ResponseType Put_Program_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Program_Hierarchy_RequestType Put_Program_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Program_Hierarchy(new Put_Program_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Program_Hierarchy_Request = Put_Program_Hierarchy_Request
			}).Put_Program_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Program_HierarchyOutput> Financial_ManagementPort.Put_Program_HierarchyAsync(Put_Program_HierarchyInput request)
		{
			return base.Channel.Put_Program_HierarchyAsync(request);
		}

		public Task<Put_Program_HierarchyOutput> Put_Program_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Program_Hierarchy_RequestType Put_Program_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Program_HierarchyAsync(new Put_Program_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Program_Hierarchy_Request = Put_Program_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SurveyOutput Financial_ManagementPort.Put_Survey(Put_SurveyInput request)
		{
			return base.Channel.Put_Survey(request);
		}

		public Put_Survey_ResponseType Put_Survey(Workday_Common_HeaderType Workday_Common_Header, Put_Survey_RequestType Put_Survey_Request)
		{
			return ((Financial_ManagementPort)this).Put_Survey(new Put_SurveyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Survey_Request = Put_Survey_Request
			}).Put_Survey_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SurveyOutput> Financial_ManagementPort.Put_SurveyAsync(Put_SurveyInput request)
		{
			return base.Channel.Put_SurveyAsync(request);
		}

		public Task<Put_SurveyOutput> Put_SurveyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Survey_RequestType Put_Survey_Request)
		{
			return ((Financial_ManagementPort)this).Put_SurveyAsync(new Put_SurveyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Survey_Request = Put_Survey_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Program_HierarchiesOutput Financial_ManagementPort.Get_Program_Hierarchies(Get_Program_HierarchiesInput request)
		{
			return base.Channel.Get_Program_Hierarchies(request);
		}

		public Get_Program_Hierarchies_ResponseType Get_Program_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Program_Hierarchies_RequestType Get_Program_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Program_Hierarchies(new Get_Program_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Program_Hierarchies_Request = Get_Program_Hierarchies_Request
			}).Get_Program_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Program_HierarchiesOutput> Financial_ManagementPort.Get_Program_HierarchiesAsync(Get_Program_HierarchiesInput request)
		{
			return base.Channel.Get_Program_HierarchiesAsync(request);
		}

		public Task<Get_Program_HierarchiesOutput> Get_Program_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Program_Hierarchies_RequestType Get_Program_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Program_HierarchiesAsync(new Get_Program_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Program_Hierarchies_Request = Get_Program_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Object_Class_SetOutput Financial_ManagementPort.Put_Object_Class_Set(Put_Object_Class_SetInput request)
		{
			return base.Channel.Put_Object_Class_Set(request);
		}

		public Put_Object_Class_Set_ResponseType Put_Object_Class_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Object_Class_Set_RequestType Put_Object_Class_Set_Request)
		{
			return ((Financial_ManagementPort)this).Put_Object_Class_Set(new Put_Object_Class_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Object_Class_Set_Request = Put_Object_Class_Set_Request
			}).Put_Object_Class_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Object_Class_SetOutput> Financial_ManagementPort.Put_Object_Class_SetAsync(Put_Object_Class_SetInput request)
		{
			return base.Channel.Put_Object_Class_SetAsync(request);
		}

		public Task<Put_Object_Class_SetOutput> Put_Object_Class_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Object_Class_Set_RequestType Put_Object_Class_Set_Request)
		{
			return ((Financial_ManagementPort)this).Put_Object_Class_SetAsync(new Put_Object_Class_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Object_Class_Set_Request = Put_Object_Class_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Object_Class_SetsOutput Financial_ManagementPort.Get_Object_Class_Sets(Get_Object_Class_SetsInput request)
		{
			return base.Channel.Get_Object_Class_Sets(request);
		}

		public Get_Object_Class_Sets_ResponseType Get_Object_Class_Sets(Workday_Common_HeaderType Workday_Common_Header, Get_Object_Class_Sets_RequestType Get_Object_Class_Sets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Object_Class_Sets(new Get_Object_Class_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Object_Class_Sets_Request = Get_Object_Class_Sets_Request
			}).Get_Object_Class_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Object_Class_SetsOutput> Financial_ManagementPort.Get_Object_Class_SetsAsync(Get_Object_Class_SetsInput request)
		{
			return base.Channel.Get_Object_Class_SetsAsync(request);
		}

		public Task<Get_Object_Class_SetsOutput> Get_Object_Class_SetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Object_Class_Sets_RequestType Get_Object_Class_Sets_Request)
		{
			return ((Financial_ManagementPort)this).Get_Object_Class_SetsAsync(new Get_Object_Class_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Object_Class_Sets_Request = Get_Object_Class_Sets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Search_SettingsOutput Financial_ManagementPort.Get_Search_Settings(Get_Search_SettingsInput request)
		{
			return base.Channel.Get_Search_Settings(request);
		}

		public Get_Search_Settings_ResponseType Get_Search_Settings(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Settings_RequestType Get_Search_Settings_Request)
		{
			return ((Financial_ManagementPort)this).Get_Search_Settings(new Get_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Search_Settings_Request = Get_Search_Settings_Request
			}).Get_Search_Settings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Search_SettingsOutput> Financial_ManagementPort.Get_Search_SettingsAsync(Get_Search_SettingsInput request)
		{
			return base.Channel.Get_Search_SettingsAsync(request);
		}

		public Task<Get_Search_SettingsOutput> Get_Search_SettingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Settings_RequestType Get_Search_Settings_Request)
		{
			return ((Financial_ManagementPort)this).Get_Search_SettingsAsync(new Get_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Search_Settings_Request = Get_Search_Settings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Search_SettingsOutput Financial_ManagementPort.Put_Search_Settings(Put_Search_SettingsInput request)
		{
			return base.Channel.Put_Search_Settings(request);
		}

		public Put_Search_Settings_ResponseType Put_Search_Settings(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Settings_RequestType Put_Search_Settings_Request)
		{
			return ((Financial_ManagementPort)this).Put_Search_Settings(new Put_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Search_Settings_Request = Put_Search_Settings_Request
			}).Put_Search_Settings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Search_SettingsOutput> Financial_ManagementPort.Put_Search_SettingsAsync(Put_Search_SettingsInput request)
		{
			return base.Channel.Put_Search_SettingsAsync(request);
		}

		public Task<Put_Search_SettingsOutput> Put_Search_SettingsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Settings_RequestType Put_Search_Settings_Request)
		{
			return ((Financial_ManagementPort)this).Put_Search_SettingsAsync(new Put_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Search_Settings_Request = Put_Search_Settings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Effort_Certification_Change_Reason_CodeOutput Financial_ManagementPort.Put_Effort_Certification_Change_Reason_Code(Put_Effort_Certification_Change_Reason_CodeInput request)
		{
			return base.Channel.Put_Effort_Certification_Change_Reason_Code(request);
		}

		public Put_Effort_Certification_Change_Reason_Code_ResponseType Put_Effort_Certification_Change_Reason_Code(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certification_Change_Reason_Code_RequestType Put_Effort_Certification_Change_Reason_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_Effort_Certification_Change_Reason_Code(new Put_Effort_Certification_Change_Reason_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Effort_Certification_Change_Reason_Code_Request = Put_Effort_Certification_Change_Reason_Code_Request
			}).Put_Effort_Certification_Change_Reason_Code_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Effort_Certification_Change_Reason_CodeOutput> Financial_ManagementPort.Put_Effort_Certification_Change_Reason_CodeAsync(Put_Effort_Certification_Change_Reason_CodeInput request)
		{
			return base.Channel.Put_Effort_Certification_Change_Reason_CodeAsync(request);
		}

		public Task<Put_Effort_Certification_Change_Reason_CodeOutput> Put_Effort_Certification_Change_Reason_CodeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certification_Change_Reason_Code_RequestType Put_Effort_Certification_Change_Reason_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_Effort_Certification_Change_Reason_CodeAsync(new Put_Effort_Certification_Change_Reason_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Effort_Certification_Change_Reason_Code_Request = Put_Effort_Certification_Change_Reason_Code_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Effort_Certification_Change_Reason_CodesOutput Financial_ManagementPort.Get_Effort_Certification_Change_Reason_Codes(Get_Effort_Certification_Change_Reason_CodesInput request)
		{
			return base.Channel.Get_Effort_Certification_Change_Reason_Codes(request);
		}

		public Get_Effort_Certification_Change_Reason_Codes_ResponseType Get_Effort_Certification_Change_Reason_Codes(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Change_Reason_Codes_RequestType Get_Effort_Certification_Change_Reason_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certification_Change_Reason_Codes(new Get_Effort_Certification_Change_Reason_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certification_Change_Reason_Codes_Request = Get_Effort_Certification_Change_Reason_Codes_Request
			}).Get_Effort_Certification_Change_Reason_Codes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Effort_Certification_Change_Reason_CodesOutput> Financial_ManagementPort.Get_Effort_Certification_Change_Reason_CodesAsync(Get_Effort_Certification_Change_Reason_CodesInput request)
		{
			return base.Channel.Get_Effort_Certification_Change_Reason_CodesAsync(request);
		}

		public Task<Get_Effort_Certification_Change_Reason_CodesOutput> Get_Effort_Certification_Change_Reason_CodesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Change_Reason_Codes_RequestType Get_Effort_Certification_Change_Reason_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certification_Change_Reason_CodesAsync(new Get_Effort_Certification_Change_Reason_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certification_Change_Reason_Codes_Request = Get_Effort_Certification_Change_Reason_Codes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Effort_Certifying_TextsOutput Financial_ManagementPort.Get_Effort_Certifying_Texts(Get_Effort_Certifying_TextsInput request)
		{
			return base.Channel.Get_Effort_Certifying_Texts(request);
		}

		public Get_Effort_Certifying_Texts_ResponseType Get_Effort_Certifying_Texts(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certifying_Texts_RequestType Get_Effort_Certifying_Texts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certifying_Texts(new Get_Effort_Certifying_TextsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certifying_Texts_Request = Get_Effort_Certifying_Texts_Request
			}).Get_Effort_Certifying_Texts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Effort_Certifying_TextsOutput> Financial_ManagementPort.Get_Effort_Certifying_TextsAsync(Get_Effort_Certifying_TextsInput request)
		{
			return base.Channel.Get_Effort_Certifying_TextsAsync(request);
		}

		public Task<Get_Effort_Certifying_TextsOutput> Get_Effort_Certifying_TextsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certifying_Texts_RequestType Get_Effort_Certifying_Texts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certifying_TextsAsync(new Get_Effort_Certifying_TextsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certifying_Texts_Request = Get_Effort_Certifying_Texts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Effort_Certification_Eligibility_RulesOutput Financial_ManagementPort.Get_Effort_Certification_Eligibility_Rules(Get_Effort_Certification_Eligibility_RulesInput request)
		{
			return base.Channel.Get_Effort_Certification_Eligibility_Rules(request);
		}

		public Get_Effort_Certification_Eligibility_Rules_ResponseType Get_Effort_Certification_Eligibility_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Eligibility_Rules_RequestType Get_Effort_Certification_Eligibility_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certification_Eligibility_Rules(new Get_Effort_Certification_Eligibility_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certification_Eligibility_Rules_Request = Get_Effort_Certification_Eligibility_Rules_Request
			}).Get_Effort_Certification_Eligibility_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Effort_Certification_Eligibility_RulesOutput> Financial_ManagementPort.Get_Effort_Certification_Eligibility_RulesAsync(Get_Effort_Certification_Eligibility_RulesInput request)
		{
			return base.Channel.Get_Effort_Certification_Eligibility_RulesAsync(request);
		}

		public Task<Get_Effort_Certification_Eligibility_RulesOutput> Get_Effort_Certification_Eligibility_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Eligibility_Rules_RequestType Get_Effort_Certification_Eligibility_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certification_Eligibility_RulesAsync(new Get_Effort_Certification_Eligibility_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certification_Eligibility_Rules_Request = Get_Effort_Certification_Eligibility_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Effort_Certifying_TextOutput Financial_ManagementPort.Put_Effort_Certifying_Text(Put_Effort_Certifying_TextInput request)
		{
			return base.Channel.Put_Effort_Certifying_Text(request);
		}

		public Put_Effort_Certifying_Text_ResponseType Put_Effort_Certifying_Text(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certifying_Text_RequestType Put_Effort_Certifying_Text_Request)
		{
			return ((Financial_ManagementPort)this).Put_Effort_Certifying_Text(new Put_Effort_Certifying_TextInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Effort_Certifying_Text_Request = Put_Effort_Certifying_Text_Request
			}).Put_Effort_Certifying_Text_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Effort_Certifying_TextOutput> Financial_ManagementPort.Put_Effort_Certifying_TextAsync(Put_Effort_Certifying_TextInput request)
		{
			return base.Channel.Put_Effort_Certifying_TextAsync(request);
		}

		public Task<Put_Effort_Certifying_TextOutput> Put_Effort_Certifying_TextAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certifying_Text_RequestType Put_Effort_Certifying_Text_Request)
		{
			return ((Financial_ManagementPort)this).Put_Effort_Certifying_TextAsync(new Put_Effort_Certifying_TextInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Effort_Certifying_Text_Request = Put_Effort_Certifying_Text_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Effort_Certification_TypesOutput Financial_ManagementPort.Get_Effort_Certification_Types(Get_Effort_Certification_TypesInput request)
		{
			return base.Channel.Get_Effort_Certification_Types(request);
		}

		public Get_Effort_Certification_Types_ResponseType Get_Effort_Certification_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Types_RequestType Get_Effort_Certification_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certification_Types(new Get_Effort_Certification_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certification_Types_Request = Get_Effort_Certification_Types_Request
			}).Get_Effort_Certification_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Effort_Certification_TypesOutput> Financial_ManagementPort.Get_Effort_Certification_TypesAsync(Get_Effort_Certification_TypesInput request)
		{
			return base.Channel.Get_Effort_Certification_TypesAsync(request);
		}

		public Task<Get_Effort_Certification_TypesOutput> Get_Effort_Certification_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Effort_Certification_Types_RequestType Get_Effort_Certification_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Effort_Certification_TypesAsync(new Get_Effort_Certification_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Effort_Certification_Types_Request = Get_Effort_Certification_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Effort_Certification_TypeOutput Financial_ManagementPort.Put_Effort_Certification_Type(Put_Effort_Certification_TypeInput request)
		{
			return base.Channel.Put_Effort_Certification_Type(request);
		}

		public Put_Effort_Certification_Type_ResponseType Put_Effort_Certification_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certification_Type_RequestType Put_Effort_Certification_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Effort_Certification_Type(new Put_Effort_Certification_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Effort_Certification_Type_Request = Put_Effort_Certification_Type_Request
			}).Put_Effort_Certification_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Effort_Certification_TypeOutput> Financial_ManagementPort.Put_Effort_Certification_TypeAsync(Put_Effort_Certification_TypeInput request)
		{
			return base.Channel.Put_Effort_Certification_TypeAsync(request);
		}

		public Task<Put_Effort_Certification_TypeOutput> Put_Effort_Certification_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Effort_Certification_Type_RequestType Put_Effort_Certification_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Effort_Certification_TypeAsync(new Put_Effort_Certification_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Effort_Certification_Type_Request = Put_Effort_Certification_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Currency_Conversion_RatesOutput Financial_ManagementPort.Put_Currency_Conversion_Rates(Put_Currency_Conversion_RatesInput request)
		{
			return base.Channel.Put_Currency_Conversion_Rates(request);
		}

		public Put_Currency_Conversion_Rates_ResponseType Put_Currency_Conversion_Rates(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Conversion_Rates_RequestType Put_Currency_Conversion_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Put_Currency_Conversion_Rates(new Put_Currency_Conversion_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Currency_Conversion_Rates_Request = Put_Currency_Conversion_Rates_Request
			}).Put_Currency_Conversion_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Currency_Conversion_RatesOutput> Financial_ManagementPort.Put_Currency_Conversion_RatesAsync(Put_Currency_Conversion_RatesInput request)
		{
			return base.Channel.Put_Currency_Conversion_RatesAsync(request);
		}

		public Task<Put_Currency_Conversion_RatesOutput> Put_Currency_Conversion_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Conversion_Rates_RequestType Put_Currency_Conversion_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Put_Currency_Conversion_RatesAsync(new Put_Currency_Conversion_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Currency_Conversion_Rates_Request = Put_Currency_Conversion_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Grant_HierarchiesOutput Financial_ManagementPort.Get_Grant_Hierarchies(Get_Grant_HierarchiesInput request)
		{
			return base.Channel.Get_Grant_Hierarchies(request);
		}

		public Get_Grant_Hierarchies_ResponseType Get_Grant_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Grant_Hierarchies_RequestType Get_Grant_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Grant_Hierarchies(new Get_Grant_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Grant_Hierarchies_Request = Get_Grant_Hierarchies_Request
			}).Get_Grant_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Grant_HierarchiesOutput> Financial_ManagementPort.Get_Grant_HierarchiesAsync(Get_Grant_HierarchiesInput request)
		{
			return base.Channel.Get_Grant_HierarchiesAsync(request);
		}

		public Task<Get_Grant_HierarchiesOutput> Get_Grant_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Grant_Hierarchies_RequestType Get_Grant_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Grant_HierarchiesAsync(new Get_Grant_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Grant_Hierarchies_Request = Get_Grant_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Grant_HierarchyOutput Financial_ManagementPort.Put_Grant_Hierarchy(Put_Grant_HierarchyInput request)
		{
			return base.Channel.Put_Grant_Hierarchy(request);
		}

		public Put_Grant_Hierarchy_ResponseType Put_Grant_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Grant_Hierarchy_RequestType Put_Grant_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Grant_Hierarchy(new Put_Grant_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Grant_Hierarchy_Request = Put_Grant_Hierarchy_Request
			}).Put_Grant_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Grant_HierarchyOutput> Financial_ManagementPort.Put_Grant_HierarchyAsync(Put_Grant_HierarchyInput request)
		{
			return base.Channel.Put_Grant_HierarchyAsync(request);
		}

		public Task<Put_Grant_HierarchyOutput> Put_Grant_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Grant_Hierarchy_RequestType Put_Grant_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Grant_HierarchyAsync(new Put_Grant_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Grant_Hierarchy_Request = Put_Grant_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_1099_MISC_AdjustmentsOutput Financial_ManagementPort.Get_1099_MISC_Adjustments(Get_1099_MISC_AdjustmentsInput request)
		{
			return base.Channel.Get_1099_MISC_Adjustments(request);
		}

		public Get_1099_MISC_Adjustments_ResponseType Get_1099_MISC_Adjustments(Workday_Common_HeaderType Workday_Common_Header, Get_1099_MISC_Adjustments_RequestType Get_1099_MISC_Adjustments_Request)
		{
			return ((Financial_ManagementPort)this).Get_1099_MISC_Adjustments(new Get_1099_MISC_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1099_MISC_Adjustments_Request = Get_1099_MISC_Adjustments_Request
			}).Get_1099_MISC_Adjustments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_1099_MISC_AdjustmentsOutput> Financial_ManagementPort.Get_1099_MISC_AdjustmentsAsync(Get_1099_MISC_AdjustmentsInput request)
		{
			return base.Channel.Get_1099_MISC_AdjustmentsAsync(request);
		}

		public Task<Get_1099_MISC_AdjustmentsOutput> Get_1099_MISC_AdjustmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_1099_MISC_Adjustments_RequestType Get_1099_MISC_Adjustments_Request)
		{
			return ((Financial_ManagementPort)this).Get_1099_MISC_AdjustmentsAsync(new Get_1099_MISC_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1099_MISC_Adjustments_Request = Get_1099_MISC_Adjustments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_1099_MISC_AdjustmentOutput Financial_ManagementPort.Submit_1099_MISC_Adjustment(Submit_1099_MISC_AdjustmentInput request)
		{
			return base.Channel.Submit_1099_MISC_Adjustment(request);
		}

		public Submit_1099_MISC_Adjustment_ResponseType Submit_1099_MISC_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Submit_1099_MISC_Adjustment_RequestType Submit_1099_MISC_Adjustment_Request)
		{
			return ((Financial_ManagementPort)this).Submit_1099_MISC_Adjustment(new Submit_1099_MISC_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_1099_MISC_Adjustment_Request = Submit_1099_MISC_Adjustment_Request
			}).Submit_1099_MISC_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_1099_MISC_AdjustmentOutput> Financial_ManagementPort.Submit_1099_MISC_AdjustmentAsync(Submit_1099_MISC_AdjustmentInput request)
		{
			return base.Channel.Submit_1099_MISC_AdjustmentAsync(request);
		}

		public Task<Submit_1099_MISC_AdjustmentOutput> Submit_1099_MISC_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_1099_MISC_Adjustment_RequestType Submit_1099_MISC_Adjustment_Request)
		{
			return ((Financial_ManagementPort)this).Submit_1099_MISC_AdjustmentAsync(new Submit_1099_MISC_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_1099_MISC_Adjustment_Request = Submit_1099_MISC_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Basic_GrantsOutput Financial_ManagementPort.Get_Basic_Grants(Get_Basic_GrantsInput request)
		{
			return base.Channel.Get_Basic_Grants(request);
		}

		public Get_Basic_Grants_ResponseType Get_Basic_Grants(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Grants_RequestType Get_Basic_Grants_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Grants(new Get_Basic_GrantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Grants_Request = Get_Basic_Grants_Request
			}).Get_Basic_Grants_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Basic_GrantsOutput> Financial_ManagementPort.Get_Basic_GrantsAsync(Get_Basic_GrantsInput request)
		{
			return base.Channel.Get_Basic_GrantsAsync(request);
		}

		public Task<Get_Basic_GrantsOutput> Get_Basic_GrantsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Grants_RequestType Get_Basic_Grants_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_GrantsAsync(new Get_Basic_GrantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Grants_Request = Get_Basic_Grants_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Basic_GrantOutput Financial_ManagementPort.Put_Basic_Grant(Put_Basic_GrantInput request)
		{
			return base.Channel.Put_Basic_Grant(request);
		}

		public Put_Basic_Grant_ResponseType Put_Basic_Grant(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Grant_RequestType Put_Basic_Grant_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Grant(new Put_Basic_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Grant_Request = Put_Basic_Grant_Request
			}).Put_Basic_Grant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Basic_GrantOutput> Financial_ManagementPort.Put_Basic_GrantAsync(Put_Basic_GrantInput request)
		{
			return base.Channel.Put_Basic_GrantAsync(request);
		}

		public Task<Put_Basic_GrantOutput> Put_Basic_GrantAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Grant_RequestType Put_Basic_Grant_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_GrantAsync(new Put_Basic_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Grant_Request = Put_Basic_Grant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Award_Personnel_ResponsibilitiesOutput Financial_ManagementPort.Get_Award_Personnel_Responsibilities(Get_Award_Personnel_ResponsibilitiesInput request)
		{
			return base.Channel.Get_Award_Personnel_Responsibilities(request);
		}

		public Get_Award_Personnel_Responsibilities_ResponseType Get_Award_Personnel_Responsibilities(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Personnel_Responsibilities_RequestType Get_Award_Personnel_Responsibilities_Request)
		{
			return ((Financial_ManagementPort)this).Get_Award_Personnel_Responsibilities(new Get_Award_Personnel_ResponsibilitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Personnel_Responsibilities_Request = Get_Award_Personnel_Responsibilities_Request
			}).Get_Award_Personnel_Responsibilities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Award_Personnel_ResponsibilitiesOutput> Financial_ManagementPort.Get_Award_Personnel_ResponsibilitiesAsync(Get_Award_Personnel_ResponsibilitiesInput request)
		{
			return base.Channel.Get_Award_Personnel_ResponsibilitiesAsync(request);
		}

		public Task<Get_Award_Personnel_ResponsibilitiesOutput> Get_Award_Personnel_ResponsibilitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Personnel_Responsibilities_RequestType Get_Award_Personnel_Responsibilities_Request)
		{
			return ((Financial_ManagementPort)this).Get_Award_Personnel_ResponsibilitiesAsync(new Get_Award_Personnel_ResponsibilitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Award_Personnel_Responsibilities_Request = Get_Award_Personnel_Responsibilities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Award_Personnel_ResponsibilityOutput Financial_ManagementPort.Put_Award_Personnel_Responsibility(Put_Award_Personnel_ResponsibilityInput request)
		{
			return base.Channel.Put_Award_Personnel_Responsibility(request);
		}

		public Put_Award_Personnel_Responsibility_ResponseType Put_Award_Personnel_Responsibility(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Personnel_Responsibility_RequestType Put_Award_Personnel_Responsibility_Request)
		{
			return ((Financial_ManagementPort)this).Put_Award_Personnel_Responsibility(new Put_Award_Personnel_ResponsibilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Personnel_Responsibility_Request = Put_Award_Personnel_Responsibility_Request
			}).Put_Award_Personnel_Responsibility_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Award_Personnel_ResponsibilityOutput> Financial_ManagementPort.Put_Award_Personnel_ResponsibilityAsync(Put_Award_Personnel_ResponsibilityInput request)
		{
			return base.Channel.Put_Award_Personnel_ResponsibilityAsync(request);
		}

		public Task<Put_Award_Personnel_ResponsibilityOutput> Put_Award_Personnel_ResponsibilityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Award_Personnel_Responsibility_RequestType Put_Award_Personnel_Responsibility_Request)
		{
			return ((Financial_ManagementPort)this).Put_Award_Personnel_ResponsibilityAsync(new Put_Award_Personnel_ResponsibilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Award_Personnel_Responsibility_Request = Put_Award_Personnel_Responsibility_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Proposal_GrantsOutput Financial_ManagementPort.Get_Proposal_Grants(Get_Proposal_GrantsInput request)
		{
			return base.Channel.Get_Proposal_Grants(request);
		}

		public Get_Proposal_Grants_ResponseType Get_Proposal_Grants(Workday_Common_HeaderType Workday_Common_Header, Get_Proposal_Grants_RequestType Get_Proposal_Grants_Request)
		{
			return ((Financial_ManagementPort)this).Get_Proposal_Grants(new Get_Proposal_GrantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Proposal_Grants_Request = Get_Proposal_Grants_Request
			}).Get_Proposal_Grants_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Proposal_GrantsOutput> Financial_ManagementPort.Get_Proposal_GrantsAsync(Get_Proposal_GrantsInput request)
		{
			return base.Channel.Get_Proposal_GrantsAsync(request);
		}

		public Task<Get_Proposal_GrantsOutput> Get_Proposal_GrantsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Proposal_Grants_RequestType Get_Proposal_Grants_Request)
		{
			return ((Financial_ManagementPort)this).Get_Proposal_GrantsAsync(new Get_Proposal_GrantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Proposal_Grants_Request = Get_Proposal_Grants_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Proposal_GrantOutput Financial_ManagementPort.Put_Proposal_Grant(Put_Proposal_GrantInput request)
		{
			return base.Channel.Put_Proposal_Grant(request);
		}

		public Put_Proposal_Grant_ResponseType Put_Proposal_Grant(Workday_Common_HeaderType Workday_Common_Header, Put_Proposal_Grant_RequestType Put_Proposal_Grant_Request)
		{
			return ((Financial_ManagementPort)this).Put_Proposal_Grant(new Put_Proposal_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Proposal_Grant_Request = Put_Proposal_Grant_Request
			}).Put_Proposal_Grant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Proposal_GrantOutput> Financial_ManagementPort.Put_Proposal_GrantAsync(Put_Proposal_GrantInput request)
		{
			return base.Channel.Put_Proposal_GrantAsync(request);
		}

		public Task<Put_Proposal_GrantOutput> Put_Proposal_GrantAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Proposal_Grant_RequestType Put_Proposal_Grant_Request)
		{
			return ((Financial_ManagementPort)this).Put_Proposal_GrantAsync(new Put_Proposal_GrantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Proposal_Grant_Request = Put_Proposal_Grant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_GiftsOutput Financial_ManagementPort.Get_Gifts(Get_GiftsInput request)
		{
			return base.Channel.Get_Gifts(request);
		}

		public Get_Gifts_ResponseType Get_Gifts(Workday_Common_HeaderType Workday_Common_Header, Get_Gifts_RequestType Get_Gifts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Gifts(new Get_GiftsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Gifts_Request = Get_Gifts_Request
			}).Get_Gifts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_GiftsOutput> Financial_ManagementPort.Get_GiftsAsync(Get_GiftsInput request)
		{
			return base.Channel.Get_GiftsAsync(request);
		}

		public Task<Get_GiftsOutput> Get_GiftsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Gifts_RequestType Get_Gifts_Request)
		{
			return ((Financial_ManagementPort)this).Get_GiftsAsync(new Get_GiftsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Gifts_Request = Get_Gifts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_GiftOutput Financial_ManagementPort.Submit_Gift(Submit_GiftInput request)
		{
			return base.Channel.Submit_Gift(request);
		}

		public Submit_Gift_ResponseType Submit_Gift(Workday_Common_HeaderType Workday_Common_Header, Submit_Gift_RequestType Submit_Gift_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Gift(new Submit_GiftInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Gift_Request = Submit_Gift_Request
			}).Submit_Gift_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_GiftOutput> Financial_ManagementPort.Submit_GiftAsync(Submit_GiftInput request)
		{
			return base.Channel.Submit_GiftAsync(request);
		}

		public Task<Submit_GiftOutput> Submit_GiftAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Gift_RequestType Submit_Gift_Request)
		{
			return ((Financial_ManagementPort)this).Submit_GiftAsync(new Submit_GiftInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Gift_Request = Submit_Gift_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Beginning_Balance_Translation_AmountsOutput Financial_ManagementPort.Put_Beginning_Balance_Translation_Amounts(Put_Beginning_Balance_Translation_AmountsInput request)
		{
			return base.Channel.Put_Beginning_Balance_Translation_Amounts(request);
		}

		public Put_Beginning_Balance_Translation_Amounts_ResponseType Put_Beginning_Balance_Translation_Amounts(Workday_Common_HeaderType Workday_Common_Header, Put_Beginning_Balance_Translation_Amounts_RequestType Put_Beginning_Balance_Translation_Amounts_Request)
		{
			return ((Financial_ManagementPort)this).Put_Beginning_Balance_Translation_Amounts(new Put_Beginning_Balance_Translation_AmountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Beginning_Balance_Translation_Amounts_Request = Put_Beginning_Balance_Translation_Amounts_Request
			}).Put_Beginning_Balance_Translation_Amounts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Beginning_Balance_Translation_AmountsOutput> Financial_ManagementPort.Put_Beginning_Balance_Translation_AmountsAsync(Put_Beginning_Balance_Translation_AmountsInput request)
		{
			return base.Channel.Put_Beginning_Balance_Translation_AmountsAsync(request);
		}

		public Task<Put_Beginning_Balance_Translation_AmountsOutput> Put_Beginning_Balance_Translation_AmountsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Beginning_Balance_Translation_Amounts_RequestType Put_Beginning_Balance_Translation_Amounts_Request)
		{
			return ((Financial_ManagementPort)this).Put_Beginning_Balance_Translation_AmountsAsync(new Put_Beginning_Balance_Translation_AmountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Beginning_Balance_Translation_Amounts_Request = Put_Beginning_Balance_Translation_Amounts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Beginning_Balance_Translation_AmountsOutput Financial_ManagementPort.Get_Beginning_Balance_Translation_Amounts(Get_Beginning_Balance_Translation_AmountsInput request)
		{
			return base.Channel.Get_Beginning_Balance_Translation_Amounts(request);
		}

		public Get_Beginning_Balance_Translation_Amounts_ResponseType Get_Beginning_Balance_Translation_Amounts(Workday_Common_HeaderType Workday_Common_Header, Get_Beginning_Balance_Translation_Amounts_RequestType Get_Beginning_Balance_Translation_Amounts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Beginning_Balance_Translation_Amounts(new Get_Beginning_Balance_Translation_AmountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Beginning_Balance_Translation_Amounts_Request = Get_Beginning_Balance_Translation_Amounts_Request
			}).Get_Beginning_Balance_Translation_Amounts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Beginning_Balance_Translation_AmountsOutput> Financial_ManagementPort.Get_Beginning_Balance_Translation_AmountsAsync(Get_Beginning_Balance_Translation_AmountsInput request)
		{
			return base.Channel.Get_Beginning_Balance_Translation_AmountsAsync(request);
		}

		public Task<Get_Beginning_Balance_Translation_AmountsOutput> Get_Beginning_Balance_Translation_AmountsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Beginning_Balance_Translation_Amounts_RequestType Get_Beginning_Balance_Translation_Amounts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Beginning_Balance_Translation_AmountsAsync(new Get_Beginning_Balance_Translation_AmountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Beginning_Balance_Translation_Amounts_Request = Get_Beginning_Balance_Translation_Amounts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Revenue_Category_HierarchiesOutput Financial_ManagementPort.Get_Revenue_Category_Hierarchies(Get_Revenue_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Revenue_Category_Hierarchies(request);
		}

		public Get_Revenue_Category_Hierarchies_ResponseType Get_Revenue_Category_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Category_Hierarchies_RequestType Get_Revenue_Category_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Revenue_Category_Hierarchies(new Get_Revenue_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Category_Hierarchies_Request = Get_Revenue_Category_Hierarchies_Request
			}).Get_Revenue_Category_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Revenue_Category_HierarchiesOutput> Financial_ManagementPort.Get_Revenue_Category_HierarchiesAsync(Get_Revenue_Category_HierarchiesInput request)
		{
			return base.Channel.Get_Revenue_Category_HierarchiesAsync(request);
		}

		public Task<Get_Revenue_Category_HierarchiesOutput> Get_Revenue_Category_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Revenue_Category_Hierarchies_RequestType Get_Revenue_Category_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Revenue_Category_HierarchiesAsync(new Get_Revenue_Category_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Revenue_Category_Hierarchies_Request = Get_Revenue_Category_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Revenue_Category_HierarchyOutput Financial_ManagementPort.Put_Revenue_Category_Hierarchy(Put_Revenue_Category_HierarchyInput request)
		{
			return base.Channel.Put_Revenue_Category_Hierarchy(request);
		}

		public Put_Revenue_Category_Hierarchy_ResponseType Put_Revenue_Category_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_Hierarchy_RequestType Put_Revenue_Category_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Revenue_Category_Hierarchy(new Put_Revenue_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Hierarchy_Request = Put_Revenue_Category_Hierarchy_Request
			}).Put_Revenue_Category_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Revenue_Category_HierarchyOutput> Financial_ManagementPort.Put_Revenue_Category_HierarchyAsync(Put_Revenue_Category_HierarchyInput request)
		{
			return base.Channel.Put_Revenue_Category_HierarchyAsync(request);
		}

		public Task<Put_Revenue_Category_HierarchyOutput> Put_Revenue_Category_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Revenue_Category_Hierarchy_RequestType Put_Revenue_Category_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Revenue_Category_HierarchyAsync(new Put_Revenue_Category_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Revenue_Category_Hierarchy_Request = Put_Revenue_Category_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Gift_HierarchiesOutput Financial_ManagementPort.Get_Gift_Hierarchies(Get_Gift_HierarchiesInput request)
		{
			return base.Channel.Get_Gift_Hierarchies(request);
		}

		public Get_Gift_Hierarchies_ResponseType Get_Gift_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Gift_Hierarchies_RequestType Get_Gift_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Gift_Hierarchies(new Get_Gift_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Gift_Hierarchies_Request = Get_Gift_Hierarchies_Request
			}).Get_Gift_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Gift_HierarchiesOutput> Financial_ManagementPort.Get_Gift_HierarchiesAsync(Get_Gift_HierarchiesInput request)
		{
			return base.Channel.Get_Gift_HierarchiesAsync(request);
		}

		public Task<Get_Gift_HierarchiesOutput> Get_Gift_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Gift_Hierarchies_RequestType Get_Gift_Hierarchies_Request)
		{
			return ((Financial_ManagementPort)this).Get_Gift_HierarchiesAsync(new Get_Gift_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Gift_Hierarchies_Request = Get_Gift_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Gift_HierarchyOutput Financial_ManagementPort.Put_Gift_Hierarchy(Put_Gift_HierarchyInput request)
		{
			return base.Channel.Put_Gift_Hierarchy(request);
		}

		public Put_Gift_Hierarchy_ResponseType Put_Gift_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Gift_Hierarchy_RequestType Put_Gift_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Gift_Hierarchy(new Put_Gift_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Gift_Hierarchy_Request = Put_Gift_Hierarchy_Request
			}).Put_Gift_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Gift_HierarchyOutput> Financial_ManagementPort.Put_Gift_HierarchyAsync(Put_Gift_HierarchyInput request)
		{
			return base.Channel.Put_Gift_HierarchyAsync(request);
		}

		public Task<Put_Gift_HierarchyOutput> Put_Gift_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Gift_Hierarchy_RequestType Put_Gift_Hierarchy_Request)
		{
			return ((Financial_ManagementPort)this).Put_Gift_HierarchyAsync(new Put_Gift_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Gift_Hierarchy_Request = Put_Gift_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Contingent_Worker_Tax_Authority_Form_TypeOutput Financial_ManagementPort.Put_Contingent_Worker_Tax_Authority_Form_Type(Put_Contingent_Worker_Tax_Authority_Form_TypeInput request)
		{
			return base.Channel.Put_Contingent_Worker_Tax_Authority_Form_Type(request);
		}

		public Put_Contingent_Worker_Tax_Authority_Form_Type_ResponseType Put_Contingent_Worker_Tax_Authority_Form_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Contingent_Worker_Tax_Authority_Form_Type_RequestType Put_Contingent_Worker_Tax_Authority_Form_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Contingent_Worker_Tax_Authority_Form_Type(new Put_Contingent_Worker_Tax_Authority_Form_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contingent_Worker_Tax_Authority_Form_Type_Request = Put_Contingent_Worker_Tax_Authority_Form_Type_Request
			}).Put_Contingent_Worker_Tax_Authority_Form_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Contingent_Worker_Tax_Authority_Form_TypeOutput> Financial_ManagementPort.Put_Contingent_Worker_Tax_Authority_Form_TypeAsync(Put_Contingent_Worker_Tax_Authority_Form_TypeInput request)
		{
			return base.Channel.Put_Contingent_Worker_Tax_Authority_Form_TypeAsync(request);
		}

		public Task<Put_Contingent_Worker_Tax_Authority_Form_TypeOutput> Put_Contingent_Worker_Tax_Authority_Form_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Contingent_Worker_Tax_Authority_Form_Type_RequestType Put_Contingent_Worker_Tax_Authority_Form_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Contingent_Worker_Tax_Authority_Form_TypeAsync(new Put_Contingent_Worker_Tax_Authority_Form_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contingent_Worker_Tax_Authority_Form_Type_Request = Put_Contingent_Worker_Tax_Authority_Form_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_1042S_Income_CodesOutput Financial_ManagementPort.Get_1042S_Income_Codes(Get_1042S_Income_CodesInput request)
		{
			return base.Channel.Get_1042S_Income_Codes(request);
		}

		public Get_1042S_Income_Codes_ResponseType Get_1042S_Income_Codes(Workday_Common_HeaderType Workday_Common_Header, Get_1042S_Income_Codes_RequestType Get_1042S_Income_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_1042S_Income_Codes(new Get_1042S_Income_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1042S_Income_Codes_Request = Get_1042S_Income_Codes_Request
			}).Get_1042S_Income_Codes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_1042S_Income_CodesOutput> Financial_ManagementPort.Get_1042S_Income_CodesAsync(Get_1042S_Income_CodesInput request)
		{
			return base.Channel.Get_1042S_Income_CodesAsync(request);
		}

		public Task<Get_1042S_Income_CodesOutput> Get_1042S_Income_CodesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_1042S_Income_Codes_RequestType Get_1042S_Income_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_1042S_Income_CodesAsync(new Get_1042S_Income_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_1042S_Income_Codes_Request = Get_1042S_Income_Codes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Basic_GiftsOutput Financial_ManagementPort.Get_Basic_Gifts(Get_Basic_GiftsInput request)
		{
			return base.Channel.Get_Basic_Gifts(request);
		}

		public Get_Basic_Gifts_ResponseType Get_Basic_Gifts(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Gifts_RequestType Get_Basic_Gifts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_Gifts(new Get_Basic_GiftsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Gifts_Request = Get_Basic_Gifts_Request
			}).Get_Basic_Gifts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Basic_GiftsOutput> Financial_ManagementPort.Get_Basic_GiftsAsync(Get_Basic_GiftsInput request)
		{
			return base.Channel.Get_Basic_GiftsAsync(request);
		}

		public Task<Get_Basic_GiftsOutput> Get_Basic_GiftsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Gifts_RequestType Get_Basic_Gifts_Request)
		{
			return ((Financial_ManagementPort)this).Get_Basic_GiftsAsync(new Get_Basic_GiftsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Basic_Gifts_Request = Get_Basic_Gifts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Basic_GiftOutput Financial_ManagementPort.Put_Basic_Gift(Put_Basic_GiftInput request)
		{
			return base.Channel.Put_Basic_Gift(request);
		}

		public Put_Basic_Gift_ResponseType Put_Basic_Gift(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Gift_RequestType Put_Basic_Gift_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_Gift(new Put_Basic_GiftInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Gift_Request = Put_Basic_Gift_Request
			}).Put_Basic_Gift_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Basic_GiftOutput> Financial_ManagementPort.Put_Basic_GiftAsync(Put_Basic_GiftInput request)
		{
			return base.Channel.Put_Basic_GiftAsync(request);
		}

		public Task<Put_Basic_GiftOutput> Put_Basic_GiftAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Gift_RequestType Put_Basic_Gift_Request)
		{
			return ((Financial_ManagementPort)this).Put_Basic_GiftAsync(new Put_Basic_GiftInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Basic_Gift_Request = Put_Basic_Gift_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_1042S_Income_CodeOutput Financial_ManagementPort.Put_1042S_Income_Code(Put_1042S_Income_CodeInput request)
		{
			return base.Channel.Put_1042S_Income_Code(request);
		}

		public Put_1042S_Income_Code_ResponseType Put_1042S_Income_Code(Workday_Common_HeaderType Workday_Common_Header, Put_1042S_Income_Code_RequestType Put_1042S_Income_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_1042S_Income_Code(new Put_1042S_Income_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_1042S_Income_Code_Request = Put_1042S_Income_Code_Request
			}).Put_1042S_Income_Code_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_1042S_Income_CodeOutput> Financial_ManagementPort.Put_1042S_Income_CodeAsync(Put_1042S_Income_CodeInput request)
		{
			return base.Channel.Put_1042S_Income_CodeAsync(request);
		}

		public Task<Put_1042S_Income_CodeOutput> Put_1042S_Income_CodeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_1042S_Income_Code_RequestType Put_1042S_Income_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_1042S_Income_CodeAsync(new Put_1042S_Income_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_1042S_Income_Code_Request = Put_1042S_Income_Code_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_LoansOutput Financial_ManagementPort.Get_Loans(Get_LoansInput request)
		{
			return base.Channel.Get_Loans(request);
		}

		public Get_Loans_ResponseType Get_Loans(Workday_Common_HeaderType Workday_Common_Header, Get_Loans_RequestType Get_Loans_Request)
		{
			return ((Financial_ManagementPort)this).Get_Loans(new Get_LoansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Loans_Request = Get_Loans_Request
			}).Get_Loans_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_LoansOutput> Financial_ManagementPort.Get_LoansAsync(Get_LoansInput request)
		{
			return base.Channel.Get_LoansAsync(request);
		}

		public Task<Get_LoansOutput> Get_LoansAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Loans_RequestType Get_Loans_Request)
		{
			return ((Financial_ManagementPort)this).Get_LoansAsync(new Get_LoansInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Loans_Request = Get_Loans_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_LoanOutput Financial_ManagementPort.Put_Loan(Put_LoanInput request)
		{
			return base.Channel.Put_Loan(request);
		}

		public Put_Loan_ResponseType Put_Loan(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_RequestType Put_Loan_Request)
		{
			return ((Financial_ManagementPort)this).Put_Loan(new Put_LoanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Loan_Request = Put_Loan_Request
			}).Put_Loan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_LoanOutput> Financial_ManagementPort.Put_LoanAsync(Put_LoanInput request)
		{
			return base.Channel.Put_LoanAsync(request);
		}

		public Task<Put_LoanOutput> Put_LoanAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_RequestType Put_Loan_Request)
		{
			return ((Financial_ManagementPort)this).Put_LoanAsync(new Put_LoanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Loan_Request = Put_Loan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Loan_Investor_TypesOutput Financial_ManagementPort.Get_Loan_Investor_Types(Get_Loan_Investor_TypesInput request)
		{
			return base.Channel.Get_Loan_Investor_Types(request);
		}

		public Get_Loan_Investor_Types_ResponseType Get_Loan_Investor_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Loan_Investor_Types_RequestType Get_Loan_Investor_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Loan_Investor_Types(new Get_Loan_Investor_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Loan_Investor_Types_Request = Get_Loan_Investor_Types_Request
			}).Get_Loan_Investor_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Loan_Investor_TypesOutput> Financial_ManagementPort.Get_Loan_Investor_TypesAsync(Get_Loan_Investor_TypesInput request)
		{
			return base.Channel.Get_Loan_Investor_TypesAsync(request);
		}

		public Task<Get_Loan_Investor_TypesOutput> Get_Loan_Investor_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Loan_Investor_Types_RequestType Get_Loan_Investor_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Loan_Investor_TypesAsync(new Get_Loan_Investor_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Loan_Investor_Types_Request = Get_Loan_Investor_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Loan_Referral_TypesOutput Financial_ManagementPort.Get_Loan_Referral_Types(Get_Loan_Referral_TypesInput request)
		{
			return base.Channel.Get_Loan_Referral_Types(request);
		}

		public Get_Loan_Referral_Types_ResponseType Get_Loan_Referral_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Loan_Referral_Types_RequestType Get_Loan_Referral_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Loan_Referral_Types(new Get_Loan_Referral_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Loan_Referral_Types_Request = Get_Loan_Referral_Types_Request
			}).Get_Loan_Referral_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Loan_Referral_TypesOutput> Financial_ManagementPort.Get_Loan_Referral_TypesAsync(Get_Loan_Referral_TypesInput request)
		{
			return base.Channel.Get_Loan_Referral_TypesAsync(request);
		}

		public Task<Get_Loan_Referral_TypesOutput> Get_Loan_Referral_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Loan_Referral_Types_RequestType Get_Loan_Referral_Types_Request)
		{
			return ((Financial_ManagementPort)this).Get_Loan_Referral_TypesAsync(new Get_Loan_Referral_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Loan_Referral_Types_Request = Get_Loan_Referral_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Loan_Investor_TypeOutput Financial_ManagementPort.Put_Loan_Investor_Type(Put_Loan_Investor_TypeInput request)
		{
			return base.Channel.Put_Loan_Investor_Type(request);
		}

		public Put_Loan_Investor_Type_ResponseType Put_Loan_Investor_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_Investor_Type_RequestType Put_Loan_Investor_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Loan_Investor_Type(new Put_Loan_Investor_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Loan_Investor_Type_Request = Put_Loan_Investor_Type_Request
			}).Put_Loan_Investor_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Loan_Investor_TypeOutput> Financial_ManagementPort.Put_Loan_Investor_TypeAsync(Put_Loan_Investor_TypeInput request)
		{
			return base.Channel.Put_Loan_Investor_TypeAsync(request);
		}

		public Task<Put_Loan_Investor_TypeOutput> Put_Loan_Investor_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_Investor_Type_RequestType Put_Loan_Investor_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Loan_Investor_TypeAsync(new Put_Loan_Investor_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Loan_Investor_Type_Request = Put_Loan_Investor_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Loan_Referral_TypeOutput Financial_ManagementPort.Put_Loan_Referral_Type(Put_Loan_Referral_TypeInput request)
		{
			return base.Channel.Put_Loan_Referral_Type(request);
		}

		public Put_Loan_Referral_Type_ResponseType Put_Loan_Referral_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_Referral_Type_RequestType Put_Loan_Referral_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Loan_Referral_Type(new Put_Loan_Referral_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Loan_Referral_Type_Request = Put_Loan_Referral_Type_Request
			}).Put_Loan_Referral_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Loan_Referral_TypeOutput> Financial_ManagementPort.Put_Loan_Referral_TypeAsync(Put_Loan_Referral_TypeInput request)
		{
			return base.Channel.Put_Loan_Referral_TypeAsync(request);
		}

		public Task<Put_Loan_Referral_TypeOutput> Put_Loan_Referral_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Loan_Referral_Type_RequestType Put_Loan_Referral_Type_Request)
		{
			return ((Financial_ManagementPort)this).Put_Loan_Referral_TypeAsync(new Put_Loan_Referral_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Loan_Referral_Type_Request = Put_Loan_Referral_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Alternate_Account_Set_MappingOutput Financial_ManagementPort.Put_Alternate_Account_Set_Mapping(Put_Alternate_Account_Set_MappingInput request)
		{
			return base.Channel.Put_Alternate_Account_Set_Mapping(request);
		}

		public Put_Alternate_Account_Set_Mapping_ResponseType Put_Alternate_Account_Set_Mapping(Workday_Common_HeaderType Workday_Common_Header, Put_Alternate_Account_Set_Mapping_RequestType Put_Alternate_Account_Set_Mapping_Request)
		{
			return ((Financial_ManagementPort)this).Put_Alternate_Account_Set_Mapping(new Put_Alternate_Account_Set_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Alternate_Account_Set_Mapping_Request = Put_Alternate_Account_Set_Mapping_Request
			}).Put_Alternate_Account_Set_Mapping_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Alternate_Account_Set_MappingOutput> Financial_ManagementPort.Put_Alternate_Account_Set_MappingAsync(Put_Alternate_Account_Set_MappingInput request)
		{
			return base.Channel.Put_Alternate_Account_Set_MappingAsync(request);
		}

		public Task<Put_Alternate_Account_Set_MappingOutput> Put_Alternate_Account_Set_MappingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Alternate_Account_Set_Mapping_RequestType Put_Alternate_Account_Set_Mapping_Request)
		{
			return ((Financial_ManagementPort)this).Put_Alternate_Account_Set_MappingAsync(new Put_Alternate_Account_Set_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Alternate_Account_Set_Mapping_Request = Put_Alternate_Account_Set_Mapping_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Alternate_Account_Set_MappingsOutput Financial_ManagementPort.Get_Alternate_Account_Set_Mappings(Get_Alternate_Account_Set_MappingsInput request)
		{
			return base.Channel.Get_Alternate_Account_Set_Mappings(request);
		}

		public Get_Alternate_Account_Set_Mappings_ResponseType Get_Alternate_Account_Set_Mappings(Workday_Common_HeaderType Workday_Common_Header, Get_Alternate_Account_Set_Mappings_RequestType Get_Alternate_Account_Set_Mappings_Request)
		{
			return ((Financial_ManagementPort)this).Get_Alternate_Account_Set_Mappings(new Get_Alternate_Account_Set_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Alternate_Account_Set_Mappings_Request = Get_Alternate_Account_Set_Mappings_Request
			}).Get_Alternate_Account_Set_Mappings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Alternate_Account_Set_MappingsOutput> Financial_ManagementPort.Get_Alternate_Account_Set_MappingsAsync(Get_Alternate_Account_Set_MappingsInput request)
		{
			return base.Channel.Get_Alternate_Account_Set_MappingsAsync(request);
		}

		public Task<Get_Alternate_Account_Set_MappingsOutput> Get_Alternate_Account_Set_MappingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Alternate_Account_Set_Mappings_RequestType Get_Alternate_Account_Set_Mappings_Request)
		{
			return ((Financial_ManagementPort)this).Get_Alternate_Account_Set_MappingsAsync(new Get_Alternate_Account_Set_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Alternate_Account_Set_Mappings_Request = Get_Alternate_Account_Set_Mappings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Third_Party_Calculated_Tax_InformationOutput Financial_ManagementPort.Put_Third_Party_Calculated_Tax_Information(Put_Third_Party_Calculated_Tax_InformationInput request)
		{
			return base.Channel.Put_Third_Party_Calculated_Tax_Information(request);
		}

		public Put_Third_Party_Calculated_Tax_Information_ResponseType Put_Third_Party_Calculated_Tax_Information(Workday_Common_HeaderType Workday_Common_Header, Put_Third_Party_Calculated_Tax_Information_RequestType Put_Third_Party_Calculated_Tax_Information_Request)
		{
			return ((Financial_ManagementPort)this).Put_Third_Party_Calculated_Tax_Information(new Put_Third_Party_Calculated_Tax_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Third_Party_Calculated_Tax_Information_Request = Put_Third_Party_Calculated_Tax_Information_Request
			}).Put_Third_Party_Calculated_Tax_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Third_Party_Calculated_Tax_InformationOutput> Financial_ManagementPort.Put_Third_Party_Calculated_Tax_InformationAsync(Put_Third_Party_Calculated_Tax_InformationInput request)
		{
			return base.Channel.Put_Third_Party_Calculated_Tax_InformationAsync(request);
		}

		public Task<Put_Third_Party_Calculated_Tax_InformationOutput> Put_Third_Party_Calculated_Tax_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Third_Party_Calculated_Tax_Information_RequestType Put_Third_Party_Calculated_Tax_Information_Request)
		{
			return ((Financial_ManagementPort)this).Put_Third_Party_Calculated_Tax_InformationAsync(new Put_Third_Party_Calculated_Tax_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Third_Party_Calculated_Tax_Information_Request = Put_Third_Party_Calculated_Tax_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Fringe_Rate_TableOutput Financial_ManagementPort.Put_Fringe_Rate_Table(Put_Fringe_Rate_TableInput request)
		{
			return base.Channel.Put_Fringe_Rate_Table(request);
		}

		public Put_Fringe_Rate_Table_ResponseType Put_Fringe_Rate_Table(Workday_Common_HeaderType Workday_Common_Header, Put_Fringe_Rate_Table_RequestType Put_Fringe_Rate_Table_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fringe_Rate_Table(new Put_Fringe_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fringe_Rate_Table_Request = Put_Fringe_Rate_Table_Request
			}).Put_Fringe_Rate_Table_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Fringe_Rate_TableOutput> Financial_ManagementPort.Put_Fringe_Rate_TableAsync(Put_Fringe_Rate_TableInput request)
		{
			return base.Channel.Put_Fringe_Rate_TableAsync(request);
		}

		public Task<Put_Fringe_Rate_TableOutput> Put_Fringe_Rate_TableAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Fringe_Rate_Table_RequestType Put_Fringe_Rate_Table_Request)
		{
			return ((Financial_ManagementPort)this).Put_Fringe_Rate_TableAsync(new Put_Fringe_Rate_TableInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Fringe_Rate_Table_Request = Put_Fringe_Rate_Table_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Budget_Fringe_Rate_TablesOutput Financial_ManagementPort.Get_Budget_Fringe_Rate_Tables(Get_Budget_Fringe_Rate_TablesInput request)
		{
			return base.Channel.Get_Budget_Fringe_Rate_Tables(request);
		}

		public Get_Budget_Fringe_Rate_Tables_ResponseType Get_Budget_Fringe_Rate_Tables(Workday_Common_HeaderType Workday_Common_Header, Get_Budget_Fringe_Rate_Tables_RequestType Get_Budget_Fringe_Rate_Tables_Request)
		{
			return ((Financial_ManagementPort)this).Get_Budget_Fringe_Rate_Tables(new Get_Budget_Fringe_Rate_TablesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Budget_Fringe_Rate_Tables_Request = Get_Budget_Fringe_Rate_Tables_Request
			}).Get_Budget_Fringe_Rate_Tables_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Budget_Fringe_Rate_TablesOutput> Financial_ManagementPort.Get_Budget_Fringe_Rate_TablesAsync(Get_Budget_Fringe_Rate_TablesInput request)
		{
			return base.Channel.Get_Budget_Fringe_Rate_TablesAsync(request);
		}

		public Task<Get_Budget_Fringe_Rate_TablesOutput> Get_Budget_Fringe_Rate_TablesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Budget_Fringe_Rate_Tables_RequestType Get_Budget_Fringe_Rate_Tables_Request)
		{
			return ((Financial_ManagementPort)this).Get_Budget_Fringe_Rate_TablesAsync(new Get_Budget_Fringe_Rate_TablesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Budget_Fringe_Rate_Tables_Request = Get_Budget_Fringe_Rate_Tables_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Escheatment_ItemsOutput Financial_ManagementPort.Get_Escheatment_Items(Get_Escheatment_ItemsInput request)
		{
			return base.Channel.Get_Escheatment_Items(request);
		}

		public Get_Escheatment_Items_ResponseType Get_Escheatment_Items(Workday_Common_HeaderType Workday_Common_Header, Get_Escheatment_Items_RequestType Get_Escheatment_Items_Request)
		{
			return ((Financial_ManagementPort)this).Get_Escheatment_Items(new Get_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Escheatment_Items_Request = Get_Escheatment_Items_Request
			}).Get_Escheatment_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Escheatment_ItemsOutput> Financial_ManagementPort.Get_Escheatment_ItemsAsync(Get_Escheatment_ItemsInput request)
		{
			return base.Channel.Get_Escheatment_ItemsAsync(request);
		}

		public Task<Get_Escheatment_ItemsOutput> Get_Escheatment_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Escheatment_Items_RequestType Get_Escheatment_Items_Request)
		{
			return ((Financial_ManagementPort)this).Get_Escheatment_ItemsAsync(new Get_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Escheatment_Items_Request = Get_Escheatment_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Escheatment_ItemsOutput Financial_ManagementPort.Submit_Escheatment_Items(Submit_Escheatment_ItemsInput request)
		{
			return base.Channel.Submit_Escheatment_Items(request);
		}

		public Submit_Escheatment_Items_ResponseType Submit_Escheatment_Items(Workday_Common_HeaderType Workday_Common_Header, Submit_Escheatment_Items_RequestType Submit_Escheatment_Items_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Escheatment_Items(new Submit_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Escheatment_Items_Request = Submit_Escheatment_Items_Request
			}).Submit_Escheatment_Items_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Escheatment_ItemsOutput> Financial_ManagementPort.Submit_Escheatment_ItemsAsync(Submit_Escheatment_ItemsInput request)
		{
			return base.Channel.Submit_Escheatment_ItemsAsync(request);
		}

		public Task<Submit_Escheatment_ItemsOutput> Submit_Escheatment_ItemsAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Escheatment_Items_RequestType Submit_Escheatment_Items_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Escheatment_ItemsAsync(new Submit_Escheatment_ItemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Escheatment_Items_Request = Submit_Escheatment_Items_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Gift_Secured_AttachmentOutput Financial_ManagementPort.Put_Gift_Secured_Attachment(Put_Gift_Secured_AttachmentInput request)
		{
			return base.Channel.Put_Gift_Secured_Attachment(request);
		}

		public Put_Gift_Secured_Attachment_ResponseType Put_Gift_Secured_Attachment(Workday_Common_HeaderType Workday_Common_Header, Put_Gift_Secured_Attachment_RequestType Put_Gift_Secured_Attachment_Request)
		{
			return ((Financial_ManagementPort)this).Put_Gift_Secured_Attachment(new Put_Gift_Secured_AttachmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Gift_Secured_Attachment_Request = Put_Gift_Secured_Attachment_Request
			}).Put_Gift_Secured_Attachment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Gift_Secured_AttachmentOutput> Financial_ManagementPort.Put_Gift_Secured_AttachmentAsync(Put_Gift_Secured_AttachmentInput request)
		{
			return base.Channel.Put_Gift_Secured_AttachmentAsync(request);
		}

		public Task<Put_Gift_Secured_AttachmentOutput> Put_Gift_Secured_AttachmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Gift_Secured_Attachment_RequestType Put_Gift_Secured_Attachment_Request)
		{
			return ((Financial_ManagementPort)this).Put_Gift_Secured_AttachmentAsync(new Put_Gift_Secured_AttachmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Gift_Secured_Attachment_Request = Put_Gift_Secured_Attachment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Related_Worktags_for_WorktagsOutput Financial_ManagementPort.Get_Related_Worktags_for_Worktags(Get_Related_Worktags_for_WorktagsInput request)
		{
			return base.Channel.Get_Related_Worktags_for_Worktags(request);
		}

		public Get_Related_Worktags_for_Worktags_ResponseType Get_Related_Worktags_for_Worktags(Workday_Common_HeaderType Workday_Common_Header, Get_Related_Worktags_for_Worktags_RequestType Get_Related_Worktags_for_Worktags_Request)
		{
			return ((Financial_ManagementPort)this).Get_Related_Worktags_for_Worktags(new Get_Related_Worktags_for_WorktagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Related_Worktags_for_Worktags_Request = Get_Related_Worktags_for_Worktags_Request
			}).Get_Related_Worktags_for_Worktags_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Related_Worktags_for_WorktagsOutput> Financial_ManagementPort.Get_Related_Worktags_for_WorktagsAsync(Get_Related_Worktags_for_WorktagsInput request)
		{
			return base.Channel.Get_Related_Worktags_for_WorktagsAsync(request);
		}

		public Task<Get_Related_Worktags_for_WorktagsOutput> Get_Related_Worktags_for_WorktagsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Related_Worktags_for_Worktags_RequestType Get_Related_Worktags_for_Worktags_Request)
		{
			return ((Financial_ManagementPort)this).Get_Related_Worktags_for_WorktagsAsync(new Get_Related_Worktags_for_WorktagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Related_Worktags_for_Worktags_Request = Get_Related_Worktags_for_Worktags_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Related_Worktags_for_WorktagOutput Financial_ManagementPort.Put_Related_Worktags_for_Worktag(Put_Related_Worktags_for_WorktagInput request)
		{
			return base.Channel.Put_Related_Worktags_for_Worktag(request);
		}

		public Put_Related_Worktags_for_Worktag_ResponseType Put_Related_Worktags_for_Worktag(Workday_Common_HeaderType Workday_Common_Header, Put_Related_Worktags_for_Worktag_RequestType Put_Related_Worktags_for_Worktag_Request)
		{
			return ((Financial_ManagementPort)this).Put_Related_Worktags_for_Worktag(new Put_Related_Worktags_for_WorktagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Related_Worktags_for_Worktag_Request = Put_Related_Worktags_for_Worktag_Request
			}).Put_Related_Worktags_for_Worktag_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Related_Worktags_for_WorktagOutput> Financial_ManagementPort.Put_Related_Worktags_for_WorktagAsync(Put_Related_Worktags_for_WorktagInput request)
		{
			return base.Channel.Put_Related_Worktags_for_WorktagAsync(request);
		}

		public Task<Put_Related_Worktags_for_WorktagOutput> Put_Related_Worktags_for_WorktagAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Related_Worktags_for_Worktag_RequestType Put_Related_Worktags_for_Worktag_Request)
		{
			return ((Financial_ManagementPort)this).Put_Related_Worktags_for_WorktagAsync(new Put_Related_Worktags_for_WorktagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Related_Worktags_for_Worktag_Request = Put_Related_Worktags_for_Worktag_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Integration_Worktag_Mapping_Source_SystemsOutput Financial_ManagementPort.Get_Integration_Worktag_Mapping_Source_Systems(Get_Integration_Worktag_Mapping_Source_SystemsInput request)
		{
			return base.Channel.Get_Integration_Worktag_Mapping_Source_Systems(request);
		}

		public Get_Integration_Worktag_Mapping_Source_Systems_ResponseType Get_Integration_Worktag_Mapping_Source_Systems(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Worktag_Mapping_Source_Systems_RequestType Get_Integration_Worktag_Mapping_Source_Systems_Request)
		{
			return ((Financial_ManagementPort)this).Get_Integration_Worktag_Mapping_Source_Systems(new Get_Integration_Worktag_Mapping_Source_SystemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Worktag_Mapping_Source_Systems_Request = Get_Integration_Worktag_Mapping_Source_Systems_Request
			}).Get_Integration_Worktag_Mapping_Source_Systems_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Integration_Worktag_Mapping_Source_SystemsOutput> Financial_ManagementPort.Get_Integration_Worktag_Mapping_Source_SystemsAsync(Get_Integration_Worktag_Mapping_Source_SystemsInput request)
		{
			return base.Channel.Get_Integration_Worktag_Mapping_Source_SystemsAsync(request);
		}

		public Task<Get_Integration_Worktag_Mapping_Source_SystemsOutput> Get_Integration_Worktag_Mapping_Source_SystemsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Worktag_Mapping_Source_Systems_RequestType Get_Integration_Worktag_Mapping_Source_Systems_Request)
		{
			return ((Financial_ManagementPort)this).Get_Integration_Worktag_Mapping_Source_SystemsAsync(new Get_Integration_Worktag_Mapping_Source_SystemsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Worktag_Mapping_Source_Systems_Request = Get_Integration_Worktag_Mapping_Source_Systems_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Integration_Worktag_Mapping_Source_SystemOutput Financial_ManagementPort.Put_Integration_Worktag_Mapping_Source_System(Put_Integration_Worktag_Mapping_Source_SystemInput request)
		{
			return base.Channel.Put_Integration_Worktag_Mapping_Source_System(request);
		}

		public Put_Integration_Worktag_Mapping_Source_System_ResponseType Put_Integration_Worktag_Mapping_Source_System(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Worktag_Mapping_Source_System_RequestType Put_Integration_Worktag_Mapping_Source_System_Request)
		{
			return ((Financial_ManagementPort)this).Put_Integration_Worktag_Mapping_Source_System(new Put_Integration_Worktag_Mapping_Source_SystemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Worktag_Mapping_Source_System_Request = Put_Integration_Worktag_Mapping_Source_System_Request
			}).Put_Integration_Worktag_Mapping_Source_System_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Integration_Worktag_Mapping_Source_SystemOutput> Financial_ManagementPort.Put_Integration_Worktag_Mapping_Source_SystemAsync(Put_Integration_Worktag_Mapping_Source_SystemInput request)
		{
			return base.Channel.Put_Integration_Worktag_Mapping_Source_SystemAsync(request);
		}

		public Task<Put_Integration_Worktag_Mapping_Source_SystemOutput> Put_Integration_Worktag_Mapping_Source_SystemAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Worktag_Mapping_Source_System_RequestType Put_Integration_Worktag_Mapping_Source_System_Request)
		{
			return ((Financial_ManagementPort)this).Put_Integration_Worktag_Mapping_Source_SystemAsync(new Put_Integration_Worktag_Mapping_Source_SystemInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Worktag_Mapping_Source_System_Request = Put_Integration_Worktag_Mapping_Source_System_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Integration_Worktag_MappingsOutput Financial_ManagementPort.Get_Integration_Worktag_Mappings(Get_Integration_Worktag_MappingsInput request)
		{
			return base.Channel.Get_Integration_Worktag_Mappings(request);
		}

		public Get_Integration_Worktag_Mappings_ResponseType Get_Integration_Worktag_Mappings(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Worktag_Mappings_RequestType Get_Integration_Worktag_Mappings_Request)
		{
			return ((Financial_ManagementPort)this).Get_Integration_Worktag_Mappings(new Get_Integration_Worktag_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Worktag_Mappings_Request = Get_Integration_Worktag_Mappings_Request
			}).Get_Integration_Worktag_Mappings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Integration_Worktag_MappingsOutput> Financial_ManagementPort.Get_Integration_Worktag_MappingsAsync(Get_Integration_Worktag_MappingsInput request)
		{
			return base.Channel.Get_Integration_Worktag_MappingsAsync(request);
		}

		public Task<Get_Integration_Worktag_MappingsOutput> Get_Integration_Worktag_MappingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Worktag_Mappings_RequestType Get_Integration_Worktag_Mappings_Request)
		{
			return ((Financial_ManagementPort)this).Get_Integration_Worktag_MappingsAsync(new Get_Integration_Worktag_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Integration_Worktag_Mappings_Request = Get_Integration_Worktag_Mappings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Integration_Worktag_MappingOutput Financial_ManagementPort.Put_Integration_Worktag_Mapping(Put_Integration_Worktag_MappingInput request)
		{
			return base.Channel.Put_Integration_Worktag_Mapping(request);
		}

		public Put_Integration_Worktag_Mapping_ResponseType Put_Integration_Worktag_Mapping(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Worktag_Mapping_RequestType Put_Integration_Worktag_Mapping_Request)
		{
			return ((Financial_ManagementPort)this).Put_Integration_Worktag_Mapping(new Put_Integration_Worktag_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Worktag_Mapping_Request = Put_Integration_Worktag_Mapping_Request
			}).Put_Integration_Worktag_Mapping_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Integration_Worktag_MappingOutput> Financial_ManagementPort.Put_Integration_Worktag_MappingAsync(Put_Integration_Worktag_MappingInput request)
		{
			return base.Channel.Put_Integration_Worktag_MappingAsync(request);
		}

		public Task<Put_Integration_Worktag_MappingOutput> Put_Integration_Worktag_MappingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Integration_Worktag_Mapping_RequestType Put_Integration_Worktag_Mapping_Request)
		{
			return ((Financial_ManagementPort)this).Put_Integration_Worktag_MappingAsync(new Put_Integration_Worktag_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Integration_Worktag_Mapping_Request = Put_Integration_Worktag_Mapping_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Escheatable_Payment_Notification_DateOutput Financial_ManagementPort.Put_Escheatable_Payment_Notification_Date(Put_Escheatable_Payment_Notification_DateInput request)
		{
			return base.Channel.Put_Escheatable_Payment_Notification_Date(request);
		}

		public Put_Escheatable_Payment_Notification_Date_ResponseType Put_Escheatable_Payment_Notification_Date(Workday_Common_HeaderType Workday_Common_Header, Put_Escheatable_Payment_Notification_Date_RequestType Put_Escheatable_Payment_Notification_Date_Request)
		{
			return ((Financial_ManagementPort)this).Put_Escheatable_Payment_Notification_Date(new Put_Escheatable_Payment_Notification_DateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Escheatable_Payment_Notification_Date_Request = Put_Escheatable_Payment_Notification_Date_Request
			}).Put_Escheatable_Payment_Notification_Date_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Escheatable_Payment_Notification_DateOutput> Financial_ManagementPort.Put_Escheatable_Payment_Notification_DateAsync(Put_Escheatable_Payment_Notification_DateInput request)
		{
			return base.Channel.Put_Escheatable_Payment_Notification_DateAsync(request);
		}

		public Task<Put_Escheatable_Payment_Notification_DateOutput> Put_Escheatable_Payment_Notification_DateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Escheatable_Payment_Notification_Date_RequestType Put_Escheatable_Payment_Notification_Date_Request)
		{
			return ((Financial_ManagementPort)this).Put_Escheatable_Payment_Notification_DateAsync(new Put_Escheatable_Payment_Notification_DateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Escheatable_Payment_Notification_Date_Request = Put_Escheatable_Payment_Notification_Date_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Spend_RestrictionOutput Financial_ManagementPort.Put_Spend_Restriction(Put_Spend_RestrictionInput request)
		{
			return base.Channel.Put_Spend_Restriction(request);
		}

		public Put_Spend_Restriction_ResponseType Put_Spend_Restriction(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Restriction_RequestType Put_Spend_Restriction_Request)
		{
			return ((Financial_ManagementPort)this).Put_Spend_Restriction(new Put_Spend_RestrictionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Spend_Restriction_Request = Put_Spend_Restriction_Request
			}).Put_Spend_Restriction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Spend_RestrictionOutput> Financial_ManagementPort.Put_Spend_RestrictionAsync(Put_Spend_RestrictionInput request)
		{
			return base.Channel.Put_Spend_RestrictionAsync(request);
		}

		public Task<Put_Spend_RestrictionOutput> Put_Spend_RestrictionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Spend_Restriction_RequestType Put_Spend_Restriction_Request)
		{
			return ((Financial_ManagementPort)this).Put_Spend_RestrictionAsync(new Put_Spend_RestrictionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Spend_Restriction_Request = Put_Spend_Restriction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Spend_RestrictionsOutput Financial_ManagementPort.Get_Spend_Restrictions(Get_Spend_RestrictionsInput request)
		{
			return base.Channel.Get_Spend_Restrictions(request);
		}

		public Get_Spend_Restrictions_ResponseType Get_Spend_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Restrictions_RequestType Get_Spend_Restrictions_Request)
		{
			return ((Financial_ManagementPort)this).Get_Spend_Restrictions(new Get_Spend_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Restrictions_Request = Get_Spend_Restrictions_Request
			}).Get_Spend_Restrictions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Spend_RestrictionsOutput> Financial_ManagementPort.Get_Spend_RestrictionsAsync(Get_Spend_RestrictionsInput request)
		{
			return base.Channel.Get_Spend_RestrictionsAsync(request);
		}

		public Task<Get_Spend_RestrictionsOutput> Get_Spend_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Restrictions_RequestType Get_Spend_Restrictions_Request)
		{
			return ((Financial_ManagementPort)this).Get_Spend_RestrictionsAsync(new Get_Spend_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Spend_Restrictions_Request = Get_Spend_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Transaction_Tax_StatusesOutput Financial_ManagementPort.Get_Transaction_Tax_Statuses(Get_Transaction_Tax_StatusesInput request)
		{
			return base.Channel.Get_Transaction_Tax_Statuses(request);
		}

		public Get_Transaction_Tax_Statuses_ResponseType Get_Transaction_Tax_Statuses(Workday_Common_HeaderType Workday_Common_Header, Get_Transaction_Tax_Statuses_RequestType Get_Transaction_Tax_Statuses_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_Statuses(new Get_Transaction_Tax_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Transaction_Tax_Statuses_Request = Get_Transaction_Tax_Statuses_Request
			}).Get_Transaction_Tax_Statuses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Transaction_Tax_StatusesOutput> Financial_ManagementPort.Get_Transaction_Tax_StatusesAsync(Get_Transaction_Tax_StatusesInput request)
		{
			return base.Channel.Get_Transaction_Tax_StatusesAsync(request);
		}

		public Task<Get_Transaction_Tax_StatusesOutput> Get_Transaction_Tax_StatusesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Transaction_Tax_Statuses_RequestType Get_Transaction_Tax_Statuses_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_StatusesAsync(new Get_Transaction_Tax_StatusesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Transaction_Tax_Statuses_Request = Get_Transaction_Tax_Statuses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Transaction_Tax_StatusOutput Financial_ManagementPort.Put_Transaction_Tax_Status(Put_Transaction_Tax_StatusInput request)
		{
			return base.Channel.Put_Transaction_Tax_Status(request);
		}

		public Put_Transaction_Tax_Status_ResponseType Put_Transaction_Tax_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Transaction_Tax_Status_RequestType Put_Transaction_Tax_Status_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_Status(new Put_Transaction_Tax_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Transaction_Tax_Status_Request = Put_Transaction_Tax_Status_Request
			}).Put_Transaction_Tax_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Transaction_Tax_StatusOutput> Financial_ManagementPort.Put_Transaction_Tax_StatusAsync(Put_Transaction_Tax_StatusInput request)
		{
			return base.Channel.Put_Transaction_Tax_StatusAsync(request);
		}

		public Task<Put_Transaction_Tax_StatusOutput> Put_Transaction_Tax_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Transaction_Tax_Status_RequestType Put_Transaction_Tax_Status_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_StatusAsync(new Put_Transaction_Tax_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Transaction_Tax_Status_Request = Put_Transaction_Tax_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Withholding_Tax_StatusOutput Financial_ManagementPort.Put_Withholding_Tax_Status(Put_Withholding_Tax_StatusInput request)
		{
			return base.Channel.Put_Withholding_Tax_Status(request);
		}

		public Put_Withholding_Tax_Status_ResponseType Put_Withholding_Tax_Status(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Status_RequestType Put_Withholding_Tax_Status_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_Status(new Put_Withholding_Tax_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Status_Request = Put_Withholding_Tax_Status_Request
			}).Put_Withholding_Tax_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Withholding_Tax_StatusOutput> Financial_ManagementPort.Put_Withholding_Tax_StatusAsync(Put_Withholding_Tax_StatusInput request)
		{
			return base.Channel.Put_Withholding_Tax_StatusAsync(request);
		}

		public Task<Put_Withholding_Tax_StatusOutput> Put_Withholding_Tax_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Status_RequestType Put_Withholding_Tax_Status_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_StatusAsync(new Put_Withholding_Tax_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Status_Request = Put_Withholding_Tax_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Withholding_Tax_StatusOutput Financial_ManagementPort.Get_Withholding_Tax_Status(Get_Withholding_Tax_StatusInput request)
		{
			return base.Channel.Get_Withholding_Tax_Status(request);
		}

		public Get_Withholding_Tax_Status_ResponseType Get_Withholding_Tax_Status(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Status_RequestType Get_Withholding_Tax_Status_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_Status(new Get_Withholding_Tax_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Status_Request = Get_Withholding_Tax_Status_Request
			}).Get_Withholding_Tax_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Withholding_Tax_StatusOutput> Financial_ManagementPort.Get_Withholding_Tax_StatusAsync(Get_Withholding_Tax_StatusInput request)
		{
			return base.Channel.Get_Withholding_Tax_StatusAsync(request);
		}

		public Task<Get_Withholding_Tax_StatusOutput> Get_Withholding_Tax_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Status_RequestType Get_Withholding_Tax_Status_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_StatusAsync(new Get_Withholding_Tax_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Status_Request = Get_Withholding_Tax_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Withholding_Tax_RatesOutput Financial_ManagementPort.Get_Withholding_Tax_Rates(Get_Withholding_Tax_RatesInput request)
		{
			return base.Channel.Get_Withholding_Tax_Rates(request);
		}

		public Get_Withholding_Tax_Rates_ResponseType Get_Withholding_Tax_Rates(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Rates_RequestType Get_Withholding_Tax_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_Rates(new Get_Withholding_Tax_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Rates_Request = Get_Withholding_Tax_Rates_Request
			}).Get_Withholding_Tax_Rates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Withholding_Tax_RatesOutput> Financial_ManagementPort.Get_Withholding_Tax_RatesAsync(Get_Withholding_Tax_RatesInput request)
		{
			return base.Channel.Get_Withholding_Tax_RatesAsync(request);
		}

		public Task<Get_Withholding_Tax_RatesOutput> Get_Withholding_Tax_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Rates_RequestType Get_Withholding_Tax_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_RatesAsync(new Get_Withholding_Tax_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Rates_Request = Get_Withholding_Tax_Rates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Withholding_Tax_RateOutput Financial_ManagementPort.Put_Withholding_Tax_Rate(Put_Withholding_Tax_RateInput request)
		{
			return base.Channel.Put_Withholding_Tax_Rate(request);
		}

		public Put_Withholding_Tax_Rate_ResponseType Put_Withholding_Tax_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Rate_RequestType Put_Withholding_Tax_Rate_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_Rate(new Put_Withholding_Tax_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Rate_Request = Put_Withholding_Tax_Rate_Request
			}).Put_Withholding_Tax_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Withholding_Tax_RateOutput> Financial_ManagementPort.Put_Withholding_Tax_RateAsync(Put_Withholding_Tax_RateInput request)
		{
			return base.Channel.Put_Withholding_Tax_RateAsync(request);
		}

		public Task<Put_Withholding_Tax_RateOutput> Put_Withholding_Tax_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Rate_RequestType Put_Withholding_Tax_Rate_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_RateAsync(new Put_Withholding_Tax_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Rate_Request = Put_Withholding_Tax_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Suspense_Account_RulesOutput Financial_ManagementPort.Get_Suspense_Account_Rules(Get_Suspense_Account_RulesInput request)
		{
			return base.Channel.Get_Suspense_Account_Rules(request);
		}

		public Get_Suspense_Account_Rules_ResponseType Get_Suspense_Account_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Suspense_Account_Rules_RequestType Get_Suspense_Account_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Suspense_Account_Rules(new Get_Suspense_Account_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Suspense_Account_Rules_Request = Get_Suspense_Account_Rules_Request
			}).Get_Suspense_Account_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Suspense_Account_RulesOutput> Financial_ManagementPort.Get_Suspense_Account_RulesAsync(Get_Suspense_Account_RulesInput request)
		{
			return base.Channel.Get_Suspense_Account_RulesAsync(request);
		}

		public Task<Get_Suspense_Account_RulesOutput> Get_Suspense_Account_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Suspense_Account_Rules_RequestType Get_Suspense_Account_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Suspense_Account_RulesAsync(new Get_Suspense_Account_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Suspense_Account_Rules_Request = Get_Suspense_Account_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Suspense_Account_RuleOutput Financial_ManagementPort.Put_Suspense_Account_Rule(Put_Suspense_Account_RuleInput request)
		{
			return base.Channel.Put_Suspense_Account_Rule(request);
		}

		public Put_Suspense_Account_Rule_ResponseType Put_Suspense_Account_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Suspense_Account_Rule_RequestType Put_Suspense_Account_Rule_Request)
		{
			return ((Financial_ManagementPort)this).Put_Suspense_Account_Rule(new Put_Suspense_Account_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Suspense_Account_Rule_Request = Put_Suspense_Account_Rule_Request
			}).Put_Suspense_Account_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Suspense_Account_RuleOutput> Financial_ManagementPort.Put_Suspense_Account_RuleAsync(Put_Suspense_Account_RuleInput request)
		{
			return base.Channel.Put_Suspense_Account_RuleAsync(request);
		}

		public Task<Put_Suspense_Account_RuleOutput> Put_Suspense_Account_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Suspense_Account_Rule_RequestType Put_Suspense_Account_Rule_Request)
		{
			return ((Financial_ManagementPort)this).Put_Suspense_Account_RuleAsync(new Put_Suspense_Account_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Suspense_Account_Rule_Request = Put_Suspense_Account_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Headcount_PlanOutput Financial_ManagementPort.Get_Headcount_Plan(Get_Headcount_PlanInput request)
		{
			return base.Channel.Get_Headcount_Plan(request);
		}

		public Get_Headcount_Plan_ResponseType Get_Headcount_Plan(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_RequestType Get_Headcount_Plan_Request)
		{
			return ((Financial_ManagementPort)this).Get_Headcount_Plan(new Get_Headcount_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plan_Request = Get_Headcount_Plan_Request
			}).Get_Headcount_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Headcount_PlanOutput> Financial_ManagementPort.Get_Headcount_PlanAsync(Get_Headcount_PlanInput request)
		{
			return base.Channel.Get_Headcount_PlanAsync(request);
		}

		public Task<Get_Headcount_PlanOutput> Get_Headcount_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_RequestType Get_Headcount_Plan_Request)
		{
			return ((Financial_ManagementPort)this).Get_Headcount_PlanAsync(new Get_Headcount_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Headcount_Plan_Request = Get_Headcount_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Transaction_Tax_Item_GroupsOutput Financial_ManagementPort.Get_Transaction_Tax_Item_Groups(Get_Transaction_Tax_Item_GroupsInput request)
		{
			return base.Channel.Get_Transaction_Tax_Item_Groups(request);
		}

		public Get_Transaction_Tax_Item_Groups_ResponseType Get_Transaction_Tax_Item_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Transaction_Tax_Item_Groups_RequestType Get_Transaction_Tax_Item_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_Item_Groups(new Get_Transaction_Tax_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Transaction_Tax_Item_Groups_Request = Get_Transaction_Tax_Item_Groups_Request
			}).Get_Transaction_Tax_Item_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Transaction_Tax_Item_GroupsOutput> Financial_ManagementPort.Get_Transaction_Tax_Item_GroupsAsync(Get_Transaction_Tax_Item_GroupsInput request)
		{
			return base.Channel.Get_Transaction_Tax_Item_GroupsAsync(request);
		}

		public Task<Get_Transaction_Tax_Item_GroupsOutput> Get_Transaction_Tax_Item_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Transaction_Tax_Item_Groups_RequestType Get_Transaction_Tax_Item_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_Transaction_Tax_Item_GroupsAsync(new Get_Transaction_Tax_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Transaction_Tax_Item_Groups_Request = Get_Transaction_Tax_Item_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Transaction_Tax_Item_GroupOutput Financial_ManagementPort.Put_Transaction_Tax_Item_Group(Put_Transaction_Tax_Item_GroupInput request)
		{
			return base.Channel.Put_Transaction_Tax_Item_Group(request);
		}

		public Put_Transaction_Tax_Item_Group_ResponseType Put_Transaction_Tax_Item_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Transaction_Tax_Item_Group_RequestType Put_Transaction_Tax_Item_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_Item_Group(new Put_Transaction_Tax_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Transaction_Tax_Item_Group_Request = Put_Transaction_Tax_Item_Group_Request
			}).Put_Transaction_Tax_Item_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Transaction_Tax_Item_GroupOutput> Financial_ManagementPort.Put_Transaction_Tax_Item_GroupAsync(Put_Transaction_Tax_Item_GroupInput request)
		{
			return base.Channel.Put_Transaction_Tax_Item_GroupAsync(request);
		}

		public Task<Put_Transaction_Tax_Item_GroupOutput> Put_Transaction_Tax_Item_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Transaction_Tax_Item_Group_RequestType Put_Transaction_Tax_Item_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_Transaction_Tax_Item_GroupAsync(new Put_Transaction_Tax_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Transaction_Tax_Item_Group_Request = Put_Transaction_Tax_Item_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Withholding_Tax_Item_GroupsOutput Financial_ManagementPort.Get_Withholding_Tax_Item_Groups(Get_Withholding_Tax_Item_GroupsInput request)
		{
			return base.Channel.Get_Withholding_Tax_Item_Groups(request);
		}

		public Get_Withholding_Tax_Item_Groups_ResponseType Get_Withholding_Tax_Item_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Item_Groups_RequestType Get_Withholding_Tax_Item_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_Item_Groups(new Get_Withholding_Tax_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Item_Groups_Request = Get_Withholding_Tax_Item_Groups_Request
			}).Get_Withholding_Tax_Item_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Withholding_Tax_Item_GroupsOutput> Financial_ManagementPort.Get_Withholding_Tax_Item_GroupsAsync(Get_Withholding_Tax_Item_GroupsInput request)
		{
			return base.Channel.Get_Withholding_Tax_Item_GroupsAsync(request);
		}

		public Task<Get_Withholding_Tax_Item_GroupsOutput> Get_Withholding_Tax_Item_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Item_Groups_RequestType Get_Withholding_Tax_Item_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_Item_GroupsAsync(new Get_Withholding_Tax_Item_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Item_Groups_Request = Get_Withholding_Tax_Item_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Withholding_Tax_Item_GroupOutput Financial_ManagementPort.Put_Withholding_Tax_Item_Group(Put_Withholding_Tax_Item_GroupInput request)
		{
			return base.Channel.Put_Withholding_Tax_Item_Group(request);
		}

		public Put_Withholding_Tax_Item_Group_ResponseType Put_Withholding_Tax_Item_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Item_Group_RequestType Put_Withholding_Tax_Item_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_Item_Group(new Put_Withholding_Tax_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Item_Group_Request = Put_Withholding_Tax_Item_Group_Request
			}).Put_Withholding_Tax_Item_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Withholding_Tax_Item_GroupOutput> Financial_ManagementPort.Put_Withholding_Tax_Item_GroupAsync(Put_Withholding_Tax_Item_GroupInput request)
		{
			return base.Channel.Put_Withholding_Tax_Item_GroupAsync(request);
		}

		public Task<Put_Withholding_Tax_Item_GroupOutput> Put_Withholding_Tax_Item_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Item_Group_RequestType Put_Withholding_Tax_Item_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_Item_GroupAsync(new Put_Withholding_Tax_Item_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Item_Group_Request = Put_Withholding_Tax_Item_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Default_Values_for_WorktagsOutput Financial_ManagementPort.Get_Default_Values_for_Worktags(Get_Default_Values_for_WorktagsInput request)
		{
			return base.Channel.Get_Default_Values_for_Worktags(request);
		}

		public Get_Default_Values_for_Worktags_ResponseType Get_Default_Values_for_Worktags(Workday_Common_HeaderType Workday_Common_Header, Get_Default_Values_for_Worktags_RequestType Get_Default_Values_for_Worktags_Request)
		{
			return ((Financial_ManagementPort)this).Get_Default_Values_for_Worktags(new Get_Default_Values_for_WorktagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Default_Values_for_Worktags_Request = Get_Default_Values_for_Worktags_Request
			}).Get_Default_Values_for_Worktags_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Default_Values_for_WorktagsOutput> Financial_ManagementPort.Get_Default_Values_for_WorktagsAsync(Get_Default_Values_for_WorktagsInput request)
		{
			return base.Channel.Get_Default_Values_for_WorktagsAsync(request);
		}

		public Task<Get_Default_Values_for_WorktagsOutput> Get_Default_Values_for_WorktagsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Default_Values_for_Worktags_RequestType Get_Default_Values_for_Worktags_Request)
		{
			return ((Financial_ManagementPort)this).Get_Default_Values_for_WorktagsAsync(new Get_Default_Values_for_WorktagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Default_Values_for_Worktags_Request = Get_Default_Values_for_Worktags_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Default_Values_for_WorktagOutput Financial_ManagementPort.Put_Default_Values_for_Worktag(Put_Default_Values_for_WorktagInput request)
		{
			return base.Channel.Put_Default_Values_for_Worktag(request);
		}

		public Put_Default_Values_for_Worktag_ResponseType Put_Default_Values_for_Worktag(Workday_Common_HeaderType Workday_Common_Header, Put_Default_Values_for_Worktag_RequestType Put_Default_Values_for_Worktag_Request)
		{
			return ((Financial_ManagementPort)this).Put_Default_Values_for_Worktag(new Put_Default_Values_for_WorktagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Default_Values_for_Worktag_Request = Put_Default_Values_for_Worktag_Request
			}).Put_Default_Values_for_Worktag_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Default_Values_for_WorktagOutput> Financial_ManagementPort.Put_Default_Values_for_WorktagAsync(Put_Default_Values_for_WorktagInput request)
		{
			return base.Channel.Put_Default_Values_for_WorktagAsync(request);
		}

		public Task<Put_Default_Values_for_WorktagOutput> Put_Default_Values_for_WorktagAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Default_Values_for_Worktag_RequestType Put_Default_Values_for_Worktag_Request)
		{
			return ((Financial_ManagementPort)this).Put_Default_Values_for_WorktagAsync(new Put_Default_Values_for_WorktagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Default_Values_for_Worktag_Request = Put_Default_Values_for_Worktag_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_VAT_GroupsOutput Financial_ManagementPort.Get_VAT_Groups(Get_VAT_GroupsInput request)
		{
			return base.Channel.Get_VAT_Groups(request);
		}

		public Get_VAT_Groups_ResponseType Get_VAT_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_VAT_Groups_RequestType Get_VAT_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_VAT_Groups(new Get_VAT_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_VAT_Groups_Request = Get_VAT_Groups_Request
			}).Get_VAT_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_VAT_GroupsOutput> Financial_ManagementPort.Get_VAT_GroupsAsync(Get_VAT_GroupsInput request)
		{
			return base.Channel.Get_VAT_GroupsAsync(request);
		}

		public Task<Get_VAT_GroupsOutput> Get_VAT_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_VAT_Groups_RequestType Get_VAT_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_VAT_GroupsAsync(new Get_VAT_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_VAT_Groups_Request = Get_VAT_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_VAT_GroupOutput Financial_ManagementPort.Put_VAT_Group(Put_VAT_GroupInput request)
		{
			return base.Channel.Put_VAT_Group(request);
		}

		public Put_VAT_Group_ResponseType Put_VAT_Group(Workday_Common_HeaderType Workday_Common_Header, Put_VAT_Group_RequestType Put_VAT_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_VAT_Group(new Put_VAT_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_VAT_Group_Request = Put_VAT_Group_Request
			}).Put_VAT_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_VAT_GroupOutput> Financial_ManagementPort.Put_VAT_GroupAsync(Put_VAT_GroupInput request)
		{
			return base.Channel.Put_VAT_GroupAsync(request);
		}

		public Task<Put_VAT_GroupOutput> Put_VAT_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_VAT_Group_RequestType Put_VAT_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_VAT_GroupAsync(new Put_VAT_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_VAT_Group_Request = Put_VAT_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Withholding_Tax_CodesOutput Financial_ManagementPort.Get_Withholding_Tax_Codes(Get_Withholding_Tax_CodesInput request)
		{
			return base.Channel.Get_Withholding_Tax_Codes(request);
		}

		public Get_Withholding_Tax_Codes_ResponseType Get_Withholding_Tax_Codes(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Codes_RequestType Get_Withholding_Tax_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_Codes(new Get_Withholding_Tax_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Codes_Request = Get_Withholding_Tax_Codes_Request
			}).Get_Withholding_Tax_Codes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Withholding_Tax_CodesOutput> Financial_ManagementPort.Get_Withholding_Tax_CodesAsync(Get_Withholding_Tax_CodesInput request)
		{
			return base.Channel.Get_Withholding_Tax_CodesAsync(request);
		}

		public Task<Get_Withholding_Tax_CodesOutput> Get_Withholding_Tax_CodesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Tax_Codes_RequestType Get_Withholding_Tax_Codes_Request)
		{
			return ((Financial_ManagementPort)this).Get_Withholding_Tax_CodesAsync(new Get_Withholding_Tax_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Tax_Codes_Request = Get_Withholding_Tax_Codes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Withholding_Tax_CodeOutput Financial_ManagementPort.Put_Withholding_Tax_Code(Put_Withholding_Tax_CodeInput request)
		{
			return base.Channel.Put_Withholding_Tax_Code(request);
		}

		public Put_Withholding_Tax_Code_ResponseType Put_Withholding_Tax_Code(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Code_RequestType Put_Withholding_Tax_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_Code(new Put_Withholding_Tax_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Code_Request = Put_Withholding_Tax_Code_Request
			}).Put_Withholding_Tax_Code_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Withholding_Tax_CodeOutput> Financial_ManagementPort.Put_Withholding_Tax_CodeAsync(Put_Withholding_Tax_CodeInput request)
		{
			return base.Channel.Put_Withholding_Tax_CodeAsync(request);
		}

		public Task<Put_Withholding_Tax_CodeOutput> Put_Withholding_Tax_CodeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Tax_Code_RequestType Put_Withholding_Tax_Code_Request)
		{
			return ((Financial_ManagementPort)this).Put_Withholding_Tax_CodeAsync(new Put_Withholding_Tax_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Tax_Code_Request = Put_Withholding_Tax_Code_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Tax_Rule_Exception_GroupsOutput Financial_ManagementPort.Get_Tax_Rule_Exception_Groups(Get_Tax_Rule_Exception_GroupsInput request)
		{
			return base.Channel.Get_Tax_Rule_Exception_Groups(request);
		}

		public Get_Tax_Rule_Exception_Groups_ResponseType Get_Tax_Rule_Exception_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Rule_Exception_Groups_RequestType Get_Tax_Rule_Exception_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_Rule_Exception_Groups(new Get_Tax_Rule_Exception_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Rule_Exception_Groups_Request = Get_Tax_Rule_Exception_Groups_Request
			}).Get_Tax_Rule_Exception_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Tax_Rule_Exception_GroupsOutput> Financial_ManagementPort.Get_Tax_Rule_Exception_GroupsAsync(Get_Tax_Rule_Exception_GroupsInput request)
		{
			return base.Channel.Get_Tax_Rule_Exception_GroupsAsync(request);
		}

		public Task<Get_Tax_Rule_Exception_GroupsOutput> Get_Tax_Rule_Exception_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Rule_Exception_Groups_RequestType Get_Tax_Rule_Exception_Groups_Request)
		{
			return ((Financial_ManagementPort)this).Get_Tax_Rule_Exception_GroupsAsync(new Get_Tax_Rule_Exception_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Rule_Exception_Groups_Request = Get_Tax_Rule_Exception_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Tax_Rule_Exception_GroupOutput Financial_ManagementPort.Put_Tax_Rule_Exception_Group(Put_Tax_Rule_Exception_GroupInput request)
		{
			return base.Channel.Put_Tax_Rule_Exception_Group(request);
		}

		public Put_Tax_Rule_Exception_Group_ResponseType Put_Tax_Rule_Exception_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Rule_Exception_Group_RequestType Put_Tax_Rule_Exception_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_Rule_Exception_Group(new Put_Tax_Rule_Exception_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Rule_Exception_Group_Request = Put_Tax_Rule_Exception_Group_Request
			}).Put_Tax_Rule_Exception_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Tax_Rule_Exception_GroupOutput> Financial_ManagementPort.Put_Tax_Rule_Exception_GroupAsync(Put_Tax_Rule_Exception_GroupInput request)
		{
			return base.Channel.Put_Tax_Rule_Exception_GroupAsync(request);
		}

		public Task<Put_Tax_Rule_Exception_GroupOutput> Put_Tax_Rule_Exception_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Rule_Exception_Group_RequestType Put_Tax_Rule_Exception_Group_Request)
		{
			return ((Financial_ManagementPort)this).Put_Tax_Rule_Exception_GroupAsync(new Put_Tax_Rule_Exception_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Rule_Exception_Group_Request = Put_Tax_Rule_Exception_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Default_Funding_SourcesOutput Financial_ManagementPort.Get_Default_Funding_Sources(Get_Default_Funding_SourcesInput request)
		{
			return base.Channel.Get_Default_Funding_Sources(request);
		}

		public Get_Default_Funding_Sources_ResponseType Get_Default_Funding_Sources(Workday_Common_HeaderType Workday_Common_Header, Get_Default_Funding_Sources_RequestType Get_Default_Funding_Sources_Request)
		{
			return ((Financial_ManagementPort)this).Get_Default_Funding_Sources(new Get_Default_Funding_SourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Default_Funding_Sources_Request = Get_Default_Funding_Sources_Request
			}).Get_Default_Funding_Sources_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Default_Funding_SourcesOutput> Financial_ManagementPort.Get_Default_Funding_SourcesAsync(Get_Default_Funding_SourcesInput request)
		{
			return base.Channel.Get_Default_Funding_SourcesAsync(request);
		}

		public Task<Get_Default_Funding_SourcesOutput> Get_Default_Funding_SourcesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Default_Funding_Sources_RequestType Get_Default_Funding_Sources_Request)
		{
			return ((Financial_ManagementPort)this).Get_Default_Funding_SourcesAsync(new Get_Default_Funding_SourcesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Default_Funding_Sources_Request = Get_Default_Funding_Sources_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Default_Funding_SourceOutput Financial_ManagementPort.Put_Default_Funding_Source(Put_Default_Funding_SourceInput request)
		{
			return base.Channel.Put_Default_Funding_Source(request);
		}

		public Put_Default_Funding_Source_ResponseType Put_Default_Funding_Source(Workday_Common_HeaderType Workday_Common_Header, Put_Default_Funding_Source_RequestType Put_Default_Funding_Source_Request)
		{
			return ((Financial_ManagementPort)this).Put_Default_Funding_Source(new Put_Default_Funding_SourceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Default_Funding_Source_Request = Put_Default_Funding_Source_Request
			}).Put_Default_Funding_Source_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Default_Funding_SourceOutput> Financial_ManagementPort.Put_Default_Funding_SourceAsync(Put_Default_Funding_SourceInput request)
		{
			return base.Channel.Put_Default_Funding_SourceAsync(request);
		}

		public Task<Put_Default_Funding_SourceOutput> Put_Default_Funding_SourceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Default_Funding_Source_RequestType Put_Default_Funding_Source_Request)
		{
			return ((Financial_ManagementPort)this).Put_Default_Funding_SourceAsync(new Put_Default_Funding_SourceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Default_Funding_Source_Request = Put_Default_Funding_Source_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Funding_Source_RulesOutput Financial_ManagementPort.Get_Funding_Source_Rules(Get_Funding_Source_RulesInput request)
		{
			return base.Channel.Get_Funding_Source_Rules(request);
		}

		public Get_Funding_Source_Rules_ResponseType Get_Funding_Source_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Funding_Source_Rules_RequestType Get_Funding_Source_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Funding_Source_Rules(new Get_Funding_Source_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Funding_Source_Rules_Request = Get_Funding_Source_Rules_Request
			}).Get_Funding_Source_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Funding_Source_RulesOutput> Financial_ManagementPort.Get_Funding_Source_RulesAsync(Get_Funding_Source_RulesInput request)
		{
			return base.Channel.Get_Funding_Source_RulesAsync(request);
		}

		public Task<Get_Funding_Source_RulesOutput> Get_Funding_Source_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Funding_Source_Rules_RequestType Get_Funding_Source_Rules_Request)
		{
			return ((Financial_ManagementPort)this).Get_Funding_Source_RulesAsync(new Get_Funding_Source_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Funding_Source_Rules_Request = Get_Funding_Source_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Funding_Source_RuleOutput Financial_ManagementPort.Put_Funding_Source_Rule(Put_Funding_Source_RuleInput request)
		{
			return base.Channel.Put_Funding_Source_Rule(request);
		}

		public Put_Funding_Source_Rule_ResponseType Put_Funding_Source_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Funding_Source_Rule_RequestType Put_Funding_Source_Rule_Request)
		{
			return ((Financial_ManagementPort)this).Put_Funding_Source_Rule(new Put_Funding_Source_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Funding_Source_Rule_Request = Put_Funding_Source_Rule_Request
			}).Put_Funding_Source_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Funding_Source_RuleOutput> Financial_ManagementPort.Put_Funding_Source_RuleAsync(Put_Funding_Source_RuleInput request)
		{
			return base.Channel.Put_Funding_Source_RuleAsync(request);
		}

		public Task<Put_Funding_Source_RuleOutput> Put_Funding_Source_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Funding_Source_Rule_RequestType Put_Funding_Source_Rule_Request)
		{
			return ((Financial_ManagementPort)this).Put_Funding_Source_RuleAsync(new Put_Funding_Source_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Funding_Source_Rule_Request = Put_Funding_Source_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Revaluation_RunOutput Financial_ManagementPort.Submit_Revaluation_Run(Submit_Revaluation_RunInput request)
		{
			return base.Channel.Submit_Revaluation_Run(request);
		}

		public Submit_Revaluation_Run_ResponseType Submit_Revaluation_Run(Workday_Common_HeaderType Workday_Common_Header, Submit_Revaluation_Run_RequestType Submit_Revaluation_Run_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Revaluation_Run(new Submit_Revaluation_RunInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Revaluation_Run_Request = Submit_Revaluation_Run_Request
			}).Submit_Revaluation_Run_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Revaluation_RunOutput> Financial_ManagementPort.Submit_Revaluation_RunAsync(Submit_Revaluation_RunInput request)
		{
			return base.Channel.Submit_Revaluation_RunAsync(request);
		}

		public Task<Submit_Revaluation_RunOutput> Submit_Revaluation_RunAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Revaluation_Run_RequestType Submit_Revaluation_Run_Request)
		{
			return ((Financial_ManagementPort)this).Submit_Revaluation_RunAsync(new Submit_Revaluation_RunInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Revaluation_Run_Request = Submit_Revaluation_Run_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Accounting_Journal(Import_Accounting_JournalInput request)
		{
			return base.Channel.Import_Accounting_Journal(request);
		}

		public Put_Import_Process_ResponseType Import_Accounting_Journal(Workday_Common_HeaderType Workday_Common_Header, Import_Accounting_Journal_RequestType Import_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Import_Accounting_Journal(new Import_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Accounting_Journal_Request = Import_Accounting_Journal_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_Accounting_JournalAsync(Import_Accounting_JournalInput request)
		{
			return base.Channel.Import_Accounting_JournalAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_Accounting_JournalAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Accounting_Journal_RequestType Import_Accounting_Journal_Request)
		{
			return ((Financial_ManagementPort)this).Import_Accounting_JournalAsync(new Import_Accounting_JournalInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Accounting_Journal_Request = Import_Accounting_Journal_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Budget_Amendment(Import_Budget_AmendmentInput request)
		{
			return base.Channel.Import_Budget_Amendment(request);
		}

		public Put_Import_Process_ResponseType Import_Budget_Amendment(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_Amendment_RequestType Import_Budget_Amendment_Request)
		{
			return ((Financial_ManagementPort)this).Import_Budget_Amendment(new Import_Budget_AmendmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Budget_Amendment_Request = Import_Budget_Amendment_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_Budget_AmendmentAsync(Import_Budget_AmendmentInput request)
		{
			return base.Channel.Import_Budget_AmendmentAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_Budget_AmendmentAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_Amendment_RequestType Import_Budget_Amendment_Request)
		{
			return ((Financial_ManagementPort)this).Import_Budget_AmendmentAsync(new Import_Budget_AmendmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Budget_Amendment_Request = Import_Budget_Amendment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Position_Budget(Import_Position_BudgetInput request)
		{
			return base.Channel.Import_Position_Budget(request);
		}

		public Put_Import_Process_ResponseType Import_Position_Budget(Workday_Common_HeaderType Workday_Common_Header, Import_Position_Budget_RequestType Import_Position_Budget_Request)
		{
			return ((Financial_ManagementPort)this).Import_Position_Budget(new Import_Position_BudgetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Position_Budget_Request = Import_Position_Budget_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_Position_BudgetAsync(Import_Position_BudgetInput request)
		{
			return base.Channel.Import_Position_BudgetAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_Position_BudgetAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Position_Budget_RequestType Import_Position_Budget_Request)
		{
			return ((Financial_ManagementPort)this).Import_Position_BudgetAsync(new Import_Position_BudgetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Position_Budget_Request = Import_Position_Budget_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Budget(Import_BudgetInput request)
		{
			return base.Channel.Import_Budget(request);
		}

		public Put_Import_Process_ResponseType Import_Budget(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_High_Volume_RequestType Import_Budget_High_Volume_Request)
		{
			return ((Financial_ManagementPort)this).Import_Budget(new Import_BudgetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Budget_High_Volume_Request = Import_Budget_High_Volume_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_BudgetAsync(Import_BudgetInput request)
		{
			return base.Channel.Import_BudgetAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_BudgetAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Budget_High_Volume_RequestType Import_Budget_High_Volume_Request)
		{
			return ((Financial_ManagementPort)this).Import_BudgetAsync(new Import_BudgetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Budget_High_Volume_Request = Import_Budget_High_Volume_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Statistic(Import_StatisticInput request)
		{
			return base.Channel.Import_Statistic(request);
		}

		public Put_Import_Process_ResponseType Import_Statistic(Workday_Common_HeaderType Workday_Common_Header, Import_Statistic_RequestType Import_Statistic_Request)
		{
			return ((Financial_ManagementPort)this).Import_Statistic(new Import_StatisticInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Statistic_Request = Import_Statistic_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_StatisticAsync(Import_StatisticInput request)
		{
			return base.Channel.Import_StatisticAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_StatisticAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Statistic_RequestType Import_Statistic_Request)
		{
			return ((Financial_ManagementPort)this).Import_StatisticAsync(new Import_StatisticInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Statistic_Request = Import_Statistic_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Headcount_Plan(Import_Headcount_PlanInput request)
		{
			return base.Channel.Import_Headcount_Plan(request);
		}

		public Put_Import_Process_ResponseType Import_Headcount_Plan(Workday_Common_HeaderType Workday_Common_Header, Import_Headcount_Plan_High_Volume_RequestType Import_Headcount_Plan_High_Volume_Request)
		{
			return ((Financial_ManagementPort)this).Import_Headcount_Plan(new Import_Headcount_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Headcount_Plan_High_Volume_Request = Import_Headcount_Plan_High_Volume_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_Headcount_PlanAsync(Import_Headcount_PlanInput request)
		{
			return base.Channel.Import_Headcount_PlanAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_Headcount_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Headcount_Plan_High_Volume_RequestType Import_Headcount_Plan_High_Volume_Request)
		{
			return ((Financial_ManagementPort)this).Import_Headcount_PlanAsync(new Import_Headcount_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Headcount_Plan_High_Volume_Request = Import_Headcount_Plan_High_Volume_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Accounting_JournalOutput Financial_ManagementPort.Import_Currency_Conversion_Rates(Import_Currency_Conversion_RatesInput request)
		{
			return base.Channel.Import_Currency_Conversion_Rates(request);
		}

		public Put_Import_Process_ResponseType Import_Currency_Conversion_Rates(Workday_Common_HeaderType Workday_Common_Header, Import_Currency_Conversion_Rates_RequestType Import_Currency_Conversion_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Import_Currency_Conversion_Rates(new Import_Currency_Conversion_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Currency_Conversion_Rates_Request = Import_Currency_Conversion_Rates_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Accounting_JournalOutput> Financial_ManagementPort.Import_Currency_Conversion_RatesAsync(Import_Currency_Conversion_RatesInput request)
		{
			return base.Channel.Import_Currency_Conversion_RatesAsync(request);
		}

		public Task<Import_Accounting_JournalOutput> Import_Currency_Conversion_RatesAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Currency_Conversion_Rates_RequestType Import_Currency_Conversion_Rates_Request)
		{
			return ((Financial_ManagementPort)this).Import_Currency_Conversion_RatesAsync(new Import_Currency_Conversion_RatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Currency_Conversion_Rates_Request = Import_Currency_Conversion_Rates_Request
			});
		}
	}
}
