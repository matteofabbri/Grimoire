using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Performance_ManagementPortClient : ClientBase<Performance_ManagementPort>, Performance_ManagementPort
	{
		public Performance_ManagementPortClient()
		{
		}

		public Performance_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Performance_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Performance_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Performance_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Start_Performance_ReviewOutput Performance_ManagementPort.Start_Performance_Review(Start_Performance_ReviewInput request)
		{
			return base.Channel.Start_Performance_Review(request);
		}

		public Start_Performance_Review_ResponseType Start_Performance_Review(Workday_Common_HeaderType Workday_Common_Header, Start_Performance_Review_RequestType Start_Performance_Review_Request)
		{
			return ((Performance_ManagementPort)this).Start_Performance_Review(new Start_Performance_ReviewInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Start_Performance_Review_Request = Start_Performance_Review_Request
			}).Start_Performance_Review_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Start_Performance_ReviewOutput> Performance_ManagementPort.Start_Performance_ReviewAsync(Start_Performance_ReviewInput request)
		{
			return base.Channel.Start_Performance_ReviewAsync(request);
		}

		public Task<Start_Performance_ReviewOutput> Start_Performance_ReviewAsync(Workday_Common_HeaderType Workday_Common_Header, Start_Performance_Review_RequestType Start_Performance_Review_Request)
		{
			return ((Performance_ManagementPort)this).Start_Performance_ReviewAsync(new Start_Performance_ReviewInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Start_Performance_Review_Request = Start_Performance_Review_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_DegreesOutput Performance_ManagementPort.Get_Degrees(Get_DegreesInput request)
		{
			return base.Channel.Get_Degrees(request);
		}

		public Get_Degrees_ResponseType Get_Degrees(Workday_Common_HeaderType Workday_Common_Header, Get_Degrees_RequestType Get_Degrees_Request)
		{
			return ((Performance_ManagementPort)this).Get_Degrees(new Get_DegreesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Degrees_Request = Get_Degrees_Request
			}).Get_Degrees_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_DegreesOutput> Performance_ManagementPort.Get_DegreesAsync(Get_DegreesInput request)
		{
			return base.Channel.Get_DegreesAsync(request);
		}

		public Task<Get_DegreesOutput> Get_DegreesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Degrees_RequestType Get_Degrees_Request)
		{
			return ((Performance_ManagementPort)this).Get_DegreesAsync(new Get_DegreesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Degrees_Request = Get_Degrees_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DegreeOutput Performance_ManagementPort.Put_Degree(Put_DegreeInput request)
		{
			return base.Channel.Put_Degree(request);
		}

		public Put_Degree_ResponseType Put_Degree(Workday_Common_HeaderType Workday_Common_Header, Put_Degree_RequestType Put_Degree_Request)
		{
			return ((Performance_ManagementPort)this).Put_Degree(new Put_DegreeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Degree_Request = Put_Degree_Request
			}).Put_Degree_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DegreeOutput> Performance_ManagementPort.Put_DegreeAsync(Put_DegreeInput request)
		{
			return base.Channel.Put_DegreeAsync(request);
		}

		public Task<Put_DegreeOutput> Put_DegreeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Degree_RequestType Put_Degree_Request)
		{
			return ((Performance_ManagementPort)this).Put_DegreeAsync(new Put_DegreeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Degree_Request = Put_Degree_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_School_TypesOutput Performance_ManagementPort.Get_School_Types(Get_School_TypesInput request)
		{
			return base.Channel.Get_School_Types(request);
		}

		public Get_School_Types_ResponseType Get_School_Types(Workday_Common_HeaderType Workday_Common_Header, Get_School_Types_RequestType Get_School_Types_Request)
		{
			return ((Performance_ManagementPort)this).Get_School_Types(new Get_School_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_School_Types_Request = Get_School_Types_Request
			}).Get_School_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_School_TypesOutput> Performance_ManagementPort.Get_School_TypesAsync(Get_School_TypesInput request)
		{
			return base.Channel.Get_School_TypesAsync(request);
		}

		public Task<Get_School_TypesOutput> Get_School_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_School_Types_RequestType Get_School_Types_Request)
		{
			return ((Performance_ManagementPort)this).Get_School_TypesAsync(new Get_School_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_School_Types_Request = Get_School_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_School_TypeOutput Performance_ManagementPort.Put_School_Type(Put_School_TypeInput request)
		{
			return base.Channel.Put_School_Type(request);
		}

		public Put_School_Type_ResponseType Put_School_Type(Workday_Common_HeaderType Workday_Common_Header, Put_School_Type_RequestType Put_School_Type_Request)
		{
			return ((Performance_ManagementPort)this).Put_School_Type(new Put_School_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_School_Type_Request = Put_School_Type_Request
			}).Put_School_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_School_TypeOutput> Performance_ManagementPort.Put_School_TypeAsync(Put_School_TypeInput request)
		{
			return base.Channel.Put_School_TypeAsync(request);
		}

		public Task<Put_School_TypeOutput> Put_School_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_School_Type_RequestType Put_School_Type_Request)
		{
			return ((Performance_ManagementPort)this).Put_School_TypeAsync(new Put_School_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_School_Type_Request = Put_School_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Fields_Of_StudyOutput Performance_ManagementPort.Get_Fields_Of_Study(Get_Fields_Of_StudyInput request)
		{
			return base.Channel.Get_Fields_Of_Study(request);
		}

		public Get_Fields_Of_Study_ResponseType Get_Fields_Of_Study(Workday_Common_HeaderType Workday_Common_Header, Get_Fields_Of_Study_RequestType Get_Fields_Of_Study_Request)
		{
			return ((Performance_ManagementPort)this).Get_Fields_Of_Study(new Get_Fields_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fields_Of_Study_Request = Get_Fields_Of_Study_Request
			}).Get_Fields_Of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Fields_Of_StudyOutput> Performance_ManagementPort.Get_Fields_Of_StudyAsync(Get_Fields_Of_StudyInput request)
		{
			return base.Channel.Get_Fields_Of_StudyAsync(request);
		}

		public Task<Get_Fields_Of_StudyOutput> Get_Fields_Of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Fields_Of_Study_RequestType Get_Fields_Of_Study_Request)
		{
			return ((Performance_ManagementPort)this).Get_Fields_Of_StudyAsync(new Get_Fields_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fields_Of_Study_Request = Get_Fields_Of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Field_Of_StudyOutput Performance_ManagementPort.Put_Field_Of_Study(Put_Field_Of_StudyInput request)
		{
			return base.Channel.Put_Field_Of_Study(request);
		}

		public Put_Field_Of_Study_ResponseType Put_Field_Of_Study(Workday_Common_HeaderType Workday_Common_Header, Put_Field_Of_Study_RequestType Put_Field_Of_Study_Request)
		{
			return ((Performance_ManagementPort)this).Put_Field_Of_Study(new Put_Field_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Field_Of_Study_Request = Put_Field_Of_Study_Request
			}).Put_Field_Of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Field_Of_StudyOutput> Performance_ManagementPort.Put_Field_Of_StudyAsync(Put_Field_Of_StudyInput request)
		{
			return base.Channel.Put_Field_Of_StudyAsync(request);
		}

		public Task<Put_Field_Of_StudyOutput> Put_Field_Of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Field_Of_Study_RequestType Put_Field_Of_Study_Request)
		{
			return ((Performance_ManagementPort)this).Put_Field_Of_StudyAsync(new Put_Field_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Field_Of_Study_Request = Put_Field_Of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Competency_CategoriesOutput Performance_ManagementPort.Get_Competency_Categories(Get_Competency_CategoriesInput request)
		{
			return base.Channel.Get_Competency_Categories(request);
		}

		public Get_Competency_Categories_ResponseType Get_Competency_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Categories_RequestType Get_Competency_Categories_Request)
		{
			return ((Performance_ManagementPort)this).Get_Competency_Categories(new Get_Competency_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competency_Categories_Request = Get_Competency_Categories_Request
			}).Get_Competency_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Competency_CategoriesOutput> Performance_ManagementPort.Get_Competency_CategoriesAsync(Get_Competency_CategoriesInput request)
		{
			return base.Channel.Get_Competency_CategoriesAsync(request);
		}

		public Task<Get_Competency_CategoriesOutput> Get_Competency_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Categories_RequestType Get_Competency_Categories_Request)
		{
			return ((Performance_ManagementPort)this).Get_Competency_CategoriesAsync(new Get_Competency_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competency_Categories_Request = Get_Competency_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_GoalsOutput Performance_ManagementPort.Manage_Goals(Manage_GoalsInput request)
		{
			return base.Channel.Manage_Goals(request);
		}

		public Manage_Goals_ResponseType Manage_Goals(Workday_Common_HeaderType Workday_Common_Header, Manage_Goals_RequestType Manage_Goals_Request)
		{
			return ((Performance_ManagementPort)this).Manage_Goals(new Manage_GoalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Goals_Request = Manage_Goals_Request
			}).Manage_Goals_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_GoalsOutput> Performance_ManagementPort.Manage_GoalsAsync(Manage_GoalsInput request)
		{
			return base.Channel.Manage_GoalsAsync(request);
		}

		public Task<Manage_GoalsOutput> Manage_GoalsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Goals_RequestType Manage_Goals_Request)
		{
			return ((Performance_ManagementPort)this).Manage_GoalsAsync(new Manage_GoalsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Goals_Request = Manage_Goals_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Competency_CategoryOutput Performance_ManagementPort.Put_Competency_Category(Put_Competency_CategoryInput request)
		{
			return base.Channel.Put_Competency_Category(request);
		}

		public Put_Competency_Category_ResponseType Put_Competency_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_Category_RequestType Put_Competency_Category_Request)
		{
			return ((Performance_ManagementPort)this).Put_Competency_Category(new Put_Competency_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Category_Request = Put_Competency_Category_Request
			}).Put_Competency_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Competency_CategoryOutput> Performance_ManagementPort.Put_Competency_CategoryAsync(Put_Competency_CategoryInput request)
		{
			return base.Channel.Put_Competency_CategoryAsync(request);
		}

		public Task<Put_Competency_CategoryOutput> Put_Competency_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_Category_RequestType Put_Competency_Category_Request)
		{
			return ((Performance_ManagementPort)this).Put_Competency_CategoryAsync(new Put_Competency_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Category_Request = Put_Competency_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Skill_Source_PrecedencesOutput Performance_ManagementPort.Get_Skill_Source_Precedences(Get_Skill_Source_PrecedencesInput request)
		{
			return base.Channel.Get_Skill_Source_Precedences(request);
		}

		public Get_Skill_Source_Precedences_ResponseType Get_Skill_Source_Precedences(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Source_Precedences_RequestType Get_Skill_Source_Precedences_Request)
		{
			return ((Performance_ManagementPort)this).Get_Skill_Source_Precedences(new Get_Skill_Source_PrecedencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Source_Precedences_Request = Get_Skill_Source_Precedences_Request
			}).Get_Skill_Source_Precedences_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Skill_Source_PrecedencesOutput> Performance_ManagementPort.Get_Skill_Source_PrecedencesAsync(Get_Skill_Source_PrecedencesInput request)
		{
			return base.Channel.Get_Skill_Source_PrecedencesAsync(request);
		}

		public Task<Get_Skill_Source_PrecedencesOutput> Get_Skill_Source_PrecedencesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Source_Precedences_RequestType Get_Skill_Source_Precedences_Request)
		{
			return ((Performance_ManagementPort)this).Get_Skill_Source_PrecedencesAsync(new Get_Skill_Source_PrecedencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Source_Precedences_Request = Get_Skill_Source_Precedences_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CompetenciesOutput Performance_ManagementPort.Get_Competencies(Get_CompetenciesInput request)
		{
			return base.Channel.Get_Competencies(request);
		}

		public Get_Competencies_ResponseType Get_Competencies(Workday_Common_HeaderType Workday_Common_Header, Get_Competencies_RequestType Get_Competencies_Request)
		{
			return ((Performance_ManagementPort)this).Get_Competencies(new Get_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competencies_Request = Get_Competencies_Request
			}).Get_Competencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CompetenciesOutput> Performance_ManagementPort.Get_CompetenciesAsync(Get_CompetenciesInput request)
		{
			return base.Channel.Get_CompetenciesAsync(request);
		}

		public Task<Get_CompetenciesOutput> Get_CompetenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Competencies_RequestType Get_Competencies_Request)
		{
			return ((Performance_ManagementPort)this).Get_CompetenciesAsync(new Get_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competencies_Request = Get_Competencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_CompetencyOutput Performance_ManagementPort.Put_Competency(Put_CompetencyInput request)
		{
			return base.Channel.Put_Competency(request);
		}

		public Put_Competency_ResponseType Put_Competency(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_RequestType Put_Competency_Request)
		{
			return ((Performance_ManagementPort)this).Put_Competency(new Put_CompetencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Request = Put_Competency_Request
			}).Put_Competency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_CompetencyOutput> Performance_ManagementPort.Put_CompetencyAsync(Put_CompetencyInput request)
		{
			return base.Channel.Put_CompetencyAsync(request);
		}

		public Task<Put_CompetencyOutput> Put_CompetencyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_RequestType Put_Competency_Request)
		{
			return ((Performance_ManagementPort)this).Put_CompetencyAsync(new Put_CompetencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Request = Put_Competency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Employee_Review_RatingOutput Performance_ManagementPort.Update_Employee_Review_Rating(Update_Employee_Review_RatingInput request)
		{
			return base.Channel.Update_Employee_Review_Rating(request);
		}

		public Update_Employee_Review_Rating_ResponseType Update_Employee_Review_Rating(Workday_Common_HeaderType Workday_Common_Header, Update_Employee_Review_Rating_RequestType Update_Employee_Review_Rating_Request)
		{
			return ((Performance_ManagementPort)this).Update_Employee_Review_Rating(new Update_Employee_Review_RatingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Employee_Review_Rating_Request = Update_Employee_Review_Rating_Request
			}).Update_Employee_Review_Rating_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Employee_Review_RatingOutput> Performance_ManagementPort.Update_Employee_Review_RatingAsync(Update_Employee_Review_RatingInput request)
		{
			return base.Channel.Update_Employee_Review_RatingAsync(request);
		}

		public Task<Update_Employee_Review_RatingOutput> Update_Employee_Review_RatingAsync(Workday_Common_HeaderType Workday_Common_Header, Update_Employee_Review_Rating_RequestType Update_Employee_Review_Rating_Request)
		{
			return ((Performance_ManagementPort)this).Update_Employee_Review_RatingAsync(new Update_Employee_Review_RatingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Employee_Review_Rating_Request = Update_Employee_Review_Rating_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CertificationsOutput Performance_ManagementPort.Get_Certifications(Get_CertificationsInput request)
		{
			return base.Channel.Get_Certifications(request);
		}

		public Get_Certifications_ResponseType Get_Certifications(Workday_Common_HeaderType Workday_Common_Header, Get_Certifications_RequestType Get_Certifications_Request)
		{
			return ((Performance_ManagementPort)this).Get_Certifications(new Get_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certifications_Request = Get_Certifications_Request
			}).Get_Certifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CertificationsOutput> Performance_ManagementPort.Get_CertificationsAsync(Get_CertificationsInput request)
		{
			return base.Channel.Get_CertificationsAsync(request);
		}

		public Task<Get_CertificationsOutput> Get_CertificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Certifications_RequestType Get_Certifications_Request)
		{
			return ((Performance_ManagementPort)this).Get_CertificationsAsync(new Get_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certifications_Request = Get_Certifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_CertificationOutput Performance_ManagementPort.Put_Certification(Put_CertificationInput request)
		{
			return base.Channel.Put_Certification(request);
		}

		public Put_Certification_ResponseType Put_Certification(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_RequestType Put_Certification_Request)
		{
			return ((Performance_ManagementPort)this).Put_Certification(new Put_CertificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Request = Put_Certification_Request
			}).Put_Certification_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_CertificationOutput> Performance_ManagementPort.Put_CertificationAsync(Put_CertificationInput request)
		{
			return base.Channel.Put_CertificationAsync(request);
		}

		public Task<Put_CertificationOutput> Put_CertificationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_RequestType Put_Certification_Request)
		{
			return ((Performance_ManagementPort)this).Put_CertificationAsync(new Put_CertificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Request = Put_Certification_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Certification_IssuersOutput Performance_ManagementPort.Get_Certification_Issuers(Get_Certification_IssuersInput request)
		{
			return base.Channel.Get_Certification_Issuers(request);
		}

		public Get_Certification_Issuers_ResponseType Get_Certification_Issuers(Workday_Common_HeaderType Workday_Common_Header, Get_Certification_Issuers_RequestType Get_Certification_Issuers_Request)
		{
			return ((Performance_ManagementPort)this).Get_Certification_Issuers(new Get_Certification_IssuersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certification_Issuers_Request = Get_Certification_Issuers_Request
			}).Get_Certification_Issuers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Certification_IssuersOutput> Performance_ManagementPort.Get_Certification_IssuersAsync(Get_Certification_IssuersInput request)
		{
			return base.Channel.Get_Certification_IssuersAsync(request);
		}

		public Task<Get_Certification_IssuersOutput> Get_Certification_IssuersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Certification_Issuers_RequestType Get_Certification_Issuers_Request)
		{
			return ((Performance_ManagementPort)this).Get_Certification_IssuersAsync(new Get_Certification_IssuersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certification_Issuers_Request = Get_Certification_Issuers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Certification_IssuerOutput Performance_ManagementPort.Put_Certification_Issuer(Put_Certification_IssuerInput request)
		{
			return base.Channel.Put_Certification_Issuer(request);
		}

		public Put_Certification_Issuer_ResponseType Put_Certification_Issuer(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_Issuer_RequestType Put_Certification_Issuer_Request)
		{
			return ((Performance_ManagementPort)this).Put_Certification_Issuer(new Put_Certification_IssuerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Issuer_Request = Put_Certification_Issuer_Request
			}).Put_Certification_Issuer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Certification_IssuerOutput> Performance_ManagementPort.Put_Certification_IssuerAsync(Put_Certification_IssuerInput request)
		{
			return base.Channel.Put_Certification_IssuerAsync(request);
		}

		public Task<Put_Certification_IssuerOutput> Put_Certification_IssuerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_Issuer_RequestType Put_Certification_Issuer_Request)
		{
			return ((Performance_ManagementPort)this).Put_Certification_IssuerAsync(new Put_Certification_IssuerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Issuer_Request = Put_Certification_Issuer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Goal_UnitsOutput Performance_ManagementPort.Get_Goal_Units(Get_Goal_UnitsInput request)
		{
			return base.Channel.Get_Goal_Units(request);
		}

		public Get_Goal_Units_ResponseType Get_Goal_Units(Workday_Common_HeaderType Workday_Common_Header, Get_Goal_Units_RequestType Get_Goal_Units_Request)
		{
			return ((Performance_ManagementPort)this).Get_Goal_Units(new Get_Goal_UnitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Goal_Units_Request = Get_Goal_Units_Request
			}).Get_Goal_Units_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Goal_UnitsOutput> Performance_ManagementPort.Get_Goal_UnitsAsync(Get_Goal_UnitsInput request)
		{
			return base.Channel.Get_Goal_UnitsAsync(request);
		}

		public Task<Get_Goal_UnitsOutput> Get_Goal_UnitsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Goal_Units_RequestType Get_Goal_Units_Request)
		{
			return ((Performance_ManagementPort)this).Get_Goal_UnitsAsync(new Get_Goal_UnitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Goal_Units_Request = Get_Goal_Units_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Goal_UnitOutput Performance_ManagementPort.Put_Goal_Unit(Put_Goal_UnitInput request)
		{
			return base.Channel.Put_Goal_Unit(request);
		}

		public Put_Goal_Unit_ResponseType Put_Goal_Unit(Workday_Common_HeaderType Workday_Common_Header, Put_Goal_Unit_RequestType Put_Goal_Unit_Request)
		{
			return ((Performance_ManagementPort)this).Put_Goal_Unit(new Put_Goal_UnitInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Goal_Unit_Request = Put_Goal_Unit_Request
			}).Put_Goal_Unit_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Goal_UnitOutput> Performance_ManagementPort.Put_Goal_UnitAsync(Put_Goal_UnitInput request)
		{
			return base.Channel.Put_Goal_UnitAsync(request);
		}

		public Task<Put_Goal_UnitOutput> Put_Goal_UnitAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Goal_Unit_RequestType Put_Goal_Unit_Request)
		{
			return ((Performance_ManagementPort)this).Put_Goal_UnitAsync(new Put_Goal_UnitInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Goal_Unit_Request = Put_Goal_Unit_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Feedback_BadgesOutput Performance_ManagementPort.Get_Feedback_Badges(Get_Feedback_BadgesInput request)
		{
			return base.Channel.Get_Feedback_Badges(request);
		}

		public Get_Feedback_Badges_ResponseType Get_Feedback_Badges(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_Badges_RequestType Get_Feedback_Badges_Request)
		{
			return ((Performance_ManagementPort)this).Get_Feedback_Badges(new Get_Feedback_BadgesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Feedback_Badges_Request = Get_Feedback_Badges_Request
			}).Get_Feedback_Badges_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Feedback_BadgesOutput> Performance_ManagementPort.Get_Feedback_BadgesAsync(Get_Feedback_BadgesInput request)
		{
			return base.Channel.Get_Feedback_BadgesAsync(request);
		}

		public Task<Get_Feedback_BadgesOutput> Get_Feedback_BadgesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_Badges_RequestType Get_Feedback_Badges_Request)
		{
			return ((Performance_ManagementPort)this).Get_Feedback_BadgesAsync(new Get_Feedback_BadgesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Feedback_Badges_Request = Get_Feedback_Badges_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Feedback_BadgeOutput Performance_ManagementPort.Put_Feedback_Badge(Put_Feedback_BadgeInput request)
		{
			return base.Channel.Put_Feedback_Badge(request);
		}

		public Put_Feedback_Badge_ResponseType Put_Feedback_Badge(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_Badge_RequestType Put_Feedback_Badge_Request)
		{
			return ((Performance_ManagementPort)this).Put_Feedback_Badge(new Put_Feedback_BadgeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Feedback_Badge_Request = Put_Feedback_Badge_Request
			}).Put_Feedback_Badge_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Feedback_BadgeOutput> Performance_ManagementPort.Put_Feedback_BadgeAsync(Put_Feedback_BadgeInput request)
		{
			return base.Channel.Put_Feedback_BadgeAsync(request);
		}

		public Task<Put_Feedback_BadgeOutput> Put_Feedback_BadgeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_Badge_RequestType Put_Feedback_Badge_Request)
		{
			return ((Performance_ManagementPort)this).Put_Feedback_BadgeAsync(new Put_Feedback_BadgeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Feedback_Badge_Request = Put_Feedback_Badge_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Review_TypesOutput Performance_ManagementPort.Get_Review_Types(Get_Review_TypesInput request)
		{
			return base.Channel.Get_Review_Types(request);
		}

		public Get_Review_Types_ResponseType Get_Review_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Review_Types_RequestType Get_Review_Types_Request)
		{
			return ((Performance_ManagementPort)this).Get_Review_Types(new Get_Review_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Review_Types_Request = Get_Review_Types_Request
			}).Get_Review_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Review_TypesOutput> Performance_ManagementPort.Get_Review_TypesAsync(Get_Review_TypesInput request)
		{
			return base.Channel.Get_Review_TypesAsync(request);
		}

		public Task<Get_Review_TypesOutput> Get_Review_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Review_Types_RequestType Get_Review_Types_Request)
		{
			return ((Performance_ManagementPort)this).Get_Review_TypesAsync(new Get_Review_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Review_Types_Request = Get_Review_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Review_TypeOutput Performance_ManagementPort.Put_Review_Type(Put_Review_TypeInput request)
		{
			return base.Channel.Put_Review_Type(request);
		}

		public Put_Review_Type_ResponseType Put_Review_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Review_Type_RequestType Put_Review_Type_Request)
		{
			return ((Performance_ManagementPort)this).Put_Review_Type(new Put_Review_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Review_Type_Request = Put_Review_Type_Request
			}).Put_Review_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Review_TypeOutput> Performance_ManagementPort.Put_Review_TypeAsync(Put_Review_TypeInput request)
		{
			return base.Channel.Put_Review_TypeAsync(request);
		}

		public Task<Put_Review_TypeOutput> Put_Review_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Review_Type_RequestType Put_Review_Type_Request)
		{
			return ((Performance_ManagementPort)this).Put_Review_TypeAsync(new Put_Review_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Review_Type_Request = Put_Review_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Feedback_and_Review_Question_CategoriesOutput Performance_ManagementPort.Get_Feedback_and_Review_Question_Categories(Get_Feedback_and_Review_Question_CategoriesInput request)
		{
			return base.Channel.Get_Feedback_and_Review_Question_Categories(request);
		}

		public Get_Feedback_and_Review_Question_Categories_ResponseType Get_Feedback_and_Review_Question_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_and_Review_Question_Categories_RequestType Get_Feedback_and_Review_Question_Categories_Request)
		{
			return ((Performance_ManagementPort)this).Get_Feedback_and_Review_Question_Categories(new Get_Feedback_and_Review_Question_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Feedback_and_Review_Question_Categories_Request = Get_Feedback_and_Review_Question_Categories_Request
			}).Get_Feedback_and_Review_Question_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Feedback_and_Review_Question_CategoriesOutput> Performance_ManagementPort.Get_Feedback_and_Review_Question_CategoriesAsync(Get_Feedback_and_Review_Question_CategoriesInput request)
		{
			return base.Channel.Get_Feedback_and_Review_Question_CategoriesAsync(request);
		}

		public Task<Get_Feedback_and_Review_Question_CategoriesOutput> Get_Feedback_and_Review_Question_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_and_Review_Question_Categories_RequestType Get_Feedback_and_Review_Question_Categories_Request)
		{
			return ((Performance_ManagementPort)this).Get_Feedback_and_Review_Question_CategoriesAsync(new Get_Feedback_and_Review_Question_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Feedback_and_Review_Question_Categories_Request = Get_Feedback_and_Review_Question_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Feedback_and_Review_QuestionsOutput Performance_ManagementPort.Get_Feedback_and_Review_Questions(Get_Feedback_and_Review_QuestionsInput request)
		{
			return base.Channel.Get_Feedback_and_Review_Questions(request);
		}

		public Get_Feedback_and_Review_Questions_ResponseType Get_Feedback_and_Review_Questions(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_and_Review_Questions_RequestType Get_Feedback_and_Review_Questions_Request)
		{
			return ((Performance_ManagementPort)this).Get_Feedback_and_Review_Questions(new Get_Feedback_and_Review_QuestionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Feedback_and_Review_Questions_Request = Get_Feedback_and_Review_Questions_Request
			}).Get_Feedback_and_Review_Questions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Feedback_and_Review_QuestionsOutput> Performance_ManagementPort.Get_Feedback_and_Review_QuestionsAsync(Get_Feedback_and_Review_QuestionsInput request)
		{
			return base.Channel.Get_Feedback_and_Review_QuestionsAsync(request);
		}

		public Task<Get_Feedback_and_Review_QuestionsOutput> Get_Feedback_and_Review_QuestionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_and_Review_Questions_RequestType Get_Feedback_and_Review_Questions_Request)
		{
			return ((Performance_ManagementPort)this).Get_Feedback_and_Review_QuestionsAsync(new Get_Feedback_and_Review_QuestionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Feedback_and_Review_Questions_Request = Get_Feedback_and_Review_Questions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Feedback_and_Review_Question_CategoryOutput Performance_ManagementPort.Put_Feedback_and_Review_Question_Category(Put_Feedback_and_Review_Question_CategoryInput request)
		{
			return base.Channel.Put_Feedback_and_Review_Question_Category(request);
		}

		public Put_Feedback_and_Review_Question_Category_ResponseType Put_Feedback_and_Review_Question_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_and_Review_Question_Category_RequestType Put_Feedback_and_Review_Question_Category_Request)
		{
			return ((Performance_ManagementPort)this).Put_Feedback_and_Review_Question_Category(new Put_Feedback_and_Review_Question_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Feedback_and_Review_Question_Category_Request = Put_Feedback_and_Review_Question_Category_Request
			}).Put_Feedback_and_Review_Question_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Feedback_and_Review_Question_CategoryOutput> Performance_ManagementPort.Put_Feedback_and_Review_Question_CategoryAsync(Put_Feedback_and_Review_Question_CategoryInput request)
		{
			return base.Channel.Put_Feedback_and_Review_Question_CategoryAsync(request);
		}

		public Task<Put_Feedback_and_Review_Question_CategoryOutput> Put_Feedback_and_Review_Question_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_and_Review_Question_Category_RequestType Put_Feedback_and_Review_Question_Category_Request)
		{
			return ((Performance_ManagementPort)this).Put_Feedback_and_Review_Question_CategoryAsync(new Put_Feedback_and_Review_Question_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Feedback_and_Review_Question_Category_Request = Put_Feedback_and_Review_Question_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Feedback_and_Review_QuestionOutput Performance_ManagementPort.Put_Feedback_and_Review_Question(Put_Feedback_and_Review_QuestionInput request)
		{
			return base.Channel.Put_Feedback_and_Review_Question(request);
		}

		public Put_Feedback_and_Review_Question_ResponseType Put_Feedback_and_Review_Question(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_and_Review_Question_RequestType Put_Feedback_and_Review_Question_Request)
		{
			return ((Performance_ManagementPort)this).Put_Feedback_and_Review_Question(new Put_Feedback_and_Review_QuestionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Feedback_and_Review_Question_Request = Put_Feedback_and_Review_Question_Request
			}).Put_Feedback_and_Review_Question_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Feedback_and_Review_QuestionOutput> Performance_ManagementPort.Put_Feedback_and_Review_QuestionAsync(Put_Feedback_and_Review_QuestionInput request)
		{
			return base.Channel.Put_Feedback_and_Review_QuestionAsync(request);
		}

		public Task<Put_Feedback_and_Review_QuestionOutput> Put_Feedback_and_Review_QuestionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_and_Review_Question_RequestType Put_Feedback_and_Review_Question_Request)
		{
			return ((Performance_ManagementPort)this).Put_Feedback_and_Review_QuestionAsync(new Put_Feedback_and_Review_QuestionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Feedback_and_Review_Question_Request = Put_Feedback_and_Review_Question_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_ReviewsOutput Performance_ManagementPort.Get_Employee_Reviews(Get_Employee_ReviewsInput request)
		{
			return base.Channel.Get_Employee_Reviews(request);
		}

		public Get_Employee_Reviews_ResponseType Get_Employee_Reviews(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Reviews_RequestType Get_Employee_Reviews_Request)
		{
			return ((Performance_ManagementPort)this).Get_Employee_Reviews(new Get_Employee_ReviewsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Employee_Reviews_Request = Get_Employee_Reviews_Request
			}).Get_Employee_Reviews_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_ReviewsOutput> Performance_ManagementPort.Get_Employee_ReviewsAsync(Get_Employee_ReviewsInput request)
		{
			return base.Channel.Get_Employee_ReviewsAsync(request);
		}

		public Task<Get_Employee_ReviewsOutput> Get_Employee_ReviewsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Employee_Reviews_RequestType Get_Employee_Reviews_Request)
		{
			return ((Performance_ManagementPort)this).Get_Employee_ReviewsAsync(new Get_Employee_ReviewsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Employee_Reviews_Request = Get_Employee_Reviews_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Employee_ReviewsOutput Performance_ManagementPort.Import_Employee_Reviews(Import_Employee_ReviewsInput request)
		{
			return base.Channel.Import_Employee_Reviews(request);
		}

		public Put_Import_Process_ResponseType Import_Employee_Reviews(Workday_Common_HeaderType Workday_Common_Header, Import_Employee_Reviews_RequestType Import_Employee_Reviews_Request)
		{
			return ((Performance_ManagementPort)this).Import_Employee_Reviews(new Import_Employee_ReviewsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Employee_Reviews_Request = Import_Employee_Reviews_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Employee_ReviewsOutput> Performance_ManagementPort.Import_Employee_ReviewsAsync(Import_Employee_ReviewsInput request)
		{
			return base.Channel.Import_Employee_ReviewsAsync(request);
		}

		public Task<Import_Employee_ReviewsOutput> Import_Employee_ReviewsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Employee_Reviews_RequestType Import_Employee_Reviews_Request)
		{
			return ((Performance_ManagementPort)this).Import_Employee_ReviewsAsync(new Import_Employee_ReviewsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Employee_Reviews_Request = Import_Employee_Reviews_Request
			});
		}
	}
}
