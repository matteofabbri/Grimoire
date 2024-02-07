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
	public class CustomerType : INotifyPropertyChanged
	{
		private CustomerObjectType customer_ReferenceField;

		private Customer_WWS_DataType customer_DataField;

		private Customer_Balance_DataType customer_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_WWS_DataType Customer_Data
		{
			get
			{
				return this.customer_DataField;
			}
			set
			{
				this.customer_DataField = value;
				this.RaisePropertyChanged("Customer_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Customer_Balance_DataType Customer_Balance_Data
		{
			get
			{
				return this.customer_Balance_DataField;
			}
			set
			{
				this.customer_Balance_DataField = value;
				this.RaisePropertyChanged("Customer_Balance_Data");
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
