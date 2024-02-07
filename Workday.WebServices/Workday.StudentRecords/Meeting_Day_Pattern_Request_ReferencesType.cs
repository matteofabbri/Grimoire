using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Meeting_Day_Pattern_Request_ReferencesType : INotifyPropertyChanged
	{
		private Meeting_Day_PatternObjectType meeting_Day_Pattern_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Meeting_Day_PatternObjectType Meeting_Day_Pattern_Reference
		{
			get
			{
				return this.meeting_Day_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Day_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Day_Pattern_Reference");
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
