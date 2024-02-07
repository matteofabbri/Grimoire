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
	public class Create_Subordinate_Event_DataType : INotifyPropertyChanged
	{
		private DateTime availability_DateField;

		private bool availability_DateFieldSpecified;

		private string organization_NameField;

		private bool include_Organization_ID_in_NameField;

		private bool include_Organization_ID_in_NameFieldSpecified;

		private string organization_CodeField;

		private bool include_Organization_Code_in_NameField;

		private bool include_Organization_Code_in_NameFieldSpecified;

		private bool include_Manager_Leader_in_NameField;

		private bool include_Manager_Leader_in_NameFieldSpecified;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private External_URLObjectType external_URL_ReferenceField;

		private LocationObjectType primary_Location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Availability_Date
		{
			get
			{
				return this.availability_DateField;
			}
			set
			{
				this.availability_DateField = value;
				this.RaisePropertyChanged("Availability_Date");
			}
		}

		[XmlIgnore]
		public bool Availability_DateSpecified
		{
			get
			{
				return this.availability_DateFieldSpecified;
			}
			set
			{
				this.availability_DateFieldSpecified = value;
				this.RaisePropertyChanged("Availability_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Organization_ID_in_Name
		{
			get
			{
				return this.include_Organization_ID_in_NameField;
			}
			set
			{
				this.include_Organization_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Organization_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Organization_ID_in_NameSpecified
		{
			get
			{
				return this.include_Organization_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Organization_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Organization_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Organization_Code
		{
			get
			{
				return this.organization_CodeField;
			}
			set
			{
				this.organization_CodeField = value;
				this.RaisePropertyChanged("Organization_Code");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Organization_Code_in_Name
		{
			get
			{
				return this.include_Organization_Code_in_NameField;
			}
			set
			{
				this.include_Organization_Code_in_NameField = value;
				this.RaisePropertyChanged("Include_Organization_Code_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Organization_Code_in_NameSpecified
		{
			get
			{
				return this.include_Organization_Code_in_NameFieldSpecified;
			}
			set
			{
				this.include_Organization_Code_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Organization_Code_in_NameSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Manager_Leader_in_Name
		{
			get
			{
				return this.include_Manager_Leader_in_NameField;
			}
			set
			{
				this.include_Manager_Leader_in_NameField = value;
				this.RaisePropertyChanged("Include_Manager_Leader_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Manager_Leader_in_NameSpecified
		{
			get
			{
				return this.include_Manager_Leader_in_NameFieldSpecified;
			}
			set
			{
				this.include_Manager_Leader_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Manager_Leader_in_NameSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Organization_SubtypeObjectType Organization_Subtype_Reference
		{
			get
			{
				return this.organization_Subtype_ReferenceField;
			}
			set
			{
				this.organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Subtype_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public External_URLObjectType External_URL_Reference
		{
			get
			{
				return this.external_URL_ReferenceField;
			}
			set
			{
				this.external_URL_ReferenceField = value;
				this.RaisePropertyChanged("External_URL_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public LocationObjectType Primary_Location_Reference
		{
			get
			{
				return this.primary_Location_ReferenceField;
			}
			set
			{
				this.primary_Location_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Location_Reference");
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
