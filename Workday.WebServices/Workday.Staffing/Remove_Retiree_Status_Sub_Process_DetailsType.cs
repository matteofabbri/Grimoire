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
	public class Remove_Retiree_Status_Sub_Process_DetailsType : INotifyPropertyChanged
	{
		private DateTime end_Retirement_DateField;

		private Event_Classification_SubcategoryObjectType reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime End_Retirement_Date
		{
			get
			{
				return this.end_Retirement_DateField;
			}
			set
			{
				this.end_Retirement_DateField = value;
				this.RaisePropertyChanged("End_Retirement_Date");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
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
