using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class TalentPortClient : ClientBase<TalentPort>, TalentPort
	{
		public TalentPortClient()
		{
		}

		public TalentPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public TalentPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public TalentPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public TalentPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assess_TalentOutput TalentPort.Assess_Talent(Assess_TalentInput request)
		{
			return base.Channel.Assess_Talent(request);
		}

		public Assess_Talent_ResponseType Assess_Talent(Workday_Common_HeaderType Workday_Common_Header, Assess_Talent_RequestType Assess_Talent_Request)
		{
			return ((TalentPort)this).Assess_Talent(new Assess_TalentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assess_Talent_Request = Assess_Talent_Request
			}).Assess_Talent_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assess_TalentOutput> TalentPort.Assess_TalentAsync(Assess_TalentInput request)
		{
			return base.Channel.Assess_TalentAsync(request);
		}

		public Task<Assess_TalentOutput> Assess_TalentAsync(Workday_Common_HeaderType Workday_Common_Header, Assess_Talent_RequestType Assess_Talent_Request)
		{
			return ((TalentPort)this).Assess_TalentAsync(new Assess_TalentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assess_Talent_Request = Assess_Talent_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Succession_PlanOutput TalentPort.Manage_Succession_Plan(Manage_Succession_PlanInput request)
		{
			return base.Channel.Manage_Succession_Plan(request);
		}

		public Manage_Succession_Plan_ResponseType Manage_Succession_Plan(Workday_Common_HeaderType Workday_Common_Header, Manage_Succession_Plan_RequestType Manage_Succession_Plan_Request)
		{
			return ((TalentPort)this).Manage_Succession_Plan(new Manage_Succession_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Succession_Plan_Request = Manage_Succession_Plan_Request
			}).Manage_Succession_Plan_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Succession_PlanOutput> TalentPort.Manage_Succession_PlanAsync(Manage_Succession_PlanInput request)
		{
			return base.Channel.Manage_Succession_PlanAsync(request);
		}

		public Task<Manage_Succession_PlanOutput> Manage_Succession_PlanAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Succession_Plan_RequestType Manage_Succession_Plan_Request)
		{
			return ((TalentPort)this).Manage_Succession_PlanAsync(new Manage_Succession_PlanInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Succession_Plan_Request = Manage_Succession_Plan_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Position_for_SuccessionOutput TalentPort.Put_Position_for_Succession(Put_Position_for_SuccessionInput request)
		{
			return base.Channel.Put_Position_for_Succession(request);
		}

		public Put_Position_for_Succession_ResponseType Put_Position_for_Succession(Workday_Common_HeaderType Workday_Common_Header, Put_Position_for_Succession_RequestType Put_Position_for_Succession_Request)
		{
			return ((TalentPort)this).Put_Position_for_Succession(new Put_Position_for_SuccessionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Position_for_Succession_Request = Put_Position_for_Succession_Request
			}).Put_Position_for_Succession_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Position_for_SuccessionOutput> TalentPort.Put_Position_for_SuccessionAsync(Put_Position_for_SuccessionInput request)
		{
			return base.Channel.Put_Position_for_SuccessionAsync(request);
		}

		public Task<Put_Position_for_SuccessionOutput> Put_Position_for_SuccessionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Position_for_Succession_RequestType Put_Position_for_Succession_Request)
		{
			return ((TalentPort)this).Put_Position_for_SuccessionAsync(new Put_Position_for_SuccessionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Position_for_Succession_Request = Put_Position_for_Succession_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_DegreesOutput TalentPort.Get_Degrees(Get_DegreesInput request)
		{
			return base.Channel.Get_Degrees(request);
		}

		public Get_Degrees_ResponseType Get_Degrees(Workday_Common_HeaderType Workday_Common_Header, Get_Degrees_RequestType Get_Degrees_Request)
		{
			return ((TalentPort)this).Get_Degrees(new Get_DegreesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Degrees_Request = Get_Degrees_Request
			}).Get_Degrees_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_DegreesOutput> TalentPort.Get_DegreesAsync(Get_DegreesInput request)
		{
			return base.Channel.Get_DegreesAsync(request);
		}

		public Task<Get_DegreesOutput> Get_DegreesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Degrees_RequestType Get_Degrees_Request)
		{
			return ((TalentPort)this).Get_DegreesAsync(new Get_DegreesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Degrees_Request = Get_Degrees_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DegreeOutput TalentPort.Put_Degree(Put_DegreeInput request)
		{
			return base.Channel.Put_Degree(request);
		}

		public Put_Degree_ResponseType Put_Degree(Workday_Common_HeaderType Workday_Common_Header, Put_Degree_RequestType Put_Degree_Request)
		{
			return ((TalentPort)this).Put_Degree(new Put_DegreeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Degree_Request = Put_Degree_Request
			}).Put_Degree_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DegreeOutput> TalentPort.Put_DegreeAsync(Put_DegreeInput request)
		{
			return base.Channel.Put_DegreeAsync(request);
		}

		public Task<Put_DegreeOutput> Put_DegreeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Degree_RequestType Put_Degree_Request)
		{
			return ((TalentPort)this).Put_DegreeAsync(new Put_DegreeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Degree_Request = Put_Degree_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_School_TypesOutput TalentPort.Get_School_Types(Get_School_TypesInput request)
		{
			return base.Channel.Get_School_Types(request);
		}

		public Get_School_Types_ResponseType Get_School_Types(Workday_Common_HeaderType Workday_Common_Header, Get_School_Types_RequestType Get_School_Types_Request)
		{
			return ((TalentPort)this).Get_School_Types(new Get_School_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_School_Types_Request = Get_School_Types_Request
			}).Get_School_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_School_TypesOutput> TalentPort.Get_School_TypesAsync(Get_School_TypesInput request)
		{
			return base.Channel.Get_School_TypesAsync(request);
		}

		public Task<Get_School_TypesOutput> Get_School_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_School_Types_RequestType Get_School_Types_Request)
		{
			return ((TalentPort)this).Get_School_TypesAsync(new Get_School_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_School_Types_Request = Get_School_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_School_TypeOutput TalentPort.Put_School_Type(Put_School_TypeInput request)
		{
			return base.Channel.Put_School_Type(request);
		}

		public Put_School_Type_ResponseType Put_School_Type(Workday_Common_HeaderType Workday_Common_Header, Put_School_Type_RequestType Put_School_Type_Request)
		{
			return ((TalentPort)this).Put_School_Type(new Put_School_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_School_Type_Request = Put_School_Type_Request
			}).Put_School_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_School_TypeOutput> TalentPort.Put_School_TypeAsync(Put_School_TypeInput request)
		{
			return base.Channel.Put_School_TypeAsync(request);
		}

		public Task<Put_School_TypeOutput> Put_School_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_School_Type_RequestType Put_School_Type_Request)
		{
			return ((TalentPort)this).Put_School_TypeAsync(new Put_School_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_School_Type_Request = Put_School_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_CertificationsOutput TalentPort.Manage_Certifications(Manage_CertificationsInput request)
		{
			return base.Channel.Manage_Certifications(request);
		}

		public Manage_Certifications_ResponseType Manage_Certifications(Workday_Common_HeaderType Workday_Common_Header, Manage_Certifications_RequestType Manage_Certifications_Request)
		{
			return ((TalentPort)this).Manage_Certifications(new Manage_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Certifications_Request = Manage_Certifications_Request
			}).Manage_Certifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_CertificationsOutput> TalentPort.Manage_CertificationsAsync(Manage_CertificationsInput request)
		{
			return base.Channel.Manage_CertificationsAsync(request);
		}

		public Task<Manage_CertificationsOutput> Manage_CertificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Certifications_RequestType Manage_Certifications_Request)
		{
			return ((TalentPort)this).Manage_CertificationsAsync(new Manage_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Certifications_Request = Manage_Certifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Manage_CertificationsOutput TalentPort.Get_Manage_Certifications(Get_Manage_CertificationsInput request)
		{
			return base.Channel.Get_Manage_Certifications(request);
		}

		public Get_Manage_Certifications_ResponseType Get_Manage_Certifications(Workday_Common_HeaderType Workday_Common_Header, Get_Manage_Certifications_RequestType Get_Manage_Certifications_Request)
		{
			return ((TalentPort)this).Get_Manage_Certifications(new Get_Manage_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Manage_Certifications_Request = Get_Manage_Certifications_Request
			}).Get_Manage_Certifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Manage_CertificationsOutput> TalentPort.Get_Manage_CertificationsAsync(Get_Manage_CertificationsInput request)
		{
			return base.Channel.Get_Manage_CertificationsAsync(request);
		}

		public Task<Get_Manage_CertificationsOutput> Get_Manage_CertificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Manage_Certifications_RequestType Get_Manage_Certifications_Request)
		{
			return ((TalentPort)this).Get_Manage_CertificationsAsync(new Get_Manage_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Manage_Certifications_Request = Get_Manage_Certifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_CompetenciesOutput TalentPort.Manage_Competencies(Manage_CompetenciesInput request)
		{
			return base.Channel.Manage_Competencies(request);
		}

		public Manage_Competencies_ResponseType Manage_Competencies(Workday_Common_HeaderType Workday_Common_Header, Manage_Competencies_RequestType Manage_Competencies_Request)
		{
			return ((TalentPort)this).Manage_Competencies(new Manage_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Competencies_Request = Manage_Competencies_Request
			}).Manage_Competencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_CompetenciesOutput> TalentPort.Manage_CompetenciesAsync(Manage_CompetenciesInput request)
		{
			return base.Channel.Manage_CompetenciesAsync(request);
		}

		public Task<Manage_CompetenciesOutput> Manage_CompetenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Competencies_RequestType Manage_Competencies_Request)
		{
			return ((TalentPort)this).Manage_CompetenciesAsync(new Manage_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Competencies_Request = Manage_Competencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Fields_Of_StudyOutput TalentPort.Get_Fields_Of_Study(Get_Fields_Of_StudyInput request)
		{
			return base.Channel.Get_Fields_Of_Study(request);
		}

		public Get_Fields_Of_Study_ResponseType Get_Fields_Of_Study(Workday_Common_HeaderType Workday_Common_Header, Get_Fields_Of_Study_RequestType Get_Fields_Of_Study_Request)
		{
			return ((TalentPort)this).Get_Fields_Of_Study(new Get_Fields_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fields_Of_Study_Request = Get_Fields_Of_Study_Request
			}).Get_Fields_Of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Fields_Of_StudyOutput> TalentPort.Get_Fields_Of_StudyAsync(Get_Fields_Of_StudyInput request)
		{
			return base.Channel.Get_Fields_Of_StudyAsync(request);
		}

		public Task<Get_Fields_Of_StudyOutput> Get_Fields_Of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Fields_Of_Study_RequestType Get_Fields_Of_Study_Request)
		{
			return ((TalentPort)this).Get_Fields_Of_StudyAsync(new Get_Fields_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Fields_Of_Study_Request = Get_Fields_Of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Field_Of_StudyOutput TalentPort.Put_Field_Of_Study(Put_Field_Of_StudyInput request)
		{
			return base.Channel.Put_Field_Of_Study(request);
		}

		public Put_Field_Of_Study_ResponseType Put_Field_Of_Study(Workday_Common_HeaderType Workday_Common_Header, Put_Field_Of_Study_RequestType Put_Field_Of_Study_Request)
		{
			return ((TalentPort)this).Put_Field_Of_Study(new Put_Field_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Field_Of_Study_Request = Put_Field_Of_Study_Request
			}).Put_Field_Of_Study_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Field_Of_StudyOutput> TalentPort.Put_Field_Of_StudyAsync(Put_Field_Of_StudyInput request)
		{
			return base.Channel.Put_Field_Of_StudyAsync(request);
		}

		public Task<Put_Field_Of_StudyOutput> Put_Field_Of_StudyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Field_Of_Study_RequestType Put_Field_Of_Study_Request)
		{
			return ((TalentPort)this).Put_Field_Of_StudyAsync(new Put_Field_Of_StudyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Field_Of_Study_Request = Put_Field_Of_Study_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Competency_CategoriesOutput TalentPort.Get_Competency_Categories(Get_Competency_CategoriesInput request)
		{
			return base.Channel.Get_Competency_Categories(request);
		}

		public Get_Competency_Categories_ResponseType Get_Competency_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Categories_RequestType Get_Competency_Categories_Request)
		{
			return ((TalentPort)this).Get_Competency_Categories(new Get_Competency_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competency_Categories_Request = Get_Competency_Categories_Request
			}).Get_Competency_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Competency_CategoriesOutput> TalentPort.Get_Competency_CategoriesAsync(Get_Competency_CategoriesInput request)
		{
			return base.Channel.Get_Competency_CategoriesAsync(request);
		}

		public Task<Get_Competency_CategoriesOutput> Get_Competency_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Categories_RequestType Get_Competency_Categories_Request)
		{
			return ((TalentPort)this).Get_Competency_CategoriesAsync(new Get_Competency_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competency_Categories_Request = Get_Competency_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_TrainingOutput TalentPort.Manage_Training(Manage_TrainingInput request)
		{
			return base.Channel.Manage_Training(request);
		}

		public Manage_Training_ResponseType Manage_Training(Workday_Common_HeaderType Workday_Common_Header, Manage_Training_RequestType Manage_Training_Request)
		{
			return ((TalentPort)this).Manage_Training(new Manage_TrainingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Training_Request = Manage_Training_Request
			}).Manage_Training_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_TrainingOutput> TalentPort.Manage_TrainingAsync(Manage_TrainingInput request)
		{
			return base.Channel.Manage_TrainingAsync(request);
		}

		public Task<Manage_TrainingOutput> Manage_TrainingAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Training_RequestType Manage_Training_Request)
		{
			return ((TalentPort)this).Manage_TrainingAsync(new Manage_TrainingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Training_Request = Manage_Training_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Awards_and_ActivitiesOutput TalentPort.Manage_Awards_and_Activities(Manage_Awards_and_ActivitiesInput request)
		{
			return base.Channel.Manage_Awards_and_Activities(request);
		}

		public Manage_Awards_and_Activities_ResponseType Manage_Awards_and_Activities(Workday_Common_HeaderType Workday_Common_Header, Manage_Awards_and_Activities_RequestType Manage_Awards_and_Activities_Request)
		{
			return ((TalentPort)this).Manage_Awards_and_Activities(new Manage_Awards_and_ActivitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Awards_and_Activities_Request = Manage_Awards_and_Activities_Request
			}).Manage_Awards_and_Activities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Awards_and_ActivitiesOutput> TalentPort.Manage_Awards_and_ActivitiesAsync(Manage_Awards_and_ActivitiesInput request)
		{
			return base.Channel.Manage_Awards_and_ActivitiesAsync(request);
		}

		public Task<Manage_Awards_and_ActivitiesOutput> Manage_Awards_and_ActivitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Awards_and_Activities_RequestType Manage_Awards_and_Activities_Request)
		{
			return ((TalentPort)this).Manage_Awards_and_ActivitiesAsync(new Manage_Awards_and_ActivitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Awards_and_Activities_Request = Manage_Awards_and_Activities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Skill_Source_PrecedencesOutput TalentPort.Get_Skill_Source_Precedences(Get_Skill_Source_PrecedencesInput request)
		{
			return base.Channel.Get_Skill_Source_Precedences(request);
		}

		public Get_Skill_Source_Precedences_ResponseType Get_Skill_Source_Precedences(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Source_Precedences_RequestType Get_Skill_Source_Precedences_Request)
		{
			return ((TalentPort)this).Get_Skill_Source_Precedences(new Get_Skill_Source_PrecedencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Source_Precedences_Request = Get_Skill_Source_Precedences_Request
			}).Get_Skill_Source_Precedences_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Skill_Source_PrecedencesOutput> TalentPort.Get_Skill_Source_PrecedencesAsync(Get_Skill_Source_PrecedencesInput request)
		{
			return base.Channel.Get_Skill_Source_PrecedencesAsync(request);
		}

		public Task<Get_Skill_Source_PrecedencesOutput> Get_Skill_Source_PrecedencesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Source_Precedences_RequestType Get_Skill_Source_Precedences_Request)
		{
			return ((TalentPort)this).Get_Skill_Source_PrecedencesAsync(new Get_Skill_Source_PrecedencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Source_Precedences_Request = Get_Skill_Source_Precedences_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_EducationOutput TalentPort.Manage_Education(Manage_EducationInput request)
		{
			return base.Channel.Manage_Education(request);
		}

		public Manage_Education_ResponseType Manage_Education(Workday_Common_HeaderType Workday_Common_Header, Manage_Education_RequestType Manage_Education_Request)
		{
			return ((TalentPort)this).Manage_Education(new Manage_EducationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Education_Request = Manage_Education_Request
			}).Manage_Education_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_EducationOutput> TalentPort.Manage_EducationAsync(Manage_EducationInput request)
		{
			return base.Channel.Manage_EducationAsync(request);
		}

		public Task<Manage_EducationOutput> Manage_EducationAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Education_RequestType Manage_Education_Request)
		{
			return ((TalentPort)this).Manage_EducationAsync(new Manage_EducationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Education_Request = Manage_Education_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CompetenciesOutput TalentPort.Get_Competencies(Get_CompetenciesInput request)
		{
			return base.Channel.Get_Competencies(request);
		}

		public Get_Competencies_ResponseType Get_Competencies(Workday_Common_HeaderType Workday_Common_Header, Get_Competencies_RequestType Get_Competencies_Request)
		{
			return ((TalentPort)this).Get_Competencies(new Get_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competencies_Request = Get_Competencies_Request
			}).Get_Competencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CompetenciesOutput> TalentPort.Get_CompetenciesAsync(Get_CompetenciesInput request)
		{
			return base.Channel.Get_CompetenciesAsync(request);
		}

		public Task<Get_CompetenciesOutput> Get_CompetenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Competencies_RequestType Get_Competencies_Request)
		{
			return ((TalentPort)this).Get_CompetenciesAsync(new Get_CompetenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competencies_Request = Get_Competencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_CompetencyOutput TalentPort.Put_Competency(Put_CompetencyInput request)
		{
			return base.Channel.Put_Competency(request);
		}

		public Put_Competency_ResponseType Put_Competency(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_RequestType Put_Competency_Request)
		{
			return ((TalentPort)this).Put_Competency(new Put_CompetencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Request = Put_Competency_Request
			}).Put_Competency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_CompetencyOutput> TalentPort.Put_CompetencyAsync(Put_CompetencyInput request)
		{
			return base.Channel.Put_CompetencyAsync(request);
		}

		public Task<Put_CompetencyOutput> Put_CompetencyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_RequestType Put_Competency_Request)
		{
			return ((TalentPort)this).Put_CompetencyAsync(new Put_CompetencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Request = Put_Competency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Internal_ProjectsOutput TalentPort.Manage_Internal_Projects(Manage_Internal_ProjectsInput request)
		{
			return base.Channel.Manage_Internal_Projects(request);
		}

		public Manage_Internal_Projects_ResponseType Manage_Internal_Projects(Workday_Common_HeaderType Workday_Common_Header, Manage_Internal_Projects_RequestType Manage_Internal_Projects_Request)
		{
			return ((TalentPort)this).Manage_Internal_Projects(new Manage_Internal_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Internal_Projects_Request = Manage_Internal_Projects_Request
			}).Manage_Internal_Projects_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Internal_ProjectsOutput> TalentPort.Manage_Internal_ProjectsAsync(Manage_Internal_ProjectsInput request)
		{
			return base.Channel.Manage_Internal_ProjectsAsync(request);
		}

		public Task<Manage_Internal_ProjectsOutput> Manage_Internal_ProjectsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Internal_Projects_RequestType Manage_Internal_Projects_Request)
		{
			return ((TalentPort)this).Manage_Internal_ProjectsAsync(new Manage_Internal_ProjectsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Internal_Projects_Request = Manage_Internal_Projects_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Work_ExperienceOutput TalentPort.Manage_Work_Experience(Manage_Work_ExperienceInput request)
		{
			return base.Channel.Manage_Work_Experience(request);
		}

		public Manage_Work_Experiences_ResponseType Manage_Work_Experience(Workday_Common_HeaderType Workday_Common_Header, Manage_Work_Experience_RequestType Manage_Work_Experience_Request)
		{
			return ((TalentPort)this).Manage_Work_Experience(new Manage_Work_ExperienceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Work_Experience_Request = Manage_Work_Experience_Request
			}).Manage_Work_Experiences_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Work_ExperienceOutput> TalentPort.Manage_Work_ExperienceAsync(Manage_Work_ExperienceInput request)
		{
			return base.Channel.Manage_Work_ExperienceAsync(request);
		}

		public Task<Manage_Work_ExperienceOutput> Manage_Work_ExperienceAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Work_Experience_RequestType Manage_Work_Experience_Request)
		{
			return ((TalentPort)this).Manage_Work_ExperienceAsync(new Manage_Work_ExperienceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Work_Experience_Request = Manage_Work_Experience_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Professional_AffiliationsOutput TalentPort.Manage_Professional_Affiliations(Manage_Professional_AffiliationsInput request)
		{
			return base.Channel.Manage_Professional_Affiliations(request);
		}

		public Manage_Professional_Affiliations_ResponseType Manage_Professional_Affiliations(Workday_Common_HeaderType Workday_Common_Header, Manage_Professional_Affiliations_RequestType Manage_Professional_Affiliations_Request)
		{
			return ((TalentPort)this).Manage_Professional_Affiliations(new Manage_Professional_AffiliationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Professional_Affiliations_Request = Manage_Professional_Affiliations_Request
			}).Manage_Professional_Affiliations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Professional_AffiliationsOutput> TalentPort.Manage_Professional_AffiliationsAsync(Manage_Professional_AffiliationsInput request)
		{
			return base.Channel.Manage_Professional_AffiliationsAsync(request);
		}

		public Task<Manage_Professional_AffiliationsOutput> Manage_Professional_AffiliationsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Professional_Affiliations_RequestType Manage_Professional_Affiliations_Request)
		{
			return ((TalentPort)this).Manage_Professional_AffiliationsAsync(new Manage_Professional_AffiliationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Professional_Affiliations_Request = Manage_Professional_Affiliations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_LanguagesOutput TalentPort.Manage_Languages(Manage_LanguagesInput request)
		{
			return base.Channel.Manage_Languages(request);
		}

		public Manage_Languages_ResponseType Manage_Languages(Workday_Common_HeaderType Workday_Common_Header, Manage_Languages_RequestType Manage_Languages_Request)
		{
			return ((TalentPort)this).Manage_Languages(new Manage_LanguagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Languages_Request = Manage_Languages_Request
			}).Manage_Languages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_LanguagesOutput> TalentPort.Manage_LanguagesAsync(Manage_LanguagesInput request)
		{
			return base.Channel.Manage_LanguagesAsync(request);
		}

		public Task<Manage_LanguagesOutput> Manage_LanguagesAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Languages_RequestType Manage_Languages_Request)
		{
			return ((TalentPort)this).Manage_LanguagesAsync(new Manage_LanguagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Languages_Request = Manage_Languages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Job_HistoryOutput TalentPort.Manage_Job_History(Manage_Job_HistoryInput request)
		{
			return base.Channel.Manage_Job_History(request);
		}

		public Manage_Job_History_ResponseType Manage_Job_History(Workday_Common_HeaderType Workday_Common_Header, Manage_Job_History_RequestType Manage_Job_History_Request)
		{
			return ((TalentPort)this).Manage_Job_History(new Manage_Job_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Job_History_Request = Manage_Job_History_Request
			}).Manage_Job_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Job_HistoryOutput> TalentPort.Manage_Job_HistoryAsync(Manage_Job_HistoryInput request)
		{
			return base.Channel.Manage_Job_HistoryAsync(request);
		}

		public Task<Manage_Job_HistoryOutput> Manage_Job_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Job_History_RequestType Manage_Job_History_Request)
		{
			return ((TalentPort)this).Manage_Job_HistoryAsync(new Manage_Job_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Job_History_Request = Manage_Job_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Talent_PoolsOutput TalentPort.Get_Talent_Pools(Get_Talent_PoolsInput request)
		{
			return base.Channel.Get_Talent_Pools(request);
		}

		public Get_Talent_Pools_ResponseType Get_Talent_Pools(Workday_Common_HeaderType Workday_Common_Header, Get_Talent_Pools_RequestType Get_Talent_Pools_Request)
		{
			return ((TalentPort)this).Get_Talent_Pools(new Get_Talent_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Talent_Pools_Request = Get_Talent_Pools_Request
			}).Get_Talent_Pools_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Talent_PoolsOutput> TalentPort.Get_Talent_PoolsAsync(Get_Talent_PoolsInput request)
		{
			return base.Channel.Get_Talent_PoolsAsync(request);
		}

		public Task<Get_Talent_PoolsOutput> Get_Talent_PoolsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Talent_Pools_RequestType Get_Talent_Pools_Request)
		{
			return ((TalentPort)this).Get_Talent_PoolsAsync(new Get_Talent_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Talent_Pools_Request = Get_Talent_Pools_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Talent_PoolOutput TalentPort.Put_Talent_Pool(Put_Talent_PoolInput request)
		{
			return base.Channel.Put_Talent_Pool(request);
		}

		public Put_Talent_Pool_ResponseType Put_Talent_Pool(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Pool_RequestType Put_Talent_Pool_Request)
		{
			return ((TalentPort)this).Put_Talent_Pool(new Put_Talent_PoolInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Talent_Pool_Request = Put_Talent_Pool_Request
			}).Put_Talent_Pool_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Talent_PoolOutput> TalentPort.Put_Talent_PoolAsync(Put_Talent_PoolInput request)
		{
			return base.Channel.Put_Talent_PoolAsync(request);
		}

		public Task<Put_Talent_PoolOutput> Put_Talent_PoolAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Pool_RequestType Put_Talent_Pool_Request)
		{
			return ((TalentPort)this).Put_Talent_PoolAsync(new Put_Talent_PoolInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Talent_Pool_Request = Put_Talent_Pool_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Language_Proficiency_LevelsOutput TalentPort.Get_Language_Proficiency_Levels(Get_Language_Proficiency_LevelsInput request)
		{
			return base.Channel.Get_Language_Proficiency_Levels(request);
		}

		public Get_Language_Proficiency_Levels_ResponseType Get_Language_Proficiency_Levels(Workday_Common_HeaderType Workday_Common_Header, Get_Language_Proficiency_Levels_RequestType Get_Language_Proficiency_Levels_Request)
		{
			return ((TalentPort)this).Get_Language_Proficiency_Levels(new Get_Language_Proficiency_LevelsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Language_Proficiency_Levels_Request = Get_Language_Proficiency_Levels_Request
			}).Get_Language_Proficiency_Levels_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Language_Proficiency_LevelsOutput> TalentPort.Get_Language_Proficiency_LevelsAsync(Get_Language_Proficiency_LevelsInput request)
		{
			return base.Channel.Get_Language_Proficiency_LevelsAsync(request);
		}

		public Task<Get_Language_Proficiency_LevelsOutput> Get_Language_Proficiency_LevelsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Language_Proficiency_Levels_RequestType Get_Language_Proficiency_Levels_Request)
		{
			return ((TalentPort)this).Get_Language_Proficiency_LevelsAsync(new Get_Language_Proficiency_LevelsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Language_Proficiency_Levels_Request = Get_Language_Proficiency_Levels_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_LanguagesOutput TalentPort.Get_Languages(Get_LanguagesInput request)
		{
			return base.Channel.Get_Languages(request);
		}

		public Get_Languages_ResponseType Get_Languages(Workday_Common_HeaderType Workday_Common_Header, Get_Languages_RequestType Get_Languages_Request)
		{
			return ((TalentPort)this).Get_Languages(new Get_LanguagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Languages_Request = Get_Languages_Request
			}).Get_Languages_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_LanguagesOutput> TalentPort.Get_LanguagesAsync(Get_LanguagesInput request)
		{
			return base.Channel.Get_LanguagesAsync(request);
		}

		public Task<Get_LanguagesOutput> Get_LanguagesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Languages_RequestType Get_Languages_Request)
		{
			return ((TalentPort)this).Get_LanguagesAsync(new Get_LanguagesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Languages_Request = Get_Languages_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Give_FeedbackOutput TalentPort.Give_Feedback(Give_FeedbackInput request)
		{
			return base.Channel.Give_Feedback(request);
		}

		public Give_Feedback_ResponseType Give_Feedback(Workday_Common_HeaderType Workday_Common_Header, Give_Feedback_RequestType Give_Feedback_Request)
		{
			return ((TalentPort)this).Give_Feedback(new Give_FeedbackInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Give_Feedback_Request = Give_Feedback_Request
			}).Give_Feedback_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Give_FeedbackOutput> TalentPort.Give_FeedbackAsync(Give_FeedbackInput request)
		{
			return base.Channel.Give_FeedbackAsync(request);
		}

		public Task<Give_FeedbackOutput> Give_FeedbackAsync(Workday_Common_HeaderType Workday_Common_Header, Give_Feedback_RequestType Give_Feedback_Request)
		{
			return ((TalentPort)this).Give_FeedbackAsync(new Give_FeedbackInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Give_Feedback_Request = Give_Feedback_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Work_ExperiencesOutput TalentPort.Get_Work_Experiences(Get_Work_ExperiencesInput request)
		{
			return base.Channel.Get_Work_Experiences(request);
		}

		public Get_Work_Experiences_ResponseType Get_Work_Experiences(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Experiences_RequestType Get_Work_Experiences_Request)
		{
			return ((TalentPort)this).Get_Work_Experiences(new Get_Work_ExperiencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Experiences_Request = Get_Work_Experiences_Request
			}).Get_Work_Experiences_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Work_ExperiencesOutput> TalentPort.Get_Work_ExperiencesAsync(Get_Work_ExperiencesInput request)
		{
			return base.Channel.Get_Work_ExperiencesAsync(request);
		}

		public Task<Get_Work_ExperiencesOutput> Get_Work_ExperiencesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Experiences_RequestType Get_Work_Experiences_Request)
		{
			return ((TalentPort)this).Get_Work_ExperiencesAsync(new Get_Work_ExperiencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Experiences_Request = Get_Work_Experiences_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Work_ExperienceOutput TalentPort.Put_Work_Experience(Put_Work_ExperienceInput request)
		{
			return base.Channel.Put_Work_Experience(request);
		}

		public Put_Work_Experience_ResponseType Put_Work_Experience(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Experience_RequestType Put_Work_Experience_Request)
		{
			return ((TalentPort)this).Put_Work_Experience(new Put_Work_ExperienceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Experience_Request = Put_Work_Experience_Request
			}).Put_Work_Experience_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Work_ExperienceOutput> TalentPort.Put_Work_ExperienceAsync(Put_Work_ExperienceInput request)
		{
			return base.Channel.Put_Work_ExperienceAsync(request);
		}

		public Task<Put_Work_ExperienceOutput> Put_Work_ExperienceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Experience_RequestType Put_Work_Experience_Request)
		{
			return ((TalentPort)this).Put_Work_ExperienceAsync(new Put_Work_ExperienceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Experience_Request = Put_Work_Experience_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SchoolsOutput TalentPort.Get_Schools(Get_SchoolsInput request)
		{
			return base.Channel.Get_Schools(request);
		}

		public Get_Schools_ResponseType Get_Schools(Workday_Common_HeaderType Workday_Common_Header, Get_Schools_RequestType Get_Schools_Request)
		{
			return ((TalentPort)this).Get_Schools(new Get_SchoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Schools_Request = Get_Schools_Request
			}).Get_Schools_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SchoolsOutput> TalentPort.Get_SchoolsAsync(Get_SchoolsInput request)
		{
			return base.Channel.Get_SchoolsAsync(request);
		}

		public Task<Get_SchoolsOutput> Get_SchoolsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Schools_RequestType Get_Schools_Request)
		{
			return ((TalentPort)this).Get_SchoolsAsync(new Get_SchoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Schools_Request = Get_Schools_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SchoolOutput TalentPort.Put_School(Put_SchoolInput request)
		{
			return base.Channel.Put_School(request);
		}

		public Put_School_ResponseType Put_School(Workday_Common_HeaderType Workday_Common_Header, Put_School_RequestType Put_School_Request)
		{
			return ((TalentPort)this).Put_School(new Put_SchoolInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_School_Request = Put_School_Request
			}).Put_School_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SchoolOutput> TalentPort.Put_SchoolAsync(Put_SchoolInput request)
		{
			return base.Channel.Put_SchoolAsync(request);
		}

		public Task<Put_SchoolOutput> Put_SchoolAsync(Workday_Common_HeaderType Workday_Common_Header, Put_School_RequestType Put_School_Request)
		{
			return ((TalentPort)this).Put_SchoolAsync(new Put_SchoolInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_School_Request = Put_School_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CertificationsOutput TalentPort.Get_Certifications(Get_CertificationsInput request)
		{
			return base.Channel.Get_Certifications(request);
		}

		public Get_Certifications_ResponseType Get_Certifications(Workday_Common_HeaderType Workday_Common_Header, Get_Certifications_RequestType Get_Certifications_Request)
		{
			return ((TalentPort)this).Get_Certifications(new Get_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certifications_Request = Get_Certifications_Request
			}).Get_Certifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CertificationsOutput> TalentPort.Get_CertificationsAsync(Get_CertificationsInput request)
		{
			return base.Channel.Get_CertificationsAsync(request);
		}

		public Task<Get_CertificationsOutput> Get_CertificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Certifications_RequestType Get_Certifications_Request)
		{
			return ((TalentPort)this).Get_CertificationsAsync(new Get_CertificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certifications_Request = Get_Certifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_CertificationOutput TalentPort.Put_Certification(Put_CertificationInput request)
		{
			return base.Channel.Put_Certification(request);
		}

		public Put_Certification_ResponseType Put_Certification(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_RequestType Put_Certification_Request)
		{
			return ((TalentPort)this).Put_Certification(new Put_CertificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Request = Put_Certification_Request
			}).Put_Certification_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_CertificationOutput> TalentPort.Put_CertificationAsync(Put_CertificationInput request)
		{
			return base.Channel.Put_CertificationAsync(request);
		}

		public Task<Put_CertificationOutput> Put_CertificationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_RequestType Put_Certification_Request)
		{
			return ((TalentPort)this).Put_CertificationAsync(new Put_CertificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Request = Put_Certification_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Relocation_PreferencesOutput TalentPort.Edit_Relocation_Preferences(Edit_Relocation_PreferencesInput request)
		{
			return base.Channel.Edit_Relocation_Preferences(request);
		}

		public Manage_Relocation_Preferences_ResponseType Edit_Relocation_Preferences(Workday_Common_HeaderType Workday_Common_Header, Edit_Relocation_Preferences_RequestType Edit_Relocation_Preferences_Request)
		{
			return ((TalentPort)this).Edit_Relocation_Preferences(new Edit_Relocation_PreferencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Relocation_Preferences_Request = Edit_Relocation_Preferences_Request
			}).Manage_Relocation_Preferences_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Relocation_PreferencesOutput> TalentPort.Edit_Relocation_PreferencesAsync(Edit_Relocation_PreferencesInput request)
		{
			return base.Channel.Edit_Relocation_PreferencesAsync(request);
		}

		public Task<Edit_Relocation_PreferencesOutput> Edit_Relocation_PreferencesAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Relocation_Preferences_RequestType Edit_Relocation_Preferences_Request)
		{
			return ((TalentPort)this).Edit_Relocation_PreferencesAsync(new Edit_Relocation_PreferencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Relocation_Preferences_Request = Edit_Relocation_Preferences_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Travel_PreferencesOutput TalentPort.Edit_Travel_Preferences(Edit_Travel_PreferencesInput request)
		{
			return base.Channel.Edit_Travel_Preferences(request);
		}

		public Edit_Travel_Preferences_ResponseType Edit_Travel_Preferences(Workday_Common_HeaderType Workday_Common_Header, Edit_Travel_Preferences_RequestType Edit_Travel_Preferences_Request)
		{
			return ((TalentPort)this).Edit_Travel_Preferences(new Edit_Travel_PreferencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Travel_Preferences_Request = Edit_Travel_Preferences_Request
			}).Edit_Travel_Preferences_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Travel_PreferencesOutput> TalentPort.Edit_Travel_PreferencesAsync(Edit_Travel_PreferencesInput request)
		{
			return base.Channel.Edit_Travel_PreferencesAsync(request);
		}

		public Task<Edit_Travel_PreferencesOutput> Edit_Travel_PreferencesAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Travel_Preferences_RequestType Edit_Travel_Preferences_Request)
		{
			return ((TalentPort)this).Edit_Travel_PreferencesAsync(new Edit_Travel_PreferencesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Travel_Preferences_Request = Edit_Travel_Preferences_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Career_InterestsOutput TalentPort.Edit_Career_Interests(Edit_Career_InterestsInput request)
		{
			return base.Channel.Edit_Career_Interests(request);
		}

		public Manage_Career_Interest_ResponseType Edit_Career_Interests(Workday_Common_HeaderType Workday_Common_Header, Edit_Career_Interests_RequestType Edit_Career_Interests_Request)
		{
			return ((TalentPort)this).Edit_Career_Interests(new Edit_Career_InterestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Career_Interests_Request = Edit_Career_Interests_Request
			}).Manage_Career_Interest_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Career_InterestsOutput> TalentPort.Edit_Career_InterestsAsync(Edit_Career_InterestsInput request)
		{
			return base.Channel.Edit_Career_InterestsAsync(request);
		}

		public Task<Edit_Career_InterestsOutput> Edit_Career_InterestsAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Career_Interests_RequestType Edit_Career_Interests_Request)
		{
			return ((TalentPort)this).Edit_Career_InterestsAsync(new Edit_Career_InterestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Career_Interests_Request = Edit_Career_Interests_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Job_InterestsOutput TalentPort.Edit_Job_Interests(Edit_Job_InterestsInput request)
		{
			return base.Channel.Edit_Job_Interests(request);
		}

		public Edit_Job_Interests_ResponseType Edit_Job_Interests(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Interests_RequestType Edit_Job_Interests_Request)
		{
			return ((TalentPort)this).Edit_Job_Interests(new Edit_Job_InterestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Job_Interests_Request = Edit_Job_Interests_Request
			}).Edit_Job_Interests_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Job_InterestsOutput> TalentPort.Edit_Job_InterestsAsync(Edit_Job_InterestsInput request)
		{
			return base.Channel.Edit_Job_InterestsAsync(request);
		}

		public Task<Edit_Job_InterestsOutput> Edit_Job_InterestsAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Interests_RequestType Edit_Job_Interests_Request)
		{
			return ((TalentPort)this).Edit_Job_InterestsAsync(new Edit_Job_InterestsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Job_Interests_Request = Edit_Job_Interests_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SkillOutput TalentPort.Put_Skill(Put_SkillInput request)
		{
			return base.Channel.Put_Skill(request);
		}

		public Put_Skill_ResponseType Put_Skill(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_RequestType Put_Skill_Request)
		{
			return ((TalentPort)this).Put_Skill(new Put_SkillInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Request = Put_Skill_Request
			}).Put_Skill_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SkillOutput> TalentPort.Put_SkillAsync(Put_SkillInput request)
		{
			return base.Channel.Put_SkillAsync(request);
		}

		public Task<Put_SkillOutput> Put_SkillAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_RequestType Put_Skill_Request)
		{
			return ((TalentPort)this).Put_SkillAsync(new Put_SkillInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Request = Put_Skill_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Skill_Item_CategoryOutput TalentPort.Put_Skill_Item_Category(Put_Skill_Item_CategoryInput request)
		{
			return base.Channel.Put_Skill_Item_Category(request);
		}

		public Put_Skill_Item_Category_ResponseType Put_Skill_Item_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_Item_Category_RequestType Put_Skill_Item_Category_Request)
		{
			return ((TalentPort)this).Put_Skill_Item_Category(new Put_Skill_Item_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Item_Category_Request = Put_Skill_Item_Category_Request
			}).Put_Skill_Item_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Skill_Item_CategoryOutput> TalentPort.Put_Skill_Item_CategoryAsync(Put_Skill_Item_CategoryInput request)
		{
			return base.Channel.Put_Skill_Item_CategoryAsync(request);
		}

		public Task<Put_Skill_Item_CategoryOutput> Put_Skill_Item_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_Item_Category_RequestType Put_Skill_Item_Category_Request)
		{
			return ((TalentPort)this).Put_Skill_Item_CategoryAsync(new Put_Skill_Item_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Item_Category_Request = Put_Skill_Item_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_History_CompanyOutput TalentPort.Put_Job_History_Company(Put_Job_History_CompanyInput request)
		{
			return base.Channel.Put_Job_History_Company(request);
		}

		public Put_Job_History_Company_ResponseType Put_Job_History_Company(Workday_Common_HeaderType Workday_Common_Header, Put_Job_History_Company_RequestType Put_Job_History_Company_Request)
		{
			return ((TalentPort)this).Put_Job_History_Company(new Put_Job_History_CompanyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_History_Company_Request = Put_Job_History_Company_Request
			}).Put_Job_History_Company_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_History_CompanyOutput> TalentPort.Put_Job_History_CompanyAsync(Put_Job_History_CompanyInput request)
		{
			return base.Channel.Put_Job_History_CompanyAsync(request);
		}

		public Task<Put_Job_History_CompanyOutput> Put_Job_History_CompanyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_History_Company_RequestType Put_Job_History_Company_Request)
		{
			return ((TalentPort)this).Put_Job_History_CompanyAsync(new Put_Job_History_CompanyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_History_Company_Request = Put_Job_History_Company_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_History_CompaniesOutput TalentPort.Get_Job_History_Companies(Get_Job_History_CompaniesInput request)
		{
			return base.Channel.Get_Job_History_Companies(request);
		}

		public Get_Job_History_Companies_ResponseType Get_Job_History_Companies(Workday_Common_HeaderType Workday_Common_Header, Get_Job_History_Companies_RequestType Get_Job_History_Companies_Request)
		{
			return ((TalentPort)this).Get_Job_History_Companies(new Get_Job_History_CompaniesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_History_Companies_Request = Get_Job_History_Companies_Request
			}).Get_Job_History_Companies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_History_CompaniesOutput> TalentPort.Get_Job_History_CompaniesAsync(Get_Job_History_CompaniesInput request)
		{
			return base.Channel.Get_Job_History_CompaniesAsync(request);
		}

		public Task<Get_Job_History_CompaniesOutput> Get_Job_History_CompaniesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_History_Companies_RequestType Get_Job_History_Companies_Request)
		{
			return ((TalentPort)this).Get_Job_History_CompaniesAsync(new Get_Job_History_CompaniesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_History_Companies_Request = Get_Job_History_Companies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Certification_IssuersOutput TalentPort.Get_Certification_Issuers(Get_Certification_IssuersInput request)
		{
			return base.Channel.Get_Certification_Issuers(request);
		}

		public Get_Certification_Issuers_ResponseType Get_Certification_Issuers(Workday_Common_HeaderType Workday_Common_Header, Get_Certification_Issuers_RequestType Get_Certification_Issuers_Request)
		{
			return ((TalentPort)this).Get_Certification_Issuers(new Get_Certification_IssuersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certification_Issuers_Request = Get_Certification_Issuers_Request
			}).Get_Certification_Issuers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Certification_IssuersOutput> TalentPort.Get_Certification_IssuersAsync(Get_Certification_IssuersInput request)
		{
			return base.Channel.Get_Certification_IssuersAsync(request);
		}

		public Task<Get_Certification_IssuersOutput> Get_Certification_IssuersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Certification_Issuers_RequestType Get_Certification_Issuers_Request)
		{
			return ((TalentPort)this).Get_Certification_IssuersAsync(new Get_Certification_IssuersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Certification_Issuers_Request = Get_Certification_Issuers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Certification_IssuerOutput TalentPort.Put_Certification_Issuer(Put_Certification_IssuerInput request)
		{
			return base.Channel.Put_Certification_Issuer(request);
		}

		public Put_Certification_Issuer_ResponseType Put_Certification_Issuer(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_Issuer_RequestType Put_Certification_Issuer_Request)
		{
			return ((TalentPort)this).Put_Certification_Issuer(new Put_Certification_IssuerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Issuer_Request = Put_Certification_Issuer_Request
			}).Put_Certification_Issuer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Certification_IssuerOutput> TalentPort.Put_Certification_IssuerAsync(Put_Certification_IssuerInput request)
		{
			return base.Channel.Put_Certification_IssuerAsync(request);
		}

		public Task<Put_Certification_IssuerOutput> Put_Certification_IssuerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_Issuer_RequestType Put_Certification_Issuer_Request)
		{
			return ((TalentPort)this).Put_Certification_IssuerAsync(new Put_Certification_IssuerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Certification_Issuer_Request = Put_Certification_Issuer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Succession_PoolsOutput TalentPort.Get_Succession_Pools(Get_Succession_PoolsInput request)
		{
			return base.Channel.Get_Succession_Pools(request);
		}

		public Get_Succession_Pools_ResponseType Get_Succession_Pools(Workday_Common_HeaderType Workday_Common_Header, Get_Succession_Pools_RequestType Get_Succession_Pools_Request)
		{
			return ((TalentPort)this).Get_Succession_Pools(new Get_Succession_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Succession_Pools_Request = Get_Succession_Pools_Request
			}).Get_Succession_Pools_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Succession_PoolsOutput> TalentPort.Get_Succession_PoolsAsync(Get_Succession_PoolsInput request)
		{
			return base.Channel.Get_Succession_PoolsAsync(request);
		}

		public Task<Get_Succession_PoolsOutput> Get_Succession_PoolsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Succession_Pools_RequestType Get_Succession_Pools_Request)
		{
			return ((TalentPort)this).Get_Succession_PoolsAsync(new Get_Succession_PoolsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Succession_Pools_Request = Get_Succession_Pools_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Succession_PoolOutput TalentPort.Manage_Succession_Pool(Manage_Succession_PoolInput request)
		{
			return base.Channel.Manage_Succession_Pool(request);
		}

		public Manage_Succession_Pool_ResponseType Manage_Succession_Pool(Workday_Common_HeaderType Workday_Common_Header, Manage_Succession_Pool_RequestType Manage_Succession_Pool_Request)
		{
			return ((TalentPort)this).Manage_Succession_Pool(new Manage_Succession_PoolInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Succession_Pool_Request = Manage_Succession_Pool_Request
			}).Manage_Succession_Pool_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Succession_PoolOutput> TalentPort.Manage_Succession_PoolAsync(Manage_Succession_PoolInput request)
		{
			return base.Channel.Manage_Succession_PoolAsync(request);
		}

		public Task<Manage_Succession_PoolOutput> Manage_Succession_PoolAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Succession_Pool_RequestType Manage_Succession_Pool_Request)
		{
			return ((TalentPort)this).Manage_Succession_PoolAsync(new Manage_Succession_PoolInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Succession_Pool_Request = Manage_Succession_Pool_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Competency_ClassOutput TalentPort.Put_Competency_Class(Put_Competency_ClassInput request)
		{
			return base.Channel.Put_Competency_Class(request);
		}

		public Put_Competency_Class_ResponseType Put_Competency_Class(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_Class_RequestType Put_Competency_Class_Request)
		{
			return ((TalentPort)this).Put_Competency_Class(new Put_Competency_ClassInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Class_Request = Put_Competency_Class_Request
			}).Put_Competency_Class_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Competency_ClassOutput> TalentPort.Put_Competency_ClassAsync(Put_Competency_ClassInput request)
		{
			return base.Channel.Put_Competency_ClassAsync(request);
		}

		public Task<Put_Competency_ClassOutput> Put_Competency_ClassAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Competency_Class_RequestType Put_Competency_Class_Request)
		{
			return ((TalentPort)this).Put_Competency_ClassAsync(new Put_Competency_ClassInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Competency_Class_Request = Put_Competency_Class_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Competency_ClassesOutput TalentPort.Get_Competency_Classes(Get_Competency_ClassesInput request)
		{
			return base.Channel.Get_Competency_Classes(request);
		}

		public Get_Competency_Classes_ResponseType Get_Competency_Classes(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Classes_RequestType Get_Competency_Classes_Request)
		{
			return ((TalentPort)this).Get_Competency_Classes(new Get_Competency_ClassesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competency_Classes_Request = Get_Competency_Classes_Request
			}).Get_Competency_Classes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Competency_ClassesOutput> TalentPort.Get_Competency_ClassesAsync(Get_Competency_ClassesInput request)
		{
			return base.Channel.Get_Competency_ClassesAsync(request);
		}

		public Task<Get_Competency_ClassesOutput> Get_Competency_ClassesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Competency_Classes_RequestType Get_Competency_Classes_Request)
		{
			return ((TalentPort)this).Get_Competency_ClassesAsync(new Get_Competency_ClassesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Competency_Classes_Request = Get_Competency_Classes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Proficiency_Rating_ScaleOutput TalentPort.Put_Proficiency_Rating_Scale(Put_Proficiency_Rating_ScaleInput request)
		{
			return base.Channel.Put_Proficiency_Rating_Scale(request);
		}

		public Put_Proficiency_Rating_Scale_ResponseType Put_Proficiency_Rating_Scale(Workday_Common_HeaderType Workday_Common_Header, Put_Proficiency_Rating_Scale_RequestType Put_Proficiency_Rating_Scale_Request)
		{
			return ((TalentPort)this).Put_Proficiency_Rating_Scale(new Put_Proficiency_Rating_ScaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Proficiency_Rating_Scale_Request = Put_Proficiency_Rating_Scale_Request
			}).Put_Proficiency_Rating_Scale_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Proficiency_Rating_ScaleOutput> TalentPort.Put_Proficiency_Rating_ScaleAsync(Put_Proficiency_Rating_ScaleInput request)
		{
			return base.Channel.Put_Proficiency_Rating_ScaleAsync(request);
		}

		public Task<Put_Proficiency_Rating_ScaleOutput> Put_Proficiency_Rating_ScaleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Proficiency_Rating_Scale_RequestType Put_Proficiency_Rating_Scale_Request)
		{
			return ((TalentPort)this).Put_Proficiency_Rating_ScaleAsync(new Put_Proficiency_Rating_ScaleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Proficiency_Rating_Scale_Request = Put_Proficiency_Rating_Scale_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Proficiency_Rating_ScalesOutput TalentPort.Get_Proficiency_Rating_Scales(Get_Proficiency_Rating_ScalesInput request)
		{
			return base.Channel.Get_Proficiency_Rating_Scales(request);
		}

		public Get_Proficiency_Rating_Scales_ResponseType Get_Proficiency_Rating_Scales(Workday_Common_HeaderType Workday_Common_Header, Get_Proficiency_Rating_Scales_RequestType Get_Proficiency_Rating_Scales_Request)
		{
			return ((TalentPort)this).Get_Proficiency_Rating_Scales(new Get_Proficiency_Rating_ScalesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Proficiency_Rating_Scales_Request = Get_Proficiency_Rating_Scales_Request
			}).Get_Proficiency_Rating_Scales_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Proficiency_Rating_ScalesOutput> TalentPort.Get_Proficiency_Rating_ScalesAsync(Get_Proficiency_Rating_ScalesInput request)
		{
			return base.Channel.Get_Proficiency_Rating_ScalesAsync(request);
		}

		public Task<Get_Proficiency_Rating_ScalesOutput> Get_Proficiency_Rating_ScalesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Proficiency_Rating_Scales_RequestType Get_Proficiency_Rating_Scales_Request)
		{
			return ((TalentPort)this).Get_Proficiency_Rating_ScalesAsync(new Get_Proficiency_Rating_ScalesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Proficiency_Rating_Scales_Request = Get_Proficiency_Rating_Scales_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SubspecialtiesOutput TalentPort.Get_Subspecialties(Get_SubspecialtiesInput request)
		{
			return base.Channel.Get_Subspecialties(request);
		}

		public Get_Subspecialties_ResponseType Get_Subspecialties(Workday_Common_HeaderType Workday_Common_Header, Get_Subspecialties_RequestType Get_Subspecialties_Request)
		{
			return ((TalentPort)this).Get_Subspecialties(new Get_SubspecialtiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subspecialties_Request = Get_Subspecialties_Request
			}).Get_Subspecialties_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SubspecialtiesOutput> TalentPort.Get_SubspecialtiesAsync(Get_SubspecialtiesInput request)
		{
			return base.Channel.Get_SubspecialtiesAsync(request);
		}

		public Task<Get_SubspecialtiesOutput> Get_SubspecialtiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Subspecialties_RequestType Get_Subspecialties_Request)
		{
			return ((TalentPort)this).Get_SubspecialtiesAsync(new Get_SubspecialtiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Subspecialties_Request = Get_Subspecialties_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SubspecialtyOutput TalentPort.Put_Subspecialty(Put_SubspecialtyInput request)
		{
			return base.Channel.Put_Subspecialty(request);
		}

		public Put_Subspecialty_ResponseType Put_Subspecialty(Workday_Common_HeaderType Workday_Common_Header, Put_Subspecialty_RequestType Put_Subspecialty_Request)
		{
			return ((TalentPort)this).Put_Subspecialty(new Put_SubspecialtyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subspecialty_Request = Put_Subspecialty_Request
			}).Put_Subspecialty_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SubspecialtyOutput> TalentPort.Put_SubspecialtyAsync(Put_SubspecialtyInput request)
		{
			return base.Channel.Put_SubspecialtyAsync(request);
		}

		public Task<Put_SubspecialtyOutput> Put_SubspecialtyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Subspecialty_RequestType Put_Subspecialty_Request)
		{
			return ((TalentPort)this).Put_SubspecialtyAsync(new Put_SubspecialtyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Subspecialty_Request = Put_Subspecialty_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_SpecialtiesOutput TalentPort.Get_Specialties(Get_SpecialtiesInput request)
		{
			return base.Channel.Get_Specialties(request);
		}

		public Get_Specialties_ResponseType Get_Specialties(Workday_Common_HeaderType Workday_Common_Header, Get_Specialties_RequestType Get_Specialties_Request)
		{
			return ((TalentPort)this).Get_Specialties(new Get_SpecialtiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Specialties_Request = Get_Specialties_Request
			}).Get_Specialties_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_SpecialtiesOutput> TalentPort.Get_SpecialtiesAsync(Get_SpecialtiesInput request)
		{
			return base.Channel.Get_SpecialtiesAsync(request);
		}

		public Task<Get_SpecialtiesOutput> Get_SpecialtiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Specialties_RequestType Get_Specialties_Request)
		{
			return ((TalentPort)this).Get_SpecialtiesAsync(new Get_SpecialtiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Specialties_Request = Get_Specialties_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_SpecialtyOutput TalentPort.Put_Specialty(Put_SpecialtyInput request)
		{
			return base.Channel.Put_Specialty(request);
		}

		public Put_Specialty_ResponseType Put_Specialty(Workday_Common_HeaderType Workday_Common_Header, Put_Specialty_RequestType Put_Specialty_Request)
		{
			return ((TalentPort)this).Put_Specialty(new Put_SpecialtyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Specialty_Request = Put_Specialty_Request
			}).Put_Specialty_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_SpecialtyOutput> TalentPort.Put_SpecialtyAsync(Put_SpecialtyInput request)
		{
			return base.Channel.Put_SpecialtyAsync(request);
		}

		public Task<Put_SpecialtyOutput> Put_SpecialtyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Specialty_RequestType Put_Specialty_Request)
		{
			return ((TalentPort)this).Put_SpecialtyAsync(new Put_SpecialtyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Specialty_Request = Put_Specialty_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Professional_Affiliation_Relationship_TypesOutput TalentPort.Get_Professional_Affiliation_Relationship_Types(Get_Professional_Affiliation_Relationship_TypesInput request)
		{
			return base.Channel.Get_Professional_Affiliation_Relationship_Types(request);
		}

		public Get_Professional_Affiliation_Relationship_Types_ResponseType Get_Professional_Affiliation_Relationship_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Professional_Affiliation_Relationship_Types_RequestType Get_Professional_Affiliation_Relationship_Types_Request)
		{
			return ((TalentPort)this).Get_Professional_Affiliation_Relationship_Types(new Get_Professional_Affiliation_Relationship_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Professional_Affiliation_Relationship_Types_Request = Get_Professional_Affiliation_Relationship_Types_Request
			}).Get_Professional_Affiliation_Relationship_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Professional_Affiliation_Relationship_TypesOutput> TalentPort.Get_Professional_Affiliation_Relationship_TypesAsync(Get_Professional_Affiliation_Relationship_TypesInput request)
		{
			return base.Channel.Get_Professional_Affiliation_Relationship_TypesAsync(request);
		}

		public Task<Get_Professional_Affiliation_Relationship_TypesOutput> Get_Professional_Affiliation_Relationship_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Professional_Affiliation_Relationship_Types_RequestType Get_Professional_Affiliation_Relationship_Types_Request)
		{
			return ((TalentPort)this).Get_Professional_Affiliation_Relationship_TypesAsync(new Get_Professional_Affiliation_Relationship_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Professional_Affiliation_Relationship_Types_Request = Get_Professional_Affiliation_Relationship_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Professional_Affiliation_Relationship_TypeOutput TalentPort.Put_Professional_Affiliation_Relationship_Type(Put_Professional_Affiliation_Relationship_TypeInput request)
		{
			return base.Channel.Put_Professional_Affiliation_Relationship_Type(request);
		}

		public Put_Professional_Affiliation_Relationship_Type_ResponseType Put_Professional_Affiliation_Relationship_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_Relationship_Type_RequestType Put_Professional_Affiliation_Relationship_Type_Request)
		{
			return ((TalentPort)this).Put_Professional_Affiliation_Relationship_Type(new Put_Professional_Affiliation_Relationship_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Professional_Affiliation_Relationship_Type_Request = Put_Professional_Affiliation_Relationship_Type_Request
			}).Put_Professional_Affiliation_Relationship_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Professional_Affiliation_Relationship_TypeOutput> TalentPort.Put_Professional_Affiliation_Relationship_TypeAsync(Put_Professional_Affiliation_Relationship_TypeInput request)
		{
			return base.Channel.Put_Professional_Affiliation_Relationship_TypeAsync(request);
		}

		public Task<Put_Professional_Affiliation_Relationship_TypeOutput> Put_Professional_Affiliation_Relationship_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_Relationship_Type_RequestType Put_Professional_Affiliation_Relationship_Type_Request)
		{
			return ((TalentPort)this).Put_Professional_Affiliation_Relationship_TypeAsync(new Put_Professional_Affiliation_Relationship_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Professional_Affiliation_Relationship_Type_Request = Put_Professional_Affiliation_Relationship_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Professional_Affiliation_TypesOutput TalentPort.Get_Professional_Affiliation_Types(Get_Professional_Affiliation_TypesInput request)
		{
			return base.Channel.Get_Professional_Affiliation_Types(request);
		}

		public Get_Professional_Affiliation_Types_ResponseType Get_Professional_Affiliation_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Professional_Affiliation_Types_RequestType Get_Professional_Affiliation_Types_Request)
		{
			return ((TalentPort)this).Get_Professional_Affiliation_Types(new Get_Professional_Affiliation_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Professional_Affiliation_Types_Request = Get_Professional_Affiliation_Types_Request
			}).Get_Professional_Affiliation_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Professional_Affiliation_TypesOutput> TalentPort.Get_Professional_Affiliation_TypesAsync(Get_Professional_Affiliation_TypesInput request)
		{
			return base.Channel.Get_Professional_Affiliation_TypesAsync(request);
		}

		public Task<Get_Professional_Affiliation_TypesOutput> Get_Professional_Affiliation_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Professional_Affiliation_Types_RequestType Get_Professional_Affiliation_Types_Request)
		{
			return ((TalentPort)this).Get_Professional_Affiliation_TypesAsync(new Get_Professional_Affiliation_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Professional_Affiliation_Types_Request = Get_Professional_Affiliation_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Professional_Affiliation_TypeOutput TalentPort.Put_Professional_Affiliation_Type(Put_Professional_Affiliation_TypeInput request)
		{
			return base.Channel.Put_Professional_Affiliation_Type(request);
		}

		public Put_Professional_Affiliation_Type_ResponseType Put_Professional_Affiliation_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_Type_RequestType Put_Professional_Affiliation_Type_Request)
		{
			return ((TalentPort)this).Put_Professional_Affiliation_Type(new Put_Professional_Affiliation_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Professional_Affiliation_Type_Request = Put_Professional_Affiliation_Type_Request
			}).Put_Professional_Affiliation_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Professional_Affiliation_TypeOutput> TalentPort.Put_Professional_Affiliation_TypeAsync(Put_Professional_Affiliation_TypeInput request)
		{
			return base.Channel.Put_Professional_Affiliation_TypeAsync(request);
		}

		public Task<Put_Professional_Affiliation_TypeOutput> Put_Professional_Affiliation_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_Type_RequestType Put_Professional_Affiliation_Type_Request)
		{
			return ((TalentPort)this).Put_Professional_Affiliation_TypeAsync(new Put_Professional_Affiliation_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Professional_Affiliation_Type_Request = Put_Professional_Affiliation_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Professional_AffiliationsOutput TalentPort.Get_Professional_Affiliations(Get_Professional_AffiliationsInput request)
		{
			return base.Channel.Get_Professional_Affiliations(request);
		}

		public Get_Professional_Affiliations_ResponseType Get_Professional_Affiliations(Workday_Common_HeaderType Workday_Common_Header, Get_Professional_Affiliations_RequestType Get_Professional_Affiliations_Request)
		{
			return ((TalentPort)this).Get_Professional_Affiliations(new Get_Professional_AffiliationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Professional_Affiliations_Request = Get_Professional_Affiliations_Request
			}).Get_Professional_Affiliations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Professional_AffiliationsOutput> TalentPort.Get_Professional_AffiliationsAsync(Get_Professional_AffiliationsInput request)
		{
			return base.Channel.Get_Professional_AffiliationsAsync(request);
		}

		public Task<Get_Professional_AffiliationsOutput> Get_Professional_AffiliationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Professional_Affiliations_RequestType Get_Professional_Affiliations_Request)
		{
			return ((TalentPort)this).Get_Professional_AffiliationsAsync(new Get_Professional_AffiliationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Professional_Affiliations_Request = Get_Professional_Affiliations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Professional_AffiliationOutput TalentPort.Put_Professional_Affiliation(Put_Professional_AffiliationInput request)
		{
			return base.Channel.Put_Professional_Affiliation(request);
		}

		public Put_Professional_Affiliation_ResponseType Put_Professional_Affiliation(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_RequestType Put_Professional_Affiliation_Request)
		{
			return ((TalentPort)this).Put_Professional_Affiliation(new Put_Professional_AffiliationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Professional_Affiliation_Request = Put_Professional_Affiliation_Request
			}).Put_Professional_Affiliation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Professional_AffiliationOutput> TalentPort.Put_Professional_AffiliationAsync(Put_Professional_AffiliationInput request)
		{
			return base.Channel.Put_Professional_AffiliationAsync(request);
		}

		public Task<Put_Professional_AffiliationOutput> Put_Professional_AffiliationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_RequestType Put_Professional_Affiliation_Request)
		{
			return ((TalentPort)this).Put_Professional_AffiliationAsync(new Put_Professional_AffiliationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Professional_Affiliation_Request = Put_Professional_Affiliation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Skill_Profile_CategoriesOutput TalentPort.Get_Skill_Profile_Categories(Get_Skill_Profile_CategoriesInput request)
		{
			return base.Channel.Get_Skill_Profile_Categories(request);
		}

		public Get_Skill_Profile_Categories_ResponseType Get_Skill_Profile_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Profile_Categories_RequestType Get_Skill_Profile_Categories_Request)
		{
			return ((TalentPort)this).Get_Skill_Profile_Categories(new Get_Skill_Profile_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Profile_Categories_Request = Get_Skill_Profile_Categories_Request
			}).Get_Skill_Profile_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Skill_Profile_CategoriesOutput> TalentPort.Get_Skill_Profile_CategoriesAsync(Get_Skill_Profile_CategoriesInput request)
		{
			return base.Channel.Get_Skill_Profile_CategoriesAsync(request);
		}

		public Task<Get_Skill_Profile_CategoriesOutput> Get_Skill_Profile_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Profile_Categories_RequestType Get_Skill_Profile_Categories_Request)
		{
			return ((TalentPort)this).Get_Skill_Profile_CategoriesAsync(new Get_Skill_Profile_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Profile_Categories_Request = Get_Skill_Profile_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Skill_Profile_CategoryOutput TalentPort.Put_Skill_Profile_Category(Put_Skill_Profile_CategoryInput request)
		{
			return base.Channel.Put_Skill_Profile_Category(request);
		}

		public Put_Skill_Profile_Category_ResponseType Put_Skill_Profile_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_Profile_Category_RequestType Put_Skill_Profile_Category_Request)
		{
			return ((TalentPort)this).Put_Skill_Profile_Category(new Put_Skill_Profile_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Profile_Category_Request = Put_Skill_Profile_Category_Request
			}).Put_Skill_Profile_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Skill_Profile_CategoryOutput> TalentPort.Put_Skill_Profile_CategoryAsync(Put_Skill_Profile_CategoryInput request)
		{
			return base.Channel.Put_Skill_Profile_CategoryAsync(request);
		}

		public Task<Put_Skill_Profile_CategoryOutput> Put_Skill_Profile_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_Profile_Category_RequestType Put_Skill_Profile_Category_Request)
		{
			return ((TalentPort)this).Put_Skill_Profile_CategoryAsync(new Put_Skill_Profile_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Profile_Category_Request = Put_Skill_Profile_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Skill_ProfilesOutput TalentPort.Get_Skill_Profiles(Get_Skill_ProfilesInput request)
		{
			return base.Channel.Get_Skill_Profiles(request);
		}

		public Get_Skill_Profiles_ResponseType Get_Skill_Profiles(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Profiles_RequestType Get_Skill_Profiles_Request)
		{
			return ((TalentPort)this).Get_Skill_Profiles(new Get_Skill_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Profiles_Request = Get_Skill_Profiles_Request
			}).Get_Skill_Profiles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Skill_ProfilesOutput> TalentPort.Get_Skill_ProfilesAsync(Get_Skill_ProfilesInput request)
		{
			return base.Channel.Get_Skill_ProfilesAsync(request);
		}

		public Task<Get_Skill_ProfilesOutput> Get_Skill_ProfilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Profiles_RequestType Get_Skill_Profiles_Request)
		{
			return ((TalentPort)this).Get_Skill_ProfilesAsync(new Get_Skill_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Skill_Profiles_Request = Get_Skill_Profiles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Skill_ProfileOutput TalentPort.Put_Skill_Profile(Put_Skill_ProfileInput request)
		{
			return base.Channel.Put_Skill_Profile(request);
		}

		public Put_Skill_Profile_ResponseType Put_Skill_Profile(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_Profile_RequestType Put_Skill_Profile_Request)
		{
			return ((TalentPort)this).Put_Skill_Profile(new Put_Skill_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Profile_Request = Put_Skill_Profile_Request
			}).Put_Skill_Profile_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Skill_ProfileOutput> TalentPort.Put_Skill_ProfileAsync(Put_Skill_ProfileInput request)
		{
			return base.Channel.Put_Skill_ProfileAsync(request);
		}

		public Task<Put_Skill_ProfileOutput> Put_Skill_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_Profile_RequestType Put_Skill_Profile_Request)
		{
			return ((TalentPort)this).Put_Skill_ProfileAsync(new Put_Skill_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Skill_Profile_Request = Put_Skill_Profile_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Talent_Statement_TypesOutput TalentPort.Get_Talent_Statement_Types(Get_Talent_Statement_TypesInput request)
		{
			return base.Channel.Get_Talent_Statement_Types(request);
		}

		public Get_Talent_Statement_Types_ResponseType Get_Talent_Statement_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Talent_Statement_Types_RequestType Get_Talent_Statement_Types_Request)
		{
			return ((TalentPort)this).Get_Talent_Statement_Types(new Get_Talent_Statement_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Talent_Statement_Types_Request = Get_Talent_Statement_Types_Request
			}).Get_Talent_Statement_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Talent_Statement_TypesOutput> TalentPort.Get_Talent_Statement_TypesAsync(Get_Talent_Statement_TypesInput request)
		{
			return base.Channel.Get_Talent_Statement_TypesAsync(request);
		}

		public Task<Get_Talent_Statement_TypesOutput> Get_Talent_Statement_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Talent_Statement_Types_RequestType Get_Talent_Statement_Types_Request)
		{
			return ((TalentPort)this).Get_Talent_Statement_TypesAsync(new Get_Talent_Statement_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Talent_Statement_Types_Request = Get_Talent_Statement_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Talent_Statement_TypeOutput TalentPort.Put_Talent_Statement_Type(Put_Talent_Statement_TypeInput request)
		{
			return base.Channel.Put_Talent_Statement_Type(request);
		}

		public Put_Talent_Statement_Type_ResponseType Put_Talent_Statement_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Statement_Type_RequestType Put_Talent_Statement_Type_Request)
		{
			return ((TalentPort)this).Put_Talent_Statement_Type(new Put_Talent_Statement_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Talent_Statement_Type_Request = Put_Talent_Statement_Type_Request
			}).Put_Talent_Statement_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Talent_Statement_TypeOutput> TalentPort.Put_Talent_Statement_TypeAsync(Put_Talent_Statement_TypeInput request)
		{
			return base.Channel.Put_Talent_Statement_TypeAsync(request);
		}

		public Task<Put_Talent_Statement_TypeOutput> Put_Talent_Statement_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Statement_Type_RequestType Put_Talent_Statement_Type_Request)
		{
			return ((TalentPort)this).Put_Talent_Statement_TypeAsync(new Put_Talent_Statement_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Talent_Statement_Type_Request = Put_Talent_Statement_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Succession_StrategiesOutput TalentPort.Get_Succession_Strategies(Get_Succession_StrategiesInput request)
		{
			return base.Channel.Get_Succession_Strategies(request);
		}

		public Get_Succession_Strategies_ResponseType Get_Succession_Strategies(Workday_Common_HeaderType Workday_Common_Header, Get_Succession_Strategies_RequestType Get_Succession_Strategies_Request)
		{
			return ((TalentPort)this).Get_Succession_Strategies(new Get_Succession_StrategiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Succession_Strategies_Request = Get_Succession_Strategies_Request
			}).Get_Succession_Strategies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Succession_StrategiesOutput> TalentPort.Get_Succession_StrategiesAsync(Get_Succession_StrategiesInput request)
		{
			return base.Channel.Get_Succession_StrategiesAsync(request);
		}

		public Task<Get_Succession_StrategiesOutput> Get_Succession_StrategiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Succession_Strategies_RequestType Get_Succession_Strategies_Request)
		{
			return ((TalentPort)this).Get_Succession_StrategiesAsync(new Get_Succession_StrategiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Succession_Strategies_Request = Get_Succession_Strategies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Succession_StrategyOutput TalentPort.Put_Succession_Strategy(Put_Succession_StrategyInput request)
		{
			return base.Channel.Put_Succession_Strategy(request);
		}

		public Put_Succession_Strategy_ResponseType Put_Succession_Strategy(Workday_Common_HeaderType Workday_Common_Header, Put_Succession_Strategy_RequestType Put_Succession_Strategy_Request)
		{
			return ((TalentPort)this).Put_Succession_Strategy(new Put_Succession_StrategyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Succession_Strategy_Request = Put_Succession_Strategy_Request
			}).Put_Succession_Strategy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Succession_StrategyOutput> TalentPort.Put_Succession_StrategyAsync(Put_Succession_StrategyInput request)
		{
			return base.Channel.Put_Succession_StrategyAsync(request);
		}

		public Task<Put_Succession_StrategyOutput> Put_Succession_StrategyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Succession_Strategy_RequestType Put_Succession_Strategy_Request)
		{
			return ((TalentPort)this).Put_Succession_StrategyAsync(new Put_Succession_StrategyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Succession_Strategy_Request = Put_Succession_Strategy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Connection_TypesOutput TalentPort.Get_Connection_Types(Get_Connection_TypesInput request)
		{
			return base.Channel.Get_Connection_Types(request);
		}

		public Get_Connection_Types_ResponseType Get_Connection_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Connection_Types_RequestType Get_Connection_Types_Request)
		{
			return ((TalentPort)this).Get_Connection_Types(new Get_Connection_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Connection_Types_Request = Get_Connection_Types_Request
			}).Get_Connection_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Connection_TypesOutput> TalentPort.Get_Connection_TypesAsync(Get_Connection_TypesInput request)
		{
			return base.Channel.Get_Connection_TypesAsync(request);
		}

		public Task<Get_Connection_TypesOutput> Get_Connection_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Connection_Types_RequestType Get_Connection_Types_Request)
		{
			return ((TalentPort)this).Get_Connection_TypesAsync(new Get_Connection_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Connection_Types_Request = Get_Connection_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Connection_TypeOutput TalentPort.Put_Connection_Type(Put_Connection_TypeInput request)
		{
			return base.Channel.Put_Connection_Type(request);
		}

		public Put_Connection_Type_ResponseType Put_Connection_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Connection_Type_RequestType Put_Connection_Type_Request)
		{
			return ((TalentPort)this).Put_Connection_Type(new Put_Connection_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Connection_Type_Request = Put_Connection_Type_Request
			}).Put_Connection_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Connection_TypeOutput> TalentPort.Put_Connection_TypeAsync(Put_Connection_TypeInput request)
		{
			return base.Channel.Put_Connection_TypeAsync(request);
		}

		public Task<Put_Connection_TypeOutput> Put_Connection_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Connection_Type_RequestType Put_Connection_Type_Request)
		{
			return ((TalentPort)this).Put_Connection_TypeAsync(new Put_Connection_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Connection_Type_Request = Put_Connection_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Talent_StatementOutput TalentPort.Put_Talent_Statement(Put_Talent_StatementInput request)
		{
			return base.Channel.Put_Talent_Statement(request);
		}

		public Put_Talent_Statement_ResponseType Put_Talent_Statement(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Statement_RequestType Put_Talent_Statement_Request)
		{
			return ((TalentPort)this).Put_Talent_Statement(new Put_Talent_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Talent_Statement_Request = Put_Talent_Statement_Request
			}).Put_Talent_Statement_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Talent_StatementOutput> TalentPort.Put_Talent_StatementAsync(Put_Talent_StatementInput request)
		{
			return base.Channel.Put_Talent_StatementAsync(request);
		}

		public Task<Put_Talent_StatementOutput> Put_Talent_StatementAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Statement_RequestType Put_Talent_Statement_Request)
		{
			return ((TalentPort)this).Put_Talent_StatementAsync(new Put_Talent_StatementInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Talent_Statement_Request = Put_Talent_Statement_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_SkillsOutput TalentPort.Manage_Skills(Manage_SkillsInput request)
		{
			return base.Channel.Manage_Skills(request);
		}

		public Manage_Skills_ResponseType Manage_Skills(Workday_Common_HeaderType Workday_Common_Header, Manage_Skills_RequestType Manage_Skills_Request)
		{
			return ((TalentPort)this).Manage_Skills(new Manage_SkillsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Skills_Request = Manage_Skills_Request
			}).Manage_Skills_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_SkillsOutput> TalentPort.Manage_SkillsAsync(Manage_SkillsInput request)
		{
			return base.Channel.Manage_SkillsAsync(request);
		}

		public Task<Manage_SkillsOutput> Manage_SkillsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Skills_RequestType Manage_Skills_Request)
		{
			return ((TalentPort)this).Manage_SkillsAsync(new Manage_SkillsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Skills_Request = Manage_Skills_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Manage_SkillsOutput TalentPort.Get_Manage_Skills(Get_Manage_SkillsInput request)
		{
			return base.Channel.Get_Manage_Skills(request);
		}

		public Get_Manage_Skills_ResponseType Get_Manage_Skills(Workday_Common_HeaderType Workday_Common_Header, Get_Manage_Skills_RequestType Get_Manage_Skills_Request)
		{
			return ((TalentPort)this).Get_Manage_Skills(new Get_Manage_SkillsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Manage_Skills_Request = Get_Manage_Skills_Request
			}).Get_Manage_Skills_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Manage_SkillsOutput> TalentPort.Get_Manage_SkillsAsync(Get_Manage_SkillsInput request)
		{
			return base.Channel.Get_Manage_SkillsAsync(request);
		}

		public Task<Get_Manage_SkillsOutput> Get_Manage_SkillsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Manage_Skills_RequestType Get_Manage_Skills_Request)
		{
			return ((TalentPort)this).Get_Manage_SkillsAsync(new Get_Manage_SkillsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Manage_Skills_Request = Get_Manage_Skills_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_PublicationsOutput TalentPort.Manage_Publications(Manage_PublicationsInput request)
		{
			return base.Channel.Manage_Publications(request);
		}

		public Manage_Publications_ResponseType Manage_Publications(Workday_Common_HeaderType Workday_Common_Header, Manage_Publications_RequestType Manage_Publications_Request)
		{
			return ((TalentPort)this).Manage_Publications(new Manage_PublicationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Publications_Request = Manage_Publications_Request
			}).Manage_Publications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_PublicationsOutput> TalentPort.Manage_PublicationsAsync(Manage_PublicationsInput request)
		{
			return base.Channel.Manage_PublicationsAsync(request);
		}

		public Task<Manage_PublicationsOutput> Manage_PublicationsAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Publications_RequestType Manage_Publications_Request)
		{
			return ((TalentPort)this).Manage_PublicationsAsync(new Manage_PublicationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Publications_Request = Manage_Publications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Close_Mentorship_ReasonsOutput TalentPort.Get_Close_Mentorship_Reasons(Get_Close_Mentorship_ReasonsInput request)
		{
			return base.Channel.Get_Close_Mentorship_Reasons(request);
		}

		public Get_Close_Mentorship_Reasons_ResponseType Get_Close_Mentorship_Reasons(Workday_Common_HeaderType Workday_Common_Header, Get_Close_Mentorship_Reasons_RequestType Get_Close_Mentorship_Reasons_Request)
		{
			return ((TalentPort)this).Get_Close_Mentorship_Reasons(new Get_Close_Mentorship_ReasonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Close_Mentorship_Reasons_Request = Get_Close_Mentorship_Reasons_Request
			}).Get_Close_Mentorship_Reasons_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Close_Mentorship_ReasonsOutput> TalentPort.Get_Close_Mentorship_ReasonsAsync(Get_Close_Mentorship_ReasonsInput request)
		{
			return base.Channel.Get_Close_Mentorship_ReasonsAsync(request);
		}

		public Task<Get_Close_Mentorship_ReasonsOutput> Get_Close_Mentorship_ReasonsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Close_Mentorship_Reasons_RequestType Get_Close_Mentorship_Reasons_Request)
		{
			return ((TalentPort)this).Get_Close_Mentorship_ReasonsAsync(new Get_Close_Mentorship_ReasonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Close_Mentorship_Reasons_Request = Get_Close_Mentorship_Reasons_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Close_Mentorship_ReasonOutput TalentPort.Put_Close_Mentorship_Reason(Put_Close_Mentorship_ReasonInput request)
		{
			return base.Channel.Put_Close_Mentorship_Reason(request);
		}

		public Put_Close_Mentorship_Reason_ResponseType Put_Close_Mentorship_Reason(Workday_Common_HeaderType Workday_Common_Header, Put_Close_Mentorship_Reason_RequestType Put_Close_Mentorship_Reason_Request)
		{
			return ((TalentPort)this).Put_Close_Mentorship_Reason(new Put_Close_Mentorship_ReasonInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Close_Mentorship_Reason_Request = Put_Close_Mentorship_Reason_Request
			}).Put_Close_Mentorship_Reason_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Close_Mentorship_ReasonOutput> TalentPort.Put_Close_Mentorship_ReasonAsync(Put_Close_Mentorship_ReasonInput request)
		{
			return base.Channel.Put_Close_Mentorship_ReasonAsync(request);
		}

		public Task<Put_Close_Mentorship_ReasonOutput> Put_Close_Mentorship_ReasonAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Close_Mentorship_Reason_RequestType Put_Close_Mentorship_Reason_Request)
		{
			return ((TalentPort)this).Put_Close_Mentorship_ReasonAsync(new Put_Close_Mentorship_ReasonInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Close_Mentorship_Reason_Request = Put_Close_Mentorship_Reason_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_MentorshipsOutput TalentPort.Get_Mentorships(Get_MentorshipsInput request)
		{
			return base.Channel.Get_Mentorships(request);
		}

		public Get_Mentorships_ResponseType Get_Mentorships(Workday_Common_HeaderType Workday_Common_Header, Get_Mentorships_RequestType Get_Mentorships_Request)
		{
			return ((TalentPort)this).Get_Mentorships(new Get_MentorshipsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Mentorships_Request = Get_Mentorships_Request
			}).Get_Mentorships_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_MentorshipsOutput> TalentPort.Get_MentorshipsAsync(Get_MentorshipsInput request)
		{
			return base.Channel.Get_MentorshipsAsync(request);
		}

		public Task<Get_MentorshipsOutput> Get_MentorshipsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Mentorships_RequestType Get_Mentorships_Request)
		{
			return ((TalentPort)this).Get_MentorshipsAsync(new Get_MentorshipsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Mentorships_Request = Get_Mentorships_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_MentorshipOutput TalentPort.Put_Mentorship(Put_MentorshipInput request)
		{
			return base.Channel.Put_Mentorship(request);
		}

		public Put_Mentorship_Event_ResponseType Put_Mentorship(Workday_Common_HeaderType Workday_Common_Header, Put_Mentorship_RequestType Put_Mentorship_Request)
		{
			return ((TalentPort)this).Put_Mentorship(new Put_MentorshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Mentorship_Request = Put_Mentorship_Request
			}).Put_Mentorship_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_MentorshipOutput> TalentPort.Put_MentorshipAsync(Put_MentorshipInput request)
		{
			return base.Channel.Put_MentorshipAsync(request);
		}

		public Task<Put_MentorshipOutput> Put_MentorshipAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Mentorship_RequestType Put_Mentorship_Request)
		{
			return ((TalentPort)this).Put_MentorshipAsync(new Put_MentorshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Mentorship_Request = Put_Mentorship_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Contact_ConnectionsOutput TalentPort.Get_Contact_Connections(Get_Contact_ConnectionsInput request)
		{
			return base.Channel.Get_Contact_Connections(request);
		}

		public Get_Contact_Connections_ResponseType Get_Contact_Connections(Workday_Common_HeaderType Workday_Common_Header, Get_Contact_Connections_RequestType Get_Contact_Connections_Request)
		{
			return ((TalentPort)this).Get_Contact_Connections(new Get_Contact_ConnectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Contact_Connections_Request = Get_Contact_Connections_Request
			}).Get_Contact_Connections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Contact_ConnectionsOutput> TalentPort.Get_Contact_ConnectionsAsync(Get_Contact_ConnectionsInput request)
		{
			return base.Channel.Get_Contact_ConnectionsAsync(request);
		}

		public Task<Get_Contact_ConnectionsOutput> Get_Contact_ConnectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Contact_Connections_RequestType Get_Contact_Connections_Request)
		{
			return ((TalentPort)this).Get_Contact_ConnectionsAsync(new Get_Contact_ConnectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Contact_Connections_Request = Get_Contact_Connections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Contact_ConnectionOutput TalentPort.Put_Contact_Connection(Put_Contact_ConnectionInput request)
		{
			return base.Channel.Put_Contact_Connection(request);
		}

		public Put_Contact_Connection_ResponseType Put_Contact_Connection(Workday_Common_HeaderType Workday_Common_Header, Put_Contact_Connection_RequestType Put_Contact_Connection_Request)
		{
			return ((TalentPort)this).Put_Contact_Connection(new Put_Contact_ConnectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contact_Connection_Request = Put_Contact_Connection_Request
			}).Put_Contact_Connection_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Contact_ConnectionOutput> TalentPort.Put_Contact_ConnectionAsync(Put_Contact_ConnectionInput request)
		{
			return base.Channel.Put_Contact_ConnectionAsync(request);
		}

		public Task<Put_Contact_ConnectionOutput> Put_Contact_ConnectionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Contact_Connection_RequestType Put_Contact_Connection_Request)
		{
			return ((TalentPort)this).Put_Contact_ConnectionAsync(new Put_Contact_ConnectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Contact_Connection_Request = Put_Contact_Connection_Request
			});
		}
	}
}
