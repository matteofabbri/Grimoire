using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Talent", ConfigurationName = "Talent.TalentPort")]
	public interface TalentPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assess_TalentOutput Assess_Talent(Assess_TalentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assess_TalentOutput> Assess_TalentAsync(Assess_TalentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Succession_PlanOutput Manage_Succession_Plan(Manage_Succession_PlanInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Succession_PlanOutput> Manage_Succession_PlanAsync(Manage_Succession_PlanInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Position_for_SuccessionOutput Put_Position_for_Succession(Put_Position_for_SuccessionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Position_for_SuccessionOutput> Put_Position_for_SuccessionAsync(Put_Position_for_SuccessionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_DegreesOutput Get_Degrees(Get_DegreesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_DegreesOutput> Get_DegreesAsync(Get_DegreesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_DegreeOutput Put_Degree(Put_DegreeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_DegreeOutput> Put_DegreeAsync(Put_DegreeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_School_TypesOutput Get_School_Types(Get_School_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_School_TypesOutput> Get_School_TypesAsync(Get_School_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_School_TypeOutput Put_School_Type(Put_School_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_School_TypeOutput> Put_School_TypeAsync(Put_School_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_CertificationsOutput Manage_Certifications(Manage_CertificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_CertificationsOutput> Manage_CertificationsAsync(Manage_CertificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Manage_CertificationsOutput Get_Manage_Certifications(Get_Manage_CertificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Manage_CertificationsOutput> Get_Manage_CertificationsAsync(Get_Manage_CertificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_CompetenciesOutput Manage_Competencies(Manage_CompetenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_CompetenciesOutput> Manage_CompetenciesAsync(Manage_CompetenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Fields_Of_StudyOutput Get_Fields_Of_Study(Get_Fields_Of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Fields_Of_StudyOutput> Get_Fields_Of_StudyAsync(Get_Fields_Of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Field_Of_StudyOutput Put_Field_Of_Study(Put_Field_Of_StudyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Field_Of_StudyOutput> Put_Field_Of_StudyAsync(Put_Field_Of_StudyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Competency_CategoriesOutput Get_Competency_Categories(Get_Competency_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Competency_CategoriesOutput> Get_Competency_CategoriesAsync(Get_Competency_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_TrainingOutput Manage_Training(Manage_TrainingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_TrainingOutput> Manage_TrainingAsync(Manage_TrainingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Awards_and_ActivitiesOutput Manage_Awards_and_Activities(Manage_Awards_and_ActivitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Awards_and_ActivitiesOutput> Manage_Awards_and_ActivitiesAsync(Manage_Awards_and_ActivitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Skill_Source_PrecedencesOutput Get_Skill_Source_Precedences(Get_Skill_Source_PrecedencesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Skill_Source_PrecedencesOutput> Get_Skill_Source_PrecedencesAsync(Get_Skill_Source_PrecedencesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_EducationOutput Manage_Education(Manage_EducationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_EducationOutput> Manage_EducationAsync(Manage_EducationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CompetenciesOutput Get_Competencies(Get_CompetenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CompetenciesOutput> Get_CompetenciesAsync(Get_CompetenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_CompetencyOutput Put_Competency(Put_CompetencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_CompetencyOutput> Put_CompetencyAsync(Put_CompetencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Internal_ProjectsOutput Manage_Internal_Projects(Manage_Internal_ProjectsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Internal_ProjectsOutput> Manage_Internal_ProjectsAsync(Manage_Internal_ProjectsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Work_ExperienceOutput Manage_Work_Experience(Manage_Work_ExperienceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Work_ExperienceOutput> Manage_Work_ExperienceAsync(Manage_Work_ExperienceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Professional_AffiliationsOutput Manage_Professional_Affiliations(Manage_Professional_AffiliationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Professional_AffiliationsOutput> Manage_Professional_AffiliationsAsync(Manage_Professional_AffiliationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_LanguagesOutput Manage_Languages(Manage_LanguagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_LanguagesOutput> Manage_LanguagesAsync(Manage_LanguagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Job_HistoryOutput Manage_Job_History(Manage_Job_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Job_HistoryOutput> Manage_Job_HistoryAsync(Manage_Job_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Talent_PoolsOutput Get_Talent_Pools(Get_Talent_PoolsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Talent_PoolsOutput> Get_Talent_PoolsAsync(Get_Talent_PoolsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Talent_PoolOutput Put_Talent_Pool(Put_Talent_PoolInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Talent_PoolOutput> Put_Talent_PoolAsync(Put_Talent_PoolInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Language_Proficiency_LevelsOutput Get_Language_Proficiency_Levels(Get_Language_Proficiency_LevelsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Language_Proficiency_LevelsOutput> Get_Language_Proficiency_LevelsAsync(Get_Language_Proficiency_LevelsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_LanguagesOutput Get_Languages(Get_LanguagesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_LanguagesOutput> Get_LanguagesAsync(Get_LanguagesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Give_FeedbackOutput Give_Feedback(Give_FeedbackInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Give_FeedbackOutput> Give_FeedbackAsync(Give_FeedbackInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Work_ExperiencesOutput Get_Work_Experiences(Get_Work_ExperiencesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Work_ExperiencesOutput> Get_Work_ExperiencesAsync(Get_Work_ExperiencesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Work_ExperienceOutput Put_Work_Experience(Put_Work_ExperienceInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Work_ExperienceOutput> Put_Work_ExperienceAsync(Put_Work_ExperienceInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SchoolsOutput Get_Schools(Get_SchoolsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SchoolsOutput> Get_SchoolsAsync(Get_SchoolsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SchoolOutput Put_School(Put_SchoolInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SchoolOutput> Put_SchoolAsync(Put_SchoolInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CertificationsOutput Get_Certifications(Get_CertificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CertificationsOutput> Get_CertificationsAsync(Get_CertificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_CertificationOutput Put_Certification(Put_CertificationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_CertificationOutput> Put_CertificationAsync(Put_CertificationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Relocation_PreferencesOutput Edit_Relocation_Preferences(Edit_Relocation_PreferencesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Relocation_PreferencesOutput> Edit_Relocation_PreferencesAsync(Edit_Relocation_PreferencesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Travel_PreferencesOutput Edit_Travel_Preferences(Edit_Travel_PreferencesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Travel_PreferencesOutput> Edit_Travel_PreferencesAsync(Edit_Travel_PreferencesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Career_InterestsOutput Edit_Career_Interests(Edit_Career_InterestsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Career_InterestsOutput> Edit_Career_InterestsAsync(Edit_Career_InterestsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Job_InterestsOutput Edit_Job_Interests(Edit_Job_InterestsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Job_InterestsOutput> Edit_Job_InterestsAsync(Edit_Job_InterestsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SkillOutput Put_Skill(Put_SkillInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SkillOutput> Put_SkillAsync(Put_SkillInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Skill_Item_CategoryOutput Put_Skill_Item_Category(Put_Skill_Item_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Skill_Item_CategoryOutput> Put_Skill_Item_CategoryAsync(Put_Skill_Item_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_History_CompanyOutput Put_Job_History_Company(Put_Job_History_CompanyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_History_CompanyOutput> Put_Job_History_CompanyAsync(Put_Job_History_CompanyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_History_CompaniesOutput Get_Job_History_Companies(Get_Job_History_CompaniesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_History_CompaniesOutput> Get_Job_History_CompaniesAsync(Get_Job_History_CompaniesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Certification_IssuersOutput Get_Certification_Issuers(Get_Certification_IssuersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Certification_IssuersOutput> Get_Certification_IssuersAsync(Get_Certification_IssuersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Certification_IssuerOutput Put_Certification_Issuer(Put_Certification_IssuerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Certification_IssuerOutput> Put_Certification_IssuerAsync(Put_Certification_IssuerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Succession_PoolsOutput Get_Succession_Pools(Get_Succession_PoolsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Succession_PoolsOutput> Get_Succession_PoolsAsync(Get_Succession_PoolsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Succession_PoolOutput Manage_Succession_Pool(Manage_Succession_PoolInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Succession_PoolOutput> Manage_Succession_PoolAsync(Manage_Succession_PoolInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Competency_ClassOutput Put_Competency_Class(Put_Competency_ClassInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Competency_ClassOutput> Put_Competency_ClassAsync(Put_Competency_ClassInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Competency_ClassesOutput Get_Competency_Classes(Get_Competency_ClassesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Competency_ClassesOutput> Get_Competency_ClassesAsync(Get_Competency_ClassesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Proficiency_Rating_ScaleOutput Put_Proficiency_Rating_Scale(Put_Proficiency_Rating_ScaleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Proficiency_Rating_ScaleOutput> Put_Proficiency_Rating_ScaleAsync(Put_Proficiency_Rating_ScaleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Proficiency_Rating_ScalesOutput Get_Proficiency_Rating_Scales(Get_Proficiency_Rating_ScalesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Proficiency_Rating_ScalesOutput> Get_Proficiency_Rating_ScalesAsync(Get_Proficiency_Rating_ScalesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SubspecialtiesOutput Get_Subspecialties(Get_SubspecialtiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SubspecialtiesOutput> Get_SubspecialtiesAsync(Get_SubspecialtiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SubspecialtyOutput Put_Subspecialty(Put_SubspecialtyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SubspecialtyOutput> Put_SubspecialtyAsync(Put_SubspecialtyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_SpecialtiesOutput Get_Specialties(Get_SpecialtiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_SpecialtiesOutput> Get_SpecialtiesAsync(Get_SpecialtiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_SpecialtyOutput Put_Specialty(Put_SpecialtyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_SpecialtyOutput> Put_SpecialtyAsync(Put_SpecialtyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Professional_Affiliation_Relationship_TypesOutput Get_Professional_Affiliation_Relationship_Types(Get_Professional_Affiliation_Relationship_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Professional_Affiliation_Relationship_TypesOutput> Get_Professional_Affiliation_Relationship_TypesAsync(Get_Professional_Affiliation_Relationship_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Professional_Affiliation_Relationship_TypeOutput Put_Professional_Affiliation_Relationship_Type(Put_Professional_Affiliation_Relationship_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Professional_Affiliation_Relationship_TypeOutput> Put_Professional_Affiliation_Relationship_TypeAsync(Put_Professional_Affiliation_Relationship_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Professional_Affiliation_TypesOutput Get_Professional_Affiliation_Types(Get_Professional_Affiliation_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Professional_Affiliation_TypesOutput> Get_Professional_Affiliation_TypesAsync(Get_Professional_Affiliation_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Professional_Affiliation_TypeOutput Put_Professional_Affiliation_Type(Put_Professional_Affiliation_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Professional_Affiliation_TypeOutput> Put_Professional_Affiliation_TypeAsync(Put_Professional_Affiliation_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Professional_AffiliationsOutput Get_Professional_Affiliations(Get_Professional_AffiliationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Professional_AffiliationsOutput> Get_Professional_AffiliationsAsync(Get_Professional_AffiliationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Professional_AffiliationOutput Put_Professional_Affiliation(Put_Professional_AffiliationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Professional_AffiliationOutput> Put_Professional_AffiliationAsync(Put_Professional_AffiliationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Skill_Profile_CategoriesOutput Get_Skill_Profile_Categories(Get_Skill_Profile_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Skill_Profile_CategoriesOutput> Get_Skill_Profile_CategoriesAsync(Get_Skill_Profile_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Skill_Profile_CategoryOutput Put_Skill_Profile_Category(Put_Skill_Profile_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Skill_Profile_CategoryOutput> Put_Skill_Profile_CategoryAsync(Put_Skill_Profile_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Skill_ProfilesOutput Get_Skill_Profiles(Get_Skill_ProfilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Skill_ProfilesOutput> Get_Skill_ProfilesAsync(Get_Skill_ProfilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Skill_ProfileOutput Put_Skill_Profile(Put_Skill_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Skill_ProfileOutput> Put_Skill_ProfileAsync(Put_Skill_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Talent_Statement_TypesOutput Get_Talent_Statement_Types(Get_Talent_Statement_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Talent_Statement_TypesOutput> Get_Talent_Statement_TypesAsync(Get_Talent_Statement_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Talent_Statement_TypeOutput Put_Talent_Statement_Type(Put_Talent_Statement_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Talent_Statement_TypeOutput> Put_Talent_Statement_TypeAsync(Put_Talent_Statement_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Succession_StrategiesOutput Get_Succession_Strategies(Get_Succession_StrategiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Succession_StrategiesOutput> Get_Succession_StrategiesAsync(Get_Succession_StrategiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Succession_StrategyOutput Put_Succession_Strategy(Put_Succession_StrategyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Succession_StrategyOutput> Put_Succession_StrategyAsync(Put_Succession_StrategyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Connection_TypesOutput Get_Connection_Types(Get_Connection_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Connection_TypesOutput> Get_Connection_TypesAsync(Get_Connection_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Connection_TypeOutput Put_Connection_Type(Put_Connection_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Connection_TypeOutput> Put_Connection_TypeAsync(Put_Connection_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Talent_StatementOutput Put_Talent_Statement(Put_Talent_StatementInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Talent_StatementOutput> Put_Talent_StatementAsync(Put_Talent_StatementInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_SkillsOutput Manage_Skills(Manage_SkillsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_SkillsOutput> Manage_SkillsAsync(Manage_SkillsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Manage_SkillsOutput Get_Manage_Skills(Get_Manage_SkillsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Manage_SkillsOutput> Get_Manage_SkillsAsync(Get_Manage_SkillsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_PublicationsOutput Manage_Publications(Manage_PublicationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_PublicationsOutput> Manage_PublicationsAsync(Manage_PublicationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Close_Mentorship_ReasonsOutput Get_Close_Mentorship_Reasons(Get_Close_Mentorship_ReasonsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Close_Mentorship_ReasonsOutput> Get_Close_Mentorship_ReasonsAsync(Get_Close_Mentorship_ReasonsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Close_Mentorship_ReasonOutput Put_Close_Mentorship_Reason(Put_Close_Mentorship_ReasonInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Close_Mentorship_ReasonOutput> Put_Close_Mentorship_ReasonAsync(Put_Close_Mentorship_ReasonInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_MentorshipsOutput Get_Mentorships(Get_MentorshipsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_MentorshipsOutput> Get_MentorshipsAsync(Get_MentorshipsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_MentorshipOutput Put_Mentorship(Put_MentorshipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_MentorshipOutput> Put_MentorshipAsync(Put_MentorshipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Contact_ConnectionsOutput Get_Contact_Connections(Get_Contact_ConnectionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Contact_ConnectionsOutput> Get_Contact_ConnectionsAsync(Get_Contact_ConnectionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Contact_ConnectionOutput Put_Contact_Connection(Put_Contact_ConnectionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Contact_ConnectionOutput> Put_Contact_ConnectionAsync(Put_Contact_ConnectionInput request);
	}
}
