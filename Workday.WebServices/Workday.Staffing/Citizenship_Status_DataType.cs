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
	public class Citizenship_Status_DataType : INotifyPropertyChanged
	{
		private string citizenship_Status_IDField;

		private string citizenship_Status_NameField;

		private string citizenship_Status_DescriptionField;

		private CountryObjectType country_ReferenceField;

		private Global_Setup_Data_MappingObjectType citizenship_Status_Mapping_ReferenceField;

		private bool citizenField;

		private bool citizenFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Citizenship_Status_ID
		{
			get
			{
				return this.citizenship_Status_IDField;
			}
			set
			{
				this.citizenship_Status_IDField = value;
				this.RaisePropertyChanged("Citizenship_Status_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Citizenship_Status_Name
		{
			get
			{
				return this.citizenship_Status_NameField;
			}
			set
			{
				this.citizenship_Status_NameField = value;
				this.RaisePropertyChanged("Citizenship_Status_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Citizenship_Status_Description
		{
			get
			{
				return this.citizenship_Status_DescriptionField;
			}
			set
			{
				this.citizenship_Status_DescriptionField = value;
				this.RaisePropertyChanged("Citizenship_Status_Description");
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

		[XmlElement(Order = 4)]
		public Global_Setup_Data_MappingObjectType Citizenship_Status_Mapping_Reference
		{
			get
			{
				return this.citizenship_Status_Mapping_ReferenceField;
			}
			set
			{
				this.citizenship_Status_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Status_Mapping_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Citizen
		{
			get
			{
				return this.citizenField;
			}
			set
			{
				this.citizenField = value;
				this.RaisePropertyChanged("Citizen");
			}
		}

		[XmlIgnore]
		public bool CitizenSpecified
		{
			get
			{
				return this.citizenFieldSpecified;
			}
			set
			{
				this.citizenFieldSpecified = value;
				this.RaisePropertyChanged("CitizenSpecified");
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
