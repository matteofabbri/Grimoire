using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Training_Achievement_DataType : INotifyPropertyChanged
	{
		private string training_IDField;

		private bool remove_TrainingField;

		private bool remove_TrainingFieldSpecified;

		private string trainingField;

		private string descriptionField;

		private Training_TypeObjectType training_Type_ReferenceField;

		private DateTime completion_DateField;

		private bool completion_DateFieldSpecified;

		private string training_DurationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Training_ID
		{
			get
			{
				return this.training_IDField;
			}
			set
			{
				this.training_IDField = value;
				this.RaisePropertyChanged("Training_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Training
		{
			get
			{
				return this.remove_TrainingField;
			}
			set
			{
				this.remove_TrainingField = value;
				this.RaisePropertyChanged("Remove_Training");
			}
		}

		[XmlIgnore]
		public bool Remove_TrainingSpecified
		{
			get
			{
				return this.remove_TrainingFieldSpecified;
			}
			set
			{
				this.remove_TrainingFieldSpecified = value;
				this.RaisePropertyChanged("Remove_TrainingSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Training
		{
			get
			{
				return this.trainingField;
			}
			set
			{
				this.trainingField = value;
				this.RaisePropertyChanged("Training");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 4)]
		public Training_TypeObjectType Training_Type_Reference
		{
			get
			{
				return this.training_Type_ReferenceField;
			}
			set
			{
				this.training_Type_ReferenceField = value;
				this.RaisePropertyChanged("Training_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Completion_Date
		{
			get
			{
				return this.completion_DateField;
			}
			set
			{
				this.completion_DateField = value;
				this.RaisePropertyChanged("Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Completion_DateSpecified
		{
			get
			{
				return this.completion_DateFieldSpecified;
			}
			set
			{
				this.completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completion_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Training_Duration
		{
			get
			{
				return this.training_DurationField;
			}
			set
			{
				this.training_DurationField = value;
				this.RaisePropertyChanged("Training_Duration");
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
