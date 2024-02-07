using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_One_Time_Payment_Rescind_and_Correct_DataType : INotifyPropertyChanged
	{
		private bool event_CorrectedField;

		private bool event_CorrectedFieldSpecified;

		private bool event_RescindedField;

		private bool event_RescindedFieldSpecified;

		private decimal amount_Delta_Since_Initialization_Date_TimeField;

		private bool amount_Delta_Since_Initialization_Date_TimeFieldSpecified;

		private DateTime effective_Date_as_of_Initialization_Date_TimeField;

		private bool effective_Date_as_of_Initialization_Date_TimeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Event_Corrected
		{
			get
			{
				return this.event_CorrectedField;
			}
			set
			{
				this.event_CorrectedField = value;
				this.RaisePropertyChanged("Event_Corrected");
			}
		}

		[XmlIgnore]
		public bool Event_CorrectedSpecified
		{
			get
			{
				return this.event_CorrectedFieldSpecified;
			}
			set
			{
				this.event_CorrectedFieldSpecified = value;
				this.RaisePropertyChanged("Event_CorrectedSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Event_Rescinded
		{
			get
			{
				return this.event_RescindedField;
			}
			set
			{
				this.event_RescindedField = value;
				this.RaisePropertyChanged("Event_Rescinded");
			}
		}

		[XmlIgnore]
		public bool Event_RescindedSpecified
		{
			get
			{
				return this.event_RescindedFieldSpecified;
			}
			set
			{
				this.event_RescindedFieldSpecified = value;
				this.RaisePropertyChanged("Event_RescindedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Amount_Delta_Since_Initialization_Date_Time
		{
			get
			{
				return this.amount_Delta_Since_Initialization_Date_TimeField;
			}
			set
			{
				this.amount_Delta_Since_Initialization_Date_TimeField = value;
				this.RaisePropertyChanged("Amount_Delta_Since_Initialization_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Amount_Delta_Since_Initialization_Date_TimeSpecified
		{
			get
			{
				return this.amount_Delta_Since_Initialization_Date_TimeFieldSpecified;
			}
			set
			{
				this.amount_Delta_Since_Initialization_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Amount_Delta_Since_Initialization_Date_TimeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Effective_Date_as_of_Initialization_Date_Time
		{
			get
			{
				return this.effective_Date_as_of_Initialization_Date_TimeField;
			}
			set
			{
				this.effective_Date_as_of_Initialization_Date_TimeField = value;
				this.RaisePropertyChanged("Effective_Date_as_of_Initialization_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Effective_Date_as_of_Initialization_Date_TimeSpecified
		{
			get
			{
				return this.effective_Date_as_of_Initialization_Date_TimeFieldSpecified;
			}
			set
			{
				this.effective_Date_as_of_Initialization_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Effective_Date_as_of_Initialization_Date_TimeSpecified");
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
