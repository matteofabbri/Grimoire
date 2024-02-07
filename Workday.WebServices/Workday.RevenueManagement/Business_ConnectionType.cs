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
	public class Business_ConnectionType : INotifyPropertyChanged
	{
		private Customer_Business_ConnectionObjectType business_Connection_ReferenceField;

		private Business_Connection_DataType[] business_Connection_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Business_ConnectionObjectType Business_Connection_Reference
		{
			get
			{
				return this.business_Connection_ReferenceField;
			}
			set
			{
				this.business_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Business_Connection_Reference");
			}
		}

		[XmlElement("Business_Connection_Data", Order = 1)]
		public Business_Connection_DataType[] Business_Connection_Data
		{
			get
			{
				return this.business_Connection_DataField;
			}
			set
			{
				this.business_Connection_DataField = value;
				this.RaisePropertyChanged("Business_Connection_Data");
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
