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
	public class Worker_Spending_Account_Period_DataType : INotifyPropertyChanged
	{
		private Enrollment_Period_DataType enrollment_Period_DataField;

		private Spending_Account_Coverage_DataType[] spending_Account_Coverage_DataField;

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

		[XmlElement("Spending_Account_Coverage_Data", Order = 1)]
		public Spending_Account_Coverage_DataType[] Spending_Account_Coverage_Data
		{
			get
			{
				return this.spending_Account_Coverage_DataField;
			}
			set
			{
				this.spending_Account_Coverage_DataField = value;
				this.RaisePropertyChanged("Spending_Account_Coverage_Data");
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
