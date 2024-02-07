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
	public class Certification_Profile_for_Job_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private CertificationObjectType certification_ReferenceField;

		private string certification_NameField;

		private string certification_IssuerField;

		private bool requiredField;

		private bool requiredFieldSpecified;

		private Skill_Qualification_EnabledObjectType qualification_Source_ReferenceField;

		private Specialty_Achievement_DataType[] specialty_Achievement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public CertificationObjectType Certification_Reference
		{
			get
			{
				return this.certification_ReferenceField;
			}
			set
			{
				this.certification_ReferenceField = value;
				this.RaisePropertyChanged("Certification_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Certification_Name
		{
			get
			{
				return this.certification_NameField;
			}
			set
			{
				this.certification_NameField = value;
				this.RaisePropertyChanged("Certification_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Certification_Issuer
		{
			get
			{
				return this.certification_IssuerField;
			}
			set
			{
				this.certification_IssuerField = value;
				this.RaisePropertyChanged("Certification_Issuer");
			}
		}

		[XmlElement(Order = 4)]
		public bool Required
		{
			get
			{
				return this.requiredField;
			}
			set
			{
				this.requiredField = value;
				this.RaisePropertyChanged("Required");
			}
		}

		[XmlIgnore]
		public bool RequiredSpecified
		{
			get
			{
				return this.requiredFieldSpecified;
			}
			set
			{
				this.requiredFieldSpecified = value;
				this.RaisePropertyChanged("RequiredSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Skill_Qualification_EnabledObjectType Qualification_Source_Reference
		{
			get
			{
				return this.qualification_Source_ReferenceField;
			}
			set
			{
				this.qualification_Source_ReferenceField = value;
				this.RaisePropertyChanged("Qualification_Source_Reference");
			}
		}

		[XmlElement("Specialty_Achievement_Data", Order = 6)]
		public Specialty_Achievement_DataType[] Specialty_Achievement_Data
		{
			get
			{
				return this.specialty_Achievement_DataField;
			}
			set
			{
				this.specialty_Achievement_DataField = value;
				this.RaisePropertyChanged("Specialty_Achievement_Data");
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
