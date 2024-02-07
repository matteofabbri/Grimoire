using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Performance_Management", ConfigurationName = "PerformanceManagement.Performance_ManagementPort")]
	public interface Performance_ManagementPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Start_Performance_ReviewOutput Start_Performance_Review(Start_Performance_ReviewInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Start_Performance_ReviewOutput> Start_Performance_ReviewAsync(Start_Performance_ReviewInput request);

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
		Manage_GoalsOutput Manage_Goals(Manage_GoalsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_GoalsOutput> Manage_GoalsAsync(Manage_GoalsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Competency_CategoryOutput Put_Competency_Category(Put_Competency_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Competency_CategoryOutput> Put_Competency_CategoryAsync(Put_Competency_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Skill_Source_PrecedencesOutput Get_Skill_Source_Precedences(Get_Skill_Source_PrecedencesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Skill_Source_PrecedencesOutput> Get_Skill_Source_PrecedencesAsync(Get_Skill_Source_PrecedencesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CompetenciesOutput Get_Competencies(Get_CompetenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CompetenciesOutput> Get_CompetenciesAsync(Get_CompetenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_CompetencyOutput Put_Competency(Put_CompetencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_CompetencyOutput> Put_CompetencyAsync(Put_CompetencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Employee_Review_RatingOutput Update_Employee_Review_Rating(Update_Employee_Review_RatingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Employee_Review_RatingOutput> Update_Employee_Review_RatingAsync(Update_Employee_Review_RatingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CertificationsOutput Get_Certifications(Get_CertificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CertificationsOutput> Get_CertificationsAsync(Get_CertificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_CertificationOutput Put_Certification(Put_CertificationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_CertificationOutput> Put_CertificationAsync(Put_CertificationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Certification_IssuersOutput Get_Certification_Issuers(Get_Certification_IssuersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Certification_IssuersOutput> Get_Certification_IssuersAsync(Get_Certification_IssuersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Certification_IssuerOutput Put_Certification_Issuer(Put_Certification_IssuerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Certification_IssuerOutput> Put_Certification_IssuerAsync(Put_Certification_IssuerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Goal_UnitsOutput Get_Goal_Units(Get_Goal_UnitsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Goal_UnitsOutput> Get_Goal_UnitsAsync(Get_Goal_UnitsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Goal_UnitOutput Put_Goal_Unit(Put_Goal_UnitInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Goal_UnitOutput> Put_Goal_UnitAsync(Put_Goal_UnitInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Feedback_BadgesOutput Get_Feedback_Badges(Get_Feedback_BadgesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Feedback_BadgesOutput> Get_Feedback_BadgesAsync(Get_Feedback_BadgesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Feedback_BadgeOutput Put_Feedback_Badge(Put_Feedback_BadgeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Feedback_BadgeOutput> Put_Feedback_BadgeAsync(Put_Feedback_BadgeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Review_TypesOutput Get_Review_Types(Get_Review_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Review_TypesOutput> Get_Review_TypesAsync(Get_Review_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Review_TypeOutput Put_Review_Type(Put_Review_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Review_TypeOutput> Put_Review_TypeAsync(Put_Review_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Feedback_and_Review_Question_CategoriesOutput Get_Feedback_and_Review_Question_Categories(Get_Feedback_and_Review_Question_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Feedback_and_Review_Question_CategoriesOutput> Get_Feedback_and_Review_Question_CategoriesAsync(Get_Feedback_and_Review_Question_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Feedback_and_Review_QuestionsOutput Get_Feedback_and_Review_Questions(Get_Feedback_and_Review_QuestionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Feedback_and_Review_QuestionsOutput> Get_Feedback_and_Review_QuestionsAsync(Get_Feedback_and_Review_QuestionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Feedback_and_Review_Question_CategoryOutput Put_Feedback_and_Review_Question_Category(Put_Feedback_and_Review_Question_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Feedback_and_Review_Question_CategoryOutput> Put_Feedback_and_Review_Question_CategoryAsync(Put_Feedback_and_Review_Question_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Feedback_and_Review_QuestionOutput Put_Feedback_and_Review_Question(Put_Feedback_and_Review_QuestionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Feedback_and_Review_QuestionOutput> Put_Feedback_and_Review_QuestionAsync(Put_Feedback_and_Review_QuestionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_ReviewsOutput Get_Employee_Reviews(Get_Employee_ReviewsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_ReviewsOutput> Get_Employee_ReviewsAsync(Get_Employee_ReviewsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Employee_ReviewsOutput Import_Employee_Reviews(Import_Employee_ReviewsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Employee_ReviewsOutput> Import_Employee_ReviewsAsync(Import_Employee_ReviewsInput request);
	}
}
