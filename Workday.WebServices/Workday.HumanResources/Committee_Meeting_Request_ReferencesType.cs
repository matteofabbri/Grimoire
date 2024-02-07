using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Meeting_Request_ReferencesType : INotifyPropertyChanged
	{
		private Committee_MeetingObjectType[] committee_Meeting_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Committee_Meeting_Reference", Order = 0)]
		public Committee_MeetingObjectType[] Committee_Meeting_Reference
		{
			get
			{
				return this.committee_Meeting_ReferenceField;
			}
			set
			{
				this.committee_Meeting_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Meeting_Reference");
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
