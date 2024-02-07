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
	public class Run_Pay_CalculationType : INotifyPropertyChanged
	{
		private Background_Process_RuntimeObjectType run_Pay_Calculation_ReferenceField;

		private Background_ProcessObjectType process_ReferenceField;

		private Background_Process_Runtime_StatusObjectType status_ReferenceField;

		private string current_Processing_TimeField;

		private string average_Processing_TimeField;

		private Run_Pay_Calculation_Process_Calculation_CriteriaType run_Pay_Calculation_Process_CriteriaField;

		private Payroll_Run_Detail_Pay_Calc_StatusType[] pay_Groups_Being_CalculatedField;

		private Run_Pay_Calculation_Process_InformationType run_Pay_Calculation_Process_InformationField;

		private Run_Pay_Calculation_Process_HistoryType run_Pay_Calculation_Process_HistoryField;

		private Run_Pay_Calculation_MessageType[] run_Pay_Calculation_MessagesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Background_Process_RuntimeObjectType Run_Pay_Calculation_Reference
		{
			get
			{
				return this.run_Pay_Calculation_ReferenceField;
			}
			set
			{
				this.run_Pay_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Background_ProcessObjectType Process_Reference
		{
			get
			{
				return this.process_ReferenceField;
			}
			set
			{
				this.process_ReferenceField = value;
				this.RaisePropertyChanged("Process_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Background_Process_Runtime_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Current_Processing_Time
		{
			get
			{
				return this.current_Processing_TimeField;
			}
			set
			{
				this.current_Processing_TimeField = value;
				this.RaisePropertyChanged("Current_Processing_Time");
			}
		}

		[XmlElement(Order = 4)]
		public string Average_Processing_Time
		{
			get
			{
				return this.average_Processing_TimeField;
			}
			set
			{
				this.average_Processing_TimeField = value;
				this.RaisePropertyChanged("Average_Processing_Time");
			}
		}

		[XmlElement(Order = 5)]
		public Run_Pay_Calculation_Process_Calculation_CriteriaType Run_Pay_Calculation_Process_Criteria
		{
			get
			{
				return this.run_Pay_Calculation_Process_CriteriaField;
			}
			set
			{
				this.run_Pay_Calculation_Process_CriteriaField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Process_Criteria");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Payroll_Run_Detail_Pay_Calc_Status", IsNullable = false)]
		public Payroll_Run_Detail_Pay_Calc_StatusType[] Pay_Groups_Being_Calculated
		{
			get
			{
				return this.pay_Groups_Being_CalculatedField;
			}
			set
			{
				this.pay_Groups_Being_CalculatedField = value;
				this.RaisePropertyChanged("Pay_Groups_Being_Calculated");
			}
		}

		[XmlElement(Order = 7)]
		public Run_Pay_Calculation_Process_InformationType Run_Pay_Calculation_Process_Information
		{
			get
			{
				return this.run_Pay_Calculation_Process_InformationField;
			}
			set
			{
				this.run_Pay_Calculation_Process_InformationField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Process_Information");
			}
		}

		[XmlElement(Order = 8)]
		public Run_Pay_Calculation_Process_HistoryType Run_Pay_Calculation_Process_History
		{
			get
			{
				return this.run_Pay_Calculation_Process_HistoryField;
			}
			set
			{
				this.run_Pay_Calculation_Process_HistoryField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Process_History");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Run_Pay_Calculation_Message", IsNullable = false)]
		public Run_Pay_Calculation_MessageType[] Run_Pay_Calculation_Messages
		{
			get
			{
				return this.run_Pay_Calculation_MessagesField;
			}
			set
			{
				this.run_Pay_Calculation_MessagesField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Messages");
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
