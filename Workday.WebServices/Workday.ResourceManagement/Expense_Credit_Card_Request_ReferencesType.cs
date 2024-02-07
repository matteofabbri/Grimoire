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
	public class Expense_Credit_Card_Request_ReferencesType : INotifyPropertyChanged
	{
		private Worker_Credit_CardObjectType[] expense_Credit_Card_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Expense_Credit_Card_Reference", Order = 0)]
		public Worker_Credit_CardObjectType[] Expense_Credit_Card_Reference
		{
			get
			{
				return this.expense_Credit_Card_ReferenceField;
			}
			set
			{
				this.expense_Credit_Card_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Reference");
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
