using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensatable_Summary_DataType : INotifyPropertyChanged
	{
		private Compensatable_Summary_Amount_DataType employee_Compensation_Summary_DataField;

		private Compensatable_Summary_Amount_Annualized_DataType annualized_Summary_DataField;

		private Compensatable_Summary_Amount_In_Target_Frequency_DataType summary_Data_in_Pay_Group_FrequencyField;

		private Compensatable_Summary_Amount_Annualized_In_Reporting_Currency_DataType annualized_in_Reporting_Currency_Summary_DataField;

		private Compensatable_Summary_Amount_Hourly_DataType summary_Data_in_Hourly_FrequencyField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensatable_Summary_Amount_DataType Employee_Compensation_Summary_Data
		{
			get
			{
				return this.employee_Compensation_Summary_DataField;
			}
			set
			{
				this.employee_Compensation_Summary_DataField = value;
				this.RaisePropertyChanged("Employee_Compensation_Summary_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Compensatable_Summary_Amount_Annualized_DataType Annualized_Summary_Data
		{
			get
			{
				return this.annualized_Summary_DataField;
			}
			set
			{
				this.annualized_Summary_DataField = value;
				this.RaisePropertyChanged("Annualized_Summary_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Compensatable_Summary_Amount_In_Target_Frequency_DataType Summary_Data_in_Pay_Group_Frequency
		{
			get
			{
				return this.summary_Data_in_Pay_Group_FrequencyField;
			}
			set
			{
				this.summary_Data_in_Pay_Group_FrequencyField = value;
				this.RaisePropertyChanged("Summary_Data_in_Pay_Group_Frequency");
			}
		}

		[XmlElement(Order = 3)]
		public Compensatable_Summary_Amount_Annualized_In_Reporting_Currency_DataType Annualized_in_Reporting_Currency_Summary_Data
		{
			get
			{
				return this.annualized_in_Reporting_Currency_Summary_DataField;
			}
			set
			{
				this.annualized_in_Reporting_Currency_Summary_DataField = value;
				this.RaisePropertyChanged("Annualized_in_Reporting_Currency_Summary_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Compensatable_Summary_Amount_Hourly_DataType Summary_Data_in_Hourly_Frequency
		{
			get
			{
				return this.summary_Data_in_Hourly_FrequencyField;
			}
			set
			{
				this.summary_Data_in_Hourly_FrequencyField = value;
				this.RaisePropertyChanged("Summary_Data_in_Hourly_Frequency");
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
