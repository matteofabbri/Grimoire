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
	public class Proficiency_Rating_Scale_Request_ReferencesType : INotifyPropertyChanged
	{
		private Proficiency_Rating_ScaleObjectType[] proficiency_Rating_Scale_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Proficiency_Rating_Scale_Reference", Order = 0)]
		public Proficiency_Rating_ScaleObjectType[] Proficiency_Rating_Scale_Reference
		{
			get
			{
				return this.proficiency_Rating_Scale_ReferenceField;
			}
			set
			{
				this.proficiency_Rating_Scale_ReferenceField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Scale_Reference");
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
