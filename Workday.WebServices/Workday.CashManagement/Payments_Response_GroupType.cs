using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payments_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Originating_Bank_DataField;

		private bool include_Originating_Bank_DataFieldSpecified;

		private bool include_Payroll_Remittance_DataField;

		private bool include_Payroll_Remittance_DataFieldSpecified;

		private bool include_Payment_Group_DataField;

		private bool include_Payment_Group_DataFieldSpecified;

		private bool include_Payroll_Result_Country_DataField;

		private bool include_Payroll_Result_Country_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Originating_Bank_Data
		{
			get
			{
				return this.include_Originating_Bank_DataField;
			}
			set
			{
				this.include_Originating_Bank_DataField = value;
				this.RaisePropertyChanged("Include_Originating_Bank_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Originating_Bank_DataSpecified
		{
			get
			{
				return this.include_Originating_Bank_DataFieldSpecified;
			}
			set
			{
				this.include_Originating_Bank_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Originating_Bank_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Payroll_Remittance_Data
		{
			get
			{
				return this.include_Payroll_Remittance_DataField;
			}
			set
			{
				this.include_Payroll_Remittance_DataField = value;
				this.RaisePropertyChanged("Include_Payroll_Remittance_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payroll_Remittance_DataSpecified
		{
			get
			{
				return this.include_Payroll_Remittance_DataFieldSpecified;
			}
			set
			{
				this.include_Payroll_Remittance_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payroll_Remittance_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Payment_Group_Data
		{
			get
			{
				return this.include_Payment_Group_DataField;
			}
			set
			{
				this.include_Payment_Group_DataField = value;
				this.RaisePropertyChanged("Include_Payment_Group_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payment_Group_DataSpecified
		{
			get
			{
				return this.include_Payment_Group_DataFieldSpecified;
			}
			set
			{
				this.include_Payment_Group_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payment_Group_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Payroll_Result_Country_Data
		{
			get
			{
				return this.include_Payroll_Result_Country_DataField;
			}
			set
			{
				this.include_Payroll_Result_Country_DataField = value;
				this.RaisePropertyChanged("Include_Payroll_Result_Country_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payroll_Result_Country_DataSpecified
		{
			get
			{
				return this.include_Payroll_Result_Country_DataFieldSpecified;
			}
			set
			{
				this.include_Payroll_Result_Country_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payroll_Result_Country_DataSpecified");
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
