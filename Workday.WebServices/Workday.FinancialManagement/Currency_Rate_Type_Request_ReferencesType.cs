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
	public class Currency_Rate_Type_Request_ReferencesType : INotifyPropertyChanged
	{
		private Currency_Rate_TypeObjectType[] currency_Rate_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Currency_Rate_Type_Reference", Order = 0)]
		public Currency_Rate_TypeObjectType[] Currency_Rate_Type_Reference
		{
			get
			{
				return this.currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Reference");
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
