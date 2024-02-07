using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "ACA_1095-C_Form_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ACA_1095C_Form_DataType : INotifyPropertyChanged
	{
		private Employee_Information_DataType employee_Information_DataField;

		private string plan_Start_MonthField;

		private Line_14_Month_DataType line_14_Month_DataField;

		private Line_15_Month_DataType line_15_Month_DataField;

		private Line_16_Month_DataType line_16_Month_DataField;

		private Line_1734_Covered_Individuals_Month_DataType[] line_1734_Covered_Individuals_Month_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Employee_Information_DataType Employee_Information_Data
		{
			get
			{
				return this.employee_Information_DataField;
			}
			set
			{
				this.employee_Information_DataField = value;
				this.RaisePropertyChanged("Employee_Information_Data");
			}
		}

		[XmlElement(Order = 1)]
		public string Plan_Start_Month
		{
			get
			{
				return this.plan_Start_MonthField;
			}
			set
			{
				this.plan_Start_MonthField = value;
				this.RaisePropertyChanged("Plan_Start_Month");
			}
		}

		[XmlElement(Order = 2)]
		public Line_14_Month_DataType Line_14_Month_Data
		{
			get
			{
				return this.line_14_Month_DataField;
			}
			set
			{
				this.line_14_Month_DataField = value;
				this.RaisePropertyChanged("Line_14_Month_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Line_15_Month_DataType Line_15_Month_Data
		{
			get
			{
				return this.line_15_Month_DataField;
			}
			set
			{
				this.line_15_Month_DataField = value;
				this.RaisePropertyChanged("Line_15_Month_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Line_16_Month_DataType Line_16_Month_Data
		{
			get
			{
				return this.line_16_Month_DataField;
			}
			set
			{
				this.line_16_Month_DataField = value;
				this.RaisePropertyChanged("Line_16_Month_Data");
			}
		}

		[XmlElement("Line_17-34_Covered_Individuals_Month_Data", Order = 5)]
		public Line_1734_Covered_Individuals_Month_DataType[] Line_1734_Covered_Individuals_Month_Data
		{
			get
			{
				return this.line_1734_Covered_Individuals_Month_DataField;
			}
			set
			{
				this.line_1734_Covered_Individuals_Month_DataField = value;
				this.RaisePropertyChanged("Line_1734_Covered_Individuals_Month_Data");
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
