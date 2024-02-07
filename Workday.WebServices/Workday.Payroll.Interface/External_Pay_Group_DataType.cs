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
	public class External_Pay_Group_DataType : INotifyPropertyChanged
	{
		private Run_CategoryObjectType run_Category_ReferenceField;

		private Period_ScheduleObjectType period_Schedule_ReferenceField;

		private PeriodObjectType override_First_Processing_Period_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Run_CategoryObjectType Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_ScheduleObjectType Period_Schedule_Reference
		{
			get
			{
				return this.period_Schedule_ReferenceField;
			}
			set
			{
				this.period_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Period_Schedule_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public PeriodObjectType Override_First_Processing_Period_Reference
		{
			get
			{
				return this.override_First_Processing_Period_ReferenceField;
			}
			set
			{
				this.override_First_Processing_Period_ReferenceField = value;
				this.RaisePropertyChanged("Override_First_Processing_Period_Reference");
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
