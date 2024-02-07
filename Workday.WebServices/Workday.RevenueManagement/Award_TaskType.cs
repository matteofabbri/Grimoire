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
	public class Award_TaskType : INotifyPropertyChanged
	{
		private Award_TaskObjectType award_Task_ReferenceField;

		private Award_Task_DataType award_Task_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_TaskObjectType Award_Task_Reference
		{
			get
			{
				return this.award_Task_ReferenceField;
			}
			set
			{
				this.award_Task_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Award_Task_DataType Award_Task_Data
		{
			get
			{
				return this.award_Task_DataField;
			}
			set
			{
				this.award_Task_DataField = value;
				this.RaisePropertyChanged("Award_Task_Data");
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
