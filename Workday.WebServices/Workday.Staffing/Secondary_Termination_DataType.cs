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
	public class Secondary_Termination_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType secondary_Termination_Reason_ReferenceField;

		private Event_Classification_CategoryObjectType secondary_Termination_Reason_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType Secondary_Termination_Reason_Reference
		{
			get
			{
				return this.secondary_Termination_Reason_ReferenceField;
			}
			set
			{
				this.secondary_Termination_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_Termination_Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_CategoryObjectType Secondary_Termination_Reason_Category_Reference
		{
			get
			{
				return this.secondary_Termination_Reason_Category_ReferenceField;
			}
			set
			{
				this.secondary_Termination_Reason_Category_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_Termination_Reason_Category_Reference");
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
