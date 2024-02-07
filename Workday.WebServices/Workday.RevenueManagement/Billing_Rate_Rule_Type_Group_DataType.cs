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
	public class Billing_Rate_Rule_Type_Group_DataType : INotifyPropertyChanged
	{
		private Billing_Rate_Rule_TypeObjectType billing_Rate_Rule_Type_ReferenceField;

		private Project_Transaction_SourceObjectType transaction_Source_ReferenceField;

		private Billing_Rate_Rule_DataType[] billing_Rate_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_Rate_Rule_TypeObjectType Billing_Rate_Rule_Type_Reference
		{
			get
			{
				return this.billing_Rate_Rule_Type_ReferenceField;
			}
			set
			{
				this.billing_Rate_Rule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Transaction_SourceObjectType Transaction_Source_Reference
		{
			get
			{
				return this.transaction_Source_ReferenceField;
			}
			set
			{
				this.transaction_Source_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Source_Reference");
			}
		}

		[XmlElement("Billing_Rate_Rule_Data", Order = 2)]
		public Billing_Rate_Rule_DataType[] Billing_Rate_Rule_Data
		{
			get
			{
				return this.billing_Rate_Rule_DataField;
			}
			set
			{
				this.billing_Rate_Rule_DataField = value;
				this.RaisePropertyChanged("Billing_Rate_Rule_Data");
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
