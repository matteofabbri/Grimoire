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
	public class Remove_Retiree_Status_Event_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType end_Retirement_Reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType End_Retirement_Reason_Reference
		{
			get
			{
				return this.end_Retirement_Reason_ReferenceField;
			}
			set
			{
				this.end_Retirement_Reason_ReferenceField = value;
				this.RaisePropertyChanged("End_Retirement_Reason_Reference");
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
