using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Paycheck_DeliveryType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType paycheck_Delivery_ReferenceField;

		private Paycheck_Delivery_DataType[] paycheck_Delivery_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Paycheck_Delivery_Reference
		{
			get
			{
				return this.paycheck_Delivery_ReferenceField;
			}
			set
			{
				this.paycheck_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Paycheck_Delivery_Reference");
			}
		}

		[XmlElement("Paycheck_Delivery_Data", Order = 1)]
		public Paycheck_Delivery_DataType[] Paycheck_Delivery_Data
		{
			get
			{
				return this.paycheck_Delivery_DataField;
			}
			set
			{
				this.paycheck_Delivery_DataField = value;
				this.RaisePropertyChanged("Paycheck_Delivery_Data");
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
