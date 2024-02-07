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
	public class Benefit_Plan_Year_Definition_Year_End_DataType : INotifyPropertyChanged
	{
		private Benefit_Plan_Year_DefinitionObjectType year_Definition_ReferenceField;

		private DateTime program_End_DateField;

		private bool program_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Benefit_Plan_Year_DefinitionObjectType Year_Definition_Reference
		{
			get
			{
				return this.year_Definition_ReferenceField;
			}
			set
			{
				this.year_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Year_Definition_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Program_End_Date
		{
			get
			{
				return this.program_End_DateField;
			}
			set
			{
				this.program_End_DateField = value;
				this.RaisePropertyChanged("Program_End_Date");
			}
		}

		[XmlIgnore]
		public bool Program_End_DateSpecified
		{
			get
			{
				return this.program_End_DateFieldSpecified;
			}
			set
			{
				this.program_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Program_End_DateSpecified");
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
