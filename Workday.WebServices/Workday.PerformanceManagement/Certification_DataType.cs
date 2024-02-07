using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Certification_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private string issuerField;

		private Certification_IssuerObjectType issuer_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType[] restrict_to_Country_Region_ReferenceField;

		private Specialty_ParentObjectType[] specialty_ReferenceField;

		private bool restrict_Specialty_to_CertificationField;

		private bool restrict_Specialty_to_CertificationFieldSpecified;

		private bool renewable_Required_Field;

		private bool renewable_Required_FieldSpecified;

		private decimal renewable_In__months_Field;

		private bool renewable_In__months_FieldSpecified;

		private bool track_Exam_Date_and_ScoreField;

		private bool track_Exam_Date_and_ScoreFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private decimal usage_CountField;

		private bool usage_CountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Issuer
		{
			get
			{
				return this.issuerField;
			}
			set
			{
				this.issuerField = value;
				this.RaisePropertyChanged("Issuer");
			}
		}

		[XmlElement(Order = 3)]
		public Certification_IssuerObjectType Issuer_Reference
		{
			get
			{
				return this.issuer_ReferenceField;
			}
			set
			{
				this.issuer_ReferenceField = value;
				this.RaisePropertyChanged("Issuer_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Restrict_to_Country_Region_Reference", Order = 5)]
		public Country_RegionObjectType[] Restrict_to_Country_Region_Reference
		{
			get
			{
				return this.restrict_to_Country_Region_ReferenceField;
			}
			set
			{
				this.restrict_to_Country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Restrict_to_Country_Region_Reference");
			}
		}

		[XmlElement("Specialty_Reference", Order = 6)]
		public Specialty_ParentObjectType[] Specialty_Reference
		{
			get
			{
				return this.specialty_ReferenceField;
			}
			set
			{
				this.specialty_ReferenceField = value;
				this.RaisePropertyChanged("Specialty_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Restrict_Specialty_to_Certification
		{
			get
			{
				return this.restrict_Specialty_to_CertificationField;
			}
			set
			{
				this.restrict_Specialty_to_CertificationField = value;
				this.RaisePropertyChanged("Restrict_Specialty_to_Certification");
			}
		}

		[XmlIgnore]
		public bool Restrict_Specialty_to_CertificationSpecified
		{
			get
			{
				return this.restrict_Specialty_to_CertificationFieldSpecified;
			}
			set
			{
				this.restrict_Specialty_to_CertificationFieldSpecified = value;
				this.RaisePropertyChanged("Restrict_Specialty_to_CertificationSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Renewable_Required_
		{
			get
			{
				return this.renewable_Required_Field;
			}
			set
			{
				this.renewable_Required_Field = value;
				this.RaisePropertyChanged("Renewable_Required_");
			}
		}

		[XmlIgnore]
		public bool Renewable_Required_Specified
		{
			get
			{
				return this.renewable_Required_FieldSpecified;
			}
			set
			{
				this.renewable_Required_FieldSpecified = value;
				this.RaisePropertyChanged("Renewable_Required_Specified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Renewable_In__months_
		{
			get
			{
				return this.renewable_In__months_Field;
			}
			set
			{
				this.renewable_In__months_Field = value;
				this.RaisePropertyChanged("Renewable_In__months_");
			}
		}

		[XmlIgnore]
		public bool Renewable_In__months_Specified
		{
			get
			{
				return this.renewable_In__months_FieldSpecified;
			}
			set
			{
				this.renewable_In__months_FieldSpecified = value;
				this.RaisePropertyChanged("Renewable_In__months_Specified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Track_Exam_Date_and_Score
		{
			get
			{
				return this.track_Exam_Date_and_ScoreField;
			}
			set
			{
				this.track_Exam_Date_and_ScoreField = value;
				this.RaisePropertyChanged("Track_Exam_Date_and_Score");
			}
		}

		[XmlIgnore]
		public bool Track_Exam_Date_and_ScoreSpecified
		{
			get
			{
				return this.track_Exam_Date_and_ScoreFieldSpecified;
			}
			set
			{
				this.track_Exam_Date_and_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("Track_Exam_Date_and_ScoreSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Usage_Count
		{
			get
			{
				return this.usage_CountField;
			}
			set
			{
				this.usage_CountField = value;
				this.RaisePropertyChanged("Usage_Count");
			}
		}

		[XmlIgnore]
		public bool Usage_CountSpecified
		{
			get
			{
				return this.usage_CountFieldSpecified;
			}
			set
			{
				this.usage_CountFieldSpecified = value;
				this.RaisePropertyChanged("Usage_CountSpecified");
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
