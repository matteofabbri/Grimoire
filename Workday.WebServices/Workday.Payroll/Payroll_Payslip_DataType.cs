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
	public class Payroll_Payslip_DataType : INotifyPropertyChanged
	{
		private Payslip_Run_Category_DataType run_Category_DataField;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private Payroll_Remittance_DataType payroll_Remittance_DataField;

		private Payslip_Payment_DataType[] payment_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		private OffCycle_DataType[] off_Cycle_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payslip_Run_Category_DataType Run_Category_Data
		{
			get
			{
				return this.run_Category_DataField;
			}
			set
			{
				this.run_Category_DataField = value;
				this.RaisePropertyChanged("Run_Category_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
		public Payroll_Remittance_DataType Payroll_Remittance_Data
		{
			get
			{
				return this.payroll_Remittance_DataField;
			}
			set
			{
				this.payroll_Remittance_DataField = value;
				this.RaisePropertyChanged("Payroll_Remittance_Data");
			}
		}

		[XmlElement("Payment_Data", Order = 3)]
		public Payslip_Payment_DataType[] Payment_Data
		{
			get
			{
				return this.payment_DataField;
			}
			set
			{
				this.payment_DataField = value;
				this.RaisePropertyChanged("Payment_Data");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 4)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
			}
		}

		[XmlElement("Off_Cycle_Data", Order = 5)]
		public OffCycle_DataType[] Off_Cycle_Data
		{
			get
			{
				return this.off_Cycle_DataField;
			}
			set
			{
				this.off_Cycle_DataField = value;
				this.RaisePropertyChanged("Off_Cycle_Data");
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
