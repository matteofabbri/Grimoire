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
	public class Period_Activity_Rate_MatrixType : INotifyPropertyChanged
	{
		private Period_Activity_Rate_MatrixObjectType period_Activity_Rate_Matrix_ReferenceField;

		private Period_Activity_Rate_Matrix_DataType[] period_Activity_Rate_Matrix_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Activity_Rate_MatrixObjectType Period_Activity_Rate_Matrix_Reference
		{
			get
			{
				return this.period_Activity_Rate_Matrix_ReferenceField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Reference");
			}
		}

		[XmlElement("Period_Activity_Rate_Matrix_Data", Order = 1)]
		public Period_Activity_Rate_Matrix_DataType[] Period_Activity_Rate_Matrix_Data
		{
			get
			{
				return this.period_Activity_Rate_Matrix_DataField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_DataField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Data");
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
