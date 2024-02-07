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
	public class Period_Activity_Assignment_Deleted_DataType : INotifyPropertyChanged
	{
		private Period_Activity_AssignmentObjectType period_Activity_Assignment_ReferenceField;

		private Period_ActivityObjectType period_Activity_ReferenceField;

		private Period_Activity_TaskObjectType period_Activity_Task_ReferenceField;

		private DateTime period_Activity_Start_DateField;

		private bool period_Activity_Start_DateFieldSpecified;

		private DateTime period_Activity_End_DateField;

		private bool period_Activity_End_DateFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Activity_AssignmentObjectType Period_Activity_Assignment_Reference
		{
			get
			{
				return this.period_Activity_Assignment_ReferenceField;
			}
			set
			{
				this.period_Activity_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_ActivityObjectType Period_Activity_Reference
		{
			get
			{
				return this.period_Activity_ReferenceField;
			}
			set
			{
				this.period_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Period_Activity_TaskObjectType Period_Activity_Task_Reference
		{
			get
			{
				return this.period_Activity_Task_ReferenceField;
			}
			set
			{
				this.period_Activity_Task_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Period_Activity_Start_Date
		{
			get
			{
				return this.period_Activity_Start_DateField;
			}
			set
			{
				this.period_Activity_Start_DateField = value;
				this.RaisePropertyChanged("Period_Activity_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Activity_Start_DateSpecified
		{
			get
			{
				return this.period_Activity_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Activity_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Activity_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Period_Activity_End_Date
		{
			get
			{
				return this.period_Activity_End_DateField;
			}
			set
			{
				this.period_Activity_End_DateField = value;
				this.RaisePropertyChanged("Period_Activity_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_Activity_End_DateSpecified
		{
			get
			{
				return this.period_Activity_End_DateFieldSpecified;
			}
			set
			{
				this.period_Activity_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Activity_End_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
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
