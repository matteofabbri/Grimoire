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
	public class Study_Abroad_Offering_Request_ReferencesType : INotifyPropertyChanged
	{
		private Study_Abroad_OfferingObjectType[] study_Abroad_Offering_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Study_Abroad_Offering_Reference", Order = 0)]
		public Study_Abroad_OfferingObjectType[] Study_Abroad_Offering_Reference
		{
			get
			{
				return this.study_Abroad_Offering_ReferenceField;
			}
			set
			{
				this.study_Abroad_Offering_ReferenceField = value;
				this.RaisePropertyChanged("Study_Abroad_Offering_Reference");
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
