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
	public class Work_Experience_Request_ReferencesType : INotifyPropertyChanged
	{
		private Work_Experience_SkillObjectType[] work_Experience_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Work_Experience_Reference", Order = 0)]
		public Work_Experience_SkillObjectType[] Work_Experience_Reference
		{
			get
			{
				return this.work_Experience_ReferenceField;
			}
			set
			{
				this.work_Experience_ReferenceField = value;
				this.RaisePropertyChanged("Work_Experience_Reference");
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
