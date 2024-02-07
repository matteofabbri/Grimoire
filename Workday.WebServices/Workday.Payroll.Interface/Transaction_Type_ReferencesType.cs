using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Transaction_Type_ReferencesType : INotifyPropertyChanged
	{
		private Transaction_Log_TypeObjectType[] transaction_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transaction_Type_Reference", Order = 0)]
		public Transaction_Log_TypeObjectType[] Transaction_Type_Reference
		{
			get
			{
				return this.transaction_Type_ReferenceField;
			}
			set
			{
				this.transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Type_Reference");
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
