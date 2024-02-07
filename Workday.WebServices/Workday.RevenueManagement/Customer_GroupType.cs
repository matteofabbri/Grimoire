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
	public class Customer_GroupType : INotifyPropertyChanged
	{
		private Customer_GroupObjectType customer_Group_ReferenceField;

		private Customer_Group_DataType customer_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_GroupObjectType Customer_Group_Reference
		{
			get
			{
				return this.customer_Group_ReferenceField;
			}
			set
			{
				this.customer_Group_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Group_DataType Customer_Group_Data
		{
			get
			{
				return this.customer_Group_DataField;
			}
			set
			{
				this.customer_Group_DataField = value;
				this.RaisePropertyChanged("Customer_Group_Data");
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
