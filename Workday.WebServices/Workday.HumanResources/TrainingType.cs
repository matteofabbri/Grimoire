using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class TrainingType : INotifyPropertyChanged
	{
		private TrainingObjectType training_ReferenceField;

		private Training_Achievement_DataType[] training_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public TrainingObjectType Training_Reference
		{
			get
			{
				return this.training_ReferenceField;
			}
			set
			{
				this.training_ReferenceField = value;
				this.RaisePropertyChanged("Training_Reference");
			}
		}

		[XmlElement("Training_Data", Order = 1)]
		public Training_Achievement_DataType[] Training_Data
		{
			get
			{
				return this.training_DataField;
			}
			set
			{
				this.training_DataField = value;
				this.RaisePropertyChanged("Training_Data");
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
