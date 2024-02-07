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
	public class Worker_Retirement_Savings_DataType : INotifyPropertyChanged
	{
		private Worker_Benefit_Election_DataType benefit_Election_DataField;

		private object itemField;

		private object item1Field;

		private Beneficiary_Designation_DataType[] beneficiary_Designation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Benefit_Election_DataType Benefit_Election_Data
		{
			get
			{
				return this.benefit_Election_DataField;
			}
			set
			{
				this.benefit_Election_DataField = value;
				this.RaisePropertyChanged("Benefit_Election_Data");
			}
		}

		[XmlElement("Employee_Contribution_Amount_Data", typeof(Employee_Contribution_Amount_DataType), Order = 1), XmlElement("Employee_Contribution_Percentage_Data", typeof(Employee_Contribution_Percentage_DataType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Employer_Contribution_Amount_Data", typeof(Employer_Contribution_Amount_DataType), Order = 2), XmlElement("Employer_Contribution_Percentage_Data", typeof(Employer_Contribution_Percentage_DataType), Order = 2)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement("Beneficiary_Designation_Data", Order = 3)]
		public Beneficiary_Designation_DataType[] Beneficiary_Designation_Data
		{
			get
			{
				return this.beneficiary_Designation_DataField;
			}
			set
			{
				this.beneficiary_Designation_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Designation_Data");
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
