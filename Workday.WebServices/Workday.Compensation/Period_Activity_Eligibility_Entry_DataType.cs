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
	public class Period_Activity_Eligibility_Entry_DataType : INotifyPropertyChanged
	{
		private Period_ActivityObjectType period_Activity_ReferenceField;

		private Period_Activity_TaskObjectType period_Activity_Task_ReferenceField;

		private decimal assigned_Unit_QuantityField;

		private bool assigned_Unit_QuantityFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_ActivityObjectType Period_Activity_Reference
		{
			get
			{
				return this.period_Activity_ReferenceField;
			}
			set
			{
				this.period_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_Activity_TaskObjectType Period_Activity_Task_Reference
		{
			get
			{
				return this.period_Activity_Task_ReferenceField;
			}
			set
			{
				this.period_Activity_Task_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Assigned_Unit_Quantity
		{
			get
			{
				return this.assigned_Unit_QuantityField;
			}
			set
			{
				this.assigned_Unit_QuantityField = value;
				this.RaisePropertyChanged("Assigned_Unit_Quantity");
			}
		}

		[XmlIgnore]
		public bool Assigned_Unit_QuantitySpecified
		{
			get
			{
				return this.assigned_Unit_QuantityFieldSpecified;
			}
			set
			{
				this.assigned_Unit_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Assigned_Unit_QuantitySpecified");
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
