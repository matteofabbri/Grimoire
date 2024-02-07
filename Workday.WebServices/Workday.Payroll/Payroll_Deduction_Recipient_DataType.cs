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
	public class Payroll_Deduction_Recipient_DataType : INotifyPropertyChanged
	{
		private string payroll_Deduction_Recipient_NameField;

		private string payroll_Alternate_Deduction_Recipient_NameField;

		private string payroll_Deduction_Recipient_IDField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Business_Entity_WWS_DataType business_Entity_DataField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payroll_Deduction_Recipient_Name
		{
			get
			{
				return this.payroll_Deduction_Recipient_NameField;
			}
			set
			{
				this.payroll_Deduction_Recipient_NameField = value;
				this.RaisePropertyChanged("Payroll_Deduction_Recipient_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Payroll_Alternate_Deduction_Recipient_Name
		{
			get
			{
				return this.payroll_Alternate_Deduction_Recipient_NameField;
			}
			set
			{
				this.payroll_Alternate_Deduction_Recipient_NameField = value;
				this.RaisePropertyChanged("Payroll_Alternate_Deduction_Recipient_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Payroll_Deduction_Recipient_ID
		{
			get
			{
				return this.payroll_Deduction_Recipient_IDField;
			}
			set
			{
				this.payroll_Deduction_Recipient_IDField = value;
				this.RaisePropertyChanged("Payroll_Deduction_Recipient_ID");
			}
		}

		[XmlElement(Order = 3)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Business_Entity_WWS_DataType Business_Entity_Data
		{
			get
			{
				return this.business_Entity_DataField;
			}
			set
			{
				this.business_Entity_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Data");
			}
		}

		[XmlElement("Settlement_Account_Data", Order = 5)]
		public Settlement_Account_WWS_DataType[] Settlement_Account_Data
		{
			get
			{
				return this.settlement_Account_DataField;
			}
			set
			{
				this.settlement_Account_DataField = value;
				this.RaisePropertyChanged("Settlement_Account_Data");
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
