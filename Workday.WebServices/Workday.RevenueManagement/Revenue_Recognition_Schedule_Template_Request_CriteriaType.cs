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
	public class Revenue_Recognition_Schedule_Template_Request_CriteriaType : INotifyPropertyChanged
	{
		private string revenue_Recognition_Schedule_Template_NameField;

		private Schedule_TypeObjectType schedule_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Revenue_Recognition_Schedule_Template_Name
		{
			get
			{
				return this.revenue_Recognition_Schedule_Template_NameField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Template_NameField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Template_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Schedule_TypeObjectType Schedule_Type_Reference
		{
			get
			{
				return this.schedule_Type_ReferenceField;
			}
			set
			{
				this.schedule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Schedule_Type_Reference");
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
