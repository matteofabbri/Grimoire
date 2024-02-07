using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Eligible_Earning_Request_CriteriaType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private Eligible_Earnings_Override_PeriodObjectType eligible_Earnings_Period_ReferenceField;

		private Bonus_Percent_PlanObjectType bonus_Plan_ReferenceField;

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
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Eligible_Earnings_Override_PeriodObjectType Eligible_Earnings_Period_Reference
		{
			get
			{
				return this.eligible_Earnings_Period_ReferenceField;
			}
			set
			{
				this.eligible_Earnings_Period_ReferenceField = value;
				this.RaisePropertyChanged("Eligible_Earnings_Period_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Bonus_Percent_PlanObjectType Bonus_Plan_Reference
		{
			get
			{
				return this.bonus_Plan_ReferenceField;
			}
			set
			{
				this.bonus_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Plan_Reference");
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
