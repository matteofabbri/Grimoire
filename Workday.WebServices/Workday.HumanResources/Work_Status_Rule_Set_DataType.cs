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
	public class Work_Status_Rule_Set_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string work_Status_Rule_Set_NameField;

		private string work_Status_Rule_Set_DescriptionField;

		private Academic_UnitObjectType[] restricted_to_Academic_Unit_ReferenceField;

		private bool default_Work_Status_Rule_SetField;

		private bool default_Work_Status_Rule_SetFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Leave_of_Absence_TypeObjectType[] applies_to_Leave_Types_ReferenceField;

		private decimal active_Periods_Required_for_EligibilityField;

		private bool active_Periods_Required_for_EligibilityFieldSpecified;

		private decimal minimum_Years_Since_Last_Applicable_LeaveField;

		private bool minimum_Years_Since_Last_Applicable_LeaveFieldSpecified;

		private Work_Status_Rule_Row_SubdataType[] work_Status_Rule_Row_SubdataField;

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
		public string Work_Status_Rule_Set_Name
		{
			get
			{
				return this.work_Status_Rule_Set_NameField;
			}
			set
			{
				this.work_Status_Rule_Set_NameField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Set_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Work_Status_Rule_Set_Description
		{
			get
			{
				return this.work_Status_Rule_Set_DescriptionField;
			}
			set
			{
				this.work_Status_Rule_Set_DescriptionField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Set_Description");
			}
		}

		[XmlElement("Restricted_to_Academic_Unit_Reference", Order = 3)]
		public Academic_UnitObjectType[] Restricted_to_Academic_Unit_Reference
		{
			get
			{
				return this.restricted_to_Academic_Unit_ReferenceField;
			}
			set
			{
				this.restricted_to_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_to_Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Default_Work_Status_Rule_Set
		{
			get
			{
				return this.default_Work_Status_Rule_SetField;
			}
			set
			{
				this.default_Work_Status_Rule_SetField = value;
				this.RaisePropertyChanged("Default_Work_Status_Rule_Set");
			}
		}

		[XmlIgnore]
		public bool Default_Work_Status_Rule_SetSpecified
		{
			get
			{
				return this.default_Work_Status_Rule_SetFieldSpecified;
			}
			set
			{
				this.default_Work_Status_Rule_SetFieldSpecified = value;
				this.RaisePropertyChanged("Default_Work_Status_Rule_SetSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("Applies_to_Leave_Types_Reference", Order = 6)]
		public Leave_of_Absence_TypeObjectType[] Applies_to_Leave_Types_Reference
		{
			get
			{
				return this.applies_to_Leave_Types_ReferenceField;
			}
			set
			{
				this.applies_to_Leave_Types_ReferenceField = value;
				this.RaisePropertyChanged("Applies_to_Leave_Types_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Active_Periods_Required_for_Eligibility
		{
			get
			{
				return this.active_Periods_Required_for_EligibilityField;
			}
			set
			{
				this.active_Periods_Required_for_EligibilityField = value;
				this.RaisePropertyChanged("Active_Periods_Required_for_Eligibility");
			}
		}

		[XmlIgnore]
		public bool Active_Periods_Required_for_EligibilitySpecified
		{
			get
			{
				return this.active_Periods_Required_for_EligibilityFieldSpecified;
			}
			set
			{
				this.active_Periods_Required_for_EligibilityFieldSpecified = value;
				this.RaisePropertyChanged("Active_Periods_Required_for_EligibilitySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Minimum_Years_Since_Last_Applicable_Leave
		{
			get
			{
				return this.minimum_Years_Since_Last_Applicable_LeaveField;
			}
			set
			{
				this.minimum_Years_Since_Last_Applicable_LeaveField = value;
				this.RaisePropertyChanged("Minimum_Years_Since_Last_Applicable_Leave");
			}
		}

		[XmlIgnore]
		public bool Minimum_Years_Since_Last_Applicable_LeaveSpecified
		{
			get
			{
				return this.minimum_Years_Since_Last_Applicable_LeaveFieldSpecified;
			}
			set
			{
				this.minimum_Years_Since_Last_Applicable_LeaveFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_Years_Since_Last_Applicable_LeaveSpecified");
			}
		}

		[XmlElement("Work_Status_Rule_Row_Subdata", Order = 9)]
		public Work_Status_Rule_Row_SubdataType[] Work_Status_Rule_Row_Subdata
		{
			get
			{
				return this.work_Status_Rule_Row_SubdataField;
			}
			set
			{
				this.work_Status_Rule_Row_SubdataField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Row_Subdata");
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
