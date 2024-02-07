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
	public class Employee_Review_Details_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType manager_ReferenceField;

		private WorkerObjectType[] multiple_Manager_ReferenceField;

		private Review_TypeObjectType review_Type_ReferenceField;

		private Employee_Review_TemplateObjectType review_Template_ReferenceField;

		private DateTime review_Initiated_DateField;

		private bool review_Initiated_DateFieldSpecified;

		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private Self_Evaluation_Detail_DataType self_Evaluation_DataField;

		private Manager_Evaluation_Detail_DataType manager_Evaluation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Manager_Reference
		{
			get
			{
				return this.manager_ReferenceField;
			}
			set
			{
				this.manager_ReferenceField = value;
				this.RaisePropertyChanged("Manager_Reference");
			}
		}

		[XmlElement("Multiple_Manager_Reference", Order = 1)]
		public WorkerObjectType[] Multiple_Manager_Reference
		{
			get
			{
				return this.multiple_Manager_ReferenceField;
			}
			set
			{
				this.multiple_Manager_ReferenceField = value;
				this.RaisePropertyChanged("Multiple_Manager_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Employee_Review_TemplateObjectType Review_Template_Reference
		{
			get
			{
				return this.review_Template_ReferenceField;
			}
			set
			{
				this.review_Template_ReferenceField = value;
				this.RaisePropertyChanged("Review_Template_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public DateTime Review_Initiated_Date
		{
			get
			{
				return this.review_Initiated_DateField;
			}
			set
			{
				this.review_Initiated_DateField = value;
				this.RaisePropertyChanged("Review_Initiated_Date");
			}
		}

		[XmlIgnore]
		public bool Review_Initiated_DateSpecified
		{
			get
			{
				return this.review_Initiated_DateFieldSpecified;
			}
			set
			{
				this.review_Initiated_DateFieldSpecified = value;
				this.RaisePropertyChanged("Review_Initiated_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlIgnore]
		public bool Period_Start_DateSpecified
		{
			get
			{
				return this.period_Start_DateFieldSpecified;
			}
			set
			{
				this.period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Self_Evaluation_Detail_DataType Self_Evaluation_Data
		{
			get
			{
				return this.self_Evaluation_DataField;
			}
			set
			{
				this.self_Evaluation_DataField = value;
				this.RaisePropertyChanged("Self_Evaluation_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Manager_Evaluation_Detail_DataType Manager_Evaluation_Data
		{
			get
			{
				return this.manager_Evaluation_DataField;
			}
			set
			{
				this.manager_Evaluation_DataField = value;
				this.RaisePropertyChanged("Manager_Evaluation_Data");
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
