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
	public class Income_Distribution_Percent_Rule_DataType : INotifyPropertyChanged
	{
		private decimal percentField;

		private bool percentFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
			}
		}

		[XmlElement("Worktag_Reference", Order = 1)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
