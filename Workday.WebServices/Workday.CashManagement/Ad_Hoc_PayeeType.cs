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
	public class Ad_Hoc_PayeeType : INotifyPropertyChanged
	{
		private Ad_Hoc_PayeeObjectType ad_Hoc_Payee_ReferenceField;

		private Ad_Hoc_Payee_DataType[] ad_Hoc_Payee_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Ad_Hoc_PayeeObjectType Ad_Hoc_Payee_Reference
		{
			get
			{
				return this.ad_Hoc_Payee_ReferenceField;
			}
			set
			{
				this.ad_Hoc_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Ad_Hoc_Payee_Reference");
			}
		}

		[XmlElement("Ad_Hoc_Payee_Data", Order = 1)]
		public Ad_Hoc_Payee_DataType[] Ad_Hoc_Payee_Data
		{
			get
			{
				return this.ad_Hoc_Payee_DataField;
			}
			set
			{
				this.ad_Hoc_Payee_DataField = value;
				this.RaisePropertyChanged("Ad_Hoc_Payee_Data");
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
