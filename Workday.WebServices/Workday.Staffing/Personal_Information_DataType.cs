using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Personal_Information_DataType : INotifyPropertyChanged
	{
		private string universal_IDField;

		private Person_Name_DataType name_DataField;

		private GenderObjectType gender_ReferenceField;

		private DateTime birth_DateField;

		private bool birth_DateFieldSpecified;

		private DateTime date_of_DeathField;

		private bool date_of_DeathFieldSpecified;

		private CountryObjectType country_of_Birth_ReferenceField;

		private Country_RegionObjectType region_of_Birth_ReferenceField;

		private string region_of_Birth_DescriptorField;

		private string city_of_BirthField;

		private Marital_StatusObjectType marital_Status_ReferenceField;

		private DateTime marital_Status_DateField;

		private bool marital_Status_DateFieldSpecified;

		private ReligionObjectType religion_ReferenceField;

		private Person_Disability_Status_DataType[] disability_Status_DataField;

		private EthnicityObjectType[] ethnicity_ReferenceField;

		private bool hispanic_or_LatinoField;

		private bool hispanic_or_LatinoFieldSpecified;

		private Citizenship_StatusObjectType[] citizenship_Status_ReferenceField;

		private CountryObjectType primary_Nationality_ReferenceField;

		private CountryObjectType[] additional_Nationality_ReferenceField;

		private Country_RegionObjectType hukou_Region_ReferenceField;

		private Country_SubregionObjectType hukou_Subregion_ReferenceField;

		private string hukou_LocalityField;

		private string hukou_Postal_CodeField;

		private Hukou_TypeObjectType hukou_Type_ReferenceField;

		private bool local_HukouField;

		private bool local_HukouFieldSpecified;

		private Country_RegionObjectType native_Region_ReferenceField;

		private string native_Region_DescriptorField;

		private string personnel_File_Agency_for_PersonField;

		private DateTime last_Medical_Exam_DateField;

		private bool last_Medical_Exam_DateFieldSpecified;

		private DateTime last_Medical_Exam_Valid_ToField;

		private bool last_Medical_Exam_Valid_ToFieldSpecified;

		private string medical_Exam_NotesField;

		private Person_Military_Service_DataType[] military_Service_DataField;

		private Person_Identification_DataType identification_DataField;

		private Contact_Information_DataType contact_DataField;

		private bool tobacco_UseField;

		private bool tobacco_UseFieldSpecified;

		private Political_AffiliationObjectType political_Affiliation_ReferenceField;

		private Social_Benefits_LocalityObjectType social_Benefits_Locality_ReferenceField;

		private Relative_Name_Information_DataType relative_Name_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Universal_ID
		{
			get
			{
				return this.universal_IDField;
			}
			set
			{
				this.universal_IDField = value;
				this.RaisePropertyChanged("Universal_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Person_Name_DataType Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Birth_Date
		{
			get
			{
				return this.birth_DateField;
			}
			set
			{
				this.birth_DateField = value;
				this.RaisePropertyChanged("Birth_Date");
			}
		}

		[XmlIgnore]
		public bool Birth_DateSpecified
		{
			get
			{
				return this.birth_DateFieldSpecified;
			}
			set
			{
				this.birth_DateFieldSpecified = value;
				this.RaisePropertyChanged("Birth_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(Order = 5)]
		public CountryObjectType Country_of_Birth_Reference
		{
			get
			{
				return this.country_of_Birth_ReferenceField;
			}
			set
			{
				this.country_of_Birth_ReferenceField = value;
				this.RaisePropertyChanged("Country_of_Birth_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Country_RegionObjectType Region_of_Birth_Reference
		{
			get
			{
				return this.region_of_Birth_ReferenceField;
			}
			set
			{
				this.region_of_Birth_ReferenceField = value;
				this.RaisePropertyChanged("Region_of_Birth_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Region_of_Birth_Descriptor
		{
			get
			{
				return this.region_of_Birth_DescriptorField;
			}
			set
			{
				this.region_of_Birth_DescriptorField = value;
				this.RaisePropertyChanged("Region_of_Birth_Descriptor");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement("Disability_Status_Data", Order = 12)]
		public Person_Disability_Status_DataType[] Disability_Status_Data
		{
			get
			{
				return this.disability_Status_DataField;
			}
			set
			{
				this.disability_Status_DataField = value;
				this.RaisePropertyChanged("Disability_Status_Data");
			}
		}

		[XmlElement("Ethnicity_Reference", Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement("Citizenship_Status_Reference", Order = 15)]
		public Citizenship_StatusObjectType[] Citizenship_Status_Reference
		{
			get
			{
				return this.citizenship_Status_ReferenceField;
			}
			set
			{
				this.citizenship_Status_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Status_Reference");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement("Additional_Nationality_Reference", Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public bool Local_Hukou
		{
			get
			{
				return this.local_HukouField;
			}
			set
			{
				this.local_HukouField = value;
				this.RaisePropertyChanged("Local_Hukou");
			}
		}

		[XmlIgnore]
		public bool Local_HukouSpecified
		{
			get
			{
				return this.local_HukouFieldSpecified;
			}
			set
			{
				this.local_HukouFieldSpecified = value;
				this.RaisePropertyChanged("Local_HukouSpecified");
			}
		}

		[XmlElement(Order = 24)]
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

		[XmlElement(Order = 25)]
		public string Native_Region_Descriptor
		{
			get
			{
				return this.native_Region_DescriptorField;
			}
			set
			{
				this.native_Region_DescriptorField = value;
				this.RaisePropertyChanged("Native_Region_Descriptor");
			}
		}

		[XmlElement(Order = 26)]
		public string Personnel_File_Agency_for_Person
		{
			get
			{
				return this.personnel_File_Agency_for_PersonField;
			}
			set
			{
				this.personnel_File_Agency_for_PersonField = value;
				this.RaisePropertyChanged("Personnel_File_Agency_for_Person");
			}
		}

		[XmlElement(DataType = "date", Order = 27)]
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

		[XmlElement(DataType = "date", Order = 28)]
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

		[XmlElement(Order = 29)]
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

		[XmlElement("Military_Service_Data", Order = 30)]
		public Person_Military_Service_DataType[] Military_Service_Data
		{
			get
			{
				return this.military_Service_DataField;
			}
			set
			{
				this.military_Service_DataField = value;
				this.RaisePropertyChanged("Military_Service_Data");
			}
		}

		[XmlElement(Order = 31)]
		public Person_Identification_DataType Identification_Data
		{
			get
			{
				return this.identification_DataField;
			}
			set
			{
				this.identification_DataField = value;
				this.RaisePropertyChanged("Identification_Data");
			}
		}

		[XmlElement(Order = 32)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement(Order = 33)]
		public bool Tobacco_Use
		{
			get
			{
				return this.tobacco_UseField;
			}
			set
			{
				this.tobacco_UseField = value;
				this.RaisePropertyChanged("Tobacco_Use");
			}
		}

		[XmlIgnore]
		public bool Tobacco_UseSpecified
		{
			get
			{
				return this.tobacco_UseFieldSpecified;
			}
			set
			{
				this.tobacco_UseFieldSpecified = value;
				this.RaisePropertyChanged("Tobacco_UseSpecified");
			}
		}

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement(Order = 36)]
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
