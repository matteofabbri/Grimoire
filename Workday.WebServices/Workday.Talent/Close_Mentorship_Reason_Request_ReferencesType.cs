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
	public class Close_Mentorship_Reason_Request_ReferencesType : INotifyPropertyChanged
	{
		private Close_Mentorship_ReasonObjectType[] close_Mentorship_Reason_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Close_Mentorship_Reason_Reference", Order = 0)]
		public Close_Mentorship_ReasonObjectType[] Close_Mentorship_Reason_Reference
		{
			get
			{
				return this.close_Mentorship_Reason_ReferenceField;
			}
			set
			{
				this.close_Mentorship_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Close_Mentorship_Reason_Reference");
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
