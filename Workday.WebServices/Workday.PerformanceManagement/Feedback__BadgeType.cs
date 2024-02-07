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
	public class Feedback__BadgeType : INotifyPropertyChanged
	{
		private Feedback_BadgeObjectType feedback__Badge_ReferenceField;

		private Feedback_Badge_DataType feedback_Badge_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Feedback_BadgeObjectType Feedback__Badge_Reference
		{
			get
			{
				return this.feedback__Badge_ReferenceField;
			}
			set
			{
				this.feedback__Badge_ReferenceField = value;
				this.RaisePropertyChanged("Feedback__Badge_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Feedback_Badge_DataType Feedback_Badge_Data
		{
			get
			{
				return this.feedback_Badge_DataField;
			}
			set
			{
				this.feedback_Badge_DataField = value;
				this.RaisePropertyChanged("Feedback_Badge_Data");
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
