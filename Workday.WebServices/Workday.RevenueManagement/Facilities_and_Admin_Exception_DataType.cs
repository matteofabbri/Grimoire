using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Facilities_and_Admin_Exception_DataType : INotifyPropertyChanged
	{
		private string facilities_and_Administration_Exception_IDField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string exception_NameField;

		private Facilities_and_Admin_Basis_TypeObjectType basis_Type_ReferenceField;

		private Facilities_and_Admin_Exception_TypeObjectType facilities_and_Admin_Exception_Type_ReferenceField;

		private decimal primary_Rate_OverrideField;

		private bool primary_Rate_OverrideFieldSpecified;

		private decimal primary_Waive_RateField;

		private bool primary_Waive_RateFieldSpecified;

		private Facilities_and_Admin_Waived_Expense_Allocation_ProfileObjectType facilities_and_Administration_Waived_Expense_Allocation_Profile_ReferenceField;

		private Facilities_and_Admin_Exception_Detail_DataType[] exception_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Facilities_and_Administration_Exception_ID
		{
			get
			{
				return this.facilities_and_Administration_Exception_IDField;
			}
			set
			{
				this.facilities_and_Administration_Exception_IDField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Exception_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Exception_Name
		{
			get
			{
				return this.exception_NameField;
			}
			set
			{
				this.exception_NameField = value;
				this.RaisePropertyChanged("Exception_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Facilities_and_Admin_Basis_TypeObjectType Basis_Type_Reference
		{
			get
			{
				return this.basis_Type_ReferenceField;
			}
			set
			{
				this.basis_Type_ReferenceField = value;
				this.RaisePropertyChanged("Basis_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Facilities_and_Admin_Exception_TypeObjectType Facilities_and_Admin_Exception_Type_Reference
		{
			get
			{
				return this.facilities_and_Admin_Exception_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Exception_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Exception_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Primary_Rate_Override
		{
			get
			{
				return this.primary_Rate_OverrideField;
			}
			set
			{
				this.primary_Rate_OverrideField = value;
				this.RaisePropertyChanged("Primary_Rate_Override");
			}
		}

		[XmlIgnore]
		public bool Primary_Rate_OverrideSpecified
		{
			get
			{
				return this.primary_Rate_OverrideFieldSpecified;
			}
			set
			{
				this.primary_Rate_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Primary_Rate_OverrideSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Primary_Waive_Rate
		{
			get
			{
				return this.primary_Waive_RateField;
			}
			set
			{
				this.primary_Waive_RateField = value;
				this.RaisePropertyChanged("Primary_Waive_Rate");
			}
		}

		[XmlIgnore]
		public bool Primary_Waive_RateSpecified
		{
			get
			{
				return this.primary_Waive_RateFieldSpecified;
			}
			set
			{
				this.primary_Waive_RateFieldSpecified = value;
				this.RaisePropertyChanged("Primary_Waive_RateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Facilities_and_Admin_Waived_Expense_Allocation_ProfileObjectType Facilities_and_Administration_Waived_Expense_Allocation_Profile_Reference
		{
			get
			{
				return this.facilities_and_Administration_Waived_Expense_Allocation_Profile_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Waived_Expense_Allocation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Waived_Expense_Allocation_Profile_Reference");
			}
		}

		[XmlElement("Exception_Detail_Data", Order = 8)]
		public Facilities_and_Admin_Exception_Detail_DataType[] Exception_Detail_Data
		{
			get
			{
				return this.exception_Detail_DataField;
			}
			set
			{
				this.exception_Detail_DataField = value;
				this.RaisePropertyChanged("Exception_Detail_Data");
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
