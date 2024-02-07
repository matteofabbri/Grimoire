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
	public class Performance_Factor_Compensation_Matrix_Weighted_DataType : INotifyPropertyChanged
	{
		private Compensation_Weighted_Percent_MatrixObjectType compensation_Matrix_Weighted_ReferenceField;

		private decimal weightField;

		private Default_ScorecardObjectType bonus_Modifier_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Weighted_Percent_MatrixObjectType Compensation_Matrix_Weighted_Reference
		{
			get
			{
				return this.compensation_Matrix_Weighted_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_Weighted_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Weighted_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
			}
		}

		[XmlElement(Order = 2)]
		public Default_ScorecardObjectType Bonus_Modifier_Reference
		{
			get
			{
				return this.bonus_Modifier_ReferenceField;
			}
			set
			{
				this.bonus_Modifier_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Modifier_Reference");
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
