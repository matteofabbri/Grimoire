using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Message_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Payment_DataField;

		private bool include_Payment_DataFieldSpecified;

		private bool include_Payroll_Remittance_DataField;

		private bool include_Payroll_Remittance_DataFieldSpecified;

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
		public bool Include_Payment_Data
		{
			get
			{
				return this.include_Payment_DataField;
			}
			set
			{
				this.include_Payment_DataField = value;
				this.RaisePropertyChanged("Include_Payment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payment_DataSpecified
		{
			get
			{
				return this.include_Payment_DataFieldSpecified;
			}
			set
			{
				this.include_Payment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payment_DataSpecified");
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
