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
	public class Organization_Common_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool include_Organization_ID_in_NameField;

		private bool include_Organization_ID_in_NameFieldSpecified;

		private string organization_NameField;

		private string organization_CodeField;

		private bool include_Organization_Code_in_NameField;

		private bool include_Organization_Code_in_NameFieldSpecified;

		private bool organization_ActiveField;

		private bool organization_ActiveFieldSpecified;

		private DateTime availability_DateField;

		private Unique_IdentifierObjectType organization_Visibility_ReferenceField;

		private External_URLObjectType external_URL_ReferenceField;

		private IDType[] integration_ID_DataField;

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

		[XmlElement(Order = 2)]
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
		public bool Organization_Active
		{
			get
			{
				return this.organization_ActiveField;
			}
			set
			{
				this.organization_ActiveField = value;
				this.RaisePropertyChanged("Organization_Active");
			}
		}

		[XmlIgnore]
		public bool Organization_ActiveSpecified
		{
			get
			{
				return this.organization_ActiveFieldSpecified;
			}
			set
			{
				this.organization_ActiveFieldSpecified = value;
				this.RaisePropertyChanged("Organization_ActiveSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Organization_Visibility_Reference
		{
			get
			{
				return this.organization_Visibility_ReferenceField;
			}
			set
			{
				this.organization_Visibility_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Visibility_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlArray(Order = 9), XmlArrayItem("ID", typeof(IDType), IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
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
