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
	public class ROE_History_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType payroll_ROE_History_Data_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private Payroll_Reference_NumberObjectType payroll_Reference_Number_ReferenceField;

		private DateTime date_IssuedField;

		private string serial_NumberField;

		private DateTime return_from_Leave_Date__Prior_to_Go_Live_Field;

		private bool return_from_Leave_Date__Prior_to_Go_Live_FieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Payroll_ROE_History_Data_Reference
		{
			get
			{
				return this.payroll_ROE_History_Data_ReferenceField;
			}
			set
			{
				this.payroll_ROE_History_Data_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_ROE_History_Data_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Reference_NumberObjectType Payroll_Reference_Number_Reference
		{
			get
			{
				return this.payroll_Reference_Number_ReferenceField;
			}
			set
			{
				this.payroll_Reference_Number_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Reference_Number_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date_Issued
		{
			get
			{
				return this.date_IssuedField;
			}
			set
			{
				this.date_IssuedField = value;
				this.RaisePropertyChanged("Date_Issued");
			}
		}

		[XmlElement(Order = 5)]
		public string Serial_Number
		{
			get
			{
				return this.serial_NumberField;
			}
			set
			{
				this.serial_NumberField = value;
				this.RaisePropertyChanged("Serial_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Return_from_Leave_Date__Prior_to_Go_Live_
		{
			get
			{
				return this.return_from_Leave_Date__Prior_to_Go_Live_Field;
			}
			set
			{
				this.return_from_Leave_Date__Prior_to_Go_Live_Field = value;
				this.RaisePropertyChanged("Return_from_Leave_Date__Prior_to_Go_Live_");
			}
		}

		[XmlIgnore]
		public bool Return_from_Leave_Date__Prior_to_Go_Live_Specified
		{
			get
			{
				return this.return_from_Leave_Date__Prior_to_Go_Live_FieldSpecified;
			}
			set
			{
				this.return_from_Leave_Date__Prior_to_Go_Live_FieldSpecified = value;
				this.RaisePropertyChanged("Return_from_Leave_Date__Prior_to_Go_Live_Specified");
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
