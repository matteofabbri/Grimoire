using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Effort_Certifying_Text_Request_ReferencesType : INotifyPropertyChanged
	{
		private Effort_Certifying_TextObjectType[] effort_Certifying_Text_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Effort_Certifying_Text_Reference", Order = 0)]
		public Effort_Certifying_TextObjectType[] Effort_Certifying_Text_Reference
		{
			get
			{
				return this.effort_Certifying_Text_ReferenceField;
			}
			set
			{
				this.effort_Certifying_Text_ReferenceField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text_Reference");
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
