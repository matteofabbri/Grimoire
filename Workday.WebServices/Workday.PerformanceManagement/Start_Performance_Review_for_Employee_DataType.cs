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
	public class Start_Performance_Review_for_Employee_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private Employee_Review_TemplateObjectType review_Template_ReferenceField;

		private DateTime period_Start_DateField;

		private bool period_Start_DateFieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private Set_Review_Content_Sub_Business_ProcessType set_Review_Content_Sub_ProcessField;

		private Complete_Self_Evaluation_Sub_Business_ProcessType complete_Self_Evaluation_Sub_ProcessField;

		private Complete_Manager_Evaluation_Sub_Business_ProcessType complete_Manager_Evaluation_Sub_ProcessField;

		private Assess_Talent_Sub_Business_ProcessType assess_Talent_Sub_ProcessField;

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

		[XmlElement(Order = 4)]
		public Set_Review_Content_Sub_Business_ProcessType Set_Review_Content_Sub_Process
		{
			get
			{
				return this.set_Review_Content_Sub_ProcessField;
			}
			set
			{
				this.set_Review_Content_Sub_ProcessField = value;
				this.RaisePropertyChanged("Set_Review_Content_Sub_Process");
			}
		}

		[XmlElement(Order = 5)]
		public Complete_Self_Evaluation_Sub_Business_ProcessType Complete_Self_Evaluation_Sub_Process
		{
			get
			{
				return this.complete_Self_Evaluation_Sub_ProcessField;
			}
			set
			{
				this.complete_Self_Evaluation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Complete_Self_Evaluation_Sub_Process");
			}
		}

		[XmlElement(Order = 6)]
		public Complete_Manager_Evaluation_Sub_Business_ProcessType Complete_Manager_Evaluation_Sub_Process
		{
			get
			{
				return this.complete_Manager_Evaluation_Sub_ProcessField;
			}
			set
			{
				this.complete_Manager_Evaluation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Complete_Manager_Evaluation_Sub_Process");
			}
		}

		[XmlElement(Order = 7)]
		public Assess_Talent_Sub_Business_ProcessType Assess_Talent_Sub_Process
		{
			get
			{
				return this.assess_Talent_Sub_ProcessField;
			}
			set
			{
				this.assess_Talent_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assess_Talent_Sub_Process");
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
