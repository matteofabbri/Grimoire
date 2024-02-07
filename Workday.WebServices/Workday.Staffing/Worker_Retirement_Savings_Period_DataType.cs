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
	public class Worker_Retirement_Savings_Period_DataType : INotifyPropertyChanged
	{
		private Enrollment_Period_DataType enrollment_Period_DataField;

		private Worker_Retirement_Savings_DataType[] retirement_Savings_Coverage_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Enrollment_Period_DataType Enrollment_Period_Data
		{
			get
			{
				return this.enrollment_Period_DataField;
			}
			set
			{
				this.enrollment_Period_DataField = value;
				this.RaisePropertyChanged("Enrollment_Period_Data");
			}
		}

		[XmlElement("Retirement_Savings_Coverage_Data", Order = 1)]
		public Worker_Retirement_Savings_DataType[] Retirement_Savings_Coverage_Data
		{
			get
			{
				return this.retirement_Savings_Coverage_DataField;
			}
			set
			{
				this.retirement_Savings_Coverage_DataField = value;
				this.RaisePropertyChanged("Retirement_Savings_Coverage_Data");
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
