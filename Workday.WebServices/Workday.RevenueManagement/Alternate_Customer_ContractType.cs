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
	public class Alternate_Customer_ContractType : INotifyPropertyChanged
	{
		private Customer_Contract_AlternateObjectType alternate_Customer_Contract_ReferenceField;

		private Customer_Contract_DataType alternate_Customer_Contract_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Contract_AlternateObjectType Alternate_Customer_Contract_Reference
		{
			get
			{
				return this.alternate_Customer_Contract_ReferenceField;
			}
			set
			{
				this.alternate_Customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Customer_Contract_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Contract_DataType Alternate_Customer_Contract_Data
		{
			get
			{
				return this.alternate_Customer_Contract_DataField;
			}
			set
			{
				this.alternate_Customer_Contract_DataField = value;
				this.RaisePropertyChanged("Alternate_Customer_Contract_Data");
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
