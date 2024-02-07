using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Get_Payroll_Pre-Printed_Payslips_Response_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Payroll_PrePrinted_Payslips_Response_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType employee_Name_ReferenceField;

		private Pay_Group_DetailObjectType pay_Group_Detail_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Unique_IdentifierObjectType payroll_Result_ReferenceField;

		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private decimal gross_AmountField;

		private bool gross_AmountFieldSpecified;

		private decimal net_AmountField;

		private bool net_AmountFieldSpecified;

		private string payroll_PrePrinted_Payslip_Document_IDField;

		private Repository_Document_MetadataType[] payroll_PrePrinted_Payslip_Document_ReferenceField;

		private byte[] file_ContentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Employee_Name_Reference
		{
			get
			{
				return this.employee_Name_ReferenceField;
			}
			set
			{
				this.employee_Name_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Name_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Pay_Group_DetailObjectType Pay_Group_Detail_Reference
		{
			get
			{
				return this.pay_Group_Detail_ReferenceField;
			}
			set
			{
				this.pay_Group_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Detail_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Unique_IdentifierObjectType Payroll_Result_Reference
		{
			get
			{
				return this.payroll_Result_ReferenceField;
			}
			set
			{
				this.payroll_Result_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Result_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Start_DateSpecified
		{
			get
			{
				return this.period_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Gross_Amount
		{
			get
			{
				return this.gross_AmountField;
			}
			set
			{
				this.gross_AmountField = value;
				this.RaisePropertyChanged("Gross_Amount");
			}
		}

		[XmlIgnore]
		public bool Gross_AmountSpecified
		{
			get
			{
				return this.gross_AmountFieldSpecified;
			}
			set
			{
				this.gross_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Gross_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Net_Amount
		{
			get
			{
				return this.net_AmountField;
			}
			set
			{
				this.net_AmountField = value;
				this.RaisePropertyChanged("Net_Amount");
			}
		}

		[XmlIgnore]
		public bool Net_AmountSpecified
		{
			get
			{
				return this.net_AmountFieldSpecified;
			}
			set
			{
				this.net_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Net_AmountSpecified");
			}
		}

		[XmlElement("Payroll_Pre-Printed_Payslip_Document_ID", Order = 9)]
		public string Payroll_PrePrinted_Payslip_Document_ID
		{
			get
			{
				return this.payroll_PrePrinted_Payslip_Document_IDField;
			}
			set
			{
				this.payroll_PrePrinted_Payslip_Document_IDField = value;
				this.RaisePropertyChanged("Payroll_PrePrinted_Payslip_Document_ID");
			}
		}

		[XmlElement("Payroll_Pre-Printed_Payslip_Document_Reference", Order = 10)]
		public Repository_Document_MetadataType[] Payroll_PrePrinted_Payslip_Document_Reference
		{
			get
			{
				return this.payroll_PrePrinted_Payslip_Document_ReferenceField;
			}
			set
			{
				this.payroll_PrePrinted_Payslip_Document_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_PrePrinted_Payslip_Document_Reference");
			}
		}

		[XmlElement(DataType = "base64Binary", Order = 11)]
		public byte[] File_Content
		{
			get
			{
				return this.file_ContentField;
			}
			set
			{
				this.file_ContentField = value;
				this.RaisePropertyChanged("File_Content");
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
