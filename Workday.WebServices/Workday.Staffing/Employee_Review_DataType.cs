using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Review_DataType : INotifyPropertyChanged
	{
		private Performance_Review_DataType performance_Review_DataField;

		private Performance_Improvement_Plan_DataType performance_Improvement_Plan_DataField;

		private Development_Plan_DataType development_Plan_DataField;

		private Disciplinary_Action_DataType disciplinary_Action_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Performance_Review_DataType Performance_Review_Data
		{
			get
			{
				return this.performance_Review_DataField;
			}
			set
			{
				this.performance_Review_DataField = value;
				this.RaisePropertyChanged("Performance_Review_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Performance_Improvement_Plan_DataType Performance_Improvement_Plan_Data
		{
			get
			{
				return this.performance_Improvement_Plan_DataField;
			}
			set
			{
				this.performance_Improvement_Plan_DataField = value;
				this.RaisePropertyChanged("Performance_Improvement_Plan_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Development_Plan_DataType Development_Plan_Data
		{
			get
			{
				return this.development_Plan_DataField;
			}
			set
			{
				this.development_Plan_DataField = value;
				this.RaisePropertyChanged("Development_Plan_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Disciplinary_Action_DataType Disciplinary_Action_Data
		{
			get
			{
				return this.disciplinary_Action_DataField;
			}
			set
			{
				this.disciplinary_Action_DataField = value;
				this.RaisePropertyChanged("Disciplinary_Action_Data");
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
