using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Award_Item_Limit_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Aggregate_Limit_TypeObjectType student_Aggregate_Limit_Type_ReferenceField;

		private CalculationObjectType minimum_Calculation_ReferenceField;

		private CalculationObjectType maximum_Calculation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Aggregate_Limit_TypeObjectType Student_Aggregate_Limit_Type_Reference
		{
			get
			{
				return this.student_Aggregate_Limit_Type_ReferenceField;
			}
			set
			{
				this.student_Aggregate_Limit_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Aggregate_Limit_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public CalculationObjectType Minimum_Calculation_Reference
		{
			get
			{
				return this.minimum_Calculation_ReferenceField;
			}
			set
			{
				this.minimum_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Minimum_Calculation_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CalculationObjectType Maximum_Calculation_Reference
		{
			get
			{
				return this.maximum_Calculation_ReferenceField;
			}
			set
			{
				this.maximum_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Maximum_Calculation_Reference");
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
