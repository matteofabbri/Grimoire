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
	public class Investment_Pool_Sale_Request_ReferencesType : INotifyPropertyChanged
	{
		private Investment_Pool_SaleObjectType[] investment_Pool_Sale_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Investment_Pool_Sale_Reference", Order = 0)]
		public Investment_Pool_SaleObjectType[] Investment_Pool_Sale_Reference
		{
			get
			{
				return this.investment_Pool_Sale_ReferenceField;
			}
			set
			{
				this.investment_Pool_Sale_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Sale_Reference");
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
