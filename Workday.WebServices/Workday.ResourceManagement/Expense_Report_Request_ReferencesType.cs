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
	public class Expense_Report_Request_ReferencesType : INotifyPropertyChanged
	{
		private Expense_ReportObjectType[] expense_Report_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Expense_Report_Reference", Order = 0)]
		public Expense_ReportObjectType[] Expense_Report_Reference
		{
			get
			{
				return this.expense_Report_ReferenceField;
			}
			set
			{
				this.expense_Report_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Report_Reference");
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
