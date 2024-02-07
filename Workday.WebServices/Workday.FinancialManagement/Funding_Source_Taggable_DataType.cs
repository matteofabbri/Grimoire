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
	public class Funding_Source_Taggable_DataType : INotifyPropertyChanged
	{
		private Accounting_Worktag_TypeObjectType accounting_Worktag_Type_ReferenceField;

		private Accounting_WorktagObjectType worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_Worktag_TypeObjectType Accounting_Worktag_Type_Reference
		{
			get
			{
				return this.accounting_Worktag_Type_ReferenceField;
			}
			set
			{
				this.accounting_Worktag_Type_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Worktag_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Accounting_WorktagObjectType Worktag_Reference
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
