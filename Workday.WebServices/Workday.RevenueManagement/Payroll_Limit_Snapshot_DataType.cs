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
	public class Payroll_Limit_Snapshot_DataType : INotifyPropertyChanged
	{
		private Payroll_Limit_SnapshotObjectType salary_Cap_Interval_ReferenceField;

		private string salary_Cap_Interval_IDField;

		private DateTime date_FromField;

		private DateTime date_ToField;

		private bool date_ToFieldSpecified;

		private decimal salary_Cap_AmountField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Limit_SnapshotObjectType Salary_Cap_Interval_Reference
		{
			get
			{
				return this.salary_Cap_Interval_ReferenceField;
			}
			set
			{
				this.salary_Cap_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Salary_Cap_Interval_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Salary_Cap_Interval_ID
		{
			get
			{
				return this.salary_Cap_Interval_IDField;
			}
			set
			{
				this.salary_Cap_Interval_IDField = value;
				this.RaisePropertyChanged("Salary_Cap_Interval_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Date_From
		{
			get
			{
				return this.date_FromField;
			}
			set
			{
				this.date_FromField = value;
				this.RaisePropertyChanged("Date_From");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Date_To
		{
			get
			{
				return this.date_ToField;
			}
			set
			{
				this.date_ToField = value;
				this.RaisePropertyChanged("Date_To");
			}
		}

		[XmlIgnore]
		public bool Date_ToSpecified
		{
			get
			{
				return this.date_ToFieldSpecified;
			}
			set
			{
				this.date_ToFieldSpecified = value;
				this.RaisePropertyChanged("Date_ToSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Salary_Cap_Amount
		{
			get
			{
				return this.salary_Cap_AmountField;
			}
			set
			{
				this.salary_Cap_AmountField = value;
				this.RaisePropertyChanged("Salary_Cap_Amount");
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
