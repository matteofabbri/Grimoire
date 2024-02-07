using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Statement_Request_ReferencesType : INotifyPropertyChanged
	{
		private Investment_StatementObjectType[] investment_Statement_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Investment_Statement_Reference", Order = 0)]
		public Investment_StatementObjectType[] Investment_Statement_Reference
		{
			get
			{
				return this.investment_Statement_ReferenceField;
			}
			set
			{
				this.investment_Statement_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Statement_Reference");
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
