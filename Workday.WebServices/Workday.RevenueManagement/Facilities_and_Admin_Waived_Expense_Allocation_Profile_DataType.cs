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
	public class Facilities_and_Admin_Waived_Expense_Allocation_Profile_DataType : INotifyPropertyChanged
	{
		private string facilities_and_Administration_Waived_Expense_Allocation_Profile_IDField;

		private string facilities_and_Administration_Waived_Expense_Allocation_Profile_NameField;

		private Facilities_and_Administration_Waived_Expense_Distribution_DataType[] facilities_and_Administration_Waived_Expense_Distribution_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Facilities_and_Administration_Waived_Expense_Allocation_Profile_ID
		{
			get
			{
				return this.facilities_and_Administration_Waived_Expense_Allocation_Profile_IDField;
			}
			set
			{
				this.facilities_and_Administration_Waived_Expense_Allocation_Profile_IDField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Waived_Expense_Allocation_Profile_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Facilities_and_Administration_Waived_Expense_Allocation_Profile_Name
		{
			get
			{
				return this.facilities_and_Administration_Waived_Expense_Allocation_Profile_NameField;
			}
			set
			{
				this.facilities_and_Administration_Waived_Expense_Allocation_Profile_NameField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Waived_Expense_Allocation_Profile_Name");
			}
		}

		[XmlElement("Facilities_and_Administration_Waived_Expense_Distribution_Data", Order = 2)]
		public Facilities_and_Administration_Waived_Expense_Distribution_DataType[] Facilities_and_Administration_Waived_Expense_Distribution_Data
		{
			get
			{
				return this.facilities_and_Administration_Waived_Expense_Distribution_DataField;
			}
			set
			{
				this.facilities_and_Administration_Waived_Expense_Distribution_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Waived_Expense_Distribution_Data");
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
