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
	public class Revenue_Recognition_Schedule_Template_Request_ReferencesType : INotifyPropertyChanged
	{
		private Revenue_Recognition_Schedule_TemplateObjectType[] revenue_Recognition_Schedule_Template_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Revenue_Recognition_Schedule_Template_Reference", Order = 0)]
		public Revenue_Recognition_Schedule_TemplateObjectType[] Revenue_Recognition_Schedule_Template_Reference
		{
			get
			{
				return this.revenue_Recognition_Schedule_Template_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Template_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Template_Reference");
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
