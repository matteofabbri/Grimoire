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
	public class Update_Employee_Review_Rating_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Review_TypeObjectType review_Type_ReferenceField;

		private DateTime period_Start_DateField;

		private DateTime period_End_DateField;

		private Review_RatingObjectType rating_ReferenceField;

		private decimal overall_Rating_OverrideField;

		private bool overall_Rating_OverrideFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Review_TypeObjectType Review_Type_Reference
		{
			get
			{
				return this.review_Type_ReferenceField;
			}
			set
			{
				this.review_Type_ReferenceField = value;
				this.RaisePropertyChanged("Review_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Period_Start_Date
		{
			get
			{
				return this.period_Start_DateField;
			}
			set
			{
				this.period_Start_DateField = value;
				this.RaisePropertyChanged("Period_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlElement(Order = 4)]
		public Review_RatingObjectType Rating_Reference
		{
			get
			{
				return this.rating_ReferenceField;
			}
			set
			{
				this.rating_ReferenceField = value;
				this.RaisePropertyChanged("Rating_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
