using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Mentorship_Request_ReferencesType : INotifyPropertyChanged
	{
		private MentorshipObjectType[] mentorship_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Mentorship_Reference", Order = 0)]
		public MentorshipObjectType[] Mentorship_Reference
		{
			get
			{
				return this.mentorship_ReferenceField;
			}
			set
			{
				this.mentorship_ReferenceField = value;
				this.RaisePropertyChanged("Mentorship_Reference");
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
