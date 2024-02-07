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
	public class Workers_Compensation_Code_DataType : INotifyPropertyChanged
	{
		private string workers_Compensation_IDField;

		private string workers_Compensation_CodeField;

		private string workers_Compensation_NameField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType[] country_Region_ReferenceField;

		private LocationObjectType[] location_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Workers_Compensation_ID
		{
			get
			{
				return this.workers_Compensation_IDField;
			}
			set
			{
				this.workers_Compensation_IDField = value;
				this.RaisePropertyChanged("Workers_Compensation_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Workers_Compensation_Code
		{
			get
			{
				return this.workers_Compensation_CodeField;
			}
			set
			{
				this.workers_Compensation_CodeField = value;
				this.RaisePropertyChanged("Workers_Compensation_Code");
			}
		}

		[XmlElement(Order = 2)]
		public string Workers_Compensation_Name
		{
			get
			{
				return this.workers_Compensation_NameField;
			}
			set
			{
				this.workers_Compensation_NameField = value;
				this.RaisePropertyChanged("Workers_Compensation_Name");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement("Country_Region_Reference", Order = 4)]
		public Country_RegionObjectType[] Country_Region_Reference
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

		[XmlElement("Location_Reference", Order = 5)]
		public LocationObjectType[] Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 6)]
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
