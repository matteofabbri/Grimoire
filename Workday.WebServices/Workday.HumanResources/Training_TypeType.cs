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
	public class Training_TypeType : INotifyPropertyChanged
	{
		private Training_TypeObjectType training_Type_ReferenceField;

		private Training_Type_DataType[] training_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Training_Type_Data", Order = 1)]
		public Training_Type_DataType[] Training_Type_Data
		{
			get
			{
				return this.training_Type_DataField;
			}
			set
			{
				this.training_Type_DataField = value;
				this.RaisePropertyChanged("Training_Type_Data");
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
