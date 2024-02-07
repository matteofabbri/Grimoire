using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_Region_Geographic_Criteria_DataType : INotifyPropertyChanged
	{
		private Geographic_CriteriaObjectType geographic_Criteria_ReferenceField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType country_Region_ReferenceField;

		private string cityField;

		private Postal_Code_SetObjectType postal_Code_Set_ReferenceField;

		private string postal_CodeField;

		private Educational_Institution_DistrictObjectType educational_Institution_District_ReferenceField;

		private Educational_InstitutionObjectType[] educational_Institution_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Geographic_CriteriaObjectType Geographic_Criteria_Reference
		{
			get
			{
				return this.geographic_Criteria_ReferenceField;
			}
			set
			{
				this.geographic_Criteria_ReferenceField = value;
				this.RaisePropertyChanged("Geographic_Criteria_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Country_RegionObjectType Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string City
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
				this.RaisePropertyChanged("City");
			}
		}

		[XmlElement(Order = 4)]
		public Postal_Code_SetObjectType Postal_Code_Set_Reference
		{
			get
			{
				return this.postal_Code_Set_ReferenceField;
			}
			set
			{
				this.postal_Code_Set_ReferenceField = value;
				this.RaisePropertyChanged("Postal_Code_Set_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Postal_Code
		{
			get
			{
				return this.postal_CodeField;
			}
			set
			{
				this.postal_CodeField = value;
				this.RaisePropertyChanged("Postal_Code");
			}
		}

		[XmlElement(Order = 6)]
		public Educational_Institution_DistrictObjectType Educational_Institution_District_Reference
		{
			get
			{
				return this.educational_Institution_District_ReferenceField;
			}
			set
			{
				this.educational_Institution_District_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_District_Reference");
			}
		}

		[XmlElement("Educational_Institution_Reference", Order = 7)]
		public Educational_InstitutionObjectType[] Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
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
