using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_Biographic_and_Demographic_Information_DataType : INotifyPropertyChanged
	{
		private GenderObjectType gender_ReferenceField;

		private DateTime date_of_BirthField;

		private bool date_of_BirthFieldSpecified;

		private CountryObjectType birth_Country_ReferenceField;

		private Country_RegionObjectType birth_Region_ReferenceField;

		private string city_of_BirthField;

		private Marital_StatusObjectType marital_Status_ReferenceField;

		private bool hispanic_or_LatinoField;

		private bool hispanic_or_LatinoFieldSpecified;

		private EthnicityObjectType[] ethnicity_ReferenceField;

		private ReligionObjectType religion_ReferenceField;

		private Citizenship_StatusObjectType[] citizenship_ReferenceField;

		private CountryObjectType nationality_ReferenceField;

		private CountryObjectType[] additional_Nationality_ReferenceField;

		private Social_Benefits_LocalityObjectType social_Benefits_Locality_ReferenceField;

		private LGBT_IdentificationObjectType[] lGBT_Identification_ReferenceField;

		private Candidate_Disability_Status_DataType[] disability_Status_DataField;

		private Candidate_Military_Service_Information_DataType[] military_Service_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement("Ethnicity_Reference", Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Citizenship_Reference", Order = 9)]
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

		[XmlElement(Order = 10)]
		public CountryObjectType Nationality_Reference
		{
			get
			{
				return this.nationality_ReferenceField;
			}
			set
			{
				this.nationality_ReferenceField = value;
				this.RaisePropertyChanged("Nationality_Reference");
			}
		}

		[XmlElement("Additional_Nationality_Reference", Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement("LGBT_Identification_Reference", Order = 13)]
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

		[XmlElement("Disability_Status_Data", Order = 14)]
		public Candidate_Disability_Status_DataType[] Disability_Status_Data
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

		[XmlElement("Military_Service_Information_Data", Order = 15)]
		public Candidate_Military_Service_Information_DataType[] Military_Service_Information_Data
		{
			get
			{
				return this.military_Service_Information_DataField;
			}
			set
			{
				this.military_Service_Information_DataField = value;
				this.RaisePropertyChanged("Military_Service_Information_Data");
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
