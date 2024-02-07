using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Health_Savings_Account_Period_DataType : INotifyPropertyChanged
	{
		private Enrollment_Period_DataType enrollment_Period_DataField;

		private Health_Savings_Account_Coverage_DataType[] health_Savings_Account_Coverage_DataField;

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

		[XmlElement("Health_Savings_Account_Coverage_Data", Order = 1)]
		public Health_Savings_Account_Coverage_DataType[] Health_Savings_Account_Coverage_Data
		{
			get
			{
				return this.health_Savings_Account_Coverage_DataField;
			}
			set
			{
				this.health_Savings_Account_Coverage_DataField = value;
				this.RaisePropertyChanged("Health_Savings_Account_Coverage_Data");
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
