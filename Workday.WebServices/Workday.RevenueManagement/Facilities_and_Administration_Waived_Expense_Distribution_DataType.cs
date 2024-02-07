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
	public class Facilities_and_Administration_Waived_Expense_Distribution_DataType : INotifyPropertyChanged
	{
		private decimal allocation_Distribution_PercentField;

		private Facilities_and_Administration_Waived_Expense_Worktag_Offset_Override_DataType[] facilities_and_Administration_Waived_Expnese_Worktag_Offest_Override_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Allocation_Distribution_Percent
		{
			get
			{
				return this.allocation_Distribution_PercentField;
			}
			set
			{
				this.allocation_Distribution_PercentField = value;
				this.RaisePropertyChanged("Allocation_Distribution_Percent");
			}
		}

		[XmlElement("Facilities_and_Administration_Waived_Expnese_Worktag_Offest_Override_Data", Order = 1)]
		public Facilities_and_Administration_Waived_Expense_Worktag_Offset_Override_DataType[] Facilities_and_Administration_Waived_Expnese_Worktag_Offest_Override_Data
		{
			get
			{
				return this.facilities_and_Administration_Waived_Expnese_Worktag_Offest_Override_DataField;
			}
			set
			{
				this.facilities_and_Administration_Waived_Expnese_Worktag_Offest_Override_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Waived_Expnese_Worktag_Offest_Override_Data");
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
