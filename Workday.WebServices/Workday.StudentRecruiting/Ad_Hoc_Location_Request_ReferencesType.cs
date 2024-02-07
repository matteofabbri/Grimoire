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
	public class Ad_Hoc_Location_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Recruiting_Event_Ad_Hoc_LocationObjectType[] ad_Hoc_Location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Ad_Hoc_Location_Reference", Order = 0)]
		public Student_Recruiting_Event_Ad_Hoc_LocationObjectType[] Ad_Hoc_Location_Reference
		{
			get
			{
				return this.ad_Hoc_Location_ReferenceField;
			}
			set
			{
				this.ad_Hoc_Location_ReferenceField = value;
				this.RaisePropertyChanged("Ad_Hoc_Location_Reference");
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
