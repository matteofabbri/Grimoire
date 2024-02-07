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
	public class Usage_Billing_Rate_DataType : INotifyPropertyChanged
	{
		private string usage_Billing_Rate_IDField;

		private string usage_Billing_Rate_NameField;

		private string usage_Billing_Rate_DescriptionField;

		private Customer_Contract_LineObjectType[] customer_Contract_Line_ReferenceField;

		private Usage_Billing_Rate_Rule_Type_Group_DataType[] usage_Billing_Rate_Rule_Type_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Usage_Billing_Rate_ID
		{
			get
			{
				return this.usage_Billing_Rate_IDField;
			}
			set
			{
				this.usage_Billing_Rate_IDField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Usage_Billing_Rate_Name
		{
			get
			{
				return this.usage_Billing_Rate_NameField;
			}
			set
			{
				this.usage_Billing_Rate_NameField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Usage_Billing_Rate_Description
		{
			get
			{
				return this.usage_Billing_Rate_DescriptionField;
			}
			set
			{
				this.usage_Billing_Rate_DescriptionField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Description");
			}
		}

		[XmlElement("Customer_Contract_Line_Reference", Order = 3)]
		public Customer_Contract_LineObjectType[] Customer_Contract_Line_Reference
		{
			get
			{
				return this.customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Reference");
			}
		}

		[XmlElement("Usage_Billing_Rate_Rule_Type_Group_Data", Order = 4)]
		public Usage_Billing_Rate_Rule_Type_Group_DataType[] Usage_Billing_Rate_Rule_Type_Group_Data
		{
			get
			{
				return this.usage_Billing_Rate_Rule_Type_Group_DataField;
			}
			set
			{
				this.usage_Billing_Rate_Rule_Type_Group_DataField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Rule_Type_Group_Data");
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
