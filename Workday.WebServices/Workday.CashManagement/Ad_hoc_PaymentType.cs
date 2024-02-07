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
	public class Ad_hoc_PaymentType : INotifyPropertyChanged
	{
		private Ad_Hoc_PaymentObjectType ad_hoc_Payment_ReferenceField;

		private Ad_hoc_Payment_DataType[] ad_hoc_Payment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Ad_Hoc_PaymentObjectType Ad_hoc_Payment_Reference
		{
			get
			{
				return this.ad_hoc_Payment_ReferenceField;
			}
			set
			{
				this.ad_hoc_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Ad_hoc_Payment_Reference");
			}
		}

		[XmlElement("Ad_hoc_Payment_Data", Order = 1)]
		public Ad_hoc_Payment_DataType[] Ad_hoc_Payment_Data
		{
			get
			{
				return this.ad_hoc_Payment_DataField;
			}
			set
			{
				this.ad_hoc_Payment_DataField = value;
				this.RaisePropertyChanged("Ad_hoc_Payment_Data");
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
