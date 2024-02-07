using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organization_Summary_DataType : INotifyPropertyChanged
	{
		private string organization_Reference_IDField;

		private string organization_CodeField;

		private IDType[] integration_ID_DataField;

		private string organization_NameField;

		private Organization_TypeObjectType organization_Type_ReferenceField;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private LocationObjectType primary_Business_Site_ReferenceField;

		private Organization_Supporting_Role_DataType[] organization_Support_Role_DataField;

		private DateTime date_of_Pay_Group_AssignmentField;

		private bool date_of_Pay_Group_AssignmentFieldSpecified;

		private bool used_in_Change_Organization_AssignmentsField;

		private bool used_in_Change_Organization_AssignmentsFieldSpecified;

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

		[XmlArray(Order = 2), XmlArrayItem("ID", typeof(IDType), IsNullable = false)]
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

		[XmlElement(Order = 4)]
		public Organization_TypeObjectType Organization_Type_Reference
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public LocationObjectType Primary_Business_Site_Reference
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

		[XmlArray(Order = 7), XmlArrayItem("Organization_Support_Role", IsNullable = false)]
		public Organization_Supporting_Role_DataType[] Organization_Support_Role_Data
		{
			get
			{
				return this.organization_Support_Role_DataField;
			}
			set
			{
				this.organization_Support_Role_DataField = value;
				this.RaisePropertyChanged("Organization_Support_Role_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Date_of_Pay_Group_Assignment
		{
			get
			{
				return this.date_of_Pay_Group_AssignmentField;
			}
			set
			{
				this.date_of_Pay_Group_AssignmentField = value;
				this.RaisePropertyChanged("Date_of_Pay_Group_Assignment");
			}
		}

		[XmlIgnore]
		public bool Date_of_Pay_Group_AssignmentSpecified
		{
			get
			{
				return this.date_of_Pay_Group_AssignmentFieldSpecified;
			}
			set
			{
				this.date_of_Pay_Group_AssignmentFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_Pay_Group_AssignmentSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Used_in_Change_Organization_Assignments
		{
			get
			{
				return this.used_in_Change_Organization_AssignmentsField;
			}
			set
			{
				this.used_in_Change_Organization_AssignmentsField = value;
				this.RaisePropertyChanged("Used_in_Change_Organization_Assignments");
			}
		}

		[XmlIgnore]
		public bool Used_in_Change_Organization_AssignmentsSpecified
		{
			get
			{
				return this.used_in_Change_Organization_AssignmentsFieldSpecified;
			}
			set
			{
				this.used_in_Change_Organization_AssignmentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_in_Change_Organization_AssignmentsSpecified");
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
