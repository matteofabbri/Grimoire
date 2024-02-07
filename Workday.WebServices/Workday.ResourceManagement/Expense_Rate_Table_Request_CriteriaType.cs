using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Rate_Table_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime expense_Rate_Table_Effective_DateField;

		private bool expense_Rate_Table_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Expense_Rate_Table_Effective_Date
		{
			get
			{
				return this.expense_Rate_Table_Effective_DateField;
			}
			set
			{
				this.expense_Rate_Table_Effective_DateField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Expense_Rate_Table_Effective_DateSpecified
		{
			get
			{
				return this.expense_Rate_Table_Effective_DateFieldSpecified;
			}
			set
			{
				this.expense_Rate_Table_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Effective_DateSpecified");
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
