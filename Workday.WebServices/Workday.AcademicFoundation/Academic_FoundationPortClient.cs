using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Academic_FoundationPortClient : ClientBase<Academic_FoundationPort>, Academic_FoundationPort
	{
		public Academic_FoundationPortClient()
		{
		}

		public Academic_FoundationPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Academic_FoundationPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Academic_FoundationPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Academic_FoundationPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Programs_of_StudyOutput Academic_FoundationPort.Get_Programs_of_Study(Get_Programs_of_StudyInput request)
		{
			return base.Channel.Get_Programs_of_Study(request);
		}

		public Get_Programs_of_Study_ResponseType Get_Programs_of_Study(Workday_Common_HeaderType Workday_Common_Header, Get_Programs_of_Study_RequestType Get_Programs_of_Study_Request)
		{
			return ((Academic_FoundationPort)this).Get_Programs_of_Study(new Get_Programs_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Programs_of_Study_Request = Get_Programs_of_Study_Request
			}).Get_Programs_of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Programs_of_StudyOutput> Academic_FoundationPort.Get_Programs_of_StudyAsync(Get_Programs_of_StudyInput request)
		{
			return base.Channel.Get_Programs_of_StudyAsync(request);
		}

		public Task<Get_Programs_of_StudyOutput> Get_Programs_of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Programs_of_Study_RequestType Get_Programs_of_Study_Request)
		{
			return ((Academic_FoundationPort)this).Get_Programs_of_StudyAsync(new Get_Programs_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Programs_of_Study_Request = Get_Programs_of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Program_of_StudyOutput Academic_FoundationPort.Put_Program_of_Study(Put_Program_of_StudyInput request)
		{
			return base.Channel.Put_Program_of_Study(request);
		}

		public Put_Program_of_Study_ResponseType Put_Program_of_Study(Workday_Common_HeaderType Workday_Common_Header, Put_Program_of_Study_RequestType Put_Program_of_Study_Request)
		{
			return ((Academic_FoundationPort)this).Put_Program_of_Study(new Put_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Program_of_Study_Request = Put_Program_of_Study_Request
			}).Put_Program_of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Program_of_StudyOutput> Academic_FoundationPort.Put_Program_of_StudyAsync(Put_Program_of_StudyInput request)
		{
			return base.Channel.Put_Program_of_StudyAsync(request);
		}

		public Task<Put_Program_of_StudyOutput> Put_Program_of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Program_of_Study_RequestType Put_Program_of_Study_Request)
		{
			return ((Academic_FoundationPort)this).Put_Program_of_StudyAsync(new Put_Program_of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Program_of_Study_Request = Put_Program_of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_External_AssociationsOutput Academic_FoundationPort.Get_External_Associations(Get_External_AssociationsInput request)
		{
			return base.Channel.Get_External_Associations(request);
		}

		public Get_External_Associations_ResponseType Get_External_Associations(Workday_Common_HeaderType Workday_Common_Header, Get_External_Associations_RequestType Get_External_Associations_Request)
		{
			return ((Academic_FoundationPort)this).Get_External_Associations(new Get_External_AssociationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Associations_Request = Get_External_Associations_Request
			}).Get_External_Associations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_External_AssociationsOutput> Academic_FoundationPort.Get_External_AssociationsAsync(Get_External_AssociationsInput request)
		{
			return base.Channel.Get_External_AssociationsAsync(request);
		}

		public Task<Get_External_AssociationsOutput> Get_External_AssociationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_External_Associations_RequestType Get_External_Associations_Request)
		{
			return ((Academic_FoundationPort)this).Get_External_AssociationsAsync(new Get_External_AssociationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Associations_Request = Get_External_Associations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_AssociationOutput Academic_FoundationPort.Put_External_Association(Put_External_AssociationInput request)
		{
			return base.Channel.Put_External_Association(request);
		}

		public Put_External_Association_ResponseType Put_External_Association(Workday_Common_HeaderType Workday_Common_Header, Put_External_Association_RequestType Put_External_Association_Request)
		{
			return ((Academic_FoundationPort)this).Put_External_Association(new Put_External_AssociationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Association_Request = Put_External_Association_Request
			}).Put_External_Association_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_AssociationOutput> Academic_FoundationPort.Put_External_AssociationAsync(Put_External_AssociationInput request)
		{
			return base.Channel.Put_External_AssociationAsync(request);
		}

		public Task<Put_External_AssociationOutput> Put_External_AssociationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Association_RequestType Put_External_Association_Request)
		{
			return ((Academic_FoundationPort)this).Put_External_AssociationAsync(new Put_External_AssociationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Association_Request = Put_External_Association_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Tag_CategoriesOutput Academic_FoundationPort.Get_Student_Tag_Categories(Get_Student_Tag_CategoriesInput request)
		{
			return base.Channel.Get_Student_Tag_Categories(request);
		}

		public Get_Student_Tag_Categories_ResponseType Get_Student_Tag_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Tag_Categories_RequestType Get_Student_Tag_Categories_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Tag_Categories(new Get_Student_Tag_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Tag_Categories_Request = Get_Student_Tag_Categories_Request
			}).Get_Student_Tag_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Tag_CategoriesOutput> Academic_FoundationPort.Get_Student_Tag_CategoriesAsync(Get_Student_Tag_CategoriesInput request)
		{
			return base.Channel.Get_Student_Tag_CategoriesAsync(request);
		}

		public Task<Get_Student_Tag_CategoriesOutput> Get_Student_Tag_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Tag_Categories_RequestType Get_Student_Tag_Categories_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Tag_CategoriesAsync(new Get_Student_Tag_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Tag_Categories_Request = Get_Student_Tag_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Tag_CategoryOutput Academic_FoundationPort.Put_Student_Tag_Category(Put_Student_Tag_CategoryInput request)
		{
			return base.Channel.Put_Student_Tag_Category(request);
		}

		public Put_Student_Tag_Category_ResponseType Put_Student_Tag_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Tag_Category_RequestType Put_Student_Tag_Category_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Tag_Category(new Put_Student_Tag_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Tag_Category_Request = Put_Student_Tag_Category_Request
			}).Put_Student_Tag_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Tag_CategoryOutput> Academic_FoundationPort.Put_Student_Tag_CategoryAsync(Put_Student_Tag_CategoryInput request)
		{
			return base.Channel.Put_Student_Tag_CategoryAsync(request);
		}

		public Task<Put_Student_Tag_CategoryOutput> Put_Student_Tag_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Tag_Category_RequestType Put_Student_Tag_Category_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Tag_CategoryAsync(new Put_Student_Tag_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Tag_Category_Request = Put_Student_Tag_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_TagsOutput Academic_FoundationPort.Get_Student_Tags(Get_Student_TagsInput request)
		{
			return base.Channel.Get_Student_Tags(request);
		}

		public Get_Student_Tags_ResponseType Get_Student_Tags(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Tags_RequestType Get_Student_Tags_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Tags(new Get_Student_TagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Tags_Request = Get_Student_Tags_Request
			}).Get_Student_Tags_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_TagsOutput> Academic_FoundationPort.Get_Student_TagsAsync(Get_Student_TagsInput request)
		{
			return base.Channel.Get_Student_TagsAsync(request);
		}

		public Task<Get_Student_TagsOutput> Get_Student_TagsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Tags_RequestType Get_Student_Tags_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_TagsAsync(new Get_Student_TagsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Tags_Request = Get_Student_Tags_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_TagOutput Academic_FoundationPort.Put_Student_Tag(Put_Student_TagInput request)
		{
			return base.Channel.Put_Student_Tag(request);
		}

		public Put_Student_Tag_ResponseType Put_Student_Tag(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Tag_RequestType Put_Student_Tag_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Tag(new Put_Student_TagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Tag_Request = Put_Student_Tag_Request
			}).Put_Student_Tag_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_TagOutput> Academic_FoundationPort.Put_Student_TagAsync(Put_Student_TagInput request)
		{
			return base.Channel.Put_Student_TagAsync(request);
		}

		public Task<Put_Student_TagOutput> Put_Student_TagAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Tag_RequestType Put_Student_Tag_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_TagAsync(new Put_Student_TagInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Tag_Request = Put_Student_Tag_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Extracurricular_ActivitiesOutput Academic_FoundationPort.Get_Extracurricular_Activities(Get_Extracurricular_ActivitiesInput request)
		{
			return base.Channel.Get_Extracurricular_Activities(request);
		}

		public Get_Extracurricular_Activities_ResponseType Get_Extracurricular_Activities(Workday_Common_HeaderType Workday_Common_Header, Get_Extracurricular_Activities_RequestType Get_Extracurricular_Activities_Request)
		{
			return ((Academic_FoundationPort)this).Get_Extracurricular_Activities(new Get_Extracurricular_ActivitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Extracurricular_Activities_Request = Get_Extracurricular_Activities_Request
			}).Get_Extracurricular_Activities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Extracurricular_ActivitiesOutput> Academic_FoundationPort.Get_Extracurricular_ActivitiesAsync(Get_Extracurricular_ActivitiesInput request)
		{
			return base.Channel.Get_Extracurricular_ActivitiesAsync(request);
		}

		public Task<Get_Extracurricular_ActivitiesOutput> Get_Extracurricular_ActivitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Extracurricular_Activities_RequestType Get_Extracurricular_Activities_Request)
		{
			return ((Academic_FoundationPort)this).Get_Extracurricular_ActivitiesAsync(new Get_Extracurricular_ActivitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Extracurricular_Activities_Request = Get_Extracurricular_Activities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Extracurricular_ActivityOutput Academic_FoundationPort.Put_Extracurricular_Activity(Put_Extracurricular_ActivityInput request)
		{
			return base.Channel.Put_Extracurricular_Activity(request);
		}

		public Put_Extracurricular_Activity_ResponseType Put_Extracurricular_Activity(Workday_Common_HeaderType Workday_Common_Header, Put_Extracurricular_Activity_RequestType Put_Extracurricular_Activity_Request)
		{
			return ((Academic_FoundationPort)this).Put_Extracurricular_Activity(new Put_Extracurricular_ActivityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Extracurricular_Activity_Request = Put_Extracurricular_Activity_Request
			}).Put_Extracurricular_Activity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Extracurricular_ActivityOutput> Academic_FoundationPort.Put_Extracurricular_ActivityAsync(Put_Extracurricular_ActivityInput request)
		{
			return base.Channel.Put_Extracurricular_ActivityAsync(request);
		}

		public Task<Put_Extracurricular_ActivityOutput> Put_Extracurricular_ActivityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Extracurricular_Activity_RequestType Put_Extracurricular_Activity_Request)
		{
			return ((Academic_FoundationPort)this).Put_Extracurricular_ActivityAsync(new Put_Extracurricular_ActivityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Extracurricular_Activity_Request = Put_Extracurricular_Activity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Academic_ContactsOutput Academic_FoundationPort.Get_Academic_Contacts(Get_Academic_ContactsInput request)
		{
			return base.Channel.Get_Academic_Contacts(request);
		}

		public Get_Academic_Contacts_ResponseType Get_Academic_Contacts(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Contacts_RequestType Get_Academic_Contacts_Request)
		{
			return ((Academic_FoundationPort)this).Get_Academic_Contacts(new Get_Academic_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Contacts_Request = Get_Academic_Contacts_Request
			}).Get_Academic_Contacts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Academic_ContactsOutput> Academic_FoundationPort.Get_Academic_ContactsAsync(Get_Academic_ContactsInput request)
		{
			return base.Channel.Get_Academic_ContactsAsync(request);
		}

		public Task<Get_Academic_ContactsOutput> Get_Academic_ContactsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Contacts_RequestType Get_Academic_Contacts_Request)
		{
			return ((Academic_FoundationPort)this).Get_Academic_ContactsAsync(new Get_Academic_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Contacts_Request = Get_Academic_Contacts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Academic_ContactOutput Academic_FoundationPort.Put_Academic_Contact(Put_Academic_ContactInput request)
		{
			return base.Channel.Put_Academic_Contact(request);
		}

		public Put_Academic_Contact_ResponseType Put_Academic_Contact(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Contact_RequestType Put_Academic_Contact_Request)
		{
			return ((Academic_FoundationPort)this).Put_Academic_Contact(new Put_Academic_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Contact_Request = Put_Academic_Contact_Request
			}).Put_Academic_Contact_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Academic_ContactOutput> Academic_FoundationPort.Put_Academic_ContactAsync(Put_Academic_ContactInput request)
		{
			return base.Channel.Put_Academic_ContactAsync(request);
		}

		public Task<Put_Academic_ContactOutput> Put_Academic_ContactAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Contact_RequestType Put_Academic_Contact_Request)
		{
			return ((Academic_FoundationPort)this).Put_Academic_ContactAsync(new Put_Academic_ContactInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Contact_Request = Put_Academic_Contact_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Grading_SchemesOutput Academic_FoundationPort.Get_Student_Grading_Schemes(Get_Student_Grading_SchemesInput request)
		{
			return base.Channel.Get_Student_Grading_Schemes(request);
		}

		public Get_Student_Grading_Schemes_ResponseType Get_Student_Grading_Schemes(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Grading_Schemes_RequestType Get_Student_Grading_Schemes_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Grading_Schemes(new Get_Student_Grading_SchemesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Grading_Schemes_Request = Get_Student_Grading_Schemes_Request
			}).Get_Student_Grading_Schemes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Grading_SchemesOutput> Academic_FoundationPort.Get_Student_Grading_SchemesAsync(Get_Student_Grading_SchemesInput request)
		{
			return base.Channel.Get_Student_Grading_SchemesAsync(request);
		}

		public Task<Get_Student_Grading_SchemesOutput> Get_Student_Grading_SchemesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Grading_Schemes_RequestType Get_Student_Grading_Schemes_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Grading_SchemesAsync(new Get_Student_Grading_SchemesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Grading_Schemes_Request = Get_Student_Grading_Schemes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Grading_SchemeOutput Academic_FoundationPort.Put_Student_Grading_Scheme(Put_Student_Grading_SchemeInput request)
		{
			return base.Channel.Put_Student_Grading_Scheme(request);
		}

		public Put_Student_Grading_Scheme_ResponseType Put_Student_Grading_Scheme(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Grading_Scheme_RequestType Put_Student_Grading_Scheme_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Grading_Scheme(new Put_Student_Grading_SchemeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Grading_Scheme_Request = Put_Student_Grading_Scheme_Request
			}).Put_Student_Grading_Scheme_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Grading_SchemeOutput> Academic_FoundationPort.Put_Student_Grading_SchemeAsync(Put_Student_Grading_SchemeInput request)
		{
			return base.Channel.Put_Student_Grading_SchemeAsync(request);
		}

		public Task<Put_Student_Grading_SchemeOutput> Put_Student_Grading_SchemeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Grading_Scheme_RequestType Put_Student_Grading_Scheme_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Grading_SchemeAsync(new Put_Student_Grading_SchemeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Grading_Scheme_Request = Put_Student_Grading_Scheme_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Education_Test_ResultsOutput Academic_FoundationPort.Get_Education_Test_Results(Get_Education_Test_ResultsInput request)
		{
			return base.Channel.Get_Education_Test_Results(request);
		}

		public Get_Education_Test_Results_ResponseType Get_Education_Test_Results(Workday_Common_HeaderType Workday_Common_Header, Get_Education_Test_Results_RequestType Get_Education_Test_Results_Request)
		{
			return ((Academic_FoundationPort)this).Get_Education_Test_Results(new Get_Education_Test_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Education_Test_Results_Request = Get_Education_Test_Results_Request
			}).Get_Education_Test_Results_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Education_Test_ResultsOutput> Academic_FoundationPort.Get_Education_Test_ResultsAsync(Get_Education_Test_ResultsInput request)
		{
			return base.Channel.Get_Education_Test_ResultsAsync(request);
		}

		public Task<Get_Education_Test_ResultsOutput> Get_Education_Test_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Education_Test_Results_RequestType Get_Education_Test_Results_Request)
		{
			return ((Academic_FoundationPort)this).Get_Education_Test_ResultsAsync(new Get_Education_Test_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Education_Test_Results_Request = Get_Education_Test_Results_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Education_Test_ResultOutput Academic_FoundationPort.Put_Education_Test_Result(Put_Education_Test_ResultInput request)
		{
			return base.Channel.Put_Education_Test_Result(request);
		}

		public Put_Education_Test_Result_ResponseType Put_Education_Test_Result(Workday_Common_HeaderType Workday_Common_Header, Put_Education_Test_Result_RequestType Put_Education_Test_Result_Request)
		{
			return ((Academic_FoundationPort)this).Put_Education_Test_Result(new Put_Education_Test_ResultInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Education_Test_Result_Request = Put_Education_Test_Result_Request
			}).Put_Education_Test_Result_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Education_Test_ResultOutput> Academic_FoundationPort.Put_Education_Test_ResultAsync(Put_Education_Test_ResultInput request)
		{
			return base.Channel.Put_Education_Test_ResultAsync(request);
		}

		public Task<Put_Education_Test_ResultOutput> Put_Education_Test_ResultAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Education_Test_Result_RequestType Put_Education_Test_Result_Request)
		{
			return ((Academic_FoundationPort)this).Put_Education_Test_ResultAsync(new Put_Education_Test_ResultInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Education_Test_Result_Request = Put_Education_Test_Result_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Maintained_Academic_PeriodsOutput Academic_FoundationPort.Get_Maintained_Academic_Periods(Get_Maintained_Academic_PeriodsInput request)
		{
			return base.Channel.Get_Maintained_Academic_Periods(request);
		}

		public Get_Maintained_Academic_Periods_ResponseType Get_Maintained_Academic_Periods(Workday_Common_HeaderType Workday_Common_Header, Get_Maintained_Academic_Periods_RequestType Get_Maintained_Academic_Periods_Request)
		{
			return ((Academic_FoundationPort)this).Get_Maintained_Academic_Periods(new Get_Maintained_Academic_PeriodsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Maintained_Academic_Periods_Request = Get_Maintained_Academic_Periods_Request
			}).Get_Maintained_Academic_Periods_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Maintained_Academic_PeriodsOutput> Academic_FoundationPort.Get_Maintained_Academic_PeriodsAsync(Get_Maintained_Academic_PeriodsInput request)
		{
			return base.Channel.Get_Maintained_Academic_PeriodsAsync(request);
		}

		public Task<Get_Maintained_Academic_PeriodsOutput> Get_Maintained_Academic_PeriodsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Maintained_Academic_Periods_RequestType Get_Maintained_Academic_Periods_Request)
		{
			return ((Academic_FoundationPort)this).Get_Maintained_Academic_PeriodsAsync(new Get_Maintained_Academic_PeriodsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Maintained_Academic_Periods_Request = Get_Maintained_Academic_Periods_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Maintained_Academic_PeriodOutput Academic_FoundationPort.Put_Maintained_Academic_Period(Put_Maintained_Academic_PeriodInput request)
		{
			return base.Channel.Put_Maintained_Academic_Period(request);
		}

		public Put_Maintained_Academic_Period_ResponseType Put_Maintained_Academic_Period(Workday_Common_HeaderType Workday_Common_Header, Put_Maintained_Academic_Period_RequestType Put_Maintained_Academic_Period_Request)
		{
			return ((Academic_FoundationPort)this).Put_Maintained_Academic_Period(new Put_Maintained_Academic_PeriodInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Maintained_Academic_Period_Request = Put_Maintained_Academic_Period_Request
			}).Put_Maintained_Academic_Period_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Maintained_Academic_PeriodOutput> Academic_FoundationPort.Put_Maintained_Academic_PeriodAsync(Put_Maintained_Academic_PeriodInput request)
		{
			return base.Channel.Put_Maintained_Academic_PeriodAsync(request);
		}

		public Task<Put_Maintained_Academic_PeriodOutput> Put_Maintained_Academic_PeriodAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Maintained_Academic_Period_RequestType Put_Maintained_Academic_Period_Request)
		{
			return ((Academic_FoundationPort)this).Put_Maintained_Academic_PeriodAsync(new Put_Maintained_Academic_PeriodInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Maintained_Academic_Period_Request = Put_Maintained_Academic_Period_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Prospective_StudentsOutput Academic_FoundationPort.Get_Prospective_Students(Get_Prospective_StudentsInput request)
		{
			return base.Channel.Get_Prospective_Students(request);
		}

		public Get_Prospective_Students_ResponseType Get_Prospective_Students(Workday_Common_HeaderType Workday_Common_Header, Get_Prospective_Students_RequestType Get_Prospective_Students_Request)
		{
			return ((Academic_FoundationPort)this).Get_Prospective_Students(new Get_Prospective_StudentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prospective_Students_Request = Get_Prospective_Students_Request
			}).Get_Prospective_Students_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Prospective_StudentsOutput> Academic_FoundationPort.Get_Prospective_StudentsAsync(Get_Prospective_StudentsInput request)
		{
			return base.Channel.Get_Prospective_StudentsAsync(request);
		}

		public Task<Get_Prospective_StudentsOutput> Get_Prospective_StudentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Prospective_Students_RequestType Get_Prospective_Students_Request)
		{
			return ((Academic_FoundationPort)this).Get_Prospective_StudentsAsync(new Get_Prospective_StudentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Prospective_Students_Request = Get_Prospective_Students_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Educational_InstitutionOutput Academic_FoundationPort.Get_Student_Educational_Institution(Get_Student_Educational_InstitutionInput request)
		{
			return base.Channel.Get_Student_Educational_Institution(request);
		}

		public Get_Student_Educational_Institution_ResponseType Get_Student_Educational_Institution(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Educational_Institution_RequestType Get_Student_Educational_Institution_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Educational_Institution(new Get_Student_Educational_InstitutionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Educational_Institution_Request = Get_Student_Educational_Institution_Request
			}).Get_Student_Educational_Institution_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Educational_InstitutionOutput> Academic_FoundationPort.Get_Student_Educational_InstitutionAsync(Get_Student_Educational_InstitutionInput request)
		{
			return base.Channel.Get_Student_Educational_InstitutionAsync(request);
		}

		public Task<Get_Student_Educational_InstitutionOutput> Get_Student_Educational_InstitutionAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Educational_Institution_RequestType Get_Student_Educational_Institution_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Educational_InstitutionAsync(new Get_Student_Educational_InstitutionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Educational_Institution_Request = Get_Student_Educational_Institution_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Educational_InstitutionOutput Academic_FoundationPort.Put_Student_Educational_Institution(Put_Student_Educational_InstitutionInput request)
		{
			return base.Channel.Put_Student_Educational_Institution(request);
		}

		public Put_Student_Educational_Institution_ResponseType Put_Student_Educational_Institution(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Educational_Institution_RequestType Put_Student_Educational_Institution_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Educational_Institution(new Put_Student_Educational_InstitutionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Educational_Institution_Request = Put_Student_Educational_Institution_Request
			}).Put_Student_Educational_Institution_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Educational_InstitutionOutput> Academic_FoundationPort.Put_Student_Educational_InstitutionAsync(Put_Student_Educational_InstitutionInput request)
		{
			return base.Channel.Put_Student_Educational_InstitutionAsync(request);
		}

		public Task<Put_Student_Educational_InstitutionOutput> Put_Student_Educational_InstitutionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Educational_Institution_RequestType Put_Student_Educational_Institution_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Educational_InstitutionAsync(new Put_Student_Educational_InstitutionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Educational_Institution_Request = Put_Student_Educational_Institution_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Educational_Institution_CourseOutput Academic_FoundationPort.Put_Educational_Institution_Course(Put_Educational_Institution_CourseInput request)
		{
			return base.Channel.Put_Educational_Institution_Course(request);
		}

		public Put_Educational_Institution_Course_ResponseType Put_Educational_Institution_Course(Workday_Common_HeaderType Workday_Common_Header, Put_Educational_Institution_Course_RequestType Put_Educational_Institution_Course_Request)
		{
			return ((Academic_FoundationPort)this).Put_Educational_Institution_Course(new Put_Educational_Institution_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Educational_Institution_Course_Request = Put_Educational_Institution_Course_Request
			}).Put_Educational_Institution_Course_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Educational_Institution_CourseOutput> Academic_FoundationPort.Put_Educational_Institution_CourseAsync(Put_Educational_Institution_CourseInput request)
		{
			return base.Channel.Put_Educational_Institution_CourseAsync(request);
		}

		public Task<Put_Educational_Institution_CourseOutput> Put_Educational_Institution_CourseAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Educational_Institution_Course_RequestType Put_Educational_Institution_Course_Request)
		{
			return ((Academic_FoundationPort)this).Put_Educational_Institution_CourseAsync(new Put_Educational_Institution_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Educational_Institution_Course_Request = Put_Educational_Institution_Course_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Educational_Institution_CourseOutput Academic_FoundationPort.Get_Educational_Institution_Course(Get_Educational_Institution_CourseInput request)
		{
			return base.Channel.Get_Educational_Institution_Course(request);
		}

		public Get_Educational_Institution_Course_ResponseType Get_Educational_Institution_Course(Workday_Common_HeaderType Workday_Common_Header, Get_Educational_Institution_Course_RequestType Get_Educational_Institution_Course_Request)
		{
			return ((Academic_FoundationPort)this).Get_Educational_Institution_Course(new Get_Educational_Institution_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Educational_Institution_Course_Request = Get_Educational_Institution_Course_Request
			}).Get_Educational_Institution_Course_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Educational_Institution_CourseOutput> Academic_FoundationPort.Get_Educational_Institution_CourseAsync(Get_Educational_Institution_CourseInput request)
		{
			return base.Channel.Get_Educational_Institution_CourseAsync(request);
		}

		public Task<Get_Educational_Institution_CourseOutput> Get_Educational_Institution_CourseAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Educational_Institution_Course_RequestType Get_Educational_Institution_Course_Request)
		{
			return ((Academic_FoundationPort)this).Get_Educational_Institution_CourseAsync(new Get_Educational_Institution_CourseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Educational_Institution_Course_Request = Get_Educational_Institution_Course_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Educational_Institution_DistrictsOutput Academic_FoundationPort.Get_Student_Educational_Institution_Districts(Get_Student_Educational_Institution_DistrictsInput request)
		{
			return base.Channel.Get_Student_Educational_Institution_Districts(request);
		}

		public Get_Student_Educational_Institution_Districts_ResponseType Get_Student_Educational_Institution_Districts(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Educational_Institution_Districts_RequestType Get_Student_Educational_Institution_Districts_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Educational_Institution_Districts(new Get_Student_Educational_Institution_DistrictsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Educational_Institution_Districts_Request = Get_Student_Educational_Institution_Districts_Request
			}).Get_Student_Educational_Institution_Districts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Educational_Institution_DistrictsOutput> Academic_FoundationPort.Get_Student_Educational_Institution_DistrictsAsync(Get_Student_Educational_Institution_DistrictsInput request)
		{
			return base.Channel.Get_Student_Educational_Institution_DistrictsAsync(request);
		}

		public Task<Get_Student_Educational_Institution_DistrictsOutput> Get_Student_Educational_Institution_DistrictsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Educational_Institution_Districts_RequestType Get_Student_Educational_Institution_Districts_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Educational_Institution_DistrictsAsync(new Get_Student_Educational_Institution_DistrictsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Educational_Institution_Districts_Request = Get_Student_Educational_Institution_Districts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Educational_Institution_DistrictOutput Academic_FoundationPort.Put_Student_Educational_Institution_District(Put_Student_Educational_Institution_DistrictInput request)
		{
			return base.Channel.Put_Student_Educational_Institution_District(request);
		}

		public Put_Student_Educational_Institution_District_ResponseType Put_Student_Educational_Institution_District(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Educational_Institution_District_RequestType Put_Student_Educational_Institution_District_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Educational_Institution_District(new Put_Student_Educational_Institution_DistrictInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Educational_Institution_District_Request = Put_Student_Educational_Institution_District_Request
			}).Put_Student_Educational_Institution_District_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Educational_Institution_DistrictOutput> Academic_FoundationPort.Put_Student_Educational_Institution_DistrictAsync(Put_Student_Educational_Institution_DistrictInput request)
		{
			return base.Channel.Put_Student_Educational_Institution_DistrictAsync(request);
		}

		public Task<Put_Student_Educational_Institution_DistrictOutput> Put_Student_Educational_Institution_DistrictAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Educational_Institution_District_RequestType Put_Student_Educational_Institution_District_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Educational_Institution_DistrictAsync(new Put_Student_Educational_Institution_DistrictInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Educational_Institution_District_Request = Put_Student_Educational_Institution_District_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_StudentsOutput Academic_FoundationPort.Get_Students(Get_StudentsInput request)
		{
			return base.Channel.Get_Students(request);
		}

		public Get_Students_ResponseType Get_Students(Workday_Common_HeaderType Workday_Common_Header, Get_Students_RequestType Get_Students_Request)
		{
			return ((Academic_FoundationPort)this).Get_Students(new Get_StudentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Students_Request = Get_Students_Request
			}).Get_Students_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_StudentsOutput> Academic_FoundationPort.Get_StudentsAsync(Get_StudentsInput request)
		{
			return base.Channel.Get_StudentsAsync(request);
		}

		public Task<Get_StudentsOutput> Get_StudentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Students_RequestType Get_Students_Request)
		{
			return ((Academic_FoundationPort)this).Get_StudentsAsync(new Get_StudentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Students_Request = Get_Students_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Transfer_Credit_RulesOutput Academic_FoundationPort.Get_Student_Transfer_Credit_Rules(Get_Student_Transfer_Credit_RulesInput request)
		{
			return base.Channel.Get_Student_Transfer_Credit_Rules(request);
		}

		public Get_Student_Transfer_Credit_Rules_ResponseType Get_Student_Transfer_Credit_Rules(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Transfer_Credit_Rules_RequestType Get_Student_Transfer_Credit_Rules_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Transfer_Credit_Rules(new Get_Student_Transfer_Credit_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Transfer_Credit_Rules_Request = Get_Student_Transfer_Credit_Rules_Request
			}).Get_Student_Transfer_Credit_Rules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Transfer_Credit_RulesOutput> Academic_FoundationPort.Get_Student_Transfer_Credit_RulesAsync(Get_Student_Transfer_Credit_RulesInput request)
		{
			return base.Channel.Get_Student_Transfer_Credit_RulesAsync(request);
		}

		public Task<Get_Student_Transfer_Credit_RulesOutput> Get_Student_Transfer_Credit_RulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Transfer_Credit_Rules_RequestType Get_Student_Transfer_Credit_Rules_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Transfer_Credit_RulesAsync(new Get_Student_Transfer_Credit_RulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Transfer_Credit_Rules_Request = Get_Student_Transfer_Credit_Rules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Transfer_Credit_RuleOutput Academic_FoundationPort.Put_Student_Transfer_Credit_Rule(Put_Student_Transfer_Credit_RuleInput request)
		{
			return base.Channel.Put_Student_Transfer_Credit_Rule(request);
		}

		public Put_Student_Transfer_Credit_Rule_ResponseType Put_Student_Transfer_Credit_Rule(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Transfer_Credit_Rule_RequestType Put_Student_Transfer_Credit_Rule_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Transfer_Credit_Rule(new Put_Student_Transfer_Credit_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Transfer_Credit_Rule_Request = Put_Student_Transfer_Credit_Rule_Request
			}).Put_Student_Transfer_Credit_Rule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Transfer_Credit_RuleOutput> Academic_FoundationPort.Put_Student_Transfer_Credit_RuleAsync(Put_Student_Transfer_Credit_RuleInput request)
		{
			return base.Channel.Put_Student_Transfer_Credit_RuleAsync(request);
		}

		public Task<Put_Student_Transfer_Credit_RuleOutput> Put_Student_Transfer_Credit_RuleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Transfer_Credit_Rule_RequestType Put_Student_Transfer_Credit_Rule_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Transfer_Credit_RuleAsync(new Put_Student_Transfer_Credit_RuleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Transfer_Credit_Rule_Request = Put_Student_Transfer_Credit_Rule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Friends_and_FamilyOutput Academic_FoundationPort.Get_Student_Friends_and_Family(Get_Student_Friends_and_FamilyInput request)
		{
			return base.Channel.Get_Student_Friends_and_Family(request);
		}

		public Get_Student_Friends_and_Family_ResponseType Get_Student_Friends_and_Family(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Friends_and_Family_RequestType Get_Student_Friends_and_Family_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Friends_and_Family(new Get_Student_Friends_and_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Friends_and_Family_Request = Get_Student_Friends_and_Family_Request
			}).Get_Student_Friends_and_Family_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Friends_and_FamilyOutput> Academic_FoundationPort.Get_Student_Friends_and_FamilyAsync(Get_Student_Friends_and_FamilyInput request)
		{
			return base.Channel.Get_Student_Friends_and_FamilyAsync(request);
		}

		public Task<Get_Student_Friends_and_FamilyOutput> Get_Student_Friends_and_FamilyAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Friends_and_Family_RequestType Get_Student_Friends_and_Family_Request)
		{
			return ((Academic_FoundationPort)this).Get_Student_Friends_and_FamilyAsync(new Get_Student_Friends_and_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Friends_and_Family_Request = Get_Student_Friends_and_Family_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Friends_and_FamilyOutput Academic_FoundationPort.Put_Student_Friends_and_Family(Put_Student_Friends_and_FamilyInput request)
		{
			return base.Channel.Put_Student_Friends_and_Family(request);
		}

		public Put_Student_Friends_and_Family_ResponseType Put_Student_Friends_and_Family(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Friends_and_Family_RequestType Put_Student_Friends_and_Family_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Friends_and_Family(new Put_Student_Friends_and_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Friends_and_Family_Request = Put_Student_Friends_and_Family_Request
			}).Put_Student_Friends_and_Family_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Friends_and_FamilyOutput> Academic_FoundationPort.Put_Student_Friends_and_FamilyAsync(Put_Student_Friends_and_FamilyInput request)
		{
			return base.Channel.Put_Student_Friends_and_FamilyAsync(request);
		}

		public Task<Put_Student_Friends_and_FamilyOutput> Put_Student_Friends_and_FamilyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Friends_and_Family_RequestType Put_Student_Friends_and_Family_Request)
		{
			return ((Academic_FoundationPort)this).Put_Student_Friends_and_FamilyAsync(new Put_Student_Friends_and_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Friends_and_Family_Request = Put_Student_Friends_and_Family_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Universal_IdentifierOutput Academic_FoundationPort.Get_Universal_Identifier(Get_Universal_IdentifierInput request)
		{
			return base.Channel.Get_Universal_Identifier(request);
		}

		public Get_Universal_Identifiers_ResponseType Get_Universal_Identifier(Workday_Common_HeaderType Workday_Common_Header, Get_Universal_Identifiers_RequestType Get_Universal_Identifiers_Request)
		{
			return ((Academic_FoundationPort)this).Get_Universal_Identifier(new Get_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Universal_Identifiers_Request = Get_Universal_Identifiers_Request
			}).Get_Universal_Identifiers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Universal_IdentifierOutput> Academic_FoundationPort.Get_Universal_IdentifierAsync(Get_Universal_IdentifierInput request)
		{
			return base.Channel.Get_Universal_IdentifierAsync(request);
		}

		public Task<Get_Universal_IdentifierOutput> Get_Universal_IdentifierAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Universal_Identifiers_RequestType Get_Universal_Identifiers_Request)
		{
			return ((Academic_FoundationPort)this).Get_Universal_IdentifierAsync(new Get_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Universal_Identifiers_Request = Get_Universal_Identifiers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Universal_IdentifierOutput Academic_FoundationPort.Put_Universal_Identifier(Put_Universal_IdentifierInput request)
		{
			return base.Channel.Put_Universal_Identifier(request);
		}

		public Put_Universal_Identifier_ResponseType Put_Universal_Identifier(Workday_Common_HeaderType Workday_Common_Header, Put_Universal_Identifier_RequestType Put_Universal_Identifier_Request)
		{
			return ((Academic_FoundationPort)this).Put_Universal_Identifier(new Put_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Universal_Identifier_Request = Put_Universal_Identifier_Request
			}).Put_Universal_Identifier_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Universal_IdentifierOutput> Academic_FoundationPort.Put_Universal_IdentifierAsync(Put_Universal_IdentifierInput request)
		{
			return base.Channel.Put_Universal_IdentifierAsync(request);
		}

		public Task<Put_Universal_IdentifierOutput> Put_Universal_IdentifierAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Universal_Identifier_RequestType Put_Universal_Identifier_Request)
		{
			return ((Academic_FoundationPort)this).Put_Universal_IdentifierAsync(new Put_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Universal_Identifier_Request = Put_Universal_Identifier_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Education_Test_ResultsOutput Academic_FoundationPort.Import_Education_Test_Results(Import_Education_Test_ResultsInput request)
		{
			return base.Channel.Import_Education_Test_Results(request);
		}

		public Put_Import_Process_ResponseType Import_Education_Test_Results(Workday_Common_HeaderType Workday_Common_Header, Import_Education_Test_Result_RequestType Import_Education_Test_Result_Request)
		{
			return ((Academic_FoundationPort)this).Import_Education_Test_Results(new Import_Education_Test_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Education_Test_Result_Request = Import_Education_Test_Result_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Education_Test_ResultsOutput> Academic_FoundationPort.Import_Education_Test_ResultsAsync(Import_Education_Test_ResultsInput request)
		{
			return base.Channel.Import_Education_Test_ResultsAsync(request);
		}

		public Task<Import_Education_Test_ResultsOutput> Import_Education_Test_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Education_Test_Result_RequestType Import_Education_Test_Result_Request)
		{
			return ((Academic_FoundationPort)this).Import_Education_Test_ResultsAsync(new Import_Education_Test_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Education_Test_Result_Request = Import_Education_Test_Result_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Education_Test_ResultsOutput Academic_FoundationPort.Import_Student_Personal_Information(Import_Student_Personal_InformationInput request)
		{
			return base.Channel.Import_Student_Personal_Information(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Personal_Information(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Personal_Information_RequestType Import_Student_Personal_Information_Request)
		{
			return ((Academic_FoundationPort)this).Import_Student_Personal_Information(new Import_Student_Personal_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Personal_Information_Request = Import_Student_Personal_Information_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Education_Test_ResultsOutput> Academic_FoundationPort.Import_Student_Personal_InformationAsync(Import_Student_Personal_InformationInput request)
		{
			return base.Channel.Import_Student_Personal_InformationAsync(request);
		}

		public Task<Import_Education_Test_ResultsOutput> Import_Student_Personal_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Personal_Information_RequestType Import_Student_Personal_Information_Request)
		{
			return ((Academic_FoundationPort)this).Import_Student_Personal_InformationAsync(new Import_Student_Personal_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Personal_Information_Request = Import_Student_Personal_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Education_Test_ResultsOutput Academic_FoundationPort.Import_Universal_Identifiers(Import_Universal_IdentifiersInput request)
		{
			return base.Channel.Import_Universal_Identifiers(request);
		}

		public Put_Import_Process_ResponseType Import_Universal_Identifiers(Workday_Common_HeaderType Workday_Common_Header, Import_Universal_Identifier_RequestType Import_Universal_Identifier_Request)
		{
			return ((Academic_FoundationPort)this).Import_Universal_Identifiers(new Import_Universal_IdentifiersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Universal_Identifier_Request = Import_Universal_Identifier_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Education_Test_ResultsOutput> Academic_FoundationPort.Import_Universal_IdentifiersAsync(Import_Universal_IdentifiersInput request)
		{
			return base.Channel.Import_Universal_IdentifiersAsync(request);
		}

		public Task<Import_Education_Test_ResultsOutput> Import_Universal_IdentifiersAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Universal_Identifier_RequestType Import_Universal_Identifier_Request)
		{
			return ((Academic_FoundationPort)this).Import_Universal_IdentifiersAsync(new Import_Universal_IdentifiersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Universal_Identifier_Request = Import_Universal_Identifier_Request
			});
		}
	}
}
