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
	public class Worker_Insurance_Coverage_DataType : INotifyPropertyChanged
	{
		private Insurance_Coverage_Level_DataType insurance_Coverage_Level_DataField;

		private Worker_Benefit_Election_DataType benefit_Election_DataField;

		private Dependent_Coverage_DataType[] dependent_Coverage_DataField;

		private Beneficiary_Designation_DataType[] beneficiary_Designation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Insurance_Coverage_Level_DataType Insurance_Coverage_Level_Data
		{
			get
			{
				return this.insurance_Coverage_Level_DataField;
			}
			set
			{
				this.insurance_Coverage_Level_DataField = value;
				this.RaisePropertyChanged("Insurance_Coverage_Level_Data");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Dependent_Coverage_Data", Order = 2)]
		public Dependent_Coverage_DataType[] Dependent_Coverage_Data
		{
			get
			{
				return this.dependent_Coverage_DataField;
			}
			set
			{
				this.dependent_Coverage_DataField = value;
				this.RaisePropertyChanged("Dependent_Coverage_Data");
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
