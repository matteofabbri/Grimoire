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
	public class Customer_Contract_Amendment_DataType : INotifyPropertyChanged
	{
		private string customer_Contract_Amendment_IDField;

		private Customer_ContractObjectType customer_Contract_ReferenceField;

		private bool customer_Contract_Change_without_AmendmentField;

		private bool customer_Contract_Change_without_AmendmentFieldSpecified;

		private Contract_Amendment_TypeObjectType active_Amendment_Type_ReferenceField;

		private DateTime amendment_Effective_DateField;

		private bool amendment_Effective_DateFieldSpecified;

		private string amendment_NumberField;

		private DateTime amendment_Signed_DateField;

		private bool amendment_Signed_DateFieldSpecified;

		private string amendment_DescriptionField;

		private Document_StatusObjectType new_Contract_Status_ReferenceField;

		private bool schedules_Exist_on_Customer_ContractField;

		private bool schedules_Exist_on_Customer_ContractFieldSpecified;

		private Customer_Contract_DataType[] customer_Contract_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Contract_Amendment_ID
		{
			get
			{
				return this.customer_Contract_Amendment_IDField;
			}
			set
			{
				this.customer_Contract_Amendment_IDField = value;
				this.RaisePropertyChanged("Customer_Contract_Amendment_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_ContractObjectType Customer_Contract_Reference
		{
			get
			{
				return this.customer_Contract_ReferenceField;
			}
			set
			{
				this.customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Customer_Contract_Change_without_Amendment
		{
			get
			{
				return this.customer_Contract_Change_without_AmendmentField;
			}
			set
			{
				this.customer_Contract_Change_without_AmendmentField = value;
				this.RaisePropertyChanged("Customer_Contract_Change_without_Amendment");
			}
		}

		[XmlIgnore]
		public bool Customer_Contract_Change_without_AmendmentSpecified
		{
			get
			{
				return this.customer_Contract_Change_without_AmendmentFieldSpecified;
			}
			set
			{
				this.customer_Contract_Change_without_AmendmentFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Contract_Change_without_AmendmentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Contract_Amendment_TypeObjectType Active_Amendment_Type_Reference
		{
			get
			{
				return this.active_Amendment_Type_ReferenceField;
			}
			set
			{
				this.active_Amendment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Active_Amendment_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Amendment_Effective_Date
		{
			get
			{
				return this.amendment_Effective_DateField;
			}
			set
			{
				this.amendment_Effective_DateField = value;
				this.RaisePropertyChanged("Amendment_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Amendment_Effective_DateSpecified
		{
			get
			{
				return this.amendment_Effective_DateFieldSpecified;
			}
			set
			{
				this.amendment_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Amendment_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Amendment_Number
		{
			get
			{
				return this.amendment_NumberField;
			}
			set
			{
				this.amendment_NumberField = value;
				this.RaisePropertyChanged("Amendment_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Amendment_Signed_Date
		{
			get
			{
				return this.amendment_Signed_DateField;
			}
			set
			{
				this.amendment_Signed_DateField = value;
				this.RaisePropertyChanged("Amendment_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Amendment_Signed_DateSpecified
		{
			get
			{
				return this.amendment_Signed_DateFieldSpecified;
			}
			set
			{
				this.amendment_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Amendment_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Amendment_Description
		{
			get
			{
				return this.amendment_DescriptionField;
			}
			set
			{
				this.amendment_DescriptionField = value;
				this.RaisePropertyChanged("Amendment_Description");
			}
		}

		[XmlElement(Order = 8)]
		public Document_StatusObjectType New_Contract_Status_Reference
		{
			get
			{
				return this.new_Contract_Status_ReferenceField;
			}
			set
			{
				this.new_Contract_Status_ReferenceField = value;
				this.RaisePropertyChanged("New_Contract_Status_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Schedules_Exist_on_Customer_Contract
		{
			get
			{
				return this.schedules_Exist_on_Customer_ContractField;
			}
			set
			{
				this.schedules_Exist_on_Customer_ContractField = value;
				this.RaisePropertyChanged("Schedules_Exist_on_Customer_Contract");
			}
		}

		[XmlIgnore]
		public bool Schedules_Exist_on_Customer_ContractSpecified
		{
			get
			{
				return this.schedules_Exist_on_Customer_ContractFieldSpecified;
			}
			set
			{
				this.schedules_Exist_on_Customer_ContractFieldSpecified = value;
				this.RaisePropertyChanged("Schedules_Exist_on_Customer_ContractSpecified");
			}
		}

		[XmlElement("Customer_Contract_Data", Order = 10)]
		public Customer_Contract_DataType[] Customer_Contract_Data
		{
			get
			{
				return this.customer_Contract_DataField;
			}
			set
			{
				this.customer_Contract_DataField = value;
				this.RaisePropertyChanged("Customer_Contract_Data");
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
