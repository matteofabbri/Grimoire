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
	public class Payroll_BalanceType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Worker_ReferenceType worker_External_Integration_ID_DataField;

		private Name_DataType[] name_DataField;

		private National_ID_DataType[] national_ID_DataField;

		private Pay_Calculation_Balance_DataType[] pay_Calculation_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Worker_ReferenceType Worker_External_Integration_ID_Data
		{
			get
			{
				return this.worker_External_Integration_ID_DataField;
			}
			set
			{
				this.worker_External_Integration_ID_DataField = value;
				this.RaisePropertyChanged("Worker_External_Integration_ID_Data");
			}
		}

		[XmlElement("Name_Data", Order = 2)]
		public Name_DataType[] Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement("National_ID_Data", Order = 3)]
		public National_ID_DataType[] National_ID_Data
		{
			get
			{
				return this.national_ID_DataField;
			}
			set
			{
				this.national_ID_DataField = value;
				this.RaisePropertyChanged("National_ID_Data");
			}
		}

		[XmlElement("Pay_Calculation_Balance_Data", Order = 4)]
		public Pay_Calculation_Balance_DataType[] Pay_Calculation_Balance_Data
		{
			get
			{
				return this.pay_Calculation_Balance_DataField;
			}
			set
			{
				this.pay_Calculation_Balance_DataField = value;
				this.RaisePropertyChanged("Pay_Calculation_Balance_Data");
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
