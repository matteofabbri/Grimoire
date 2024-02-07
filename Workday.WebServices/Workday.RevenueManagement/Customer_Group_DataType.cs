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
	public class Customer_Group_DataType : INotifyPropertyChanged
	{
		private string customer_Group_IDField;

		private string customer_Group_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Group_ID
		{
			get
			{
				return this.customer_Group_IDField;
			}
			set
			{
				this.customer_Group_IDField = value;
				this.RaisePropertyChanged("Customer_Group_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Group_Name
		{
			get
			{
				return this.customer_Group_NameField;
			}
			set
			{
				this.customer_Group_NameField = value;
				this.RaisePropertyChanged("Customer_Group_Name");
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
