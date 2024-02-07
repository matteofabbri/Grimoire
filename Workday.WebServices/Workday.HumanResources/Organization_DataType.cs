using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organization_DataType : INotifyPropertyChanged
	{
		private string organization_Reference_IDField;

		private bool include_Organization_ID_in_NameField;

		private bool include_Organization_ID_in_NameFieldSpecified;

		private IDType[] integration_ID_DataField;

		private string organization_NameField;

		private DateTime availability_DateField;

		private bool availability_DateFieldSpecified;

		private bool include_Organization_Code_In_NameField;

		private bool include_Organization_Code_In_NameFieldSpecified;

		private string organization_CodeField;

		private bool include_Leader_In_NameField;

		private bool include_Leader_In_NameFieldSpecified;

		private bool frozen_StatusField;

		private bool frozen_StatusFieldSpecified;

		private bool job_Management_EnabledField;

		private bool job_Management_EnabledFieldSpecified;

		private bool position_Management_EnabledField;

		private bool position_Management_EnabledFieldSpecified;

		private Superior_Organization_Reference_DataType superior_Organization_ReferenceField;

		private Organization_Type_Reference_DataType organization_Type_ReferenceField;

		private Organization_Subtype_Reference_DataType organization_Subtype_ReferenceField;

		private Organization_Visibility_Reference_DataType organization_Visibility_ReferenceField;

		private Primary_Business_Site_Reference_DataType primary_Business_Site_ReferenceField;

		private Container_Organization_Reference_DataType[] container_Organization_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Organization_Reference_ID
		{
			get
			{
				return this.organization_Reference_IDField;
			}
			set
			{
				this.organization_Reference_IDField = value;
				this.RaisePropertyChanged("Organization_Reference_ID");
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

		[XmlArray(Order = 2), XmlArrayItem("ID", IsNullable = false)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(Order = 5)]
		public bool Include_Organization_Code_In_Name
		{
			get
			{
				return this.include_Organization_Code_In_NameField;
			}
			set
			{
				this.include_Organization_Code_In_NameField = value;
				this.RaisePropertyChanged("Include_Organization_Code_In_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Organization_Code_In_NameSpecified
		{
			get
			{
				return this.include_Organization_Code_In_NameFieldSpecified;
			}
			set
			{
				this.include_Organization_Code_In_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Organization_Code_In_NameSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public bool Include_Leader_In_Name
		{
			get
			{
				return this.include_Leader_In_NameField;
			}
			set
			{
				this.include_Leader_In_NameField = value;
				this.RaisePropertyChanged("Include_Leader_In_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Leader_In_NameSpecified
		{
			get
			{
				return this.include_Leader_In_NameFieldSpecified;
			}
			set
			{
				this.include_Leader_In_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Leader_In_NameSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Frozen_Status
		{
			get
			{
				return this.frozen_StatusField;
			}
			set
			{
				this.frozen_StatusField = value;
				this.RaisePropertyChanged("Frozen_Status");
			}
		}

		[XmlIgnore]
		public bool Frozen_StatusSpecified
		{
			get
			{
				return this.frozen_StatusFieldSpecified;
			}
			set
			{
				this.frozen_StatusFieldSpecified = value;
				this.RaisePropertyChanged("Frozen_StatusSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Job_Management_Enabled
		{
			get
			{
				return this.job_Management_EnabledField;
			}
			set
			{
				this.job_Management_EnabledField = value;
				this.RaisePropertyChanged("Job_Management_Enabled");
			}
		}

		[XmlIgnore]
		public bool Job_Management_EnabledSpecified
		{
			get
			{
				return this.job_Management_EnabledFieldSpecified;
			}
			set
			{
				this.job_Management_EnabledFieldSpecified = value;
				this.RaisePropertyChanged("Job_Management_EnabledSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Position_Management_Enabled
		{
			get
			{
				return this.position_Management_EnabledField;
			}
			set
			{
				this.position_Management_EnabledField = value;
				this.RaisePropertyChanged("Position_Management_Enabled");
			}
		}

		[XmlIgnore]
		public bool Position_Management_EnabledSpecified
		{
			get
			{
				return this.position_Management_EnabledFieldSpecified;
			}
			set
			{
				this.position_Management_EnabledFieldSpecified = value;
				this.RaisePropertyChanged("Position_Management_EnabledSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Superior_Organization_Reference_DataType Superior_Organization_Reference
		{
			get
			{
				return this.superior_Organization_ReferenceField;
			}
			set
			{
				this.superior_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Organization_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Organization_Type_Reference_DataType Organization_Type_Reference
		{
			get
			{
				return this.organization_Type_ReferenceField;
			}
			set
			{
				this.organization_Type_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Type_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Organization_Subtype_Reference_DataType Organization_Subtype_Reference
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

		[XmlElement(Order = 14)]
		public Organization_Visibility_Reference_DataType Organization_Visibility_Reference
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

		[XmlElement(Order = 15)]
		public Primary_Business_Site_Reference_DataType Primary_Business_Site_Reference
		{
			get
			{
				return this.primary_Business_Site_ReferenceField;
			}
			set
			{
				this.primary_Business_Site_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Business_Site_Reference");
			}
		}

		[XmlElement("Container_Organization_Reference", Order = 16)]
		public Container_Organization_Reference_DataType[] Container_Organization_Reference
		{
			get
			{
				return this.container_Organization_ReferenceField;
			}
			set
			{
				this.container_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Container_Organization_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
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
