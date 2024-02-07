using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Details_Personal_Information_Subedit_DataType : INotifyPropertyChanged
	{
		private Marital_StatusObjectType[] marital_Status_ReferenceField;

		private CountryObjectType country_of_Birth_ReferenceField;

		private Country_RegionObjectType region_of_Birth_ReferenceField;

		private string city_of_BirthField;

		private Generic_Military_Information_DataType[] generic_Military_Service_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Marital_Status_Reference", Order = 0)]
		public Marital_StatusObjectType[] Marital_Status_Reference
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Generic_Military_Service_Data", Order = 4)]
		public Generic_Military_Information_DataType[] Generic_Military_Service_Data
		{
			get
			{
				return this.generic_Military_Service_DataField;
			}
			set
			{
				this.generic_Military_Service_DataField = value;
				this.RaisePropertyChanged("Generic_Military_Service_Data");
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
