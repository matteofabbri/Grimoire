using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Overall_Evaluation_DataType : INotifyPropertyChanged
	{
		private Review_RatingObjectType performance_Evaluation_Rating_ReferenceField;

		private string employee_CommentField;

		private decimal overall_Rating_OverrideField;

		private bool overall_Rating_OverrideFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Review_RatingObjectType Performance_Evaluation_Rating_Reference
		{
			get
			{
				return this.performance_Evaluation_Rating_ReferenceField;
			}
			set
			{
				this.performance_Evaluation_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Performance_Evaluation_Rating_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Employee_Comment
		{
			get
			{
				return this.employee_CommentField;
			}
			set
			{
				this.employee_CommentField = value;
				this.RaisePropertyChanged("Employee_Comment");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Overall_Rating_Override
		{
			get
			{
				return this.overall_Rating_OverrideField;
			}
			set
			{
				this.overall_Rating_OverrideField = value;
				this.RaisePropertyChanged("Overall_Rating_Override");
			}
		}

		[XmlIgnore]
		public bool Overall_Rating_OverrideSpecified
		{
			get
			{
				return this.overall_Rating_OverrideFieldSpecified;
			}
			set
			{
				this.overall_Rating_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Overall_Rating_OverrideSpecified");
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
