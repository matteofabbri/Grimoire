using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiting_Event_Request_CriteriaType : INotifyPropertyChanged
	{
		private string event_NameField;

		private string event_StatusField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Event_Name
		{
			get
			{
				return this.event_NameField;
			}
			set
			{
				this.event_NameField = value;
				this.RaisePropertyChanged("Event_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Event_Status
		{
			get
			{
				return this.event_StatusField;
			}
			set
			{
				this.event_StatusField = value;
				this.RaisePropertyChanged("Event_Status");
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
