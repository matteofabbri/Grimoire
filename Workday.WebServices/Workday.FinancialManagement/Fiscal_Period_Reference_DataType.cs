using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Fiscal_Period_Reference_DataType : INotifyPropertyChanged
	{
		private Fiscal_YearObjectType fiscal_Year_ReferenceField;

		private Fiscal_Posting_IntervalObjectType fiscal_Posting_Interval_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Fiscal_YearObjectType Fiscal_Year_Reference
		{
			get
			{
				return this.fiscal_Year_ReferenceField;
			}
			set
			{
				this.fiscal_Year_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Year_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Fiscal_Posting_IntervalObjectType Fiscal_Posting_Interval_Reference
		{
			get
			{
				return this.fiscal_Posting_Interval_ReferenceField;
			}
			set
			{
				this.fiscal_Posting_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Posting_Interval_Reference");
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
