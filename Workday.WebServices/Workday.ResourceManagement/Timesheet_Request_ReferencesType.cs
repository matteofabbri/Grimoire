using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Timesheet_Request_ReferencesType : INotifyPropertyChanged
	{
		private TimesheetObjectType[] timesheet_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Timesheet_Reference", Order = 0)]
		public TimesheetObjectType[] Timesheet_Reference
		{
			get
			{
				return this.timesheet_ReferenceField;
			}
			set
			{
				this.timesheet_ReferenceField = value;
				this.RaisePropertyChanged("Timesheet_Reference");
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
