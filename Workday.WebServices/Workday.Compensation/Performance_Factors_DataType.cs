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
	public class Performance_Factors_DataType : INotifyPropertyChanged
	{
		private Performance_Factor_Scorecard_DataType[] performance_Factor_Scorecard_DataField;

		private Performance_Factor_Compensation_Matrix_Weighted_DataType performance_Factor_Compensation_Matrix_Weighted_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Performance_Factor_Scorecard_Data", Order = 0)]
		public Performance_Factor_Scorecard_DataType[] Performance_Factor_Scorecard_Data
		{
			get
			{
				return this.performance_Factor_Scorecard_DataField;
			}
			set
			{
				this.performance_Factor_Scorecard_DataField = value;
				this.RaisePropertyChanged("Performance_Factor_Scorecard_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Performance_Factor_Compensation_Matrix_Weighted_DataType Performance_Factor_Compensation_Matrix_Weighted_Data
		{
			get
			{
				return this.performance_Factor_Compensation_Matrix_Weighted_DataField;
			}
			set
			{
				this.performance_Factor_Compensation_Matrix_Weighted_DataField = value;
				this.RaisePropertyChanged("Performance_Factor_Compensation_Matrix_Weighted_Data");
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
