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
	public class Facilities_and_Administration_Waived_Expense_Allocation_ProfileType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Waived_Expense_Allocation_ProfileObjectType facilities_and_Admin_Waived_Expense_Allocation_Profile_ReferenceField;

		private Facilities_and_Admin_Waived_Expense_Allocation_Profile_DataType[] facilities_and_Administration_Waived_Expense_Allocation_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_Waived_Expense_Allocation_ProfileObjectType Facilities_and_Admin_Waived_Expense_Allocation_Profile_Reference
		{
			get
			{
				return this.facilities_and_Admin_Waived_Expense_Allocation_Profile_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Waived_Expense_Allocation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Waived_Expense_Allocation_Profile_Reference");
			}
		}

		[XmlElement("Facilities_and_Administration_Waived_Expense_Allocation_Profile_Data", Order = 1)]
		public Facilities_and_Admin_Waived_Expense_Allocation_Profile_DataType[] Facilities_and_Administration_Waived_Expense_Allocation_Profile_Data
		{
			get
			{
				return this.facilities_and_Administration_Waived_Expense_Allocation_Profile_DataField;
			}
			set
			{
				this.facilities_and_Administration_Waived_Expense_Allocation_Profile_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Waived_Expense_Allocation_Profile_Data");
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
