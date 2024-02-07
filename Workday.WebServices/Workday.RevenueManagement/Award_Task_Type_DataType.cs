using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_Type_DataType : INotifyPropertyChanged
	{
		private Award_Task_TypeObjectType award_Task_Type_ReferenceField;

		private string award_Task_Type_Reference_IDField;

		private string award_Task_Type_NameField;

		private bool award_Task_Type_For_Closeout_TaskField;

		private bool award_Task_Type_For_Closeout_TaskFieldSpecified;

		private bool award_Task_Type_Is_InactiveField;

		private bool award_Task_Type_Is_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Task_TypeObjectType Award_Task_Type_Reference
		{
			get
			{
				return this.award_Task_Type_ReferenceField;
			}
			set
			{
				this.award_Task_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Task_Type_Reference_ID
		{
			get
			{
				return this.award_Task_Type_Reference_IDField;
			}
			set
			{
				this.award_Task_Type_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Task_Type_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Award_Task_Type_Name
		{
			get
			{
				return this.award_Task_Type_NameField;
			}
			set
			{
				this.award_Task_Type_NameField = value;
				this.RaisePropertyChanged("Award_Task_Type_Name");
			}
		}

		[XmlElement(Order = 3)]
		public bool Award_Task_Type_For_Closeout_Task
		{
			get
			{
				return this.award_Task_Type_For_Closeout_TaskField;
			}
			set
			{
				this.award_Task_Type_For_Closeout_TaskField = value;
				this.RaisePropertyChanged("Award_Task_Type_For_Closeout_Task");
			}
		}

		[XmlIgnore]
		public bool Award_Task_Type_For_Closeout_TaskSpecified
		{
			get
			{
				return this.award_Task_Type_For_Closeout_TaskFieldSpecified;
			}
			set
			{
				this.award_Task_Type_For_Closeout_TaskFieldSpecified = value;
				this.RaisePropertyChanged("Award_Task_Type_For_Closeout_TaskSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Award_Task_Type_Is_Inactive
		{
			get
			{
				return this.award_Task_Type_Is_InactiveField;
			}
			set
			{
				this.award_Task_Type_Is_InactiveField = value;
				this.RaisePropertyChanged("Award_Task_Type_Is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Award_Task_Type_Is_InactiveSpecified
		{
			get
			{
				return this.award_Task_Type_Is_InactiveFieldSpecified;
			}
			set
			{
				this.award_Task_Type_Is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Award_Task_Type_Is_InactiveSpecified");
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
