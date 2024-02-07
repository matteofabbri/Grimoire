using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Cash_ManagementPortClient : ClientBase<Cash_ManagementPort>, Cash_ManagementPort
	{
		public Cash_ManagementPortClient()
		{
		}

		public Cash_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Cash_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Cash_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Cash_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Ad_Hoc_Bank_TransactionOutput Cash_ManagementPort.Submit_Ad_Hoc_Bank_Transaction(Submit_Ad_Hoc_Bank_TransactionInput request)
		{
			return base.Channel.Submit_Ad_Hoc_Bank_Transaction(request);
		}

		public Submit_Ad_hoc_Bank_Transaction_ResponseType Submit_Ad_Hoc_Bank_Transaction(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_hoc_Bank_Transaction_RequestType Submit_Ad_hoc_Bank_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Ad_Hoc_Bank_Transaction(new Submit_Ad_Hoc_Bank_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_hoc_Bank_Transaction_Request = Submit_Ad_hoc_Bank_Transaction_Request
			}).Submit_Ad_hoc_Bank_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Ad_Hoc_Bank_TransactionOutput> Cash_ManagementPort.Submit_Ad_Hoc_Bank_TransactionAsync(Submit_Ad_Hoc_Bank_TransactionInput request)
		{
			return base.Channel.Submit_Ad_Hoc_Bank_TransactionAsync(request);
		}

		public Task<Submit_Ad_Hoc_Bank_TransactionOutput> Submit_Ad_Hoc_Bank_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_hoc_Bank_Transaction_RequestType Submit_Ad_hoc_Bank_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Ad_Hoc_Bank_TransactionAsync(new Submit_Ad_Hoc_Bank_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_hoc_Bank_Transaction_Request = Submit_Ad_hoc_Bank_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Bank_AccountsOutput Cash_ManagementPort.Get_Bank_Accounts(Get_Bank_AccountsInput request)
		{
			return base.Channel.Get_Bank_Accounts(request);
		}

		public Get_Bank_Accounts_ResponseType Get_Bank_Accounts(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Accounts_RequestType Get_Bank_Accounts_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Accounts(new Get_Bank_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Accounts_Request = Get_Bank_Accounts_Request
			}).Get_Bank_Accounts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Bank_AccountsOutput> Cash_ManagementPort.Get_Bank_AccountsAsync(Get_Bank_AccountsInput request)
		{
			return base.Channel.Get_Bank_AccountsAsync(request);
		}

		public Task<Get_Bank_AccountsOutput> Get_Bank_AccountsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Accounts_RequestType Get_Bank_Accounts_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_AccountsAsync(new Get_Bank_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Accounts_Request = Get_Bank_Accounts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Bank_AccountOutput Cash_ManagementPort.Put_Bank_Account(Put_Bank_AccountInput request)
		{
			return base.Channel.Put_Bank_Account(request);
		}

		public Put_Bank_Account_ResponseType Put_Bank_Account(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Account_RequestType Put_Bank_Account_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Account(new Put_Bank_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Account_Request = Put_Bank_Account_Request
			}).Put_Bank_Account_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Bank_AccountOutput> Cash_ManagementPort.Put_Bank_AccountAsync(Put_Bank_AccountInput request)
		{
			return base.Channel.Put_Bank_AccountAsync(request);
		}

		public Task<Put_Bank_AccountOutput> Put_Bank_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Account_RequestType Put_Bank_Account_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_AccountAsync(new Put_Bank_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Account_Request = Put_Bank_Account_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Financial_InstitutionsOutput Cash_ManagementPort.Get_Financial_Institutions(Get_Financial_InstitutionsInput request)
		{
			return base.Channel.Get_Financial_Institutions(request);
		}

		public Get_Financial_Institutions_ResponseType Get_Financial_Institutions(Workday_Common_HeaderType Workday_Common_Header, Get_Financial_Institutions_RequestType Get_Financial_Institutions_Request)
		{
			return ((Cash_ManagementPort)this).Get_Financial_Institutions(new Get_Financial_InstitutionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Financial_Institutions_Request = Get_Financial_Institutions_Request
			}).Get_Financial_Institutions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Financial_InstitutionsOutput> Cash_ManagementPort.Get_Financial_InstitutionsAsync(Get_Financial_InstitutionsInput request)
		{
			return base.Channel.Get_Financial_InstitutionsAsync(request);
		}

		public Task<Get_Financial_InstitutionsOutput> Get_Financial_InstitutionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Financial_Institutions_RequestType Get_Financial_Institutions_Request)
		{
			return ((Cash_ManagementPort)this).Get_Financial_InstitutionsAsync(new Get_Financial_InstitutionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Financial_Institutions_Request = Get_Financial_Institutions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Financial_InstitutionOutput Cash_ManagementPort.Put_Financial_Institution(Put_Financial_InstitutionInput request)
		{
			return base.Channel.Put_Financial_Institution(request);
		}

		public Put_Financial_Institution_ResponseType Put_Financial_Institution(Workday_Common_HeaderType Workday_Common_Header, Put_Financial_Institution_RequestType Put_Financial_Institution_Request)
		{
			return ((Cash_ManagementPort)this).Put_Financial_Institution(new Put_Financial_InstitutionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Financial_Institution_Request = Put_Financial_Institution_Request
			}).Put_Financial_Institution_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Financial_InstitutionOutput> Cash_ManagementPort.Put_Financial_InstitutionAsync(Put_Financial_InstitutionInput request)
		{
			return base.Channel.Put_Financial_InstitutionAsync(request);
		}

		public Task<Put_Financial_InstitutionOutput> Put_Financial_InstitutionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Financial_Institution_RequestType Put_Financial_Institution_Request)
		{
			return ((Cash_ManagementPort)this).Put_Financial_InstitutionAsync(new Put_Financial_InstitutionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Financial_Institution_Request = Put_Financial_Institution_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Bank_BranchesOutput Cash_ManagementPort.Get_Bank_Branches(Get_Bank_BranchesInput request)
		{
			return base.Channel.Get_Bank_Branches(request);
		}

		public Get_Bank_Branches_ResponseType Get_Bank_Branches(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Branches_RequestType Get_Bank_Branches_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Branches(new Get_Bank_BranchesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Branches_Request = Get_Bank_Branches_Request
			}).Get_Bank_Branches_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Bank_BranchesOutput> Cash_ManagementPort.Get_Bank_BranchesAsync(Get_Bank_BranchesInput request)
		{
			return base.Channel.Get_Bank_BranchesAsync(request);
		}

		public Task<Get_Bank_BranchesOutput> Get_Bank_BranchesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Branches_RequestType Get_Bank_Branches_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_BranchesAsync(new Get_Bank_BranchesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Branches_Request = Get_Bank_Branches_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Bank_BranchOutput Cash_ManagementPort.Put_Bank_Branch(Put_Bank_BranchInput request)
		{
			return base.Channel.Put_Bank_Branch(request);
		}

		public Put_Bank_Branch_ResponseType Put_Bank_Branch(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Branch_RequestType Put_Bank_Branch_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Branch(new Put_Bank_BranchInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Branch_Request = Put_Bank_Branch_Request
			}).Put_Bank_Branch_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Bank_BranchOutput> Cash_ManagementPort.Put_Bank_BranchAsync(Put_Bank_BranchInput request)
		{
			return base.Channel.Put_Bank_BranchAsync(request);
		}

		public Task<Put_Bank_BranchOutput> Put_Bank_BranchAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Branch_RequestType Put_Bank_Branch_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_BranchAsync(new Put_Bank_BranchInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Branch_Request = Put_Bank_Branch_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Petty_Cash_AccountsOutput Cash_ManagementPort.Get_Petty_Cash_Accounts(Get_Petty_Cash_AccountsInput request)
		{
			return base.Channel.Get_Petty_Cash_Accounts(request);
		}

		public Get_Petty_Cash_Accounts_ResponseType Get_Petty_Cash_Accounts(Workday_Common_HeaderType Workday_Common_Header, Get_Petty_Cash_Accounts_RequestType Get_Petty_Cash_Accounts_Request)
		{
			return ((Cash_ManagementPort)this).Get_Petty_Cash_Accounts(new Get_Petty_Cash_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Petty_Cash_Accounts_Request = Get_Petty_Cash_Accounts_Request
			}).Get_Petty_Cash_Accounts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Petty_Cash_AccountsOutput> Cash_ManagementPort.Get_Petty_Cash_AccountsAsync(Get_Petty_Cash_AccountsInput request)
		{
			return base.Channel.Get_Petty_Cash_AccountsAsync(request);
		}

		public Task<Get_Petty_Cash_AccountsOutput> Get_Petty_Cash_AccountsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Petty_Cash_Accounts_RequestType Get_Petty_Cash_Accounts_Request)
		{
			return ((Cash_ManagementPort)this).Get_Petty_Cash_AccountsAsync(new Get_Petty_Cash_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Petty_Cash_Accounts_Request = Get_Petty_Cash_Accounts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Petty_Cash_AccountOutput Cash_ManagementPort.Put_Petty_Cash_Account(Put_Petty_Cash_AccountInput request)
		{
			return base.Channel.Put_Petty_Cash_Account(request);
		}

		public Put_Petty_Cash_Account_ResponseType Put_Petty_Cash_Account(Workday_Common_HeaderType Workday_Common_Header, Put_Petty_Cash_Account_RequestType Put_Petty_Cash_Account_Request)
		{
			return ((Cash_ManagementPort)this).Put_Petty_Cash_Account(new Put_Petty_Cash_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Petty_Cash_Account_Request = Put_Petty_Cash_Account_Request
			}).Put_Petty_Cash_Account_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Petty_Cash_AccountOutput> Cash_ManagementPort.Put_Petty_Cash_AccountAsync(Put_Petty_Cash_AccountInput request)
		{
			return base.Channel.Put_Petty_Cash_AccountAsync(request);
		}

		public Task<Put_Petty_Cash_AccountOutput> Put_Petty_Cash_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Petty_Cash_Account_RequestType Put_Petty_Cash_Account_Request)
		{
			return ((Cash_ManagementPort)this).Put_Petty_Cash_AccountAsync(new Put_Petty_Cash_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Petty_Cash_Account_Request = Put_Petty_Cash_Account_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Ad_Hoc_Bank_TransactionOutput Cash_ManagementPort.Cancel_Ad_Hoc_Bank_Transaction(Cancel_Ad_Hoc_Bank_TransactionInput request)
		{
			return base.Channel.Cancel_Ad_Hoc_Bank_Transaction(request);
		}

		public Cancel_Ad_hoc_Bank_Transaction_ResponseType Cancel_Ad_Hoc_Bank_Transaction(Workday_Common_HeaderType Workday_Common_Header, Cancel_Ad_hoc_Bank_Transaction_RequestType Cancel_Ad_hoc_Bank_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Ad_Hoc_Bank_Transaction(new Cancel_Ad_Hoc_Bank_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Ad_hoc_Bank_Transaction_Request = Cancel_Ad_hoc_Bank_Transaction_Request
			}).Cancel_Ad_hoc_Bank_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Ad_Hoc_Bank_TransactionOutput> Cash_ManagementPort.Cancel_Ad_Hoc_Bank_TransactionAsync(Cancel_Ad_Hoc_Bank_TransactionInput request)
		{
			return base.Channel.Cancel_Ad_Hoc_Bank_TransactionAsync(request);
		}

		public Task<Cancel_Ad_Hoc_Bank_TransactionOutput> Cancel_Ad_Hoc_Bank_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Ad_hoc_Bank_Transaction_RequestType Cancel_Ad_hoc_Bank_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Ad_Hoc_Bank_TransactionAsync(new Cancel_Ad_Hoc_Bank_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Ad_hoc_Bank_Transaction_Request = Cancel_Ad_hoc_Bank_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_Entity_ContactsOutput Cash_ManagementPort.Get_Business_Entity_Contacts(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_Contacts(request);
		}

		public Get_Business_Entity_Contacts_ResponseType Get_Business_Entity_Contacts(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Cash_ManagementPort)this).Get_Business_Entity_Contacts(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			}).Get_Business_Entity_Contacts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_Entity_ContactsOutput> Cash_ManagementPort.Get_Business_Entity_ContactsAsync(Get_Business_Entity_ContactsInput request)
		{
			return base.Channel.Get_Business_Entity_ContactsAsync(request);
		}

		public Task<Get_Business_Entity_ContactsOutput> Get_Business_Entity_ContactsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Business_Entity_Contacts_RequestType Get_Business_Entity_Contacts_Request)
		{
			return ((Cash_ManagementPort)this).Get_Business_Entity_ContactsAsync(new Get_Business_Entity_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Business_Entity_Contacts_Request = Get_Business_Entity_Contacts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Business_Entity_ContactOutput Cash_ManagementPort.Put_Business_Entity_Contact(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_Contact(request);
		}

		public Put_Business_Entity_Contact_ResponseType Put_Business_Entity_Contact(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Cash_ManagementPort)this).Put_Business_Entity_Contact(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			}).Put_Business_Entity_Contact_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Business_Entity_ContactOutput> Cash_ManagementPort.Put_Business_Entity_ContactAsync(Put_Business_Entity_ContactInput request)
		{
			return base.Channel.Put_Business_Entity_ContactAsync(request);
		}

		public Task<Put_Business_Entity_ContactOutput> Put_Business_Entity_ContactAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			return ((Cash_ManagementPort)this).Put_Business_Entity_ContactAsync(new Put_Business_Entity_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_Election_EnrollmentsOutput Cash_ManagementPort.Get_Payment_Election_Enrollments(Get_Payment_Election_EnrollmentsInput request)
		{
			return base.Channel.Get_Payment_Election_Enrollments(request);
		}

		public Get_Payment_Election_Enrollments_ResponseType Get_Payment_Election_Enrollments(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Election_Enrollments_RequestType Get_Payment_Election_Enrollments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payment_Election_Enrollments(new Get_Payment_Election_EnrollmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Election_Enrollments_Request = Get_Payment_Election_Enrollments_Request
			}).Get_Payment_Election_Enrollments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_Election_EnrollmentsOutput> Cash_ManagementPort.Get_Payment_Election_EnrollmentsAsync(Get_Payment_Election_EnrollmentsInput request)
		{
			return base.Channel.Get_Payment_Election_EnrollmentsAsync(request);
		}

		public Task<Get_Payment_Election_EnrollmentsOutput> Get_Payment_Election_EnrollmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Election_Enrollments_RequestType Get_Payment_Election_Enrollments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payment_Election_EnrollmentsAsync(new Get_Payment_Election_EnrollmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Election_Enrollments_Request = Get_Payment_Election_Enrollments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Payment_Election_EnrollmentOutput Cash_ManagementPort.Submit_Payment_Election_Enrollment(Submit_Payment_Election_EnrollmentInput request)
		{
			return base.Channel.Submit_Payment_Election_Enrollment(request);
		}

		public Put_Payment_Election_Enrollment_ResponseType Submit_Payment_Election_Enrollment(Workday_Common_HeaderType Workday_Common_Header, Submit_Payment_Election_Enrollment_RequestType Submit_Payment_Election_Enrollment_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Payment_Election_Enrollment(new Submit_Payment_Election_EnrollmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Payment_Election_Enrollment_Request = Submit_Payment_Election_Enrollment_Request
			}).Put_Payment_Election_Enrollment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Payment_Election_EnrollmentOutput> Cash_ManagementPort.Submit_Payment_Election_EnrollmentAsync(Submit_Payment_Election_EnrollmentInput request)
		{
			return base.Channel.Submit_Payment_Election_EnrollmentAsync(request);
		}

		public Task<Submit_Payment_Election_EnrollmentOutput> Submit_Payment_Election_EnrollmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Payment_Election_Enrollment_RequestType Submit_Payment_Election_Enrollment_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Payment_Election_EnrollmentAsync(new Submit_Payment_Election_EnrollmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Payment_Election_Enrollment_Request = Submit_Payment_Election_Enrollment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Ad_Hoc_Bank_TransactionsOutput Cash_ManagementPort.Get_Ad_Hoc_Bank_Transactions(Get_Ad_Hoc_Bank_TransactionsInput request)
		{
			return base.Channel.Get_Ad_Hoc_Bank_Transactions(request);
		}

		public Get_Ad_hoc_Bank_Transactions_ResponseType Get_Ad_Hoc_Bank_Transactions(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_hoc_Bank_Transactions_RequestType Get_Ad_hoc_Bank_Transactions_Request)
		{
			return ((Cash_ManagementPort)this).Get_Ad_Hoc_Bank_Transactions(new Get_Ad_Hoc_Bank_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_hoc_Bank_Transactions_Request = Get_Ad_hoc_Bank_Transactions_Request
			}).Get_Ad_hoc_Bank_Transactions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Ad_Hoc_Bank_TransactionsOutput> Cash_ManagementPort.Get_Ad_Hoc_Bank_TransactionsAsync(Get_Ad_Hoc_Bank_TransactionsInput request)
		{
			return base.Channel.Get_Ad_Hoc_Bank_TransactionsAsync(request);
		}

		public Task<Get_Ad_Hoc_Bank_TransactionsOutput> Get_Ad_Hoc_Bank_TransactionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_hoc_Bank_Transactions_RequestType Get_Ad_hoc_Bank_Transactions_Request)
		{
			return ((Cash_ManagementPort)this).Get_Ad_Hoc_Bank_TransactionsAsync(new Get_Ad_Hoc_Bank_TransactionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_hoc_Bank_Transactions_Request = Get_Ad_hoc_Bank_Transactions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payment_Acknowledgement_MessageOutput Cash_ManagementPort.Put_Payment_Acknowledgement_Message(Put_Payment_Acknowledgement_MessageInput request)
		{
			return base.Channel.Put_Payment_Acknowledgement_Message(request);
		}

		public Put_Payment_Acknowledgement_Message_ResponseType Put_Payment_Acknowledgement_Message(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Acknowledgement_Message_RequestType Put_Payment_Acknowledgement_Message_Request)
		{
			return ((Cash_ManagementPort)this).Put_Payment_Acknowledgement_Message(new Put_Payment_Acknowledgement_MessageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Acknowledgement_Message_Request = Put_Payment_Acknowledgement_Message_Request
			}).Put_Payment_Acknowledgement_Message_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payment_Acknowledgement_MessageOutput> Cash_ManagementPort.Put_Payment_Acknowledgement_MessageAsync(Put_Payment_Acknowledgement_MessageInput request)
		{
			return base.Channel.Put_Payment_Acknowledgement_MessageAsync(request);
		}

		public Task<Put_Payment_Acknowledgement_MessageOutput> Put_Payment_Acknowledgement_MessageAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Acknowledgement_Message_RequestType Put_Payment_Acknowledgement_Message_Request)
		{
			return ((Cash_ManagementPort)this).Put_Payment_Acknowledgement_MessageAsync(new Put_Payment_Acknowledgement_MessageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Acknowledgement_Message_Request = Put_Payment_Acknowledgement_Message_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Ad_Hoc_PaymentsOutput Cash_ManagementPort.Get_Ad_Hoc_Payments(Get_Ad_Hoc_PaymentsInput request)
		{
			return base.Channel.Get_Ad_Hoc_Payments(request);
		}

		public Get_Ad_hoc_Payments_ResponseType Get_Ad_Hoc_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_hoc_Payments_RequestType Get_Ad_hoc_Payments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Ad_Hoc_Payments(new Get_Ad_Hoc_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_hoc_Payments_Request = Get_Ad_hoc_Payments_Request
			}).Get_Ad_hoc_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Ad_Hoc_PaymentsOutput> Cash_ManagementPort.Get_Ad_Hoc_PaymentsAsync(Get_Ad_Hoc_PaymentsInput request)
		{
			return base.Channel.Get_Ad_Hoc_PaymentsAsync(request);
		}

		public Task<Get_Ad_Hoc_PaymentsOutput> Get_Ad_Hoc_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_hoc_Payments_RequestType Get_Ad_hoc_Payments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Ad_Hoc_PaymentsAsync(new Get_Ad_Hoc_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_hoc_Payments_Request = Get_Ad_hoc_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Ad_Hoc_PaymentOutput Cash_ManagementPort.Submit_Ad_Hoc_Payment(Submit_Ad_Hoc_PaymentInput request)
		{
			return base.Channel.Submit_Ad_Hoc_Payment(request);
		}

		public Submit_Ad_hoc_Payment_ResponseType Submit_Ad_Hoc_Payment(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_hoc_Payment_RequestType Submit_Ad_hoc_Payment_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Ad_Hoc_Payment(new Submit_Ad_Hoc_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_hoc_Payment_Request = Submit_Ad_hoc_Payment_Request
			}).Submit_Ad_hoc_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Ad_Hoc_PaymentOutput> Cash_ManagementPort.Submit_Ad_Hoc_PaymentAsync(Submit_Ad_Hoc_PaymentInput request)
		{
			return base.Channel.Submit_Ad_Hoc_PaymentAsync(request);
		}

		public Task<Submit_Ad_Hoc_PaymentOutput> Submit_Ad_Hoc_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_hoc_Payment_RequestType Submit_Ad_hoc_Payment_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Ad_Hoc_PaymentAsync(new Submit_Ad_Hoc_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Ad_hoc_Payment_Request = Submit_Ad_hoc_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Ad_Hoc_PaymentOutput Cash_ManagementPort.Cancel_Ad_Hoc_Payment(Cancel_Ad_Hoc_PaymentInput request)
		{
			return base.Channel.Cancel_Ad_Hoc_Payment(request);
		}

		public Cancel_Ad_hoc_Payment_ResponseType Cancel_Ad_Hoc_Payment(Workday_Common_HeaderType Workday_Common_Header, Cancel_Ad_hoc_Payment_RequestType Cancel_Ad_hoc_Payment_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Ad_Hoc_Payment(new Cancel_Ad_Hoc_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Ad_hoc_Payment_Request = Cancel_Ad_hoc_Payment_Request
			}).Cancel_Ad_hoc_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Ad_Hoc_PaymentOutput> Cash_ManagementPort.Cancel_Ad_Hoc_PaymentAsync(Cancel_Ad_Hoc_PaymentInput request)
		{
			return base.Channel.Cancel_Ad_Hoc_PaymentAsync(request);
		}

		public Task<Cancel_Ad_Hoc_PaymentOutput> Cancel_Ad_Hoc_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Ad_hoc_Payment_RequestType Cancel_Ad_hoc_Payment_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Ad_Hoc_PaymentAsync(new Cancel_Ad_Hoc_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Ad_hoc_Payment_Request = Cancel_Ad_hoc_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PaymentsOutput Cash_ManagementPort.Get_Payments(Get_PaymentsInput request)
		{
			return base.Channel.Get_Payments(request);
		}

		public Get_Payments_ResponseType Get_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Payments_RequestType Get_Payments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payments(new Get_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payments_Request = Get_Payments_Request
			}).Get_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PaymentsOutput> Cash_ManagementPort.Get_PaymentsAsync(Get_PaymentsInput request)
		{
			return base.Channel.Get_PaymentsAsync(request);
		}

		public Task<Get_PaymentsOutput> Get_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payments_RequestType Get_Payments_Request)
		{
			return ((Cash_ManagementPort)this).Get_PaymentsAsync(new Get_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payments_Request = Get_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_MessagesOutput Cash_ManagementPort.Get_Payment_Messages(Get_Payment_MessagesInput request)
		{
			return base.Channel.Get_Payment_Messages(request);
		}

		public Get_Payment_Messages_ResponseType Get_Payment_Messages(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Messages_RequestType Get_Payment_Messages_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payment_Messages(new Get_Payment_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Messages_Request = Get_Payment_Messages_Request
			}).Get_Payment_Messages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_MessagesOutput> Cash_ManagementPort.Get_Payment_MessagesAsync(Get_Payment_MessagesInput request)
		{
			return base.Channel.Get_Payment_MessagesAsync(request);
		}

		public Task<Get_Payment_MessagesOutput> Get_Payment_MessagesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Messages_RequestType Get_Payment_Messages_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payment_MessagesAsync(new Get_Payment_MessagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Messages_Request = Get_Payment_Messages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payment_Election_OptionsOutput Cash_ManagementPort.Get_Payment_Election_Options(Get_Payment_Election_OptionsInput request)
		{
			return base.Channel.Get_Payment_Election_Options(request);
		}

		public Get_Payment_Election_Options_ResponseType Get_Payment_Election_Options(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Election_Options_RequestType Get_Payment_Election_Options_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payment_Election_Options(new Get_Payment_Election_OptionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Election_Options_Request = Get_Payment_Election_Options_Request
			}).Get_Payment_Election_Options_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payment_Election_OptionsOutput> Cash_ManagementPort.Get_Payment_Election_OptionsAsync(Get_Payment_Election_OptionsInput request)
		{
			return base.Channel.Get_Payment_Election_OptionsAsync(request);
		}

		public Task<Get_Payment_Election_OptionsOutput> Get_Payment_Election_OptionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Election_Options_RequestType Get_Payment_Election_Options_Request)
		{
			return ((Cash_ManagementPort)this).Get_Payment_Election_OptionsAsync(new Get_Payment_Election_OptionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payment_Election_Options_Request = Get_Payment_Election_Options_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payment_Election_OptionOutput Cash_ManagementPort.Put_Payment_Election_Option(Put_Payment_Election_OptionInput request)
		{
			return base.Channel.Put_Payment_Election_Option(request);
		}

		public Put_Payment_Election_Option_ResponseType Put_Payment_Election_Option(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Election_Option_RequestType Put_Payment_Election_Option_Request)
		{
			return ((Cash_ManagementPort)this).Put_Payment_Election_Option(new Put_Payment_Election_OptionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Election_Option_Request = Put_Payment_Election_Option_Request
			}).Put_Payment_Election_Option_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payment_Election_OptionOutput> Cash_ManagementPort.Put_Payment_Election_OptionAsync(Put_Payment_Election_OptionInput request)
		{
			return base.Channel.Put_Payment_Election_OptionAsync(request);
		}

		public Task<Put_Payment_Election_OptionOutput> Put_Payment_Election_OptionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Election_Option_RequestType Put_Payment_Election_Option_Request)
		{
			return ((Cash_ManagementPort)this).Put_Payment_Election_OptionAsync(new Put_Payment_Election_OptionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payment_Election_Option_Request = Put_Payment_Election_Option_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Bank_Statement_FileOutput Cash_ManagementPort.Put_Bank_Statement_File(Put_Bank_Statement_FileInput request)
		{
			return base.Channel.Put_Bank_Statement_File(request);
		}

		public Put_Bank_Statement_File_ResponseType Put_Bank_Statement_File(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_File_RequestType Put_Bank_Statement_File_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Statement_File(new Put_Bank_Statement_FileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Statement_File_Request = Put_Bank_Statement_File_Request
			}).Put_Bank_Statement_File_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Bank_Statement_FileOutput> Cash_ManagementPort.Put_Bank_Statement_FileAsync(Put_Bank_Statement_FileInput request)
		{
			return base.Channel.Put_Bank_Statement_FileAsync(request);
		}

		public Task<Put_Bank_Statement_FileOutput> Put_Bank_Statement_FileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_File_RequestType Put_Bank_Statement_File_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Statement_FileAsync(new Put_Bank_Statement_FileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Statement_File_Request = Put_Bank_Statement_File_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Bank_StatementOutput Cash_ManagementPort.Put_Bank_Statement(Put_Bank_StatementInput request)
		{
			return base.Channel.Put_Bank_Statement(request);
		}

		public Put_Bank_Statement_ResponseType Put_Bank_Statement(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_RequestType Put_Bank_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Statement(new Put_Bank_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Statement_Request = Put_Bank_Statement_Request
			}).Put_Bank_Statement_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Bank_StatementOutput> Cash_ManagementPort.Put_Bank_StatementAsync(Put_Bank_StatementInput request)
		{
			return base.Channel.Put_Bank_StatementAsync(request);
		}

		public Task<Put_Bank_StatementOutput> Put_Bank_StatementAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_RequestType Put_Bank_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_StatementAsync(new Put_Bank_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Statement_Request = Put_Bank_Statement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Bank_Statement_FilesOutput Cash_ManagementPort.Get_Bank_Statement_Files(Get_Bank_Statement_FilesInput request)
		{
			return base.Channel.Get_Bank_Statement_Files(request);
		}

		public Get_Bank_Statement_Files_ResponseType Get_Bank_Statement_Files(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statement_File_RequestType Get_Bank_Statement_File_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Statement_Files(new Get_Bank_Statement_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Statement_File_Request = Get_Bank_Statement_File_Request
			}).Get_Bank_Statement_Files_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Bank_Statement_FilesOutput> Cash_ManagementPort.Get_Bank_Statement_FilesAsync(Get_Bank_Statement_FilesInput request)
		{
			return base.Channel.Get_Bank_Statement_FilesAsync(request);
		}

		public Task<Get_Bank_Statement_FilesOutput> Get_Bank_Statement_FilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statement_File_RequestType Get_Bank_Statement_File_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Statement_FilesAsync(new Get_Bank_Statement_FilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Statement_File_Request = Get_Bank_Statement_File_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Bank_StatementsOutput Cash_ManagementPort.Get_Bank_Statements(Get_Bank_StatementsInput request)
		{
			return base.Channel.Get_Bank_Statements(request);
		}

		public Get_Bank_Statements_ResponseType Get_Bank_Statements(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statements_RequestType Get_Bank_Statements_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Statements(new Get_Bank_StatementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Statements_Request = Get_Bank_Statements_Request
			}).Get_Bank_Statements_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Bank_StatementsOutput> Cash_ManagementPort.Get_Bank_StatementsAsync(Get_Bank_StatementsInput request)
		{
			return base.Channel.Get_Bank_StatementsAsync(request);
		}

		public Task<Get_Bank_StatementsOutput> Get_Bank_StatementsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statements_RequestType Get_Bank_Statements_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_StatementsAsync(new Get_Bank_StatementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Statements_Request = Get_Bank_Statements_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_DonorsOutput Cash_ManagementPort.Get_Donors(Get_DonorsInput request)
		{
			return base.Channel.Get_Donors(request);
		}

		public Get_Donors_ResponseType Get_Donors(Workday_Common_HeaderType Workday_Common_Header, Get_Donors_RequestType Get_Donors_Request)
		{
			return ((Cash_ManagementPort)this).Get_Donors(new Get_DonorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Donors_Request = Get_Donors_Request
			}).Get_Donors_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_DonorsOutput> Cash_ManagementPort.Get_DonorsAsync(Get_DonorsInput request)
		{
			return base.Channel.Get_DonorsAsync(request);
		}

		public Task<Get_DonorsOutput> Get_DonorsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Donors_RequestType Get_Donors_Request)
		{
			return ((Cash_ManagementPort)this).Get_DonorsAsync(new Get_DonorsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Donors_Request = Get_Donors_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DonorOutput Cash_ManagementPort.Put_Donor(Put_DonorInput request)
		{
			return base.Channel.Put_Donor(request);
		}

		public Put_Donor_ResponseType Put_Donor(Workday_Common_HeaderType Workday_Common_Header, Put_Donor_RequestType Put_Donor_Request)
		{
			return ((Cash_ManagementPort)this).Put_Donor(new Put_DonorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Donor_Request = Put_Donor_Request
			}).Put_Donor_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DonorOutput> Cash_ManagementPort.Put_DonorAsync(Put_DonorInput request)
		{
			return base.Channel.Put_DonorAsync(request);
		}

		public Task<Put_DonorOutput> Put_DonorAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Donor_RequestType Put_Donor_Request)
		{
			return ((Cash_ManagementPort)this).Put_DonorAsync(new Put_DonorInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Donor_Request = Put_Donor_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Donor_ContributionsOutput Cash_ManagementPort.Get_Donor_Contributions(Get_Donor_ContributionsInput request)
		{
			return base.Channel.Get_Donor_Contributions(request);
		}

		public Get_Donor_Contributions_ResponseType Get_Donor_Contributions(Workday_Common_HeaderType Workday_Common_Header, Get_Donor_Contributions_RequestType Get_Donor_Contributions_Request)
		{
			return ((Cash_ManagementPort)this).Get_Donor_Contributions(new Get_Donor_ContributionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Donor_Contributions_Request = Get_Donor_Contributions_Request
			}).Get_Donor_Contributions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Donor_ContributionsOutput> Cash_ManagementPort.Get_Donor_ContributionsAsync(Get_Donor_ContributionsInput request)
		{
			return base.Channel.Get_Donor_ContributionsAsync(request);
		}

		public Task<Get_Donor_ContributionsOutput> Get_Donor_ContributionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Donor_Contributions_RequestType Get_Donor_Contributions_Request)
		{
			return ((Cash_ManagementPort)this).Get_Donor_ContributionsAsync(new Get_Donor_ContributionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Donor_Contributions_Request = Get_Donor_Contributions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Donor_ContributionOutput Cash_ManagementPort.Submit_Donor_Contribution(Submit_Donor_ContributionInput request)
		{
			return base.Channel.Submit_Donor_Contribution(request);
		}

		public Submit_Donor_Contribution_ResponseType Submit_Donor_Contribution(Workday_Common_HeaderType Workday_Common_Header, Submit_Donor_Contribution_RequestType Submit_Donor_Contribution_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Donor_Contribution(new Submit_Donor_ContributionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Donor_Contribution_Request = Submit_Donor_Contribution_Request
			}).Submit_Donor_Contribution_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Donor_ContributionOutput> Cash_ManagementPort.Submit_Donor_ContributionAsync(Submit_Donor_ContributionInput request)
		{
			return base.Channel.Submit_Donor_ContributionAsync(request);
		}

		public Task<Submit_Donor_ContributionOutput> Submit_Donor_ContributionAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Donor_Contribution_RequestType Submit_Donor_Contribution_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Donor_ContributionAsync(new Submit_Donor_ContributionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Donor_Contribution_Request = Submit_Donor_Contribution_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Investment_StatementsOutput Cash_ManagementPort.Get_Investment_Statements(Get_Investment_StatementsInput request)
		{
			return base.Channel.Get_Investment_Statements(request);
		}

		public Get_Investment_Statements_ResponseType Get_Investment_Statements(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Statements_RequestType Get_Investment_Statements_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Statements(new Get_Investment_StatementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Statements_Request = Get_Investment_Statements_Request
			}).Get_Investment_Statements_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Investment_StatementsOutput> Cash_ManagementPort.Get_Investment_StatementsAsync(Get_Investment_StatementsInput request)
		{
			return base.Channel.Get_Investment_StatementsAsync(request);
		}

		public Task<Get_Investment_StatementsOutput> Get_Investment_StatementsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Statements_RequestType Get_Investment_Statements_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_StatementsAsync(new Get_Investment_StatementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Statements_Request = Get_Investment_Statements_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Investment_StatementOutput Cash_ManagementPort.Submit_Investment_Statement(Submit_Investment_StatementInput request)
		{
			return base.Channel.Submit_Investment_Statement(request);
		}

		public Submit_Investment_Statement_ResponseType Submit_Investment_Statement(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Statement_RequestType Submit_Investment_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Statement(new Submit_Investment_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Statement_Request = Submit_Investment_Statement_Request
			}).Submit_Investment_Statement_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Investment_StatementOutput> Cash_ManagementPort.Submit_Investment_StatementAsync(Submit_Investment_StatementInput request)
		{
			return base.Channel.Submit_Investment_StatementAsync(request);
		}

		public Task<Submit_Investment_StatementOutput> Submit_Investment_StatementAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Statement_RequestType Submit_Investment_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_StatementAsync(new Submit_Investment_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Statement_Request = Submit_Investment_Statement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Investment_Pool_PurchasesOutput Cash_ManagementPort.Get_Investment_Pool_Purchases(Get_Investment_Pool_PurchasesInput request)
		{
			return base.Channel.Get_Investment_Pool_Purchases(request);
		}

		public Get_Investment_Pool_Purchases_ResponseType Get_Investment_Pool_Purchases(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Purchases_RequestType Get_Investment_Pool_Purchases_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_Purchases(new Get_Investment_Pool_PurchasesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Purchases_Request = Get_Investment_Pool_Purchases_Request
			}).Get_Investment_Pool_Purchases_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Investment_Pool_PurchasesOutput> Cash_ManagementPort.Get_Investment_Pool_PurchasesAsync(Get_Investment_Pool_PurchasesInput request)
		{
			return base.Channel.Get_Investment_Pool_PurchasesAsync(request);
		}

		public Task<Get_Investment_Pool_PurchasesOutput> Get_Investment_Pool_PurchasesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Purchases_RequestType Get_Investment_Pool_Purchases_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_PurchasesAsync(new Get_Investment_Pool_PurchasesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Purchases_Request = Get_Investment_Pool_Purchases_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Investment_Pool_PurchaseOutput Cash_ManagementPort.Submit_Investment_Pool_Purchase(Submit_Investment_Pool_PurchaseInput request)
		{
			return base.Channel.Submit_Investment_Pool_Purchase(request);
		}

		public Submit_Investment_Pool_Purchase_ResponseType Submit_Investment_Pool_Purchase(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Purchase_RequestType Submit_Investment_Pool_Purchase_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_Purchase(new Submit_Investment_Pool_PurchaseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Purchase_Request = Submit_Investment_Pool_Purchase_Request
			}).Submit_Investment_Pool_Purchase_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Investment_Pool_PurchaseOutput> Cash_ManagementPort.Submit_Investment_Pool_PurchaseAsync(Submit_Investment_Pool_PurchaseInput request)
		{
			return base.Channel.Submit_Investment_Pool_PurchaseAsync(request);
		}

		public Task<Submit_Investment_Pool_PurchaseOutput> Submit_Investment_Pool_PurchaseAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Purchase_RequestType Submit_Investment_Pool_Purchase_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_PurchaseAsync(new Submit_Investment_Pool_PurchaseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Purchase_Request = Submit_Investment_Pool_Purchase_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Investment_Pool_TransfersOutput Cash_ManagementPort.Get_Investment_Pool_Transfers(Get_Investment_Pool_TransfersInput request)
		{
			return base.Channel.Get_Investment_Pool_Transfers(request);
		}

		public Get_Investment_Pool_Transfers_ResponseType Get_Investment_Pool_Transfers(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Transfers_RequestType Get_Investment_Pool_Transfers_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_Transfers(new Get_Investment_Pool_TransfersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Transfers_Request = Get_Investment_Pool_Transfers_Request
			}).Get_Investment_Pool_Transfers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Investment_Pool_TransfersOutput> Cash_ManagementPort.Get_Investment_Pool_TransfersAsync(Get_Investment_Pool_TransfersInput request)
		{
			return base.Channel.Get_Investment_Pool_TransfersAsync(request);
		}

		public Task<Get_Investment_Pool_TransfersOutput> Get_Investment_Pool_TransfersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Transfers_RequestType Get_Investment_Pool_Transfers_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_TransfersAsync(new Get_Investment_Pool_TransfersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Transfers_Request = Get_Investment_Pool_Transfers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Ad_Hoc_PayeesOutput Cash_ManagementPort.Get_Ad_Hoc_Payees(Get_Ad_Hoc_PayeesInput request)
		{
			return base.Channel.Get_Ad_Hoc_Payees(request);
		}

		public Get_Ad_Hoc_Payees_ResponseType Get_Ad_Hoc_Payees(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_Hoc_Payees_RequestType Get_Ad_Hoc_Payees_Request)
		{
			return ((Cash_ManagementPort)this).Get_Ad_Hoc_Payees(new Get_Ad_Hoc_PayeesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_Hoc_Payees_Request = Get_Ad_Hoc_Payees_Request
			}).Get_Ad_Hoc_Payees_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Ad_Hoc_PayeesOutput> Cash_ManagementPort.Get_Ad_Hoc_PayeesAsync(Get_Ad_Hoc_PayeesInput request)
		{
			return base.Channel.Get_Ad_Hoc_PayeesAsync(request);
		}

		public Task<Get_Ad_Hoc_PayeesOutput> Get_Ad_Hoc_PayeesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_Hoc_Payees_RequestType Get_Ad_Hoc_Payees_Request)
		{
			return ((Cash_ManagementPort)this).Get_Ad_Hoc_PayeesAsync(new Get_Ad_Hoc_PayeesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_Hoc_Payees_Request = Get_Ad_Hoc_Payees_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Ad_Hoc_PayeeOutput Cash_ManagementPort.Put_Ad_Hoc_Payee(Put_Ad_Hoc_PayeeInput request)
		{
			return base.Channel.Put_Ad_Hoc_Payee(request);
		}

		public Put_Ad_Hoc_Payee_ResponseType Put_Ad_Hoc_Payee(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Payee_RequestType Put_Ad_Hoc_Payee_Request)
		{
			return ((Cash_ManagementPort)this).Put_Ad_Hoc_Payee(new Put_Ad_Hoc_PayeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ad_Hoc_Payee_Request = Put_Ad_Hoc_Payee_Request
			}).Put_Ad_Hoc_Payee_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Ad_Hoc_PayeeOutput> Cash_ManagementPort.Put_Ad_Hoc_PayeeAsync(Put_Ad_Hoc_PayeeInput request)
		{
			return base.Channel.Put_Ad_Hoc_PayeeAsync(request);
		}

		public Task<Put_Ad_Hoc_PayeeOutput> Put_Ad_Hoc_PayeeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Payee_RequestType Put_Ad_Hoc_Payee_Request)
		{
			return ((Cash_ManagementPort)this).Put_Ad_Hoc_PayeeAsync(new Put_Ad_Hoc_PayeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ad_Hoc_Payee_Request = Put_Ad_Hoc_Payee_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Investment_Pool_TransferOutput Cash_ManagementPort.Submit_Investment_Pool_Transfer(Submit_Investment_Pool_TransferInput request)
		{
			return base.Channel.Submit_Investment_Pool_Transfer(request);
		}

		public Submit_Investment_Pool_Transfer_ResponseType Submit_Investment_Pool_Transfer(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Transfer_RequestType Submit_Investment_Pool_Transfer_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_Transfer(new Submit_Investment_Pool_TransferInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Transfer_Request = Submit_Investment_Pool_Transfer_Request
			}).Submit_Investment_Pool_Transfer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Investment_Pool_TransferOutput> Cash_ManagementPort.Submit_Investment_Pool_TransferAsync(Submit_Investment_Pool_TransferInput request)
		{
			return base.Channel.Submit_Investment_Pool_TransferAsync(request);
		}

		public Task<Submit_Investment_Pool_TransferOutput> Submit_Investment_Pool_TransferAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Transfer_RequestType Submit_Investment_Pool_Transfer_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_TransferAsync(new Submit_Investment_Pool_TransferInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Transfer_Request = Submit_Investment_Pool_Transfer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Investment_Pool_SaleOutput Cash_ManagementPort.Submit_Investment_Pool_Sale(Submit_Investment_Pool_SaleInput request)
		{
			return base.Channel.Submit_Investment_Pool_Sale(request);
		}

		public Submit_Investment_Pool_Sale_ResponseType Submit_Investment_Pool_Sale(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Sale_RequestType Submit_Investment_Pool_Sale_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_Sale(new Submit_Investment_Pool_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Sale_Request = Submit_Investment_Pool_Sale_Request
			}).Submit_Investment_Pool_Sale_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Investment_Pool_SaleOutput> Cash_ManagementPort.Submit_Investment_Pool_SaleAsync(Submit_Investment_Pool_SaleInput request)
		{
			return base.Channel.Submit_Investment_Pool_SaleAsync(request);
		}

		public Task<Submit_Investment_Pool_SaleOutput> Submit_Investment_Pool_SaleAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Sale_RequestType Submit_Investment_Pool_Sale_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_SaleAsync(new Submit_Investment_Pool_SaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Sale_Request = Submit_Investment_Pool_Sale_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Investment_Pool_SalesOutput Cash_ManagementPort.Get_Investment_Pool_Sales(Get_Investment_Pool_SalesInput request)
		{
			return base.Channel.Get_Investment_Pool_Sales(request);
		}

		public Get_Investment_Pool_Sales_ResponseType Get_Investment_Pool_Sales(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Sales_RequestType Get_Investment_Pool_Sales_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_Sales(new Get_Investment_Pool_SalesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Sales_Request = Get_Investment_Pool_Sales_Request
			}).Get_Investment_Pool_Sales_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Investment_Pool_SalesOutput> Cash_ManagementPort.Get_Investment_Pool_SalesAsync(Get_Investment_Pool_SalesInput request)
		{
			return base.Channel.Get_Investment_Pool_SalesAsync(request);
		}

		public Task<Get_Investment_Pool_SalesOutput> Get_Investment_Pool_SalesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Sales_RequestType Get_Investment_Pool_Sales_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_SalesAsync(new Get_Investment_Pool_SalesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Sales_Request = Get_Investment_Pool_Sales_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Investment_Pool_AdjustmentOutput Cash_ManagementPort.Submit_Investment_Pool_Adjustment(Submit_Investment_Pool_AdjustmentInput request)
		{
			return base.Channel.Submit_Investment_Pool_Adjustment(request);
		}

		public Submit_Investment_Pool_Adjustment_ResponseType Submit_Investment_Pool_Adjustment(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Adjustment_RequestType Submit_Investment_Pool_Adjustment_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_Adjustment(new Submit_Investment_Pool_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Adjustment_Request = Submit_Investment_Pool_Adjustment_Request
			}).Submit_Investment_Pool_Adjustment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Investment_Pool_AdjustmentOutput> Cash_ManagementPort.Submit_Investment_Pool_AdjustmentAsync(Submit_Investment_Pool_AdjustmentInput request)
		{
			return base.Channel.Submit_Investment_Pool_AdjustmentAsync(request);
		}

		public Task<Submit_Investment_Pool_AdjustmentOutput> Submit_Investment_Pool_AdjustmentAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Adjustment_RequestType Submit_Investment_Pool_Adjustment_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Investment_Pool_AdjustmentAsync(new Submit_Investment_Pool_AdjustmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Investment_Pool_Adjustment_Request = Submit_Investment_Pool_Adjustment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Investment_Pool_AdjustmentsOutput Cash_ManagementPort.Get_Investment_Pool_Adjustments(Get_Investment_Pool_AdjustmentsInput request)
		{
			return base.Channel.Get_Investment_Pool_Adjustments(request);
		}

		public Get_Investment_Pool_Adjustments_ResponseType Get_Investment_Pool_Adjustments(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Adjustments_RequestType Get_Investment_Pool_Adjustments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_Adjustments(new Get_Investment_Pool_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Adjustments_Request = Get_Investment_Pool_Adjustments_Request
			}).Get_Investment_Pool_Adjustments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Investment_Pool_AdjustmentsOutput> Cash_ManagementPort.Get_Investment_Pool_AdjustmentsAsync(Get_Investment_Pool_AdjustmentsInput request)
		{
			return base.Channel.Get_Investment_Pool_AdjustmentsAsync(request);
		}

		public Task<Get_Investment_Pool_AdjustmentsOutput> Get_Investment_Pool_AdjustmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Investment_Pool_Adjustments_RequestType Get_Investment_Pool_Adjustments_Request)
		{
			return ((Cash_ManagementPort)this).Get_Investment_Pool_AdjustmentsAsync(new Get_Investment_Pool_AdjustmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Investment_Pool_Adjustments_Request = Get_Investment_Pool_Adjustments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Bank_Account_TransfersOutput Cash_ManagementPort.Get_Bank_Account_Transfers(Get_Bank_Account_TransfersInput request)
		{
			return base.Channel.Get_Bank_Account_Transfers(request);
		}

		public Get_Bank_Account_Transfers_ResponseType Get_Bank_Account_Transfers(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Account_Transfers_RequestType Get_Bank_Account_Transfers_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Account_Transfers(new Get_Bank_Account_TransfersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Account_Transfers_Request = Get_Bank_Account_Transfers_Request
			}).Get_Bank_Account_Transfers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Bank_Account_TransfersOutput> Cash_ManagementPort.Get_Bank_Account_TransfersAsync(Get_Bank_Account_TransfersInput request)
		{
			return base.Channel.Get_Bank_Account_TransfersAsync(request);
		}

		public Task<Get_Bank_Account_TransfersOutput> Get_Bank_Account_TransfersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Account_Transfers_RequestType Get_Bank_Account_Transfers_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Account_TransfersAsync(new Get_Bank_Account_TransfersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Account_Transfers_Request = Get_Bank_Account_Transfers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Bank_Account_TransferOutput Cash_ManagementPort.Submit_Bank_Account_Transfer(Submit_Bank_Account_TransferInput request)
		{
			return base.Channel.Submit_Bank_Account_Transfer(request);
		}

		public Submit_Bank_Account_Transfer_ResponseType Submit_Bank_Account_Transfer(Workday_Common_HeaderType Workday_Common_Header, Submit_Bank_Account_Transfer_RequestType Submit_Bank_Account_Transfer_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Bank_Account_Transfer(new Submit_Bank_Account_TransferInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Bank_Account_Transfer_Request = Submit_Bank_Account_Transfer_Request
			}).Submit_Bank_Account_Transfer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Bank_Account_TransferOutput> Cash_ManagementPort.Submit_Bank_Account_TransferAsync(Submit_Bank_Account_TransferInput request)
		{
			return base.Channel.Submit_Bank_Account_TransferAsync(request);
		}

		public Task<Submit_Bank_Account_TransferOutput> Submit_Bank_Account_TransferAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Bank_Account_Transfer_RequestType Submit_Bank_Account_Transfer_Request)
		{
			return ((Cash_ManagementPort)this).Submit_Bank_Account_TransferAsync(new Submit_Bank_Account_TransferInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Bank_Account_Transfer_Request = Submit_Bank_Account_Transfer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Bank_Statement_Custom_Code_SetsOutput Cash_ManagementPort.Get_Bank_Statement_Custom_Code_Sets(Get_Bank_Statement_Custom_Code_SetsInput request)
		{
			return base.Channel.Get_Bank_Statement_Custom_Code_Sets(request);
		}

		public Get_Bank_Statement_Custom_Code_Sets_ResponseType Get_Bank_Statement_Custom_Code_Sets(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statement_Custom_Code_Sets_RequestType Get_Bank_Statement_Custom_Code_Sets_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Statement_Custom_Code_Sets(new Get_Bank_Statement_Custom_Code_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Statement_Custom_Code_Sets_Request = Get_Bank_Statement_Custom_Code_Sets_Request
			}).Get_Bank_Statement_Custom_Code_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Bank_Statement_Custom_Code_SetsOutput> Cash_ManagementPort.Get_Bank_Statement_Custom_Code_SetsAsync(Get_Bank_Statement_Custom_Code_SetsInput request)
		{
			return base.Channel.Get_Bank_Statement_Custom_Code_SetsAsync(request);
		}

		public Task<Get_Bank_Statement_Custom_Code_SetsOutput> Get_Bank_Statement_Custom_Code_SetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Bank_Statement_Custom_Code_Sets_RequestType Get_Bank_Statement_Custom_Code_Sets_Request)
		{
			return ((Cash_ManagementPort)this).Get_Bank_Statement_Custom_Code_SetsAsync(new Get_Bank_Statement_Custom_Code_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Bank_Statement_Custom_Code_Sets_Request = Get_Bank_Statement_Custom_Code_Sets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Bank_Statement_Custom_Code_SetOutput Cash_ManagementPort.Put_Bank_Statement_Custom_Code_Set(Put_Bank_Statement_Custom_Code_SetInput request)
		{
			return base.Channel.Put_Bank_Statement_Custom_Code_Set(request);
		}

		public Put_Bank_Statement_Custom_Code_Set_ResponseType Put_Bank_Statement_Custom_Code_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_Custom_Code_Set_RequestType Put_Bank_Statement_Custom_Code_Set_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Statement_Custom_Code_Set(new Put_Bank_Statement_Custom_Code_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Statement_Custom_Code_Set_Request = Put_Bank_Statement_Custom_Code_Set_Request
			}).Put_Bank_Statement_Custom_Code_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Bank_Statement_Custom_Code_SetOutput> Cash_ManagementPort.Put_Bank_Statement_Custom_Code_SetAsync(Put_Bank_Statement_Custom_Code_SetInput request)
		{
			return base.Channel.Put_Bank_Statement_Custom_Code_SetAsync(request);
		}

		public Task<Put_Bank_Statement_Custom_Code_SetOutput> Put_Bank_Statement_Custom_Code_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Bank_Statement_Custom_Code_Set_RequestType Put_Bank_Statement_Custom_Code_Set_Request)
		{
			return ((Cash_ManagementPort)this).Put_Bank_Statement_Custom_Code_SetAsync(new Put_Bank_Statement_Custom_Code_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Bank_Statement_Custom_Code_Set_Request = Put_Bank_Statement_Custom_Code_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Intraday_Bank_StatementsOutput Cash_ManagementPort.Get_Intraday_Bank_Statements(Get_Intraday_Bank_StatementsInput request)
		{
			return base.Channel.Get_Intraday_Bank_Statements(request);
		}

		public Get_Intraday_Bank_Statements_ResponseType Get_Intraday_Bank_Statements(Workday_Common_HeaderType Workday_Common_Header, Get_Intraday_Bank_Statements_RequestType Get_Intraday_Bank_Statements_Request)
		{
			return ((Cash_ManagementPort)this).Get_Intraday_Bank_Statements(new Get_Intraday_Bank_StatementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Intraday_Bank_Statements_Request = Get_Intraday_Bank_Statements_Request
			}).Get_Intraday_Bank_Statements_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Intraday_Bank_StatementsOutput> Cash_ManagementPort.Get_Intraday_Bank_StatementsAsync(Get_Intraday_Bank_StatementsInput request)
		{
			return base.Channel.Get_Intraday_Bank_StatementsAsync(request);
		}

		public Task<Get_Intraday_Bank_StatementsOutput> Get_Intraday_Bank_StatementsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Intraday_Bank_Statements_RequestType Get_Intraday_Bank_Statements_Request)
		{
			return ((Cash_ManagementPort)this).Get_Intraday_Bank_StatementsAsync(new Get_Intraday_Bank_StatementsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Intraday_Bank_Statements_Request = Get_Intraday_Bank_Statements_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Investment_Pool_Catchup_Payout_CriteriaOutput Cash_ManagementPort.Put_Investment_Pool_Catchup_Payout_Criteria(Put_Investment_Pool_Catchup_Payout_CriteriaInput request)
		{
			return base.Channel.Put_Investment_Pool_Catchup_Payout_Criteria(request);
		}

		public Put_Investment_Pool_Catchup_Payout_Criteria_ResponseType Put_Investment_Pool_Catchup_Payout_Criteria(Workday_Common_HeaderType Workday_Common_Header, Put_Investment_Pool_Catchup_Payout_Criteria_RequestType Put_Investment_Pool_Catchup_Payout_Criteria_Request)
		{
			return ((Cash_ManagementPort)this).Put_Investment_Pool_Catchup_Payout_Criteria(new Put_Investment_Pool_Catchup_Payout_CriteriaInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Investment_Pool_Catchup_Payout_Criteria_Request = Put_Investment_Pool_Catchup_Payout_Criteria_Request
			}).Put_Investment_Pool_Catchup_Payout_Criteria_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Investment_Pool_Catchup_Payout_CriteriaOutput> Cash_ManagementPort.Put_Investment_Pool_Catchup_Payout_CriteriaAsync(Put_Investment_Pool_Catchup_Payout_CriteriaInput request)
		{
			return base.Channel.Put_Investment_Pool_Catchup_Payout_CriteriaAsync(request);
		}

		public Task<Put_Investment_Pool_Catchup_Payout_CriteriaOutput> Put_Investment_Pool_Catchup_Payout_CriteriaAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Investment_Pool_Catchup_Payout_Criteria_RequestType Put_Investment_Pool_Catchup_Payout_Criteria_Request)
		{
			return ((Cash_ManagementPort)this).Put_Investment_Pool_Catchup_Payout_CriteriaAsync(new Put_Investment_Pool_Catchup_Payout_CriteriaInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Investment_Pool_Catchup_Payout_Criteria_Request = Put_Investment_Pool_Catchup_Payout_Criteria_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Investment_Pool_TransactionOutput Cash_ManagementPort.Cancel_Investment_Pool_Transaction(Cancel_Investment_Pool_TransactionInput request)
		{
			return base.Channel.Cancel_Investment_Pool_Transaction(request);
		}

		public Cancel_Investment_Pool_Transaction_ResponseType Cancel_Investment_Pool_Transaction(Workday_Common_HeaderType Workday_Common_Header, Cancel_Investment_Pool_Transaction_RequestType Cancel_Investment_Pool_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Investment_Pool_Transaction(new Cancel_Investment_Pool_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Investment_Pool_Transaction_Request = Cancel_Investment_Pool_Transaction_Request
			}).Cancel_Investment_Pool_Transaction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Investment_Pool_TransactionOutput> Cash_ManagementPort.Cancel_Investment_Pool_TransactionAsync(Cancel_Investment_Pool_TransactionInput request)
		{
			return base.Channel.Cancel_Investment_Pool_TransactionAsync(request);
		}

		public Task<Cancel_Investment_Pool_TransactionOutput> Cancel_Investment_Pool_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Investment_Pool_Transaction_RequestType Cancel_Investment_Pool_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Investment_Pool_TransactionAsync(new Cancel_Investment_Pool_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Investment_Pool_Transaction_Request = Cancel_Investment_Pool_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Recalculate_Bank_Statement_BalanceOutput Cash_ManagementPort.Recalculate_Bank_Statement_Balance(Recalculate_Bank_Statement_BalanceInput request)
		{
			return base.Channel.Recalculate_Bank_Statement_Balance(request);
		}

		public Recalculate_Bank_Statement_Balance_ResponseType Recalculate_Bank_Statement_Balance(Workday_Common_HeaderType Workday_Common_Header, Recalculate_Bank_Statement_Balance_RequestType Recalculate_Bank_Statement_Balance_Request)
		{
			return ((Cash_ManagementPort)this).Recalculate_Bank_Statement_Balance(new Recalculate_Bank_Statement_BalanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Recalculate_Bank_Statement_Balance_Request = Recalculate_Bank_Statement_Balance_Request
			}).Recalculate_Bank_Statement_Balance_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Recalculate_Bank_Statement_BalanceOutput> Cash_ManagementPort.Recalculate_Bank_Statement_BalanceAsync(Recalculate_Bank_Statement_BalanceInput request)
		{
			return base.Channel.Recalculate_Bank_Statement_BalanceAsync(request);
		}

		public Task<Recalculate_Bank_Statement_BalanceOutput> Recalculate_Bank_Statement_BalanceAsync(Workday_Common_HeaderType Workday_Common_Header, Recalculate_Bank_Statement_Balance_RequestType Recalculate_Bank_Statement_Balance_Request)
		{
			return ((Cash_ManagementPort)this).Recalculate_Bank_Statement_BalanceAsync(new Recalculate_Bank_Statement_BalanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Recalculate_Bank_Statement_Balance_Request = Recalculate_Bank_Statement_Balance_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Cancel_Donor_ContributionOutput Cash_ManagementPort.Cancel_Donor_Contribution(Cancel_Donor_ContributionInput request)
		{
			return base.Channel.Cancel_Donor_Contribution(request);
		}

		public Cancel_Donor_Contribution_ResponseType Cancel_Donor_Contribution(Workday_Common_HeaderType Workday_Common_Header, Cancel_Donor_Contribution_RequestType Cancel_Donor_Contribution_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Donor_Contribution(new Cancel_Donor_ContributionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Donor_Contribution_Request = Cancel_Donor_Contribution_Request
			}).Cancel_Donor_Contribution_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Cancel_Donor_ContributionOutput> Cash_ManagementPort.Cancel_Donor_ContributionAsync(Cancel_Donor_ContributionInput request)
		{
			return base.Channel.Cancel_Donor_ContributionAsync(request);
		}

		public Task<Cancel_Donor_ContributionOutput> Cancel_Donor_ContributionAsync(Workday_Common_HeaderType Workday_Common_Header, Cancel_Donor_Contribution_RequestType Cancel_Donor_Contribution_Request)
		{
			return ((Cash_ManagementPort)this).Cancel_Donor_ContributionAsync(new Cancel_Donor_ContributionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Cancel_Donor_Contribution_Request = Cancel_Donor_Contribution_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Bank_StatementOutput Cash_ManagementPort.Import_Bank_Statement(Import_Bank_StatementInput request)
		{
			return base.Channel.Import_Bank_Statement(request);
		}

		public Put_Import_Process_ResponseType Import_Bank_Statement(Workday_Common_HeaderType Workday_Common_Header, Import_Bank_Statement_RequestType Import_Bank_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Import_Bank_Statement(new Import_Bank_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Bank_Statement_Request = Import_Bank_Statement_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Bank_StatementOutput> Cash_ManagementPort.Import_Bank_StatementAsync(Import_Bank_StatementInput request)
		{
			return base.Channel.Import_Bank_StatementAsync(request);
		}

		public Task<Import_Bank_StatementOutput> Import_Bank_StatementAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Bank_Statement_RequestType Import_Bank_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Import_Bank_StatementAsync(new Import_Bank_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Bank_Statement_Request = Import_Bank_Statement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Bank_StatementOutput Cash_ManagementPort.Import_Ad_hoc_Bank_Transaction(Import_Ad_hoc_Bank_TransactionInput request)
		{
			return base.Channel.Import_Ad_hoc_Bank_Transaction(request);
		}

		public Put_Import_Process_ResponseType Import_Ad_hoc_Bank_Transaction(Workday_Common_HeaderType Workday_Common_Header, Import_Ad_hoc_Bank_Transaction_RequestType Import_Ad_hoc_Bank_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Import_Ad_hoc_Bank_Transaction(new Import_Ad_hoc_Bank_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Ad_hoc_Bank_Transaction_Request = Import_Ad_hoc_Bank_Transaction_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Bank_StatementOutput> Cash_ManagementPort.Import_Ad_hoc_Bank_TransactionAsync(Import_Ad_hoc_Bank_TransactionInput request)
		{
			return base.Channel.Import_Ad_hoc_Bank_TransactionAsync(request);
		}

		public Task<Import_Bank_StatementOutput> Import_Ad_hoc_Bank_TransactionAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Ad_hoc_Bank_Transaction_RequestType Import_Ad_hoc_Bank_Transaction_Request)
		{
			return ((Cash_ManagementPort)this).Import_Ad_hoc_Bank_TransactionAsync(new Import_Ad_hoc_Bank_TransactionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Ad_hoc_Bank_Transaction_Request = Import_Ad_hoc_Bank_Transaction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Bank_StatementOutput Cash_ManagementPort.Import_Intraday_Bank_Statement(Import_Intraday_Bank_StatementInput request)
		{
			return base.Channel.Import_Intraday_Bank_Statement(request);
		}

		public Put_Import_Process_ResponseType Import_Intraday_Bank_Statement(Workday_Common_HeaderType Workday_Common_Header, Import_Intraday_Bank_Statement_RequestType Import_Intraday_Bank_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Import_Intraday_Bank_Statement(new Import_Intraday_Bank_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Intraday_Bank_Statement_Request = Import_Intraday_Bank_Statement_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Bank_StatementOutput> Cash_ManagementPort.Import_Intraday_Bank_StatementAsync(Import_Intraday_Bank_StatementInput request)
		{
			return base.Channel.Import_Intraday_Bank_StatementAsync(request);
		}

		public Task<Import_Bank_StatementOutput> Import_Intraday_Bank_StatementAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Intraday_Bank_Statement_RequestType Import_Intraday_Bank_Statement_Request)
		{
			return ((Cash_ManagementPort)this).Import_Intraday_Bank_StatementAsync(new Import_Intraday_Bank_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Intraday_Bank_Statement_Request = Import_Intraday_Bank_Statement_Request
			});
		}
	}
}
