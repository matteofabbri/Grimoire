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
	public class Review_Question_DataType : INotifyPropertyChanged
	{
		private QuestionObjectType question_ReferenceField;

		private decimal weightField;

		private bool weightFieldSpecified;

		private Manager_Component_Evaluation_DataType manager_Evaluation_DataField;

		private Employee_Component_Evaluation_DataType employee_Evaluation_DataField;

		private Additional_Manager_Component_Evaluation_DataType[] additional_Manager_Evaluation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public QuestionObjectType Question_Reference
		{
			get
			{
				return this.question_ReferenceField;
			}
			set
			{
				this.question_ReferenceField = value;
				this.RaisePropertyChanged("Question_Reference");
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

		[XmlIgnore]
		public bool WeightSpecified
		{
			get
			{
				return this.weightFieldSpecified;
			}
			set
			{
				this.weightFieldSpecified = value;
				this.RaisePropertyChanged("WeightSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Manager_Component_Evaluation_DataType Manager_Evaluation_Data
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

		[XmlElement(Order = 3)]
		public Employee_Component_Evaluation_DataType Employee_Evaluation_Data
		{
			get
			{
				return this.employee_Evaluation_DataField;
			}
			set
			{
				this.employee_Evaluation_DataField = value;
				this.RaisePropertyChanged("Employee_Evaluation_Data");
			}
		}

		[XmlElement("Additional_Manager_Evaluation_Data", Order = 4)]
		public Additional_Manager_Component_Evaluation_DataType[] Additional_Manager_Evaluation_Data
		{
			get
			{
				return this.additional_Manager_Evaluation_DataField;
			}
			set
			{
				this.additional_Manager_Evaluation_DataField = value;
				this.RaisePropertyChanged("Additional_Manager_Evaluation_Data");
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
