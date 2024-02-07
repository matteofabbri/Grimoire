using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cash_Sale_Request_ReferenceType : INotifyPropertyChanged
	{
		private Cash_SaleObjectType[] cash_Sale_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Cash_Sale_Reference", Order = 0)]
		public Cash_SaleObjectType[] Cash_Sale_Reference
		{
			get
			{
				return this.cash_Sale_ReferenceField;
			}
			set
			{
				this.cash_Sale_ReferenceField = value;
				this.RaisePropertyChanged("Cash_Sale_Reference");
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
