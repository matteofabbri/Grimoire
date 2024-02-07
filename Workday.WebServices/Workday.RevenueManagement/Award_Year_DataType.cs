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
	public class Award_Year_DataType : INotifyPropertyChanged
	{
		private string award_Period_Reference_IDField;

		private string award_Period_NameField;

		private decimal award_Period_NumberField;

		private Award_Period_DataType[] award_Interval_DataField;

		private bool is_Award_Contract_Start_DateField;

		private bool is_Award_Contract_Start_DateFieldSpecified;

		private bool is_Award_Contract_End_DateField;

		private bool is_Award_Contract_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Period_Reference_ID
		{
			get
			{
				return this.award_Period_Reference_IDField;
			}
			set
			{
				this.award_Period_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Period_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Period_Name
		{
			get
			{
				return this.award_Period_NameField;
			}
			set
			{
				this.award_Period_NameField = value;
				this.RaisePropertyChanged("Award_Period_Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Award_Period_Number
		{
			get
			{
				return this.award_Period_NumberField;
			}
			set
			{
				this.award_Period_NumberField = value;
				this.RaisePropertyChanged("Award_Period_Number");
			}
		}

		[XmlElement("Award_Interval_Data", Order = 3)]
		public Award_Period_DataType[] Award_Interval_Data
		{
			get
			{
				return this.award_Interval_DataField;
			}
			set
			{
				this.award_Interval_DataField = value;
				this.RaisePropertyChanged("Award_Interval_Data");
			}
		}

		[XmlElement(Order = 4)]
		public bool Is_Award_Contract_Start_Date
		{
			get
			{
				return this.is_Award_Contract_Start_DateField;
			}
			set
			{
				this.is_Award_Contract_Start_DateField = value;
				this.RaisePropertyChanged("Is_Award_Contract_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Is_Award_Contract_Start_DateSpecified
		{
			get
			{
				return this.is_Award_Contract_Start_DateFieldSpecified;
			}
			set
			{
				this.is_Award_Contract_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Is_Award_Contract_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Is_Award_Contract_End_Date
		{
			get
			{
				return this.is_Award_Contract_End_DateField;
			}
			set
			{
				this.is_Award_Contract_End_DateField = value;
				this.RaisePropertyChanged("Is_Award_Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Is_Award_Contract_End_DateSpecified
		{
			get
			{
				return this.is_Award_Contract_End_DateFieldSpecified;
			}
			set
			{
				this.is_Award_Contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Is_Award_Contract_End_DateSpecified");
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
