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
	public class Period_Activity_Rate_Matrix_Entry_DataType : INotifyPropertyChanged
	{
		private Period_Activity_CategoryObjectType period_Activity_Category_ReferenceField;

		private Period_Activity_UnitObjectType period_Activity_Unit_ReferenceField;

		private Period_Activity_Rate_Matrix_Entry_Sequence_DataType period_Activity_Rate_Matrix_Entry_Sequence_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Activity_CategoryObjectType Period_Activity_Category_Reference
		{
			get
			{
				return this.period_Activity_Category_ReferenceField;
			}
			set
			{
				this.period_Activity_Category_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_Activity_UnitObjectType Period_Activity_Unit_Reference
		{
			get
			{
				return this.period_Activity_Unit_ReferenceField;
			}
			set
			{
				this.period_Activity_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Unit_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Period_Activity_Rate_Matrix_Entry_Sequence_DataType Period_Activity_Rate_Matrix_Entry_Sequence_Data
		{
			get
			{
				return this.period_Activity_Rate_Matrix_Entry_Sequence_DataField;
			}
			set
			{
				this.period_Activity_Rate_Matrix_Entry_Sequence_DataField = value;
				this.RaisePropertyChanged("Period_Activity_Rate_Matrix_Entry_Sequence_Data");
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
