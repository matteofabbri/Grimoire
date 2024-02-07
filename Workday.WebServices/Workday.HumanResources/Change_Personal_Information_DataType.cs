using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Change_Personal_Information_DataType : INotifyPropertyChanged
	{
		private DateTime date_of_BirthField;

		private bool date_of_BirthFieldSpecified;

		private CountryObjectType birth_Country_ReferenceField;

		private Country_RegionObjectType birth_Region_ReferenceField;

		private GenderObjectType gender_ReferenceField;

		private Disability_Information_DataType disability_Information_DataField;

		private Marital_StatusObjectType marital_Status_ReferenceField;

		private Citizenship_StatusObjectType[] citizenship_ReferenceField;

		private CountryObjectType primary_Nationality_ReferenceField;

		private CountryObjectType[] additional_Nationality_ReferenceField;

		private EthnicityObjectType[] ethnicity_ReferenceField;

		private bool hispanic_or_LatinoField;

		private bool hispanic_or_LatinoFieldSpecified;

		private EthnicityObjectType[] visual_Survey_Ethnicity_ReferenceField;

		private bool hispanic_or_Latino_for_Visual_SurveyField;

		private bool hispanic_or_Latino_for_Visual_SurveyFieldSpecified;

		private ReligionObjectType religion_ReferenceField;

		private Country_RegionObjectType hukou_Region_ReferenceField;

		private Country_SubregionObjectType hukou_Subregion_ReferenceField;

		private string hukou_LocalityField;

		private string hukou_Postal_CodeField;

		private Hukou_TypeObjectType hukou_Type_ReferenceField;

		private Country_RegionObjectType native_Region_ReferenceField;

		private string personnel_File_AgencyField;

		private Military_Information_DataType military_Information_DataField;

		private Political_AffiliationObjectType political_Affiliation_ReferenceField;

		private DateTime date_of_DeathField;

		private bool date_of_DeathFieldSpecified;

		private string city_of_BirthField;

		private DateTime marital_Status_DateField;

		private bool marital_Status_DateFieldSpecified;

		private DateTime last_Medical_Exam_DateField;

		private bool last_Medical_Exam_DateFieldSpecified;

		private DateTime last_Medical_Exam_Valid_ToField;

		private bool last_Medical_Exam_Valid_ToFieldSpecified;

		private string medical_Exam_NotesField;

		private bool uses_TobaccoField;

		private bool uses_TobaccoFieldSpecified;

		private Social_Benefits_LocalityObjectType social_Benefits_Locality_ReferenceField;

		private LGBT_IdentificationObjectType[] lGBT_Identification_ReferenceField;

		private Sexual_OrientationObjectType sexual_Orientation_ReferenceField;

		private Gender_IdentityObjectType gender_Identity_ReferenceField;

		private PronounObjectType pronoun_ReferenceField;

		private Relative_Name_Information_DataType relative_Name_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Date_of_Birth
		{
			get
			{
				return this.date_of_BirthField;
			}
			set
			{
				this.date_of_BirthField = value;
				this.RaisePropertyChanged("Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Date_of_BirthSpecified
		{
			get
			{
				return this.date_of_BirthFieldSpecified;
			}
			set
			{
				this.date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_BirthSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public CountryObjectType Birth_Country_Reference
		{
			get
			{
				return this.birth_Country_ReferenceField;
			}
			set
			{
				this.birth_Country_ReferenceField = value;
				this.RaisePropertyChanged("Birth_Country_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Country_RegionObjectType Birth_Region_Reference
		{
			get
			{
				return this.birth_Region_ReferenceField;
			}
			set
			{
				this.birth_Region_ReferenceField = value;
				this.RaisePropertyChanged("Birth_Region_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public GenderObjectType Gender_Reference
		{
			get
			{
				return this.gender_ReferenceField;
			}
			set
			{
				this.gender_ReferenceField = value;
				this.RaisePropertyChanged("Gender_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Disability_Information_DataType Disability_Information_Data
		{
			get
			{
				return this.disability_Information_DataField;
			}
			set
			{
				this.disability_Information_DataField = value;
				this.RaisePropertyChanged("Disability_Information_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Marital_StatusObjectType Marital_Status_Reference
		{
			get
			{
				return this.marital_Status_ReferenceField;
			}
			set
			{
				this.marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Marital_Status_Reference");
			}
		}

		[XmlElement("Citizenship_Reference", Order = 6)]
		public Citizenship_StatusObjectType[] Citizenship_Reference
		{
			get
			{
				return this.citizenship_ReferenceField;
			}
			set
			{
				this.citizenship_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public CountryObjectType Primary_Nationality_Reference
		{
			get
			{
				return this.primary_Nationality_ReferenceField;
			}
			set
			{
				this.primary_Nationality_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Nationality_Reference");
			}
		}

		[XmlElement("Additional_Nationality_Reference", Order = 8)]
		public CountryObjectType[] Additional_Nationality_Reference
		{
			get
			{
				return this.additional_Nationality_ReferenceField;
			}
			set
			{
				this.additional_Nationality_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Nationality_Reference");
			}
		}

		[XmlElement("Ethnicity_Reference", Order = 9)]
		public EthnicityObjectType[] Ethnicity_Reference
		{
			get
			{
				return this.ethnicity_ReferenceField;
			}
			set
			{
				this.ethnicity_ReferenceField = value;
				this.RaisePropertyChanged("Ethnicity_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Hispanic_or_Latino
		{
			get
			{
				return this.hispanic_or_LatinoField;
			}
			set
			{
				this.hispanic_or_LatinoField = value;
				this.RaisePropertyChanged("Hispanic_or_Latino");
			}
		}

		[XmlIgnore]
		public bool Hispanic_or_LatinoSpecified
		{
			get
			{
				return this.hispanic_or_LatinoFieldSpecified;
			}
			set
			{
				this.hispanic_or_LatinoFieldSpecified = value;
				this.RaisePropertyChanged("Hispanic_or_LatinoSpecified");
			}
		}

		[XmlElement("Visual_Survey_Ethnicity_Reference", Order = 11)]
		public EthnicityObjectType[] Visual_Survey_Ethnicity_Reference
		{
			get
			{
				return this.visual_Survey_Ethnicity_ReferenceField;
			}
			set
			{
				this.visual_Survey_Ethnicity_ReferenceField = value;
				this.RaisePropertyChanged("Visual_Survey_Ethnicity_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public bool Hispanic_or_Latino_for_Visual_Survey
		{
			get
			{
				return this.hispanic_or_Latino_for_Visual_SurveyField;
			}
			set
			{
				this.hispanic_or_Latino_for_Visual_SurveyField = value;
				this.RaisePropertyChanged("Hispanic_or_Latino_for_Visual_Survey");
			}
		}

		[XmlIgnore]
		public bool Hispanic_or_Latino_for_Visual_SurveySpecified
		{
			get
			{
				return this.hispanic_or_Latino_for_Visual_SurveyFieldSpecified;
			}
			set
			{
				this.hispanic_or_Latino_for_Visual_SurveyFieldSpecified = value;
				this.RaisePropertyChanged("Hispanic_or_Latino_for_Visual_SurveySpecified");
			}
		}

		[XmlElement(Order = 13)]
		public ReligionObjectType Religion_Reference
		{
			get
			{
				return this.religion_ReferenceField;
			}
			set
			{
				this.religion_ReferenceField = value;
				this.RaisePropertyChanged("Religion_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Country_RegionObjectType Hukou_Region_Reference
		{
			get
			{
				return this.hukou_Region_ReferenceField;
			}
			set
			{
				this.hukou_Region_ReferenceField = value;
				this.RaisePropertyChanged("Hukou_Region_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Country_SubregionObjectType Hukou_Subregion_Reference
		{
			get
			{
				return this.hukou_Subregion_ReferenceField;
			}
			set
			{
				this.hukou_Subregion_ReferenceField = value;
				this.RaisePropertyChanged("Hukou_Subregion_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public string Hukou_Locality
		{
			get
			{
				return this.hukou_LocalityField;
			}
			set
			{
				this.hukou_LocalityField = value;
				this.RaisePropertyChanged("Hukou_Locality");
			}
		}

		[XmlElement(Order = 17)]
		public string Hukou_Postal_Code
		{
			get
			{
				return this.hukou_Postal_CodeField;
			}
			set
			{
				this.hukou_Postal_CodeField = value;
				this.RaisePropertyChanged("Hukou_Postal_Code");
			}
		}

		[XmlElement(Order = 18)]
		public Hukou_TypeObjectType Hukou_Type_Reference
		{
			get
			{
				return this.hukou_Type_ReferenceField;
			}
			set
			{
				this.hukou_Type_ReferenceField = value;
				this.RaisePropertyChanged("Hukou_Type_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Country_RegionObjectType Native_Region_Reference
		{
			get
			{
				return this.native_Region_ReferenceField;
			}
			set
			{
				this.native_Region_ReferenceField = value;
				this.RaisePropertyChanged("Native_Region_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public string Personnel_File_Agency
		{
			get
			{
				return this.personnel_File_AgencyField;
			}
			set
			{
				this.personnel_File_AgencyField = value;
				this.RaisePropertyChanged("Personnel_File_Agency");
			}
		}

		[XmlElement(Order = 21)]
		public Military_Information_DataType Military_Information_Data
		{
			get
			{
				return this.military_Information_DataField;
			}
			set
			{
				this.military_Information_DataField = value;
				this.RaisePropertyChanged("Military_Information_Data");
			}
		}

		[XmlElement(Order = 22)]
		public Political_AffiliationObjectType Political_Affiliation_Reference
		{
			get
			{
				return this.political_Affiliation_ReferenceField;
			}
			set
			{
				this.political_Affiliation_ReferenceField = value;
				this.RaisePropertyChanged("Political_Affiliation_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 23)]
		public DateTime Date_of_Death
		{
			get
			{
				return this.date_of_DeathField;
			}
			set
			{
				this.date_of_DeathField = value;
				this.RaisePropertyChanged("Date_of_Death");
			}
		}

		[XmlIgnore]
		public bool Date_of_DeathSpecified
		{
			get
			{
				return this.date_of_DeathFieldSpecified;
			}
			set
			{
				this.date_of_DeathFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_DeathSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public string City_of_Birth
		{
			get
			{
				return this.city_of_BirthField;
			}
			set
			{
				this.city_of_BirthField = value;
				this.RaisePropertyChanged("City_of_Birth");
			}
		}

		[XmlElement(DataType = "date", Order = 25)]
		public DateTime Marital_Status_Date
		{
			get
			{
				return this.marital_Status_DateField;
			}
			set
			{
				this.marital_Status_DateField = value;
				this.RaisePropertyChanged("Marital_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Marital_Status_DateSpecified
		{
			get
			{
				return this.marital_Status_DateFieldSpecified;
			}
			set
			{
				this.marital_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Marital_Status_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 26)]
		public DateTime Last_Medical_Exam_Date
		{
			get
			{
				return this.last_Medical_Exam_DateField;
			}
			set
			{
				this.last_Medical_Exam_DateField = value;
				this.RaisePropertyChanged("Last_Medical_Exam_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Medical_Exam_DateSpecified
		{
			get
			{
				return this.last_Medical_Exam_DateFieldSpecified;
			}
			set
			{
				this.last_Medical_Exam_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Medical_Exam_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 27)]
		public DateTime Last_Medical_Exam_Valid_To
		{
			get
			{
				return this.last_Medical_Exam_Valid_ToField;
			}
			set
			{
				this.last_Medical_Exam_Valid_ToField = value;
				this.RaisePropertyChanged("Last_Medical_Exam_Valid_To");
			}
		}

		[XmlIgnore]
		public bool Last_Medical_Exam_Valid_ToSpecified
		{
			get
			{
				return this.last_Medical_Exam_Valid_ToFieldSpecified;
			}
			set
			{
				this.last_Medical_Exam_Valid_ToFieldSpecified = value;
				this.RaisePropertyChanged("Last_Medical_Exam_Valid_ToSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public string Medical_Exam_Notes
		{
			get
			{
				return this.medical_Exam_NotesField;
			}
			set
			{
				this.medical_Exam_NotesField = value;
				this.RaisePropertyChanged("Medical_Exam_Notes");
			}
		}

		[XmlElement(Order = 29)]
		public bool Uses_Tobacco
		{
			get
			{
				return this.uses_TobaccoField;
			}
			set
			{
				this.uses_TobaccoField = value;
				this.RaisePropertyChanged("Uses_Tobacco");
			}
		}

		[XmlIgnore]
		public bool Uses_TobaccoSpecified
		{
			get
			{
				return this.uses_TobaccoFieldSpecified;
			}
			set
			{
				this.uses_TobaccoFieldSpecified = value;
				this.RaisePropertyChanged("Uses_TobaccoSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public Social_Benefits_LocalityObjectType Social_Benefits_Locality_Reference
		{
			get
			{
				return this.social_Benefits_Locality_ReferenceField;
			}
			set
			{
				this.social_Benefits_Locality_ReferenceField = value;
				this.RaisePropertyChanged("Social_Benefits_Locality_Reference");
			}
		}

		[XmlElement("LGBT_Identification_Reference", Order = 31)]
		public LGBT_IdentificationObjectType[] LGBT_Identification_Reference
		{
			get
			{
				return this.lGBT_Identification_ReferenceField;
			}
			set
			{
				this.lGBT_Identification_ReferenceField = value;
				this.RaisePropertyChanged("LGBT_Identification_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public Sexual_OrientationObjectType Sexual_Orientation_Reference
		{
			get
			{
				return this.sexual_Orientation_ReferenceField;
			}
			set
			{
				this.sexual_Orientation_ReferenceField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public Gender_IdentityObjectType Gender_Identity_Reference
		{
			get
			{
				return this.gender_Identity_ReferenceField;
			}
			set
			{
				this.gender_Identity_ReferenceField = value;
				this.RaisePropertyChanged("Gender_Identity_Reference");
			}
		}

		[XmlElement(Order = 34)]
		public PronounObjectType Pronoun_Reference
		{
			get
			{
				return this.pronoun_ReferenceField;
			}
			set
			{
				this.pronoun_ReferenceField = value;
				this.RaisePropertyChanged("Pronoun_Reference");
			}
		}

		[XmlElement(Order = 35)]
		public Relative_Name_Information_DataType Relative_Name_Information_Data
		{
			get
			{
				return this.relative_Name_Information_DataField;
			}
			set
			{
				this.relative_Name_Information_DataField = value;
				this.RaisePropertyChanged("Relative_Name_Information_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
