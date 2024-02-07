using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Prepaid_Spend_AmortizationType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType prepaid_Spend_Amortization_ReferenceField;

		private Prepaid_Spend_Amortization_DataType[] prepaid_Spend_Amortization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Prepaid_Spend_Amortization_Reference
		{
			get
			{
				return this.prepaid_Spend_Amortization_ReferenceField;
			}
			set
			{
				this.prepaid_Spend_Amortization_ReferenceField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Reference");
			}
		}

		[XmlElement("Prepaid_Spend_Amortization_Data", Order = 1)]
		public Prepaid_Spend_Amortization_DataType[] Prepaid_Spend_Amortization_Data
		{
			get
			{
				return this.prepaid_Spend_Amortization_DataField;
			}
			set
			{
				this.prepaid_Spend_Amortization_DataField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Data");
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
