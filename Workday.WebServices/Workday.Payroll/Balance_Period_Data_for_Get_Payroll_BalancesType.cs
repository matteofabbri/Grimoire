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
	public class Balance_Period_Data_for_Get_Payroll_BalancesType : INotifyPropertyChanged
	{
		private string balance_Period_NameField;

		private DateTime balance_Period_Start_DateField;

		private bool balance_Period_Start_DateFieldSpecified;

		private DateTime balance_Period_End_DateField;

		private bool balance_Period_End_DateFieldSpecified;

		private Balance_Period_Detail_DataType[] balance_Period_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Balance_Period_Name
		{
			get
			{
				return this.balance_Period_NameField;
			}
			set
			{
				this.balance_Period_NameField = value;
				this.RaisePropertyChanged("Balance_Period_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Balance_Period_Start_Date
		{
			get
			{
				return this.balance_Period_Start_DateField;
			}
			set
			{
				this.balance_Period_Start_DateField = value;
				this.RaisePropertyChanged("Balance_Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Balance_Period_Start_DateSpecified
		{
			get
			{
				return this.balance_Period_Start_DateFieldSpecified;
			}
			set
			{
				this.balance_Period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Balance_Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Balance_Period_End_Date
		{
			get
			{
				return this.balance_Period_End_DateField;
			}
			set
			{
				this.balance_Period_End_DateField = value;
				this.RaisePropertyChanged("Balance_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Balance_Period_End_DateSpecified
		{
			get
			{
				return this.balance_Period_End_DateFieldSpecified;
			}
			set
			{
				this.balance_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Balance_Period_End_DateSpecified");
			}
		}

		[XmlElement("Balance_Period_Detail_Data", Order = 3)]
		public Balance_Period_Detail_DataType[] Balance_Period_Detail_Data
		{
			get
			{
				return this.balance_Period_Detail_DataField;
			}
			set
			{
				this.balance_Period_Detail_DataField = value;
				this.RaisePropertyChanged("Balance_Period_Detail_Data");
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
